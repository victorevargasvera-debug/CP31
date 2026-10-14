using System;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A3 RID: 675
	public class BATBlockAndIndex
	{
		// Token: 0x060012A3 RID: 4771 RVA: 0x00037FD1 File Offset: 0x000361D1
		public BATBlockAndIndex(int index, global::NPOI.POIFS.Storage.BATBlock block)
		{
			this.index = index;
			this.block = block;
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00037FE7 File Offset: 0x000361E7
		public int Index
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00037FEF File Offset: 0x000361EF
		public global::NPOI.POIFS.Storage.BATBlock Block
		{
			get
			{
				return this.block;
			}
		}

		// Token: 0x040007B8 RID: 1976
		private int index;

		// Token: 0x040007B9 RID: 1977
		private global::NPOI.POIFS.Storage.BATBlock block;
	}
}
