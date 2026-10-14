using System;
using System.Globalization;
using System.Windows.Data;

namespace MackinawCPS
{
	// Token: 0x02000011 RID: 17
	public class ProgramCertificateEnableConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000A590 File Offset: 0x00008790
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1203961856;
			short num2 = num;
			num = (short)957123235;
			short num3 = num;
			num = (short)56330915;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F5:
				num = (short)272039937;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)196214784;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				break;
			}
			for (;;)
			{
				IL_81:
				switch (num4)
				{
				case 0:
					if (value is bool)
					{
						num = (short)1024262145;
						if (num != 0)
						{
						}
						num = (short)1150681090;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
				case 1:
					goto IL_10C;
				case 2:
					goto IL_EC;
				}
				goto IL_93;
			}
			IL_EC:
			bool flag = (bool)value;
			goto IL_F5;
			IL_10C:
			IL_10E:
			return flag;
			IL_93:
			flag = false;
			num = (short)1193082880;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_81;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000A6B4 File Offset: 0x000088B4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)626873899;
			short num2 = num;
			num = (short)1759729195;
			switch (num2 == num)
			{
			}
			num = (short)897712129;
			if (num != 0)
			{
			}
			num = (short)144310272;
			if (num != 0)
			{
			}
			num = (short)989921280;
			short num3 = num;
			return null;
		}

		// Token: 0x04000025 RID: 37
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
