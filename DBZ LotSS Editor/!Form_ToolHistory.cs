using HexTools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{

    public partial class Form_ToolHistory : HexForm
    {

        private MemoryOperationAction[] _Actions;
        protected MemoryOperationAction[] Actions
        {
            get
            {
                return _Actions;
            }
            private set
            {
                if (!ReferenceEquals(value, _Actions))
                {
                    _Actions = value;
                }
            }
        }

        private TreeNode[] UnfilteredList { get; set; }
        private string[] CurrentFilters;
        private int TotalFilters = 0;

        public int StartIndex { get; set; } = -1;

        public Form_ToolHistory()
        {
            InitializeComponent();
        }

        private object CreateChangeRecordItem(string Label, object Value, HistoryContextActions ContentActions, params TreeNode[] Children)
        {
            var Node = new TreeNode($"{Label}: {Value.ToString()}", Children);
            Node.Name = Value.ToString();
            if (ContentActions != null)
            {
                Node.ContextMenuStrip = ChangeContextMenuStrip;
                Node.Tag = ContentActions;
            }
            TotalFilters += 1;
            return Node;
        }

        private object CreateChangeRecord(string Label, object Value, params TreeNode[] Children)
        {
            return CreateChangeRecordItem(Label, Value, null, Children);
        }

        private void PopulateFilterControl(ComboBox ComboBox, Func<MemoryOperationAction, string> Selector)
        {
            ComboBox.Items.Clear();
            ComboBox.Items.AddRange(new string[] { "All" }.Concat(Actions.Select(Selector).Distinct()).ToArray());
            ComboBox.SelectedIndex = 0;
        }

        private void Form_ToolHistory_Load(object sender, EventArgs e)
        {
            RegenerateHistory();
        }

        private void ClearHistory(bool Full = false)
        {
            TreeViewHistory.SelectedNode = null;
            TreeViewHistory.Nodes.Clear();
            UnfilteredList = null;
            CurrentFilters = null;
            TotalFilters = 0;
            if (Full)
            {
                StartIndex = -1;
            }
        }

        private void CreateHistory(bool Clear = false)
        {
            if (Clear == true)
            {
                TreeViewHistory.Nodes.Clear();
                TotalFilters = 0;
            }
            foreach (MemoryOperationAction Action in Actions)
            {
                var Offset = CreateChangeRecordItem("Hex Offset", Action.NewValue.HexOffset, new HistoryContextActions(Action.NewValue.HexOffset));
                var OldValue = CreateChangeRecordItem("Old Value", Action.OldValue.HexChanges, new HistoryContextActions(Action.OldValue.HexChanges));
                var NewValue = CreateChangeRecordItem("New Value", Action.NewValue.HexChanges, new HistoryContextActions(Action.NewValue.HexChanges));
                var TimeStamp = CreateChangeRecordItem("Modified", Action.Modified, new HistoryContextActions(Action.Modified));
                var Control = CreateChangeRecordItem("Control", Action.Name, new HistoryContextActions(Action.RawChanges), (TreeNode)Offset, (TreeNode)OldValue, (TreeNode)NewValue, (TreeNode)TimeStamp);
                var Owner = CreateChangeRecord("Module", Action.OwnerName, (TreeNode)Control) as TreeNode;
                if (TreeViewHistory.Nodes.ContainsKey(Owner.Name))
                {
                    TreeViewHistory.Nodes[TreeViewHistory.Nodes.IndexOfKey(Owner.Name)].Nodes.Add((TreeNode)Control);
                }
                else
                {
                    TreeViewHistory.Nodes.Add(Owner);
                }
            }
            TreeViewHistory.ExpandAll();
        }

        private void RegenerateHistory()
        {
            Actions = MemoryLiterator.ActionModule.AllUndos;

            bool HaveActions = Actions.Length > 0;
            bool HaveManyActions = Actions.Length > 1;
            AbsoluteCenterLayout.Visible = !HaveActions;
            ContentPanel.Enabled = HaveActions;
            CheckBoxSort.Enabled = HaveManyActions;

            ClearHistory();

            if (!HaveActions)
            {
                return;
            }

            CreateHistory();

            if (StartIndex >= 0)
            {
                TreeViewHistory.SelectedNode = TreeViewHistory.Nodes[StartIndex];
                TreeViewHistory.Select();
            }
            else
            {
                OK_Button.Select();
            }

            CurrentFilters = new string[TotalFilters];

            PopulateFilterControl(ComboBoxModule, (Action) => Action.OwnerName);

            PopulateFilterControl(ComboBoxControl, (Action) => Action.Name);
        }

        private void CopyToolStripMenuItem_Click(object Sender, EventArgs e)
        {
            var Node = TreeViewHistory.SelectedNode;
            HistoryContextActions ContextActions = (HistoryContextActions)Node.Tag;

            Clipboard.SetText(ContextActions.Copy);
        }

        private IEnumerable<TreeNode> IterateAllNodes(TreeNode Parent)
        {
            if (Parent != null)
            {
                var Children = new Queue<TreeNode>();
                Children.Enqueue(Parent);
                while (Children.Count > 0)
                {
                    Parent = Children.Dequeue();

                    // Print the node.  
                    yield return Parent;
                    foreach (TreeNode Node in Parent.Nodes)
                        Children.Enqueue(Node);
                }
            }
        }

        private IEnumerable<TreeNode> AllNodes(TreeView TreeView)
        {
            foreach (var RootNode in TreeView.Nodes)
            {
                foreach (var Node in IterateAllNodes((TreeNode)RootNode))
                    yield return Node;
            }
        }

        private IEnumerable<NestedTreeNode> NodesAtDepth(TreeView TreeView, int Depth)
        {
            TreeNode Root = null;
            foreach (var Node in AllNodes(TreeView))
            {
                if (Node.Level == 0)
                    Root = Node;
                if (Node.Level == Depth)
                {
                    yield return new NestedTreeNode(Root, Node);
                }
            }
        }

        private void FilterBy(int Filter, string Criteria)
        {
            if (string.IsNullOrEmpty(Criteria))
                return;
            if ((CurrentFilters[Filter] ?? "") != (Criteria ?? ""))
            {
                if (UnfilteredList != null)
                {
                    TreeViewHistory.Nodes.Clear();
                    TreeViewHistory.Nodes.AddRange(UnfilteredList);
                }
                CurrentFilters[Filter] = Criteria;
                if (Criteria == "All")
                    return;
            }
            if (UnfilteredList == null)
            {
                UnfilteredList = new TreeNode[TreeViewHistory.Nodes.Count];
                TreeViewHistory.Nodes.CopyTo(UnfilteredList, 0);
            }
            for (int CurrentFilter = 0, loopTo = CurrentFilters.Count() - 1; CurrentFilter <= loopTo; CurrentFilter++)
            {
                string CurrentCritiera = CurrentFilters[CurrentFilter];
                if (CurrentCritiera == "All" | string.IsNullOrEmpty(CurrentCritiera))
                    continue;
                foreach (NestedTreeNode Tree in NodesAtDepth(TreeViewHistory, CurrentFilter).ToList())
                {
                    if (!Tree.Node.Text.Contains(CurrentCritiera))
                    {
                        TreeViewHistory.Nodes.Remove(Tree.Root);
                    }
                }
            }
        }

        private void ComboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy(0, Conversions.ToString(ComboBoxModule.SelectedItem));
        }

        private void ComboBoxControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy(1, Conversions.ToString(ComboBoxControl.SelectedItem));
        }

        private void FilterCustomSearch(int Index, ComboBox ComboxBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Debug.WriteLine(ComboxBox.Text);
                FilterBy(Index, ComboxBox.Text);
            }
        }

        private void ComboBoxModule_KeyDown(object sender, KeyEventArgs e)
        {
            FilterCustomSearch(0, ComboBoxModule, e);
        }

        private void ComboBoxControl_KeyDown(object sender, KeyEventArgs e)
        {
            FilterCustomSearch(1, ComboBoxControl, e);
        }

        private void CheckBoxSort_CheckedChanged(object sender, EventArgs e)
        {
            Actions = Actions.Reverse().ToArray();
            CreateHistory(true);
            CheckBoxSort.Text = CheckBoxSort.Checked ? "Newest" : "Oldest";
        }

        private void Form_ToolHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearHistory(true);
        }

        private void OK_Button_Click(object Sender, EventArgs e)
        {
            ClearHistory(true);
            Close();
        }
    }

    public class HistoryContextActions
    {

        public string Copy { get; private set; }

        public HistoryContextActions(string Copy)
        {
            this.Copy = Copy;
        }

    }

    public class NestedTreeNode
    {

        public TreeNode Root { get; private set; }
        public TreeNode Node { get; private set; }

        public NestedTreeNode(TreeNode Root, TreeNode Node)
        {
            this.Root = Root;
            this.Node = Node;
        }

    }
}