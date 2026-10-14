using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200000E RID: 14
	public class CodeplugCfgMenuVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00009F08 File Offset: 0x00008108
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::System.Windows.Visibility visibility;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_AD;
				case 1:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num2 = (short)1208877062;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				}
				case 2:
					visibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)1905852416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (value is global::AcpCommonLib.ApplicationMode)
					{
						goto IL_77;
					}
					goto IL_19A;
				case 4:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1292632066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				}
				case 5:
				{
					num2 = (short)721687313;
					short num3 = num2;
					num2 = (short)399381265;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
					{
						num2 = (short)250019840;
						if (num2 != 0)
						{
						}
						global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)value;
						num2 = (short)746258433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					num2 = (short)750256132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_77:
				num2 = (short)690290693;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AD:
			num2 = (short)94830593;
			if (num2 != 0)
			{
			}
			IL_19A:
			return visibility;
			IL_2C:
			num2 = (short)83296256;
			short num4 = num2;
			visibility = global::System.Windows.Visibility.Visible;
			num2 = (short)1357447171;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)581452542;
			short num2 = num;
			num = (short)852181758;
			switch (num2 == num)
			{
			}
			num = (short)1429536768;
			if (num != 0)
			{
			}
			num = (short)174260225;
			if (num != 0)
			{
			}
			num = (short)1995177984;
			short num3 = num;
			return null;
		}

		// Token: 0x04000022 RID: 34
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
