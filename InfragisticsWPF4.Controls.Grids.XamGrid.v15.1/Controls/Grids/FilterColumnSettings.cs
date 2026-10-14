using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B6 RID: 182
	public class FilterColumnSettings : global::Infragistics.Controls.Grids.ColumnSettings, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x0001B908 File Offset: 0x00019B08
		public FilterColumnSettings(global::Infragistics.Controls.Grids.Column column)
		{
			base.Column = column;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001B917 File Offset: 0x00019B17
		public FilterColumnSettings()
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001B91F File Offset: 0x00019B1F
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0001B928 File Offset: 0x00019B28
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FilterOperand FilteringOperand
		{
			get
			{
				return this._filteringOperand;
			}
			set
			{
				if (this._filteringOperand != value)
				{
					this._filteringOperand = value;
					this.OnPropertyChanged("FilteringOperand");
					if (this._filteringOperand != null && this.Column != null)
					{
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Column.ColumnLayout;
						if (!this._filteringOperand.RequiresFilteringInput)
						{
							if (columnLayout != null)
							{
								this.Column.ColumnLayout.Grid.ExitEditModeInternal(true);
							}
							this._filterCellValue = null;
						}
					}
					this.BuildFilters(true);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001B9A4 File Offset: 0x00019BA4
		public global::Infragistics.Controls.Grids.FilterOperand FilteringOperandResolved
		{
			get
			{
				if (this._filteringOperand != null)
				{
					return this._filteringOperand;
				}
				if (this._filterRowDefaultOperator != null)
				{
					global::System.Type type = this._filterRowDefaultOperator.GetType();
					foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this.RowFilterOperands)
					{
						if (filterOperand.GetType() == type)
						{
							return this._filterRowDefaultOperator;
						}
					}
				}
				if (this.RowFilterOperands.Count == 0)
				{
					return this._filterRowDefaultOperator;
				}
				return this.RowFilterOperands[0];
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001BA48 File Offset: 0x00019C48
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0001BA50 File Offset: 0x00019C50
		public bool FilterCaseSensitive
		{
			get
			{
				return this.filterCaseSensitive;
			}
			set
			{
				if (this.filterCaseSensitive != value)
				{
					this.filterCaseSensitive = value;
					this.OnPropertyChanged("FilterCaseSensitive");
					this.BuildFilters(true);
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001BA74 File Offset: 0x00019C74
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0001BA7C File Offset: 0x00019C7C
		[global::System.ComponentModel.Browsable(false)]
		public object FilterCellValue
		{
			get
			{
				return this._filterCellValue;
			}
			set
			{
				if (this.Column == null || this.Column.DataType == null)
				{
					this._filterCellValue = value;
					this.OnPropertyChanged("FilterCellValue");
					this.BuildFilters(true);
					return;
				}
				if (this._filterCellValue != value)
				{
					string value2 = value as string;
					if (!string.IsNullOrEmpty(value2))
					{
						try
						{
							object obj = global::Infragistics.Controls.Grids.Primitives.FilterRow.ChangeType(value, this.Column.DataType);
							if (this._filterCellValue != obj)
							{
								this._filterCellValue = global::Infragistics.Controls.Grids.Primitives.FilterRow.ChangeType(value, this.Column.DataType);
								this.OnPropertyChanged("FilterCellValue");
								this.BuildFilters(true);
							}
							return;
						}
						catch (global::System.FormatException)
						{
							global::Infragistics.Controls.Grids.EditableColumn editableColumn = this.Column as global::Infragistics.Controls.Grids.EditableColumn;
							if (editableColumn != null && editableColumn.AllowEditingValidation)
							{
								throw;
							}
							return;
						}
					}
					if (this._filterCellValue != null)
					{
						if (!(this.Column.DataType == typeof(string)))
						{
							this._filterCellValue = value;
							this.OnPropertyChanged("FilterCellValue");
							this.BuildFilters(true);
							return;
						}
						if (!string.IsNullOrEmpty(this._filterCellValue as string))
						{
							this._filterCellValue = value;
							this.OnPropertyChanged("FilterCellValue");
							this.BuildFilters(true);
							return;
						}
					}
					else
					{
						if (value is string && string.IsNullOrEmpty((string)value) && this._filterCellValue == null)
						{
							return;
						}
						this._filterCellValue = value;
						this.OnPropertyChanged("FilterCellValue");
						this.BuildFilters(true);
					}
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.FilterOperandCollection RowFilterOperands
		{
			get
			{
				if (this._rowFilterOperands == null)
				{
					this._rowFilterOperands = new global::Infragistics.Controls.Grids.FilterOperandCollection();
					if (this.Column != null)
					{
						this.Column.FillAvailableFilters(this._rowFilterOperands);
						this._autopopulatedFilterOperands = true;
					}
					this.OnPropertyChanged("RowFilterOperands");
				}
				if (this.Column != null && this.Column.ColumnLayout != null)
				{
					foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this._rowFilterOperands)
					{
						filterOperand.XamWebGrid = this.Column.ColumnLayout.Grid;
					}
				}
				return this._rowFilterOperands;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001BCAC File Offset: 0x00019EAC
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0001BCB4 File Offset: 0x00019EB4
		public string FilterMenuClearFiltersString
		{
			get
			{
				return this._filterMenuClearFiltersString;
			}
			set
			{
				if (this._filterMenuClearFiltersString != value)
				{
					this._filterMenuClearFiltersString = value;
					this.OnPropertyChanged("FilterMenuClearFiltersString");
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		public string FilterMenuClearFiltersStringResolved
		{
			get
			{
				string filterMenuClearFiltersString = this.FilterMenuClearFiltersString;
				if (string.IsNullOrEmpty(filterMenuClearFiltersString) && this.Column != null && this.Column.ColumnLayout != null)
				{
					return this.Column.ColumnLayout.FilteringSettings.FilterMenuClearFiltersStringResolved;
				}
				return filterMenuClearFiltersString;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001BD20 File Offset: 0x00019F20
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0001BD28 File Offset: 0x00019F28
		public string FilterMenuTypeSpecificFiltersString
		{
			get
			{
				return this._filterMenuTypeSpecificFiltersString;
			}
			set
			{
				if (this._filterMenuTypeSpecificFiltersString != value)
				{
					this._filterMenuTypeSpecificFiltersString = value;
					this.OnPropertyChanged("FilterMenuTypeSpecificFiltersString");
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001BD4A File Offset: 0x00019F4A
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0001BD5C File Offset: 0x00019F5C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? FilterMenuCustomFilteringButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuCustomFilteringButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuCustomFilteringButtonVisibilityProperty, value);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001BD70 File Offset: 0x00019F70
		private static void FilterMenuCustomFilteringButtonVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = (global::Infragistics.Controls.Grids.FilterColumnSettings)obj;
			filterColumnSettings.OnPropertyChanged("FilterMenuCustomFilteringButtonVisibility");
			filterColumnSettings.OnPropertyChanged("FilterMenuCustomFilteringButtonVisibilityResolved");
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001BD9C File Offset: 0x00019F9C
		public global::System.Windows.Visibility FilterMenuCustomFilteringButtonVisibilityResolved
		{
			get
			{
				global::System.Windows.Visibility result = global::System.Windows.Visibility.Visible;
				if (this.FilterMenuCustomFilteringButtonVisibility == null)
				{
					if (this.Column != null && this.Column.ColumnLayout != null)
					{
						result = this.Column.ColumnLayout.FilteringSettings.FilterMenuCustomFilteringButtonVisibilityResolved;
					}
				}
				else
				{
					result = this.FilterMenuCustomFilteringButtonVisibility.Value;
				}
				return result;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x0001BE0A File Offset: 0x0001A00A
		public string FilterMenuFormatString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuFormatStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuFormatStringProperty, value);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001BE18 File Offset: 0x0001A018
		private static void FilterMenuFormatStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = (global::Infragistics.Controls.Grids.FilterColumnSettings)obj;
			filterColumnSettings.OnPropertyChanged("FilterMenuFormatString");
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001BE37 File Offset: 0x0001A037
		public string FilterMenuFormatStringResolved
		{
			get
			{
				if (!string.IsNullOrEmpty(this.FilterMenuFormatString))
				{
					return this.FilterMenuFormatString;
				}
				return this.Column.FormatStringResolved;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001BE58 File Offset: 0x0001A058
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x0001BE6A File Offset: 0x0001A06A
		public global::System.Windows.Style FilterRowCellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterRowCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterRowCellStyleProperty, value);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001BE78 File Offset: 0x0001A078
		private static void FilterRowCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = (global::Infragistics.Controls.Grids.FilterColumnSettings)obj;
			if (filterColumnSettings.Column != null)
			{
				filterColumnSettings.Column.OnStyleChanged();
			}
			filterColumnSettings.OnPropertyChanged("FilterRowCellStyle");
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> FilterMenuOperands
		{
			get
			{
				if (this._filterMenuOps == null)
				{
					this._filterMenuOps = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject>();
					if (this.Column != null)
					{
						this.Column.FillFilterMenuOptions(this._filterMenuOps);
						this._autopopulatedFilterMenuOperands = true;
					}
					this.OnPropertyChanged("FilterMenuOperands");
				}
				this.SetFilterColumnSettings(this._filterMenuOps);
				return this._filterMenuOps;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001BF09 File Offset: 0x0001A109
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0001BF11 File Offset: 0x0001A111
		protected internal bool SilentUpdate { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001BF1A File Offset: 0x0001A11A
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0001BF24 File Offset: 0x0001A124
		public override global::Infragistics.Controls.Grids.Column Column
		{
			get
			{
				return base.Column;
			}
			protected internal set
			{
				if (this.Column != value)
				{
					base.Column = value;
					if (value != null)
					{
						this._filterRowDefaultOperator = this.Column.DefaultFilterOperand;
					}
				}
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001BF57 File Offset: 0x0001A157
		internal void BuildFilters(bool raiseEvents)
		{
			this.BuildFilters(raiseEvents, true);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001BF64 File Offset: 0x0001A164
		internal void BuildFilters(bool raiseEvents, bool clearExistingFilters)
		{
			if (this.Column != null)
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Column.ColumnLayout;
				if (columnLayout != null)
				{
					global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettings = columnLayout.FilteringSettings;
					if (filteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout)
					{
						global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollection = columnLayout.FilteringSettings.RowFiltersCollection;
						if (columnLayout.BuildFilters(rowFiltersCollection, this.FilterCellValue, this.Column, this.FilteringOperandResolved, this.SilentUpdate, clearExistingFilters, raiseEvents))
						{
							columnLayout.Grid.OnFiltered(rowFiltersCollection);
						}
					}
					columnLayout.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001BFE0 File Offset: 0x0001A1E0
		private void SetFilterColumnSettings(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			if (list != null)
			{
				foreach (global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject in list)
				{
					filterMenuTrackingObject.FilterColumnSettings = this;
					this.SetFilterColumnSettings(filterMenuTrackingObject.Children);
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001C040 File Offset: 0x0001A240
		protected internal void ValidateFilterOperands()
		{
			if (this._rowFilterOperands == null || (this._autopopulatedFilterOperands && this.Column != null))
			{
				this._rowFilterOperands = null;
				global::Infragistics.Controls.Grids.FilterOperandCollection rowFilterOperands = this.RowFilterOperands;
				this._filterRowDefaultOperator = this.Column.DefaultFilterOperand;
				this.OnLoadedCatchUp();
			}
			else if (this._rowFilterOperands != null && !this._autopopulatedFilterOperands)
			{
				this.OnLoadedCatchUp();
			}
			this.OnPropertyChanged("RowFilterOperands");
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001C0AD File Offset: 0x0001A2AD
		protected internal void ValidateFilterMenuOperands()
		{
			if (this._filterMenuOps == null || (this._autopopulatedFilterMenuOperands && this.Column != null))
			{
				this._filterMenuOps = null;
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> filterMenuOperands = this.FilterMenuOperands;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001C0D5 File Offset: 0x0001A2D5
		protected internal void ValidateResolvedProperties()
		{
			this.OnPropertyChanged("FilterMenuFormatStringResolved");
			this.OnPropertyChanged("FilterMenuCustomFilteringButtonVisibilityResolved");
			this.OnPropertyChanged("FilterMenuClearFiltersStringResolved");
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		protected internal override void OnLoadedCatchUp()
		{
			global::Infragistics.Controls.Grids.Column column = this.Column;
			if (column != null && column.ColumnLayout != null)
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
				global::Infragistics.Controls.Grids.XamGrid grid = columnLayout.Grid;
				if (grid != null && (columnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout || columnLayout.Level == 0))
				{
					global::Infragistics.Controls.Grids.FilterOperand filteringOperandResolved = this.FilteringOperandResolved;
					if (filteringOperandResolved != null && (!filteringOperandResolved.RequiresFilteringInput || (filteringOperandResolved.RequiresFilteringInput && this.FilterCellValue != null)) && columnLayout.BuildFilters(grid.RowsManager.RowFiltersCollectionResolved, this.FilterCellValue, column, filteringOperandResolved, true, true))
					{
						columnLayout.Grid.OnFiltered(grid.RowsManager.RowFiltersCollectionResolved);
					}
				}
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001C198 File Offset: 0x0001A398
		protected internal override void Reset()
		{
			base.Reset();
			if (this._autopopulatedFilterMenuOperands && this._filterMenuOps != null)
			{
				this._filterMenuOps = null;
			}
			if (this._autopopulatedFilterOperands && this._rowFilterOperands != null)
			{
				foreach (global::Infragistics.Controls.Grids.FilterOperand filterOperand in this._rowFilterOperands)
				{
					filterOperand.XamWebGrid = null;
				}
				this._rowFilterOperands.Clear();
				this._rowFilterOperands = null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001C224 File Offset: 0x0001A424
		protected override global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"FilteringOperandResolved",
						"FilterMenuCustomFilteringButtonVisibilityResolved",
						"FilterMenuFormatStringResolved",
						"FilterMenuClearFiltersStringResolved",
						"Column"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001C283 File Offset: 0x0001A483
		protected override global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000180 RID: 384
		private global::Infragistics.Controls.Grids.FilterOperand _filterRowDefaultOperator;

		// Token: 0x04000181 RID: 385
		private bool filterCaseSensitive;

		// Token: 0x04000182 RID: 386
		private object _filterCellValue;

		// Token: 0x04000183 RID: 387
		private global::Infragistics.Controls.Grids.FilterOperandCollection _rowFilterOperands;

		// Token: 0x04000184 RID: 388
		private global::Infragistics.Controls.Grids.FilterOperand _filteringOperand;

		// Token: 0x04000185 RID: 389
		private bool _autopopulatedFilterOperands;

		// Token: 0x04000186 RID: 390
		private bool _autopopulatedFilterMenuOperands;

		// Token: 0x04000187 RID: 391
		private string _filterMenuClearFiltersString;

		// Token: 0x04000188 RID: 392
		private string _filterMenuTypeSpecificFiltersString;

		// Token: 0x04000189 RID: 393
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> _filterMenuOps;

		// Token: 0x0400018A RID: 394
		public static readonly global::System.Windows.DependencyProperty FilterMenuCustomFilteringButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("FilterMenuCustomFilteringButtonVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Grids.FilterColumnSettings), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuCustomFilteringButtonVisibilityChanged)));

		// Token: 0x0400018B RID: 395
		public static readonly global::System.Windows.DependencyProperty FilterMenuFormatStringProperty = global::System.Windows.DependencyProperty.Register("FilterMenuFormatString", typeof(string), typeof(global::Infragistics.Controls.Grids.FilterColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterMenuFormatStringChanged)));

		// Token: 0x0400018C RID: 396
		public static readonly global::System.Windows.DependencyProperty FilterRowCellStyleProperty = global::System.Windows.DependencyProperty.Register("FilterRowCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FilterColumnSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FilterColumnSettings.FilterRowCellStyleChanged)));

		// Token: 0x0400018D RID: 397
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
