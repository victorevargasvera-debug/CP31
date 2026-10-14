using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200023D RID: 573
	public class ColumnLayout : global::Infragistics.Controls.Grids.ColumnBase, global::System.IDisposable, global::Infragistics.INeedInitializationForPersistence, global::Infragistics.IProvideCustomStorage
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x0003FC21 File Offset: 0x0003DE21
		public ColumnLayout()
		{
			this._keys = new global::System.Collections.ObjectModel.Collection<string>();
			this._rowsManagers = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Grids.RowsManagerBase>();
			this._childBandRowManager = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Grids.ChildBandRowsManager>();
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0003FC56 File Offset: 0x0003DE56
		public ColumnLayout(global::Infragistics.Controls.Grids.XamGrid grid) : this()
		{
			this.Grid = grid;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0003FC65 File Offset: 0x0003DE65
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x0003FC77 File Offset: 0x0003DE77
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.TypeTypeConverter))]
		private global::System.Type TargetType
		{
			get
			{
				return (global::System.Type)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.TargetTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.TargetTypeProperty, value);
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0003FC85 File Offset: 0x0003DE85
		private static void TypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0003FC87 File Offset: 0x0003DE87
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0003FC99 File Offset: 0x0003DE99
		public string TargetTypeName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.TargetTypeNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.TargetTypeNameProperty, value);
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0003FCA7 File Offset: 0x0003DEA7
		private static void TargetTypeNameChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0003FCA9 File Offset: 0x0003DEA9
		public global::Infragistics.Controls.Grids.ColumnBaseCollection Columns
		{
			get
			{
				if (this._columns == null)
				{
					this._columns = new global::Infragistics.Controls.Grids.ColumnBaseCollection(this);
					this._columns.CollectionChanged += this.Columns_CollectionChanged;
				}
				return this._columns;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		public global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				return this._grid;
			}
			internal set
			{
				if (this._grid != null)
				{
					if (this._grid == value)
					{
						return;
					}
					this._grid.PropertyChanged -= this.Grid_PropertyChanged;
					this.UnregisterExpansionIndicatorSettings();
					this.UnregisterRowSelectorSettings();
					this.UnregisterSortingSettings();
					this.UnregisterPagerSettings();
					this.UnregisterFixedColumnSettings();
					this.UnregisterGroupBySettings();
					this.UnregisterDeferredScrollingSettings();
					this.UnregisterAddNewRowSettings();
					this.UnregisterFilterRowSettings();
					this.UnregisterFillerColumnSettings();
					this.UnregisterSummaryRowSettings();
					this.UnregisterConditionalFormattingSettings();
					this.UnregisterColumnChooserSettings();
				}
				this._grid = value;
				if (this._grid != null)
				{
					this._grid.PropertyChanged += this.Grid_PropertyChanged;
					this.RegisterExpansionIndicatorSettings();
					this.RegisterRowSelectorSettings();
					this.RegisterSortingSettings();
					this.RegisterPagerSettings();
					this.RegisterFixedColumnSettings();
					this.RegisterGroupBySettings();
					this.RegisterDeferredScrollingSettings();
					this.RegisterAddNewRowSettings();
					this.RegisterFilterRowSettings();
					this.RegisterFillerColumnSettings();
					this.RegisterSummaryRowSettings();
					this.RegisterConditionalFormattingSettings();
					this.RegisterColumnChooserSettings();
					this.ExecuteColumnCatchup();
				}
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0003FDE2 File Offset: 0x0003DFE2
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0003FDF4 File Offset: 0x0003DFF4
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderVisibilityProperty, value);
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0003FE08 File Offset: 0x0003E008
		private static void HeaderVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("HeaderVisibility");
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0003FE28 File Offset: 0x0003E028
		public global::System.Windows.Visibility HeaderVisibilityResolved
		{
			get
			{
				if (this.HeaderVisibility == null && this.Grid != null)
				{
					return this.Grid.HeaderVisibility;
				}
				if (!(this.HeaderVisibility == global::System.Windows.Visibility.Visible))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0003FE78 File Offset: 0x0003E078
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0003FE8A File Offset: 0x0003E08A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? FooterVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.FooterVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.FooterVisibilityProperty, value);
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		private static void FooterVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("FooterVisibility");
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		public global::System.Windows.Visibility FooterVisibilityResolved
		{
			get
			{
				if (this.FooterVisibility == null && this.Grid != null)
				{
					return this.Grid.FooterVisibility;
				}
				if (!(this.FooterVisibility == global::System.Windows.Visibility.Visible))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0003FF10 File Offset: 0x0003E110
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0003FF22 File Offset: 0x0003E122
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AutoGenerateColumns
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.AutoGenerateColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.AutoGenerateColumnsProperty, value);
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0003FF38 File Offset: 0x0003E138
		private static void AutoGenerateColumnsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("AutoGenerateColumns");
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0003FF58 File Offset: 0x0003E158
		public bool AutoGenerateColumnsResolved
		{
			get
			{
				if (this.AutoGenerateColumns == null && this.Grid != null)
				{
					return this.Grid.AutoGenerateColumns;
				}
				return this.AutoGenerateColumns == true;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0003FFA2 File Offset: 0x0003E1A2
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0003FFB4 File Offset: 0x0003E1B4
		public double Indentation
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.IndentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.IndentationProperty, value);
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0003FFC8 File Offset: 0x0003E1C8
		private static void IndentationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("Indentation");
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0003FFE7 File Offset: 0x0003E1E7
		public double IndentationResolved
		{
			get
			{
				if (double.IsNaN(this.Indentation) && this.Grid != null)
				{
					return this.Grid.Indentation;
				}
				return this.Indentation;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00040010 File Offset: 0x0003E210
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00040022 File Offset: 0x0003E222
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility>))]
		public global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility? ColumnLayoutHeaderVisibility
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnLayoutHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnLayoutHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00040038 File Offset: 0x0003E238
		private static void ColumnLayoutHeaderVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("ColumnLayoutHeaderVisibility");
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00040058 File Offset: 0x0003E258
		public global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility ColumnLayoutHeaderVisibilityResolved
		{
			get
			{
				if (this.ColumnLayoutHeaderVisibility != null)
				{
					return this.ColumnLayoutHeaderVisibility.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.ColumnLayoutHeaderVisibility;
				}
				return (global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility)global::Infragistics.Controls.Grids.XamGrid.ColumnLayoutHeaderVisibilityProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000400B6 File Offset: 0x0003E2B6
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000400BE File Offset: 0x0003E2BE
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsAlternateRowsEnabled
		{
			get
			{
				return this._cachedIsAlternateRowsEnabled;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.IsAlternateRowsEnabledProperty, value);
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000400D4 File Offset: 0x0003E2D4
		private static void IsAlternateRowsEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout._cachedIsAlternateRowsEnabled = (bool?)e.NewValue;
			columnLayout.OnPropertyChanged("IsAlternateRowsEnabled");
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00040108 File Offset: 0x0003E308
		public bool IsAlternateRowsEnabledResolved
		{
			get
			{
				if (this.IsAlternateRowsEnabled == null && this.Grid != null)
				{
					return this.Grid.IsAlternateRowsEnabled;
				}
				return this.IsAlternateRowsEnabled == true;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00040152 File Offset: 0x0003E352
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0004015A File Offset: 0x0003E35A
		public global::System.Windows.Style ChildBandHeaderStyle
		{
			get
			{
				return this._childBandHeaderStyle;
			}
			set
			{
				if (this._childBandHeaderStyle != value)
				{
					this._childBandHeaderStyle = value;
					if (this.Grid != null)
					{
						this.Grid.ResetPanelRows();
					}
					this.OnPropertyChanged("ChildBandHeaderStyle");
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0004018A File Offset: 0x0003E38A
		public global::System.Windows.Style ChildBandHeaderStyleResolved
		{
			get
			{
				if (this.ChildBandHeaderStyle == null && this.Grid != null)
				{
					return this.Grid.ChildBandHeaderStyle;
				}
				return this.ChildBandHeaderStyle;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000401AE File Offset: 0x0003E3AE
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x000401C0 File Offset: 0x0003E3C0
		public global::System.Windows.DataTemplate ColumnsHeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsHeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsHeaderTemplateProperty, value);
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000401D0 File Offset: 0x0003E3D0
		private static void ColumnsHeaderTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("ColumnsHeaderTemplate");
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000401EF File Offset: 0x0003E3EF
		public global::System.Windows.DataTemplate ColumnsHeaderTemplateResolved
		{
			get
			{
				if (this.ColumnsHeaderTemplate == null && this.Grid != null)
				{
					return this.Grid.ColumnsHeaderTemplate;
				}
				return this.ColumnsHeaderTemplate;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00040213 File Offset: 0x0003E413
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00040225 File Offset: 0x0003E425
		public global::System.Windows.DataTemplate ColumnsFooterTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsFooterTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsFooterTemplateProperty, value);
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00040234 File Offset: 0x0003E434
		private static void ColumnsFooterTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("ColumnsFooterTemplate");
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x00040253 File Offset: 0x0003E453
		public global::System.Windows.DataTemplate ColumnsFooterTemplateResolved
		{
			get
			{
				if (this.ColumnsFooterTemplate == null && this.Grid != null)
				{
					return this.Grid.ColumnsFooterTemplate;
				}
				return this.ColumnsFooterTemplate;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00040277 File Offset: 0x0003E477
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x000402B8 File Offset: 0x0003E4B8
		public global::Infragistics.Controls.Grids.RowSelectorSettingsOverride RowSelectorSettings
		{
			get
			{
				if (this._rowSelectorSettings == null)
				{
					this._rowSelectorSettings = new global::Infragistics.Controls.Grids.RowSelectorSettingsOverride();
					this._rowSelectorSettings.PropertyChanged += this.RowSelectorSettings_PropertyChanged;
				}
				this._rowSelectorSettings.ColumnLayout = this;
				return this._rowSelectorSettings;
			}
			set
			{
				if (value != this._rowSelectorSettings)
				{
					if (this._rowSelectorSettings != null)
					{
						this._rowSelectorSettings.PropertyChanged -= this.RowSelectorSettings_PropertyChanged;
					}
					this._rowSelectorSettings = value;
					if (this._rowSelectorSettings != null)
					{
						this._rowSelectorSettings.PropertyChanged += this.RowSelectorSettings_PropertyChanged;
					}
					if (this.Columns != null)
					{
						this.RegisterUnregisterFixedAdornerColumn(this.Columns.RowSelectorColumn, this.RowSelectorSettings.VisibilityResolved, false);
					}
					if (this.Grid != null)
					{
						this.Grid.InvalidateScrollPanel(true);
					}
				}
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004034C File Offset: 0x0003E54C
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0004038C File Offset: 0x0003E58C
		public global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride ExpansionIndicatorSettings
		{
			get
			{
				if (this._expansionIndicatorSettings == null)
				{
					this._expansionIndicatorSettings = new global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride();
					this._expansionIndicatorSettings.PropertyChanged += this.ExpansionIndicatorSettings_PropertyChanged;
				}
				this._expansionIndicatorSettings.ColumnLayout = this;
				return this._expansionIndicatorSettings;
			}
			set
			{
				if (value != this._expansionIndicatorSettings)
				{
					if (this._expansionIndicatorSettings != null)
					{
						this._expansionIndicatorSettings.PropertyChanged -= this.ExpansionIndicatorSettings_PropertyChanged;
					}
					this._expansionIndicatorSettings = value;
					if (this._expansionIndicatorSettings != null)
					{
						this._expansionIndicatorSettings.PropertyChanged += this.ExpansionIndicatorSettings_PropertyChanged;
					}
					if (this.Columns != null && this.Columns.ColumnLayouts.Count > 0)
					{
						this.RegisterUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn, this.ExpansionIndicatorSettings.VisibilityResolved, true);
					}
					if (this.Grid != null)
					{
						this.Grid.InvalidateScrollPanel(true);
					}
				}
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00040436 File Offset: 0x0003E636
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x00040474 File Offset: 0x0003E674
		public global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride ColumnMovingSettings
		{
			get
			{
				if (this._columnMovingSettings == null)
				{
					this._columnMovingSettings = new global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride();
					this._columnMovingSettings.PropertyChanged += this.ColumnMovingSettings_PropertyChanged;
				}
				this._columnMovingSettings.ColumnLayout = this;
				return this._columnMovingSettings;
			}
			set
			{
				if (value != this._columnMovingSettings)
				{
					if (this._columnMovingSettings != null)
					{
						this._columnMovingSettings.PropertyChanged -= this.ColumnMovingSettings_PropertyChanged;
					}
					this._columnMovingSettings = value;
					if (this._columnMovingSettings != null)
					{
						this._columnMovingSettings.PropertyChanged += this.ColumnMovingSettings_PropertyChanged;
					}
					this.OnPropertyChanged("");
				}
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000404DA File Offset: 0x0003E6DA
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00040518 File Offset: 0x0003E718
		public global::Infragistics.Controls.Grids.EditingSettingsOverride EditingSettings
		{
			get
			{
				if (this._editingSettings == null)
				{
					this._editingSettings = new global::Infragistics.Controls.Grids.EditingSettingsOverride();
					this._editingSettings.PropertyChanged += this.EditingSettings_PropertyChanged;
				}
				this._editingSettings.ColumnLayout = this;
				return this._editingSettings;
			}
			set
			{
				if (this._editingSettings != null)
				{
					this._editingSettings.PropertyChanged -= this.EditingSettings_PropertyChanged;
				}
				this._editingSettings = value;
				if (this._editingSettings != null)
				{
					this._editingSettings.PropertyChanged += this.EditingSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0004056A File Offset: 0x0003E76A
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x000405A8 File Offset: 0x0003E7A8
		public global::Infragistics.Controls.Grids.SortingSettingsOverride SortingSettings
		{
			get
			{
				if (this._sortingSettings == null)
				{
					this._sortingSettings = new global::Infragistics.Controls.Grids.SortingSettingsOverride();
					this._sortingSettings.PropertyChanged += this.SortingSettings_PropertyChanged;
				}
				this._sortingSettings.ColumnLayout = this;
				return this._sortingSettings;
			}
			set
			{
				if (value != this._sortingSettings)
				{
					if (this._sortingSettings != null)
					{
						this._sortingSettings.PropertyChanged -= this.SortingSettings_PropertyChanged;
					}
					this._sortingSettings = value;
					if (this._sortingSettings != null)
					{
						this._sortingSettings.PropertyChanged += this.SortingSettings_PropertyChanged;
					}
					this.OnPropertyChanged("");
				}
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004060E File Offset: 0x0003E80E
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0004064C File Offset: 0x0003E84C
		public global::Infragistics.Controls.Grids.GroupBySettingsOverride GroupBySettings
		{
			get
			{
				if (this._groupBySettings == null)
				{
					this._groupBySettings = new global::Infragistics.Controls.Grids.GroupBySettingsOverride();
					this._groupBySettings.PropertyChanged += this.GroupBySettings_PropertyChanged;
				}
				this._groupBySettings.ColumnLayout = this;
				return this._groupBySettings;
			}
			set
			{
				if (this._groupBySettings != null)
				{
					this._groupBySettings.PropertyChanged -= this.GroupBySettings_PropertyChanged;
				}
				this._groupBySettings = value;
				if (this._groupBySettings != null)
				{
					this._groupBySettings.PropertyChanged += this.GroupBySettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0004069E File Offset: 0x0003E89E
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x000406DC File Offset: 0x0003E8DC
		public global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride DeferredScrollingSettings
		{
			get
			{
				if (this._deferredScrollingSettings == null)
				{
					this._deferredScrollingSettings = new global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride();
					this._deferredScrollingSettings.PropertyChanged += this.DeferredScrollingSettings_PropertyChanged;
				}
				this._deferredScrollingSettings.ColumnLayout = this;
				return this._deferredScrollingSettings;
			}
			set
			{
				if (this._deferredScrollingSettings != null)
				{
					this._deferredScrollingSettings.PropertyChanged -= this.DeferredScrollingSettings_PropertyChanged;
				}
				this._deferredScrollingSettings = value;
				if (this._deferredScrollingSettings != null)
				{
					this._deferredScrollingSettings.PropertyChanged += this.DeferredScrollingSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0004072E File Offset: 0x0003E92E
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0004076C File Offset: 0x0003E96C
		public global::Infragistics.Controls.Grids.PagerSettingsOverride PagerSettings
		{
			get
			{
				if (this._pagerSettings == null)
				{
					this._pagerSettings = new global::Infragistics.Controls.Grids.PagerSettingsOverride();
					this._pagerSettings.PropertyChanged += this.PagerSettings_PropertyChanged;
				}
				this._pagerSettings.ColumnLayout = this;
				return this._pagerSettings;
			}
			set
			{
				if (this._pagerSettings != null)
				{
					this._pagerSettings.PropertyChanged -= this.PagerSettings_PropertyChanged;
				}
				this._pagerSettings = value;
				if (this._pagerSettings != null)
				{
					this._pagerSettings.PropertyChanged += this.PagerSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x000407BE File Offset: 0x0003E9BE
		public override global::System.Windows.Style CellStyleResolved
		{
			get
			{
				if (base.CellStyle == null && this.Grid != null)
				{
					return this.Grid.CellStyle;
				}
				return base.CellStyle;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000407E2 File Offset: 0x0003E9E2
		public override global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (base.HeaderStyle == null && this.Grid != null)
				{
					return this.Grid.HeaderStyle;
				}
				return base.HeaderStyle;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00040806 File Offset: 0x0003EA06
		public override global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (base.FooterStyle == null && this.Grid != null)
				{
					return this.Grid.FooterStyle;
				}
				return base.FooterStyle;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0004082A File Offset: 0x0003EA2A
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00040868 File Offset: 0x0003EA68
		public global::Infragistics.Controls.Grids.FixedColumnSettingsOverride FixedColumnSettings
		{
			get
			{
				if (this._fixedColumnSettings == null)
				{
					this._fixedColumnSettings = new global::Infragistics.Controls.Grids.FixedColumnSettingsOverride();
					this._fixedColumnSettings.PropertyChanged += this.FixedColumnSettings_PropertyChanged;
				}
				this._fixedColumnSettings.ColumnLayout = this;
				return this._fixedColumnSettings;
			}
			set
			{
				if (value != this._fixedColumnSettings)
				{
					if (this._fixedColumnSettings != null)
					{
						this._fixedColumnSettings.PropertyChanged -= this.FixedColumnSettings_PropertyChanged;
					}
					this._fixedColumnSettings = value;
					if (this._fixedColumnSettings != null)
					{
						this._fixedColumnSettings.PropertyChanged += this.FixedColumnSettings_PropertyChanged;
					}
					this.OnPropertyChanged("FixedColumnSettings");
				}
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000408CE File Offset: 0x0003EACE
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0004090C File Offset: 0x0003EB0C
		public global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride ColumnResizingSettings
		{
			get
			{
				if (this._columnResizingSettings == null)
				{
					this._columnResizingSettings = new global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride();
					this._columnResizingSettings.PropertyChanged += this.ColumnResizingSettings_PropertyChanged;
				}
				this._columnResizingSettings.ColumnLayout = this;
				return this._columnResizingSettings;
			}
			set
			{
				if (this._columnResizingSettings != null)
				{
					this._columnResizingSettings.PropertyChanged -= this.ColumnResizingSettings_PropertyChanged;
				}
				this._columnResizingSettings = value;
				if (this._columnResizingSettings != null)
				{
					this._columnResizingSettings.PropertyChanged += this.ColumnResizingSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0004095E File Offset: 0x0003EB5E
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0004099C File Offset: 0x0003EB9C
		public global::Infragistics.Controls.Grids.AddNewRowSettingsOverride AddNewRowSettings
		{
			get
			{
				if (this._addNewRowSettings == null)
				{
					this._addNewRowSettings = new global::Infragistics.Controls.Grids.AddNewRowSettingsOverride();
					this._addNewRowSettings.PropertyChanged += this.AddNewRowSettings_PropertyChanged;
				}
				this._addNewRowSettings.ColumnLayout = this;
				return this._addNewRowSettings;
			}
			set
			{
				if (value != this._addNewRowSettings)
				{
					if (this._addNewRowSettings != null)
					{
						this._addNewRowSettings.PropertyChanged -= this.AddNewRowSettings_PropertyChanged;
					}
					this._addNewRowSettings = value;
					if (this._addNewRowSettings != null)
					{
						this._addNewRowSettings.ColumnLayout = this;
						this._addNewRowSettings.PropertyChanged += this.AddNewRowSettings_PropertyChanged;
					}
					this.OnPropertyChanged("AddNewRowSettings");
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00040A0E File Offset: 0x0003EC0E
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x00040A4C File Offset: 0x0003EC4C
		public global::Infragistics.Controls.Grids.SummaryRowSettingsOverride SummaryRowSettings
		{
			get
			{
				if (this._summaryRowSettings == null)
				{
					this._summaryRowSettings = new global::Infragistics.Controls.Grids.SummaryRowSettingsOverride();
					this._summaryRowSettings.PropertyChanged += this.SummaryRowSettings_PropertyChanged;
				}
				this._summaryRowSettings.ColumnLayout = this;
				return this._summaryRowSettings;
			}
			set
			{
				if (this._summaryRowSettings != null)
				{
					this._summaryRowSettings.PropertyChanged -= this.SummaryRowSettings_PropertyChanged;
				}
				this._summaryRowSettings = value;
				if (this._summaryRowSettings != null)
				{
					this._summaryRowSettings.PropertyChanged += this.SummaryRowSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00040A9E File Offset: 0x0003EC9E
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00040ADC File Offset: 0x0003ECDC
		public global::Infragistics.Controls.Grids.FilteringSettingsOverride FilteringSettings
		{
			get
			{
				if (this._filteringSettings == null)
				{
					this._filteringSettings = new global::Infragistics.Controls.Grids.FilteringSettingsOverride();
					this._filteringSettings.PropertyChanged += this.FilteringSettings_PropertyChanged;
				}
				this._filteringSettings.ColumnLayout = this;
				return this._filteringSettings;
			}
			set
			{
				if (value != this._filteringSettings)
				{
					if (this._filteringSettings != null)
					{
						this._filteringSettings.PropertyChanged -= this.FilteringSettings_PropertyChanged;
					}
					this._filteringSettings = value;
					if (this._filteringSettings != null)
					{
						this._filteringSettings.ColumnLayout = this;
						this._filteringSettings.PropertyChanged += this.FilteringSettings_PropertyChanged;
					}
					this.OnPropertyChanged("FilteringSettings");
				}
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00040B4E File Offset: 0x0003ED4E
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x00040B56 File Offset: 0x0003ED56
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? RowHeight
		{
			get
			{
				return this._cachedRowHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.RowHeightProperty, value);
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00040B6C File Offset: 0x0003ED6C
		private static void RowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout._cachedRowHeight = (global::Infragistics.Controls.Grids.RowHeight?)e.NewValue;
			columnLayout.OnPropertyChanged("RowHeight");
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00040BA0 File Offset: 0x0003EDA0
		public global::Infragistics.Controls.Grids.RowHeight RowHeightResolved
		{
			get
			{
				if (this.RowHeight != null)
				{
					return this.RowHeight.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.RowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.XamGrid.RowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00040BFE File Offset: 0x0003EDFE
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x00040C10 File Offset: 0x0003EE10
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableDoubleConverter))]
		public double? MinimumRowHeight
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.MinimumRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.MinimumRowHeightProperty, value);
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00040C24 File Offset: 0x0003EE24
		private static void MinimumRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("MinimumRowHeight");
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00040C44 File Offset: 0x0003EE44
		public double MinimumRowHeightResolved
		{
			get
			{
				if (this.MinimumRowHeight != null)
				{
					return this.MinimumRowHeight.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.MinimumRowHeight;
				}
				return (double)global::Infragistics.Controls.Grids.XamGrid.MinimumRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00040CA3 File Offset: 0x0003EEA3
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00040CB5 File Offset: 0x0003EEB5
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.DeleteKeyAction>))]
		public global::Infragistics.Controls.Grids.DeleteKeyAction? DeleteKeyAction
		{
			get
			{
				return (global::Infragistics.Controls.Grids.DeleteKeyAction?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.DeleteKeyActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.DeleteKeyActionProperty, value);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00040CC8 File Offset: 0x0003EEC8
		public global::Infragistics.Controls.Grids.DeleteKeyAction DeleteKeyActionResolved
		{
			get
			{
				if (this.DeleteKeyAction != null)
				{
					return this.DeleteKeyAction.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.DeleteKeyAction;
				}
				return (global::Infragistics.Controls.Grids.DeleteKeyAction)global::Infragistics.Controls.Grids.XamGrid.DeleteKeyActionProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00040D26 File Offset: 0x0003EF26
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00040D38 File Offset: 0x0003EF38
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? HeaderRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderRowHeightProperty, value);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00040D4C File Offset: 0x0003EF4C
		private static void HeaderRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("HeaderRowHeight");
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00040D6C File Offset: 0x0003EF6C
		public global::Infragistics.Controls.Grids.RowHeight HeaderRowHeightResolved
		{
			get
			{
				if (this.HeaderRowHeight != null)
				{
					return this.HeaderRowHeight.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.HeaderRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.XamGrid.HeaderRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00040DCA File Offset: 0x0003EFCA
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00040DDC File Offset: 0x0003EFDC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? FooterRowHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.FooterRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.FooterRowHeightProperty, value);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00040DF0 File Offset: 0x0003EFF0
		private static void FooterRowHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("FooterRowHeight");
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00040E10 File Offset: 0x0003F010
		public global::Infragistics.Controls.Grids.RowHeight FooterRowHeightResolved
		{
			get
			{
				if (this.FooterRowHeight != null)
				{
					return this.FooterRowHeight.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.FooterRowHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.XamGrid.FooterRowHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00040E6E File Offset: 0x0003F06E
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00040E80 File Offset: 0x0003F080
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.RowHeightTypeConverter))]
		public global::Infragistics.Controls.Grids.RowHeight? ChildBandHeaderHeight
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowHeight?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.ChildBandHeaderHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.ChildBandHeaderHeightProperty, value);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00040E94 File Offset: 0x0003F094
		private static void ChildBandHeaderHeightChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("ChildBandHeaderHeight");
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		public global::Infragistics.Controls.Grids.RowHeight ChildBandHeaderHeightResolved
		{
			get
			{
				if (this.ChildBandHeaderHeight != null)
				{
					return this.ChildBandHeaderHeight.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.ChildBandHeaderHeight;
				}
				return (global::Infragistics.Controls.Grids.RowHeight)global::Infragistics.Controls.Grids.XamGrid.ChildBandHeaderHeightProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00040F12 File Offset: 0x0003F112
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00040F1A File Offset: 0x0003F11A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableColumnWidthTypeConverter))]
		public global::Infragistics.Controls.Grids.ColumnWidth? ColumnWidth
		{
			get
			{
				return this._cachedColumnWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.ColumnWidthProperty, value);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00040F30 File Offset: 0x0003F130
		private static void ColumnWidthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout._cachedColumnWidth = (global::Infragistics.Controls.Grids.ColumnWidth?)e.NewValue;
			columnLayout.OnPropertyChanged("ColumnWidth");
			foreach (global::Infragistics.Controls.Grids.Column column in columnLayout.Columns.DataColumns)
			{
				column.ActualWidth = 0.0;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00040FB0 File Offset: 0x0003F1B0
		public global::Infragistics.Controls.Grids.ColumnWidth ColumnWidthResolved
		{
			get
			{
				if (this.ColumnWidth != null)
				{
					return this.ColumnWidth.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.ColumnWidth;
				}
				return global::Infragistics.Controls.Grids.ColumnWidth.Auto;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00040FF5 File Offset: 0x0003F1F5
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00041034 File Offset: 0x0003F234
		public global::Infragistics.Controls.Grids.FillerColumnSettingsOverride FillerColumnSettings
		{
			get
			{
				if (this._fillerColumnSettings == null)
				{
					this._fillerColumnSettings = new global::Infragistics.Controls.Grids.FillerColumnSettingsOverride();
					this._fillerColumnSettings.PropertyChanged += this.FillerColumnSettings_PropertyChanged;
				}
				this._fillerColumnSettings.ColumnLayout = this;
				return this._fillerColumnSettings;
			}
			set
			{
				if (this._fillerColumnSettings != null)
				{
					this._fillerColumnSettings.PropertyChanged -= this.FillerColumnSettings_PropertyChanged;
				}
				this._fillerColumnSettings = value;
				if (this._fillerColumnSettings != null)
				{
					this._fillerColumnSettings.PropertyChanged += this.FillerColumnSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00041086 File Offset: 0x0003F286
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00041098 File Offset: 0x0003F298
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.HorizontalAlignment>))]
		public global::System.Windows.HorizontalAlignment? HeaderTextHorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextHorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextHorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000410AC File Offset: 0x0003F2AC
		private static void HeaderTextHorizontalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("HeaderTextHorizontalAlignment");
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000410CC File Offset: 0x0003F2CC
		public global::System.Windows.HorizontalAlignment HeaderTextHorizontalAlignmentResolved
		{
			get
			{
				if (this.HeaderTextHorizontalAlignment != null)
				{
					return this.HeaderTextHorizontalAlignment.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.HeaderTextHorizontalAlignment;
				}
				return (global::System.Windows.HorizontalAlignment)global::Infragistics.Controls.Grids.XamGrid.HeaderTextHorizontalAlignmentProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0004112A File Offset: 0x0003F32A
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x0004113C File Offset: 0x0003F33C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.VerticalAlignment>))]
		public global::System.Windows.VerticalAlignment? HeaderTextVerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment?)base.GetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextVerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextVerticalAlignmentProperty, value);
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00041150 File Offset: 0x0003F350
		private static void HeaderTextVerticalAlignmentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = (global::Infragistics.Controls.Grids.ColumnLayout)obj;
			columnLayout.OnPropertyChanged("HeaderTextVerticalAlignment");
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00041170 File Offset: 0x0003F370
		public global::System.Windows.VerticalAlignment HeaderTextVerticalAlignmentResolved
		{
			get
			{
				if (this.HeaderTextVerticalAlignment != null)
				{
					return this.HeaderTextVerticalAlignment.Value;
				}
				if (this.Grid != null)
				{
					return this.Grid.HeaderTextVerticalAlignment;
				}
				return (global::System.Windows.VerticalAlignment)global::Infragistics.Controls.Grids.XamGrid.HeaderTextVerticalAlignmentProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.XamGrid)).DefaultValue;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000411CE File Offset: 0x0003F3CE
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0004120C File Offset: 0x0003F40C
		internal global::Infragistics.Controls.Grids.ConditionalFormattingSettingsOverride ConditionalFormattingSettings
		{
			get
			{
				if (this._conditionalFormattingSettings == null)
				{
					this._conditionalFormattingSettings = new global::Infragistics.Controls.Grids.ConditionalFormattingSettingsOverride();
					this._conditionalFormattingSettings.PropertyChanged += this.ConditionalFormattingSettings_PropertyChanged;
				}
				this._conditionalFormattingSettings.ColumnLayout = this;
				return this._conditionalFormattingSettings;
			}
			set
			{
				if (this._conditionalFormattingSettings != null)
				{
					this._conditionalFormattingSettings.PropertyChanged -= this.ConditionalFormattingSettings_PropertyChanged;
				}
				this._conditionalFormattingSettings = value;
				if (this._conditionalFormattingSettings != null)
				{
					this._conditionalFormattingSettings.PropertyChanged += this.ConditionalFormattingSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0004125E File Offset: 0x0003F45E
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0004129C File Offset: 0x0003F49C
		public global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride ColumnChooserSettings
		{
			get
			{
				if (this._columnChooserSettings == null)
				{
					this._columnChooserSettings = new global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride();
					this._columnChooserSettings.PropertyChanged += this.ColumnChooserSettings_PropertyChanged;
				}
				this._columnChooserSettings.ColumnLayout = this;
				return this._columnChooserSettings;
			}
			set
			{
				if (this._columnChooserSettings != null)
				{
					this._columnChooserSettings.PropertyChanged -= this.ColumnChooserSettings_PropertyChanged;
				}
				this._columnChooserSettings = value;
				if (this._columnChooserSettings != null)
				{
					this._columnChooserSettings.PropertyChanged += this.ColumnChooserSettings_PropertyChanged;
				}
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000412EE File Offset: 0x0003F4EE
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x000412F6 File Offset: 0x0003F4F6
		protected internal global::System.Windows.DataTemplate InternalTemplate { get; set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000412FF File Offset: 0x0003F4FF
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00041307 File Offset: 0x0003F507
		protected internal object DefaultDataObject { get; set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00041310 File Offset: 0x0003F510
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00041318 File Offset: 0x0003F518
		protected internal global::System.Type ObjectDataType { get; set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00041321 File Offset: 0x0003F521
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00041329 File Offset: 0x0003F529
		protected internal global::Infragistics.CachedTypedInfo ObjectDataTypeInfo { get; set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00041332 File Offset: 0x0003F532
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0004133A File Offset: 0x0003F53A
		protected internal object ColumnLayoutFilteringObject { get; set; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00041344 File Offset: 0x0003F544
		protected internal global::Infragistics.Controls.Grids.ConditionalFormatCollection ConditionalFormatCollection
		{
			get
			{
				if (this._conditionalFormats == null)
				{
					this._conditionalFormats = new global::Infragistics.Controls.Grids.ConditionalFormatCollection();
					this._conditionalFormats.CollectionChanged += this.ConditionalFormats_CollectionChanged;
					this._conditionalFormats.CollectionItemChanged += this.ConditionalFormats_CollectionItemChanged;
				}
				return this._conditionalFormats;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00041398 File Offset: 0x0003F598
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x000413A0 File Offset: 0x0003F5A0
		internal bool IsInitialized { get; set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000413A9 File Offset: 0x0003F5A9
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x000413B1 File Offset: 0x0003F5B1
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> DataFields { get; set; }

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000413BA File Offset: 0x0003F5BA
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000413C2 File Offset: 0x0003F5C2
		internal bool? IsDefinedGlobally { get; set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000413CC File Offset: 0x0003F5CC
		internal bool IsDefinedGloballyResolved
		{
			get
			{
				return this.IsDefinedGlobally == true;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000413F4 File Offset: 0x0003F5F4
		internal int Level
		{
			get
			{
				int num = 0;
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this;
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = null;
				while (columnLayout.ColumnLayout != null && columnLayout.ColumnLayout != this && columnLayout != columnLayout2)
				{
					num++;
					columnLayout2 = columnLayout;
					columnLayout = columnLayout.ColumnLayout;
				}
				return num;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0004142C File Offset: 0x0003F62C
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00041434 File Offset: 0x0003F634
		internal bool IsXamlComplete { get; set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0004143D File Offset: 0x0003F63D
		internal override global::System.Windows.Style StrippedCellStyleForConditionalFormattingResolved
		{
			get
			{
				if (base.StrippedCellStyleForConditionalFormatting == null && this.Grid != null)
				{
					return this.Grid.StrippedCellStyleForConditionalFormatting;
				}
				return base.StrippedCellStyleForConditionalFormatting;
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00041464 File Offset: 0x0003F664
		protected internal virtual void OnChildColumnLayoutAdded(global::Infragistics.Controls.Grids.ColumnLayout childColumnLayout)
		{
			if (childColumnLayout.Visibility != global::System.Windows.Visibility.Collapsed && this.ExpansionIndicatorSettings.VisibilityResolved == global::System.Windows.Visibility.Visible && this.Columns.ColumnLayouts.Count > 0)
			{
				this.Columns.InternalRegisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn, true);
			}
			this.OnChildColumnLayoutStateChanged(this, childColumnLayout, global::Infragistics.Controls.Grids.ChildColumnLayoutState.Added);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x000414BC File Offset: 0x0003F6BC
		protected internal virtual void OnChildColumnLayoutRemoved(global::Infragistics.Controls.Grids.ColumnLayout childColumnLayout)
		{
			if (this.ExpansionIndicatorSettings.VisibilityResolved == global::System.Windows.Visibility.Collapsed || this.Columns.ColumnLayouts.Count == 0)
			{
				this.Columns.InternalUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn);
			}
			this.OnChildColumnLayoutStateChanged(this, childColumnLayout, global::Infragistics.Controls.Grids.ChildColumnLayoutState.Removed);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00041508 File Offset: 0x0003F708
		protected internal virtual void InvalidateSorting()
		{
			if (this.Grid != null)
			{
				this.Grid.ResetPanelRows();
			}
			this.OnPropertyChanged("SortingInvalidated");
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00041528 File Offset: 0x0003F728
		protected internal virtual void InvalidateGroupBy()
		{
			this.OnPropertyChanged("GroupByInvalidated");
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00041535 File Offset: 0x0003F735
		protected internal virtual void InvalidateGroupByReset()
		{
			this.OnPropertyChanged("GroupByInvalidatedReset");
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00041542 File Offset: 0x0003F742
		protected internal virtual void InvalidateFiltering()
		{
			this.OnPropertyChanged("ColumnLayoutFilteringInvalidated");
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0004154F File Offset: 0x0003F74F
		protected internal virtual void InvalidateConditionalFormatting()
		{
			this.OnPropertyChanged("InvalidateConditionalFormatting");
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0004155C File Offset: 0x0003F75C
		protected internal virtual void InvalidateSummaries()
		{
			this.OnPropertyChanged("InvalidateSummaries");
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00041569 File Offset: 0x0003F769
		protected internal virtual void InvalidateData()
		{
			this.OnPropertyChanged("InvalidateData");
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00041578 File Offset: 0x0003F778
		protected internal void BuildNullableFilter(global::Infragistics.Controls.Grids.RowFiltersCollection rowFilters, global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FilterOperand filterOperand, bool suppressInvalidation, bool clearExistingFilters, bool raiseEvents)
		{
			if (column.DataType == null)
			{
				return;
			}
			if (this.Grid.OnFiltering(column, filterOperand, rowFilters, null))
			{
				this.InvalidateFiltering();
				return;
			}
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFilters[column.Key];
			if (rowsFilter != null)
			{
				if (clearExistingFilters)
				{
					rowsFilter.Conditions.ClearSilently();
				}
			}
			else
			{
				rowsFilter = new global::Infragistics.Controls.Grids.RowsFilter(this.ObjectDataType, column);
				rowFilters.AddItemSilently(rowsFilter);
			}
			if (filterOperand == null)
			{
				return;
			}
			rowsFilter.Conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
			{
				Operator = filterOperand.ComparisonOperatorValue.Value,
				FilterValue = null
			});
			if (!suppressInvalidation)
			{
				this.InvalidateFiltering();
			}
			if (raiseEvents)
			{
				this.Grid.OnFiltered(rowFilters);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0004162C File Offset: 0x0003F82C
		protected internal bool BuildFilters(global::Infragistics.Controls.Grids.RowFiltersCollection rowFilters, object newValue, global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FilterOperand filterOperand, bool suppressInvalidation, bool fireEvents)
		{
			return this.BuildFilters(rowFilters, newValue, column, filterOperand, suppressInvalidation, true, fireEvents);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00041640 File Offset: 0x0003F840
		protected internal bool BuildFilters(global::Infragistics.Controls.Grids.RowFiltersCollection rowFilters, object newValue, global::Infragistics.Controls.Grids.Column column, global::Infragistics.Controls.Grids.FilterOperand filterOperand, bool suppressInvalidation, bool clearExistingFilters, bool fireEvents)
		{
			if (column.DataType == null || !column.CanBeFiltered)
			{
				return false;
			}
			if (fireEvents && this.Grid.OnFiltering(column, filterOperand, rowFilters, newValue))
			{
				this.InvalidateFiltering();
				return false;
			}
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFilters[column.Key];
			bool result = false;
			string text = newValue as string;
			if (rowsFilter != null)
			{
				if (clearExistingFilters)
				{
					result = (rowsFilter.Conditions.Count > 0);
					rowsFilter.Conditions.ClearSilently();
				}
			}
			else
			{
				rowsFilter = new global::Infragistics.Controls.Grids.RowsFilter(this.ObjectDataType, column);
				rowFilters.AddItemSilently(rowsFilter);
			}
			bool isValueType = column.DataType.IsValueType;
			if (filterOperand != null)
			{
				if (filterOperand.ComparisonOperatorValue == null)
				{
					if ((filterOperand.RequiresFilteringInput && newValue != null) || !filterOperand.RequiresFilteringInput)
					{
						global::System.Linq.Expressions.Expression expression = filterOperand.FilteringExpression(newValue);
						if (expression != null)
						{
							rowsFilter.Conditions.AddItemSilently(new global::Infragistics.CustomComparisonCondition
							{
								FilterOperand = filterOperand.GetType(),
								FilterValue = newValue,
								Expression = expression
							});
							result = true;
						}
					}
				}
				else if (column.DataType == typeof(string) && string.IsNullOrEmpty(text))
				{
					if (newValue != null && newValue is global::System.Collections.IList)
					{
						rowsFilter.Conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
						{
							Operator = filterOperand.ComparisonOperatorValue.Value,
							FilterValue = newValue
						});
						result = true;
					}
				}
				else if (((!global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(column.DataType) && !isValueType) || text == null) && (isValueType || !(newValue is string) || !string.IsNullOrEmpty((string)newValue)))
				{
					if (newValue != null)
					{
						rowsFilter.Conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
						{
							Operator = filterOperand.ComparisonOperatorValue.Value,
							FilterValue = newValue
						});
						result = true;
					}
					else if (!filterOperand.RequiresFilteringInput)
					{
						rowsFilter.Conditions.AddItemSilently(new global::Infragistics.ComparisonCondition
						{
							Operator = filterOperand.ComparisonOperatorValue.Value
						});
						result = true;
					}
				}
			}
			if (!suppressInvalidation)
			{
				this.InvalidateFiltering();
			}
			return result;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0004186B File Offset: 0x0003FA6B
		protected internal void RefreshSummaryRowVisual()
		{
			this.OnPropertyChanged("RefreshSummaryRowVisual");
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00041878 File Offset: 0x0003FA78
		protected internal virtual void ClearCachedRows()
		{
			this.OnPropertyChanged("ClearCachedRows");
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00041888 File Offset: 0x0003FA88
		protected virtual void InitObject(object owner)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = owner as global::Infragistics.Controls.Grids.XamGrid;
			if (xamGrid != null)
			{
				this.Grid = xamGrid;
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000418A8 File Offset: 0x0003FAA8
		protected virtual string Save()
		{
			return "IsDefinedGlobally=" + this.IsDefinedGloballyResolved.ToString();
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x000418D0 File Offset: 0x0003FAD0
		protected virtual void Load(string value)
		{
			bool value2 = true;
			if (!string.IsNullOrEmpty(value))
			{
				int num = value.IndexOf('=');
				if (num != -1 && num + 1 < value.Length)
				{
					string value3 = value.Substring(num + 1);
					bool.TryParse(value3, out value2);
				}
			}
			this.IsDefinedGlobally = new bool?(value2);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00041920 File Offset: 0x0003FB20
		protected internal virtual void OnColumnAdded(global::Infragistics.Controls.Grids.ColumnBase columnBase)
		{
			bool flag = false;
			if (this.Grid != null)
			{
				flag = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this.Grid);
			}
			if (!flag && this.Grid != null)
			{
				if (this._keys.Contains(columnBase.Key))
				{
					throw new global::Infragistics.Controls.Grids.DuplicateColumnKeyException(columnBase.Key);
				}
				if (string.IsNullOrEmpty(columnBase.Key))
				{
					throw new global::Infragistics.Controls.Grids.EmptyColumnKeyException();
				}
			}
			this._keys.Add(columnBase.Key);
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = columnBase as global::Infragistics.Controls.Grids.ColumnLayout;
			if (columnLayout == null || columnLayout.ColumnLayout == null || columnLayout != this)
			{
				columnBase.ColumnLayout = this;
			}
			if (this.DataFields != null && (columnLayout == null || (!columnLayout.IsDefinedGloballyResolved && string.IsNullOrEmpty(columnLayout.TargetTypeName))))
			{
				bool flag2 = false;
				foreach (global::Infragistics.DataField dataField in this.DataFields)
				{
					if (dataField.Name == columnBase.Key)
					{
						flag2 = true;
						columnBase.DataType = dataField.FieldType;
						columnBase.DataField = dataField;
						if (string.IsNullOrEmpty(columnBase.HeaderText))
						{
							columnBase.HeaderText = (dataField.DisplayName ?? dataField.Name);
							break;
						}
						break;
					}
				}
				if (!flag2)
				{
					if (columnBase.Key.Contains("[") && columnBase.Key.Contains("]"))
					{
						try
						{
							global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(columnBase.Key, global::System.Linq.Expressions.Expression.Parameter(this.Columns.DataType, "param"));
							if (expression != null && columnBase.DataType == null)
							{
								columnBase.DataType = expression.Type;
							}
							goto IL_243;
						}
						catch (global::System.Exception)
						{
							goto IL_243;
						}
					}
					string[] array = columnBase.Key.Split(new char[]
					{
						'.'
					});
					global::System.Type type = this.Columns.DataType;
					flag2 = true;
					foreach (string propertyName in array)
					{
						global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type, propertyName);
						if (propertyInfo == null)
						{
							if (!columnBase.RequiresBoundDataKey)
							{
								flag2 = false;
								break;
							}
							if (this.Grid == null)
							{
								throw new global::Infragistics.Controls.Grids.InvalidColumnKeyException(columnBase.Key);
							}
							this.Grid.ThrowInvalidColumnKeyException(columnBase.Key);
						}
						else
						{
							type = propertyInfo.PropertyType;
						}
					}
					if (flag2)
					{
						columnBase.DataType = type;
					}
				}
			}
			IL_243:
			if (columnLayout != null)
			{
				this.Columns.InternalColumnLayouts.Add(columnLayout);
				this.OnChildColumnLayoutAdded(columnLayout);
			}
			else
			{
				global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)columnBase;
				global::Infragistics.ICollectionBase collectionBase = column.ResolveChildColumns();
				if (collectionBase != null)
				{
					collectionBase.CollectionChanged += this.Columns_CollectionChanged;
					this.AddRemoveConditionalFormatsFromMergeCollection(collectionBase, true);
				}
				if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left)
				{
					this.Columns.FixedColumnsLeft.Add(column);
				}
				else if (column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Right)
				{
					this.Columns.FixedColumnsRight.Add(column);
				}
				if (column.IsGroupBy)
				{
					if (this.Grid == null)
					{
						throw new global::Infragistics.Controls.Grids.ChildColumnIsGroupByAccessDeniedException();
					}
					this.Columns.GroupByColumns.Add(column);
				}
				if (column.IsSorted != global::Infragistics.Controls.Grids.SortDirection.None)
				{
					this.Columns.SortedColumns.AddItemSilently(column);
				}
				if (column.IsSelected)
				{
					if (this.Grid == null)
					{
						throw new global::Infragistics.Controls.Grids.ChildColumnIsSelectedAccessDeniedException();
					}
					global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumns = this.Grid.SelectionSettings.SelectedColumns;
					if (!selectedColumns.Contains(column))
					{
						selectedColumns.InternalAddItemSilently(selectedColumns.Count, column);
					}
				}
				column.SummaryColumnSettings.OnLoadedCatchUp();
				column.FilterColumnSettings.OnLoadedCatchUp();
			}
			if (this.IsXamlComplete)
			{
				this.InvalidateData();
			}
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
			columnBase.PropertyChanged += this.Column_PropertyChanged;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00041CF0 File Offset: 0x0003FEF0
		protected internal virtual void OnColumnRemoved(global::Infragistics.Controls.Grids.ColumnBase columnBase)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = columnBase as global::Infragistics.Controls.Grids.ColumnLayout;
			this._keys.Remove(columnBase.Key);
			if (columnLayout != null)
			{
				this.Columns.InternalColumnLayouts.Remove(columnLayout);
				this.OnChildColumnLayoutRemoved(columnLayout);
			}
			global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
			if (column != null)
			{
				global::Infragistics.Controls.Grids.GroupColumn groupColumn = column as global::Infragistics.Controls.Grids.GroupColumn;
				if (groupColumn != null)
				{
					foreach (global::Infragistics.Controls.Grids.Column column2 in groupColumn.Columns)
					{
						this._keys.Remove(column2.Key);
					}
				}
				foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule item in column.ConditionalFormatCollection)
				{
					if (this.ConditionalFormatCollection.Contains(item))
					{
						this.ConditionalFormatCollection.Remove(item);
					}
				}
				global::Infragistics.ICollectionBase collectionBase = column.ResolveChildColumns();
				if (collectionBase != null)
				{
					collectionBase.CollectionChanged -= this.Columns_CollectionChanged;
					this.AddRemoveConditionalFormatsFromMergeCollection(collectionBase, false);
				}
				global::Infragistics.Controls.Grids.TemplateColumn templateColumn = column as global::Infragistics.Controls.Grids.TemplateColumn;
				if (this.Grid != null && this.Grid.IsLoaded && templateColumn != null)
				{
					this.Grid.ResetPanelRows(true);
				}
			}
			this.Columns.InvalidateActiveCell(columnBase);
			this.Columns.InvalidateSelection(columnBase);
			columnBase.PropertyChanged -= this.Column_PropertyChanged;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00041E70 File Offset: 0x00040070
		internal void RegisterChildBandRowsManager(global::Infragistics.Controls.Grids.ChildBandRowsManager rowsManager)
		{
			this._childBandRowManager.Add(rowsManager);
			if (this._childBandRowManager.Count % 500 == 0)
			{
				this._childBandRowManager.Compact();
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00041E9D File Offset: 0x0004009D
		internal void RegisterRowsManager(global::Infragistics.Controls.Grids.RowsManagerBase rowsManager)
		{
			this._rowsManagers.Add(rowsManager);
			if (this._rowsManagers.Count % 500 == 0)
			{
				this._rowsManagers.Compact();
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00041ECC File Offset: 0x000400CC
		internal global::System.Reflection.PropertyInfo ResovlePropertyInfo(object data)
		{
			if (this._propertyInfo == null && data != null && !string.IsNullOrEmpty(base.Key))
			{
				global::System.Type type = data.GetType();
				if (this.IsDefinedGloballyResolved && !string.IsNullOrEmpty(this.TargetTypeName))
				{
					global::System.Reflection.PropertyInfo[] array = global::Infragistics.DataManagerBase.ResolveProperties(type);
					foreach (global::System.Reflection.PropertyInfo propertyInfo in array)
					{
						object value = propertyInfo.GetValue(data, null);
						if (value != null)
						{
							global::System.Collections.IEnumerable enumerable = value as global::System.Collections.IEnumerable;
							if (enumerable != null)
							{
								global::System.Type type2 = global::Infragistics.DataManagerBase.ResolveItemType(enumerable);
								if (type2 != null && this == this.Grid.ColumnLayouts.FromType(type2))
								{
									this._propertyInfo = propertyInfo;
									break;
								}
							}
						}
					}
				}
				else
				{
					this._propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type, base.Key);
				}
			}
			if (this._propertyInfo != null && data != null && this._propertyInfo.DeclaringType != data.GetType())
			{
				return null;
			}
			return this._propertyInfo;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00041FCD File Offset: 0x000401CD
		internal void UnregisterChildBandRowsManager(global::Infragistics.Controls.Grids.ChildBandRowsManager rowsManager)
		{
			this._childBandRowManager.Remove(rowsManager);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00041FDC File Offset: 0x000401DC
		internal void UnregisterRowsManager(global::Infragistics.Controls.Grids.RowsManagerBase rowsManager)
		{
			this._rowsManagers.Remove(rowsManager);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00041FEC File Offset: 0x000401EC
		private void RegisterExpansionIndicatorSettings()
		{
			this._grid.ExpansionIndicatorSettings.PropertyChanged += this.ExpansionIndicatorSettings_PropertyChanged;
			if (this.Columns.ColumnLayouts.Count > 0)
			{
				if (this.ExpansionIndicatorSettings.VisibilityResolved == global::System.Windows.Visibility.Visible)
				{
					this.Columns.InternalRegisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn, true);
					return;
				}
				this.Columns.InternalUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00042063 File Offset: 0x00040263
		private void UnregisterExpansionIndicatorSettings()
		{
			this._grid.ExpansionIndicatorSettings.PropertyChanged -= this.ExpansionIndicatorSettings_PropertyChanged;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00042084 File Offset: 0x00040284
		private void RegisterRowSelectorSettings()
		{
			this._grid.RowSelectorSettings.PropertyChanged += this.RowSelectorSettings_PropertyChanged;
			if (this.RowSelectorSettings.VisibilityResolved == global::System.Windows.Visibility.Visible)
			{
				this.Columns.InternalRegisterFixedAdornerColumn(this.Columns.RowSelectorColumn, false);
				return;
			}
			this.Columns.InternalUnregisterFixedAdornerColumn(this.Columns.RowSelectorColumn);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000420E8 File Offset: 0x000402E8
		private void UnregisterRowSelectorSettings()
		{
			this._grid.RowSelectorSettings.PropertyChanged -= this.RowSelectorSettings_PropertyChanged;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00042106 File Offset: 0x00040306
		private void RegisterSortingSettings()
		{
			this._grid.SortingSettings.PropertyChanged += this.SortingSettings_PropertyChanged;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00042124 File Offset: 0x00040324
		private void UnregisterSortingSettings()
		{
			this._grid.SortingSettings.PropertyChanged -= this.SortingSettings_PropertyChanged;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00042142 File Offset: 0x00040342
		private void RegisterGroupBySettings()
		{
			this._grid.GroupBySettings.PropertyChanged += this.GroupBySettings_PropertyChanged;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00042160 File Offset: 0x00040360
		private void UnregisterGroupBySettings()
		{
			this._grid.GroupBySettings.PropertyChanged -= this.GroupBySettings_PropertyChanged;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0004217E File Offset: 0x0004037E
		private void RegisterDeferredScrollingSettings()
		{
			this._grid.DeferredScrollingSettings.PropertyChanged += this.DeferredScrollingSettings_PropertyChanged;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0004219C File Offset: 0x0004039C
		private void UnregisterDeferredScrollingSettings()
		{
			this._grid.DeferredScrollingSettings.PropertyChanged -= this.DeferredScrollingSettings_PropertyChanged;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000421BA File Offset: 0x000403BA
		private void RegisterPagerSettings()
		{
			this._grid.PagerSettings.PropertyChanged += this.PagerSettings_PropertyChanged;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x000421D8 File Offset: 0x000403D8
		private void UnregisterPagerSettings()
		{
			this._grid.PagerSettings.PropertyChanged -= this.PagerSettings_PropertyChanged;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000421F6 File Offset: 0x000403F6
		private void RegisterFixedColumnSettings()
		{
			this._grid.FixedColumnSettings.PropertyChanged += this.FixedColumnSettings_PropertyChanged;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00042214 File Offset: 0x00040414
		private void UnregisterFixedColumnSettings()
		{
			this._grid.FixedColumnSettings.PropertyChanged -= this.FixedColumnSettings_PropertyChanged;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00042232 File Offset: 0x00040432
		private void RegisterAddNewRowSettings()
		{
			this._grid.AddNewRowSettings.PropertyChanged += this.AddNewRowSettings_PropertyChanged;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00042250 File Offset: 0x00040450
		private void UnregisterAddNewRowSettings()
		{
			this._grid.AddNewRowSettings.PropertyChanged -= this.AddNewRowSettings_PropertyChanged;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0004226E File Offset: 0x0004046E
		private void RegisterFilterRowSettings()
		{
			this._grid.FilteringSettings.PropertyChanged += this.FilteringSettings_PropertyChanged;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0004228C File Offset: 0x0004048C
		private void UnregisterFilterRowSettings()
		{
			this._grid.FilteringSettings.PropertyChanged -= this.FilteringSettings_PropertyChanged;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000422AA File Offset: 0x000404AA
		private void RegisterSummaryRowSettings()
		{
			this._grid.SummaryRowSettings.PropertyChanged += this.SummaryRowSettings_PropertyChanged;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000422C8 File Offset: 0x000404C8
		private void UnregisterSummaryRowSettings()
		{
			this._grid.SummaryRowSettings.PropertyChanged -= this.SummaryRowSettings_PropertyChanged;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000422E6 File Offset: 0x000404E6
		private void RegisterFillerColumnSettings()
		{
			this._grid.FillerColumnSettings.PropertyChanged += this.FillerColumnSettings_PropertyChanged;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00042304 File Offset: 0x00040504
		private void UnregisterFillerColumnSettings()
		{
			this._grid.FillerColumnSettings.PropertyChanged -= this.FillerColumnSettings_PropertyChanged;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00042322 File Offset: 0x00040522
		private void RegisterUnregisterFixedAdornerColumn(global::Infragistics.Controls.Grids.Column col, global::System.Windows.Visibility visibility, bool first)
		{
			if (visibility == global::System.Windows.Visibility.Visible)
			{
				this.Columns.InternalRegisterFixedAdornerColumn(col, first);
			}
			else
			{
				this.Columns.InternalUnregisterFixedAdornerColumn(col);
			}
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00042356 File Offset: 0x00040556
		private void RegisterConditionalFormattingSettings()
		{
			this._grid.ConditionalFormattingSettings.PropertyChanged += this.ConditionalFormattingSettings_PropertyChanged;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00042374 File Offset: 0x00040574
		private void UnregisterConditionalFormattingSettings()
		{
			this._grid.ConditionalFormattingSettings.PropertyChanged -= this.ConditionalFormattingSettings_PropertyChanged;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00042392 File Offset: 0x00040592
		private void RegisterColumnChooserSettings()
		{
			this._grid.ColumnChooserSettings.PropertyChanged += this.ColumnChooserSettings_PropertyChanged;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000423B0 File Offset: 0x000405B0
		private void UnregisterColumnChooserSettings()
		{
			this._grid.ColumnChooserSettings.PropertyChanged -= this.ColumnChooserSettings_PropertyChanged;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000423D0 File Offset: 0x000405D0
		private void ExecuteColumnCatchup()
		{
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Columns.AllColumns)
			{
				global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column != null)
				{
					column.FilterColumnSettings.OnLoadedCatchUp();
					column.SummaryColumnSettings.OnLoadedCatchUp();
				}
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0004243C File Offset: 0x0004063C
		protected override void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventArgs e = new global::System.ComponentModel.PropertyChangedEventArgs(propertyName);
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._rowsManagers)
			{
				rowsManagerBase.OnColumnLayoutPropertyChanged(this, e);
			}
			foreach (global::Infragistics.Controls.Grids.ChildBandRowsManager childBandRowsManager in this._childBandRowManager)
			{
				childBandRowsManager.ChildColumnLayout_PropertyChanged(this, e);
			}
			base.OnPropertyChanged(propertyName);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000424DC File Offset: 0x000406DC
		protected internal override void OnStyleChanged()
		{
			if (this.Grid != null)
			{
				this.Grid.ResetPanelRows();
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000424F4 File Offset: 0x000406F4
		protected override void OnVisibilityChanged()
		{
			base.OnVisibilityChanged();
			if (base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = this.Grid;
				if (grid != null && grid.ActiveCell != null)
				{
					for (global::Infragistics.Controls.Grids.ColumnLayout columnLayout = grid.ActiveCell.Row.ColumnLayout; columnLayout != null; columnLayout = columnLayout.ColumnLayout)
					{
						if (columnLayout.Visibility == global::System.Windows.Visibility.Collapsed)
						{
							grid.ActiveCell = null;
							break;
						}
					}
				}
			}
			if (base.ColumnLayout != null)
			{
				base.ColumnLayout.OnChildColumnLayoutStateChanged(this, this, global::Infragistics.Controls.Grids.ChildColumnLayoutState.VisibilityChanged);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00042567 File Offset: 0x00040767
		internal override global::System.Windows.Controls.ControlTemplate ControlTemplateForConditionalFormattingResolved
		{
			get
			{
				if (base.ControlTemplateForConditionalFormatting == null && this.Grid != null)
				{
					return this.Grid.ControlTemplateForConditionalFormatting;
				}
				return base.ControlTemplateForConditionalFormatting;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0004258C File Offset: 0x0004078C
		private void Grid_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "RowSelectorSettings")
			{
				this.RegisterRowSelectorSettings();
			}
			else if (e.PropertyName == "ExpansionIndicatorSettings")
			{
				this.RegisterExpansionIndicatorSettings();
			}
			else if (e.PropertyName == "SortingSettings")
			{
				this.RegisterSortingSettings();
			}
			else if (e.PropertyName == "FixedColumnSettings")
			{
				this.RegisterFixedColumnSettings();
			}
			else if (e.PropertyName == "PagingSettings")
			{
				this.RegisterPagerSettings();
			}
			else if (e.PropertyName == "GroupBySettings")
			{
				this.RegisterGroupBySettings();
			}
			else if (e.PropertyName == "DeferredScrollingSettings")
			{
				this.RegisterDeferredScrollingSettings();
			}
			else if (e.PropertyName == "AddNewRowSettings")
			{
				this.RegisterAddNewRowSettings();
			}
			else if (e.PropertyName == "FilteringSettings")
			{
				this.RegisterFilterRowSettings();
			}
			else if (e.PropertyName == "SummaryRowSettings")
			{
				this.RegisterSummaryRowSettings();
			}
			else if (e.PropertyName == "FillerColumnSettings")
			{
				this.RegisterFillerColumnSettings();
			}
			else if (e.PropertyName == "ConditionalFormattingSettings")
			{
				this.RegisterConditionalFormattingSettings();
			}
			else if (e.PropertyName == "ColumnChooserSettings")
			{
				this.RegisterColumnChooserSettings();
			}
			else
			{
				if (e.PropertyName == "ColumnWidth")
				{
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.Column> enumerator = this.Columns.DataColumns.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Controls.Grids.Column column = enumerator.Current;
							column.ActualWidth = 0.0;
						}
						goto IL_1CE;
					}
				}
				this.OnPropertyChanged(e.PropertyName);
			}
			IL_1CE:
			this.Grid.InvalidateScrollPanel(true);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00042784 File Offset: 0x00040984
		internal void RowSelectorSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Visibility")
			{
				this.RegisterUnregisterFixedAdornerColumn(this.Columns.RowSelectorColumn, this.RowSelectorSettings.VisibilityResolved, false);
			}
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000427D4 File Offset: 0x000409D4
		internal void FillerColumnSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000427EC File Offset: 0x000409EC
		internal void ExpansionIndicatorSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Visibility" && this.Columns.ColumnLayouts.Count > 0)
			{
				this.RegisterUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn, this.ExpansionIndicatorSettings.VisibilityResolved, true);
			}
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0004284F File Offset: 0x00040A4F
		private void ColumnMovingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00042851 File Offset: 0x00040A51
		private void ColumnResizingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00042853 File Offset: 0x00040A53
		private void FixedColumnSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00042869 File Offset: 0x00040A69
		private void SortingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0004287F File Offset: 0x00040A7F
		private void GroupBySettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000428A1 File Offset: 0x00040AA1
		private void DeferredScrollingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000428B0 File Offset: 0x00040AB0
		private void PagerSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				if (e.PropertyName == "AllowPaging" && this.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					this.InvalidateConditionalFormatting();
				}
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00042907 File Offset: 0x00040B07
		private void EditingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0004290C File Offset: 0x00040B0C
		private void AddRemoveConditionalFormatsFromMergeCollection(global::System.Collections.IList items, bool add)
		{
			if (items != null && items.Count > 0)
			{
				int count = items.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Grids.Column column = items[i] as global::Infragistics.Controls.Grids.Column;
					if (column != null && !column.IsMoving)
					{
						if (add)
						{
							column.ConditionalFormatCollection.CollectionChanged += this.ConditionalFormatCollection_CollectionChanged;
						}
						else
						{
							column.ConditionalFormatCollection.CollectionChanged -= this.ConditionalFormatCollection_CollectionChanged;
						}
						foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule item in column.ConditionalFormatCollection)
						{
							if (add)
							{
								this.ConditionalFormatCollection.Add(item);
							}
							else
							{
								this.ConditionalFormatCollection.Remove(item);
							}
						}
					}
				}
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000429F0 File Offset: 0x00040BF0
		private void ConditionalFormatCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.IConditionalFormattingRule item = (global::Infragistics.Controls.Grids.IConditionalFormattingRule)obj;
						this.ConditionalFormatCollection.Add(item);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						global::Infragistics.Controls.Grids.IConditionalFormattingRule item2 = (global::Infragistics.Controls.Grids.IConditionalFormattingRule)obj2;
						this.ConditionalFormatCollection.Remove(item2);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
			{
				foreach (object obj3 in e.NewItems)
				{
					global::Infragistics.Controls.Grids.IConditionalFormattingRule item3 = (global::Infragistics.Controls.Grids.IConditionalFormattingRule)obj3;
					this.ConditionalFormatCollection.Add(item3);
				}
				using (global::System.Collections.IEnumerator enumerator4 = e.OldItems.GetEnumerator())
				{
					while (enumerator4.MoveNext())
					{
						object obj4 = enumerator4.Current;
						global::Infragistics.Controls.Grids.IConditionalFormattingRule item4 = (global::Infragistics.Controls.Grids.IConditionalFormattingRule)obj4;
						this.ConditionalFormatCollection.Remove(item4);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				int count = this.ConditionalFormatCollection.Count;
				this.OnPropertyChanged("ClearFilterProxies");
				this.ConditionalFormatCollection.CollectionChanged -= this.ConditionalFormats_CollectionChanged;
				for (int i = count - 1; i >= 0; i--)
				{
					this.ConditionalFormatCollection.RemoveAt(i);
				}
				this.ConditionalFormatCollection.CollectionChanged += this.ConditionalFormats_CollectionChanged;
				this.InvalidateConditionalFormatting();
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00042BF0 File Offset: 0x00040DF0
		private void Columns_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.AddRemoveConditionalFormatsFromMergeCollection(e.NewItems, true);
			this.AddRemoveConditionalFormatsFromMergeCollection(e.OldItems, false);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00042C0C File Offset: 0x00040E0C
		private void AddNewRowSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00042C2E File Offset: 0x00040E2E
		private void SummaryRowSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				if (e.PropertyName == "SummaryExecution")
				{
					this.Grid.ResetPanelRows();
				}
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00042C6D File Offset: 0x00040E6D
		private void FilteringSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00042C8F File Offset: 0x00040E8F
		private void ConditionalFormattingSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00042C9D File Offset: 0x00040E9D
		private void ConditionalFormats_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			this.OnPropertyChanged("ConditionalFormatRule");
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00042CAA File Offset: 0x00040EAA
		private void ConditionalFormats_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InvalidateConditionalFormatting();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00042CB2 File Offset: 0x00040EB2
		private void ColumnChooserSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Grid != null)
			{
				this.Grid.InvalidateScrollPanel(true);
			}
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00042CD4 File Offset: 0x00040ED4
		private void Column_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Visibility")
			{
				this.Columns.InvalidateColumnsCollections(true);
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = sender as global::Infragistics.Controls.Grids.ColumnLayout;
				global::Infragistics.Controls.Grids.ColumnBase columnBase = sender as global::Infragistics.Controls.Grids.ColumnBase;
				if (columnLayout != null)
				{
					if (columnLayout.Grid == null)
					{
						columnLayout.Grid = this.Grid;
					}
					bool flag = true;
					foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 in this.Columns.ColumnLayouts)
					{
						if (columnLayout2.Visibility == global::System.Windows.Visibility.Visible)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						this.Columns.InternalUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn);
					}
					else if (columnLayout.ExpansionIndicatorSettings.VisibilityResolved == global::System.Windows.Visibility.Visible)
					{
						this.Columns.InternalRegisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn, true);
					}
					else
					{
						this.Columns.InternalUnregisterFixedAdornerColumn(this.Columns.ExpansionIndicatorColumn);
					}
				}
				else if (columnBase != null && columnBase.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Controls.Grids.XamGrid grid = this.Grid;
					if (grid != null && grid.ActiveCell != null && columnBase.Equals(grid.ActiveCell.Column))
					{
						grid.ActiveCell = null;
					}
				}
				if (this.Grid != null && columnBase != null)
				{
					global::Infragistics.Controls.Grids.ColumnVisibilityChangedEventArgs e2 = new global::Infragistics.Controls.Grids.ColumnVisibilityChangedEventArgs
					{
						Column = columnBase
					};
					this.Grid.OnColumnVisibilityChanged(e2);
					if (columnBase is global::Infragistics.Controls.Grids.GroupColumn && columnBase.Visibility == global::System.Windows.Visibility.Visible)
					{
						this.Grid.ResetPanelRows();
						this.Grid.InvalidateScrollPanel(false);
						return;
					}
				}
			}
			else
			{
				if (e.PropertyName == "IsFixed" || e.PropertyName == "Width")
				{
					this.Columns.InvalidateColumnsCollections(true);
					return;
				}
				if (e.PropertyName == "AllowCaseSensitiveSort" || e.PropertyName == "SortComparer" || e.PropertyName == "IsSorted")
				{
					this.InvalidateSorting();
					return;
				}
				if (e.PropertyName == "IsGroupBy")
				{
					this.InvalidateGroupBy();
					if (this.Grid != null && this.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
					{
						this.Columns.InvalidateColumnsCollections(true);
						return;
					}
				}
				else
				{
					if (e.PropertyName == "FilterColumnSettings" || e.PropertyName == "FilteringInvalidated")
					{
						this.InvalidateFiltering();
						return;
					}
					if (e.PropertyName == "SummaryColumnSettings")
					{
						this.InvalidateSummaries();
						return;
					}
					if (e.PropertyName == "ValueConverter" || e.PropertyName == "EditorStyle" || e.PropertyName == "ConditionalFormatCollectionCollectionChanged")
					{
						if (this.Grid != null)
						{
							this.Grid.ResetPanelRows();
							this.Grid.InvalidateScrollPanel(false);
							return;
						}
					}
					else if (e.PropertyName == "SelectedDateFormat")
					{
						if (this.Grid != null && this.Grid.IsLoaded)
						{
							this.Grid.ResetPanelRows(true);
							return;
						}
					}
					else if (e.PropertyName == "ItemsSource")
					{
						if (this.Grid != null)
						{
							this.Grid.ResetPanelRows(true);
							return;
						}
					}
					else if (e.PropertyName != "ActualWidth")
					{
						if (this.Grid != null)
						{
							this.Grid.InvalidateScrollPanel(true);
							return;
						}
					}
					else if (this.Grid != null)
					{
						this.Grid.InvalidateScrollPanel(false);
					}
				}
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00043058 File Offset: 0x00041258
		private void OnChildColumnLayoutStateChanged(global::Infragistics.Controls.Grids.ColumnLayout sender, global::Infragistics.Controls.Grids.ColumnLayout childColumnLayout, global::Infragistics.Controls.Grids.ChildColumnLayoutState state)
		{
			if (this._rowsManagers.Count > 0)
			{
				global::Infragistics.Controls.Grids.ChildColumnLayoutStateChangedEventArgs e = new global::Infragistics.Controls.Grids.ChildColumnLayoutStateChangedEventArgs(childColumnLayout, state);
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._rowsManagers)
				{
					rowsManagerBase.ColumnLayout_ChildColumnLayoutStateChanged(sender, e);
				}
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000430BC File Offset: 0x000412BC
		internal void OnColumnLayoutDisposing()
		{
			this._grid.PropertyChanged -= this.Grid_PropertyChanged;
			this.UnregisterExpansionIndicatorSettings();
			this.UnregisterRowSelectorSettings();
			this.UnregisterSortingSettings();
			this.UnregisterPagerSettings();
			this.UnregisterFixedColumnSettings();
			this.UnregisterGroupBySettings();
			this.UnregisterDeferredScrollingSettings();
			this.UnregisterAddNewRowSettings();
			this.UnregisterFilterRowSettings();
			this.UnregisterFillerColumnSettings();
			this.UnregisterSummaryRowSettings();
			this.UnregisterConditionalFormattingSettings();
			this.UnregisterColumnChooserSettings();
			this.OnColumnLayoutStateChanged(global::Infragistics.Controls.Grids.ColumnLayoutState.Disposing);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00043135 File Offset: 0x00041335
		internal void OnColumnLayoutReset()
		{
			this.OnColumnLayoutStateChanged(global::Infragistics.Controls.Grids.ColumnLayoutState.Reset);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00043140 File Offset: 0x00041340
		private void OnColumnLayoutStateChanged(global::Infragistics.Controls.Grids.ColumnLayoutState state)
		{
			if (this._rowsManagers.Count > 0)
			{
				global::Infragistics.Controls.Grids.ColumnLayoutStateChangedEventArgs e = new global::Infragistics.Controls.Grids.ColumnLayoutStateChangedEventArgs(state);
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._rowsManagers)
				{
					rowsManagerBase.ColumnLayout_StateChanged(this, e);
				}
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000431A4 File Offset: 0x000413A4
		protected virtual void Dispose(bool disposing)
		{
			if (this._columns != null)
			{
				this._columns.CollectionChanged -= this.Columns_CollectionChanged;
				this._columns.Dispose();
			}
			if (this._fixedColumnSettings != null)
			{
				this._fixedColumnSettings.Dispose();
			}
			if (this._sortingSettings != null)
			{
				this._sortingSettings.Dispose();
			}
			if (this._filteringSettings != null)
			{
				this._filteringSettings.Dispose();
			}
			if (this._summaryRowSettings != null)
			{
				this._summaryRowSettings.Dispose();
			}
			if (this._conditionalFormats != null)
			{
				this._conditionalFormats.CollectionChanged -= this.ConditionalFormats_CollectionChanged;
				this._conditionalFormats.CollectionItemChanged -= this.ConditionalFormats_CollectionItemChanged;
				this._conditionalFormats.Dispose();
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00043268 File Offset: 0x00041468
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00043277 File Offset: 0x00041477
		void global::Infragistics.INeedInitializationForPersistence.InitObject(object owner)
		{
			this.InitObject(owner);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00043280 File Offset: 0x00041480
		string global::Infragistics.IProvideCustomStorage.Save()
		{
			return this.Save();
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00043288 File Offset: 0x00041488
		void global::Infragistics.IProvideCustomStorage.Load(string value)
		{
			this.Load(value);
		}

		// Token: 0x04000577 RID: 1399
		private global::Infragistics.Controls.Grids.ColumnBaseCollection _columns;

		// Token: 0x04000578 RID: 1400
		private global::Infragistics.Controls.Grids.XamGrid _grid;

		// Token: 0x04000579 RID: 1401
		private global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride _expansionIndicatorSettings;

		// Token: 0x0400057A RID: 1402
		private global::Infragistics.Controls.Grids.RowSelectorSettingsOverride _rowSelectorSettings;

		// Token: 0x0400057B RID: 1403
		private global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride _columnMovingSettings;

		// Token: 0x0400057C RID: 1404
		private global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride _columnResizingSettings;

		// Token: 0x0400057D RID: 1405
		private global::Infragistics.Controls.Grids.SortingSettingsOverride _sortingSettings;

		// Token: 0x0400057E RID: 1406
		private global::Infragistics.Controls.Grids.PagerSettingsOverride _pagerSettings;

		// Token: 0x0400057F RID: 1407
		private global::Infragistics.Controls.Grids.FixedColumnSettingsOverride _fixedColumnSettings;

		// Token: 0x04000580 RID: 1408
		private global::Infragistics.Controls.Grids.GroupBySettingsOverride _groupBySettings;

		// Token: 0x04000581 RID: 1409
		private global::Infragistics.Controls.Grids.DeferredScrollingSettingsOverride _deferredScrollingSettings;

		// Token: 0x04000582 RID: 1410
		private global::Infragistics.Controls.Grids.AddNewRowSettingsOverride _addNewRowSettings;

		// Token: 0x04000583 RID: 1411
		private global::Infragistics.Controls.Grids.FilteringSettingsOverride _filteringSettings;

		// Token: 0x04000584 RID: 1412
		private global::Infragistics.Controls.Grids.SummaryRowSettingsOverride _summaryRowSettings;

		// Token: 0x04000585 RID: 1413
		private global::Infragistics.Controls.Grids.FillerColumnSettingsOverride _fillerColumnSettings;

		// Token: 0x04000586 RID: 1414
		private global::System.Reflection.PropertyInfo _propertyInfo;

		// Token: 0x04000587 RID: 1415
		private global::Infragistics.Controls.Grids.ConditionalFormattingSettingsOverride _conditionalFormattingSettings;

		// Token: 0x04000588 RID: 1416
		private global::Infragistics.Controls.Grids.ConditionalFormatCollection _conditionalFormats;

		// Token: 0x04000589 RID: 1417
		private global::System.Windows.Style _childBandHeaderStyle;

		// Token: 0x0400058A RID: 1418
		private global::Infragistics.Controls.Grids.ColumnChooserSettingsOverride _columnChooserSettings;

		// Token: 0x0400058B RID: 1419
		private global::System.Collections.ObjectModel.Collection<string> _keys;

		// Token: 0x0400058C RID: 1420
		private bool? _cachedIsAlternateRowsEnabled = null;

		// Token: 0x0400058D RID: 1421
		private global::Infragistics.Controls.Grids.ColumnWidth? _cachedColumnWidth;

		// Token: 0x0400058E RID: 1422
		private global::Infragistics.Controls.Grids.RowHeight? _cachedRowHeight;

		// Token: 0x0400058F RID: 1423
		private global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Grids.RowsManagerBase> _rowsManagers;

		// Token: 0x04000590 RID: 1424
		private global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Grids.ChildBandRowsManager> _childBandRowManager;

		// Token: 0x04000591 RID: 1425
		private static readonly global::System.Windows.DependencyProperty TargetTypeProperty = global::System.Windows.DependencyProperty.Register("TargetType", typeof(global::System.Type), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.TypeChanged)));

		// Token: 0x04000592 RID: 1426
		public static readonly global::System.Windows.DependencyProperty TargetTypeNameProperty = global::System.Windows.DependencyProperty.Register("TargetTypeName", typeof(string), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.TargetTypeNameChanged)));

		// Token: 0x04000593 RID: 1427
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.HeaderVisibilityChanged)));

		// Token: 0x04000594 RID: 1428
		public static readonly global::System.Windows.DependencyProperty FooterVisibilityProperty = global::System.Windows.DependencyProperty.Register("FooterVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.FooterVisibilityChanged)));

		// Token: 0x04000595 RID: 1429
		public static readonly global::System.Windows.DependencyProperty AutoGenerateColumnsProperty = global::System.Windows.DependencyProperty.Register("AutoGenerateColumns", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.AutoGenerateColumnsChanged)));

		// Token: 0x04000596 RID: 1430
		public static readonly global::System.Windows.DependencyProperty IndentationProperty = global::System.Windows.DependencyProperty.Register("Indentation", typeof(double), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.IndentationChanged)));

		// Token: 0x04000597 RID: 1431
		public static readonly global::System.Windows.DependencyProperty ColumnLayoutHeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("ColumnLayoutHeaderVisibility", typeof(global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.ColumnLayoutHeaderVisibilityChanged)));

		// Token: 0x04000598 RID: 1432
		public static readonly global::System.Windows.DependencyProperty IsAlternateRowsEnabledProperty = global::System.Windows.DependencyProperty.Register("IsAlternateRowsEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.IsAlternateRowsEnabledChanged)));

		// Token: 0x04000599 RID: 1433
		public static readonly global::System.Windows.DependencyProperty ColumnsHeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("ColumnsHeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsHeaderTemplateChanged)));

		// Token: 0x0400059A RID: 1434
		public static readonly global::System.Windows.DependencyProperty ColumnsFooterTemplateProperty = global::System.Windows.DependencyProperty.Register("ColumnsFooterTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.ColumnsFooterTemplateChanged)));

		// Token: 0x0400059B RID: 1435
		private global::Infragistics.Controls.Grids.EditingSettingsOverride _editingSettings;

		// Token: 0x0400059C RID: 1436
		public static readonly global::System.Windows.DependencyProperty RowHeightProperty = global::System.Windows.DependencyProperty.Register("RowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.RowHeightChanged))));

		// Token: 0x0400059D RID: 1437
		public static readonly global::System.Windows.DependencyProperty MinimumRowHeightProperty = global::System.Windows.DependencyProperty.Register("MinimumRowHeight", typeof(double?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.MinimumRowHeightChanged)));

		// Token: 0x0400059E RID: 1438
		public static readonly global::System.Windows.DependencyProperty DeleteKeyActionProperty = global::System.Windows.DependencyProperty.Register("DeleteKeyAction", typeof(global::Infragistics.Controls.Grids.DeleteKeyAction?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400059F RID: 1439
		public static readonly global::System.Windows.DependencyProperty HeaderRowHeightProperty = global::System.Windows.DependencyProperty.Register("HeaderRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.HeaderRowHeightChanged))));

		// Token: 0x040005A0 RID: 1440
		public static readonly global::System.Windows.DependencyProperty FooterRowHeightProperty = global::System.Windows.DependencyProperty.Register("FooterRowHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.FooterRowHeightChanged))));

		// Token: 0x040005A1 RID: 1441
		public static readonly global::System.Windows.DependencyProperty ChildBandHeaderHeightProperty = global::System.Windows.DependencyProperty.Register("ChildBandHeaderHeight", typeof(global::Infragistics.Controls.Grids.RowHeight?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.RowHeight?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.ChildBandHeaderHeightChanged))));

		// Token: 0x040005A2 RID: 1442
		public static readonly global::System.Windows.DependencyProperty ColumnWidthProperty = global::System.Windows.DependencyProperty.Register("ColumnWidth", typeof(global::Infragistics.Controls.Grids.ColumnWidth?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Grids.ColumnWidth?>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.ColumnWidthChanged))));

		// Token: 0x040005A3 RID: 1443
		public static readonly global::System.Windows.DependencyProperty HeaderTextHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextHorizontalAlignmentChanged)));

		// Token: 0x040005A4 RID: 1444
		public static readonly global::System.Windows.DependencyProperty HeaderTextVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HeaderTextVerticalAlignment", typeof(global::System.Windows.VerticalAlignment?), typeof(global::Infragistics.Controls.Grids.ColumnLayout), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnLayout.HeaderTextVerticalAlignmentChanged)));
	}
}
