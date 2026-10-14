using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200007E RID: 126
	public class MenuItemsRemoveBtnConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x00078E58 File Offset: 0x00077058
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)525860873;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::System.Convert.ToInt32(values[1]) < 0)
					{
						num = (short)2114125831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1546059778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)230555654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_240;
				case 2:
				{
					num = (short)2089723672;
					short num3 = num;
					num = (short)1261414168;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
					{
						num = (short)2038956032;
						if (num != 0)
						{
						}
						int num4;
						if (num4 > 1)
						{
							num = (short)1851195396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					}
					}
					break;
				}
				case 3:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1619066885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_240;
				case 4:
					goto IL_108;
				case 5:
					num = (short)1182728193;
					if (num != 0)
					{
					}
					num = (short)1031536641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1166934016;
					short num5 = num;
					int num4 = global::System.Convert.ToInt32(values[0]);
					num = (short)850460672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_1D3;
				case 8:
					goto IL_86;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				}
				IL_4E:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)367984648;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1051197443;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_86:
			return false;
			IL_108:
			return true;
			IL_10A:
			return false;
			IL_177:
			return false;
			IL_1D3:
			goto IL_10A;
			IL_240:
			return false;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000790AC File Offset: 0x000772AC
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)580287867;
			short num2 = num;
			num = (short)450526587;
			switch (num2 == num)
			{
			}
			num = (short)1934491649;
			if (num != 0)
			{
			}
			num = (short)836894720;
			if (num != 0)
			{
			}
			num = (short)1829961728;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
