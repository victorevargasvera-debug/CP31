using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000203 RID: 515
	internal class NegateConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x000892A2 File Offset: 0x000874A2
		private NegateConverter()
		{
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000892AA File Offset: 0x000874AA
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return -(double)value;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x000892B8 File Offset: 0x000874B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000D3D RID: 3389
		internal static readonly global::System.Windows.Data.IValueConverter Instance = new global::Infragistics.Windows.DataPresenter.NegateConverter();
	}
}
