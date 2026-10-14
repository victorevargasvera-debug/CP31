using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000218 RID: 536
	public class GroupByColumnLayoutHeaderCellControl : global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x0003A4E3 File Offset: 0x000386E3
		public GroupByColumnLayoutHeaderCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCellControl);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0003A4FC File Offset: 0x000386FC
		protected override void AttachContent()
		{
			bool flag = true;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Cell.Row.ColumnLayout;
			if (columnLayout.HeaderTemplate != null)
			{
				base.Content = columnLayout.HeaderTemplate.LoadContent();
				base.DataContext = columnLayout.Key;
				flag = false;
			}
			if (flag || base.Content == null)
			{
				if (string.IsNullOrEmpty(columnLayout.HeaderText))
				{
					base.Content = columnLayout.Key;
					return;
				}
				base.Content = columnLayout.HeaderText;
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0003A574 File Offset: 0x00038774
		protected override bool OnMouseLeftButtonDownColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			return false;
		}
	}
}
