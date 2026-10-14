using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000084 RID: 132
	public class LinkTypeToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00014C0C File Offset: 0x00012E0C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)723714051;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5E;
				case 1:
					num = (short)24707076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.LinkType linkType;
					switch (linkType)
					{
					case global::Motorola.CommonCPS.Server.EntityModel.LinkType.SINGLESITE:
						goto IL_170;
					case global::Motorola.CommonCPS.Server.EntityModel.LinkType.PEER:
						goto IL_63;
					case global::Motorola.CommonCPS.Server.EntityModel.LinkType.MASTER:
						goto IL_11A;
					default:
						num = (short)574029825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
					goto IL_A6;
				}
				IL_42:
				if (value == null)
				{
					num = (short)1544552448;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.Server.EntityModel.LinkType linkType = (global::Motorola.CommonCPS.Server.EntityModel.LinkType)value;
					num = (short)1740374018;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5E:
			return null;
			IL_63:
			num = (short)2000748544;
			short num3 = num;
			return 1;
			IL_A6:
			num = (short)1548943361;
			if (num != 0)
			{
			}
			num = (short)16076139;
			short num4 = num;
			num = (short)1651199339;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11A:
				return 2;
			default:
				num = (short)556859392;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("鯽狿瀁欃琅", a_));
			}
			IL_170:
			return 0;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00014DA4 File Offset: 0x00012FA4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
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
					goto IL_104;
				case 1:
					switch (num2)
					{
					case 0:
						goto IL_E6;
					case 1:
						goto IL_6D;
					case 2:
						goto IL_106;
					default:
						num3 = (short)1287585794;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				case 2:
					num3 = (short)965738496;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_25;
			}
			IL_6D:
			num3 = (short)1703704403;
			short num4 = num3;
			num3 = (short)1551595347;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10D:
				num3 = (short)325451776;
				short num5 = num3;
				throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("釳蓵諷闹軻", a_));
			}
			default:
				num3 = (short)207290368;
				if (num3 != 0)
				{
				}
				num3 = (short)29818881;
				if (num3 != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.EntityModel.LinkType.PEER;
			}
			IL_E6:
			return global::Motorola.CommonCPS.Server.EntityModel.LinkType.SINGLESITE;
			IL_104:
			goto IL_10D;
			IL_106:
			return global::Motorola.CommonCPS.Server.EntityModel.LinkType.MASTER;
			IL_25:
			num2 = (int)value;
			num3 = (short)1761214465;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}
	}
}
