using System;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x02000183 RID: 387
	public class AstroRecSetCountsItem
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x00003788 File Offset: 0x00001988
		public AstroRecSetCountsItem(string recsetName, int instance, int count, int maxpool, int countToMaxPool)
		{
			this._recSetName = recsetName;
			this._recSetInstanceNo = instance;
			this._count = count;
			this._maxPool = maxpool;
			this._counterToMaxPool = countToMaxPool;
		}

		// Token: 0x04000A22 RID: 2594
		public int _count;

		// Token: 0x04000A23 RID: 2595
		public int _maxPool;

		// Token: 0x04000A24 RID: 2596
		public int _counterToMaxPool;

		// Token: 0x04000A25 RID: 2597
		public int _recSetInstanceNo;

		// Token: 0x04000A26 RID: 2598
		public string _recSetName;
	}
}
