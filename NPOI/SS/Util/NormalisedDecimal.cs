using System;
using System.Globalization;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000026 RID: 38
	public class NormalisedDecimal
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00007438 File Offset: 0x00005638
		public static global::NPOI.SS.Util.NormalisedDecimal Create(global::NPOI.Util.BigInteger frac, int binaryExponent)
		{
			int num;
			if (binaryExponent > 49 || binaryExponent < 46)
			{
				num = -(15204352 - binaryExponent * 315653 + 524288 >> 20);
			}
			else
			{
				num = 0;
			}
			global::NPOI.SS.Util.MutableFPNumber mutableFPNumber = new global::NPOI.SS.Util.MutableFPNumber(frac, binaryExponent);
			if (num != 0)
			{
				mutableFPNumber.multiplyByPowerOfTen(-num);
			}
			switch (mutableFPNumber.Get64BitNormalisedExponent())
			{
			case 44:
			case 45:
				break;
			case 46:
				if (mutableFPNumber.IsAboveMinRep())
				{
					goto IL_B4;
				}
				break;
			case 47:
			case 48:
				goto IL_B4;
			case 49:
				if (!mutableFPNumber.IsBelowMaxRep())
				{
					goto IL_84;
				}
				goto IL_B4;
			case 50:
				goto IL_84;
			default:
				throw new global::System.InvalidOperationException("Bad binary exp " + mutableFPNumber.Get64BitNormalisedExponent().ToString() + ".");
			}
			mutableFPNumber.multiplyByPowerOfTen(1);
			num--;
			goto IL_B4;
			IL_84:
			mutableFPNumber.multiplyByPowerOfTen(-1);
			num++;
			IL_B4:
			mutableFPNumber.Normalise64bit();
			return mutableFPNumber.CreateNormalisedDecimal(num);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007508 File Offset: 0x00005708
		public global::NPOI.SS.Util.NormalisedDecimal RoundUnits()
		{
			long num = this._wholePart;
			if (this._fractionalPart >= 8388608)
			{
				num += 1L;
			}
			int relativeDecimalExponent = this._relativeDecimalExponent;
			if (num < 1000000000000000L)
			{
				return new global::NPOI.SS.Util.NormalisedDecimal(num, 0, relativeDecimalExponent);
			}
			return new global::NPOI.SS.Util.NormalisedDecimal(num / 10L, 0, relativeDecimalExponent + 1);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007558 File Offset: 0x00005758
		public NormalisedDecimal(long wholePart, int fracPart, int decimalExponent)
		{
			this._wholePart = wholePart;
			this._fractionalPart = fracPart;
			this._relativeDecimalExponent = decimalExponent;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007575 File Offset: 0x00005775
		public global::NPOI.SS.Util.ExpandedDouble NormaliseBaseTwo()
		{
			global::NPOI.SS.Util.MutableFPNumber mutableFPNumber = new global::NPOI.SS.Util.MutableFPNumber(this.ComposeFrac(), 39);
			mutableFPNumber.multiplyByPowerOfTen(this._relativeDecimalExponent);
			mutableFPNumber.Normalise64bit();
			return mutableFPNumber.CreateExpandedDouble();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000759C File Offset: 0x0000579C
		public global::NPOI.Util.BigInteger ComposeFrac()
		{
			long wholePart = this._wholePart;
			int fractionalPart = this._fractionalPart;
			return new global::NPOI.Util.BigInteger(new byte[]
			{
				(byte)(wholePart >> 56),
				(byte)(wholePart >> 48),
				(byte)(wholePart >> 40),
				(byte)(wholePart >> 32),
				(byte)(wholePart >> 24),
				(byte)(wholePart >> 16),
				(byte)(wholePart >> 8),
				(byte)wholePart,
				(byte)(fractionalPart >> 16),
				(byte)(fractionalPart >> 8),
				(byte)fractionalPart
			});
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007615 File Offset: 0x00005815
		public string GetSignificantDecimalDigits()
		{
			return this._wholePart.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007628 File Offset: 0x00005828
		public string GetSignificantDecimalDigitsLastDigitRounded()
		{
			long value = this._wholePart + 5L;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(24);
			stringBuilder.Append(value);
			stringBuilder[stringBuilder.Length - 1] = '0';
			return stringBuilder.ToString();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007663 File Offset: 0x00005863
		public int GetDecimalExponent()
		{
			return this._relativeDecimalExponent + 14;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007670 File Offset: 0x00005870
		public int CompareNormalised(global::NPOI.SS.Util.NormalisedDecimal other)
		{
			int num = this._relativeDecimalExponent - other._relativeDecimalExponent;
			if (num != 0)
			{
				return num;
			}
			if (this._wholePart > other._wholePart)
			{
				return 1;
			}
			if (this._wholePart < other._wholePart)
			{
				return -1;
			}
			return this._fractionalPart - other._fractionalPart;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000076BD File Offset: 0x000058BD
		public decimal GetFractionalPart()
		{
			return new decimal(this._fractionalPart) / global::NPOI.SS.Util.NormalisedDecimal.BD_2_POW_24;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000076D4 File Offset: 0x000058D4
		private string GetFractionalDigits()
		{
			if (this._fractionalPart == 0)
			{
				return "0";
			}
			return this.GetFractionalPart().ToString(global::System.Globalization.CultureInfo.InvariantCulture).Substring(2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007708 File Offset: 0x00005908
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			string text = this._wholePart.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			stringBuilder.Append(text[0]);
			stringBuilder.Append('.');
			stringBuilder.Append(text.Substring(1));
			stringBuilder.Append(' ');
			stringBuilder.Append(this.GetFractionalDigits());
			stringBuilder.Append("E");
			stringBuilder.Append(this.GetDecimalExponent());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x0400008B RID: 139
		private const int EXPONENT_OFFSET = 14;

		// Token: 0x0400008C RID: 140
		private static readonly decimal BD_2_POW_24 = new decimal((global::NPOI.Util.BigInteger.One << 24).LongValue());

		// Token: 0x0400008D RID: 141
		private const int LOG_BASE_10_OF_2_TIMES_2_POW_20 = 315653;

		// Token: 0x0400008E RID: 142
		private const int C_2_POW_19 = 524288;

		// Token: 0x0400008F RID: 143
		private const int FRAC_HALF = 8388608;

		// Token: 0x04000090 RID: 144
		private const long MAX_REP_WHOLE_PART = 1000000000000000L;

		// Token: 0x04000091 RID: 145
		private int _relativeDecimalExponent;

		// Token: 0x04000092 RID: 146
		private long _wholePart;

		// Token: 0x04000093 RID: 147
		private int _fractionalPart;
	}
}
