using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000073 RID: 115
	public class PrintPreviewIDToNAConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00012A14 File Offset: 0x00010C14
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			short num = (short)1784086528;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				num = (short)1449328641;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 1:
					goto IL_FC;
				case 2:
					goto IL_141;
				case 3:
				{
					num = (short)1217275445;
					short num3 = num;
					num = (short)1590568501;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						num = (short)2139750400;
						if (num != 0)
						{
						}
						num = (short)235864065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (int.TryParse(value.ToString(), out num4))
					{
						num = (short)1226244099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 5:
					goto IL_88;
				}
				IL_6E:
				if (value == null)
				{
					num = (short)1737949189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)68616196;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FC:
				num = (short)129564672;
				short num5 = num;
				if (num4 < 0)
				{
					goto IL_14C;
				}
				num = (short)148963330;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_88:
			return "";
			IL_141:
			return num4.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			IL_14C:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("맶훸뫺", a_);
			IL_19E:
			return "";
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1932547937;
			short num2 = num;
			num = (short)1686001505;
			switch (num2 == num)
			{
			}
			num = (short)1500577793;
			if (num != 0)
			{
			}
			num = (short)1983381504;
			if (num != 0)
			{
			}
			num = (short)850264064;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
