using System;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000255 RID: 597
	public class GroupDisplayColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x0004802C File Offset: 0x0004622C
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = cell.Row.Data as global::Infragistics.Controls.Grids.XamGridConditionInfo;
			int num = 0;
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> dataColumns = cell.Column.ColumnLayout.Columns.DataColumns;
			global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl groupDisplayCellControl = (global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl)cell.Control;
			for (int i = 0; i < dataColumns.Count; i++)
			{
				if (dataColumns[i] is global::Infragistics.Controls.Grids.GroupDisplayColumn)
				{
					num++;
				}
			}
			int num2 = dataColumns.IndexOf(cell.Column);
			if (num2 == 0)
			{
				groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			}
			else if (xamGridConditionInfo.Group.ParentGroup != null)
			{
				int num3 = xamGridConditionInfo.Group.ParentGroup.ChildGroups.IndexOf(xamGridConditionInfo.Group);
				if (num3 == 0)
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, (double)(num2 * 3), 0.0, 0.0);
				}
				else if (num3 == xamGridConditionInfo.Group.ParentGroup.ChildGroups.Count - 1)
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, (double)(num2 * 3));
				}
				else
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
				}
			}
			else
			{
				groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			}
			return null;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000481E8 File Offset: 0x000463E8
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = cell.Row.Data as global::Infragistics.Controls.Grids.XamGridConditionInfo;
			int num = 0;
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> dataColumns = cell.Column.ColumnLayout.Columns.DataColumns;
			global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl groupDisplayCellControl = (global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl)cell.Control;
			for (int i = 0; i < dataColumns.Count; i++)
			{
				if (dataColumns[i] is global::Infragistics.Controls.Grids.GroupDisplayColumn)
				{
					num++;
				}
			}
			int num2 = dataColumns.IndexOf(cell.Column);
			if (num2 == 0)
			{
				groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			}
			else if (xamGridConditionInfo.Group.ParentGroup != null)
			{
				int num3 = xamGridConditionInfo.Group.InfoObjects.IndexOf(xamGridConditionInfo);
				if (num3 == 0 && xamGridConditionInfo.Group.Level == num2)
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, (double)(num2 * 3), 0.0, 0.0);
				}
				else if (num3 == xamGridConditionInfo.Group.InfoObjects.Count - 1 && xamGridConditionInfo.Group.Level == num2)
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, (double)(num2 * 3));
				}
				else
				{
					groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
				}
			}
			else
			{
				groupDisplayCellControl.InnerControlMargin = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			}
			if (cell.Control != null)
			{
				cell.Control.EnsureCurrentState();
			}
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000483CA File Offset: 0x000465CA
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000483CD File Offset: 0x000465CD
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			return null;
		}
	}
}
