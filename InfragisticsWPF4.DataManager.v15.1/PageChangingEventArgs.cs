using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x0200003D RID: 61
	internal class PageChangingEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0000DD49 File Offset: 0x0000BF49
		public PageChangingEventArgs(int newPageIndex)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000DD51 File Offset: 0x0000BF51
		public int NewPageIndex
		{
			get
			{
				return -1;
			}
		}
	}
}
