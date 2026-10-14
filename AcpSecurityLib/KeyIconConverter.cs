using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;

namespace AcpSecurityLib
{
	// Token: 0x02000003 RID: 3
	public class KeyIconConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			short num;
			string result;
			for (;;)
			{
				IL_13:
				num = (short)693108736;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
				{
					global::AcpASKLib.KeySource keySource;
					if (keySource != global::AcpASKLib.KeySource.HARDWARE)
					{
						num = (short)1161822210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				}
				case 1:
				{
					global::AcpASKLib.KeySource keySource;
					if (keySource != global::AcpASKLib.KeySource.LEGACY_KEY_FILE)
					{
						num = (short)375717891;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("ﻐ뫒뛔룖럘꣚곞軠藢釤郦裨駪裬ꓮ铰諲\udbf4蟶韸鳺", a_);
					num = (short)340262917;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1665859585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1348796417;
					if (num != 0)
					{
					}
					num = (short)1004929030;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				}
				goto IL_5E;
			}
			return result;
			IL_5E:
			num = (short)838460842;
			short num4 = num;
			num = (short)816768426;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F2:
				result = global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("ﻐ뫒뛔룖럘꣚뛞菠離釤鏦蛨藪쏬鿮鿰铲", a_);
				num = (short)114294788;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)275316736;
				if (num != 0)
				{
				}
				result = global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("ﻐ뫒뛔룖럘꣚뛞菠離釤鏦蛨藪쏬鿮鿰铲", a_);
				global::AcpASKLib.KeySource keySource = (global::AcpASKLib.KeySource)value;
				num = (short)2116747264;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022EC File Offset: 0x000004EC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)161677312;
			short num2 = num;
			num = (short)131969857;
			short num3 = num;
			num = (short)912831297;
			switch (num3 == num)
			{
			}
			num = (short)335675393;
			if (num != 0)
			{
			}
			num = (short)897581056;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
