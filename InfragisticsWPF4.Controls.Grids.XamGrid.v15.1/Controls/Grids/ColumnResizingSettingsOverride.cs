using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000024 RID: 36
	public class ColumnResizingSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0000A0FC File Offset: 0x000082FC
		public ColumnResizingSettingsOverride()
		{
			this._indicatorContainer = new global::System.Windows.Controls.Primitives.Popup();
			this._indicator = new global::Infragistics.Controls.Grids.Primitives.ResizingIndicator();
			this._indicatorContainer.Child = this._indicator;
			this._indicatorContainer.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._indicatorContainer.AllowsTransparency = true;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000A150 File Offset: 0x00008350
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.ColumnResizingSettings;
				}
				return result;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000A188 File Offset: 0x00008388
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Grids.Primitives.ResizingIndicator Indicator
		{
			get
			{
				global::System.Windows.Style indicatorStyleResolved = this.IndicatorStyleResolved;
				if (this._indicator.Style != indicatorStyleResolved)
				{
					this._indicator.Style = indicatorStyleResolved;
				}
				return this._indicator;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000A1BC File Offset: 0x000083BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Windows.Controls.Primitives.Popup IndicatorContainer
		{
			get
			{
				return this._indicatorContainer;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000A1C4 File Offset: 0x000083C4
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000A1D6 File Offset: 0x000083D6
		public global::System.Windows.Style IndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.IndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.IndicatorStyleProperty, value);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A1E4 File Offset: 0x000083E4
		private static void IndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride)obj;
			columnResizingSettingsOverride.OnPropertyChanged("IndicatorStyle");
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A203 File Offset: 0x00008403
		public global::System.Windows.Style IndicatorStyleResolved
		{
			get
			{
				if (this.IndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnResizingSettings)this.SettingsObject).IndicatorStyle;
				}
				return this.IndicatorStyle;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000A22C File Offset: 0x0000842C
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000A23E File Offset: 0x0000843E
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.ColumnResizingType>))]
		public global::Infragistics.Controls.Grids.ColumnResizingType? AllowColumnResizing
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnResizingType?)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowColumnResizingTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowColumnResizingTypeProperty, value);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A254 File Offset: 0x00008454
		private static void AllowColumnResizingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride)obj;
			columnResizingSettingsOverride.OnPropertyChanged("AllowColumnResizing");
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000A274 File Offset: 0x00008474
		public global::Infragistics.Controls.Grids.ColumnResizingType AllowColumnResizingResolved
		{
			get
			{
				if (this.AllowColumnResizing != null)
				{
					return this.AllowColumnResizing.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnResizingSettings)this.SettingsObject).AllowColumnResizing;
				}
				return (global::Infragistics.Controls.Grids.ColumnResizingType)global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowColumnResizingTypeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000A2D7 File Offset: 0x000084D7
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000A2E9 File Offset: 0x000084E9
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowDoubleClickToSize
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowDoubleClickToSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowDoubleClickToSizeProperty, value);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000A2FC File Offset: 0x000084FC
		private static void AllowDoubleClickToSizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride)obj;
			columnResizingSettingsOverride.OnPropertyChanged("AllowDoubleClickToSize");
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000A31C File Offset: 0x0000851C
		public bool AllowDoubleClickToSizeResolved
		{
			get
			{
				if (this.AllowDoubleClickToSize != null)
				{
					return this.AllowDoubleClickToSize.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnResizingSettings)this.SettingsObject).AllowDoubleClickToSize;
				}
				return (bool)global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowDoubleClickToSizeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000A37F File Offset: 0x0000857F
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000A391 File Offset: 0x00008591
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowMultipleColumnResize
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowMultipleColumnResizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowMultipleColumnResizeProperty, value);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000A3A4 File Offset: 0x000085A4
		private static void AllowMultipleColumnResizeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride)obj;
			columnResizingSettingsOverride.OnPropertyChanged("AllowMultipleColumnResize");
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000A3C4 File Offset: 0x000085C4
		public bool AllowMultipleColumnResizeResolved
		{
			get
			{
				if (this.AllowMultipleColumnResize != null)
				{
					return this.AllowMultipleColumnResize.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnResizingSettings)this.SettingsObject).AllowMultipleColumnResize;
				}
				return (bool)global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowMultipleColumnResizeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000A427 File Offset: 0x00008627
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000A439 File Offset: 0x00008639
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowCellAreaResizing
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowCellAreaResizingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowCellAreaResizingProperty, value);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000A44C File Offset: 0x0000864C
		private static void AllowCellAreaResizingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride)obj;
			columnResizingSettingsOverride.OnPropertyChanged("AllowCellAreaResizing");
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000A46C File Offset: 0x0000866C
		public bool AllowCellAreaResizingResolved
		{
			get
			{
				if (this.AllowCellAreaResizing != null)
				{
					return this.AllowCellAreaResizing.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnResizingSettings)this.SettingsObject).AllowCellAreaResizing;
				}
				return (bool)global::Infragistics.Controls.Grids.ColumnResizingSettings.AllowCellAreaResizingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnResizingSettings)).DefaultValue;
			}
		}

		// Token: 0x04000072 RID: 114
		private global::Infragistics.Controls.Grids.Primitives.ResizingIndicator _indicator;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Controls.Primitives.Popup _indicatorContainer;

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty IndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("IndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.IndicatorStyleChanged)));

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Windows.DependencyProperty AllowColumnResizingTypeProperty = global::System.Windows.DependencyProperty.Register("AllowColumnResizing", typeof(global::Infragistics.Controls.Grids.ColumnResizingType?), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowColumnResizingChanged)));

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty AllowDoubleClickToSizeProperty = global::System.Windows.DependencyProperty.Register("AllowDoubleClickToSize", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowDoubleClickToSizeChanged)));

		// Token: 0x04000077 RID: 119
		public static readonly global::System.Windows.DependencyProperty AllowMultipleColumnResizeProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleColumnResize", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowMultipleColumnResizeChanged)));

		// Token: 0x04000078 RID: 120
		public static readonly global::System.Windows.DependencyProperty AllowCellAreaResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCellAreaResizing", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride.AllowCellAreaResizingChanged)));
	}
}
