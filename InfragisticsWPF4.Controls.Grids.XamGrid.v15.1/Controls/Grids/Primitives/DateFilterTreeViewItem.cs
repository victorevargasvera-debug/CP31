using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200008A RID: 138
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DateFilterTreeViewItem : global::System.Windows.Controls.TreeViewItem
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x0001AD1D File Offset: 0x00018F1D
		static DateFilterTreeViewItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem)));
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001AD4C File Offset: 0x00018F4C
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem dateFilterTreeViewItem = new global::Infragistics.Controls.Grids.Primitives.DateFilterTreeViewItem();
			dateFilterTreeViewItem.SetBinding(global::System.Windows.Controls.TreeViewItem.IsExpandedProperty, new global::System.Windows.Data.Binding("IsExpanded")
			{
				Mode = global::System.Windows.Data.BindingMode.TwoWay
			});
			return dateFilterTreeViewItem;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001AD80 File Offset: 0x00018F80
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::System.Windows.Controls.Primitives.ToggleButton toggleButton = base.GetTemplateChild("ExpanderButton") as global::System.Windows.Controls.Primitives.ToggleButton;
			if (toggleButton != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("IsExpanded");
				binding.Source = this;
				binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
				toggleButton.SetBinding(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);
			}
		}
	}
}
