using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000243 RID: 579
	public abstract class ComboBoxColumnBase : global::Infragistics.Controls.Grids.CustomDisplayEditableColumn
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00043D05 File Offset: 0x00041F05
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00043D17 File Offset: 0x00041F17
		public global::System.Windows.Data.IValueConverter FilterMenuItemConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumnBase.FilterMenuItemConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumnBase.FilterMenuItemConverterProperty, value);
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00043D28 File Offset: 0x00041F28
		private static void FilterMenuItemConverterPropertyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumnBase comboBoxColumnBase = (global::Infragistics.Controls.Grids.ComboBoxColumnBase)obj;
			comboBoxColumnBase.OnPropertyChanged("FilterMenuItemConverter");
		}

		// Token: 0x040005BB RID: 1467
		public static readonly global::System.Windows.DependencyProperty FilterMenuItemConverterProperty = global::System.Windows.DependencyProperty.Register("FilterMenuItemConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Controls.Grids.ComboBoxColumnBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumnBase.FilterMenuItemConverterPropertyChanged)));
	}
}
