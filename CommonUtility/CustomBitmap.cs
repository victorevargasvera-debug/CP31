using System;

namespace CommonUtility
{
	// Token: 0x0200002B RID: 43
	public class CustomBitmap
	{
		// Token: 0x06000109 RID: 265 RVA: 0x0001AD74 File Offset: 0x00018F74
		public bool ProcessBMP(ref global::CommonUtility.CustomBitmap.BitmapStruct sbmp, byte[] bytesFile)
		{
			int a_ = 11;
			short num = (short)378667008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				byte[] array;
				byte[] array2;
				byte[] array3;
				for (;;)
				{
					IL_30:
					int num3;
					int num5;
					switch (num2)
					{
					case 0:
						if (num3 >= sbmp.Header.FileSize)
						{
							num = (short)106430464;
							short num4 = num;
							num = (short)1677459463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num5] = bytesFile[num3];
						num5++;
						num3++;
						num = (short)1204748296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_15D;
					case 2:
						goto IL_DC;
					case 3:
					{
						if (!sbmp.Header.Identifier.Equals(global::CommonUtility.VersionUtility.b("縻猽", a_)))
						{
							num = (short)29229058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[0] = bytesFile[2];
						array2[1] = bytesFile[3];
						array2[2] = bytesFile[4];
						array2[3] = bytesFile[5];
						sbmp.Header.FileSize = this.b(array2);
						array2[0] = bytesFile[10];
						array2[1] = bytesFile[11];
						array2[2] = bytesFile[12];
						array2[3] = bytesFile[13];
						sbmp.Header.BitMapDataOffset = this.b(array2);
						array2[0] = bytesFile[14];
						array2[1] = bytesFile[15];
						array2[2] = bytesFile[16];
						array2[3] = bytesFile[17];
						sbmp.Header.BitMapHeaderSize = this.b(array2);
						array2[0] = bytesFile[18];
						array2[1] = bytesFile[19];
						array2[2] = bytesFile[20];
						array2[3] = bytesFile[21];
						sbmp.Header.Width = this.b(array2);
						array2[0] = bytesFile[22];
						array2[1] = bytesFile[23];
						array2[2] = bytesFile[24];
						array2[3] = bytesFile[25];
						sbmp.Header.Height = this.b(array2);
						array3[0] = bytesFile[26];
						array3[1] = bytesFile[27];
						sbmp.Header.Planes = (short)this.b(array3);
						array3[0] = bytesFile[28];
						array3[1] = bytesFile[29];
						sbmp.Header.BitsPerPixel = (short)this.b(array3);
						array2[0] = bytesFile[30];
						array2[1] = bytesFile[31];
						array2[2] = bytesFile[32];
						array2[3] = bytesFile[33];
						sbmp.Header.Compression = this.b(array2);
						array2[0] = bytesFile[34];
						array2[1] = bytesFile[35];
						array2[2] = bytesFile[36];
						array2[3] = bytesFile[37];
						sbmp.Header.BitMapDataSize = this.b(array2);
						array2[0] = bytesFile[38];
						array2[1] = bytesFile[39];
						array2[2] = bytesFile[40];
						array2[3] = bytesFile[41];
						sbmp.Header.HResolution = this.b(array2);
						array2[0] = bytesFile[42];
						array2[1] = bytesFile[43];
						array2[2] = bytesFile[44];
						array2[3] = bytesFile[45];
						sbmp.Header.VResolution = this.b(array2);
						array2[0] = bytesFile[46];
						array2[1] = bytesFile[47];
						array2[2] = bytesFile[48];
						array2[3] = bytesFile[49];
						sbmp.Header.Colors = this.b(array2);
						array2[0] = bytesFile[50];
						array2[1] = bytesFile[51];
						array2[2] = bytesFile[52];
						array2[3] = bytesFile[53];
						sbmp.Header.ImportantColors = this.b(array2);
						num5 = 0;
						array = new byte[sbmp.Header.BitMapDataOffset - 54];
						int num6 = 54;
						num = (short)536084486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num6;
						if (num6 >= sbmp.Header.BitMapDataOffset)
						{
							num = (short)1296957449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num5] = bytesFile[num6];
						num5++;
						num6++;
						num = (short)880082945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_415;
					case 6:
						goto IL_15D;
					case 7:
					{
						num = (short)1914290992;
						short num7 = num;
						num = (short)1575994160;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_108;
						default:
							goto IL_514;
						}
						break;
					}
					case 8:
						goto IL_415;
					case 9:
						goto IL_108;
					}
					goto IL_5F;
					IL_108:
					sbmp.Palette.Palette = array;
					num5 = 0;
					array = new byte[sbmp.Header.FileSize - sbmp.Header.BitMapDataOffset];
					num3 = sbmp.Header.BitMapDataOffset;
					num = (short)1246822405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					num = (short)1057751044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_415:
					num = (short)532938752;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DC:
				num = (short)1764884481;
				if (num != 0)
				{
				}
				return false;
				IL_514:
				num = (short)172752896;
				if (num != 0)
				{
				}
				sbmp.Data.BitMapData = array;
				return true;
				IL_5F:
				array3 = new byte[2];
				array2 = new byte[4];
				array3[0] = bytesFile[0];
				array3[1] = bytesFile[1];
				sbmp.Header.Identifier = this.a(array3);
				num = (short)16252931;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001B2B8 File Offset: 0x000194B8
		private int b(byte[] A_0)
		{
			short num = (short)1167732161;
			short num2 = num;
			num = (short)508833217;
			int num7;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)37879809;
				if (num != 0)
				{
				}
				num = (short)225247232;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				int num3;
				int num6;
				for (;;)
				{
					IL_7C:
					switch (num3)
					{
					case 0:
						goto IL_175;
					case 1:
						goto IL_C3;
					case 2:
						goto IL_175;
					case 3:
						goto IL_1A9;
					case 4:
					{
						num = (short)1578762240;
						short num4 = num;
						int num5 = (int)global::System.Math.Pow(256.0, (double)num6);
						num7 += (int)A_0[num6] * num5;
						num = (short)2052718593;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num6 < 0)
						{
							num = (short)1122172931;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)345505798;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_0[num6] != 0)
						{
							num = (short)1931608068;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3;
					}
					goto IL_9E;
					IL_C3:
					num6--;
					num = (short)682754050;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					num = (short)1950285829;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A9:
				break;
				IL_9E:
				num7 = 0;
				num6 = A_0.Length - 1;
				num = (short)1953955840;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
			return num7;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001B474 File Offset: 0x00019674
		private string a(byte[] A_0)
		{
			short num = (short)100990976;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num3;
			string text;
			int num4;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					goto IL_69;
				case 1:
					goto IL_69;
				case 2:
					return text;
				case 3:
				{
					if (num4 >= A_0.Length)
					{
						num = (short)625147906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					text += global::System.Convert.ToChar((int)A_0[num4]).ToString();
					num4++;
					num = (short)1684078593;
					if (num != 0)
					{
					}
					num = (short)707791474;
					short num5 = num;
					num = (short)1296566898;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return text;
					default:
						num = (short)2818048;
						if (num != 0)
						{
						}
						num = (short)520224769;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4A;
				IL_69:
				num = (short)648085507;
				num3 = (int)((global::System.IntPtr)num);
			}
			return text;
			IL_4A:
			text = string.Empty;
			num4 = 0;
			num = (short)1833631744;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x0200002C RID: 44
		public struct BitmapStruct
		{
			// Token: 0x0400007D RID: 125
			public global::CommonUtility.CustomBitmap.BMPHeader Header;

			// Token: 0x0400007E RID: 126
			public global::CommonUtility.CustomBitmap.BMPPalette Palette;

			// Token: 0x0400007F RID: 127
			public global::CommonUtility.CustomBitmap.BMPData Data;
		}

		// Token: 0x0200002D RID: 45
		public struct BMPHeader
		{
			// Token: 0x04000080 RID: 128
			public string Identifier;

			// Token: 0x04000081 RID: 129
			public int FileSize;

			// Token: 0x04000082 RID: 130
			public int BitMapDataOffset;

			// Token: 0x04000083 RID: 131
			public int BitMapHeaderSize;

			// Token: 0x04000084 RID: 132
			public int Width;

			// Token: 0x04000085 RID: 133
			public int Height;

			// Token: 0x04000086 RID: 134
			public short Planes;

			// Token: 0x04000087 RID: 135
			public short BitsPerPixel;

			// Token: 0x04000088 RID: 136
			public int Compression;

			// Token: 0x04000089 RID: 137
			public int BitMapDataSize;

			// Token: 0x0400008A RID: 138
			public int HResolution;

			// Token: 0x0400008B RID: 139
			public int VResolution;

			// Token: 0x0400008C RID: 140
			public int Colors;

			// Token: 0x0400008D RID: 141
			public int ImportantColors;
		}

		// Token: 0x0200002E RID: 46
		public struct BMPPalette
		{
			// Token: 0x0400008E RID: 142
			public byte[] Palette;
		}

		// Token: 0x0200002F RID: 47
		public struct BMPData
		{
			// Token: 0x0400008F RID: 143
			public byte[] BitMapData;
		}
	}
}
