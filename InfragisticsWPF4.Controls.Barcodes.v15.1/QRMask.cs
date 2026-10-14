using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000019 RID: 25
	internal class QRMask
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000D068 File Offset: 0x0000B268
		public static bool ShouldMaskTheBit(int mask, int row, int col)
		{
			int num;
			switch (mask)
			{
			case 0:
				num = (row + col & 1);
				break;
			case 1:
				num = (row & 1);
				break;
			case 2:
				num = col % 3;
				break;
			case 3:
				num = (row + col) % 3;
				break;
			case 4:
				num = ((row >> 1) + col / 3 & 1);
				break;
			case 5:
			{
				int num2 = row * col;
				num = (num2 & 1) + num2 % 3;
				break;
			}
			case 6:
			{
				int num2 = row * col;
				num = ((num2 & 1) + num2 % 3 & 1);
				break;
			}
			default:
			{
				int num2 = row * col;
				num = (num2 % 3 + (row + col & 1) & 1);
				break;
			}
			}
			return num == 0;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000D0F5 File Offset: 0x0000B2F5
		public static int GetPenalty(int[][] matrix)
		{
			return global::Infragistics.Controls.Barcodes.QRMask.GetFeature1(matrix) + global::Infragistics.Controls.Barcodes.QRMask.GetFeature2(matrix) + global::Infragistics.Controls.Barcodes.QRMask.GetFeature3(matrix) + global::Infragistics.Controls.Barcodes.QRMask.GetFeature4(matrix);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D114 File Offset: 0x0000B314
		private static int GetFeature4(int[][] matrix)
		{
			int num = 0;
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (matrix[i][j] == 1)
					{
						num++;
					}
				}
			}
			int num2 = 2 * matrix.Length;
			double num3 = (double)num / (double)num2;
			return (int)global::System.Math.Floor(global::System.Math.Abs((double)((int)(num3 * 100.0 - 50.0)) / 5.0)) * 10;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D18C File Offset: 0x0000B38C
		private static int GetFeature3(int[][] matrix)
		{
			int num = 0;
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (j + 6 < matrix.Length && matrix[i][j] == 1 && matrix[i][j + 1] == 0 && matrix[i][j + 2] == 1 && matrix[i][j + 3] == 1 && matrix[i][j + 4] == 1 && matrix[i][j + 5] == 0 && matrix[i][j + 6] == 1 && ((j + 10 < matrix.Length && matrix[i][j + 7] == 0 && matrix[i][j + 8] == 0 && matrix[i][j + 9] == 0 && matrix[i][j + 10] == 0) || (j - 4 >= 0 && matrix[i][j - 1] == 0 && matrix[i][j - 2] == 0 && matrix[i][j - 3] == 0 && matrix[i][j - 4] == 0)))
					{
						num += 40;
					}
					if (i + 6 < matrix[i].Length && matrix[i][j] == 1 && matrix[i + 1][j] == 0 && matrix[i + 2][j] == 1 && matrix[i + 3][j] == 1 && matrix[i + 4][j] == 1 && matrix[i + 5][j] == 0 && matrix[i + 6][j] == 1 && ((i + 10 < matrix[i].Length && matrix[i + 7][j] == 0 && matrix[i + 8][j] == 0 && matrix[i + 9][j] == 0 && matrix[i + 10][j] == 0) || (i - 4 >= 0 && matrix[i - 1][j] == 0 && matrix[i - 2][j] == 0 && matrix[i - 3][j] == 0 && matrix[i - 4][j] == 0)))
					{
						num += 40;
					}
				}
			}
			return num;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D334 File Offset: 0x0000B534
		private static int GetFeature2(int[][] matrix)
		{
			int num = 0;
			for (int i = 0; i < matrix.Length - 1; i++)
			{
				for (int j = 0; j < matrix[i].Length - 1; j++)
				{
					int num2 = matrix[i][j];
					if (num2 != -2 && num2 == matrix[i][j + 1] && num2 == matrix[i + 1][j] && num2 == matrix[i + 1][j + 1])
					{
						num += 3;
					}
				}
			}
			return num;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D395 File Offset: 0x0000B595
		private static int GetFeature1(int[][] matrix)
		{
			return global::Infragistics.Controls.Barcodes.QRMask.GetAdjacentSameColorModules(matrix, true) + global::Infragistics.Controls.Barcodes.QRMask.GetAdjacentSameColorModules(matrix, false);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		private static int GetAdjacentSameColorModules(int[][] matrix, bool isRow)
		{
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					int num4 = isRow ? matrix[i][j] : matrix[j][i];
					if (num4 != -2)
					{
						if (num4 == num3)
						{
							num2++;
							if (num2 == 5)
							{
								num += 3;
							}
							else if (num2 > 5)
							{
								num++;
							}
						}
						else
						{
							num2 = 1;
							num3 = num4;
						}
					}
				}
				num2 = 0;
			}
			return num;
		}

		// Token: 0x040000D7 RID: 215
		public const int MinMaskIndex = 0;

		// Token: 0x040000D8 RID: 216
		public const int MaxMaskIndex = 7;

		// Token: 0x040000D9 RID: 217
		private const int N1 = 3;

		// Token: 0x040000DA RID: 218
		private const int N2 = 3;

		// Token: 0x040000DB RID: 219
		private const int N3 = 40;

		// Token: 0x040000DC RID: 220
		private const int N4 = 10;
	}
}
