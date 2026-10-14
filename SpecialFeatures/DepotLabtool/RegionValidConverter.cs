using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000136 RID: 310
	public class RegionValidConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x0016C1E8 File Offset: 0x0016A3E8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)2140602391;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1952828246;
					short num3 = num;
					num = (short)1740950358;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
					{
						num = (short)156565504;
						if (num != 0)
						{
						}
						string text;
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[2]))
						{
							num = (short)82771986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_696;
					}
					}
					break;
				}
				case 1:
					num = (short)1063452672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1118240799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1206517787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_5E7;
				case 5:
					if (!(values[2].ToString() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힐킒횔랖\uda98춠쪢쒤즦\udda8", a_)))
					{
						num = (short)815857686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_177;
				case 6:
					if (values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90ꂒꖔ", a_)))
					{
						num = (short)52756496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1119354891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					string text;
					if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[3]))
					{
						num = (short)1656160259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 8:
				{
					string text;
					if (text.Length >= 4)
					{
						num = (short)1044709377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 9:
				{
					num = (short)156041216;
					short num4 = num;
					num = (short)915472385;
					if (num != 0)
					{
					}
					string text;
					if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(text[2]))
					{
						num = (short)220135437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 10:
					if (values.Length == 3)
					{
						num = (short)140640286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				case 11:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud990ꪒ꒔", a_)))
					{
						num = (short)1097138178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				case 12:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud990ꪒꊔ", a_)))
					{
						num = (short)2078277656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51E;
				case 13:
					num = (short)146604051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud990ꪒ궔", a_)))
					{
						num = (short)768016413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51E;
				case 15:
					goto IL_17D;
				case 16:
					goto IL_51E;
				case 17:
				{
					string text;
					if (text.Length >= 3)
					{
						num = (short)25165845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 18:
					goto IL_132;
				case 19:
				{
					string text;
					if (((byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[2]) & 2) != 0)
					{
						num = (short)1695875104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 20:
					goto IL_20D;
				case 21:
					num = (short)1983315977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1382613020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					switch (0)
					{
					case 0:
						goto IL_BE;
					}
					continue;
				case 24:
					num = (short)1372848134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)1757741082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
				{
					byte b;
					if ((b & 4) != 0)
					{
						num = (short)1307901956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				}
				case 27:
				{
					string text;
					bool flag = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[2]) != 0;
					byte b = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(text[3]);
					if (((flag ? 1 : 0) & 4) == 0)
					{
						num = (short)1230569497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_212;
				}
				case 28:
				{
					if (values[2].ToString() == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎐잒솔튖릘\ud89a토쾢첤욦잨\udfaa", a_))
					{
						num = (short)1367146516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string text = values[1].ToString();
					num = (short)906362894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
					num = (short)294977569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)643825669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90ꂒꊔ", a_)))
					{
						num = (short)332857359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_696;
				case 32:
					goto IL_25B;
				case 33:
					if (!values[0].ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90ꆒꂔ", a_)))
					{
						num = (short)857866274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51E;
				case 34:
					num = (short)782106636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)664797194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BE:
				if (values != null)
				{
					num = (short)898039843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_696;
				IL_132:
				num = (short)2128805895;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17D:
				num = (short)1945108497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51E:
				num = (short)7798792;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_177:
			return global::System.Windows.Media.Brushes.Black;
			IL_20D:
			goto IL_177;
			IL_212:
			return global::System.Windows.Media.Brushes.Black;
			IL_25B:
			return global::System.Windows.Media.Brushes.Black;
			IL_5E7:
			goto IL_212;
			IL_696:
			return global::System.Windows.Media.Brushes.Red;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0016C890 File Offset: 0x0016AA90
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)697171969;
			if (num != 0)
			{
			}
			num = (short)753793745;
			short num2 = num;
			num = (short)1249704657;
			switch (num2 == num)
			{
			}
			num = (short)1031733248;
			short num3 = num;
			num = (short)1644888064;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
