using System;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x0200001B RID: 27
	public class ExpandedDouble
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00006A2B File Offset: 0x00004C2B
		private static global::NPOI.Util.BigInteger GetFrac(long rawBits)
		{
			return ((new global::NPOI.Util.BigInteger(rawBits) & global::NPOI.SS.Util.ExpandedDouble.BI_FRAC_MASK) | global::NPOI.SS.Util.ExpandedDouble.BI_IMPLIED_FRAC_MSB) << 11;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006A4E File Offset: 0x00004C4E
		public static global::NPOI.SS.Util.ExpandedDouble FromRawBitsAndExponent(long rawBits, int exp)
		{
			return new global::NPOI.SS.Util.ExpandedDouble(global::NPOI.SS.Util.ExpandedDouble.GetFrac(rawBits), exp);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006A5C File Offset: 0x00004C5C
		public ExpandedDouble(long rawBits)
		{
			int num = (int)(rawBits >> 52);
			if (num == 0)
			{
				global::NPOI.Util.BigInteger bigInteger = new global::NPOI.Util.BigInteger(rawBits) & global::NPOI.SS.Util.ExpandedDouble.BI_FRAC_MASK;
				int num2 = 64 - bigInteger.BitLength();
				this._significand = bigInteger << num2;
				this._binaryExponent = (num & 2047) - 1023 - num2;
				return;
			}
			global::NPOI.Util.BigInteger frac = global::NPOI.SS.Util.ExpandedDouble.GetFrac(rawBits);
			this._significand = frac;
			this._binaryExponent = (num & 2047) - 1023;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006AD7 File Offset: 0x00004CD7
		public ExpandedDouble(global::NPOI.Util.BigInteger frac, int binaryExp)
		{
			if (frac.BitLength() != 64)
			{
				throw new global::System.ArgumentException("bad bit length");
			}
			this._significand = frac;
			this._binaryExponent = binaryExp;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006B02 File Offset: 0x00004D02
		public global::NPOI.SS.Util.NormalisedDecimal NormaliseBaseTen()
		{
			return global::NPOI.SS.Util.NormalisedDecimal.Create(this._significand, this._binaryExponent);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006B15 File Offset: 0x00004D15
		public int GetBinaryExponent()
		{
			return this._binaryExponent;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006B1D File Offset: 0x00004D1D
		public global::NPOI.Util.BigInteger GetSignificand()
		{
			return this._significand;
		}

		// Token: 0x04000067 RID: 103
		private static readonly global::NPOI.Util.BigInteger BI_FRAC_MASK = new global::NPOI.Util.BigInteger(4503599627370495L);

		// Token: 0x04000068 RID: 104
		private static readonly global::NPOI.Util.BigInteger BI_IMPLIED_FRAC_MSB = new global::NPOI.Util.BigInteger(4503599627370496L);

		// Token: 0x04000069 RID: 105
		private global::NPOI.Util.BigInteger _significand;

		// Token: 0x0400006A RID: 106
		private int _binaryExponent;
	}
}
