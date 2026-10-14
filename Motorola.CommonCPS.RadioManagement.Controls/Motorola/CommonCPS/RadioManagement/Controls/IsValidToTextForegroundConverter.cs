using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001D RID: 29
	internal class IsValidToTextForegroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000070F0 File Offset: 0x000052F0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			if ((bool)value)
			{
				short num = (short)40821557;
				short num2 = num;
				num = (short)1280828213;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1464991744;
					short num3 = num;
					num = (short)773980160;
					if (num != 0)
					{
					}
					num = (short)1662517249;
					if (num != 0)
					{
					}
					return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud899펟쪡즥욧\udea9\udeab솭\udcaf\udbb3쒵\uddb7\uddb9캻톽떿곁ꃃ軅Ꟈ볉꧋볍", a_)];
				}
				}
			}
			return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud899펟쪡ﮣ욧\udca9춫슭\ud9af횱", a_)];
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000071E8 File Offset: 0x000053E8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2143391918;
			short num2 = num;
			num = (short)1601015982;
			switch (num2 == num)
			{
			}
			num = (short)1537540096;
			if (num != 0)
			{
			}
			num = (short)1685716993;
			if (num != 0)
			{
			}
			num = (short)1306001408;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
