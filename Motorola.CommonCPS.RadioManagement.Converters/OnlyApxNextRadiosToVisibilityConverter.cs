using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000018 RID: 24
	public class OnlyApxNextRadiosToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000508C File Offset: 0x0000328C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)785261896;
					short num3 = num2;
					num2 = (short)922101064;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)831520768;
						if (num2 != 0)
						{
						}
						if (observableCollection == null)
						{
							goto IL_1D1;
						}
						break;
					}
					num2 = (short)488046595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_D6;
				case 2:
					if (!observableCollection.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.OnlyApxNextRadiosToVisibilityConverter.a)))
					{
						num2 = (short)1706819585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)999751685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)762576900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (observableCollection.Count > 0)
					{
						num2 = (short)183959558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 5:
					goto IL_D0;
				case 6:
					num2 = (short)331350017;
					if (num2 != 0)
					{
					}
					num2 = (short)611581954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_EE;
				}
				goto IL_30;
				IL_D6:
				num2 = (short)1909850119;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D0:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_17F;
			IL_EE:
			num2 = (short)1951006720;
			short num4 = num2;
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_17F:
			return visibility;
			IL_1D1:
			return global::System.Windows.Visibility.Collapsed;
			IL_30:
			observableCollection = (value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
			num2 = (short)1626800128;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005270 File Offset: 0x00003470
		private static bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1831731200;
				short num2 = num;
				if (A_0.ProductFamily != null)
				{
					break;
				}
				num = (short)2040600986;
				short num3 = num;
				num = (short)965941658;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BA;
				}
			}
			num = (short)675282945;
			if (num != 0)
			{
			}
			return A_0.ProductFamily.Value.HasFlag(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP);
			IL_BA:
			num = (short)103546880;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005350 File Offset: 0x00003550
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1796472832;
			short num2 = num;
			num = (short)383486536;
			short num3 = num;
			num = (short)138119752;
			switch (num3 == num)
			{
			}
			num = (short)1867120641;
			if (num != 0)
			{
			}
			num = (short)435879936;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
