using System;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000025 RID: 37
	public class MutableFPNumber
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00007170 File Offset: 0x00005370
		public MutableFPNumber(global::NPOI.Util.BigInteger frac, int binaryExponent)
		{
			this._significand = frac;
			this._binaryExponent = binaryExponent;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007186 File Offset: 0x00005386
		public global::NPOI.SS.Util.MutableFPNumber Copy()
		{
			return new global::NPOI.SS.Util.MutableFPNumber(this._significand, this._binaryExponent);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000719C File Offset: 0x0000539C
		public void Normalise64bit()
		{
			int num = this._significand.BitLength();
			int num2 = num - 64;
			if (num2 == 0)
			{
				return;
			}
			if (num2 < 0)
			{
				throw new global::System.InvalidOperationException("Not enough precision");
			}
			this._binaryExponent += num2;
			if (num2 > 32)
			{
				int num3 = num2 - 1 & 16777184;
				this._significand >>= num3;
				num2 -= num3;
				num -= num3;
			}
			if (num2 < 1)
			{
				throw new global::System.InvalidOperationException();
			}
			this._significand = global::NPOI.SS.Util.MutableFPNumber.Rounder.Round(this._significand, num2);
			if (this._significand.BitLength() > num)
			{
				num2++;
				this._binaryExponent++;
			}
			this._significand >>= num2;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007252 File Offset: 0x00005452
		public int Get64BitNormalisedExponent()
		{
			return this._binaryExponent + this._significand.BitLength() - 64;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000726C File Offset: 0x0000546C
		public bool IsBelowMaxRep()
		{
			int n = this._significand.BitLength() - 64;
			return this._significand.CompareTo(global::NPOI.SS.Util.MutableFPNumber.BI_MAX_BASE.ShiftLeft(n)) < 0;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000072A4 File Offset: 0x000054A4
		public bool IsAboveMinRep()
		{
			int n = this._significand.BitLength() - 64;
			return this._significand.CompareTo(global::NPOI.SS.Util.MutableFPNumber.BI_MIN_BASE.ShiftLeft(n)) > 0;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000072DC File Offset: 0x000054DC
		public global::NPOI.SS.Util.NormalisedDecimal CreateNormalisedDecimal(int pow10)
		{
			int num = this._binaryExponent - 39;
			int fracPart = this._significand.IntValue() << num & 16777088;
			return new global::NPOI.SS.Util.NormalisedDecimal((this._significand >> 64 - this._binaryExponent - 1).LongValue(), fracPart, pow10);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000732C File Offset: 0x0000552C
		public void multiplyByPowerOfTen(int pow10)
		{
			global::NPOI.SS.Util.MutableFPNumber.TenPower instance = global::NPOI.SS.Util.MutableFPNumber.TenPower.GetInstance(global::System.Math.Abs(pow10));
			if (pow10 < 0)
			{
				this.mulShift(instance._divisor, instance._divisorShift);
				return;
			}
			this.mulShift(instance._multiplicand, instance._multiplierShift);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007370 File Offset: 0x00005570
		private void mulShift(global::NPOI.Util.BigInteger multiplicand, int multiplierShift)
		{
			this._significand *= multiplicand;
			this._binaryExponent += multiplierShift;
			int num = this._significand.BitLength() - 72 & -32;
			if (num > 0)
			{
				this._significand >>= num;
				this._binaryExponent += num;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000073D3 File Offset: 0x000055D3
		public global::NPOI.SS.Util.ExpandedDouble CreateExpandedDouble()
		{
			return new global::NPOI.SS.Util.ExpandedDouble(this._significand, this._binaryExponent);
		}

		// Token: 0x04000085 RID: 133
		private static readonly global::NPOI.Util.BigInteger BI_MIN_BASE = new global::NPOI.Util.BigInteger(new int[]
		{
			-1243209484,
			2147477094
		}, 1);

		// Token: 0x04000086 RID: 134
		private static readonly global::NPOI.Util.BigInteger BI_MAX_BASE = new global::NPOI.Util.BigInteger(new int[]
		{
			-480270031,
			-1610620928
		}, 1);

		// Token: 0x04000087 RID: 135
		private const int C_64 = 64;

		// Token: 0x04000088 RID: 136
		private const int MIN_PRECISION = 72;

		// Token: 0x04000089 RID: 137
		private global::NPOI.Util.BigInteger _significand;

		// Token: 0x0400008A RID: 138
		private int _binaryExponent;

		// Token: 0x02000554 RID: 1364
		private class Rounder
		{
			// Token: 0x0600336A RID: 13162 RVA: 0x000A1018 File Offset: 0x0009F218
			static Rounder()
			{
				global::NPOI.Util.BigInteger[] array = new global::NPOI.Util.BigInteger[33];
				long num = 1L;
				for (int i = 1; i < array.Length; i++)
				{
					array[i] = new global::NPOI.Util.BigInteger(num);
					num <<= 1;
				}
				global::NPOI.SS.Util.MutableFPNumber.Rounder.HALF_BITS = array;
			}

			// Token: 0x0600336B RID: 13163 RVA: 0x000A1051 File Offset: 0x0009F251
			public static global::NPOI.Util.BigInteger Round(global::NPOI.Util.BigInteger bi, int nBits)
			{
				if (nBits < 1)
				{
					return bi;
				}
				return bi + global::NPOI.SS.Util.MutableFPNumber.Rounder.HALF_BITS[nBits];
			}

			// Token: 0x04001868 RID: 6248
			private static global::NPOI.Util.BigInteger[] HALF_BITS;
		}

		// Token: 0x02000555 RID: 1365
		private class TenPower
		{
			// Token: 0x0600336D RID: 13165 RVA: 0x000A1068 File Offset: 0x0009F268
			private TenPower(int index)
			{
				global::NPOI.Util.BigInteger bigInteger = global::NPOI.SS.Util.MutableFPNumber.TenPower.FIVE.Pow(index);
				int num = bigInteger.BitLength();
				int shiftVal = 80 + num;
				global::NPOI.Util.BigInteger bigInteger2 = (global::NPOI.Util.BigInteger.One << shiftVal) / bigInteger;
				int num2 = bigInteger2.BitLength() - 80;
				this._divisor = bigInteger2 >> num2;
				num -= num2;
				this._divisorShift = -(num + index + 80);
				int num3 = bigInteger.BitLength() - 68;
				if (num3 > 0)
				{
					this._multiplierShift = index + num3;
					this._multiplicand = bigInteger >> num3;
					return;
				}
				this._multiplierShift = index;
				this._multiplicand = bigInteger;
			}

			// Token: 0x0600336E RID: 13166 RVA: 0x000A1108 File Offset: 0x0009F308
			public static global::NPOI.SS.Util.MutableFPNumber.TenPower GetInstance(int index)
			{
				global::NPOI.SS.Util.MutableFPNumber.TenPower tenPower = global::NPOI.SS.Util.MutableFPNumber.TenPower._cache[index];
				if (tenPower == null)
				{
					tenPower = new global::NPOI.SS.Util.MutableFPNumber.TenPower(index);
					global::NPOI.SS.Util.MutableFPNumber.TenPower._cache[index] = tenPower;
				}
				return tenPower;
			}

			// Token: 0x04001869 RID: 6249
			private static readonly global::NPOI.Util.BigInteger FIVE = new global::NPOI.Util.BigInteger(5L);

			// Token: 0x0400186A RID: 6250
			private static global::NPOI.SS.Util.MutableFPNumber.TenPower[] _cache = new global::NPOI.SS.Util.MutableFPNumber.TenPower[350];

			// Token: 0x0400186B RID: 6251
			public global::NPOI.Util.BigInteger _multiplicand;

			// Token: 0x0400186C RID: 6252
			public global::NPOI.Util.BigInteger _divisor;

			// Token: 0x0400186D RID: 6253
			public int _divisorShift;

			// Token: 0x0400186E RID: 6254
			public int _multiplierShift;
		}
	}
}
