using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HexTools;

namespace DBZ_LotSS_Editor
{
	public partial class Data_Battlers
	{
		private const int BattlerEditorGroupWidth = 720;
		private const int BattlerEditorLeftMargin = 12;
		private const int BattlerEditorInputLeft = 160;
		private const int BattlerEditorRightMargin = 12;
		private static readonly BattlerMultiActionDefinition DefaultMultiActionDefinition =
			new BasicTools.BasicJsonDefinition<BattlerDataDefinition>(My.Resources.Resources.DataEditor_Battlers)
				.Definition
				.MultiAction;

		private Label TurnProfileLabel;
		private ProfileComboBox TurnProfileComboBox;
		private Label ActionSelectorProfileLabel;
		private ProfileComboBox ActionSelectorProfileComboBox;
		private Label MultiActionLabel;
		private TextBox MultiActionSummary;
		private ToolTip MultiActionToolTip;
		private bool UpdatingTurnProfile;
		private bool UpdatingActionSelectorProfile;

		private void InitializeMultiActionEditor()
		{
			this.ExpandBattlerEditorLayout();
			this.RelayoutPanelsBelowSkills();

			this.TurnProfileLabel = new Label
			{
				AutoSize = true,
				Location = new Point(8, 127),
				Name = "TurnProfileLabel",
				Size = new Size(82, 17),
				Text = "Turn Profile"
			};

			this.TurnProfileComboBox = new ProfileComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				FormattingEnabled = true,
				Location = new Point(BattlerEditorInputLeft, 123),
				Name = "TurnProfileComboBox",
				ReloadAction = this.UpdateMultiActionControl,
				Size = new Size(this.GetBattlerInputWidth(), 24),
				TabIndex = 31
			};
			this.TurnProfileComboBox.Items.AddRange(this.GetTurnProfileItems().ToArray());
			this.TurnProfileComboBox.SelectedIndexChanged += this.TurnProfileComboBox_SelectedIndexChanged;

			this.ActionSelectorProfileLabel = new Label
			{
				AutoSize = true,
				Location = new Point(8, 160),
				Name = "ActionSelectorProfileLabel",
				Size = new Size(145, 17),
				Text = "Action selector profile"
			};

			this.ActionSelectorProfileComboBox = new ProfileComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				FormattingEnabled = true,
				Location = new Point(BattlerEditorInputLeft, 156),
				Name = "ActionSelectorProfileComboBox",
				ReloadAction = this.UpdateMultiActionControl,
				Size = new Size(this.GetBattlerInputWidth(), 24),
				TabIndex = 32
			};
			this.ActionSelectorProfileComboBox.Items.AddRange(new object[]
			{
				"0: broad/default",
				"1: low/conservative",
				"2: high/aggressive",
				"3: uniform",
				"4: split low/high"
			});
			this.ActionSelectorProfileComboBox.SelectedIndexChanged += this.ActionSelectorProfileComboBox_SelectedIndexChanged;

			this.MultiActionLabel = new Label
			{
				AutoSize = true,
				Location = new Point(8, 193),
				Name = "MultiActionLabel",
				Size = new Size(82, 17),
				Text = "Action selectors"
			};

			this.MultiActionSummary = new TextBox
			{
				BackColor = SystemColors.Control,
				BorderStyle = BorderStyle.FixedSingle,
				Location = new Point(BattlerEditorInputLeft, 189),
				Multiline = true,
				Name = "MultiActionSummary",
				ReadOnly = true,
				ScrollBars = ScrollBars.Vertical,
				Size = new Size(this.GetBattlerInputWidth(), 58),
				TabIndex = 33,
				Text = string.Empty
			};

			this.MultiActionToolTip = new ToolTip();
			this.MultiActionToolTip.SetToolTip(
				this.TurnProfileComboBox,
				"Controls whether this battler can act again in the same round with a refreshed card.");
			this.MultiActionToolTip.SetToolTip(
				this.ActionSelectorProfileComboBox,
				"Controls the card attack distribution used by action-list selector bytes like $39.");
			this.MultiActionToolTip.SetToolTip(
				this.MultiActionSummary,
				"Shows when this battler's action list can grant extra actions in one turn.");

