using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000059 RID: 89
	public class DMR3ProductFamilyToVALPEnable : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600010E RID: 270 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6D;
				case 1:
					num2 = (short)1328676866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_88;
				case 3:
					if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num2 = (short)200015876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				case 4:
					num2 = (short)250544133;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)565968897;
					if (num2 != 0)
					{
					}
					if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
					{
						num2 = (short)458096641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				case 6:
					if (productFamily == null)
					{
						num2 = (short)416940032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1017708547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_124;
				}
				goto IL_30;
				IL_10D:
				num2 = (short)1121255431;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_6D:
			return true;
			IL_88:
			bool flag = productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;
			goto IL_1E3;
			IL_124:
			num2 = (short)842421685;
			short num3 = num2;
			num2 = (short)807163317;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6D;
			default:
			{
				num2 = (short)63373312;
				short num4 = num2;
				num2 = (short)1372454912;
				if (num2 != 0)
				{
				}
				flag = false;
				break;
			}
			}
			IL_1E3:
			return flag;
			IL_30:
			productFamily = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?)value;
			num2 = (short)1260388358;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1546119871;
			short num2 = num;
			num = (short)260958911;
			switch (num2 == num)
			{
			}
			num = (short)446365697;
			if (num != 0)
			{
			}
			num = (short)414187520;
			if (num != 0)
			{
			}
			num = (short)1661009920;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
