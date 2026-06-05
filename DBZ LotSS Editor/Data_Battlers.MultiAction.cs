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
		private const int BattlerEditorInputLeft = 107;
		private const int BattlerEditorRightMargin = 12;

		private Label TurnProfileLabel;
		private ComboBox TurnProfileComboBox;
		private Label MultiActionLabel;
		private TextBox MultiActionSummary;
		private ToolTip MultiActionToolTip;
		private bool UpdatingTurnProfile;

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

			this.TurnProfileComboBox = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				FormattingEnabled = true,
				Location = new Point(107, 123),
				Name = "TurnProfileComboBox",
				Size = new Size(this.GetBattlerInputWidth(), 24),
				TabIndex = 31
			};
			this.TurnProfileComboBox.Items.AddRange(this.GetTurnProfileItems().ToArray());
			this.TurnProfileComboBox.SelectedIndexChanged += this.TurnProfileComboBox_SelectedIndexChanged;

			this.MultiActionLabel = new Label
			{
				AutoSize = true,
				Location = new Point(8, 160),
				Name = "MultiActionLabel",
				Size = new Size(82, 17),
				Text = "Action selectors"
			};

			this.MultiActionSummary = new TextBox
			{
				BackColor = SystemColors.Control,
				BorderStyle = BorderStyle.FixedSingle,
				Location = new Point(107, 156),
				Multiline = true,
				Name = "MultiActionSummary",
				ReadOnly = true,
				ScrollBars = ScrollBars.Vertical,
				Size = new Size(this.GetBattlerInputWidth(), 58),
				TabIndex = 32,
				Text = string.Empty
			};

			this.MultiActionToolTip = new ToolTip();
			this.MultiActionToolTip.SetToolTip(
				this.TurnProfileComboBox,
				"Controls whether this battler can act again in the same round with a refreshed card.");
			this.MultiActionToolTip.SetToolTip(
				this.MultiActionSummary,
				"Derived from the battler action list and card attack profile. ROM selector values are shown in parentheses.");

			this.HexListBox1.SelectedIndexChanged += this.MultiAction_SelectedBattlerChanged;
			this.HandleCreated += this.MultiAction_HandleCreated;
			this.VisibleChanged += this.MultiAction_VisibleChanged;
			this.Enter += this.MultiAction_Enter;
			this.HexPanel2.Controls.Add(this.TurnProfileLabel);
			this.HexPanel2.Controls.Add(this.TurnProfileComboBox);
			this.HexPanel2.Controls.Add(this.MultiActionLabel);
			this.HexPanel2.Controls.Add(this.MultiActionSummary);

			this.UpdateMultiActionControl();
		}

		private void ExpandBattlerEditorLayout()
		{
			var groupWidth = Math.Max(this.BasicListBoxAssociate1.Width, BattlerEditorGroupWidth);
			this.BasicListBoxAssociate1.Size = new Size(groupWidth, this.BasicListBoxAssociate1.Height);

			var panelWidth = groupWidth - BattlerEditorLeftMargin - BattlerEditorRightMargin;
			this.HexPanel2.Size = new Size(panelWidth, 220);
			this.HexPanel1.Location = new Point(this.HexPanel1.Left, 249);
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
			if (this.MultiActionSummary == null || this.TurnProfileComboBox == null)
			{
				return;
			}

			var battlerIndex = this.HexListBox1.SelectedIndex;
			this.UpdateTurnProfileControl(battlerIndex);
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

			rom[profileOffset] = (byte)packed;
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
				return 0;
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

		private string DescribeSelector(int action, int attackProfile, int continuationSlots)
		{
			var odds = this.GetSelectorOdds(action, attackProfile);
			return string.Format(
				"Multi-action selector {0} (ROM ${1:X2}){4}{2}{4}Reserved follow-up slots: {3}; card odds profile: {5}",
				action - 0x37,
				action,
				odds,
				continuationSlots,
				Environment.NewLine,
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
				return string.Format("Extra action chance by card tier: low/no extra {0}/{3}, mid/+1 action {1}/{3}, high/+2 actions {2}/{3}", extra0, extra1, extra2, profileLength);
			}

			return string.Format("Extra action chance: none {0}/{3}, +1 action {1}/{3}, +2 actions {2}/{3}", extra0, extra1, extra2, profileLength);
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
				var context = HexDefinitionManager.Instance.Context as AppDefinitionContext;
				return context?.DataEditor?.Battlers?.MultiAction ?? new BattlerMultiActionDefinition();
			}
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

		private bool CanRead(byte[] rom, int offset, int length)
		{
			return rom != null && offset >= 0 && length >= 0 && offset + length <= rom.Length;
		}
	}
}
