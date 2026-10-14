using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200001F RID: 31
	internal class DockedLocationToSplitterOrientationConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0000828C File Offset: 0x0000648C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (!(value is global::Infragistics.Windows.DockManager.PaneLocation))
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			switch ((global::Infragistics.Windows.DockManager.PaneLocation)value)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				return global::Infragistics.KnownBoxes.OrientationVerticalBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				return global::Infragistics.KnownBoxes.OrientationHorizontalBox;
			default:
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000082DB File Offset: 0x000064DB
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}

		// Token: 0x04000090 RID: 144
		public static readonly global::Infragistics.Windows.DockManager.DockedLocationToSplitterOrientationConverter Instance = new global::Infragistics.Windows.DockManager.DockedLocationToSplitterOrientationConverter();
	}
}
