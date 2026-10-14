using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000057 RID: 87
	public class MigrationJobContainerStateVisibilyConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000E86C File Offset: 0x0000CA6C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)424083458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11A;
				case 1:
					num = (short)11534336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)867486454;
					short num3 = num;
					num = (short)1235340022;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1422196736;
						short num4 = num;
						num = (short)1625096193;
						if (num != 0)
						{
						}
						num = (short)467402752;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_102;
				}
				IL_CE:
				if ((global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus)value != global::Motorola.CommonCPS.RadioManagement.UIModels.ContainerStatus.COMPLETE)
				{
					num = (short)362414081;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)517865475;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_102:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_11D;
			IL_11A:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_11D:
			return visibility;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E99C File Offset: 0x0000CB9C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1810255047;
			short num2 = num;
			num = (short)278351047;
			switch (num2 == num)
			{
			}
			num = (short)37552129;
			if (num != 0)
			{
			}
			num = (short)436404224;
			if (num != 0)
			{
			}
			num = (short)1371930624;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
