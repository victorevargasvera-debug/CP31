using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000155 RID: 341
	internal class GroupNumberManager
	{
		// Token: 0x06001477 RID: 5239 RVA: 0x0005BA58 File Offset: 0x00059C58
		internal GroupNumberManager()
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0005BA60 File Offset: 0x00059C60
		internal int NextGroupNumber
		{
			get
			{
				return this._nextGroupNumber++;
			}
		}

		// Token: 0x04000862 RID: 2146
		private int _nextGroupNumber;
	}
}
