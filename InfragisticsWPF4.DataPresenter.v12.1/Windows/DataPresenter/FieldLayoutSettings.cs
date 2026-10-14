using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001BC RID: 444
	[global::System.Windows.StyleTypedProperty(Property = "RecordSelectorStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.RecordSelector))]
	[global::System.Windows.StyleTypedProperty(Property = "RecordListControlStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.RecordListControl))]
	[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.CloneObject)]
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	[global::System.Windows.StyleTypedProperty(Property = "DataRecordCellAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea))]
	[global::System.Windows.StyleTypedProperty(Property = "DataRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderLabelAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderPrefixAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea))]
	public class FieldLayoutSettings : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x0006EA98 File Offset: 0x0006CC98
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaGridTemplateProperty)
			{
				this._dataRecordCellAreaTemplateGrid = null;
				global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = e.NewValue as global::System.Windows.Controls.ItemsPanelTemplate;
				if (itemsPanelTemplate != null)
				{
					if (!itemsPanelTemplate.IsSealed)
					{
						itemsPanelTemplate.Seal();
					}
					this._dataRecordCellAreaTemplateGrid = (itemsPanelTemplate.LoadContent() as global::System.Windows.Controls.Grid);
					if (this._dataRecordCellAreaTemplateGrid == null)
					{
						throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_9"));
					}
					this._dataRecordCellAreaTemplateGrid.IsItemsHost = false;
				}
			}
			base.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0006EB26 File Offset: 0x0006CD26
		private static bool IsAddNewRecordLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation), value);
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x0006EB38 File Offset: 0x0006CD38
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x0006EB4A File Offset: 0x0006CD4A
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AddNewRecordLocation AddNewRecordLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AddNewRecordLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AddNewRecordLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AddNewRecordLocationProperty, value);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0006EB5D File Offset: 0x0006CD5D
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0006EB6F File Offset: 0x0006CD6F
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowAddNew
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowAddNewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowAddNewProperty, value);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0006EB82 File Offset: 0x0006CD82
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0006EB94 File Offset: 0x0006CD94
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowDelete
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowDeleteProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowDeleteProperty, value);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0006EBA7 File Offset: 0x0006CDA7
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0006EBB9 File Offset: 0x0006CDB9
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldMoving AllowFieldMoving
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowFieldMoving)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowFieldMovingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowFieldMovingProperty, value);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0006EBDE File Offset: 0x0006CDDE
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowRecordFixing AllowRecordFixing
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowRecordFixing)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowRecordFixingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowRecordFixingProperty, value);
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0006EBF1 File Offset: 0x0006CDF1
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0006EC03 File Offset: 0x0006CE03
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.AllowClipboardOperations>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowClipboardOperations? AllowClipboardOperations
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowClipboardOperationsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowClipboardOperationsProperty, value);
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0006EC16 File Offset: 0x0006CE16
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0006EC28 File Offset: 0x0006CE28
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AutoFitMode AutoFitMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AutoFitMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoFitModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoFitModeProperty, value);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0006EC3B File Offset: 0x0006CE3B
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0006EC4D File Offset: 0x0006CE4D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AutoGenerateFields
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoGenerateFieldsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoGenerateFieldsProperty, value);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0006EC60 File Offset: 0x0006CE60
		private static bool IsAutoArrangeCellsValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AutoArrangeCells), value);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006EC72 File Offset: 0x0006CE72
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x0006EC84 File Offset: 0x0006CE84
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AutoArrangeCells AutoArrangeCells
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AutoArrangeCells)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeCellsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeCellsProperty, value);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0006EC97 File Offset: 0x0006CE97
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0006ECA9 File Offset: 0x0006CEA9
		[global::System.ComponentModel.Bindable(true)]
		public int AutoArrangeMaxColumns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeMaxColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeMaxColumnsProperty, value);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0006ECBC File Offset: 0x0006CEBC
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0006ECCE File Offset: 0x0006CECE
		[global::System.ComponentModel.Bindable(true)]
		public int AutoArrangeMaxRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeMaxRowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangeMaxRowsProperty, value);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0006ECE1 File Offset: 0x0006CEE1
		private static bool IsAutoArrangePrimaryFieldReservationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation), value);
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x0006ECF3 File Offset: 0x0006CEF3
		// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0006ED05 File Offset: 0x0006CF05
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation AutoArrangePrimaryFieldReservation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangePrimaryFieldReservationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoArrangePrimaryFieldReservationProperty, value);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060018D7 RID: 6359 RVA: 0x0006ED18 File Offset: 0x0006CF18
		// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0006ED2A File Offset: 0x0006CF2A
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CalculationScope CalculationScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CalculationScope)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CalculationScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CalculationScopeProperty, value);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0006ED3D File Offset: 0x0006CF3D
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x0006ED4F File Offset: 0x0006CF4F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder ChildRecordsDisplayOrder
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ChildRecordsDisplayOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ChildRecordsDisplayOrderProperty, value);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0006ED62 File Offset: 0x0006CF62
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0006ED74 File Offset: 0x0006CF74
		[global::System.ComponentModel.Bindable(true)]
		public bool? CopyFieldLabelsToClipboard
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CopyFieldLabelsToClipboardProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CopyFieldLabelsToClipboardProperty, value);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0006ED87 File Offset: 0x0006CF87
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0006ED99 File Offset: 0x0006CF99
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Controls.ItemsPanelTemplate DataRecordCellAreaGridTemplate
		{
			get
			{
				return (global::System.Windows.Controls.ItemsPanelTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaGridTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaGridTemplateProperty, value);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0006EDA7 File Offset: 0x0006CFA7
		// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0006EDB9 File Offset: 0x0006CFB9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DataRecordCellAreaStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleProperty, value);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0006EDC7 File Offset: 0x0006CFC7
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0006EDD9 File Offset: 0x0006CFD9
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector DataRecordCellAreaStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleSelectorProperty, value);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0006EDE7 File Offset: 0x0006CFE7
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0006EDF9 File Offset: 0x0006CFF9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DataRecordPresenterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleProperty, value);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0006EE07 File Offset: 0x0006D007
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0006EE19 File Offset: 0x0006D019
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector DataRecordPresenterStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleSelectorProperty, value);
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0006EE27 File Offset: 0x0006D027
		private static bool IsDataRecordSizingModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode), value);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0006EE3C File Offset: 0x0006D03C
		private static void OnDataRecordSizingModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.DataRecordSizingMode cachedDataRecordSizingMode = (global::Infragistics.Windows.DataPresenter.DataRecordSizingMode)e.NewValue;
			fieldLayoutSettings._cachedDataRecordSizingMode = cachedDataRecordSizingMode;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0006EE64 File Offset: 0x0006D064
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0006EE6C File Offset: 0x0006D06C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DataRecordSizingMode
		{
			get
			{
				return this._cachedDataRecordSizingMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordSizingModeProperty, value);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0006EE7F File Offset: 0x0006D07F
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0006EE91 File Offset: 0x0006D091
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Controls.ColumnDefinition DefaultColumnDefinition
		{
			get
			{
				return (global::System.Windows.Controls.ColumnDefinition)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DefaultColumnDefinitionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DefaultColumnDefinitionProperty, value);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0006EE9F File Offset: 0x0006D09F
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0006EEB1 File Offset: 0x0006D0B1
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Controls.RowDefinition DefaultRowDefinition
		{
			get
			{
				return (global::System.Windows.Controls.RowDefinition)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DefaultRowDefinitionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DefaultRowDefinitionProperty, value);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0006EEBF File Offset: 0x0006D0BF
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0006EED1 File Offset: 0x0006D0D1
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode DataErrorDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataErrorDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataErrorDisplayModeProperty, value);
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0006EEE4 File Offset: 0x0006D0E4
		private static bool IsExpansionIndicatorDisplayModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode), value);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006EEF8 File Offset: 0x0006D0F8
		private static void OnExpansionIndicatorDisplayModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode cachedExpansionIndicatorDisplayMode = (global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode)e.NewValue;
			fieldLayoutSettings._cachedExpansionIndicatorDisplayMode = cachedExpansionIndicatorDisplayMode;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0006EF20 File Offset: 0x0006D120
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0006EF28 File Offset: 0x0006D128
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode ExpansionIndicatorDisplayMode
		{
			get
			{
				return this._cachedExpansionIndicatorDisplayMode;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ExpansionIndicatorDisplayModeProperty, value);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0006EF3B File Offset: 0x0006D13B
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0006EF4D File Offset: 0x0006D14D
		[global::System.ComponentModel.Bindable(true)]
		public int? FieldMovingMaxColumns
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldMovingMaxColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldMovingMaxColumnsProperty, value);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0006EF60 File Offset: 0x0006D160
		private static bool ValidateFieldMovingMaxRowColumns(object objVal)
		{
			int? num = (int?)objVal;
			return num == null || num.Value >= 0;
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0006EF8A File Offset: 0x0006D18A
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0006EF9C File Offset: 0x0006D19C
		[global::System.ComponentModel.Bindable(true)]
		public int? FieldMovingMaxRows
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldMovingMaxRowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldMovingMaxRowsProperty, value);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0006EFAF File Offset: 0x0006D1AF
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0006EFC1 File Offset: 0x0006D1C1
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterAction FilterAction
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordFilterAction)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterActionProperty, value);
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0006EFD4 File Offset: 0x0006D1D4
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0006EFE6 File Offset: 0x0006D1E6
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation FilterClearButtonLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterClearButtonLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterClearButtonLocationProperty, value);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0006EFF9 File Offset: 0x0006D1F9
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0006F00B File Offset: 0x0006D20B
		public global::Infragistics.Windows.DataPresenter.FilterEvaluationMode FilterEvaluationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterEvaluationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterEvaluationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterEvaluationModeProperty, value);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006F01E File Offset: 0x0006D21E
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0006F030 File Offset: 0x0006D230
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterRecordLocation FilterRecordLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterRecordLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterRecordLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterRecordLocationProperty, value);
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0006F043 File Offset: 0x0006D243
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0006F055 File Offset: 0x0006D255
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FilterUIType FilterUIType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterUIType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterUITypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterUITypeProperty, value);
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0006F068 File Offset: 0x0006D268
		private static void OnFilterUITypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0006F06A File Offset: 0x0006D26A
		private static void OnFixedFieldUITypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0006F06C File Offset: 0x0006D26C
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0006F07E File Offset: 0x0006D27E
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldUIType FixedFieldUIType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedFieldUIType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedFieldUITypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedFieldUITypeProperty, value);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0006F094 File Offset: 0x0006D294
		private static bool ValidateFixedRecordLimit(object value)
		{
			if (value == null)
			{
				return true;
			}
			int num = (int)value;
			return num >= 0;
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0006F0B4 File Offset: 0x0006D2B4
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x0006F0C6 File Offset: 0x0006D2C6
		[global::System.ComponentModel.Bindable(true)]
		public int? FixedRecordLimit
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordLimitProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordLimitProperty, value);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0006F0D9 File Offset: 0x0006D2D9
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x0006F0EB File Offset: 0x0006D2EB
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FixedRecordUIType FixedRecordUIType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedRecordUIType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty, value);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0006F0FE File Offset: 0x0006D2FE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedRecordUIType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty, this);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0006F10B File Offset: 0x0006D30B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedRecordUIType()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty);
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0006F118 File Offset: 0x0006D318
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0006F12A File Offset: 0x0006D32A
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder FixedRecordSortOrder
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordSortOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordSortOrderProperty, value);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0006F13D File Offset: 0x0006D33D
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0006F14F File Offset: 0x0006D34F
		public global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode GroupByEvaluationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupByEvaluationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupByEvaluationModeProperty, value);
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0006F162 File Offset: 0x0006D362
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0006F174 File Offset: 0x0006D374
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility? GroupByExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupByExpansionIndicatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupByExpansionIndicatorVisibilityProperty, value);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0006F187 File Offset: 0x0006D387
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0006F199 File Offset: 0x0006D399
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode GroupBySummaryDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupBySummaryDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupBySummaryDisplayModeProperty, value);
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0006F1AC File Offset: 0x0006D3AC
		private static bool IsHeaderPlacementValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacement), value);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0006F1C0 File Offset: 0x0006D3C0
		private static void OnHeaderPlacementChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.HeaderPlacement cachedHeaderPlacement = (global::Infragistics.Windows.DataPresenter.HeaderPlacement)e.NewValue;
			fieldLayoutSettings._cachedHeaderPlacement = cachedHeaderPlacement;
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0006F1F0 File Offset: 0x0006D3F0
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.HeaderPlacement HeaderPlacement
		{
			get
			{
				return this._cachedHeaderPlacement;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPlacementProperty, value);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0006F203 File Offset: 0x0006D403
		private static bool IsHeaderPlacementInGroupByValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy), value);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0006F218 File Offset: 0x0006D418
		private static void OnHeaderPlacementInGroupByChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy cachedHeaderPlacementInGroupBy = (global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy)e.NewValue;
			fieldLayoutSettings._cachedHeaderPlacementInGroupBy = cachedHeaderPlacementInGroupBy;
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0006F240 File Offset: 0x0006D440
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0006F248 File Offset: 0x0006D448
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy HeaderPlacementInGroupBy
		{
			get
			{
				return this._cachedHeaderPlacementInGroupBy;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPlacementInGroupByProperty, value);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0006F25B File Offset: 0x0006D45B
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0006F26D File Offset: 0x0006D46D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style HeaderPresenterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPresenterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPresenterStyleProperty, value);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0006F27B File Offset: 0x0006D47B
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0006F28D File Offset: 0x0006D48D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style HeaderLabelAreaStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderLabelAreaStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderLabelAreaStyleProperty, value);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0006F29B File Offset: 0x0006D49B
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0006F2AD File Offset: 0x0006D4AD
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode HeaderPrefixAreaDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaDisplayModeProperty, value);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0006F2C0 File Offset: 0x0006D4C0
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x0006F2D2 File Offset: 0x0006D4D2
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style HeaderPrefixAreaStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaStyleProperty, value);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0006F2F2 File Offset: 0x0006D4F2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? HighlightAlternateRecords
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HighlightAlternateRecordsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HighlightAlternateRecordsProperty, value);
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0006F305 File Offset: 0x0006D505
		private static bool IsHighlightPrimaryFieldValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField), value);
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0006F317 File Offset: 0x0006D517
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0006F329 File Offset: 0x0006D529
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.HighlightPrimaryField HighlightPrimaryField
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.HighlightPrimaryField)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HighlightPrimaryFieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HighlightPrimaryFieldProperty, value);
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0006F33C File Offset: 0x0006D53C
		private static bool IsLabelLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.LabelLocation), value);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006F350 File Offset: 0x0006D550
		private static void OnLabelLocationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.LabelLocation cachedLabelLocation = (global::Infragistics.Windows.DataPresenter.LabelLocation)e.NewValue;
			fieldLayoutSettings._cachedLabelLocation = cachedLabelLocation;
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0006F378 File Offset: 0x0006D578
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0006F380 File Offset: 0x0006D580
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.LabelLocation LabelLocation
		{
			get
			{
				return this._cachedLabelLocation;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.LabelLocationProperty, value);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0006F393 File Offset: 0x0006D593
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0006F3A5 File Offset: 0x0006D5A5
		[global::System.ComponentModel.Bindable(true)]
		public int MaxFieldsToAutoGenerate
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxFieldsToAutoGenerateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxFieldsToAutoGenerateProperty, value);
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
		private static bool OnValidateMaxSelected(object value)
		{
			if (value is int?)
			{
				return (int?)value == null || ((int?)value).Value >= 0;
			}
			if (value is int)
			{
				return (int)value >= 0;
			}
			return value == null;
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0006F40F File Offset: 0x0006D60F
		// (set) Token: 0x06001934 RID: 6452 RVA: 0x0006F421 File Offset: 0x0006D621
		[global::System.ComponentModel.Bindable(true)]
		public int? MaxSelectedCells
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxSelectedCellsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxSelectedCellsProperty, value);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0006F434 File Offset: 0x0006D634
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x0006F446 File Offset: 0x0006D646
		[global::System.ComponentModel.Bindable(true)]
		public int? MaxSelectedRecords
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxSelectedRecordsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.MaxSelectedRecordsProperty, value);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0006F459 File Offset: 0x0006D659
		// (set) Token: 0x06001938 RID: 6456 RVA: 0x0006F46B File Offset: 0x0006D66B
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterScope RecordFilterScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordFilterScope)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordFilterScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordFilterScopeProperty, value);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0006F47E File Offset: 0x0006D67E
		// (set) Token: 0x0600193A RID: 6458 RVA: 0x0006F490 File Offset: 0x0006D690
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.LogicalOperator>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.LogicalOperator? RecordFiltersLogicalOperator
		{
			get
			{
				return (global::Infragistics.Windows.Controls.LogicalOperator?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordFiltersLogicalOperatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordFiltersLogicalOperatorProperty, value);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0006F4A3 File Offset: 0x0006D6A3
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0006F4B5 File Offset: 0x0006D6B5
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style RecordListControlStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordListControlStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordListControlStyleProperty, value);
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006F4C3 File Offset: 0x0006D6C3
		private static bool IsRecordSelectorLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation), value);
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0006F4D5 File Offset: 0x0006D6D5
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0006F4E7 File Offset: 0x0006D6E7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorLocation RecordSelectorLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSelectorLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorLocationProperty, value);
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0006F4FA File Offset: 0x0006D6FA
		private static bool IsRecordSelectorExtentValid(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value >= 1.0);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0006F529 File Offset: 0x0006D729
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x0006F53B File Offset: 0x0006D73B
		[global::System.ComponentModel.Bindable(true)]
		public double RecordSelectorExtent
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorExtentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorExtentProperty, value);
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0006F54E File Offset: 0x0006D74E
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0006F560 File Offset: 0x0006D760
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style RecordSelectorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleProperty, value);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x0006F56E File Offset: 0x0006D76E
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x0006F580 File Offset: 0x0006D780
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.StyleSelector RecordSelectorStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleSelectorProperty, value);
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x0006F58E File Offset: 0x0006D78E
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x0006F5A0 File Offset: 0x0006D7A0
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation? RecordSeparatorLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSeparatorLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSeparatorLocationProperty, value);
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x0006F5B3 File Offset: 0x0006D7B3
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0006F5C5 File Offset: 0x0006D7C5
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? ReevaluateFiltersOnDataChange
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnDataChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnDataChangeProperty, value);
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0006F5D8 File Offset: 0x0006D7D8
		private static bool IsResizingModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.ResizingMode), value);
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x0006F5EA File Offset: 0x0006D7EA
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x0006F5FC File Offset: 0x0006D7FC
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ResizingMode ResizingMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ResizingMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ResizingModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ResizingModeProperty, value);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0006F60F File Offset: 0x0006D80F
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x0006F621 File Offset: 0x0006D821
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeCell
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SelectionType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeCellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeCellProperty, value);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0006F634 File Offset: 0x0006D834
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0006F646 File Offset: 0x0006D846
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeField
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SelectionType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeFieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeFieldProperty, value);
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0006F659 File Offset: 0x0006D859
		private static bool IsSelectionTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.SelectionType), value);
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x0006F66B File Offset: 0x0006D86B
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0006F67D File Offset: 0x0006D87D
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeRecord
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SelectionType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeRecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SelectionTypeRecordProperty, value);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x0006F690 File Offset: 0x0006D890
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0006F6A2 File Offset: 0x0006D8A2
		public global::Infragistics.Windows.DataPresenter.SortEvaluationMode SortEvaluationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SortEvaluationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SortEvaluationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SortEvaluationModeProperty, value);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x0006F6B5 File Offset: 0x0006D8B5
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0006F6C7 File Offset: 0x0006D8C7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SpecialRecordOrder SpecialRecordOrder
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SpecialRecordOrder)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SpecialRecordOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SpecialRecordOrderProperty, value);
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		private static void OnSpecialRecordOrderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings @object = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.SpecialRecordOrder specialRecordOrder = (global::Infragistics.Windows.DataPresenter.SpecialRecordOrder)e.OldValue;
			global::Infragistics.Windows.DataPresenter.SpecialRecordOrder specialRecordOrder2 = (global::Infragistics.Windows.DataPresenter.SpecialRecordOrder)e.NewValue;
			if (specialRecordOrder != null)
			{
				specialRecordOrder.PropertyChanged -= @object.SpecialRecordOrder_PropertyChanged;
			}
			if (specialRecordOrder2 != null)
			{
				specialRecordOrder2.PropertyChanged += @object.SpecialRecordOrder_PropertyChanged;
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0006F730 File Offset: 0x0006D930
		private void SpecialRecordOrder_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SpecialRecordOrder");
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0006F73D File Offset: 0x0006D93D
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0006F74F File Offset: 0x0006D94F
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility? SummaryDescriptionVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SummaryDescriptionVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SummaryDescriptionVisibilityProperty, value);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0006F762 File Offset: 0x0006D962
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0006F774 File Offset: 0x0006D974
		public global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode SummaryEvaluationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SummaryEvaluationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SummaryEvaluationModeProperty, value);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0006F787 File Offset: 0x0006D987
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x0006F799 File Offset: 0x0006D999
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo SupportDataErrorInfo
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SupportDataErrorInfoProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SupportDataErrorInfoProperty, value);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		internal global::System.Windows.Controls.Grid DataRecordCellAreaTemplateGrid
		{
			get
			{
				return this._dataRecordCellAreaTemplateGrid;
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0006F7B4 File Offset: 0x0006D9B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0006F7BC File Offset: 0x0006D9BC
		internal void ResetExcludedSettings(global::Infragistics.Windows.DataPresenter.ReportViewBase view)
		{
			if (view != null && view.ExcludeRecordSizing)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordSizingModeProperty);
			}
		}

		// Token: 0x04000A28 RID: 2600
		private global::System.Windows.Controls.Grid _dataRecordCellAreaTemplateGrid;

		// Token: 0x04000A29 RID: 2601
		public static readonly global::System.Windows.DependencyProperty AddNewRecordLocationProperty = global::System.Windows.DependencyProperty.Register("AddNewRecordLocation", typeof(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAddNewRecordLocationValid));

		// Token: 0x04000A2A RID: 2602
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AllowAddNewProperty = global::System.Windows.DependencyProperty.Register("AllowAddNew", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A2B RID: 2603
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AllowDeleteProperty = global::System.Windows.DependencyProperty.Register("AllowDelete", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A2C RID: 2604
		public static readonly global::System.Windows.DependencyProperty AllowFieldMovingProperty = global::System.Windows.DependencyProperty.Register("AllowFieldMoving", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldMoving), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Default));

		// Token: 0x04000A2D RID: 2605
		public static readonly global::System.Windows.DependencyProperty AllowRecordFixingProperty = global::System.Windows.DependencyProperty.Register("AllowRecordFixing", typeof(global::Infragistics.Windows.DataPresenter.AllowRecordFixing), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Default));

		// Token: 0x04000A2E RID: 2606
		public static readonly global::System.Windows.DependencyProperty AllowClipboardOperationsProperty = global::System.Windows.DependencyProperty.Register("AllowClipboardOperations", typeof(global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A2F RID: 2607
		public static readonly global::System.Windows.DependencyProperty AutoFitModeProperty = global::System.Windows.DependencyProperty.Register("AutoFitMode", typeof(global::Infragistics.Windows.DataPresenter.AutoFitMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoFitMode.Default));

		// Token: 0x04000A30 RID: 2608
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AutoGenerateFieldsProperty = global::System.Windows.DependencyProperty.Register("AutoGenerateFields", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A31 RID: 2609
		public static readonly global::System.Windows.DependencyProperty AutoArrangeCellsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeCells", typeof(global::Infragistics.Windows.DataPresenter.AutoArrangeCells), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAutoArrangeCellsValid));

		// Token: 0x04000A32 RID: 2610
		public static readonly global::System.Windows.DependencyProperty AutoArrangeMaxColumnsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeMaxColumns", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(-1));

		// Token: 0x04000A33 RID: 2611
		public static readonly global::System.Windows.DependencyProperty AutoArrangeMaxRowsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeMaxRows", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(-1));

		// Token: 0x04000A34 RID: 2612
		public static readonly global::System.Windows.DependencyProperty AutoArrangePrimaryFieldReservationProperty = global::System.Windows.DependencyProperty.Register("AutoArrangePrimaryFieldReservation", typeof(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAutoArrangePrimaryFieldReservationValid));

		// Token: 0x04000A35 RID: 2613
		public static readonly global::System.Windows.DependencyProperty CalculationScopeProperty = global::System.Windows.DependencyProperty.Register("CalculationScope", typeof(global::Infragistics.Windows.DataPresenter.CalculationScope), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CalculationScope.Default));

		// Token: 0x04000A36 RID: 2614
		public static readonly global::System.Windows.DependencyProperty ChildRecordsDisplayOrderProperty = global::System.Windows.DependencyProperty.Register("ChildRecordsDisplayOrder", typeof(global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.Default));

		// Token: 0x04000A37 RID: 2615
		public static readonly global::System.Windows.DependencyProperty CopyFieldLabelsToClipboardProperty = global::System.Windows.DependencyProperty.Register("CopyFieldLabelsToClipboard", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A38 RID: 2616
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaGridTemplateProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaGridTemplate", typeof(global::System.Windows.Controls.ItemsPanelTemplate), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A39 RID: 2617
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaStyleProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A3A RID: 2618
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A3B RID: 2619
		public static readonly global::System.Windows.DependencyProperty DataRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("DataRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A3C RID: 2620
		public static readonly global::System.Windows.DependencyProperty DataRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("DataRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A3D RID: 2621
		public static readonly global::System.Windows.DependencyProperty DataRecordSizingModeProperty = global::System.Windows.DependencyProperty.Register("DataRecordSizingMode", typeof(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnDataRecordSizingModeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsDataRecordSizingModeValid));

		// Token: 0x04000A3E RID: 2622
		private global::Infragistics.Windows.DataPresenter.DataRecordSizingMode _cachedDataRecordSizingMode;

		// Token: 0x04000A3F RID: 2623
		public static readonly global::System.Windows.DependencyProperty DefaultColumnDefinitionProperty = global::System.Windows.DependencyProperty.Register("DefaultColumnDefinition", typeof(global::System.Windows.Controls.ColumnDefinition), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A40 RID: 2624
		public static readonly global::System.Windows.DependencyProperty DefaultRowDefinitionProperty = global::System.Windows.DependencyProperty.Register("DefaultRowDefinition", typeof(global::System.Windows.Controls.RowDefinition), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A41 RID: 2625
		public static readonly global::System.Windows.DependencyProperty DataErrorDisplayModeProperty = global::System.Windows.DependencyProperty.Register("DataErrorDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A42 RID: 2626
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorDisplayModeProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnExpansionIndicatorDisplayModeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsExpansionIndicatorDisplayModeValid));

		// Token: 0x04000A43 RID: 2627
		private global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode _cachedExpansionIndicatorDisplayMode;

		// Token: 0x04000A44 RID: 2628
		public static readonly global::System.Windows.DependencyProperty FieldMovingMaxColumnsProperty = global::System.Windows.DependencyProperty.Register("FieldMovingMaxColumns", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFieldMovingMaxRowColumns));

		// Token: 0x04000A45 RID: 2629
		public static readonly global::System.Windows.DependencyProperty FieldMovingMaxRowsProperty = global::System.Windows.DependencyProperty.Register("FieldMovingMaxRows", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFieldMovingMaxRowColumns));

		// Token: 0x04000A46 RID: 2630
		public static readonly global::System.Windows.DependencyProperty FilterActionProperty = global::System.Windows.DependencyProperty.Register("FilterAction", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterAction), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A47 RID: 2631
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonLocationProperty = global::System.Windows.DependencyProperty.Register("FilterClearButtonLocation", typeof(global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A48 RID: 2632
		public static readonly global::System.Windows.DependencyProperty FilterEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("FilterEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.FilterEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Default));

		// Token: 0x04000A49 RID: 2633
		public static readonly global::System.Windows.DependencyProperty FilterRecordLocationProperty = global::System.Windows.DependencyProperty.Register("FilterRecordLocation", typeof(global::Infragistics.Windows.DataPresenter.FilterRecordLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterRecordLocation.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A4A RID: 2634
		public static readonly global::System.Windows.DependencyProperty FilterUITypeProperty = global::System.Windows.DependencyProperty.Register("FilterUIType", typeof(global::Infragistics.Windows.DataPresenter.FilterUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterUIType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnFilterUITypeChanged)));

		// Token: 0x04000A4B RID: 2635
		public static readonly global::System.Windows.DependencyProperty FixedFieldUITypeProperty = global::System.Windows.DependencyProperty.Register("FixedFieldUIType", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnFixedFieldUITypeChanged)));

		// Token: 0x04000A4C RID: 2636
		public static readonly global::System.Windows.DependencyProperty FixedRecordLimitProperty = global::System.Windows.DependencyProperty.Register("FixedRecordLimit", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFixedRecordLimit));

		// Token: 0x04000A4D RID: 2637
		public static readonly global::System.Windows.DependencyProperty FixedRecordUITypeProperty = global::System.Windows.DependencyProperty.Register("FixedRecordUIType", typeof(global::Infragistics.Windows.DataPresenter.FixedRecordUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Default));

		// Token: 0x04000A4E RID: 2638
		public static readonly global::System.Windows.DependencyProperty FixedRecordSortOrderProperty = global::System.Windows.DependencyProperty.Register("FixedRecordSortOrder", typeof(global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Default));

		// Token: 0x04000A4F RID: 2639
		public static readonly global::System.Windows.DependencyProperty GroupByEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("GroupByEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Default));

		// Token: 0x04000A50 RID: 2640
		public static readonly global::System.Windows.DependencyProperty GroupByExpansionIndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("GroupByExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A51 RID: 2641
		public static readonly global::System.Windows.DependencyProperty GroupBySummaryDisplayModeProperty = global::System.Windows.DependencyProperty.Register("GroupBySummaryDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Default));

		// Token: 0x04000A52 RID: 2642
		public static readonly global::System.Windows.DependencyProperty HeaderPlacementProperty = global::System.Windows.DependencyProperty.Register("HeaderPlacement", typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacement), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnHeaderPlacementChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHeaderPlacementValid));

		// Token: 0x04000A53 RID: 2643
		private global::Infragistics.Windows.DataPresenter.HeaderPlacement _cachedHeaderPlacement;

		// Token: 0x04000A54 RID: 2644
		public static readonly global::System.Windows.DependencyProperty HeaderPlacementInGroupByProperty = global::System.Windows.DependencyProperty.Register("HeaderPlacementInGroupBy", typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnHeaderPlacementInGroupByChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHeaderPlacementInGroupByValid));

		// Token: 0x04000A55 RID: 2645
		private global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy _cachedHeaderPlacementInGroupBy;

		// Token: 0x04000A56 RID: 2646
		public static readonly global::System.Windows.DependencyProperty HeaderPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A57 RID: 2647
		public static readonly global::System.Windows.DependencyProperty HeaderLabelAreaStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderLabelAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A58 RID: 2648
		public static readonly global::System.Windows.DependencyProperty HeaderPrefixAreaDisplayModeProperty = global::System.Windows.DependencyProperty.Register("HeaderPrefixAreaDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A59 RID: 2649
		public static readonly global::System.Windows.DependencyProperty HeaderPrefixAreaStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderPrefixAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A5A RID: 2650
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty HighlightAlternateRecordsProperty = global::System.Windows.DependencyProperty.Register("HighlightAlternateRecords", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A5B RID: 2651
		public static readonly global::System.Windows.DependencyProperty HighlightPrimaryFieldProperty = global::System.Windows.DependencyProperty.Register("HighlightPrimaryField", typeof(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHighlightPrimaryFieldValid));

		// Token: 0x04000A5C RID: 2652
		public static readonly global::System.Windows.DependencyProperty LabelLocationProperty = global::System.Windows.DependencyProperty.Register("LabelLocation", typeof(global::Infragistics.Windows.DataPresenter.LabelLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelLocation.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnLabelLocationChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsLabelLocationValid));

		// Token: 0x04000A5D RID: 2653
		private global::Infragistics.Windows.DataPresenter.LabelLocation _cachedLabelLocation;

		// Token: 0x04000A5E RID: 2654
		public static readonly global::System.Windows.DependencyProperty MaxFieldsToAutoGenerateProperty = global::System.Windows.DependencyProperty.Register("MaxFieldsToAutoGenerate", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000A5F RID: 2655
		public static readonly global::System.Windows.DependencyProperty MaxSelectedCellsProperty = global::System.Windows.DependencyProperty.Register("MaxSelectedCells", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnValidateMaxSelected));

		// Token: 0x04000A60 RID: 2656
		public static readonly global::System.Windows.DependencyProperty MaxSelectedRecordsProperty = global::System.Windows.DependencyProperty.Register("MaxSelectedRecords", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnValidateMaxSelected));

		// Token: 0x04000A61 RID: 2657
		public static readonly global::System.Windows.DependencyProperty RecordFilterScopeProperty = global::System.Windows.DependencyProperty.Register("RecordFilterScope", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterScope), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A62 RID: 2658
		public static readonly global::System.Windows.DependencyProperty RecordFiltersLogicalOperatorProperty = global::System.Windows.DependencyProperty.Register("RecordFiltersLogicalOperator", typeof(global::Infragistics.Windows.Controls.LogicalOperator?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A63 RID: 2659
		public static readonly global::System.Windows.DependencyProperty RecordListControlStyleProperty = global::System.Windows.DependencyProperty.Register("RecordListControlStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A64 RID: 2660
		public static readonly global::System.Windows.DependencyProperty RecordSelectorLocationProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorLocation", typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorLocationValid));

		// Token: 0x04000A65 RID: 2661
		public static readonly global::System.Windows.DependencyProperty RecordSelectorExtentProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorExtentValid));

		// Token: 0x04000A66 RID: 2662
		public static readonly global::System.Windows.DependencyProperty RecordSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A67 RID: 2663
		public static readonly global::System.Windows.DependencyProperty RecordSelectorStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000A68 RID: 2664
		public static readonly global::System.Windows.DependencyProperty RecordSeparatorLocationProperty = global::System.Windows.DependencyProperty.Register("RecordSeparatorLocation", typeof(global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A69 RID: 2665
		public static readonly global::System.Windows.DependencyProperty ReevaluateFiltersOnDataChangeProperty = global::System.Windows.DependencyProperty.Register("ReevaluateFiltersOnDataChange", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000A6A RID: 2666
		public static readonly global::System.Windows.DependencyProperty ResizingModeProperty = global::System.Windows.DependencyProperty.Register("ResizingMode", typeof(global::Infragistics.Windows.Controls.ResizingMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ResizingMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsResizingModeValid));

		// Token: 0x04000A6B RID: 2667
		public static readonly global::System.Windows.DependencyProperty SelectionTypeCellProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeCell", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000A6C RID: 2668
		public static readonly global::System.Windows.DependencyProperty SelectionTypeFieldProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeField", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000A6D RID: 2669
		public static readonly global::System.Windows.DependencyProperty SelectionTypeRecordProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeRecord", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000A6E RID: 2670
		public static readonly global::System.Windows.DependencyProperty SortEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SortEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.SortEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Default));

		// Token: 0x04000A6F RID: 2671
		public static readonly global::System.Windows.DependencyProperty SpecialRecordOrderProperty = global::System.Windows.DependencyProperty.Register("SpecialRecordOrder", typeof(global::Infragistics.Windows.DataPresenter.SpecialRecordOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnSpecialRecordOrderChanged)));

		// Token: 0x04000A70 RID: 2672
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionVisibilityProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000A71 RID: 2673
		public static readonly global::System.Windows.DependencyProperty SummaryEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SummaryEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Default));

		// Token: 0x04000A72 RID: 2674
		public static readonly global::System.Windows.DependencyProperty SupportDataErrorInfoProperty = global::System.Windows.DependencyProperty.Register("SupportDataErrorInfo", typeof(global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
