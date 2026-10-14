using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001FD RID: 509
	public class FooterCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000E6C RID: 3692 RVA: 0x00035CDD File Offset: 0x00033EDD
		public FooterCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.FooterCellControl);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00035CF5 File Offset: 0x00033EF5
		protected override void AttachContent()
		{
			this.EnsureContent();
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00035D00 File Offset: 0x00033F00
		protected internal override void EnsureContent()
		{
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			if (column != null)
			{
				bool flag = true;
				string dataContext = null;
				if (column.Key != null)
				{
					string[] array = column.Key.Split(new char[]
					{
						'.'
					});
					dataContext = array[array.Length - 1];
				}
				if (column.FooterTemplate != null)
				{
					if (this._currentTemplate != column.FooterTemplate)
					{
						this._currentTemplate = column.FooterTemplate;
						this._contentElement = (column.FooterTemplate.LoadContent() as global::System.Windows.FrameworkElement);
					}
					base.Content = this._contentElement;
					base.DataContext = dataContext;
					flag = false;
				}
				else if (column.SupportsHeaderFooterContent)
				{
					global::System.Windows.DataTemplate columnsFooterTemplateResolved = base.Cell.Row.ColumnLayout.ColumnsFooterTemplateResolved;
					if (columnsFooterTemplateResolved != null)
					{
						if (this._currentTemplate != columnsFooterTemplateResolved)
						{
							this._contentElement = (columnsFooterTemplateResolved.LoadContent() as global::System.Windows.FrameworkElement);
						}
						base.Content = this._contentElement;
						base.DataContext = dataContext;
						flag = false;
					}
					this._currentTemplate = columnsFooterTemplateResolved;
				}
				if (flag || base.Content == null)
				{
					if (string.IsNullOrEmpty(column.FooterText))
					{
						base.Content = " ";
						return;
					}
					base.Content = column.FooterText;
				}
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00035E2A File Offset: 0x0003402A
		protected internal override void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			base.OnReleased(cell);
			base.DataContext = null;
		}

		// Token: 0x040004A7 RID: 1191
		private global::System.Windows.DataTemplate _currentTemplate;

		// Token: 0x040004A8 RID: 1192
		private global::System.Windows.FrameworkElement _contentElement;
	}
}
