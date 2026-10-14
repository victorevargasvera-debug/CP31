using System;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011E RID: 286
	public class PagingControlCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x00025604 File Offset: 0x00023804
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.PagerControlBase pagerControlBase = parameter as global::Infragistics.Controls.Grids.Primitives.PagerControlBase;
			if (pagerControlBase != null)
			{
				return this.CanExecutePagingControl(pagerControlBase);
			}
			object[] array = parameter as object[];
			if (array != null)
			{
				this.CanExecutePagingControl((global::Infragistics.Controls.Grids.Primitives.PagerControlBase)array[0], int.Parse(array[1].ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return true;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00025650 File Offset: 0x00023850
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.PagerControlBase pagerControlBase = parameter as global::Infragistics.Controls.Grids.Primitives.PagerControlBase;
			if (pagerControlBase != null)
			{
				this.ExecutePagingCommand(pagerControlBase);
				base.CommandSource.Handled = true;
			}
			object[] array = parameter as object[];
			if (array != null)
			{
				this.ExecutePagingCommand((global::Infragistics.Controls.Grids.Primitives.PagerControlBase)array[0], int.Parse(array[1].ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				base.CommandSource.Handled = true;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000256B0 File Offset: 0x000238B0
		protected virtual void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000256B2 File Offset: 0x000238B2
		protected virtual void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager, int rowIndex)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000256B4 File Offset: 0x000238B4
		protected virtual bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			return true;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000256B7 File Offset: 0x000238B7
		protected virtual bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager, int nextPage)
		{
			return true;
		}
	}
}
