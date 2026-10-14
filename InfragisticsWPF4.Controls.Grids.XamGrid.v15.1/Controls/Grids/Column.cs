using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using Infragistics.Collections;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000233 RID: 563
	public abstract class Column : global::Infragistics.Controls.Grids.ColumnBase, global::Infragistics.ISelectableObject
	{
		// Token: 0x06000FEC RID: 4076 RVA: 0x0003BC4C File Offset: 0x00039E4C
		protected Column()
		{
			this._isFixable = true;
			this.IsMovable = true;
			this._isSortable = true;
			this.IsResizable = true;
			this.IsGroupable = true;
			this.AddNewRowItemTemplateVerticalContentAlignment = (this.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Center);
			this._cachedAllowToolTips = (global::Infragistics.Controls.Grids.AllowToolTips)base.GetValue(global::Infragistics.Controls.Grids.Column.AllowToolTipsProperty);
			this._cachedColumnWidth = (global::Infragistics.Controls.Grids.ColumnWidth?)base.GetValue(global::Infragistics.Controls.Grids.Column.WidthProperty);
			this._cachedMinimumWidth = (double)base.GetValue(global::Infragistics.Controls.Grids.Column.MinimumWidthProperty);
			this._cachedMaximumWidth = (double)base.GetValue(global::Infragistics.Controls.Grids.Column.MaximumWidthProperty);
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x0003BCFF File Offset: 0x00039EFF
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0003BD07 File Offset: 0x00039F07
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableColumnWidthTypeConverter))]
		public virtual global::Infragistics.Controls.Grids.ColumnWidth? Width
		{
			get
			{
				return this._cachedColumnWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.WidthProperty, value);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0003BD1C File Offset: 0x00039F1C
		private static void WidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column._cachedColumnWidth = (global::Infragistics.Controls.Grids.ColumnWidth?)e.NewValue;
			column.ActualWidth = 0.0;
			column.OnPropertyChanged("Width");
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0003BD5C File Offset: 0x00039F5C
		public virtual global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				if (this.Width == null)
				{
					return base.ColumnLayout.ColumnWidthResolved;
				}
				return this.Width.Value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0003BD93 File Offset: 0x00039F93
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0003BD9B File Offset: 0x00039F9B
		public double ActualWidth
		{
			get
			{
				return this._actualWidth;
			}
			internal set
			{
				if (this._actualWidth != value)
				{
					this._actualWidth = value;
					this.OnPropertyChanged("ActualWidth");
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0003BDC0 File Offset: 0x00039FC0
		public virtual double MinimumWidth
		{
			get
			{
				return this._cachedMinimumWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.MinimumWidthProperty, value);
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		private static void MinimumWidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column._cachedMinimumWidth = (double)e.NewValue;
			column.OnPropertyChanged("MinimumWidth");
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0003BE05 File Offset: 0x0003A005
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0003BE0D File Offset: 0x0003A00D
		public virtual double MaximumWidth
		{
			get
			{
				return this._cachedMaximumWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.MaximumWidthProperty, value);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0003BE20 File Offset: 0x0003A020
		private static void MaximumWidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column._cachedMaximumWidth = (double)e.NewValue;
			column.OnPropertyChanged("MaximumWidth");
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0003BE51 File Offset: 0x0003A051
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x0003BE59 File Offset: 0x0003A059
		public global::System.Windows.DataTemplate FooterTemplate
		{
			get
			{
				return this._footerTemplate;
			}
			set
			{
				this._footerTemplate = value;
				this.OnPropertyChanged("FooterTemplate");
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0003BE6D File Offset: 0x0003A06D
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x0003BE7F File Offset: 0x0003A07F
		public string FooterText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Column.FooterTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.FooterTextProperty, value);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0003BE90 File Offset: 0x0003A090
		private static void FooterTextChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("FooterText");
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0003BEAF File Offset: 0x0003A0AF
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0003BEB7 File Offset: 0x0003A0B7
		public global::Infragistics.Controls.Grids.FixedState IsFixed
		{
			get
			{
				return this._isFixed;
			}
			set
			{
				if (this._isFixed != value)
				{
					this.SetFixedColumnState(value);
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0003BECA File Offset: 0x0003A0CA
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0003BED4 File Offset: 0x0003A0D4
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.FixedIndicatorDirection>))]
		public global::Infragistics.Controls.Grids.FixedIndicatorDirection? FixedIndicatorDirection
		{
			get
			{
				return this._fixedDirection;
			}
			set
			{
				if (this._fixedDirection != value)
				{
					this._fixedDirection = value;
					this.OnPropertyChanged("FixedIndicatorDirection");
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0003BF24 File Offset: 0x0003A124
		public global::Infragistics.Controls.Grids.FixedIndicatorDirection FixedIndicatorDirectionResolved
		{
			get
			{
				if (this.FixedIndicatorDirection == null && base.ColumnLayout != null)
				{
					return base.ColumnLayout.FixedColumnSettings.FixedIndicatorDirectionResolved;
				}
				return this.FixedIndicatorDirection.Value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0003BF68 File Offset: 0x0003A168
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x0003BFBC File Offset: 0x0003A1BC
		public virtual bool IsFixable
		{
			get
			{
				return this.ParentColumn == null && (!this.IsGroupBy || base.ColumnLayout == null || base.ColumnLayout.Grid == null || base.ColumnLayout.Grid.GroupBySettings.GroupByOperation != global::Infragistics.Controls.Grids.GroupByOperation.MergeCells) && this._isFixable;
			}
			set
			{
				if (this._isFixable != value)
				{
					this._isFixable = value;
					this.OnPropertyChanged("IsFixable");
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0003BFD9 File Offset: 0x0003A1D9
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x0003BFE1 File Offset: 0x0003A1E1
		public global::System.Windows.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				return this._hAlign;
			}
			set
			{
				this._hAlign = value;
				this.OnPropertyChanged("HorizontalContentAlignment");
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x0003BFF5 File Offset: 0x0003A1F5
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x0003BFFD File Offset: 0x0003A1FD
		public global::System.Windows.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				return this._vAlign;
			}
			set
			{
				this._vAlign = value;
				this.OnPropertyChanged("VerticalContentAlignment");
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0003C011 File Offset: 0x0003A211
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0003C019 File Offset: 0x0003A219
		public virtual bool IsSortable
		{
			get
			{
				return this._isSortable;
			}
			set
			{
				if (this._isSortable != value)
				{
					this._isSortable = value;
					this.OnPropertyChanged("IsSortable");
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0003C036 File Offset: 0x0003A236
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x0003C03E File Offset: 0x0003A23E
		public bool AllowCaseSensitiveSort
		{
			get
			{
				return this._allowCaseSensitiveSort;
			}
			set
			{
				if (this._allowCaseSensitiveSort != value)
				{
					this._allowCaseSensitiveSort = value;
					this.OnPropertyChanged("AllowCaseSensitiveSort");
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0003C05B File Offset: 0x0003A25B
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x0003C063 File Offset: 0x0003A263
		public object SortComparer
		{
			get
			{
				return this._comparer;
			}
			set
			{
				if (this._comparer != value)
				{
					this._comparer = value;
					this.ValidateSortComparer();
					this.OnPropertyChanged("SortComparer");
				}
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0003C086 File Offset: 0x0003A286
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x0003C08E File Offset: 0x0003A28E
		public virtual bool IsMovable { get; set; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x0003C097 File Offset: 0x0003A297
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x0003C09F File Offset: 0x0003A29F
		public virtual bool IsResizable { get; set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x0003C0A8 File Offset: 0x0003A2A8
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x0003C0B0 File Offset: 0x0003A2B0
		public virtual bool IsFilterable
		{
			get
			{
				return this._isFilterable;
			}
			set
			{
				if (this._isFilterable != value)
				{
					this._isFilterable = value;
					if (base.ColumnLayout != null)
					{
						base.ColumnLayout.Grid.ExitEditModeInternal(true);
						base.ColumnLayout.Grid.InvalidateScrollPanel(false);
					}
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0003C0ED File Offset: 0x0003A2ED
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x0003C0F8 File Offset: 0x0003A2F8
		public virtual bool IsSelected
		{
			get
			{
				return this._isSelected;
			}
			set
			{
				if (this.SupportsActivationAndSelection)
				{
					if (base.ColumnLayout != null)
					{
						if (value)
						{
							base.ColumnLayout.Grid.SelectColumn(this, global::Infragistics.Controls.Grids.InvokeAction.Code);
							return;
						}
						base.ColumnLayout.Grid.UnselectColumn(this);
						return;
					}
					else
					{
						this._isSelected = value;
					}
				}
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0003C145 File Offset: 0x0003A345
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x0003C14D File Offset: 0x0003A34D
		public virtual global::Infragistics.Controls.Grids.SortDirection IsSorted
		{
			get
			{
				return this._isSorted;
			}
			set
			{
				if (this._isSorted != value)
				{
					this.SetSortedColumnState(value);
				}
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0003C160 File Offset: 0x0003A360
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x0003C168 File Offset: 0x0003A368
		public virtual bool IsSummable
		{
			get
			{
				return this._isSummable;
			}
			set
			{
				if (this._isSummable != value)
				{
					this._isSummable = value;
					if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
					{
						base.ColumnLayout.Grid.InvalidateScrollPanel(false);
					}
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0003C1A0 File Offset: 0x0003A3A0
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x0003C1A8 File Offset: 0x0003A3A8
		public virtual bool IsGroupable
		{
			get
			{
				return this._isGroupable;
			}
			set
			{
				if (this._isGroupable != value)
				{
					this._isGroupable = value;
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0003C1BA File Offset: 0x0003A3BA
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x0003C1C4 File Offset: 0x0003A3C4
		public bool IsGroupBy
		{
			get
			{
				return this._isGroupBy;
			}
			set
			{
				if (this._isGroupBy != value && this.CanBeGroupedBy)
				{
					if (base.ColumnLayout != null)
					{
						if (value)
						{
							base.ColumnLayout.Grid.GroupBySettings.GroupByColumns.Add(this);
							return;
						}
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
						if (columnLayout != null && columnLayout.Grid != null && (columnLayout.Grid.CurrentEditCell != null || columnLayout.Grid.CurrentEditRow != null))
						{
							columnLayout.Grid.ExitEditMode(true);
						}
						base.ColumnLayout.Grid.GroupBySettings.GroupByColumns.Remove(this);
						return;
					}
					else
					{
						this._isGroupBy = value;
					}
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x0003C26C File Offset: 0x0003A46C
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x0003C27E File Offset: 0x0003A47E
		public global::System.Windows.Data.IValueConverter ValueConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Grids.Column.ValueConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ValueConverterProperty, value);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0003C28C File Offset: 0x0003A48C
		private static void ValueConverterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("ValueConverter");
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows();
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0003C2D0 File Offset: 0x0003A4D0
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0003C2DD File Offset: 0x0003A4DD
		public object ValueConverterParameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.Column.ValueConverterParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ValueConverterParameterProperty, value);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0003C2EC File Offset: 0x0003A4EC
		private static void ValueConverterParameterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("ValueConverterParameter");
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0003C30B File Offset: 0x0003A50B
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x0003C31D File Offset: 0x0003A51D
		public global::System.Windows.DataTemplate GroupByItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Column.GroupByItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.GroupByItemTemplateProperty, value);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0003C32C File Offset: 0x0003A52C
		private static void GroupByItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows(true);
			}
			column.OnPropertyChanged("GroupByItemTemplate");
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0003C371 File Offset: 0x0003A571
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x0003C379 File Offset: 0x0003A579
		public object GroupByComparer
		{
			get
			{
				return this._groupByComparer;
			}
			set
			{
				if (this._groupByComparer != value)
				{
					this._groupByComparer = value;
					this.ValidateGroupByComparer();
					this.OnPropertyChanged("GroupByComparer");
					if (base.ColumnLayout != null)
					{
						base.ColumnLayout.InvalidateGroupByReset();
					}
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0003C3AF File Offset: 0x0003A5AF
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x0003C3E4 File Offset: 0x0003A5E4
		public global::Infragistics.Controls.Grids.SummaryColumnSettings SummaryColumnSettings
		{
			get
			{
				if (this._summaryColumnSettings == null)
				{
					this._summaryColumnSettings = new global::Infragistics.Controls.Grids.SummaryColumnSettings(this);
					this._summaryColumnSettings.PropertyChanged += this.SummaryColumnSettings_PropertyChanged;
				}
				return this._summaryColumnSettings;
			}
			set
			{
				if (this._summaryColumnSettings != value)
				{
					if (this._summaryColumnSettings != null)
					{
						this._summaryColumnSettings.PropertyChanged -= this.SummaryColumnSettings_PropertyChanged;
					}
					this._summaryColumnSettings = value;
					if (value != null)
					{
						this._summaryColumnSettings.Column = this;
						value.RepopulateSummaryDefinitionCollection();
						this._summaryColumnSettings.PropertyChanged += this.SummaryColumnSettings_PropertyChanged;
					}
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0003C44C File Offset: 0x0003A64C
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x0003C468 File Offset: 0x0003A668
		public global::Infragistics.Controls.Grids.FilterColumnSettings FilterColumnSettings
		{
			get
			{
				if (this._filterColumnSettings == null)
				{
					this._filterColumnSettings = new global::Infragistics.Controls.Grids.FilterColumnSettings(this);
				}
				return this._filterColumnSettings;
			}
			set
			{
				if (this._filterColumnSettings != value)
				{
					this._filterColumnSettings = value;
					if (value != null)
					{
						this._filterColumnSettings.Column = this;
					}
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0003C489 File Offset: 0x0003A689
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x0003C49B File Offset: 0x0003A69B
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.SortDirection>))]
		public global::Infragistics.Controls.Grids.SortDirection? FirstSortDirection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SortDirection?)base.GetValue(global::Infragistics.Controls.Grids.Column.FirstSortDirectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.FirstSortDirectionProperty, value);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		private static void FirstSortDirectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("FirstSortDirection");
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0003C4D0 File Offset: 0x0003A6D0
		public global::Infragistics.Controls.Grids.SortDirection FirstSortDirectionResolved
		{
			get
			{
				if (this.FirstSortDirection != null)
				{
					return this.FirstSortDirection.Value;
				}
				if (base.ColumnLayout != null)
				{
					return base.ColumnLayout.SortingSettings.FirstSortDirectionResolved;
				}
				return global::Infragistics.Controls.Grids.SortDirection.Ascending;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0003C516 File Offset: 0x0003A716
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x0003C528 File Offset: 0x0003A728
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.HorizontalAlignment>))]
		public global::System.Windows.HorizontalAlignment? HeaderTextHorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment?)base.GetValue(global::Infragistics.Controls.Grids.Column.HeaderTextHorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.HeaderTextHorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0003C53C File Offset: 0x0003A73C
		private static void HeaderTextHorizontalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("HeaderTextHorizontalAlignment");
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0003C55C File Offset: 0x0003A75C
		public global::System.Windows.HorizontalAlignment HeaderTextHorizontalAlignmentResolved
		{
			get
			{
				if (this.HeaderTextHorizontalAlignment != null)
				{
					return this.HeaderTextHorizontalAlignment.Value;
				}
				if (base.ColumnLayout != null)
				{
					return base.ColumnLayout.HeaderTextHorizontalAlignmentResolved;
				}
				return (global::System.Windows.HorizontalAlignment)global::Infragistics.Controls.Grids.XamGrid.HeaderTextHorizontalAlignmentProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0003C5BA File Offset: 0x0003A7BA
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.VerticalAlignment>))]
		public global::System.Windows.VerticalAlignment? HeaderTextVerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment?)base.GetValue(global::Infragistics.Controls.Grids.Column.HeaderTextVerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.HeaderTextVerticalAlignmentProperty, value);
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0003C5E0 File Offset: 0x0003A7E0
		private static void HeaderTextVerticalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("HeaderTextVerticalAlignment");
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0003C600 File Offset: 0x0003A800
		public global::System.Windows.VerticalAlignment HeaderTextVerticalAlignmentResolved
		{
			get
			{
				if (this.HeaderTextVerticalAlignment != null)
				{
					return this.HeaderTextVerticalAlignment.Value;
				}
				if (base.ColumnLayout != null)
				{
					return base.ColumnLayout.HeaderTextVerticalAlignmentResolved;
				}
				return (global::System.Windows.VerticalAlignment)global::Infragistics.Controls.Grids.XamGrid.HeaderTextVerticalAlignmentProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0003C660 File Offset: 0x0003A860
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.ConditionalFormatCollection ConditionalFormatCollection
		{
			get
			{
				if (this._conditionalFormatCollection == null)
				{
					this._conditionalFormatCollection = new global::Infragistics.Controls.Grids.ConditionalFormatCollection();
					this._conditionalFormatCollection.CollectionChanged += this.ConditionalFormatCollection_CollectionChanged;
					this._conditionalFormatCollection.CollectionItemChanged += this.ConditionalFormatCollection_CollectionItemChanged;
					this._conditionalFormatCollection.Column = this;
				}
				return this._conditionalFormatCollection;
			}
			set
			{
				if (this._conditionalFormatCollection != null)
				{
					this._conditionalFormatCollection.CollectionChanged -= this.ConditionalFormatCollection_CollectionChanged;
					this._conditionalFormatCollection.CollectionItemChanged -= this.ConditionalFormatCollection_CollectionItemChanged;
					this._conditionalFormatCollection.Column = null;
				}
				this._conditionalFormatCollection = value;
				if (this._conditionalFormatCollection != null)
				{
					this._conditionalFormatCollection.CollectionChanged += this.ConditionalFormatCollection_CollectionChanged;
					this._conditionalFormatCollection.CollectionItemChanged += this.ConditionalFormatCollection_CollectionItemChanged;
					this._conditionalFormatCollection.Column = this;
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0003C758 File Offset: 0x0003A958
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0003C76A File Offset: 0x0003A96A
		public global::System.Windows.Style ToolTipStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Column.ToolTipStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ToolTipStyleProperty, value);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0003C778 File Offset: 0x0003A978
		private static void ToolTipStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("ToolTipStyle");
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0003C797 File Offset: 0x0003A997
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0003C7A9 File Offset: 0x0003A9A9
		public global::System.Windows.DataTemplate ToolTipContentTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Column.ToolTipContentTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ToolTipContentTemplateProperty, value);
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		private static void ToolTipContentTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("TooltipContentTemplate");
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0003C7D7 File Offset: 0x0003A9D7
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0003C7DF File Offset: 0x0003A9DF
		public global::Infragistics.Controls.Grids.AllowToolTips AllowToolTips
		{
			get
			{
				return this._cachedAllowToolTips;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AllowToolTipsProperty, value);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0003C7F2 File Offset: 0x0003A9F2
		internal virtual bool ShouldAlwaysAllowToolTips(global::Infragistics.Controls.Grids.CellBase cell)
		{
			return this.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Always;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0003C800 File Offset: 0x0003AA00
		private static void AllowToolTipsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column._cachedAllowToolTips = (global::Infragistics.Controls.Grids.AllowToolTips)e.NewValue;
			column.OnPropertyChanged("AllowToolTips");
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0003C831 File Offset: 0x0003AA31
		[global::System.ComponentModel.Browsable(false)]
		public virtual global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllColumns
		{
			get
			{
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>());
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0003C83D File Offset: 0x0003AA3D
		[global::System.ComponentModel.Browsable(false)]
		public virtual global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllVisibleChildColumns
		{
			get
			{
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>());
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0003C849 File Offset: 0x0003AA49
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0003C85B File Offset: 0x0003AA5B
		public global::System.Windows.DataTemplate AddNewRowItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateProperty, value);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0003C86C File Offset: 0x0003AA6C
		private static void AddNewRowItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowItemTemplate");
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0003C8B1 File Offset: 0x0003AAB1
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x0003C8C3 File Offset: 0x0003AAC3
		public global::System.Windows.DataTemplate AddNewRowEditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateProperty, value);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0003C8D4 File Offset: 0x0003AAD4
		private static void AddNewRowEditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowEditorTemplate");
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0003C919 File Offset: 0x0003AB19
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0003C92B File Offset: 0x0003AB2B
		public global::System.Windows.HorizontalAlignment AddNewRowItemTemplateHorizontalContentAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateHorizontalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateHorizontalContentAlignmentProperty, value);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0003C940 File Offset: 0x0003AB40
		private static void AddNewRowItemTemplateHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowItemTemplateHorizontalContentAlignment");
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0003C985 File Offset: 0x0003AB85
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x0003C997 File Offset: 0x0003AB97
		public global::System.Windows.VerticalAlignment AddNewRowItemTemplateVerticalContentAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateVerticalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateVerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		private static void AddNewRowItemTemplateVerticalContentAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowItemTemplateVerticalContentAlignment");
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0003C9F1 File Offset: 0x0003ABF1
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0003CA03 File Offset: 0x0003AC03
		public global::System.Windows.VerticalAlignment AddNewRowEditorTemplateVerticalContentAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateVerticalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateVerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0003CA18 File Offset: 0x0003AC18
		private static void AddNewRowEditorTemplateVerticalContentAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowEditorTemplateVerticalContentAlignment");
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0003CA37 File Offset: 0x0003AC37
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x0003CA49 File Offset: 0x0003AC49
		public global::System.Windows.HorizontalAlignment AddNewRowEditorTemplateHorizontalContentAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateHorizontalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateHorizontalContentAlignmentProperty, value);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		private static void AddNewRowEditorTemplateHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnPropertyChanged("AddNewRowEditorTemplateHorizontalContentAlignment");
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0003CA7B File Offset: 0x0003AC7B
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x0003CA8D File Offset: 0x0003AC8D
		public global::System.Windows.DataTemplate MergedItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Column.MergedItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.MergedItemTemplateProperty, value);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		private static void MergedItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			if (column.ColumnLayout != null && column.ColumnLayout.Grid != null)
			{
				column.ColumnLayout.Grid.ResetPanelRows();
			}
			column.OnPropertyChanged("MergedItemTemplate");
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0003CAE0 File Offset: 0x0003ACE0
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0003CAF2 File Offset: 0x0003ACF2
		public global::System.Windows.Style AddNewRowCellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Column.AddNewRowCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.AddNewRowCellStyleProperty, value);
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0003CB00 File Offset: 0x0003AD00
		private static void AddNewRowCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnStyleChanged();
			column.OnPropertyChanged("AddNewRowCellStyle");
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0003CB25 File Offset: 0x0003AD25
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x0003CB37 File Offset: 0x0003AD37
		public global::System.Windows.Style GroupByRowStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Column.GroupByRowCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.GroupByRowCellStyleProperty, value);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0003CB48 File Offset: 0x0003AD48
		private static void GroupByRowCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnStyleChanged();
			column.OnPropertyChanged("GroupByRowCellStyle");
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0003CB6D File Offset: 0x0003AD6D
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x0003CB7F File Offset: 0x0003AD7F
		public global::System.Windows.Style GroupByHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Column.GroupByHeaderCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.GroupByHeaderCellStyleProperty, value);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0003CB90 File Offset: 0x0003AD90
		private static void GroupByHeaderCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnStyleChanged();
			column.OnPropertyChanged("GroupByHeaderCellStyle");
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0003CBB5 File Offset: 0x0003ADB5
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0003CBC7 File Offset: 0x0003ADC7
		public global::System.Windows.Style MergeCellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Column.MergeCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.MergeCellStyleProperty, value);
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0003CBD8 File Offset: 0x0003ADD8
		private static void MergeCellStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
			column.OnStyleChanged();
			column.OnPropertyChanged("MergeCellStyle");
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0003CBFD File Offset: 0x0003ADFD
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x0003CC05 File Offset: 0x0003AE05
		internal double PercentMoved { get; set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0003CC0E File Offset: 0x0003AE0E
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x0003CC16 File Offset: 0x0003AE16
		internal double MovingColumnsWidth { get; set; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0003CC1F File Offset: 0x0003AE1F
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x0003CC27 File Offset: 0x0003AE27
		internal bool ReverseMove { get; set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0003CC30 File Offset: 0x0003AE30
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x0003CC38 File Offset: 0x0003AE38
		internal bool IsInitialAutoSet { get; set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0003CC41 File Offset: 0x0003AE41
		internal string TypeName
		{
			get
			{
				if (this._cachedTypeName == null)
				{
					this._cachedTypeName = base.GetType().Name;
				}
				return this._cachedTypeName;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0003CC62 File Offset: 0x0003AE62
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x0003CC6A File Offset: 0x0003AE6A
		internal bool IsDragging { get; set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0003CC73 File Offset: 0x0003AE73
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x0003CC7B File Offset: 0x0003AE7B
		internal bool ForceUpdateRowStyle { get; set; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0003CC84 File Offset: 0x0003AE84
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		internal bool? CachedPropertyReadOnly { get; set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0003CC95 File Offset: 0x0003AE95
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x0003CC9D File Offset: 0x0003AE9D
		internal int CachedClipboardIndex { get; set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0003CCA6 File Offset: 0x0003AEA6
		internal global::Infragistics.Controls.Grids.Column CachedParentColumn
		{
			get
			{
				return this._cachedParentColumn;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0003CCAE File Offset: 0x0003AEAE
		protected internal virtual bool SupportsHeaderFooterContent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0003CCB1 File Offset: 0x0003AEB1
		protected internal virtual bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x0003CCB4 File Offset: 0x0003AEB4
		protected internal virtual bool UniqueColumnContent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0003CCB7 File Offset: 0x0003AEB7
		protected internal virtual global::Infragistics.Controls.Grids.FilterOperand DefaultFilterOperand
		{
			get
			{
				if (this._defaultFilterOperand == null)
				{
					this._defaultFilterOperand = new global::Infragistics.Controls.Grids.EqualsOperand();
				}
				return this._defaultFilterOperand;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0003CCD2 File Offset: 0x0003AED2
		protected internal virtual bool AllowCellEditorValueChangedFiltering
		{
			get
			{
				return this.DataType == typeof(string);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0003CCE9 File Offset: 0x0003AEE9
		protected internal virtual string FormatStringResolved
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x0003CCEC File Offset: 0x0003AEEC
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		protected internal global::Infragistics.Controls.Grids.Column ParentColumn { get; set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0003CCFD File Offset: 0x0003AEFD
		protected internal virtual global::Infragistics.Controls.Grids.Column ResizeColumnResolved
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0003CD00 File Offset: 0x0003AF00
		protected internal virtual bool SupportsActivationAndSelection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0003CD03 File Offset: 0x0003AF03
		protected internal virtual bool CanBeGroupedBy
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0003CD06 File Offset: 0x0003AF06
		protected internal virtual bool CanBeSorted
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0003CD09 File Offset: 0x0003AF09
		protected internal virtual bool CanBeFiltered
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		protected internal virtual bool UseReadOnlyFlag
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0003CD0F File Offset: 0x0003AF0F
		protected internal virtual bool ResetCellValueObjectAfterEditing
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x0003CD12 File Offset: 0x0003AF12
		protected virtual string FilterMenuCustomFilterString
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("CustomFiltersWithoutType");
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0003CD1E File Offset: 0x0003AF1E
		protected internal virtual void SetSelected(bool isSelected)
		{
			this._isSelected = isSelected;
			if (base.ColumnLayout != null)
			{
				base.ColumnLayout.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0003CD40 File Offset: 0x0003AF40
		protected internal virtual global::Infragistics.Controls.Grids.CellBase GenerateCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row is global::Infragistics.Controls.Grids.Primitives.HeaderRow)
			{
				return this.GenerateHeaderCell(row);
			}
			if (row is global::Infragistics.Controls.Grids.Primitives.FooterRow)
			{
				return this.GenerateFooterCell(row);
			}
			return this.GenerateDataCell(row);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0003CD69 File Offset: 0x0003AF69
		protected virtual global::Infragistics.Controls.Grids.CellBase GenerateHeaderCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.HeaderCell(row, this);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0003CD72 File Offset: 0x0003AF72
		protected virtual global::Infragistics.Controls.Grids.CellBase GenerateFooterCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.FooterCell(row, this);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0003CD7C File Offset: 0x0003AF7C
		protected virtual global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.AddNewRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.FilterRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.SummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.SummaryRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.MergedSummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.MergedSummaryCell(row, this);
			}
			if (base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
			{
				return new global::Infragistics.Controls.Grids.ConditionalFormattingCell(row, this);
			}
			return new global::Infragistics.Controls.Grids.Cell(row, this);
		}

		// Token: 0x06001090 RID: 4240
		protected internal abstract global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider();

		// Token: 0x06001091 RID: 4241 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		protected internal virtual void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
			if (columnLayout != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = columnLayout.Grid;
				if (grid != null)
				{
					availableFilters.Add(new global::Infragistics.Controls.Grids.EqualsOperand
					{
						XamWebGrid = grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.NotEqualsOperand
					{
						XamWebGrid = grid
					});
				}
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0003CE44 File Offset: 0x0003B044
		protected internal virtual void FillAvailableSummaries(global::Infragistics.SummaryOperandCollection availableSummaries)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
			if (columnLayout != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = columnLayout.Grid;
				if (grid != null)
				{
					availableSummaries.Add(new global::Infragistics.Controls.Grids.CountSummaryOperand());
					if (this.DataType != typeof(bool) && this.DataType != typeof(bool?))
					{
						availableSummaries.Add(new global::Infragistics.Controls.Grids.MaximumSummaryOperand());
						availableSummaries.Add(new global::Infragistics.Controls.Grids.MinimumSummaryOperand());
					}
					if (this.DataType == typeof(int) || this.DataType == typeof(int?) || this.DataType == typeof(double) || this.DataType == typeof(double?) || this.DataType == typeof(decimal) || this.DataType == typeof(decimal?) || this.DataType == typeof(long) || this.DataType == typeof(long?) || this.DataType == typeof(float) || this.DataType == typeof(float?) || this.DataType == typeof(byte) || this.DataType == typeof(byte?) || this.DataType == typeof(sbyte) || this.DataType == typeof(sbyte?) || this.DataType == typeof(short) || this.DataType == typeof(short?) || this.DataType == typeof(ushort) || this.DataType == typeof(ushort?) || this.DataType == typeof(ulong) || this.DataType == typeof(ulong?) || this.DataType == typeof(uint) || this.DataType == typeof(uint?))
					{
						availableSummaries.Add(new global::Infragistics.Controls.Grids.SumSummaryOperand());
						availableSummaries.Add(new global::Infragistics.Controls.Grids.AverageSummaryOperand());
					}
				}
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0003D0FC File Offset: 0x0003B2FC
		protected internal void OnShowAvailableColumnFilterOperands()
		{
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
			{
				global::Infragistics.Controls.Grids.PopulatingFiltersEventArgs populatingFiltersEventArgs = new global::Infragistics.Controls.Grids.PopulatingFiltersEventArgs();
				populatingFiltersEventArgs.Column = this;
				populatingFiltersEventArgs.FilterOperands = this.FilterColumnSettings.RowFilterOperands;
				base.ColumnLayout.Grid.OnShowAvailableColumnFilterOperands(populatingFiltersEventArgs);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0003D150 File Offset: 0x0003B350
		protected virtual void ValidateSortComparer()
		{
			if (this._comparer != null && this.DataType != null)
			{
				global::System.Type type = typeof(global::System.Collections.Generic.IComparer<>).MakeGenericType(new global::System.Type[]
				{
					this.DataType
				});
				if (!type.IsAssignableFrom(this._comparer.GetType()))
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					throw new global::System.TypeLoadException(string.Format(currentCulture, global::Infragistics.SRGrid.GetString("TypeMismatchException"), new object[]
					{
						this._comparer.GetType().Name,
						type.Name
					}));
				}
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
		protected virtual void ValidateGroupByComparer()
		{
			if (this._groupByComparer != null && this.DataType != null)
			{
				global::System.Type type = typeof(global::System.Collections.Generic.IEqualityComparer<>).MakeGenericType(new global::System.Type[]
				{
					this.DataType
				});
				if (!type.IsAssignableFrom(this._groupByComparer.GetType()))
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					throw new global::System.TypeLoadException(string.Format(currentCulture, global::Infragistics.SRGrid.GetString("TypeMismatchException"), new object[]
					{
						this._groupByComparer.GetType().Name,
						type.Name
					}));
				}
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0003D28F File Offset: 0x0003B48F
		protected internal virtual global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column> ResolveChildColumns()
		{
			return null;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0003D294 File Offset: 0x0003B494
		protected internal void InvalidateVisibility(bool makeFirstVisIfCollapsed)
		{
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = this.AllColumns;
			bool flag = false;
			foreach (global::Infragistics.Controls.Grids.Column column in allColumns)
			{
				if (column.ParentColumn == this && column.Visibility == global::System.Windows.Visibility.Visible)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				base.Visibility = global::System.Windows.Visibility.Collapsed;
				if (makeFirstVisIfCollapsed && allColumns.Count > 0)
				{
					allColumns[0].Visibility = global::System.Windows.Visibility.Visible;
				}
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0003D318 File Offset: 0x0003B518
		protected internal virtual global::Infragistics.Controls.Grids.Primitives.SelectionControl GenerateFilterSelectionControl()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl();
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0003D320 File Offset: 0x0003B520
		protected internal virtual void FillFilterMenuOptions(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			if (list != null)
			{
				global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject = new global::Infragistics.Controls.Grids.FilterMenuTrackingObject();
				filterMenuTrackingObject.Label = (string.IsNullOrEmpty(this.FilterColumnSettings.FilterMenuTypeSpecificFiltersString) ? this.FilterMenuCustomFilterString : this.FilterColumnSettings.FilterMenuTypeSpecificFiltersString);
				list.Add(filterMenuTrackingObject);
				filterMenuTrackingObject.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.EqualsOperand
				{
					DisplayName = global::Infragistics.SRGrid.GetString("EqualsEllipsis")
				}));
				filterMenuTrackingObject.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.NotEqualsOperand
				{
					DisplayName = global::Infragistics.SRGrid.GetString("NotEqualsEllipsis")
				}));
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		internal void SetGroupBy(bool groupBy)
		{
			if (!this._ignoreGroupByCalls)
			{
				this._isGroupBy = groupBy;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && base.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
				{
					if (groupBy)
					{
						this.IsFixed = global::Infragistics.Controls.Grids.FixedState.NotFixed;
						if (this.ParentColumn != null)
						{
							global::Infragistics.Controls.Grids.Column parentColumn = this.ParentColumn;
							if (parentColumn._cachedChildren == null)
							{
								parentColumn._cachedChildren = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(this.ParentColumn.ResolveChildColumns());
							}
							this._cachedParentColumn = this.ParentColumn;
							global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
							global::Infragistics.Controls.Grids.XamGrid grid = columnLayout.Grid;
							base.IsMoving = false;
							global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column> collectionBase = parentColumn.ResolveChildColumns();
							collectionBase.Remove(this);
							columnLayout.Columns.Add(this);
							grid.ResetPanelRows();
							grid.InvalidateScrollPanel(true);
							this._ignoreGroupByCalls = true;
							grid.GroupBySettings.GroupByColumns.Remove(this);
							this._ignoreGroupByCalls = false;
							parentColumn.InvalidateVisibility(false);
						}
					}
					else if (this._cachedParentColumn != null)
					{
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = base.ColumnLayout;
						global::Infragistics.Controls.Grids.XamGrid grid2 = columnLayout2.Grid;
						this._ignoreGroupByCalls = true;
						global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column> collectionBase2 = this._cachedParentColumn.ResolveChildColumns();
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> cachedChildren = this._cachedParentColumn._cachedChildren;
						base.IsMoving = false;
						columnLayout2.Columns.Remove(this);
						int num = cachedChildren.IndexOf(this);
						bool flag = false;
						for (int i = num + 1; i < cachedChildren.Count; i++)
						{
							global::Infragistics.Controls.Grids.Column item = cachedChildren[i];
							int num2 = collectionBase2.IndexOf(item);
							if (num2 != -1)
							{
								collectionBase2.Insert(num2, this);
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							collectionBase2.Add(this);
						}
						if (this._cachedParentColumn.Visibility == global::System.Windows.Visibility.Collapsed)
						{
							this._cachedParentColumn.Visibility = global::System.Windows.Visibility.Visible;
						}
						if (collectionBase2.Count == cachedChildren.Count)
						{
							this._cachedParentColumn._cachedChildren = null;
						}
						this._cachedParentColumn = null;
						this._ignoreGroupByCalls = false;
					}
					this.OnPropertyChanged("IsGroupBy");
				}
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		internal bool SetFixedColumnState(global::Infragistics.Controls.Grids.FixedState state)
		{
			bool flag = false;
			if (this.IsGroupBy && base.ColumnLayout != null && base.ColumnLayout.Grid != null && base.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
			{
				flag = true;
			}
			if (this.ParentColumn != null || flag)
			{
				this._isFixed = global::Infragistics.Controls.Grids.FixedState.NotFixed;
				if (state != global::Infragistics.Controls.Grids.FixedState.NotFixed)
				{
					return false;
				}
			}
			bool flag2 = false;
			if (base.ColumnLayout != null)
			{
				flag2 = base.ColumnLayout.Grid.OnColumnFixedStateChanging(this, state);
			}
			if (!flag2)
			{
				global::Infragistics.Controls.Grids.FixedState isFixed = this._isFixed;
				this._isFixed = state;
				if (base.ColumnLayout != null)
				{
					if (state == global::Infragistics.Controls.Grids.FixedState.Left)
					{
						base.ColumnLayout.FixedColumnSettings.FixedColumnsLeft.AddItemSilently(this);
						base.ColumnLayout.FixedColumnSettings.FixedColumnsRight.RemoveItemSilently(this);
					}
					else if (state == global::Infragistics.Controls.Grids.FixedState.NotFixed)
					{
						base.ColumnLayout.FixedColumnSettings.FixedColumnsRight.RemoveItemSilently(this);
						base.ColumnLayout.FixedColumnSettings.FixedColumnsLeft.RemoveItemSilently(this);
					}
					else if (state == global::Infragistics.Controls.Grids.FixedState.Right)
					{
						base.ColumnLayout.FixedColumnSettings.FixedColumnsRight.AddItemSilently(this);
						base.ColumnLayout.FixedColumnSettings.FixedColumnsLeft.RemoveItemSilently(this);
					}
					base.ColumnLayout.Grid.OnColumnFixedStateChanged(this, isFixed);
				}
				this.OnPropertyChanged("IsFixed");
			}
			return !flag2;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0003D710 File Offset: 0x0003B910
		internal void SetSortedColumnStateSilent(global::Infragistics.Controls.Grids.SortDirection state)
		{
			if (!this.CanBeSorted)
			{
				return;
			}
			this._isSorted = state;
			if (base.ColumnLayout != null)
			{
				if (state == global::Infragistics.Controls.Grids.SortDirection.Ascending)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.AddItemSilently(this);
					return;
				}
				if (state == global::Infragistics.Controls.Grids.SortDirection.Descending)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.AddItemSilently(this);
					return;
				}
				if (state == global::Infragistics.Controls.Grids.SortDirection.None)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.RemoveItemSilently(this);
				}
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0003D784 File Offset: 0x0003B984
		internal void SetSortedColumnStateSilent(global::Infragistics.Controls.Grids.SortDirection state, int index)
		{
			this._isSorted = state;
			if (base.ColumnLayout != null)
			{
				if (state == global::Infragistics.Controls.Grids.SortDirection.Ascending)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.InsertItemSilently(this, index);
					return;
				}
				if (state == global::Infragistics.Controls.Grids.SortDirection.Descending)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.InsertItemSilently(this, index);
					return;
				}
				if (state == global::Infragistics.Controls.Grids.SortDirection.None)
				{
					base.ColumnLayout.SortingSettings.SortedColumns.RemoveItemSilently(this);
				}
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0003D7F1 File Offset: 0x0003B9F1
		internal bool SetSortedColumnState(global::Infragistics.Controls.Grids.SortDirection state)
		{
			return this.SetSortedColumnStateInternally(state, false);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0003D7FC File Offset: 0x0003B9FC
		internal bool SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection state, bool silent)
		{
			if (!this.CanBeSorted)
			{
				return true;
			}
			bool flag = false;
			if (base.ColumnLayout != null)
			{
				flag = base.ColumnLayout.Grid.OnColumnSorting(this, state);
			}
			if (!flag)
			{
				global::Infragistics.Controls.Grids.SortDirection isSorted = this._isSorted;
				this.SetSortedColumnStateSilent(state);
				if (!silent)
				{
					this.OnPropertyChanged("IsSorted");
				}
				if (base.ColumnLayout != null)
				{
					base.ColumnLayout.Grid.OnColumnSorted(this, isSorted);
				}
			}
			return !flag;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0003D870 File Offset: 0x0003BA70
		internal bool SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection state, bool silent, int index)
		{
			bool flag = false;
			if (base.ColumnLayout != null)
			{
				flag = base.ColumnLayout.Grid.OnColumnSorting(this, state);
			}
			if (!flag)
			{
				global::Infragistics.Controls.Grids.SortDirection isSorted = this._isSorted;
				this.SetSortedColumnStateSilent(state, index);
				if (!silent)
				{
					this.OnPropertyChanged("IsSorted");
				}
				if (base.ColumnLayout != null)
				{
					base.ColumnLayout.Grid.OnColumnSorted(this, isSorted);
				}
			}
			return !flag;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
		internal bool SetSortedColumnState(global::Infragistics.Controls.Grids.SortDirection state, bool multipleColumnSort)
		{
			if (!this.CanBeSorted)
			{
				return true;
			}
			bool flag = false;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
			if (columnLayout != null)
			{
				flag = columnLayout.Grid.OnColumnSorting(this, state);
			}
			if (!flag)
			{
				global::Infragistics.Controls.Grids.SortDirection isSorted = this._isSorted;
				global::Infragistics.Controls.Grids.SortedColumnsCollection sortedColumns = columnLayout.SortingSettings.SortedColumns;
				if (state == global::Infragistics.Controls.Grids.SortDirection.None)
				{
					sortedColumns.RemoveItemSilently(this);
				}
				else
				{
					global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettings = columnLayout.SortingSettings;
					if (!multipleColumnSort || !sortingSettings.AllowMultipleColumnSortingResolved)
					{
						sortedColumns.RemoveItemSilently(this);
						sortedColumns.ClearSilently();
						sortedColumns.AddItemSilently(this);
					}
				}
				this.SetSortedColumnStateSilent(state);
				this.OnPropertyChanged("IsSorted");
				if (base.ColumnLayout != null)
				{
					base.ColumnLayout.Grid.OnColumnSorted(this, isSorted);
				}
			}
			return !flag;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0003D984 File Offset: 0x0003BB84
		internal global::Infragistics.Controls.Grids.SortDirection NextSortDirection
		{
			get
			{
				global::Infragistics.Controls.Grids.SortDirection result = this.IsSorted;
				if (base.ColumnLayout != null)
				{
					if (this.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending)
					{
						result = global::Infragistics.Controls.Grids.SortDirection.Descending;
					}
					else if (this.IsSorted == global::Infragistics.Controls.Grids.SortDirection.None)
					{
						result = this.FirstSortDirectionResolved;
					}
					else
					{
						result = global::Infragistics.Controls.Grids.SortDirection.Ascending;
					}
				}
				return result;
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0003D9C1 File Offset: 0x0003BBC1
		internal void SetActualWidthSilently(double width)
		{
			this._actualWidth = width;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0003D9CC File Offset: 0x0003BBCC
		internal global::Infragistics.Controls.Grids.Column ResolveRootColumn()
		{
			global::Infragistics.Controls.Grids.Column parentColumn = this.ParentColumn;
			while (parentColumn != null && parentColumn.ParentColumn != null)
			{
				parentColumn = parentColumn.ParentColumn;
			}
			return parentColumn;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0003D9F5 File Offset: 0x0003BBF5
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0003D9FD File Offset: 0x0003BBFD
		bool global::Infragistics.ISelectableObject.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
			set
			{
				this.IsSelected = value;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0003DA06 File Offset: 0x0003BC06
		void global::Infragistics.ISelectableObject.SetSelected(bool isSelected)
		{
			this.SetSelected(isSelected);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0003DA10 File Offset: 0x0003BC10
		protected override void OnVisibilityChanged()
		{
			if (base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				this._cachedActualWidth = this._actualWidth;
				this._actualWidth = 0.0;
			}
			else
			{
				this._actualWidth = this._cachedActualWidth;
				this._cachedActualWidth = 0.0;
			}
			base.OnVisibilityChanged();
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0003DA64 File Offset: 0x0003BC64
		protected override void OnDataTypeChanged()
		{
			this.SummaryColumnSettings.ValidateSummaryOperands();
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = this.FilterColumnSettings;
			filterColumnSettings.Reset();
			filterColumnSettings.ValidateFilterMenuOperands();
			filterColumnSettings.ValidateFilterOperands();
			base.OnDataTypeChanged();
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0003DA9C File Offset: 0x0003BC9C
		protected override void OnColumnLayoutChanged()
		{
			this.SummaryColumnSettings.ValidateSummaryOperands();
			global::Infragistics.Controls.Grids.FilterColumnSettings filterColumnSettings = this.FilterColumnSettings;
			filterColumnSettings.Reset();
			filterColumnSettings.ValidateFilterMenuOperands();
			filterColumnSettings.ValidateFilterOperands();
			base.OnColumnLayoutChanged();
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
		private void SummaryColumnSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null && (propertyName == "RowDisplayLabel" || propertyName == "FormatString"))
			{
				if (base.ColumnLayout != null)
				{
					base.ColumnLayout.RefreshSummaryRowVisual();
					return;
				}
			}
			else
			{
				this.OnPropertyChanged("SummaryColumnSettings");
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0003DB24 File Offset: 0x0003BD24
		private void ConditionalFormatCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("ConditionalFormatCollectionCollectionChanged");
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0003DB31 File Offset: 0x0003BD31
		private void ConditionalFormatCollection_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			if (base.ColumnLayout != null)
			{
				base.ColumnLayout.InvalidateConditionalFormatting();
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0003DB48 File Offset: 0x0003BD48
		protected override global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				global::System.Collections.Generic.List<string> propertiesToIgnore = base.PropertiesToIgnore;
				propertiesToIgnore.AddRange(new global::System.Collections.Generic.List<string>
				{
					"IsGroupBy",
					"IsFixed",
					"IsSorted",
					"IsSelected"
				});
				return propertiesToIgnore;
			}
		}

		// Token: 0x040004FD RID: 1277
		private double _actualWidth;

		// Token: 0x040004FE RID: 1278
		private global::Infragistics.Controls.Grids.FixedState _isFixed;

		// Token: 0x040004FF RID: 1279
		private global::Infragistics.Controls.Grids.FixedIndicatorDirection? _fixedDirection;

		// Token: 0x04000500 RID: 1280
		private bool _isFixable;

		// Token: 0x04000501 RID: 1281
		private bool _isSortable;

		// Token: 0x04000502 RID: 1282
		private bool _isSelected;

		// Token: 0x04000503 RID: 1283
		private bool _isGroupBy;

		// Token: 0x04000504 RID: 1284
		private bool _allowCaseSensitiveSort = true;

		// Token: 0x04000505 RID: 1285
		private bool _isFilterable = true;

		// Token: 0x04000506 RID: 1286
		private bool _isSummable = true;

		// Token: 0x04000507 RID: 1287
		private global::System.Windows.HorizontalAlignment _hAlign;

		// Token: 0x04000508 RID: 1288
		private global::System.Windows.VerticalAlignment _vAlign;

		// Token: 0x04000509 RID: 1289
		private global::System.Windows.DataTemplate _footerTemplate;

		// Token: 0x0400050A RID: 1290
		private object _comparer;

		// Token: 0x0400050B RID: 1291
		private object _groupByComparer;

		// Token: 0x0400050C RID: 1292
		private global::Infragistics.Controls.Grids.SortDirection _isSorted;

		// Token: 0x0400050D RID: 1293
		private global::Infragistics.Controls.Grids.FilterColumnSettings _filterColumnSettings;

		// Token: 0x0400050E RID: 1294
		private global::Infragistics.Controls.Grids.FilterOperand _defaultFilterOperand;

		// Token: 0x0400050F RID: 1295
		private global::Infragistics.Controls.Grids.SummaryColumnSettings _summaryColumnSettings;

		// Token: 0x04000510 RID: 1296
		private global::Infragistics.Controls.Grids.ConditionalFormatCollection _conditionalFormatCollection;

		// Token: 0x04000511 RID: 1297
		private bool _isGroupable;

		// Token: 0x04000512 RID: 1298
		private global::Infragistics.Controls.Grids.Column _cachedParentColumn;

		// Token: 0x04000513 RID: 1299
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> _cachedChildren;

		// Token: 0x04000514 RID: 1300
		private bool _ignoreGroupByCalls;

		// Token: 0x04000515 RID: 1301
		private string _cachedTypeName;

		// Token: 0x04000516 RID: 1302
		private global::Infragistics.Controls.Grids.AllowToolTips _cachedAllowToolTips;

		// Token: 0x04000517 RID: 1303
		private global::Infragistics.Controls.Grids.ColumnWidth? _cachedColumnWidth;

		// Token: 0x04000518 RID: 1304
		private double _cachedMinimumWidth;

		// Token: 0x04000519 RID: 1305
		private double _cachedMaximumWidth;

		// Token: 0x0400051A RID: 1306
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(global::Infragistics.Controls.Grids.ColumnWidth?), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.ColumnWidth?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.WidthChanged))));

		// Token: 0x0400051B RID: 1307
		private double _cachedActualWidth;

		// Token: 0x0400051C RID: 1308
		public static readonly global::System.Windows.DependencyProperty MinimumWidthProperty = global::System.Windows.DependencyProperty.Register("MinimumWidth", typeof(double), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.MinimumWidthChanged)));

		// Token: 0x0400051D RID: 1309
		public static readonly global::System.Windows.DependencyProperty MaximumWidthProperty = global::System.Windows.DependencyProperty.Register("MaximumWidth", typeof(double), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.MaximumWidthChanged)));

		// Token: 0x0400051E RID: 1310
		public static readonly global::System.Windows.DependencyProperty FooterTextProperty = global::System.Windows.DependencyProperty.Register("FooterText", typeof(string), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.FooterTextChanged)));

		// Token: 0x0400051F RID: 1311
		public static readonly global::System.Windows.DependencyProperty ValueConverterProperty = global::System.Windows.DependencyProperty.Register("ValueConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.ValueConverterChanged)));

		// Token: 0x04000520 RID: 1312
		public static readonly global::System.Windows.DependencyProperty ValueConverterParameterProperty = global::System.Windows.DependencyProperty.Register("ValueConverterParameter", typeof(object), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.ValueConverterParameterChanged)));

		// Token: 0x04000521 RID: 1313
		public static readonly global::System.Windows.DependencyProperty GroupByItemTemplateProperty = global::System.Windows.DependencyProperty.Register("GroupByItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.GroupByItemTemplateChanged)));

		// Token: 0x04000522 RID: 1314
		public static readonly global::System.Windows.DependencyProperty FirstSortDirectionProperty = global::System.Windows.DependencyProperty.Register("DefaultSort", typeof(global::Infragistics.Controls.Grids.SortDirection?), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.FirstSortDirectionChanged)));

		// Token: 0x04000523 RID: 1315
		public static readonly global::System.Windows.DependencyProperty HeaderTextHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment?), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.HeaderTextHorizontalAlignmentChanged)));

		// Token: 0x04000524 RID: 1316
		public static readonly global::System.Windows.DependencyProperty HeaderTextVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextVerticalAlignment", typeof(global::System.Windows.VerticalAlignment?), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.HeaderTextVerticalAlignmentChanged)));

		// Token: 0x04000525 RID: 1317
		public static readonly global::System.Windows.DependencyProperty ToolTipStyleProperty = global::System.Windows.DependencyProperty.Register("ToolTipStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.ToolTipStyleChanged)));

		// Token: 0x04000526 RID: 1318
		public static readonly global::System.Windows.DependencyProperty ToolTipContentTemplateProperty = global::System.Windows.DependencyProperty.Register("TooltipContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.ToolTipContentTemplateChanged)));

		// Token: 0x04000527 RID: 1319
		public static readonly global::System.Windows.DependencyProperty AllowToolTipsProperty = global::System.Windows.DependencyProperty.Register("AllowToolTips", typeof(global::Infragistics.Controls.Grids.AllowToolTips), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.AllowToolTips.Never, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AllowToolTipsChanged)));

		// Token: 0x04000528 RID: 1320
		public static readonly global::System.Windows.DependencyProperty AddNewRowItemTemplateProperty = global::System.Windows.DependencyProperty.Register("AddNewRowItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateChanged)));

		// Token: 0x04000529 RID: 1321
		public static readonly global::System.Windows.DependencyProperty AddNewRowEditorTemplateProperty = global::System.Windows.DependencyProperty.Register("AddNewRowEditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateChanged)));

		// Token: 0x0400052A RID: 1322
		public static readonly global::System.Windows.DependencyProperty AddNewRowItemTemplateHorizontalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("AddNewRowItemTemplateHorizontalContentAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Left, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateHorizontalContentAlignmentChanged)));

		// Token: 0x0400052B RID: 1323
		public static readonly global::System.Windows.DependencyProperty AddNewRowItemTemplateVerticalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("AddNewRowItemTemplateVerticalContentAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowItemTemplateVerticalContentAlignmentChanged)));

		// Token: 0x0400052C RID: 1324
		public static readonly global::System.Windows.DependencyProperty AddNewRowEditorTemplateVerticalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("AddNewRowEditorTemplateVerticalContentAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(global::System.Windows.VerticalAlignment.Stretch, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateVerticalContentAlignmentChanged)));

		// Token: 0x0400052D RID: 1325
		public static readonly global::System.Windows.DependencyProperty AddNewRowEditorTemplateHorizontalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("AddNewRowEditorTemplateHorizontalContentAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Stretch, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowEditorTemplateHorizontalContentAlignmentChanged)));

		// Token: 0x0400052E RID: 1326
		public static readonly global::System.Windows.DependencyProperty MergedItemTemplateProperty = global::System.Windows.DependencyProperty.Register("MergedItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.MergedItemTemplateChanged)));

		// Token: 0x0400052F RID: 1327
		public static readonly global::System.Windows.DependencyProperty AddNewRowCellStyleProperty = global::System.Windows.DependencyProperty.Register("AddNewRowCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.AddNewRowCellStyleChanged)));

		// Token: 0x04000530 RID: 1328
		public static readonly global::System.Windows.DependencyProperty GroupByRowCellStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByRowCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.GroupByRowCellStyleChanged)));

		// Token: 0x04000531 RID: 1329
		public static readonly global::System.Windows.DependencyProperty GroupByHeaderCellStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByHeaderCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.GroupByHeaderCellStyleChanged)));

		// Token: 0x04000532 RID: 1330
		public static readonly global::System.Windows.DependencyProperty MergeCellStyleProperty = global::System.Windows.DependencyProperty.Register("MergeCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Column), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Column.MergeCellStyleChanged)));
	}
}
