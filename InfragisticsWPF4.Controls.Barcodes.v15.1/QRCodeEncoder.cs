using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200002C RID: 44
	internal class QRCodeEncoder : global::Infragistics.Controls.Barcodes.BarcodeEncodedAlgorithm
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00017AEE File Offset: 0x00015CEE
		public QRCodeEncoder(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode barcode) : base(barcode)
		{
			this.Barcode = barcode;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00017B00 File Offset: 0x00015D00
		public int[][] EncodeData()
		{
			this.SetProperties();
			string text = this.Barcode.Data;
			global::Infragistics.Controls.Barcodes.SizeVersion sizeVersion = this.Barcode.SizeVersion;
			global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel errorCorrectionLevel = this.Barcode.ErrorCorrectionLevel;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.Barcode.EciHeaderDisplayMode == global::Infragistics.Controls.Barcodes.HeaderDisplayMode.Show)
			{
				stringBuilder.Append(global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetEciHeader(this.Barcode.EciNumber));
			}
			global::Infragistics.Controls.Barcodes.Fnc1Mode fnc1Mode = this.Barcode.Fnc1Mode;
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.QRCodeEncoder.SetFnc1Mode(fnc1Mode, this.Barcode.ApplicationIndicator));
			if (fnc1Mode == global::Infragistics.Controls.Barcodes.Fnc1Mode.Gs1 || fnc1Mode == global::Infragistics.Controls.Barcodes.Fnc1Mode.Industry)
			{
				char fnc1Character = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetFnc1Character(this.Barcode.EncodingMode);
				string text2 = text;
				if (fnc1Mode == global::Infragistics.Controls.Barcodes.Fnc1Mode.Gs1)
				{
					text2 = global::Infragistics.Controls.Barcodes.Gs1Helper.VerifyApplicationIdentifier(text2, fnc1Character);
					if (string.IsNullOrEmpty(text2))
					{
						string @string = global::SR.GetString("InvalidAI");
						global::System.ArgumentException ex = new global::System.ArgumentException(@string);
						throw ex;
					}
				}
				if (!text.Equals(text2))
				{
					this.SaveFnc1Positions(text, text2, fnc1Character);
					text = text2;
				}
			}
			global::System.Collections.Generic.List<string> encodedData = this.ConvertData(text, sizeVersion, this.Barcode.EncodingMode);
			string text3 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetStringDataOfList(encodedData);
			int versionNumber = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetVersionNumber(sizeVersion, (int)errorCorrectionLevel, text3.Length + stringBuilder.ToString().Length);
			string text4 = this.FixEncodedData(encodedData, versionNumber);
			while (text3.Length != text4.Length)
			{
				text3 = text4;
				versionNumber = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetVersionNumber(sizeVersion, (int)errorCorrectionLevel, text4.Length + stringBuilder.ToString().Length);
				text4 = this.FixEncodedData(encodedData, versionNumber);
			}
			int maxDataBits = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.DataBitsCapacity[(int)errorCorrectionLevel][versionNumber];
			stringBuilder.Append(text4);
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetTerminator(stringBuilder.ToString(), (int)errorCorrectionLevel, versionNumber));
			string[] codewords = global::Infragistics.Controls.Barcodes.QRCodeEncoder.DivideIntoCodewords(stringBuilder.ToString(), maxDataBits);
			string[] maxDataCodewords = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillWidthPads(codewords, maxDataBits);
			int maxCodewordsNumber = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.DataCodewordsCapacity[versionNumber];
			byte[] rsBlockOrderTemp;
			byte[] rsEccCodewords;
			try
			{
				string arg = errorCorrectionLevel.ToString().Substring(0, 1);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::Infragistics.Controls.Barcodes.ResourceHelper.GetResourceBytes("ecc" + versionNumber + arg));
				global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream);
				rsBlockOrderTemp = global::System.Convert.FromBase64String(streamReader.ReadLine());
				rsEccCodewords = global::System.Convert.FromBase64String(streamReader.ReadLine());
				streamReader.Close();
				memoryStream.Close();
			}
			catch (global::System.Exception ex2)
			{
				throw new global::System.ArgumentException(ex2.Message);
			}
			string[] collection = global::Infragistics.Controls.Barcodes.QRCodeEncoder.AddErrorCorrectionCodewords(maxDataCodewords, maxCodewordsNumber, rsEccCodewords, rsBlockOrderTemp);
			int modulesNumberPerSide = 17 + (versionNumber << 2);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateMatrix(global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetStringDataOfList(new global::System.Collections.Generic.List<string>(collection)), modulesNumberPerSide, versionNumber, errorCorrectionLevel);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00017D7C File Offset: 0x00015F7C
		private void SaveFnc1Positions(string data, string fnc1Data, char fnc1Char)
		{
			int num = 0;
			for (int i = 0; i < fnc1Data.Length; i++)
			{
				if (num == data.Length)
				{
					return;
				}
				if (this.Fnc1Mode == global::Infragistics.Controls.Barcodes.Fnc1Mode.Gs1 && (data[num] == '(' || data[num] == ')'))
				{
					num++;
				}
				char c = fnc1Data[i];
				if (!c.Equals(data[num]) && c.Equals(fnc1Char))
				{
					this.Fnc1Positions.Add(i);
				}
				else
				{
					num++;
				}
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00017E00 File Offset: 0x00016000
		private static string GetTerminator(string data, int level, int version)
		{
			string result = string.Empty;
			int terminatorLength = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetTerminatorLength(data.Length, level, version);
			if (terminatorLength > 0)
			{
				result = 0.ToString().PadLeft(terminatorLength, '0');
			}
			return result;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00017E38 File Offset: 0x00016038
		private static int GetTerminatorLength(int dataLength, int level, int version)
		{
			int num = (version == 0) ? global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.DataBitsCapacity[level][40] : global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.DataBitsCapacity[level][version];
			if (dataLength == num)
			{
				return 0;
			}
			int num2 = dataLength % 8;
			num2 = ((num2 != 0) ? (8 - num2) : num2);
			if (num2 < 4 && version != 0 && num - (num2 + dataLength) >= 8)
			{
				num2 += 8;
			}
			return num2;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00017E88 File Offset: 0x00016088
		private string FixEncodedData(global::System.Collections.Generic.List<string> encodedData, int version)
		{
			string stringDataOfList = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetStringDataOfList(encodedData);
			int num = (version < 10) ? 0 : ((version < 27) ? 1 : 2);
			bool flag = false;
			for (int i = 0; i < encodedData.Count; i += 3)
			{
				int num2 = encodedData[i].TrimStart(new char[]
				{
					'0'
				}).Length - 1;
				int num3 = (int)global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[num2][num];
				if (encodedData[i + 1].Length != num3)
				{
					encodedData[i + 1] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, this.DataSize[i / 3].ToString(), 10).PadLeft(num3, '0');
					flag = true;
				}
			}
			if (flag)
			{
				stringDataOfList = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetStringDataOfList(encodedData);
			}
			return stringDataOfList;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00017F45 File Offset: 0x00016145
		private void SetProperties()
		{
			this.SetEncoding();
			this.Fnc1Positions = new global::System.Collections.Generic.List<int>();
			this.DataSize = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00017F64 File Offset: 0x00016164
		private static string SetFnc1Mode(global::Infragistics.Controls.Barcodes.Fnc1Mode mode, string applicationIndicator)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			switch (mode)
			{
			case global::Infragistics.Controls.Barcodes.Fnc1Mode.Gs1:
				stringBuilder.Append(101.ToString().PadLeft(4, '0'));
				break;
			case global::Infragistics.Controls.Barcodes.Fnc1Mode.Industry:
			{
				stringBuilder.Append(1001.ToString().PadLeft(4, '0'));
				string applicationIndicatorCodeword = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetApplicationIndicatorCodeword(applicationIndicator);
				if (string.IsNullOrEmpty(applicationIndicatorCodeword))
				{
					string message = global::SR.GetString("InvalidPropertyValue").Replace("{0}", "ApplicationIndicator").Replace("{1}", "{a-z, A-Z, 00").Replace("{2}", "99}");
					global::System.ArgumentException ex = new global::System.ArgumentException(message);
					throw ex;
				}
				stringBuilder.Append(applicationIndicatorCodeword);
				break;
			}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00018028 File Offset: 0x00016228
		private void SetEncoding()
		{
			string name = string.Empty;
			try
			{
				name = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[this.Barcode.EciNumber];
			}
			catch (global::System.Exception)
			{
				string message = global::SR.GetString("NotSupportedEncoding").Replace("{0}", "Eci number").Replace("{1}", this.Barcode.EciNumber.ToString());
				throw new global::System.ArgumentException(message);
			}
			global::System.Text.Encoding encoding = base.GetEncoding(name);
			this.QrEncoding = encoding;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000180B4 File Offset: 0x000162B4
		private static int GetVersionNumber(global::Infragistics.Controls.Barcodes.SizeVersion version, int level, int encodedDataLength)
		{
			int num = (int)version;
			int terminatorLength = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetTerminatorLength(encodedDataLength, level, num);
			if (num == 0)
			{
				num = 1;
				int num2 = 1;
				while (num2 < 40 && global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.DataBitsCapacity[level][num2] < encodedDataLength + terminatorLength)
				{
					num++;
					num2++;
				}
			}
			return num;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000180F4 File Offset: 0x000162F4
		private static string GetStringDataOfList(global::System.Collections.Generic.List<string> encodedData)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (string value in encodedData)
			{
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00018150 File Offset: 0x00016350
		private static int[][] CreateMatrix(string dataBitsString, int modulesNumberPerSide, int versionNumber, global::Infragistics.Controls.Barcodes.QRCodeErrorCorrectionLevel level)
		{
			byte mask = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CalculateMask(dataBitsString, modulesNumberPerSide, (int)level, versionNumber);
			int[][] matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateFunctionPatternsMatrix(modulesNumberPerSide, versionNumber);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFormatInfo((int)level, (int)mask, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillVersionInfo(versionNumber, matrix);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillDataBits(dataBitsString, mask, matrix);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001818C File Offset: 0x0001638C
		private static int[][] CreateFunctionPatternsMatrix(int modulesNumberPerSide, int version)
		{
			int[][] array = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateEmptyMatrix(modulesNumberPerSide);
			array = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFinderPatternsAndSeparators(array);
			array[array.Length - 8][8] = 1;
			array = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillAlignmentPatterns(version, array);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillTimingPatterns(array);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000181C4 File Offset: 0x000163C4
		private static int[][] FillTimingPatterns(int[][] matrix)
		{
			for (int i = 8; i < matrix.Length - 8; i++)
			{
				if ((matrix[i][6] != -1 && matrix[i][6] != -2 && matrix[i][6] != 0 && matrix[i][6] != 1) || (matrix[6][i] != -1 && matrix[6][i] != -2 && matrix[6][i] != 0 && matrix[6][i] != 1))
				{
					string @string = global::SR.GetString("EncodingError");
					throw new global::System.ArgumentException(@string);
				}
				int num = (i + 1) % 2;
				if (matrix[i][6] == -1)
				{
					matrix[i][6] = num;
				}
				if (matrix[6][i] == -1)
				{
					matrix[6][i] = num;
				}
			}
			return matrix;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00018258 File Offset: 0x00016458
		private static int[][] FillAlignmentPatterns(int version, int[][] matrix)
		{
			if (version >= 2)
			{
				int num = version - 1;
				int[] array = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.AlignmentPatternsIndexes[num];
				int num2 = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.AlignmentPatternsIndexes[num].Length;
				for (int i = 0; i < num2; i++)
				{
					for (int j = 0; j < num2; j++)
					{
						int num3 = array[i];
						int num4 = array[j];
						if (matrix[num3][num4] == -1)
						{
							int num5 = num4 - 2;
							int num6 = num3 - 2;
							for (int k = 0; k < 5; k++)
							{
								for (int l = 0; l < 5; l++)
								{
									if (matrix[num6 + k][num5 + l] == -1)
									{
										matrix[num6 + k][num5 + l] = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.AlignmentPattern[k][l];
									}
								}
							}
						}
					}
				}
			}
			return matrix;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001830C File Offset: 0x0001650C
		private static int[][] FillFinderPatternsAndSeparators(int[][] matrix)
		{
			int num = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.FinderPattern[0].Length;
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFinderPattern(0, 0, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFinderPattern(matrix.Length - num, 0, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFinderPattern(0, matrix.Length - num, matrix);
			int num2 = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.HorizontalSeparatorPattern[0].Length;
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillHorizontalSeparationPattern(0, num2 - 1, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillHorizontalSeparationPattern(matrix.Length - num2, num2 - 1, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillHorizontalSeparationPattern(0, matrix.Length - num2, matrix);
			int num3 = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.VerticalSeparatorPattern.Length;
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillVerticalSeparationPattern(num3, 0, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillVerticalSeparationPattern(matrix.Length - num3 - 1, 0, matrix);
			matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillVerticalSeparationPattern(num3, matrix.Length - num3, matrix);
			return matrix;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000183B0 File Offset: 0x000165B0
		private static int[][] FillVerticalSeparationPattern(int xIndex, int yIndex, int[][] matrix)
		{
			for (int i = 0; i < 7; i++)
			{
				if (matrix[yIndex + i][xIndex] != -1)
				{
					string @string = global::SR.GetString("EncodingError");
					throw new global::System.ArgumentException(@string);
				}
				matrix[yIndex + i][xIndex] = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.VerticalSeparatorPattern[i][0];
			}
			return matrix;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000183F8 File Offset: 0x000165F8
		private static int[][] FillHorizontalSeparationPattern(int xIndex, int yIndex, int[][] matrix)
		{
			for (int i = 0; i < 8; i++)
			{
				if (matrix[yIndex][xIndex + i] != -1)
				{
					string @string = global::SR.GetString("EncodingError");
					throw new global::System.ArgumentException(@string);
				}
				matrix[yIndex][xIndex + i] = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.HorizontalSeparatorPattern[0][i];
			}
			return matrix;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00018440 File Offset: 0x00016640
		private static int[][] FillFinderPattern(int xIndex, int yIndex, int[][] matrix)
		{
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					matrix[yIndex + i][xIndex + j] = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.FinderPattern[i][j];
				}
			}
			return matrix;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00018478 File Offset: 0x00016678
		private static int[][] FillFormatInfo(int level, int mask, int[][] matrix)
		{
			byte[] array = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateFormatInfo(level, mask);
			for (int i = 0; i < array.Length; i++)
			{
				byte b = array[array.Length - 1 - i];
				int num = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.FormatInfoCells[i][0];
				int num2 = global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.FormatInfoCells[i][1];
				matrix[num2][num] = (int)b;
				if (i < 8)
				{
					int num3 = matrix.Length - i - 1;
					matrix[8][num3] = (int)b;
				}
				else
				{
					int num4 = matrix.Length - 7 + (i - 8);
					matrix[num4][8] = (int)b;
				}
			}
			return matrix;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000184EC File Offset: 0x000166EC
		private static byte[] CreateFormatInfo(int level, int mask)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int data = level << 3 | mask;
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, data.ToString(), 10).PadLeft(5, '0'));
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, global::Infragistics.Controls.Barcodes.Bch.GetBchCode(data, 1335).ToString(), 10).PadLeft(10, '0'));
			string bits = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, 21522.ToString(), 10).PadLeft(15, '0');
			return global::Infragistics.Controls.Barcodes.GfArithmetics.CalculateSumOfBits(global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetBitsArray(stringBuilder.ToString()), global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetBitsArray(bits));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00018588 File Offset: 0x00016788
		private static byte[] GetBitsArray(string bits)
		{
			byte[] array = new byte[bits.Length];
			for (int i = 0; i < bits.Length; i++)
			{
				array[i] = (byte)int.Parse(bits[i].ToString());
			}
			return array;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000185CC File Offset: 0x000167CC
		private static int[][] FillVersionInfo(int version, int[][] matrix)
		{
			if (version >= 7)
			{
				string text = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateVersionInfo(version);
				int num = 17;
				for (int i = 0; i < 6; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						int num2 = (int)(text[num] - '0');
						num--;
						matrix[matrix.Length - 11 + j][i] = num2;
						matrix[i][matrix.Length - 11 + j] = num2;
					}
				}
			}
			return matrix;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001862C File Offset: 0x0001682C
		private static string CreateVersionInfo(int version)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, version.ToString(), 10).PadLeft(6, '0'));
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, global::Infragistics.Controls.Barcodes.Bch.GetBchCode(version, 7973).ToString(), 10).PadLeft(12, '0'));
			return stringBuilder.ToString();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00018690 File Offset: 0x00016890
		private static int[][] FillDataBits(string dataBits, byte mask, int[][] matrix)
		{
			int num = 0;
			int num2 = -1;
			int i = matrix.Length - 1;
			int num3 = i;
			while (i > 0)
			{
				if (i == 6)
				{
					i--;
				}
				while (num3 >= 0 && num3 < matrix.Length)
				{
					for (int j = 0; j < 2; j++)
					{
						int num4 = i - j;
						if (matrix[num3][num4] == -1 || matrix[num3][num4] == -2)
						{
							int num5;
							if (num < dataBits.Length)
							{
								num5 = (int)(dataBits[num] - '0');
								num++;
							}
							else
							{
								num5 = 0;
							}
							if (global::Infragistics.Controls.Barcodes.QRMask.ShouldMaskTheBit((int)mask, num3, num4))
							{
								num5 ^= 1;
							}
							matrix[num3][num4] = num5;
						}
					}
					num3 += num2;
				}
				num2 = -num2;
				num3 += num2;
				i -= 2;
			}
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.Rotate(matrix);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00018740 File Offset: 0x00016940
		private static int[][] Rotate(int[][] matrix)
		{
			int[][] array = new int[matrix.Length][];
			for (int i = 0; i < matrix.Length; i++)
			{
				for (int j = 0; j < matrix[i].Length; j++)
				{
					if (array[j] == null)
					{
						array[j] = new int[matrix[i].Length];
					}
					array[j][i] = matrix[i][j];
				}
			}
			return array;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00018794 File Offset: 0x00016994
		private static int[][] CreateEmptyMatrix(int length)
		{
			int[][] array = new int[length][];
			for (int i = 0; i < length; i++)
			{
				array[i] = new int[length];
				for (int j = 0; j < length; j++)
				{
					array[i][j] = -1;
				}
			}
			return array;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000187D0 File Offset: 0x000169D0
		private static byte CalculateMask(string dataBitsString, int modulesNumberPerSide, int level, int version)
		{
			int num = int.MaxValue;
			byte result = 0;
			for (byte b = 0; b < 7; b += 1)
			{
				int[][] matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.CreateFunctionPatternsMatrix(modulesNumberPerSide, version);
				matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillFormatInfo(level, (int)b, matrix);
				matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillVersionInfo(version, matrix);
				matrix = global::Infragistics.Controls.Barcodes.QRCodeEncoder.FillDataBits(dataBitsString, b, matrix);
				int penalty = global::Infragistics.Controls.Barcodes.QRMask.GetPenalty(matrix);
				if (penalty < num)
				{
					num = penalty;
					result = b;
				}
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00018828 File Offset: 0x00016A28
		private static string[] AddErrorCorrectionCodewords(string[] maxDataCodewords, int maxCodewordsNumber, byte[] rsEccCodewords, byte[] rsBlockOrderTemp)
		{
			int num = 0;
			int[] array = new int[maxDataCodewords.Length];
			foreach (string text in maxDataCodewords)
			{
				array[num] = int.Parse(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(10, text, 2));
				num++;
			}
			byte b = 1;
			for (byte b2 = 1; b2 < 128; b2 += 1)
			{
				if (rsBlockOrderTemp.Length == (int)b2 || rsBlockOrderTemp[(int)b2] == 0)
				{
					b = b2;
					break;
				}
			}
			int[] array2 = new int[(int)b];
			global::System.Array.Copy(rsBlockOrderTemp, 0, array2, 0, (int)b);
			global::Infragistics.Controls.Barcodes.QRReedSolomon qrreedSolomon = new global::Infragistics.Controls.Barcodes.QRReedSolomon();
			int[] array3 = qrreedSolomon.GenerateErrorCorrectionCodewords(array, (int)rsEccCodewords[0], array2, maxDataCodewords.Length, maxCodewordsNumber);
			if (array3 == null)
			{
				return null;
			}
			string[] array4 = new string[maxCodewordsNumber];
			for (int j = 0; j < array3.Length; j++)
			{
				array4[j] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, array3[j].ToString(), 10).PadLeft(8, '0');
			}
			return array4;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00018910 File Offset: 0x00016B10
		private static string[] DivideIntoCodewords(string bitStream, int maxDataBits)
		{
			int i = 0;
			string[] array = new string[bitStream.Length / 8];
			while (i < bitStream.Length)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int j = 0; j < 8; j++)
				{
					stringBuilder.Append(bitStream[i + j]);
				}
				array[i / 8] = stringBuilder.ToString();
				i += 8;
			}
			if (maxDataBits / 8 < array.Length)
			{
				string @string = global::SR.GetString("InvalidVersion");
				global::System.ArgumentException ex = new global::System.ArgumentException(@string);
				throw ex;
			}
			return array;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001898C File Offset: 0x00016B8C
		private static string[] FillWidthPads(string[] codewords, int maxDataBits)
		{
			int num = maxDataBits / 8;
			if (codewords.Length == num)
			{
				return codewords;
			}
			string[] array = new string[num];
			global::System.Array.Copy(codewords, 0, array, 0, codewords.Length);
			bool flag = true;
			for (int i = codewords.Length; i < array.Length; i++)
			{
				array[i] = (flag ? "11101100" : "00010001");
				flag = !flag;
			}
			return array;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000189E4 File Offset: 0x00016BE4
		private global::System.Collections.Generic.List<string> ConvertData(string data, global::Infragistics.Controls.Barcodes.SizeVersion version, global::Infragistics.Controls.Barcodes.EncodingMode mode)
		{
			int num = (version < global::Infragistics.Controls.Barcodes.SizeVersion.Version10) ? 0 : ((version < global::Infragistics.Controls.Barcodes.SizeVersion.Version27) ? 1 : 2);
			int totalWidth = (int)((mode != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined) ? global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[(int)mode][num] : 0);
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			switch (mode)
			{
			case global::Infragistics.Controls.Barcodes.EncodingMode.Numeric:
			{
				int num2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CountConsecutiveDigits(data, 0);
				if (num2 != data.Length)
				{
					string message = global::SR.GetString("WrongCompactionMode").Replace("{0}", "Numeric");
					global::System.ArgumentException ex = new global::System.ArgumentException(message);
					throw ex;
				}
				int length = data.Length;
				this.DataSize.Add(length);
				int bitsToFill = (length % 3 == 0) ? 0 : ((length % 3 == 1) ? 4 : 7);
				list.Add(1.ToString().PadLeft(4, '0'));
				list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, this.DataSize[0].ToString(), 10).PadLeft(totalWidth, '0'));
				list.Add(this.EncodeNumeric(data, bitsToFill));
				break;
			}
			case global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric:
				list.Add(10.ToString().PadLeft(4, '0'));
				if (this.Fnc1Mode != global::Infragistics.Controls.Barcodes.Fnc1Mode.None)
				{
					data = this.EscapePercentCharacter(data, global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetFnc1Character(global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric), 0);
				}
				this.DataSize.Add(data.Length);
				list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, this.DataSize[0].ToString(), 10).PadLeft(totalWidth, '0'));
				list.Add(this.EncodeAlphanumeric(data));
				break;
			case global::Infragistics.Controls.Barcodes.EncodingMode.Byte:
			{
				list.Add(100.ToString().PadLeft(4, '0'));
				if (this.Fnc1Mode != global::Infragistics.Controls.Barcodes.Fnc1Mode.None)
				{
					data = this.EscapePercentCharacter(data, global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetFnc1Character(global::Infragistics.Controls.Barcodes.EncodingMode.Byte), 0);
				}
				string text = this.EncodeByte(data);
				int item = text.Length / 8;
				this.DataSize.Add(item);
				list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, item.ToString(), 10).PadLeft(totalWidth, '0'));
				list.Add(text);
				break;
			}
			case global::Infragistics.Controls.Barcodes.EncodingMode.Kanji:
				list.Add(1000.ToString().PadLeft(4, '0'));
				this.DataSize.Add(data.Length);
				list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, this.DataSize[0].ToString(), 10).PadLeft(totalWidth, '0'));
				list.Add(this.EncodeKanji(data));
				break;
			default:
				return this.EncodeMixed(data, version);
			}
			return list;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00018C5C File Offset: 0x00016E5C
		private static char GetFnc1Character(global::Infragistics.Controls.Barcodes.EncodingMode mode)
		{
			if (mode == global::Infragistics.Controls.Barcodes.EncodingMode.Byte)
			{
				return '\u001d';
			}
			return '%';
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00018C68 File Offset: 0x00016E68
		private static string GetApplicationIndicatorCodeword(string applicationIdicator)
		{
			if (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsApplicationIndicatorValid(applicationIdicator))
			{
				if (applicationIdicator.Length == 2)
				{
					return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, applicationIdicator, 10).PadLeft(8, '0');
				}
				if (applicationIdicator.Length == 1)
				{
					char c = applicationIdicator[0];
					string text = ((int)(c + 'd')).ToString();
					return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text, 10).PadLeft(8, '0');
				}
			}
			return string.Empty;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00018CD0 File Offset: 0x00016ED0
		private string EscapePercentCharacter(string data, char fnc1, int currentIndex)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				char value = data[i];
				if (value.Equals(fnc1) && !this.Fnc1Positions.Contains(i + currentIndex))
				{
					stringBuilder.Append(value);
				}
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00018D2C File Offset: 0x00016F2C
		private static string GetEciHeader(int eciNumber)
		{
			string str = 111.ToString().PadLeft(4, '0');
			int totalWidth;
			string text;
			if (eciNumber < 128)
			{
				totalWidth = 7;
				text = "0";
			}
			else if (eciNumber < 16384)
			{
				totalWidth = 14;
				text = "10";
			}
			else
			{
				totalWidth = 21;
				text = "110";
			}
			string str2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, eciNumber.ToString(), 10).PadLeft(totalWidth, '0');
			text += str2;
			return str + text;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00018DA4 File Offset: 0x00016FA4
		private global::System.Collections.Generic.List<string> EncodeMixed(string data, global::Infragistics.Controls.Barcodes.SizeVersion version)
		{
			global::Infragistics.Controls.Barcodes.EncodingSequence encodingSequence = new global::Infragistics.Controls.Barcodes.EncodingSequence(new global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.EncodingMode>(), new global::System.Collections.Generic.List<int>());
			global::Infragistics.Controls.Barcodes.EncodingMode encodingMode = this.SelectInitialMode(data, version);
			int i = 0;
			while (i < data.Length)
			{
				global::Infragistics.Controls.Barcodes.EncodingMode lastEncodingType = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetLastEncodingType(encodingSequence);
				bool flag = false;
				switch (encodingMode)
				{
				case global::Infragistics.Controls.Barcodes.EncodingMode.Numeric:
				{
					encodingSequence = this.WhileInNumeric(data, i, encodingSequence);
					global::Infragistics.Controls.Barcodes.EncodingMode lastEncodingType2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetLastEncodingType(encodingSequence);
					if (lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Numeric && lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined)
					{
						encodingMode = lastEncodingType2;
						i += encodingSequence.BytesNumber[encodingSequence.BytesNumber.Count - 1];
						flag = false;
					}
					else
					{
						flag = true;
					}
					break;
				}
				case global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric:
				{
					encodingSequence = this.WhileInAlphanumeric(data, (int)version, i, encodingSequence);
					global::Infragistics.Controls.Barcodes.EncodingMode lastEncodingType2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetLastEncodingType(encodingSequence);
					if (lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric && lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined)
					{
						encodingMode = lastEncodingType2;
						i += encodingSequence.BytesNumber[encodingSequence.BytesNumber.Count - 1];
						flag = false;
					}
					else
					{
						flag = true;
					}
					break;
				}
				case global::Infragistics.Controls.Barcodes.EncodingMode.Byte:
				{
					encodingSequence = this.WhileInByte(data, (int)version, i, encodingSequence);
					global::Infragistics.Controls.Barcodes.EncodingMode lastEncodingType2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetLastEncodingType(encodingSequence);
					if (lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Byte && lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined)
					{
						encodingMode = lastEncodingType2;
						i += encodingSequence.BytesNumber[encodingSequence.BytesNumber.Count - 1];
						flag = false;
					}
					else
					{
						flag = true;
					}
					break;
				}
				case global::Infragistics.Controls.Barcodes.EncodingMode.Kanji:
				{
					encodingSequence = this.WhileInKanji(data, i, encodingSequence);
					global::Infragistics.Controls.Barcodes.EncodingMode lastEncodingType2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetLastEncodingType(encodingSequence);
					if (lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Kanji && lastEncodingType2 != global::Infragistics.Controls.Barcodes.EncodingMode.Undefined)
					{
						encodingMode = lastEncodingType2;
						i += encodingSequence.BytesNumber[encodingSequence.BytesNumber.Count - 1];
						flag = false;
					}
					else
					{
						flag = true;
					}
					break;
				}
				}
				if (flag)
				{
					if (lastEncodingType != encodingMode)
					{
						encodingSequence.EncodingType.Add(encodingMode);
						encodingSequence.BytesNumber.Add(0);
					}
					global::System.Collections.Generic.List<int> bytesNumber;
					int index;
					(bytesNumber = encodingSequence.BytesNumber)[index = encodingSequence.BytesNumber.Count - 1] = bytesNumber[index] + 1;
					i++;
				}
			}
			return this.AppendSequences(encodingSequence, data, (int)version);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00018F8C File Offset: 0x0001718C
		private global::System.Collections.Generic.List<string> AppendSequences(global::Infragistics.Controls.Barcodes.EncodingSequence sequence, string data, int version)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			int num = (version < 10) ? 0 : ((version < 27) ? 1 : 2);
			int num2 = 0;
			for (int i = 0; i < sequence.EncodingType.Count; i++)
			{
				if (sequence.BytesNumber[i] != 0)
				{
					global::Infragistics.Controls.Barcodes.EncodingMode encodingMode = (global::Infragistics.Controls.Barcodes.EncodingMode)sequence.EncodingType[i];
					string text = data.Substring(num2, sequence.BytesNumber[i]);
					if ((encodingMode == global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric || encodingMode == global::Infragistics.Controls.Barcodes.EncodingMode.Byte) && this.Fnc1Mode != global::Infragistics.Controls.Barcodes.Fnc1Mode.None)
					{
						text = this.EscapePercentCharacter(text, global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetFnc1Character(encodingMode), num2);
					}
					switch (encodingMode)
					{
					case global::Infragistics.Controls.Barcodes.EncodingMode.Numeric:
					{
						list.Add(1.ToString().PadLeft(4, '0'));
						int totalWidth = (int)global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[0][num];
						this.DataSize.Add(text.Length);
						list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text.Length.ToString(), 10).PadLeft(totalWidth, '0'));
						int length = text.Length;
						int bitsToFill = (length % 3 == 0) ? 0 : ((length % 3 == 1) ? 4 : 7);
						list.Add(this.EncodeNumeric(text, bitsToFill));
						break;
					}
					case global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric:
					{
						list.Add(10.ToString().PadLeft(4, '0'));
						int totalWidth = (int)global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[1][num];
						this.DataSize.Add(text.Length);
						list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text.Length.ToString(), 10).PadLeft(totalWidth, '0'));
						list.Add(this.EncodeAlphanumeric(text));
						break;
					}
					case global::Infragistics.Controls.Barcodes.EncodingMode.Byte:
					{
						list.Add(100.ToString().PadLeft(4, '0'));
						int totalWidth = (int)global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[2][num];
						string text2 = this.EncodeByte(text);
						int item = text2.Length / 8;
						this.DataSize.Add(item);
						list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, item.ToString(), 10).PadLeft(totalWidth, '0'));
						list.Add(text2);
						break;
					}
					case global::Infragistics.Controls.Barcodes.EncodingMode.Kanji:
					{
						list.Add(1000.ToString().PadLeft(4, '0'));
						int totalWidth = (int)global::Infragistics.Controls.Barcodes.QRCodeAlgorithm.CharacterCountIndicatorBitsNumber[3][num];
						this.DataSize.Add(text.Length);
						list.Add(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text.Length.ToString(), 10).PadLeft(totalWidth, '0'));
						list.Add(this.EncodeKanji(text));
						break;
					}
					}
					num2 += text.Length;
				}
			}
			return list;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001923C File Offset: 0x0001743C
		private global::Infragistics.Controls.Barcodes.EncodingSequence WhileInKanji(string data, int ptr, global::Infragistics.Controls.Barcodes.EncodingSequence sequence)
		{
			if (data.Length <= ptr)
			{
				return sequence;
			}
			string text = data.Substring(ptr, 1);
			if (!this.AreAllKanji(text))
			{
				byte[] bytes = this.KanjiEncoding.GetBytes(text);
				if (bytes.Length < 2)
				{
					bytes = this.QrEncoding.GetBytes(text);
					if (bytes.Length == 1 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsAscii((int)bytes[0]))
					{
						sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Byte);
						sequence.BytesNumber.Add(1);
					}
					return sequence;
				}
			}
			return sequence;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000192BC File Offset: 0x000174BC
		private global::Infragistics.Controls.Barcodes.EncodingSequence WhileInNumeric(string data, int start, global::Infragistics.Controls.Barcodes.EncodingSequence sequence)
		{
			if (data.Length <= start)
			{
				return sequence;
			}
			bool flag = false;
			byte[] bytes = this.KanjiEncoding.GetBytes(data[start].ToString());
			bool flag2 = this.CouldBeKanji();
			if (flag2 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(bytes))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Kanji);
				sequence.BytesNumber.Add(1);
				flag = true;
			}
			byte[] bytes2 = this.QrEncoding.GetBytes(data[start].ToString());
			int input = (bytes2.Length > 0) ? ((int)bytes2[0]) : -2;
			if (!flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(input))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Byte);
				sequence.BytesNumber.Add(1);
				flag = true;
			}
			if (!flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(input))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric);
				sequence.BytesNumber.Add(1);
			}
			return sequence;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000193BC File Offset: 0x000175BC
		private global::Infragistics.Controls.Barcodes.EncodingSequence WhileInAlphanumeric(string data, int version, int start, global::Infragistics.Controls.Barcodes.EncodingSequence sequence)
		{
			if (data.Length <= start)
			{
				return sequence;
			}
			bool flag = false;
			bool flag2 = this.CouldBeKanji();
			byte[] bytes = this.KanjiEncoding.GetBytes(data[start].ToString());
			if (flag2 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(bytes))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Kanji);
				sequence.BytesNumber.Add(1);
				flag = true;
			}
			byte[] bytes2 = this.QrEncoding.GetBytes(data[start].ToString());
			int input = (bytes2.Length > 0) ? ((int)bytes2[0]) : -2;
			if (!flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(input))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Byte);
				sequence.BytesNumber.Add(1);
				flag = true;
			}
			int charsNumberByVersion = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
			{
				13,
				15,
				17
			}, version);
			int num = this.CheckBytesTypeByVersion(charsNumberByVersion, "N", data, start);
			if (!flag && data.Length > charsNumberByVersion + start)
			{
				bytes2 = this.QrEncoding.GetBytes(data[start + charsNumberByVersion].ToString());
				input = ((bytes2.Length > 0) ? ((int)bytes2[0]) : -2);
				if (num == -1 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(input))
				{
					sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Numeric);
					sequence.BytesNumber.Add(charsNumberByVersion);
				}
			}
			return sequence;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00019544 File Offset: 0x00017744
		private global::Infragistics.Controls.Barcodes.EncodingSequence WhileInByte(string data, int version, int start, global::Infragistics.Controls.Barcodes.EncodingSequence sequence)
		{
			if (data.Length <= start)
			{
				return sequence;
			}
			bool flag = this.CouldBeKanji();
			bool flag2 = false;
			byte[] bytes = this.KanjiEncoding.GetBytes(data[start].ToString());
			if (flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(bytes))
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Kanji);
				sequence.BytesNumber.Add(1);
				flag2 = true;
			}
			int charsNumberByVersion = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
			{
				11,
				15,
				16
			}, version);
			int num = this.CheckBytesTypeByVersion(charsNumberByVersion, "EA", data, start);
			if (!flag2 && num == -1)
			{
				sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric);
				sequence.BytesNumber.Add(charsNumberByVersion);
				flag2 = true;
			}
			charsNumberByVersion = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
			{
				6,
				8,
				9
			}, version);
			num = this.CheckBytesTypeByVersion(charsNumberByVersion, "N", data, start);
			if (!flag2 && data.Length > start + charsNumberByVersion)
			{
				byte[] bytes2 = this.QrEncoding.GetBytes(data[start + charsNumberByVersion].ToString());
				int input = (bytes2.Length > 0) ? ((int)bytes2[0]) : -2;
				if (num == -1 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(input))
				{
					sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Numeric);
					sequence.BytesNumber.Add(charsNumberByVersion);
					flag2 = true;
				}
			}
			charsNumberByVersion = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
			{
				6,
				7,
				8
			}, version);
			num = this.CheckBytesTypeByVersion(charsNumberByVersion, "N", data, start);
			if (!flag2 && data.Length > start + charsNumberByVersion)
			{
				byte[] bytes2 = this.QrEncoding.GetBytes(data[start + charsNumberByVersion].ToString());
				int input = (bytes2.Length > 0) ? ((int)bytes2[0]) : -2;
				if (num == -1 && (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(input) || global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset(input)))
				{
					sequence.EncodingType.Add(global::Infragistics.Controls.Barcodes.EncodingMode.Numeric);
					sequence.BytesNumber.Add(charsNumberByVersion);
				}
			}
			return sequence;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00019738 File Offset: 0x00017938
		private static int GetCharsNumberByVersion(int[] vesrionApplicableArray, int version)
		{
			int result;
			if (version < 9)
			{
				result = vesrionApplicableArray[0];
			}
			else if (version < 27)
			{
				result = vesrionApplicableArray[1];
			}
			else
			{
				result = vesrionApplicableArray[2];
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00019760 File Offset: 0x00017960
		private static global::Infragistics.Controls.Barcodes.EncodingMode GetLastEncodingType(global::Infragistics.Controls.Barcodes.EncodingSequence encodingSequence)
		{
			if (encodingSequence.EncodingType.Count == 0)
			{
				return global::Infragistics.Controls.Barcodes.EncodingMode.Undefined;
			}
			return (global::Infragistics.Controls.Barcodes.EncodingMode)encodingSequence.EncodingType[encodingSequence.EncodingType.Count - 1];
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000197C4 File Offset: 0x000179C4
		private global::Infragistics.Controls.Barcodes.EncodingMode SelectInitialMode(string data, global::Infragistics.Controls.Barcodes.SizeVersion version)
		{
			bool flag = this.CouldBeKanji();
			if (flag && this.HasKanjiCharacters(data) && this.AreAllKanji(data))
			{
				return global::Infragistics.Controls.Barcodes.EncodingMode.Kanji;
			}
			if (flag && global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(this.KanjiEncoding.GetBytes(data)))
			{
				if (!this.HasKanjiCharacters(data[0].ToString()))
				{
					return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
				}
				return global::Infragistics.Controls.Barcodes.EncodingMode.Kanji;
			}
			else if (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset((int)data[0]))
			{
				int charsNumberByVersion = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
				{
					6,
					7,
					8
				}, (int)version);
				int num = this.CheckBytesTypeByVersion(charsNumberByVersion, "EA", data.Substring(1, data.Length - 1), 0);
				if (num != -1 && num != -2 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(num))
				{
					return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
				}
				if (num == -2)
				{
					num = this.CheckBytesTypeByVersion(data.Length - 1, "EA", data.Substring(1, data.Length - 1), 0);
					if (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(num))
					{
						return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
					}
				}
				return global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric;
			}
			else
			{
				if (!global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset((int)data[0]))
				{
					return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
				}
				int charsNumberByVersion2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
				{
					4,
					4,
					5
				}, (int)version);
				int num2 = this.CheckBytesTypeByVersion(charsNumberByVersion2, "N", data.Substring(1, data.Length - 1), 0);
				if (num2 != -2 && num2 != -1 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(num2))
				{
					return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
				}
				if (num2 == -2)
				{
					num2 = this.CheckBytesTypeByVersion(data.Length - 1, "N", data.Substring(1, data.Length - 1), 0);
					if (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(num2))
					{
						return global::Infragistics.Controls.Barcodes.EncodingMode.Byte;
					}
				}
				charsNumberByVersion2 = global::Infragistics.Controls.Barcodes.QRCodeEncoder.GetCharsNumberByVersion(new int[]
				{
					7,
					8,
					9
				}, (int)version);
				num2 = this.CheckBytesTypeByVersion(charsNumberByVersion2, "N", data.Substring(1, data.Length - 1), 0);
				if (num2 != -2 && num2 != -1 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(num2))
				{
					return global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric;
				}
				if (num2 == -2)
				{
					num2 = this.CheckBytesTypeByVersion(data.Length - 1, "N", data.Substring(1, data.Length - 1), 0);
					if (global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(num2))
					{
						return global::Infragistics.Controls.Barcodes.EncodingMode.Alphanumeric;
					}
				}
				return global::Infragistics.Controls.Barcodes.EncodingMode.Numeric;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000199C4 File Offset: 0x00017BC4
		private bool CouldBeKanji()
		{
			string text = string.Empty;
			global::Infragistics.IEncoding encoding = this.QrEncoding as global::Infragistics.IEncoding;
			if (encoding != null)
			{
				text = encoding.Name;
			}
			else
			{
				global::System.Text.Encoding qrEncoding = this.QrEncoding;
				if (qrEncoding != null)
				{
					text = this.QrEncoding.WebName;
				}
			}
			return text.Equals("iso-8859-1") || text.Equals("shift_jis");
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00019A20 File Offset: 0x00017C20
		private int CheckBytesTypeByVersion(int charsNumberToCheck, string mode, string data, int start)
		{
			if (start + charsNumberToCheck > data.Length)
			{
				return -2;
			}
			byte[] array = new byte[data.Length * 2];
			bool flag = false;
			if (mode.Equals("K"))
			{
				string text = data.Substring(start, charsNumberToCheck);
				array = this.KanjiEncoding.GetBytes(text);
				flag = (array.Length == text.Length * 2);
			}
			byte[] bytes = this.QrEncoding.GetBytes(data.Substring(start));
			for (int i = 0; i < charsNumberToCheck; i++)
			{
				int num = (int)bytes[i];
				if (mode.Equals("B") && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsAscii(num))
				{
					return num;
				}
				if (mode.Equals("EB") && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInByteExclSubset(num))
				{
					return num;
				}
				if (mode.Equals("K") && (!flag || !global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(new byte[]
				{
					array[2 * i],
					array[2 * i + 1]
				})))
				{
					return num;
				}
				if (mode.Equals("A") && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(num))
				{
					return num;
				}
				if (mode.Equals("EA") && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(num) && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset(num))
				{
					return num;
				}
				if (mode.Equals("N") && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset(num))
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00019B78 File Offset: 0x00017D78
		private string EncodeKanji(string data)
		{
			if (!this.AreAllKanji(data))
			{
				throw new global::System.ArgumentException(global::SR.GetString("WrongCompactionMode").Replace("{0}", "Kanji"));
			}
			byte[] bytes = this.KanjiEncoding.GetBytes(data);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.EncodeKanjiBytes(bytes);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00019BC0 File Offset: 0x00017DC0
		private static string EncodeKanjiBytes(byte[] dataBytes)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = dataBytes.Length;
			for (int i = 0; i < num; i += 2)
			{
				int num2 = (int)(dataBytes[i] & byte.MaxValue);
				int num3 = (int)(dataBytes[i + 1] & byte.MaxValue);
				int num4 = num2 << 8 | num3;
				int num5 = -1;
				if (num4 >= 33088 && num4 <= 40956)
				{
					num5 = num4 - 33088;
				}
				else if (num4 >= 57408 && num4 <= 60351)
				{
					num5 = num4 - 49472;
				}
				if (num5 == -1)
				{
					throw new global::System.ArgumentException("Invalid byte sequence");
				}
				stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, ((num5 >> 8) * 192 + (num5 & 255)).ToString(), 10).PadLeft(13, '0'));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00019C8F File Offset: 0x00017E8F
		private string EncodeByte(string data)
		{
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.EncodeByteBytes(this.QrEncoding.GetBytes(data));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00019CA4 File Offset: 0x00017EA4
		private static string EncodeByteBytes(byte[] dataBytes)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (byte b in dataBytes)
			{
				stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, ((int)(b & byte.MaxValue)).ToString(), 10).PadLeft(8, '0'));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00019CF8 File Offset: 0x00017EF8
		private string EncodeNumeric(string data, int bitsToFill)
		{
			byte[] bytes = this.QrEncoding.GetBytes(data);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.EncodeNumericBytes(bytes, bitsToFill);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00019D1C File Offset: 0x00017F1C
		private static string EncodeNumericBytes(byte[] dataBytes, int bitsToFill)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < dataBytes.Length; i += 3)
			{
				int num = dataBytes.Length - i;
				string text = string.Empty;
				if (num < 3)
				{
					for (int j = 0; j < num; j++)
					{
						text += (char)dataBytes[i + j];
					}
					stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text, 10).PadLeft(bitsToFill, '0'));
					break;
				}
				text = (char)dataBytes[i] + (char)dataBytes[i + 1] + (char)dataBytes[i + 2];
				stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, text, 10).PadLeft(10, '0'));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00019DD4 File Offset: 0x00017FD4
		private string EncodeAlphanumeric(string data)
		{
			byte[] bytes = this.QrEncoding.GetBytes(data);
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.EncodeAlphanumericBytes(bytes);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00019DF4 File Offset: 0x00017FF4
		private static string EncodeAlphanumericBytes(byte[] dataBytes)
		{
			global::System.Collections.Generic.Dictionary<byte, int> dictionary = new global::System.Collections.Generic.Dictionary<byte, int>();
			foreach (byte b in dataBytes)
			{
				if (!global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset((int)b) && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset((int)b))
				{
					string message = global::SR.GetString("WrongCompactionMode").Replace("{0}", "Alphanumeric");
					throw new global::System.ArgumentException(message);
				}
				int value = global::Infragistics.Controls.Barcodes.QRCodeEncoder.EncodeAlphanumericValue(b);
				dictionary[b] = value;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int j = 0;
			while (j < dataBytes.Length)
			{
				int num;
				if (dataBytes.Length - j >= 2)
				{
					byte[] array = new byte[]
					{
						dataBytes[j],
						dataBytes[j + 1]
					};
					num = dictionary[array[0]] * 45 + dictionary[array[1]];
					j += 2;
				}
				else
				{
					num = dictionary[dataBytes[j]];
					j++;
				}
				stringBuilder.Append(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(2, num.ToString(), 10).PadLeft((j % 2 == 0) ? 11 : 6, '0'));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00019F08 File Offset: 0x00018108
		private static int EncodeAlphanumericValue(byte index)
		{
			int result = 0;
			if (index >= 48 && index < 58)
			{
				result = (int)(index - 48);
			}
			else if (index >= 65 && index < 91)
			{
				result = (int)(index - 55);
			}
			else
			{
				if (index == 32)
				{
					result = 36;
				}
				if (index == 36)
				{
					result = 37;
				}
				if (index == 37)
				{
					result = 38;
				}
				if (index == 42)
				{
					result = 39;
				}
				if (index == 43)
				{
					result = 40;
				}
				if (index == 45)
				{
					result = 41;
				}
				if (index == 46)
				{
					result = 42;
				}
				if (index == 47)
				{
					result = 43;
				}
				if (index == 58)
				{
					result = 44;
				}
			}
			return result;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00019F84 File Offset: 0x00018184
		private bool HasKanjiCharacters(string data)
		{
			for (int i = 0; i < data.Length; i++)
			{
				byte[] bytes = this.KanjiEncoding.GetBytes(data[i].ToString());
				if (bytes.Length == 2 && global::Infragistics.Controls.Barcodes.QRCodeEncoder.AreBytesKanjiEncodable(bytes))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00019FD0 File Offset: 0x000181D0
		private bool AreAllKanji(string data)
		{
			byte[] bytes = this.KanjiEncoding.GetBytes(data);
			int num = bytes.Length;
			if (num % 2 != 0)
			{
				return false;
			}
			for (int i = 0; i < num; i += 2)
			{
				int num2 = (int)(bytes[i] & byte.MaxValue);
				if ((num2 < 129 || num2 > 159) && (num2 < 224 || num2 > 235))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001A02E File Offset: 0x0001822E
		internal static bool IsInNumericExclSubset(int input)
		{
			return input >= 48 && input <= 57;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001A040 File Offset: 0x00018240
		internal static bool AreBytesKanjiEncodable(byte[] bytes)
		{
			if (bytes.Length < 2)
			{
				return false;
			}
			for (int i = 0; i < bytes.Length; i += 2)
			{
				int num = (int)(bytes[i] & byte.MaxValue);
				if ((num >= 129 && num <= 159) || (num >= 224 && num <= 235))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001A090 File Offset: 0x00018290
		internal static bool IsAscii(int input)
		{
			return input >= 0 && input <= 255;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001A0A3 File Offset: 0x000182A3
		internal static bool IsInByteExclSubset(int input)
		{
			return global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsAscii(input) && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInAlphanumericExclSubset(input) && !global::Infragistics.Controls.Barcodes.QRCodeEncoder.IsInNumericExclSubset(input);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001A0C0 File Offset: 0x000182C0
		internal static bool IsInAlphanumericExclSubset(int input)
		{
			return (input >= 65 && input <= 90) || input == 32 || input == 36 || input == 37 || input == 42 || input == 43 || input == 45 || input == 46 || input == 47 || input == 58;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001A0FB File Offset: 0x000182FB
		internal static bool IsEciInRange(int eci)
		{
			return eci == 3 || (eci >= -1 && eci <= 999999);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001A114 File Offset: 0x00018314
		internal static bool IsApplicationIndicatorValid(string ai)
		{
			return (ai.Length == 2 && char.IsDigit(ai, 0) && char.IsDigit(ai, 1)) || (ai.Length == 1 && ((ai[0] >= 'a' && ai[0] <= 'z') || (ai[0] >= 'A' && ai[0] <= 'Z')));
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0001A17C File Offset: 0x0001837C
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0001A184 File Offset: 0x00018384
		private global::Infragistics.Controls.Barcodes.XamQRCodeBarcode Barcode { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0001A18D File Offset: 0x0001838D
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0001A195 File Offset: 0x00018395
		internal global::System.Text.Encoding QrEncoding { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001A19E File Offset: 0x0001839E
		private global::System.Text.Encoding KanjiEncoding
		{
			get
			{
				if (this._kanjiEncoding == null)
				{
					this._kanjiEncoding = base.GetEncoding("shift_jis");
				}
				return this._kanjiEncoding;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001A1BF File Offset: 0x000183BF
		private global::Infragistics.Controls.Barcodes.Fnc1Mode Fnc1Mode
		{
			get
			{
				return this.Barcode.Fnc1Mode;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001A1CC File Offset: 0x000183CC
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0001A1D4 File Offset: 0x000183D4
		private global::System.Collections.Generic.List<int> DataSize { get; set; }

		// Token: 0x0400011B RID: 283
		private const int InvalidValue = -2;

		// Token: 0x0400011C RID: 284
		private const int AllInclusive = -1;

		// Token: 0x0400011D RID: 285
		private const int EmptyCell = -1;

		// Token: 0x0400011E RID: 286
		private global::System.Text.Encoding _kanjiEncoding;

		// Token: 0x0400011F RID: 287
		private global::System.Collections.Generic.List<int> Fnc1Positions;

		// Token: 0x04000120 RID: 288
		private global::Infragistics.Controls.Barcodes.QRModeIndicator _modeIndicator;
	}
}
