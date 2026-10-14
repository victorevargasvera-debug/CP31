using System;

namespace NPOI.POIFS.Common
{
	// Token: 0x0200029F RID: 671
	public class POIFSBigBlockSize
	{
		// Token: 0x0600125C RID: 4700 RVA: 0x000371A4 File Offset: 0x000353A4
		internal POIFSBigBlockSize(int bigBlockSize, short headerValue)
		{
			this.bigBlockSize = bigBlockSize;
			this.headerValue = headerValue;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000371BA File Offset: 0x000353BA
		public int GetBigBlockSize()
		{
			return this.bigBlockSize;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000371C2 File Offset: 0x000353C2
		public short GetHeaderValue()
		{
			return this.headerValue;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000371CA File Offset: 0x000353CA
		public int GetPropertiesPerBlock()
		{
			return this.bigBlockSize / 128;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000371D8 File Offset: 0x000353D8
		public int GetBATEntriesPerBlock()
		{
			return this.bigBlockSize / 4;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000371E2 File Offset: 0x000353E2
		public int GetXBATEntriesPerBlock()
		{
			return this.GetBATEntriesPerBlock() - 1;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000371EC File Offset: 0x000353EC
		public int GetNextXBATChainOffset()
		{
			return this.GetXBATEntriesPerBlock() * 4;
		}

		// Token: 0x04000790 RID: 1936
		private int bigBlockSize;

		// Token: 0x04000791 RID: 1937
		private short headerValue;
	}
}
