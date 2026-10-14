using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200002E RID: 46
	internal class SetsCountToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00009C3C File Offset: 0x00007E3C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			for (;;)
			{
				IL_00:
				short num = (short)784072704;
				switch (num)
				{
				default:
				{
					num = (short)523829252;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_29B;
						case 1:
						{
							global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerable;
							if (enumerable != null)
							{
								num = (short)403308551;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_323;
						}
						case 2:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollection;
							global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerable = observableCollection.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.SetsCountToVisibilityConverter.<>c.<>9.a));
							num = (short)1538654209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_40A;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_9B;
							}
							continue;
						case 5:
							num = (short)1808793602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)992542736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)155975698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_B9;
						case 9:
							if (values[1] == null)
							{
								num = (short)437977091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)540868629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollection;
							if (observableCollection == null)
							{
								num = (short)1196621835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool flag = false;
							int count = observableCollection.Count;
							num = (short)537329677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_19A;
						case 12:
							num = (short)879230977;
							if (num != 0)
							{
							}
							num = (short)1494220817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							int count;
							if (count > 0)
							{
								num = (short)1196425221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_323;
						}
						case 14:
						{
							bool flag = true;
							num = (short)269615119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_323;
						case 16:
							goto IL_208;
						case 17:
						{
							if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
							{
								num = (short)359727104;
								short num3 = num;
								num = (short)856489984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4 = (int)values[0];
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollection = values[1] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>;
							num = (short)146145290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> enumerable;
							if (enumerable.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>() > 0)
							{
								num = (short)166068238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_323;
						}
						case 19:
						{
							bool flag;
							if (flag)
							{
								num = (short)613220358;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1241907220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							goto IL_427;
						case 21:
							if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
							{
								num = (short)1669988364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						IL_9B:
						if (values[0] == null)
						{
							num = (short)703004680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)945190234;
						short num5 = num;
						num = (short)88569178;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)12386304;
							if (num != 0)
							{
							}
							num = (short)1655177225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_323:
						num = (short)1102053395;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_B9:
			return global::System.Windows.Visibility.Collapsed;
			IL_19A:
			return global::System.Windows.Visibility.Collapsed;
			IL_19C:
			return global::System.Windows.Visibility.Collapsed;
			IL_208:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_42A;
			IL_29B:
			goto IL_19C;
			IL_40A:
			return global::System.Windows.Visibility.Collapsed;
			IL_427:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_42A:
			return visibility;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000A078 File Offset: 0x00008278
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)456330488;
			short num2 = num;
			num = (short)809831672;
			switch (num2 == num)
			{
			}
			num = (short)1848705024;
			if (num != 0)
			{
			}
			num = (short)1921712129;
			if (num != 0)
			{
			}
			num = (short)1766719488;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
