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
	// Token: 0x020002BE RID: 702
	[global::System.ComponentModel.DefaultProperty("Fields")]
	[global::System.Windows.Markup.ContentProperty("Fields")]
	public class FieldLayout : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x0600200F RID: 8207 RVA: 0x00089460 File Offset: 0x00087660
		public FieldLayout()
		{
			this._fields = new global::Infragistics.Windows.DataPresenter.FieldCollection(this);
			this._fields.CollectionChanged += this.OnFieldCollectionChanged;
			this._autoSizeInfo = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo(this);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000894DC File Offset: 0x000876DC
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
					if (e.NewValue != null)
					{
						((global::Infragistics.Windows.DataPresenter.FieldSettings)e.NewValue).PropertyChanged += this.OnFieldSettingsPropertyChanged;
					}
				}
			}
			base.RaisePropertyChangedEvent(property.Name);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00089600 File Offset: 0x00087800
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0008968C File Offset: 0x0008788C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x000896E0 File Offset: 0x000878E0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool AllowAddNewResolved
		{
			get
			{
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00089764 File Offset: 0x00087964
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x000897D0 File Offset: 0x000879D0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldMoving AllowFieldMovingResolved
		{
			get
			{
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
						allowFieldMoving = global::Infragistics.Windows.DataPresenter.AllowFieldMoving.Yes;
					}
				}
				return allowFieldMoving;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00089820 File Offset: 0x00087A20
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0008986E File Offset: 0x00087A6E
		public bool AutoFitToHeight
		{
			get
			{
				return this.IsAutoFitHeight;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00089876 File Offset: 0x00087A76
		public bool AutoFitToWidth
		{
			get
			{
				return this.IsAutoFitWidth;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00089880 File Offset: 0x00087A80
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x0600201A RID: 8218 RVA: 0x00089914 File Offset: 0x00087B14
		private static void OnCalculationReferenceIdChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			fieldLayout._calculationRefernceId = (e.NewValue as string);
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x0008993A File Offset: 0x00087B3A
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x00089942 File Offset: 0x00087B42
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

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x00089950 File Offset: 0x00087B50
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x00089985 File Offset: 0x00087B85
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder ChildRecordsDisplayOrderResolved
		{
			get
			{
				if (this._cachedChildRecordsDisplayOrderResolved == null)
				{
					this._cachedChildRecordsDisplayOrderResolved = new global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder?(this.GetChildRecordsDisplayOrderResolvedInternal());
				}
				return this._cachedChildRecordsDisplayOrderResolved.Value;
			}
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000899B0 File Offset: 0x00087BB0
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00089A20 File Offset: 0x00087C20
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00089A6D File Offset: 0x00087C6D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._presenter;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00089A78 File Offset: 0x00087C78
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x06002023 RID: 8227 RVA: 0x00089AF0 File Offset: 0x00087CF0
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00089B20 File Offset: 0x00087D20
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00089C75 File Offset: 0x00087E75
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

		// Token: 0x06002026 RID: 8230 RVA: 0x00089C8A File Offset: 0x00087E8A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDescription()
		{
			return this._cachedDescription != null && this._cachedDescription.Length > 0;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00089CA4 File Offset: 0x00087EA4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDescription()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.DescriptionProperty);
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00089CB4 File Offset: 0x00087EB4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x00089D24 File Offset: 0x00087F24
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00089D92 File Offset: 0x00087F92
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.FieldCollection Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00089D9A File Offset: 0x00087F9A
		internal global::Infragistics.Windows.DataPresenter.FieldCollection FieldsIfAllocated
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00089DA2 File Offset: 0x00087FA2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFields()
		{
			return this._fields != null && this._fields.ShouldSerialize();
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00089DBC File Offset: 0x00087FBC
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00089E38 File Offset: 0x00088038
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00089E8A File Offset: 0x0008808A
		public global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettings
		{
			get
			{
				if (this._cachedFieldSettings == null && (this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)))
				{
					this._cachedFieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
					this._cachedFieldSettings.PropertyChanged += this.OnFieldSettingsPropertyChanged;
				}
				return this._cachedFieldSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty, value);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00089E98 File Offset: 0x00088098
		internal global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettingsIfAllocated
		{
			get
			{
				return this._cachedFieldSettings;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00089EA0 File Offset: 0x000880A0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldSettings()
		{
			return this._cachedFieldSettings != null && this._cachedFieldSettings.ShouldSerialize();
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00089EB7 File Offset: 0x000880B7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty);
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x00089EC4 File Offset: 0x000880C4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00089EE0 File Offset: 0x000880E0
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

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00089F30 File Offset: 0x00088130
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00089F80 File Offset: 0x00088180
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00089FD0 File Offset: 0x000881D0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0008A034 File Offset: 0x00088234
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldUIType FixedFieldUITypeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this.GetFixedFieldInfo(true);
				return this.GetFixedFieldUITypeResolved(fixedFieldInfo.HasFixedFields, fixedFieldInfo.HasFixableFields);
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0008A05C File Offset: 0x0008825C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0008A0D4 File Offset: 0x000882D4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0008A130 File Offset: 0x00088330
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0008A18C File Offset: 0x0008838C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0008A1F6 File Offset: 0x000883F6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasFieldSettings
		{
			get
			{
				return this._cachedFieldSettings != null;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0008A204 File Offset: 0x00088404
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasSeparateHeader
		{
			get
			{
				return this._cachedHasSeparateHeader;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0008A20C File Offset: 0x0008840C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasSettings
		{
			get
			{
				return this._settings != null;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0008A21A File Offset: 0x0008841A
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasGroupBySortFields
		{
			get
			{
				return this.HasSortedFields && this.SortedFields.CountOfGroupByFields > 0;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0008A234 File Offset: 0x00088434
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

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0008A24E File Offset: 0x0008844E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0008A268 File Offset: 0x00088468
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x0008A284 File Offset: 0x00088484
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0008A2D8 File Offset: 0x000884D8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0008A34C File Offset: 0x0008854C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode HeaderPrefixAreaDisplayModeResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaDisplayModeProperty, global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.Default, global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.None);
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0008A35C File Offset: 0x0008855C
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0008A3C6 File Offset: 0x000885C6
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HighlightPrimaryFieldResolved
		{
			get
			{
				return this._presenter != null && this._presenter.GetHighlightPrimaryFieldResolved(this);
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008A3DE File Offset: 0x000885DE
		// (set) Token: 0x0600204A RID: 8266 RVA: 0x0008A3FD File Offset: 0x000885FD
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0008A438 File Offset: 0x00088638
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsInitialized
		{
			get
			{
				return this._isInitialized;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0008A440 File Offset: 0x00088640
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x0008A448 File Offset: 0x00088648
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

		// Token: 0x0600204E RID: 8270 RVA: 0x0008A456 File Offset: 0x00088656
		internal void InitializeKey(object value)
		{
			this.Key = value;
			this._keyExplicitlySet = false;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0008A466 File Offset: 0x00088666
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeKey()
		{
			return this._keyExplicitlySet && this._cachedKey != null;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0008A480 File Offset: 0x00088680
		private static void OnKeyMatchingEnforcedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = target as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout != null)
			{
				fieldLayout._keyMatchingEnforced = (bool)e.NewValue;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0008A4A9 File Offset: 0x000886A9
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x0008A4B1 File Offset: 0x000886B1
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0008A4C4 File Offset: 0x000886C4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.LabelLocation LabelLocationResolved
		{
			get
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
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0008A54C File Offset: 0x0008874C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0008A5A4 File Offset: 0x000887A4
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0008A614 File Offset: 0x00088814
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0008A684 File Offset: 0x00088884
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0008A6FC File Offset: 0x000888FC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x06002059 RID: 8281 RVA: 0x0008A794 File Offset: 0x00088994
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0008A7E7 File Offset: 0x000889E7
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0008A7F4 File Offset: 0x000889F4
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

		// Token: 0x0600205C RID: 8284 RVA: 0x0008A804 File Offset: 0x00088A04
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0008A841 File Offset: 0x00088A41
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x0008A853 File Offset: 0x00088A53
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

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0008A864 File Offset: 0x00088A64
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x0008A8E4 File Offset: 0x00088AE4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0008A91E File Offset: 0x00088B1E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0008A93A File Offset: 0x00088B3A
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFiltersIfAllocated
		{
			get
			{
				return this._recordFilters;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0008A942 File Offset: 0x00088B42
		internal bool HasRecordFilters
		{
			get
			{
				return this._recordFilters != null && this._recordFilters.Count > 0;
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0008A95C File Offset: 0x00088B5C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRecordFilters()
		{
			return this._recordFilters != null && this._recordFilters.ShouldSerialize();
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0008A973 File Offset: 0x00088B73
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRecordFilters()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.Clear();
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0008A988 File Offset: 0x00088B88
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0008A9C0 File Offset: 0x00088BC0
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0008AA25 File Offset: 0x00088C25
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int RecordIndentVersion
		{
			get
			{
				return this._indentOffsetVersion;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0008AA30 File Offset: 0x00088C30
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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
				global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo supportDataErrorInfoResolved = this.SupportDataErrorInfoResolved;
				if (global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsOnly == supportDataErrorInfoResolved || global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsAndCells == supportDataErrorInfoResolved)
				{
					double num2 = (this._presenter != null) ? this._presenter.RecordSelectorErrorIconExtent : double.NaN;
					if (double.IsNaN(num2))
					{
						num += 10.0;
					}
					else
					{
						num += num2;
					}
				}
				if (this._presenter != null && !this._presenter.IsReportControl && this.AllowRecordFixingResolved != global::Infragistics.Windows.DataPresenter.AllowRecordFixing.No && this.FixedRecordUITypeResolved == global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Button)
				{
					double num3 = (this._presenter != null) ? this._presenter.RecordSelectorFixButtonExtent : double.NaN;
					if (double.IsNaN(num3))
					{
						num += 12.0;
					}
					else
					{
						num += num3;
					}
				}
				return num;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0008AB68 File Offset: 0x00088D68
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0008ABD0 File Offset: 0x00088DD0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0008AC18 File Offset: 0x00088E18
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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0008AC6C File Offset: 0x00088E6C
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x0008ACE0 File Offset: 0x00088EE0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0008AD08 File Offset: 0x00088F08
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0008AD5C File Offset: 0x00088F5C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0008ADB0 File Offset: 0x00088FB0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0008AE04 File Offset: 0x00089004
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0008AE58 File Offset: 0x00089058
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public global::Infragistics.Windows.DataPresenter.FieldLayoutSettings Settings
		{
			get
			{
				if (this._settings == null && (this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)))
				{
					this._settings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
					this._settings.PropertyChanged += this.OnSettingsPropertyChanged;
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
						this._settings.PropertyChanged += this.OnSettingsPropertyChanged;
					}
					base.RaisePropertyChangedEvent("Settings");
				}
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0008AEBE File Offset: 0x000890BE
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutSettings SettingsIfAllocated
		{
			get
			{
				return this._settings;
			}
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0008AEC6 File Offset: 0x000890C6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSettings()
		{
			return this._settings != null && this._settings.ShouldSerialize();
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0008AEDD File Offset: 0x000890DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSettings()
		{
			this._settings = null;
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0008AEE8 File Offset: 0x000890E8
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

		// Token: 0x06002078 RID: 8312 RVA: 0x0008AF42 File Offset: 0x00089142
		private void OnSortedFieldsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "CountOfGroupByFields")
			{
				this.BumpGroupByVersion();
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0008AF5C File Offset: 0x0008915C
		private void OnSortedFieldsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.BumpSortVersion();
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0008AF64 File Offset: 0x00089164
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

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0008AF80 File Offset: 0x00089180
		internal global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection SummaryDefinitionsIfAllocated
		{
			get
			{
				return this._summaryDefinitions;
			}
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0008AF88 File Offset: 0x00089188
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDefinitions()
		{
			return this._summaryDefinitions != null && this._summaryDefinitions.Count > 0;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0008AFA2 File Offset: 0x000891A2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDefinitions()
		{
			if (this._summaryDefinitions != null)
			{
				this._summaryDefinitions.Clear();
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0008AFB7 File Offset: 0x000891B7
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x0008AFC9 File Offset: 0x000891C9
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

		// Token: 0x06002080 RID: 8320 RVA: 0x0008AFD7 File Offset: 0x000891D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDescriptionMask()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty, this);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0008AFE4 File Offset: 0x000891E4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDescriptionMask()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskProperty);
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0008AFF1 File Offset: 0x000891F1
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x0008B003 File Offset: 0x00089203
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

		// Token: 0x06002084 RID: 8324 RVA: 0x0008B011 File Offset: 0x00089211
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryDescriptionMaskInGroupBy()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty, this);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0008B01E File Offset: 0x0008921E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryDescriptionMaskInGroupBy()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayout.SummaryDescriptionMaskInGroupByProperty);
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x0008B02B File Offset: 0x0008922B
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x0008B038 File Offset: 0x00089238
		[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.ShareInstance)]
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
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

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0008B046 File Offset: 0x00089246
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x0008B053 File Offset: 0x00089253
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0008B061 File Offset: 0x00089261
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int TotalColumnsGenerated
		{
			get
			{
				return this._totalColumnsGenerated;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0008B069 File Offset: 0x00089269
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public int TotalRowsGenerated
		{
			get
			{
				return this._totalRowsGenerated;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0008B074 File Offset: 0x00089274
		internal global::Infragistics.Windows.DataPresenter.AllowClipboardOperations AllowClipboardOperationsResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AllowClipboardOperationsProperty, null, new global::Infragistics.Windows.DataPresenter.AllowClipboardOperations?(global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.None)).Value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0008B0A4 File Offset: 0x000892A4
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0008B110 File Offset: 0x00089310
		internal bool AreFieldsInitialized
		{
			get
			{
				return this._areFieldsInitialized;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0008B118 File Offset: 0x00089318
		internal global::Infragistics.Windows.DataPresenter.AutoArrangeCells AutoArrangeCellsResolved
		{
			get
			{
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x0008B191 File Offset: 0x00089391
		internal global::Infragistics.Windows.DataPresenter.AutoFitMode AutoFitModeResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AutoFitMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoFitModeProperty, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default);
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0008B1A0 File Offset: 0x000893A0
		internal global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo AutoSizeInfo
		{
			get
			{
				return this._autoSizeInfo;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0008B1A8 File Offset: 0x000893A8
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0008B1F5 File Offset: 0x000893F5
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager CellLayoutManager
		{
			get
			{
				this.VerifyLayoutManagers();
				return this._cellLayoutManager;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0008B204 File Offset: 0x00089404
		internal bool CopyFieldLabelsToClipboardResolved
		{
			get
			{
				return this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.CopyFieldLabelsToClipboardProperty, null, new bool?(false)).Value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0008B233 File Offset: 0x00089433
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0008B23B File Offset: 0x0008943B
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0008B244 File Offset: 0x00089444
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

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0008B294 File Offset: 0x00089494
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

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0008B308 File Offset: 0x00089508
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

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x0008B37C File Offset: 0x0008957C
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0008B400 File Offset: 0x00089600
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0008B474 File Offset: 0x00089674
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0008B4E8 File Offset: 0x000896E8
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0008B569 File Offset: 0x00089769
		internal bool FieldLayoutInitializedEventRaised
		{
			get
			{
				return this._fieldLayoutInitializedEventRaised;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0008B571 File Offset: 0x00089771
		internal global::Infragistics.Windows.DataPresenter.FilterEvaluationMode FilterEvaluationModeResolved
		{
			get
			{
				if (this._cachedFilterEvaluationModeResolved == null)
				{
					this._cachedFilterEvaluationModeResolved = new global::Infragistics.Windows.DataPresenter.FilterEvaluationMode?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FilterEvaluationMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.FilterEvaluationModeProperty, global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Default, global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto));
				}
				return this._cachedFilterEvaluationModeResolved.Value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0008B5A3 File Offset: 0x000897A3
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0008B5AB File Offset: 0x000897AB
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

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0008B5B4 File Offset: 0x000897B4
		internal int FixedFieldVersion
		{
			get
			{
				return this._fixedFieldVersion + this.TemplateVersion;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0008B5C4 File Offset: 0x000897C4
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
				return global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.CheckOnExpand;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0008B616 File Offset: 0x00089816
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0008B648 File Offset: 0x00089848
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0008B692 File Offset: 0x00089892
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int GroupByVersion
		{
			get
			{
				return this._groupByVersion;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0008B69A File Offset: 0x0008989A
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0008B6C6 File Offset: 0x000898C6
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

		// Token: 0x060020A9 RID: 8361 RVA: 0x0008B6F2 File Offset: 0x000898F2
		private static void OnGridColumnWidthVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.FieldLayout)d)._cachedGridColumnWidthVersion = (int)e.NewValue;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0008B70B File Offset: 0x0008990B
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x0008B713 File Offset: 0x00089913
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0008B726 File Offset: 0x00089926
		internal bool HasBeenInitializedAfterDataSourceChange
		{
			get
			{
				return this._hasBeenInitializedAfterDataSourceChange;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0008B730 File Offset: 0x00089930
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0008B78C File Offset: 0x0008998C
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0008B79E File Offset: 0x0008999E
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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0008B7B1 File Offset: 0x000899B1
		internal bool IsAutoFit
		{
			get
			{
				return this.IsAutoFitWidth || this.IsAutoFitHeight;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0008B7C3 File Offset: 0x000899C3
		internal bool IsAutoFitWidth
		{
			get
			{
				this.VerifyAutoFitSettings(false);
				return (byte)(this._autoFitState.Value & global::Infragistics.Windows.DataPresenter.AutoFitState.Width) != 0;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0008B7E0 File Offset: 0x000899E0
		internal bool IsAutoFitHeight
		{
			get
			{
				this.VerifyAutoFitSettings(false);
				return (byte)(this._autoFitState.Value & global::Infragistics.Windows.DataPresenter.AutoFitState.Height) != 0;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0008B7FD File Offset: 0x000899FD
		internal bool IsGridBagAutoFitWidth
		{
			get
			{
				return this.IsAutoFitWidth && this.AutoFitModeResolved != global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0008B815 File Offset: 0x00089A15
		internal bool IsGridBagAutoFitHeight
		{
			get
			{
				return this.IsAutoFitHeight && this.AutoFitModeResolved != global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0008B830 File Offset: 0x00089A30
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0008B85C File Offset: 0x00089A5C
		internal bool IsFieldChooserUIEnabled
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				return global::Infragistics.Windows.DataPresenter.HeaderPrefixAreaDisplayMode.FieldChooserButton == this.HeaderPrefixAreaDisplayModeResolved || (dataPresenter != null && dataPresenter.HasRegisteredFieldChoosers());
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0008B888 File Offset: 0x00089A88
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

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0008B8C4 File Offset: 0x00089AC4
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

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0008B92A File Offset: 0x00089B2A
		internal bool IsInFieldInitialization
		{
			get
			{
				return this._isInFieldInitialization;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0008B932 File Offset: 0x00089B32
		internal bool IsInitialRecordLoaded
		{
			get
			{
				return this._initialRecordLoaded;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0008B93A File Offset: 0x00089B3A
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0008B94C File Offset: 0x00089B4C
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0008B95F File Offset: 0x00089B5F
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0008B971 File Offset: 0x00089B71
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0008B984 File Offset: 0x00089B84
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0008B9E0 File Offset: 0x00089BE0
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager LabelLayoutManager
		{
			get
			{
				this.VerifyLayoutManagers();
				return this._labelLayoutManager;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0008B9EE File Offset: 0x00089BEE
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0008BA00 File Offset: 0x00089C00
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0008BA19 File Offset: 0x00089C19
		internal int LayoutItemVersion
		{
			get
			{
				return this._layoutItemVersion;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0008BA21 File Offset: 0x00089C21
		internal int LayoutManagerVersion
		{
			get
			{
				return this._layoutManagerVersion + this.TemplateVersion;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0008BA30 File Offset: 0x00089C30
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0008BA38 File Offset: 0x00089C38
		internal int MaxRecordManagerDepth
		{
			get
			{
				return this._maxRecordManagerDepth;
			}
			set
			{
				if (value > this._maxRecordManagerDepth)
				{
					this._maxRecordManagerDepth = value;
					this.AutoSizeInfo.OnMaxDepthChanged();
				}
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0008BA58 File Offset: 0x00089C58
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

		// Token: 0x060020C8 RID: 8392 RVA: 0x0008BA7C File Offset: 0x00089C7C
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

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0008BAC2 File Offset: 0x00089CC2
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0008BACA File Offset: 0x00089CCA
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

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0008BAD3 File Offset: 0x00089CD3
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0008BB0C File Offset: 0x00089D0C
		private global::Infragistics.Windows.DataPresenter.RecordFilterScope InternalRecordFilterScopeResolvedDefault
		{
			get
			{
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0008BB5C File Offset: 0x00089D5C
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0008BBDC File Offset: 0x00089DDC
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0008BBFB File Offset: 0x00089DFB
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0008BC2D File Offset: 0x00089E2D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int SortVersion
		{
			get
			{
				return this._sortVersion;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0008BC35 File Offset: 0x00089E35
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x0008BC47 File Offset: 0x00089E47
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0008BC5A File Offset: 0x00089E5A
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x0008BC62 File Offset: 0x00089E62
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

		// Token: 0x060020D5 RID: 8405 RVA: 0x0008BC78 File Offset: 0x00089E78
		private static void OnSpecialRecordsVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (global::Infragistics.Windows.DataPresenter.FieldLayout)dependencyObject;
			fieldLayout._cachedSpecialRecordsVersion = (int)e.NewValue;
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0008BCA0 File Offset: 0x00089EA0
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
				return global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0008BD02 File Offset: 0x00089F02
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0008BD34 File Offset: 0x00089F34
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0008BD4E File Offset: 0x00089F4E
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0008BD80 File Offset: 0x00089F80
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator StyleGenerator
		{
			get
			{
				return this._styleGenerator;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x0008BD88 File Offset: 0x00089F88
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

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0008BDA4 File Offset: 0x00089FA4
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0008BE0B File Offset: 0x0008A00B
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

		// Token: 0x060020DE RID: 8414 RVA: 0x0008BE28 File Offset: 0x0008A028
		private static void OnTemplateVersion(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (global::Infragistics.Windows.DataPresenter.FieldLayout)d;
			fieldLayout._templateVersion = (int)e.NewValue;
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x0008BE4E File Offset: 0x0008A04E
		internal int TemplateVersion
		{
			get
			{
				return this._templateVersion;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0008BE56 File Offset: 0x0008A056
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

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x0008BE7F File Offset: 0x0008A07F
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0008BE9F File Offset: 0x0008A09F
		internal bool WrapsEnumerableObject
		{
			get
			{
				return this._wrapsEnumerableObject;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0008BEA7 File Offset: 0x0008A0A7
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

		// Token: 0x060020E4 RID: 8420 RVA: 0x0008BEC3 File Offset: 0x0008A0C3
		internal void BumpRecordFilterVersion()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.BumpVersion();
			}
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0008BED8 File Offset: 0x0008A0D8
		internal void BumpGridColumnWidthVersion()
		{
			this.GridColumnWidthVersion++;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0008BEE8 File Offset: 0x0008A0E8
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x0008BF35 File Offset: 0x0008A135
		internal void BumpRecordIndentVersion()
		{
			this._bumpRecordIndentVersionPending = null;
			this._indentOffsetVersion++;
			base.RaisePropertyChangedEvent("RecordIndentVersion");
			this.BumpGridColumnWidthVersion();
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0008BF60 File Offset: 0x0008A160
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

		// Token: 0x060020E9 RID: 8425 RVA: 0x0008BFB5 File Offset: 0x0008A1B5
		internal void BumpLayoutItemVersion()
		{
			this.BumpLayoutItemVersion(true);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
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

		// Token: 0x060020EB RID: 8427 RVA: 0x0008C01F File Offset: 0x0008A21F
		internal void BumpLayoutItemVersionAsync()
		{
			if (this._bumpLayoutItemOp == null)
			{
				this._bumpLayoutItemOp = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpLayoutItemVersion));
			}
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0008C048 File Offset: 0x0008A248
		internal void BumpLayoutManagerVersion()
		{
			if (this.PreventBumpLayoutManagerVersionRequired)
			{
				return;
			}
			this._layoutManagerVersion++;
			this.BumpLayoutItemVersion();
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0008C068 File Offset: 0x0008A268
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

		// Token: 0x060020EE RID: 8430 RVA: 0x0008C0B5 File Offset: 0x0008A2B5
		internal void BumpSortOperationVersion()
		{
			this.SortOperationVersion++;
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0008C0C5 File Offset: 0x0008A2C5
		internal void BumpSpecialRecordsVersion()
		{
			this.SpecialRecordsVersion++;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0008C0D5 File Offset: 0x0008A2D5
		internal void BumpTemplateVersion(bool releaseTemplateCache)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty, this._templateVersion + 1);
			this.TemplateDataRecordCache.BumpCacheVersion(releaseTemplateCache);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0008C0FC File Offset: 0x0008A2FC
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

		// Token: 0x060020F2 RID: 8434 RVA: 0x0008C198 File Offset: 0x0008A398
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
			if ((global::Infragistics.Windows.DataPresenter.CustomizationType.FieldPosition & customizations) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				if (fields != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field field2 in fields)
					{
						field2.FixedLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
						field2.IgnoreFieldVisibilityOverrides = false;
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
				this.PostDelayedInvalidation();
			}
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
		internal void DirtyFixedState()
		{
			this._fixedFieldVersion++;
			this.BumpLayoutManagerVersion();
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0008C2E6 File Offset: 0x0008A4E6
		internal bool DoesParentFieldMatch(global::Infragistics.Windows.DataPresenter.Field fieldToTest)
		{
			if (fieldToTest != null)
			{
				return fieldToTest.Owner != this && fieldToTest == this.ParentField;
			}
			return this._parentFieldLayout == null && this.ParentFieldLayoutKey == null;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0008C313 File Offset: 0x0008A513
		internal bool DoesParentFieldLayoutMatch(global::Infragistics.Windows.DataPresenter.FieldLayout layoutToTest)
		{
			if (layoutToTest != null)
			{
				return layoutToTest != this && layoutToTest == this.ParentFieldLayout;
			}
			return this._parentFieldLayout == null && this.ParentFieldLayoutKey == null;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0008C33C File Offset: 0x0008A53C
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

		// Token: 0x060020F7 RID: 8439 RVA: 0x0008C380 File Offset: 0x0008A580
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

		// Token: 0x060020F8 RID: 8440 RVA: 0x0008C3F3 File Offset: 0x0008A5F3
		internal void EnsureStyleGeneratorInitialized()
		{
			if (this.StyleGenerator == null)
			{
				this.Initialize(this.DataPresenter.CurrentViewInternal.GetFieldLayoutTemplateGenerator(this));
			}
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0008C414 File Offset: 0x0008A614
		internal global::System.Windows.Controls.ColumnDefinition[] GetCellAreaColumnDefinitions()
		{
			if (this._styleGenerator == null)
			{
				return new global::System.Windows.Controls.ColumnDefinition[0];
			}
			return this._styleGenerator.GetCellAreaColumnDefinitions();
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0008C430 File Offset: 0x0008A630
		internal global::System.Windows.Controls.RowDefinition[] GetCellAreaRowDefinitions()
		{
			if (this._styleGenerator == null)
			{
				return new global::System.Windows.Controls.RowDefinition[0];
			}
			return this._styleGenerator.GetCellAreaRowDefinitions();
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0008C44C File Offset: 0x0008A64C
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

		// Token: 0x060020FC RID: 8444 RVA: 0x0008C494 File Offset: 0x0008A694
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

		// Token: 0x060020FD RID: 8445 RVA: 0x0008C548 File Offset: 0x0008A748
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

		// Token: 0x060020FE RID: 8446 RVA: 0x0008C5BC File Offset: 0x0008A7BC
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

		// Token: 0x060020FF RID: 8447 RVA: 0x0008C63C File Offset: 0x0008A83C
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

		// Token: 0x06002100 RID: 8448 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
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

		// Token: 0x06002101 RID: 8449 RVA: 0x0008C768 File Offset: 0x0008A968
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

		// Token: 0x06002102 RID: 8450 RVA: 0x0008C7BC File Offset: 0x0008A9BC
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

		// Token: 0x06002103 RID: 8451 RVA: 0x0008C820 File Offset: 0x0008AA20
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

		// Token: 0x06002104 RID: 8452 RVA: 0x0008C8D0 File Offset: 0x0008AAD0
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

		// Token: 0x06002105 RID: 8453 RVA: 0x0008C944 File Offset: 0x0008AB44
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

		// Token: 0x06002106 RID: 8454 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
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

		// Token: 0x06002107 RID: 8455 RVA: 0x0008CA3C File Offset: 0x0008AC3C
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

		// Token: 0x06002108 RID: 8456 RVA: 0x0008CA89 File Offset: 0x0008AC89
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

		// Token: 0x06002109 RID: 8457 RVA: 0x0008CAB8 File Offset: 0x0008ACB8
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

		// Token: 0x0600210A RID: 8458 RVA: 0x0008CAFC File Offset: 0x0008ACFC
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

		// Token: 0x0600210B RID: 8459 RVA: 0x0008CB68 File Offset: 0x0008AD68
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

		// Token: 0x0600210C RID: 8460 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
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

		// Token: 0x0600210D RID: 8461 RVA: 0x0008CC5C File Offset: 0x0008AE5C
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider GetProvider(object listObject, global::System.Collections.IEnumerable containingCollection)
		{
			global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider = this._presenter.FieldLayouts.GetPropertyDescriptorProvider(listObject, containingCollection);
			if (propertyDescriptorProvider == null)
			{
				return null;
			}
			return this.GetProvider(propertyDescriptorProvider);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0008CC88 File Offset: 0x0008AE88
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

		// Token: 0x0600210F RID: 8463 RVA: 0x0008CD24 File Offset: 0x0008AF24
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

		// Token: 0x06002110 RID: 8464 RVA: 0x0008CDA7 File Offset: 0x0008AFA7
		private global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategyHelper(global::Infragistics.Windows.Controls.SelectionType selectionType, global::Infragistics.Windows.Selection.SelectionStrategyBase oldStrategy)
		{
			return global::Infragistics.Windows.Selection.SelectionStrategyBase.GetSelectionStrategy(selectionType, this.DataPresenter, oldStrategy);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0008CDB8 File Offset: 0x0008AFB8
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

		// Token: 0x06002112 RID: 8466 RVA: 0x0008CE16 File Offset: 0x0008B016
		internal void InitializeFields(object listObject, global::System.Collections.IEnumerable containingCollection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection)
		{
			this.InitializeFields(listObject, containingCollection, parentRecordCollection, null);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0008CE24 File Offset: 0x0008B024
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
						if (field.IsUnbound)
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
						if (!field3.IsUnbound && !hashSet.Exists(field3))
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
				if (this._recordFilters != null)
				{
					this._recordFilters.OnFieldLayoutInitialized();
				}
				this._dataColumnMap = null;
				this._isInFieldInitialization = false;
			}
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0008D294 File Offset: 0x0008B494
		private void InitializeFieldHelper(global::System.ComponentModel.PropertyDescriptor pd, object pdsource, global::Infragistics.Windows.DataPresenter.Field[] existingFields, bool autoGenerate, ref int totalFieldsGenerated)
		{
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
					field.InitializePropertyDescriptor(pd, false);
					field.InitializeDefaultLabel(labelFromPropertyDescriptor);
					existingFields[i] = null;
					return;
				}
			}
			if (autoGenerate)
			{
				global::Infragistics.Windows.DataPresenter.Field field = new global::Infragistics.Windows.DataPresenter.Field(propertyType, name, labelFromPropertyDescriptor);
				field.InitializePropertyDescriptor(pd, false);
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

		// Token: 0x06002115 RID: 8469 RVA: 0x0008D34C File Offset: 0x0008B54C
		internal void InitializeOwner(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			if (this._presenter != null && this._presenter != presenter)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_10"));
			}
			this._presenter = presenter;
			this.DirtyFixedState();
			if ((this._presenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._presenter)) && !(base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty) is global::Infragistics.Windows.DataPresenter.FieldSettings))
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.FieldSettingsProperty, this.FieldSettings);
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0008D3C1 File Offset: 0x0008B5C1
		internal void InitializeParentInfo(global::Infragistics.Windows.DataPresenter.FieldLayout parentFieldLayout, global::Infragistics.Windows.DataPresenter.Field parentField)
		{
			this.ParentFieldLayoutKey = parentFieldLayout.Key;
			this.ParentFieldName = ((parentField != null) ? parentField.Name : null);
			this._parentFieldLayout = parentFieldLayout;
			this._parentField = parentField;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0008D3EF File Offset: 0x0008B5EF
		internal void InvalidateGeneratedStyles(bool bumpVersion)
		{
			this.InvalidateGeneratedStyles(bumpVersion, true);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0008D3F9 File Offset: 0x0008B5F9
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates)
		{
			this.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, false);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0008D404 File Offset: 0x0008B604
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool regenerateTemplates, bool bumpSpecialRecords)
		{
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
			if (regenerateTemplates)
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
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0008D4E1 File Offset: 0x0008B6E1
		internal void InvalidateGeneratedStylesAsnyc(bool bumpVersion, bool regenerateTemplates)
		{
			this.InvalidateGeneratedStylesAsnyc(bumpVersion, regenerateTemplates, false);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0008D4EC File Offset: 0x0008B6EC
		internal void InvalidateGeneratedStylesAsnyc(bool bumpVersion, bool regenerateTemplates, bool bumpSpecialRecords)
		{
			global::System.Windows.Threading.Dispatcher dispatcher = base.Dispatcher;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			bool flag = dataPresenter != null && !dataPresenter.IsSynchronousControl;
			if (dispatcher == null || !flag)
			{
				this.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, bumpSpecialRecords);
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

		// Token: 0x0600211C RID: 8476 RVA: 0x0008D5B0 File Offset: 0x0008B7B0
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

		// Token: 0x0600211D RID: 8477 RVA: 0x0008D5F0 File Offset: 0x0008B7F0
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

		// Token: 0x0600211E RID: 8478 RVA: 0x0008D664 File Offset: 0x0008B864
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
					if (!field.IsUnbound)
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

		// Token: 0x0600211F RID: 8479 RVA: 0x0008D7F3 File Offset: 0x0008B9F3
		internal void OnAddedToCollection()
		{
			if (this._templateDataRecordCache != null)
			{
				this._templateDataRecordCache.ReleaseCache();
			}
			this._wasRemovedFromCollection = false;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0008D810 File Offset: 0x0008BA10
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

		// Token: 0x06002121 RID: 8481 RVA: 0x0008D8A8 File Offset: 0x0008BAA8
		internal void OnCurrentViewChanged(bool formatSettingsChanged)
		{
			this._cachedIsEmptyCellCollapsingSupportedByView = null;
			this._cachedCellPresentation = null;
			this._cachedIsHorizontal = null;
			this.DirtyFixedState();
			if (this._fields != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fields)
				{
					field.OnCurrentViewChanged(formatSettingsChanged);
					field.DirtyCellContentAlignmentCache();
				}
			}
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0008D930 File Offset: 0x0008BB30
		internal void OnDataRecordLoaded()
		{
			if (!this._initialRecordLoaded)
			{
				this._initialRecordLoaded = true;
				if (this._presenter != null)
				{
					this._presenter.BumpGroupByAreaStyleVersion();
				}
			}
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0008D954 File Offset: 0x0008BB54
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

		// Token: 0x06002124 RID: 8484 RVA: 0x0008D98B File Offset: 0x0008BB8B
		internal void OnFieldAddedRemovedFromCollection()
		{
			this._areFieldsAutoGenerated = false;
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0008D994 File Offset: 0x0008BB94
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

		// Token: 0x06002126 RID: 8486 RVA: 0x0008DA1C File Offset: 0x0008BC1C
		internal void OnFieldVisibilityChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.InvalidateGeneratedStylesAsnyc(false, false, true);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0008DA27 File Offset: 0x0008BC27
		internal void OnPropertyDescriptorAdded(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorAddedHelper(propertyDescriptor, provider, this.AutoGenerateFieldsResolved, true);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0008DA42 File Offset: 0x0008BC42
		internal void OnPropertyDescriptorChanged(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, false, true);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0008DA58 File Offset: 0x0008BC58
		internal void OnPropertyDescriptorDeleted(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			if (!this.IsProviderCached(provider))
			{
				return;
			}
			this.PropertyDescriptorChangedHelper(propertyDescriptor, provider, true, true);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0008DA70 File Offset: 0x0008BC70
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
				this.PostDelayedInvalidation();
			}
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0008DB6C File Offset: 0x0008BD6C
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

		// Token: 0x0600212C RID: 8492 RVA: 0x0008DBEC File Offset: 0x0008BDEC
		internal static void ProcessFieldLayoutSettingsPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings settings, object settingsOwner, bool firstPassForPresenterFlag, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			bool flag = presenter != null && presenter.IsInitialized;
			string propertyName = e.PropertyName;
			bool flag2 = false;
			bool flag3 = false;
			string key;
			if ((key = propertyName) != null)
			{
				if (global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60020d9-1 == null)
				{
					global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60020d9-1 = new global::System.Collections.Generic.Dictionary<string, int>(32)
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
							"FilterAction",
							16
						},
						{
							"FilterClearButtonLocation",
							17
						},
						{
							"FilterRecordLocation",
							18
						},
						{
							"FilterUIType",
							19
						},
						{
							"RecordFilterScope",
							20
						},
						{
							"ReevaluateFiltersOnDataChange",
							21
						},
						{
							"GroupByExpansionIndicatorVisibility",
							22
						},
						{
							"RecordSelectorLocation",
							23
						},
						{
							"RecordSelectorExtent",
							24
						},
						{
							"ChildRecordsDisplayOrder",
							25
						},
						{
							"SupportDataErrorInfo",
							26
						},
						{
							"LabelLocation",
							27
						},
						{
							"SortEvaluationMode",
							28
						},
						{
							"FilterEvaluationMode",
							29
						},
						{
							"SummaryEvaluationMode",
							30
						},
						{
							"GroupByEvaluationMode",
							31
						}
					};
				}
				int num;
				if (global::<PrivateImplementationDetails>{71941DAA-8CFD-4121-BD7F-0A50EDB9A71E}.$$method0x60020d9-1.TryGetValue(key, out num))
				{
					switch (num)
					{
					case 0:
					case 1:
						goto IL_5BC;
					case 2:
						flag2 = true;
						if (fieldLayout != null && fieldLayout._summaryDefinitions != null)
						{
							fieldLayout._summaryDefinitions.BumpDataVersion();
							goto IL_5BC;
						}
						goto IL_5BC;
					case 3:
					case 4:
						flag2 = true;
						if (fieldLayout != null && fieldLayout._summaryDefinitions != null)
						{
							fieldLayout._summaryDefinitions.BumpSummariesVersion();
							goto IL_5BC;
						}
						goto IL_5BC;
					case 5:
					case 6:
					case 7:
					case 8:
						flag2 = ("SpecialRecordOrder" != propertyName);
						if (fieldLayout == null)
						{
							goto IL_5BC;
						}
						fieldLayout.BumpSpecialRecordsVersion();
						if (presenter != null && propertyName == "AllowAddNew")
						{
							presenter.BumpScrollCountRecalcVersion();
							goto IL_5BC;
						}
						goto IL_5BC;
					case 9:
						if (fieldLayout != null)
						{
							fieldLayout.OnFieldWidthHeightChanged();
							goto IL_5BC;
						}
						goto IL_5BC;
					case 10:
						if (fieldLayout == null)
						{
							goto IL_5BC;
						}
						flag2 = true;
						fieldLayout.DirtyFixedState();
						if (fieldLayout._fields == null)
						{
							goto IL_5BC;
						}
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator = fieldLayout._fields.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.Windows.DataPresenter.Field field = enumerator.Current;
								field.VerifyFixedState();
							}
							goto IL_5BC;
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
							goto IL_5BC;
						}
						goto IL_5BC;
					case 14:
					case 15:
						flag2 = true;
						goto IL_5BC;
					case 16:
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
					{
						flag2 = true;
						if (fieldLayout == null)
						{
							goto IL_5BC;
						}
						fieldLayout._cachedReevaluateFiltersOnDataChange = null;
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
								goto IL_5BC;
							}
							goto IL_49F;
						}
						goto IL_5BC;
					}
					case 22:
					case 23:
					case 24:
						goto IL_49F;
					case 25:
						if (fieldLayout != null)
						{
							fieldLayout.ResetCachedChildRecordsDisplayOrderResolvedValue();
						}
						if (firstPassForPresenterFlag && flag && presenter != null)
						{
							presenter.OnChildRecordsDisplayOrderChanged();
						}
						flag2 = true;
						goto IL_5BC;
					case 26:
						flag3 = true;
						if (fieldLayout != null)
						{
							fieldLayout._cachedSupportDataErrorInfoResolvedDefault = null;
							goto IL_5BC;
						}
						goto IL_5BC;
					case 27:
						flag3 = true;
						if (fieldLayout != null)
						{
							fieldLayout.InvalidateCellContentAlignmentResolved();
							goto IL_5BC;
						}
						goto IL_5BC;
					case 28:
					case 29:
					case 30:
					case 31:
					{
						if (fieldLayout == null)
						{
							goto IL_5BC;
						}
						fieldLayout._cachedSortEvaluationModeResolved = null;
						fieldLayout._cachedFilterEvaluationModeResolved = null;
						fieldLayout._cachedGroupByEvaluationModeResolved = null;
						fieldLayout._cachedSummaryEvaluationModeResolved = null;
						string a;
						if ((a = propertyName) == null)
						{
							goto IL_5BC;
						}
						if (a == "SortEvaluationMode" || a == "GroupByEvaluationMode")
						{
							fieldLayout.BumpSortVersion();
							goto IL_5BC;
						}
						if (a == "FilterEvaluationMode")
						{
							fieldLayout.BumpRecordFilterVersion();
							goto IL_5BC;
						}
						if (!(a == "SummaryEvaluationMode"))
						{
							goto IL_5BC;
						}
						if (fieldLayout.SummaryDefinitionsIfAllocated != null)
						{
							fieldLayout.SummaryDefinitionsIfAllocated.Refresh();
							goto IL_5BC;
						}
						goto IL_5BC;
					}
					default:
						goto IL_5BA;
					}
					flag2 = true;
					if (fieldLayout != null)
					{
						fieldLayout._cachedRecordFiltersLogicalOperatorResolved = null;
						fieldLayout.BumpRecordFilterVersion();
						goto IL_5BC;
					}
					goto IL_5BC;
					IL_49F:
					if (fieldLayout != null)
					{
						fieldLayout.BumpRecordIndentVersionAsync();
					}
					flag3 = true;
					if (propertyName == "GroupByExpansionIndicatorVisibility")
					{
						flag2 = true;
						goto IL_5BC;
					}
					goto IL_5BC;
				}
			}
			IL_5BA:
			flag3 = true;
			IL_5BC:
			if (flag3 && flag)
			{
				if (fieldLayout == null)
				{
					presenter.InvalidateGeneratedStylesAsync();
				}
				else
				{
					fieldLayout.PostDelayedInvalidation();
				}
			}
			if (flag2 && fieldLayout != null)
			{
				fieldLayout.RaisePropertyChangedEvent(propertyName + "Resolved");
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0008E204 File Offset: 0x0008C404
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

		// Token: 0x0600212E RID: 8494 RVA: 0x0008E234 File Offset: 0x0008C434
		internal void ResetCachedChildRecordsDisplayOrderResolvedValue()
		{
			this._cachedChildRecordsDisplayOrderResolved = null;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x0008E242 File Offset: 0x0008C442
		internal void ReturnHeaderPresenterToCache(global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter)
		{
			this.HeaderPresenterCache.Add(headerPresenter);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0008E250 File Offset: 0x0008C450
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

		// Token: 0x06002131 RID: 8497 RVA: 0x0008E328 File Offset: 0x0008C528
		internal void SetGridCounts(int totalColumnsGenerated, int totalRowsGenerated)
		{
			this._totalColumnsGenerated = totalColumnsGenerated;
			this._totalRowsGenerated = totalRowsGenerated;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0008E338 File Offset: 0x0008C538
		internal void SetHasSeparateHeader(bool separateHeader)
		{
			this._cachedHasSeparateHeader = separateHeader;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayout.HasSeparateHeaderPropertyKey, global::Infragistics.KnownBoxes.FromValue(separateHeader));
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0008E354 File Offset: 0x0008C554
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return this.ShouldSerializeSettings() || this.ShouldSerializeDescription() || this.ShouldSerializeFields() || this.ShouldSerializeFieldSettings() || this.ShouldSerializeRecordFilters() || this.ShouldSerializeSummaryDefinitions() || this.ShouldSerializeKey() || global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0008E3A4 File Offset: 0x0008C5A4
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

		// Token: 0x06002135 RID: 8501 RVA: 0x0008E55C File Offset: 0x0008C75C
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

		// Token: 0x06002136 RID: 8502 RVA: 0x0008E5AC File Offset: 0x0008C7AC
		internal void VerifyStyleGeneratorTemplates()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this._styleGenerator;
			if (styleGenerator != null && !styleGenerator.IsGeneratingTemplates)
			{
				styleGenerator.GenerateTemplates();
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0008E5D4 File Offset: 0x0008C7D4
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

		// Token: 0x06002138 RID: 8504 RVA: 0x0008E650 File Offset: 0x0008C850
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

		// Token: 0x06002139 RID: 8505 RVA: 0x0008E6B8 File Offset: 0x0008C8B8
		private void InitializeHeaderPresenter(global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter)
		{
			headerPresenter.Content = this;
			headerPresenter.SetBinding(global::System.Windows.Controls.ContentControl.ContentTemplateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("HeaderAreaTemplate", global::System.Windows.Data.BindingMode.OneWay, this));
			headerPresenter.SetBinding(global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0008E6F4 File Offset: 0x0008C8F4
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

		// Token: 0x0600213B RID: 8507 RVA: 0x0008E72A File Offset: 0x0008C92A
		private void OnCustomFilterDialogClosed(global::Infragistics.Windows.Controls.ToolWindow toolWindow, bool? dialogResult)
		{
			toolWindow.Resources = null;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0008E734 File Offset: 0x0008C934
		private void OnFieldCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._isInFieldInitialization)
			{
				return;
			}
			if (((global::Infragistics.Windows.DataPresenter.FieldCollection)sender).Count < 1 || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._areFieldsInitialized = false;
			}
			this.DirtyFixedState();
			this.TemplateDataRecordCache.BumpCacheVersion(true);
			if (this._presenter != null && this._presenter.IsInitialized)
			{
				this.InvalidateGeneratedStylesAsnyc(true, e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
				global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this._presenter, this, "Fields", null);
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x0008E7B4 File Offset: 0x0008C9B4
		private void OnSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout.ProcessFieldLayoutSettingsPropertyChanged(e, this._settings, this, null != dataPresenter, this, dataPresenter);
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0008E7DE File Offset: 0x0008C9DE
		internal void PostDelayedInvalidation()
		{
			if (this._presenter != null && !this._isInFieldInitialization)
			{
				this._presenter.InvalidateGeneratedStylesAsync();
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0008E7FC File Offset: 0x0008C9FC
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
			if (dataRecord2 != null && dataRecord2.AssociatedRecordPresenter != null)
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

		// Token: 0x06002140 RID: 8512 RVA: 0x0008E94C File Offset: 0x0008CB4C
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
				if (!field.IsUnbound)
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

		// Token: 0x06002141 RID: 8513 RVA: 0x0008EB04 File Offset: 0x0008CD04
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
				this.PostDelayedInvalidation();
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0008EBA0 File Offset: 0x0008CDA0
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
				this.PostDelayedInvalidation();
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
				this.PostDelayedInvalidation();
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0008ECF4 File Offset: 0x0008CEF4
		private static global::Infragistics.Windows.DataPresenter.AutoFitState ResolveAutoFit(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter = fl._presenter;
			if (presenter == null)
			{
				return global::Infragistics.Windows.DataPresenter.AutoFitState.None;
			}
			global::Infragistics.Windows.DataPresenter.AutoFitState autoFitState = global::Infragistics.Windows.DataPresenter.AutoFitState.None;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = presenter.CurrentViewInternal;
			global::Infragistics.Windows.DataPresenter.AutoFitMode autoFitMode = fl.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AutoFitMode>(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.AutoFitModeProperty, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default, global::Infragistics.Windows.DataPresenter.AutoFitMode.Default);
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

		// Token: 0x06002144 RID: 8516 RVA: 0x0008EDB0 File Offset: 0x0008CFB0
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

		// Token: 0x06002145 RID: 8517 RVA: 0x0008EE18 File Offset: 0x0008D018
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

		// Token: 0x06002146 RID: 8518 RVA: 0x0008EF14 File Offset: 0x0008D114
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

		// Token: 0x04000FBD RID: 4029
		private const double DefaultRecordSelectorBaseExtent = 20.0;

		// Token: 0x04000FBE RID: 4030
		private const double DefaultRecordSelectorErrorIconExtent = 10.0;

		// Token: 0x04000FBF RID: 4031
		private const double DefaultRecordSelectorFixButtonExtent = 12.0;

		// Token: 0x04000FC0 RID: 4032
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.DataColumn> _dataColumnMap;

		// Token: 0x04000FC1 RID: 4033
		private global::Infragistics.Windows.DataPresenter.FieldCollection _fields;

		// Token: 0x04000FC2 RID: 4034
		private global::Infragistics.Windows.DataPresenter.Field _primaryField;

		// Token: 0x04000FC3 RID: 4035
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

		// Token: 0x04000FC4 RID: 4036
		private bool _isdefault;

		// Token: 0x04000FC5 RID: 4037
		private bool _isInitialized;

		// Token: 0x04000FC6 RID: 4038
		private bool _areFieldsInitialized;

		// Token: 0x04000FC7 RID: 4039
		private bool _keyExplicitlySet;

		// Token: 0x04000FC8 RID: 4040
		private bool _initialRecordLoaded;

		// Token: 0x04000FC9 RID: 4041
		private bool _isInFieldInitialization;

		// Token: 0x04000FCA RID: 4042
		private bool _areFieldsAutoGenerated;

		// Token: 0x04000FCB RID: 4043
		private bool _wrapsEnumerableObject;

		// Token: 0x04000FCC RID: 4044
		private bool _wasRemovedFromCollection;

		// Token: 0x04000FCD RID: 4045
		private global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator _styleGenerator;

		// Token: 0x04000FCE RID: 4046
		private int _totalRowsGenerated;

		// Token: 0x04000FCF RID: 4047
		private int _totalColumnsGenerated;

		// Token: 0x04000FD0 RID: 4048
		private int _sortVersion;

		// Token: 0x04000FD1 RID: 4049
		private int _groupByVersion;

		// Token: 0x04000FD2 RID: 4050
		private int _index;

		// Token: 0x04000FD3 RID: 4051
		private global::Infragistics.Windows.DataPresenter.FieldLayoutSettings _settings;

		// Token: 0x04000FD4 RID: 4052
		private global::Infragistics.Windows.DataPresenter.FieldSettings _cachedFieldSettings;

		// Token: 0x04000FD5 RID: 4053
		private global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection _sortedFields;

		// Token: 0x04000FD6 RID: 4054
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyCell;

		// Token: 0x04000FD7 RID: 4055
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyField;

		// Token: 0x04000FD8 RID: 4056
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategyRecord;

		// Token: 0x04000FD9 RID: 4057
		private string _cachedDescription;

		// Token: 0x04000FDA RID: 4058
		private object _cachedKey;

		// Token: 0x04000FDB RID: 4059
		private global::System.Collections.Generic.List<global::System.WeakReference> _propertyDescriptorProviders;

		// Token: 0x04000FDC RID: 4060
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderPresenter> _headerPresenterCache;

		// Token: 0x04000FDD RID: 4061
		private int _primaryFieldVersion;

		// Token: 0x04000FDE RID: 4062
		private global::Infragistics.Windows.DataPresenter.Field _scrollTipField;

		// Token: 0x04000FDF RID: 4063
		private int _scrollTipFieldVersion;

		// Token: 0x04000FE0 RID: 4064
		private global::Infragistics.Windows.DataPresenter.DataRecord _templateDataRecord;

		// Token: 0x04000FE1 RID: 4065
		private global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache _templateDataRecordCache;

		// Token: 0x04000FE2 RID: 4066
		private global::Infragistics.Windows.DataPresenter.FieldLayout _parentFieldLayout;

		// Token: 0x04000FE3 RID: 4067
		private global::Infragistics.Windows.DataPresenter.Field _parentField;

		// Token: 0x04000FE4 RID: 4068
		private bool _keyMatchingEnforced;

		// Token: 0x04000FE5 RID: 4069
		private global::Infragistics.Windows.Helpers.HashSet _pendingFieldsToRefresh;

		// Token: 0x04000FE6 RID: 4070
		private global::Infragistics.Windows.DataPresenter.GroupByRecord _templateGroupByRecord;

		// Token: 0x04000FE7 RID: 4071
		private global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection _summaryDefinitions;

		// Token: 0x04000FE8 RID: 4072
		private int _cachedSpecialRecordsVersion = 1;

		// Token: 0x04000FE9 RID: 4073
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _fieldLayoutInfo;

		// Token: 0x04000FEA RID: 4074
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo _autoGeneratedPositions;

		// Token: 0x04000FEB RID: 4075
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _recordFilters;

		// Token: 0x04000FEC RID: 4076
		private global::Infragistics.Windows.DataPresenter.RecordFilterAction _cachedRecordFilterActionResolved;

		// Token: 0x04000FED RID: 4077
		private global::Infragistics.Windows.Controls.LogicalOperator? _cachedRecordFiltersLogicalOperatorResolved;

		// Token: 0x04000FEE RID: 4078
		private global::Infragistics.Windows.DataPresenter.RecordFilterScope? _cachedRecordFilterScopeResolvedDefault;

		// Token: 0x04000FEF RID: 4079
		private bool? _cachedReevaluateFiltersOnDataChange;

		// Token: 0x04000FF0 RID: 4080
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _cellLayoutManager;

		// Token: 0x04000FF1 RID: 4081
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _labelLayoutManager;

		// Token: 0x04000FF2 RID: 4082
		private int _verifiedLayoutManagerVersion = -1;

		// Token: 0x04000FF3 RID: 4083
		private int _layoutManagerVersion;

		// Token: 0x04000FF4 RID: 4084
		private int _layoutItemVersion = 1;

		// Token: 0x04000FF5 RID: 4085
		private int _fixedFieldVersion;

		// Token: 0x04000FF6 RID: 4086
		private global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo _fixedFieldInfo;

		// Token: 0x04000FF7 RID: 4087
		private global::System.Windows.Size _expansionIndicatorSize;

		// Token: 0x04000FF8 RID: 4088
		private int _indentOffsetVersion;

		// Token: 0x04000FF9 RID: 4089
		private bool _createDragFieldLayout;

		// Token: 0x04000FFA RID: 4090
		private global::System.Windows.Threading.DispatcherOperation _bumpLayoutItemOp;

		// Token: 0x04000FFB RID: 4091
		private bool _hasBeenInitializedAfterDataSourceChange;

		// Token: 0x04000FFC RID: 4092
		private global::System.Windows.Threading.DispatcherOperation _bumpRecordIndentVersionPending;

		// Token: 0x04000FFD RID: 4093
		private global::Infragistics.Windows.DataPresenter.AutoFitState? _autoFitState;

		// Token: 0x04000FFE RID: 4094
		private global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo _autoSizeInfo;

		// Token: 0x04000FFF RID: 4095
		private int _maxRecordManagerDepth;

		// Token: 0x04001000 RID: 4096
		private bool _fieldLayoutInitializedEventRaised;

		// Token: 0x04001001 RID: 4097
		private global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateStylesAsyncInfo _pendingInvalidateGeneratedStyles;

		// Token: 0x04001002 RID: 4098
		private bool? _hasStarFieldsX = null;

		// Token: 0x04001003 RID: 4099
		private bool? _hasStarFieldsY = null;

		// Token: 0x04001004 RID: 4100
		private global::Infragistics.Windows.DataPresenter.CellPresentation? _cachedCellPresentation;

		// Token: 0x04001005 RID: 4101
		private bool? _cachedIsEmptyCellCollapsingSupportedByView;

		// Token: 0x04001006 RID: 4102
		private global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder? _cachedChildRecordsDisplayOrderResolved;

		// Token: 0x04001007 RID: 4103
		private global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo? _cachedSupportDataErrorInfoResolvedDefault;

		// Token: 0x04001008 RID: 4104
		private bool _preventBumpLayoutManagerVersionRequired;

		// Token: 0x04001009 RID: 4105
		private bool? _cachedIsHorizontal = null;

		// Token: 0x0400100A RID: 4106
		private global::System.WeakReference _lastSelectableItemLabel;

		// Token: 0x0400100B RID: 4107
		private global::Infragistics.Windows.DataPresenter.SortEvaluationMode? _cachedSortEvaluationModeResolved;

		// Token: 0x0400100C RID: 4108
		private global::Infragistics.Windows.DataPresenter.FilterEvaluationMode? _cachedFilterEvaluationModeResolved;

		// Token: 0x0400100D RID: 4109
		private global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode? _cachedGroupByEvaluationModeResolved;

		// Token: 0x0400100E RID: 4110
		private global::Infragistics.Windows.DataPresenter.SummaryEvaluationMode? _cachedSummaryEvaluationModeResolved;

		// Token: 0x0400100F RID: 4111
		public static readonly global::System.Windows.DependencyProperty CalculationReferenceIdProperty = global::System.Windows.DependencyProperty.Register("CalculationReferenceId", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnCalculationReferenceIdChanged)));

		// Token: 0x04001010 RID: 4112
		private string _calculationRefernceId;

		// Token: 0x04001011 RID: 4113
		private static readonly global::System.Windows.DependencyPropertyKey CellPresentationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CellPresentation", typeof(global::Infragistics.Windows.DataPresenter.CellPresentation), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellPresentation.CardView));

		// Token: 0x04001012 RID: 4114
		public static readonly global::System.Windows.DependencyProperty CellPresentationProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.CellPresentationPropertyKey.DependencyProperty;

		// Token: 0x04001013 RID: 4115
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty = global::System.Windows.DependencyProperty.Register("Description", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.CoerceDescription)));

		// Token: 0x04001014 RID: 4116
		public static readonly global::System.Windows.DependencyProperty FieldSettingsProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty;

		// Token: 0x04001015 RID: 4117
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparateHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSeparateHeader", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001016 RID: 4118
		public static readonly global::System.Windows.DependencyProperty HasSeparateHeaderProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.HasSeparateHeaderPropertyKey.DependencyProperty;

		// Token: 0x04001017 RID: 4119
		private bool _cachedHasSeparateHeader;

		// Token: 0x04001018 RID: 4120
		public static readonly global::System.Windows.DependencyProperty KeyProperty = global::System.Windows.DependencyProperty.Register("Key", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04001019 RID: 4121
		public static readonly global::System.Windows.DependencyProperty KeyMatchingEnforcedProperty = global::System.Windows.DependencyProperty.Register("KeyMatchingEnforced", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnKeyMatchingEnforcedChanged)));

		// Token: 0x0400101A RID: 4122
		public static readonly global::System.Windows.DependencyProperty ParentFieldLayoutKeyProperty = global::System.Windows.DependencyProperty.Register("ParentFieldLayoutKey", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnParentFieldLayoutKeyChanged)));

		// Token: 0x0400101B RID: 4123
		public static readonly global::System.Windows.DependencyProperty ParentFieldNameProperty = global::System.Windows.DependencyProperty.Register("ParentFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnParentFieldNameChanged)));

		// Token: 0x0400101C RID: 4124
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionMaskProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionMask", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400101D RID: 4125
		public static readonly global::System.Windows.DependencyProperty SummaryDescriptionMaskInGroupByProperty = global::System.Windows.DependencyProperty.Register("SummaryDescriptionMaskInGroupBy", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400101E RID: 4126
		public static readonly global::System.Windows.DependencyProperty TagProperty = global::System.Windows.FrameworkElement.TagProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayout));

		// Token: 0x0400101F RID: 4127
		public static readonly global::System.Windows.DependencyProperty ToolTipProperty = global::System.Windows.DependencyProperty.Register("ToolTip", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04001020 RID: 4128
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.ColumnDefinition g_fallbackColumnDefinition = null;

		// Token: 0x04001021 RID: 4129
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.ColumnDefinition g_fallbackColumnDefinitionAutoFit = null;

		// Token: 0x04001022 RID: 4130
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.RowDefinition g_fallbackRowDefinition = null;

		// Token: 0x04001023 RID: 4131
		[global::System.ThreadStatic]
		private static global::System.Windows.Controls.RowDefinition g_fallbackRowDefinitionAutoFit = null;

		// Token: 0x04001024 RID: 4132
		private int _cachedGridColumnWidthVersion;

		// Token: 0x04001025 RID: 4133
		internal static readonly global::System.Windows.DependencyProperty GridColumnWidthVersionProperty = global::System.Windows.DependencyProperty.Register("GridColumnWidthVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnGridColumnWidthVersionChanged)));

		// Token: 0x04001026 RID: 4134
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x04001027 RID: 4135
		internal static readonly global::System.Windows.DependencyProperty IsOverNearSplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverNearSplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001028 RID: 4136
		internal static readonly global::System.Windows.DependencyProperty IsOverFarSplitterProperty = global::System.Windows.DependencyProperty.Register("IsOverFarSplitter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001029 RID: 4137
		internal static readonly global::System.Windows.DependencyProperty SortOperationVersionProperty = global::System.Windows.DependencyProperty.Register("SortOperationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x0400102A RID: 4138
		internal static readonly global::System.Windows.DependencyProperty SpecialRecordsVersionProperty = global::System.Windows.DependencyProperty.Register("SpecialRecordsVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnSpecialRecordsVersionChanged)));

		// Token: 0x0400102B RID: 4139
		internal static readonly global::System.Windows.DependencyProperty TemplateVersionProperty = global::System.Windows.DependencyProperty.Register("TemplateVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldLayout.OnTemplateVersion)));

		// Token: 0x0400102C RID: 4140
		private int _templateVersion;

		// Token: 0x020002BF RID: 703
		internal class LayoutPropertyDescriptorProvider
		{
			// Token: 0x0600214A RID: 8522 RVA: 0x0008F43E File Offset: 0x0008D63E
			internal LayoutPropertyDescriptorProvider(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
			{
				this._fieldLayout = fieldLayout;
				this._provider = provider;
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x0008F454 File Offset: 0x0008D654
			internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
			{
				get
				{
					return this._fieldLayout;
				}
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x0600214C RID: 8524 RVA: 0x0008F45C File Offset: 0x0008D65C
			internal global::Infragistics.Windows.Internal.PropertyDescriptorProvider Provider
			{
				get
				{
					return this._provider;
				}
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x0008F464 File Offset: 0x0008D664
			private global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[] FieldDescriptors
			{
				get
				{
					this.VerifyFieldDescriptors();
					return this._fieldDescriptors;
				}
			}

			// Token: 0x0600214E RID: 8526 RVA: 0x0008F472 File Offset: 0x0008D672
			internal void Dirty()
			{
				this._fieldDescriptorVersion--;
			}

			// Token: 0x0600214F RID: 8527 RVA: 0x0008F484 File Offset: 0x0008D684
			internal global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor GetFieldDescriptor(global::Infragistics.Windows.DataPresenter.Field field)
			{
				int index = field.Index;
				if (index < 0 || field.Owner != this._fieldLayout)
				{
					return null;
				}
				return this.FieldDescriptors[index];
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x0008F4B4 File Offset: 0x0008D6B4
			internal bool HasPropertyDescriptorFor(global::Infragistics.Windows.DataPresenter.UnboundField field)
			{
				this.VerifyFieldDescriptors();
				int index = field.Index;
				return this._unboundFieldsWithPropertyDescriptor != null && index >= 0 && index < this._unboundFieldsWithPropertyDescriptor.Length && null != this._unboundFieldsWithPropertyDescriptor[index];
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
			internal static bool HasPropertyDescriptorFor(global::Infragistics.Windows.DataPresenter.UnboundCell cell)
			{
				global::Infragistics.Windows.DataPresenter.UnboundField field = cell.Field as global::Infragistics.Windows.DataPresenter.UnboundField;
				global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = (record != null) ? record.PropertyDescriptorProvider : null;
				return layoutPropertyDescriptorProvider != null && layoutPropertyDescriptorProvider.HasPropertyDescriptorFor(field);
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x0008F534 File Offset: 0x0008D734
			internal static global::Infragistics.Windows.DataPresenter.UnboundField GetUnboundFieldWithPropertyDescriptor(global::Infragistics.Windows.DataPresenter.DataRecord record, string propertyDescriptorName)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = record.PropertyDescriptorProvider;
				if (propertyDescriptorProvider != null)
				{
					propertyDescriptorProvider.VerifyFieldDescriptors();
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.UnboundField> unboundFieldsWithPropertyDescriptorMap = propertyDescriptorProvider._unboundFieldsWithPropertyDescriptorMap;
					global::Infragistics.Windows.DataPresenter.UnboundField result;
					if (unboundFieldsWithPropertyDescriptorMap != null && unboundFieldsWithPropertyDescriptorMap.TryGetValue(propertyDescriptorName, out result))
					{
						return result;
					}
				}
				return null;
			}

			// Token: 0x06002153 RID: 8531 RVA: 0x0008F56C File Offset: 0x0008D76C
			internal static bool HasUnboundFieldWithPropertyDescriptor(global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = record.PropertyDescriptorProvider;
				if (propertyDescriptorProvider != null)
				{
					propertyDescriptorProvider.VerifyFieldDescriptors();
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.UnboundField> unboundFieldsWithPropertyDescriptorMap = propertyDescriptorProvider._unboundFieldsWithPropertyDescriptorMap;
					return unboundFieldsWithPropertyDescriptorMap != null && unboundFieldsWithPropertyDescriptorMap.Count > 0;
				}
				return false;
			}

			// Token: 0x06002154 RID: 8532 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
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
						if (!this._fieldLayout.AutoGenerateFieldsResolved && this._fieldLayout._fieldLayoutInitializedEventRaised && !field.IsUnbound && !field.IsPropertyDescriptorInitialized)
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
					global::Infragistics.Windows.DataPresenter.UnboundField unboundField = array[k] as global::Infragistics.Windows.DataPresenter.UnboundField;
					if (unboundField != null)
					{
						global::System.Windows.PropertyPath bindingPath = unboundField.BindingPath;
						if (bindingPath != null && unboundField.Binding == null)
						{
							string path = bindingPath.Path;
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptorCollection.Find(path, false);
							if (propertyDescriptor != null && (this._unboundFieldsWithPropertyDescriptorMap == null || !this._unboundFieldsWithPropertyDescriptorMap.ContainsKey(path)) && fields.IndexOf(path) < 0)
							{
								if (this._unboundFieldsWithPropertyDescriptorMap == null)
								{
									this._unboundFieldsWithPropertyDescriptor = new string[count];
									this._unboundFieldsWithPropertyDescriptorMap = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.UnboundField>();
								}
								this._unboundFieldsWithPropertyDescriptor[k] = path;
								this._unboundFieldsWithPropertyDescriptorMap[path] = unboundField;
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

			// Token: 0x0400102F RID: 4143
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x04001030 RID: 4144
			private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _provider;

			// Token: 0x04001031 RID: 4145
			private global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor[] _fieldDescriptors;

			// Token: 0x04001032 RID: 4146
			private int _fieldDescriptorVersion;

			// Token: 0x04001033 RID: 4147
			private string[] _unboundFieldsWithPropertyDescriptor;

			// Token: 0x04001034 RID: 4148
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.UnboundField> _unboundFieldsWithPropertyDescriptorMap;
		}

		// Token: 0x020002C0 RID: 704
		internal class FieldDescriptor
		{
			// Token: 0x06002155 RID: 8533 RVA: 0x0008F870 File Offset: 0x0008DA70
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

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x06002156 RID: 8534 RVA: 0x0008F900 File Offset: 0x0008DB00
			internal global::System.Data.DataColumn DataColumn
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x06002157 RID: 8535 RVA: 0x0008F908 File Offset: 0x0008DB08
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x06002158 RID: 8536 RVA: 0x0008F910 File Offset: 0x0008DB10
			internal global::System.ComponentModel.PropertyDescriptor PropertyDescriptor
			{
				get
				{
					return this._propertyDescriptor;
				}
			}

			// Token: 0x04001035 RID: 4149
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x04001036 RID: 4150
			private global::System.ComponentModel.PropertyDescriptor _propertyDescriptor;

			// Token: 0x04001037 RID: 4151
			private global::System.Data.DataColumn _column;
		}
	}
}
