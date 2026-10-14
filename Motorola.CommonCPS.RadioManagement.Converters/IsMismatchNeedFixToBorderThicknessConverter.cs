using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005B RID: 91
	public class IsMismatchNeedFixToBorderThicknessConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)33423371;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1777017437;
				short num3 = num;
				num = (short)2010194525;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_188;
				case 1:
					break;
				default:
				{
					num = (short)2133262336;
					short num4 = num;
					break;
				}
				}
				num = (short)1776549888;
				if (num != 0)
				{
				}
				bool flag2;
				switch (num2)
				{
				case 0:
				{
					bool flag;
					if (flag || flag2)
					{
						goto IL_188;
					}
					goto IL_2B1;
				}
				case 1:
					goto IL_134;
				case 2:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)7995398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C;
				case 3:
					goto IL_1A0;
				case 4:
					if (values.Length != 2)
					{
						num = (short)45416458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)933756930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1188036615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					bool flag = false;
					num = (short)1521221641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)1846018053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_26C;
				case 8:
					num = (short)420544516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (values[0] != null)
					{
						num = (short)653459468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 10:
					goto IL_1DB;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_CA;
					}
					continue;
				case 12:
				{
					bool flag = (bool)values[0];
					num = (short)1586561025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_CA:
				if (values != null)
				{
					num = (short)2000420872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_120;
				IL_134:
				flag2 = (bool)values[1];
				num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)393674752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_188:
				num = (short)1653342211;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			return new global::System.Windows.Thickness(0.0);
			IL_120:
			return new global::System.Windows.Thickness(0.0);
			IL_1A0:
			return new global::System.Windows.Thickness(1.0);
			IL_1DB:
			goto IL_120;
			IL_26C:
			goto IL_10C;
			IL_2B1:
			return new global::System.Windows.Thickness(0.0);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1884249439;
			short num2 = num;
			num = (short)381181279;
			switch (num2 == num)
			{
			}
			num = (short)1505034241;
			if (num != 0)
			{
			}
			num = (short)1975910400;
			if (num != 0)
			{
			}
			num = (short)1506803712;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
