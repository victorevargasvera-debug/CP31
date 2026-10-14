using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200001E RID: 30
	public class ContentValidationConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00008230 File Offset: 0x00006430
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00008238 File Offset: 0x00006438
		public string ErrorMessage { get; set; }

		// Token: 0x060001A0 RID: 416 RVA: 0x00008244 File Offset: 0x00006444
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Media.Visual)
			{
				return new global::System.Windows.Controls.TextBlock
				{
					Text = this.ErrorMessage,
					Foreground = global::System.Windows.Media.Brushes.Red,
					Background = global::System.Windows.Media.Brushes.White
				};
			}
			return value;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008284 File Offset: 0x00006484
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
