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
	// Token: 0x02000019 RID: 25
	public class OnlySingleApxNextRadioToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00005414 File Offset: 0x00003614
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
					num2 = (short)1006098598;
					short num3 = num2;
					num2 = (short)1100994726;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)274792449;
						if (num2 != 0)
						{
						}
						num2 = (short)1055457280;
						if (num2 != 0)
						{
						}
						if (observableCollection == null)
						{
							goto IL_1CC;
						}
						break;
					}
					num2 = (short)1143799811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_FC;
				case 2:
					if (!observableCollection.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.OnlySingleApxNextRadioToVisibilityConverter.a)))
					{
						num2 = (short)2002649089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1690959877;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1916928004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (observableCollection.Count == 1)
					{
						num2 = (short)522846214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FC;
				case 5:
					goto IL_F6;
				case 6:
					num2 = (short)1788477442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_13D;
				}
				goto IL_30;
				IL_FC:
				num2 = (short)641925120;
				short num4 = num2;
				num2 = (short)911015943;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F6:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_17A;
			IL_13D:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_17A:
			return visibility;
			IL_1CC:
			return global::System.Windows.Visibility.Collapsed;
			IL_30:
			observableCollection = (value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
			num2 = (short)1217462272;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000055F4 File Offset: 0x000037F4
		private static bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num;
			for (;;)
			{
				num = (short)249495552;
				short num2 = num;
				if (A_0.ProductFamily != null)
				{
					break;
				}
				num = (short)664929811;
				short num3 = num;
				num = (short)171050515;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_93;
				}
			}
			return A_0.ProductFamily.Value.HasFlag(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP);
			IL_93:
			num = (short)2034368512;
			if (num != 0)
			{
			}
			num = (short)819265537;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000056D4 File Offset: 0x000038D4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)138346496;
			short num2 = num;
			num = (short)742327095;
			short num3 = num;
			num = (short)427492151;
			switch (num3 == num)
			{
			}
			num = (short)76480513;
			if (num != 0)
			{
			}
			num = (short)1316356096;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
