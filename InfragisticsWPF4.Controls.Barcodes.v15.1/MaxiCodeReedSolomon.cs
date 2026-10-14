using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200000D RID: 13
	internal class MaxiCodeReedSolomon : global::Infragistics.Controls.Barcodes.ReedSolomon
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0000542A File Offset: 0x0000362A
		public MaxiCodeReedSolomon()
		{
			this.gf64 = new global::Infragistics.Controls.Barcodes.Gf64(67);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000543F File Offset: 0x0000363F
		internal void CalculateReedSolomonCheckwords(int[] data, int startIndex, int checkwordsNumber)
		{
			if (data.Length < startIndex + checkwordsNumber)
			{
				return;
			}
			global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.SetPolynomial(checkwordsNumber);
			base.CalculateCheckwords(data, startIndex, checkwordsNumber, global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.p, this.gf64);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005464 File Offset: 0x00003664
		private static void SetPolynomial(int checkwordsNumber)
		{
			if (checkwordsNumber == 10)
			{
				global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.p = global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.Poly10;
				return;
			}
			if (checkwordsNumber == 20)
			{
				global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.p = global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.Poly20;
				return;
			}
			if (checkwordsNumber != 28)
			{
				global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.p = global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.Poly10;
				return;
			}
			global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.p = global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon.Poly28;
		}

		// Token: 0x04000033 RID: 51
		private static int[] p;

		// Token: 0x04000034 RID: 52
		private static readonly int[] Poly10 = new int[]
		{
			31,
			28,
			39,
			42,
			57,
			2,
			3,
			49,
			44,
			46
		};

		// Token: 0x04000035 RID: 53
		private static readonly int[] Poly20 = new int[]
		{
			23,
			44,
			11,
			33,
			27,
			8,
			22,
			37,
			57,
			36,
			15,
			48,
			22,
			17,
			38,
			33,
			31,
			19,
			23,
			59
		};

		// Token: 0x04000036 RID: 54
		private static readonly int[] Poly28 = new int[]
		{
			22,
			45,
			53,
			10,
			41,
			55,
			35,
			10,
			22,
			29,
			23,
			13,
			61,
			45,
			34,
			55,
			40,
			37,
			46,
			49,
			34,
			41,
			9,
			43,
			7,
			20,
			11,
			28
		};

		// Token: 0x04000037 RID: 55
		private readonly global::Infragistics.Controls.Barcodes.Gf64 gf64;
	}
}
