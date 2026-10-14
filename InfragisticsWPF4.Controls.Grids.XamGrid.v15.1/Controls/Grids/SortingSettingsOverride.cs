using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000136 RID: 310
	public class SortingSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase, global::System.IDisposable
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00027140 File Offset: 0x00025340
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.SortingSettings;
				}
				return result;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00027176 File Offset: 0x00025376
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00027188 File Offset: 0x00025388
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowSorting
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowSortingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowSortingProperty, value);
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002719C File Offset: 0x0002539C
		private static void AllowSortingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettingsOverride = (global::Infragistics.Controls.Grids.SortingSettingsOverride)obj;
			sortingSettingsOverride.OnPropertyChanged("AllowSorting");
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000271BC File Offset: 0x000253BC
		public bool AllowSortingResolved
		{
			get
			{
				if (this.AllowSorting != null)
				{
					return this.AllowSorting.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SortingSettings)this.SettingsObject).AllowSorting;
				}
				return (bool)global::Infragistics.Controls.Grids.SortingSettings.AllowSortingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SortingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0002721F File Offset: 0x0002541F
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00027231 File Offset: 0x00025431
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? ShowSortIndicator
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.ShowSortIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.ShowSortIndicatorProperty, value);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00027244 File Offset: 0x00025444
		private static void ShowSortIndicatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettingsOverride = (global::Infragistics.Controls.Grids.SortingSettingsOverride)obj;
			sortingSettingsOverride.OnPropertyChanged("ShowSortIndicator");
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00027264 File Offset: 0x00025464
		public bool ShowSortIndicatorResolved
		{
			get
			{
				if (this.ShowSortIndicator != null)
				{
					return this.ShowSortIndicator.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SortingSettings)this.SettingsObject).ShowSortIndicator;
				}
				return (bool)global::Infragistics.Controls.Grids.SortingSettings.ShowSortIndicatorProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SortingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000272C7 File Offset: 0x000254C7
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x000272D9 File Offset: 0x000254D9
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowMultipleColumnSorting
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowMultipleColumnSortingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowMultipleColumnSortingProperty, value);
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000272EC File Offset: 0x000254EC
		private static void AllowMultipleColumnSortingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettingsOverride = (global::Infragistics.Controls.Grids.SortingSettingsOverride)obj;
			sortingSettingsOverride.OnPropertyChanged("AllowMultipleColumnSorting");
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002730C File Offset: 0x0002550C
		public bool AllowMultipleColumnSortingResolved
		{
			get
			{
				if (this.AllowMultipleColumnSorting != null)
				{
					return this.AllowMultipleColumnSorting.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SortingSettings)this.SettingsObject).AllowMultipleColumnSorting;
				}
				return (bool)global::Infragistics.Controls.Grids.SortingSettings.AllowMultipleColumnSortingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SortingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002736F File Offset: 0x0002556F
		public global::Infragistics.Controls.Grids.SortedColumnsCollection SortedColumns
		{
			get
			{
				if (this._sortedColumns == null)
				{
					this._sortedColumns = new global::Infragistics.Controls.Grids.SortedColumnsCollection();
					this._sortedColumns.CollectionChanged += this.SortedColumns_CollectionChanged;
				}
				return this._sortedColumns;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000273A1 File Offset: 0x000255A1
		protected internal global::Infragistics.Controls.Grids.MultiSortingKey MultiSortingKeyResolved
		{
			get
			{
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SortingSettings)this.SettingsObject).MultiSortingKey;
				}
				return global::Infragistics.Controls.Grids.MultiSortingKey.Control;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x000273BD File Offset: 0x000255BD
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000273CF File Offset: 0x000255CF
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.SortDirection>))]
		public global::Infragistics.Controls.Grids.SortDirection? FirstSortDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SortDirection?)base.GetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.FirstSortDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SortingSettingsOverride.FirstSortDirectionProperty, value);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000273E4 File Offset: 0x000255E4
		private static void FirstSortDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettingsOverride = (global::Infragistics.Controls.Grids.SortingSettingsOverride)obj;
			sortingSettingsOverride.OnPropertyChanged("FirstSortDirection");
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00027404 File Offset: 0x00025604
		public global::Infragistics.Controls.Grids.SortDirection FirstSortDirectionResolved
		{
			get
			{
				if (this.FirstSortDirection != null)
				{
					return this.FirstSortDirection.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.SortingSettings)this.SettingsObject).FirstSortDirection;
				}
				return (global::Infragistics.Controls.Grids.SortDirection)global::Infragistics.Controls.Grids.SortingSettings.FirstSortDirectionProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.SortingSettings)).DefaultValue;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00027467 File Offset: 0x00025667
		private void SortedColumns_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (base.ColumnLayout != null)
			{
				base.ColumnLayout.InvalidateSorting();
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002747C File Offset: 0x0002567C
		protected virtual void Dispose(bool disposing)
		{
			if (this._sortedColumns != null)
			{
				this._sortedColumns.Dispose();
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00027491 File Offset: 0x00025691
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000278 RID: 632
		private global::Infragistics.Controls.Grids.SortedColumnsCollection _sortedColumns;

		// Token: 0x04000279 RID: 633
		public static readonly global::System.Windows.DependencyProperty AllowSortingProperty = global::System.Windows.DependencyProperty.Register("AllowSorting", typeof(bool?), typeof(global::Infragistics.Controls.Grids.SortingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowSortingChanged)));

		// Token: 0x0400027A RID: 634
		public static readonly global::System.Windows.DependencyProperty ShowSortIndicatorProperty = global::System.Windows.DependencyProperty.Register("ShowSortIndicator", typeof(bool?), typeof(global::Infragistics.Controls.Grids.SortingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettingsOverride.ShowSortIndicatorChanged)));

		// Token: 0x0400027B RID: 635
		public static readonly global::System.Windows.DependencyProperty AllowMultipleColumnSortingProperty = global::System.Windows.DependencyProperty.Register("AllowMultipleColumnSorting", typeof(bool?), typeof(global::Infragistics.Controls.Grids.SortingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettingsOverride.AllowMultipleColumnSortingChanged)));

		// Token: 0x0400027C RID: 636
		public static readonly global::System.Windows.DependencyProperty FirstSortDirectionProperty = global::System.Windows.DependencyProperty.Register("FirstSortDirection", typeof(global::Infragistics.Controls.Grids.SortDirection?), typeof(global::Infragistics.Controls.Grids.SortingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SortingSettingsOverride.FirstSortDirectionChanged)));
	}
}
