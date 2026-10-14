using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200006B RID: 107
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.CellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "FooterStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.FooterCellControl))]
	public class FillerColumnSettings : global::Infragistics.Controls.Grids.StyleSettingsBase
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000106E5 File Offset: 0x0000E8E5
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x000106F7 File Offset: 0x0000E8F7
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FillerColumnSettings.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FillerColumnSettings.HeaderStyleProperty, value);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00010708 File Offset: 0x0000E908
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FillerColumnSettings fillerColumnSettings = (global::Infragistics.Controls.Grids.FillerColumnSettings)obj;
			fillerColumnSettings.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00010727 File Offset: 0x0000E927
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00010739 File Offset: 0x0000E939
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FillerColumnSettings.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FillerColumnSettings.FooterStyleProperty, value);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00010748 File Offset: 0x0000E948
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FillerColumnSettings fillerColumnSettings = (global::Infragistics.Controls.Grids.FillerColumnSettings)obj;
			fillerColumnSettings.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FillerColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FillerColumnSettings.HeaderStyleChanged)));

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FillerColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FillerColumnSettings.FooterStyleChanged)));
	}
}
