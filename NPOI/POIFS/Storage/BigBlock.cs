using System;
using System.IO;
using NPOI.POIFS.Common;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A4 RID: 676
	public abstract class BigBlock : global::NPOI.POIFS.Storage.BlockWritable
	{
		// Token: 0x060012A6 RID: 4774 RVA: 0x0000253E File Offset: 0x0000073E
		protected BigBlock()
		{
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00037FF7 File Offset: 0x000361F7
		protected BigBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this.bigBlockSize = bigBlockSize;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00038006 File Offset: 0x00036206
		protected void WriteData(global::System.IO.Stream stream, byte[] data)
		{
			stream.Write(data, 0, data.Length);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00038013 File Offset: 0x00036213
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			this.WriteData(stream);
		}

		// Token: 0x060012AA RID: 4778
		public abstract void WriteData(global::System.IO.Stream stream);

		// Token: 0x040007BA RID: 1978
		protected global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;
	}
}
