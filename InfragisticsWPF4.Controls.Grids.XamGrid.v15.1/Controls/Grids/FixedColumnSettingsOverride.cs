using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000F8 RID: 248
	public class FixedColumnSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase, global::System.IDisposable
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00020FD3 File Offset: 0x0001F1D3
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00020FE5 File Offset: 0x0001F1E5
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FixedColumnType>))]
		public global::Infragistics.Controls.Grids.FixedColumnType? AllowFixedColumns
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedColumnType?)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.AllowFixedColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.AllowFixedColumnsProperty, value);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		private static void AllowFixedColumnsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("AllowFixedColumns");
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00021018 File Offset: 0x0001F218
		public global::Infragistics.Controls.Grids.FixedColumnType AllowFixedColumnsResolved
		{
			get
			{
				if (this.AllowFixedColumns != null)
				{
					return this.AllowFixedColumns.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).AllowFixedColumns;
				}
				return (global::Infragistics.Controls.Grids.FixedColumnType)global::Infragistics.Controls.Grids.FixedColumnSettings.AllowFixedColumnsProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FixedColumnSettings)).DefaultValue;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0002107B File Offset: 0x0001F27B
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x0002108D File Offset: 0x0001F28D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FixedIndicatorDirection>))]
		public global::Infragistics.Controls.Grids.FixedIndicatorDirection? FixedIndicatorDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedIndicatorDirection?)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedIndicatorDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedIndicatorDirectionProperty, value);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000210A0 File Offset: 0x0001F2A0
		private static void FixedIndicatorDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedIndicatorDirection");
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000210C0 File Offset: 0x0001F2C0
		public global::Infragistics.Controls.Grids.FixedIndicatorDirection FixedIndicatorDirectionResolved
		{
			get
			{
				if (this.FixedIndicatorDirection != null)
				{
					return this.FixedIndicatorDirection.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedIndicatorDirection;
				}
				return (global::Infragistics.Controls.Grids.FixedIndicatorDirection)global::Infragistics.Controls.Grids.FixedColumnSettings.FixedIndicatorDirectionProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FixedColumnSettings)).DefaultValue;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00021123 File Offset: 0x0001F323
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00021135 File Offset: 0x0001F335
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FixedDropAreaLocation>))]
		public global::Infragistics.Controls.Grids.FixedDropAreaLocation? FixedDropAreaLocation
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FixedDropAreaLocation?)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLocationProperty, value);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00021148 File Offset: 0x0001F348
		private static void FixedDropAreaLocationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedDropAreaLocation");
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00021168 File Offset: 0x0001F368
		public global::Infragistics.Controls.Grids.FixedDropAreaLocation FixedDropAreaLocationResolved
		{
			get
			{
				if (this.FixedDropAreaLocation != null)
				{
					return this.FixedDropAreaLocation.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedDropAreaLocation;
				}
				return (global::Infragistics.Controls.Grids.FixedDropAreaLocation)global::Infragistics.Controls.Grids.FixedColumnSettings.FixedDropAreaLocationProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FixedColumnSettings)).DefaultValue;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000211CB File Offset: 0x0001F3CB
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000211DD File Offset: 0x0001F3DD
		public global::System.Windows.Style FixedBorderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderStyleProperty, value);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000211EC File Offset: 0x0001F3EC
		private static void FixedBorderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedBorderStyle");
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0002120B File Offset: 0x0001F40B
		public global::System.Windows.Style FixedBorderStyleResolved
		{
			get
			{
				if (this.FixedBorderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedBorderStyle;
				}
				return this.FixedBorderStyle;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00021234 File Offset: 0x0001F434
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00021246 File Offset: 0x0001F446
		public global::System.Windows.Style FixedBorderHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderHeaderStyleProperty, value);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00021254 File Offset: 0x0001F454
		private static void FixedBorderHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedBorderHeaderStyle");
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00021273 File Offset: 0x0001F473
		public global::System.Windows.Style FixedBorderHeaderStyleResolved
		{
			get
			{
				if (this.FixedBorderHeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedBorderHeaderStyle;
				}
				return this.FixedBorderHeaderStyle;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002129C File Offset: 0x0001F49C
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000212AE File Offset: 0x0001F4AE
		public global::System.Windows.Style FixedBorderFooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderFooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderFooterStyleProperty, value);
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000212BC File Offset: 0x0001F4BC
		private static void FixedBorderFooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedBorderFooterStyle");
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000212DB File Offset: 0x0001F4DB
		public global::System.Windows.Style FixedBorderFooterStyleResolved
		{
			get
			{
				if (this.FixedBorderFooterStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedBorderFooterStyle;
				}
				return this.FixedBorderFooterStyle;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00021304 File Offset: 0x0001F504
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00021316 File Offset: 0x0001F516
		public global::System.Windows.Style FixedDropAreaLeftStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLeftStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLeftStyleProperty, value);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00021324 File Offset: 0x0001F524
		private static void FixedDropAreaLeftStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedDropAreaLeftStyle");
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00021343 File Offset: 0x0001F543
		public global::System.Windows.Style FixedDropAreaLeftStyleResolved
		{
			get
			{
				if (this.FixedDropAreaLeftStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedDropAreaLeftStyle;
				}
				return this.FixedDropAreaLeftStyle;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0002136C File Offset: 0x0001F56C
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0002137E File Offset: 0x0001F57E
		public global::System.Windows.Style FixedDropAreaRightStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaRightStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaRightStyleProperty, value);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002138C File Offset: 0x0001F58C
		private static void FixedDropAreaRightStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = (global::Infragistics.Controls.Grids.FixedColumnSettingsOverride)obj;
			fixedColumnSettingsOverride.OnPropertyChanged("FixedDropAreaRightStyle");
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000213AB File Offset: 0x0001F5AB
		public global::System.Windows.Style FixedDropAreaRightStyleResolved
		{
			get
			{
				if (this.FixedDropAreaRightStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FixedColumnSettings)this.SettingsObject).FixedDropAreaRightStyle;
				}
				return this.FixedDropAreaRightStyle;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000213D4 File Offset: 0x0001F5D4
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsLeft
		{
			get
			{
				if (this._fixedColumnsCollectionLeft == null)
				{
					this._fixedColumnsCollectionLeft = new global::Infragistics.Controls.Grids.FixedColumnsCollection(global::Infragistics.Controls.Grids.FixedState.Left);
				}
				return this._fixedColumnsCollectionLeft;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000213F0 File Offset: 0x0001F5F0
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsRight
		{
			get
			{
				if (this._fixedColumnsCollectionRight == null)
				{
					this._fixedColumnsCollectionRight = new global::Infragistics.Controls.Grids.FixedColumnsCollection(global::Infragistics.Controls.Grids.FixedState.Right);
				}
				return this._fixedColumnsCollectionRight;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0002140C File Offset: 0x0001F60C
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.FixedColumnSettings;
				}
				return result;
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00021442 File Offset: 0x0001F642
		protected virtual void Dispose(bool disposing)
		{
			if (this._fixedColumnsCollectionLeft != null)
			{
				this._fixedColumnsCollectionLeft.Dispose();
			}
			if (this._fixedColumnsCollectionRight != null)
			{
				this._fixedColumnsCollectionRight.Dispose();
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0002146A File Offset: 0x0001F66A
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040001FF RID: 511
		private global::Infragistics.Controls.Grids.FixedColumnsCollection _fixedColumnsCollectionLeft;

		// Token: 0x04000200 RID: 512
		private global::Infragistics.Controls.Grids.FixedColumnsCollection _fixedColumnsCollectionRight;

		// Token: 0x04000201 RID: 513
		public static readonly global::System.Windows.DependencyProperty AllowFixedColumnsProperty = global::System.Windows.DependencyProperty.Register("AllowFixedColumns", typeof(global::Infragistics.Controls.Grids.FixedColumnType?), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.AllowFixedColumnsChanged)));

		// Token: 0x04000202 RID: 514
		public static readonly global::System.Windows.DependencyProperty FixedIndicatorDirectionProperty = global::System.Windows.DependencyProperty.Register("FixedIndicatorDirection", typeof(global::Infragistics.Controls.Grids.FixedIndicatorDirection?), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedIndicatorDirectionChanged)));

		// Token: 0x04000203 RID: 515
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaLocationProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaLocation", typeof(global::Infragistics.Controls.Grids.FixedDropAreaLocation?), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLocationChanged)));

		// Token: 0x04000204 RID: 516
		public static readonly global::System.Windows.DependencyProperty FixedBorderStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderStyleChanged)));

		// Token: 0x04000205 RID: 517
		public static readonly global::System.Windows.DependencyProperty FixedBorderHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderHeaderStyleChanged)));

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty FixedBorderFooterStyleProperty = global::System.Windows.DependencyProperty.Register("FixedBorderFooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedBorderFooterStyleChanged)));

		// Token: 0x04000207 RID: 519
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaLeftStyleProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaLeftStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaLeftStyleChanged)));

		// Token: 0x04000208 RID: 520
		public static readonly global::System.Windows.DependencyProperty FixedDropAreaRightStyleProperty = global::System.Windows.DependencyProperty.Register("FixedDropAreaRightStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FixedColumnSettingsOverride.FixedDropAreaRightStyleChanged)));
	}
}
