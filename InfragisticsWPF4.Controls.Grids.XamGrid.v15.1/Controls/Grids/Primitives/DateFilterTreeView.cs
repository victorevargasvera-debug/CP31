using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000089 RID: 137
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DateFilterTreeView : global::System.Windows.Controls.TreeView
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem dateFilterTreeViewItem = new global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem();
			dateFilterTreeViewItem.SetBinding(global::System.Windows.Controls.TreeViewItem.IsExpandedProperty, new global::System.Windows.Data.Binding("IsExpanded")
			{
				Mode = global::System.Windows.Data.BindingMode.TwoWay
			});
			return dateFilterTreeViewItem;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001AD0B File Offset: 0x00018F0B
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
		}
	}
}
