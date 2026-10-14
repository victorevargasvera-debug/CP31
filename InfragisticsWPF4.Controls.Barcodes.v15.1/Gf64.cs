using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200000B RID: 11
	public class Gf64 : global::Infragistics.Controls.Barcodes.GfArithmetics
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00005239 File Offset: 0x00003439
		public Gf64(int primePolynom) : base(64)
		{
			this.pp = primePolynom;
			base.CreateLogArrays(primePolynom);
		}

		// Token: 0x04000030 RID: 48
		public const int GfNumber = 64;

		// Token: 0x04000031 RID: 49
		public const int N = 63;

		// Token: 0x04000032 RID: 50
		private int pp;
	}
}
