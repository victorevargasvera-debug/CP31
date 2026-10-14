using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F3 RID: 499
	public class ChildBandCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000E0E RID: 3598 RVA: 0x0003480A File Offset: 0x00032A0A
		public ChildBandCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.ChildBandCellControl);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00034822 File Offset: 0x00032A22
		protected override void AttachContent()
		{
			this.EnsureContent();
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0003482C File Offset: 0x00032A2C
		protected internal override void EnsureContent()
		{
			bool flag = true;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Cell.Row.ColumnLayout;
			if (columnLayout.HeaderTemplate != null)
			{
				if (this._currentTemplate != columnLayout.HeaderTemplate)
				{
					this._currentTemplate = columnLayout.HeaderTemplate;
					this._elem = (columnLayout.HeaderTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				base.Content = this._elem;
				if (this._elem != null)
				{
					this._elem.DataContext = base.Cell.Row.Data;
				}
				flag = false;
			}
			else
			{
				this._currentTemplate = null;
				this._elem = null;
			}
			if (flag || base.Content == null)
			{
				if (string.IsNullOrEmpty(columnLayout.HeaderText))
				{
					if (columnLayout.Key != null)
					{
						string[] array = columnLayout.Key.Split(new char[]
						{
							'.'
						});
						base.Content = array[array.Length - 1];
						return;
					}
				}
				else
				{
					base.Content = columnLayout.HeaderText;
				}
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00034918 File Offset: 0x00032B18
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			base.DataContext = null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00034928 File Offset: 0x00032B28
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!(base.Cell.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn))
			{
				base.Cell.Row.ColumnLayout.Grid.ActiveCell = base.Cell;
			}
		}

		// Token: 0x04000494 RID: 1172
		private global::System.Windows.DataTemplate _currentTemplate;

		// Token: 0x04000495 RID: 1173
		private global::System.Windows.FrameworkElement _elem;
	}
}
