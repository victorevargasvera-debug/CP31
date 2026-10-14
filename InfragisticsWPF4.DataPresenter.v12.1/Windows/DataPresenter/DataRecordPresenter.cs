using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000326 RID: 806
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord_AlternateRow", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	public class DataRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x060026AD RID: 9901 RVA: 0x000A8574 File Offset: 0x000A6774
		static DataRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter)));
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000A87C4 File Offset: 0x000A69C4
		internal override global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty)
		{
			if (!global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplatesCached)
			{
				lock (typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter))
				{
					if (!global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplatesCached)
					{
						global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplatesCached = true;
						global::System.Windows.Style dataRecordPresenter = global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.DataRecordPresenter;
						if (dataRecordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplate = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(dataRecordPresenter, global::System.Windows.Controls.Control.TemplateProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplateTabluar = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(dataRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplateCardView = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(dataRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
						}
					}
				}
			}
			if (templateProperty == global::System.Windows.Controls.Control.TemplateProperty)
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplate;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplateTabluar;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordPresenter.s_DefaultTemplateCardView;
			}
			return null;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000A8890 File Offset: 0x000A6A90
		internal override global::System.Windows.DataTemplate GetRecordContentAreaTemplate(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator generator)
		{
			if (base.Record is global::Infragistics.Windows.DataPresenter.TemplateDataRecord)
			{
				return generator.TemplateDataRecordContentAreaTemplate;
			}
			return generator.GeneratedVirtualRecordContentAreaTemplate;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000A88AC File Offset: 0x000A6AAC
		internal override global::Infragistics.Windows.DataPresenter.Record GetRecordForMeasure()
		{
			if (this._headerRecordCollection != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._headerRecordCollection) as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
				if (viewableRecordCollection != null && viewableRecordCollection.Count > 0)
				{
					return viewableRecordCollection[0];
				}
			}
			return base.Record;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000A88EC File Offset: 0x000A6AEC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000A88F4 File Offset: 0x000A6AF4
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled && base.IsHeaderRecord && !base.ShouldDisplayRecordContent && !base.ShouldDisplayGroupByRecordContent)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = dependencyObject as global::Infragistics.Windows.DataPresenter.LabelPresenter;
					if (labelPresenter == null)
					{
						labelPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true, this) as global::Infragistics.Windows.DataPresenter.LabelPresenter);
					}
					if (labelPresenter != null && labelPresenter.Field != null && labelPresenter.Field.LabelClickActionResolved != global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing)
					{
						return;
					}
				}
				e.Handled = true;
			}
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000A897C File Offset: 0x000A6B7C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (base.IsClearingBindings)
			{
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordProperty)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = e.NewValue as global::Infragistics.Windows.DataPresenter.DataRecord;
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataRecordPropertyKey, dataRecord);
				if (dataRecord != null && !base.IsHeaderRecord)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsAddRecord));
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsDataChangedPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsDataChanged));
					return;
				}
			}
			else if (e.Property == global::System.Windows.UIElement.VisibilityProperty)
			{
				if (global::System.Windows.Visibility.Collapsed.Equals(e.OldValue))
				{
					this.RefreshAutoFitExtent(false);
					return;
				}
			}
			else if (e.Property == global::System.Windows.FrameworkElement.ActualHeightProperty || e.Property == global::System.Windows.FrameworkElement.ActualWidthProperty)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout != null)
				{
					if (e.Property == global::System.Windows.FrameworkElement.ActualHeightProperty && fieldLayout.IsAutoFitHeight)
					{
						this.UpdateAutoFitProperties();
					}
					if (e.Property == global::System.Windows.FrameworkElement.ActualWidthProperty && fieldLayout.IsAutoFitWidth)
					{
						this.UpdateAutoFitProperties();
					}
				}
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000A8A86 File Offset: 0x000A6C86
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			base.OnRecordChanged(oldRecord, newRecord);
			this.UpdateDataError();
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000A8A98 File Offset: 0x000A6C98
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnRecordPropertyChanged(e);
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "IsAddRecord")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(((global::Infragistics.Windows.DataPresenter.DataRecord)base.Record).IsAddRecord));
					return;
				}
				if (propertyName == "IsDataChanged")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsDataChangedPropertyKey, global::Infragistics.KnownBoxes.FromValue(((global::Infragistics.Windows.DataPresenter.DataRecord)base.Record).IsDataChanged));
					return;
				}
				if (!(propertyName == "DataError"))
				{
					return;
				}
				this.UpdateDataError();
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000A8B28 File Offset: 0x000A6D28
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			if (base.IsFilterRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilterRecord", useTransitions);
			}
			else if (this.IsAddRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "AddRecord", useTransitions);
			}
			else if (base.IsAlternate)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"DataRecord_AlternateRow",
					"DataRecord"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "DataRecord", useTransitions);
			}
			if (this.HasDataError)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "InvalidEx", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "ValidEx", useTransitions);
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000A8BC4 File Offset: 0x000A6DC4
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x000A8BF7 File Offset: 0x000A6DF7
		internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel AssociatedVirtualizingDataRecordCellPanel
		{
			get
			{
				if (this.associatedVirtualizingDataRecordCellPanel == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this.associatedVirtualizingDataRecordCellPanel) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
				if (virtualizingDataRecordCellPanel == null)
				{
					this.associatedVirtualizingDataRecordCellPanel = null;
				}
				return virtualizingDataRecordCellPanel;
			}
			set
			{
				if (value == null)
				{
					this.associatedVirtualizingDataRecordCellPanel = null;
					return;
				}
				this.associatedVirtualizingDataRecordCellPanel = new global::System.WeakReference(value);
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000A8C10 File Offset: 0x000A6E10
		private static void OnAutoFitExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = target as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter == null || dataRecordPresenter.TreatAsCollapsed || !dataRecordPresenter.IsVisible)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = dataRecordPresenter.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
				if (fieldLayout != null)
				{
					if (fieldLayout.IsAutoFitWidth && e.Property == global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthProperty)
					{
						fieldLayout.TemplateDataRecordCache.SetCachedAutoFitWidth(dataRecord, (double)e.NewValue);
					}
					if (fieldLayout.IsAutoFitHeight && e.Property == global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightProperty)
					{
						fieldLayout.TemplateDataRecordCache.SetCachedAutoFitHeight(dataRecord, (double)e.NewValue);
					}
				}
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x000A8CB5 File Offset: 0x000A6EB5
		internal double AutoFitCellAreaHeight
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CalculateCellAreaAutoFitExtent(this, false);
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000A8CBE File Offset: 0x000A6EBE
		internal double AutoFitCellAreaWidth
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CalculateCellAreaAutoFitExtent(this, true);
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000A8CC7 File Offset: 0x000A6EC7
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty);
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x000A8CD4 File Offset: 0x000A6ED4
		internal void UpdateDataError()
		{
			bool flag = false;
			object value = null;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.DataRecord;
			if (dataRecord != null)
			{
				value = dataRecord.DataError;
				flag = dataRecord.HasDataError;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorPropertyKey, value);
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey, flag);
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x000A8D1A File Offset: 0x000A6F1A
		public global::Infragistics.Windows.DataPresenter.DataRecord DataRecord
		{
			get
			{
				return base.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000A8D27 File Offset: 0x000A6F27
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty);
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000A8D39 File Offset: 0x000A6F39
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsAddRecordProperty);
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000A8D4B File Offset: 0x000A6F4B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsDataChangedProperty);
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x000A8D5D File Offset: 0x000A6F5D
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x000A8D6F File Offset: 0x000A6F6F
		public global::System.Windows.Media.Brush HeaderAreaBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty, value);
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000A8D7D File Offset: 0x000A6F7D
		internal override void PrepareContainerForItem(object item, bool isUsedForHeaderOnly)
		{
			base.PrepareContainerForItem(item, isUsedForHeaderOnly);
			if (item == null)
			{
				return;
			}
			this.RefreshAutoFitExtent(true);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x000A8D94 File Offset: 0x000A6F94
		public global::Infragistics.Windows.DataPresenter.CellValuePresenter[] GetChildCellValuePresenters()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter> childCellValuePresenterList = this.GetChildCellValuePresenterList();
			global::Infragistics.Windows.DataPresenter.CellValuePresenter[] array = new global::Infragistics.Windows.DataPresenter.CellValuePresenter[childCellValuePresenterList.Count];
			if (childCellValuePresenterList.Count > 0)
			{
				childCellValuePresenterList.CopyTo(array);
			}
			return array;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x000A8DC8 File Offset: 0x000A6FC8
		internal void OnRecordResized()
		{
			base.InvalidateMeasure();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPresenter> childCellPresenterList = this.GetChildCellPresenterList();
			global::System.Windows.UIElement uielement;
			if (childCellPresenterList.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter in childCellPresenterList)
				{
					cellPresenter.OnRecordResized();
				}
				uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(childCellPresenterList[0]) as global::System.Windows.UIElement);
			}
			else
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter> childCellValuePresenterList = this.GetChildCellValuePresenterList();
				foreach (global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter in childCellValuePresenterList)
				{
					cellValuePresenter.InvalidateMeasure();
				}
				uielement = ((childCellValuePresenterList.Count > 0) ? (global::System.Windows.Media.VisualTreeHelper.GetParent(childCellValuePresenterList[0]) as global::System.Windows.UIElement) : null);
			}
			if (uielement is global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)
			{
				uielement.InvalidateMeasure();
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000A8EB4 File Offset: 0x000A70B4
		internal void SetHeaderRecordCollection(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection records)
		{
			this._headerRecordCollection = ((records == null) ? null : new global::System.WeakReference(records));
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000A8EC8 File Offset: 0x000A70C8
		internal static double CalculateCellAreaAutoFitExtent(global::Infragistics.Windows.DataPresenter.RecordPresenter rp, bool isAutoFitWidth)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			if (fieldLayout == null)
			{
				return double.NaN;
			}
			if (isAutoFitWidth)
			{
				if (!fieldLayout.IsAutoFitWidth)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null && dataRecordPresenter._cachedAutoFitExtent != null && dataRecordPresenter._cachedAutoFitExtent._width != null)
				{
					return dataRecordPresenter._cachedAutoFitExtent._width.Value;
				}
			}
			else
			{
				if (!fieldLayout.IsAutoFitHeight)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter2 = rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter2 != null && dataRecordPresenter2._cachedAutoFitExtent != null && dataRecordPresenter2._cachedAutoFitExtent._height != null)
				{
					return dataRecordPresenter2._cachedAutoFitExtent._height.Value;
				}
			}
			global::System.Windows.FrameworkElement frameworkElement = null;
			global::System.Windows.FrameworkElement frameworkElement2 = null;
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter.GetCellAreaAndRestrictToElement(rp, ref frameworkElement2, ref frameworkElement, out flag);
			if (frameworkElement == null || (isAutoFitWidth && frameworkElement.ActualWidth < 1.0) || (!isAutoFitWidth && frameworkElement.ActualHeight < 1.0) || frameworkElement2 == null)
			{
				return double.NaN;
			}
			global::System.Windows.Point point = flag ? default(global::System.Windows.Point) : frameworkElement2.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), frameworkElement);
			if (!flag)
			{
				global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement2, typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), true, rp) as global::Infragistics.Windows.DataPresenter.RecordCellAreaBase;
				if (recordCellAreaBase != null)
				{
					global::System.Windows.Media.GeneralTransform generalTransform = recordCellAreaBase.RenderTransform;
					if (generalTransform != global::System.Windows.Media.Transform.Identity && generalTransform != null)
					{
						generalTransform = generalTransform.Inverse;
						point = generalTransform.Transform(point);
					}
				}
			}
			double num = 0.0;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = rp.Record;
				if (record != null)
				{
					num += record.FieldLayout.TemplateDataRecordCache.GetVirtPanelOffset(true, true);
				}
				while (record != null)
				{
					num += record.FarOffset;
					record = record.ParentRecord;
					if (record != null)
					{
						num += record.FieldLayout.TemplateDataRecordCache.GetNestedContentChrome(record, true);
					}
				}
			}
			global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = frameworkElement as global::System.Windows.Controls.ScrollContentPresenter;
			if (scrollContentPresenter != null)
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = null;
				if (scrollContentPresenter.CanContentScroll)
				{
					scrollInfo = (scrollContentPresenter.Content as global::System.Windows.Controls.Primitives.IScrollInfo);
					if (scrollInfo == null)
					{
						global::System.Windows.Controls.ItemsPresenter itemsPresenter = scrollContentPresenter.Content as global::System.Windows.Controls.ItemsPresenter;
						if (itemsPresenter != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(itemsPresenter) > 0)
						{
							scrollInfo = (global::System.Windows.Media.VisualTreeHelper.GetChild(itemsPresenter, 0) as global::System.Windows.Controls.Primitives.IScrollInfo);
						}
					}
				}
				if (scrollInfo == null)
				{
					scrollInfo = scrollContentPresenter;
				}
				if (scrollInfo != null)
				{
					if (isAutoFitWidth)
					{
						num += scrollInfo.HorizontalOffset;
					}
					else
					{
						num += scrollInfo.VerticalOffset;
					}
				}
			}
			if (isAutoFitWidth)
			{
				return global::System.Math.Max(frameworkElement.ActualWidth - (num + point.X), 1.0);
			}
			return global::System.Math.Max(frameworkElement.ActualHeight - (num + point.Y), 1.0);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000A9170 File Offset: 0x000A7370
		private static void GetCellAreaAndRestrictToElement(global::Infragistics.Windows.DataPresenter.RecordPresenter rp, ref global::System.Windows.FrameworkElement cellPanel, ref global::System.Windows.FrameworkElement clipToElement, out bool isScaled)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = rp.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ViewBase viewBase = (dataPresenter == null) ? null : dataPresenter.CurrentViewInternal;
			global::System.Type type;
			if (viewBase != null && viewBase.AutoFitToRecord)
			{
				type = viewBase.RecordPresenterContainerType;
			}
			else
			{
				type = typeof(global::Infragistics.Windows.DataPresenter.RecordListControl);
			}
			if (type != null)
			{
				clipToElement = (global::Infragistics.Windows.DataPresenter.DataRecordPresenter.GetAutoFitScrollPresenter(rp, type, out isScaled) as global::System.Windows.Controls.ScrollContentPresenter);
			}
			else
			{
				isScaled = false;
			}
			if (clipToElement == null && type != typeof(global::Infragistics.Windows.DataPresenter.RecordListControl))
			{
				clipToElement = rp;
			}
			if (clipToElement == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter != null)
			{
				cellPanel = dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel;
			}
			if (cellPanel == null)
			{
				cellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(rp, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel);
			}
			if (cellPanel == null)
			{
				if (rp is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)
				{
					cellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(rp, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea), true) as global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea);
				}
				else
				{
					cellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(rp, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), true) as global::Infragistics.Windows.DataPresenter.DataRecordCellArea);
				}
				if (cellPanel == null)
				{
					cellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(rp, typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), true) as global::Infragistics.Windows.DataPresenter.HeaderLabelArea);
					return;
				}
			}
			if (viewBase != null && !viewBase.IsNestedPanelsSupported)
			{
				return;
			}
			global::System.Windows.Controls.Panel currentPanel = dataPresenter.CurrentPanel;
			if (currentPanel != null)
			{
				clipToElement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(currentPanel, typeof(global::System.Windows.Controls.ScrollContentPresenter), true, null, type) as global::System.Windows.Controls.ScrollContentPresenter);
				if (clipToElement != null)
				{
					return;
				}
			}
			while (clipToElement != null && rp.Record != null && rp.Record.ParentDataRecord != null)
			{
				rp = (global::Infragistics.Windows.Utilities.GetAncestorFromType(clipToElement, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true, dataPresenter) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (rp == null)
				{
					return;
				}
				clipToElement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(rp, typeof(global::System.Windows.Controls.ScrollContentPresenter), true, null, type) as global::System.Windows.Controls.ScrollContentPresenter);
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000A9300 File Offset: 0x000A7500
		private static global::System.Windows.DependencyObject GetAutoFitScrollPresenter(global::System.Windows.FrameworkElement descendant, global::System.Type stopAtType, out bool isScaled)
		{
			isScaled = false;
			global::System.Windows.DependencyObject dependencyObject = descendant;
			for (;;)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				if (dependencyObject is global::System.Windows.Controls.Viewbox && ((global::System.Windows.Controls.Viewbox)dependencyObject).Stretch != global::System.Windows.Media.Stretch.None)
				{
					isScaled = true;
				}
				else if (dependencyObject is global::System.Windows.Controls.ScrollContentPresenter)
				{
					break;
				}
				if (dependencyObject == null || stopAtType.IsAssignableFrom(dependencyObject.GetType()))
				{
					return dependencyObject;
				}
			}
			return (global::System.Windows.Controls.ScrollContentPresenter)dependencyObject;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000A9354 File Offset: 0x000A7554
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter> GetChildCellValuePresenterList()
		{
			if (base.FieldLayout == null)
			{
				return new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter>();
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValuePresenter>(base.FieldLayout.Fields.Count);
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), false) as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea == null)
			{
				return list;
			}
			global::System.Windows.UIElement uielement = dataRecordCellArea.Content as global::System.Windows.UIElement;
			if (!(uielement is global::System.Windows.Controls.Grid) && !(uielement is global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel))
			{
				return list;
			}
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(uielement);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(uielement, i);
				if (child is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
				{
					list.Add(child as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.Utilities.GetDescendantFromType(child, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), true) as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
					if (cellValuePresenter != null)
					{
						list.Add(cellValuePresenter);
					}
				}
			}
			return list;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000A9420 File Offset: 0x000A7620
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPresenter> GetChildCellPresenterList()
		{
			if (base.FieldLayout == null)
			{
				return new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPresenter>();
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPresenter>(base.FieldLayout.Fields.Count);
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), false) as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea == null)
			{
				return list;
			}
			global::System.Windows.UIElement uielement = dataRecordCellArea.Content as global::System.Windows.UIElement;
			if (!(uielement is global::System.Windows.Controls.Grid) && !(uielement is global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel))
			{
				return list;
			}
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(uielement);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(uielement, i);
				if (child is global::Infragistics.Windows.DataPresenter.CellPresenter)
				{
					list.Add(child as global::Infragistics.Windows.DataPresenter.CellPresenter);
				}
			}
			return list;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000A94C4 File Offset: 0x000A76C4
		private void RefreshAutoFitExtent(bool calledFromPrepare)
		{
			this._cachedAutoFitExtent = null;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = base.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
				if (fieldLayout != null && fieldLayout.IsAutoFit)
				{
					double? width = null;
					double? height = null;
					if (fieldLayout.IsAutoFitWidth)
					{
						width = fieldLayout.TemplateDataRecordCache.GetCachedAutoFitWidth(dataRecord);
						if (width != null)
						{
							base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthPropertyKey, width.Value);
						}
					}
					if (fieldLayout.IsAutoFitHeight)
					{
						height = fieldLayout.TemplateDataRecordCache.GetCachedAutoFitHeight(dataRecord);
						if (height != null)
						{
							base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightPropertyKey, height.Value);
						}
					}
					if (width != null || height != null)
					{
						this._cachedAutoFitExtent = new global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CachedAutoFitExtent();
						this._cachedAutoFitExtent._width = width;
						this._cachedAutoFitExtent._height = height;
						if (!calledFromPrepare)
						{
							global::System.Windows.UIElement uielement = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this.associatedVirtualizingDataRecordCellPanel) as global::System.Windows.UIElement;
							if (uielement != null)
							{
								global::Infragistics.Windows.Utilities.InvalidateMeasure(uielement, this);
								uielement.InvalidateMeasure();
							}
						}
					}
				}
			}
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000A95E4 File Offset: 0x000A77E4
		internal override void UpdateAutoFitProperties()
		{
			if (!base.IsArrangedInView)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter.ClearAutoFitCellAreaProperties(this);
				return;
			}
			base.UpdateAutoFitProperties();
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter.UpdateAutoFitPropertiesHelper(this);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000A9601 File Offset: 0x000A7801
		internal static void ClearAutoFitCellAreaProperties(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			rp.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthPropertyKey);
			rp.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightPropertyKey);
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000A961C File Offset: 0x000A781C
		internal static void UpdateAutoFitPropertiesHelper(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			if (rp.IsHeaderRecord)
			{
				if (!rp.HasHeaderContent)
				{
					return;
				}
			}
			else if (!rp.ShouldDisplayRecordContent)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			if (fieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter != null && dataRecordPresenter._cachedAutoFitExtent != null)
			{
				dataRecordPresenter._cachedAutoFitExtent = null;
			}
			if (fieldLayout.IsAutoFitWidth)
			{
				double num = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CalculateCellAreaAutoFitExtent(rp, true);
				if (dataRecordPresenter != null)
				{
					fieldLayout.TemplateDataRecordCache.SetCachedAutoFitWidth(rp.Record, num);
				}
				rp.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthPropertyKey, num);
			}
			else
			{
				rp.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthPropertyKey);
			}
			if (fieldLayout.IsAutoFitHeight)
			{
				double num2 = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CalculateCellAreaAutoFitExtent(rp, false);
				if (dataRecordPresenter != null)
				{
					fieldLayout.TemplateDataRecordCache.SetCachedAutoFitHeight(rp.Record, num2);
				}
				rp.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightPropertyKey, num2);
				return;
			}
			rp.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightPropertyKey);
		}

		// Token: 0x04001251 RID: 4689
		private global::System.WeakReference associatedVirtualizingDataRecordCellPanel;

		// Token: 0x04001252 RID: 4690
		private global::System.WeakReference _headerRecordCollection;

		// Token: 0x04001253 RID: 4691
		private global::Infragistics.Windows.DataPresenter.DataRecordPresenter.CachedAutoFitExtent _cachedAutoFitExtent;

		// Token: 0x04001254 RID: 4692
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x04001255 RID: 4693
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x04001256 RID: 4694
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x04001257 RID: 4695
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x04001258 RID: 4696
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitCellAreaHeightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoFitCellAreaHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.OnAutoFitExtentChanged)));

		// Token: 0x04001259 RID: 4697
		internal static readonly global::System.Windows.DependencyProperty AutoFitCellAreaHeightProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightPropertyKey.DependencyProperty;

		// Token: 0x0400125A RID: 4698
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitCellAreaWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoFitCellAreaWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.OnAutoFitExtentChanged)));

		// Token: 0x0400125B RID: 4699
		internal static readonly global::System.Windows.DependencyProperty AutoFitCellAreaWidthProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthPropertyKey.DependencyProperty;

		// Token: 0x0400125C RID: 4700
		internal static readonly global::System.Windows.DependencyPropertyKey DataErrorPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DataError", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400125D RID: 4701
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorPropertyKey.DependencyProperty;

		// Token: 0x0400125E RID: 4702
		private static readonly global::System.Windows.DependencyPropertyKey DataRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DataRecord", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x0400125F RID: 4703
		public static readonly global::System.Windows.DependencyProperty DataRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataRecordPropertyKey.DependencyProperty;

		// Token: 0x04001260 RID: 4704
		internal static readonly global::System.Windows.DependencyPropertyKey HasDataErrorPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasDataError", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001261 RID: 4705
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey.DependencyProperty;

		// Token: 0x04001262 RID: 4706
		private static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001263 RID: 4707
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsAddRecordPropertyKey.DependencyProperty;

		// Token: 0x04001264 RID: 4708
		private static readonly global::System.Windows.DependencyPropertyKey IsDataChangedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataChanged", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));

		// Token: 0x04001265 RID: 4709
		public static readonly global::System.Windows.DependencyProperty IsDataChangedProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.IsDataChangedPropertyKey.DependencyProperty;

		// Token: 0x04001266 RID: 4710
		public static readonly global::System.Windows.DependencyProperty HeaderAreaBackgroundProperty = global::System.Windows.DependencyProperty.Register("HeaderAreaBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x02000327 RID: 807
		private class CachedAutoFitExtent
		{
			// Token: 0x04001267 RID: 4711
			internal double? _height;

			// Token: 0x04001268 RID: 4712
			internal double? _width;
		}
	}
}
