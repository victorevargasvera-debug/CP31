using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000096 RID: 150
	public class ProductFamilyToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00017554 File Offset: 0x00015754
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num2;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)1350565903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix)
						{
							num2 = (short)656408585;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)414777346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
						{
							num2 = (short)84869143;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_480;
					case 3:
						num2 = (short)32178186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)127598597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_E4;
					case 6:
						num2 = (short)915931150;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
						{
							num2 = (short)524550144;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)452853772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						goto IL_28B;
					case 9:
						num2 = (short)1737687051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_2D0;
					case 11:
						switch (productFamily)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX:
							goto IL_3EF;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix:
							goto IL_31C;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix:
							goto IL_487;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise:
							goto IL_C5;
						default:
							num2 = (short)778436629;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					case 12:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)1444478982;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_16D;
					case 13:
						if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
						{
							num2 = (short)1344274448;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1025376263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)386859012;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F2;
					case 15:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight)
						{
							num2 = (short)1683685398;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_126;
					case 16:
						num2 = (short)1472987137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 17:
						num2 = (short)859963400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 18:
					{
						num2 = (short)1700748614;
						short num3 = num2;
						num2 = (short)78404934;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num2 = (short)455147520;
							if (num2 != 0)
							{
							}
							num2 = (short)1583808513;
							if (num2 != 0)
							{
							}
							num2 = (short)1632829464;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 19:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix)
						{
							num2 = (short)1620312067;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_166;
					case 20:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
						{
							num2 = (short)754843665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_315;
					case 21:
						num2 = (short)718667795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 22:
						num2 = (short)842661913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 23:
						num2 = (short)1301544980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 24:
						goto IL_362;
					case 25:
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
						{
							num2 = (short)1890123794;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1EB;
					}
					break;
				}
				IL_81:
				productFamily = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value;
				num2 = (short)1192296461;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_C5:
			return 2;
			IL_E4:
			goto IL_487;
			IL_126:
			return 6;
			IL_166:
			return 3;
			IL_16D:
			return 8;
			IL_1EB:
			return 7;
			IL_1F2:
			return 9;
			IL_28B:
			num2 = (short)851574784;
			short num4 = num2;
			IL_2D0:
			goto IL_487;
			IL_315:
			return 5;
			IL_31C:
			return 1;
			IL_362:
			goto IL_487;
			IL_3EF:
			return 0;
			IL_480:
			return 4;
			IL_487:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("觫鳭苯鷱蛳", a_));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000179FC File Offset: 0x00015BFC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_EB;
				case 1:
					switch (num2)
					{
					case 0:
						goto IL_C2;
					case 1:
					{
						num3 = (short)1880913000;
						short num4 = num3;
						num3 = (short)796357736;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AD;
						default:
							goto IL_144;
						}
						break;
					}
					case 2:
						goto IL_18E;
					case 3:
						goto IL_106;
					case 4:
						goto IL_BA;
					case 5:
						goto IL_186;
					case 6:
						goto IL_AF;
					case 7:
						goto IL_F0;
					case 8:
						goto IL_C9;
					case 9:
						goto IL_FB;
					default:
					{
						num3 = (short)105250816;
						short num5 = num3;
						num3 = (short)1468923906;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					}
					break;
				case 2:
					goto IL_AD;
				}
				goto IL_25;
				IL_AD:
				num3 = (short)1665794048;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_AF:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight;
			IL_BA:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater;
			IL_C2:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
			IL_C9:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
			IL_EB:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("鋶诸觺鋼跾", a_));
			IL_F0:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller;
			IL_FB:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;
			IL_106:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix;
			IL_144:
			num3 = (short)810811393;
			if (num3 != 0)
			{
			}
			num3 = (short)1174536192;
			if (num3 != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix;
			IL_186:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater;
			IL_18E:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise;
			IL_25:
			num2 = (int)value;
			num3 = (short)812974081;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}
	}
}
