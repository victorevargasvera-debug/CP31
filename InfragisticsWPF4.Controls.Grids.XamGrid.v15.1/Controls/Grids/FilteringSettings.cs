using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B9 RID: 185
	public class FilteringSettings : global::Infragistics.Controls.Grids.EditingSettingsBase, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x0001C71B File Offset: 0x0001A91B
		public FilteringSettings()
		{
			base.IsOnCellActiveEditingEnabled = true;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0001C72A File Offset: 0x0001A92A
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0001C73C File Offset: 0x0001A93C
		public global::Infragistics.Controls.Grids.FilterUIType AllowFiltering
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilterUIType)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilteringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilteringProperty, value);
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001C750 File Offset: 0x0001A950
		private static void AllowFilteringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("AllowFiltering");
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001C76F File Offset: 0x0001A96F
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x0001C781 File Offset: 0x0001A981
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Obsolete("This property is obsolete. The functionality has been superceded by the AllowFiltering property.", true)]
		public global::Infragistics.Controls.Grids.FilterRowLocation AllowFilterRow
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilterRowLocation)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilterRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilterRowProperty, value);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001C794 File Offset: 0x0001A994
		private static void AllowFilterRowChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("AllowFilterRow");
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001C7B3 File Offset: 0x0001A9B3
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0001C7C5 File Offset: 0x0001A9C5
		public global::System.Windows.Style ExpansionIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.ExpansionIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.ExpansionIndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		private static void ExpansionIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			if (filteringSettings.Grid != null)
			{
				filteringSettings.Grid.ResetPanelRows();
			}
			filteringSettings.OnPropertyChanged("ExpansionIndicatorStyle");
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001C808 File Offset: 0x0001AA08
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection
		{
			get
			{
				global::Infragistics.Controls.Grids.RowFiltersCollection result = null;
				if (base.Grid != null)
				{
					result = base.Grid.RowsManager.RowFiltersCollectionResolved;
				}
				return result;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001C831 File Offset: 0x0001AA31
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x0001C843 File Offset: 0x0001AA43
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.StyleProperty, value);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001C854 File Offset: 0x0001AA54
		private static void StyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("Style");
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001C873 File Offset: 0x0001AA73
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0001C885 File Offset: 0x0001AA85
		public global::System.Windows.Style RowSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.RowSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.RowSelectorStyleProperty, value);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001C894 File Offset: 0x0001AA94
		private static void RowSelectorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("RowSelectorStyle");
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001C8B3 File Offset: 0x0001AAB3
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x0001C8C5 File Offset: 0x0001AAC5
		public global::Infragistics.Controls.Grids.FilteringScope FilteringScope
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilteringScope)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilteringScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilteringScopeProperty, value);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		private static void FilteringScopeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilteringScope");
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001C8F7 File Offset: 0x0001AAF7
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0001C909 File Offset: 0x0001AB09
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight FilterRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterRowHeightProperty, value);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001C91C File Offset: 0x0001AB1C
		private static void FilterRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilterRowHeight");
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001C93B File Offset: 0x0001AB3B
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0001C94D File Offset: 0x0001AB4D
		public string FilterMenuClearFiltersString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuClearFiltersStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuClearFiltersStringProperty, value);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001C95C File Offset: 0x0001AB5C
		private static void FilterMenuClearFiltersStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilterMenuClearFiltersString");
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001C97B File Offset: 0x0001AB7B
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0001C98D File Offset: 0x0001AB8D
		public global::System.Windows.Visibility FilterMenuCustomFilteringButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuCustomFilteringButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuCustomFilteringButtonVisibilityProperty, value);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001C9A0 File Offset: 0x0001ABA0
		private static void FilterMenuCustomFilteringButtonVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilterMenuCustomFilteringButtonVisibility");
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001C9BF File Offset: 0x0001ABBF
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x0001C9D1 File Offset: 0x0001ABD1
		public global::System.Windows.Style FilterSelectionControlStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterSelectionControlStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterSelectionControlStyleProperty, value);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		private static void FilterSelectionControlStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilterSelectionControlStyle");
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001C9FF File Offset: 0x0001ABFF
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x0001CA11 File Offset: 0x0001AC11
		public global::System.Windows.Style CustomFilterDialogStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.CustomFilterDialogStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.CustomFilterDialogStyleProperty, value);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001CA20 File Offset: 0x0001AC20
		private static void CustomFilterDialogStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("CustomFilterDialogStyle");
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001CA3F File Offset: 0x0001AC3F
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0001CA51 File Offset: 0x0001AC51
		public string SelectAllText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.SelectAllTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.SelectAllTextProperty, value);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001CA5F File Offset: 0x0001AC5F
		private static void SelectAllTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001CA61 File Offset: 0x0001AC61
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0001CA73 File Offset: 0x0001AC73
		public string EmptyValueString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.EmptyValueStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.EmptyValueStringProperty, value);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001CA81 File Offset: 0x0001AC81
		private static void EmptyValueStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001CA83 File Offset: 0x0001AC83
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0001CA95 File Offset: 0x0001AC95
		public string NullValueString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.NullValueStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.NullValueStringProperty, value);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001CAA3 File Offset: 0x0001ACA3
		private static void NullValueStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001CAA5 File Offset: 0x0001ACA5
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0001CAB7 File Offset: 0x0001ACB7
		public global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList FilterMenuSelectionListGeneration
		{
			get
			{
				return (global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList)base.GetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuSelectionListGenerationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuSelectionListGenerationProperty, value);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001CACC File Offset: 0x0001ACCC
		private static void FilterMenuSelectionListGenerationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilteringSettings filteringSettings = (global::Infragistics.Controls.Grids.FilteringSettings)obj;
			filteringSettings.OnPropertyChanged("FilterMenuSelectionListGeneration");
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"RowFiltersCollection"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001CB1F File Offset: 0x0001AD1F
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001CB27 File Offset: 0x0001AD27
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001CB2A File Offset: 0x0001AD2A
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001CB32 File Offset: 0x0001AD32
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001CB34 File Offset: 0x0001AD34
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x04000193 RID: 403
		public static readonly global::System.Windows.DependencyProperty AllowFilteringProperty = global::System.Windows.DependencyProperty.Register("AllowFiltering", typeof(global::Infragistics.Controls.Grids.FilterUIType), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FilterUIType.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilteringChanged)));

		// Token: 0x04000194 RID: 404
		public static readonly global::System.Windows.DependencyProperty AllowFilterRowProperty = global::System.Windows.DependencyProperty.Register("AllowFilterRow", typeof(global::Infragistics.Controls.Grids.FilterRowLocation), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FilterRowLocation.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.AllowFilterRowChanged)));

		// Token: 0x04000195 RID: 405
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.ExpansionIndicatorStyleChanged)));

		// Token: 0x04000196 RID: 406
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.StyleChanged)));

		// Token: 0x04000197 RID: 407
		public static readonly global::System.Windows.DependencyProperty RowSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RowSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.RowSelectorStyleChanged)));

		// Token: 0x04000198 RID: 408
		public static readonly global::System.Windows.DependencyProperty FilteringScopeProperty = global::System.Windows.DependencyProperty.Register("FilteringScope", typeof(global::Infragistics.Controls.Grids.FilteringScope), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FilteringScope.ChildBand, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilteringScopeChanged)));

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.DependencyProperty FilterRowHeightProperty = global::System.Windows.DependencyProperty.Register("FilterRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilterRowHeightChanged))));

		// Token: 0x0400019A RID: 410
		public static readonly global::System.Windows.DependencyProperty FilterMenuClearFiltersStringProperty = global::System.Windows.DependencyProperty.Register("FilterMenuClearFiltersString", typeof(string), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuClearFiltersStringChanged)));

		// Token: 0x0400019B RID: 411
		public static readonly global::System.Windows.DependencyProperty FilterMenuCustomFilteringButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("FilterMenuCustomFilteringButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuCustomFilteringButtonVisibilityChanged)));

		// Token: 0x0400019C RID: 412
		public static readonly global::System.Windows.DependencyProperty FilterSelectionControlStyleProperty = global::System.Windows.DependencyProperty.Register("FilterSelectionControlStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilterSelectionControlStyleChanged)));

		// Token: 0x0400019D RID: 413
		public static readonly global::System.Windows.DependencyProperty CustomFilterDialogStyleProperty = global::System.Windows.DependencyProperty.Register("CustomFilterDialogStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.CustomFilterDialogStyleChanged)));

		// Token: 0x0400019E RID: 414
		public static readonly global::System.Windows.DependencyProperty SelectAllTextProperty = global::System.Windows.DependencyProperty.Register("SelectAllText", typeof(string), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.SRGrid.GetString("SelectAllCheckBox"), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.SelectAllTextChanged)));

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.DependencyProperty EmptyValueStringProperty = global::System.Windows.DependencyProperty.Register("EmptyValueString", typeof(string), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.SRGrid.GetString("EmptyContentString"), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.EmptyValueStringChanged)));

		// Token: 0x040001A0 RID: 416
		public static readonly global::System.Windows.DependencyProperty NullValueStringProperty = global::System.Windows.DependencyProperty.Register("NullValueString", typeof(string), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.SRGrid.GetString("NullContentString"), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.NullValueStringChanged)));

		// Token: 0x040001A1 RID: 417
		public static readonly global::System.Windows.DependencyProperty FilterMenuSelectionListGenerationProperty = global::System.Windows.DependencyProperty.Register("FilterMenuSelectionListGeneration", typeof(global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList), typeof(global::Infragistics.Controls.Grids.FilteringSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList.ExcelStyle, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilteringSettings.FilterMenuSelectionListGenerationChanged)));

		// Token: 0x040001A2 RID: 418
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
