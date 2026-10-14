using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000021 RID: 33
	internal class DataGridPropertiesToStatusTextConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000079B4 File Offset: 0x00005BB4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2022113280;
			switch (num)
			{
			default:
			{
				int num3;
				int num6;
				int num7;
				int num8;
				for (;;)
				{
					IL_1D:
					num = (short)920322049;
					if (num != 0)
					{
					}
					num = (short)3276801;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_11C;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7F;
							}
							continue;
						case 2:
							goto IL_15B;
						case 3:
							goto IL_11C;
						case 4:
							num3 = (int)values[0];
							num = (short)52953088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_7F:
						num = (short)796895320;
						short num4 = num;
						num = (short)1257416792;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						case 1:
							break;
						default:
						{
							num = (short)663617536;
							short num5 = num;
							break;
						}
						}
						num = (short)1737490432;
						if (num != 0)
						{
						}
						if ((bool)values[7])
						{
							num = (short)1784217604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (int)values[6];
						num = (short)1288110083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11C:
						num6 = (values[5] as global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder).GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>().Count<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						num7 = (int)values[3];
						num8 = (int)values[4];
						num = (short)1316290562;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_15B:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMDatagrid_StatusBarText, (num8 >= 0) ? num8 : num3, (num7 >= 0) ? num7 : num6);
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007B9C File Offset: 0x00005D9C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1773928786;
			short num2 = num;
			num = (short)2130968914;
			switch (num2 == num)
			{
			}
			num = (short)1403846656;
			if (num != 0)
			{
			}
			num = (short)1652490241;
			if (num != 0)
			{
			}
			num = (short)193265664;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
