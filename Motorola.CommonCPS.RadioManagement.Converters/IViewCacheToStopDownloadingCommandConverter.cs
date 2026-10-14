using System;
using System.Globalization;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000067 RID: 103
	public class IViewCacheToStopDownloadingCommandConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000139 RID: 313 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = values[0] as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
			if (viewCache == null)
			{
				short num = (short)1226532611;
				short num2 = num;
				num = (short)937912067;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1911422976;
					if (num != 0)
					{
					}
					num = (short)65339392;
					short num3 = num;
					num = (short)2081226753;
					if (num != 0)
					{
					}
					return null;
				}
				}
			}
			return new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(viewCache.StopDownloading), new global::System.Func<bool>(viewCache.CanStopDownloading));
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00011298 File Offset: 0x0000F498
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1215430656;
			short num2 = num;
			num = (short)1010099802;
			short num3 = num;
			num = (short)142599770;
			switch (num3 == num)
			{
			}
			num = (short)29425665;
			if (num != 0)
			{
			}
			num = (short)1813643264;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
