using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000135 RID: 309
	public class ExtendedU1ValidConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x0016BB4C File Offset: 0x00169D4C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)410648595;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊뺌뢎", a_)))
					{
						num = (short)2046754841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				case 1:
					num = (short)1452670984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1677000704;
					short num3 = num;
					num = (short)685834240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뒌뺎", a_)))
					{
						num = (short)919339010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_426;
				case 4:
					num = (short)95682570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)146604055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					string text = values[1].ToString();
					num = (short)546963484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_4A7;
				case 8:
				{
					string text;
					if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[3]))
					{
						num = (short)1836646405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 9:
				{
					byte b;
					if ((b & 4) == 0)
					{
						goto IL_5DC;
					}
					num = (short)1104175231;
					short num4 = num;
					num = (short)1046831231;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A7;
					default:
						num = (short)1294729216;
						if (num != 0)
						{
						}
						num = (short)944635917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
				{
					string text;
					if (((byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[2]) & 2) != 0)
					{
						num = (short)1680080897;
						if (num != 0)
						{
						}
						num = (short)81657868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 11:
					num = (short)681443350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_38A;
				case 13:
					goto IL_1A8;
				case 14:
				{
					string text;
					if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[2]))
					{
						num = (short)685244417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 15:
				{
					string text;
					if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[2]))
					{
						num = (short)844496900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 16:
					num = (short)1134034961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뒌뢎", a_)))
					{
						num = (short)619839512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46C;
				case 18:
					num = (short)194969615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 20:
				{
					string text;
					if (text.Length >= 4)
					{
						num = (short)176619527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 21:
					num = (short)291635209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊뾌몎", a_)))
					{
						num = (short)1948450832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46C;
				case 23:
				{
					string text;
					bool flag = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[2]) != 0;
					byte b = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[3]);
					if (((flag ? 1 : 0) & 4) == 0)
					{
						num = (short)413794325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D6;
				}
				case 24:
					num = (short)1159069722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_426;
				case 26:
					if (values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊뺌뾎", a_)))
					{
						num = (short)1507917853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)895811587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (values.Length == 2)
					{
						num = (short)1712193542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				case 28:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뒌랎", a_)))
					{
						num = (short)1747255307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46C;
				case 29:
					goto IL_46C;
				case 30:
				{
					string text;
					if (text.Length >= 3)
					{
						num = (short)1416560658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DC;
				}
				case 31:
					num = (short)568459291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AE:
				if (values != null)
				{
					num = (short)406323231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5DC;
				IL_426:
				num = (short)110231582;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46C:
				num = (short)767688724;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A7:
				num = (short)967507982;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A8:
			goto IL_5D6;
			IL_38A:
			return global::System.Windows.Media.Brushes.Black;
			IL_5D6:
			return global::System.Windows.Media.Brushes.Black;
			IL_5DC:
			return global::System.Windows.Media.Brushes.Red;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0016C13C File Offset: 0x0016A33C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1865926406;
			short num2 = num;
			num = (short)1000916742;
			switch (num2 == num)
			{
			}
			num = (short)1004470273;
			if (num != 0)
			{
			}
			num = (short)1456013312;
			short num3 = num;
			num = (short)542244864;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
