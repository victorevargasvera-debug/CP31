using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021C RID: 540
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "Selected")]
	[global::System.Windows.TemplateVisualState(GroupName = "LogicalOperators", Name = "And")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "UnFixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "FixedStates", Name = "Fixed")]
	[global::System.Windows.TemplateVisualState(GroupName = "LogicalOperators", Name = "Or")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "InActive")]
	[global::System.Windows.TemplateVisualState(GroupName = "SelectedStates", Name = "NotSelected")]
	[global::System.Windows.TemplateVisualState(GroupName = "ActiveStates", Name = "Active")]
	[global::System.Windows.TemplateVisualState(GroupName = "EditingStates", Name = "Editing")]
	[global::System.Windows.TemplateVisualState(GroupName = "EditingStates", Name = "NotEditing")]
	[global::System.Windows.TemplateVisualState(GroupName = "LogicalOperators", Name = "NoLogicalOp")]
	public class GroupDisplayCellControl : global::Infragistics.Controls.Grids.CellControl
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x0003A75C File Offset: 0x0003895C
		static GroupDisplayCellControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl)));
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0003A7C8 File Offset: 0x000389C8
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0003A7DA File Offset: 0x000389DA
		public global::System.Windows.Thickness InnerControlMargin
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl.InnerControlMarginProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl.InnerControlMarginProperty, value);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0003A7F0 File Offset: 0x000389F0
		private static void InnerControlMarginChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl groupDisplayCellControl = (global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl)obj;
			groupDisplayCellControl.OnPropertyChanged("InnerControlMargin");
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0003A810 File Offset: 0x00038A10
		protected internal override void EnsureCurrentState()
		{
			if (base.Cell != null && base.Cell.Row != null)
			{
				global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = base.Cell.Row.Data as global::Infragistics.Controls.Grids.XamGridConditionInfo;
				if (xamGridConditionInfo != null)
				{
					global::Infragistics.LogicalOperator? logicalOperator = this.ResolveOperator();
					if (logicalOperator == global::Infragistics.LogicalOperator.Or)
					{
						global::System.Windows.VisualStateManager.GoToState(this, "Or", false);
					}
					else if (logicalOperator == global::Infragistics.LogicalOperator.And)
					{
						global::System.Windows.VisualStateManager.GoToState(this, "And", false);
					}
					else
					{
						global::System.Windows.VisualStateManager.GoToState(this, "NoLogicalOp", false);
					}
				}
			}
			base.EnsureCurrentState();
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0003A8B5 File Offset: 0x00038AB5
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this.EnsureCurrentState();
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0003A8C4 File Offset: 0x00038AC4
		internal global::Infragistics.LogicalOperator? ResolveOperator()
		{
			int num = 0;
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> dataColumns = base.Column.ColumnLayout.Columns.DataColumns;
			for (int i = 0; i < dataColumns.Count; i++)
			{
				if (dataColumns[i] is global::Infragistics.Controls.Grids.GroupDisplayColumn)
				{
					num++;
				}
			}
			int num2 = dataColumns.IndexOf(base.Column);
			for (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = ((global::Infragistics.Controls.Grids.XamGridConditionInfo)base.Cell.Row.Data).Group; xamGridConditionInfoGroup != null; xamGridConditionInfoGroup = xamGridConditionInfoGroup.ParentGroup)
			{
				if (xamGridConditionInfoGroup.Level == num2)
				{
					return new global::Infragistics.LogicalOperator?(xamGridConditionInfoGroup.Operator);
				}
			}
			return null;
		}

		// Token: 0x040004DE RID: 1246
		public static readonly global::System.Windows.DependencyProperty InnerControlMarginProperty = global::System.Windows.DependencyProperty.Register("InnerControlMargin", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl.InnerControlMarginChanged)));
	}
}
