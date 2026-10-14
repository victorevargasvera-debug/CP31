using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000025 RID: 37
	internal class Gs1DataBarEncoder
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000104FF File Offset: 0x0000E6FF
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00010507 File Offset: 0x0000E707
		public int Segments { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00010510 File Offset: 0x0000E710
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00010518 File Offset: 0x0000E718
		public int ExpandedStackedRows
		{
			get
			{
				return this.expandedStackedRows;
			}
			private set
			{
				int num = value;
				if (num < 1)
				{
					num = 1;
				}
				if (num > 11)
				{
					num = 11;
				}
				this.expandedStackedRows = num;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000106EC File Offset: 0x0000E8EC
		public byte[][] EncodeRssExtended(string code)
		{
			byte[][] array = new byte[12][];
			int[][] array2 = new int[10][];
			int[][] array3 = array2;
			int num = 0;
			int[] array4 = new int[11];
			array4[0] = 1;
			array4[1] = -1;
			array3[num] = array4;
			array2[1] = new int[]
			{
				1,
				-2,
				2,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			array2[2] = new int[]
			{
				1,
				-3,
				2,
				-4,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			array2[3] = new int[]
			{
				1,
				-5,
				2,
				-4,
				3,
				0,
				0,
				0,
				0,
				0,
				0
			};
			array2[4] = new int[]
			{
				1,
				-5,
				2,
				-4,
				4,
				-6,
				0,
				0,
				0,
				0,
				0
			};
			array2[5] = new int[]
			{
				1,
				-5,
				2,
				-4,
				5,
				-6,
				6,
				0,
				0,
				0,
				0
			};
			array2[6] = new int[]
			{
				1,
				-1,
				2,
				-2,
				3,
				-3,
				4,
				-4,
				0,
				0,
				0
			};
			array2[7] = new int[]
			{
				1,
				-1,
				2,
				-2,
				3,
				-3,
				4,
				-5,
				5,
				0,
				0
			};
			array2[8] = new int[]
			{
				1,
				-1,
				2,
				-2,
				3,
				-3,
				4,
				-5,
				6,
				-6,
				0
			};
			array2[9] = new int[]
			{
				1,
				-1,
				2,
				-2,
				3,
				-4,
				4,
				-5,
				5,
				-6,
				6
			};
			int[][] array5 = array2;
			int num2 = 0;
			int weight = 0;
			int i;
			if ((i = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.Check2dData(code)) != 0 || (i = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.IsSymbolSepatator(code)) != 0)
			{
				string message = global::SR.GetString("InvalidCharacter").Replace("{0}", code[i].ToString()).Replace("{1}", "all ASCII characters.");
				global::System.ArgumentException ex = new global::System.ArgumentException(message);
				throw ex;
			}
			byte[] array6 = new byte[36];
			int num3 = this.Pack(code + '\0', array6);
			if (num3 < 0 || this.errorOccurred)
			{
				string @string = global::SR.GetString("EncodingError");
				global::System.ArgumentException ex2 = new global::System.ArgumentException(@string);
				throw ex2;
			}
			if ((array6[0] & 64) == 64)
			{
				byte[] array7 = array6;
				int num4 = 0;
				array7[num4] |= (byte)(((num3 + 1 & 1) << 5) + ((num3 > 13) ? 16 : 0));
			}
			if ((array6[0] & 96) == 0)
			{
				byte[] array8 = array6;
				int num5 = 0;
				array8[num5] |= (byte)(((num3 + 1 & 1) << 4) + ((num3 > 13) ? 8 : 0));
			}
			if ((array6[0] & 113) == 48)
			{
				byte[] array9 = array6;
				int num6 = 0;
				array9[num6] |= (byte)(((num3 + 1 & 1) << 1) + ((num3 > 13) ? 1 : 0));
			}
			int num7 = (num3 - 2) / 2;
			for (i = 0; i < (num3 + 2) / 2; i++)
			{
				int num8 = array5[num7][i];
				int num9 = (num8 >= 0) ? (num8 * 2) : (-num8 * 2 + 1);
				if (array[i] == null)
				{
					array[i] = new byte[42];
				}
				if (i > 0)
				{
					weight = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PairWeights[2 * (num9 - 2)];
					int val = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetVal12(array6, i * 2 - 1);
					num2 = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.SymbolCharPat(ref array[i], 0, val, num2, weight, true);
				}
				if (num8 < 0)
				{
					array[i][12] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[-num8 - 1][0];
					array[i][11] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[-num8 - 1][1];
					array[i][10] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[-num8 - 1][2];
					array[i][9] = 1;
					array[i][8] = 1;
				}
				else
				{
					array[i][8] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[num8 - 1][0];
					array[i][9] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[num8 - 1][1];
					array[i][10] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Finders[num8 - 1][2];
					array[i][11] = 1;
					array[i][12] = 1;
				}
				if (num3 > i * 2)
				{
					weight = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PairWeights[2 * (num9 - 2) + 1];
					int val = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetVal12(array6, i * 2);
					num2 = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.SymbolCharPat(ref array[i], 13, val, num2, weight, false);
				}
			}
			global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.SymbolCharPat(ref array[0], 0, (num3 - 3) * 211 + num2, 0, weight, true);
			this.Segments = num3 + 1;
			this.ExpandedStackedRows = this.Segments / 4 + ((this.Segments % 4 > 0) ? 1 : 0);
			return array;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010AB4 File Offset: 0x0000ECB4
		public static byte[] EncodeRssLimited(string code)
		{
			byte[] array = new byte[42];
			double num = double.Parse(code, global::Infragistics.CultureInfoHelper.CultureToUse);
			long num2 = (long)(num / 2013571.0);
			long num3 = num2;
			int num4 = 0;
			while (num3 >= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 5])
			{
				num3 -= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 5];
				num4 += 6;
			}
			int n = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4];
			int maxWidth = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 1];
			long num5 = num3 / global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 4];
			long value = num5;
			byte[] array2 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 7, maxWidth, true);
			int num6 = 0;
			for (int i = 0; i < 7; i++)
			{
				array[i * 2] = array2[i];
				num6 += global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.LeftWeights[i * 2] * (int)array2[i];
				num6 %= 89;
			}
			value = num3 - global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 4] * num5;
			n = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 2];
			maxWidth = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 3];
			array2 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 7, maxWidth, false);
			for (int j = 0; j < 7; j++)
			{
				array[j * 2 + 1] = array2[j];
				num6 += global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.LeftWeights[j * 2 + 1] * (int)array2[j];
				num6 %= 89;
			}
			num3 = (long)(num - (double)num2 * 2013571.0);
			num4 = 0;
			while (num3 >= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 5])
			{
				num3 -= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 5];
				num4 += 6;
			}
			n = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4];
			maxWidth = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 1];
			array2 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(num5 = num3 / global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 4], n, 7, maxWidth, true);
			for (int k = 0; k < 7; k++)
			{
				array[k * 2 + 28] = array2[k];
				num6 += global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.RightWeights[k * 2] * (int)array2[k];
				num6 %= 89;
			}
			value = num3 - global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 4] * num5;
			n = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 2];
			maxWidth = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table267[num4 + 3];
			array2 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 7, maxWidth, false);
			for (int l = 0; l < 7; l++)
			{
				array[l * 2 + 1 + 28] = array2[l];
				num6 += global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.RightWeights[l * 2 + 1] * (int)array2[l];
				num6 %= 89;
			}
			for (int m = 0; m < 14; m++)
			{
				array[14 + m] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.LimitedCheckPattern[num6 * 14 + m];
			}
			return array;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00010E90 File Offset: 0x0000F090
		public static byte[] EncodeRss14(string code)
		{
			byte[] array = new byte[42];
			int[] array2 = new int[]
			{
				10,
				7,
				5,
				2,
				4,
				336,
				8,
				5,
				7,
				4,
				20,
				700,
				6,
				3,
				9,
				6,
				48,
				480,
				4,
				1,
				11,
				8,
				81,
				81
			};
			int[] array3 = new int[]
			{
				12,
				8,
				4,
				1,
				1,
				161,
				10,
				6,
				6,
				3,
				10,
				800,
				8,
				4,
				8,
				5,
				34,
				1054,
				6,
				3,
				10,
				6,
				70,
				700,
				4,
				1,
				12,
				8,
				126,
				126
			};
			int[] array4 = new int[]
			{
				1,
				3,
				9,
				27,
				2,
				6,
				18,
				54,
				4,
				12,
				36,
				29,
				8,
				24,
				72,
				58
			};
			int[] array5 = new int[]
			{
				16,
				48,
				65,
				37,
				32,
				17,
				51,
				74,
				64,
				34,
				23,
				69,
				49,
				68,
				46,
				59
			};
			double num = double.Parse(code, global::Infragistics.CultureInfoHelper.CultureToUse);
			array[11] = 1;
			array[12] = 1;
			array[29] = 1;
			array[30] = 1;
			long num2 = (long)(num / 4537077.0);
			long num3 = num2;
			long num4 = num2 / 1597L;
			long num5 = num4;
			int num6 = 0;
			while (num4 >= (long)array3[num6 + 5])
			{
				num4 -= (long)array3[num6 + 5];
				num6 += 6;
			}
			int n = array3[num6];
			int maxWidth = array3[num6 + 1];
			long num7 = num4 / (long)array3[num6 + 4];
			long value = num7;
			byte[] array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, true);
			int num8 = 0;
			for (int i = 0; i < 4; i++)
			{
				array[i * 2] = array6[i];
				num8 += array4[i * 2] * (int)array6[i];
				num8 %= 79;
			}
			value = num4 - (long)array3[num6 + 4] * num7;
			n = array3[num6 + 2];
			maxWidth = array3[num6 + 3];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, false);
			for (int j = 0; j < 4; j++)
			{
				array[1 + j * 2] = array6[j];
				num8 += array4[j * 2 + 1] * (int)array6[j];
				num8 %= 79;
			}
			num4 = num2 - num5 * 1597L;
			num6 = 0;
			while (num4 >= (long)array2[num6 + 5])
			{
				num4 -= (long)array2[num6 + 5];
				num6 += 6;
			}
			n = array2[num6];
			maxWidth = array2[num6 + 1];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(num7 = num4 / (long)array2[num6 + 4], n, 4, maxWidth, true);
			for (int k = 0; k < 4; k++)
			{
				array[19 - k * 2] = array6[k];
				num8 += array4[k * 2 + 1 + 8] * (int)array6[k];
				num8 %= 79;
			}
			value = num4 - (long)array2[num6 + 4] * num7;
			n = array2[num6 + 2];
			maxWidth = array2[num6 + 3];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, false);
			for (int l = 0; l < 4; l++)
			{
				array[20 - l * 2] = array6[l];
				num8 += array4[l * 2 + 8] * (int)array6[l];
				num8 %= 79;
			}
			num2 = (long)(num - (double)num3 * 4537077.0);
			num5 = (num4 = num2 / 1597L);
			num6 = 0;
			while (num4 >= (long)array3[num6 + 5])
			{
				num4 -= (long)array3[num6 + 5];
				num6 += 6;
			}
			n = array3[num6];
			maxWidth = array3[num6 + 1];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(num7 = num4 / (long)array3[num6 + 4], n, 4, maxWidth, true);
			for (int m = 0; m < 4; m++)
			{
				array[41 - m * 2] = array6[m];
				num8 += array5[m * 2] * (int)array6[m];
				num8 %= 79;
			}
			value = num4 - (long)array3[num6 + 4] * num7;
			n = array3[num6 + 2];
			maxWidth = array3[num6 + 3];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, false);
			for (int num9 = 0; num9 < 4; num9++)
			{
				array[40 - num9 * 2] = array6[num9];
				num8 += array5[num9 * 2 + 1] * (int)array6[num9];
				num8 %= 79;
			}
			num4 = num2 - num5 * 1597L;
			num6 = 0;
			while (num4 >= (long)array2[num6 + 5])
			{
				num4 -= (long)array2[num6 + 5];
				num6 += 6;
			}
			n = array2[num6];
			maxWidth = array2[num6 + 1];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(num7 = num4 / (long)array2[num6 + 4], n, 4, maxWidth, true);
			for (int num10 = 0; num10 < 4; num10++)
			{
				array[22 + num10 * 2] = array6[num10];
				num8 += array5[num10 * 2 + 1 + 8] * (int)array6[num10];
				num8 %= 79;
			}
			value = num4 - (long)array2[num6 + 4] * num7;
			n = array2[num6 + 2];
			maxWidth = array2[num6 + 3];
			array6 = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, false);
			for (int num11 = 0; num11 < 4; num11++)
			{
				array[21 + num11 * 2] = array6[num11];
				num8 += array5[num11 * 2 + 8] * (int)array6[num11];
				num8 %= 79;
			}
			if (num8 >= 8)
			{
				num8++;
			}
			if (num8 >= 72)
			{
				num8++;
			}
			int num12 = num8 / 9;
			int num13 = num8 % 9;
			for (int num14 = 0; num14 < 3; num14++)
			{
				array[8 + num14] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.LeftParity[num12 * 3 + num14];
			}
			for (int num15 = 0; num15 < 3; num15++)
			{
				array[33 - num15] = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.LeftParity[num13 * 3 + num15];
			}
			return array;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00011394 File Offset: 0x0000F594
		private static int SymbolCharPat(ref byte[] bars, int index, int symValue, int parity, int weight, bool forwardFlag)
		{
			int num = weight;
			int num2 = weight * 3 % 211;
			int num3 = 0;
			while (symValue >= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 5])
			{
				symValue -= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 5];
				num3 += 6;
			}
			int n = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3];
			int maxWidth = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 1];
			int num4 = symValue / global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 4];
			long value = (long)num4;
			byte[] array = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, false);
			for (int i = 0; i < 4; i++)
			{
				if (forwardFlag)
				{
					bars[index + i * 2] = array[i];
				}
				else
				{
					bars[index + 7 - i * 2] = array[i];
				}
				parity += num * (int)array[i];
				parity %= 211;
				num = num * 9 % 211;
			}
			value = (long)(symValue - global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 4] * num4);
			n = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 2];
			maxWidth = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.Table174[num3 + 3];
			array = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.CalculateBarsWidths(value, n, 4, maxWidth, true);
			for (int j = 0; j < 4; j++)
			{
				if (forwardFlag)
				{
					bars[index + 1 + j * 2] = array[j];
				}
				else
				{
					bars[index + 6 - j * 2] = array[j];
				}
				parity += num2 * (int)array[j];
				parity %= 211;
				num2 = num2 * 9 % 211;
			}
			return parity;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000114E0 File Offset: 0x0000F6E0
		private static int GetVal12(byte[] bitString, int symIndex)
		{
			int num = symIndex * 3 / 2;
			int num2;
			if (symIndex % 2 == 1)
			{
				num2 = (int)(bitString[num] & 15);
				num2 = (num2 << 8) + (int)bitString[num + 1];
			}
			else
			{
				num2 = (int)bitString[num];
				num2 = (num2 << 4) + (bitString[num + 1] >> 4);
			}
			return num2;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00011520 File Offset: 0x0000F720
		internal static int IsSymbolSepatator(string text)
		{
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '^')
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001154C File Offset: 0x0000F74C
		private int Pack(string code, byte[] bitField)
		{
			global::Infragistics.Controls.Barcodes.EncodeT encodeT = new global::Infragistics.Controls.Barcodes.EncodeT();
			encodeT.Data = code;
			encodeT.BitField = bitField;
			encodeT.DataIndex = (encodeT.BitIndex = 0);
			encodeT.BitIndex++;
			encodeT.Mode = this.DoLinMethods(encodeT.Data, ref encodeT.DataIndex, ref encodeT.BitField, ref encodeT.BitIndex);
			while (encodeT.Mode != global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Fini && !this.errorOccurred)
			{
				switch (encodeT.Mode)
				{
				case global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num:
					encodeT.Mode = this.ProcNum(ref encodeT);
					break;
				case global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Alnu:
					encodeT.Mode = this.ProcAlnu(ref encodeT);
					break;
				case global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Iso:
					encodeT.Mode = this.ProcIso(ref encodeT);
					break;
				default:
					return -1;
				}
			}
			return this.InsertPad(ref encodeT);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001161C File Offset: 0x0000F81C
		private int InsertPad(ref global::Infragistics.Controls.Barcodes.EncodeT encode)
		{
			int result = 0;
			int i = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetUnusedBitCnt(encode.BitIndex, ref result);
			if (i < 0)
			{
				return -1;
			}
			while (i >= 5)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, 4);
				encode.BitIndex += 5;
				i -= 5;
			}
			if (i > 0)
			{
				int bits = 4 >> 5 - i;
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, i, bits);
				encode.BitIndex += i;
			}
			return result;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000116B8 File Offset: 0x0000F8B8
		private global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode ProcIso(ref global::Infragistics.Controls.Barcodes.EncodeT encode)
		{
			int num = (int)encode.Data[encode.DataIndex];
			int num2 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[num];
			if (num2 == 128)
			{
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Fini;
			}
			int num3 = 0;
			if ((num2 & 4) != 0 && (num2 & 2) == 0)
			{
				if ((num2 & 1) != 0)
				{
					num3 = 1;
				}
				int i = 1;
				while (i < 10)
				{
					int num4 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[(int)encode.Data[encode.DataIndex + i]];
					if (num4 == 128)
					{
						if (num3 >= 4 || num3 <= -4)
						{
							this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 3, 0);
							encode.BitIndex += 3;
							return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
						}
						if (i >= 5)
						{
							this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, 4);
							encode.BitIndex += 5;
							return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Alnu;
						}
						break;
					}
					else
					{
						if ((num4 & 1) != 0)
						{
							if (num3 > 0)
							{
								num3++;
							}
						}
						else if (num3 > 0)
						{
							num3 = -num3;
						}
						if ((num4 & 4) == 0)
						{
							break;
						}
						i++;
					}
				}
				if (i == 10)
				{
					if (num3 >= 4 || num3 <= -4)
					{
						this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 3, 0);
						encode.BitIndex += 3;
						return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
					}
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, 4);
					encode.BitIndex += 5;
					return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Alnu;
				}
			}
			encode.DataIndex++;
			if ((num2 & 1) != 0)
			{
				if ((num2 & 2) != 0)
				{
					num = 15;
					encode.Mode = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
				}
				else
				{
					num = num - 48 + 5;
				}
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, num);
				encode.BitIndex += 5;
			}
			else if (num >= 65 && num <= 90)
			{
				num = num - 65 + 64;
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 7, num);
				encode.BitIndex += 7;
			}
			else if (num >= 97 && num <= 122)
			{
				num = num - 97 + 90;
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 7, num);
				encode.BitIndex += 7;
			}
			else
			{
				if (num == 32)
				{
					num = 252;
				}
				else if (num == 94)
				{
					num = 253;
					encode.Mode = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
				}
				else if (num == 95)
				{
					num = 251;
				}
				else if (num >= 58)
				{
					num = num - 58 + 245;
				}
				else if (num >= 37)
				{
					num = num - 37 + 234;
				}
				else
				{
					num = num - 33 + 232;
				}
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 8, num);
				encode.BitIndex += 8;
			}
			return encode.Mode;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000119CC File Offset: 0x0000FBCC
		private global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode ProcAlnu(ref global::Infragistics.Controls.Barcodes.EncodeT encode)
		{
			int num = (int)encode.Data[encode.DataIndex];
			int num2 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[num];
			if (num2 == 128)
			{
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Fini;
			}
			if ((num2 & 4) == 0)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, 4);
				encode.BitIndex += 5;
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Iso;
			}
			if ((num2 & 1) != 0 && ((num2 | (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[(int)encode.Data[encode.DataIndex + 1]]) & 2) == 0)
			{
				int i = 1;
				while (i < 6)
				{
					int num3 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[(int)encode.Data[encode.DataIndex + i]];
					if (num3 == 128)
					{
						if (i >= 4)
						{
							this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 3, 0);
							encode.BitIndex += 3;
							return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
						}
						break;
					}
					else
					{
						if ((num3 & 1) == 0)
						{
							break;
						}
						i++;
					}
				}
				if (i == 6)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 3, 0);
					encode.BitIndex += 3;
					return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
				}
			}
			encode.DataIndex++;
			if ((num2 & 1) != 0)
			{
				if ((num2 & 2) != 0)
				{
					num = 15;
					encode.Mode = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
				}
				else
				{
					num = num - 48 + 5;
				}
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 5, num);
				encode.BitIndex += 5;
			}
			else
			{
				if (num == 94)
				{
					num = 31;
					encode.Mode = global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
				}
				else if (num >= 65)
				{
					num -= 65;
				}
				else if (num >= 44)
				{
					num = num - 44 + 27;
				}
				else
				{
					num = 26;
				}
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 6, num + 32);
				encode.BitIndex += 6;
			}
			return encode.Mode;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		private global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode ProcNum(ref global::Infragistics.Controls.Barcodes.EncodeT encode)
		{
			int num = 0;
			int num2 = (int)encode.Data[encode.DataIndex];
			int num3 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[num2];
			if (num3 == 128 || encode.DataIndex == encode.Data.Length - 1)
			{
				int num4 = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetUnusedBitCnt(encode.BitIndex, ref num);
				if (num4 > 4)
				{
					num4 = 4;
				}
				if (num4 > 0)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, num4, 0);
					encode.BitIndex += num4;
				}
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Fini;
			}
			if ((num3 & 1) == 0)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 4, 0);
				encode.BitIndex += 4;
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Alnu;
			}
			int num5 = (int)encode.Data[encode.DataIndex + 1];
			int num6 = (int)global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[num5];
			if (num6 == 128 && (num3 & 2) == 0)
			{
				encode.DataIndex++;
				int num4 = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetUnusedBitCnt(encode.BitIndex, ref num);
				if (num4 >= 4 && num4 < 7)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 4, num2 + 1 - 48);
					num4 -= 4;
					if (num4 > 0)
					{
						this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex + 4, num4, 0);
					}
					encode.BitIndex += 4 + num4;
				}
				else
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 7, (num2 - 48) * 11 + 10 + 8);
					encode.BitIndex += 7;
					num4 -= 7;
					if (num4 > 4 || num4 < 0)
					{
						num4 = 4;
					}
					if (num4 > 0)
					{
						this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, num4, 0);
						encode.BitIndex += num4;
					}
				}
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Fini;
			}
			if ((num3 & num6 & 2) != 0 || (num6 & 1) == 0)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 4, 0);
				encode.BitIndex += 4;
				return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Alnu;
			}
			encode.DataIndex += 2;
			if ((num3 & 2) != 0)
			{
				num2 = 10;
			}
			else
			{
				num2 -= 48;
			}
			if ((num6 & 2) != 0)
			{
				num5 = 10;
			}
			else
			{
				num5 -= 48;
			}
			this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref encode.BitField, encode.BitIndex, 7, num2 * 11 + num5 + 8);
			encode.BitIndex += 7;
			return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00011E90 File Offset: 0x00010090
		private static int GetUnusedBitCnt(int iBit, ref int size)
		{
			size = 0;
			if (iBit <= 252)
			{
				if ((size = (iBit + 11) / 12) < 3)
				{
					size = 3;
				}
				if ((size + 1 + 22) % 22 == 1)
				{
					size++;
				}
				return size * 12 - iBit;
			}
			return -1;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00011ED8 File Offset: 0x000100D8
		private global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode DoLinMethods(string code, ref int iStr, ref byte[] bitField, ref int iBit)
		{
			string text = string.Empty;
			if (code.Length >= 26)
			{
				text = code.Substring(20, 6) + '\0';
			}
			if (code.Length >= 16 && code.StartsWith("01", global::System.StringComparison.CurrentCultureIgnoreCase))
			{
				long num = long.Parse(string.IsNullOrEmpty(text) ? "0" : text, global::Infragistics.CultureInfoHelper.CultureToUse);
				if (code[2] == '9' && code.Length == 26 && code[16] == '3' && code[17] == '1' && code[18] == '0' && code[19] == '3' && num <= 32767L)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, 4);
					iBit += 4;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 15, (int)num);
					iBit += 15;
					iStr += 11;
				}
				else if (code[2] == '9' && code.Length == 26 && code[16] == '3' && code[17] == '2' && code[18] == '0' && code[19] == '2' && num <= 9999L)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, 5);
					iBit += 4;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 15, (int)num);
					iBit += 15;
					iStr += 11;
				}
				else if (code[2] == '9' && code.Length == 26 && code[16] == '3' && code[17] == '2' && code[18] == '0' && code[19] == '3' && num <= 22767L)
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, 5);
					iBit += 4;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 15, (int)num + 10000);
					iBit += 15;
					iStr += 11;
				}
				else if (code[2] == '9' && code.Length >= 21 && code[16] == '3' && code[17] == '9' && code[18] == '2' && code[19] >= '0' && code[19] <= '3')
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 7, 48);
					iBit += 7;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 2, (int)(code[19] - '0'));
					iBit += 2;
					iStr += 5;
				}
				else if (code[2] == '9' && code.Length >= 24 && code[16] == '3' && code[17] == '9' && code[18] == '3' && code[19] >= '0' && code[19] <= '3')
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 7, 52);
					iBit += 7;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 2, (int)(code[19] - '0'));
					iBit += 2;
					iStr += 5;
					text = code.Substring(20, 3) + '\0';
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 10, int.Parse(text.ToString(global::Infragistics.CultureInfoHelper.CultureToUse), global::Infragistics.CultureInfoHelper.CultureToUse));
					iBit += 10;
					iStr += 3;
				}
				else if (code[2] == '9' && code.Length == 26 && code[16] == '3' && (code[17] == '1' || code[17] == '2') && code[18] == '0' && num <= 99999L)
				{
					int bits = (int)('8' + (code[17] - '1'));
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 7, bits);
					iBit += 7;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					num += (long)(code[19] - '0') * 100000L;
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, (int)(num >> 16));
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit + 4, 16, (int)(num & 65535L));
					iBit += 20;
					iStr += 11;
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 16, 38400);
					iBit += 16;
				}
				else if (code[2] == '9' && code.Length == 34 && code[16] == '3' && (code[17] == '1' || code[17] == '2') && code[18] == '0' && num <= 99999L && code[26] == '1' && (code[27] == '1' || code[27] == '3' || code[27] == '5' || code[27] == '7'))
				{
					int bits2 = (int)('8' + (code[27] - '1') + (code[17] - '1'));
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 7, bits2);
					iBit += 7;
					iStr += 3;
					this.Convert12To40Bits(code, ref iStr, ref bitField, ref iBit);
					num += (long)(code[19] - '0') * 100000L;
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, (int)(num >> 16));
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit + 4, 16, (int)(num & 65535L));
					iBit += 20;
					iStr += 11;
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 16, global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.GetIntOfDate(code, iStr + 2));
					iBit += 16;
					iStr += 8;
				}
				else
				{
					this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 3, 4);
					iBit += 3;
					iStr += 2;
					this.Convert13To44Bits(code, ref iStr, ref bitField, ref iBit);
					iStr++;
				}
			}
			else
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, 0);
				iBit += 4;
			}
			return global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithmMode.Num;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00012650 File Offset: 0x00010850
		private static int GetIntOfDate(string str, int index)
		{
			int num = (int)(((str[index] - '0') * '\n' + (str[index + 1] - '0')) * 'ƀ');
			num += (int)(((str[index + 2] - '0') * '\n' + (str[index + 3] - '0') - '\u0001') * ' ');
			return num + (int)((str[index + 4] - '0') * '\n' + (str[index + 5] - '0'));
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000126C4 File Offset: 0x000108C4
		private void Convert12To40Bits(string code, ref int iStr, ref byte[] bitField, ref int iBit)
		{
			for (int i = 0; i < 4; i++)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 10, (int)((code[iStr] - '0') * 'd' + (code[iStr + 1] - '0') * '\n' + code[iStr + 2] - '0'));
				iBit += 10;
				iStr += 3;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00012730 File Offset: 0x00010930
		private void Convert13To44Bits(string str, ref int iStr, ref byte[] bitField, ref int iBit)
		{
			this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 4, (int)(str[iStr] - '0'));
			iBit += 4;
			iStr++;
			for (int i = 0; i < 4; i++)
			{
				this.errorOccurred |= global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.PutBits(ref bitField, iBit, 10, (int)((str[iStr] - '0') * 'd' + (str[iStr + 1] - '0') * '\n' + str[iStr + 2] - '0'));
				iBit += 10;
				iStr += 3;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000127CC File Offset: 0x000109CC
		private static int Check2dData(string dataStr)
		{
			int num = 0;
			while (num < dataStr.Length && global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[(int)dataStr[num]] != 128)
			{
				if (global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.IsWhat[(int)dataStr[num]] == 0)
				{
					return num;
				}
				num++;
			}
			return 0;
		}

		// Token: 0x04000103 RID: 259
		private const int SegmentsPerRow = 4;

		// Token: 0x04000104 RID: 260
		private bool errorOccurred;

		// Token: 0x04000105 RID: 261
		private int expandedStackedRows = 1;
	}
}