			this.HexListBox1.SelectedIndexChanged += this.MultiAction_SelectedBattlerChanged;
			this.HandleCreated += this.MultiAction_HandleCreated;
			this.VisibleChanged += this.MultiAction_VisibleChanged;
			this.Enter += this.MultiAction_Enter;
			this.Disposed += this.MultiAction_Disposed;
			HexDefinitionManager.OnLoad += this.MultiAction_DefinitionsLoaded;
			this.HexPanel2.Controls.Add(this.TurnProfileLabel);
			this.HexPanel2.Controls.Add(this.TurnProfileComboBox);
			this.HexPanel2.Controls.Add(this.ActionSelectorProfileLabel);
			this.HexPanel2.Controls.Add(this.ActionSelectorProfileComboBox);
			this.HexPanel2.Controls.Add(this.MultiActionLabel);
			this.HexPanel2.Controls.Add(this.MultiActionSummary);

			this.UpdateMultiActionControl();
		}

		private void ExpandBattlerEditorLayout()
		{
			var groupWidth = Math.Max(this.BasicListBoxAssociate1.Width, BattlerEditorGroupWidth);
			this.BasicListBoxAssociate1.Size = new Size(groupWidth, this.BasicListBoxAssociate1.Height);

			var panelWidth = groupWidth - BattlerEditorLeftMargin - BattlerEditorRightMargin;
			this.HexPanel2.Size = new Size(panelWidth, 253);
			this.HexPanel1.Location = new Point(this.HexPanel1.Left, 282);
			this.HexPanel1.Size = new Size(panelWidth, 140);
			this.Skills.Size = new Size(panelWidth - 11, 137);
			this.ColumnHeader2.Width = Math.Max(240, this.Skills.Width - this.ColumnHeader1.Width - 8);

			this.HexPanel3.Size = new Size(panelWidth, this.HexPanel3.Height);
			this.HexPanel4.Size = new Size(panelWidth, this.HexPanel4.Height);
			this.HexPanel5.Size = new Size(panelWidth, this.HexPanel5.Height);
			this.HexPanel6.Size = new Size(panelWidth, this.HexPanel6.Height);
			this.HexPanel7.Size = new Size(panelWidth, this.HexPanel7.Height);
			this.StretchComboBox(this.PortraitSprite);
			this.StretchComboBox(this.PortraitPalette);
			this.StretchComboBox(this.BattlersSprite);
			this.StretchComboBox(this.BattlersPalette);
			this.StretchComboBox(this.FlyerSpritePalette);

			this.Size = new Size(Math.Max(this.Width, this.BasicListBoxAssociate1.Right + 24), this.Height);
		}

		private int GetBattlerInputWidth()
		{
			return this.HexPanel2.Width - BattlerEditorInputLeft - BattlerEditorRightMargin;
		}

		private void StretchComboBox(ComboBox comboBox)
		{
			if (comboBox == null)
			{
				return;
			}

			comboBox.Width = Math.Max(comboBox.Width, comboBox.Parent.Width - comboBox.Left - BattlerEditorRightMargin);
		}

		private void RelayoutPanelsBelowSkills()
		{
			var lowerTop = this.HexPanel1.Bottom + 18;
			this.HexPanel3.Location = new Point(this.HexPanel3.Left, lowerTop);
			this.HexPanel7.Location = new Point(this.HexPanel7.Left, lowerTop + 3);
			this.HexPanel6.Location = new Point(this.HexPanel6.Left, lowerTop + 56);
			this.HexPanel4.Location = new Point(this.HexPanel4.Left, lowerTop + 111);
			this.HexPanel5.Location = new Point(this.HexPanel5.Left, lowerTop + 179);

			var requiredGroupHeight = this.HexPanel5.Bottom + 15;
			if (this.BasicListBoxAssociate1.Height < requiredGroupHeight)
			{
				this.BasicListBoxAssociate1.Height = requiredGroupHeight;
			}

			var requiredControlHeight = this.BasicListBoxAssociate1.Bottom + 24;
			if (this.Height < requiredControlHeight)
			{
				this.Height = requiredControlHeight;
			}
		}

		private void MultiAction_SelectedBattlerChanged(object sender, EventArgs e)
		{
			this.UpdateMultiActionControl();
		}

		private void MultiAction_HandleCreated(object sender, EventArgs e)
		{
			this.QueueMultiActionUpdate();
		}

		private void MultiAction_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
			{
				this.QueueMultiActionUpdate();
			}
		}

		private void MultiAction_Enter(object sender, EventArgs e)
		{
			this.QueueMultiActionUpdate();
		}

		private void MultiAction_DefinitionsLoaded()
		{
			if (!this.IsHandleCreated || this.IsDisposed)
			{
				return;
			}

			this.BeginInvoke(new MethodInvoker(this.ReloadTurnProfileItems));
		}

		private void MultiAction_Disposed(object sender, EventArgs e)
		{
			HexDefinitionManager.OnLoad -= this.MultiAction_DefinitionsLoaded;
		}

		private void QueueMultiActionUpdate()
		{
			if (!this.IsHandleCreated)
			{
				return;
			}

			this.BeginInvoke(new MethodInvoker(this.UpdateMultiActionControl));
		}

		private void UpdateMultiActionControl()
		{
			if (this.MultiActionSummary == null || this.TurnProfileComboBox == null || this.ActionSelectorProfileComboBox == null)
			{
				return;
			}

			var battlerIndex = this.HexListBox1.SelectedIndex;
			this.UpdateTurnProfileControl(battlerIndex);
			this.UpdateActionSelectorProfileControl(battlerIndex);
			this.MultiActionSummary.Text = battlerIndex < 0
				? "Select a battler."
				: this.BuildMultiActionSummary(battlerIndex);
		}

		private void UpdateTurnProfileControl(int battlerIndex)
		{
			this.UpdatingTurnProfile = true;
			try
			{
				var rom = HexStorage.Memory;
				var profile = battlerIndex < 0 ? -1 : this.ReadTurnProfile(rom, battlerIndex);
				this.TurnProfileComboBox.Enabled = profile >= 0;
				this.TurnProfileComboBox.SelectedIndex = profile >= 0 && profile < this.GetTurnProfileCount() ? profile : -1;
			}
			finally
			{
				this.UpdatingTurnProfile = false;
			}
		}

		private void TurnProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.UpdatingTurnProfile || this.TurnProfileComboBox.SelectedIndex < 0)
			{
				return;
			}

			var battlerIndex = this.HexListBox1.SelectedIndex;
			if (battlerIndex < 0)
			{
				return;
			}

			this.WriteTurnProfile(HexStorage.Memory, battlerIndex, this.TurnProfileComboBox.SelectedIndex);
		}

		private void UpdateActionSelectorProfileControl(int battlerIndex)
		{
			this.UpdatingActionSelectorProfile = true;
			try
			{
				var rom = HexStorage.Memory;
				var profile = battlerIndex < 0 ? -1 : this.ReadAttackProfile(rom, battlerIndex);
				this.ActionSelectorProfileComboBox.Enabled = profile >= 0;
				this.ActionSelectorProfileComboBox.SelectedIndex = profile >= 0 && profile < this.MultiActionDefinition.CardSetupValueProfileCount ? profile : -1;
			}
			finally
			{
				this.UpdatingActionSelectorProfile = false;
			}
		}

		private void ActionSelectorProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.UpdatingActionSelectorProfile || this.ActionSelectorProfileComboBox.SelectedIndex < 0)
			{
				return;
			}

			var battlerIndex = this.HexListBox1.SelectedIndex;
			if (battlerIndex < 0)
			{
				return;
			}

			this.WriteAttackProfile(HexStorage.Memory, battlerIndex, this.ActionSelectorProfileComboBox.SelectedIndex);
			this.MultiActionSummary.Text = this.BuildMultiActionSummary(battlerIndex);
		}

		private string BuildMultiActionSummary(int battlerIndex)
		{
			var rom = HexStorage.Memory;
			if (rom == null || rom.Length == 0)
			{
				return "ROM not loaded.";
			}

			var actions = this.ReadBattlerActions(rom, battlerIndex);
			if (actions.Count == 0)
			{
				return "No action list data.";
			}

			var attackProfile = this.ReadAttackProfile(rom, battlerIndex);
			var summaries = new List<string>();
			for (var index = 0; index < actions.Count; index++)
			{
				var action = actions[index];
				if (!this.IsMultiActionSelector(action))
				{
					continue;
				}

				var continuationSlots = this.CountFollowingContinuationSlots(actions, index + 1);
				summaries.Add(this.DescribeSelector(action, attackProfile, continuationSlots));
			}

			if (summaries.Count == 0)
			{
				return "No multi-action selector actions found.";
			}

			return string.Join(Environment.NewLine, summaries);
		}

		private int ReadTurnProfile(byte[] rom, int battlerIndex)
		{
			var definition = this.MultiActionDefinition;
			var profileOffset = this.ToRomOffset(definition.TurnProfileOffset) + battlerIndex / 2;
			if (!this.CanRead(rom, profileOffset, 1))
			{
				return -1;
			}

			var packed = (int)rom[profileOffset];
			return (battlerIndex & 1) == 0 ? packed >> 4 & 0x0F : packed & 0x0F;
		}

		private void WriteTurnProfile(byte[] rom, int battlerIndex, int profile)
		{
			var definition = this.MultiActionDefinition;
			var profileOffset = this.ToRomOffset(definition.TurnProfileOffset) + battlerIndex / 2;
			if (!this.CanRead(rom, profileOffset, 1) || profile < 0 || profile >= this.GetTurnProfileCount())
			{
				return;
			}

			var packed = (int)rom[profileOffset];
			if ((battlerIndex & 1) == 0)
			{
				packed = packed & 0x0F | profile << 4;
			}
			else
			{
				packed = packed & 0xF0 | profile;
			}

			this.WriteMemory(this.TurnProfileComboBox, profileOffset, new byte[] { (byte)packed });
		}

		private List<int> ReadBattlerActions(byte[] rom, int battlerIndex)
		{
			var definition = this.MultiActionDefinition;
			var actions = new List<int>();
			var pointerOffset = this.ToRomOffset(definition.SkillPointerOffset) + battlerIndex * 2;
			if (!this.CanRead(rom, pointerOffset, 2))
			{
				return actions;
			}

			var pointer = rom[pointerOffset] | rom[pointerOffset + 1] << 8;
			var actionListOffset = this.LoRomPointerToRomOffset(definition.SkillPointerBank, pointer);
			if (!this.CanRead(rom, actionListOffset, 1))
			{
				return actions;
			}

			var count = rom[actionListOffset];
			for (var index = 0; index < count && this.CanRead(rom, actionListOffset + 1 + index, 1); index++)
			{
				actions.Add(rom[actionListOffset + 1 + index]);
			}

			return actions;
		}

		private int ReadAttackProfile(byte[] rom, int battlerIndex)
		{
			var definition = this.MultiActionDefinition;
			var setupOffset = this.ToRomOffset(definition.CardSetupActorWordOffset) + battlerIndex * 2;
			if (!this.CanRead(rom, setupOffset, 2))
			{
				return -1;
			}

			var lowByte = rom[setupOffset];
			var highByte = rom[setupOffset + 1];
			var usesPackedProfileNibbles = (lowByte & 0xF0) == 0;
			if (!usesPackedProfileNibbles)
			{
				return 0;
			}

			var attackProfile = highByte >> 4 & 0x0F;
			return attackProfile < definition.CardSetupValueProfileCount ? attackProfile : 0;
		}

		private void WriteAttackProfile(byte[] rom, int battlerIndex, int profile)
		{
			var definition = this.MultiActionDefinition;
			var setupOffset = this.ToRomOffset(definition.CardSetupActorWordOffset) + battlerIndex * 2;
			if (!this.CanRead(rom, setupOffset, 2) || profile < 0 || profile >= definition.CardSetupValueProfileCount)
			{
				return;
			}

			var lowByte = rom[setupOffset] & 0x0F;
			var highByte = (rom[setupOffset + 1] & 0x0F) | (profile << 4);
			this.WriteMemory(this.ActionSelectorProfileComboBox, setupOffset, new byte[] { (byte)lowByte, (byte)highByte });
		}

		private string DescribeSelector(int action, int attackProfile, int continuationSlots)
		{
			var odds = this.GetSelectorOdds(action, attackProfile);
			return string.Format(
				"Extra action rule {0}{4}{2}{4}Uses {3} follow-up action slot{5}.{4}Internal: selector ${1:X2}, odds profile {6}",
				action - 0x37,
				action,
				odds,
				continuationSlots,
				Environment.NewLine,
				continuationSlots == 1 ? string.Empty : "s",
				attackProfile);
		}

		private string GetSelectorOdds(int action, int attackProfile)
		{
			var definition = this.MultiActionDefinition;
			var profileLength = definition.CardSetupValueProfileLength;
			var profileOffset = this.ToRomOffset(definition.CardSetupValueProfileOffset) + attackProfile * profileLength;
			if (!this.CanRead(HexStorage.Memory, profileOffset, profileLength))
			{
				return "odds unavailable";
			}

			var extra0 = 0;
			var extra1 = 0;
			var extra2 = 0;
			for (var index = 0; index < profileLength; index++)
			{
				switch (this.GetExtraSlotCount(action, HexStorage.Memory[profileOffset + index]))
				{
					case 0:
						extra0++;
						break;
					case 1:
						extra1++;
						break;
					default:
						extra2++;
						break;
				}
			}

			if (action == 0x39 || action == 0x3A)
			{
				return string.Format("Chance: low cards give no extra action {0}/{3}; mid cards give +1 action {1}/{3}; high cards give +2 actions {2}/{3}.", extra0, extra1, extra2, profileLength);
			}

			return string.Format("Chance: {1}/{3} cards give +1 action; {0}/{3} give no extra action; {2}/{3} give +2 actions.", extra0, extra1, extra2, profileLength);
		}

		private int GetExtraSlotCount(int action, int cardAttack)
		{
			switch (action)
			{
				case 0x39:
				case 0x3A:
					if (cardAttack >= 7)
					{
						return 2;
					}

					return cardAttack >= 4 ? 1 : 0;
				case 0x38:
				case 0x3B:
				case 0x3C:
				case 0x3D:
				case 0x3E:
					return cardAttack >= 6 ? 1 : 0;
				default:
					return 0;
			}
		}

		private bool IsMultiActionSelector(int action)
		{
			return action >= 0x38 && action <= 0x3E;
		}

		private int CountFollowingContinuationSlots(List<int> actions, int startIndex)
		{
			var count = 0;
			for (var index = startIndex; index < actions.Count && actions[index] == 0xFF; index++)
			{
				count++;
			}

			return count;
		}

		private BattlerMultiActionDefinition MultiActionDefinition
		{
			get
			{
				return this.TryGetMultiActionDefinition() ?? DefaultMultiActionDefinition;
			}
		}

		private BattlerMultiActionDefinition TryGetMultiActionDefinition()
		{
			try
			{
				var context = HexDefinitionManager.Instance.Context as AppDefinitionContext;
				return context?.DataEditor?.Battlers?.MultiAction;
			}
			catch (InvalidOperationException)
			{
				return null;
			}
		}

		private void ReloadTurnProfileItems()
		{
			if (this.TurnProfileComboBox == null)
			{
				return;
			}

			this.UpdatingTurnProfile = true;
			try
			{
				var selectedIndex = this.TurnProfileComboBox.SelectedIndex;
				this.TurnProfileComboBox.Items.Clear();
				this.TurnProfileComboBox.Items.AddRange(this.GetTurnProfileItems().ToArray());
				this.TurnProfileComboBox.SelectedIndex = selectedIndex >= 0 && selectedIndex < this.TurnProfileComboBox.Items.Count
					? selectedIndex
					: -1;
			}
			finally
			{
				this.UpdatingTurnProfile = false;
			}

			this.UpdateMultiActionControl();
		}

		private List<object> GetTurnProfileItems()
		{
			var definition = this.MultiActionDefinition;
			var labels = definition.TurnProfileLabels ?? new List<string>();
			var count = this.GetTurnProfileCount();
			var items = new List<object>();

			for (var index = 0; index < count; index++)
			{
				items.Add(index < labels.Count ? labels[index] : string.Format("{0}: profile {0}", index));
			}

			return items;
		}

		private int GetTurnProfileCount()
		{
			var definition = this.MultiActionDefinition;
			if (definition.TurnProfileCount > 0)
			{
				return definition.TurnProfileCount;
			}

			return definition.TurnProfileLabels?.Count ?? 0;
		}

		private int LoRomPointerToRomOffset(int bank, int pointer)
		{
			var snesAddress = bank << 16 | pointer;
			return HexConvert.SnesToPC(HexConvert.IntToHex(snesAddress, 5), false);
		}

		private int ToRomOffset(string pcOffset)
		{
			if (string.IsNullOrWhiteSpace(pcOffset))
			{
				return -1;
			}

			return HexStorage.GlobalOffset + HexConvert.HexToInt(HexConvert.AddressToHex(pcOffset));
		}

		private void WriteMemory(Control source, int offset, byte[] value)
		{
			MemoryLiterator.Write(source, new MemoryOperation(offset, value));
			HexStorage.DataStore(source);
		}

		private bool CanRead(byte[] rom, int offset, int length)
		{
			return rom != null && offset >= 0 && length >= 0 && offset + length <= rom.Length;
		}

		private sealed class ProfileComboBox : ComboBox, IHexReader
		{
			public Action ReloadAction { get; set; }

			void IHexReader.Load()
			{
				this.ReloadAction?.Invoke();
			}
		}
	}
}
