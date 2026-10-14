using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200001C RID: 28
	public class RadiosChangeIndicatorToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00005C28 File Offset: 0x00003E28
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			global::Motorola.CommonCPS.RadioManagement.Converters.RadiosChangeIndicatorToVisibilityConverter.a a;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (!global::System.Enum.TryParse<global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator>((string)parameter, out a.a))
						{
							num2 = (short)1619984387;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection = value as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
						num2 = (short)897056774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_1E3;
					case 2:
						num2 = (short)1485897735;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_CD;
					case 4:
						num2 = (short)190513153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_E9;
					case 6:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection != null)
						{
							num2 = (short)1482555394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1E6;
					}
					case 7:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
						if (observableCollection.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(a.b)))
						{
							num2 = (short)1304035333;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1337822107;
						short num3 = num2;
						num2 = (short)349735835;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D;
						default:
							num2 = (short)1771962368;
							if (num2 != 0)
							{
							}
							num2 = (short)252444676;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_30;
				}
				IL_CD:
				return global::System.Windows.Visibility.Collapsed;
				IL_E9:
				global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
				IL_188:
				return visibility;
				IL_1E3:
				visibility = global::System.Windows.Visibility.Collapsed;
				goto IL_188;
				IL_1E6:
				return global::System.Windows.Visibility.Collapsed;
			}
			}
			IL_30:
			num2 = (short)1081278465;
			if (num2 != 0)
			{
			}
			a = new global::Motorola.CommonCPS.RadioManagement.Converters.RadiosChangeIndicatorToVisibilityConverter.a();
			IL_5D:
			num2 = (short)26476544;
			short num4 = num2;
			num2 = (short)220069888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005E24 File Offset: 0x00004024
		private static bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator A_1)
		{
			short num = (short)1068695552;
			short num2 = num;
			num = (short)1923945645;
			short num3 = num;
			num = (short)44307629;
			switch (num3 == num)
			{
			}
			num = (short)1060634625;
			if (num != 0)
			{
			}
			num = (short)156499968;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator changeIndicator = (global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator)A_0.ChangeIndicator;
			return changeIndicator.HasFlag(A_1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005EE8 File Offset: 0x000040E8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)422838272;
			short num2 = num;
			num = (short)893014763;
			short num3 = num;
			num = (short)1672434411;
			switch (num3 == num)
			{
			}
			num = (short)728104960;
			if (num != 0)
			{
			}
			num = (short)409731073;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000059 RID: 89 RVA: 0x00005FC0 File Offset: 0x000041C0
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
			{
				short num = (short)1479016448;
				short num2 = num;
				num = (short)1260661785;
				short num3 = num;
				num = (short)1223699481;
				switch (num3 == num)
				{
				}
				num = (short)183173121;
				if (num != 0)
				{
				}
				num = (short)183042048;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Converters.RadiosChangeIndicatorToVisibilityConverter.a(A_0, this.a);
			}

			// Token: 0x04000007 RID: 7
			public global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator a;
		}
	}
}
