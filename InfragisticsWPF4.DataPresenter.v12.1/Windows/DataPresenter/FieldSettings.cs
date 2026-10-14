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
	// Token: 0x020001BD RID: 445
	[global::System.Windows.StyleTypedProperty(Property = "CellValuePresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter))]
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	[global::System.Windows.StyleTypedProperty(Property = "CellPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.CellPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "LabelPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "EditorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.ValueEditor))]
	[global::System.Windows.StyleTypedProperty(Property = "ExpandedCellStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ExpandableFieldRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))]
	[global::System.Windows.StyleTypedProperty(Property = "GroupByRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord))]
	[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.CloneObject)]
	[global::System.Windows.StyleTypedProperty(Property = "FilterCellValuePresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "FilterCellEditorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.ValueEditor))]
	public class FieldSettings : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x06001966 RID: 6502 RVA: 0x0007061F File Offset: 0x0006E81F
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			base.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0007063C File Offset: 0x0006E83C
		private static void OnAllowCellVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedAllowCellVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedAllowCellVirtualization = cachedAllowCellVirtualization;
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00070664 File Offset: 0x0006E864
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0007066C File Offset: 0x0006E86C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
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

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0007067F File Offset: 0x0006E87F
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00070691 File Offset: 0x0006E891
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x0600196C RID: 6508 RVA: 0x000706A4 File Offset: 0x0006E8A4
		private static void OnAllowFixingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x000706A6 File Offset: 0x0006E8A6
		// (set) Token: 0x0600196E RID: 6510 RVA: 0x000706B8 File Offset: 0x0006E8B8
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

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x000706CB File Offset: 0x0006E8CB
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x000706DD File Offset: 0x0006E8DD
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000706F0 File Offset: 0x0006E8F0
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x00070702 File Offset: 0x0006E902
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

		// Token: 0x06001973 RID: 6515 RVA: 0x00070715 File Offset: 0x0006E915
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowHiding()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty, this);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00070722 File Offset: 0x0006E922
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowHiding()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00070730 File Offset: 0x0006E930
		private static void OnAllowLabelVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedAllowLabelVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedAllowLabelVirtualization = cachedAllowLabelVirtualization;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x00070758 File Offset: 0x0006E958
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x00070760 File Offset: 0x0006E960
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00070773 File Offset: 0x0006E973
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x00070785 File Offset: 0x0006E985
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00070798 File Offset: 0x0006E998
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x000707AA File Offset: 0x0006E9AA
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x000707BD File Offset: 0x0006E9BD
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x000707CF File Offset: 0x0006E9CF
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

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x000707E2 File Offset: 0x0006E9E2
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x000707F4 File Offset: 0x0006E9F4
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00070807 File Offset: 0x0006EA07
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00070819 File Offset: 0x0006EA19
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

		// Token: 0x06001982 RID: 6530 RVA: 0x0007082C File Offset: 0x0006EA2C
		private static bool IsCellClickActionValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.CellClickAction), value);
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x0007083E File Offset: 0x0006EA3E
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x00070850 File Offset: 0x0006EA50
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

		// Token: 0x06001985 RID: 6533 RVA: 0x00070863 File Offset: 0x0006EA63
		private static bool IsCellContentAlignmentValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), value);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00070878 File Offset: 0x0006EA78
		private static void OnCellContentAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.CellContentAlignment cachedCellContentAlignment = (global::Infragistics.Windows.DataPresenter.CellContentAlignment)e.NewValue;
			fieldSettings._cachedCellContentAlignment = cachedCellContentAlignment;
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x000708A0 File Offset: 0x0006EAA0
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x000708A8 File Offset: 0x0006EAA8
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

		// Token: 0x06001989 RID: 6537 RVA: 0x000708BC File Offset: 0x0006EABC
		private static void OnCellHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellHeight = (double)e.NewValue;
			fieldSettings._cachedCellHeight = cachedCellHeight;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000708E4 File Offset: 0x0006EAE4
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x000708EC File Offset: 0x0006EAEC
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

		// Token: 0x0600198C RID: 6540 RVA: 0x00070900 File Offset: 0x0006EB00
		private static void OnCellMaxHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMaxHeight = (double)e.NewValue;
			fieldSettings._cachedCellMaxHeight = cachedCellMaxHeight;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00070928 File Offset: 0x0006EB28
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00070930 File Offset: 0x0006EB30
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

		// Token: 0x0600198F RID: 6543 RVA: 0x00070944 File Offset: 0x0006EB44
		private static void OnCellMaxWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMaxWidth = (double)e.NewValue;
			fieldSettings._cachedCellMaxWidth = cachedCellMaxWidth;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0007096C File Offset: 0x0006EB6C
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x00070974 File Offset: 0x0006EB74
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

		// Token: 0x06001992 RID: 6546 RVA: 0x00070988 File Offset: 0x0006EB88
		private static void OnCellMinHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMinHeight = (double)e.NewValue;
			fieldSettings._cachedCellMinHeight = cachedCellMinHeight;
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x000709B0 File Offset: 0x0006EBB0
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x000709B8 File Offset: 0x0006EBB8
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

		// Token: 0x06001995 RID: 6549 RVA: 0x000709CC File Offset: 0x0006EBCC
		private static void OnCellMinWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellMinWidth = (double)e.NewValue;
			fieldSettings._cachedCellMinWidth = cachedCellMinWidth;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x000709F4 File Offset: 0x0006EBF4
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x000709FC File Offset: 0x0006EBFC
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

		// Token: 0x06001998 RID: 6552 RVA: 0x00070A10 File Offset: 0x0006EC10
		private static void OnCellPresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellPresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00070A38 File Offset: 0x0006EC38
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00070A6C File Offset: 0x0006EC6C
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x00070A74 File Offset: 0x0006EC74
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

		// Token: 0x0600199C RID: 6556 RVA: 0x00070A84 File Offset: 0x0006EC84
		private static void OnCellPresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellPresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00070AAA File Offset: 0x0006ECAA
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00070AB2 File Offset: 0x0006ECB2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x0600199F RID: 6559 RVA: 0x00070AC0 File Offset: 0x0006ECC0
		private static void OnCellValuePresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellValuePresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00070AE8 File Offset: 0x0006ECE8
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

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00070B1C File Offset: 0x0006ED1C
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x00070B24 File Offset: 0x0006ED24
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

		// Token: 0x060019A3 RID: 6563 RVA: 0x00070B34 File Offset: 0x0006ED34
		private static void OnCellValuePresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedCellValuePresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00070B5A File Offset: 0x0006ED5A
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00070B62 File Offset: 0x0006ED62
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00070B70 File Offset: 0x0006ED70
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00070B78 File Offset: 0x0006ED78
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x060019A8 RID: 6568 RVA: 0x00070B8C File Offset: 0x0006ED8C
		private static void OnCellVisibilityWhenGroupedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Visibility? cachedCellVisibilityWhenGrouped = (global::System.Windows.Visibility?)e.NewValue;
			fieldSettings._cachedCellVisibilityWhenGrouped = cachedCellVisibilityWhenGrouped;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		private static void OnCellWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedCellWidth = (double)e.NewValue;
			fieldSettings._cachedCellWidth = cachedCellWidth;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00070BDC File Offset: 0x0006EDDC
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x00070BE4 File Offset: 0x0006EDE4
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

		// Token: 0x060019AC RID: 6572 RVA: 0x00070BF8 File Offset: 0x0006EDF8
		private static void OnCollapseWhenEmptyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedCollapseWhenEmpty = (bool?)e.NewValue;
			fieldSettings._cachedCollapseWhenEmpty = cachedCollapseWhenEmpty;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x00070C20 File Offset: 0x0006EE20
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x00070C28 File Offset: 0x0006EE28
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

		// Token: 0x060019AF RID: 6575 RVA: 0x00070C3C File Offset: 0x0006EE3C
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00070C75 File Offset: 0x0006EE75
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00070C8C File Offset: 0x0006EE8C
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

		// Token: 0x060019B2 RID: 6578 RVA: 0x00070C9F File Offset: 0x0006EE9F
		private static void OnDataValueChangedNotificationsActiveChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00070CA1 File Offset: 0x0006EEA1
		// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00070CB8 File Offset: 0x0006EEB8
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

		// Token: 0x060019B5 RID: 6581 RVA: 0x00070CCB File Offset: 0x0006EECB
		private static void OnDataValueChangedScopeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00070CCD File Offset: 0x0006EECD
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00070CDF File Offset: 0x0006EEDF
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00070CF2 File Offset: 0x0006EEF2
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x00070CFA File Offset: 0x0006EEFA
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

		// Token: 0x060019BA RID: 6586 RVA: 0x00070D08 File Offset: 0x0006EF08
		private static void OnEditAsTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Type cachedEditAsType = (global::System.Type)e.NewValue;
			fieldSettings._cachedEditAsType = cachedEditAsType;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00070D30 File Offset: 0x0006EF30
		private static void OnEditorStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Style cachedEditorStyle = (global::System.Windows.Style)e.NewValue;
			fieldSettings._cachedEditorStyle = cachedEditorStyle;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00070D58 File Offset: 0x0006EF58
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00070DC2 File Offset: 0x0006EFC2
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00070DCA File Offset: 0x0006EFCA
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

		// Token: 0x060019BF RID: 6591 RVA: 0x00070DD8 File Offset: 0x0006EFD8
		private static void OnEditorStyleSelectorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Controls.StyleSelector cachedEditorStyleSelector = (global::System.Windows.Controls.StyleSelector)e.NewValue;
			fieldSettings._cachedEditorStyleSelector = cachedEditorStyleSelector;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00070E00 File Offset: 0x0006F000
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00070E08 File Offset: 0x0006F008
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

		// Token: 0x060019C2 RID: 6594 RVA: 0x00070E18 File Offset: 0x0006F018
		private static void OnEditorTypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Type cachedEditorType = (global::System.Type)e.NewValue;
			fieldSettings._cachedEditorType = cachedEditorType;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00070E40 File Offset: 0x0006F040
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00070E81 File Offset: 0x0006F081
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00070E89 File Offset: 0x0006F089
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00070E97 File Offset: 0x0006F097
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00070EA9 File Offset: 0x0006F0A9
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

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00070EB7 File Offset: 0x0006F0B7
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00070EC9 File Offset: 0x0006F0C9
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

		// Token: 0x060019CA RID: 6602 RVA: 0x00070ED7 File Offset: 0x0006F0D7
		private static bool IsExpandableFieldRecordExpansionModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode), value);
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00070EE9 File Offset: 0x0006F0E9
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00070EFB File Offset: 0x0006F0FB
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

		// Token: 0x060019CD RID: 6605 RVA: 0x00070F0E File Offset: 0x0006F10E
		private static bool IsExpandableFieldRecordHeaderDisplayModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode), value);
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00070F20 File Offset: 0x0006F120
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00070F32 File Offset: 0x0006F132
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

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00070F45 File Offset: 0x0006F145
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00070F57 File Offset: 0x0006F157
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00070F65 File Offset: 0x0006F165
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00070F77 File Offset: 0x0006F177
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x060019D4 RID: 6612 RVA: 0x00070F88 File Offset: 0x0006F188
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00070FBC File Offset: 0x0006F1BC
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x00070FCE File Offset: 0x0006F1CE
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

		// Token: 0x060019D7 RID: 6615 RVA: 0x00070FDC File Offset: 0x0006F1DC
		private static void OnFilterCellEditorStyleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.Style cachedFilterCellEditorStyle = (global::System.Windows.Style)e.NewValue;
			fieldSettings._cachedFilterCellEditorStyle = cachedFilterCellEditorStyle;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00071004 File Offset: 0x0006F204
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00071038 File Offset: 0x0006F238
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00071040 File Offset: 0x0006F240
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0007104E File Offset: 0x0006F24E
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00071060 File Offset: 0x0006F260
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x00071073 File Offset: 0x0006F273
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x00071085 File Offset: 0x0006F285
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00071098 File Offset: 0x0006F298
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x000710AA File Offset: 0x0006F2AA
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x000710BD File Offset: 0x0006F2BD
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x000710CF File Offset: 0x0006F2CF
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000710E2 File Offset: 0x0006F2E2
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x000710F4 File Offset: 0x0006F2F4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperator>))]
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00071107 File Offset: 0x0006F307
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x00071119 File Offset: 0x0006F319
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.ComparisonOperatorFlags>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0007112C File Offset: 0x0006F32C
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0007113E File Offset: 0x0006F33E
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00071151 File Offset: 0x0006F351
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x00071163 File Offset: 0x0006F363
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

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00071171 File Offset: 0x0006F371
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00071183 File Offset: 0x0006F383
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x060019ED RID: 6637 RVA: 0x00071194 File Offset: 0x0006F394
		private static void OnForceCellVirtualizationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			bool? cachedForceCellVirtualization = (bool?)e.NewValue;
			fieldSettings._cachedForceCellVirtualization = cachedForceCellVirtualization;
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x000711BC File Offset: 0x0006F3BC
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x000711C4 File Offset: 0x0006F3C4
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000711D7 File Offset: 0x0006F3D7
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x000711E9 File Offset: 0x0006F3E9
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000711F7 File Offset: 0x0006F3F7
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00071209 File Offset: 0x0006F409
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x060019F4 RID: 6644 RVA: 0x00071217 File Offset: 0x0006F417
		private static bool IsGroupByModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.FieldGroupByMode), value);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00071229 File Offset: 0x0006F429
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0007123B File Offset: 0x0006F43B
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0007124E File Offset: 0x0006F44E
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x00071260 File Offset: 0x0006F460
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0007126E File Offset: 0x0006F46E
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x00071280 File Offset: 0x0006F480
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

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0007128E File Offset: 0x0006F48E
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x000712A0 File Offset: 0x0006F4A0
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

		// Token: 0x060019FD RID: 6653 RVA: 0x000712B4 File Offset: 0x0006F4B4
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::Infragistics.Windows.Editors.InvalidValueBehavior cachedInvalidValueBehavior = (global::Infragistics.Windows.Editors.InvalidValueBehavior)e.NewValue;
			fieldSettings._cachedInvalidValueBehavior = cachedInvalidValueBehavior;
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000712DC File Offset: 0x0006F4DC
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x000712E4 File Offset: 0x0006F4E4
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

		// Token: 0x06001A00 RID: 6656 RVA: 0x000712F7 File Offset: 0x0006F4F7
		private static bool IsLabelClickActionValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.LabelClickAction), value);
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00071309 File Offset: 0x0006F509
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0007131B File Offset: 0x0006F51B
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

		// Token: 0x06001A03 RID: 6659 RVA: 0x00071330 File Offset: 0x0006F530
		private static void OnLabelHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelHeight = (double)e.NewValue;
			fieldSettings._cachedLabelHeight = cachedLabelHeight;
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00071358 File Offset: 0x0006F558
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x00071360 File Offset: 0x0006F560
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

		// Token: 0x06001A06 RID: 6662 RVA: 0x00071374 File Offset: 0x0006F574
		private static void OnLabelMaxHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMaxHeight = (double)e.NewValue;
			fieldSettings._cachedLabelMaxHeight = cachedLabelMaxHeight;
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0007139C File Offset: 0x0006F59C
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x000713A4 File Offset: 0x0006F5A4
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

		// Token: 0x06001A09 RID: 6665 RVA: 0x000713B8 File Offset: 0x0006F5B8
		private static void OnLabelMaxWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMaxWidth = (double)e.NewValue;
			fieldSettings._cachedLabelMaxWidth = cachedLabelMaxWidth;
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x000713E0 File Offset: 0x0006F5E0
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x000713E8 File Offset: 0x0006F5E8
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

		// Token: 0x06001A0C RID: 6668 RVA: 0x000713FC File Offset: 0x0006F5FC
		private static void OnLabelMinHeightChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMinHeight = (double)e.NewValue;
			fieldSettings._cachedLabelMinHeight = cachedLabelMinHeight;
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00071424 File Offset: 0x0006F624
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0007142C File Offset: 0x0006F62C
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

		// Token: 0x06001A0F RID: 6671 RVA: 0x00071440 File Offset: 0x0006F640
		private static void OnLabelMinWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelMinWidth = (double)e.NewValue;
			fieldSettings._cachedLabelMinWidth = cachedLabelMinWidth;
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00071468 File Offset: 0x0006F668
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x00071470 File Offset: 0x0006F670
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

		// Token: 0x06001A12 RID: 6674 RVA: 0x00071484 File Offset: 0x0006F684
		private static void OnLabelPresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedLabelPresenterStyle = (e.NewValue as global::System.Windows.Style);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000714AC File Offset: 0x0006F6AC
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

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000714E0 File Offset: 0x0006F6E0
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x000714E8 File Offset: 0x0006F6E8
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

		// Token: 0x06001A16 RID: 6678 RVA: 0x000714F8 File Offset: 0x0006F6F8
		private static void OnLabelPresenterStyleSelectorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = target as global::Infragistics.Windows.DataPresenter.FieldSettings;
			fieldSettings._cachedLabelPresenterStyleSelector = (e.NewValue as global::System.Windows.Controls.StyleSelector);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0007151E File Offset: 0x0006F71E
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00071526 File Offset: 0x0006F726
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

		// Token: 0x06001A19 RID: 6681 RVA: 0x00071534 File Offset: 0x0006F734
		private static void OnLabelTextAlignmentChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextAlignment? cachedLabelTextAlignment = (global::System.Windows.TextAlignment?)e.NewValue;
			fieldSettings._cachedLabelTextAlignment = cachedLabelTextAlignment;
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0007155C File Offset: 0x0006F75C
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00071564 File Offset: 0x0006F764
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

		// Token: 0x06001A1C RID: 6684 RVA: 0x00071578 File Offset: 0x0006F778
		private static void OnLabelTextTrimmingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextTrimming? cachedLabelTextTrimming = (global::System.Windows.TextTrimming?)e.NewValue;
			fieldSettings._cachedLabelTextTrimming = cachedLabelTextTrimming;
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x000715A0 File Offset: 0x0006F7A0
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x000715A8 File Offset: 0x0006F7A8
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextTrimming>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06001A1F RID: 6687 RVA: 0x000715BC File Offset: 0x0006F7BC
		private static void OnLabelTextWrappingChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			global::System.Windows.TextWrapping? cachedLabelTextWrapping = (global::System.Windows.TextWrapping?)e.NewValue;
			fieldSettings._cachedLabelTextWrapping = cachedLabelTextWrapping;
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000715E4 File Offset: 0x0006F7E4
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x000715EC File Offset: 0x0006F7EC
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

		// Token: 0x06001A22 RID: 6690 RVA: 0x00071600 File Offset: 0x0006F800
		private static void OnLabelWidthChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)dependencyObject;
			double cachedLabelWidth = (double)e.NewValue;
			fieldSettings._cachedLabelWidth = cachedLabelWidth;
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00071628 File Offset: 0x0006F828
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00071630 File Offset: 0x0006F830
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

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00071643 File Offset: 0x0006F843
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x00071655 File Offset: 0x0006F855
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00071668 File Offset: 0x0006F868
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0007167A File Offset: 0x0006F87A
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0007168D File Offset: 0x0006F88D
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0007169F File Offset: 0x0006F89F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06001A2B RID: 6699 RVA: 0x000716AD File Offset: 0x0006F8AD
		private static bool IsSortComparisonTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), value);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x000716BF File Offset: 0x0006F8BF
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x000716D1 File Offset: 0x0006F8D1
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

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000716E4 File Offset: 0x0006F8E4
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x000716F6 File Offset: 0x0006F8F6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas>))]
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

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00071709 File Offset: 0x0006F909
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0007171B File Offset: 0x0006F91B
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

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0007172E File Offset: 0x0006F92E
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x00071740 File Offset: 0x0006F940
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

		// Token: 0x06001A34 RID: 6708 RVA: 0x00071753 File Offset: 0x0006F953
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0007175B File Offset: 0x0006F95B
		private static bool ValidatePixelValue(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value >= 0.0);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0007178C File Offset: 0x0006F98C
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

		// Token: 0x04000A73 RID: 2675
		public static readonly global::System.Windows.DependencyProperty AllowCellVirtualizationProperty = global::System.Windows.DependencyProperty.Register("AllowCellVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowCellVirtualizationChanged)));

		// Token: 0x04000A74 RID: 2676
		private bool? _cachedAllowCellVirtualization;

		// Token: 0x04000A75 RID: 2677
		public static readonly global::System.Windows.DependencyProperty AllowEditProperty = global::System.Windows.DependencyProperty.Register("AllowEdit", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A76 RID: 2678
		public static readonly global::System.Windows.DependencyProperty AllowFixingProperty = global::System.Windows.DependencyProperty.Register("AllowFixing", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldFixing), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowFixingChanged)));

		// Token: 0x04000A77 RID: 2679
		public static readonly global::System.Windows.DependencyProperty AllowGroupByProperty = global::System.Windows.DependencyProperty.Register("AllowGroupBy", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A78 RID: 2680
		public static readonly global::System.Windows.DependencyProperty AllowHidingProperty = global::System.Windows.DependencyProperty.Register("AllowHiding", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldHiding), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A79 RID: 2681
		public static readonly global::System.Windows.DependencyProperty AllowLabelVirtualizationProperty = global::System.Windows.DependencyProperty.Register("AllowLabelVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnAllowLabelVirtualizationChanged)));

		// Token: 0x04000A7A RID: 2682
		private bool? _cachedAllowLabelVirtualization;

		// Token: 0x04000A7B RID: 2683
		public static readonly global::System.Windows.DependencyProperty AllowRecordFilteringProperty = global::System.Windows.DependencyProperty.Register("AllowRecordFiltering", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A7C RID: 2684
		public static readonly global::System.Windows.DependencyProperty AllowResizeProperty = global::System.Windows.DependencyProperty.Register("AllowResize", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A7D RID: 2685
		public static readonly global::System.Windows.DependencyProperty AllowSummariesProperty = global::System.Windows.DependencyProperty.Register("AllowSummaries", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A7E RID: 2686
		public static readonly global::System.Windows.DependencyProperty AutoSizeOptionsProperty = global::System.Windows.DependencyProperty.Register("AutoSizeOptions", typeof(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A7F RID: 2687
		public static readonly global::System.Windows.DependencyProperty AutoSizeScopeProperty = global::System.Windows.DependencyProperty.Register("AutoSizeScope", typeof(global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.Default));

		// Token: 0x04000A80 RID: 2688
		public static readonly global::System.Windows.DependencyProperty CellClickActionProperty = global::System.Windows.DependencyProperty.Register("CellClickAction", typeof(global::Infragistics.Windows.DataPresenter.CellClickAction), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellClickAction.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsCellClickActionValid));

		// Token: 0x04000A81 RID: 2689
		public static readonly global::System.Windows.DependencyProperty CellContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("CellContentAlignment", typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellContentAlignmentChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsCellContentAlignmentValid));

		// Token: 0x04000A82 RID: 2690
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment _cachedCellContentAlignment;

		// Token: 0x04000A83 RID: 2691
		public static readonly global::System.Windows.DependencyProperty CellHeightProperty = global::System.Windows.DependencyProperty.Register("CellHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A84 RID: 2692
		private double _cachedCellHeight = double.NaN;

		// Token: 0x04000A85 RID: 2693
		public static readonly global::System.Windows.DependencyProperty CellMaxHeightProperty = global::System.Windows.DependencyProperty.Register("CellMaxHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMaxHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A86 RID: 2694
		private double _cachedCellMaxHeight = double.NaN;

		// Token: 0x04000A87 RID: 2695
		public static readonly global::System.Windows.DependencyProperty CellMaxWidthProperty = global::System.Windows.DependencyProperty.Register("CellMaxWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMaxWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A88 RID: 2696
		private double _cachedCellMaxWidth = double.NaN;

		// Token: 0x04000A89 RID: 2697
		public static readonly global::System.Windows.DependencyProperty CellMinHeightProperty = global::System.Windows.DependencyProperty.Register("CellMinHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMinHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A8A RID: 2698
		private double _cachedCellMinHeight = double.NaN;

		// Token: 0x04000A8B RID: 2699
		public static readonly global::System.Windows.DependencyProperty CellMinWidthProperty = global::System.Windows.DependencyProperty.Register("CellMinWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellMinWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A8C RID: 2700
		private double _cachedCellMinWidth = double.NaN;

		// Token: 0x04000A8D RID: 2701
		public static readonly global::System.Windows.DependencyProperty CellPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("CellPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellPresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateCellPresenterStyle));

		// Token: 0x04000A8E RID: 2702
		private global::System.Windows.Style _cachedCellPresenterStyle;

		// Token: 0x04000A8F RID: 2703
		public static readonly global::System.Windows.DependencyProperty CellPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CellPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellPresenterStyleSelectorChanged)));

		// Token: 0x04000A90 RID: 2704
		private global::System.Windows.Controls.StyleSelector _cachedCellPresenterStyleSelector;

		// Token: 0x04000A91 RID: 2705
		public static readonly global::System.Windows.DependencyProperty CellValuePresenterStyleProperty = global::System.Windows.DependencyProperty.Register("CellValuePresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellValuePresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateCellValuePresenterStyle));

		// Token: 0x04000A92 RID: 2706
		private global::System.Windows.Style _cachedCellValuePresenterStyle;

		// Token: 0x04000A93 RID: 2707
		public static readonly global::System.Windows.DependencyProperty CellValuePresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CellValuePresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellValuePresenterStyleSelectorChanged)));

		// Token: 0x04000A94 RID: 2708
		private global::System.Windows.Controls.StyleSelector _cachedCellValuePresenterStyleSelector;

		// Token: 0x04000A95 RID: 2709
		public static readonly global::System.Windows.DependencyProperty CellVisibilityWhenGroupedProperty = global::System.Windows.DependencyProperty.Register("CellVisibilityWhenGrouped", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellVisibilityWhenGroupedChanged), null));

		// Token: 0x04000A96 RID: 2710
		private global::System.Windows.Visibility? _cachedCellVisibilityWhenGrouped;

		// Token: 0x04000A97 RID: 2711
		public static readonly global::System.Windows.DependencyProperty CellWidthProperty = global::System.Windows.DependencyProperty.Register("CellWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCellWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000A98 RID: 2712
		private double _cachedCellWidth = double.NaN;

		// Token: 0x04000A99 RID: 2713
		public static readonly global::System.Windows.DependencyProperty CollapseWhenEmptyProperty = global::System.Windows.DependencyProperty.Register("CollapseWhenEmpty", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnCollapseWhenEmptyChanged)));

		// Token: 0x04000A9A RID: 2714
		private bool? _cachedCollapseWhenEmpty;

		// Token: 0x04000A9B RID: 2715
		public static readonly global::System.Windows.DependencyProperty DataValueChangedHistoryLimitProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedHistoryLimit", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.CoerceDataValueChangedHistoryLimit)));

		// Token: 0x04000A9C RID: 2716
		public static readonly global::System.Windows.DependencyProperty DataValueChangedNotificationsActiveProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedNotificationsActive", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnDataValueChangedNotificationsActiveChanged)));

		// Token: 0x04000A9D RID: 2717
		public static readonly global::System.Windows.DependencyProperty DataValueChangedScopeProperty = global::System.Windows.DependencyProperty.Register("DataValueChangedScope", typeof(global::Infragistics.Windows.DataPresenter.DataValueChangedScope), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataValueChangedScope.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnDataValueChangedScopeChanged)));

		// Token: 0x04000A9E RID: 2718
		public static readonly global::System.Windows.DependencyProperty EditAsTypeProperty = global::System.Windows.DependencyProperty.Register("EditAsType", typeof(global::System.Type), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditAsTypeChanged)));

		// Token: 0x04000A9F RID: 2719
		private global::System.Type _cachedEditAsType;

		// Token: 0x04000AA0 RID: 2720
		public static readonly global::System.Windows.DependencyProperty EditorStyleProperty = global::System.Windows.DependencyProperty.Register("EditorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateEditorStyle));

		// Token: 0x04000AA1 RID: 2721
		private global::System.Windows.Style _cachedEditorStyle;

		// Token: 0x04000AA2 RID: 2722
		public static readonly global::System.Windows.DependencyProperty EditorStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("EditorStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorStyleSelectorChanged)));

		// Token: 0x04000AA3 RID: 2723
		private global::System.Windows.Controls.StyleSelector _cachedEditorStyleSelector;

		// Token: 0x04000AA4 RID: 2724
		public static readonly global::System.Windows.DependencyProperty EditorTypeProperty = global::System.Windows.DependencyProperty.Register("EditorType", typeof(global::System.Type), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnEditorTypeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateEditorType));

		// Token: 0x04000AA5 RID: 2725
		private global::System.Type _cachedEditorType;

		// Token: 0x04000AA6 RID: 2726
		public static readonly global::System.Windows.DependencyProperty ExpandedCellStyleProperty = global::System.Windows.DependencyProperty.Register("ExpandedCellStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000AA7 RID: 2727
		public static readonly global::System.Windows.DependencyProperty ExpandedCellStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("ExpandedCellStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000AA8 RID: 2728
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordExpansionModeProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordExpansionMode", typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsExpandableFieldRecordExpansionModeValid));

		// Token: 0x04000AA9 RID: 2729
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordHeaderDisplayModeProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordHeaderDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsExpandableFieldRecordHeaderDisplayModeValid));

		// Token: 0x04000AAA RID: 2730
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000AAB RID: 2731
		public static readonly global::System.Windows.DependencyProperty ExpandableFieldRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("ExpandableFieldRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000AAC RID: 2732
		public static readonly global::System.Windows.DependencyProperty FilterCellValuePresenterStyleProperty = global::System.Windows.DependencyProperty.Register("FilterCellValuePresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateFilterCellValuePresenterStyle));

		// Token: 0x04000AAD RID: 2733
		public static readonly global::System.Windows.DependencyProperty FilterCellEditorStyleProperty = global::System.Windows.DependencyProperty.Register("FilterCellEditorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnFilterCellEditorStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateFilterCellEditorStyle));

		// Token: 0x04000AAE RID: 2734
		private global::System.Windows.Style _cachedFilterCellEditorStyle;

		// Token: 0x04000AAF RID: 2735
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("FilterClearButtonVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB0 RID: 2736
		public static readonly global::System.Windows.DependencyProperty FilterEvaluationTriggerProperty = global::System.Windows.DependencyProperty.Register("FilterEvaluationTrigger", typeof(global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB1 RID: 2737
		public static readonly global::System.Windows.DependencyProperty FilterLabelIconDropDownTypeProperty = global::System.Windows.DependencyProperty.Register("FilterLabelIconDropDownType", typeof(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.Default));

		// Token: 0x04000AB2 RID: 2738
		public static readonly global::System.Windows.DependencyProperty FilterOperandUITypeProperty = global::System.Windows.DependencyProperty.Register("FilterOperandUIType", typeof(global::Infragistics.Windows.DataPresenter.FilterOperandUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB3 RID: 2739
		public static readonly global::System.Windows.DependencyProperty FilterOperatorDefaultValueProperty = global::System.Windows.DependencyProperty.Register("FilterOperatorDefaultValue", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB4 RID: 2740
		public static readonly global::System.Windows.DependencyProperty FilterOperatorDropDownItemsProperty = global::System.Windows.DependencyProperty.Register("FilterOperatorDropDownItems", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorFlags?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB5 RID: 2741
		public static readonly global::System.Windows.DependencyProperty FilterStringComparisonTypeProperty = global::System.Windows.DependencyProperty.Register("FilterStringComparisonType", typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000AB6 RID: 2742
		public static readonly global::System.Windows.DependencyProperty FilterComparerProperty = global::System.Windows.DependencyProperty.Register("FilterComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AB7 RID: 2743
		public static readonly global::System.Windows.DependencyProperty FilterEvaluatorProperty = global::System.Windows.DependencyProperty.Register("FilterEvaluator", typeof(global::Infragistics.Windows.Controls.IFilterEvaluator), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AB8 RID: 2744
		public static readonly global::System.Windows.DependencyProperty ForceCellVirtualizationProperty = global::System.Windows.DependencyProperty.Register("ForceCellVirtualization", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnForceCellVirtualizationChanged)));

		// Token: 0x04000AB9 RID: 2745
		private bool? _cachedForceCellVirtualization;

		// Token: 0x04000ABA RID: 2746
		public static readonly global::System.Windows.DependencyProperty GroupByComparerProperty = global::System.Windows.DependencyProperty.Register("GroupByComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000ABB RID: 2747
		public static readonly global::System.Windows.DependencyProperty GroupByEvaluatorProperty = global::System.Windows.DependencyProperty.Register("GroupByEvaluator", typeof(global::Infragistics.Windows.DataPresenter.IGroupByEvaluator), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000ABC RID: 2748
		public static readonly global::System.Windows.DependencyProperty GroupByModeProperty = global::System.Windows.DependencyProperty.Register("GroupByMode", typeof(global::Infragistics.Windows.DataPresenter.FieldGroupByMode), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsGroupByModeValid));

		// Token: 0x04000ABD RID: 2749
		public static readonly global::System.Windows.DependencyProperty GroupByRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000ABE RID: 2750
		public static readonly global::System.Windows.DependencyProperty GroupByRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("GroupByRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000ABF RID: 2751
		public static readonly global::System.Windows.DependencyProperty HeightProperty = global::System.Windows.DependencyProperty.Register("Height", typeof(global::Infragistics.Windows.DataPresenter.FieldLength?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AC0 RID: 2752
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty = global::System.Windows.DependencyProperty.Register("InvalidValueBehavior", typeof(global::Infragistics.Windows.Editors.InvalidValueBehavior), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.InvalidValueBehavior.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnInvalidValueBehaviorChanged)));

		// Token: 0x04000AC1 RID: 2753
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _cachedInvalidValueBehavior;

		// Token: 0x04000AC2 RID: 2754
		public static readonly global::System.Windows.DependencyProperty LabelClickActionProperty = global::System.Windows.DependencyProperty.Register("LabelClickAction", typeof(global::Infragistics.Windows.DataPresenter.LabelClickAction), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelClickAction.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsLabelClickActionValid));

		// Token: 0x04000AC3 RID: 2755
		public static readonly global::System.Windows.DependencyProperty LabelHeightProperty = global::System.Windows.DependencyProperty.Register("LabelHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000AC4 RID: 2756
		private double _cachedLabelHeight = double.NaN;

		// Token: 0x04000AC5 RID: 2757
		public static readonly global::System.Windows.DependencyProperty LabelMaxHeightProperty = global::System.Windows.DependencyProperty.Register("LabelMaxHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMaxHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000AC6 RID: 2758
		private double _cachedLabelMaxHeight = double.NaN;

		// Token: 0x04000AC7 RID: 2759
		public static readonly global::System.Windows.DependencyProperty LabelMaxWidthProperty = global::System.Windows.DependencyProperty.Register("LabelMaxWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMaxWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000AC8 RID: 2760
		private double _cachedLabelMaxWidth = double.NaN;

		// Token: 0x04000AC9 RID: 2761
		public static readonly global::System.Windows.DependencyProperty LabelMinHeightProperty = global::System.Windows.DependencyProperty.Register("LabelMinHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMinHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000ACA RID: 2762
		private double _cachedLabelMinHeight = double.NaN;

		// Token: 0x04000ACB RID: 2763
		public static readonly global::System.Windows.DependencyProperty LabelMinWidthProperty = global::System.Windows.DependencyProperty.Register("LabelMinWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelMinWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000ACC RID: 2764
		private double _cachedLabelMinWidth = double.NaN;

		// Token: 0x04000ACD RID: 2765
		public static readonly global::System.Windows.DependencyProperty LabelPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("LabelPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelPresenterStyleChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidateLabelPresenterStyle));

		// Token: 0x04000ACE RID: 2766
		private global::System.Windows.Style _cachedLabelPresenterStyle;

		// Token: 0x04000ACF RID: 2767
		public static readonly global::System.Windows.DependencyProperty LabelPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("LabelPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelPresenterStyleSelectorChanged)));

		// Token: 0x04000AD0 RID: 2768
		private global::System.Windows.Controls.StyleSelector _cachedLabelPresenterStyleSelector;

		// Token: 0x04000AD1 RID: 2769
		public static readonly global::System.Windows.DependencyProperty LabelTextAlignmentProperty = global::System.Windows.DependencyProperty.Register("LabelTextAlignment", typeof(global::System.Windows.TextAlignment?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextAlignmentChanged)));

		// Token: 0x04000AD2 RID: 2770
		private global::System.Windows.TextAlignment? _cachedLabelTextAlignment;

		// Token: 0x04000AD3 RID: 2771
		public static readonly global::System.Windows.DependencyProperty LabelTextTrimmingProperty = global::System.Windows.DependencyProperty.Register("LabelTextTrimming", typeof(global::System.Windows.TextTrimming?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextTrimmingChanged)));

		// Token: 0x04000AD4 RID: 2772
		private global::System.Windows.TextTrimming? _cachedLabelTextTrimming;

		// Token: 0x04000AD5 RID: 2773
		public static readonly global::System.Windows.DependencyProperty LabelTextWrappingProperty = global::System.Windows.DependencyProperty.Register("LabelTextWrapping", typeof(global::System.Windows.TextWrapping?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelTextWrappingChanged)));

		// Token: 0x04000AD6 RID: 2774
		private global::System.Windows.TextWrapping? _cachedLabelTextWrapping;

		// Token: 0x04000AD7 RID: 2775
		public static readonly global::System.Windows.DependencyProperty LabelWidthProperty = global::System.Windows.DependencyProperty.Register("LabelWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.OnLabelWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.ValidatePixelValue));

		// Token: 0x04000AD8 RID: 2776
		private double _cachedLabelWidth = double.NaN;

		// Token: 0x04000AD9 RID: 2777
		public static readonly global::System.Windows.DependencyProperty NonSpecificNotificationBehaviorProperty = global::System.Windows.DependencyProperty.Register("NonSpecificNotificationBehavior", typeof(global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default));

		// Token: 0x04000ADA RID: 2778
		public static readonly global::System.Windows.DependencyProperty SupportDataErrorInfoProperty = global::System.Windows.DependencyProperty.Register("SupportDataErrorInfo", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000ADB RID: 2779
		public static readonly global::System.Windows.DependencyProperty SortComparerProperty = global::System.Windows.DependencyProperty.Register("SortComparer", typeof(global::System.Collections.IComparer), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000ADC RID: 2780
		public static readonly global::System.Windows.DependencyProperty SortComparisonTypeProperty = global::System.Windows.DependencyProperty.Register("SortComparisonType", typeof(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldSettings.IsSortComparisonTypeValid));

		// Token: 0x04000ADD RID: 2781
		public static readonly global::System.Windows.DependencyProperty SummaryDisplayAreaProperty = global::System.Windows.DependencyProperty.Register("SummaryDisplayArea", typeof(global::Infragistics.Windows.DataPresenter.SummaryDisplayAreas?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000ADE RID: 2782
		public static readonly global::System.Windows.DependencyProperty SummaryUITypeProperty = global::System.Windows.DependencyProperty.Register("SummaryUIType", typeof(global::Infragistics.Windows.DataPresenter.SummaryUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SummaryUIType.Default));

		// Token: 0x04000ADF RID: 2783
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(global::Infragistics.Windows.DataPresenter.FieldLength?), typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
