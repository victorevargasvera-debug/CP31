using System;
using System.IO;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200000E RID: 14
	internal class QRReedSolomon : global::Infragistics.Controls.Barcodes.ReedSolomon
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000054AF File Offset: 0x000036AF
		public QRReedSolomon()
		{
			this.gf256 = new global::Infragistics.Controls.Barcodes.Gf256(285);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000054C8 File Offset: 0x000036C8
		public int[] GenerateErrorCorrectionCodewords(int[] codewords, int rsEccCodewords, int[] rsBlockOrder, int maxDataCodewords, int maxCodewords)
		{
			byte[][] array = global::Infragistics.Controls.Barcodes.QRReedSolomon.SetPolinomial(rsEccCodewords);
			if (array == null)
			{
				return null;
			}
			int i = 0;
			int j = 0;
			byte[][] array2 = new byte[rsBlockOrder.Length][];
			for (int k = 0; k < rsBlockOrder.Length; k++)
			{
				array2[k] = new byte[(rsBlockOrder[k] & 255) - rsEccCodewords];
			}
			for (int k = 0; k < maxDataCodewords; k++)
			{
				array2[j][i] = (byte)codewords[k];
				i++;
				if (i >= (rsBlockOrder[j] & 255) - rsEccCodewords)
				{
					i = 0;
					j++;
				}
			}
			j = 0;
			byte[][] array3 = new byte[rsBlockOrder.Length][];
			while (j < rsBlockOrder.Length)
			{
				byte[] array4 = new byte[array2[j].Length];
				global::System.Array.Copy(array2[j], 0, array4, 0, array2[j].Length);
				int num = rsBlockOrder[j] & 255;
				int num2 = num - rsEccCodewords;
				for (i = num2; i > 0; i--)
				{
					byte b = array4[0];
					if (b != 0)
					{
						byte[] array5 = new byte[array4.Length - 1];
						global::System.Array.Copy(array4, 1, array5, 0, array4.Length - 1);
						byte[] xb = array[(int)(b & byte.MaxValue)];
						array4 = global::Infragistics.Controls.Barcodes.GfArithmetics.CalculateSumOfBits(array5, xb);
					}
					else if (rsEccCodewords < array4.Length)
					{
						byte[] array6 = new byte[array4.Length - 1];
						global::System.Array.Copy(array4, 1, array6, 0, array4.Length - 1);
						array4 = new byte[array6.Length];
						global::System.Array.Copy(array6, 0, array4, 0, array6.Length);
					}
					else
					{
						byte[] array7 = new byte[rsEccCodewords];
						global::System.Array.Copy(array4, 1, array7, 0, array4.Length - 1);
						array7[rsEccCodewords - 1] = 0;
						array4 = new byte[array7.Length];
						global::System.Array.Copy(array7, 0, array4, 0, array7.Length);
					}
				}
				array3[j] = array4;
				j++;
			}
			return global::Infragistics.Controls.Barcodes.QRReedSolomon.AssembleDataAndErrorCorrectionBytes(array2, array3, rsBlockOrder, maxDataCodewords, maxCodewords);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005678 File Offset: 0x00003878
		internal static byte[][] DisassembleDataBlocksCodewords(byte[] codewords, byte[] blocksOrder, byte eccNumberPerBlock, out int[] dataCodewordsPerBlock)
		{
			byte[][] array = new byte[blocksOrder.Length][];
			dataCodewordsPerBlock = new int[blocksOrder.Length];
			for (int i = 0; i < blocksOrder.Length; i++)
			{
				array[i] = new byte[(int)blocksOrder[i]];
			}
			int num = (int)blocksOrder[0];
			int num2 = blocksOrder.Length;
			while (num2 > 0 && (int)blocksOrder[num2 - 1] != num)
			{
				num2--;
			}
			int num3 = num - (int)eccNumberPerBlock;
			int num4 = 0;
			for (int j = 0; j < num3; j++)
			{
				for (int k = 0; k < blocksOrder.Length; k++)
				{
					array[k][j] = codewords[num4++];
				}
			}
			for (int l = 0; l < num2; l++)
			{
				dataCodewordsPerBlock[l] = num3;
			}
			for (int m = num2; m < blocksOrder.Length; m++)
			{
				array[m][num3] = codewords[num4++];
				dataCodewordsPerBlock[m] = num3 + 1;
			}
			for (int n = num3; n < array[0].Length; n++)
			{
				for (int num5 = 0; num5 < blocksOrder.Length; num5++)
				{
					int num6 = (num5 < num2) ? n : (n + 1);
					array[num5][num6] = codewords[num4++];
				}
			}
			return array;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005790 File Offset: 0x00003990
		internal bool CorrectBlockDataBytes(byte[] blockDataBytes, int eccNumber)
		{
			int[] array = new int[eccNumber];
			bool flag = false;
			int[] array2 = new int[blockDataBytes.Length];
			int num = 0;
			foreach (byte b in blockDataBytes)
			{
				array2[num++] = (int)b;
			}
			for (int j = 0; j < eccNumber; j++)
			{
				int num2 = this.gf256.CalculatePolynomialAt(array2, this.gf256.GetALog(j));
				array[array.Length - 1 - j] = num2;
				if (num2 != 0)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return true;
			}
			int[] monomialCoefficients = global::Infragistics.Controls.Barcodes.Gf256.GetMonomialCoefficients(eccNumber, 1);
			if (monomialCoefficients == null)
			{
				return false;
			}
			int[][] array3 = this.RunEuclideanAlgorithm(monomialCoefficients, array, eccNumber);
			if (array3 == null)
			{
				return false;
			}
			int[] errorLocator = array3[0];
			int[] errorEvaluator = array3[1];
			int[] array4 = this.FindErrorPositions(errorLocator);
			int[] array5 = this.FindErrorsSize(errorEvaluator, array4);
			if (array4 == null || array5 == null)
			{
				return false;
			}
			for (int k = 0; k < array4.Length; k++)
			{
				int num3 = blockDataBytes.Length - 1 - this.gf256.GetLog(array4[k]);
				if (num3 < 0)
				{
					return false;
				}
				blockDataBytes[num3] = (byte)global::Infragistics.Controls.Barcodes.GfArithmetics.Difference(array2[num3], array5[k]);
			}
			return true;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000058AC File Offset: 0x00003AAC
		private int[] FindErrorsSize(int[] errorEvaluator, int[] errorPositions)
		{
			int num = errorPositions.Length;
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				int num2 = this.gf256.Inverse(errorPositions[i]);
				int a = 1;
				for (int j = 0; j < num; j++)
				{
					if (i != j)
					{
						a = this.gf256.Product(a, global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(1, this.gf256.Product(errorPositions[j], num2)));
					}
				}
				array[i] = this.gf256.Product(this.gf256.CalculatePolynomialAt(errorEvaluator, num2), this.gf256.Inverse(a));
			}
			return array;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005948 File Offset: 0x00003B48
		private int[] FindErrorPositions(int[] errorLocator)
		{
			int num = errorLocator.Length - 1;
			if (num == 1)
			{
				return new int[]
				{
					errorLocator[0]
				};
			}
			int[] array = new int[num];
			int num2 = 0;
			int num3 = 1;
			while (num3 < 256 && num2 < num)
			{
				if (this.gf256.CalculatePolynomialAt(errorLocator, num3) == 0)
				{
					array[num2] = this.gf256.Inverse(num3);
					num2++;
				}
				num3++;
			}
			if (num2 != num)
			{
				return null;
			}
			return array;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000059B8 File Offset: 0x00003BB8
		private int[][] RunEuclideanAlgorithm(int[] aCoefficients, int[] bCoefficients, int degree)
		{
			int[] array = aCoefficients;
			int[] array2 = bCoefficients;
			if (array2.Length > array.Length)
			{
				int[] array3 = array2;
				array2 = array;
				array = array3;
			}
			int[] array4 = array;
			int[] array5 = array2;
			int[] array6 = new int[]
			{
				1
			};
			int[] array7 = new int[1];
			int[] array8 = array7;
			int[] array9 = new int[1];
			int[] array10 = array9;
			int[] array11 = new int[]
			{
				1
			};
			while (array5.Length > degree / 2)
			{
				int[] array12 = array4;
				int[] bCoefficients2 = array6;
				int[] bCoefficients3 = array10;
				array4 = array5;
				array6 = array8;
				array10 = array11;
				if (array4.Length == 1 && array4[0] == 0)
				{
					return null;
				}
				array5 = array12;
				int[] array13 = new int[1];
				int[] array14 = array13;
				int a = array4[0];
				int b = this.gf256.Inverse(a);
				while (array5.Length >= array4.Length && (array5.Length != 0 || array5[0] != 0))
				{
					int degree2 = array5.Length - array4.Length;
					int num = this.gf256.Product(array5[0], b);
					array14 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(array14, global::Infragistics.Controls.Barcodes.Gf256.GetMonomialCoefficients(degree2, num));
					array5 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(array5, this.gf256.MultiplyByMonomial(array4, degree2, num));
					if (array5 == null || array14 == null)
					{
						return null;
					}
				}
				array8 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(this.gf256.Product(array14, array6), bCoefficients2);
				array11 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(this.gf256.Product(array14, array10), bCoefficients3);
			}
			int num2 = array11[array11.Length - 1];
			if (num2 == 0)
			{
				return null;
			}
			int scalar = this.gf256.Inverse(num2);
			int[] array15 = this.gf256.Product(array11, scalar);
			int[] array16 = this.gf256.Product(array5, scalar);
			return new int[][]
			{
				array15,
				array16
			};
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005B60 File Offset: 0x00003D60
		private static byte[][] SetPolinomial(int eccCodewordsNumber)
		{
			byte[][] array = new byte[256][];
			for (int i = 0; i < 256; i++)
			{
				array[i] = new byte[eccCodewordsNumber];
			}
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::Infragistics.Controls.Barcodes.ResourceHelper.GetResourceBytes("RSP" + eccCodewordsNumber));
				global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream);
				for (int j = 0; j < 256; j++)
				{
					array[j] = global::System.Convert.FromBase64String(streamReader.ReadLine());
				}
				streamReader.Close();
				memoryStream.Close();
			}
			catch
			{
				return null;
			}
			return array;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005C00 File Offset: 0x00003E00
		private static int[] AssembleDataAndErrorCorrectionBytes(byte[][] ecDataBytesPerBlock, byte[][] ecBytesPerBlock, int[] rsBlockOrder, int maxDataCodewords, int maxCodewords)
		{
			int i = 0;
			int num = 0;
			int[] array = new int[maxCodewords];
			while (i < maxDataCodewords)
			{
				for (int j = 0; j < rsBlockOrder.Length; j++)
				{
					if (ecDataBytesPerBlock[j].Length > num)
					{
						array[i] = (int)(ecDataBytesPerBlock[j][num] & byte.MaxValue);
						i++;
					}
				}
				num++;
			}
			num = 0;
			while (i < maxCodewords)
			{
				for (int j = 0; j < rsBlockOrder.Length; j++)
				{
					if (ecBytesPerBlock[j].Length > num)
					{
						array[i] = (int)(ecBytesPerBlock[j][num] & byte.MaxValue);
						i++;
					}
				}
				num++;
			}
			return array;
		}

		// Token: 0x04000038 RID: 56
		private readonly global::Infragistics.Controls.Barcodes.Gf256 gf256;
	}
}
