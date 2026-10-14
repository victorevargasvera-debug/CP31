using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000108 RID: 264
	public class GroupBySettings : global::Infragistics.Controls.Grids.SettingsBase, global::System.IDisposable
	{
		// Token: 0x0600089D RID: 2205 RVA: 0x000223F3 File Offset: 0x000205F3
		public GroupBySettings()
		{
			this.EmptyGroupByAreaContent = global::Infragistics.SRGrid.GetString("EmptyGroupByAreaText");
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002240B File Offset: 0x0002060B
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x0002241D File Offset: 0x0002061D
		public global::Infragistics.Controls.Grids.GroupByAreaLocation AllowGroupByArea
		{
			get
			{
				return (global::Infragistics.Controls.Grids.GroupByAreaLocation)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.AllowGroupByAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.AllowGroupByAreaProperty, value);
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00022430 File Offset: 0x00020630
		private static void AllowGroupByAreaChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("AllowGroupByArea");
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0002244F File Offset: 0x0002064F
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00022461 File Offset: 0x00020661
		public bool IsGroupable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupableProperty, value);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00022474 File Offset: 0x00020674
		private static void IsGroupableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("IsGroupable");
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00022493 File Offset: 0x00020693
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.GroupByColumnsCollection GroupByColumns
		{
			get
			{
				if (this._groupByColumns == null)
				{
					this._groupByColumns = new global::Infragistics.Controls.Grids.GroupByColumnsCollection();
					this._groupByColumns.Grid = base.Grid;
				}
				return this._groupByColumns;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000224BF File Offset: 0x000206BF
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x000224CC File Offset: 0x000206CC
		public object EmptyGroupByAreaContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.EmptyGroupByAreaContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.EmptyGroupByAreaContentProperty, value);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000224DC File Offset: 0x000206DC
		private static void EmptyGroupByAreaContentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("EmptyGroupByAreaContent");
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000224FB File Offset: 0x000206FB
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0002250D File Offset: 0x0002070D
		public global::System.Windows.Style GroupByMovingIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByMovingIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByMovingIndicatorStyleProperty, value);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002251C File Offset: 0x0002071C
		private static void GroupByMovingIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByMovingIndicatorStyle");
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002253B File Offset: 0x0002073B
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x0002254D File Offset: 0x0002074D
		public global::System.Windows.Style GroupByAreaStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaStyleProperty, value);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0002255C File Offset: 0x0002075C
		private static void GroupByAreaStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByAreaStyle");
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002257B File Offset: 0x0002077B
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0002258D File Offset: 0x0002078D
		public global::System.Windows.Style GroupByHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByHeaderStyleProperty, value);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002259C File Offset: 0x0002079C
		private static void GroupByHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByHeaderStyle");
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000225BB File Offset: 0x000207BB
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x000225CD File Offset: 0x000207CD
		public global::System.Windows.Style GroupByColumnLayoutHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByColumnLayoutHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByColumnLayoutHeaderStyleProperty, value);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000225DC File Offset: 0x000207DC
		private static void GroupByColumnLayoutHeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByColumnLayoutHeaderStyle");
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000225FB File Offset: 0x000207FB
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0002260D File Offset: 0x0002080D
		public global::System.Windows.Style GroupByRowStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowStyleProperty, value);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002261C File Offset: 0x0002081C
		private static void GroupByRowStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByRowStyle");
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0002263B File Offset: 0x0002083B
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x0002264D File Offset: 0x0002084D
		public bool IsGroupByAreaExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupByAreaExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupByAreaExpandedProperty, value);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00022660 File Offset: 0x00020860
		private static void IsGroupByAreaExpandedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("IsGroupByAreaExpanded");
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0002267F File Offset: 0x0002087F
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00022691 File Offset: 0x00020891
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.ExpansionIndicatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.ExpansionIndicatorVisibilityProperty, value);
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000226A4 File Offset: 0x000208A4
		private static void ExpansionIndicatorVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("ExpansionIndicatorVisibility");
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x000226C3 File Offset: 0x000208C3
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000226D5 File Offset: 0x000208D5
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight GroupByRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowHeightProperty, value);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000226E8 File Offset: 0x000208E8
		private static void GroupByRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByRowHeight");
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00022707 File Offset: 0x00020907
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00022719 File Offset: 0x00020919
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight GroupByAreaRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaRowHeightProperty, value);
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0002272C File Offset: 0x0002092C
		private static void GroupByAreaRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByAreaRowHeight");
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0002274B File Offset: 0x0002094B
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0002275D File Offset: 0x0002095D
		public global::Infragistics.Controls.Grids.GroupByOperation GroupByOperation
		{
			get
			{
				return (global::Infragistics.Controls.Grids.GroupByOperation)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByOperationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.GroupByOperationProperty, value);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00022770 File Offset: 0x00020970
		private static void GroupByOperationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("GroupByOperation");
			if (groupBySettings.Grid != null)
			{
				groupBySettings.Grid.InvalidateData();
				groupBySettings.Grid.Columns.InvalidateColumnsCollections(true);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000227B3 File Offset: 0x000209B3
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000227C5 File Offset: 0x000209C5
		public bool DisplayCountOnGroupedRow
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.GroupBySettings.DisplayCountOnGroupedRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.GroupBySettings.DisplayCountOnGroupedRowProperty, value);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000227D8 File Offset: 0x000209D8
		private static void DisplayCountOnGroupedRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = (global::Infragistics.Controls.Grids.GroupBySettings)obj;
			groupBySettings.OnPropertyChanged("DisplayCountOnGroupedRow");
			if (groupBySettings.Grid != null)
			{
				groupBySettings.Grid.InvalidateScrollPanel(true, true);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002280C File Offset: 0x00020A0C
		protected virtual void Dispose(bool disposing)
		{
			if (this._groupByColumns != null)
			{
				this._groupByColumns.Dispose();
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00022821 File Offset: 0x00020A21
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400021E RID: 542
		private global::Infragistics.Controls.Grids.GroupByColumnsCollection _groupByColumns;

		// Token: 0x0400021F RID: 543
		public static readonly global::System.Windows.DependencyProperty AllowGroupByAreaProperty = global::System.Windows.DependencyProperty.Register("AllowGroupByArea", typeof(global::Infragistics.Controls.Grids.GroupByAreaLocation), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.GroupByAreaLocation.Hidden, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.AllowGroupByAreaChanged)));

		// Token: 0x04000220 RID: 544
		public static readonly global::System.Windows.DependencyProperty IsGroupableProperty = global::System.Windows.DependencyProperty.Register("IsGroupable", typeof(bool), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupableChanged)));

		// Token: 0x04000221 RID: 545
		public static readonly global::System.Windows.DependencyProperty EmptyGroupByAreaContentProperty = global::System.Windows.DependencyProperty.Register("EmptyGroupByAreaContent", typeof(object), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.EmptyGroupByAreaContentChanged)));

		// Token: 0x04000222 RID: 546
		public static readonly global::System.Windows.DependencyProperty GroupByMovingIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByMovingIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByMovingIndicatorStyleChanged)));

		// Token: 0x04000223 RID: 547
		public static readonly global::System.Windows.DependencyProperty GroupByAreaStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaStyleChanged)));

		// Token: 0x04000224 RID: 548
		public static readonly global::System.Windows.DependencyProperty GroupByHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByHeaderStyleChanged)));

		// Token: 0x04000225 RID: 549
		public static readonly global::System.Windows.DependencyProperty GroupByColumnLayoutHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByColumnLayoutHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByColumnLayoutHeaderStyleChanged)));

		// Token: 0x04000226 RID: 550
		public static readonly global::System.Windows.DependencyProperty GroupByRowStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByRowStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowStyleChanged)));

		// Token: 0x04000227 RID: 551
		public static readonly global::System.Windows.DependencyProperty IsGroupByAreaExpandedProperty = global::System.Windows.DependencyProperty.Register("IsGroupByAreaExpanded", typeof(bool), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.IsGroupByAreaExpandedChanged)));

		// Token: 0x04000228 RID: 552
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.ExpansionIndicatorVisibilityChanged)));

		// Token: 0x04000229 RID: 553
		public static readonly global::System.Windows.DependencyProperty GroupByRowHeightProperty = global::System.Windows.DependencyProperty.Register("GroupByRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByRowHeightChanged))));

		// Token: 0x0400022A RID: 554
		public static readonly global::System.Windows.DependencyProperty GroupByAreaRowHeightProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.Dynamic, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByAreaRowHeightChanged))));

		// Token: 0x0400022B RID: 555
		public static readonly global::System.Windows.DependencyProperty GroupByOperationProperty = global::System.Windows.DependencyProperty.Register("GroupByOperation", typeof(global::Infragistics.Controls.Grids.GroupByOperation), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.GroupByOperation.GroupByRows, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.GroupByOperationChanged)));

		// Token: 0x0400022C RID: 556
		public static readonly global::System.Windows.DependencyProperty DisplayCountOnGroupedRowProperty = global::System.Windows.DependencyProperty.Register("DisplayCountOnGroupedRow", typeof(bool), typeof(global::Infragistics.Controls.Grids.GroupBySettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.GroupBySettings.DisplayCountOnGroupedRowChanged)));
	}
}
