using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using System.Xml;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002FC RID: 764
	[global::System.ComponentModel.DefaultProperty("Fields")]
	[global::System.Windows.Markup.ContentProperty("Fields")]
	public class FieldLayout : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x00099B1C File Offset: 0x00097D1C
		static FieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty = global::System.Windows.FrameworkElement.DataContextProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnDataContextChanged)));
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00099F5E File Offset: 0x0009815E
		internal FieldLayout(bool isAutoCreated) : this()
		{
			this.IsAutoCreated = isAutoCreated;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00099F70 File Offset: 0x00098170
		public FieldLayout()
		{
			this._fields = new global::Infragistics.Windows.DataPresenter.FieldCollection(this);
			this._fields.CollectionChanged += this.OnFieldCollectionChanged;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00099FE0 File Offset: 0x000981E0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::Infragistics.Windows.DataPresenter.FieldLayout.DescriptionProperty)
			{
				this._cachedDescription = (e.NewValue as string);
				global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this._presenter, this, "Description", null);
			}
			else if (property == global::Infragistics.Windows.DataPresenter.FieldLayout.KeyProperty)
			{
				this._cachedKey = e.NewValue;
				this._keyExplicitlySet = true;
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DescriptionProperty);
			}
			else if (property == global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty)
			{
				if (this._presenter != null)
				{
					this._presenter.ClearStyleCache();
				}
				this.BumpTemplateVersion(true);
			}
			else if (property == global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty)
			{
				if (e.OldValue != null)
				{
					((global::Infragistics.Windows.DataPresenter.FieldSettings)e.OldValue).PropertyChanged -= this.OnFieldSettingsPropertyChanged;
				}
				if ((global::Infragistics.Windows.DataPresenter.FieldSettings)e.NewValue != this._cachedFieldSettings)
				{
					this._cachedFieldSettings = (global::Infragistics.Windows.DataPresenter.FieldSettings)e.NewValue;
					this.OnNewFieldSettings();
				}
			}
			base.RaisePropertyChangedEvent(property.Name);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x0009A0E0 File Offset: 0x000982E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.Description);
			stringBuilder.Append(" - ");
			stringBuilder.Append(this.Fields.Count.ToString());
			stringBuilder.Append(" Fields");
			if (this._presenter != null)
			{
				stringBuilder.Append(" - index = ");
				stringBuilder.Append(this._presenter.FieldLayouts.IndexOf(this).ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0009A16C File Offset: 0x0009836C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.AddNewRecordLocation AddNewRecordLocationResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.AddNewRecordLocation addNewRecordLocation = this._settings.AddNewRecordLocation;
					if (addNewRecordLocation != global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default)
					{
						return addNewRecordLocation;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.AddNewRecordLocation addNewRecordLocation = this._presenter.FieldLayoutSettings.AddNewRecordLocation;
					if (addNewRecordLocation != global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default)
					{
						return addNewRecordLocation;
					}
				}
				return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x0009A1C0 File Offset: 0x000983C0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AllowAddNewResolved
		{
			get
			{
				if (this.IsTreeView)
				{
					return false;
				}
				if (this._presenter != null && this._presenter.IsReportControl)
				{
					return false;
				}
				if (this._settings != null)
				{
					bool? allowAddNew = this._settings.AllowAddNew;
					if (allowAddNew != null)
					{
						return allowAddNew.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					bool? allowAddNew = this._presenter.FieldLayoutSettings.AllowAddNew;
					if (allowAddNew != null)
					{
						return allowAddNew.Value;
					}
				}
				return false;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0009A24C File Offset: 0x0009844C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AllowDeleteResolved
		{
			get
			{
				if (this._settings != null)
				{
					bool? allowDelete = this._settings.AllowDelete;
					if (allowDelete != null)
					{
						return allowDelete.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					bool? allowDelete = this._presenter.FieldLayoutSettings.AllowDelete;
					if (allowDelete != null)
					{
						return allowDelete.Value;
					}
				}
				return true;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0009A2B8 File Offset: 0x000984B8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldMoving AllowFieldMovingResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.AllowFieldMovingResolved;
				}
				global::Infragistics.Windows.DataPresenter.AllowFieldMoving allowFieldMoving = (this._settings != null) ? this._settings.AllowFieldMoving : global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Default;
				if (allowFieldMoving == global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Default)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
					if (fieldLayoutSettings != null)
					{
						allowFieldMoving = fieldLayoutSettings.AllowFieldMoving;
					}
					if (allowFieldMoving == global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Default)
					{
						if (this.IsTreeView)
						{
							return global::Infragistics.Windows.DataPresenter.AllowFieldMoving.WithinLogicalRow;
						}
						allowFieldMoving = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Yes;
					}
				}
				return allowFieldMoving;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0009A324 File Offset: 0x00098524
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.AllowRecordFixing AllowRecordFixingResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.AllowRecordFixing allowRecordFixing = (this._settings != null) ? this._settings.AllowRecordFixing : global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Default;
				if (allowRecordFixing == global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Default)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
					if (fieldLayoutSettings != null)
					{
						allowRecordFixing = fieldLayoutSettings.AllowRecordFixing;
					}
					if (allowRecordFixing == global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Default)
					{
						allowRecordFixing = global::Infragistics.Windows.DataPresenter.AllowRecordFixing.No;
					}
				}
				return allowRecordFixing;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0009A372 File Offset: 0x00098572
		public bool AutoFitToHeight
		{
			get
			{
				return this.IsAutoFitHeight;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x0009A37A File Offset: 0x0009857A
		public bool AutoFitToWidth
		{
			get
			{
				return this.IsAutoFitWidth;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x0009A384 File Offset: 0x00098584
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AutoGenerateFieldsResolved
		{
			get
			{
				if (this._presenter != null && this._presenter.BindToSampleData && this._presenter.DataSource == global::Infragistics.Windows.Internal.DataBindingUtilities.GetSampleData())
				{
					return true;
				}
				if (this._settings != null)
				{
					bool? autoGenerateFields = this._settings.AutoGenerateFields;
					if (autoGenerateFields != null)
					{
						return autoGenerateFields.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					bool? autoGenerateFields = this._presenter.FieldLayoutSettings.AutoGenerateFields;
					if (autoGenerateFields != null)
					{
						return autoGenerateFields.Value;
					}
				}
				return true;
			}
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0009A418 File Offset: 0x00098618
		private static void OnCalculationReferenceIdChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			fieldLayout._calculationRefernceId = (e.NewValue as string);
			global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(fieldLayout._presenter, fieldLayout, "CalculationReferenceId", e);
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0009A455 File Offset: 0x00098655
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0009A45D File Offset: 0x0009865D
		public string CalculationReferenceId
		{
			get
			{
				return this._calculationRefernceId;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.CalculationReferenceIdProperty, value);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0009A46B File Offset: 0x0009866B
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				if (this._cachedCellPresentation == null)
				{
					this._cachedCellPresentation = new global::Infragistics.Windows.DataPresenter.CellPresentation?((global::Infragistics.Windows.DataPresenter.CellPresentation)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.CellPresentationProperty));
				}
				return this._cachedCellPresentation.Value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x0009A4A0 File Offset: 0x000986A0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder ChildRecordsDisplayOrderResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.ChildRecordsDisplayOrderResolved;
				}
				if (this._cachedChildRecordsDisplayOrderResolved == null)
				{
					this._cachedChildRecordsDisplayOrderResolved = new global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder?(this.GetChildRecordsDisplayOrderResolvedInternal());
				}
				return this._cachedChildRecordsDisplayOrderResolved.Value;
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0009A4E8 File Offset: 0x000986E8
		private global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder GetChildRecordsDisplayOrderResolvedInternal()
		{
			if (this._presenter != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this._presenter.CurrentViewInternal;
				if (currentViewInternal != null && !currentViewInternal.IsChildRecordsDisplayOrderSupported)
				{
					return global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
				}
			}
			if (this._settings != null)
			{
				global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder childRecordsDisplayOrder = this._settings.ChildRecordsDisplayOrder;
				if (childRecordsDisplayOrder != global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.Default)
				{
					return childRecordsDisplayOrder;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
			if (fieldLayoutSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder childRecordsDisplayOrder = fieldLayoutSettings.ChildRecordsDisplayOrder;
				if (childRecordsDisplayOrder != global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.Default)
				{
					return childRecordsDisplayOrder;
				}
			}
			return global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0009A558 File Offset: 0x00098758
		private static void OnDataContextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			int num = (fieldLayout._fields != null) ? fieldLayout._fields.Count : 0;
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fieldLayout._fields[i];
				if (field.Owner == fieldLayout)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.SetCurrentValueIfSourceDefault(field, global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, e.NewValue);
				}
			}
			if (fieldLayout._settings != null && fieldLayout._settings.HasFieldBinding)
			{
				fieldLayout._settings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, e.NewValue);
			}
			if (fieldLayout._cachedFieldSettings != null && fieldLayout._cachedFieldSettings.HasFieldBinding)
			{
				fieldLayout._cachedFieldSettings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, e.NewValue);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0009A60F File Offset: 0x0009880F
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0009A61C File Offset: 0x0009881C
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object DataContext
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, value);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0009A62C File Offset: 0x0009882C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode DataErrorDisplayModeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode dataErrorDisplayMode = this._settings.DataErrorDisplayMode;
					if (dataErrorDisplayMode != global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Default)
					{
						return dataErrorDisplayMode;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode dataErrorDisplayMode = fieldLayoutSettings.DataErrorDisplayMode;
					if (dataErrorDisplayMode != global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Default)
					{
						return dataErrorDisplayMode;
					}
				}
				return global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIcon;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0009A679 File Offset: 0x00098879
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._presenter;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0009A684 File Offset: 0x00098884
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecordSizingMode DataRecordSizingModeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.DataRecordSizingMode dataRecordSizingMode = this._settings.DataRecordSizingMode;
					if (dataRecordSizingMode != global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default)
					{
						return dataRecordSizingMode;
					}
				}
				if (this._presenter != null)
				{
					if (this._presenter.HasFieldLayoutSettings)
					{
						global::Infragistics.Windows.DataPresenter.DataRecordSizingMode dataRecordSizingMode = this._presenter.FieldLayoutSettings.DataRecordSizingMode;
						if (dataRecordSizingMode != global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default)
						{
							return dataRecordSizingMode;
						}
					}
					if (this._presenter.CurrentViewInternal != null)
					{
						global::Infragistics.Windows.DataPresenter.DataRecordSizingMode dataRecordSizingMode = this._presenter.CurrentViewInternal.DefaultDataRecordSizingMode;
						if (dataRecordSizingMode != global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Default)
						{
							return dataRecordSizingMode;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed;
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0009A6FC File Offset: 0x000988FC
		private static object CoerceDescription(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (!string.IsNullOrEmpty((string)value))
			{
				return value;
			}
			if (fieldLayout != null)
			{
				return fieldLayout.Description;
			}
			return value;
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0009A72C File Offset: 0x0009892C
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0009A881 File Offset: 0x00098A81
		[global::System.ComponentModel.Bindable(true)]
		public string Description
		{
			get
			{
				if (this._cachedDescription != null && this._cachedDescription.Length > 0)
				{
					return this._cachedDescription;
				}
				global::Infragistics.Windows.DataPresenter.Field parentField = this.ParentField;
				if (parentField != null)
				{
					string text = parentField.Label as string;
					if (text != null && text.Length > 0)
					{
						return text;
					}
					text = parentField.Name;
					if (text != null && text.Length > 0)
					{
						return text;
					}
				}
				if (this._cachedKey == null)
				{
					return string.Empty;
				}
				if (this._propertyDescriptorProviders != null && this._propertyDescriptorProviders.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._propertyDescriptorProviders[0]) as global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider;
					if (layoutPropertyDescriptorProvider != null && layoutPropertyDescriptorProvider.Provider != null && layoutPropertyDescriptorProvider.Provider == this._cachedKey)
					{
						return layoutPropertyDescriptorProvider.Provider.ToString();
					}
				}
				global::System.Type type = this._cachedKey as global::System.Type;
				if (type != null)
				{
					return type.Name;
				}
				string text2 = null;
				global::System.Xml.XmlElement xmlElement = this._cachedKey as global::System.Xml.XmlElement;
				if (xmlElement != null)
				{
					text2 = xmlElement.LocalName;
				}
				else
				{
					global::System.Data.DataTable dataTable = this._cachedKey as global::System.Data.DataTable;
					if (dataTable == null)
					{
						global::System.Data.DataView dataView = this._cachedKey as global::System.Data.DataView;
						if (dataView != null)
						{
							dataTable = dataView.Table;
						}
					}
					if (dataTable != null)
					{
						text2 = dataTable.TableName;
					}
				}
				if (text2 != null && text2.Length > 0)
				{
					return text2;
				}
				return this._cachedKey.ToString();
			}
			set
			{
				this._cachedDescription = value;
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DescriptionProperty, value);
			}
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0009A896 File Offset: 0x00098A96
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDescription()
		{
			return this._cachedDescription != null && this._cachedDescription.Length > 0;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0009A8B0 File Offset: 0x00098AB0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDescription()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DescriptionProperty);
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x0009A8C0 File Offset: 0x00098AC0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public int FieldMovingMaxColumnsResolved
		{
			get
			{
				int? num = (this._settings != null) ? this._settings.FieldMovingMaxColumns : null;
				if (num == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
					if (fieldLayoutSettings != null)
					{
						num = fieldLayoutSettings.FieldMovingMaxColumns;
					}
					if (num == null)
					{
						num = new int?(0);
					}
				}
				return num.Value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x0009A930 File Offset: 0x00098B30
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int FieldMovingMaxRowsResolved
		{
			get
			{
				int? num = (this._settings != null) ? this._settings.FieldMovingMaxRows : null;
				if (num == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
					if (fieldLayoutSettings != null)
					{
						num = fieldLayoutSettings.FieldMovingMaxRows;
					}
					if (num == null)
					{
						num = new int?(0);
					}
				}
				return num.Value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x0009A99E File Offset: 0x00098B9E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.FieldCollection Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x0009A9A6 File Offset: 0x00098BA6
		internal global::Infragistics.Windows.DataPresenter.FieldCollection FieldsIfAllocated
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0009A9AE File Offset: 0x00098BAE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFields()
		{
			return this._fields != null && this._fields.ShouldSerialize();
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0009A9C8 File Offset: 0x00098BC8
		private void OnFieldSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this.FieldSettings;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (this._fields != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fields)
				{
					global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, fieldSettings, this, false, false, field, this, dataPresenter);
				}
			}
			global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, fieldSettings, this, null != dataPresenter, true, null, this, dataPresenter);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0009AA44 File Offset: 0x00098C44
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0009AA7A File Offset: 0x00098C7A
		public global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettings
		{
			get
			{
				if (this._cachedFieldSettings == null && (this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)))
				{
					this._cachedFieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
					this.OnNewFieldSettings();
				}
				return this._cachedFieldSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty, value);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0009AA88 File Offset: 0x00098C88
		internal global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettingsIfAllocated
		{
			get
			{
				return this._cachedFieldSettings;
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0009AA90 File Offset: 0x00098C90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldSettings()
		{
			return this._cachedFieldSettings != null && this._cachedFieldSettings.ShouldSerialize();
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0009AAA7 File Offset: 0x00098CA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty);
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0009AAB4 File Offset: 0x00098CB4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterAction FilterActionResolved
		{
			get
			{
				if (this._cachedRecordFilterActionResolved == global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default)
				{
					this._cachedRecordFilterActionResolved = this.InternalFilterActionResolved;
				}
				return this._cachedRecordFilterActionResolved;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		private global::Infragistics.Windows.DataPresenter.RecordFilterAction InternalFilterActionResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterAction filterAction = this._settings.FilterAction;
					if (filterAction != global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default)
					{
						return filterAction;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterAction filterAction = fieldLayoutSettings.FilterAction;
					if (filterAction != global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default)
					{
						return filterAction;
					}
				}
				return global::Infragistics.Windows.DataPresenter.RecordFilterAction.Hide;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x0009AB20 File Offset: 0x00098D20
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation FilterClearButtonLocationResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation filterClearButtonLocation = this._settings.FilterClearButtonLocation;
					if (filterClearButtonLocation != global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.Default)
					{
						return filterClearButtonLocation;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation filterClearButtonLocation = fieldLayoutSettings.FilterClearButtonLocation;
					if (filterClearButtonLocation != global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.Default)
					{
						return filterClearButtonLocation;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.RecordSelectorAndFilterCell;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x0009AB70 File Offset: 0x00098D70
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.FilterRecordLocation FilterRecordLocationResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterRecordLocation filterRecordLocation = this._settings.FilterRecordLocation;
					if (filterRecordLocation != global::Infragistics.Windows.DataPresenter.FilterRecordLocation.Default)
					{
						return filterRecordLocation;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterRecordLocation filterRecordLocation = fieldLayoutSettings.FilterRecordLocation;
					if (filterRecordLocation != global::Infragistics.Windows.DataPresenter.FilterRecordLocation.Default)
					{
						return filterRecordLocation;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FilterRecordLocation.OnTopFixed;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0009ABC0 File Offset: 0x00098DC0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FilterUIType FilterUITypeResolved
		{
			get
			{
				if (this._presenter != null && this._presenter.IsReportControl)
				{
					return global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons;
				}
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterUIType filterUIType = this._settings.FilterUIType;
					if (filterUIType != global::Infragistics.Windows.DataPresenter.FilterUIType.Default)
					{
						return filterUIType;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterUIType filterUIType = fieldLayoutSettings.FilterUIType;
					if (filterUIType != global::Infragistics.Windows.DataPresenter.FilterUIType.Default)
					{
						return filterUIType;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FilterUIType.FilterRecord;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0009AC24 File Offset: 0x00098E24
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldUIType FixedFieldUITypeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this.GetFixedFieldInfo(true);
				return this.GetFixedFieldUITypeResolved(fixedFieldInfo.HasFixedFields, fixedFieldInfo.HasFixableFields);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0009AC4C File Offset: 0x00098E4C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public int FixedRecordLimitResolved
		{
			get
			{
				int? num = null;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
				if (presenter != null && presenter.IsFixedRecordsSupportedResolved)
				{
					if (this._settings != null)
					{
						num = this._settings.FixedRecordLimit;
					}
					if (num == null && this._presenter.HasFieldLayoutSettings)
					{
						num = this._presenter.FieldLayoutSettings.FixedRecordLimit;
					}
				}
				if (num != null)
				{
					return num.Value;
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FixedRecordUIType FixedRecordUITypeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordUIType fixedRecordUIType = global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Default;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
				if (presenter != null && presenter.IsFixedRecordsSupportedResolved)
				{
					if (this._settings != null)
					{
						fixedRecordUIType = this._settings.FixedRecordUIType;
					}
					if (fixedRecordUIType == global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Default && this._presenter.HasFieldLayoutSettings)
					{
						fixedRecordUIType = this._presenter.FieldLayoutSettings.FixedRecordUIType;
					}
				}
				if (fixedRecordUIType != global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Default)
				{
					return fixedRecordUIType;
				}
				return global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Button;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0009AD20 File Offset: 0x00098F20
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder FixedRecordSortOrderResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder fixedRecordSortOrder = global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Default;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
				if (presenter != null && presenter.IsFixedRecordsSupportedResolved)
				{
					if (this._settings != null)
					{
						fixedRecordSortOrder = this._settings.FixedRecordSortOrder;
					}
					if (fixedRecordSortOrder == global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Default && this._presenter.HasFieldLayoutSettings)
					{
						fixedRecordSortOrder = this._presenter.FieldLayoutSettings.FixedRecordSortOrder;
					}
				}
				if (fixedRecordSortOrder != global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Default)
				{
					return fixedRecordSortOrder;
				}
				return global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Sorted;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0009AD7C File Offset: 0x00098F7C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility GroupByExpansionIndicatorVisibilityResolved
		{
			get
			{
				global::System.Windows.Visibility? visibility = null;
				if (this._settings != null)
				{
					visibility = this._settings.GroupByExpansionIndicatorVisibility;
				}
				if (visibility == null && this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					visibility = this._presenter.FieldLayoutSettings.GroupByExpansionIndicatorVisibility;
				}
				if (visibility == null)
				{
					return global::System.Windows.Visibility.Visible;
				}
				return visibility.Value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0009ADE6 File Offset: 0x00098FE6
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasFieldSettings
		{
			get
			{
				return this._cachedFieldSettings != null;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0009ADF4 File Offset: 0x00098FF4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasSeparateHeader
		{
			get
			{
				return this._cachedHasSeparateHeader;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0009ADFC File Offset: 0x00098FFC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasSettings
		{
			get
			{
				return this._settings != null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0009AE0A File Offset: 0x0009900A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasGroupBySortFields
		{
			get
			{
				return this.HasSortedFields && this.SortedFields.CountOfGroupByFields > 0;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x0009AE24 File Offset: 0x00099024
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasSortedFields
		{
			get
			{
				return this._sortedFields != null && this._sortedFields.Count > 0;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x0009AE3E File Offset: 0x0009903E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate HeaderAreaTemplate
		{
			get
			{
				if (this._styleGenerator != null)
				{
					return this._styleGenerator.GeneratedHeaderTemplate;
				}
				return null;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x0009AE58 File Offset: 0x00099058
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.HeaderPlacement HeaderPlacementResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacementExplicitResolved = this.HeaderPlacementExplicitResolved;
				if (headerPlacementExplicitResolved != global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default)
				{
					return headerPlacementExplicitResolved;
				}
				return global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnTopOnly;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x0009AE74 File Offset: 0x00099074
		private global::Infragistics.Windows.DataPresenter.HeaderPlacement HeaderPlacementExplicitResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement = this._settings.HeaderPlacement;
					if (headerPlacement != global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default)
					{
						return headerPlacement;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement = this._presenter.FieldLayoutSettings.HeaderPlacement;
					if (headerPlacement != global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default)
					{
						return headerPlacement;
					}
				}
				return global::Infragistics.Windows.DataPresenter.HeaderPlacement.Default;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x0009AEC8 File Offset: 0x000990C8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy HeaderPlacementInGroupByResolved
		{
			get
			{
				if (this.IsHorizontal)
				{
					return global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords;
				}
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy headerPlacementInGroupBy = this._settings.HeaderPlacementInGroupBy;
					if (headerPlacementInGroupBy != global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.Default)
					{
						return headerPlacementInGroupBy;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy headerPlacementInGroupBy = this._presenter.FieldLayoutSettings.HeaderPlacementInGroupBy;
					if (headerPlacementInGroupBy != global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.Default)
					{
						return headerPlacementInGroupBy;
					}
				}
				global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacementExplicitResolved = this.HeaderPlacementExplicitResolved;
				if (headerPlacementExplicitResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnTopOnly)
				{
					return global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly;
				}
				if (this.FilterUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons)
				{
					return global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly;
				}
				return global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x0009AF3C File Offset: 0x0009913C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode HeaderPrefixAreaDisplayModeResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaDisplayModeProperty, global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.Default, global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.None);
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0009AF4C File Offset: 0x0009914C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HighlightAlternateRecordsResolved
		{
			get
			{
				if (this._settings != null)
				{
					bool? highlightAlternateRecords = this._settings.HighlightAlternateRecords;
					if (highlightAlternateRecords != null)
					{
						return highlightAlternateRecords.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					bool? highlightAlternateRecords = this._presenter.FieldLayoutSettings.HighlightAlternateRecords;
					if (highlightAlternateRecords != null)
					{
						return highlightAlternateRecords.Value;
					}
				}
				return false;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x0009AFB6 File Offset: 0x000991B6
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HighlightPrimaryFieldResolved
		{
			get
			{
				return this._presenter != null && this._presenter.GetHighlightPrimaryFieldResolved(this);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0009AFCE File Offset: 0x000991CE
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0009AFED File Offset: 0x000991ED
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsDefault
		{
			get
			{
				if (this._presenter != null)
				{
					return this == this._presenter.DefaultFieldLayout;
				}
				return this._isdefault;
			}
			set
			{
				this._isdefault = value;
				if (this._presenter != null)
				{
					if (value)
					{
						this._presenter.DefaultFieldLayout = this;
						return;
					}
					if (this._presenter.DefaultFieldLayout == this)
					{
						this._presenter.DefaultFieldLayout = null;
					}
				}
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0009B028 File Offset: 0x00099228
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsInitialized
		{
			get
			{
				return this._isInitialized;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0009B030 File Offset: 0x00099230
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0009B038 File Offset: 0x00099238
		public object Key
		{
			get
			{
				return this._cachedKey;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.KeyProperty, value);
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0009B046 File Offset: 0x00099246
		internal void InitializeKey(object value)
		{
			this.Key = value;
			this._keyExplicitlySet = false;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0009B056 File Offset: 0x00099256
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeKey()
		{
			return this._keyExplicitlySet && this._cachedKey != null;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0009B070 File Offset: 0x00099270
		private static void OnKeyMatchingEnforcedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout != null)
			{
				fieldLayout._keyMatchingEnforced = (bool)e.NewValue;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0009B099 File Offset: 0x00099299
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x0009B0A1 File Offset: 0x000992A1
		[global::System.ComponentModel.Bindable(true)]
		public bool KeyMatchingEnforced
		{
			get
			{
				return this._keyMatchingEnforced;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.KeyMatchingEnforcedProperty, value);
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0009B0B4 File Offset: 0x000992B4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.LabelLocation LabelLocationResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.LabelLocation labelLocationResolved = this.GetLabelLocationResolved();
				if (labelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells && this.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader;
				}
				return labelLocationResolved;
			}
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0009B0D8 File Offset: 0x000992D8
		private global::Infragistics.Windows.DataPresenter.LabelLocation GetLabelLocationResolved()
		{
			if (this._settings != null)
			{
				global::Infragistics.Windows.DataPresenter.LabelLocation labelLocation = this._settings.LabelLocation;
				if (labelLocation != global::Infragistics.Windows.DataPresenter.LabelLocation.Default)
				{
					return labelLocation;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
			{
				global::Infragistics.Windows.DataPresenter.LabelLocation labelLocation = this._presenter.FieldLayoutSettings.LabelLocation;
				if (labelLocation != global::Infragistics.Windows.DataPresenter.LabelLocation.Default)
				{
					return labelLocation;
				}
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this._presenter.CurrentViewInternal;
				if (currentViewInternal != null)
				{
					labelLocation = currentViewInternal.DefaultLabelLocation;
					if (labelLocation != global::Infragistics.Windows.DataPresenter.LabelLocation.Default)
					{
						return labelLocation;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this.StyleGenerator;
			bool flag = styleGenerator != null && styleGenerator.SupportsLabelHeaders;
			if (flag)
			{
				return global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader;
			}
			return global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0009B160 File Offset: 0x00099360
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public int MaxFieldsToAutoGenerateResolved
		{
			get
			{
				if (this._settings != null)
				{
					int maxFieldsToAutoGenerate = this._settings.MaxFieldsToAutoGenerate;
					if (maxFieldsToAutoGenerate > 0)
					{
						return maxFieldsToAutoGenerate;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					int maxFieldsToAutoGenerate = this._presenter.FieldLayoutSettings.MaxFieldsToAutoGenerate;
					if (maxFieldsToAutoGenerate > 0)
					{
						return maxFieldsToAutoGenerate;
					}
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0009B1B8 File Offset: 0x000993B8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public int MaxSelectedCellsResolved
		{
			get
			{
				if (this._settings != null)
				{
					int? maxSelectedCells = this._settings.MaxSelectedCells;
					if (maxSelectedCells != null)
					{
						return maxSelectedCells.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					int? maxSelectedCells = this._presenter.FieldLayoutSettings.MaxSelectedCells;
					if (maxSelectedCells != null)
					{
						return maxSelectedCells.Value;
					}
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0009B228 File Offset: 0x00099428
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int MaxSelectedRecordsResolved
		{
			get
			{
				if (this._settings != null)
				{
					int? maxSelectedRecords = this._settings.MaxSelectedRecords;
					if (maxSelectedRecords != null)
					{
						return maxSelectedRecords.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					int? maxSelectedRecords = this._presenter.FieldLayoutSettings.MaxSelectedRecords;
					if (maxSelectedRecords != null)
					{
						return maxSelectedRecords.Value;
					}
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0009B298 File Offset: 0x00099498
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.Field ParentField
		{
			get
			{
				if (this._parentField != null)
				{
					return this._parentField;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = this.ParentFieldLayout;
				if (parentFieldLayout == null)
				{
					return null;
				}
				string parentFieldName = this.ParentFieldName;
				if (string.IsNullOrEmpty(parentFieldName))
				{
					return null;
				}
				int num = parentFieldLayout.Fields.IndexOf(parentFieldName);
				if (num >= 0)
				{
					this._parentField = parentFieldLayout.Fields[num];
				}
				if (this._parentField != null)
				{
					base.RaisePropertyChangedEvent("ParentField");
				}
				return this._parentField;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0009B310 File Offset: 0x00099510
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout ParentFieldLayout
		{
			get
			{
				if (this._parentFieldLayout != null)
				{
					return this._parentFieldLayout;
				}
				if (this._parentField != null)
				{
					return this._parentField.Owner;
				}
				object parentFieldLayoutKey = this.ParentFieldLayoutKey;
				if (parentFieldLayoutKey == null)
				{
					return null;
				}
				int num = (this._presenter != null) ? this._presenter.FieldLayouts.IndexOfKey(parentFieldLayoutKey) : -1;
				if (num >= 0 && num != this.Index)
				{
					this._parentFieldLayout = this._presenter.FieldLayouts[num];
				}
				if (this._parentFieldLayout != null)
				{
					base.RaisePropertyChangedEvent("ParentFieldLayout");
				}
				return this._parentFieldLayout;
			}
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0009B3A8 File Offset: 0x000995A8
		private static void OnParentFieldLayoutKeyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = fieldLayout._parentFieldLayout;
				fieldLayout._parentFieldLayout = null;
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout2 = fieldLayout.ParentFieldLayout;
				if (parentFieldLayout != null && parentFieldLayout2 == null)
				{
					fieldLayout.RaisePropertyChangedEvent("ParentFieldLayout");
				}
				if (parentFieldLayout != parentFieldLayout2)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(fieldLayout._presenter, fieldLayout, "ParentFieldLayout", null);
				}
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0009B3FB File Offset: 0x000995FB
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0009B408 File Offset: 0x00099608
		public object ParentFieldLayoutKey
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ParentFieldLayoutKeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ParentFieldLayoutKeyProperty, value);
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0009B418 File Offset: 0x00099618
		private static void OnParentFieldNameChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Field parentField = fieldLayout._parentField;
				fieldLayout._parentField = null;
				global::Infragistics.Windows.DataPresenter.Field parentField2 = fieldLayout.ParentField;
				if (parentField != null && parentField2 == null)
				{
					fieldLayout.RaisePropertyChangedEvent("ParentFieldName");
				}
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0009B455 File Offset: 0x00099655
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0009B467 File Offset: 0x00099667
		public string ParentFieldName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ParentFieldNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ParentFieldNameProperty, value);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0009B478 File Offset: 0x00099678
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x0009B4F8 File Offset: 0x000996F8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field PrimaryField
		{
			get
			{
				if (this._fields == null)
				{
					return null;
				}
				if (this._fields.Version != this._primaryFieldVersion)
				{
					this._primaryFieldVersion = this._fields.Version;
					if (this._primaryField != null && !this._fields.Contains(this._primaryField))
					{
						this.PrimaryField = null;
					}
				}
				if (this._primaryField != null)
				{
					return this._primaryField;
				}
				return this._primaryField = this._fields.GetFirstFieldVisibleInCellArea();
			}
			internal set
			{
				if (value == this._primaryField)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.Field primaryField = this._primaryField;
				this._primaryField = value;
				base.RaisePropertyChangedEvent("PrimaryField");
				if (primaryField != null)
				{
					primaryField.SetIsPrimaryInternal(false);
				}
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0009B532 File Offset: 0x00099732
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFilters
		{
			get
			{
				if (this._recordFilters == null)
				{
					this._recordFilters = new global::Infragistics.Windows.DataPresenter.RecordFilterCollection(this);
				}
				return this._recordFilters;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0009B54E File Offset: 0x0009974E
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFiltersIfAllocated
		{
			get
			{
				return this._recordFilters;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0009B556 File Offset: 0x00099756
		internal bool HasRecordFilters
		{
			get
			{
				return this._recordFilters != null && this._recordFilters.Count > 0;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0009B570 File Offset: 0x00099770
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRecordFilters()
		{
			return this._recordFilters != null && this._recordFilters.ShouldSerialize();
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0009B587 File Offset: 0x00099787
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRecordFilters()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.Clear();
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x0009B59C File Offset: 0x0009979C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.LogicalOperator RecordFiltersLogicalOperatorResolved
		{
			get
			{
				if (this._cachedRecordFiltersLogicalOperatorResolved != null)
				{
					return this._cachedRecordFiltersLogicalOperatorResolved.Value;
				}
				this._cachedRecordFiltersLogicalOperatorResolved = new global::Infragistics.Windows.Controls.LogicalOperator?(this.InternalRecordFiltersLogicalOperatorResolved);
				return this._cachedRecordFiltersLogicalOperatorResolved.Value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0009B5D4 File Offset: 0x000997D4
		private global::Infragistics.Windows.Controls.LogicalOperator InternalRecordFiltersLogicalOperatorResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.LogicalOperator? recordFiltersLogicalOperator = this._settings.RecordFiltersLogicalOperator;
					if (recordFiltersLogicalOperator != null)
					{
						return recordFiltersLogicalOperator.Value;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.Controls.LogicalOperator? recordFiltersLogicalOperator = fieldLayoutSettings.RecordFiltersLogicalOperator;
					if (recordFiltersLogicalOperator != null)
					{
						return recordFiltersLogicalOperator.Value;
					}
				}
				return global::Infragistics.Windows.Controls.LogicalOperator.And;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0009B639 File Offset: 0x00099839
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int RecordIndentVersion
		{
			get
			{
				return this._indentOffsetVersion;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0009B644 File Offset: 0x00099844
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public double RecordSelectorExtentResolved
		{
			get
			{
				if (this._settings != null)
				{
					double recordSelectorExtent = this._settings.RecordSelectorExtent;
					if (!double.IsNaN(recordSelectorExtent))
					{
						return recordSelectorExtent;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					double recordSelectorExtent = this._presenter.FieldLayoutSettings.RecordSelectorExtent;
					if (!double.IsNaN(recordSelectorExtent))
					{
						return recordSelectorExtent;
					}
				}
				double num = (this._presenter != null) ? this._presenter.RecordSelectorExtent : double.NaN;
				if (double.IsNaN(num))
				{
					num = 20.0;
				}
				bool flag = true;
				switch (this.RecordSelectorLocationResolved)
				{
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
					flag = false;
					break;
				}
				global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo supportDataErrorInfoResolved = this.SupportDataErrorInfoResolved;
				if (global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsOnly == supportDataErrorInfoResolved || global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsAndCells == supportDataErrorInfoResolved)
				{
					double num2 = (this._presenter != null) ? this._presenter.RecordSelectorErrorIconExtent : double.NaN;
					double num3;
					if (double.IsNaN(num2))
					{
						num3 = 10.0;
					}
					else
					{
						num3 = num2;
					}
					if (flag)
					{
						num += num3;
					}
					else
					{
						num = global::System.Math.Max(num, num3);
					}
				}
				if (this._presenter != null && !this._presenter.IsReportControl && this.AllowRecordFixingResolved != global::Infragistics.Windows.DataPresenter.AllowRecordFixing.No && this.FixedRecordUITypeResolved == global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Button)
				{
					double num4 = (this._presenter != null) ? this._presenter.RecordSelectorFixButtonExtent : double.NaN;
					double num5;
					if (double.IsNaN(num4))
					{
						num5 = 12.0;
					}
					else
					{
						num5 = num4;
					}
					if (flag)
					{
						num += num5;
					}
					else
					{
						num = global::System.Math.Max(num, num5);
					}
				}
				return num;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0009B7C0 File Offset: 0x000999C0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorLocation RecordSelectorLocationResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorLocation recordSelectorLocation = this._settings.RecordSelectorLocation;
					if (recordSelectorLocation != global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.Default)
					{
						return recordSelectorLocation;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorLocation recordSelectorLocation = this._presenter.FieldLayoutSettings.RecordSelectorLocation;
					if (recordSelectorLocation != global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.Default)
					{
						return recordSelectorLocation;
					}
				}
				if (this._presenter == null)
				{
					return global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.None;
				}
				if (this.IsHorizontal)
				{
					return global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea;
				}
				return global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0009B828 File Offset: 0x00099A28
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat RecordSelectorNumberFormatResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat recordSelectorNumberFormat = this._settings.RecordSelectorNumberFormat;
					if (recordSelectorNumberFormat != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.Default)
					{
						return recordSelectorNumberFormat;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat recordSelectorNumberFormat = this._presenter.FieldLayoutSettings.RecordSelectorNumberFormat;
					if (recordSelectorNumberFormat != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.Default)
					{
						return recordSelectorNumberFormat;
					}
				}
				if (this.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.IncludeParentRecordNumber;
				}
				return global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.RecordNumberOnly;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x0009B884 File Offset: 0x00099A84
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int RecordSelectorNumberStartResolved
		{
			get
			{
				if (this._settings != null)
				{
					int? recordSelectorNumberStart = this._settings.RecordSelectorNumberStart;
					if (recordSelectorNumberStart != null)
					{
						return recordSelectorNumberStart.Value;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					int? recordSelectorNumberStart = this._presenter.FieldLayoutSettings.RecordSelectorNumberStart;
					if (recordSelectorNumberStart != null)
					{
						return recordSelectorNumberStart.Value;
					}
				}
				return 1;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0009B8EE File Offset: 0x00099AEE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType RecordSelectorNumberTypeResolved
		{
			get
			{
				if (this._cachedRecordSelectorNumberTypeResolved == null)
				{
					this._cachedRecordSelectorNumberTypeResolved = new global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType?(this.RecordSelectorNumberTypeResolvedHelper);
				}
				return this._cachedRecordSelectorNumberTypeResolved.Value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x0009B91C File Offset: 0x00099B1C
		private global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType RecordSelectorNumberTypeResolvedHelper
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType recordSelectorNumberType = this._settings.RecordSelectorNumberType;
					if (recordSelectorNumberType != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.Default)
					{
						return recordSelectorNumberType;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType recordSelectorNumberType = this._presenter.FieldLayoutSettings.RecordSelectorNumberType;
					if (recordSelectorNumberType != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.Default)
					{
						return recordSelectorNumberType;
					}
				}
				return global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0009B970 File Offset: 0x00099B70
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool ReevaluateFiltersOnDataChangeResolved
		{
			get
			{
				if (this._cachedReevaluateFiltersOnDataChange == null)
				{
					this._cachedReevaluateFiltersOnDataChange = this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnDataChangeProperty, null, new bool?(true));
				}
				return this._cachedReevaluateFiltersOnDataChange.Value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x0009B9B8 File Offset: 0x00099BB8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool ReevaluateFiltersOnRecordsAddedResolved
		{
			get
			{
				if (this._cachedReevaluateFiltersOnRecordsAdded == null)
				{
					this._cachedReevaluateFiltersOnRecordsAdded = this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.ReevaluateFiltersOnRecordsAddedProperty, null, new bool?(true));
				}
				return this._cachedReevaluateFiltersOnRecordsAdded.Value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0009BA00 File Offset: 0x00099C00
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ResizingMode ResizingModeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.ResizingMode resizingMode = this._settings.ResizingMode;
					if (resizingMode != global::Infragistics.Windows.Controls.ResizingMode.Default)
					{
						return resizingMode;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.Controls.ResizingMode resizingMode = this._presenter.FieldLayoutSettings.ResizingMode;
					if (resizingMode != global::Infragistics.Windows.Controls.ResizingMode.Default)
					{
						return resizingMode;
					}
				}
				return global::Infragistics.Windows.Controls.ResizingMode.Deferred;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x0009BA54 File Offset: 0x00099C54
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x0009BAC8 File Offset: 0x00099CC8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.Field ScrollTipField
		{
			get
			{
				if (this._fields == null)
				{
					return null;
				}
				if (this._fields.Version != this._scrollTipFieldVersion)
				{
					this._scrollTipFieldVersion = this._fields.Version;
					if (this._scrollTipField != null && !this._fields.Contains(this._scrollTipField))
					{
						this.ScrollTipField = null;
					}
				}
				if (this._scrollTipField != null)
				{
					return this._scrollTipField;
				}
				return this.PrimaryField;
			}
			internal set
			{
				global::Infragistics.Windows.DataPresenter.Field scrollTipField = this._scrollTipField;
				this._scrollTipField = value;
				if (scrollTipField != null)
				{
					scrollTipField.IsScrollTipField = false;
				}
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x0009BAF0 File Offset: 0x00099CF0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeCellResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeCell = this._settings.SelectionTypeCell;
					if (selectionTypeCell != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeCell;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeCell = this._presenter.FieldLayoutSettings.SelectionTypeCell;
					if (selectionTypeCell != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeCell;
					}
				}
				return global::Infragistics.Windows.Controls.SelectionType.Extended;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x0009BB44 File Offset: 0x00099D44
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeFieldResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeField = this._settings.SelectionTypeField;
					if (selectionTypeField != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeField;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeField = this._presenter.FieldLayoutSettings.SelectionTypeField;
					if (selectionTypeField != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeField;
					}
				}
				return global::Infragistics.Windows.Controls.SelectionType.Extended;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0009BB98 File Offset: 0x00099D98
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeRecordResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeRecord = this._settings.SelectionTypeRecord;
					if (selectionTypeRecord != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeRecord;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.Controls.SelectionType selectionTypeRecord = this._presenter.FieldLayoutSettings.SelectionTypeRecord;
					if (selectionTypeRecord != global::Infragistics.Windows.Controls.SelectionType.Default)
					{
						return selectionTypeRecord;
					}
				}
				return global::Infragistics.Windows.Controls.SelectionType.Extended;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x0009BBEA File Offset: 0x00099DEA
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x0009BC20 File Offset: 0x00099E20
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public global::Infragistics.Windows.DataPresenter.FieldLayoutSettings Settings
		{
			get
			{
				if (this._settings == null && (this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)))
				{
					this._settings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
					this.OnNewFieldLayoutSettings();
				}
				return this._settings;
			}
			set
			{
				if (value != this._settings)
				{
					if (this._settings != null)
					{
						this._settings.PropertyChanged -= this.OnSettingsPropertyChanged;
					}
					this._settings = value;
					if (this._settings != null)
					{
						this.OnNewFieldLayoutSettings();
					}
					base.RaisePropertyChangedEvent("Settings");
				}
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x0009BC75 File Offset: 0x00099E75
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutSettings SettingsIfAllocated
		{
			get
			{
				return this._settings;
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0009BC7D File Offset: 0x00099E7D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSettings()
		{
			return this._settings != null && this._settings.ShouldSerialize();
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0009BC94 File Offset: 0x00099E94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSettings()
		{
			this._settings = null;
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0009BCA0 File Offset: 0x00099EA0
		public global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection SortedFields
		{
			get
			{
				if (this._sortedFields == null)
				{
					this._sortedFields = new global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection(this, new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription>());
					this._sortedFields.CollectionChanged += this.OnSortedFieldsCollectionChanged;
					((global::System.ComponentModel.INotifyPropertyChanged)this._sortedFields).PropertyChanged += this.OnSortedFieldsPropertyChanged;
				}
				return this._sortedFields;
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0009BCFA File Offset: 0x00099EFA
		private void OnSortedFieldsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "CountOfGroupByFields")
			{
				this.BumpGroupByVersion();
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0009BD14 File Offset: 0x00099F14
		private void OnSortedFieldsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.BumpSortVersion();
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0009BD1C File Offset: 0x00099F1C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection SummaryDefinitions
		{
			get
			{
				if (this._summaryDefinitions == null)
				{
					this._summaryDefinitions = new global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection(this);
				}
				return this._summaryDefinitions;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0009BD38 File Offset: 0x00099F38
		internal global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection SummaryDefinitionsIfAllocated
		{
			get
			{
				return this._summaryDefinitions;
			}
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0009BD40 File Offset: 0x00099F40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDefinitions()
		{
			return this._summaryDefinitions != null && this._summaryDefinitions.Count > 0;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0009BD5A File Offset: 0x00099F5A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDefinitions()
		{
			if (this._summaryDefinitions != null)
			{
				this._summaryDefinitions.Clear();
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x0009BD6F File Offset: 0x00099F6F
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0009BD81 File Offset: 0x00099F81
		[global::System.ComponentModel.Bindable(true)]
		public string SummaryDescriptionMask
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty, value);
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0009BD8F File Offset: 0x00099F8F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDescriptionMask()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty, this);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0009BD9C File Offset: 0x00099F9C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDescriptionMask()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0009BDA9 File Offset: 0x00099FA9
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0009BDBB File Offset: 0x00099FBB
		[global::System.ComponentModel.Bindable(true)]
		public string SummaryDescriptionMaskInGroupBy
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty, value);
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0009BDC9 File Offset: 0x00099FC9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDescriptionMaskInGroupBy()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty, this);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x0009BDD6 File Offset: 0x00099FD6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDescriptionMaskInGroupBy()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty);
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x0009BDE3 File Offset: 0x00099FE3
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x0009BDF0 File Offset: 0x00099FF0
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.ShareInstance)]
		public object Tag
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.TagProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.TagProperty, value);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0009BDFE File Offset: 0x00099FFE
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x0009BE0B File Offset: 0x0009A00B
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.ToolTipProperty, value);
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0009BE1C File Offset: 0x0009A01C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int TotalColumnsGenerated
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.TotalColumnsGenerated;
				}
				return this._totalColumnsGenerated;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0009BE40 File Offset: 0x0009A040
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int TotalRowsGenerated
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.TotalRowsGenerated;
				}
				return this._totalRowsGenerated;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x0009BE64 File Offset: 0x0009A064
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x0009BE74 File Offset: 0x0009A074
		internal global::Infragistics.Windows.DataPresenter.FieldLayout AlignmentFieldLayout
		{
			get
			{
				this.VerifyTreeMappings();
				return this._alignmentFieldLayout;
			}
			private set
			{
				if (this._alignmentFieldLayout != value)
				{
					if (this._alignmentFieldLayout != null)
					{
						this._alignmentFieldLayout.PropertyChanged -= this.OnAlignmentFieldLayoutPropertyChanged;
						global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty);
						global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty);
						this._alignmentLayoutFilterVersionTracker = null;
					}
					this._alignmentFieldLayout = value;
					if (this._alignmentFieldLayout != null)
					{
						this._alignmentFieldLayout.PropertyChanged += this.OnAlignmentFieldLayoutPropertyChanged;
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty, global::System.Windows.Data.BindingMode.TwoWay, this._alignmentFieldLayout));
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty, global::System.Windows.Data.BindingMode.TwoWay, this._alignmentFieldLayout));
						this._alignmentLayoutFilterVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._alignmentFieldLayout.RecordFilters, "Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnAlignmentLayoutFilterVersionChanged), true);
						this._areFiltersSynchronized = false;
					}
				}
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x0009BF5C File Offset: 0x0009A15C
		internal global::Infragistics.Windows.DataPresenter.AllowClipboardOperations AllowClipboardOperationsResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowClipboardOperationsProperty, null, new global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?(global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.None)).Value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0009BF8C File Offset: 0x0009A18C
		internal bool AllowRecordFilteringResolvedDefault
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
				if (presenter != null && presenter.IsReportControl)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this.FieldSettingsIfAllocated;
				if (fieldSettings != null)
				{
					bool? allowRecordFiltering = fieldSettings.AllowRecordFiltering;
					if (allowRecordFiltering != null)
					{
						return allowRecordFiltering.Value;
					}
				}
				fieldSettings = ((presenter != null) ? presenter.FieldSettingsIfAllocated : null);
				if (fieldSettings != null)
				{
					bool? allowRecordFiltering = fieldSettings.AllowRecordFiltering;
					if (allowRecordFiltering != null)
					{
						return allowRecordFiltering.Value;
					}
				}
				return false;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0009BFF8 File Offset: 0x0009A1F8
		internal bool AreFieldsInitialized
		{
			get
			{
				return this._areFieldsInitialized;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0009C000 File Offset: 0x0009A200
		internal global::Infragistics.Windows.DataPresenter.AutoArrangeCells AutoArrangeCellsResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.AutoArrangeCellsResolved;
				}
				global::Infragistics.Windows.DataPresenter.AutoArrangeCells autoArrangeCells = global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default;
				if (this._settings != null)
				{
					autoArrangeCells = this._settings.AutoArrangeCells;
				}
				if (autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default && this.DataPresenter.HasFieldLayoutSettings)
				{
					autoArrangeCells = this.DataPresenter.FieldLayoutSettings.AutoArrangeCells;
				}
				if (autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.DataPresenter.CurrentViewInternal;
					autoArrangeCells = currentViewInternal.DefaultAutoArrangeCells;
					if (autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Default)
					{
						if (currentViewInternal.HasLogicalOrientation)
						{
							if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
							{
								autoArrangeCells = global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
							}
							else
							{
								autoArrangeCells = global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
							}
						}
						else
						{
							autoArrangeCells = global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
						}
					}
				}
				return autoArrangeCells;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0009C08C File Offset: 0x0009A28C
		internal global::Infragistics.Windows.DataPresenter.AutoFitMode AutoFitModeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.AutoFitModeResolved;
				}
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AutoFitMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoFitModeProperty, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default);
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0009C0B8 File Offset: 0x0009A2B8
		internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo AutoSizeInfo
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.AutoSizeInfo;
				}
				if (this._autoSizeInfo == null)
				{
					this._autoSizeInfo = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo(this);
				}
				return this._autoSizeInfo;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0009C0F0 File Offset: 0x0009A2F0
		internal global::Infragistics.Windows.DataPresenter.CalculationScope CalculationScopeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.CalculationScope calculationScope = this._settings.CalculationScope;
					if (calculationScope != global::Infragistics.Windows.DataPresenter.CalculationScope.Default)
					{
						return calculationScope;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.CalculationScope calculationScope = fieldLayoutSettings.CalculationScope;
					if (calculationScope != global::Infragistics.Windows.DataPresenter.CalculationScope.Default)
					{
						return calculationScope;
					}
				}
				return global::Infragistics.Windows.DataPresenter.CalculationScope.FilteredSortedList;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0009C13D File Offset: 0x0009A33D
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager CellLayoutManager
		{
			get
			{
				this.VerifyLayoutManagers();
				return this._cellLayoutManager;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0009C14C File Offset: 0x0009A34C
		internal bool CopyFieldLabelsToClipboardResolved
		{
			get
			{
				return this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CopyFieldLabelsToClipboardProperty, null, new bool?(false)).Value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0009C17B File Offset: 0x0009A37B
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x0009C183 File Offset: 0x0009A383
		internal bool ShouldCreateDragFieldLayout
		{
			get
			{
				return this._createDragFieldLayout;
			}
			set
			{
				this._createDragFieldLayout = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0009C18C File Offset: 0x0009A38C
		internal global::System.Windows.Controls.Grid DataRecordCellAreaTemplateGridResolved
		{
			get
			{
				global::System.Windows.Controls.Grid grid = null;
				if (this._settings != null)
				{
					grid = this._settings.DataRecordCellAreaTemplateGrid;
					if (grid != null)
					{
						return grid;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					grid = this._presenter.FieldLayoutSettings.DataRecordCellAreaTemplateGrid;
				}
				return grid;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0009C1DC File Offset: 0x0009A3DC
		private static global::System.Windows.Controls.ColumnDefinition FallbackColumnDefinition
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinition == null)
				{
					lock (typeof(global::Infragistics.Windows.DataPresenter.FieldLayout))
					{
						if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinition == null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinition = new global::System.Windows.Controls.ColumnDefinition();
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinition.Width = new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Auto);
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinition;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x0009C250 File Offset: 0x0009A450
		private static global::System.Windows.Controls.ColumnDefinition FallbackColumnDefinitionAutoFit
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinitionAutoFit == null)
				{
					lock (typeof(global::Infragistics.Windows.DataPresenter.FieldLayout))
					{
						if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinitionAutoFit == null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinitionAutoFit = new global::System.Windows.Controls.ColumnDefinition();
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinitionAutoFit.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackColumnDefinitionAutoFit;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x0009C2C4 File Offset: 0x0009A4C4
		internal global::System.Windows.Controls.ColumnDefinition DefaultColumnDefinitionResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.Controls.ColumnDefinition defaultColumnDefinition = this._settings.DefaultColumnDefinition;
					if (defaultColumnDefinition != null)
					{
						return defaultColumnDefinition;
					}
				}
				if (this._presenter != null)
				{
					if (this._presenter.HasFieldLayoutSettings)
					{
						global::System.Windows.Controls.ColumnDefinition defaultColumnDefinition = this._presenter.FieldLayoutSettings.DefaultColumnDefinition;
						if (defaultColumnDefinition != null)
						{
							return defaultColumnDefinition;
						}
					}
					if (this.IsAutoFitWidth)
					{
						return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackColumnDefinitionAutoFit;
					}
					global::System.Windows.Controls.Grid dataRecordCellAreaTemplateGridResolved = this.DataRecordCellAreaTemplateGridResolved;
					if (dataRecordCellAreaTemplateGridResolved != null && !double.IsNaN(dataRecordCellAreaTemplateGridResolved.Width))
					{
						return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackColumnDefinitionAutoFit;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackColumnDefinition;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x0009C348 File Offset: 0x0009A548
		private static global::System.Windows.Controls.RowDefinition FallbackRowDefinition
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinition == null)
				{
					lock (typeof(global::Infragistics.Windows.DataPresenter.FieldLayout))
					{
						if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinition == null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinition = new global::System.Windows.Controls.RowDefinition();
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinition.Height = new global::System.Windows.GridLength(0.0, global::System.Windows.GridUnitType.Auto);
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinition;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0009C3BC File Offset: 0x0009A5BC
		private static global::System.Windows.Controls.RowDefinition FallbackRowDefinitionAutoFit
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinitionAutoFit == null)
				{
					lock (typeof(global::Infragistics.Windows.DataPresenter.FieldLayout))
					{
						if (global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinitionAutoFit == null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinitionAutoFit = new global::System.Windows.Controls.RowDefinition();
							global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinitionAutoFit.Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.g_fallbackRowDefinitionAutoFit;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0009C430 File Offset: 0x0009A630
		internal global::System.Windows.Controls.RowDefinition DefaultRowDefinitionResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.Controls.RowDefinition defaultRowDefinition = this._settings.DefaultRowDefinition;
					if (defaultRowDefinition != null)
					{
						return defaultRowDefinition;
					}
				}
				if (this._presenter != null)
				{
					if (this._presenter.HasFieldLayoutSettings)
					{
						global::System.Windows.Controls.RowDefinition defaultRowDefinition = this._presenter.FieldLayoutSettings.DefaultRowDefinition;
						if (defaultRowDefinition != null)
						{
							return defaultRowDefinition;
						}
					}
					if (this.IsAutoFitHeight)
					{
						return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackRowDefinitionAutoFit;
					}
					global::System.Windows.Controls.Grid dataRecordCellAreaTemplateGridResolved = this.DataRecordCellAreaTemplateGridResolved;
					if (dataRecordCellAreaTemplateGridResolved != null && !double.IsNaN(dataRecordCellAreaTemplateGridResolved.Height))
					{
						return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackRowDefinitionAutoFit;
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldLayout.FallbackRowDefinition;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0009C4B1 File Offset: 0x0009A6B1
		internal bool FieldLayoutInitializedEventRaised
		{
			get
			{
				return this._fieldLayoutInitializedEventRaised;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0009C4BC File Offset: 0x0009A6BC
		internal global::Infragistics.Windows.DataPresenter.FilterEvaluationMode FilterEvaluationModeResolved
		{
			get
			{
				if (this._cachedFilterEvaluationModeResolved == null)
				{
					this._cachedFilterEvaluationModeResolved = new global::Infragistics.Windows.DataPresenter.FilterEvaluationMode?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FilterEvaluationMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterEvaluationModeProperty, global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Default, global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto));
				}
				if (this._cachedFilterEvaluationModeResolved == global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView && this.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto;
				}
				return this._cachedFilterEvaluationModeResolved.Value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0009C520 File Offset: 0x0009A720
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0009C528 File Offset: 0x0009A728
		internal global::System.Windows.Size ExpansionIndicatorSize
		{
			get
			{
				return this._expansionIndicatorSize;
			}
			set
			{
				this._expansionIndicatorSize = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0009C531 File Offset: 0x0009A731
		internal int FixedFieldVersion
		{
			get
			{
				return this._fixedFieldVersion + this.TemplateVersion;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x0009C540 File Offset: 0x0009A740
		internal global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode ExpansionIndicatorDisplayModeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode expansionIndicatorDisplayMode = this._settings.ExpansionIndicatorDisplayMode;
					if (expansionIndicatorDisplayMode != global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Default)
					{
						return expansionIndicatorDisplayMode;
					}
				}
				if (this._presenter != null && this._presenter.HasFieldLayoutSettings)
				{
					global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode expansionIndicatorDisplayMode = this._presenter.FieldLayoutSettings.ExpansionIndicatorDisplayMode;
					if (expansionIndicatorDisplayMode != global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Default)
					{
						return expansionIndicatorDisplayMode;
					}
				}
				if (this.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.CheckOnDisplay;
				}
				return global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.CheckOnExpand;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x0009C59C File Offset: 0x0009A79C
		internal global::Infragistics.Windows.DataPresenter.FieldResizingArea FieldResizingAreaResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FieldResizingArea>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FieldResizingAreaProperty, global::Infragistics.Windows.DataPresenter.FieldResizingArea.Default, global::Infragistics.Windows.DataPresenter.FieldResizingArea.LabelsAndCells);
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x0009C5AB File Offset: 0x0009A7AB
		internal global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode GroupByEvaluationModeResolvedDefault
		{
			get
			{
				if (this._cachedGroupByEvaluationModeResolved == null)
				{
					this._cachedGroupByEvaluationModeResolved = new global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.GroupByEvaluationModeProperty, global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Default, global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Auto));
				}
				return this._cachedGroupByEvaluationModeResolved.Value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x0009C5E0 File Offset: 0x0009A7E0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode GroupBySummaryDisplayModeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode groupBySummaryDisplayMode = this._settings.GroupBySummaryDisplayMode;
					if (groupBySummaryDisplayMode != global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Default)
					{
						return groupBySummaryDisplayMode;
					}
				}
				if (this._presenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettingsIfAllocated = this._presenter.FieldLayoutSettingsIfAllocated;
					if (fieldLayoutSettingsIfAllocated != null)
					{
						global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode groupBySummaryDisplayMode = fieldLayoutSettingsIfAllocated.GroupBySummaryDisplayMode;
						if (groupBySummaryDisplayMode != global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Default)
						{
							return groupBySummaryDisplayMode;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.GroupBySummaryDisplayMode.Text;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x0009C62A File Offset: 0x0009A82A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int GroupByVersion
		{
			get
			{
				return this._groupByVersion;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x0009C634 File Offset: 0x0009A834
		internal bool HasUnboundFieldsWithoutBindings
		{
			get
			{
				if (this._hasUnboundFieldsWithoutBindings == null)
				{
					this._hasUnboundFieldsWithoutBindings = new bool?(false);
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this.Fields)
					{
						if (field != null && field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && field.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty) == null && field.AlternateBinding == null)
						{
							this._hasUnboundFieldsWithoutBindings = new bool?(true);
							break;
						}
					}
				}
				return this._hasUnboundFieldsWithoutBindings == true;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x0009C6DC File Offset: 0x0009A8DC
		internal bool HasStarFieldsX
		{
			get
			{
				if (this._hasStarFieldsX == null)
				{
					this._hasStarFieldsX = new bool?(this.HasStarFields(true));
				}
				return this._hasStarFieldsX.Value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0009C708 File Offset: 0x0009A908
		internal bool HasStarFieldsY
		{
			get
			{
				if (this._hasStarFieldsY == null)
				{
					this._hasStarFieldsY = new bool?(this.HasStarFields(false));
				}
				return this._hasStarFieldsY.Value;
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0009C734 File Offset: 0x0009A934
		private static void OnGridColumnWidthVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.FieldLayout)d)._cachedGridColumnWidthVersion = (int)e.NewValue;
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x0009C74D File Offset: 0x0009A94D
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0009C755 File Offset: 0x0009A955
		internal int GridColumnWidthVersion
		{
			get
			{
				return this._cachedGridColumnWidthVersion;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty, value);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x0009C768 File Offset: 0x0009A968
		internal bool HasBeenInitializedAfterDataSourceChange
		{
			get
			{
				return this._hasBeenInitializedAfterDataSourceChange;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x0009C770 File Offset: 0x0009A970
		internal int Index
		{
			get
			{
				if (this._presenter == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayouts = this._presenter.FieldLayouts;
				if (this._index < 0 || this._index >= fieldLayouts.Count || fieldLayouts[this._index] != this)
				{
					this._index = fieldLayouts.IndexOf(this);
				}
				return this._index;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x0009C7CC File Offset: 0x0009A9CC
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0009C7DE File Offset: 0x0009A9DE
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, value);
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x0009C7F1 File Offset: 0x0009A9F1
		internal bool IsAutoFit
		{
			get
			{
				return this.IsAutoFitWidth || this.IsAutoFitHeight;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0009C803 File Offset: 0x0009AA03
		internal bool IsAutoFitWidth
		{
			get
			{
				this.VerifyAutoFitSettings(false);
				return (byte)(this._autoFitState.Value & global::Infragistics.Windows.DataPresenter.AutoFitState.Width) != 0;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0009C820 File Offset: 0x0009AA20
		internal bool IsAutoFitHeight
		{
			get
			{
				this.VerifyAutoFitSettings(false);
				return (byte)(this._autoFitState.Value & global::Infragistics.Windows.DataPresenter.AutoFitState.Height) != 0;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x0009C83D File Offset: 0x0009AA3D
		internal bool IsGridBagAutoFitWidth
		{
			get
			{
				return this.IsAutoFitWidth && this.AutoFitModeResolved != global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x0009C855 File Offset: 0x0009AA55
		internal bool IsGridBagAutoFitHeight
		{
			get
			{
				return this.IsAutoFitHeight && this.AutoFitModeResolved != global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x0009C870 File Offset: 0x0009AA70
		internal bool IsDataRecordSizedToContent
		{
			get
			{
				switch (this.DataRecordSizingModeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed:
				case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
					return true;
				default:
					return false;
				}
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0009C89C File Offset: 0x0009AA9C
		internal bool IsFieldChooserUIEnabled
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				return global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.FieldChooserButton == this.HeaderPrefixAreaDisplayModeResolved || (dataPresenter != null && dataPresenter.HasRegisteredFieldChoosers());
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x0009C8C8 File Offset: 0x0009AAC8
		internal bool IsFixedFieldsEnabled
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
				if (presenter != null && presenter.IsFixedFieldsSupportedResolved)
				{
					global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this.GetFixedFieldInfo(true);
					return fixedFieldInfo.HasFixableFields || fixedFieldInfo.HasFixedFields;
				}
				return false;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x0009C904 File Offset: 0x0009AB04
		internal bool IsHorizontal
		{
			get
			{
				if (this._cachedIsHorizontal == null && this._presenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this._presenter.CurrentViewInternal;
					this._cachedIsHorizontal = new bool?(currentViewInternal.HasLogicalOrientation && currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal);
				}
				return this._cachedIsHorizontal == true;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x0009C96A File Offset: 0x0009AB6A
		internal bool IsInFieldInitialization
		{
			get
			{
				return this._isInFieldInitialization;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x0009C972 File Offset: 0x0009AB72
		internal bool IsInitialRecordLoaded
		{
			get
			{
				return this._initialRecordLoaded;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x0009C97A File Offset: 0x0009AB7A
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x0009C98C File Offset: 0x0009AB8C
		internal bool IsOverNearSplitter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverNearSplitterProperty, value);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x0009C99F File Offset: 0x0009AB9F
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x0009C9B1 File Offset: 0x0009ABB1
		internal bool IsOverFarSplitter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.IsOverFarSplitterProperty, value);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x0009C9C4 File Offset: 0x0009ABC4
		internal bool IsTreeView
		{
			get
			{
				return this._presenter != null && this._presenter.IsTreeView;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x0009C9DC File Offset: 0x0009ABDC
		internal bool IsEmptyCellCollapsingSupportedByView
		{
			get
			{
				if (this._cachedIsEmptyCellCollapsingSupportedByView == null)
				{
					this._cachedIsEmptyCellCollapsingSupportedByView = new bool?(false);
					global::Infragistics.Windows.DataPresenter.ViewBase viewBase = (this._presenter != null) ? this._presenter.CurrentViewInternal : null;
					if (viewBase != null)
					{
						this._cachedIsEmptyCellCollapsingSupportedByView = new bool?(viewBase.IsEmptyCellCollapsingSupported);
					}
				}
				return this._cachedIsEmptyCellCollapsingSupportedByView.Value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x0009CA38 File Offset: 0x0009AC38
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager LabelLayoutManager
		{
			get
			{
				this.VerifyLayoutManagers();
				return this._labelLayoutManager;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0009CA46 File Offset: 0x0009AC46
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0009CA58 File Offset: 0x0009AC58
		internal global::Infragistics.Windows.DataPresenter.LabelPresenter LastSelectableItemLabel
		{
			get
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastSelectableItemLabel) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			}
			set
			{
				if (value == null)
				{
					this._lastSelectableItemLabel = null;
					return;
				}
				this._lastSelectableItemLabel = new global::System.WeakReference(value);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0009CA71 File Offset: 0x0009AC71
		internal int LayoutItemVersion
		{
			get
			{
				return this._layoutItemVersion;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0009CA79 File Offset: 0x0009AC79
		internal int LayoutManagerVersion
		{
			get
			{
				return this._layoutManagerVersion + this.TemplateVersion;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0009CA88 File Offset: 0x0009AC88
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0009CAAC File Offset: 0x0009ACAC
		internal int MaxRecordManagerDepth
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.MaxRecordManagerDepth;
				}
				return this._maxRecordManagerDepth;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					alignmentFieldLayout.MaxRecordManagerDepth = value;
					return;
				}
				if (value > this._maxRecordManagerDepth)
				{
					this._maxRecordManagerDepth = value;
					this.AutoSizeInfo.OnMaxDepthChanged();
				}
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0009CAE8 File Offset: 0x0009ACE8
		internal int NestingDepth
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = this.ParentFieldLayout;
				if (parentFieldLayout != null)
				{
					return 1 + parentFieldLayout.NestingDepth;
				}
				return 0;
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0009CB0C File Offset: 0x0009AD0C
		internal void OnFieldWidthHeightChanged()
		{
			if (this._autoFitState != null)
			{
				this.VerifyAutoFitSettings(true);
			}
			bool? hasStarFieldsY = null;
			this._hasStarFieldsY = hasStarFieldsY;
			this._hasStarFieldsX = (this._hasStarFieldsY = hasStarFieldsY);
			this.BumpLayoutManagerVersion();
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0009CB52 File Offset: 0x0009AD52
		internal global::Infragistics.Windows.DataPresenter.PlaceholderField[] PlaceholderFields
		{
			get
			{
				this.VerifyTreeMappings();
				return this._placeholderFields;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x0009CB60 File Offset: 0x0009AD60
		internal int PlaceholderFieldsVersion
		{
			get
			{
				return this._placeholderFieldsVersion;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0009CB68 File Offset: 0x0009AD68
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x0009CB70 File Offset: 0x0009AD70
		internal bool PreventBumpLayoutManagerVersionRequired
		{
			get
			{
				return this._preventBumpLayoutManagerVersionRequired;
			}
			set
			{
				this._preventBumpLayoutManagerVersionRequired = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0009CB79 File Offset: 0x0009AD79
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		internal global::Infragistics.Windows.DataPresenter.RecordFilterScope RecordFilterScopeResolvedDefault
		{
			get
			{
				if (this._cachedRecordFilterScopeResolvedDefault != null)
				{
					return this._cachedRecordFilterScopeResolvedDefault.Value;
				}
				this._cachedRecordFilterScopeResolvedDefault = new global::Infragistics.Windows.DataPresenter.RecordFilterScope?(this.InternalRecordFilterScopeResolvedDefault);
				return this._cachedRecordFilterScopeResolvedDefault.Value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x0009CBB0 File Offset: 0x0009ADB0
		private global::Infragistics.Windows.DataPresenter.RecordFilterScope InternalRecordFilterScopeResolvedDefault
		{
			get
			{
				if (this.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords;
				}
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScope = this._settings.RecordFilterScope;
					if (recordFilterScope != global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default)
					{
						return recordFilterScope;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
				if (fieldLayoutSettings != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterScope recordFilterScope = fieldLayoutSettings.RecordFilterScope;
					if (recordFilterScope != global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default)
					{
						return recordFilterScope;
					}
				}
				return global::Infragistics.Windows.DataPresenter.RecordFilterScope.Default;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0009CC07 File Offset: 0x0009AE07
		internal global::Infragistics.Windows.DataPresenter.RecordResizingArea RecordResizingAreaResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.RecordResizingArea>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordResizingAreaProperty, global::Infragistics.Windows.DataPresenter.RecordResizingArea.Default, global::Infragistics.Windows.DataPresenter.RecordResizingArea.CellsOnly);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x0009CC16 File Offset: 0x0009AE16
		internal int RecordSelectorNumberSizeVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.RecordSelectorNumberSizeVersionProperty);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x0009CC28 File Offset: 0x0009AE28
		internal global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation RecordSeparatorLocationResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation? recordSeparatorLocation = null;
				if (this._settings != null)
				{
					recordSeparatorLocation = this._settings.RecordSeparatorLocation;
					if (recordSeparatorLocation != null)
					{
						return recordSeparatorLocation.Value;
					}
				}
				if (this._presenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettingsIfAllocated = this._presenter.FieldLayoutSettingsIfAllocated;
					if (fieldLayoutSettingsIfAllocated != null)
					{
						recordSeparatorLocation = fieldLayoutSettingsIfAllocated.RecordSeparatorLocation;
						if (recordSeparatorLocation != null)
						{
							return recordSeparatorLocation.Value;
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation? recordSeparatorLocation2 = recordSeparatorLocation;
				if (recordSeparatorLocation2 == null)
				{
					return global::Infragistics.Windows.DataPresenter.RecordSeparatorLocation.FixedRecords;
				}
				return recordSeparatorLocation2.GetValueOrDefault();
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x0009CCA8 File Offset: 0x0009AEA8
		internal global::Infragistics.Windows.DataPresenter.FieldLayout RootFieldLayout
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout = this.ParentFieldLayout;
				if (parentFieldLayout != null)
				{
					return parentFieldLayout.RootFieldLayout;
				}
				return this;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x0009CCC7 File Offset: 0x0009AEC7
		internal global::Infragistics.Windows.DataPresenter.SortEvaluationMode SortEvaluationModeResolvedDefault
		{
			get
			{
				if (this._cachedSortEvaluationModeResolved == null)
				{
					this._cachedSortEvaluationModeResolved = new global::Infragistics.Windows.DataPresenter.SortEvaluationMode?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.SortEvaluationMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SortEvaluationModeProperty, global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Default, global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Auto));
				}
				return this._cachedSortEvaluationModeResolved.Value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x0009CCF9 File Offset: 0x0009AEF9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SortVersion
		{
			get
			{
				return this._sortVersion;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x0009CD01 File Offset: 0x0009AF01
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x0009CD13 File Offset: 0x0009AF13
		internal int SortOperationVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SortOperationVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SortOperationVersionProperty, value);
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0009CD26 File Offset: 0x0009AF26
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0009CD2E File Offset: 0x0009AF2E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		internal int SpecialRecordsVersion
		{
			get
			{
				return this._cachedSpecialRecordsVersion;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SpecialRecordsVersionProperty, value);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0009CD44 File Offset: 0x0009AF44
		private static void OnSpecialRecordsVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (global::Infragistics.Windows.DataPresenter.FieldLayout)dependencyObject;
			fieldLayout._cachedSpecialRecordsVersion = (int)e.NewValue;
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x0009CD6C File Offset: 0x0009AF6C
		internal global::System.Windows.Visibility SummaryDescriptionVisibilityResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.Visibility? summaryDescriptionVisibility = this._settings.SummaryDescriptionVisibility;
					if (summaryDescriptionVisibility != null)
					{
						return summaryDescriptionVisibility.Value;
					}
				}
				if (this._presenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettingsIfAllocated = this._presenter.FieldLayoutSettingsIfAllocated;
					if (fieldLayoutSettingsIfAllocated != null)
					{
						global::System.Windows.Visibility? summaryDescriptionVisibility = fieldLayoutSettingsIfAllocated.SummaryDescriptionVisibility;
						if (summaryDescriptionVisibility != null)
						{
							return summaryDescriptionVisibility.Value;
						}
					}
				}
				if (this.IsTreeView)
				{
					return global::System.Windows.Visibility.Visible;
				}
				return global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x0009CDD8 File Offset: 0x0009AFD8
		internal global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode SummaryEvaluationModeResolved
		{
			get
			{
				if (this._cachedSummaryEvaluationModeResolved == null)
				{
					this._cachedSummaryEvaluationModeResolved = new global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SummaryEvaluationModeProperty, global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Default, global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode.Auto));
				}
				return this._cachedSummaryEvaluationModeResolved.Value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0009CE0C File Offset: 0x0009B00C
		internal global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo SupportDataErrorInfoResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo supportDataErrorInfoResolvedDefault = this.SupportDataErrorInfoResolvedDefault;
				if (supportDataErrorInfoResolvedDefault != global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.Default)
				{
					return supportDataErrorInfoResolvedDefault;
				}
				return global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.None;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0009CE26 File Offset: 0x0009B026
		internal global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo SupportDataErrorInfoResolvedDefault
		{
			get
			{
				if (this._cachedSupportDataErrorInfoResolvedDefault == null)
				{
					this._cachedSupportDataErrorInfoResolvedDefault = new global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.SupportDataErrorInfoProperty, global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.Default, global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.Default));
				}
				return this._cachedSupportDataErrorInfoResolvedDefault.Value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x0009CE58 File Offset: 0x0009B058
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator StyleGenerator
		{
			get
			{
				return this._styleGenerator;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0009CE60 File Offset: 0x0009B060
		internal global::Infragistics.Windows.DataPresenter.DataRecord TemplateDataRecord
		{
			get
			{
				if (this._templateDataRecord == null)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord.CreateTemplateDataRecord(this, out this._templateDataRecord);
				}
				return this._templateDataRecord;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0009CE7C File Offset: 0x0009B07C
		internal global::Infragistics.Windows.DataPresenter.GroupByRecord TemplateGroupByRecord
		{
			get
			{
				if (this._templateGroupByRecord == null && this._presenter != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateGroupByRecords = this._presenter.FieldLayouts.TemplateGroupByRecords;
					this._templateGroupByRecord = new global::Infragistics.Windows.DataPresenter.GroupByRecord(this, templateGroupByRecords);
					this._templateGroupByRecord.SetIsExpanded(true, null);
					templateGroupByRecords.BeginUpdate();
					templateGroupByRecords.AddRecord(this._templateGroupByRecord);
					templateGroupByRecords.EndUpdate(true);
				}
				return this._templateGroupByRecord;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0009CEE3 File Offset: 0x0009B0E3
		internal global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache TemplateDataRecordCache
		{
			get
			{
				if (this._templateDataRecordCache == null)
				{
					this._templateDataRecordCache = new global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache(this);
				}
				return this._templateDataRecordCache;
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0009CF00 File Offset: 0x0009B100
		private static void OnTemplateVersion(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (global::Infragistics.Windows.DataPresenter.FieldLayout)d;
			fieldLayout._templateVersion = (int)e.NewValue;
			fieldLayout.RaisePropertyChangedEvent("LayoutManagerVersion");
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0009CF31 File Offset: 0x0009B131
		internal int TemplateVersion
		{
			get
			{
				return this._templateVersion;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0009CF3C File Offset: 0x0009B13C
		internal global::Infragistics.Windows.DataPresenter.Field TreeField
		{
			get
			{
				if (this._fields == null || this._fields.Count == 0)
				{
					return null;
				}
				if (!this.IsTreeView)
				{
					return null;
				}
				if (this._treeField != null)
				{
					return this._treeField;
				}
				if (this._presenter == null || !this.IsInitialized)
				{
					return null;
				}
				if (this.IsDefault)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this._presenter.CurrentViewInternal;
					global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = (currentViewInternal is global::Infragistics.Windows.DataPresenter.TreeView) ? ((global::Infragistics.Windows.DataPresenter.TreeView)currentViewInternal).ViewSettings : null;
					string text = (treeViewSettings != null) ? treeViewSettings.TreeFieldName : null;
					if (!string.IsNullOrEmpty(text))
					{
						int num = this._fields.IndexOf(text);
						if (num >= 0)
						{
							global::Infragistics.Windows.DataPresenter.Field field = this._fields[num];
							if (!field.IsExpandableResolved)
							{
								this._treeField = field;
							}
						}
					}
					if (this._treeField == null)
					{
						global::Infragistics.Windows.DataPresenter.Field primaryField = this.PrimaryField;
						if (primaryField != null && !primaryField.IsExpandableResolved)
						{
							this._treeField = primaryField;
						}
					}
					if (this._treeField == null)
					{
						int count = this._fields.Count;
						for (int i = 0; i < count; i++)
						{
							global::Infragistics.Windows.DataPresenter.Field field2 = this._fields[i];
							if (!field2.IsExpandableResolved && field2.VisibilityResolved == global::System.Windows.Visibility.Visible)
							{
								this._treeField = field2;
							}
						}
					}
					if (this._treeField != null)
					{
						this._treeField.IsTreeField = true;
					}
					return this._treeField;
				}
				this.VerifyTreeMappings();
				global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this._presenter.DefaultFieldLayout;
				if (defaultFieldLayout == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Field treeField = defaultFieldLayout.TreeField;
				if (treeField == null)
				{
					return null;
				}
				this._treeField = this.GetFieldFromMappedField(treeField);
				if (this._treeField != null)
				{
					this._treeField.IsTreeField = true;
					return this._treeField;
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(string.Format("There is no field in FieldLayout: '{0}'", this));
				if (this.ParentField != null)
				{
					stringBuilder.Append(string.Format(" (from parent field: '{0}')", this.ParentField));
				}
				stringBuilder.Append(" that maps to the tree field in the default FieldLayout. ");
				stringBuilder.Append(global::System.Environment.NewLine);
				stringBuilder.Append("  - To map a tree field from this FieldLayout set its 'Label' property to '");
				stringBuilder.Append(treeField.Name);
				stringBuilder.Append("'.");
				stringBuilder.Append(global::System.Environment.NewLine);
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(stringBuilder.ToString());
				return null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0009D16D File Offset: 0x0009B36D
		internal bool UseCellPresenters
		{
			get
			{
				if (this._styleGenerator != null)
				{
					return this._styleGenerator.UseCellPresenters;
				}
				return !this.HasSeparateHeader && this.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0009D196 File Offset: 0x0009B396
		internal bool WasRemovedFromCollection
		{
			get
			{
				if (this._wasRemovedFromCollection && this.Index >= 0)
				{
					this._wasRemovedFromCollection = false;
				}
				return this._wasRemovedFromCollection;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x0009D1B6 File Offset: 0x0009B3B6
		internal bool WrapsEnumerableObject
		{
			get
			{
				return this._wrapsEnumerableObject;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x0009D1BE File Offset: 0x0009B3BE
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderPresenter> HeaderPresenterCache
		{
			get
			{
				if (this._headerPresenterCache == null)
				{
					this._headerPresenterCache = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderPresenter>(3);
				}
				return this._headerPresenterCache;
			}
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0009D1DA File Offset: 0x0009B3DA
		internal void BumpRecordFilterVersion()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.BumpVersion();
			}
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0009D1EF File Offset: 0x0009B3EF
		internal void BumpGridColumnWidthVersion()
		{
			this.GridColumnWidthVersion++;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0009D200 File Offset: 0x0009B400
		internal void BumpGroupByVersion()
		{
			this._groupByVersion++;
			base.RaisePropertyChangedEvent("GroupByVersion");
			if (this._presenter != null)
			{
				this._presenter.InvalidateGeneratedStyles(true, false, false);
				this._presenter.InvalidateItemsHost();
				this.BumpRecordIndentVersionAsync();
			}
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0009D24D File Offset: 0x0009B44D
		internal void BumpRecordIndentVersion()
		{
			this._bumpRecordIndentVersionPending = null;
			this._indentOffsetVersion++;
			base.RaisePropertyChangedEvent("RecordIndentVersion");
			this.BumpGridColumnWidthVersion();
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0009D278 File Offset: 0x0009B478
		internal void BumpRecordIndentVersionAsync()
		{
			if (this._presenter == null)
			{
				return;
			}
			if (this._presenter.IsSynchronousControl)
			{
				this.BumpRecordIndentVersion();
				return;
			}
			if (this._bumpRecordIndentVersionPending == null)
			{
				this._bumpRecordIndentVersionPending = this._presenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpRecordIndentVersion));
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0009D2CD File Offset: 0x0009B4CD
		internal void BumpLayoutItemVersion()
		{
			this.BumpLayoutItemVersion(true);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0009D2D8 File Offset: 0x0009B4D8
		internal void BumpLayoutItemVersion(bool bumpFieldLayoutVersion)
		{
			if (this._bumpLayoutItemOp != null)
			{
				if (this._bumpLayoutItemOp.Status == global::System.Windows.Threading.DispatcherOperationStatus.Pending)
				{
					this._bumpLayoutItemOp.Abort();
				}
				this._bumpLayoutItemOp = null;
			}
			if (bumpFieldLayoutVersion)
			{
				this._layoutItemVersion++;
			}
			this.BumpGridColumnWidthVersion();
			if (this._presenter != null)
			{
				this._presenter.RaiseCellsInViewChangedAsyncHelper();
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0009D337 File Offset: 0x0009B537
		internal void BumpLayoutItemVersionAsync()
		{
			if (this._bumpLayoutItemOp == null)
			{
				this._bumpLayoutItemOp = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpLayoutItemVersion));
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0009D360 File Offset: 0x0009B560
		internal void BumpLayoutManagerVersion()
		{
			if (this.PreventBumpLayoutManagerVersionRequired)
			{
				return;
			}
			this._layoutManagerVersion++;
			this.BumpLayoutItemVersion();
			base.RaisePropertyChangedEvent("LayoutManagerVersion");
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0009D38A File Offset: 0x0009B58A
		internal void BumpRecordSelectorNumberSizeVersion()
		{
			this._bumpRecordNumberSizeVersionPending = null;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.RecordSelectorNumberSizeVersionPropertyKey, this.RecordSelectorNumberSizeVersion + 1);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0009D3AC File Offset: 0x0009B5AC
		internal void BumpRecordSelectorNumberSizeVersionAsync()
		{
			if (this._presenter == null)
			{
				return;
			}
			if (this._presenter.IsSynchronousControl)
			{
				this.BumpRecordSelectorNumberSizeVersion();
				return;
			}
			if (this._bumpRecordNumberSizeVersionPending == null)
			{
				this._bumpRecordNumberSizeVersionPending = this._presenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpRecordSelectorNumberSizeVersion));
			}
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0009D404 File Offset: 0x0009B604
		internal void BumpSortVersion()
		{
			this._sortVersion++;
			if (this._summaryDefinitions != null)
			{
				this._summaryDefinitions.RefreshSummariesAffectedBySort();
			}
			base.RaisePropertyChangedEvent("SortVersion");
			if (this.DataPresenter != null)
			{
				this.DataPresenter.OnSortCriteriaChanged(this);
			}
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0009D451 File Offset: 0x0009B651
		internal void BumpSortOperationVersion()
		{
			this.SortOperationVersion++;
			this._sortOperationVersionPending = null;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0009D470 File Offset: 0x0009B670
		internal void BumpSortOperationVersionAsync()
		{
			if (this._sortOperationVersionPending == null)
			{
				this._sortOperationVersionPending = global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this.BumpSortOperationVersion();
				}), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[0]);
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0009D49D File Offset: 0x0009B69D
		internal void BumpSpecialRecordsVersion()
		{
			this.SpecialRecordsVersion++;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0009D4AD File Offset: 0x0009B6AD
		internal void BumpTemplateVersion(bool releaseTemplateCache)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty, this._templateVersion + 1);
			this.TemplateDataRecordCache.BumpCacheVersion(releaseTemplateCache);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0009D4D4 File Offset: 0x0009B6D4
		internal void CloneDragFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout clonedLayout)
		{
			if (this._fieldLayoutInfo == null || this._fieldLayoutInfo.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this.Fields;
			global::Infragistics.Windows.DataPresenter.FieldCollection fields2 = clonedLayout.Fields;
			int count = fields.Count;
			if (count != fields2.Count)
			{
				return;
			}
			clonedLayout._fieldLayoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(clonedLayout);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fields[i];
				if (this._fieldLayoutInfo.ContainsKey(field))
				{
					global::Infragistics.Windows.DataPresenter.Field field2 = fields2[i];
					clonedLayout._fieldLayoutInfo.Add(field2, this._fieldLayoutInfo[field].Clone());
				}
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0009D570 File Offset: 0x0009B770
		internal void ClearCustomizations(global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._fields;
			if (fields != null && (global::Infragistics.Windows.DataPresenter.CustomizationType.FieldExtent & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
				{
					field.ClearUserResize();
					flag = true;
				}
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.CalculationSettings & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				if (fields != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field field2 in fields)
					{
						field2.CalculationSettings = null;
					}
				}
				if (this._summaryDefinitions != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in this._summaryDefinitions)
					{
						summaryDefinition.CalculationSettings = null;
					}
				}
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.FieldPosition & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				if (fields != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field field3 in fields)
					{
						field3.FixedLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
						field3.IgnoreFieldVisibilityOverrides = false;
					}
				}
				this._createDragFieldLayout = false;
				this._fieldLayoutInfo = null;
				this._autoGeneratedPositions = null;
				flag = true;
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.GroupingAndSorting & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None && this._sortedFields != null)
			{
				this._sortedFields.Clear();
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None && this._recordFilters != null)
			{
				this._recordFilters.Clear();
			}
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.Summaries & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None && this._summaryDefinitions != null)
			{
				this._summaryDefinitions.Clear();
			}
			if (this._presenter != null)
			{
				this._presenter.History.OnCustomizationsChanged(this, customizations);
			}
			if (flag && this._presenter != null)
			{
				this.PostDelayedInvalidation(false);
			}
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0009D73C File Offset: 0x0009B93C
		internal void DirtyFixedState()
		{
			this._fixedFieldVersion++;
			this.BumpLayoutManagerVersion();
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0009D752 File Offset: 0x0009B952
		internal bool DoesParentFieldMatch(global::Infragistics.Windows.DataPresenter.Field fieldToTest)
		{
			if (fieldToTest != null)
			{
				return fieldToTest.Owner != this && fieldToTest == this.ParentField;
			}
			return this._parentFieldLayout == null && this.ParentFieldLayoutKey == null;
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0009D77F File Offset: 0x0009B97F
		internal bool DoesParentFieldLayoutMatch(global::Infragistics.Windows.DataPresenter.FieldLayout layoutToTest)
		{
			if (layoutToTest != null)
			{
				return layoutToTest != this && layoutToTest == this.ParentFieldLayout;
			}
			return this._parentFieldLayout == null && this.ParentFieldLayoutKey == null;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0009D7A8 File Offset: 0x0009B9A8
		internal bool DoesProviderMatchKeyByName(global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider)
		{
			string text = this.Key as string;
			if (text == null || text.Length == 0 || propertyDescriptorProvider == null)
			{
				return false;
			}
			string name = propertyDescriptorProvider.Name;
			return name != null && !(name != text);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0009D7EC File Offset: 0x0009B9EC
		internal bool DoesProviderMatchKeyExactly(global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider)
		{
			object key = this.Key;
			if (key == null || propertyDescriptorProvider == null)
			{
				return false;
			}
			if (key == propertyDescriptorProvider.Source)
			{
				return true;
			}
			global::System.Xml.XmlNode xmlNode = key as global::System.Xml.XmlNode;
			global::System.Xml.XmlNode xmlNode2 = propertyDescriptorProvider.Source as global::System.Xml.XmlNode;
			return xmlNode != null && xmlNode2 != null && (((xmlNode.SchemaInfo != null || xmlNode2.SchemaInfo != null) && xmlNode.SchemaInfo == xmlNode2.SchemaInfo) || xmlNode.LocalName == xmlNode2.LocalName);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0009D85F File Offset: 0x0009BA5F
		internal void EnsureStyleGeneratorInitialized()
		{
			if (this.StyleGenerator == null)
			{
				this.Initialize(this.DataPresenter.CurrentViewInternal.GetFieldLayoutTemplateGenerator(this));
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0009DA7C File Offset: 0x0009BC7C
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetAllFields(bool includeFieldsNotInLayout = false)
		{
			if (this._fields != null && this.IsInitialized)
			{
				bool isTreeView = this.IsTreeView;
				if (isTreeView)
				{
					this.VerifyTreeMappings();
				}
				int count = this.Fields.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field fld = this._fields[i];
					if (includeFieldsNotInLayout || fld.IsInLayout)
					{
						yield return fld;
					}
				}
				if (isTreeView && this._placeholderFields != null)
				{
					for (int j = 0; j < this._placeholderFields.Length; j++)
					{
						yield return this._placeholderFields[j];
					}
				}
			}
			yield break;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0009DAA0 File Offset: 0x0009BCA0
		internal global::System.Windows.Controls.ColumnDefinition[] GetCellAreaColumnDefinitions()
		{
			if (this._styleGenerator == null)
			{
				return new global::System.Windows.Controls.ColumnDefinition[0];
			}
			return this._styleGenerator.GetCellAreaColumnDefinitions();
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0009DABC File Offset: 0x0009BCBC
		internal global::System.Windows.Controls.RowDefinition[] GetCellAreaRowDefinitions()
		{
			if (this._styleGenerator == null)
			{
				return new global::System.Windows.Controls.RowDefinition[0];
			}
			return this._styleGenerator.GetCellAreaRowDefinitions();
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		internal global::Infragistics.Windows.DataPresenter.AllowFieldFixing GetDefaultAllowFieldFixing(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.AllowFieldFixing allowFieldFixing = global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default;
			if (this._cachedFieldSettings != null)
			{
				allowFieldFixing = this._cachedFieldSettings.AllowFixing;
			}
			if (allowFieldFixing == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default && this._presenter != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettingsIfAllocated = this._presenter.FieldSettingsIfAllocated;
				if (fieldSettingsIfAllocated != null)
				{
					allowFieldFixing = fieldSettingsIfAllocated.AllowFixing;
				}
			}
			return allowFieldFixing;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0009DB20 File Offset: 0x0009BD20
		internal bool GetDefaultAllowGroupBy(global::Infragistics.Windows.DataPresenter.Field field, bool? defaultValue)
		{
			bool? flag = null;
			if (this._cachedFieldSettings != null)
			{
				flag = this._cachedFieldSettings.AllowGroupBy;
				if (flag != null)
				{
					return flag.Value;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				flag = this._presenter.FieldSettings.AllowGroupBy;
				if (flag != null)
				{
					return flag.Value;
				}
			}
			if (defaultValue != null)
			{
				return defaultValue.Value;
			}
			return field == null || (field.HasSettings && field.Settings.SortComparer != null) || typeof(global::System.IComparable).IsAssignableFrom(field.DataTypeUnderlying);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0009DBD4 File Offset: 0x0009BDD4
		internal bool GetDefaultAllowResize(global::Infragistics.Windows.DataPresenter.Field field)
		{
			bool? flag = null;
			if (this._cachedFieldSettings != null)
			{
				flag = this._cachedFieldSettings.AllowResize;
				if (flag != null)
				{
					return flag.Value;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				flag = this._presenter.FieldSettings.AllowResize;
				if (flag != null)
				{
					return flag.Value;
				}
			}
			return true;
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0009DC48 File Offset: 0x0009BE48
		internal bool GetDefaultAllowSummaries(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUITypeResolved = field.SummaryUITypeResolved;
			if ((global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelectForNumericsOnly == summaryUITypeResolved || global::Infragistics.Windows.DataPresenter.SummaryUIType.SingleSelectForNumericsOnly == summaryUITypeResolved) && !field.IsEditAsTypeNumeric)
			{
				return false;
			}
			if (this._cachedFieldSettings != null)
			{
				bool? allowSummaries = this._cachedFieldSettings.AllowSummaries;
				if (allowSummaries != null)
				{
					return allowSummaries.Value;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (this._presenter != null) ? this._presenter.FieldSettingsIfAllocated : null;
			if (fieldSettings != null)
			{
				bool? allowSummaries = fieldSettings.AllowSummaries;
				if (allowSummaries != null)
				{
					return allowSummaries.Value;
				}
			}
			return false;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0009DCC8 File Offset: 0x0009BEC8
		internal global::Infragistics.Windows.DataPresenter.CellClickAction GetDefaultCellClickAction(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.CellClickAction cellClickAction = this._cachedFieldSettings.CellClickAction;
				if (cellClickAction != global::Infragistics.Windows.DataPresenter.CellClickAction.Default)
				{
					return cellClickAction;
				}
			}
			if (this._presenter != null)
			{
				if (this._presenter.HasFieldSettings)
				{
					global::Infragistics.Windows.DataPresenter.CellClickAction cellClickAction = this._presenter.FieldSettings.CellClickAction;
					if (cellClickAction != global::Infragistics.Windows.DataPresenter.CellClickAction.Default)
					{
						return cellClickAction;
					}
				}
				if (this._presenter.CurrentViewInternal.DefaultCellClickAction != global::Infragistics.Windows.DataPresenter.CellClickAction.Default)
				{
					return this._presenter.CurrentViewInternal.DefaultCellClickAction;
				}
			}
			return global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0009DD40 File Offset: 0x0009BF40
		internal global::Infragistics.Windows.DataPresenter.CellContentAlignment GetDefaultCellContentAlignment(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment = this._cachedFieldSettings.CellContentAlignment;
				if (cellContentAlignment != global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default)
				{
					return cellContentAlignment;
				}
			}
			if (this._presenter != null)
			{
				if (this._presenter.HasFieldSettings)
				{
					global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment = this._presenter.FieldSettings.CellContentAlignment;
					if (cellContentAlignment != global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default)
					{
						return cellContentAlignment;
					}
				}
				if (this.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.Hidden)
				{
					return global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly;
				}
				if (this._presenter.CurrentViewInternal.DefaultCellContentAlignment != global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default)
				{
					return this._presenter.CurrentViewInternal.DefaultCellContentAlignment;
				}
			}
			if (this._styleGenerator == null)
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
			bool flag = field != null && field.IsPrimary;
			if (flag)
			{
				return this._styleGenerator.PrimaryFieldDefaultCellContentAlignment;
			}
			return this._styleGenerator.DefaultCellContentAlignment;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0009DDF4 File Offset: 0x0009BFF4
		internal global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode GetDefaultExpandableFieldRecordExpansionMode(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode expandableFieldRecordExpansionMode = this._cachedFieldSettings.ExpandableFieldRecordExpansionMode;
				if (expandableFieldRecordExpansionMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default)
				{
					return expandableFieldRecordExpansionMode;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode expandableFieldRecordExpansionMode = this._presenter.FieldSettings.ExpandableFieldRecordExpansionMode;
				if (expandableFieldRecordExpansionMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default)
				{
					return expandableFieldRecordExpansionMode;
				}
			}
			return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.ShowExpansionIndicatorIfSiblingsExist;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0009DE48 File Offset: 0x0009C048
		internal global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode GetDefaultExpandableFieldRecordHeaderDisplayMode(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode expandableFieldRecordHeaderDisplayMode = this._cachedFieldSettings.ExpandableFieldRecordHeaderDisplayMode;
				if (expandableFieldRecordHeaderDisplayMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default)
				{
					return expandableFieldRecordHeaderDisplayMode;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode expandableFieldRecordHeaderDisplayMode = this._presenter.FieldSettings.ExpandableFieldRecordHeaderDisplayMode;
				if (expandableFieldRecordHeaderDisplayMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default)
				{
					return expandableFieldRecordHeaderDisplayMode;
				}
			}
			if (this.Fields.ExpandableFieldsCount < 2)
			{
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.NeverDisplayHeader;
			}
			return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.AlwaysDisplayHeader;
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0009DEAC File Offset: 0x0009C0AC
		internal global::Infragistics.Windows.DataPresenter.LabelClickAction GetDefaultLabelClickAction(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.LabelClickAction labelClickAction = this._cachedFieldSettings.LabelClickAction;
				if (labelClickAction != global::Infragistics.Windows.DataPresenter.LabelClickAction.Default)
				{
					return labelClickAction;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				global::Infragistics.Windows.DataPresenter.LabelClickAction labelClickAction = this._presenter.FieldSettings.LabelClickAction;
				if (labelClickAction != global::Infragistics.Windows.DataPresenter.LabelClickAction.Default)
				{
					return labelClickAction;
				}
			}
			if (field != null && (!field.HasSettings || field.Settings.SortComparer == null) && !typeof(global::System.IComparable).IsAssignableFrom(field.DataTypeUnderlying))
			{
				return global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
			}
			if (this._presenter != null && this._presenter.CurrentViewInternal.DefaultLabelClickAction != global::Infragistics.Windows.DataPresenter.LabelClickAction.Default)
			{
				return this._presenter.CurrentViewInternal.DefaultLabelClickAction;
			}
			return global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields;
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0009DF5C File Offset: 0x0009C15C
		internal global::System.Windows.TextAlignment GetDefaultLabelTextAlignment(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.TextAlignment? textAlignment = null;
			if (this._cachedFieldSettings != null)
			{
				textAlignment = this._cachedFieldSettings.LabelTextAlignment;
				if (textAlignment != null)
				{
					return textAlignment.Value;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				textAlignment = this._presenter.FieldSettings.LabelTextAlignment;
				if (textAlignment != null)
				{
					return textAlignment.Value;
				}
			}
			return global::System.Windows.TextAlignment.Left;
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0009DFD0 File Offset: 0x0009C1D0
		internal global::System.Windows.TextTrimming GetDefaultLabelTextTrimming(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.TextTrimming? textTrimming = null;
			if (this._cachedFieldSettings != null)
			{
				textTrimming = this._cachedFieldSettings.LabelTextTrimming;
				if (textTrimming != null)
				{
					return textTrimming.Value;
				}
			}
			if (this._presenter != null && this._presenter.HasFieldSettings)
			{
				textTrimming = this._presenter.FieldSettings.LabelTextTrimming;
				if (textTrimming != null)
				{
					return textTrimming.Value;
				}
			}
			return global::System.Windows.TextTrimming.None;
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0009E044 File Offset: 0x0009C244
		internal global::System.Windows.TextWrapping GetDefaultLabelTextWrapping(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.TextWrapping? textWrapping = null;
			if (this._cachedFieldSettings != null)
			{
				textWrapping = this._cachedFieldSettings.LabelTextWrapping;
				if (textWrapping != null)
				{
					return textWrapping.Value;
				}
			}
			if (this._presenter != null)
			{
				if (this._presenter.HasFieldSettings)
				{
					textWrapping = this._presenter.FieldSettings.LabelTextWrapping;
					if (textWrapping != null)
					{
						return textWrapping.Value;
					}
				}
				if (this._presenter.IsReportControl)
				{
					return global::System.Windows.TextWrapping.Wrap;
				}
			}
			return global::System.Windows.TextWrapping.NoWrap;
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0009E0C8 File Offset: 0x0009C2C8
		internal global::Infragistics.Windows.DataPresenter.SummaryUIType GetDefaultSummaryUIType(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cachedFieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUIType = this._cachedFieldSettings.SummaryUIType;
				if (summaryUIType != global::Infragistics.Windows.DataPresenter.SummaryUIType.Default)
				{
					return summaryUIType;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = (this._presenter != null) ? this._presenter.FieldSettingsIfAllocated : null;
			if (fieldSettings != null)
			{
				global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUIType = fieldSettings.SummaryUIType;
				if (summaryUIType != global::Infragistics.Windows.DataPresenter.SummaryUIType.Default)
				{
					return summaryUIType;
				}
			}
			return global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelectForNumericsOnly;
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009E115 File Offset: 0x0009C315
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo GetFieldLayoutInfo(bool fallbackToAutogenerated, bool createNewIfNecessary)
		{
			if (this._fieldLayoutInfo != null)
			{
				return this._fieldLayoutInfo;
			}
			if (fallbackToAutogenerated && this._autoGeneratedPositions != null)
			{
				return this._autoGeneratedPositions;
			}
			if (createNewIfNecessary)
			{
				return global::Infragistics.Windows.DataPresenter.LayoutInfo.Create(this);
			}
			return null;
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0009E144 File Offset: 0x0009C344
		internal global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo GetFixedFieldInfo(bool verifyTemplate)
		{
			if (this._fixedFieldInfo == null)
			{
				this._fixedFieldInfo = new global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo(this);
			}
			if (verifyTemplate)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this.StyleGenerator;
				if (styleGenerator != null && !styleGenerator.IsGeneratingTemplates)
				{
					styleGenerator.GenerateTemplates();
				}
			}
			return this._fixedFieldInfo;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0009E188 File Offset: 0x0009C388
		internal global::Infragistics.Windows.DataPresenter.FixedFieldUIType GetFixedFieldUITypeResolved(bool hasFixed, bool hasFixable)
		{
			global::Infragistics.Windows.DataPresenter.FixedFieldUIType fixedFieldUIType = global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = this._presenter;
			if (presenter != null && presenter.IsFixedFieldsSupportedResolved)
			{
				if (this._settings != null)
				{
					fixedFieldUIType = this._settings.FixedFieldUIType;
				}
				if (fixedFieldUIType == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default && this._presenter.HasFieldLayoutSettings)
				{
					fixedFieldUIType = this._presenter.FieldLayoutSettings.FixedFieldUIType;
				}
				if (fixedFieldUIType == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default)
				{
					if (hasFixable)
					{
						fixedFieldUIType = global::Infragistics.Windows.DataPresenter.FixedFieldUIType.ButtonAndSplitter;
					}
					else if (hasFixed)
					{
						fixedFieldUIType = global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Splitter;
					}
				}
			}
			if (fixedFieldUIType != global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Default)
			{
				return fixedFieldUIType;
			}
			return global::Infragistics.Windows.DataPresenter.FixedFieldUIType.None;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0009E1F4 File Offset: 0x0009C3F4
		internal global::Infragistics.Windows.DataPresenter.HeaderPresenter GetHeaderPresenterFromCache()
		{
			global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter;
			if (this._headerPresenterCache != null && this._headerPresenterCache.Count > 0)
			{
				headerPresenter = this._headerPresenterCache[0];
				this._headerPresenterCache.RemoveAt(0);
				this.InitializeHeaderPresenter(headerPresenter);
				return headerPresenter;
			}
			headerPresenter = new global::Infragistics.Windows.DataPresenter.HeaderPresenter();
			this.InitializeHeaderPresenter(headerPresenter);
			return headerPresenter;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0009E24C File Offset: 0x0009C44C
		internal string GetLabelFromPropertyDescriptor(global::System.ComponentModel.PropertyDescriptor pd, object pdSource)
		{
			string text = null;
			global::System.Data.DataColumn dataColumn = null;
			global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor dataColumnPropertyDescriptor = pd as global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor;
			if (dataColumnPropertyDescriptor != null)
			{
				dataColumn = dataColumnPropertyDescriptor.Column;
			}
			else if (this._dataColumnMap != null)
			{
				this._dataColumnMap.TryGetValue(pd.Name, out dataColumn);
			}
			else
			{
				global::System.Data.DataView dataView = pdSource as global::System.Data.DataView;
				if (dataView != null && dataView.Table != null)
				{
					int num = dataView.Table.Columns.IndexOf(pd.Name);
					if (num >= 0)
					{
						dataColumn = dataView.Table.Columns[num];
					}
				}
			}
			if (dataColumn != null)
			{
				text = dataColumn.Caption;
			}
			if (text == null)
			{
				text = pd.DisplayName;
			}
			return text;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0009E2E8 File Offset: 0x0009C4E8
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider GetProvider(object listObject, global::System.Collections.IEnumerable containingCollection)
		{
			global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider = this._presenter.FieldLayouts.GetPropertyDescriptorProvider(listObject, containingCollection);
			if (propertyDescriptorProvider == null)
			{
				return null;
			}
			return this.GetProvider(propertyDescriptorProvider);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0009E314 File Offset: 0x0009C514
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider GetProvider(global::Infragistics.Windows.Internal.PropertyDescriptorProvider propDescProvider)
		{
			if (this._propertyDescriptorProviders == null)
			{
				this._propertyDescriptorProviders = new global::System.Collections.Generic.List<global::System.WeakReference>();
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = null;
				for (int i = this._propertyDescriptorProviders.Count - 1; i >= 0; i--)
				{
					global::System.WeakReference weakReference = this._propertyDescriptorProviders[i];
					global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider2 = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference) as global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider;
					if (layoutPropertyDescriptorProvider2 == null)
					{
						this._propertyDescriptorProviders.RemoveAt(i);
					}
					else if (layoutPropertyDescriptorProvider == null && layoutPropertyDescriptorProvider2.Provider.IsCompatibleProvider(propDescProvider))
					{
						layoutPropertyDescriptorProvider = layoutPropertyDescriptorProvider2;
					}
				}
				if (layoutPropertyDescriptorProvider != null)
				{
					return layoutPropertyDescriptorProvider;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider3 = new global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider(this, propDescProvider);
			this._propertyDescriptorProviders.Add(new global::System.WeakReference(layoutPropertyDescriptorProvider3));
			return layoutPropertyDescriptorProvider3;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0009E3B0 File Offset: 0x0009C5B0
		internal double GetRecordSelectorExtent(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			double recordSelectorExtentResolved = this.RecordSelectorExtentResolved;
			if (this.RecordSelectorNumberTypeResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
			{
				return recordSelectorExtentResolved;
			}
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = rcd as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.Record attachedToRecord = headerRecord.AttachedToRecord;
				if (attachedToRecord != null)
				{
					rcd = attachedToRecord;
				}
			}
			global::System.Windows.Size recordSelectorNumberSize = this.TemplateDataRecordCache.GetRecordSelectorNumberSize(rcd);
			switch (this.RecordSelectorLocationResolved)
			{
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
				return global::System.Math.Max(recordSelectorNumberSize.Height, recordSelectorExtentResolved);
			default:
				return recordSelectorExtentResolved + recordSelectorNumberSize.Width;
			}
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0009E428 File Offset: 0x0009C628
		internal global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategyForItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				this._selectionStrategyRecord = this.GetSelectionStrategyHelper(this.SelectionTypeRecordResolved, this._selectionStrategyRecord);
				return this._selectionStrategyRecord;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				this._selectionStrategyCell = this.GetSelectionStrategyHelper(this.SelectionTypeCellResolved, this._selectionStrategyCell);
				return this._selectionStrategyCell;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				this._selectionStrategyField = this.GetSelectionStrategyHelper(this.SelectionTypeFieldResolved, this._selectionStrategyField);
				return this._selectionStrategyField;
			}
			return null;
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0009E4AB File Offset: 0x0009C6AB
		private global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategyHelper(global::Infragistics.Windows.Controls.SelectionType selectionType, global::Infragistics.Windows.Selection.SelectionStrategyBase oldStrategy)
		{
			return global::Infragistics.Windows.Selection.SelectionStrategyBase.GetSelectionStrategy(selectionType, this.DataPresenter, oldStrategy);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0009E4BC File Offset: 0x0009C6BC
		internal void FlipFieldPositions()
		{
			if (!this.IsInitialized && this.AutoGenerateFieldsResolved)
			{
				return;
			}
			if (this._autoGeneratedPositions != null)
			{
				this._autoGeneratedPositions.FlipFieldPositions();
			}
			if (this._fieldLayoutInfo != null)
			{
				this._fieldLayoutInfo.FlipFieldPositions();
			}
			if (this._fixedFieldInfo != null)
			{
				this._fixedFieldInfo.FlipFieldPositions();
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this.Fields)
			{
				field.FlipFieldPositions();
			}
			this.InvalidateGeneratedStylesAsnyc(true, true);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0009E55C File Offset: 0x0009C75C
		internal void Initialize(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator)
		{
			this._styleGenerator = styleGenerator;
			if (styleGenerator != null)
			{
				this._cachedCellPresentation = null;
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.CellPresentationPropertyKey, styleGenerator.CellPresentation);
			}
			this.InvalidateCellContentAlignmentResolved();
			this._isInitialized = true;
			this._hasBeenInitializedAfterDataSourceChange = true;
			if (styleGenerator != null)
			{
				this.InternalVersion++;
			}
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0009E5BA File Offset: 0x0009C7BA
		internal void InitializeFields(object listObject, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection)
		{
			this.InitializeFields(listObject, containingCollection, parentRecordCollection, null);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
		internal void InitializeFields(object listObject, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider)
		{
			if (this._presenter == null || this._areFieldsInitialized)
			{
				return;
			}
			this._isInFieldInitialization = true;
			try
			{
				this._areFieldsInitialized = true;
				this._wrapsEnumerableObject = (listObject is global::Infragistics.Windows.Helpers.EnumerableObjectWrapper);
				this._presenter.RaiseFieldLayoutInitializingEvent(this);
				bool autoGenerateFieldsResolved = this.AutoGenerateFieldsResolved;
				global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[this.Fields.Count];
				if (this.Fields.Count > 0)
				{
					this.Fields.CopyTo(array, 0);
				}
				if (propertyDescriptorProvider == null)
				{
					propertyDescriptorProvider = this._presenter.FieldLayouts.GetPropertyDescriptorProvider(listObject, containingCollection);
				}
				if (this.Key == null)
				{
					this.InitializeKey(propertyDescriptorProvider.Key);
				}
				object source = propertyDescriptorProvider.Source;
				global::System.Data.DataView dataView = source as global::System.Data.DataView;
				if (dataView != null && dataView.Table != null)
				{
					this._dataColumnMap = new global::System.Collections.Generic.Dictionary<string, global::System.Data.DataColumn>();
					foreach (object obj in dataView.Table.Columns)
					{
						global::System.Data.DataColumn dataColumn = (global::System.Data.DataColumn)obj;
						this._dataColumnMap.Add(dataColumn.ColumnName, dataColumn);
					}
				}
				global::System.ComponentModel.PropertyDescriptorCollection properties = propertyDescriptorProvider.GetProperties();
				int num = 0;
				int count = properties.Count;
				for (int i = 0; i < count; i++)
				{
					this.InitializeFieldHelper(properties[i], source, array, autoGenerateFieldsResolved, ref num);
				}
				foreach (global::Infragistics.Windows.DataPresenter.Field field in array)
				{
					if (field != null)
					{
						if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
						{
							if (field.Label == null && field.Name != null)
							{
								field.InitializeDefaultLabel(field.Name);
							}
						}
						else if (!(propertyDescriptorProvider is global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider))
						{
							throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_8", new object[]
							{
								field.Name,
								propertyDescriptorProvider.Source.ToString()
							}));
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator = this._presenter.CurrentViewInternal.GetFieldLayoutTemplateGenerator(this);
				if (fieldLayoutTemplateGenerator != null && !this.IsInitialized)
				{
					this.Initialize(fieldLayoutTemplateGenerator);
				}
				if (this._sortedFields != null)
				{
					this._sortedFields.OnOwnerInitialized();
				}
				this._areFieldsAutoGenerated = autoGenerateFieldsResolved;
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (parentRecordCollection != null) ? (parentRecordCollection.ParentRecord as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord) : null;
				global::Infragistics.Windows.DataPresenter.Field field2 = (expandableFieldRecord != null) ? expandableFieldRecord.Field : null;
				if (field2 != null)
				{
					if (this.ParentFieldLayoutKey == null && this.ParentFieldName == null)
					{
						this.InitializeParentInfo(field2.Owner, field2);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout owner = field2.Owner;
						if (this.ParentFieldLayoutKey == null)
						{
							this._parentFieldLayout = owner;
							this.ParentFieldLayoutKey = owner.Key;
						}
						if (this.ParentFieldName == null)
						{
							this._parentField = null;
							this.ParentFieldName = field2.Name;
						}
					}
				}
				if (this._propertyDescriptorProviders == null && propertyDescriptorProvider != null)
				{
					this.GetProvider(propertyDescriptorProvider);
				}
				this._fieldLayoutInitializedEventRaised = true;
				global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
				hashSet.AddItems(this._fields);
				this._presenter.RaiseFieldLayoutInitializedEvent(this);
				global::Infragistics.Windows.Helpers.HashSet hashSet2 = new global::Infragistics.Windows.Helpers.HashSet();
				hashSet2.AddItems(this._fields);
				if (!global::Infragistics.Windows.Helpers.HashSet.AreEqual(hashSet, hashSet2))
				{
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>();
					foreach (object obj2 in hashSet2)
					{
						global::Infragistics.Windows.DataPresenter.Field field3 = (global::Infragistics.Windows.DataPresenter.Field)obj2;
						if (field3.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && !hashSet.Exists(field3))
						{
							dictionary[field3.Name] = field3;
						}
					}
					if (dictionary.Count > 0)
					{
						int num2 = 0;
						for (int i = 0; i < count; i++)
						{
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = properties[i];
							global::Infragistics.Windows.DataPresenter.Field field4;
							if (propertyDescriptor != null && dictionary.TryGetValue(propertyDescriptor.Name, out field4))
							{
								this.InitializeFieldHelper(propertyDescriptor, source, new global::Infragistics.Windows.DataPresenter.Field[]
								{
									field4
								}, false, ref num2);
								dictionary.Remove(propertyDescriptor.Name);
								if (dictionary.Count == 0)
								{
									break;
								}
							}
						}
					}
				}
				this._presenter.CustomizationsManager.ApplyCustomizations();
				this._presenter.BumpGroupByAreaStyleVersion();
			}
			finally
			{
				this._areTreeFieldMappingsDirty = this.IsTreeView;
				if (this._recordFilters != null)
				{
					this._recordFilters.OnFieldLayoutInitialized();
				}
				this._dataColumnMap = null;
				this._isInFieldInitialization = false;
			}
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0009EA44 File Offset: 0x0009CC44
		private void InitializeFieldHelper(global::System.ComponentModel.PropertyDescriptor pd, object pdsource, global::Infragistics.Windows.DataPresenter.Field[] existingFields, bool autoGenerate, ref int totalFieldsGenerated)
		{
			bool reinitialize = this.DataPresenter != null && this.DataPresenter.IsExportControl;
			string name = pd.Name;
			global::System.Type propertyType = pd.PropertyType;
			string labelFromPropertyDescriptor = this.GetLabelFromPropertyDescriptor(pd, pdsource);
			for (int i = 0; i < existingFields.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = existingFields[i];
				if (field != null && field.DoesPropertyMatch(pd))
				{
					if (!field.IsDataTypeExplicitySet)
					{
						field.DataType = propertyType;
					}
					field.InitializePropertyDescriptor(pd, reinitialize);
					field.InitializeDefaultLabel(labelFromPropertyDescriptor);
					existingFields[i] = null;
					return;
				}
			}
			if (autoGenerate)
			{
				global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field(propertyType, name, labelFromPropertyDescriptor);
				field.InitializePropertyDescriptor(pd, reinitialize);
				if (field.IsExpandableByDefault)
				{
					this.Fields.Add(field);
					return;
				}
				if (totalFieldsGenerated < this.MaxFieldsToAutoGenerateResolved)
				{
					this.Fields.Add(field);
					totalFieldsGenerated++;
				}
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0009EB20 File Offset: 0x0009CD20
		internal void InitializeOwner(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			if (this._presenter != null && this._presenter != presenter)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_10"));
			}
			this._presenter = presenter;
			global::Infragistics.Windows.DataPresenter.GridUtilities.SetCurrentValueIfSourceDefault(this, global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, (this._presenter != null) ? this._presenter.DataContext : null);
			this._cachedCellPresentation = null;
			this._cachedChildRecordsDisplayOrderResolved = null;
			this._cachedFilterEvaluationModeResolved = null;
			this._cachedGroupByEvaluationModeResolved = null;
			this._cachedRecordFilterActionResolved = global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default;
			this._cachedRecordFiltersLogicalOperatorResolved = null;
			this._cachedRecordFilterScopeResolvedDefault = null;
			this._cachedReevaluateFiltersOnDataChange = null;
			this._cachedReevaluateFiltersOnRecordsAdded = null;
			this._cachedSortEvaluationModeResolved = null;
			this._cachedSummaryEvaluationModeResolved = null;
			this._cachedSupportDataErrorInfoResolvedDefault = null;
			this.DirtyFixedState();
			if ((this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)) && !(base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty) is global::Infragistics.Windows.DataPresenter.FieldSettings))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty, this.FieldSettings);
			}
			this.OnPropertyChanged("DataPresenter");
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0009EC4C File Offset: 0x0009CE4C
		internal void InitializeParentInfo(global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout, global::Infragistics.Windows.DataPresenter.Field parentField)
		{
			this.ParentFieldLayoutKey = parentFieldLayout.Key;
			this.ParentFieldName = ((parentField != null) ? parentField.Name : null);
			this._parentFieldLayout = parentFieldLayout;
			this._parentField = parentField;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0009EC7A File Offset: 0x0009CE7A
		internal void InvalidateGeneratedStyles(bool bumpVersion)
		{
			this.InvalidateGeneratedStyles(bumpVersion, true);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0009EC84 File Offset: 0x0009CE84
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates)
		{
			this.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, false, null);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0009ECA4 File Offset: 0x0009CEA4
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates, bool bumpSpecialRecords, bool? clearAutoFitState = null)
		{
			this.ClearCachedTreeField();
			global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateStylesAsyncInfo pendingInvalidateGeneratedStyles = this._pendingInvalidateGeneratedStyles;
			this._pendingInvalidateGeneratedStyles = null;
			if (pendingInvalidateGeneratedStyles != null)
			{
				bumpVersion = (bumpVersion || pendingInvalidateGeneratedStyles._bumpVersion);
				regenerateTemplates = (regenerateTemplates || pendingInvalidateGeneratedStyles._regenerateTemplates);
				if (pendingInvalidateGeneratedStyles._dispatcherOperation != null)
				{
					pendingInvalidateGeneratedStyles._dispatcherOperation.Abort();
				}
				bumpSpecialRecords = (bumpSpecialRecords || pendingInvalidateGeneratedStyles._bumpSpecialRecordsVersion);
			}
			if (bumpSpecialRecords)
			{
				this.BumpSpecialRecordsVersion();
			}
			if (this._presenter != null)
			{
				this._presenter.EditHelper.EndEditMode(true, true);
			}
			if (clearAutoFitState ?? regenerateTemplates)
			{
				this._autoFitState = null;
			}
			if (this._styleGenerator != null)
			{
				this._styleGenerator.InvalidateGeneratedTemplates(regenerateTemplates);
			}
			if (this._templateDataRecordCache != null)
			{
				this._templateDataRecordCache.BumpCacheVersion(regenerateTemplates);
			}
			if (bumpVersion)
			{
				this.InternalVersion++;
			}
			if (this._styleGenerator != null && regenerateTemplates)
			{
				base.RaisePropertyChangedEvent("HeaderAreaTemplate");
			}
			if (this.IsTreeView && this.IsDefault)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._presenter.FieldLayouts)
				{
					if (fieldLayout != this && fieldLayout.IsInitialized && fieldLayout.AlignmentFieldLayout == this)
					{
						fieldLayout._cellLayoutManager = null;
						fieldLayout._labelLayoutManager = null;
						fieldLayout.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, bumpSpecialRecords, clearAutoFitState);
						global::Infragistics.Windows.DataPresenter.Field treeField = fieldLayout.TreeField;
					}
				}
			}
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0009EE20 File Offset: 0x0009D020
		internal void InvalidateGeneratedStylesAsnyc(bool bumpVersion, bool regenerateTemplates)
		{
			this.InvalidateGeneratedStylesAsnyc(bumpVersion, regenerateTemplates, false);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0009EE2C File Offset: 0x0009D02C
		internal void InvalidateGeneratedStylesAsnyc(bool bumpVersion, bool regenerateTemplates, bool bumpSpecialRecords)
		{
			global::System.Windows.Threading.Dispatcher dispatcher = base.Dispatcher;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			bool flag = dataPresenter != null && !dataPresenter.IsSynchronousControl;
			if (dispatcher == null || !flag)
			{
				this.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, bumpSpecialRecords, null);
				return;
			}
			if (this._pendingInvalidateGeneratedStyles == null)
			{
				this._pendingInvalidateGeneratedStyles = new global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateStylesAsyncInfo();
				this._pendingInvalidateGeneratedStyles._dispatcherOperation = dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.InvalidateGeneratedStylesAsnycHandler));
			}
			this._pendingInvalidateGeneratedStyles._bumpVersion = (bumpVersion || this._pendingInvalidateGeneratedStyles._bumpVersion);
			this._pendingInvalidateGeneratedStyles._regenerateTemplates = (regenerateTemplates || this._pendingInvalidateGeneratedStyles._regenerateTemplates);
			this._pendingInvalidateGeneratedStyles._bumpSpecialRecordsVersion = (bumpSpecialRecords || this._pendingInvalidateGeneratedStyles._bumpSpecialRecordsVersion);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		private void InvalidateGeneratedStylesAsnycHandler()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateStylesAsyncInfo pendingInvalidateGeneratedStyles = this._pendingInvalidateGeneratedStyles;
			this._pendingInvalidateGeneratedStyles = null;
			if (pendingInvalidateGeneratedStyles != null)
			{
				if (pendingInvalidateGeneratedStyles._bumpSpecialRecordsVersion)
				{
					this.BumpSpecialRecordsVersion();
				}
				this.InvalidateGeneratedStyles(pendingInvalidateGeneratedStyles._bumpVersion, pendingInvalidateGeneratedStyles._regenerateTemplates);
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0009EF38 File Offset: 0x0009D138
		internal bool IsProviderCached(global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider)
		{
			if (this._propertyDescriptorProviders == null || this._propertyDescriptorProviders.Count == 0)
			{
				return false;
			}
			for (int i = this._propertyDescriptorProviders.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = this._propertyDescriptorProviders[i];
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference) as global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider;
				if (layoutPropertyDescriptorProvider == null)
				{
					this._propertyDescriptorProviders.RemoveAt(i);
				}
				else if (layoutPropertyDescriptorProvider.Provider == propertyDescriptorProvider)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0009EFAC File Offset: 0x0009D1AC
		internal bool IsListObjectCompatible(object listObject, global::System.Collections.IEnumerable containingCollection, bool ignoreAutoGenerateFlag, global::Infragistics.Windows.Internal.PropertyDescriptorProvider pp)
		{
			if (this._presenter == null)
			{
				return false;
			}
			global::System.Xml.XmlNode xmlNode = listObject as global::System.Xml.XmlNode;
			if (xmlNode != null && pp is global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider)
			{
				if (ignoreAutoGenerateFlag)
				{
					return true;
				}
				object key = this.Key;
				string text = key as string;
				if (text != null && text.Length > 0)
				{
					return string.Compare(text, xmlNode.LocalName, true) == 0;
				}
				return key == null;
			}
			else
			{
				if (this._fields == null)
				{
					return true;
				}
				int count = this._fields.Count;
				bool flag = this._areFieldsAutoGenerated && !ignoreAutoGenerateFlag;
				if (count < 1 && !flag)
				{
					return true;
				}
				if (pp == null)
				{
					pp = this._presenter.FieldLayouts.GetPropertyDescriptorProvider(listObject, containingCollection);
				}
				global::System.ComponentModel.PropertyDescriptorCollection properties = pp.GetProperties();
				int count2 = properties.Count;
				if (flag && count != this._fields.UnboundFieldsCount + count2)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._fields[i];
					if (field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
					{
						global::System.ComponentModel.PropertyDescriptor propertyDescriptor = properties.Find(field.Name, false);
						if (propertyDescriptor == null)
						{
							return false;
						}
						global::System.Type dataType = field.DataType;
						if (dataType != null)
						{
							if (count2 == 1 && !ignoreAutoGenerateFlag && propertyDescriptor is global::Infragistics.Windows.Internal.ValuePropertyDescriptor && dataType == typeof(object) && listObject != null && listObject.GetType() != typeof(object))
							{
								return false;
							}
							if (!(propertyDescriptor.PropertyType == dataType) && !dataType.IsAssignableFrom(propertyDescriptor.PropertyType))
							{
								return false;
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0009F13B File Offset: 0x0009D33B
		internal void OnAddedToCollection()
		{
			if (this._templateDataRecordCache != null)
			{
				this._templateDataRecordCache.ReleaseCache();
			}
			this._wasRemovedFromCollection = false;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0009F157 File Offset: 0x0009D357
		internal void OnClonedForExport(global::Infragistics.Windows.DataPresenter.FieldLayout sourceFieldLayout)
		{
			this._areTreeFieldMappingsDirty = sourceFieldLayout.IsTreeView;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0009F168 File Offset: 0x0009D368
		internal void OnRemovedFromCollection()
		{
			if (this._templateDataRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateDataRecords = this._presenter.FieldLayouts.TemplateDataRecords;
				int num = templateDataRecords.IndexOf(this._templateDataRecord);
				if (num >= 0)
				{
					templateDataRecords.RemoveAt(num);
				}
				this._templateDataRecord = null;
			}
			if (this._templateGroupByRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateGroupByRecords = this._presenter.FieldLayouts.TemplateGroupByRecords;
				int num2 = templateGroupByRecords.IndexOf(this._templateGroupByRecord);
				if (num2 >= 0)
				{
					templateGroupByRecords.RemoveAt(num2);
				}
				this._templateGroupByRecord = null;
			}
			if (this._templateDataRecordCache != null)
			{
				this._templateDataRecordCache.OnFieldLayoutRemoved();
			}
			this._wasRemovedFromCollection = true;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0009F200 File Offset: 0x0009D400
		internal void OnCurrentViewChanged(bool formatSettingsChanged)
		{
			this.ClearCachedTreeField();
			this.AlignmentFieldLayout = null;
			this._fieldMap = null;
			this._placeholderFields = null;
			this._cachedIsEmptyCellCollapsingSupportedByView = null;
			this._cachedCellPresentation = null;
			this._cachedIsHorizontal = null;
			this.DirtyFixedState();
			if (this._fields != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fields)
				{
					field.MappedTreeField = null;
				}
				foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._fields)
				{
					field2.OnCurrentViewChanged(formatSettingsChanged);
					field2.DirtyCellContentAlignmentCache();
				}
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0009F2DC File Offset: 0x0009D4DC
		internal void OnDataRecordLoaded()
		{
			if (!this._initialRecordLoaded)
			{
				this._initialRecordLoaded = true;
				if (this._presenter != null)
				{
					this._presenter.BumpGroupByAreaStyleVersion();
					if (!this._hasBeenInitializedAfterDataSourceChange && this._isInitialized && this._styleGenerator != null)
					{
						this._hasBeenInitializedAfterDataSourceChange = true;
					}
				}
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0009F32A File Offset: 0x0009D52A
		internal void OnDataSourceChanged()
		{
			this._initialRecordLoaded = false;
			this._maxRecordManagerDepth = -1;
			this.AutoSizeInfo.HasViewableRecordFields = false;
			this.AutoSizeInfo.HasRecordsInViewFields = false;
			if (this._hasBeenInitializedAfterDataSourceChange)
			{
				this._hasBeenInitializedAfterDataSourceChange = false;
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0009F364 File Offset: 0x0009D564
		internal void OnFieldAddedToCollection(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._isInitialized && this._presenter != null && !this._presenter.IsReportControl && !this._presenter.IsExportControl && this._sortedFields != null && this._sortedFields.CountOfGroupByFields > 0 && field.IsGroupBy)
			{
				this._presenter.BumpOverallSortVersion();
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0009F3C4 File Offset: 0x0009D5C4
		internal void OnFieldAddedRemovedFromCollection()
		{
			this._areFieldsAutoGenerated = false;
			this.OnLabelChanged();
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0009F3D4 File Offset: 0x0009D5D4
		private global::Infragistics.Windows.DataPresenter.Field GetFieldFromMappedField(string fieldName)
		{
			if (this._fieldMap != null && this._alignmentFieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(this._alignmentFieldLayout.Fields, fieldName, false);
				if (field != null)
				{
					return this.GetFieldFromMappedField(field);
				}
			}
			return null;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0009F410 File Offset: 0x0009D610
		internal global::Infragistics.Windows.DataPresenter.Field GetFieldFromMappedField(global::Infragistics.Windows.DataPresenter.Field mappedField)
		{
			global::Infragistics.Windows.DataPresenter.Field result = null;
			if (this._fieldMap != null)
			{
				this._fieldMap.TryGetValue(mappedField, out result);
			}
			return result;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0009F460 File Offset: 0x0009D660
		internal void OnFieldIsUnboundChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._isInFieldInitialization || this._isUnboundFieldTranitionPending || !this._isInitialized)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			this._isUnboundFieldTranitionPending = true;
			dataPresenter.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				this._isUnboundFieldTranitionPending = false;
				this.OnFieldCollectionChanged(this.Fields, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				this.Fields.OnFieldIsUnboundChanged();
			}), new object[0]);
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0009F4B8 File Offset: 0x0009D6B8
		internal void OnFieldRemovedFromCollection(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._presenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._presenter.ActiveCell;
				if (activeCell != null && activeCell.Field == field)
				{
					if (activeCell.IsInEditMode)
					{
						activeCell.EndEditMode(false, true);
					}
					this._presenter.Dispatcher.BeginInvoke(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.VerifyActiveCell), new object[0]);
				}
				global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = this._presenter.SelectedItems.Cells;
				int count = cells.Count;
				int i;
				for (i = count - 1; i >= 0; i--)
				{
					if (field == cells[i].Field)
					{
						cells.RemoveAt(i);
					}
				}
				global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields = this._presenter.SelectedItems.Fields;
				i = fields.IndexOf(field);
				if (i >= 0)
				{
					fields.RemoveAt(i);
				}
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0009F580 File Offset: 0x0009D780
		internal void OnFieldConverterChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (!this._areFieldsInitialized || !this._hasBeenInitializedAfterDataSourceChange || this._isInFieldInitialization || field.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
			{
				return;
			}
			if (this._pendingFieldsToRefresh == null)
			{
				this._pendingFieldsToRefresh = new global::Infragistics.Windows.Helpers.HashSet();
			}
			int count = this._pendingFieldsToRefresh.Count;
			this._pendingFieldsToRefresh.Add(field);
			int count2 = this._pendingFieldsToRefresh.Count;
			if (count2 == 1 && count2 != count)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessPendingFieldsToRefresh));
			}
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0009F608 File Offset: 0x0009D808
		internal void OnFieldVisibilityChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.InvalidateGeneratedStylesAsnyc(false, false, true);
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x0009F614 File Offset: 0x0009D814
		internal void OnLabelChanged()
		{
			if (this._presenter == null || !this.IsTreeView)
			{
				return;
			}
			if (!this.IsInitialized)
			{
				return;
			}
			this.ProcessLabelChangeInTreeViewAsync();
			if (this.IsDefault)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._presenter.FieldLayouts)
				{
					if (fieldLayout != this)
					{
						fieldLayout.ProcessLabelChangeInTreeViewAsync();
					}
				}
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0009F694 File Offset: 0x0009D894
		internal void OnPropertyDescriptorAdded(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorAddedHelper(propertyDescriptor, provider, this.AutoGenerateFieldsResolved, true);
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0009F6AF File Offset: 0x0009D8AF
		internal void OnPropertyDescriptorChanged(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, false, true);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0009F6C5 File Offset: 0x0009D8C5
		internal void OnPropertyDescriptorDeleted(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, true, true);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0009F6DC File Offset: 0x0009D8DC
		internal void OnProviderPropertyDescriptorsChanged(global::Infragistics.Windows.Internal.PropertyDescriptorsChangedEventArgs e)
		{
			global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider = e.Provider;
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			bool flag = false;
			if (e.PropertiesRemoved != null && e.PropertiesRemoved.Length > 0)
			{
				foreach (global::System.ComponentModel.PropertyDescriptor propertyDescriptor in e.PropertiesRemoved)
				{
					this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, true, false);
					flag = true;
				}
			}
			if (e.PropertiesChanged != null && e.PropertiesChanged.Length > 0)
			{
				foreach (global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 in e.PropertiesChanged)
				{
					this.PropertyDescriptorChangedHelper(propertyDescriptor2, provider, false, false);
					flag = true;
				}
			}
			bool autoGenerateFieldsResolved = this.AutoGenerateFieldsResolved;
			if (e.PropertiesAdded != null && e.PropertiesAdded.Length > 0)
			{
				foreach (global::System.ComponentModel.PropertyDescriptor propertyDescriptor3 in e.PropertiesAdded)
				{
					this.PropertyDescriptorAddedHelper(propertyDescriptor3, e.Provider, autoGenerateFieldsResolved, false);
					flag = true;
				}
			}
			if (flag)
			{
				this.PostDelayedInvalidation(true);
			}
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		internal void OnTemplatesGenerated()
		{
			bool? hasStarFieldsX = null;
			this._hasStarFieldsX = hasStarFieldsX;
			this._hasStarFieldsY = (this._hasStarFieldsX = hasStarFieldsX);
			this.DirtyFixedState();
			this.BumpLayoutManagerVersion();
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this.Fields)
			{
				field.OnFieldLayoutTemplatesGenerated();
			}
			this.VerifyAutoFitSettings(true);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0009F858 File Offset: 0x0009DA58
		internal static void ProcessFieldLayoutSettingsPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings settings, object settingsOwner, bool firstPassForPresenterFlag, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			bool flag = presenter != null && presenter.IsInitialized;
			string propertyName = e.PropertyName;
			bool flag2 = false;
			bool flag3 = false;
			string key;
			if ((key = propertyName) != null)
			{
				if (global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x6002421-1 == null)
				{
					global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x6002421-1 = new global::System.Collections.Generic.Dictionary<string, int>(36)
					{
						{
							"CopyFieldLabelsToClipboard",
							0
						},
						{
							"AllowClipboardOperations",
							1
						},
						{
							"CalculationScope",
							2
						},
						{
							"SummaryDescriptionVisibility",
							3
						},
						{
							"GroupBySummaryDisplayMode",
							4
						},
						{
							"AddNewRecordLocation",
							5
						},
						{
							"AllowAddNew",
							6
						},
						{
							"SpecialRecordOrder",
							7
						},
						{
							"RecordSeparatorLocation",
							8
						},
						{
							"AutoFitMode",
							9
						},
						{
							"FixedFieldUIType",
							10
						},
						{
							"RecordFiltersLogicalOperator",
							11
						},
						{
							"AllowRecordFixing",
							12
						},
						{
							"FixedRecordUIType",
							13
						},
						{
							"FixedRecordLimit",
							14
						},
						{
							"FixedRecordSortOrder",
							15
						},
						{
							"FieldResizingArea",
							16
						},
						{
							"RecordResizingArea",
							17
						},
						{
							"FilterAction",
							18
						},
						{
							"FilterClearButtonLocation",
							19
						},
						{
							"FilterRecordLocation",
							20
						},
						{
							"FilterUIType",
							21
						},
						{
							"RecordFilterScope",
							22
						},
						{
							"ReevaluateFiltersOnDataChange",
							23
						},
						{
							"ReevaluateFiltersOnRecordsAdded",
							24
						},
						{
							"GroupByExpansionIndicatorVisibility",
							25
						},
						{
							"RecordSelectorLocation",
							26
						},
						{
							"RecordSelectorExtent",
							27
						},
						{
							"RecordSelectorNumberType",
							28
						},
						{
							"ChildRecordsDisplayOrder",
							29
						},
						{
							"SupportDataErrorInfo",
							30
						},
						{
							"LabelLocation",
							31
						},
						{
							"SortEvaluationMode",
							32
						},
						{
							"FilterEvaluationMode",
							33
						},
						{
							"SummaryEvaluationMode",
							34
						},
						{
							"GroupByEvaluationMode",
							35
						}
					};
				}
				int num;
				if (global::<PrivateImplementationDetails>{7DBDF509-2AF2-4141-9B69-36E942A1F09D}.$$method0x6002421-1.TryGetValue(key, out num))
				{
					switch (num)
					{
					case 0:
					case 1:
						goto IL_639;
					case 2:
						flag2 = true;
						if (fieldLayout != null && fieldLayout._summaryDefinitions != null)
						{
							fieldLayout._summaryDefinitions.BumpDataVersion();
							goto IL_639;
						}
						goto IL_639;
					case 3:
					case 4:
						flag2 = true;
						if (fieldLayout != null && fieldLayout._summaryDefinitions != null)
						{
							fieldLayout._summaryDefinitions.BumpSummariesVersion();
							goto IL_639;
						}
						goto IL_639;
					case 5:
					case 6:
					case 7:
					case 8:
						flag2 = ("SpecialRecordOrder" != propertyName);
						if (fieldLayout == null)
						{
							goto IL_639;
						}
						fieldLayout.BumpSpecialRecordsVersion();
						if (presenter != null && propertyName == "AllowAddNew")
						{
							presenter.BumpScrollCountRecalcVersion();
							goto IL_639;
						}
						goto IL_639;
					case 9:
						if (fieldLayout != null)
						{
							fieldLayout.OnFieldWidthHeightChanged();
							goto IL_639;
						}
						goto IL_639;
					case 10:
						if (fieldLayout == null)
						{
							goto IL_639;
						}
						flag2 = true;
						fieldLayout.DirtyFixedState();
						if (fieldLayout._fields == null)
						{
							goto IL_639;
						}
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator = fieldLayout._fields.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.Windows.DataPresenter.Field field = enumerator.Current;
								field.VerifyFixedState();
							}
							goto IL_639;
						}
						break;
					case 11:
						break;
					case 12:
					case 13:
						flag2 = true;
						if (fieldLayout != null)
						{
							fieldLayout.RaisePropertyChangedEvent("RecordSelectorExtentResolved");
						}
						flag3 = true;
						goto IL_639;
					case 14:
					case 15:
						flag2 = true;
						goto IL_639;
					case 16:
					case 17:
						flag2 = true;
						goto IL_639;
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					{
						flag2 = true;
						if (fieldLayout == null)
						{
							goto IL_639;
						}
						fieldLayout._cachedReevaluateFiltersOnDataChange = null;
						fieldLayout._cachedReevaluateFiltersOnRecordsAdded = null;
						if ("RecordFilterScope" == propertyName)
						{
							flag2 = false;
							fieldLayout._cachedRecordFilterScopeResolvedDefault = null;
							fieldLayout.BumpRecordFilterVersion();
						}
						else if ("FilterAction" == propertyName)
						{
							fieldLayout._cachedRecordFilterActionResolved = global::Infragistics.Windows.DataPresenter.RecordFilterAction.Default;
							fieldLayout.BumpRecordFilterVersion();
						}
						fieldLayout.BumpSpecialRecordsVersion();
						global::Infragistics.Windows.DataPresenter.FieldCollection fieldsIfAllocated = fieldLayout.FieldsIfAllocated;
						if (fieldsIfAllocated != null)
						{
							string text = (propertyName == "FilterUIType") ? "AllowRecordFiltering" : (("FilterClearButtonLocation" == propertyName) ? "FilterClearButtonVisibility" : null);
							using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator2 = fieldsIfAllocated.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									global::Infragistics.Windows.DataPresenter.Field field2 = enumerator2.Current;
									field2.DirtyRecordFilterRelatedCache(true);
									if (text != null)
									{
										global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(text), fieldLayout.FieldSettings, fieldLayout, firstPassForPresenterFlag, firstPassForPresenterFlag, field2, fieldLayout, fieldLayout.DataPresenter);
									}
								}
								goto IL_639;
							}
							goto IL_4F6;
						}
						goto IL_639;
					}
					case 25:
					case 26:
					case 27:
						goto IL_4F6;
					case 28:
						if (fieldLayout != null)
						{
							fieldLayout._cachedRecordSelectorNumberTypeResolved = null;
							fieldLayout.RaisePropertyChangedEvent("RecordSelectorExtentResolved");
						}
						flag2 = true;
						flag3 = true;
						goto IL_639;
					case 29:
						if (fieldLayout != null)
						{
							fieldLayout.ResetCachedChildRecordsDisplayOrderResolvedValue();
						}
						if (firstPassForPresenterFlag && flag && presenter != null)
						{
							presenter.OnChildRecordsDisplayOrderChanged();
						}
						flag2 = true;
						goto IL_639;
					case 30:
						flag3 = true;
						if (fieldLayout != null)
						{
							fieldLayout._cachedSupportDataErrorInfoResolvedDefault = null;
							goto IL_639;
						}
						goto IL_639;
					case 31:
						flag3 = true;
						if (fieldLayout != null)
						{
							fieldLayout.InvalidateCellContentAlignmentResolved();
							goto IL_639;
						}
						goto IL_639;
					case 32:
					case 33:
					case 34:
					case 35:
					{
						if (fieldLayout == null)
						{
							goto IL_639;
						}
						fieldLayout._cachedSortEvaluationModeResolved = null;
						fieldLayout._cachedFilterEvaluationModeResolved = null;
						fieldLayout._cachedGroupByEvaluationModeResolved = null;
						fieldLayout._cachedSummaryEvaluationModeResolved = null;
						string a;
						if ((a = propertyName) == null)
						{
							goto IL_639;
						}
						if (a == "SortEvaluationMode" || a == "GroupByEvaluationMode")
						{
							fieldLayout.BumpSortVersion();
							goto IL_639;
						}
						if (a == "FilterEvaluationMode")
						{
							fieldLayout.BumpRecordFilterVersion();
							goto IL_639;
						}
						if (!(a == "SummaryEvaluationMode"))
						{
							goto IL_639;
						}
						if (fieldLayout.SummaryDefinitionsIfAllocated != null)
						{
							fieldLayout.SummaryDefinitionsIfAllocated.Refresh();
							goto IL_639;
						}
						goto IL_639;
					}
					default:
						goto IL_637;
					}
					flag2 = true;
					if (fieldLayout != null)
					{
						fieldLayout._cachedRecordFiltersLogicalOperatorResolved = null;
						fieldLayout.BumpRecordFilterVersion();
						goto IL_639;
					}
					goto IL_639;
					IL_4F6:
					if (fieldLayout != null)
					{
						fieldLayout.BumpRecordIndentVersionAsync();
					}
					flag3 = true;
					if (propertyName == "GroupByExpansionIndicatorVisibility")
					{
						flag2 = true;
						goto IL_639;
					}
					goto IL_639;
				}
			}
			IL_637:
			flag3 = true;
			IL_639:
			if (flag3 && flag)
			{
				if (fieldLayout == null)
				{
					presenter.InvalidateGeneratedStylesAsync(true);
				}
				else
				{
					fieldLayout.PostDelayedInvalidation(true);
				}
			}
			if (flag2 && fieldLayout != null)
			{
				fieldLayout.RaisePropertyChangedEvent(propertyName + "Resolved");
			}
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		internal void Reset()
		{
			this._styleGenerator = null;
			this._isInitialized = false;
			this._autoFitState = null;
			if (this._templateDataRecordCache != null)
			{
				this._templateDataRecordCache.BumpCacheVersion(true);
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0009FF20 File Offset: 0x0009E120
		internal void ResetCachedChildRecordsDisplayOrderResolvedValue()
		{
			this._cachedChildRecordsDisplayOrderResolved = null;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0009FF2E File Offset: 0x0009E12E
		internal void ReturnHeaderPresenterToCache(global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter)
		{
			this.HeaderPresenterCache.Add(headerPresenter);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0009FF3C File Offset: 0x0009E13C
		internal void SetFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.LayoutInfo newLayoutInfo, bool mergeWithCurrent, bool syncFieldVisibility)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			if (this._fieldLayoutInfo != newLayoutInfo)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fields)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = (this._fieldLayoutInfo != null) ? this._fieldLayoutInfo[field] : null;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = (newLayoutInfo != null) ? newLayoutInfo[field] : null;
					if (itemLayoutInfo != itemLayoutInfo2 && (itemLayoutInfo == null || itemLayoutInfo2 == null || !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(itemLayoutInfo, itemLayoutInfo2)))
					{
						list.Add(field);
					}
				}
				if (this._fieldLayoutInfo != null && mergeWithCurrent)
				{
					this._fieldLayoutInfo.Merge(newLayoutInfo, true);
				}
				else
				{
					this._fieldLayoutInfo = newLayoutInfo;
				}
			}
			global::Infragistics.Windows.DataPresenter.Field.RaisePropertyChangedEventHelper(list, "ActualPosition");
			if (syncFieldVisibility && newLayoutInfo != null)
			{
				newLayoutInfo.SynchronizeFieldVisibility();
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000A0014 File Offset: 0x0009E214
		internal void SetGridCounts(int totalColumnsGenerated, int totalRowsGenerated)
		{
			this._totalColumnsGenerated = totalColumnsGenerated;
			this._totalRowsGenerated = totalRowsGenerated;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000A0024 File Offset: 0x0009E224
		internal void SetHasSeparateHeader(bool separateHeader)
		{
			this._cachedHasSeparateHeader = separateHeader;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.HasSeparateHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(separateHeader));
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000A0040 File Offset: 0x0009E240
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return this.ShouldSerializeSettings() || this.ShouldSerializeDescription() || this.ShouldSerializeFields() || this.ShouldSerializeFieldSettings() || this.ShouldSerializeRecordFilters() || this.ShouldSerializeSummaryDefinitions() || this.ShouldSerializeKey() || global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000A0090 File Offset: 0x0009E290
		internal void VerifyAutoFitSettings(bool force)
		{
			if (this._autoFitState == null || force)
			{
				if (this._styleGenerator != null && !this._styleGenerator.IsGeneratingTemplates && this.TemplateDataRecordCache.IsInitializingCache)
				{
					this._styleGenerator.GenerateTemplates();
				}
				global::Infragistics.Windows.DataPresenter.AutoFitState autoFitState = global::Infragistics.Windows.DataPresenter.FieldLayout.ResolveAutoFit(this);
				if (autoFitState != this._autoFitState)
				{
					bool flag = this._autoFitState != null;
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState2 = this._autoFitState;
					this._autoFitState = new global::Infragistics.Windows.DataPresenter.AutoFitState?(autoFitState);
					if (flag)
					{
						this.InvalidateGeneratedStyles(true, true);
					}
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState3 = this._autoFitState;
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState4 = (autoFitState3 != null) ? new global::Infragistics.Windows.DataPresenter.AutoFitState?(autoFitState3.GetValueOrDefault() & global::Infragistics.Windows.DataPresenter.AutoFitState.Width) : null;
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState5 = autoFitState2;
					if (autoFitState4 != ((autoFitState5 != null) ? new global::Infragistics.Windows.DataPresenter.AutoFitState?(autoFitState5.GetValueOrDefault() & global::Infragistics.Windows.DataPresenter.AutoFitState.Width) : null))
					{
						this.OnPropertyChanged("AutoFitToWidth");
					}
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState6 = this._autoFitState;
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState7 = (autoFitState6 != null) ? new global::Infragistics.Windows.DataPresenter.AutoFitState?(autoFitState6.GetValueOrDefault() & global::Infragistics.Windows.DataPresenter.AutoFitState.Height) : null;
					global::Infragistics.Windows.DataPresenter.AutoFitState? autoFitState8 = autoFitState2;
					if (autoFitState7 != ((autoFitState8 != null) ? new global::Infragistics.Windows.DataPresenter.AutoFitState?(autoFitState8.GetValueOrDefault() & global::Infragistics.Windows.DataPresenter.AutoFitState.Height) : null))
					{
						this.OnPropertyChanged("AutoFitToHeight");
					}
				}
			}
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x000A0248 File Offset: 0x0009E448
		internal void VerifyAllPropertyDescriptorProviders()
		{
			if (this._propertyDescriptorProviders == null)
			{
				return;
			}
			for (int i = this._propertyDescriptorProviders.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = this._propertyDescriptorProviders[i];
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference) as global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider;
				if (layoutPropertyDescriptorProvider != null)
				{
					layoutPropertyDescriptorProvider.VerifyFieldDescriptors();
				}
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000A0298 File Offset: 0x0009E498
		internal void VerifyStyleGeneratorTemplates()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this._styleGenerator;
			if (styleGenerator != null && !styleGenerator.IsGeneratingTemplates)
			{
				styleGenerator.GenerateTemplates();
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000A02C0 File Offset: 0x0009E4C0
		internal void VerifyTreeMappings()
		{
			if (!this._areTreeFieldMappingsDirty || this._presenter == null || !this.IsInitialized || this._isVerifyingTreeMappings)
			{
				return;
			}
			try
			{
				this._isVerifyingTreeMappings = true;
				this.VerifyTreeMappingsImpl();
			}
			finally
			{
				this._isVerifyingTreeMappings = false;
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x000A0318 File Offset: 0x0009E518
		private void VerifyTreeMappingsImpl()
		{
			this._areTreeFieldMappingsDirty = false;
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this._presenter.DefaultFieldLayout;
			if (this._alignmentFieldLayout != null && defaultFieldLayout != this._alignmentFieldLayout)
			{
				this.AlignmentFieldLayout = null;
			}
			if (defaultFieldLayout == null)
			{
				if (this._fieldMap != null)
				{
					this._fieldMap.Clear();
				}
				if (this._placeholderFields != null)
				{
					this._placeholderFields = null;
					this._placeholderFieldsVersion++;
				}
				return;
			}
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.Field> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.Field>(new global::Infragistics.Windows.DataPresenter.FieldLayout.LabelComparer());
			foreach (global::Infragistics.Windows.DataPresenter.Field field in defaultFieldLayout.Fields)
			{
				if (!field.IsExpandableResolved)
				{
					object obj = field.Label;
					if (obj == null || dictionary.ContainsKey(obj))
					{
						obj = new object();
					}
					dictionary[obj] = field;
					field.MappedTreeField = null;
				}
			}
			if (defaultFieldLayout == this || !this._presenter.IsTreeView)
			{
				this._fieldMap = null;
				if (this._placeholderFields != null)
				{
					this._placeholderFields = null;
					this._placeholderFieldsVersion++;
				}
				return;
			}
			this._autoSizeInfo = null;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field> fieldMap = this._fieldMap;
			global::Infragistics.Windows.DataPresenter.PlaceholderField[] placeholderFields = this._placeholderFields;
			this._fieldMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field>();
			this.AlignmentFieldLayout = defaultFieldLayout;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this.Fields)
			{
				if (!field2.IsExpandableResolved && field2.Label != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field3;
					if (dictionary.TryGetValue(field2.Label, out field3))
					{
						field2.MappedTreeField = field3;
						dictionary.Remove(field2.Label);
						this._fieldMap.Add(field3, field2);
					}
					else
					{
						list.Add(field2);
					}
				}
			}
			global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>(global::System.Collections.Generic.EqualityComparer<string>.Default);
			foreach (global::Infragistics.Windows.DataPresenter.Field field4 in dictionary.Values)
			{
				dictionary2[field4.Name] = field4;
			}
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field5 = list[i];
					string text = field5.Label as string;
					global::Infragistics.Windows.DataPresenter.Field field3;
					if (text != null && dictionary2.TryGetValue(text, out field3))
					{
						field5.MappedTreeField = field3;
						dictionary2.Remove(text);
						this._fieldMap.Add(field3, field5);
						list.RemoveAt(i);
						i--;
					}
				}
				if (list.Count > 0)
				{
					for (int j = 0; j < list.Count; j++)
					{
						global::Infragistics.Windows.DataPresenter.Field field6 = list[j];
						string name = field6.Name;
						global::Infragistics.Windows.DataPresenter.Field field3;
						if (dictionary2.TryGetValue(name, out field3))
						{
							field6.MappedTreeField = field3;
							dictionary2.Remove(name);
							this._fieldMap.Add(field3, field6);
							list.RemoveAt(j);
							j--;
						}
					}
				}
			}
			if (list.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field7 in list)
				{
					field7.MappedTreeField = global::Infragistics.Windows.DataPresenter.Field.UnMappedField;
				}
			}
			if (this._fieldMap.Count == 0)
			{
				global::Infragistics.Windows.DataPresenter.Field parentField = this.ParentField;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(string.Format("There are no fields in FieldLayout: '{0}'", this));
				if (parentField != null)
				{
					stringBuilder.Append(string.Format(" (from parent field: '{0}')", parentField));
				}
				stringBuilder.Append(" that map to fields in the default FieldLayout. ");
				stringBuilder.Append(global::System.Environment.NewLine);
				if (parentField != null)
				{
					stringBuilder.Append(string.Format("  - To collapse these records set the {0} Field's Visibility property to 'Collapsed'. ", parentField.Name));
					stringBuilder.Append(global::System.Environment.NewLine);
				}
				stringBuilder.Append("  - To map a field from this FieldLayout set its 'Label' property so that it matches a field's Label or Name in the default FieldLayout.");
				stringBuilder.Append(global::System.Environment.NewLine);
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(stringBuilder.ToString());
			}
			if (dictionary2.Count > 0)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>(dictionary2.Values);
				for (int k = 0; k < list2.Count; k++)
				{
					global::Infragistics.Windows.DataPresenter.Field field8 = list2[k];
					if (field8.VisibilityResolved == global::System.Windows.Visibility.Collapsed || !field8.IsValid)
					{
						dictionary2.Remove(field8.Name);
					}
				}
			}
			bool flag = false;
			if (placeholderFields != null && placeholderFields.Length > 0)
			{
				if (placeholderFields.Length == dictionary2.Count)
				{
					flag = true;
					foreach (global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField in placeholderFields)
					{
						if (!dictionary2.ContainsValue(placeholderField.MappedTreeField))
						{
							flag = false;
							break;
						}
					}
				}
				if (!flag)
				{
					foreach (global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField2 in placeholderFields)
					{
						placeholderField2.SetPlaceholderIndex(-1);
					}
				}
			}
			if (flag)
			{
				if (this._placeholderFields != null)
				{
					for (int n = 0; n < this._placeholderFields.Length; n++)
					{
						global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField3 = this._placeholderFields[n];
						this._fieldMap.Add(placeholderField3.MappedTreeField, placeholderField3);
					}
				}
			}
			else
			{
				if (dictionary2.Count == 0)
				{
					this._placeholderFields = null;
				}
				else
				{
					this._placeholderFields = new global::Infragistics.Windows.DataPresenter.PlaceholderField[dictionary2.Count];
					int num = 0;
					foreach (global::Infragistics.Windows.DataPresenter.Field field9 in dictionary2.Values)
					{
						global::Infragistics.Windows.DataPresenter.Field field3;
						global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField4;
						if (fieldMap != null && fieldMap.TryGetValue(field9, out field3) && field3.IsPlaceholderForTreeView)
						{
							placeholderField4 = (field3 as global::Infragistics.Windows.DataPresenter.PlaceholderField);
						}
						else
						{
							placeholderField4 = new global::Infragistics.Windows.DataPresenter.PlaceholderField(this, field9);
						}
						this._fieldMap.Add(field9, placeholderField4);
						placeholderField4.SetPlaceholderIndex(num);
						this._placeholderFields[num] = placeholderField4;
						num++;
					}
				}
				this._placeholderFieldsVersion++;
			}
			this.SynchronizeSortedFields();
			this.SynchronizeSummaryDefinitions();
			this.VerifyFiltersAreSynchronized();
			this._fields.BumpVersion();
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x000A096C File Offset: 0x0009EB6C
		private void ClearCachedTreeField()
		{
			if (this._treeField != null)
			{
				global::Infragistics.Windows.DataPresenter.Field oldTreeField = this._treeField;
				if (this._presenter != null)
				{
					if (this._presenter.IsSynchronousControl)
					{
						oldTreeField.IsTreeField = false;
					}
					else
					{
						base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
						{
							oldTreeField.IsTreeField = (oldTreeField == this.TreeField);
						}), new object[0]);
					}
				}
				this._treeField = null;
				this._areTreeFieldMappingsDirty = true;
				return;
			}
			if (this._presenter != null && this.IsInitialized)
			{
				this._areTreeFieldMappingsDirty = this._presenter.IsTreeView;
			}
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000A0A14 File Offset: 0x0009EC14
		private T GetResolvedValue<T>(global::System.Windows.DependencyProperty property, T defaultValue, T defaultResolvedValue)
		{
			if (this._settings != null)
			{
				T t = (T)((object)this._settings.GetValue(property));
				if (!object.Equals(defaultValue, t))
				{
					return t;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = (this._presenter != null) ? this._presenter.FieldLayoutSettingsIfAllocated : null;
			if (fieldLayoutSettings != null)
			{
				T t = (T)((object)fieldLayoutSettings.GetValue(property));
				if (!object.Equals(defaultValue, t))
				{
					return t;
				}
			}
			return defaultResolvedValue;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000A0A90 File Offset: 0x0009EC90
		internal bool HasStarFields(bool width)
		{
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this.Fields)
			{
				if (field.IsInLayout && field.GetWidthOrHeight(width).IsStar)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000A0AF8 File Offset: 0x0009ECF8
		private void InitializeHeaderPresenter(global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter)
		{
			headerPresenter.Content = this;
			headerPresenter.SetBinding(global::System.Windows.Controls.ContentControl.ContentTemplateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("HeaderAreaTemplate", global::System.Windows.Data.BindingMode.OneWay, this));
			headerPresenter.SetBinding(global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000A0B34 File Offset: 0x0009ED34
		private void InvalidateCellContentAlignmentResolved()
		{
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._fields;
			if (fields != null)
			{
				int i = 0;
				int count = fields.Count;
				while (i < count)
				{
					fields[i].DirtyCellContentAlignmentCache();
					i++;
				}
			}
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000A0B6A File Offset: 0x0009ED6A
		private void OnAlignmentLayoutFilterVersionChanged()
		{
			this._areFiltersSynchronized = false;
			global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(this.VerifyFiltersAreSynchronized), new object[0]);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000A0B90 File Offset: 0x0009ED90
		private void OnCustomFilterDialogClosed(global::Infragistics.Windows.Controls.ToolWindow toolWindow, bool? dialogResult)
		{
			toolWindow.Resources = null;
			if (this._presenter != null && this._presenter.IsKeyboardFocusWithin)
			{
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this._presenter);
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true, this._presenter) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
					if (labelPresenter != null && labelPresenter.DataPresenter == this._presenter)
					{
						global::Infragistics.Windows.DataPresenter.Record activeRecord = this._presenter.ActiveRecord;
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (activeRecord != null) ? activeRecord.AssociatedRecordPresenter : null;
						if (recordPresenter != null)
						{
							recordPresenter.Focus();
							return;
						}
						this._presenter.Focus();
					}
				}
			}
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000A0C38 File Offset: 0x0009EE38
		private void OnAlignmentFieldLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "GridColumnWidthVersion")
				{
					this.BumpLayoutItemVersion();
					return;
				}
				if (propertyName == "LayoutManagerVersion")
				{
					this.DirtyFixedState();
					return;
				}
				if (propertyName == "SortVersion")
				{
					this.SynchronizeSortedFields();
					return;
				}
				if (!(propertyName == "SpecialRecordsVersion"))
				{
					return;
				}
				this.SynchronizeSummaryDefinitions();
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000A0C9F File Offset: 0x0009EE9F
		private void OnFieldCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnFieldCollectionChanged(e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, ((global::Infragistics.Windows.DataPresenter.FieldCollection)sender).Count > 0);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000A0CC0 File Offset: 0x0009EEC0
		private void OnFieldCollectionChanged(bool isReset = true, bool hasFields = true)
		{
			this._fieldCollectionChangePending = null;
			this._hasUnboundFieldsWithoutBindings = null;
			if (this._isInFieldInitialization)
			{
				return;
			}
			if (!hasFields || isReset)
			{
				this._areFieldsInitialized = false;
			}
			this.DirtyFixedState();
			this.TemplateDataRecordCache.BumpCacheVersion(true);
			if (this._presenter != null && this._presenter.IsInitialized)
			{
				this.InvalidateGeneratedStylesAsnyc(true, isReset);
				global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this._presenter, this, "Fields", null);
			}
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000A0D38 File Offset: 0x0009EF38
		private void OnNewFieldLayoutSettings()
		{
			if (this._settings != null)
			{
				this._settings.PropertyChanged += this.OnSettingsPropertyChanged;
				if (this._settings.HasFieldBinding)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter != null)
					{
						this._settings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, this.DataContext);
					}
				}
			}
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000A0D94 File Offset: 0x0009EF94
		private void OnNewFieldSettings()
		{
			if (this._cachedFieldSettings != null)
			{
				this._cachedFieldSettings.PropertyChanged += this.OnFieldSettingsPropertyChanged;
				if (this._cachedFieldSettings.HasFieldBinding)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter != null)
					{
						this._cachedFieldSettings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DataContextProperty, this.DataContext);
					}
				}
			}
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000A0DF0 File Offset: 0x0009EFF0
		private void OnSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout.ProcessFieldLayoutSettingsPropertyChanged(e, this._settings, this, null != dataPresenter, this, dataPresenter);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000A0E1A File Offset: 0x0009F01A
		internal void PostDelayedInvalidation(bool invalidateTemplates = true)
		{
			if (this._presenter != null && !this._isInFieldInitialization)
			{
				this._presenter.InvalidateGeneratedStylesAsync(invalidateTemplates);
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000A0E48 File Offset: 0x0009F048
		private void ProcessLabelChangeInTreeViewAsync()
		{
			this.ClearCachedTreeField();
			if (this._fieldCollectionChangePending == null)
			{
				this._fieldCollectionChangePending = global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this.ClearCachedTreeField();
					this.OnFieldCollectionChanged(true, true);
				}), new object[0]);
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000A0E7C File Offset: 0x0009F07C
		private void ProcessPendingFieldsToRefresh()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (object obj in this._pendingFieldsToRefresh)
			{
				global::Infragistics.Windows.DataPresenter.Field item = (global::Infragistics.Windows.DataPresenter.Field)obj;
				list.Add(item);
			}
			this._pendingFieldsToRefresh = null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record[] recordsInView = dataPresenter.GetRecordsInView(true);
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			foreach (global::Infragistics.Windows.DataPresenter.Record record in recordsInView)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && dataRecord.FieldLayout == this)
				{
					hashSet.Add(dataRecord);
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = dataPresenter.ActiveRecordInternal as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord2 != null && dataRecord2.AssociatedRecordPresenter != null && dataRecord2.FieldLayout == this)
			{
				hashSet.Add(dataRecord2);
			}
			foreach (object obj2 in hashSet)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = (global::Infragistics.Windows.DataPresenter.DataRecord)obj2;
				dataRecord3.RefreshCellValues(list, true);
			}
			this.BumpRecordFilterVersion();
			if (this._summaryDefinitions != null)
			{
				this._summaryDefinitions.BumpDataVersion();
			}
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
		private void ProcessPropertyDescriptorsChanged(global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider, bool postInvalidation)
		{
			if (!this.AutoGenerateFieldsResolved)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this.Fields;
			global::System.Collections.Generic.Dictionary<string, global::System.ComponentModel.PropertyDescriptor> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.ComponentModel.PropertyDescriptor>();
			foreach (object obj in provider.GetProperties())
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
				dictionary[propertyDescriptor.Name] = propertyDescriptor;
			}
			global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			int num = 0;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
			{
				if (field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
				{
					global::System.ComponentModel.PropertyDescriptor pd;
					if (dictionary.TryGetValue(field.Name, out pd))
					{
						field.OnPropertyDescriptorChanged(pd, provider);
						dictionary2[field.Name] = field;
						if (field.AutoGenerated)
						{
							num++;
						}
					}
					else
					{
						list.Add(field);
					}
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.ComponentModel.PropertyDescriptor> keyValuePair in dictionary)
			{
				if (!dictionary2.ContainsKey(keyValuePair.Key) && num <= this.MaxFieldsToAutoGenerateResolved)
				{
					this.OnPropertyDescriptorAdded(keyValuePair.Value, provider);
					num++;
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field item in list)
			{
				fields.Remove(item);
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000A118C File Offset: 0x0009F38C
		internal void PropertyDescriptorAddedHelper(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider, bool autoGenerate, bool postInvalidation)
		{
			global::Infragistics.Windows.DataPresenter.Field fieldFromPropertyDescriptor = this.Fields.GetFieldFromPropertyDescriptor(propertyDescriptor);
			if (fieldFromPropertyDescriptor != null)
			{
				this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, false, postInvalidation);
				return;
			}
			if (!autoGenerate)
			{
				return;
			}
			global::System.Type propertyType = propertyDescriptor.PropertyType;
			if (propertyType != null)
			{
				global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(propertyType);
				if (underlyingType != typeof(string) && typeof(global::System.Collections.IEnumerable).IsAssignableFrom(underlyingType))
				{
					global::System.ComponentModel.PropertyDescriptorCollection properties = provider.GetProperties();
					if (!properties.Contains(propertyDescriptor))
					{
						return;
					}
				}
			}
			int num = 0;
			this.InitializeFieldHelper(propertyDescriptor, provider.Source, new global::Infragistics.Windows.DataPresenter.Field[0], true, ref num);
			if (postInvalidation)
			{
				this.PostDelayedInvalidation(true);
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000A122C File Offset: 0x0009F42C
		private void PropertyDescriptorChangedHelper(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider, bool deleted, bool postInvalidation)
		{
			bool flag = false;
			if (propertyDescriptor == null)
			{
				this.ProcessPropertyDescriptorsChanged(provider, postInvalidation);
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field fieldFromPropertyDescriptor = this.Fields.GetFieldFromPropertyDescriptor(propertyDescriptor);
			if (fieldFromPropertyDescriptor == null)
			{
				return;
			}
			bool flag2 = false;
			if (!deleted)
			{
				global::System.Type left = (fieldFromPropertyDescriptor != null) ? fieldFromPropertyDescriptor.DataType : null;
				flag2 = (left != null && left != typeof(object) && left != propertyDescriptor.PropertyType);
			}
			for (int i = this._propertyDescriptorProviders.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = this._propertyDescriptorProviders[i];
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference) as global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider;
				if (layoutPropertyDescriptorProvider == null)
				{
					this._propertyDescriptorProviders.RemoveAt(i);
				}
				else if (layoutPropertyDescriptorProvider.Provider == provider)
				{
					layoutPropertyDescriptorProvider.Dirty();
					if (deleted && (fieldFromPropertyDescriptor == null || !fieldFromPropertyDescriptor.AutoGenerated))
					{
						return;
					}
				}
				else if (fieldFromPropertyDescriptor != null && fieldFromPropertyDescriptor.AutoGenerated)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = layoutPropertyDescriptorProvider.GetFieldDescriptor(fieldFromPropertyDescriptor);
					if (fieldDescriptor != null)
					{
						flag = true;
						break;
					}
				}
			}
			if (deleted)
			{
				if (!flag)
				{
					this.Fields.Remove(fieldFromPropertyDescriptor);
				}
				this.PostDelayedInvalidation(true);
				return;
			}
			if (flag2 && flag)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fieldFromPropertyDescriptor.Clone(true);
				field.IsPrimary = false;
				field.OnPropertyDescriptorChanged(propertyDescriptor, provider);
				this.Fields.Add(field);
			}
			else
			{
				fieldFromPropertyDescriptor.OnPropertyDescriptorChanged(propertyDescriptor, provider);
				fieldFromPropertyDescriptor.BumpPropertyDescriptorVersion();
			}
			if (postInvalidation)
			{
				this.PostDelayedInvalidation(true);
			}
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000A1384 File Offset: 0x0009F584
		private static global::Infragistics.Windows.DataPresenter.AutoFitState ResolveAutoFit(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = fl._presenter;
			if (presenter == null)
			{
				return global::Infragistics.Windows.DataPresenter.AutoFitState.None;
			}
			global::Infragistics.Windows.DataPresenter.AutoFitState autoFitState = global::Infragistics.Windows.DataPresenter.AutoFitState.None;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = presenter.CurrentViewInternal;
			global::Infragistics.Windows.DataPresenter.AutoFitMode autoFitMode = fl.AutoFitModeResolved;
			if (autoFitMode == global::Infragistics.Windows.DataPresenter.AutoFitMode.Default)
			{
				if (presenter.AutoFitResolved)
				{
					autoFitState = global::Infragistics.Windows.DataPresenter.AutoFitState.WidthAndHeight;
				}
				else if (presenter.AutoFit == null)
				{
					autoFitMode = global::Infragistics.Windows.DataPresenter.AutoFitMode.OnlyWithVisibleStarFields;
				}
				else
				{
					autoFitMode = global::Infragistics.Windows.DataPresenter.AutoFitMode.Never;
				}
			}
			switch (autoFitMode)
			{
			case global::Infragistics.Windows.DataPresenter.AutoFitMode.Never:
				autoFitState = global::Infragistics.Windows.DataPresenter.AutoFitState.None;
				break;
			case global::Infragistics.Windows.DataPresenter.AutoFitMode.Always:
			case global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField:
				autoFitState = global::Infragistics.Windows.DataPresenter.AutoFitState.WidthAndHeight;
				break;
			case global::Infragistics.Windows.DataPresenter.AutoFitMode.OnlyWithVisibleStarFields:
				if (fl.HasStarFields(true))
				{
					autoFitState |= global::Infragistics.Windows.DataPresenter.AutoFitState.Width;
				}
				if (fl.HasStarFields(false))
				{
					autoFitState |= global::Infragistics.Windows.DataPresenter.AutoFitState.Height;
				}
				break;
			}
			if (!currentViewInternal.IsAutoFitWidthSupported)
			{
				autoFitState &= ~global::Infragistics.Windows.DataPresenter.AutoFitState.Width;
			}
			if (!currentViewInternal.IsAutoFitHeightSupported)
			{
				autoFitState &= ~global::Infragistics.Windows.DataPresenter.AutoFitState.Height;
			}
			return autoFitState;
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000A1438 File Offset: 0x0009F638
		private void SynchronizeSortedFields()
		{
			if (this._alignmentFieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = this._alignmentFieldLayout.SortedFields;
			if (sortedFields == null || sortedFields.Count == 0)
			{
				if (this._sortedFields != null)
				{
					this._sortedFields.Clear();
				}
				return;
			}
			bool flag = sortedFields.Count == this.SortedFields.Count;
			if (flag)
			{
				for (int i = 0; i < sortedFields.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2 = this._sortedFields[i];
					if (fieldSortDescription.Direction != fieldSortDescription2.Direction || fieldSortDescription.IsGroupBy != fieldSortDescription2.IsGroupBy)
					{
						flag = false;
						break;
					}
					global::Infragistics.Windows.DataPresenter.Field field = fieldSortDescription.Field;
					if (field == null)
					{
						field = this.GetFieldFromMappedField(fieldSortDescription.FieldName);
					}
					global::Infragistics.Windows.DataPresenter.Field field2 = fieldSortDescription2.Field;
					if (field2 == null)
					{
						field2 = this.GetFieldFromMappedField(fieldSortDescription2.FieldName);
					}
					if (field2 == null || field == null || field != field2.MappedTreeField)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields2 = this.SortedFields;
			sortedFields2.BeginUpdate();
			sortedFields2.Clear();
			if (this._fieldMap != null && this._fieldMap.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription3 in sortedFields)
				{
					global::Infragistics.Windows.DataPresenter.Field field3;
					if (this._fieldMap.TryGetValue(fieldSortDescription3.Field, out field3))
					{
						sortedFields2.Add(new global::Infragistics.Windows.DataPresenter.FieldSortDescription(field3.Name, fieldSortDescription3.Direction, fieldSortDescription3.IsGroupBy));
					}
				}
			}
			sortedFields2.EndUpdate();
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000A15D8 File Offset: 0x0009F7D8
		private void SynchronizeSummaryDefinitions()
		{
			if (this._alignmentFieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionsIfAllocated = this._alignmentFieldLayout.SummaryDefinitionsIfAllocated;
			if (summaryDefinitionsIfAllocated == null || summaryDefinitionsIfAllocated.Count == 0)
			{
				if (this._summaryDefinitions != null)
				{
					this._summaryDefinitions.Clear();
				}
				return;
			}
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions = this.SummaryDefinitions;
			bool flag = summaryDefinitionsIfAllocated.Count == summaryDefinitions.Count;
			if (flag)
			{
				for (int i = 0; i < summaryDefinitions.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition = summaryDefinitionsIfAllocated[i];
					global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition2 = summaryDefinitions[i];
					if (summaryDefinition.Calculator != summaryDefinition2.Calculator || summaryDefinition.Key != summaryDefinition2.Key)
					{
						flag = false;
						break;
					}
					global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField = this.GetFieldFromMappedField(summaryDefinition.SourceFieldName);
					if (fieldFromMappedField.Name != summaryDefinition2.SourceFieldName)
					{
						flag = false;
						break;
					}
					string positionFieldName = summaryDefinition.PositionFieldName;
					string positionFieldName2 = summaryDefinition2.PositionFieldName;
					if (positionFieldName != positionFieldName2)
					{
						if (string.IsNullOrEmpty(positionFieldName) || string.IsNullOrEmpty(positionFieldName2))
						{
							flag = false;
							break;
						}
						global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField2 = this.GetFieldFromMappedField(positionFieldName);
						global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField3 = this.GetFieldFromMappedField(positionFieldName2);
						if (fieldFromMappedField2 == null || fieldFromMappedField3 == null || fieldFromMappedField2 != fieldFromMappedField3.MappedTreeField)
						{
							flag = false;
							break;
						}
					}
					if (summaryDefinition.IsVisible != summaryDefinition2.IsVisible)
					{
						summaryDefinition2.IsVisible = summaryDefinition.IsVisible;
					}
				}
				if (flag)
				{
					return;
				}
			}
			summaryDefinitions.Clear();
			if (this._fieldMap != null && this._fieldMap.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition3 in summaryDefinitionsIfAllocated)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField4 = this.GetFieldFromMappedField(summaryDefinition3.SourceFieldName);
					if (fieldFromMappedField4 != null)
					{
						global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition4 = global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(summaryDefinition3, false) as global::Infragistics.Windows.DataPresenter.SummaryDefinition;
						summaryDefinition4.SourceFieldName = fieldFromMappedField4.Name;
						string positionFieldName3 = summaryDefinition3.PositionFieldName;
						if (!string.IsNullOrEmpty(positionFieldName3))
						{
							if (positionFieldName3 == fieldFromMappedField4.Name)
							{
								summaryDefinition4.PositionFieldName = fieldFromMappedField4.Name;
							}
							else
							{
								global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField5 = this.GetFieldFromMappedField(positionFieldName3);
								if (fieldFromMappedField5 != null)
								{
									summaryDefinition4.PositionFieldName = fieldFromMappedField5.Name;
								}
							}
						}
						summaryDefinitions.Add(summaryDefinition4);
					}
				}
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x000A1820 File Offset: 0x0009FA20
		private void VerifyActiveCell()
		{
			if (this._presenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._presenter.ActiveCell;
				if (activeCell != null && !activeCell.Field.IsValid)
				{
					this._presenter.ActiveCell = null;
				}
			}
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000A1860 File Offset: 0x0009FA60
		private void VerifyFiltersAreSynchronized()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this.AlignmentFieldLayout;
			if (this._areFiltersSynchronized || alignmentFieldLayout == null)
			{
				return;
			}
			this._areFiltersSynchronized = true;
			this.RecordFilters.SynchronizeTreeFilters();
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000A1894 File Offset: 0x0009FA94
		private void VerifyLayoutManagers()
		{
			if (this._verifiedLayoutManagerVersion != this.LayoutManagerVersion)
			{
				this._verifiedLayoutManagerVersion = this.LayoutManagerVersion;
				if (this._cellLayoutManager == null)
				{
					this._cellLayoutManager = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateGridBagLayoutManager(this, global::Infragistics.Windows.DataPresenter.LayoutManagerType.Record);
				}
				if (this._labelLayoutManager == null)
				{
					this._labelLayoutManager = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateGridBagLayoutManager(this, global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header);
				}
			}
			this._labelLayoutManager.VerifyLayout();
			this._cellLayoutManager.VerifyLayout();
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000A18FC File Offset: 0x0009FAFC
		public void EnsureUniqueFieldPositions()
		{
			global::Infragistics.Windows.DataPresenter.LayoutInfo fieldLayoutInfo = this.GetFieldLayoutInfo(false, false);
			if (fieldLayoutInfo != null)
			{
				bool flag = fieldLayoutInfo.EnsureItemsDontOverlap();
				this.SetFieldLayoutInfo(fieldLayoutInfo, true, false);
				if (flag)
				{
					this.InvalidateGeneratedStylesAsnyc(false, false);
				}
			}
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000A19F8 File Offset: 0x0009FBF8
		public void ShowCustomFilterSelectionControl(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(recordFilter, "recordFilter");
			if (!this.Fields.Contains(recordFilter.Field))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_MismatchedFieldLayoutInRecordFilter", new object[]
				{
					recordFilter.Field.Name
				}));
			}
			global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl = new global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl(recordFilter, recordManager);
			global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs customFilterSelectionControlOpeningEventArgs = new global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs(recordFilter, customFilterSelectionControl);
			this.DataPresenter.RaiseCustomFilterSelectionControlOpening(customFilterSelectionControlOpeningEventArgs);
			if (customFilterSelectionControlOpeningEventArgs.Cancel)
			{
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = new global::Infragistics.Windows.Controls.ToolWindow();
			global::System.Windows.FrameworkElement dataPresenter = this.DataPresenter;
			toolWindow.Content = customFilterSelectionControl;
			toolWindow.ResizeMode = global::System.Windows.ResizeMode.CanResizeWithGrip;
			toolWindow.Height = 380.0;
			toolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl.TitleDescriptionProperty, global::System.Windows.Data.BindingMode.OneWay, customFilterSelectionControl));
			toolWindow.Resources = this.DataPresenter.Resources;
			toolWindow.Loaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::System.Windows.Threading.DispatcherOperationCallback method = delegate(object param)
				{
					((global::Infragistics.Windows.Controls.ToolWindow)param).MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
					return null;
				};
				((global::Infragistics.Windows.Controls.ToolWindow)sender).Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, method, sender);
			};
			toolWindow.Closing += delegate(object sender, global::System.ComponentModel.CancelEventArgs e)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)sender;
				global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl customFilterSelectionControl2 = toolWindow.Content as global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl;
				if (toolWindow.DialogResult == null && customFilterSelectionControl2 != null && customFilterSelectionControl2.IsDirty)
				{
					global::System.Windows.MessageBoxResult messageBoxResult = global::Infragistics.Windows.Utilities.ShowMessageBox(this, customFilterSelectionControl2.CancelMessageText, customFilterSelectionControl2.CancelMessageTitle, global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Exclamation);
					if (messageBoxResult == global::System.Windows.MessageBoxResult.No)
					{
						e.Cancel = true;
					}
				}
			};
			toolWindow.ShowDialog(dataPresenter, new global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback(this.OnCustomFilterDialogClosed));
		}

		// Token: 0x040011B2 RID: 4530
		private const double DefaultRecordSelectorBaseExtent = 20.0;

		// Token: 0x040011B3 RID: 4531
		private const double DefaultRecordSelectorErrorIconExtent = 10.0;

		// Token: 0x040011B4 RID: 4532
		private const double DefaultRecordSelectorFixButtonExtent = 12.0;

		// Token: 0x040011B5 RID: 4533
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.DataColumn> _dataColumnMap;

		// Token: 0x040011B6 RID: 4534
		private global::Infragistics.Windows.DataPresenter.FieldCollection _fields;

		// Token: 0x040011B7 RID: 4535
		private global::Infragistics.Windows.DataPresenter.Field _primaryField;

		// Token: 0x040011B8 RID: 4536
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x040011B9 RID: 4537
		private bool _isdefault;

		// Token: 0x040011BA RID: 4538
		private bool _isInitialized;

		// Token: 0x040011BB RID: 4539
		private bool _areFieldsInitialized;

		// Token: 0x040011BC RID: 4540
		private bool _keyExplicitlySet;

		// Token: 0x040011BD RID: 4541
		private bool _initialRecordLoaded;

		// Token: 0x040011BE RID: 4542
		private bool _isInFieldInitialization;

		// Token: 0x040011BF RID: 4543
		private bool _areFieldsAutoGenerated;

		// Token: 0x040011C0 RID: 4544
		private bool _wrapsEnumerableObject;

		// Token: 0x040011C1 RID: 4545
		private bool _wasRemovedFromCollection;

		// Token: 0x040011C2 RID: 4546
		private global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator _styleGenerator;

		// Token: 0x040011C3 RID: 4547
		private int _totalRowsGenerated;

		// Token: 0x040011C4 RID: 4548
		private int _totalColumnsGenerated;

		// Token: 0x040011C5 RID: 4549
		private int _sortVersion;

		// Token: 0x040011C6 RID: 4550
		private int _groupByVersion;

		// Token: 0x040011C7 RID: 4551
		private int _index;

		// Token: 0x040011C8 RID: 4552
		private global::Infragistics.Windows.DataPresenter.FieldLayoutSettings _settings;

		// Token: 0x040011C9 RID: 4553
		private global::Infragistics.Windows.DataPresenter.FieldSettings _cachedFieldSettings;

		// Token: 0x040011CA RID: 4554
		private global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection _sortedFields;

		// Token: 0x040011CB RID: 4555
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyCell;

		// Token: 0x040011CC RID: 4556
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyField;

		// Token: 0x040011CD RID: 4557
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyRecord;

		// Token: 0x040011CE RID: 4558
		private string _cachedDescription;

		// Token: 0x040011CF RID: 4559
		private object _cachedKey;

		// Token: 0x040011D0 RID: 4560
		private global::System.Collections.Generic.List<global::System.WeakReference> _propertyDescriptorProviders;

		// Token: 0x040011D1 RID: 4561
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderPresenter> _headerPresenterCache;

		// Token: 0x040011D2 RID: 4562
		private int _primaryFieldVersion;

		// Token: 0x040011D3 RID: 4563
		private global::Infragistics.Windows.DataPresenter.Field _scrollTipField;

		// Token: 0x040011D4 RID: 4564
		private int _scrollTipFieldVersion;

		// Token: 0x040011D5 RID: 4565
		private global::Infragistics.Windows.DataPresenter.DataRecord _templateDataRecord;

		// Token: 0x040011D6 RID: 4566
		private global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache _templateDataRecordCache;

		// Token: 0x040011D7 RID: 4567
		private global::Infragistics.Windows.DataPresenter.FieldLayout _parentFieldLayout;

		// Token: 0x040011D8 RID: 4568
		private global::Infragistics.Windows.DataPresenter.Field _parentField;

		// Token: 0x040011D9 RID: 4569
		private bool _keyMatchingEnforced;

		// Token: 0x040011DA RID: 4570
		private global::Infragistics.Windows.Helpers.HashSet _pendingFieldsToRefresh;

		// Token: 0x040011DB RID: 4571
		private global::Infragistics.Windows.DataPresenter.GroupByRecord _templateGroupByRecord;

		// Token: 0x040011DC RID: 4572
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _summaryDefinitions;

		// Token: 0x040011DD RID: 4573
		private int _cachedSpecialRecordsVersion = 1;

		// Token: 0x040011DE RID: 4574
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _fieldLayoutInfo;

		// Token: 0x040011DF RID: 4575
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo _autoGeneratedPositions;

		// Token: 0x040011E0 RID: 4576
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _recordFilters;

		// Token: 0x040011E1 RID: 4577
		private global::Infragistics.Windows.DataPresenter.RecordFilterAction _cachedRecordFilterActionResolved;

		// Token: 0x040011E2 RID: 4578
		private global::Infragistics.Windows.Controls.LogicalOperator? _cachedRecordFiltersLogicalOperatorResolved;

		// Token: 0x040011E3 RID: 4579
		private global::Infragistics.Windows.DataPresenter.RecordFilterScope? _cachedRecordFilterScopeResolvedDefault;

		// Token: 0x040011E4 RID: 4580
		private global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType? _cachedRecordSelectorNumberTypeResolved;

		// Token: 0x040011E5 RID: 4581
		private bool? _cachedReevaluateFiltersOnDataChange;

		// Token: 0x040011E6 RID: 4582
		private bool? _cachedReevaluateFiltersOnRecordsAdded;

		// Token: 0x040011E7 RID: 4583
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _cellLayoutManager;

		// Token: 0x040011E8 RID: 4584
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _labelLayoutManager;

		// Token: 0x040011E9 RID: 4585
		private int _verifiedLayoutManagerVersion = -1;

		// Token: 0x040011EA RID: 4586
		private int _layoutManagerVersion;

		// Token: 0x040011EB RID: 4587
		private int _layoutItemVersion = 1;

		// Token: 0x040011EC RID: 4588
		private int _fixedFieldVersion;

		// Token: 0x040011ED RID: 4589
		private global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo _fixedFieldInfo;

		// Token: 0x040011EE RID: 4590
		private global::System.Windows.Size _expansionIndicatorSize;

		// Token: 0x040011EF RID: 4591
		private int _indentOffsetVersion;

		// Token: 0x040011F0 RID: 4592
		private bool _createDragFieldLayout;

		// Token: 0x040011F1 RID: 4593
		private global::System.Windows.Threading.DispatcherOperation _bumpLayoutItemOp;

		// Token: 0x040011F2 RID: 4594
		private bool _hasBeenInitializedAfterDataSourceChange;

		// Token: 0x040011F3 RID: 4595
		private global::System.Windows.Threading.DispatcherOperation _bumpRecordIndentVersionPending;

		// Token: 0x040011F4 RID: 4596
		private global::System.Windows.Threading.DispatcherOperation _bumpRecordNumberSizeVersionPending;

		// Token: 0x040011F5 RID: 4597
		private global::Infragistics.Windows.DataPresenter.AutoFitState? _autoFitState;

		// Token: 0x040011F6 RID: 4598
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo _autoSizeInfo;

		// Token: 0x040011F7 RID: 4599
		private int _maxRecordManagerDepth;

		// Token: 0x040011F8 RID: 4600
		private bool _fieldLayoutInitializedEventRaised;

		// Token: 0x040011F9 RID: 4601
		private global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateStylesAsyncInfo _pendingInvalidateGeneratedStyles;

		// Token: 0x040011FA RID: 4602
		private bool? _hasStarFieldsX = null;

		// Token: 0x040011FB RID: 4603
		private bool? _hasStarFieldsY = null;

		// Token: 0x040011FC RID: 4604
		private global::Infragistics.Windows.DataPresenter.CellPresentation? _cachedCellPresentation;

		// Token: 0x040011FD RID: 4605
		private bool? _cachedIsEmptyCellCollapsingSupportedByView;

		// Token: 0x040011FE RID: 4606
		private global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder? _cachedChildRecordsDisplayOrderResolved;

		// Token: 0x040011FF RID: 4607
		private global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo? _cachedSupportDataErrorInfoResolvedDefault;

		// Token: 0x04001200 RID: 4608
		private bool _preventBumpLayoutManagerVersionRequired;

		// Token: 0x04001201 RID: 4609
		private bool? _cachedIsHorizontal = null;

		// Token: 0x04001202 RID: 4610
		private global::System.WeakReference _lastSelectableItemLabel;

		// Token: 0x04001203 RID: 4611
		private global::Infragistics.Windows.DataPresenter.SortEvaluationMode? _cachedSortEvaluationModeResolved;

		// Token: 0x04001204 RID: 4612
		private global::Infragistics.Windows.DataPresenter.FilterEvaluationMode? _cachedFilterEvaluationModeResolved;

		// Token: 0x04001205 RID: 4613
		private global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode? _cachedGroupByEvaluationModeResolved;

		// Token: 0x04001206 RID: 4614
		private global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode? _cachedSummaryEvaluationModeResolved;

		// Token: 0x04001207 RID: 4615
		internal bool? _hasUnboundFieldsWithoutBindings;

		// Token: 0x04001208 RID: 4616
		private bool _isUnboundFieldTranitionPending;

		// Token: 0x04001209 RID: 4617
		private global::Infragistics.Windows.DataPresenter.Field _treeField;

		// Token: 0x0400120A RID: 4618
		private bool _areTreeFieldMappingsDirty;

		// Token: 0x0400120B RID: 4619
		private global::Infragistics.Windows.DataPresenter.FieldLayout _alignmentFieldLayout;

		// Token: 0x0400120C RID: 4620
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field> _fieldMap;

		// Token: 0x0400120D RID: 4621
		private global::Infragistics.Windows.DataPresenter.PlaceholderField[] _placeholderFields;

		// Token: 0x0400120E RID: 4622
		private int _placeholderFieldsVersion;

		// Token: 0x0400120F RID: 4623
		private bool _isVerifyingTreeMappings;

		// Token: 0x04001210 RID: 4624
		private global::Infragistics.Windows.Internal.PropertyValueTracker _alignmentLayoutFilterVersionTracker;

		// Token: 0x04001211 RID: 4625
		private bool _areFiltersSynchronized;

		// Token: 0x04001212 RID: 4626
		private global::System.Windows.Threading.DispatcherOperation _sortOperationVersionPending;

		// Token: 0x04001213 RID: 4627
		private global::System.Windows.Threading.DispatcherOperation _fieldCollectionChangePending;

		// Token: 0x04001214 RID: 4628
		internal readonly bool IsAutoCreated;

		// Token: 0x04001215 RID: 4629
		public static readonly global::System.Windows.DependencyProperty CalculationReferenceIdProperty = global::System.Windows.DependencyProperty.Register("CalculationReferenceId", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnCalculationReferenceIdChanged)));

		// Token: 0x04001216 RID: 4630
		private string _calculationRefernceId;

		// Token: 0x04001217 RID: 4631
		private static readonly global::System.Windows.DependencyPropertyKey CellPresentationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CellPresentation", typeof(global::Infragistics.Windows.DataPresenter.CellPresentation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellPresentation.CardView));

		// Token: 0x04001218 RID: 4632
		public static readonly global::System.Windows.DependencyProperty CellPresentationProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.CellPresentationPropertyKey.DependencyProperty;

		// Token: 0x04001219 RID: 4633
		public static readonly global::System.Windows.DependencyProperty DataContextProperty;

		// Token: 0x0400121A RID: 4634
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty = global::System.Windows.DependencyProperty.Register("Description", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.CoerceDescription)));

		// Token: 0x0400121B RID: 4635
		public static readonly global::System.Windows.DependencyProperty FieldSettingsProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty;

		// Token: 0x0400121C RID: 4636
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparateHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSeparateHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400121D RID: 4637
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.HasSeparateHeaderPropertyKey.DependencyProperty;

		// Token: 0x0400121E RID: 4638
		private bool _cachedHasSeparateHeader;

		// Token: 0x0400121F RID: 4639
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04001220 RID: 4640
		public static readonly global::System.Windows.DependencyProperty KeyMatchingEnforcedProperty = global::System.Windows.DependencyProperty.Register("KeyMatchingEnforced", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnKeyMatchingEnforcedChanged)));

		// Token: 0x04001221 RID: 4641
		public static readonly global::System.Windows.DependencyProperty ParentFieldLayoutKeyProperty = global::System.Windows.DependencyProperty.Register("ParentFieldLayoutKey", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnParentFieldLayoutKeyChanged)));

		// Token: 0x04001222 RID: 4642
		public static readonly global::System.Windows.DependencyProperty ParentFieldNameProperty = global::System.Windows.DependencyProperty.Register("ParentFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnParentFieldNameChanged)));

		// Token: 0x04001223 RID: 4643
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionMaskProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionMask", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001224 RID: 4644
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionMaskInGroupByProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionMaskInGroupBy", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001225 RID: 4645
		public static readonly global::System.Windows.DependencyProperty TagProperty = global::System.Windows.FrameworkElement.TagProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayout));

		// Token: 0x04001226 RID: 4646
		public static readonly global::System.Windows.DependencyProperty ToolTipProperty = global::System.Windows.DependencyProperty.Register("ToolTip", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001227 RID: 4647
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.ColumnDefinition g_fallbackColumnDefinition = null;

		// Token: 0x04001228 RID: 4648
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.ColumnDefinition g_fallbackColumnDefinitionAutoFit = null;

		// Token: 0x04001229 RID: 4649
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.RowDefinition g_fallbackRowDefinition = null;

		// Token: 0x0400122A RID: 4650
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.RowDefinition g_fallbackRowDefinitionAutoFit = null;

		// Token: 0x0400122B RID: 4651
		private int _cachedGridColumnWidthVersion;

		// Token: 0x0400122C RID: 4652
		internal static readonly global::System.Windows.DependencyProperty GridColumnWidthVersionProperty = global::System.Windows.DependencyProperty.Register("GridColumnWidthVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnGridColumnWidthVersionChanged)));

		// Token: 0x0400122D RID: 4653
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400122E RID: 4654
		internal static readonly global::System.Windows.DependencyProperty IsOverNearSplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverNearSplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400122F RID: 4655
		internal static readonly global::System.Windows.DependencyProperty IsOverFarSplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverFarSplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001230 RID: 4656
		private static readonly global::System.Windows.DependencyPropertyKey RecordSelectorNumberSizeVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordSelectorNumberSizeVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04001231 RID: 4657
		internal static readonly global::System.Windows.DependencyProperty RecordSelectorNumberSizeVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.RecordSelectorNumberSizeVersionPropertyKey.DependencyProperty;

		// Token: 0x04001232 RID: 4658
		internal static readonly global::System.Windows.DependencyProperty SortOperationVersionProperty = global::System.Windows.DependencyProperty.Register("SortOperationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04001233 RID: 4659
		internal static readonly global::System.Windows.DependencyProperty SpecialRecordsVersionProperty = global::System.Windows.DependencyProperty.Register("SpecialRecordsVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnSpecialRecordsVersionChanged)));

		// Token: 0x04001234 RID: 4660
		internal static readonly global::System.Windows.DependencyProperty TemplateVersionProperty = global::System.Windows.DependencyProperty.Register("TemplateVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnTemplateVersion)));

		// Token: 0x04001235 RID: 4661
		private int _templateVersion;

		// Token: 0x020002FD RID: 765
		internal class LayoutPropertyDescriptorProvider
		{
			// Token: 0x060024CF RID: 9423 RVA: 0x000A1B46 File Offset: 0x0009FD46
			internal LayoutPropertyDescriptorProvider(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
			{
				this._fieldLayout = fieldLayout;
				this._provider = provider;
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000A1B5C File Offset: 0x0009FD5C
			internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
			{
				get
				{
					return this._fieldLayout;
				}
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x060024D1 RID: 9425 RVA: 0x000A1B64 File Offset: 0x0009FD64
			internal global::Infragistics.Windows.Internal.PropertyDescriptorProvider Provider
			{
				get
				{
					return this._provider;
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000A1B6C File Offset: 0x0009FD6C
			private global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[] FieldDescriptors
			{
				get
				{
					this.VerifyFieldDescriptors();
					return this._fieldDescriptors;
				}
			}

			// Token: 0x060024D3 RID: 9427 RVA: 0x000A1B7A File Offset: 0x0009FD7A
			internal void Dirty()
			{
				this._fieldDescriptorVersion--;
			}

			// Token: 0x060024D4 RID: 9428 RVA: 0x000A1B8C File Offset: 0x0009FD8C
			internal global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor GetFieldDescriptor(global::Infragistics.Windows.DataPresenter.Field field)
			{
				int index = field.Index;
				if (index < 0 || field.Owner != this._fieldLayout)
				{
					return null;
				}
				return this.FieldDescriptors[index];
			}

			// Token: 0x060024D5 RID: 9429 RVA: 0x000A1BBC File Offset: 0x0009FDBC
			internal bool HasPropertyDescriptorFor(global::Infragistics.Windows.DataPresenter.Field field)
			{
				this.VerifyFieldDescriptors();
				int index = field.Index;
				return this._unboundFieldsWithPropertyDescriptor != null && index >= 0 && index < this._unboundFieldsWithPropertyDescriptor.Length && null != this._unboundFieldsWithPropertyDescriptor[index];
			}

			// Token: 0x060024D6 RID: 9430 RVA: 0x000A1C00 File Offset: 0x0009FE00
			internal static bool HasPropertyDescriptorFor(global::Infragistics.Windows.DataPresenter.UnboundCell cell)
			{
				global::Infragistics.Windows.DataPresenter.Field field = cell.Field;
				global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = (record != null) ? record.PropertyDescriptorProvider : null;
				return layoutPropertyDescriptorProvider != null && layoutPropertyDescriptorProvider.HasPropertyDescriptorFor(field);
			}

			// Token: 0x060024D7 RID: 9431 RVA: 0x000A1C34 File Offset: 0x0009FE34
			internal static global::Infragistics.Windows.DataPresenter.Field GetUnboundFieldWithPropertyDescriptor(global::Infragistics.Windows.DataPresenter.DataRecord record, string propertyDescriptorName)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = record.PropertyDescriptorProvider;
				if (propertyDescriptorProvider != null)
				{
					propertyDescriptorProvider.VerifyFieldDescriptors();
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> unboundFieldsWithPropertyDescriptorMap = propertyDescriptorProvider._unboundFieldsWithPropertyDescriptorMap;
					global::Infragistics.Windows.DataPresenter.Field result;
					if (unboundFieldsWithPropertyDescriptorMap != null && unboundFieldsWithPropertyDescriptorMap.TryGetValue(propertyDescriptorName, out result))
					{
						return result;
					}
				}
				return null;
			}

			// Token: 0x060024D8 RID: 9432 RVA: 0x000A1C6C File Offset: 0x0009FE6C
			internal static bool HasUnboundFieldWithPropertyDescriptor(global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = record.PropertyDescriptorProvider;
				if (propertyDescriptorProvider != null)
				{
					propertyDescriptorProvider.VerifyFieldDescriptors();
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> unboundFieldsWithPropertyDescriptorMap = propertyDescriptorProvider._unboundFieldsWithPropertyDescriptorMap;
					return unboundFieldsWithPropertyDescriptorMap != null && unboundFieldsWithPropertyDescriptorMap.Count > 0;
				}
				return false;
			}

			// Token: 0x060024D9 RID: 9433 RVA: 0x000A1CA0 File Offset: 0x0009FEA0
			internal void VerifyFieldDescriptors()
			{
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._fieldLayout.Fields;
				if (this._fieldDescriptors != null && this._fieldDescriptorVersion == fields.Version)
				{
					return;
				}
				this._fieldDescriptorVersion = fields.Version;
				int count = fields.Count;
				global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[count];
				((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Field>)fields).CopyTo(array, 0);
				global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[] fieldDescriptors = this._fieldDescriptors;
				this._fieldDescriptors = new global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[count];
				bool flag = false;
				global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptorCollection = null;
				try
				{
					propertyDescriptorCollection = this._provider.GetProperties();
				}
				catch (global::System.Exception)
				{
					propertyDescriptorCollection = new global::System.ComponentModel.PropertyDescriptorCollection(null);
				}
				int count2 = propertyDescriptorCollection.Count;
				for (int i = 0; i < count2; i++)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
					global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor;
					if (fieldDescriptors != null && fieldDescriptors.Length > i)
					{
						fieldDescriptor = fieldDescriptors[i];
					}
					else
					{
						fieldDescriptor = null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor2;
					global::Infragistics.Windows.DataPresenter.Field field;
					if (fieldDescriptor != null && fieldDescriptor.PropertyDescriptor == propertyDescriptor && fieldDescriptor.Field != null && fieldDescriptor.Field.Index >= 0)
					{
						fieldDescriptor2 = fieldDescriptors[i];
						field = fieldDescriptor2.Field;
						array[field.Index] = null;
					}
					else
					{
						fieldDescriptor2 = null;
						field = null;
						for (int j = 0; j < count; j++)
						{
							global::Infragistics.Windows.DataPresenter.Field field2 = array[j];
							if (field2 != null && field2.DoesPropertyMatch(propertyDescriptor))
							{
								field = field2;
								array[j] = null;
								break;
							}
						}
					}
					if (fieldDescriptor2 == null && field != null)
					{
						fieldDescriptor2 = new global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor(field, propertyDescriptor, this._provider);
						if (!this._fieldLayout.AutoGenerateFieldsResolved && this._fieldLayout._fieldLayoutInitializedEventRaised && field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && !field.IsPropertyDescriptorInitialized)
						{
							field.DataType = propertyDescriptor.PropertyType;
							field.InitializePropertyDescriptor(propertyDescriptor, true);
							flag = true;
						}
						field.InitializeDefaultLabel(this._fieldLayout.GetLabelFromPropertyDescriptor(propertyDescriptor, this.Provider.Source));
					}
					if (fieldDescriptor2 != null)
					{
						this._fieldDescriptors[field.Index] = fieldDescriptor2;
					}
				}
				this._unboundFieldsWithPropertyDescriptor = null;
				this._unboundFieldsWithPropertyDescriptorMap = null;
				for (int k = 0; k < count; k++)
				{
					global::Infragistics.Windows.DataPresenter.Field field3 = array[k];
					if (field3 != null && field3.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
					{
						global::System.Windows.PropertyPath propertyPath = field3.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty) as global::System.Windows.PropertyPath;
						if (propertyPath != null && field3.AlternateBinding == null)
						{
							string path = propertyPath.Path;
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptorCollection.Find(path, false);
							if (propertyDescriptor != null && (this._unboundFieldsWithPropertyDescriptorMap == null || !this._unboundFieldsWithPropertyDescriptorMap.ContainsKey(path)) && fields.IndexOf(path) < 0)
							{
								if (this._unboundFieldsWithPropertyDescriptorMap == null)
								{
									this._unboundFieldsWithPropertyDescriptor = new string[count];
									this._unboundFieldsWithPropertyDescriptorMap = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>();
								}
								this._unboundFieldsWithPropertyDescriptor[k] = path;
								this._unboundFieldsWithPropertyDescriptorMap[path] = field3;
							}
						}
					}
				}
				if (flag)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._fieldLayout != null) ? this._fieldLayout.DataPresenter : null;
					if (dataPresenterBase != null)
					{
						dataPresenterBase.CustomizationsManager.ApplyCustomizations();
					}
				}
			}

			// Token: 0x04001238 RID: 4664
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x04001239 RID: 4665
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _provider;

			// Token: 0x0400123A RID: 4666
			private global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[] _fieldDescriptors;

			// Token: 0x0400123B RID: 4667
			private int _fieldDescriptorVersion;

			// Token: 0x0400123C RID: 4668
			private string[] _unboundFieldsWithPropertyDescriptor;

			// Token: 0x0400123D RID: 4669
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> _unboundFieldsWithPropertyDescriptorMap;
		}

		// Token: 0x020002FE RID: 766
		internal class FieldDescriptor
		{
			// Token: 0x060024DA RID: 9434 RVA: 0x000A1F80 File Offset: 0x000A0180
			internal FieldDescriptor(global::Infragistics.Windows.DataPresenter.Field field, global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
			{
				this._field = field;
				this._propertyDescriptor = propertyDescriptor;
				global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor dataColumnPropertyDescriptor = this._propertyDescriptor as global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor;
				if (dataColumnPropertyDescriptor != null)
				{
					this._column = dataColumnPropertyDescriptor.Column;
					return;
				}
				global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider dataViewPropertyDescriptorProvider = provider as global::Infragistics.Windows.Internal.DataViewPropertyDescriptorProvider;
				if (dataViewPropertyDescriptorProvider != null && dataViewPropertyDescriptorProvider.View != null && dataViewPropertyDescriptorProvider.View.Table != null)
				{
					global::System.Data.DataColumnCollection columns = dataViewPropertyDescriptorProvider.View.Table.Columns;
					if (columns != null && columns.Contains(propertyDescriptor.Name))
					{
						this._column = columns[propertyDescriptor.Name];
					}
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x060024DB RID: 9435 RVA: 0x000A2010 File Offset: 0x000A0210
			internal global::System.Data.DataColumn DataColumn
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x060024DC RID: 9436 RVA: 0x000A2018 File Offset: 0x000A0218
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x060024DD RID: 9437 RVA: 0x000A2020 File Offset: 0x000A0220
			internal global::System.ComponentModel.PropertyDescriptor PropertyDescriptor
			{
				get
				{
					return this._propertyDescriptor;
				}
			}

			// Token: 0x0400123E RID: 4670
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x0400123F RID: 4671
			private global::System.ComponentModel.PropertyDescriptor _propertyDescriptor;

			// Token: 0x04001240 RID: 4672
			private global::System.Data.DataColumn _column;
		}

		// Token: 0x020002FF RID: 767
		private class LabelComparer : global::System.Collections.Generic.IEqualityComparer<object>
		{
			// Token: 0x060024DE RID: 9438 RVA: 0x000A2028 File Offset: 0x000A0228
			bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
			{
				string text = x as string;
				string text2 = y as string;
				if (text != null)
				{
					return text2 != null && 0 == string.Compare(text, text2, false);
				}
				return x == y;
			}

			// Token: 0x060024DF RID: 9439 RVA: 0x000A205B File Offset: 0x000A025B
			int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
			{
				return obj.GetHashCode();
			}
		}
	}
}
