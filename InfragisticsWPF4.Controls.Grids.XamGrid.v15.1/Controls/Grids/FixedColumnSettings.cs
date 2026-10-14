using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000F7 RID: 247
	public class FixedColumnSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00020B94 File Offset: 0x0001ED94
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00020BA6 File Offset: 0x0001EDA6
		public global::Infragistics.Controls.Grids.FixedColumnType AllowFixedColumns
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedColumnType)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.AllowFixedColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.AllowFixedColumnsProperty, value);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00020BBC File Offset: 0x0001EDBC
		private static void AllowFixedColumnsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("AllowFixedColumns");
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00020BDB File Offset: 0x0001EDDB
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00020BED File Offset: 0x0001EDED
		public global::Infragistics.Controls.Grids.FixedIndicatorDirection FixedIndicatorDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedIndicatorDirection)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedIndicatorDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedIndicatorDirectionProperty, value);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00020C00 File Offset: 0x0001EE00
		private static void FixedDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedIndicatorDirection");
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00020C1F File Offset: 0x0001EE1F
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00020C31 File Offset: 0x0001EE31
		public global::Infragistics.Controls.Grids.FixedDropAreaLocation FixedDropAreaLocation
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedDropAreaLocation)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLocationProperty, value);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00020C44 File Offset: 0x0001EE44
		private static void FixedDropAreaLocationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedDropAreaLocation");
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00020C63 File Offset: 0x0001EE63
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00020C75 File Offset: 0x0001EE75
		public global::System.Windows.Style FixedBorderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderStyleProperty, value);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00020C84 File Offset: 0x0001EE84
		private static void FixedBorderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedBorderStyle");
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00020CA3 File Offset: 0x0001EEA3
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00020CB5 File Offset: 0x0001EEB5
		public global::System.Windows.Style FixedBorderHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderHeaderStyleProperty, value);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		private static void FixedBorderHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedBorderHeaderStyle");
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00020CE3 File Offset: 0x0001EEE3
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00020CF5 File Offset: 0x0001EEF5
		public global::System.Windows.Style FixedBorderFooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderFooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderFooterStyleProperty, value);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00020D04 File Offset: 0x0001EF04
		private static void FixedBorderFooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedBorderFooterStyle");
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00020D23 File Offset: 0x0001EF23
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00020D35 File Offset: 0x0001EF35
		public global::System.Windows.Style FixedDropAreaLeftStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLeftStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLeftStyleProperty, value);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00020D44 File Offset: 0x0001EF44
		private static void FixedDropAreaLeftStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedDropAreaLeftStyle");
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00020D63 File Offset: 0x0001EF63
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00020D75 File Offset: 0x0001EF75
		public global::System.Windows.Style FixedDropAreaRightStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaRightStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaRightStyleProperty, value);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00020D84 File Offset: 0x0001EF84
		private static void FixedDropAreaRightStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettings fixedColumnSettings = (global::Infragistics.Controls.Grids.FixedColumnSettings)obj;
			fixedColumnSettings.OnPropertyChanged("FixedDropAreaRightStyle");
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00020DA4 File Offset: 0x0001EFA4
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsLeft
		{
			get
			{
				global::Infragistics.Controls.Grids.FixedColumnsCollection result = null;
				if (base.Grid != null)
				{
					result = base.Grid.RowsManager.ColumnLayout.FixedColumnSettings.FixedColumnsLeft;
				}
				return result;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsRight
		{
			get
			{
				global::Infragistics.Controls.Grids.FixedColumnsCollection result = null;
				if (base.Grid != null)
				{
					result = base.Grid.RowsManager.ColumnLayout.FixedColumnSettings.FixedColumnsRight;
				}
				return result;
			}
		}

		// Token: 0x040001F7 RID: 503
		public static readonly global::System.Windows.DependencyProperty AllowFixedColumnsProperty = global::System.Windows.DependencyProperty.Register("AllowFixedColumns", typeof(global::Infragistics.Controls.Grids.FixedColumnType), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FixedColumnType.Disabled, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.AllowFixedColumnsChanged)));

		// Token: 0x040001F8 RID: 504
		public static readonly global::System.Windows.DependencyProperty FixedIndicatorDirectionProperty = global::System.Windows.DependencyProperty.Register("FixedIndicatorDirection", typeof(global::Infragistics.Controls.Grids.FixedIndicatorDirection), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FixedIndicatorDirection.Left, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDirectionChanged)));

		// Token: 0x040001F9 RID: 505
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaLocationProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaLocation", typeof(global::Infragistics.Controls.Grids.FixedDropAreaLocation), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FixedDropAreaLocation.Both, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLocationChanged)));

		// Token: 0x040001FA RID: 506
		public static readonly global::System.Windows.DependencyProperty FixedBorderStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderStyleChanged)));

		// Token: 0x040001FB RID: 507
		public static readonly global::System.Windows.DependencyProperty FixedBorderHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderHeaderStyleChanged)));

		// Token: 0x040001FC RID: 508
		public static readonly global::System.Windows.DependencyProperty FixedBorderFooterStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderFooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedBorderFooterStyleChanged)));

		// Token: 0x040001FD RID: 509
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaLeftStyleProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaLeftStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLeftStyleChanged)));

		// Token: 0x040001FE RID: 510
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaRightStyleProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaRightStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaRightStyleChanged)));
	}
}
