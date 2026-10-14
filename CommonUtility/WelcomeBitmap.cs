using System;
using System.Drawing.Imaging;

namespace CommonUtility
{
	// Token: 0x02000030 RID: 48
	public class WelcomeBitmap
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0001B5DC File Offset: 0x000197DC
		public static void ImageMatchRadioModel(int bitsPerPixel, int colorLength, int width, int height, ref global::CommonUtility.WelcomeBitmap.WelcomeBitmapStruct bitMap)
		{
			switch (0)
			{
			case 0:
				goto IL_1F4;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_3F7;
				case 1:
					if (bitMap.ImageModel != global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZELK)
					{
						num2 = (short)289734702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_5F5;
				case 3:
					num2 = (short)2036727858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (height == 72)
					{
						num2 = (short)1993146417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BF9;
				case 5:
					if (bitMap.ImageModel != global::CommonUtility.WelcomeBitmap.ImageModelTypes.MALTA)
					{
						num2 = (short)101515359;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_988;
				case 6:
					if (height != 90)
					{
						num2 = (short)1291321413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD3;
				case 7:
					num2 = (short)298385413;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)106692702;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					bitMap.ImageModel = global::CommonUtility.WelcomeBitmap.ImageModelTypes.MALTA;
					num2 = (short)1011286086;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (width == 320)
					{
						num2 = (short)1157627933;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A0;
				case 11:
					num2 = (short)77201471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (bitsPerPixel == 16)
					{
						num2 = (short)903938048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
					bitMap.ImagePixelFormat = global::System.Drawing.Imaging.PixelFormat.Format1bppIndexed;
					num2 = (short)175046731;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1459486805;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)206569555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_5F5;
				case 17:
					if (height == 240)
					{
						num2 = (short)1572892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 18:
					num2 = (short)373358706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (colorLength == 0)
					{
						num2 = (short)1678377051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E2;
				case 20:
					if (width == 132)
					{
						num2 = (short)2039414894;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FE4;
				case 21:
					if (bitsPerPixel != 16)
					{
						num2 = (short)637861954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115E;
				case 22:
					goto IL_81A;
				case 23:
					if (width == 160)
					{
						num2 = (short)581959757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A3B;
				case 24:
					if (height != 72)
					{
						num2 = (short)857210995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_90A;
				case 25:
					goto IL_8CB;
				case 26:
					if (bitMap.ImageModel == global::CommonUtility.WelcomeBitmap.ImageModelTypes.MALTA)
					{
						num2 = (short)1110835225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E11;
				case 27:
					goto IL_5F5;
				case 28:
					goto IL_948;
				case 29:
					num2 = (short)306249775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (bitMap.ImagePixelFormat == global::System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
					{
						num2 = (short)1877147685;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F9F;
				case 31:
					num2 = (short)1942552588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (height != 90)
					{
						num2 = (short)1729953910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_948;
				case 33:
					goto IL_AB5;
				case 34:
					if (bitsPerPixel != 8)
					{
						num2 = (short)968228895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3F7;
				case 35:
					goto IL_88F;
				case 36:
					num2 = (short)1036976247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					num2 = (short)1669398529;
					if (num2 != 0)
					{
					}
					num2 = (short)1640956017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					num2 = (short)396623973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					goto IL_E6D;
				case 40:
					if (bitMap.ImageModel != global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZE)
					{
						num2 = (short)849018992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 41:
					if (width == 132)
					{
						num2 = (short)1036517478;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BF9;
				case 42:
					if (width == 132)
					{
						num2 = (short)1011220495;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5B6;
				case 43:
					goto IL_A01;
				case 44:
					if (bitMap.ImagePixelFormat == global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565)
					{
						num2 = (short)1210253412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115E;
				case 45:
					if (bitsPerPixel != 1)
					{
						num2 = (short)1493041261;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3F7;
				case 46:
					goto IL_90A;
				case 47:
					if (height == 240)
					{
						num2 = (short)1340538889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A0;
				case 48:
					if (colorLength != 0)
					{
						num2 = (short)2002321408;
						short num3 = num2;
						num2 = (short)23920679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 49:
					bitMap.ImageModel = global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZELK;
					num2 = (short)1241448450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					if (bitMap.ImageModel != global::CommonUtility.WelcomeBitmap.ImageModelTypes.BALI)
					{
						num2 = (short)422707256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 51:
					if (width == 132)
					{
						num2 = (short)1615593575;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA9;
				case 52:
					if (bitMap.ImagePixelFormat == global::System.Drawing.Imaging.PixelFormat.Format1bppIndexed)
					{
						num2 = (short)194445428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB5;
				case 53:
					if (height != 72)
					{
						num2 = (short)545914934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9C3;
				case 54:
					goto IL_699;
				case 55:
					goto IL_237;
				case 56:
					num2 = (short)454819945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 57:
					if (width == 132)
					{
						num2 = (short)1582628902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10A1;
				case 58:
					if (width == 0)
					{
						num2 = (short)1611137035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E2;
				case 59:
				{
					num2 = (short)1297208220;
					short num4 = num2;
					num2 = (short)1207620508;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B6;
					default:
						num2 = (short)1978597376;
						if (num2 != 0)
						{
						}
						if (bitsPerPixel == 16)
						{
							num2 = (short)1381105760;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 60:
					num2 = (short)1055064136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 61:
					num2 = (short)1163788305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					num2 = (short)1033568364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 63:
					if (height == 0)
					{
						num2 = (short)1784479812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E2;
				case 64:
					if (bitsPerPixel == 1)
					{
						num2 = (short)4718625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 65:
					if (bitsPerPixel == 1)
					{
						num2 = (short)714997822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F62;
				case 66:
					goto IL_51B;
				case 67:
					num2 = (short)2042429488;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 68:
					return;
				case 69:
					goto IL_FE4;
				case 70:
					goto IL_5F5;
				case 71:
					num2 = (short)2087059475;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 72:
					if (colorLength > 1024)
					{
						num2 = (short)2138243139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E6D;
				case 73:
					goto IL_F9F;
				case 74:
					goto IL_F62;
				case 75:
					goto IL_A01;
				case 76:
					goto IL_A01;
				case 77:
					num2 = (short)1113194603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 78:
					if (width == 160)
					{
						num2 = (short)668074082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_699;
				case 79:
					if (bitsPerPixel == 16)
					{
						num2 = (short)154140680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_988;
				case 80:
					bitMap.ImageModel = global::CommonUtility.WelcomeBitmap.ImageModelTypes.BALI;
					num2 = (short)411566107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 81:
					bitMap.ImageModel = global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZE;
					num2 = (short)880541712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 82:
					num2 = (short)24969248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 83:
					if (height == 90)
					{
						num2 = (short)1793785937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5B6;
				case 84:
					if (width == 160)
					{
						num2 = (short)1421148174;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_81A;
				case 85:
					if (height != 72)
					{
						num2 = (short)350027798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_948;
				case 86:
					if (colorLength != 8)
					{
						num2 = (short)2005729340;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E6D;
				case 87:
					num2 = (short)184090712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 88:
					if (colorLength <= 1024)
					{
						num2 = (short)1761280003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 89:
					if (width == 320)
					{
						num2 = (short)1000538173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 90:
					if (bitMap.ImageModel != global::CommonUtility.WelcomeBitmap.ImageModelTypes.BALI)
					{
						num2 = (short)706412664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 91:
					num2 = (short)1379401786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 92:
					if (bitsPerPixel == 1)
					{
						num2 = (short)1732968461;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2088829032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 93:
					goto IL_10A1;
				case 94:
					if (colorLength != 0)
					{
						num2 = (short)1157169159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 95:
					return;
				case 96:
					bitMap.ImagePixelFormat = global::System.Drawing.Imaging.PixelFormat.Format16bppRgb565;
					num2 = (short)1393360972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 97:
					if (width == 320)
					{
						num2 = (short)1690173458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_88F;
				case 98:
					num2 = (short)1410793525;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 99:
					if (width == 132)
					{
						num2 = (short)2051932242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_754;
				case 100:
					num2 = (short)2101280789;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 101:
					if (height != 72)
					{
						num2 = (short)712900701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_948;
				case 102:
					num2 = (short)310509572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 103:
					num2 = (short)1349779480;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 104:
					if (bitsPerPixel == 8)
					{
						num2 = (short)1501102191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1566441531;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 105:
					if (bitMap.ImageModel == global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZE)
					{
						num2 = (short)61669431;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 106:
					if (bitsPerPixel == 8)
					{
						num2 = (short)1975124055;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 107:
					if (height == 72)
					{
						num2 = (short)2112421968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A3B;
				case 108:
					if (colorLength == 8)
					{
						num2 = (short)1809776676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 109:
					num2 = (short)252903458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 110:
					num2 = (short)1055653894;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 111:
					bitMap.ImagePixelFormat = global::System.Drawing.Imaging.PixelFormat.Format8bppIndexed;
					num2 = (short)1190527019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 112:
					goto IL_DD3;
				case 113:
					if (bitsPerPixel == 8)
					{
						num2 = (short)1445331017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 114:
					if (height != 240)
					{
						num2 = (short)827654179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E11;
				case 115:
					goto IL_EA9;
				case 116:
					num2 = (short)1249837120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 117:
					if (bitsPerPixel == 0)
					{
						num2 = (short)1079509063;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E2;
				case 118:
					goto IL_754;
				case 119:
					if (bitMap.ImageModel == global::CommonUtility.WelcomeBitmap.ImageModelTypes.BELIZELK)
					{
						num2 = (short)1661075530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 120:
					goto IL_9C3;
				}
				goto IL_1F4;
				IL_237:
				num2 = (short)172687439;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3F7:
				num2 = (short)358416436;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5B6:
				num2 = (short)1184104489;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5F5:
				num2 = (short)1669791828;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_699:
				num2 = (short)1111752794;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_754:
				num2 = (short)1059323961;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_81A:
				num2 = (short)1626669155;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_88F:
				num2 = (short)1716781082;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_90A:
				num2 = (short)1950154849;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_948:
				num2 = (short)1282080846;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_988:
				num2 = (short)1304363100;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_9C3:
				num2 = (short)843448340;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A01:
				num2 = (short)2139684909;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A3B:
				num2 = (short)1804861482;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_AB5:
				num2 = (short)696778782;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_BF9:
				num2 = (short)713883658;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_DD3:
				num2 = (short)1275920435;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E11:
				num2 = (short)1487732822;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E6D:
				num2 = (short)1347289153;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_EA9:
				num2 = (short)1951465473;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F62:
				num2 = (short)228982890;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F9F:
				num2 = (short)1326317612;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_FE4:
				num2 = (short)508952616;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10A1:
				num2 = (short)952959065;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10E2:
				num2 = (short)1384382487;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_4A0:
			bitMap.ImageModel = global::CommonUtility.WelcomeBitmap.ImageModelTypes.NONE;
			return;
			IL_51B:
			return;
			IL_8CB:
			return;
			IL_115E:
			bitMap.MatchRadio = true;
			return;
			IL_1F4:
			bitMap.MatchRadio = false;
			num2 = (short)48627829;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x02000031 RID: 49
		public struct WelcomeBitmapStruct
		{
			// Token: 0x04000090 RID: 144
			public bool MatchRadio;

			// Token: 0x04000091 RID: 145
			public global::CommonUtility.WelcomeBitmap.ImageModelTypes ImageModel;

			// Token: 0x04000092 RID: 146
			public global::System.Drawing.Imaging.PixelFormat ImagePixelFormat;
		}

		// Token: 0x02000032 RID: 50
		public enum ImageModelTypes
		{
			// Token: 0x04000094 RID: 148
			NONE,
			// Token: 0x04000095 RID: 149
			BELIZE,
			// Token: 0x04000096 RID: 150
			BELIZELK,
			// Token: 0x04000097 RID: 151
			BALI = 4,
			// Token: 0x04000098 RID: 152
			MALTA = 8
		}
	}
}
