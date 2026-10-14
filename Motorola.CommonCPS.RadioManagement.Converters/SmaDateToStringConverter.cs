using System;
using System.Globalization;
using System.Windows.Data;
using CommonUtility;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000023 RID: 35
	public class SmaDateToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00007108 File Offset: 0x00005308
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 10;
			short num = (short)706674688;
			short num2 = num;
			string result = string.Empty;
			if (value != null)
			{
				try
				{
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					int num3;
					byte b;
					for (;;)
					{
						IL_4B:
						switch (num3)
						{
						case 0:
						{
							if (b == 0)
							{
								num = (short)1917517826;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)544563182;
							short num4 = num;
							num = (short)161964014;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_175;
							default:
								num = (short)270139392;
								if (num != 0)
								{
								}
								result = new global::CommonUtility.SMAConverter().ConvertNumberToDateTimeString(b, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("룴뫶훸鿺駼탾砀稂簄縆", a_), null);
								num = (short)1782185987;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_175;
						case 2:
							result = global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
							num = (short)1794113540;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_15E;
						case 4:
							goto IL_15E;
						}
						goto IL_65;
						IL_15E:
						num = (short)1487208449;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_175:
					return result;
					IL_65:
					b = global::System.Convert.ToByte(value);
					num = (short)896598017;
					if (num != 0)
					{
					}
					num = (short)932970496;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_4B;
				}
				catch (global::System.FormatException)
				{
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				}
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000072B4 File Offset: 0x000054B4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			byte b;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)854205944;
					short num3 = num2;
					num2 = (short)364848632;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)958857216;
						if (num2 != 0)
						{
						}
						if (value != null)
						{
							num2 = (short)954466305;
							if (num2 != 0)
							{
							}
							num2 = (short)894107650;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17C;
					}
					break;
				}
				case 1:
					if (!object.Equals(value, global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable))
					{
						num2 = (short)938934275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17C;
				case 2:
				{
					num2 = (short)1683095552;
					short num4 = num2;
					goto IL_13B;
				}
				case 3:
					try
					{
						b = new global::CommonUtility.SMAConverter().ConvertDateTimeStringToByte(value.ToString(), global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("믵뗷헹飻髽⿿笁紃缅焇", a_), null);
						goto IL_17C;
					}
					catch (global::System.FormatException e)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(e, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뿵雷賹鷻鋽槿昁␃琅洇昉椋漍挏眑㐓爕礗渙礛", a_));
						goto IL_17C;
					}
					goto IL_13B;
				}
				goto IL_29;
				IL_13B:
				num2 = (short)846200833;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17C:
			return b;
			IL_29:
			b = 0;
			num2 = (short)166395904;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
