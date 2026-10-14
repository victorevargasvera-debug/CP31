using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000BA RID: 186
	public class FilteringSettingsOverride : global::Infragistics.Controls.Grids.EditingSettingsBaseOverride, global::System.IDisposable
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.FilteringSettings;
				}
				return result;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0001CEDA File Offset: 0x0001B0DA
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FilterUIType>))]
		public global::Infragistics.Controls.Grids.FilterUIType? AllowFiltering
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilterUIType?)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilteringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilteringProperty, value);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001CF00 File Offset: 0x0001B100
		private static void AllowFilteringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("AllowFiltering");
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001CF20 File Offset: 0x0001B120
		public global::Infragistics.Controls.Grids.FilterUIType AllowFilteringResolved
		{
			get
			{
				if (this.AllowFiltering != null)
				{
					return this.AllowFiltering.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).AllowFiltering;
				}
				return (global::Infragistics.Controls.Grids.FilterUIType)global::Infragistics.Controls.Grids.FilteringSettings.AllowFilteringProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FilteringSettings)).DefaultValue;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0001CF83 File Offset: 0x0001B183
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x0001CF95 File Offset: 0x0001B195
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FilterRowLocation>))]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Obsolete("This property is obsolete. The functionality has been superceded by the AllowFiltering property.", true)]
		public global::Infragistics.Controls.Grids.FilterRowLocation? AllowFilterRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilterRowLocation?)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilterRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilterRowProperty, value);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		private static void AllowFilterRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("AllowFilterRow");
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[global::System.Obsolete("This property is obsolete. The functionality has been superceded by the AllowFilteringResolved property.", true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Grids.FilterRowLocation AllowFilterRowResolved
		{
			get
			{
				if (this.AllowFilterRow != null)
				{
					return this.AllowFilterRow.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).AllowFilterRow;
				}
				return (global::Infragistics.Controls.Grids.FilterRowLocation)global::Infragistics.Controls.Grids.FilteringSettings.AllowFilterRowProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FilteringSettings)).DefaultValue;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001D02B File Offset: 0x0001B22B
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0001D03D File Offset: 0x0001B23D
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001D04C File Offset: 0x0001B24C
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			if (filteringSettingsOverride.ColumnLayout != null && filteringSettingsOverride.ColumnLayout.Grid != null)
			{
				filteringSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			filteringSettingsOverride.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001D090 File Offset: 0x0001B290
		public global::System.Windows.Style ExpansionIndicatorStyleResolved
		{
			get
			{
				if (this.ExpansionIndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).ExpansionIndicatorStyle;
				}
				return this.ExpansionIndicatorStyle;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001D0B9 File Offset: 0x0001B2B9
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0001D0CB File Offset: 0x0001B2CB
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.StyleProperty, value);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001D0DC File Offset: 0x0001B2DC
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("Style");
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001D0FB File Offset: 0x0001B2FB
		public global::System.Windows.Style StyleResolved
		{
			get
			{
				if (this.Style == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).Style;
				}
				return this.Style;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001D124 File Offset: 0x0001B324
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0001D136 File Offset: 0x0001B336
		public global::System.Windows.Style FilterSelectionControlStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterSelectionControlStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterSelectionControlStyleProperty, value);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001D144 File Offset: 0x0001B344
		private static void FilterSelectionControlStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("FilterSelectionControlStyle");
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001D163 File Offset: 0x0001B363
		public global::System.Windows.Style FilterSelectionControlStyleResolved
		{
			get
			{
				if (this.FilterSelectionControlStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).FilterSelectionControlStyle;
				}
				return this.FilterSelectionControlStyle;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001D18C File Offset: 0x0001B38C
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0001D19E File Offset: 0x0001B39E
		public global::System.Windows.Style CustomFilterDialogStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.CustomFilterDialogStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.CustomFilterDialogStyleProperty, value);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		private static void CustomFilterDialogStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("CustomFilterDialogStyle");
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001D1CB File Offset: 0x0001B3CB
		public global::System.Windows.Style CustomFilterDialogStyleResolved
		{
			get
			{
				if (this.CustomFilterDialogStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).CustomFilterDialogStyle;
				}
				return this.CustomFilterDialogStyle;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0001D206 File Offset: 0x0001B406
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001D214 File Offset: 0x0001B414
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001D233 File Offset: 0x0001B433
		public global::System.Windows.Style RowSelectorStyleResolved
		{
			get
			{
				if (this.RowSelectorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).RowSelectorStyle;
				}
				return this.RowSelectorStyle;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001D25C File Offset: 0x0001B45C
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0001D26E File Offset: 0x0001B46E
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FilteringScope>))]
		public global::Infragistics.Controls.Grids.FilteringScope? FilteringScope
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilteringScope?)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilteringScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilteringScopeProperty, value);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001D284 File Offset: 0x0001B484
		private static void FilteringScopeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("FilteringScope");
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		public global::Infragistics.Controls.Grids.FilteringScope FilteringScopeResolved
		{
			get
			{
				if (this.FilteringScope != null)
				{
					return this.FilteringScope.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).FilteringScope;
				}
				return (global::Infragistics.Controls.Grids.FilteringScope)global::Infragistics.Controls.Grids.FilteringSettings.FilteringScopeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FilteringSettings)).DefaultValue;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001D308 File Offset: 0x0001B508
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection
		{
			get
			{
				if (this._rowFiltersCollection == null)
				{
					this._rowFiltersCollection = new global::Infragistics.Controls.Grids.RowFiltersCollection();
					this._rowFiltersCollection.CollectionChanged += this.RowFiltersCollection_CollectionChanged;
					this._rowFiltersCollection.CollectionItemChanged += this.RowFiltersCollection_CollectionItemChanged;
					this._rowFiltersCollection.PropertyChanged += this.RowFiltersCollection_PropertyChanged;
				}
				return this._rowFiltersCollection;
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001D373 File Offset: 0x0001B573
		protected internal override global::Infragistics.Controls.Grids.EditingType ResolveEditingType()
		{
			return global::Infragistics.Controls.Grids.EditingType.Cell;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001D376 File Offset: 0x0001B576
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0001D388 File Offset: 0x0001B588
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? FilterRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterRowHeightProperty, value);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001D39C File Offset: 0x0001B59C
		private static void FilterRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("FilterRowHeight");
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		public global::Infragistics.Controls.Grids.RowHeight FilterRowHeightResolved
		{
			get
			{
				if (this.FilterRowHeight != null)
				{
					return this.FilterRowHeight.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).FilterRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.FilteringSettings.FilterRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FilteringSettings)).DefaultValue;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001D41F File Offset: 0x0001B61F
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0001D431 File Offset: 0x0001B631
		public string FilterMenuClearFiltersString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuClearFiltersStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuClearFiltersStringProperty, value);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001D440 File Offset: 0x0001B640
		private static void FilterMenuClearFiltersStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("FilterMenuClearFiltersString");
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001D460 File Offset: 0x0001B660
		public string FilterMenuClearFiltersStringResolved
		{
			get
			{
				string filterMenuClearFiltersString = this.FilterMenuClearFiltersString;
				if (string.IsNullOrEmpty(filterMenuClearFiltersString))
				{
					global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = this.SettingsObject as global::Infragistics.Controls.Grids.FilteringSettings;
					if (filteringSettings != null)
					{
						return filteringSettings.FilterMenuClearFiltersString;
					}
				}
				return filterMenuClearFiltersString;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001D493 File Offset: 0x0001B693
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0001D4A5 File Offset: 0x0001B6A5
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? FilterMenuCustomFilteringButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuCustomFilteringButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuCustomFilteringButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		private static void FilterMenuCustomFilteringButtonVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettingsOverride = (global::Infragistics.Controls.Grids.FilteringSettingsOverride)obj;
			filteringSettingsOverride.OnPropertyChanged("FilterMenuCustomFilteringButtonVisibility");
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		public global::System.Windows.Visibility FilterMenuCustomFilteringButtonVisibilityResolved
		{
			get
			{
				if (this.FilterMenuCustomFilteringButtonVisibility != null)
				{
					return this.FilterMenuCustomFilteringButtonVisibility.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FilteringSettings)this.SettingsObject).FilterMenuCustomFilteringButtonVisibility;
				}
				return (global::System.Windows.Visibility)global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuCustomFilteringButtonVisibilityProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.FilteringSettings)).DefaultValue;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001D53C File Offset: 0x0001B73C
		protected virtual void Dispose(bool disposing)
		{
			if (this._rowFiltersCollection != null)
			{
				this._rowFiltersCollection.CollectionChanged -= this.RowFiltersCollection_CollectionChanged;
				this._rowFiltersCollection.CollectionItemChanged -= this.RowFiltersCollection_CollectionItemChanged;
				this._rowFiltersCollection.Dispose();
				this._rowFiltersCollection = null;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001D591 File Offset: 0x0001B791
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		private void RowFiltersCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("FilteringInvalidated");
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001D5AD File Offset: 0x0001B7AD
		private void RowFiltersCollection_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			this.OnPropertyChanged("FilteringInvalidated");
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001D5BA File Offset: 0x0001B7BA
		private void RowFiltersCollection_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged("FilteringInvalidated");
		}

		// Token: 0x040001A3 RID: 419
		private global::Infragistics.Controls.Grids.RowFiltersCollection _rowFiltersCollection;

		// Token: 0x040001A4 RID: 420
		public static readonly global::System.Windows.DependencyProperty AllowFilteringProperty = global::System.Windows.DependencyProperty.Register("AllowFiltering", typeof(global::Infragistics.Controls.Grids.FilterUIType?), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilteringChanged)));

		// Token: 0x040001A5 RID: 421
		public static readonly global::System.Windows.DependencyProperty AllowFilterRowProperty = global::System.Windows.DependencyProperty.Register("AllowFilterRow", typeof(global::Infragistics.Controls.Grids.FilterRowLocation?), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.AllowFilterRowChanged)));

		// Token: 0x040001A6 RID: 422
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.ExpansionIndicatorStyleChanged)));

		// Token: 0x040001A7 RID: 423
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.StyleChanged)));

		// Token: 0x040001A8 RID: 424
		public static readonly global::System.Windows.DependencyProperty FilterSelectionControlStyleProperty = global::System.Windows.DependencyProperty.Register("FilterSelectionControlStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterSelectionControlStyleChanged)));

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.DependencyProperty CustomFilterDialogStyleProperty = global::System.Windows.DependencyProperty.Register("CustomFilterDialogStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.CustomFilterDialogStyleChanged)));

		// Token: 0x040001AA RID: 426
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.RowSelectorStyleChanged)));

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty FilteringScopeProperty = global::System.Windows.DependencyProperty.Register("FilteringScope", typeof(global::Infragistics.Controls.Grids.FilteringScope?), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilteringScopeChanged)));

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.DependencyProperty FilterRowHeightProperty = global::System.Windows.DependencyProperty.Register("FilterRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterRowHeightChanged))));

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.DependencyProperty FilterMenuClearFiltersStringProperty = global::System.Windows.DependencyProperty.Register("FilterMenuClearFiltersString", typeof(string), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuClearFiltersStringChanged)));

		// Token: 0x040001AE RID: 430
		public static readonly global::System.Windows.DependencyProperty FilterMenuCustomFilteringButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("FilterMenuCustomFilteringButtonVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Grids.FilteringSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettingsOverride.FilterMenuCustomFilteringButtonVisibilityChanged)));
	}
}
