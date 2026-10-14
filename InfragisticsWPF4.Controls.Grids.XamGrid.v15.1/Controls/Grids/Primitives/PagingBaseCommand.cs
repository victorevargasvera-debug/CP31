using System;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000118 RID: 280
	public abstract class PagingBaseCommand : global::Infragistics.CommandBase
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x00025404 File Offset: 0x00023604
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = parameter as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				return rowsManager != null && rowsManager.ColumnLayout.PagerSettings.AllowPagingResolved != global::Infragistics.Controls.Grids.PagingLocation.None && this.CanExecutePaging(rowsManager);
			}
			object[] array = parameter as object[];
			if (array != null && array.Length > 1)
			{
				rowsManager = (array[0] as global::Infragistics.Controls.Grids.RowsManager);
				int rowIndex = int.Parse(array[1].ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				return rowsManager != null && rowsManager.ColumnLayout.PagerSettings.AllowPagingResolved != global::Infragistics.Controls.Grids.PagingLocation.None && this.CanExecutePaging(rowsManager, rowIndex);
			}
			return false;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00025488 File Offset: 0x00023688
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = parameter as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				this.ExecutePaging(rowsManager);
				base.CommandSource.Handled = true;
			}
			object[] array = parameter as object[];
			if (array != null)
			{
				this.ExecutePaging((global::Infragistics.Controls.Grids.RowsManager)array[0], int.Parse(array[1].ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000254EF File Offset: 0x000236EF
		protected virtual void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000254F1 File Offset: 0x000236F1
		protected virtual void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase, int pageIndex)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000254F3 File Offset: 0x000236F3
		protected virtual bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			return false;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000254F6 File Offset: 0x000236F6
		protected virtual bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase, int rowIndex)
		{
			return false;
		}
	}
}
