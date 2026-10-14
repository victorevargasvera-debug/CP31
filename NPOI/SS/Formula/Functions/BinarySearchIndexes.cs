using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A9 RID: 425
	internal class BinarySearchIndexes
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x0001F883 File Offset: 0x0001DA83
		public BinarySearchIndexes(int highIx)
		{
			this._lowIx = -1;
			this._highIx = highIx;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001F89C File Offset: 0x0001DA9C
		public int GetMidIx()
		{
			int num = this._highIx - this._lowIx;
			if (num < 2)
			{
				return -1;
			}
			return this._lowIx + num / 2;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001F8C7 File Offset: 0x0001DAC7
		public int GetLowIx()
		{
			return this._lowIx;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001F8CF File Offset: 0x0001DACF
		public int GetHighIx()
		{
			return this._highIx;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001F8D7 File Offset: 0x0001DAD7
		public void NarrowSearch(int midIx, bool isLessThan)
		{
			if (isLessThan)
			{
				this._highIx = midIx;
				return;
			}
			this._lowIx = midIx;
		}

		// Token: 0x0400057B RID: 1403
		private int _lowIx;

		// Token: 0x0400057C RID: 1404
		private int _highIx;
	}
}
