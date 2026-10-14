using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005A RID: 90
	public class IsMismatchAndDelaySyncNeedFixToBorderBrushConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2089943040;
			switch (num)
			{
			default:
			{
				num = (short)588316686;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool? flag;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)140312579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 1:
					{
						global::Motorola.Common.CustomException.CommonErrorCode? commonErrorCode;
						if (commonErrorCode != null)
						{
							num = (short)356122626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					}
					case 2:
						goto IL_1AB;
					case 3:
						num = (short)227344389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_27B;
					case 5:
					{
						if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1018691596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (bool?)values[0];
						bool flag2 = (bool)values[1];
						global::Motorola.Common.CustomException.CommonErrorCode? commonErrorCode = (global::Motorola.Common.CustomException.CommonErrorCode?)values[2];
						flag3 = flag;
						flag4 = true;
						num = (short)819331079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_13D;
					case 7:
						num = (short)1853030401;
						if (num != 0)
						{
						}
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)1416232970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 8:
						goto IL_227;
					case 9:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)608370694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F0;
					case 10:
					{
						num = (short)446300160;
						short num3 = num;
						num = (short)939458561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1708373994;
						short num4 = num;
						num = (short)1190246378;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F0;
						default:
							num = (short)66781184;
							if (num != 0)
							{
							}
							num = (short)1113784335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_35A;
					case 13:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)1901264904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					}
					case 14:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 15:
						if (values.Length != 3)
						{
							num = (short)507904004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)810942464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_84:
					if (values != null)
					{
						num = (short)705757195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_229;
					IL_F0:
					flag3 = flag;
					flag4 = true;
					num = (short)1519779849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F0:
					num = (short)1166802957;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13D:
				return global::System.Windows.Media.Brushes.Yellow;
				IL_1AB:
				return global::System.Windows.Media.Brushes.Red;
				IL_227:
				return global::System.Windows.Media.Brushes.Red;
				IL_229:
				return global::System.Windows.Media.Brushes.Transparent;
				IL_23B:
				return global::System.Windows.Media.Brushes.Transparent;
				IL_27B:
				goto IL_229;
				IL_35A:
				goto IL_23B;
				IL_35F:
				return global::System.Windows.Media.Brushes.Transparent;
			}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000F228 File Offset: 0x0000D428
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1539618040;
			short num2 = num;
			num = (short)1780528376;
			switch (num2 == num)
			{
			}
			num = (short)1895038977;
			if (num != 0)
			{
			}
			num = (short)2039152640;
			if (num != 0)
			{
			}
			num = (short)107544576;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
