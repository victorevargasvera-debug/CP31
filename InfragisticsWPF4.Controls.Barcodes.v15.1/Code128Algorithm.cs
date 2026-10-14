using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000006 RID: 6
	internal class Code128Algorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003168 File Offset: 0x00001368
		static Code128Algorithm()
		{
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[0] = new byte[]
			{
				2,
				1,
				2,
				2,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[1] = new byte[]
			{
				2,
				2,
				2,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[2] = new byte[]
			{
				2,
				2,
				2,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[3] = new byte[]
			{
				1,
				2,
				1,
				2,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[4] = new byte[]
			{
				1,
				2,
				1,
				3,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[5] = new byte[]
			{
				1,
				3,
				1,
				2,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[6] = new byte[]
			{
				1,
				2,
				2,
				2,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[7] = new byte[]
			{
				1,
				2,
				2,
				3,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[8] = new byte[]
			{
				1,
				3,
				2,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[9] = new byte[]
			{
				2,
				2,
				1,
				2,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[10] = new byte[]
			{
				2,
				2,
				1,
				3,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[11] = new byte[]
			{
				2,
				3,
				1,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[12] = new byte[]
			{
				1,
				1,
				2,
				2,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[13] = new byte[]
			{
				1,
				2,
				2,
				1,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[14] = new byte[]
			{
				1,
				2,
				2,
				2,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[15] = new byte[]
			{
				1,
				1,
				3,
				2,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[16] = new byte[]
			{
				1,
				2,
				3,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[17] = new byte[]
			{
				1,
				2,
				3,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[18] = new byte[]
			{
				2,
				2,
				3,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[19] = new byte[]
			{
				2,
				2,
				1,
				1,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[20] = new byte[]
			{
				2,
				2,
				1,
				2,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[21] = new byte[]
			{
				2,
				1,
				3,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[22] = new byte[]
			{
				2,
				2,
				3,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[23] = new byte[]
			{
				3,
				1,
				2,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[24] = new byte[]
			{
				3,
				1,
				1,
				2,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[25] = new byte[]
			{
				3,
				2,
				1,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[26] = new byte[]
			{
				3,
				2,
				1,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[27] = new byte[]
			{
				3,
				1,
				2,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[28] = new byte[]
			{
				3,
				2,
				2,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[29] = new byte[]
			{
				3,
				2,
				2,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[30] = new byte[]
			{
				2,
				1,
				2,
				1,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[31] = new byte[]
			{
				2,
				1,
				2,
				3,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[32] = new byte[]
			{
				2,
				3,
				2,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[33] = new byte[]
			{
				1,
				1,
				1,
				3,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[34] = new byte[]
			{
				1,
				3,
				1,
				1,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[35] = new byte[]
			{
				1,
				3,
				1,
				3,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[36] = new byte[]
			{
				1,
				1,
				2,
				3,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[37] = new byte[]
			{
				1,
				3,
				2,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[38] = new byte[]
			{
				1,
				3,
				2,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[39] = new byte[]
			{
				2,
				1,
				1,
				3,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[40] = new byte[]
			{
				2,
				3,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[41] = new byte[]
			{
				2,
				3,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[42] = new byte[]
			{
				1,
				1,
				2,
				1,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[43] = new byte[]
			{
				1,
				1,
				2,
				3,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[44] = new byte[]
			{
				1,
				3,
				2,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[45] = new byte[]
			{
				1,
				1,
				3,
				1,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[46] = new byte[]
			{
				1,
				1,
				3,
				3,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[47] = new byte[]
			{
				1,
				3,
				3,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[48] = new byte[]
			{
				3,
				1,
				3,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[49] = new byte[]
			{
				2,
				1,
				1,
				3,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[50] = new byte[]
			{
				2,
				3,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[51] = new byte[]
			{
				2,
				1,
				3,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[52] = new byte[]
			{
				2,
				1,
				3,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[53] = new byte[]
			{
				2,
				1,
				3,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[54] = new byte[]
			{
				3,
				1,
				1,
				1,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[55] = new byte[]
			{
				3,
				1,
				1,
				3,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[56] = new byte[]
			{
				3,
				3,
				1,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[57] = new byte[]
			{
				3,
				1,
				2,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[58] = new byte[]
			{
				3,
				1,
				2,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[59] = new byte[]
			{
				3,
				3,
				2,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[60] = new byte[]
			{
				3,
				1,
				4,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[61] = new byte[]
			{
				2,
				2,
				1,
				4,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[62] = new byte[]
			{
				4,
				3,
				1,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[63] = new byte[]
			{
				1,
				1,
				1,
				2,
				2,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[64] = new byte[]
			{
				1,
				1,
				1,
				4,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[65] = new byte[]
			{
				1,
				2,
				1,
				1,
				2,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[66] = new byte[]
			{
				1,
				2,
				1,
				4,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[67] = new byte[]
			{
				1,
				4,
				1,
				1,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[68] = new byte[]
			{
				1,
				4,
				1,
				2,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[69] = new byte[]
			{
				1,
				1,
				2,
				2,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[70] = new byte[]
			{
				1,
				1,
				2,
				4,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[71] = new byte[]
			{
				1,
				2,
				2,
				1,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[72] = new byte[]
			{
				1,
				2,
				2,
				4,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[73] = new byte[]
			{
				1,
				4,
				2,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[74] = new byte[]
			{
				1,
				4,
				2,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[75] = new byte[]
			{
				2,
				4,
				1,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[76] = new byte[]
			{
				2,
				2,
				1,
				1,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[77] = new byte[]
			{
				4,
				1,
				3,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[78] = new byte[]
			{
				2,
				4,
				1,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[79] = new byte[]
			{
				1,
				3,
				4,
				1,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[80] = new byte[]
			{
				1,
				1,
				1,
				2,
				4,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[81] = new byte[]
			{
				1,
				2,
				1,
				1,
				4,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[82] = new byte[]
			{
				1,
				2,
				1,
				2,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[83] = new byte[]
			{
				1,
				1,
				4,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[84] = new byte[]
			{
				1,
				2,
				4,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[85] = new byte[]
			{
				1,
				2,
				4,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[86] = new byte[]
			{
				4,
				1,
				1,
				2,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[87] = new byte[]
			{
				4,
				2,
				1,
				1,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[88] = new byte[]
			{
				4,
				2,
				1,
				2,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[89] = new byte[]
			{
				2,
				1,
				2,
				1,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[90] = new byte[]
			{
				2,
				1,
				4,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[91] = new byte[]
			{
				4,
				1,
				2,
				1,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[92] = new byte[]
			{
				1,
				1,
				1,
				1,
				4,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[93] = new byte[]
			{
				1,
				1,
				1,
				3,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[94] = new byte[]
			{
				1,
				3,
				1,
				1,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[95] = new byte[]
			{
				1,
				1,
				4,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[96] = new byte[]
			{
				1,
				1,
				4,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[97] = new byte[]
			{
				4,
				1,
				1,
				1,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[98] = new byte[]
			{
				4,
				1,
				1,
				3,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[99] = new byte[]
			{
				1,
				1,
				3,
				1,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[100] = new byte[]
			{
				1,
				1,
				4,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[101] = new byte[]
			{
				3,
				1,
				1,
				1,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[102] = new byte[]
			{
				4,
				1,
				1,
				1,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[103] = new byte[]
			{
				2,
				1,
				1,
				4,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[104] = new byte[]
			{
				2,
				1,
				1,
				2,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[105] = new byte[]
			{
				2,
				1,
				1,
				2,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.Code128Algorithm.StopChar = new byte[]
			{
				2,
				3,
				3,
				1,
				1,
				1,
				2
			};
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003D90 File Offset: 0x00001F90
		public static char GenerateCheckDigit(string code)
		{
			int num = (int)code[0];
			for (int i = 1; i < code.Length; i++)
			{
				num += i * (int)code[i];
			}
			num %= 103;
			return (char)num;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003DCC File Offset: 0x00001FCC
		internal static char ConvertToAscii(char s, char codeSet)
		{
			switch (codeSet)
			{
			case 'g':
				if (s < ' ')
				{
					return s + '@';
				}
				return s - ' ';
			}
			return s - ' ';
		}

		// Token: 0x04000010 RID: 16
		internal const char Shift = 'b';

		// Token: 0x04000011 RID: 17
		internal const char CodeABtoC = 'c';

		// Token: 0x04000012 RID: 18
		internal const char CodeACtoB = 'd';

		// Token: 0x04000013 RID: 19
		internal const char CodeBCtoA = 'e';

		// Token: 0x04000014 RID: 20
		internal const char Fnc1Index = 'f';

		// Token: 0x04000015 RID: 21
		internal const char StartA = 'g';

		// Token: 0x04000016 RID: 22
		internal const char StartB = 'h';

		// Token: 0x04000017 RID: 23
		internal const char StartC = 'i';

		// Token: 0x04000018 RID: 24
		internal const char Fnc1 = 'Ê';

		// Token: 0x04000019 RID: 25
		public const int MaxNumberEncodedChars = 48;

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Collections.Generic.Dictionary<int, byte[]> Code128Chars = new global::System.Collections.Generic.Dictionary<int, byte[]>();

		// Token: 0x0400001B RID: 27
		public static readonly byte[] StopChar;
	}
}
