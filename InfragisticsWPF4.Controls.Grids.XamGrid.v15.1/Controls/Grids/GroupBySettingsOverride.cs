using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000109 RID: 265
	public class GroupBySettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00022B5C File Offset: 0x00020D5C
		public GroupBySettingsOverride()
		{
			this._indicator = new global::Infragistics.Controls.Grids.Primitives.GroupByMovingIndicator();
			this._indicatorContainer = new global::System.Windows.Controls.Primitives.Popup();
			this._indicatorContainer.Child = this._indicator;
			this._indicatorContainer.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._indicatorContainer.AllowsTransparency = true;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00022BB0 File Offset: 0x00020DB0
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.GroupBySettings;
				}
				return result;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00022BE6 File Offset: 0x00020DE6
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00022BF8 File Offset: 0x00020DF8
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsGroupable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.IsGroupableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.IsGroupableProperty, value);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00022C0C File Offset: 0x00020E0C
		private static void IsGroupableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("IsGroupable");
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00022C2C File Offset: 0x00020E2C
		public bool IsGroupableResolved
		{
			get
			{
				if (this.IsGroupable != null)
				{
					return this.IsGroupable.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).IsGroupable;
				}
				return (bool)global::Infragistics.Controls.Grids.GroupBySettings.IsGroupableProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.GroupBySettings)).DefaultValue;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00022C8F File Offset: 0x00020E8F
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00022CA1 File Offset: 0x00020EA1
		public global::System.Windows.Style GroupByMovingIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByMovingIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByMovingIndicatorStyleProperty, value);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00022CB0 File Offset: 0x00020EB0
		private static void GroupByMovingIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByMovingIndicatorStyle");
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00022CCF File Offset: 0x00020ECF
		public global::System.Windows.Style GroupByMovingIndicatorStyleResolved
		{
			get
			{
				if (this.GroupByMovingIndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByMovingIndicatorStyle;
				}
				return this.GroupByMovingIndicatorStyle;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00022CF8 File Offset: 0x00020EF8
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00022D0A File Offset: 0x00020F0A
		public global::System.Windows.Style GroupByHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByHeaderStyleProperty, value);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00022D18 File Offset: 0x00020F18
		private static void GroupByHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByHeaderStyle");
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00022D37 File Offset: 0x00020F37
		public global::System.Windows.Style GroupByHeaderStyleResolved
		{
			get
			{
				if (this.GroupByHeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByHeaderStyle;
				}
				return this.GroupByHeaderStyle;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00022D60 File Offset: 0x00020F60
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00022D72 File Offset: 0x00020F72
		public global::System.Windows.Style GroupByColumnLayoutHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByColumnLayoutHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByColumnLayoutHeaderStyleProperty, value);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00022D80 File Offset: 0x00020F80
		private static void GroupByColumnLayoutHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByColumnLayoutHeaderStyle");
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00022D9F File Offset: 0x00020F9F
		public global::System.Windows.Style GroupByColumnLayoutHeaderStyleResolved
		{
			get
			{
				if (this.GroupByColumnLayoutHeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByColumnLayoutHeaderStyle;
				}
				return this.GroupByColumnLayoutHeaderStyle;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00022DC8 File Offset: 0x00020FC8
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00022DDA File Offset: 0x00020FDA
		public global::System.Windows.Style GroupByRowStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowStyleProperty, value);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00022DE8 File Offset: 0x00020FE8
		private static void GroupByRowStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByRowStyle");
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00022E07 File Offset: 0x00021007
		public global::System.Windows.Style GroupByRowStyleResolved
		{
			get
			{
				if (this.GroupByRowStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByRowStyle;
				}
				return this.GroupByRowStyle;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00022E30 File Offset: 0x00021030
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00022E42 File Offset: 0x00021042
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? GroupByRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowHeightProperty, value);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00022E58 File Offset: 0x00021058
		private static void GroupByRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByRowHeight");
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00022E78 File Offset: 0x00021078
		public global::Infragistics.Controls.Grids.RowHeight GroupByRowHeightResolved
		{
			get
			{
				if (this.GroupByRowHeight != null)
				{
					return this.GroupByRowHeight.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.GroupBySettings)).DefaultValue;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00022EDB File Offset: 0x000210DB
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00022EED File Offset: 0x000210ED
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? GroupByAreaRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByAreaRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByAreaRowHeightProperty, value);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00022F00 File Offset: 0x00021100
		private static void GroupByAreaRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettingsOverride groupBySettingsOverride = (global::Infragistics.Controls.Grids.GroupBySettingsOverride)obj;
			groupBySettingsOverride.OnPropertyChanged("GroupByAreaRowHeight");
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00022F20 File Offset: 0x00021120
		public global::Infragistics.Controls.Grids.RowHeight GroupByAreaRowHeightResolved
		{
			get
			{
				if (this.GroupByAreaRowHeight != null)
				{
					return this.GroupByAreaRowHeight.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.GroupBySettings)this.SettingsObject).GroupByAreaRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.GroupBySettings)).DefaultValue;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00022F84 File Offset: 0x00021184
		internal global::Infragistics.Controls.Grids.Primitives.GroupByMovingIndicator Indicator
		{
			get
			{
				global::System.Windows.Style groupByMovingIndicatorStyleResolved = this.GroupByMovingIndicatorStyleResolved;
				global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(this._indicator, groupByMovingIndicatorStyleResolved);
				return this._indicator;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00022FAA File Offset: 0x000211AA
		internal global::System.Windows.Controls.Primitives.Popup IndicatorContainer
		{
			get
			{
				return this._indicatorContainer;
			}
		}

		// Token: 0x0400022D RID: 557
		private global::Infragistics.Controls.Grids.Primitives.GroupByMovingIndicator _indicator;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Controls.Primitives.Popup _indicatorContainer;

		// Token: 0x0400022F RID: 559
		public static readonly global::System.Windows.DependencyProperty IsGroupableProperty = global::System.Windows.DependencyProperty.Register("IsGroupable", typeof(bool?), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.IsGroupableChanged)));

		// Token: 0x04000230 RID: 560
		public static readonly global::System.Windows.DependencyProperty GroupByMovingIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByMovingIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByMovingIndicatorStyleChanged)));

		// Token: 0x04000231 RID: 561
		public static readonly global::System.Windows.DependencyProperty GroupByHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByHeaderStyleChanged)));

		// Token: 0x04000232 RID: 562
		public static readonly global::System.Windows.DependencyProperty GroupByColumnLayoutHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByColumnLayoutHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByColumnLayoutHeaderStyleChanged)));

		// Token: 0x04000233 RID: 563
		public static readonly global::System.Windows.DependencyProperty GroupByRowStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByRowStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowStyleChanged)));

		// Token: 0x04000234 RID: 564
		public static readonly global::System.Windows.DependencyProperty GroupByRowHeightProperty = global::System.Windows.DependencyProperty.Register("GroupByRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByRowHeightChanged))));

		// Token: 0x04000235 RID: 565
		public static readonly global::System.Windows.DependencyProperty GroupByAreaRowHeightProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.GroupBySettingsOverride), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettingsOverride.GroupByAreaRowHeightChanged))));
	}
}
