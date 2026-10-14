using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200001B RID: 27
	internal class RoyalMailAlgorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000D61C File Offset: 0x0000B81C
		static RoyalMailAlgorithm()
		{
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['0'] = 11;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['1'] = 12;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['2'] = 13;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['3'] = 14;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['4'] = 15;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['5'] = 10;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['6'] = 21;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['7'] = 22;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['8'] = 23;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['9'] = 24;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['A'] = 25;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['B'] = 20;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['C'] = 31;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['D'] = 32;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['E'] = 33;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['F'] = 34;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['G'] = 35;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['H'] = 30;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['I'] = 41;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['J'] = 42;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['K'] = 43;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['L'] = 44;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['M'] = 45;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['N'] = 40;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['O'] = 51;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['P'] = 52;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['Q'] = 53;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['R'] = 54;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['S'] = 55;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['T'] = 50;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['U'] = 1;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['V'] = 2;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['W'] = 3;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['X'] = 4;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['Y'] = 5;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable['Z'] = 0;
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars = new global::System.Collections.Generic.Dictionary<char, byte[]>();
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['0'] = new byte[]
			{
				1,
				1,
				4,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['1'] = new byte[]
			{
				1,
				3,
				2,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['2'] = new byte[]
			{
				1,
				3,
				4,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['3'] = new byte[]
			{
				3,
				1,
				2,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['4'] = new byte[]
			{
				3,
				1,
				4,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['5'] = new byte[]
			{
				3,
				3,
				2,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['6'] = new byte[]
			{
				1,
				2,
				3,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['7'] = new byte[]
			{
				1,
				4,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['8'] = new byte[]
			{
				1,
				4,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['9'] = new byte[]
			{
				3,
				2,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['A'] = new byte[]
			{
				3,
				2,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['B'] = new byte[]
			{
				3,
				4,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['C'] = new byte[]
			{
				1,
				2,
				4,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['D'] = new byte[]
			{
				1,
				4,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['E'] = new byte[]
			{
				1,
				4,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['F'] = new byte[]
			{
				3,
				2,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['G'] = new byte[]
			{
				3,
				2,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['H'] = new byte[]
			{
				3,
				4,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['I'] = new byte[]
			{
				2,
				1,
				3,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['J'] = new byte[]
			{
				2,
				3,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['K'] = new byte[]
			{
				2,
				3,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['L'] = new byte[]
			{
				4,
				1,
				1,
				4
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['M'] = new byte[]
			{
				4,
				1,
				3,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['N'] = new byte[]
			{
				4,
				3,
				1,
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['O'] = new byte[]
			{
				2,
				1,
				4,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['P'] = new byte[]
			{
				2,
				3,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['Q'] = new byte[]
			{
				2,
				3,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['R'] = new byte[]
			{
				4,
				1,
				2,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['S'] = new byte[]
			{
				4,
				1,
				4,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['T'] = new byte[]
			{
				4,
				3,
				2,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['U'] = new byte[]
			{
				2,
				2,
				3,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['V'] = new byte[]
			{
				2,
				4,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['W'] = new byte[]
			{
				2,
				4,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['X'] = new byte[]
			{
				4,
				2,
				1,
				3
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['Y'] = new byte[]
			{
				4,
				2,
				3,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['Z'] = new byte[]
			{
				4,
				4,
				1,
				1
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['('] = new byte[]
			{
				2
			};
			global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars[')'] = new byte[]
			{
				4
			};
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000DC74 File Offset: 0x0000BE74
		public static char GenerateCheckSum(string code)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < code.Length; i++)
			{
				num += global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.GetRow(code[i]);
				num2 += global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.GetCol(code[i]);
			}
			num %= 6;
			num2 %= 6;
			return global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.GetCheckSum(num * 10 + num2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		private static char GetCheckSum(int p)
		{
			for (int i = 0; i < "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length; i++)
			{
				if (global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable["0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i]] == p)
				{
					return "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i];
				}
			}
			return ' ';
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000DD10 File Offset: 0x0000BF10
		private static int GetRow(char p)
		{
			return global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable[p] / 10;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000DD20 File Offset: 0x0000BF20
		private static int GetCol(char p)
		{
			return global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.ErrorCheckTable[p] % 10;
		}

		// Token: 0x040000DF RID: 223
		public const string ValidRoyalMailChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		// Token: 0x040000E0 RID: 224
		public const int TopQuietZone = 1;

		// Token: 0x040000E1 RID: 225
		public const int BottomQuietZone = 1;

		// Token: 0x040000E2 RID: 226
		private static readonly global::System.Collections.Generic.Dictionary<char, int> ErrorCheckTable = new global::System.Collections.Generic.Dictionary<char, int>();

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Collections.Generic.Dictionary<char, byte[]> RoyalMailChars;
	}
}
