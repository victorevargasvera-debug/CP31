using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000092 RID: 146
	public class EditabilityInComparatorCustomModesConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x0007E910 File Offset: 0x0007CB10
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)972816384;
			short num2 = num;
			num = (short)1617426788;
			short num3 = num;
			num = (short)1038940516;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FB:
				if ((global::AcpCommonLib.ApplicationMode)value != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					num = (short)329449473;
					if (num != 0)
					{
					}
					return true;
				}
				num = (short)834469892;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)121110528;
				if (num != 0)
				{
				}
				num = (short)1781006337;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_FB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 2:
					goto IL_E5;
				case 3:
					if ((global::AcpCommonLib.ApplicationMode)value != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1420230661;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15D;
				case 4:
					goto IL_11B;
				case 5:
					num = (short)803733504;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)740360194;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1112539139;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E5:
			return false;
			IL_11B:
			IL_15D:
			return false;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)499646465;
			if (num != 0)
			{
			}
			num = (short)880214016;
			short num2 = num;
			num = (short)1052186874;
			short num3 = num;
			num = (short)1950816506;
			switch (num3 == num)
			{
			}
			num = (short)1243545600;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
