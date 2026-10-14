using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Features.Converters
{
	// Token: 0x02000030 RID: 48
	public sealed class PackUnpackAsciiRegion : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000066A0 File Offset: 0x000048A0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)1898315780;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						if (value.ToString() == global::AllFeatures.CodeplugGuid.b("", a_))
						{
							num = (short)714276867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)408354821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_61;
					case 3:
						goto IL_188;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 5:
					{
						num = (short)1317863425;
						if (num != 0)
						{
						}
						if (!(value.ToString() == global::AllFeatures.CodeplugGuid.b("", a_)))
						{
							goto IL_1B6;
						}
						num = (short)1422930231;
						short num3 = num;
						num = (short)316813623;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1474166784;
							if (num != 0)
							{
							}
							num = (short)1706098688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_47:
					if (value == null)
					{
						num = (short)1063583746;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)567476225;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_61:
			return "";
			IL_125:
			return global::CommonResources.AcgResources.ID_ETSI;
			IL_188:
			num = (short)1457717248;
			short num4 = num;
			return global::CommonResources.AcgResources.ID_FCC;
			IL_1B6:
			return value.ToString();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000686C File Offset: 0x00004A6C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				IL_09:
				num = (short)1901592580;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_117;
					case 1:
						if (value.ToString() == global::CommonResources.AcgResources.ID_FCC)
						{
							num = (short)1284440067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1486094341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_60;
					case 3:
						goto IL_182;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 5:
					{
						if (!(value.ToString() == global::CommonResources.AcgResources.ID_ETSI))
						{
							goto IL_1B0;
						}
						num = (short)70553161;
						short num3 = num;
						num = (short)1018269257;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1974599680;
							if (num != 0)
							{
							}
							num = (short)1250230272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_45:
					if (value == null)
					{
						num = (short)1595867138;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1740636161;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_60:
			num = (short)1888354305;
			if (num != 0)
			{
			}
			return "";
			IL_117:
			return global::AllFeatures.CodeplugGuid.b("", a_);
			IL_182:
			num = (short)1038090240;
			short num4 = num;
			return global::AllFeatures.CodeplugGuid.b("", a_);
			IL_1B0:
			return value.ToString();
		}
	}
}
