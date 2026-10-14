using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000031 RID: 49
	public class TreeSelectionSettings : global::Infragistics.Controls.Menus.SettingsBase, global::System.IDisposable
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000099B7 File Offset: 0x00007BB7
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000099C9 File Offset: 0x00007BC9
		public global::Infragistics.Controls.Menus.TreeSelectionType NodeSelection
		{
			get
			{
				return (global::Infragistics.Controls.Menus.TreeSelectionType)base.GetValue(global::Infragistics.Controls.Menus.TreeSelectionSettings.NodeSelectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeSelectionSettings.NodeSelectionProperty, value);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000099DC File Offset: 0x00007BDC
		private static void NodeSelectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeSelectionSettings treeSelectionSettings = (global::Infragistics.Controls.Menus.TreeSelectionSettings)obj;
			treeSelectionSettings.OnPropertyChanged("NodeSelection");
			if (treeSelectionSettings.Tree != null)
			{
				switch (treeSelectionSettings.NodeSelection)
				{
				case global::Infragistics.Controls.Menus.TreeSelectionType.None:
					treeSelectionSettings.Tree.SelectionSettings.SelectedNodes.Clear();
					return;
				case global::Infragistics.Controls.Menus.TreeSelectionType.Single:
					if (treeSelectionSettings.Tree.SelectedDataItems != null && treeSelectionSettings.Tree.SelectedDataItems.Count<object>() > 1)
					{
						global::System.Collections.Generic.List<object> list = treeSelectionSettings.Tree.SelectedDataItems.Cast<object>().ToList<object>();
						list.RemoveRange(0, list.Count - 1);
						treeSelectionSettings.Tree.SetSelectedDataItemsExternal(list.ToArray());
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00009A88 File Offset: 0x00007C88
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Menus.SelectedNodesCollection SelectedNodes
		{
			get
			{
				if (this._selectedNodes == null)
				{
					this._selectedNodes = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
					this._selectedNodes.Tree = base.Tree;
				}
				return this._selectedNodes;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00009AB4 File Offset: 0x00007CB4
		protected virtual void Dispose(bool disposing)
		{
			if (this._selectedNodes != null)
			{
				this._selectedNodes.Dispose();
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009AC9 File Offset: 0x00007CC9
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000A4 RID: 164
		private global::Infragistics.Controls.Menus.SelectedNodesCollection _selectedNodes;

		// Token: 0x040000A5 RID: 165
		public static readonly global::System.Windows.DependencyProperty NodeSelectionProperty = global::System.Windows.DependencyProperty.Register("NodeSelection", typeof(global::Infragistics.Controls.Menus.TreeSelectionType), typeof(global::Infragistics.Controls.Menus.TreeSelectionSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.TreeSelectionType.Single, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeSelectionSettings.NodeSelectionChanged)));
	}
}
