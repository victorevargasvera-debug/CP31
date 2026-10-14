using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using SpecialFeatures.Comms;

namespace SpecialFeatures.CloneWizard
{
	// Token: 0x02000197 RID: 407
	public class SerialNumberValidMultiConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x001C311C File Offset: 0x001C131C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_62;
			}
			short num;
			int num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)189530113;
				if (num != 0)
				{
				}
				object obj;
				switch (num2)
				{
				case 0:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)163971075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B;
				case 1:
				{
					num = (short)794762237;
					short num3 = num;
					num = (short)1340087293;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F0;
					case 1:
						goto IL_1CD;
					}
					goto Block_4;
				}
				case 2:
					goto IL_F7;
				case 3:
					num = (short)1135411209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)131989511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					string s = (string)obj;
					flag = global::SpecialFeatures.Comms.SerialNumberValidator.ValidateSerialNumber(global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(s)));
					num = (short)880869377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (obj != null)
					{
						num = (short)1972305925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B;
				case 7:
					if (!(bool)values[0])
					{
						num = (short)1110114306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F0;
				case 8:
					goto IL_B0;
				case 9:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1596325892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B;
				case 10:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)526712840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1063911424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_62;
				IL_1F0:
				obj = values[1];
				num = (short)602013702;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B0:
			return false;
			IL_F7:
			return true;
			Block_4:
			num = (short)1724776448;
			short num4 = num;
			IL_1CD:
			num = (short)177340416;
			if (num != 0)
			{
			}
			IL_26B:
			return flag;
			IL_62:
			flag = false;
			num = (short)1196621834;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x001C339C File Offset: 0x001C159C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)779719004;
			short num2 = num;
			num = (short)1643549020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1522008064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1600913409;
			if (num != 0)
			{
			}
			num = (short)201195520;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
