using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E1 RID: 481
	[global::System.Windows.StyleTypedProperty(Property = "GroupByRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord))]
	[global::System.Windows.StyleTypedProperty(Property = "LabelPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "FilterCellEditorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.ValueEditor))]
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	[global::System.Windows.StyleTypedProperty(Property = "CellPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.CellPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "FilterCellValuePresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter))]
	[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.CloneObject)]
	[global::System.Windows.StyleTypedProperty(Property = "CellValuePresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "EditorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.ValueEditor))]
	[global::System.Windows.StyleTypedProperty(Property = "ExpandedCellStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ExpandableFieldRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))]
	public class FieldSettings : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x06001D44 RID: 7492 RVA: 0x00083C84 File Offset: 0x00081E84
		static FieldSettings()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldSettings));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00084E93 File Offset: 0x00083093
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			base.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00084EB0 File Offset: 0x000830B0
		private static void OnAllowCellVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedAllowCellVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedAllowCellVirtualization = cachedAllowCellVirtualization;
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00084ED8 File Offset: 0x000830D8
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00084EE0 File Offset: 0x000830E0
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowCellVirtualization
		{
			get
			{
				return this._cachedAllowCellVirtualization;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowCellVirtualizationProperty, value);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00084EF3 File Offset: 0x000830F3
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00084F05 File Offset: 0x00083105
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowEdit
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowEditProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowEditProperty, value);
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00084F18 File Offset: 0x00083118
		private static void OnAllowFixingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00084F1A File Offset: 0x0008311A
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00084F2C File Offset: 0x0008312C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldFixing AllowFixing
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowFieldFixing)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowFixingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowFixingProperty, value);
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00084F3F File Offset: 0x0008313F
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00084F51 File Offset: 0x00083151
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowGroupBy
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowGroupByProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowGroupByProperty, value);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00084F64 File Offset: 0x00083164
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00084F76 File Offset: 0x00083176
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldHiding AllowHiding
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowFieldHiding)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty, value);
			}
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00084F89 File Offset: 0x00083189
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowHiding()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty, this);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00084F96 File Offset: 0x00083196
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowHiding()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00084FA4 File Offset: 0x000831A4
		private static void OnAllowLabelVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedAllowLabelVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedAllowLabelVirtualization = cachedAllowLabelVirtualization;
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00084FCC File Offset: 0x000831CC
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00084FD4 File Offset: 0x000831D4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowLabelVirtualization
		{
			get
			{
				return this._cachedAllowLabelVirtualization;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowLabelVirtualizationProperty, value);
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00084FE7 File Offset: 0x000831E7
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00084FF9 File Offset: 0x000831F9
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowRecordFiltering
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowRecordFilteringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowRecordFilteringProperty, value);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0008500C File Offset: 0x0008320C
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0008501E File Offset: 0x0008321E
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowResize
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowResizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowResizeProperty, value);
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00085031 File Offset: 0x00083231
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00085043 File Offset: 0x00083243
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowSummaries
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowSummariesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowSummariesProperty, value);
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00085056 File Offset: 0x00083256
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00085068 File Offset: 0x00083268
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions? AutoSizeOptions
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeOptionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeOptionsProperty, value);
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0008507B File Offset: 0x0008327B
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0008508D File Offset: 0x0008328D
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope AutoSizeScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeScopeProperty, value);
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000850A0 File Offset: 0x000832A0
		private static bool IsCellClickActionValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.CellClickAction), value);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000850B2 File Offset: 0x000832B2
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x000850C4 File Offset: 0x000832C4
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CellClickAction CellClickAction
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CellClickAction)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellClickActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellClickActionProperty, value);
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000850D7 File Offset: 0x000832D7
		private static bool IsCellContentAlignmentValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), value);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000850EC File Offset: 0x000832EC
		private static void OnCellContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.CellContentAlignment cachedCellContentAlignment = (global::Infragistics.Windows.DataPresenter.CellContentAlignment)e.NewValue;
			fieldSettings._cachedCellContentAlignment = cachedCellContentAlignment;
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00085114 File Offset: 0x00083314
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0008511C File Offset: 0x0008331C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CellContentAlignment CellContentAlignment
		{
			get
			{
				return this._cachedCellContentAlignment;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellContentAlignmentProperty, value);
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00085130 File Offset: 0x00083330
		private static void OnCellHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellHeight = (double)e.NewValue;
			fieldSettings._cachedCellHeight = cachedCellHeight;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00085158 File Offset: 0x00083358
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00085160 File Offset: 0x00083360
		[global::System.ComponentModel.Bindable(true)]
		public double CellHeight
		{
			get
			{
				return this._cachedCellHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellHeightProperty, value);
			}
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00085174 File Offset: 0x00083374
		private static void OnCellMaxHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMaxHeight = (double)e.NewValue;
			fieldSettings._cachedCellMaxHeight = cachedCellMaxHeight;
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0008519C File Offset: 0x0008339C
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x000851A4 File Offset: 0x000833A4
		[global::System.ComponentModel.Bindable(true)]
		public double CellMaxHeight
		{
			get
			{
				return this._cachedCellMaxHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellMaxHeightProperty, value);
			}
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x000851B8 File Offset: 0x000833B8
		private static void OnCellMaxWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMaxWidth = (double)e.NewValue;
			fieldSettings._cachedCellMaxWidth = cachedCellMaxWidth;
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000851E0 File Offset: 0x000833E0
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x000851E8 File Offset: 0x000833E8
		[global::System.ComponentModel.Bindable(true)]
		public double CellMaxWidth
		{
			get
			{
				return this._cachedCellMaxWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellMaxWidthProperty, value);
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000851FC File Offset: 0x000833FC
		private static void OnCellMinHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMinHeight = (double)e.NewValue;
			fieldSettings._cachedCellMinHeight = cachedCellMinHeight;
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00085224 File Offset: 0x00083424
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0008522C File Offset: 0x0008342C
		[global::System.ComponentModel.Bindable(true)]
		public double CellMinHeight
		{
			get
			{
				return this._cachedCellMinHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellMinHeightProperty, value);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00085240 File Offset: 0x00083440
		private static void OnCellMinWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMinWidth = (double)e.NewValue;
			fieldSettings._cachedCellMinWidth = cachedCellMinWidth;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00085268 File Offset: 0x00083468
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00085270 File Offset: 0x00083470
		[global::System.ComponentModel.Bindable(true)]
		public double CellMinWidth
		{
			get
			{
				return this._cachedCellMinWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellMinWidthProperty, value);
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00085284 File Offset: 0x00083484
		private static void OnCellPresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellPresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000852AC File Offset: 0x000834AC
		private static bool ValidateCellPresenterStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter), "FieldSettings.CellPresenterStyle");
			return true;
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000852E0 File Offset: 0x000834E0
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x000852E8 File Offset: 0x000834E8
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CellPresenterStyle
		{
			get
			{
				return this._cachedCellPresenterStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleProperty, value);
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000852F8 File Offset: 0x000834F8
		private static void OnCellPresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellPresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0008531E File Offset: 0x0008351E
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00085326 File Offset: 0x00083526
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.StyleSelector CellPresenterStyleSelector
		{
			get
			{
				return this._cachedCellPresenterStyleSelector;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00085334 File Offset: 0x00083534
		private static void OnCellValuePresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellValuePresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0008535C File Offset: 0x0008355C
		private static bool ValidateCellValuePresenterStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), "FieldSettings.CellValuePresenterStyle");
			return true;
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00085390 File Offset: 0x00083590
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00085398 File Offset: 0x00083598
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CellValuePresenterStyle
		{
			get
			{
				return this._cachedCellValuePresenterStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleProperty, value);
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000853A8 File Offset: 0x000835A8
		private static void OnCellValuePresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellValuePresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000853CE File Offset: 0x000835CE
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x000853D6 File Offset: 0x000835D6
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.StyleSelector CellValuePresenterStyleSelector
		{
			get
			{
				return this._cachedCellValuePresenterStyleSelector;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000853E4 File Offset: 0x000835E4
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x000853EC File Offset: 0x000835EC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? CellVisibilityWhenGrouped
		{
			get
			{
				return this._cachedCellVisibilityWhenGrouped;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellVisibilityWhenGroupedProperty, value);
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00085400 File Offset: 0x00083600
		private static void OnCellVisibilityWhenGroupedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Visibility? cachedCellVisibilityWhenGrouped = (global::System.Windows.Visibility?)e.NewValue;
			fieldSettings._cachedCellVisibilityWhenGrouped = cachedCellVisibilityWhenGrouped;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00085428 File Offset: 0x00083628
		private static void OnCellWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellWidth = (double)e.NewValue;
			fieldSettings._cachedCellWidth = cachedCellWidth;
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00085450 File Offset: 0x00083650
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00085458 File Offset: 0x00083658
		[global::System.ComponentModel.Bindable(true)]
		public double CellWidth
		{
			get
			{
				return this._cachedCellWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CellWidthProperty, value);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0008546C File Offset: 0x0008366C
		private static void OnCollapseWhenEmptyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedCollapseWhenEmpty = (bool?)e.NewValue;
			fieldSettings._cachedCollapseWhenEmpty = cachedCollapseWhenEmpty;
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00085494 File Offset: 0x00083694
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0008549C File Offset: 0x0008369C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? CollapseWhenEmpty
		{
			get
			{
				return this._cachedCollapseWhenEmpty;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.CollapseWhenEmptyProperty, value);
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000854AF File Offset: 0x000836AF
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x000854C1 File Offset: 0x000836C1
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger DataItemUpdateTrigger
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataItemUpdateTriggerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataItemUpdateTriggerProperty, value);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x000854D4 File Offset: 0x000836D4
		private static object CoerceDataValueChangedHistoryLimit(global::System.Windows.DependencyObject target, object value)
		{
			if (value == null)
			{
				return null;
			}
			int? num = value as int?;
			if (num != null && num.Value < 0)
			{
				return 0;
			}
			return value;
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x0008550D File Offset: 0x0008370D
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00085524 File Offset: 0x00083724
		[global::System.ComponentModel.Bindable(true)]
		public int? DataValueChangedHistoryLimit
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedHistoryLimitProperty) as int?;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedHistoryLimitProperty, value);
			}
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00085537 File Offset: 0x00083737
		private static void OnDataValueChangedNotificationsActiveChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00085539 File Offset: 0x00083739
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00085550 File Offset: 0x00083750
		[global::System.ComponentModel.Bindable(true)]
		public bool? DataValueChangedNotificationsActive
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedNotificationsActiveProperty) as bool?;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedNotificationsActiveProperty, value);
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00085563 File Offset: 0x00083763
		private static void OnDataValueChangedScopeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00085565 File Offset: 0x00083765
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00085577 File Offset: 0x00083777
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataValueChangedScope DataValueChangedScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataValueChangedScope)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedScopeProperty, value);
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0008558A File Offset: 0x0008378A
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00085592 File Offset: 0x00083792
		public global::System.Type EditAsType
		{
			get
			{
				return this._cachedEditAsType;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.EditAsTypeProperty, value);
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000855A0 File Offset: 0x000837A0
		private static void OnEditAsTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Type cachedEditAsType = (global::System.Type)e.NewValue;
			fieldSettings._cachedEditAsType = cachedEditAsType;
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000855C8 File Offset: 0x000837C8
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x000855D0 File Offset: 0x000837D0
		public global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate EditModeBehaviorOnDataUpdate
		{
			get
			{
				return this._cachedEditModeBehaviorOnDataUpdate;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.EditModeBehaviorOnDataUpdateProperty, value);
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000855E4 File Offset: 0x000837E4
		private static void OnEditModeBehaviorOnDataUpdateChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate cachedEditModeBehaviorOnDataUpdate = (global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate)e.NewValue;
			fieldSettings._cachedEditModeBehaviorOnDataUpdate = cachedEditModeBehaviorOnDataUpdate;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0008560C File Offset: 0x0008380C
		private static void OnEditorStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Style cachedEditorStyle = (global::System.Windows.Style)e.NewValue;
			fieldSettings._cachedEditorStyle = cachedEditorStyle;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00085634 File Offset: 0x00083834
		private static bool ValidateEditorStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.Editors.ValueEditor), "FieldSettings.EditorStyle");
			if (style.TargetType != null && style.TargetType.IsInterface)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_EditorStyleTargetTypeMissingOrInvalid", new object[0]), "EditorStyle");
			}
			return true;
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0008569E File Offset: 0x0008389E
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x000856A6 File Offset: 0x000838A6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style EditorStyle
		{
			get
			{
				return this._cachedEditorStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleProperty, value);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000856B4 File Offset: 0x000838B4
		private static void OnEditorStyleSelectorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Controls.StyleSelector cachedEditorStyleSelector = (global::System.Windows.Controls.StyleSelector)e.NewValue;
			fieldSettings._cachedEditorStyleSelector = cachedEditorStyleSelector;
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000856DC File Offset: 0x000838DC
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x000856E4 File Offset: 0x000838E4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector EditorStyleSelector
		{
			get
			{
				return this._cachedEditorStyleSelector;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000856F4 File Offset: 0x000838F4
		private static void OnEditorTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Type cachedEditorType = (global::System.Type)e.NewValue;
			fieldSettings._cachedEditorType = cachedEditorType;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0008571C File Offset: 0x0008391C
		private static bool ValidateEditorType(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Type c = value as global::System.Type;
			if (!typeof(global::Infragistics.Windows.Editors.ValueEditor).IsAssignableFrom(c))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_20"), "EditorType");
			}
			return true;
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0008575D File Offset: 0x0008395D
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00085765 File Offset: 0x00083965
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Type EditorType
		{
			get
			{
				return this._cachedEditorType;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.EditorTypeProperty, value);
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00085773 File Offset: 0x00083973
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00085785 File Offset: 0x00083985
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator ExcelStyleFilterSearchOperator
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExcelStyleFilterSearchOperatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExcelStyleFilterSearchOperatorProperty, value);
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00085798 File Offset: 0x00083998
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x000857AA File Offset: 0x000839AA
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ExpandedCellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleProperty, value);
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000857B8 File Offset: 0x000839B8
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x000857CA File Offset: 0x000839CA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector ExpandedCellStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000857D8 File Offset: 0x000839D8
		private static bool IsExpandableFieldRecordExpansionModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode), value);
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000857EA File Offset: 0x000839EA
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x000857FC File Offset: 0x000839FC
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode ExpandableFieldRecordExpansionMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordExpansionModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordExpansionModeProperty, value);
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0008580F File Offset: 0x00083A0F
		private static bool IsExpandableFieldRecordHeaderDisplayModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode), value);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00085821 File Offset: 0x00083A21
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00085833 File Offset: 0x00083A33
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode ExpandableFieldRecordHeaderDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordHeaderDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordHeaderDisplayModeProperty, value);
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00085846 File Offset: 0x00083A46
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00085858 File Offset: 0x00083A58
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ExpandableFieldRecordPresenterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleProperty, value);
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00085866 File Offset: 0x00083A66
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00085878 File Offset: 0x00083A78
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector ExpandableFieldRecordPresenterStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00085888 File Offset: 0x00083A88
		private static bool ValidateFilterCellValuePresenterStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter), "FieldSettings.FilterCellValuePresenterStyle");
			return true;
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000858BC File Offset: 0x00083ABC
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x000858CE File Offset: 0x00083ACE
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style FilterCellValuePresenterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterCellValuePresenterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterCellValuePresenterStyleProperty, value);
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000858DC File Offset: 0x00083ADC
		private static void OnFilterCellEditorStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Style cachedFilterCellEditorStyle = (global::System.Windows.Style)e.NewValue;
			fieldSettings._cachedFilterCellEditorStyle = cachedFilterCellEditorStyle;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00085904 File Offset: 0x00083B04
		private static bool ValidateFilterCellEditorStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.Editors.ValueEditor), "FieldSettings.FilterCellEditorStyle");
			return true;
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00085938 File Offset: 0x00083B38
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00085940 File Offset: 0x00083B40
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style FilterCellEditorStyle
		{
			get
			{
				return this._cachedFilterCellEditorStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterCellEditorStyleProperty, value);
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0008594E File Offset: 0x00083B4E
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00085960 File Offset: 0x00083B60
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? FilterClearButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterClearButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterClearButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00085973 File Offset: 0x00083B73
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x00085985 File Offset: 0x00083B85
		[global::System.ComponentModel.Bindable(true)]
		public int? FilterConditionOptimizationThreshold
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterConditionOptimizationThresholdProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterConditionOptimizationThresholdProperty, value);
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00085998 File Offset: 0x00083B98
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x000859AA File Offset: 0x00083BAA
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger FilterEvaluationTrigger
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterEvaluationTriggerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterEvaluationTriggerProperty, value);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000859BD File Offset: 0x00083BBD
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x000859CF File Offset: 0x00083BCF
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType FilterLabelIconDropDownType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterLabelIconDropDownTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterLabelIconDropDownTypeProperty, value);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000859E2 File Offset: 0x00083BE2
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x000859F4 File Offset: 0x00083BF4
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterOperandUIType FilterOperandUIType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterOperandUIType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperandUITypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperandUITypeProperty, value);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00085A07 File Offset: 0x00083C07
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x00085A19 File Offset: 0x00083C19
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperator>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ComparisonOperator? FilterOperatorDefaultValue
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ComparisonOperator?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperatorDefaultValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperatorDefaultValueProperty, value);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00085A2C File Offset: 0x00083C2C
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00085A3E File Offset: 0x00083C3E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperatorFlags>))]
		public global::Infragistics.Windows.Controls.ComparisonOperatorFlags? FilterOperatorDropDownItems
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ComparisonOperatorFlags?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperatorDropDownItemsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterOperatorDropDownItemsProperty, value);
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00085A51 File Offset: 0x00083C51
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00085A63 File Offset: 0x00083C63
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldSortComparisonType FilterStringComparisonType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldSortComparisonType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterStringComparisonTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterStringComparisonTypeProperty, value);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00085A76 File Offset: 0x00083C76
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00085A88 File Offset: 0x00083C88
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IComparer FilterComparer
		{
			get
			{
				return (global::System.Collections.IComparer)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterComparerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterComparerProperty, value);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00085A96 File Offset: 0x00083C96
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00085AA8 File Offset: 0x00083CA8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluator
		{
			get
			{
				return (global::Infragistics.Windows.Controls.IFilterEvaluator)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterEvaluatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterEvaluatorProperty, value);
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00085AB8 File Offset: 0x00083CB8
		private static void OnForceCellVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedForceCellVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedForceCellVirtualization = cachedForceCellVirtualization;
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00085AE0 File Offset: 0x00083CE0
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00085AE8 File Offset: 0x00083CE8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? ForceCellVirtualization
		{
			get
			{
				return this._cachedForceCellVirtualization;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.ForceCellVirtualizationProperty, value);
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00085AFB File Offset: 0x00083CFB
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00085B0D File Offset: 0x00083D0D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.IComparer GroupByComparer
		{
			get
			{
				return (global::System.Collections.IComparer)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByComparerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByComparerProperty, value);
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00085B1B File Offset: 0x00083D1B
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00085B2D File Offset: 0x00083D2D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.IGroupByEvaluator GroupByEvaluator
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.IGroupByEvaluator)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByEvaluatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByEvaluatorProperty, value);
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00085B3B File Offset: 0x00083D3B
		private static bool IsGroupByModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.FieldGroupByMode), value);
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00085B4D File Offset: 0x00083D4D
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00085B5F File Offset: 0x00083D5F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldGroupByMode GroupByMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldGroupByMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByModeProperty, value);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00085B72 File Offset: 0x00083D72
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00085B84 File Offset: 0x00083D84
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style GroupByRecordPresenterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleProperty, value);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00085B92 File Offset: 0x00083D92
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00085BA4 File Offset: 0x00083DA4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector GroupByRecordPresenterStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00085BB2 File Offset: 0x00083DB2
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00085BC4 File Offset: 0x00083DC4
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLength? Height
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldLength?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.HeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.HeightProperty, value);
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00085BD8 File Offset: 0x00083DD8
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::Infragistics.Windows.Editors.InvalidValueBehavior cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)e.NewValue;
			fieldSettings._cachedInvalidValueBehavior = cachedInvalidValueBehavior;
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00085C00 File Offset: 0x00083E00
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00085C08 File Offset: 0x00083E08
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehavior
		{
			get
			{
				return this._cachedInvalidValueBehavior;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.InvalidValueBehaviorProperty, value);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00085C1B File Offset: 0x00083E1B
		private static bool IsLabelClickActionValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.LabelClickAction), value);
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00085C2D File Offset: 0x00083E2D
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00085C3F File Offset: 0x00083E3F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.LabelClickAction LabelClickAction
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.LabelClickAction)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelClickActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelClickActionProperty, value);
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00085C54 File Offset: 0x00083E54
		private static void OnLabelHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelHeight = (double)e.NewValue;
			fieldSettings._cachedLabelHeight = cachedLabelHeight;
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00085C7C File Offset: 0x00083E7C
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00085C84 File Offset: 0x00083E84
		[global::System.ComponentModel.Bindable(true)]
		public double LabelHeight
		{
			get
			{
				return this._cachedLabelHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelHeightProperty, value);
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00085C98 File Offset: 0x00083E98
		private static void OnLabelMaxHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMaxHeight = (double)e.NewValue;
			fieldSettings._cachedLabelMaxHeight = cachedLabelMaxHeight;
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00085CC0 File Offset: 0x00083EC0
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00085CC8 File Offset: 0x00083EC8
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMaxHeight
		{
			get
			{
				return this._cachedLabelMaxHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelMaxHeightProperty, value);
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00085CDC File Offset: 0x00083EDC
		private static void OnLabelMaxWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMaxWidth = (double)e.NewValue;
			fieldSettings._cachedLabelMaxWidth = cachedLabelMaxWidth;
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00085D04 File Offset: 0x00083F04
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x00085D0C File Offset: 0x00083F0C
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMaxWidth
		{
			get
			{
				return this._cachedLabelMaxWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelMaxWidthProperty, value);
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00085D20 File Offset: 0x00083F20
		private static void OnLabelMinHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMinHeight = (double)e.NewValue;
			fieldSettings._cachedLabelMinHeight = cachedLabelMinHeight;
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00085D48 File Offset: 0x00083F48
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00085D50 File Offset: 0x00083F50
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMinHeight
		{
			get
			{
				return this._cachedLabelMinHeight;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelMinHeightProperty, value);
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00085D64 File Offset: 0x00083F64
		private static void OnLabelMinWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMinWidth = (double)e.NewValue;
			fieldSettings._cachedLabelMinWidth = cachedLabelMinWidth;
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00085D8C File Offset: 0x00083F8C
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00085D94 File Offset: 0x00083F94
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMinWidth
		{
			get
			{
				return this._cachedLabelMinWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelMinWidthProperty, value);
			}
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00085DA8 File Offset: 0x00083FA8
		private static void OnLabelPresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedLabelPresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00085DD0 File Offset: 0x00083FD0
		private static bool ValidateLabelPresenterStyle(object value)
		{
			if (value == null)
			{
				return true;
			}
			global::System.Windows.Style style = value as global::System.Windows.Style;
			if (style == null)
			{
				return false;
			}
			global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), "FieldSettings.LabelPresenterStyle");
			return true;
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00085E04 File Offset: 0x00084004
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00085E0C File Offset: 0x0008400C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style LabelPresenterStyle
		{
			get
			{
				return this._cachedLabelPresenterStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleProperty, value);
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00085E1C File Offset: 0x0008401C
		private static void OnLabelPresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedLabelPresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00085E42 File Offset: 0x00084042
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00085E4A File Offset: 0x0008404A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector LabelPresenterStyleSelector
		{
			get
			{
				return this._cachedLabelPresenterStyleSelector;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00085E58 File Offset: 0x00084058
		private static void OnLabelTextAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextAlignment? cachedLabelTextAlignment = (global::System.Windows.TextAlignment?)e.NewValue;
			fieldSettings._cachedLabelTextAlignment = cachedLabelTextAlignment;
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00085E80 File Offset: 0x00084080
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x00085E88 File Offset: 0x00084088
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextAlignment>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextAlignment? LabelTextAlignment
		{
			get
			{
				return this._cachedLabelTextAlignment;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelTextAlignmentProperty, value);
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00085E9C File Offset: 0x0008409C
		private static void OnLabelTextTrimmingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextTrimming? cachedLabelTextTrimming = (global::System.Windows.TextTrimming?)e.NewValue;
			fieldSettings._cachedLabelTextTrimming = cachedLabelTextTrimming;
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00085EC4 File Offset: 0x000840C4
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00085ECC File Offset: 0x000840CC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextTrimming>))]
		public global::System.Windows.TextTrimming? LabelTextTrimming
		{
			get
			{
				return this._cachedLabelTextTrimming;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelTextTrimmingProperty, value);
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00085EE0 File Offset: 0x000840E0
		private static void OnLabelTextWrappingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextWrapping? cachedLabelTextWrapping = (global::System.Windows.TextWrapping?)e.NewValue;
			fieldSettings._cachedLabelTextWrapping = cachedLabelTextWrapping;
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00085F08 File Offset: 0x00084108
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x00085F10 File Offset: 0x00084110
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextWrapping>))]
		public global::System.Windows.TextWrapping? LabelTextWrapping
		{
			get
			{
				return this._cachedLabelTextWrapping;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelTextWrappingProperty, value);
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00085F24 File Offset: 0x00084124
		private static void OnLabelWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelWidth = (double)e.NewValue;
			fieldSettings._cachedLabelWidth = cachedLabelWidth;
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x00085F4C File Offset: 0x0008414C
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00085F54 File Offset: 0x00084154
		[global::System.ComponentModel.Bindable(true)]
		public double LabelWidth
		{
			get
			{
				return this._cachedLabelWidth;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.LabelWidthProperty, value);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00085F67 File Offset: 0x00084167
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x00085F79 File Offset: 0x00084179
		public global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior NonSpecificNotificationBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.NonSpecificNotificationBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.NonSpecificNotificationBehaviorProperty, value);
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00085F8C File Offset: 0x0008418C
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x00085F9E File Offset: 0x0008419E
		[global::System.ComponentModel.Bindable(true)]
		public bool? SupportDataErrorInfo
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SupportDataErrorInfoProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SupportDataErrorInfoProperty, value);
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00085FB1 File Offset: 0x000841B1
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00085FC3 File Offset: 0x000841C3
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.IComparer SortComparer
		{
			get
			{
				return (global::System.Collections.IComparer)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SortComparerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SortComparerProperty, value);
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00085FD1 File Offset: 0x000841D1
		private static bool IsSortComparisonTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), value);
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00085FE3 File Offset: 0x000841E3
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00085FF5 File Offset: 0x000841F5
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldSortComparisonType SortComparisonType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldSortComparisonType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SortComparisonTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SortComparisonTypeProperty, value);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00086008 File Offset: 0x00084208
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0008601A File Offset: 0x0008421A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas? SummaryDisplayArea
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SummaryDisplayAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SummaryDisplayAreaProperty, value);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0008602D File Offset: 0x0008422D
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0008603F File Offset: 0x0008423F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryUIType SummaryUIType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryUIType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SummaryUITypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldSettings.SummaryUITypeProperty, value);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00086052 File Offset: 0x00084252
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00086064 File Offset: 0x00084264
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLength? Width
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldLength?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.WidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.WidthProperty, value);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00086077 File Offset: 0x00084277
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0008607F File Offset: 0x0008427F
		internal bool HasFieldBinding { get; set; }

		// Token: 0x06001E1F RID: 7711 RVA: 0x00086088 File Offset: 0x00084288
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00086090 File Offset: 0x00084290
		private static bool ValidatePixelValue(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value >= 0.0);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000860C0 File Offset: 0x000842C0
		internal void ResetExcludedSettings(global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = options as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			if (reportViewBase != null && reportViewBase.ExcludeEditorSettings)
			{
				this.EditorType = typeof(global::Infragistics.Windows.Editors.XamTextEditor);
				this.EditorStyle = null;
				this.EditorStyleSelector = null;
			}
			if (reportViewBase != null && reportViewBase.ExcludeCellValuePresenterStyles)
			{
				this.CellValuePresenterStyle = null;
				this.CellValuePresenterStyleSelector = null;
			}
			if (reportViewBase != null && reportViewBase.ExcludeLabelPresenterStyles)
			{
				this.LabelPresenterStyle = null;
				this.LabelPresenterStyleSelector = null;
			}
			if (options.ExcludeSummaries)
			{
				this.AllowSummaries = new bool?(false);
				this.SummaryUIType = global::Infragistics.Windows.DataPresenter.SummaryUIType.Default;
				this.SummaryDisplayArea = new global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas.None);
			}
		}

		// Token: 0x04000C53 RID: 3155
		public static readonly global::System.Windows.DependencyProperty AllowCellVirtualizationProperty = global::System.Windows.DependencyProperty.Register("AllowCellVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowCellVirtualizationChanged)));

		// Token: 0x04000C54 RID: 3156
		private bool? _cachedAllowCellVirtualization;

		// Token: 0x04000C55 RID: 3157
		public static readonly global::System.Windows.DependencyProperty AllowEditProperty = global::System.Windows.DependencyProperty.Register("AllowEdit", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C56 RID: 3158
		public static readonly global::System.Windows.DependencyProperty AllowFixingProperty = global::System.Windows.DependencyProperty.Register("AllowFixing", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldFixing), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowFixingChanged)));

		// Token: 0x04000C57 RID: 3159
		public static readonly global::System.Windows.DependencyProperty AllowGroupByProperty = global::System.Windows.DependencyProperty.Register("AllowGroupBy", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C58 RID: 3160
		public static readonly global::System.Windows.DependencyProperty AllowHidingProperty = global::System.Windows.DependencyProperty.Register("AllowHiding", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldHiding), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C59 RID: 3161
		public static readonly global::System.Windows.DependencyProperty AllowLabelVirtualizationProperty = global::System.Windows.DependencyProperty.Register("AllowLabelVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowLabelVirtualizationChanged)));

		// Token: 0x04000C5A RID: 3162
		private bool? _cachedAllowLabelVirtualization;

		// Token: 0x04000C5B RID: 3163
		public static readonly global::System.Windows.DependencyProperty AllowRecordFilteringProperty = global::System.Windows.DependencyProperty.Register("AllowRecordFiltering", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C5C RID: 3164
		public static readonly global::System.Windows.DependencyProperty AllowResizeProperty = global::System.Windows.DependencyProperty.Register("AllowResize", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5D RID: 3165
		public static readonly global::System.Windows.DependencyProperty AllowSummariesProperty = global::System.Windows.DependencyProperty.Register("AllowSummaries", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5E RID: 3166
		public static readonly global::System.Windows.DependencyProperty AutoSizeOptionsProperty = global::System.Windows.DependencyProperty.Register("AutoSizeOptions", typeof(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C5F RID: 3167
		public static readonly global::System.Windows.DependencyProperty AutoSizeScopeProperty = global::System.Windows.DependencyProperty.Register("AutoSizeScope", typeof(global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.Default));

		// Token: 0x04000C60 RID: 3168
		public static readonly global::System.Windows.DependencyProperty CellClickActionProperty = global::System.Windows.DependencyProperty.Register("CellClickAction", typeof(global::Infragistics.Windows.DataPresenter.CellClickAction), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellClickAction.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsCellClickActionValid));

		// Token: 0x04000C61 RID: 3169
		public static readonly global::System.Windows.DependencyProperty CellContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("CellContentAlignment", typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellContentAlignmentChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsCellContentAlignmentValid));

		// Token: 0x04000C62 RID: 3170
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cachedCellContentAlignment;

		// Token: 0x04000C63 RID: 3171
		public static readonly global::System.Windows.DependencyProperty CellHeightProperty = global::System.Windows.DependencyProperty.Register("CellHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C64 RID: 3172
		private double _cachedCellHeight = double.NaN;

		// Token: 0x04000C65 RID: 3173
		public static readonly global::System.Windows.DependencyProperty CellMaxHeightProperty = global::System.Windows.DependencyProperty.Register("CellMaxHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMaxHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C66 RID: 3174
		private double _cachedCellMaxHeight = double.NaN;

		// Token: 0x04000C67 RID: 3175
		public static readonly global::System.Windows.DependencyProperty CellMaxWidthProperty = global::System.Windows.DependencyProperty.Register("CellMaxWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMaxWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C68 RID: 3176
		private double _cachedCellMaxWidth = double.NaN;

		// Token: 0x04000C69 RID: 3177
		public static readonly global::System.Windows.DependencyProperty CellMinHeightProperty = global::System.Windows.DependencyProperty.Register("CellMinHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMinHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C6A RID: 3178
		private double _cachedCellMinHeight = double.NaN;

		// Token: 0x04000C6B RID: 3179
		public static readonly global::System.Windows.DependencyProperty CellMinWidthProperty = global::System.Windows.DependencyProperty.Register("CellMinWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMinWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C6C RID: 3180
		private double _cachedCellMinWidth = double.NaN;

		// Token: 0x04000C6D RID: 3181
		public static readonly global::System.Windows.DependencyProperty CellPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("CellPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellPresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateCellPresenterStyle));

		// Token: 0x04000C6E RID: 3182
		private global::System.Windows.Style _cachedCellPresenterStyle;

		// Token: 0x04000C6F RID: 3183
		public static readonly global::System.Windows.DependencyProperty CellPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CellPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellPresenterStyleSelectorChanged)));

		// Token: 0x04000C70 RID: 3184
		private global::System.Windows.Controls.StyleSelector _cachedCellPresenterStyleSelector;

		// Token: 0x04000C71 RID: 3185
		public static readonly global::System.Windows.DependencyProperty CellValuePresenterStyleProperty = global::System.Windows.DependencyProperty.Register("CellValuePresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellValuePresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateCellValuePresenterStyle));

		// Token: 0x04000C72 RID: 3186
		private global::System.Windows.Style _cachedCellValuePresenterStyle;

		// Token: 0x04000C73 RID: 3187
		public static readonly global::System.Windows.DependencyProperty CellValuePresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CellValuePresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellValuePresenterStyleSelectorChanged)));

		// Token: 0x04000C74 RID: 3188
		private global::System.Windows.Controls.StyleSelector _cachedCellValuePresenterStyleSelector;

		// Token: 0x04000C75 RID: 3189
		public static readonly global::System.Windows.DependencyProperty CellVisibilityWhenGroupedProperty = global::System.Windows.DependencyProperty.Register("CellVisibilityWhenGrouped", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellVisibilityWhenGroupedChanged), null));

		// Token: 0x04000C76 RID: 3190
		private global::System.Windows.Visibility? _cachedCellVisibilityWhenGrouped;

		// Token: 0x04000C77 RID: 3191
		public static readonly global::System.Windows.DependencyProperty CellWidthProperty = global::System.Windows.DependencyProperty.Register("CellWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000C78 RID: 3192
		private double _cachedCellWidth = double.NaN;

		// Token: 0x04000C79 RID: 3193
		public static readonly global::System.Windows.DependencyProperty CollapseWhenEmptyProperty = global::System.Windows.DependencyProperty.Register("CollapseWhenEmpty", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCollapseWhenEmptyChanged)));

		// Token: 0x04000C7A RID: 3194
		private bool? _cachedCollapseWhenEmpty;

		// Token: 0x04000C7B RID: 3195
		public static readonly global::System.Windows.DependencyProperty DataItemUpdateTriggerProperty = global::System.Windows.DependencyProperty.Register("DataItemUpdateTrigger", typeof(global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C7C RID: 3196
		public static readonly global::System.Windows.DependencyProperty DataValueChangedHistoryLimitProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedHistoryLimit", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.CoerceDataValueChangedHistoryLimit)));

		// Token: 0x04000C7D RID: 3197
		public static readonly global::System.Windows.DependencyProperty DataValueChangedNotificationsActiveProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedNotificationsActive", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnDataValueChangedNotificationsActiveChanged)));

		// Token: 0x04000C7E RID: 3198
		public static readonly global::System.Windows.DependencyProperty DataValueChangedScopeProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedScope", typeof(global::Infragistics.Windows.DataPresenter.DataValueChangedScope), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataValueChangedScope.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnDataValueChangedScopeChanged)));

		// Token: 0x04000C7F RID: 3199
		public static readonly global::System.Windows.DependencyProperty EditAsTypeProperty = global::System.Windows.DependencyProperty.Register("EditAsType", typeof(global::System.Type), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditAsTypeChanged)));

		// Token: 0x04000C80 RID: 3200
		private global::System.Type _cachedEditAsType;

		// Token: 0x04000C81 RID: 3201
		public static readonly global::System.Windows.DependencyProperty EditModeBehaviorOnDataUpdateProperty = global::System.Windows.DependencyProperty.Register("EditModeBehaviorOnDataUpdate", typeof(global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditModeBehaviorOnDataUpdateChanged)));

		// Token: 0x04000C82 RID: 3202
		private global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate _cachedEditModeBehaviorOnDataUpdate;

		// Token: 0x04000C83 RID: 3203
		public static readonly global::System.Windows.DependencyProperty EditorStyleProperty = global::System.Windows.DependencyProperty.Register("EditorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateEditorStyle));

		// Token: 0x04000C84 RID: 3204
		private global::System.Windows.Style _cachedEditorStyle;

		// Token: 0x04000C85 RID: 3205
		public static readonly global::System.Windows.DependencyProperty EditorStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("EditorStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorStyleSelectorChanged)));

		// Token: 0x04000C86 RID: 3206
		private global::System.Windows.Controls.StyleSelector _cachedEditorStyleSelector;

		// Token: 0x04000C87 RID: 3207
		public static readonly global::System.Windows.DependencyProperty EditorTypeProperty = global::System.Windows.DependencyProperty.Register("EditorType", typeof(global::System.Type), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorTypeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateEditorType));

		// Token: 0x04000C88 RID: 3208
		private global::System.Type _cachedEditorType;

		// Token: 0x04000C89 RID: 3209
		public static readonly global::System.Windows.DependencyProperty ExcelStyleFilterSearchOperatorProperty = global::System.Windows.DependencyProperty.Register("ExcelStyleFilterSearchOperator", typeof(global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator.Default));

		// Token: 0x04000C8A RID: 3210
		public static readonly global::System.Windows.DependencyProperty ExpandedCellStyleProperty = global::System.Windows.DependencyProperty.Register("ExpandedCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C8B RID: 3211
		public static readonly global::System.Windows.DependencyProperty ExpandedCellStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("ExpandedCellStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C8C RID: 3212
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordExpansionModeProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordExpansionMode", typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsExpandableFieldRecordExpansionModeValid));

		// Token: 0x04000C8D RID: 3213
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordHeaderDisplayModeProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordHeaderDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsExpandableFieldRecordHeaderDisplayModeValid));

		// Token: 0x04000C8E RID: 3214
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C8F RID: 3215
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C90 RID: 3216
		public static readonly global::System.Windows.DependencyProperty FilterCellValuePresenterStyleProperty = global::System.Windows.DependencyProperty.Register("FilterCellValuePresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateFilterCellValuePresenterStyle));

		// Token: 0x04000C91 RID: 3217
		public static readonly global::System.Windows.DependencyProperty FilterCellEditorStyleProperty = global::System.Windows.DependencyProperty.Register("FilterCellEditorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnFilterCellEditorStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateFilterCellEditorStyle));

		// Token: 0x04000C92 RID: 3218
		private global::System.Windows.Style _cachedFilterCellEditorStyle;

		// Token: 0x04000C93 RID: 3219
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("FilterClearButtonVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C94 RID: 3220
		public static readonly global::System.Windows.DependencyProperty FilterConditionOptimizationThresholdProperty = global::System.Windows.DependencyProperty.Register("FilterConditionOptimizationThreshold", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C95 RID: 3221
		public static readonly global::System.Windows.DependencyProperty FilterEvaluationTriggerProperty = global::System.Windows.DependencyProperty.Register("FilterEvaluationTrigger", typeof(global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C96 RID: 3222
		public static readonly global::System.Windows.DependencyProperty FilterLabelIconDropDownTypeProperty = global::System.Windows.DependencyProperty.Register("FilterLabelIconDropDownType", typeof(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.Default));

		// Token: 0x04000C97 RID: 3223
		public static readonly global::System.Windows.DependencyProperty FilterOperandUITypeProperty = global::System.Windows.DependencyProperty.Register("FilterOperandUIType", typeof(global::Infragistics.Windows.DataPresenter.FilterOperandUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C98 RID: 3224
		public static readonly global::System.Windows.DependencyProperty FilterOperatorDefaultValueProperty = global::System.Windows.DependencyProperty.Register("FilterOperatorDefaultValue", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C99 RID: 3225
		public static readonly global::System.Windows.DependencyProperty FilterOperatorDropDownItemsProperty = global::System.Windows.DependencyProperty.Register("FilterOperatorDropDownItems", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorFlags?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C9A RID: 3226
		public static readonly global::System.Windows.DependencyProperty FilterStringComparisonTypeProperty = global::System.Windows.DependencyProperty.Register("FilterStringComparisonType", typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C9B RID: 3227
		public static readonly global::System.Windows.DependencyProperty FilterComparerProperty = global::System.Windows.DependencyProperty.Register("FilterComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C9C RID: 3228
		public static readonly global::System.Windows.DependencyProperty FilterEvaluatorProperty = global::System.Windows.DependencyProperty.Register("FilterEvaluator", typeof(global::Infragistics.Windows.Controls.IFilterEvaluator), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C9D RID: 3229
		public static readonly global::System.Windows.DependencyProperty ForceCellVirtualizationProperty = global::System.Windows.DependencyProperty.Register("ForceCellVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnForceCellVirtualizationChanged)));

		// Token: 0x04000C9E RID: 3230
		private bool? _cachedForceCellVirtualization;

		// Token: 0x04000C9F RID: 3231
		public static readonly global::System.Windows.DependencyProperty GroupByComparerProperty = global::System.Windows.DependencyProperty.Register("GroupByComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000CA0 RID: 3232
		public static readonly global::System.Windows.DependencyProperty GroupByEvaluatorProperty = global::System.Windows.DependencyProperty.Register("GroupByEvaluator", typeof(global::Infragistics.Windows.DataPresenter.IGroupByEvaluator), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000CA1 RID: 3233
		public static readonly global::System.Windows.DependencyProperty GroupByModeProperty = global::System.Windows.DependencyProperty.Register("GroupByMode", typeof(global::Infragistics.Windows.DataPresenter.FieldGroupByMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsGroupByModeValid));

		// Token: 0x04000CA2 RID: 3234
		public static readonly global::System.Windows.DependencyProperty GroupByRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000CA3 RID: 3235
		public static readonly global::System.Windows.DependencyProperty GroupByRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("GroupByRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000CA4 RID: 3236
		public static readonly global::System.Windows.DependencyProperty HeightProperty = global::System.Windows.DependencyProperty.Register("Height", typeof(global::Infragistics.Windows.DataPresenter.FieldLength?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CA5 RID: 3237
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty = global::System.Windows.DependencyProperty.Register("InvalidValueBehavior", typeof(global::Infragistics.Windows.Editors.InvalidValueBehavior), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.InvalidValueBehavior.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnInvalidValueBehaviorChanged)));

		// Token: 0x04000CA6 RID: 3238
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _cachedInvalidValueBehavior;

		// Token: 0x04000CA7 RID: 3239
		public static readonly global::System.Windows.DependencyProperty LabelClickActionProperty = global::System.Windows.DependencyProperty.Register("LabelClickAction", typeof(global::Infragistics.Windows.DataPresenter.LabelClickAction), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelClickAction.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsLabelClickActionValid));

		// Token: 0x04000CA8 RID: 3240
		public static readonly global::System.Windows.DependencyProperty LabelHeightProperty = global::System.Windows.DependencyProperty.Register("LabelHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CA9 RID: 3241
		private double _cachedLabelHeight = double.NaN;

		// Token: 0x04000CAA RID: 3242
		public static readonly global::System.Windows.DependencyProperty LabelMaxHeightProperty = global::System.Windows.DependencyProperty.Register("LabelMaxHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMaxHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CAB RID: 3243
		private double _cachedLabelMaxHeight = double.NaN;

		// Token: 0x04000CAC RID: 3244
		public static readonly global::System.Windows.DependencyProperty LabelMaxWidthProperty = global::System.Windows.DependencyProperty.Register("LabelMaxWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMaxWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CAD RID: 3245
		private double _cachedLabelMaxWidth = double.NaN;

		// Token: 0x04000CAE RID: 3246
		public static readonly global::System.Windows.DependencyProperty LabelMinHeightProperty = global::System.Windows.DependencyProperty.Register("LabelMinHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMinHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CAF RID: 3247
		private double _cachedLabelMinHeight = double.NaN;

		// Token: 0x04000CB0 RID: 3248
		public static readonly global::System.Windows.DependencyProperty LabelMinWidthProperty = global::System.Windows.DependencyProperty.Register("LabelMinWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMinWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CB1 RID: 3249
		private double _cachedLabelMinWidth = double.NaN;

		// Token: 0x04000CB2 RID: 3250
		public static readonly global::System.Windows.DependencyProperty LabelPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("LabelPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelPresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateLabelPresenterStyle));

		// Token: 0x04000CB3 RID: 3251
		private global::System.Windows.Style _cachedLabelPresenterStyle;

		// Token: 0x04000CB4 RID: 3252
		public static readonly global::System.Windows.DependencyProperty LabelPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("LabelPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelPresenterStyleSelectorChanged)));

		// Token: 0x04000CB5 RID: 3253
		private global::System.Windows.Controls.StyleSelector _cachedLabelPresenterStyleSelector;

		// Token: 0x04000CB6 RID: 3254
		public static readonly global::System.Windows.DependencyProperty LabelTextAlignmentProperty = global::System.Windows.DependencyProperty.Register("LabelTextAlignment", typeof(global::System.Windows.TextAlignment?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextAlignmentChanged)));

		// Token: 0x04000CB7 RID: 3255
		private global::System.Windows.TextAlignment? _cachedLabelTextAlignment;

		// Token: 0x04000CB8 RID: 3256
		public static readonly global::System.Windows.DependencyProperty LabelTextTrimmingProperty = global::System.Windows.DependencyProperty.Register("LabelTextTrimming", typeof(global::System.Windows.TextTrimming?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextTrimmingChanged)));

		// Token: 0x04000CB9 RID: 3257
		private global::System.Windows.TextTrimming? _cachedLabelTextTrimming;

		// Token: 0x04000CBA RID: 3258
		public static readonly global::System.Windows.DependencyProperty LabelTextWrappingProperty = global::System.Windows.DependencyProperty.Register("LabelTextWrapping", typeof(global::System.Windows.TextWrapping?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextWrappingChanged)));

		// Token: 0x04000CBB RID: 3259
		private global::System.Windows.TextWrapping? _cachedLabelTextWrapping;

		// Token: 0x04000CBC RID: 3260
		public static readonly global::System.Windows.DependencyProperty LabelWidthProperty = global::System.Windows.DependencyProperty.Register("LabelWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000CBD RID: 3261
		private double _cachedLabelWidth = double.NaN;

		// Token: 0x04000CBE RID: 3262
		public static readonly global::System.Windows.DependencyProperty NonSpecificNotificationBehaviorProperty = global::System.Windows.DependencyProperty.Register("NonSpecificNotificationBehavior", typeof(global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default));

		// Token: 0x04000CBF RID: 3263
		public static readonly global::System.Windows.DependencyProperty SupportDataErrorInfoProperty = global::System.Windows.DependencyProperty.Register("SupportDataErrorInfo", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000CC0 RID: 3264
		public static readonly global::System.Windows.DependencyProperty SortComparerProperty = global::System.Windows.DependencyProperty.Register("SortComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000CC1 RID: 3265
		public static readonly global::System.Windows.DependencyProperty SortComparisonTypeProperty = global::System.Windows.DependencyProperty.Register("SortComparisonType", typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsSortComparisonTypeValid));

		// Token: 0x04000CC2 RID: 3266
		public static readonly global::System.Windows.DependencyProperty SummaryDisplayAreaProperty = global::System.Windows.DependencyProperty.Register("SummaryDisplayArea", typeof(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000CC3 RID: 3267
		public static readonly global::System.Windows.DependencyProperty SummaryUITypeProperty = global::System.Windows.DependencyProperty.Register("SummaryUIType", typeof(global::Infragistics.Windows.DataPresenter.SummaryUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SummaryUIType.Default));

		// Token: 0x04000CC4 RID: 3268
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(global::Infragistics.Windows.DataPresenter.FieldLength?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
