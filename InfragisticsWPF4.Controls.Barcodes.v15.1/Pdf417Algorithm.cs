using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000017 RID: 23
	internal class Pdf417Algorithm
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		static Pdf417Algorithm()
		{
			global::Infragistics.Controls.Barcodes.Pdf417Algorithm.PunctuationSet = new byte[128];
			byte b = 0;
			while ((int)b < global::Infragistics.Controls.Barcodes.Pdf417Algorithm.TextPuncutationAscii.Length)
			{
				byte b2 = global::Infragistics.Controls.Barcodes.Pdf417Algorithm.TextPuncutationAscii[(int)b];
				if (b2 > 0)
				{
					global::Infragistics.Controls.Barcodes.Pdf417Algorithm.PunctuationSet[(int)b2] = b;
				}
				b += 1;
			}
			global::Infragistics.Controls.Barcodes.Pdf417Algorithm.TextMixedAscii = new byte[]
			{
				48,
				49,
				50,
				51,
				52,
				53,
				54,
				55,
				56,
				57,
				38,
				13,
				9,
				44,
				58,
				35,
				45,
				46,
				36,
				47,
				43,
				37,
				42,
				61,
				94,
				0,
				32,
				0,
				0,
				0
			};
			global::Infragistics.Controls.Barcodes.Pdf417Algorithm.MixedSet = new byte[128];
			byte b3 = 0;
			while ((int)b3 < global::Infragistics.Controls.Barcodes.Pdf417Algorithm.TextMixedAscii.Length)
			{
				byte b4 = global::Infragistics.Controls.Barcodes.Pdf417Algorithm.TextMixedAscii[(int)b3];
				if (b4 > 0)
				{
					global::Infragistics.Controls.Barcodes.Pdf417Algorithm.MixedSet[(int)b4] = b3;
				}
				b3 += 1;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000BF17 File Offset: 0x0000A117
		public static int GetErrorCorrectionCodewordCount(int errorCorrectionLevel)
		{
			return 2 << errorCorrectionLevel;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000BF1F File Offset: 0x0000A11F
		public static bool IsColumnInRange(int cols)
		{
			return cols >= 1 && cols <= 30;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000BF2F File Offset: 0x0000A12F
		public static bool IsRowInRange(int rows)
		{
			return rows >= 3 && rows <= 90;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000BF3F File Offset: 0x0000A13F
		public static bool IsAspectRatioValid(double aspectRatio)
		{
			return aspectRatio >= 0.001 && aspectRatio <= 1000.0;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000BF60 File Offset: 0x0000A160
		internal static bool IsRowsColumnsCombinationValid(byte rows, byte cols, int sourceCodewordsNumber, int errorCorrectionCodewordsNumber)
		{
			bool flag = global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsColumnInRange((int)cols) && global::Infragistics.Controls.Barcodes.Pdf417Algorithm.IsRowInRange((int)rows);
			if (flag)
			{
				int num = (int)(cols * rows);
				if (num < sourceCodewordsNumber + errorCorrectionCodewordsNumber + 1)
				{
					string message = global::SR.GetString("PDF417InvalidRowsColumnsCombination").Replace("{0}", rows.ToString()).Replace("{1}", cols.ToString());
					global::System.ArgumentException ex = new global::System.ArgumentException(message);
					throw ex;
				}
			}
			return flag;
		}

		// Token: 0x04000094 RID: 148
		public const int QuietHZone = 2;

		// Token: 0x04000095 RID: 149
		public const int QuietVZone = 2;

		// Token: 0x04000096 RID: 150
		public const byte MinCols = 1;

		// Token: 0x04000097 RID: 151
		public const byte MaxCols = 30;

		// Token: 0x04000098 RID: 152
		public const byte MinRows = 3;

		// Token: 0x04000099 RID: 153
		public const byte MaxRows = 90;

		// Token: 0x0400009A RID: 154
		public const double MinAspectRatio = 0.001;

		// Token: 0x0400009B RID: 155
		public const double MaxAspectRatio = 1000.0;

		// Token: 0x0400009C RID: 156
		public const int StartChar = 130728;

		// Token: 0x0400009D RID: 157
		public const int StopChar = 260649;

		// Token: 0x0400009E RID: 158
		public const int StartCodeLength = 17;

		// Token: 0x0400009F RID: 159
		public const int CharLength = 17;

		// Token: 0x040000A0 RID: 160
		public const int StopCodeLength = 18;

		// Token: 0x040000A1 RID: 161
		internal const char PadChar = '΄';

		// Token: 0x040000A2 RID: 162
		internal const int TextMode = 900;

		// Token: 0x040000A3 RID: 163
		internal const int ByteMode6 = 924;

		// Token: 0x040000A4 RID: 164
		internal const int ByteMode = 901;

		// Token: 0x040000A5 RID: 165
		internal const int ByteShift = 913;

		// Token: 0x040000A6 RID: 166
		internal const int NumericMode = 902;

		// Token: 0x040000A7 RID: 167
		public const int AbsoluteMaxTextSize = 5420;

		// Token: 0x040000A8 RID: 168
		public const int MaxDataCodewords = 926;

		// Token: 0x040000A9 RID: 169
		internal const int MacroOptionalField = 923;

		// Token: 0x040000AA RID: 170
		internal const int MacroControlBlock = 928;

		// Token: 0x040000AB RID: 171
		internal const int MacroLastSegment = 922;

		// Token: 0x040000AC RID: 172
		internal const char PunctuationLatch = '\u0019';

		// Token: 0x040000AD RID: 173
		internal const char LowercaseLatch = '\u001b';

		// Token: 0x040000AE RID: 174
		internal const char AlphabeticShift = '\u001b';

		// Token: 0x040000AF RID: 175
		internal const char MixedLatch = '\u001c';

		// Token: 0x040000B0 RID: 176
		internal const char AlphanumericUppercaseLatch = '\u001c';

		// Token: 0x040000B1 RID: 177
		internal const char PunctuationShift = '\u001d';

		// Token: 0x040000B2 RID: 178
		internal const int AlphanumericLatch = 29;

		// Token: 0x040000B3 RID: 179
		internal const int ModuloNumber = 929;

		// Token: 0x040000B4 RID: 180
		internal static string MixedValidChars = string.Concat(new object[]
		{
			"0123456789&",
			'\r',
			'\t',
			",:#-.$/+%*=^"
		});

		// Token: 0x040000B5 RID: 181
		internal static readonly byte[] MixedSet;

		// Token: 0x040000B6 RID: 182
		private static readonly byte[] TextMixedAscii;

		// Token: 0x040000B7 RID: 183
		internal static string PunctuationValidChars = string.Concat(new object[]
		{
			";<>@[",
			'\\',
			"]_`~!",
			'\r',
			'\t',
			",:",
			'\n',
			"-.$/\"|*()?{}'"
		});

		// Token: 0x040000B8 RID: 184
		internal static readonly byte[] PunctuationSet;

		// Token: 0x040000B9 RID: 185
		private static readonly byte[] TextPuncutationAscii = new byte[]
		{
			59,
			60,
			62,
			64,
			91,
			92,
			93,
			95,
			96,
			126,
			33,
			13,
			9,
			44,
			58,
			10,
			45,
			46,
			36,
			47,
			34,
			124,
			42,
			40,
			41,
			63,
			123,
			125,
			39,
			0
		};
	}
}
