using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000139 RID: 313
	internal class GroupNumberManager
	{
		// Token: 0x0600110E RID: 4366 RVA: 0x0004A75C File Offset: 0x0004895C
		internal GroupNumberManager()
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0004A764 File Offset: 0x00048964
		internal int NextGroupNumber
		{
			get
			{
				return this._nextGroupNumber++;
			}
		}

		// Token: 0x040006BC RID: 1724
		private int _nextGroupNumber;
	}
}
