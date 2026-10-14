using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F2 RID: 754
	public class ChainingMode
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00040B88 File Offset: 0x0003ED88
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00040B90 File Offset: 0x0003ED90
		public string jceId { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00040B99 File Offset: 0x0003ED99
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00040BA1 File Offset: 0x0003EDA1
		public int ecmaId { get; set; }

		// Token: 0x060015B5 RID: 5557 RVA: 0x00040BAA File Offset: 0x0003EDAA
		public ChainingMode(string jceId, int ecmaId)
		{
			this.jceId = jceId;
			this.ecmaId = ecmaId;
		}

		// Token: 0x040008B3 RID: 2227
		public static readonly global::NPOI.POIFS.Crypt.ChainingMode ecb = new global::NPOI.POIFS.Crypt.ChainingMode("ECB", 1);

		// Token: 0x040008B4 RID: 2228
		public static readonly global::NPOI.POIFS.Crypt.ChainingMode cbc = new global::NPOI.POIFS.Crypt.ChainingMode("CBC", 2);

		// Token: 0x040008B5 RID: 2229
		public static readonly global::NPOI.POIFS.Crypt.ChainingMode cfb = new global::NPOI.POIFS.Crypt.ChainingMode("CFB8", 3);
	}
}
