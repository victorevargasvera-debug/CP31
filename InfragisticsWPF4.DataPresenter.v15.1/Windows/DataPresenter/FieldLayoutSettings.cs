using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E0 RID: 480
	[global::System.Windows.StyleTypedProperty(Property = "HeaderPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "DataRecordCellAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea))]
	[global::System.Windows.StyleTypedProperty(Property = "DataRecordPresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter))]
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderLabelAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderPrefixAreaStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea))]
	[global::System.Windows.StyleTypedProperty(Property = "RecordListControlStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.RecordListControl))]
	[global::System.Windows.StyleTypedProperty(Property = "RecordSelectorStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.RecordSelector))]
	[global::System.Windows.StyleTypedProperty(Property = "RecordSelectorNumberStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber))]
	[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.CloneObject)]
	public class FieldLayoutSettings : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x00081EE0 File Offset: 0x000800E0
		static FieldLayoutSettings()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings));
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00082DF4 File Offset: 0x00080FF4
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

		// Token: 0x06001C88 RID: 7304 RVA: 0x00082E82 File Offset: 0x00081082
		private static bool IsAddNewRecordLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation), value);
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00082E94 File Offset: 0x00081094
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00082EA6 File Offset: 0x000810A6
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00082EB9 File Offset: 0x000810B9
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00082ECB File Offset: 0x000810CB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00082EDE File Offset: 0x000810DE
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00082EF0 File Offset: 0x000810F0
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00082F03 File Offset: 0x00081103
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00082F15 File Offset: 0x00081115
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00082F28 File Offset: 0x00081128
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x00082F3A File Offset: 0x0008113A
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00082F4D File Offset: 0x0008114D
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00082F5F File Offset: 0x0008115F
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

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00082F72 File Offset: 0x00081172
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00082F84 File Offset: 0x00081184
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00082F97 File Offset: 0x00081197
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00082FA9 File Offset: 0x000811A9
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

		// Token: 0x06001C99 RID: 7321 RVA: 0x00082FBC File Offset: 0x000811BC
		private static bool IsAutoArrangeCellsValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AutoArrangeCells), value);
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00082FCE File Offset: 0x000811CE
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x00082FE0 File Offset: 0x000811E0
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00082FF3 File Offset: 0x000811F3
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x00083005 File Offset: 0x00081205
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00083018 File Offset: 0x00081218
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0008302A File Offset: 0x0008122A
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

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0008303D File Offset: 0x0008123D
		private static bool IsAutoArrangePrimaryFieldReservationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation), value);
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0008304F File Offset: 0x0008124F
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x00083061 File Offset: 0x00081261
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00083074 File Offset: 0x00081274
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x00083086 File Offset: 0x00081286
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00083099 File Offset: 0x00081299
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x000830AB File Offset: 0x000812AB
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000830BE File Offset: 0x000812BE
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x000830D0 File Offset: 0x000812D0
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000830E3 File Offset: 0x000812E3
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x000830F5 File Offset: 0x000812F5
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00083103 File Offset: 0x00081303
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x00083115 File Offset: 0x00081315
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

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00083123 File Offset: 0x00081323
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x00083135 File Offset: 0x00081335
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

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00083143 File Offset: 0x00081343
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x00083155 File Offset: 0x00081355
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

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00083163 File Offset: 0x00081363
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00083175 File Offset: 0x00081375
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

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00083183 File Offset: 0x00081383
		private static bool IsDataRecordSizingModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode), value);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00083198 File Offset: 0x00081398
		private static void OnDataRecordSizingModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.DataRecordSizingMode cachedDataRecordSizingMode = (global::Infragistics.Windows.DataPresenter.DataRecordSizingMode)e.NewValue;
			fieldLayoutSettings._cachedDataRecordSizingMode = cachedDataRecordSizingMode;
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x000831C0 File Offset: 0x000813C0
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x000831C8 File Offset: 0x000813C8
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

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x000831DB File Offset: 0x000813DB
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x000831ED File Offset: 0x000813ED
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

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000831FB File Offset: 0x000813FB
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0008320D File Offset: 0x0008140D
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

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0008321B File Offset: 0x0008141B
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0008322D File Offset: 0x0008142D
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

		// Token: 0x06001CBD RID: 7357 RVA: 0x00083240 File Offset: 0x00081440
		private static bool IsExpansionIndicatorDisplayModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode), value);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00083254 File Offset: 0x00081454
		private static void OnExpansionIndicatorDisplayModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode cachedExpansionIndicatorDisplayMode = (global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode)e.NewValue;
			fieldLayoutSettings._cachedExpansionIndicatorDisplayMode = cachedExpansionIndicatorDisplayMode;
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0008327C File Offset: 0x0008147C
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x00083284 File Offset: 0x00081484
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00083297 File Offset: 0x00081497
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x000832A9 File Offset: 0x000814A9
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

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000832BC File Offset: 0x000814BC
		private static bool ValidateFieldMovingMaxRowColumns(object objVal)
		{
			int? num = (int?)objVal;
			return num == null || num.Value >= 0;
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000832E6 File Offset: 0x000814E6
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000832F8 File Offset: 0x000814F8
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

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0008330B File Offset: 0x0008150B
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0008331D File Offset: 0x0008151D
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldResizingArea FieldResizingArea
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldResizingArea)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldResizingAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldResizingAreaProperty, value);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00083330 File Offset: 0x00081530
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00083342 File Offset: 0x00081542
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

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00083355 File Offset: 0x00081555
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00083367 File Offset: 0x00081567
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0008337A File Offset: 0x0008157A
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0008338C File Offset: 0x0008158C
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

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0008339F File Offset: 0x0008159F
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x000833B1 File Offset: 0x000815B1
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000833C4 File Offset: 0x000815C4
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000833D6 File Offset: 0x000815D6
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

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000833E9 File Offset: 0x000815E9
		private static void OnFilterUITypeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000833EB File Offset: 0x000815EB
		private static void OnFixedFieldUITypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000833ED File Offset: 0x000815ED
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000833FF File Offset: 0x000815FF
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

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00083414 File Offset: 0x00081614
		private static bool ValidateFixedRecordLimit(object value)
		{
			if (value == null)
			{
				return true;
			}
			int num = (int)value;
			return num >= 0;
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00083434 File Offset: 0x00081634
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x00083446 File Offset: 0x00081646
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x00083459 File Offset: 0x00081659
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0008346B File Offset: 0x0008166B
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

		// Token: 0x06001CDB RID: 7387 RVA: 0x0008347E File Offset: 0x0008167E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedRecordUIType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty, this);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0008348B File Offset: 0x0008168B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedRecordUIType()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FixedRecordUITypeProperty);
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00083498 File Offset: 0x00081698
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x000834AA File Offset: 0x000816AA
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x000834BD File Offset: 0x000816BD
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x000834CF File Offset: 0x000816CF
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

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000834E2 File Offset: 0x000816E2
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x000834F4 File Offset: 0x000816F4
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

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00083507 File Offset: 0x00081707
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x00083519 File Offset: 0x00081719
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

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0008352C File Offset: 0x0008172C
		private static bool IsHeaderPlacementValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacement), value);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00083540 File Offset: 0x00081740
		private static void OnHeaderPlacementChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.HeaderPlacement cachedHeaderPlacement = (global::Infragistics.Windows.DataPresenter.HeaderPlacement)e.NewValue;
			fieldLayoutSettings._cachedHeaderPlacement = cachedHeaderPlacement;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00083568 File Offset: 0x00081768
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x00083570 File Offset: 0x00081770
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

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00083583 File Offset: 0x00081783
		private static bool IsHeaderPlacementInGroupByValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy), value);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00083598 File Offset: 0x00081798
		private static void OnHeaderPlacementInGroupByChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy cachedHeaderPlacementInGroupBy = (global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy)e.NewValue;
			fieldLayoutSettings._cachedHeaderPlacementInGroupBy = cachedHeaderPlacementInGroupBy;
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x000835C0 File Offset: 0x000817C0
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x000835C8 File Offset: 0x000817C8
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x000835DB File Offset: 0x000817DB
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x000835ED File Offset: 0x000817ED
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000835FB File Offset: 0x000817FB
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0008360D File Offset: 0x0008180D
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

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0008361B File Offset: 0x0008181B
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0008362D File Offset: 0x0008182D
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

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x00083640 File Offset: 0x00081840
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00083652 File Offset: 0x00081852
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

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x00083660 File Offset: 0x00081860
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x00083672 File Offset: 0x00081872
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

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00083685 File Offset: 0x00081885
		private static bool IsHighlightPrimaryFieldValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField), value);
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00083697 File Offset: 0x00081897
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000836A9 File Offset: 0x000818A9
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

		// Token: 0x06001CFA RID: 7418 RVA: 0x000836BC File Offset: 0x000818BC
		private static bool IsLabelLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.LabelLocation), value);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000836D0 File Offset: 0x000818D0
		private static void OnLabelLocationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)dependencyObject;
			global::Infragistics.Windows.DataPresenter.LabelLocation cachedLabelLocation = (global::Infragistics.Windows.DataPresenter.LabelLocation)e.NewValue;
			fieldLayoutSettings._cachedLabelLocation = cachedLabelLocation;
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000836F8 File Offset: 0x000818F8
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00083700 File Offset: 0x00081900
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

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00083713 File Offset: 0x00081913
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00083725 File Offset: 0x00081925
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

		// Token: 0x06001D00 RID: 7424 RVA: 0x00083738 File Offset: 0x00081938
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0008378F File Offset: 0x0008198F
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x000837A1 File Offset: 0x000819A1
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x000837B4 File Offset: 0x000819B4
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x000837C6 File Offset: 0x000819C6
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

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x000837D9 File Offset: 0x000819D9
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x000837EB File Offset: 0x000819EB
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x000837FE File Offset: 0x000819FE
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00083810 File Offset: 0x00081A10
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.LogicalOperator>))]
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00083823 File Offset: 0x00081A23
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00083835 File Offset: 0x00081A35
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00083843 File Offset: 0x00081A43
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00083855 File Offset: 0x00081A55
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordResizingArea RecordResizingArea
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordResizingArea)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordResizingAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordResizingAreaProperty, value);
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00083868 File Offset: 0x00081A68
		private static bool IsRecordSelectorLocationValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation), value);
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0008387A File Offset: 0x00081A7A
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0008388C File Offset: 0x00081A8C
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

		// Token: 0x06001D10 RID: 7440 RVA: 0x0008389F File Offset: 0x00081A9F
		private static bool IsRecordSelectorExtentValid(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value >= 1.0);
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000838CE File Offset: 0x00081ACE
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x000838E0 File Offset: 0x00081AE0
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

		// Token: 0x06001D13 RID: 7443 RVA: 0x000838F3 File Offset: 0x00081AF3
		private static bool IsRecordSelectorNumberFormatValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat), value);
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00083905 File Offset: 0x00081B05
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00083917 File Offset: 0x00081B17
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat RecordSelectorNumberFormat
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberFormatProperty, value);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0008392A File Offset: 0x00081B2A
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0008393C File Offset: 0x00081B3C
		[global::System.ComponentModel.Bindable(true)]
		public int? RecordSelectorNumberStart
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStartProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStartProperty, value);
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x0008394F File Offset: 0x00081B4F
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00083961 File Offset: 0x00081B61
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style RecordSelectorNumberStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleProperty, value);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0008396F File Offset: 0x00081B6F
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00083981 File Offset: 0x00081B81
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.StyleSelector RecordSelectorNumberStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleSelectorProperty, value);
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0008398F File Offset: 0x00081B8F
		private static bool IsRecordSelectorNumberTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType), value);
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x000839A1 File Offset: 0x00081BA1
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x000839B3 File Offset: 0x00081BB3
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType RecordSelectorNumberType
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberTypeProperty, value);
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000839C6 File Offset: 0x00081BC6
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x000839D8 File Offset: 0x00081BD8
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000839E6 File Offset: 0x00081BE6
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x000839F8 File Offset: 0x00081BF8
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00083A06 File Offset: 0x00081C06
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x00083A18 File Offset: 0x00081C18
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation>))]
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

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00083A2B File Offset: 0x00081C2B
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00083A3D File Offset: 0x00081C3D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00083A50 File Offset: 0x00081C50
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00083A62 File Offset: 0x00081C62
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? ReevaluateFiltersOnRecordsAdded
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnRecordsAddedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnRecordsAddedProperty, value);
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00083A75 File Offset: 0x00081C75
		private static bool IsResizingModeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.ResizingMode), value);
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00083A87 File Offset: 0x00081C87
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00083A99 File Offset: 0x00081C99
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00083AAC File Offset: 0x00081CAC
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00083ABE File Offset: 0x00081CBE
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00083AD1 File Offset: 0x00081CD1
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00083AE3 File Offset: 0x00081CE3
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

		// Token: 0x06001D30 RID: 7472 RVA: 0x00083AF6 File Offset: 0x00081CF6
		private static bool IsSelectionTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.SelectionType), value);
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00083B08 File Offset: 0x00081D08
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00083B1A File Offset: 0x00081D1A
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00083B2D File Offset: 0x00081D2D
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00083B3F File Offset: 0x00081D3F
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

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00083B52 File Offset: 0x00081D52
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00083B64 File Offset: 0x00081D64
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

		// Token: 0x06001D37 RID: 7479 RVA: 0x00083B74 File Offset: 0x00081D74
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

		// Token: 0x06001D38 RID: 7480 RVA: 0x00083BCC File Offset: 0x00081DCC
		private void SpecialRecordOrder_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.RaisePropertyChangedEvent("SpecialRecordOrder");
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00083BD9 File Offset: 0x00081DD9
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00083BEB File Offset: 0x00081DEB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Visibility>))]
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00083BFE File Offset: 0x00081DFE
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x00083C10 File Offset: 0x00081E10
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

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00083C23 File Offset: 0x00081E23
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00083C35 File Offset: 0x00081E35
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00083C48 File Offset: 0x00081E48
		internal global::System.Windows.Controls.Grid DataRecordCellAreaTemplateGrid
		{
			get
			{
				return this._dataRecordCellAreaTemplateGrid;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00083C50 File Offset: 0x00081E50
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00083C58 File Offset: 0x00081E58
		internal bool HasFieldBinding { get; set; }

		// Token: 0x06001D42 RID: 7490 RVA: 0x00083C61 File Offset: 0x00081E61
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00083C69 File Offset: 0x00081E69
		internal void ResetExcludedSettings(global::Infragistics.Windows.DataPresenter.ReportViewBase view)
		{
			if (view != null && view.ExcludeRecordSizing)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordSizingModeProperty);
			}
		}

		// Token: 0x04000BFF RID: 3071
		private global::System.Windows.Controls.Grid _dataRecordCellAreaTemplateGrid;

		// Token: 0x04000C00 RID: 3072
		public static readonly global::System.Windows.DependencyProperty AddNewRecordLocationProperty = global::System.Windows.DependencyProperty.Register("AddNewRecordLocation", typeof(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAddNewRecordLocationValid));

		// Token: 0x04000C01 RID: 3073
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AllowAddNewProperty = global::System.Windows.DependencyProperty.Register("AllowAddNew", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C02 RID: 3074
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AllowDeleteProperty = global::System.Windows.DependencyProperty.Register("AllowDelete", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C03 RID: 3075
		public static readonly global::System.Windows.DependencyProperty AllowFieldMovingProperty = global::System.Windows.DependencyProperty.Register("AllowFieldMoving", typeof(global::Infragistics.Windows.DataPresenter.AllowFieldMoving), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Default));

		// Token: 0x04000C04 RID: 3076
		public static readonly global::System.Windows.DependencyProperty AllowRecordFixingProperty = global::System.Windows.DependencyProperty.Register("AllowRecordFixing", typeof(global::Infragistics.Windows.DataPresenter.AllowRecordFixing), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Default));

		// Token: 0x04000C05 RID: 3077
		public static readonly global::System.Windows.DependencyProperty AllowClipboardOperationsProperty = global::System.Windows.DependencyProperty.Register("AllowClipboardOperations", typeof(global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C06 RID: 3078
		public static readonly global::System.Windows.DependencyProperty AutoFitModeProperty = global::System.Windows.DependencyProperty.Register("AutoFitMode", typeof(global::Infragistics.Windows.DataPresenter.AutoFitMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoFitMode.Default));

		// Token: 0x04000C07 RID: 3079
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty AutoGenerateFieldsProperty = global::System.Windows.DependencyProperty.Register("AutoGenerateFields", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C08 RID: 3080
		public static readonly global::System.Windows.DependencyProperty AutoArrangeCellsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeCells", typeof(global::Infragistics.Windows.DataPresenter.AutoArrangeCells), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAutoArrangeCellsValid));

		// Token: 0x04000C09 RID: 3081
		public static readonly global::System.Windows.DependencyProperty AutoArrangeMaxColumnsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeMaxColumns", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(-1));

		// Token: 0x04000C0A RID: 3082
		public static readonly global::System.Windows.DependencyProperty AutoArrangeMaxRowsProperty = global::System.Windows.DependencyProperty.Register("AutoArrangeMaxRows", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(-1));

		// Token: 0x04000C0B RID: 3083
		public static readonly global::System.Windows.DependencyProperty AutoArrangePrimaryFieldReservationProperty = global::System.Windows.DependencyProperty.Register("AutoArrangePrimaryFieldReservation", typeof(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsAutoArrangePrimaryFieldReservationValid));

		// Token: 0x04000C0C RID: 3084
		public static readonly global::System.Windows.DependencyProperty CalculationScopeProperty = global::System.Windows.DependencyProperty.Register("CalculationScope", typeof(global::Infragistics.Windows.DataPresenter.CalculationScope), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CalculationScope.Default));

		// Token: 0x04000C0D RID: 3085
		public static readonly global::System.Windows.DependencyProperty ChildRecordsDisplayOrderProperty = global::System.Windows.DependencyProperty.Register("ChildRecordsDisplayOrder", typeof(global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.Default));

		// Token: 0x04000C0E RID: 3086
		public static readonly global::System.Windows.DependencyProperty CopyFieldLabelsToClipboardProperty = global::System.Windows.DependencyProperty.Register("CopyFieldLabelsToClipboard", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C0F RID: 3087
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaGridTemplateProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaGridTemplate", typeof(global::System.Windows.Controls.ItemsPanelTemplate), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C10 RID: 3088
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaStyleProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C11 RID: 3089
		public static readonly global::System.Windows.DependencyProperty DataRecordCellAreaStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("DataRecordCellAreaStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C12 RID: 3090
		public static readonly global::System.Windows.DependencyProperty DataRecordPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("DataRecordPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C13 RID: 3091
		public static readonly global::System.Windows.DependencyProperty DataRecordPresenterStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("DataRecordPresenterStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C14 RID: 3092
		public static readonly global::System.Windows.DependencyProperty DataRecordSizingModeProperty = global::System.Windows.DependencyProperty.Register("DataRecordSizingMode", typeof(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnDataRecordSizingModeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsDataRecordSizingModeValid));

		// Token: 0x04000C15 RID: 3093
		private global::Infragistics.Windows.DataPresenter.DataRecordSizingMode _cachedDataRecordSizingMode;

		// Token: 0x04000C16 RID: 3094
		public static readonly global::System.Windows.DependencyProperty DefaultColumnDefinitionProperty = global::System.Windows.DependencyProperty.Register("DefaultColumnDefinition", typeof(global::System.Windows.Controls.ColumnDefinition), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C17 RID: 3095
		public static readonly global::System.Windows.DependencyProperty DefaultRowDefinitionProperty = global::System.Windows.DependencyProperty.Register("DefaultRowDefinition", typeof(global::System.Windows.Controls.RowDefinition), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C18 RID: 3096
		public static readonly global::System.Windows.DependencyProperty DataErrorDisplayModeProperty = global::System.Windows.DependencyProperty.Register("DataErrorDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C19 RID: 3097
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorDisplayModeProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnExpansionIndicatorDisplayModeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsExpansionIndicatorDisplayModeValid));

		// Token: 0x04000C1A RID: 3098
		private global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode _cachedExpansionIndicatorDisplayMode;

		// Token: 0x04000C1B RID: 3099
		public static readonly global::System.Windows.DependencyProperty FieldMovingMaxColumnsProperty = global::System.Windows.DependencyProperty.Register("FieldMovingMaxColumns", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFieldMovingMaxRowColumns));

		// Token: 0x04000C1C RID: 3100
		public static readonly global::System.Windows.DependencyProperty FieldMovingMaxRowsProperty = global::System.Windows.DependencyProperty.Register("FieldMovingMaxRows", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFieldMovingMaxRowColumns));

		// Token: 0x04000C1D RID: 3101
		public static readonly global::System.Windows.DependencyProperty FieldResizingAreaProperty = global::System.Windows.DependencyProperty.Register("FieldResizingArea", typeof(global::Infragistics.Windows.DataPresenter.FieldResizingArea), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldResizingArea.Default));

		// Token: 0x04000C1E RID: 3102
		public static readonly global::System.Windows.DependencyProperty FilterActionProperty = global::System.Windows.DependencyProperty.Register("FilterAction", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterAction), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C1F RID: 3103
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonLocationProperty = global::System.Windows.DependencyProperty.Register("FilterClearButtonLocation", typeof(global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C20 RID: 3104
		public static readonly global::System.Windows.DependencyProperty FilterEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("FilterEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.FilterEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Default));

		// Token: 0x04000C21 RID: 3105
		public static readonly global::System.Windows.DependencyProperty FilterRecordLocationProperty = global::System.Windows.DependencyProperty.Register("FilterRecordLocation", typeof(global::Infragistics.Windows.DataPresenter.FilterRecordLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterRecordLocation.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C22 RID: 3106
		public static readonly global::System.Windows.DependencyProperty FilterUITypeProperty = global::System.Windows.DependencyProperty.Register("FilterUIType", typeof(global::Infragistics.Windows.DataPresenter.FilterUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FilterUIType.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnFilterUITypeChanged)));

		// Token: 0x04000C23 RID: 3107
		public static readonly global::System.Windows.DependencyProperty FixedFieldUITypeProperty = global::System.Windows.DependencyProperty.Register("FixedFieldUIType", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnFixedFieldUITypeChanged)));

		// Token: 0x04000C24 RID: 3108
		public static readonly global::System.Windows.DependencyProperty FixedRecordLimitProperty = global::System.Windows.DependencyProperty.Register("FixedRecordLimit", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ValidateFixedRecordLimit));

		// Token: 0x04000C25 RID: 3109
		public static readonly global::System.Windows.DependencyProperty FixedRecordUITypeProperty = global::System.Windows.DependencyProperty.Register("FixedRecordUIType", typeof(global::Infragistics.Windows.DataPresenter.FixedRecordUIType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Default));

		// Token: 0x04000C26 RID: 3110
		public static readonly global::System.Windows.DependencyProperty FixedRecordSortOrderProperty = global::System.Windows.DependencyProperty.Register("FixedRecordSortOrder", typeof(global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Default));

		// Token: 0x04000C27 RID: 3111
		public static readonly global::System.Windows.DependencyProperty GroupByEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("GroupByEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Default));

		// Token: 0x04000C28 RID: 3112
		public static readonly global::System.Windows.DependencyProperty GroupByExpansionIndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("GroupByExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C29 RID: 3113
		public static readonly global::System.Windows.DependencyProperty GroupBySummaryDisplayModeProperty = global::System.Windows.DependencyProperty.Register("GroupBySummaryDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Default));

		// Token: 0x04000C2A RID: 3114
		public static readonly global::System.Windows.DependencyProperty HeaderPlacementProperty = global::System.Windows.DependencyProperty.Register("HeaderPlacement", typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacement), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnHeaderPlacementChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHeaderPlacementValid));

		// Token: 0x04000C2B RID: 3115
		private global::Infragistics.Windows.DataPresenter.HeaderPlacement _cachedHeaderPlacement;

		// Token: 0x04000C2C RID: 3116
		public static readonly global::System.Windows.DependencyProperty HeaderPlacementInGroupByProperty = global::System.Windows.DependencyProperty.Register("HeaderPlacementInGroupBy", typeof(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnHeaderPlacementInGroupByChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHeaderPlacementInGroupByValid));

		// Token: 0x04000C2D RID: 3117
		private global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy _cachedHeaderPlacementInGroupBy;

		// Token: 0x04000C2E RID: 3118
		public static readonly global::System.Windows.DependencyProperty HeaderPresenterStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderPresenterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C2F RID: 3119
		public static readonly global::System.Windows.DependencyProperty HeaderLabelAreaStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderLabelAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C30 RID: 3120
		public static readonly global::System.Windows.DependencyProperty HeaderPrefixAreaDisplayModeProperty = global::System.Windows.DependencyProperty.Register("HeaderPrefixAreaDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C31 RID: 3121
		public static readonly global::System.Windows.DependencyProperty HeaderPrefixAreaStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderPrefixAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C32 RID: 3122
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty HighlightAlternateRecordsProperty = global::System.Windows.DependencyProperty.Register("HighlightAlternateRecords", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C33 RID: 3123
		public static readonly global::System.Windows.DependencyProperty HighlightPrimaryFieldProperty = global::System.Windows.DependencyProperty.Register("HighlightPrimaryField", typeof(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsHighlightPrimaryFieldValid));

		// Token: 0x04000C34 RID: 3124
		public static readonly global::System.Windows.DependencyProperty LabelLocationProperty = global::System.Windows.DependencyProperty.Register("LabelLocation", typeof(global::Infragistics.Windows.DataPresenter.LabelLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.LabelLocation.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnLabelLocationChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsLabelLocationValid));

		// Token: 0x04000C35 RID: 3125
		private global::Infragistics.Windows.DataPresenter.LabelLocation _cachedLabelLocation;

		// Token: 0x04000C36 RID: 3126
		public static readonly global::System.Windows.DependencyProperty MaxFieldsToAutoGenerateProperty = global::System.Windows.DependencyProperty.Register("MaxFieldsToAutoGenerate", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04000C37 RID: 3127
		public static readonly global::System.Windows.DependencyProperty MaxSelectedCellsProperty = global::System.Windows.DependencyProperty.Register("MaxSelectedCells", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnValidateMaxSelected));

		// Token: 0x04000C38 RID: 3128
		public static readonly global::System.Windows.DependencyProperty MaxSelectedRecordsProperty = global::System.Windows.DependencyProperty.Register("MaxSelectedRecords", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnValidateMaxSelected));

		// Token: 0x04000C39 RID: 3129
		public static readonly global::System.Windows.DependencyProperty RecordFilterScopeProperty = global::System.Windows.DependencyProperty.Register("RecordFilterScope", typeof(global::Infragistics.Windows.DataPresenter.RecordFilterScope), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C3A RID: 3130
		public static readonly global::System.Windows.DependencyProperty RecordFiltersLogicalOperatorProperty = global::System.Windows.DependencyProperty.Register("RecordFiltersLogicalOperator", typeof(global::Infragistics.Windows.Controls.LogicalOperator?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C3B RID: 3131
		public static readonly global::System.Windows.DependencyProperty RecordListControlStyleProperty = global::System.Windows.DependencyProperty.Register("RecordListControlStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C3C RID: 3132
		public static readonly global::System.Windows.DependencyProperty RecordResizingAreaProperty = global::System.Windows.DependencyProperty.Register("RecordResizingArea", typeof(global::Infragistics.Windows.DataPresenter.RecordResizingArea), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordResizingArea.Default));

		// Token: 0x04000C3D RID: 3133
		public static readonly global::System.Windows.DependencyProperty RecordSelectorLocationProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorLocation", typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorLocationValid));

		// Token: 0x04000C3E RID: 3134
		public static readonly global::System.Windows.DependencyProperty RecordSelectorExtentProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorExtentValid));

		// Token: 0x04000C3F RID: 3135
		public static readonly global::System.Windows.DependencyProperty RecordSelectorNumberFormatProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorNumberFormat", typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorNumberFormatValid));

		// Token: 0x04000C40 RID: 3136
		public static readonly global::System.Windows.DependencyProperty RecordSelectorNumberStartProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorNumberStart", typeof(int?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C41 RID: 3137
		public static readonly global::System.Windows.DependencyProperty RecordSelectorNumberStyleProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorNumberStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C42 RID: 3138
		public static readonly global::System.Windows.DependencyProperty RecordSelectorNumberStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorNumberStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C43 RID: 3139
		public static readonly global::System.Windows.DependencyProperty RecordSelectorNumberTypeProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorNumberType", typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsRecordSelectorNumberTypeValid));

		// Token: 0x04000C44 RID: 3140
		public static readonly global::System.Windows.DependencyProperty RecordSelectorStyleProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C45 RID: 3141
		public static readonly global::System.Windows.DependencyProperty RecordSelectorStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000C46 RID: 3142
		public static readonly global::System.Windows.DependencyProperty RecordSeparatorLocationProperty = global::System.Windows.DependencyProperty.Register("RecordSeparatorLocation", typeof(global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C47 RID: 3143
		public static readonly global::System.Windows.DependencyProperty ReevaluateFiltersOnDataChangeProperty = global::System.Windows.DependencyProperty.Register("ReevaluateFiltersOnDataChange", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C48 RID: 3144
		public static readonly global::System.Windows.DependencyProperty ReevaluateFiltersOnRecordsAddedProperty = global::System.Windows.DependencyProperty.Register("ReevaluateFiltersOnRecordsAdded", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000C49 RID: 3145
		public static readonly global::System.Windows.DependencyProperty ResizingModeProperty = global::System.Windows.DependencyProperty.Register("ResizingMode", typeof(global::Infragistics.Windows.Controls.ResizingMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ResizingMode.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsResizingModeValid));

		// Token: 0x04000C4A RID: 3146
		public static readonly global::System.Windows.DependencyProperty SelectionTypeCellProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeCell", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000C4B RID: 3147
		public static readonly global::System.Windows.DependencyProperty SelectionTypeFieldProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeField", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000C4C RID: 3148
		public static readonly global::System.Windows.DependencyProperty SelectionTypeRecordProperty = global::System.Windows.DependencyProperty.Register("SelectionTypeRecord", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.IsSelectionTypeValid));

		// Token: 0x04000C4D RID: 3149
		public static readonly global::System.Windows.DependencyProperty SortEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SortEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.SortEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Default));

		// Token: 0x04000C4E RID: 3150
		public static readonly global::System.Windows.DependencyProperty SpecialRecordOrderProperty = global::System.Windows.DependencyProperty.Register("SpecialRecordOrder", typeof(global::Infragistics.Windows.DataPresenter.SpecialRecordOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.OnSpecialRecordOrderChanged)));

		// Token: 0x04000C4F RID: 3151
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionVisibilityProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C50 RID: 3152
		public static readonly global::System.Windows.DependencyProperty SummaryEvaluationModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SummaryEvaluationMode", typeof(global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Default));

		// Token: 0x04000C51 RID: 3153
		public static readonly global::System.Windows.DependencyProperty SupportDataErrorInfoProperty = global::System.Windows.DependencyProperty.Register("SupportDataErrorInfo", typeof(global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.Default, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
