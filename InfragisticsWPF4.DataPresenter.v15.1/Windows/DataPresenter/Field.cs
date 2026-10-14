using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000D4 RID: 212
	[global::System.Windows.StyleTypedProperty(Property = "EditorStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.ValueEditor))]
	[global::System.Windows.StyleTypedProperty(Property = "CellValuePresenterStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter))]
	public class Field : global::Infragistics.DependencyObjectNotifier, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x0002C508 File Offset: 0x0002A708
		static Field()
		{
			global::Infragistics.Windows.DataPresenter.Field.DataContextProperty = global::System.Windows.FrameworkElement.DataContextProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnDataContextChanged)));
			global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo[] array = new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo[]
			{
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsArrowKeysInEditMode, global::Infragistics.Windows.Editors.ValueEditor.AcceptsArrowKeysInEditModeProperty, global::Infragistics.Windows.DataPresenter.Field.AcceptsArrowKeysInEditModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AlwaysValidate, global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty, global::Infragistics.Windows.DataPresenter.Field.AlwaysValidateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Format, global::Infragistics.Windows.Editors.ValueEditor.FormatProperty, global::Infragistics.Windows.DataPresenter.Field.FormatProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.FormatProvider, global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty, global::Infragistics.Windows.DataPresenter.Field.FormatProviderProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.HorizontalContentAlignment, global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty, global::Infragistics.Windows.DataPresenter.Field.HorizontalContentAlignmentProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.InvalidValueBehavior, global::Infragistics.Windows.Editors.ValueEditor.InvalidValueBehaviorProperty, global::Infragistics.Windows.DataPresenter.Field.InvalidValueBehaviorProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsReadOnly, global::Infragistics.Windows.Editors.ValueEditor.IsReadOnlyProperty, global::Infragistics.Windows.DataPresenter.Field.IsReadOnlyProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueConstraint, global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty, global::Infragistics.Windows.DataPresenter.Field.ValueConstraintProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToTextConverter, global::Infragistics.Windows.Editors.ValueEditor.ValueToTextConverterProperty, global::Infragistics.Windows.DataPresenter.Field.ValueToTextConverterProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.VerticalContentAlignment, global::System.Windows.Controls.Control.VerticalContentAlignmentProperty, global::Infragistics.Windows.DataPresenter.Field.VerticalContentAlignmentProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.NullText, global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty, global::Infragistics.Windows.DataPresenter.TextFieldBase.NullTextProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToDisplayTextConverter, global::Infragistics.Windows.Editors.TextEditorBase.ValueToDisplayTextConverterProperty, global::Infragistics.Windows.DataPresenter.TextFieldBase.ValueToDisplayTextConverterProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsReturn, global::Infragistics.Windows.Editors.XamTextEditor.AcceptsReturnProperty, global::Infragistics.Windows.DataPresenter.TextField.AcceptsReturnProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsTab, global::Infragistics.Windows.Editors.XamTextEditor.AcceptsTabProperty, global::Infragistics.Windows.DataPresenter.TextField.AcceptsTabProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.HorizontalScrollbarVisibility, global::Infragistics.Windows.Editors.XamTextEditor.HorizontalScrollBarVisibilityProperty, global::Infragistics.Windows.DataPresenter.TextField.HorizontalScrollBarVisibilityProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TextAlignment, global::Infragistics.Windows.Editors.XamTextEditor.TextAlignmentProperty, global::Infragistics.Windows.DataPresenter.TextField.TextAlignmentProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TextWrapping, global::Infragistics.Windows.Editors.XamTextEditor.TextWrappingProperty, global::Infragistics.Windows.DataPresenter.TextField.TextWrappingProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.VerticalScrollbarVisibility, global::Infragistics.Windows.Editors.XamTextEditor.VerticalScrollBarVisibilityProperty, global::Infragistics.Windows.DataPresenter.TextField.VerticalScrollBarVisibilityProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsThreeState, global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty, global::Infragistics.Windows.DataPresenter.CheckBoxField.IsThreeStateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ComboBoxStyle, global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.ComboBoxStyleProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayMemberPath, global::Infragistics.Windows.Editors.XamComboEditor.DisplayMemberPathProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayMemberPathProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayValueSource, global::Infragistics.Windows.Editors.XamComboEditor.DisplayValueSourceProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayValueSourceProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonDisplayMode, global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonDisplayModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonStyle, global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonStyleProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownResizeMode, global::Infragistics.Windows.Editors.XamComboEditor.DropDownResizeModeProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownResizeModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsEditable, global::Infragistics.Windows.Editors.XamComboEditor.IsEditableProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.IsEditableProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ItemsSource, global::Infragistics.Windows.Editors.XamComboEditor.ItemsSourceProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.ItemsSourceProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.LimitToList, global::Infragistics.Windows.Editors.XamComboEditor.LimitToListProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.LimitToListProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MaxDropDownHeight, global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownHeightProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownHeightProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MaxDropDownWidth, global::Infragistics.Windows.Editors.XamComboEditor.MaxDropDownWidthProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownWidthProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MinDropDownWidth, global::Infragistics.Windows.Editors.XamComboEditor.MinDropDownWidthProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.MinDropDownWidthProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PreDropDownAreaTemplate, global::Infragistics.Windows.Editors.XamComboEditor.PreDropDownAreaTemplateProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.PreDropDownAreaTemplateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PostDropDownAreaTemplate, global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.PostDropDownAreaTemplateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValuePath, global::Infragistics.Windows.Editors.XamComboEditor.ValuePathProperty, global::Infragistics.Windows.DataPresenter.ComboBoxField.ValuePathProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AllowShiftingAcrossSections, global::Infragistics.Windows.Editors.XamMaskedEditor.AllowShiftingAcrossSectionsProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.AllowShiftingAcrossSectionsProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AutoFillDate, global::Infragistics.Windows.Editors.XamMaskedEditor.AutoFillDateProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.AutoFillDateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ClipMode, global::Infragistics.Windows.Editors.XamMaskedEditor.ClipModeProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.ClipModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DataMode, global::Infragistics.Windows.Editors.XamMaskedEditor.DataModeProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.DataModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayMode, global::Infragistics.Windows.Editors.XamMaskedEditor.DisplayModeProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.DisplayModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Mask, global::Infragistics.Windows.Editors.XamMaskedEditor.MaskProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.MaskProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PadChar, global::Infragistics.Windows.Editors.XamMaskedEditor.PadCharProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.PadCharProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PromptChar, global::Infragistics.Windows.Editors.XamMaskedEditor.PromptCharProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.PromptCharProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SelectAllBehavior, global::Infragistics.Windows.Editors.XamMaskedEditor.SelectAllBehaviorProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.SelectAllBehaviorProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinButtonDisplayMode, global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonDisplayModeProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonDisplayModeProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinButtonStyle, global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonStyleProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonStyleProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinIncrement, global::Infragistics.Windows.Editors.XamMaskedEditor.SpinIncrementProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinIncrementProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinWrap, global::Infragistics.Windows.Editors.XamMaskedEditor.SpinWrapProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinWrapProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TabNavigation, global::Infragistics.Windows.Editors.XamMaskedEditor.TabNavigationProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.TabNavigationProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TrimFractionalZeros, global::Infragistics.Windows.Editors.XamMaskedEditor.TrimFractionalZerosProperty, global::Infragistics.Windows.DataPresenter.MaskedTextField.TrimFractionalZerosProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AllowDropDown, global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty, global::Infragistics.Windows.DataPresenter.DateTimeField.AllowDropDownProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayTemplate, global::Infragistics.Windows.Editors.TemplateEditor.DisplayDataTemplateProperty, global::Infragistics.Windows.DataPresenter.TemplateField.DisplayTemplateProperty),
				new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId.EditTemplate, global::Infragistics.Windows.Editors.TemplateEditor.EditDataTemplateProperty, global::Infragistics.Windows.DataPresenter.TemplateField.EditTemplateProperty)
			};
			global::Infragistics.Windows.DataPresenter.Field._EditorPropInfos = new global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo[52];
			foreach (global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo editorPropertyInfo in array)
			{
				global::Infragistics.Windows.DataPresenter.Field._EditorPropInfos[(int)editorPropertyInfo._index] = editorPropertyInfo;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002D734 File Offset: 0x0002B934
		public Field()
		{
			this.Initialize();
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002D7B3 File Offset: 0x0002B9B3
		public Field(string name) : this()
		{
			this.Name = name;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0002D7C2 File Offset: 0x0002B9C2
		public Field(string name, global::System.Type dataType) : this(name)
		{
			this.DataType = dataType;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002D7D2 File Offset: 0x0002B9D2
		public Field(string name, object label) : this(name)
		{
			this.Label = label;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0002D7E2 File Offset: 0x0002B9E2
		public Field(string name, global::System.Type dataType, object label) : this(name, dataType)
		{
			this.Label = label;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		internal Field(global::System.Type dataType, string name, object label)
		{
			this._autoGenerated = true;
			this.DataType = dataType;
			this.Name = name;
			this.InitializeDefaultLabel(label);
			this._dataTypeExplicitySet = false;
			this._nameExplicitySet = false;
			this._cachedFixedLocation = this.FixedLocation;
			this.Initialize();
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0002D8A9 File Offset: 0x0002BAA9
		private void Initialize()
		{
			this.CacheDataType(base.GetValue(global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty) as global::System.Type);
			this._cachedBindingType = (global::Infragistics.Windows.DataPresenter.BindingType)global::Infragistics.Windows.DataPresenter.Field.BindingTypeProperty.GetMetadata(base.GetType()).DefaultValue;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		protected override void OnPropertyChanged(string propertyName)
		{
			long editorPropsChangedBits = this._editorPropsChangedBits;
			base.OnPropertyChanged(propertyName);
			this._editorPropsChangedBits &= ~editorPropsChangedBits;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002D910 File Offset: 0x0002BB10
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			bool? flag = null;
			if (this._owner != null && e.Property == global::Infragistics.Windows.DataPresenter.Field.LabelProperty)
			{
				flag = new bool?(this.AllowLabelVirtualizationResolved);
			}
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty)
			{
				this._dataTypeExplicitySet = true;
				this.CacheDataType((global::System.Type)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty));
				bool isExpandableResolved = this.IsExpandableResolved;
				if (this._cachedDataTypeUnderlying == null || this._cachedDataTypeUnderlying == typeof(string))
				{
					this._isExpandableByDefault = false;
				}
				else
				{
					this._isExpandableByDefault = typeof(global::System.Collections.IEnumerable).IsAssignableFrom(this._cachedDataTypeUnderlying);
				}
				if (this._owner != null && isExpandableResolved != this.IsExpandableResolved)
				{
					this._owner.Fields.OnIsExpandableFieldInvalidated(this);
					this.ProcessIsExpandableChanged();
				}
				this.DirtyRecordFilterRelatedCache(true);
			}
			else if (property == global::Infragistics.Windows.DataPresenter.Field.LabelProperty)
			{
				if (this._owner != null && flag != null && flag.Value != this.AllowLabelVirtualizationResolved && this._owner.TemplateDataRecordCache != null)
				{
					this._owner.BumpTemplateVersion(false);
				}
			}
			else if (property == global::Infragistics.Windows.DataPresenter.Field.IsExpandableProperty)
			{
				this._cachedIsExpandable = (bool?)e.NewValue;
				if (this._owner != null)
				{
					this._owner.Fields.OnIsExpandableFieldInvalidated(this);
				}
				this.ProcessIsExpandableChanged();
			}
			else if (property == global::Infragistics.Windows.DataPresenter.Field.VisibilityProperty)
			{
				if (this._owner != null && this._owner.DataPresenter != null)
				{
					this._owner.Fields.OnIsExpandableFieldInvalidated(this);
					this._owner.OnFieldVisibilityChanged(this);
				}
				this.BumpLayoutItemVersion();
				base.RaisePropertyChangedEvent("VisibilityResolved");
			}
			else if (global::Infragistics.Windows.DataPresenter.Field.SummaryStringFormatsProperty == property)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionCollection = (this._owner != null) ? this._owner.SummaryDefinitionsIfAllocated : null;
				if (summaryDefinitionCollection != null)
				{
					summaryDefinitionCollection.BumpDataVersion();
				}
			}
			base.RaisePropertyChangedEvent(property.Name);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0002DB14 File Offset: 0x0002BD14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Field: ");
			stringBuilder.Append(this.Name);
			return stringBuilder.ToString();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002DB46 File Offset: 0x0002BD46
		private static void OnAcceptsArrowKeysInEditModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsArrowKeysInEditMode, e.NewValue);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002DB5B File Offset: 0x0002BD5B
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x0002DB6D File Offset: 0x0002BD6D
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AcceptsArrowKeysInEditMode
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AcceptsArrowKeysInEditModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AcceptsArrowKeysInEditModeProperty, value);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002DB80 File Offset: 0x0002BD80
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0002DB88 File Offset: 0x0002BD88
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.BindingBase AlternateBinding
		{
			get
			{
				return this._alternateBinding;
			}
			set
			{
				if (this._alternateBinding != value)
				{
					this.ValidateBindingSetting(value);
					this._alternateBinding = value;
					this.InitializeIsBoundToRootProperty();
					base.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.BindingTypeProperty);
					base.RaisePropertyChangedEvent("AlternateBinding");
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002DBBD File Offset: 0x0002BDBD
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0002DBCF File Offset: 0x0002BDCF
		public global::Infragistics.Windows.DataPresenter.BindingRetentionMode AlternateBindingRetentionMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.BindingRetentionMode)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AlternateBindingRetentionModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AlternateBindingRetentionModeProperty, value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0002DCA9 File Offset: 0x0002BEA9
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldPosition ActualPosition
		{
			get
			{
				if (this._owner != null && this._owner.IsTreeView && this.IsFieldMapped)
				{
					return this._mappedTreeField.ActualPosition;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
				if (owner != null)
				{
					global::Infragistics.Windows.DataPresenter.LayoutInfo fieldLayoutInfo = owner.GetFieldLayoutInfo(true, false);
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = (fieldLayoutInfo != null) ? fieldLayoutInfo[this] : null;
					if (itemLayoutInfo != null)
					{
						return new global::Infragistics.Windows.DataPresenter.FieldPosition(itemLayoutInfo.Column, itemLayoutInfo.Row, itemLayoutInfo.ColumnSpan, itemLayoutInfo.RowSpan);
					}
				}
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = this.GridPosition;
				if (gridPosition != null && !gridPosition.IsEmpty)
				{
					return new global::Infragistics.Windows.DataPresenter.FieldPosition(gridPosition.Column, gridPosition.Row, gridPosition.ColumnSpan, gridPosition.RowSpan);
				}
				return new global::Infragistics.Windows.DataPresenter.FieldPosition(this.Column, this.Row, this.ColumnSpan, this.RowSpan);
			}
			set
			{
				this.SetActualPosition(value, false);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowCellVirtualizationResolved
		{
			get
			{
				return this.GetAllowCellVirtualizationResolved(null);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool AllowLabelVirtualizationResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = null;
				if (this._owner != null)
				{
					dataPresenterBase = this._owner.DataPresenter;
				}
				if (dataPresenterBase != null && dataPresenterBase.IsReportControl)
				{
					return false;
				}
				bool? flag = null;
				if (this._settings != null)
				{
					flag = this._settings.AllowLabelVirtualization;
				}
				if (flag == null && this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						flag = this._owner.FieldSettings.AllowLabelVirtualization;
					}
					if (flag == null && dataPresenterBase != null && dataPresenterBase.HasFieldSettings)
					{
						flag = dataPresenterBase.FieldSettings.AllowLabelVirtualization;
					}
				}
				if (flag != null && !flag.Value)
				{
					return false;
				}
				if (this._cachedLabel == null)
				{
					return false;
				}
				if (this.HasSettings)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings settings = this.Settings;
					if (settings.LabelPresenterStyle != null || settings.LabelPresenterStyleSelector != null || settings.CellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly)
					{
						return false;
					}
				}
				return this._cachedLabel is string && !string.IsNullOrEmpty((string)this._cachedLabel) && this.LabelTextWrappingResolved == global::System.Windows.TextWrapping.NoWrap;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002DDDE File Offset: 0x0002BFDE
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0002DDF0 File Offset: 0x0002BFF0
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowEdit
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowEditProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowEditProperty, value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002DE04 File Offset: 0x0002C004
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AllowEditResolved
		{
			get
			{
				if (this.HasFormula)
				{
					return false;
				}
				bool? allowEdit = this.AllowEdit;
				if (allowEdit != null)
				{
					return allowEdit.Value;
				}
				if (this._settings != null)
				{
					allowEdit = this._settings.AllowEdit;
				}
				if (allowEdit != null)
				{
					return allowEdit.Value;
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (this._owner.HasFieldSettings)
					{
						allowEdit = this._owner.FieldSettings.AllowEdit;
						if (allowEdit != null)
						{
							return allowEdit.Value;
						}
					}
					if (this._owner.WrapsEnumerableObject)
					{
						return false;
					}
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						allowEdit = dataPresenter.FieldSettings.AllowEdit;
						if (allowEdit != null)
						{
							return allowEdit.Value;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0002DED3 File Offset: 0x0002C0D3
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0002DEE5 File Offset: 0x0002C0E5
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldFixing AllowFixing
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowFieldFixing)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowFixingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowFixingProperty, value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002DEF8 File Offset: 0x0002C0F8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldFixing AllowFixingResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.AllowFieldFixing allowFieldFixing = this.AllowFixing;
				if (allowFieldFixing != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default)
				{
					return allowFieldFixing;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null && dataPresenter.IsFixedFieldsSupportedResolved)
				{
					if (this._settings != null)
					{
						allowFieldFixing = this._settings.AllowFixing;
					}
					if (allowFieldFixing == global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default && this._owner != null)
					{
						allowFieldFixing = this._owner.GetDefaultAllowFieldFixing(this);
					}
				}
				if (allowFieldFixing != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Default)
				{
					return allowFieldFixing;
				}
				return global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002DF55 File Offset: 0x0002C155
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0002DF67 File Offset: 0x0002C167
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowGroupBy
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowGroupByProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowGroupByProperty, value);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0002DF7C File Offset: 0x0002C17C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool AllowGroupByResolved
		{
			get
			{
				bool? allowGroupBy = this.AllowGroupBy;
				if (allowGroupBy == null && this._settings != null)
				{
					allowGroupBy = this._settings.AllowGroupBy;
				}
				if (allowGroupBy == null && this._owner != null)
				{
					allowGroupBy = new bool?(this._owner.GetDefaultAllowGroupBy(this, null));
				}
				if (allowGroupBy == null)
				{
					allowGroupBy = new bool?(true);
				}
				if (allowGroupBy.Value && this._owner != null && this._cachedBindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == this._owner.GroupByEvaluationModeResolvedDefault)
				{
					allowGroupBy = new bool?(false);
				}
				return allowGroupBy.Value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002E021 File Offset: 0x0002C221
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x0002E033 File Offset: 0x0002C233
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AllowFieldHiding AllowHiding
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AllowFieldHiding)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowHidingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowHidingProperty, value);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0002E048 File Offset: 0x0002C248
		public global::Infragistics.Windows.DataPresenter.AllowFieldHiding AllowHidingResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.AllowFieldHiding allowFieldHiding = this.AllowHiding;
				if (allowFieldHiding != global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default)
				{
					return allowFieldHiding;
				}
				if (!this.IsTreeViewExpander)
				{
					allowFieldHiding = this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.AllowFieldHiding>(global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty, global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default, global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default);
					if (allowFieldHiding == global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default)
					{
						allowFieldHiding = ((this._owner != null && this._owner.IsFieldChooserUIEnabled) ? global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Always : global::Infragistics.Windows.DataPresenter.AllowFieldHiding.ViaFieldChooserOnly);
					}
					return allowFieldHiding;
				}
				if (this._settings != null)
				{
					allowFieldHiding = this._settings.AllowHiding;
				}
				if (allowFieldHiding != global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Default)
				{
					return allowFieldHiding;
				}
				return global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0002E0C2 File Offset: 0x0002C2C2
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowRecordFiltering
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowRecordFilteringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowRecordFilteringProperty, value);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
		public bool AllowRecordFilteringResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._owner != null) ? this._owner.DataPresenter : null;
				if (dataPresenterBase != null && dataPresenterBase.IsReportControl)
				{
					return false;
				}
				if (this._cachedBindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && this._owner != null && global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.UseCollectionView == this._owner.FilterEvaluationModeResolved)
				{
					return false;
				}
				bool? allowRecordFiltering = this.AllowRecordFiltering;
				if (allowRecordFiltering != null)
				{
					return allowRecordFiltering.Value;
				}
				if (this._settings != null)
				{
					allowRecordFiltering = this._settings.AllowRecordFiltering;
					if (allowRecordFiltering != null)
					{
						return allowRecordFiltering.Value;
					}
				}
				return this._owner != null && this._owner.AllowRecordFilteringResolvedDefault;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002E17B File Offset: 0x0002C37B
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0002E18D File Offset: 0x0002C38D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowResize
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AllowResizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AllowResizeProperty, value);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool AllowResizeResolved
		{
			get
			{
				bool? allowResize = this.AllowResize;
				if (allowResize != null)
				{
					return allowResize.Value;
				}
				if (this._settings != null)
				{
					allowResize = this._settings.AllowResize;
				}
				if (allowResize != null)
				{
					return allowResize.Value;
				}
				return this._owner == null || this._owner.GetDefaultAllowResize(this);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002E200 File Offset: 0x0002C400
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool AllowSummariesResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				global::Infragistics.Windows.DataPresenter.ViewBase viewBase = (dataPresenter != null) ? dataPresenter.CurrentViewInternal : null;
				if (viewBase != null && !viewBase.IsSummaryRecordSupported)
				{
					return false;
				}
				if (dataPresenter != null && dataPresenter.IsReportControl)
				{
					return false;
				}
				if (this._settings != null)
				{
					bool? allowSummaries = this._settings.AllowSummaries;
					if (allowSummaries != null)
					{
						return allowSummaries.Value;
					}
				}
				return this._owner == null || this._owner.GetDefaultAllowSummaries(this);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002E276 File Offset: 0x0002C476
		private static void OnAlwaysValidateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AlwaysValidate, e.NewValue);
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002E28B File Offset: 0x0002C48B
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0002E29D File Offset: 0x0002C49D
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AlwaysValidate
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.AlwaysValidateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.AlwaysValidateProperty, value);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool AutoGenerated
		{
			get
			{
				return this._autoGenerated;
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002E2B8 File Offset: 0x0002C4B8
		private static object CoerceBindingType(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				if (field._alternateBinding != null)
				{
					return global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding;
				}
				if (field is global::Infragistics.Windows.DataPresenter.UnboundField)
				{
					return global::Infragistics.Windows.DataPresenter.BindingType.Unbound;
				}
			}
			return value;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		private static void OnBindingTypeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				bool flag = field._cachedBindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding;
				field._cachedBindingType = (global::Infragistics.Windows.DataPresenter.BindingType)e.NewValue;
				bool flag2 = field._cachedBindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding;
				if (field._owner != null && flag != flag2)
				{
					field._owner.OnFieldIsUnboundChanged(field);
				}
				if (!(field is global::Infragistics.Windows.DataPresenter.UnboundField) && flag != flag2 && !field._dataTypeExplicitySet)
				{
					if (flag2)
					{
						if (field._cachedDataTypeUnderlying == typeof(object))
						{
							field.CacheDataType(typeof(string));
							return;
						}
					}
					else if (field._cachedDataTypeUnderlying == typeof(string))
					{
						field.CacheDataType(typeof(object));
					}
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002E3B4 File Offset: 0x0002C5B4
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0002E3BC File Offset: 0x0002C5BC
		public global::Infragistics.Windows.DataPresenter.BindingType BindingType
		{
			get
			{
				return this._cachedBindingType;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.BindingTypeProperty, value);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		private static void OnCalculationSettingsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._calculationSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0002E3F6 File Offset: 0x0002C5F6
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0002E3FE File Offset: 0x0002C5FE
		public global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings CalculationSettings
		{
			get
			{
				return this._calculationSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.CalculationSettingsProperty, value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0002E40C File Offset: 0x0002C60C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.CellBindingCollection CellBindings
		{
			get
			{
				if (this._cellBindings == null)
				{
					this._cellBindings = new global::Infragistics.Windows.DataPresenter.CellBindingCollection(this);
				}
				return this._cellBindings;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0002E428 File Offset: 0x0002C628
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.CellClickAction CellClickActionResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.CellClickAction cellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.Default;
				if (this._settings != null)
				{
					cellClickAction = this._settings.CellClickAction;
				}
				if (cellClickAction != global::Infragistics.Windows.DataPresenter.CellClickAction.Default)
				{
					return cellClickAction;
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultCellClickAction(this);
				}
				return global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002E468 File Offset: 0x0002C668
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CellContentAlignment CellContentAlignmentResolved
		{
			get
			{
				if (this._cachedCellContentAlignmentResolved == null)
				{
					global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment = global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;
					if (this._settings != null)
					{
						cellContentAlignment = this._settings.CellContentAlignment;
					}
					if (cellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default)
					{
						if (this._owner != null)
						{
							cellContentAlignment = this._owner.GetDefaultCellContentAlignment(this);
						}
						else
						{
							cellContentAlignment = global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
						}
					}
					this._cachedCellContentAlignmentResolved = new global::Infragistics.Windows.DataPresenter.CellContentAlignment?(cellContentAlignment);
				}
				return this._cachedCellContentAlignmentResolved.Value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002E4CC File Offset: 0x0002C6CC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public double CellHeightResolved
		{
			get
			{
				if (this._owner != null)
				{
					global::System.Windows.Size templateItemSize = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetTemplateItemSize(this, false);
					double cellMaxHeightResolved = this.CellMaxHeightResolved;
					if (!double.IsNaN(cellMaxHeightResolved) && templateItemSize.Height > cellMaxHeightResolved)
					{
						templateItemSize.Height = cellMaxHeightResolved;
					}
					return templateItemSize.Height;
				}
				return this.CellHeightResolvedInternal;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0002E518 File Offset: 0x0002C718
		internal double CellHeightResolvedInternal
		{
			get
			{
				double num = this.GetCellHeightResolvedHelper(false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				if (this._cellPosition.RowSpan > 1)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				bool flag = true;
				if (owner != null)
				{
					flag = (!owner.IsHorizontal && owner.IsDataRecordSizedToContent);
				}
				if (flag)
				{
					return double.NaN;
				}
				num = this.GetLabelHeightResolvedHelper(false, false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				return this.DefaultCellHeight;
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002E594 File Offset: 0x0002C794
		internal double GetCellHeightResolvedHelper(bool provideDefault)
		{
			global::Infragistics.Windows.DataPresenter.FieldSize resizeSize = this.GetResizeSize(false, false);
			if (resizeSize.HasExplicitSize)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase view = global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(this);
				global::System.Windows.Controls.Orientation orientation = (view != null) ? view.LogicalOrientation : global::System.Windows.Controls.Orientation.Vertical;
				if (orientation == global::System.Windows.Controls.Orientation.Horizontal || (this._owner != null && this._owner.DataRecordSizingModeResolved == global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized))
				{
					return resizeSize.Value;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = this.GetWidthOrHeight(false);
			if (widthOrHeight.IsAbsolute)
			{
				return widthOrHeight.Value;
			}
			if (widthOrHeight.IsAnyAuto && resizeSize.HasAutoModeSize)
			{
				return resizeSize.Value;
			}
			if (this._settings != null)
			{
				double cellHeight = this._settings.CellHeight;
				if (!double.IsNaN(cellHeight))
				{
					return cellHeight;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				if (owner.HasFieldSettings)
				{
					double cellHeight = owner.FieldSettings.CellHeight;
					if (!double.IsNaN(cellHeight))
					{
						return cellHeight;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter != null && dataPresenter.HasFieldSettings)
				{
					double cellHeight = dataPresenter.FieldSettings.CellHeight;
					if (!double.IsNaN(cellHeight))
					{
						return cellHeight;
					}
				}
			}
			if (provideDefault)
			{
				return this.DefaultCellHeight;
			}
			return double.NaN;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0002E6BC File Offset: 0x0002C8BC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public double CellMaxHeightResolved
		{
			get
			{
				if (this._settings != null)
				{
					double cellMaxHeight = this._settings.CellMaxHeight;
					if (!double.IsNaN(cellMaxHeight))
					{
						return cellMaxHeight;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double cellMaxHeight = owner.FieldSettings.CellMaxHeight;
						if (!double.IsNaN(cellMaxHeight))
						{
							return cellMaxHeight;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double cellMaxHeight = dataPresenter.FieldSettings.CellMaxHeight;
						if (!double.IsNaN(cellMaxHeight))
						{
							return cellMaxHeight;
						}
					}
				}
				return double.PositiveInfinity;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002E74C File Offset: 0x0002C94C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double CellMaxWidthResolved
		{
			get
			{
				if (this._settings != null)
				{
					double cellMaxWidth = this._settings.CellMaxWidth;
					if (!double.IsNaN(cellMaxWidth))
					{
						return cellMaxWidth;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double cellMaxWidth = owner.FieldSettings.CellMaxWidth;
						if (!double.IsNaN(cellMaxWidth))
						{
							return cellMaxWidth;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double cellMaxWidth = dataPresenter.FieldSettings.CellMaxWidth;
						if (!double.IsNaN(cellMaxWidth))
						{
							return cellMaxWidth;
						}
					}
				}
				return double.PositiveInfinity;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002E7DC File Offset: 0x0002C9DC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double CellMinHeightResolved
		{
			get
			{
				if (this._settings != null)
				{
					double cellMinHeight = this._settings.CellMinHeight;
					if (!double.IsNaN(cellMinHeight))
					{
						return cellMinHeight;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double cellMinHeight = owner.FieldSettings.CellMinHeight;
						if (!double.IsNaN(cellMinHeight))
						{
							return cellMinHeight;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double cellMinHeight = dataPresenter.FieldSettings.CellMinHeight;
						if (!double.IsNaN(cellMinHeight))
						{
							return cellMinHeight;
						}
					}
				}
				return 0.0;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002E86C File Offset: 0x0002CA6C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public double CellMinWidthResolved
		{
			get
			{
				if (this._settings != null)
				{
					double cellMinWidth = this._settings.CellMinWidth;
					if (!double.IsNaN(cellMinWidth))
					{
						return cellMinWidth;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double cellMinWidth = owner.FieldSettings.CellMinWidth;
						if (!double.IsNaN(cellMinWidth))
						{
							return cellMinWidth;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double cellMinWidth = dataPresenter.FieldSettings.CellMinWidth;
						if (!double.IsNaN(cellMinWidth))
						{
							return cellMinWidth;
						}
					}
				}
				return 0.0;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002E8FC File Offset: 0x0002CAFC
		private static void OnCellValuePresenterStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._cachedCellValuePresenterStyle = (e.NewValue as global::System.Windows.Style);
			global::Infragistics.Windows.DataPresenter.Field.ProcessResolvedFieldPropertyChanged(field, e);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002E929 File Offset: 0x0002CB29
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002E931 File Offset: 0x0002CB31
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CellValuePresenterStyle
		{
			get
			{
				return this._cachedCellValuePresenterStyle;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.CellValuePresenterStyleProperty, value);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002E940 File Offset: 0x0002CB40
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double CellWidthResolved
		{
			get
			{
				if (this._owner != null)
				{
					global::System.Windows.Size templateItemSize = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetTemplateItemSize(this, false);
					double cellMaxWidthResolved = this.CellMaxWidthResolved;
					if (!double.IsNaN(cellMaxWidthResolved) && templateItemSize.Width > cellMaxWidthResolved)
					{
						templateItemSize.Width = cellMaxWidthResolved;
					}
					return templateItemSize.Width;
				}
				return this.CellWidthResolvedInternal;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002E98C File Offset: 0x0002CB8C
		internal double CellWidthResolvedInternal
		{
			get
			{
				double num = this.GetCellWidthResolvedHelper(false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				if (this._cellPosition.ColumnSpan > 1)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				bool flag = true;
				if (owner != null)
				{
					flag = (owner.IsHorizontal && owner.IsDataRecordSizedToContent);
				}
				if (flag)
				{
					return double.NaN;
				}
				num = this.GetLabelWidthResolvedHelper(false, false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				return this.DefaultCellWidth;
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002EA08 File Offset: 0x0002CC08
		internal double GetCellWidthResolvedHelper(bool provideDefault)
		{
			global::Infragistics.Windows.DataPresenter.FieldSize resizeSize = this.GetResizeSize(false, true);
			if (resizeSize.HasExplicitSize)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase view = global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(this);
				global::System.Windows.Controls.Orientation orientation = (view != null) ? view.LogicalOrientation : global::System.Windows.Controls.Orientation.Vertical;
				if (global::System.Windows.Controls.Orientation.Vertical == orientation || (this._owner != null && this._owner.DataRecordSizingModeResolved == global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized))
				{
					return resizeSize.Value;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = this.GetWidthOrHeight(true);
			if (widthOrHeight.IsAbsolute)
			{
				return widthOrHeight.Value;
			}
			if (widthOrHeight.IsAnyAuto && resizeSize.HasAutoModeSize)
			{
				return resizeSize.Value;
			}
			if (this._settings != null)
			{
				double cellWidth = this._settings.CellWidth;
				if (!double.IsNaN(cellWidth))
				{
					return cellWidth;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				if (owner.HasFieldSettings)
				{
					double cellWidth = owner.FieldSettings.CellWidth;
					if (!double.IsNaN(cellWidth))
					{
						return cellWidth;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter != null && dataPresenter.HasFieldSettings)
				{
					double cellWidth = dataPresenter.FieldSettings.CellWidth;
					if (!double.IsNaN(cellWidth))
					{
						return cellWidth;
					}
				}
			}
			if (provideDefault)
			{
				return this.DefaultCellWidth;
			}
			return double.NaN;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002EB30 File Offset: 0x0002CD30
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool CollapseWhenEmptyResolved
		{
			get
			{
				return this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldSettings.CollapseWhenEmptyProperty, null, new bool?(true)).Value;
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002EB5F File Offset: 0x0002CD5F
		private static bool OnValidateRowColumnSetting(object value)
		{
			return (int)value >= 0;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002EB70 File Offset: 0x0002CD70
		private static void OnRowOrColumnChange(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null && field._owner != null && field._owner.DataPresenter != null && field.VisibilityResolved != global::System.Windows.Visibility.Collapsed)
			{
				field._owner.PostDelayedInvalidation(true);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002EBB1 File Offset: 0x0002CDB1
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0002EBC3 File Offset: 0x0002CDC3
		[global::System.ComponentModel.Bindable(true)]
		public int Column
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.ColumnProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ColumnProperty, value);
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002EBD6 File Offset: 0x0002CDD6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeColumn()
		{
			return this.Column > 0;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002EBE1 File Offset: 0x0002CDE1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetColumn()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.ColumnProperty);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002EBEE File Offset: 0x0002CDEE
		private static object OnCoerceRowColumnSpan(global::System.Windows.DependencyObject target, object value)
		{
			if ((int)value >= 1)
			{
				return value;
			}
			return 1;
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0002EC01 File Offset: 0x0002CE01
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0002EC13 File Offset: 0x0002CE13
		[global::System.ComponentModel.Bindable(true)]
		public int ColumnSpan
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.ColumnSpanProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ColumnSpanProperty, value);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002EC26 File Offset: 0x0002CE26
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeColumnSpan()
		{
			return this.ColumnSpan >= 0;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002EC34 File Offset: 0x0002CE34
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetColumnSpan()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.ColumnSpanProperty);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002EC44 File Offset: 0x0002CE44
		private static void OnConverterChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				field._converter = (e.NewValue as global::System.Windows.Data.IValueConverter);
				if (field.DataPresenter != null)
				{
					field._owner.OnFieldConverterChanged(field);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002EC81 File Offset: 0x0002CE81
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0002EC89 File Offset: 0x0002CE89
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Data.IValueConverter Converter
		{
			get
			{
				return this._converter;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ConverterProperty, value);
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002EC98 File Offset: 0x0002CE98
		private static void OnConverterCultureChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				field._converterCulture = (e.NewValue as global::System.Globalization.CultureInfo);
				field._cachedCellTextConverterInfo = null;
				if (field.DataPresenter != null)
				{
					global::System.Globalization.CultureInfo converterCultureResolved = field.ConverterCultureResolved;
					field._owner.OnFieldConverterChanged(field);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002ECE3 File Offset: 0x0002CEE3
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0002ECEB File Offset: 0x0002CEEB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CultureInfoIetfLanguageTagConverter))]
		public global::System.Globalization.CultureInfo ConverterCulture
		{
			get
			{
				return this._converterCulture;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ConverterCultureProperty, value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0002ECFC File Offset: 0x0002CEFC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Globalization.CultureInfo ConverterCultureResolved
		{
			get
			{
				global::System.Globalization.CultureInfo converterCultureResolvedImpl = this.ConverterCultureResolvedImpl;
				if (converterCultureResolvedImpl != this._converterCultureResolved)
				{
					global::System.Globalization.CultureInfo converterCultureResolved = this._converterCultureResolved;
					this._converterCultureResolved = converterCultureResolvedImpl;
					if (converterCultureResolved != null)
					{
						base.RaisePropertyChangedEvent("ConverterCultureResolved");
					}
				}
				return this._converterCultureResolved;
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		private static void OnConverterParameterChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				field._converterParameter = e.NewValue;
				if (field.DataPresenter != null)
				{
					field._owner.OnFieldConverterChanged(field);
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0002ED74 File Offset: 0x0002CF74
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::System.ComponentModel.Bindable(true)]
		public object ConverterParameter
		{
			get
			{
				return this._converterParameter;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ConverterParameterProperty, value);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002ED8C File Offset: 0x0002CF8C
		private static void OnDataContextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field._settings != null && field._settings.HasFieldBinding)
			{
				field._settings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.DataContextProperty, e.NewValue);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0002EDD9 File Offset: 0x0002CFD9
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object DataContext
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.Field.DataContextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.DataContextProperty, value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		public global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger DataItemUpdateTriggerResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger dataItemUpdateTrigger = this._settings.DataItemUpdateTrigger;
					if (dataItemUpdateTrigger != global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.Default)
					{
						return dataItemUpdateTrigger;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger dataItemUpdateTrigger = fieldSettings.DataItemUpdateTrigger;
						if (dataItemUpdateTrigger != global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.Default)
						{
							return dataItemUpdateTrigger;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger dataItemUpdateTrigger = fieldSettings.DataItemUpdateTrigger;
						if (dataItemUpdateTrigger != global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.Default)
						{
							return dataItemUpdateTrigger;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.DataItemUpdateTrigger.OnLeaveCell;
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002EE5C File Offset: 0x0002D05C
		private static bool OnValidateDataType(object value)
		{
			global::System.Type right = value as global::System.Type;
			return null != right;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002EE77 File Offset: 0x0002D077
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0002EE7F File Offset: 0x0002D07F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Type DataType
		{
			get
			{
				return this._cachedDataType;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty, value);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002EE90 File Offset: 0x0002D090
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDataType()
		{
			object defaultValue = global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty.GetMetadata(this).DefaultValue;
			return this._dataTypeExplicitySet && this._cachedDataType != defaultValue as global::System.Type;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0002EECC File Offset: 0x0002D0CC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int DataValueChangedHistoryLimitResolved
		{
			get
			{
				if (this._cachedDataValueChangedHistoryLimitResolved == null)
				{
					this._cachedDataValueChangedHistoryLimitResolved = this.GetResolvedValue<int?>(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedHistoryLimitProperty, null, new int?(1));
				}
				return this._cachedDataValueChangedHistoryLimitResolved.Value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002EF14 File Offset: 0x0002D114
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool DataValueChangedNotificationsActiveResolved
		{
			get
			{
				if (this._cachedDataValueChangedNotificationsActiveResolved == null)
				{
					this._cachedDataValueChangedNotificationsActiveResolved = this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedNotificationsActiveProperty, null, new bool?(false));
				}
				return this._cachedDataValueChangedNotificationsActiveResolved.Value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002EF59 File Offset: 0x0002D159
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataValueChangedScope DataValueChangedScopeResolved
		{
			get
			{
				if (this._cachedDataValueChangedScopeResolved == null)
				{
					this._cachedDataValueChangedScopeResolved = new global::Infragistics.Windows.DataPresenter.DataValueChangedScope?(this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.DataValueChangedScope>(global::Infragistics.Windows.DataPresenter.FieldSettings.DataValueChangedScopeProperty, global::Infragistics.Windows.DataPresenter.DataValueChangedScope.Default, global::Infragistics.Windows.DataPresenter.DataValueChangedScope.OnlyRecordsInView));
				}
				return this._cachedDataValueChangedScopeResolved.Value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002EF8B File Offset: 0x0002D18B
		protected virtual global::System.Type DefaultEditorType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0002EF8E File Offset: 0x0002D18E
		protected virtual global::System.Type DefaultEditAsType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002EF91 File Offset: 0x0002D191
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0002EFA3 File Offset: 0x0002D1A3
		[global::System.ComponentModel.Bindable(true)]
		public bool DisallowModificationViaClipboard
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.DisallowModificationViaClipboardProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.DisallowModificationViaClipboardProperty, value);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002EFB6 File Offset: 0x0002D1B6
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Description")]
		public global::System.Windows.Style EditorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.EditorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.EditorStyleProperty, value);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002EFD6 File Offset: 0x0002D1D6
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		[global::System.ComponentModel.Description("Description")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Type EditorType
		{
			get
			{
				return (global::System.Type)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.EditorTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.EditorTypeProperty, value);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Type EditorTypeResolved
		{
			get
			{
				global::System.Type type = this.EditorType;
				if (type != null)
				{
					return type;
				}
				if (this._settings != null)
				{
					type = this._settings.EditorType;
				}
				if (type != null)
				{
					return type;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						type = this._owner.FieldSettings.EditorType;
					}
					if (type != null)
					{
						return type;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						type = dataPresenter.FieldSettings.EditorType;
					}
					if (type != null)
					{
						return type;
					}
				}
				type = this.DefaultEditorType;
				if (type != null)
				{
					return type;
				}
				global::System.Type editAsTypeResolved = this.EditAsTypeResolved;
				if (editAsTypeResolved == null)
				{
					return null;
				}
				return global::Infragistics.Windows.Editors.ValueEditor.GetDefaultEditorForType(editAsTypeResolved);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002F0C1 File Offset: 0x0002D2C1
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0002F0D3 File Offset: 0x0002D2D3
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Description")]
		public global::System.Type EditAsType
		{
			get
			{
				return (global::System.Type)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.EditAsTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.EditAsTypeProperty, value);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0002F0E1 File Offset: 0x0002D2E1
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Type EditAsTypeResolved
		{
			get
			{
				if (this._cachedEditAsTypeResolved == null)
				{
					this._cachedEditAsTypeResolved = this.GetEditAsTypeResolvedInternal();
				}
				return this._cachedEditAsTypeResolved;
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002F104 File Offset: 0x0002D304
		private global::System.Type GetEditAsTypeResolvedInternal()
		{
			global::System.Type type = this.EditAsType;
			if (type != null)
			{
				return type;
			}
			if (this._settings != null)
			{
				type = this._settings.EditAsType;
			}
			if (null == type && this._owner != null)
			{
				if (this._owner.HasFieldSettings)
				{
					type = this._owner.FieldSettings.EditAsType;
				}
				if (null == type)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						type = dataPresenter.FieldSettings.EditAsType;
					}
				}
			}
			if (type == null)
			{
				type = this.DefaultEditAsType;
			}
			if (type != null)
			{
				return type;
			}
			if (null == type)
			{
				type = this.DataType;
			}
			if (null == type)
			{
				type = typeof(string);
			}
			return type;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
		public global::System.Windows.Visibility CellVisibilityWhenGroupedResolved
		{
			get
			{
				if (this._ignoreFieldVisibilityOverrides)
				{
					return global::System.Windows.Visibility.Visible;
				}
				global::System.Windows.Visibility? visibility = null;
				if (this._settings != null)
				{
					visibility = this._settings.CellVisibilityWhenGrouped;
				}
				if (visibility == null && this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						visibility = this._owner.FieldSettings.CellVisibilityWhenGrouped;
					}
					if (visibility == null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
						if (dataPresenter != null && dataPresenter.HasFieldSettings)
						{
							visibility = dataPresenter.FieldSettings.CellVisibilityWhenGrouped;
						}
					}
				}
				global::System.Windows.Visibility? visibility2 = visibility;
				if (visibility2 == null)
				{
					return global::System.Windows.Visibility.Visible;
				}
				return visibility2.GetValueOrDefault();
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002F276 File Offset: 0x0002D476
		public global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate EditModeBehaviorOnDataUpdateResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate>(global::Infragistics.Windows.DataPresenter.FieldSettings.EditModeBehaviorOnDataUpdateProperty, global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate.Default, global::Infragistics.Windows.DataPresenter.EditModeBehaviorOnDataUpdate.UpdateEditValue);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0002F285 File Offset: 0x0002D485
		public global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator ExcelStyleFilterSearchOperatorResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator>(global::Infragistics.Windows.DataPresenter.FieldSettings.ExcelStyleFilterSearchOperatorProperty, global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator.Default, global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator.Like);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002F294 File Offset: 0x0002D494
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode ExpandableFieldRecordExpansionModeResolved
		{
			get
			{
				if (this._owner != null && this._owner.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.ExpandAlways;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode expandableFieldRecordExpansionMode = global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default;
				if (this._settings != null)
				{
					expandableFieldRecordExpansionMode = this._settings.ExpandableFieldRecordExpansionMode;
				}
				if (expandableFieldRecordExpansionMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.Default)
				{
					return expandableFieldRecordExpansionMode;
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultExpandableFieldRecordExpansionMode(this);
				}
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.ShowExpansionIndicatorIfSiblingsExist;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode ExpandableFieldRecordHeaderDisplayModeResolved
		{
			get
			{
				if (this._owner != null && this._owner.IsTreeView)
				{
					return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.NeverDisplayHeader;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode expandableFieldRecordHeaderDisplayMode = global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default;
				if (this._settings != null)
				{
					expandableFieldRecordHeaderDisplayMode = this._settings.ExpandableFieldRecordHeaderDisplayMode;
				}
				if (expandableFieldRecordHeaderDisplayMode != global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.Default)
				{
					return expandableFieldRecordHeaderDisplayMode;
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultExpandableFieldRecordHeaderDisplayMode(this);
				}
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.AlwaysDisplayHeader;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002F344 File Offset: 0x0002D544
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Style FilterCellEditorStyleResolved
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None == this.FilterOperandUITypeResolved)
				{
					return null;
				}
				global::System.Windows.Style style = null;
				if (this._settings != null)
				{
					style = this._settings.FilterCellEditorStyle;
				}
				if (style != null)
				{
					return style;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						style = this._owner.FieldSettings.FilterCellEditorStyle;
					}
					if (style != null)
					{
						return style;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						style = dataPresenter.FieldSettings.FilterCellEditorStyle;
					}
					if (style != null)
					{
						return style;
					}
				}
				if (this.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
				{
					return this.EditorStyleResolved;
				}
				return null;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002F3DC File Offset: 0x0002D5DC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style FilterCellValuePresenterStyleResolved
		{
			get
			{
				global::System.Windows.Style style = null;
				if (this._settings != null)
				{
					style = this._settings.FilterCellValuePresenterStyle;
				}
				if (style != null)
				{
					return style;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						style = this._owner.FieldSettings.FilterCellValuePresenterStyle;
					}
					if (style != null)
					{
						return style;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						style = dataPresenter.FieldSettings.FilterCellValuePresenterStyle;
					}
					if (style != null)
					{
						return style;
					}
				}
				return null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002F458 File Offset: 0x0002D658
		public global::System.Windows.Visibility FilterClearButtonVisibilityResolved
		{
			get
			{
				global::System.Windows.Visibility? visibility = null;
				if (this._settings != null)
				{
					visibility = this._settings.FilterClearButtonVisibility;
					if (visibility != null)
					{
						return visibility.Value;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						visibility = fieldSettings.FilterClearButtonVisibility;
						if (visibility != null)
						{
							return visibility.Value;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						visibility = fieldSettings.FilterClearButtonVisibility;
						if (visibility != null)
						{
							return visibility.Value;
						}
					}
					global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation filterClearButtonLocationResolved = this._owner.FilterClearButtonLocationResolved;
					visibility = new global::System.Windows.Visibility?((global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.FilterCell == filterClearButtonLocationResolved || global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.RecordSelectorAndFilterCell == filterClearButtonLocationResolved) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
				}
				if (visibility == null)
				{
					return global::System.Windows.Visibility.Visible;
				}
				return visibility.Value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0002F528 File Offset: 0x0002D728
		public int FilterConditionOptimizationThresholdResolved
		{
			get
			{
				return this.GetResolvedValue<int?>(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterConditionOptimizationThresholdProperty, null, new int?(3)).Value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002F558 File Offset: 0x0002D758
		public global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger FilterEvaluationTriggerResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger filterEvaluationTrigger = this._settings.FilterEvaluationTrigger;
					if (filterEvaluationTrigger != global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.Default)
					{
						return filterEvaluationTrigger;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger filterEvaluationTrigger = fieldSettings.FilterEvaluationTrigger;
						if (filterEvaluationTrigger != global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.Default)
						{
							return filterEvaluationTrigger;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger filterEvaluationTrigger = fieldSettings.FilterEvaluationTrigger;
						if (filterEvaluationTrigger != global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.Default)
						{
							return filterEvaluationTrigger;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnCellValueChange;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		public global::Infragistics.Windows.DataPresenter.FilterOperandUIType FilterOperandUITypeResolved
		{
			get
			{
				if (!this.AllowRecordFilteringResolved)
				{
					return global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None;
				}
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FilterOperandUIType filterOperandUIType = this._settings.FilterOperandUIType;
					if (filterOperandUIType != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Default)
					{
						return filterOperandUIType;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FilterOperandUIType filterOperandUIType = fieldSettings.FilterOperandUIType;
						if (filterOperandUIType != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Default)
						{
							return filterOperandUIType;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FilterOperandUIType filterOperandUIType = fieldSettings.FilterOperandUIType;
						if (filterOperandUIType != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Default)
						{
							return filterOperandUIType;
						}
					}
				}
				this.VerifyRecordFilterRelatedCache();
				return this._cachedDefaultFilterOperandUIType;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002F654 File Offset: 0x0002D854
		public global::Infragistics.Windows.Controls.ComparisonOperator FilterOperatorDefaultValueResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.ComparisonOperator? filterOperatorDefaultValue = this._settings.FilterOperatorDefaultValue;
					if (filterOperatorDefaultValue != null)
					{
						return filterOperatorDefaultValue.Value;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.Controls.ComparisonOperator? filterOperatorDefaultValue = fieldSettings.FilterOperatorDefaultValue;
						if (filterOperatorDefaultValue != null)
						{
							return filterOperatorDefaultValue.Value;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.Controls.ComparisonOperator? filterOperatorDefaultValue = fieldSettings.FilterOperatorDefaultValue;
						if (filterOperatorDefaultValue != null)
						{
							return filterOperatorDefaultValue.Value;
						}
					}
				}
				this.VerifyRecordFilterRelatedCache();
				return this._cachedDefaultFilterOperatorDefaultValue;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0002F6F8 File Offset: 0x0002D8F8
		public global::Infragistics.Windows.Controls.ComparisonOperatorFlags FilterOperatorDropDownItemsResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.Controls.ComparisonOperatorFlags? filterOperatorDropDownItems = this._settings.FilterOperatorDropDownItems;
					if (filterOperatorDropDownItems != null)
					{
						return filterOperatorDropDownItems.Value;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.Controls.ComparisonOperatorFlags? filterOperatorDropDownItems = fieldSettings.FilterOperatorDropDownItems;
						if (filterOperatorDropDownItems != null)
						{
							return filterOperatorDropDownItems.Value;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.Controls.ComparisonOperatorFlags? filterOperatorDropDownItems = fieldSettings.FilterOperatorDropDownItems;
						if (filterOperatorDropDownItems != null)
						{
							return filterOperatorDropDownItems.Value;
						}
					}
				}
				this.VerifyRecordFilterRelatedCache();
				return this._cachedDefaultFilterOperatorDropDownItems;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002F799 File Offset: 0x0002D999
		public global::System.Windows.Visibility FilterOperatorVisibilityResolved
		{
			get
			{
				this.VerifyRecordFilterRelatedCache();
				return this._cachedDefaultFilterOperatorVisibility;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		public global::Infragistics.Windows.DataPresenter.FieldSortComparisonType FilterStringComparisonTypeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortComparisonType filterStringComparisonType = this._settings.FilterStringComparisonType;
					if (filterStringComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
					{
						return filterStringComparisonType;
					}
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldSortComparisonType filterStringComparisonType = fieldSettings.FilterStringComparisonType;
						if (filterStringComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
						{
							return filterStringComparisonType;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
					if (fieldSettings != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldSortComparisonType filterStringComparisonType = fieldSettings.FilterStringComparisonType;
						if (filterStringComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
						{
							return filterStringComparisonType;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002F81A File Offset: 0x0002DA1A
		public global::System.Collections.IComparer FilterComparerResolved
		{
			get
			{
				return this.GetResolvedValue<global::System.Collections.IComparer>(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterComparerProperty, null, null);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0002F829 File Offset: 0x0002DA29
		public global::Infragistics.Windows.Controls.IFilterEvaluator FilterEvaluatorResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.Controls.IFilterEvaluator>(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterEvaluatorProperty, null, null);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002F838 File Offset: 0x0002DA38
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility FixedButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityProperty);
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002F84C File Offset: 0x0002DA4C
		private static object CoerceFixedLocation(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.Field field = d as global::Infragistics.Windows.DataPresenter.Field;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
			if (field.IsFieldMapped)
			{
				return field._mappedTreeField.FixedLocation;
			}
			field._actualFixedLocation = (global::Infragistics.Windows.DataPresenter.FixedFieldLocation)newValue;
			if (dataPresenter != null && !dataPresenter.IsFixedFieldsSupportedResolved)
			{
				return global::Infragistics.Windows.DataPresenter.Field.FixedFieldLocationScrollable;
			}
			return newValue;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002F89E File Offset: 0x0002DA9E
		internal global::Infragistics.Windows.DataPresenter.FixedFieldLocation ActualFixedLocation
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField._actualFixedLocation;
				}
				return this._actualFixedLocation;
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002F8BC File Offset: 0x0002DABC
		private static void OnFixedLocationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)dependencyObject;
			field._cachedFixedLocation = (global::Infragistics.Windows.DataPresenter.FixedFieldLocation)e.NewValue;
			if (field.ReadLocalValue(e.Property) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				field._actualFixedLocation = (global::Infragistics.Windows.DataPresenter.FixedFieldLocation)e.Property.GetMetadata(field).DefaultValue;
			}
			field.VerifyFixedState();
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field._owner;
			if (owner != null)
			{
				owner.DirtyFixedState();
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter != null && !dataPresenter.IsApplyingCustomizations)
				{
					if (!owner.IsInFieldInitialization)
					{
						owner.ShouldCreateDragFieldLayout = true;
					}
					if (!field.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.SuppressFixedLocationInvalidate))
					{
						owner.InvalidateGeneratedStylesAsnyc(false, false);
					}
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002F95C File Offset: 0x0002DB5C
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0002F978 File Offset: 0x0002DB78
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.FixedLocation;
				}
				return this._cachedFixedLocation;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty, value);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002F98B File Offset: 0x0002DB8B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedLocation()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty, this);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002F998 File Offset: 0x0002DB98
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedLocation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002F9A5 File Offset: 0x0002DBA5
		private static void OnFormatChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Format, e.NewValue);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0002F9BB File Offset: 0x0002DBBB
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0002F9CD File Offset: 0x0002DBCD
		public string Format
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.FormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FormatProperty, value);
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002F9DB File Offset: 0x0002DBDB
		private static void OnFormatProviderChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.FormatProvider, e.NewValue);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002F9F1 File Offset: 0x0002DBF1
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0002FA03 File Offset: 0x0002DC03
		public global::System.IFormatProvider FormatProvider
		{
			get
			{
				return (global::System.IFormatProvider)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.FormatProviderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FormatProviderProperty, value);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002FA14 File Offset: 0x0002DC14
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.IComparer GroupByComparerResolved
		{
			get
			{
				global::System.Collections.IComparer comparer = null;
				if (this._settings != null)
				{
					comparer = this._settings.GroupByComparer;
				}
				if (comparer != null)
				{
					return comparer;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						comparer = this._owner.FieldSettings.GroupByComparer;
						if (comparer != null)
						{
							return comparer;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						comparer = dataPresenter.FieldSettings.GroupByComparer;
						if (comparer != null)
						{
							return comparer;
						}
					}
				}
				return null;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002FA90 File Offset: 0x0002DC90
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.IGroupByEvaluator GroupByEvaluatorResolved
		{
			get
			{
				if (this._cachedGroupByEvaluator == null)
				{
					this._cachedGroupByEvaluator = this.InternalGroupByEvaluatorResolved;
				}
				return this._cachedGroupByEvaluator;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002FAAC File Offset: 0x0002DCAC
		private global::Infragistics.Windows.DataPresenter.IGroupByEvaluator InternalGroupByEvaluatorResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluator = null;
				if (this._settings != null)
				{
					groupByEvaluator = this._settings.GroupByEvaluator;
				}
				if (groupByEvaluator != null)
				{
					return groupByEvaluator;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						groupByEvaluator = this._owner.FieldSettings.GroupByEvaluator;
						if (groupByEvaluator != null)
						{
							return groupByEvaluator;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						groupByEvaluator = dataPresenter.FieldSettings.GroupByEvaluator;
						if (groupByEvaluator != null)
						{
							return groupByEvaluator;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CreateEvaluator(this);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002FB2D File Offset: 0x0002DD2D
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0002FB3F File Offset: 0x0002DD3F
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldGroupByMode GroupByMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldGroupByMode)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.GroupByModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.GroupByModeProperty, value);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002FB54 File Offset: 0x0002DD54
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.FieldGroupByMode GroupByModeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldGroupByMode groupByMode = this.GroupByMode;
				if (groupByMode != global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default)
				{
					return groupByMode;
				}
				if (this._settings != null)
				{
					groupByMode = this._settings.GroupByMode;
				}
				if (groupByMode != global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default)
				{
					return groupByMode;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						groupByMode = this._owner.FieldSettings.GroupByMode;
						if (groupByMode != global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default)
						{
							return groupByMode;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						groupByMode = dataPresenter.FieldSettings.GroupByMode;
						if (groupByMode != global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Default)
						{
							return groupByMode;
						}
					}
				}
				global::System.Type editAsTypeResolvedUnderlying = this.EditAsTypeResolvedUnderlying;
				if (editAsTypeResolvedUnderlying == typeof(string))
				{
					return global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Text;
				}
				if (editAsTypeResolvedUnderlying == typeof(global::System.DateTime))
				{
					return global::Infragistics.Windows.DataPresenter.FieldGroupByMode.OutlookDate;
				}
				return global::Infragistics.Windows.DataPresenter.FieldGroupByMode.Value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Style GroupByRecordPresenterStyleResolved
		{
			get
			{
				global::System.Windows.Style style = null;
				if (this._settings != null)
				{
					style = this._settings.GroupByRecordPresenterStyle;
				}
				if (style != null)
				{
					return style;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						style = this._owner.FieldSettings.GroupByRecordPresenterStyle;
					}
					if (style != null)
					{
						return style;
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						style = dataPresenter.FieldSettings.GroupByRecordPresenterStyle;
					}
					if (style != null)
					{
						return style;
					}
				}
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002FC88 File Offset: 0x0002DE88
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasLabel
		{
			get
			{
				return this._cachedLabel != null && (!(this._cachedLabel is string) || ((string)this._cachedLabel).Length > 0);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002FCB6 File Offset: 0x0002DEB6
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasSettings
		{
			get
			{
				return this._settings != null;
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002FCC4 File Offset: 0x0002DEC4
		private static void OnWidthHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)d;
			bool flag = e.Property == global::Infragistics.Windows.DataPresenter.Field.HeightProperty;
			if (flag)
			{
				field._cachedHeight = null;
			}
			else
			{
				field._cachedWidth = null;
			}
			if (field._explicitResizeInfo != null)
			{
				field._explicitResizeInfo.ClearExplicit(true, !flag);
				field._explicitResizeInfo.ClearExplicit(false, !flag);
			}
			if (field._owner != null)
			{
				field._owner.OnFieldWidthHeightChanged();
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002FD3F File Offset: 0x0002DF3F
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0002FD51 File Offset: 0x0002DF51
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

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0002FD64 File Offset: 0x0002DF64
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.HorizontalContentAlignment, e.NewValue);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002FD7A File Offset: 0x0002DF7A
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002FD8C File Offset: 0x0002DF8C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.HorizontalAlignment>))]
		public global::System.Windows.HorizontalAlignment? HorizontalContentAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.HorizontalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.HorizontalContentAlignmentProperty, value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
		[global::System.ComponentModel.ReadOnly(true)]
		public int Index
		{
			get
			{
				if (this._owner == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._owner.Fields;
				int index = this._index;
				if (index < 0 || index >= fields.Count || fields[index] != this)
				{
					this._index = -1;
					int i = 0;
					int count = fields.Count;
					while (i < count)
					{
						fields[i]._index = i;
						i++;
					}
					index = this._index;
				}
				return index;
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002FE10 File Offset: 0x0002E010
		private static void OnInvalidValueBehaviorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.InvalidValueBehavior, e.NewValue);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002FE26 File Offset: 0x0002E026
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0002FE38 File Offset: 0x0002E038
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.InvalidValueBehavior>))]
		public global::Infragistics.Windows.Editors.InvalidValueBehavior? InvalidValueBehavior
		{
			get
			{
				return (global::Infragistics.Windows.Editors.InvalidValueBehavior?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.InvalidValueBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.InvalidValueBehaviorProperty, value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002FE4C File Offset: 0x0002E04C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehaviorResolved
		{
			get
			{
				global::Infragistics.Windows.Editors.InvalidValueBehavior invalidValueBehavior = global::Infragistics.Windows.Editors.InvalidValueBehavior.Default;
				if (this.GetIsEditorPropSet(4194304L))
				{
					global::Infragistics.Windows.Editors.InvalidValueBehavior? invalidValueBehavior2 = this.InvalidValueBehavior;
					if (invalidValueBehavior2 != null && invalidValueBehavior2.Value != global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
					{
						return invalidValueBehavior2.Value;
					}
				}
				if (this._settings != null)
				{
					invalidValueBehavior = this._settings.InvalidValueBehavior;
				}
				if (invalidValueBehavior != global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
				{
					return invalidValueBehavior;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						invalidValueBehavior = this._owner.FieldSettings.InvalidValueBehavior;
						if (invalidValueBehavior != global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
						{
							return invalidValueBehavior;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						invalidValueBehavior = dataPresenter.FieldSettings.InvalidValueBehavior;
						if (invalidValueBehavior != global::Infragistics.Windows.Editors.InvalidValueBehavior.Default)
						{
							return invalidValueBehavior;
						}
					}
				}
				return global::Infragistics.Windows.Editors.InvalidValueBehavior.Default;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002FEF7 File Offset: 0x0002E0F7
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0002FF09 File Offset: 0x0002E109
		[global::System.ComponentModel.Bindable(true)]
		public bool IsEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsEnabledProperty, value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002FF1C File Offset: 0x0002E11C
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0002FF2E File Offset: 0x0002E12E
		[global::System.ComponentModel.Bindable(true)]
		public bool IsEnabledInAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsEnabledInAddRecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsEnabledInAddRecordProperty, value);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002FF41 File Offset: 0x0002E141
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0002FF53 File Offset: 0x0002E153
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsExpandable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsExpandableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsExpandableProperty, value);
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002FF68 File Offset: 0x0002E168
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsExpandable()
		{
			return this.IsExpandable != null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002FF83 File Offset: 0x0002E183
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsExpandable()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.IsExpandableProperty);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002FF90 File Offset: 0x0002E190
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsExpandableResolved
		{
			get
			{
				if (this._cachedIsExpandable != null)
				{
					return this._cachedIsExpandable.Value;
				}
				global::System.Type type = base.GetType();
				return (type == typeof(global::Infragistics.Windows.DataPresenter.Field) || type == typeof(global::Infragistics.Windows.DataPresenter.UnboundField)) && this._isExpandableByDefault;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0002FFE9 File Offset: 0x0002E1E9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedProperty);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002FFFB File Offset: 0x0002E1FB
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixedStateChanging
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingProperty);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0003000D File Offset: 0x0002E20D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsGroupBy
		{
			get
			{
				return this._isGroupBy;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00030015 File Offset: 0x0002E215
		public virtual bool IsPlaceholderForTreeView
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00030018 File Offset: 0x0002E218
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00030038 File Offset: 0x0002E238
		[global::System.ComponentModel.Bindable(true)]
		public bool IsPrimary
		{
			get
			{
				if (this._owner != null)
				{
					return this == this._owner.PrimaryField;
				}
				return this._isPrimary;
			}
			set
			{
				this._isPrimary = value;
				this._cachedCellContentAlignmentResolved = null;
				if (this._owner != null)
				{
					if (value)
					{
						if (!this._owner.Fields.Contains(this))
						{
							throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_15"));
						}
						this._owner.PrimaryField = this;
						return;
					}
					else if (this._owner.PrimaryField == this)
					{
						this._owner.PrimaryField = null;
					}
				}
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000300AD File Offset: 0x0002E2AD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsPrimary()
		{
			return this._isPrimary;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000300B5 File Offset: 0x0002E2B5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsPrimaryField()
		{
			this.IsPrimary = false;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000300BE File Offset: 0x0002E2BE
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsReadOnly, e.NewValue);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000300D4 File Offset: 0x0002E2D4
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x000300E6 File Offset: 0x0002E2E6
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsReadOnly
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x000300F9 File Offset: 0x0002E2F9
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00030118 File Offset: 0x0002E318
		[global::System.ComponentModel.Bindable(true)]
		public bool IsScrollTipField
		{
			get
			{
				if (this._owner != null)
				{
					return this == this._owner.ScrollTipField;
				}
				return this._isScrollTip;
			}
			set
			{
				this._isScrollTip = value;
				if (this._owner != null)
				{
					if (value)
					{
						if (!this._owner.Fields.Contains(this))
						{
							throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_16"));
						}
						this._owner.ScrollTipField = this;
						return;
					}
					else if (this._owner.ScrollTipField == this)
					{
						this._owner.ScrollTipField = null;
					}
				}
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00030181 File Offset: 0x0002E381
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsScrollTipField()
		{
			return this._isScrollTip;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00030189 File Offset: 0x0002E389
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsScrollTipFieldField()
		{
			this.IsScrollTipField = false;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00030194 File Offset: 0x0002E394
		private static object OnCoerceIsSelected(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null && value is bool)
			{
				if (field._selected == (bool)value)
				{
					return field._selected;
				}
				if (field.Owner == null)
				{
					return value;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.Owner.DataPresenter;
				if (dataPresenter != null)
				{
					bool clearExistingSelection = true;
					global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = field.Owner.GetSelectionStrategyForItem(field);
					if (selectionStrategyForItem != null)
					{
						clearExistingSelection = selectionStrategyForItem.IsSingleSelect;
					}
					bool flag = dataPresenter.InternalSelectItem(field, clearExistingSelection, (bool)value);
					if (flag && dataPresenter.SelectedItems.Fields.Count == 1)
					{
						((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).SetPivotItem(field, false);
					}
					return field._selected;
				}
			}
			return false;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00030246 File Offset: 0x0002E446
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0003024E File Offset: 0x0002E44E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsSelected
		{
			get
			{
				return this._selected;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00030261 File Offset: 0x0002E461
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00030273 File Offset: 0x0002E473
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTabStop
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsTabStopProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsTabStopProperty, value);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00030286 File Offset: 0x0002E486
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00030298 File Offset: 0x0002E498
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTabStopInAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.IsTabStopInAddRecordProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsTabStopInAddRecordProperty, value);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000302AC File Offset: 0x0002E4AC
		private static void OnIsTreeFieldChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._cachedIsTreeField = (bool)e.NewValue;
			if (field._cachedIsTreeField)
			{
				field._wasEverTreeField = true;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000302E1 File Offset: 0x0002E4E1
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000302E9 File Offset: 0x0002E4E9
		public bool IsTreeField
		{
			get
			{
				return this._cachedIsTreeField;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsTreeFieldPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000302FC File Offset: 0x0002E4FC
		[global::System.Obsolete("Use BindingType instead", false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public virtual bool IsUnbound
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00030300 File Offset: 0x0002E500
		private static object CoerceLabel(global::System.Windows.DependencyObject target, object value)
		{
			if (value != global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance)
			{
				return value;
			}
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null && field._defaultLabel != global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance)
			{
				return field._defaultLabel;
			}
			return null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00030338 File Offset: 0x0002E538
		private static void OnLabelChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)dependencyObject;
			object newValue = e.NewValue;
			if (newValue == global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance)
			{
				if (field._defaultLabel == global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance)
				{
					field._defaultLabel = null;
				}
				else
				{
					field._cachedLabel = field._defaultLabel;
				}
				field.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty);
			}
			else
			{
				field._cachedLabel = newValue;
			}
			if (field.IsPlaceholderForTreeView)
			{
				return;
			}
			int lineCount = global::Infragistics.Windows.Utilities.GetLineCount(field._cachedLabel as string);
			if (field._owner != null)
			{
				field._owner.OnLabelChanged();
				if (lineCount != field._labelLineCount)
				{
					field._owner.InternalVersion++;
				}
				field._owner.AutoSizeInfo.OnLabelChanged(field);
			}
			field._labelLineCount = lineCount;
			field.BumpLayoutItemVersion();
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000303F9 File Offset: 0x0002E5F9
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00030401 File Offset: 0x0002E601
		[global::System.ComponentModel.Bindable(true)]
		public object Label
		{
			get
			{
				return this._cachedLabel;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty, value);
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003040F File Offset: 0x0002E60F
		internal void InitializeDefaultLabel(object value)
		{
			this._defaultLabel = value;
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00030424 File Offset: 0x0002E624
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeLabel()
		{
			global::System.Windows.BaseValueSource baseValueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(this, global::Infragistics.Windows.DataPresenter.Field.LabelProperty).BaseValueSource;
			return baseValueSource >= global::System.Windows.BaseValueSource.Local;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003044D File Offset: 0x0002E64D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetLabel()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty);
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0003045C File Offset: 0x0002E65C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.LabelClickAction LabelClickActionResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.LabelClickAction labelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Default;
				if (this._settings != null)
				{
					labelClickAction = this._settings.LabelClickAction;
				}
				if (labelClickAction == global::Infragistics.Windows.DataPresenter.LabelClickAction.Default && this._owner != null)
				{
					labelClickAction = this._owner.GetDefaultLabelClickAction(this);
				}
				if (labelClickAction == global::Infragistics.Windows.DataPresenter.LabelClickAction.Default && (this._settings == null || this._settings.SortComparer == null) && !typeof(global::System.IComparable).IsAssignableFrom(this._cachedDataTypeUnderlying))
				{
					labelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
				}
				if (labelClickAction == global::Infragistics.Windows.DataPresenter.LabelClickAction.Default)
				{
					labelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields;
				}
				if ((global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields == labelClickAction || global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields == labelClickAction || global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields == labelClickAction || global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields == labelClickAction) && this._cachedBindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && this._owner != null && global::Infragistics.Windows.DataPresenter.SortEvaluationMode.UseCollectionView == this._owner.SortEvaluationModeResolvedDefault)
				{
					labelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing;
				}
				return labelClickAction;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00030500 File Offset: 0x0002E700
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public double LabelHeightResolved
		{
			get
			{
				if (this._owner != null)
				{
					global::System.Windows.Size templateItemSize = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetTemplateItemSize(this, true);
					double labelMaxHeightResolved = this.LabelMaxHeightResolved;
					if (!double.IsNaN(labelMaxHeightResolved) && templateItemSize.Height > labelMaxHeightResolved)
					{
						templateItemSize.Height = labelMaxHeightResolved;
					}
					return templateItemSize.Height;
				}
				return this.LabelHeightResolvedInternal;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0003054C File Offset: 0x0002E74C
		internal double LabelHeightResolvedInternal
		{
			get
			{
				double num = this.GetLabelHeightResolvedHelper(false, false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				if (this._cellPosition.RowSpan > 1)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				bool flag = true;
				if (owner != null)
				{
					flag = (!owner.IsHorizontal && owner.IsDataRecordSizedToContent);
				}
				if (flag)
				{
					return double.NaN;
				}
				num = this.GetCellHeightResolvedHelper(false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				return this.GetDefaultHeight(true);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000305CC File Offset: 0x0002E7CC
		internal double GetLabelHeightResolvedHelper(bool provideDefault, bool forceDefault)
		{
			global::Infragistics.Windows.DataPresenter.FieldSize resizeSize = this.GetResizeSize(true, false);
			if (resizeSize.HasExplicitSize)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase view = global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(this);
				if (view != null && view.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return resizeSize.Value;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = this.GetWidthOrHeight(false);
			if (widthOrHeight.IsAbsolute && this.SyncCellLabelHeight)
			{
				return widthOrHeight.Value;
			}
			if (widthOrHeight.IsAnyAuto && resizeSize.HasAutoModeSize)
			{
				return resizeSize.Value;
			}
			double num;
			if (this._settings != null)
			{
				num = this._settings.LabelHeight;
				if (!double.IsNaN(num))
				{
					return num;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				if (owner.HasFieldSettings)
				{
					num = owner.FieldSettings.LabelHeight;
					if (!double.IsNaN(num))
					{
						return num;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter != null && dataPresenter.HasFieldSettings)
				{
					num = dataPresenter.FieldSettings.LabelHeight;
					if (!double.IsNaN(num))
					{
						return num;
					}
				}
			}
			if (!provideDefault)
			{
				return double.NaN;
			}
			num = this.GetDefaultHeight(true);
			if (forceDefault && double.IsNaN(num))
			{
				return 32.0;
			}
			return num;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00030700 File Offset: 0x0002E900
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double LabelMaxHeightResolved
		{
			get
			{
				if (this._settings != null)
				{
					double labelMaxHeight = this._settings.LabelMaxHeight;
					if (!double.IsNaN(labelMaxHeight))
					{
						return labelMaxHeight;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double labelMaxHeight = owner.FieldSettings.LabelMaxHeight;
						if (!double.IsNaN(labelMaxHeight))
						{
							return labelMaxHeight;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double labelMaxHeight = dataPresenter.FieldSettings.LabelMaxHeight;
						if (!double.IsNaN(labelMaxHeight))
						{
							return labelMaxHeight;
						}
					}
				}
				return double.PositiveInfinity;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00030790 File Offset: 0x0002E990
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMaxWidthResolved
		{
			get
			{
				if (this._settings != null)
				{
					double labelMaxWidth = this._settings.LabelMaxWidth;
					if (!double.IsNaN(labelMaxWidth))
					{
						return labelMaxWidth;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double labelMaxWidth = owner.FieldSettings.LabelMaxWidth;
						if (!double.IsNaN(labelMaxWidth))
						{
							return labelMaxWidth;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double labelMaxWidth = dataPresenter.FieldSettings.LabelMaxWidth;
						if (!double.IsNaN(labelMaxWidth))
						{
							return labelMaxWidth;
						}
					}
				}
				return double.PositiveInfinity;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00030820 File Offset: 0x0002EA20
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public double LabelMinHeightResolved
		{
			get
			{
				if (this._settings != null)
				{
					double labelMinHeight = this._settings.LabelMinHeight;
					if (!double.IsNaN(labelMinHeight))
					{
						return labelMinHeight;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double labelMinHeight = owner.FieldSettings.LabelMinHeight;
						if (!double.IsNaN(labelMinHeight))
						{
							return labelMinHeight;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double labelMinHeight = dataPresenter.FieldSettings.LabelMinHeight;
						if (!double.IsNaN(labelMinHeight))
						{
							return labelMinHeight;
						}
					}
				}
				return 0.0;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000308B0 File Offset: 0x0002EAB0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public double LabelMinWidthResolved
		{
			get
			{
				if (this._settings != null)
				{
					double labelMinWidth = this._settings.LabelMinWidth;
					if (!double.IsNaN(labelMinWidth))
					{
						return labelMinWidth;
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				if (owner != null)
				{
					if (owner.HasFieldSettings)
					{
						double labelMinWidth = owner.FieldSettings.LabelMinWidth;
						if (!double.IsNaN(labelMinWidth))
						{
							return labelMinWidth;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						double labelMinWidth = dataPresenter.FieldSettings.LabelMinWidth;
						if (!double.IsNaN(labelMinWidth))
						{
							return labelMinWidth;
						}
					}
				}
				return 0.0;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00030940 File Offset: 0x0002EB40
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextAlignment LabelTextAlignmentResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.TextAlignment? labelTextAlignment = this._settings.LabelTextAlignment;
					if (labelTextAlignment != null)
					{
						return labelTextAlignment.Value;
					}
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultLabelTextAlignment(this);
				}
				return global::System.Windows.TextAlignment.Left;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00030988 File Offset: 0x0002EB88
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.TextTrimming LabelTextTrimmingResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.TextTrimming? labelTextTrimming = this._settings.LabelTextTrimming;
					if (labelTextTrimming != null)
					{
						return labelTextTrimming.Value;
					}
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultLabelTextTrimming(this);
				}
				return global::System.Windows.TextTrimming.None;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000309D0 File Offset: 0x0002EBD0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.TextWrapping LabelTextWrappingResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::System.Windows.TextWrapping? labelTextWrapping = this._settings.LabelTextWrapping;
					if (labelTextWrapping != null)
					{
						return labelTextWrapping.Value;
					}
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultLabelTextWrapping(this);
				}
				return global::System.Windows.TextWrapping.NoWrap;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00030A18 File Offset: 0x0002EC18
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public double LabelWidthResolved
		{
			get
			{
				if (this._owner != null)
				{
					global::System.Windows.Size templateItemSize = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetTemplateItemSize(this, true);
					double labelMaxWidthResolved = this.LabelMaxWidthResolved;
					if (!double.IsNaN(labelMaxWidthResolved) && templateItemSize.Width > labelMaxWidthResolved)
					{
						templateItemSize.Width = labelMaxWidthResolved;
					}
					return templateItemSize.Width;
				}
				return this.LabelWidthResolvedInternal;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00030A64 File Offset: 0x0002EC64
		internal double LabelWidthResolvedInternal
		{
			get
			{
				double num = this.GetLabelWidthResolvedHelper(false, false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				if (this._cellPosition.ColumnSpan > 1)
				{
					return double.NaN;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
				bool flag = true;
				if (owner != null)
				{
					flag = (owner.IsHorizontal && owner.IsDataRecordSizedToContent);
				}
				if (flag)
				{
					return double.NaN;
				}
				num = this.GetCellWidthResolvedHelper(false);
				if (!double.IsNaN(num))
				{
					return num;
				}
				return this.DefaultCellWidth;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00030AE0 File Offset: 0x0002ECE0
		internal double GetLabelWidthResolvedHelper(bool provideDefault, bool forceDefault)
		{
			global::Infragistics.Windows.DataPresenter.FieldSize resizeSize = this.GetResizeSize(true, true);
			if (resizeSize.HasExplicitSize)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase view = global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(this);
				global::System.Windows.Controls.Orientation orientation = (view != null) ? view.LogicalOrientation : global::System.Windows.Controls.Orientation.Vertical;
				if (global::System.Windows.Controls.Orientation.Vertical == orientation)
				{
					return resizeSize.Value;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = this.GetWidthOrHeight(true);
			if (widthOrHeight.IsAbsolute && this.SyncCellLabelWidth)
			{
				return widthOrHeight.Value;
			}
			if (widthOrHeight.IsAnyAuto && resizeSize.HasAutoModeSize)
			{
				return resizeSize.Value;
			}
			double num;
			if (this._settings != null)
			{
				num = this._settings.LabelWidth;
				if (!double.IsNaN(num))
				{
					return num;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				if (owner.HasFieldSettings)
				{
					num = owner.FieldSettings.LabelWidth;
					if (!double.IsNaN(num))
					{
						return num;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter != null && dataPresenter.HasFieldSettings)
				{
					num = dataPresenter.FieldSettings.LabelWidth;
					if (!double.IsNaN(num))
					{
						return num;
					}
				}
			}
			if (!provideDefault)
			{
				return double.NaN;
			}
			num = this.GetDefaultWidth(true);
			if (forceDefault && double.IsNaN(num))
			{
				return 120.0;
			}
			return num;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00030C14 File Offset: 0x0002EE14
		private static void OnNameChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			if (field != null)
			{
				field._nameExplicitySet = true;
				if (field.IsPlaceholderForTreeView)
				{
					field._cachedName = (e.NewValue as string);
					field._defaultLabel = (e.NewValue as string);
					field.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty);
					return;
				}
				if (field._owner != null)
				{
					field._owner.Fields.OnFieldNameChanged(field, (string)e.NewValue, (string)e.OldValue);
				}
				field._cachedName = (string)field.GetValue(global::Infragistics.Windows.DataPresenter.Field.NameProperty);
				if (field._defaultLabel == global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance || (field._defaultLabel is string && string.Compare((string)e.OldValue, (string)field._defaultLabel, false) == 0))
				{
					field._defaultLabel = field._cachedName;
					field.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.LabelProperty);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00030D04 File Offset: 0x0002EF04
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00030D0C File Offset: 0x0002EF0C
		public string Name
		{
			get
			{
				return this._cachedName;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.NameProperty, value);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00030D1A File Offset: 0x0002EF1A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeName()
		{
			return this._nameExplicitySet && this._cachedName != null && this._cachedName.Length > 0;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00030D3C File Offset: 0x0002EF3C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetName()
		{
			if (this.ShouldSerializeName())
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.NameProperty);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00030D51 File Offset: 0x0002EF51
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior NonSpecificNotificationBehaviorResolved
		{
			get
			{
				if (this._cachedNonSpecificNotificationBehavior == global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default)
				{
					this._cachedNonSpecificNotificationBehavior = this.GetNonSpecificNotificationBehaviorResolvedInternal();
				}
				return this._cachedNonSpecificNotificationBehavior;
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00030D70 File Offset: 0x0002EF70
		private global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior GetNonSpecificNotificationBehaviorResolvedInternal()
		{
			global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior nonSpecificNotificationBehavior = global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default;
			if (this._settings != null)
			{
				nonSpecificNotificationBehavior = this._settings.NonSpecificNotificationBehavior;
			}
			if (nonSpecificNotificationBehavior == global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default && this._owner != null)
			{
				if (this._owner.HasFieldSettings)
				{
					nonSpecificNotificationBehavior = this._owner.FieldSettings.NonSpecificNotificationBehavior;
				}
				if (nonSpecificNotificationBehavior == global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						nonSpecificNotificationBehavior = dataPresenter.FieldSettings.NonSpecificNotificationBehavior;
					}
				}
			}
			if (nonSpecificNotificationBehavior == global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default)
			{
				nonSpecificNotificationBehavior = global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.RefreshValue;
			}
			return nonSpecificNotificationBehavior;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00030DE8 File Offset: 0x0002EFE8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00030E02 File Offset: 0x0002F002
		[global::System.ComponentModel.Bindable(true)]
		public int Row
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.RowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.RowProperty, value);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00030E15 File Offset: 0x0002F015
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRow()
		{
			return this.Row > 0;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00030E20 File Offset: 0x0002F020
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRow()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.RowProperty);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00030E2D File Offset: 0x0002F02D
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00030E3F File Offset: 0x0002F03F
		[global::System.ComponentModel.Bindable(true)]
		public int RowSpan
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.RowSpanProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.RowSpanProperty, value);
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00030E52 File Offset: 0x0002F052
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRowSpan()
		{
			return this.RowSpan >= 0;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00030E60 File Offset: 0x0002F060
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRowSpan()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.RowSpanProperty);
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00030E70 File Offset: 0x0002F070
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00030EC4 File Offset: 0x0002F0C4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public global::Infragistics.Windows.DataPresenter.FieldSettings Settings
		{
			get
			{
				if (this._settings == null && (this._owner == null || this._owner.DataPresenter == null || !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._owner.DataPresenter)))
				{
					this._settings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
					this.OnNewSettings();
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
						this.OnNewSettings();
					}
					this._cachedEditAsTypeResolved = null;
					this._cachedEditAsTypeResolvedUnderlying = null;
					this.DirtyRecordFilterRelatedCache(true);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00030F23 File Offset: 0x0002F123
		internal global::Infragistics.Windows.DataPresenter.FieldSettings SettingsIfAllocated
		{
			get
			{
				return this._settings;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00030F2B File Offset: 0x0002F12B
		public bool ShouldSerializeSettings()
		{
			return this._settings != null && this._settings.ShouldSerialize();
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00030F42 File Offset: 0x0002F142
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSettings()
		{
			this.Settings = null;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00030F4C File Offset: 0x0002F14C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.IComparer SortComparerResolved
		{
			get
			{
				global::System.Collections.IComparer comparer = null;
				if (this._settings != null)
				{
					comparer = this._settings.SortComparer;
				}
				if (comparer != null)
				{
					return comparer;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						comparer = this._owner.FieldSettings.SortComparer;
						if (comparer != null)
						{
							return comparer;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						comparer = dataPresenter.FieldSettings.SortComparer;
						if (comparer != null)
						{
							return comparer;
						}
					}
				}
				return null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00030FC8 File Offset: 0x0002F1C8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldSortComparisonType SortComparisonTypeResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldSortComparisonType fieldSortComparisonType = global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default;
				if (this._settings != null)
				{
					fieldSortComparisonType = this._settings.SortComparisonType;
				}
				if (fieldSortComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
				{
					return fieldSortComparisonType;
				}
				if (this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						fieldSortComparisonType = this._owner.FieldSettings.SortComparisonType;
						if (fieldSortComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
						{
							return fieldSortComparisonType;
						}
					}
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null && dataPresenter.HasFieldSettings)
					{
						fieldSortComparisonType = dataPresenter.FieldSettings.SortComparisonType;
						if (fieldSortComparisonType != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.Default)
						{
							return fieldSortComparisonType;
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseSensitive;
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00031044 File Offset: 0x0002F244
		private static void OnSortStatusChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._cachedSortStatus = (global::Infragistics.Windows.Controls.SortStatus)e.NewValue;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003106A File Offset: 0x0002F26A
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00031072 File Offset: 0x0002F272
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.SortStatus SortStatus
		{
			get
			{
				return this._cachedSortStatus;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.SortStatusPropertyKey, value);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00031088 File Offset: 0x0002F288
		private static void OnSortStatusGroupByChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._cachedSortStatusGroupBy = (global::Infragistics.Windows.Controls.SortStatus)e.NewValue;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000310AE File Offset: 0x0002F2AE
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000310B6 File Offset: 0x0002F2B6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SortStatus SortStatusGroupBy
		{
			get
			{
				return this._cachedSortStatusGroupBy;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.SortStatusGroupByPropertyKey, value);
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000310CC File Offset: 0x0002F2CC
		private static void OnSummaryStringFormatsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = target as global::Infragistics.Windows.DataPresenter.Field;
			field._cachedSummaryStringFormats = null;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000310E7 File Offset: 0x0002F2E7
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x000310F9 File Offset: 0x0002F2F9
		[global::System.ComponentModel.Bindable(true)]
		public string SummaryStringFormats
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.SummaryStringFormatsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.SummaryStringFormatsProperty, value);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00031108 File Offset: 0x0002F308
		private static bool ValidateSummaryStringFormats(object objVal)
		{
			string text = (string)objVal;
			string text2 = null;
			if (string.IsNullOrWhiteSpace(text) || global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.IsValid(text, out text2))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(text2))
			{
				throw new global::System.ArgumentException(text2);
			}
			return false;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00031144 File Offset: 0x0002F344
		internal string GetSummaryStringFormat(string calculatorName)
		{
			if (this._cachedSummaryStringFormats == null)
			{
				string summaryStringFormats = this.SummaryStringFormats;
				if (!string.IsNullOrEmpty(summaryStringFormats))
				{
					string text;
					this._cachedSummaryStringFormats = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.Parse(summaryStringFormats, out text);
				}
			}
			string result;
			if (this._cachedSummaryStringFormats != null && this._cachedSummaryStringFormats.TryGetValue(calculatorName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00031191 File Offset: 0x0002F391
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryStringFormats()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.Field.SummaryStringFormatsProperty, this);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0003119E File Offset: 0x0002F39E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryStringFormats()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.SummaryStringFormatsProperty);
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000311AC File Offset: 0x0002F3AC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryUIType SummaryUITypeResolved
		{
			get
			{
				if (this._settings != null)
				{
					global::Infragistics.Windows.DataPresenter.SummaryUIType summaryUIType = this._settings.SummaryUIType;
					if (summaryUIType != global::Infragistics.Windows.DataPresenter.SummaryUIType.Default)
					{
						return summaryUIType;
					}
				}
				if (this._owner != null)
				{
					return this._owner.GetDefaultSummaryUIType(this);
				}
				return global::Infragistics.Windows.DataPresenter.SummaryUIType.MultiSelectForNumericsOnly;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000311E8 File Offset: 0x0002F3E8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x000311F5 File Offset: 0x0002F3F5
		[global::Infragistics.Windows.Internal.CloneBehavior(global::Infragistics.Windows.Internal.CloneBehavior.ShareInstance)]
		[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
		public object Tag
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.Field.TagProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.TagProperty, value);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00031203 File Offset: 0x0002F403
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00031210 File Offset: 0x0002F410
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.Field.ToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ToolTipProperty, value);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0003121E File Offset: 0x0002F41E
		private static void OnValueConstraintChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueConstraint, e.NewValue);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00031234 File Offset: 0x0002F434
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00031246 File Offset: 0x0002F446
		public global::Infragistics.Windows.Editors.ValueConstraint ValueConstraint
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ValueConstraint)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.ValueConstraintProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ValueConstraintProperty, value);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00031254 File Offset: 0x0002F454
		private static void OnValueToTextConverteChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToTextConverter, e.NewValue);
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0003126A File Offset: 0x0002F46A
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0003127C File Offset: 0x0002F47C
		public global::System.Windows.Data.IValueConverter ValueToTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.ValueToTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.ValueToTextConverterProperty, value);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003128A File Offset: 0x0002F48A
		private static void OnVerticalContentAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.VerticalContentAlignment, e.NewValue);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x000312A0 File Offset: 0x0002F4A0
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x000312B2 File Offset: 0x0002F4B2
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.VerticalAlignment>))]
		public global::System.Windows.VerticalAlignment? VerticalContentAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment?)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.VerticalContentAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.VerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000312C8 File Offset: 0x0002F4C8
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)dependencyObject;
			global::System.Windows.Visibility cachedVisibility = (global::System.Windows.Visibility)e.NewValue;
			field._cachedVisibility = cachedVisibility;
			field.BumpLayoutItemVersion();
			field.RaisePropertyChangedEvent("VisibilityResolved");
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00031301 File Offset: 0x0002F501
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00031309 File Offset: 0x0002F509
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return this._cachedVisibility;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.VisibilityProperty, value);
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0003131C File Offset: 0x0002F51C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeVisibility()
		{
			return this.Visibility != global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0003132A File Offset: 0x0002F52A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.VisibilityProperty);
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00031338 File Offset: 0x0002F538
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				if (this._mappedTreeField == global::Infragistics.Windows.DataPresenter.Field.UnMappedField)
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				if (this._mappedTreeField != null)
				{
					return this._mappedTreeField.VisibilityResolved;
				}
				if (this._isGroupBy && global::System.Windows.Visibility.Collapsed != this._cachedVisibility)
				{
					global::System.Windows.Visibility cellVisibilityWhenGroupedResolved = this.CellVisibilityWhenGroupedResolved;
					if (cellVisibilityWhenGroupedResolved != global::System.Windows.Visibility.Visible)
					{
						return cellVisibilityWhenGroupedResolved;
					}
				}
				return this._cachedVisibility;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0003138B File Offset: 0x0002F58B
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0003139D File Offset: 0x0002F59D
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000313B0 File Offset: 0x0002F5B0
		internal bool AllowUnGrouping
		{
			get
			{
				bool? flag = null;
				if (this._settings != null)
				{
					flag = this._settings.AllowGroupBy;
				}
				if (flag != null)
				{
					return flag.Value;
				}
				return this._owner == null || this._owner.GetDefaultAllowGroupBy(this, this._isPropertyDescriptorInitialized ? null : new bool?(true));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0003141C File Offset: 0x0002F61C
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions AutoSizeOptionsResolved
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.AutoSizeOptionsResolved;
				}
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?>(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeOptionsProperty, null, new global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.All)).Value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0003145F File Offset: 0x0002F65F
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope AutoSizeScopeResolved
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.AutoSizeScopeResolved;
				}
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope>(global::Infragistics.Windows.DataPresenter.FieldSettings.AutoSizeScopeProperty, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.Default, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope.RecordsInView);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00031482 File Offset: 0x0002F682
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0003149E File Offset: 0x0002F69E
		internal int AutoSizeVersion
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.AutoSizeVersion;
				}
				return this._autoSizeVersion;
			}
			set
			{
				if (this.IsFieldMapped)
				{
					this._mappedTreeField.AutoSizeVersion = value;
					return;
				}
				this._autoSizeVersion = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000314BC File Offset: 0x0002F6BC
		internal global::System.Windows.Data.Binding CellContentAlignmentBinding
		{
			get
			{
				if (this._cellContentAlignmentBinding == null)
				{
					this._cellContentAlignmentBinding = global::Infragistics.Windows.Utilities.CreateBindingObject("CellContentAlignmentResolved", global::System.Windows.Data.BindingMode.OneWay, this);
				}
				return this._cellContentAlignmentBinding;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000314DE File Offset: 0x0002F6DE
		internal global::Infragistics.Windows.DataPresenter.CellElementKey CellElementKey
		{
			get
			{
				this.VerifyLayoutVersion();
				if (this._cellElementKey == null)
				{
					this._cellElementKey = new global::Infragistics.Windows.DataPresenter.CellElementKey(this);
				}
				return this._cellElementKey;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00031500 File Offset: 0x0002F700
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItem CellLayoutItem
		{
			get
			{
				if (this._cellLayoutItem == null)
				{
					this._cellLayoutItem = new global::Infragistics.Windows.DataPresenter.FieldLayoutItem(this, false);
				}
				return this._cellLayoutItem;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003151D File Offset: 0x0002F71D
		internal global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint CellLayoutConstraint
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.CellLayoutConstraint;
				}
				if (this._owner != null && this._owner.UseCellPresenters)
				{
					return this.CellLayoutItem;
				}
				return this.LayoutConstraint;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0003155D File Offset: 0x0002F75D
		internal global::System.Windows.Style CellPresenterStyleResolved
		{
			get
			{
				return this.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.CellPresenterStyle, null);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00031594 File Offset: 0x0002F794
		internal global::System.Windows.Style CellValuePresenterStyleResolved
		{
			get
			{
				return this.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.CellValuePresenterStyle, (global::Infragistics.Windows.DataPresenter.Field f) => f.CellValuePresenterStyle);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000315E4 File Offset: 0x0002F7E4
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
				if (owner == null)
				{
					return null;
				}
				return owner.DataPresenter;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00031603 File Offset: 0x0002F803
		internal global::System.Type DataTypeUnderlying
		{
			get
			{
				return this._cachedDataTypeUnderlying;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0003160B File Offset: 0x0002F80B
		internal global::System.Type EditAsTypeResolvedUnderlying
		{
			get
			{
				if (this._cachedEditAsTypeResolvedUnderlying == null)
				{
					this._cachedEditAsTypeResolvedUnderlying = global::Infragistics.CoreUtilities.GetUnderlyingType(this.EditAsTypeResolved);
				}
				return this._cachedEditAsTypeResolvedUnderlying;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00031644 File Offset: 0x0002F844
		internal global::System.Windows.Style EditorStyleResolved
		{
			get
			{
				return this.GetFieldSettingsStyleResolved((global::Infragistics.Windows.DataPresenter.FieldSettings fs) => fs.EditorStyle, (global::Infragistics.Windows.DataPresenter.Field f) => f.EditorStyle);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00031691 File Offset: 0x0002F891
		internal global::System.Collections.IEqualityComparer ExcelStyleFilterUniqueValueComparer
		{
			get
			{
				if (this.FilterStringComparisonTypeResolved != global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive || !(this.DataType == typeof(string)))
				{
					return null;
				}
				return new global::Infragistics.Windows.DataPresenter.Field.StringCellValueEqualityComparer(global::System.StringComparer.CurrentCultureIgnoreCase);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x000316BF File Offset: 0x0002F8BF
		internal global::Infragistics.Windows.DataPresenter.FilterCellElementKey FilterCellElementKey
		{
			get
			{
				this.VerifyLayoutVersion();
				if (this._filterCellElementKey == null)
				{
					this._filterCellElementKey = new global::Infragistics.Windows.DataPresenter.FilterCellElementKey(this);
				}
				return this._filterCellElementKey;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000316E4 File Offset: 0x0002F8E4
		internal global::System.Type FilterEditAsTypeResolved
		{
			get
			{
				switch (this.FilterOperandUITypeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo:
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.DropDownList:
					return typeof(object);
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor:
					return this.EditAsTypeResolved;
				default:
					return typeof(string);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0003172C File Offset: 0x0002F92C
		internal global::System.Type FilterEditorTypeResolved
		{
			get
			{
				switch (this.FilterOperandUITypeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo:
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.DropDownList:
					return typeof(global::Infragistics.Windows.Editors.XamComboEditor);
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor:
					return this.EditorTypeResolved;
				default:
					return typeof(global::Infragistics.Windows.Editors.XamTextEditor);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00031772 File Offset: 0x0002F972
		internal global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType FilterLabelIconDropDownTypeResolved
		{
			get
			{
				return this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType>(global::Infragistics.Windows.DataPresenter.FieldSettings.FilterLabelIconDropDownTypeProperty, global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.Default, global::Infragistics.Windows.DataPresenter.FilterLabelIconDropDownType.SingleSelect);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00031781 File Offset: 0x0002F981
		internal global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition GridPosition
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.GridPosition;
				}
				return this._cellPosition;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0003179D File Offset: 0x0002F99D
		internal bool HasCellBindings
		{
			get
			{
				return this._cellBindings != null && this._cellBindings.Count > 0;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000317B7 File Offset: 0x0002F9B7
		internal bool HasCvpBindings
		{
			get
			{
				return this._cellBindings != null && this._cellBindings.CvpBindingCount > 0;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000317D1 File Offset: 0x0002F9D1
		internal bool HasCellEditorBindings
		{
			get
			{
				return this._cellBindings != null && this._cellBindings.EditorBindingCount > 0;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x000317EB File Offset: 0x0002F9EB
		internal bool HasCellValuePresenterStyleSelector
		{
			get
			{
				return this._hasCellValuePresenterStyleSelector;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000317F3 File Offset: 0x0002F9F3
		internal bool HasEditorStyleSelector
		{
			get
			{
				return this._hasEditorStyleSelector;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000317FB File Offset: 0x0002F9FB
		internal bool HasFormula
		{
			get
			{
				return this._calculationSettings != null && !string.IsNullOrEmpty(this._calculationSettings.Formula);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0003181A File Offset: 0x0002FA1A
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00031824 File Offset: 0x0002FA24
		internal bool IgnoreFieldVisibilityOverrides
		{
			get
			{
				return this._ignoreFieldVisibilityOverrides;
			}
			set
			{
				if (this._ignoreFieldVisibilityOverrides != value)
				{
					global::System.Windows.Visibility visibilityResolved = this.VisibilityResolved;
					this._ignoreFieldVisibilityOverrides = value;
					if (visibilityResolved != this.VisibilityResolved)
					{
						if (this._owner != null)
						{
							this._owner.OnFieldVisibilityChanged(this);
						}
						base.RaisePropertyChangedEvent("VisibilityResolved");
					}
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00031870 File Offset: 0x0002FA70
		internal int IndexForCompare
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.Index;
				}
				return this.Index;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0003188C File Offset: 0x0002FA8C
		internal bool IsBoundToRootProperty
		{
			get
			{
				return this._isBoundToRootProperty;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00031894 File Offset: 0x0002FA94
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x0003189D File Offset: 0x0002FA9D
		internal bool IsCellVirtualized
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.CellVirtualized);
			}
			set
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.CellVirtualized, value);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000318A7 File Offset: 0x0002FAA7
		internal bool IsDataTypeExplicitySet
		{
			get
			{
				return this._dataTypeExplicitySet;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000318AF File Offset: 0x0002FAAF
		internal bool IsFieldMapped
		{
			get
			{
				return this.MappedTreeField != null && this._mappedTreeField != global::Infragistics.Windows.DataPresenter.Field._UnMappedField;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000318CB File Offset: 0x0002FACB
		internal bool IsFieldMapped_NoVerify
		{
			get
			{
				return this._mappedTreeField != null && this._mappedTreeField != global::Infragistics.Windows.DataPresenter.Field._UnMappedField;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x000318E7 File Offset: 0x0002FAE7
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x000318F0 File Offset: 0x0002FAF0
		internal bool IsFilterCellVirtualized
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.FilterCellVirtualized);
			}
			set
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.FilterCellVirtualized, value);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x000318FA File Offset: 0x0002FAFA
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00031912 File Offset: 0x0002FB12
		internal virtual bool IsInLayout
		{
			get
			{
				return this._mappedTreeField != global::Infragistics.Windows.DataPresenter.Field.UnMappedField && this.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.IsInLayout);
			}
			set
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.IsInLayout, value);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003191C File Offset: 0x0002FB1C
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00031925 File Offset: 0x0002FB25
		internal bool IsLabelVirtualized
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.LabelVirtualized);
			}
			set
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.LabelVirtualized, value);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0003192F File Offset: 0x0002FB2F
		internal bool IsSortOrGroupBy
		{
			get
			{
				return this.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted || this.IsGroupBy;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00031941 File Offset: 0x0002FB41
		internal virtual bool IsValid
		{
			get
			{
				return this.Index >= 0;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00031950 File Offset: 0x0002FB50
		internal bool IsTreeViewExpander
		{
			get
			{
				bool flag = this._owner != null && this._owner.TreeField == this;
				if (flag != this._cachedIsTreeField)
				{
					this.IsTreeField = flag;
				}
				return flag;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00031988 File Offset: 0x0002FB88
		internal global::Infragistics.Windows.DataPresenter.LabelElementKey LabelElementKey
		{
			get
			{
				this.VerifyLayoutVersion();
				if (this._labelElementKey == null)
				{
					this._labelElementKey = new global::Infragistics.Windows.DataPresenter.LabelElementKey(this);
				}
				return this._labelElementKey;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x000319AA File Offset: 0x0002FBAA
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItem LabelLayoutItem
		{
			get
			{
				if (this._labelLayoutItem == null)
				{
					this._labelLayoutItem = new global::Infragistics.Windows.DataPresenter.FieldLayoutItem(this, true);
				}
				return this._labelLayoutItem;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000319C7 File Offset: 0x0002FBC7
		internal global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint LabelLayoutConstraint
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.LabelLayoutConstraint;
				}
				if (this._owner != null && this._owner.UseCellPresenters)
				{
					return this.LabelLayoutItem;
				}
				return this.LayoutConstraint;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000319FF File Offset: 0x0002FBFF
		internal int LabelLineCount
		{
			get
			{
				return this._labelLineCount;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00031A07 File Offset: 0x0002FC07
		internal global::Infragistics.Windows.DataPresenter.GridBagConstraint LayoutConstraint
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.LayoutConstraint;
				}
				if (this._layoutConstraint == null)
				{
					this._layoutConstraint = new global::Infragistics.Windows.DataPresenter.GridBagConstraint();
				}
				return this._layoutConstraint;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00031A36 File Offset: 0x0002FC36
		internal int LayoutItemVersion
		{
			get
			{
				return this._layoutItemVersion + ((this._owner != null) ? this._owner.LayoutItemVersion : 0);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00031A55 File Offset: 0x0002FC55
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00031A70 File Offset: 0x0002FC70
		internal global::Infragistics.Windows.DataPresenter.Field MappedTreeField
		{
			get
			{
				if (this._owner != null)
				{
					this._owner.VerifyTreeMappings();
				}
				return this._mappedTreeField;
			}
			set
			{
				if (this._mappedTreeField != value)
				{
					if (this.IsFieldMapped_NoVerify)
					{
						if (this._mappedTreeField._fieldsMappedToThisField != null && this._mappedTreeField._fieldsMappedToThisField.Contains(this))
						{
							this._mappedTreeField._fieldsMappedToThisField.Remove(this);
						}
						this._mappedTreeField.PropertyChanged -= this.OnMappedFieldPropertyChanged;
					}
					this._mappedTreeField = value;
					if (this.IsFieldMapped_NoVerify)
					{
						this._mappedTreeField.PropertyChanged += this.OnMappedFieldPropertyChanged;
						if (this._mappedTreeField._fieldsMappedToThisField == null)
						{
							this._mappedTreeField._fieldsMappedToThisField = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field>();
						}
						this._mappedTreeField._fieldsMappedToThisField.Add(this);
						base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedPropertyKey, this._mappedTreeField.IsFixed);
						base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityPropertyKey, this._mappedTreeField.FixedButtonVisibility);
						base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty, this._mappedTreeField.FixedLocation);
						return;
					}
					base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedPropertyKey);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityPropertyKey);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty);
				}
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		internal int NavigationIndex
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.NavigationIndex;
				}
				if (this._owner != null && this._owner.StyleGenerator != null)
				{
					this._navigationIndex = this._owner.StyleGenerator.GridFieldMap.GetNavigationIndex(this, this._navigationIndex);
				}
				return this._navigationIndex;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00031C08 File Offset: 0x0002FE08
		internal int NavigationIndexCompressedCell
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.NavigationIndexCompressedCell;
				}
				if (this._owner != null && this._owner.TemplateDataRecordCache != null)
				{
					this._navigationIndexCompressedCell = this._owner.TemplateDataRecordCache.CellFieldMap.GetNavigationIndex(this, this._navigationIndexCompressedCell);
				}
				return this._navigationIndexCompressedCell;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00031C68 File Offset: 0x0002FE68
		internal int NavigationIndexCompressedLabel
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.NavigationIndexCompressedLabel;
				}
				if (this._owner != null && this._owner.TemplateDataRecordCache != null)
				{
					this._navigationIndexCompressedLabel = this._owner.TemplateDataRecordCache.LabelFieldMap.GetNavigationIndex(this, this._navigationIndexCompressedLabel);
				}
				return this._navigationIndexCompressedLabel;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00031CC6 File Offset: 0x0002FEC6
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00031CD8 File Offset: 0x0002FED8
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.Field.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.InternalVersionProperty, value);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00031CEC File Offset: 0x0002FEEC
		internal bool IsEditAsTypeNumeric
		{
			get
			{
				global::System.Type editAsTypeResolved = this.EditAsTypeResolved;
				return global::Infragistics.Windows.Utilities.IsNumericType(global::Infragistics.CoreUtilities.GetUnderlyingType(editAsTypeResolved));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00031D0B File Offset: 0x0002FF0B
		internal bool IsExpandableByDefault
		{
			get
			{
				return this._isExpandableByDefault;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00031D13 File Offset: 0x0002FF13
		internal bool IsPropertyDescriptorInitialized
		{
			get
			{
				return this._isPropertyDescriptorInitialized;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00031D1B File Offset: 0x0002FF1B
		internal bool IsVisibleInCellArea
		{
			get
			{
				return global::System.Windows.Visibility.Collapsed != this.VisibilityInCellArea;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00031D29 File Offset: 0x0002FF29
		internal global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo ExplicitResizeInfo
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.ExplicitResizeInfo;
				}
				if (this._explicitResizeInfo == null)
				{
					this._explicitResizeInfo = new global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo(this);
				}
				return this._explicitResizeInfo;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00031D59 File Offset: 0x0002FF59
		internal global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo ExplicitResizeInfoIfAllocated
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.ExplicitResizeInfoIfAllocated;
				}
				return this._explicitResizeInfo;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00031D75 File Offset: 0x0002FF75
		internal int PropertyDescriptorVersion
		{
			get
			{
				return this._propertyDescriptorVersion;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00031D80 File Offset: 0x0002FF80
		internal bool SupportDataErrorInfoResolved
		{
			get
			{
				if (-1 == this._cachedSupportDataErrorInfoResolved)
				{
					bool? resolvedValue = this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldSettings.SupportDataErrorInfoProperty, null, null);
					this._cachedSupportDataErrorInfoResolved = ((resolvedValue == null) ? 0 : (resolvedValue.Value ? 1 : 2));
				}
				if (this._cachedSupportDataErrorInfoResolved != 0)
				{
					return 1 == this._cachedSupportDataErrorInfoResolved;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
				if (owner != null)
				{
					global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo supportDataErrorInfoResolvedDefault = owner.SupportDataErrorInfoResolvedDefault;
					return global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.CellsOnly == supportDataErrorInfoResolvedDefault || global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsAndCells == supportDataErrorInfoResolvedDefault;
				}
				return false;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00031E04 File Offset: 0x00030004
		internal bool SyncCellLabelWidth
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
				if (owner == null)
				{
					return false;
				}
				if (owner.UseCellPresenters)
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.IsLabelAboveBelowCell(this.CellContentAlignmentResolved);
				}
				return !owner.IsHorizontal && owner.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00031E44 File Offset: 0x00030044
		internal bool SyncCellLabelHeight
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
				if (owner == null)
				{
					return false;
				}
				if (owner.UseCellPresenters)
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.IsLabelLeftRightCell(this.CellContentAlignmentResolved);
				}
				return owner.IsHorizontal && owner.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00031E84 File Offset: 0x00030084
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00031EA0 File Offset: 0x000300A0
		internal int TemplateCellIndex
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.TemplateCellIndex;
				}
				return this._templateCellIndex;
			}
			set
			{
				this._templateCellIndex = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00031EAC File Offset: 0x000300AC
		internal static global::Infragistics.Windows.DataPresenter.Field UnMappedField
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.Field._UnMappedField == null)
				{
					lock (typeof(global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker))
					{
						if (global::Infragistics.Windows.DataPresenter.Field._UnMappedField == null)
						{
							global::Infragistics.Windows.DataPresenter.Field._UnMappedField = new global::Infragistics.Windows.DataPresenter.Field();
						}
					}
				}
				return global::Infragistics.Windows.DataPresenter.Field._UnMappedField;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00031F08 File Offset: 0x00030108
		internal global::System.Windows.Data.Binding VisibilityBinding
		{
			get
			{
				if (this._visibilityBinding == null)
				{
					this._visibilityBinding = global::Infragistics.Windows.Utilities.CreateBindingObject("VisibilityResolved", global::System.Windows.Data.BindingMode.OneWay, this);
				}
				return this._visibilityBinding;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00031F2A File Offset: 0x0003012A
		internal global::System.Windows.Visibility VisibilityInCellArea
		{
			get
			{
				if (this.IsFieldMapped)
				{
					return this._mappedTreeField.VisibilityInCellArea;
				}
				if (this.IsExpandableResolved)
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return this.VisibilityResolved;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00031F50 File Offset: 0x00030150
		private global::System.Globalization.CultureInfo ConverterCultureResolvedImpl
		{
			get
			{
				global::System.Globalization.CultureInfo converterCulture = this._converterCulture;
				if (converterCulture != null)
				{
					return converterCulture;
				}
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
					if (dataPresenter != null)
					{
						return dataPresenter.DefaultConverterCulture;
					}
				}
				return null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00031F88 File Offset: 0x00030188
		private double DefaultCellHeight
		{
			get
			{
				return this.GetDefaultHeight(false);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00031F91 File Offset: 0x00030191
		private double DefaultCellWidth
		{
			get
			{
				return this.GetDefaultWidth(false);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00031F9A File Offset: 0x0003019A
		public double CalculateAutoSizeExtent()
		{
			return this.CalculateAutoSizeExtent(this.AutoSizeOptionsResolved, this.AutoSizeScopeResolved);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00031FB0 File Offset: 0x000301B0
		public double CalculateAutoSizeExtent(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			this.PrepareForExplicitAutoSizeOperation();
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper autoSizeFieldHelper;
			if (!this.CalculateAutoSizeExtent(options, scope, out autoSizeFieldHelper))
			{
				return double.NaN;
			}
			return autoSizeFieldHelper.GetExtent(this);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00031FE0 File Offset: 0x000301E0
		private bool CalculateAutoSizeExtent(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope, out global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper helper)
		{
			helper = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper(this, options, scope);
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotInFieldLayoutFields"));
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
			if (dataPresenter == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_5"));
			}
			if (!helper.ExitEditModeIfNeeded())
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags = global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.RecalculateRecords | global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.UseTemplateRecordAsFallback;
			return helper.Calculate(dataPresenter.Records, global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetNestingDepth(owner), flags, null);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00032050 File Offset: 0x00030250
		public global::Infragistics.Windows.DataPresenter.Field GetMappedFieldInTree(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(fieldLayout, "fieldLayout");
			if (fieldLayout.DataPresenter == null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError("Can't get mapped field in tree from a fieldLayout that hasn't been initialized.");
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._owner != null) ? this._owner.DataPresenter : null;
			if (this._owner == null || dataPresenterBase == null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(string.Format("Can't get mapped field in tree from a field that hasn't been initialized:, Field: {0}", this.Name));
				return null;
			}
			if (this._owner == fieldLayout)
			{
				return this;
			}
			if (fieldLayout.DataPresenter != dataPresenterBase)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_29"));
			}
			if (this._owner.IsDefault)
			{
				return fieldLayout.GetFieldFromMappedField(this);
			}
			global::Infragistics.Windows.DataPresenter.Field mappedTreeField = this.MappedTreeField;
			if (mappedTreeField == null || mappedTreeField == global::Infragistics.Windows.DataPresenter.Field.UnMappedField)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._owner.AlignmentFieldLayout;
			if (fieldLayout == alignmentFieldLayout)
			{
				return mappedTreeField;
			}
			return fieldLayout.GetFieldFromMappedField(mappedTreeField);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0003211D File Offset: 0x0003031D
		public global::System.ComponentModel.PropertyDescriptor GetPropertyDescriptor(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			return dataRecord.GetPropertyDescriptor(this);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00032126 File Offset: 0x00030326
		public void PerformAutoSize()
		{
			this.PerformAutoSize(this.AutoSizeOptionsResolved, this.AutoSizeScopeResolved);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0003213A File Offset: 0x0003033A
		public void PerformAutoSize(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope)
		{
			this.PrepareForExplicitAutoSizeOperation();
			this.PerformAutoSize(options, scope, false);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0003215C File Offset: 0x0003035C
		internal void PerformAutoSize(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions options, global::Infragistics.Windows.DataPresenter.FieldAutoSizeScope scope, bool addToUndo)
		{
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper autoSizeFieldHelper;
			if (!this.CalculateAutoSizeExtent(options, scope, out autoSizeFieldHelper))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			if (!currentViewInternal.IsLogicalFieldWidthResizingAllowed)
			{
				return;
			}
			bool isHorizontal = owner.IsHorizontal;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager labelLayoutManager = owner.LabelLayoutManager;
			global::System.Windows.Size size = labelLayoutManager.CalculatePreferredSize();
			bool isGridBagAutoFitHeight = owner.IsGridBagAutoFitHeight;
			bool isGridBagAutoFitWidth = owner.IsGridBagAutoFitWidth;
			if (isGridBagAutoFitHeight || isGridBagAutoFitWidth)
			{
				global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.DataPresenter.DataRecordPresenter> callback = (global::Infragistics.Windows.DataPresenter.DataRecordPresenter rp) => rp.FieldLayout == this.Owner;
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter descendantFromType = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.DataRecordPresenter>(dataPresenter, true, callback, new global::System.Type[]
				{
					typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase),
					typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaBase)
				});
				if (descendantFromType != null)
				{
					if (isGridBagAutoFitHeight)
					{
						size.Height = descendantFromType.AutoFitCellAreaHeight;
					}
					if (isGridBagAutoFitWidth)
					{
						size.Width = descendantFromType.AutoFitCellAreaWidth;
					}
				}
			}
			object containerContext = new global::System.Windows.Rect(size);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase>();
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = labelLayoutManager.GetLayoutItem(this, true);
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem2 = labelLayoutManager.GetLayoutItem(this, false);
			if (layoutItem != null)
			{
				list.Add(layoutItem);
			}
			if (layoutItem2 != null)
			{
				list.Add(layoutItem2);
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> preferredSizes = autoSizeFieldHelper.GetPreferredSizes(labelLayoutManager, list);
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary2;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents = labelLayoutManager.PerformAutoSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, preferredSizes, isGridBagAutoFitWidth, isGridBagAutoFitHeight, out dictionary, out dictionary2);
			labelLayoutManager.ResizeItems(newExtents, !isHorizontal, null, addToUndo, global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize, (!isHorizontal) ? dictionary : dictionary2);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000322BE File Offset: 0x000304BE
		internal void BumpLayoutItemVersion()
		{
			this._layoutItemVersion++;
			if (this._owner != null)
			{
				this._owner.BumpLayoutItemVersion(false);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000322E2 File Offset: 0x000304E2
		internal void BumpPropertyDescriptorVersion()
		{
			this._propertyDescriptorVersion++;
			base.RaisePropertyChangedEvent("PropertyDescriptorVersion");
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000322FD File Offset: 0x000304FD
		internal void BumpVersion()
		{
			this.InternalVersion++;
			this.Owner.DataPresenter.InvalidateItemsHost();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00032320 File Offset: 0x00030520
		protected internal virtual void ClearEditorProperties(global::Infragistics.Windows.Editors.ValueEditor editor, bool isInFilterCell)
		{
			if (this._wasEverTreeField && (this._editorPropsSetBits & 20L) == 0L)
			{
				this.ClearEditorProperty(editor, 20);
			}
			if (this._editorPropsSetBits == 0L)
			{
				return;
			}
			long num = this._editorPropsSetBits;
			if (isInFilterCell)
			{
				if (this.FilterOperandUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
				{
					return;
				}
				long num2 = 16777216L;
				if (this.GetIsEditorPropSet(num2))
				{
					num &= ~num2;
				}
			}
			int num3 = 0;
			while (num != 0L)
			{
				long num4 = 1L << num3;
				if (this.GetIsEditorPropSet(num4))
				{
					num &= ~num4;
					this.ClearEditorProperty(editor, num3);
				}
				num3++;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000323AC File Offset: 0x000305AC
		internal void ClearUserResize()
		{
			if (this._explicitResizeInfo != null)
			{
				this._explicitResizeInfo.Reset();
				bool flag = this._owner != null && this._owner.IsHorizontal;
				if (this.GetWidthOrHeight(!flag).IsInitialAuto)
				{
					this._hasPendingInitialAutoSize = true;
				}
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00032400 File Offset: 0x00030600
		internal global::Infragistics.Windows.DataPresenter.Field Clone(bool includeSettings)
		{
			global::Infragistics.Windows.DataPresenter.Field field = global::System.Activator.CreateInstance(base.GetType()) as global::Infragistics.Windows.DataPresenter.Field;
			field.InitializeFrom(this);
			if (includeSettings && this.HasSettings)
			{
				field.Settings = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(this.Settings, true) as global::Infragistics.Windows.DataPresenter.FieldSettings);
			}
			return field;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00032448 File Offset: 0x00030648
		internal object ConvertValue(object value, global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			if (this._converter != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = (record != null) ? record.GetCellIfAllocated(this) : null;
				global::System.Type targetType = (cell != null) ? cell.EditAsTypeResolved : this.EditAsTypeResolved;
				object converterParameterResolved = this.GetConverterParameterResolved(record);
				return this._converter.Convert(value, targetType, converterParameterResolved, this.ConverterCultureResolved);
			}
			return value;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0003249B File Offset: 0x0003069B
		internal void DirtyCellContentAlignmentCache()
		{
			this._cachedCellContentAlignmentResolved = null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000324A9 File Offset: 0x000306A9
		internal void DirtyRecordFilterRelatedCache(bool verify)
		{
			this._isFilterRecordCacheDirty = true;
			if (verify && this._owner != null)
			{
				this.VerifyRecordFilterRelatedCache();
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000324C3 File Offset: 0x000306C3
		internal bool DoesPropertyMatch(global::System.ComponentModel.PropertyDescriptor pd)
		{
			return pd != null && this._cachedBindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && this.Name == pd.Name;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000324E4 File Offset: 0x000306E4
		internal void FlipFieldPositions()
		{
			int row = this.Row;
			int rowSpan = this.RowSpan;
			base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.RowProperty, this.Column);
			base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.RowSpanProperty, this.ColumnSpan);
			base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.ColumnProperty, row);
			base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.ColumnSpanProperty, rowSpan);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000327F4 File Offset: 0x000309F4
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMappedFields(bool excludeThisField = false)
		{
			if (!excludeThisField)
			{
				yield return this;
			}
			bool isTreeView = this._owner != null && this._owner.IsTreeView;
			if (isTreeView)
			{
				if (this._owner != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._owner.AlignmentFieldLayout;
				}
				global::Infragistics.Windows.DataPresenter.Field fieldInDefaultLayout = this.IsFieldMapped ? this.MappedTreeField : this;
				if (this != fieldInDefaultLayout)
				{
					yield return fieldInDefaultLayout;
				}
				if (fieldInDefaultLayout._fieldsMappedToThisField != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field mappedField in fieldInDefaultLayout._fieldsMappedToThisField)
					{
						if (mappedField != null && mappedField != this)
						{
							yield return mappedField;
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00032818 File Offset: 0x00030A18
		internal float GetAutoFitWeight(bool cell, bool weightX, global::Infragistics.Windows.DataPresenter.AutoFitMode autoFitMode)
		{
			float num = this.GetAutoFitWeight(cell, weightX);
			if (cell && num == 0f)
			{
				switch (autoFitMode)
				{
				case global::Infragistics.Windows.DataPresenter.AutoFitMode.Default:
				case global::Infragistics.Windows.DataPresenter.AutoFitMode.Always:
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
					if (owner != null && owner.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.CardView && owner.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells)
					{
						if (weightX && !owner.HasStarFieldsX)
						{
							num = 1f;
						}
						else if (!weightX && !owner.HasStarFieldsY)
						{
							num = 1f;
						}
					}
					break;
				}
				}
			}
			return num;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00032890 File Offset: 0x00030A90
		internal float GetAutoFitWeight(bool cell, bool weightX)
		{
			global::Infragistics.Windows.DataPresenter.LayoutItemSize size = weightX ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth : global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight;
			if (!cell && !global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.ShouldSynchronize(size, this))
			{
				return 0f;
			}
			global::Infragistics.Windows.DataPresenter.FieldLength widthOrHeight = this.GetWidthOrHeight(weightX);
			if (!widthOrHeight.IsStar)
			{
				return 0f;
			}
			return global::System.Convert.ToSingle(widthOrHeight.Value);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000328DC File Offset: 0x00030ADC
		internal object GetConverterParameterResolved(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			object obj = this.ConverterParameter;
			if (obj == null)
			{
				obj = record;
			}
			return obj;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000328F8 File Offset: 0x00030AF8
		internal global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions GetCurrentAutoSizeOptions()
		{
			global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions fieldAutoSizeOptions = this.AutoSizeOptionsResolved;
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfoIfAllocated = this.ExplicitResizeInfoIfAllocated;
			if (fieldAutoSizeOptions != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None && this._owner != null && explicitResizeInfoIfAllocated != null)
			{
				bool isHorizontal = this._owner.IsHorizontal;
				if ((!isHorizontal && !this.SyncCellLabelWidth) || (isHorizontal && !this.SyncCellLabelHeight))
				{
					if (explicitResizeInfoIfAllocated.GetSize(true, !isHorizontal).HasExplicitSize)
					{
						fieldAutoSizeOptions &= ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;
					}
					if (explicitResizeInfoIfAllocated.GetSize(false, !isHorizontal).HasExplicitSize)
					{
						fieldAutoSizeOptions &= global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;
					}
				}
			}
			return fieldAutoSizeOptions;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00032978 File Offset: 0x00030B78
		internal global::Infragistics.Windows.DataPresenter.FieldLength GetWidthOrHeight(bool width)
		{
			if (this.IsFieldMapped)
			{
				return this._mappedTreeField.GetWidthOrHeight(width);
			}
			if (width && this._cachedWidth != null)
			{
				return this._cachedWidth.Value;
			}
			if (!width && this._cachedHeight != null)
			{
				return this._cachedHeight.Value;
			}
			global::Infragistics.Windows.DataPresenter.FieldLength? fieldLength = width ? this.Width : this.Height;
			if (fieldLength == null)
			{
				global::System.Windows.DependencyProperty property = width ? global::Infragistics.Windows.DataPresenter.FieldSettings.WidthProperty : global::Infragistics.Windows.DataPresenter.FieldSettings.HeightProperty;
				fieldLength = this.GetResolvedValue<global::Infragistics.Windows.DataPresenter.FieldLength?>(property, null, null);
			}
			if (fieldLength == null)
			{
				fieldLength = new global::Infragistics.Windows.DataPresenter.FieldLength?(global::Infragistics.Windows.DataPresenter.FieldLength.Empty);
			}
			if (width)
			{
				this._cachedWidth = fieldLength;
			}
			else
			{
				this._cachedHeight = fieldLength;
			}
			if (!fieldLength.Value.IsAnyAuto && this._explicitResizeInfo != null)
			{
				this._explicitResizeInfo.ClearAuto(true, width);
				this._explicitResizeInfo.ClearAuto(false, width);
			}
			return fieldLength.Value;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00032A7C File Offset: 0x00030C7C
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter()
		{
			this.VerifyLayoutVersion();
			bool isTreeViewExpander = this.IsTreeViewExpander;
			if (this._cachedCellValuePresenters != null && this._cachedCellValuePresenters.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = this._cachedCellValuePresenters.Pop();
				if (isTreeViewExpander)
				{
					if (cellValuePresenter is global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter)
					{
						return cellValuePresenter;
					}
				}
				else if (!(cellValuePresenter is global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter))
				{
					return cellValuePresenter;
				}
				this._cachedCellValuePresenters.Clear();
			}
			if (isTreeViewExpander)
			{
				return new global::Infragistics.Windows.DataPresenter.TreeCellValuePresenter();
			}
			return new global::Infragistics.Windows.DataPresenter.CellValuePresenter();
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00032AE8 File Offset: 0x00030CE8
		internal global::System.Windows.Style GetFieldSettingsStyleResolved(global::System.Func<global::Infragistics.Windows.DataPresenter.FieldSettings, global::System.Windows.Style> fieldSettingsGetter, global::System.Func<global::Infragistics.Windows.DataPresenter.Field, global::System.Windows.Style> fieldGetter = null)
		{
			global::System.Windows.Style style = (fieldGetter != null) ? fieldGetter(this) : null;
			if (style == null)
			{
				if (this._settings != null)
				{
					style = fieldSettingsGetter(this._settings);
				}
				if (style == null && this._owner != null)
				{
					if (this._owner.HasFieldSettings)
					{
						style = fieldSettingsGetter(this._owner.FieldSettings);
					}
					if (style == null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
						if (dataPresenter != null && dataPresenter.HasFieldSettings)
						{
							style = fieldSettingsGetter(dataPresenter.FieldSettings);
						}
					}
				}
			}
			return style;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00032B6D File Offset: 0x00030D6D
		internal bool GetIsEditingAllowed(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return record != null && record.GetIsEditingAllowed(this);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00032B7B File Offset: 0x00030D7B
		internal global::Infragistics.Windows.DataPresenter.LabelPresenter GetLabelPresenter()
		{
			this.VerifyLayoutVersion();
			if (this._cachedLabelPresenters != null && this._cachedLabelPresenters.Count > 0)
			{
				return this._cachedLabelPresenters.Pop();
			}
			return new global::Infragistics.Windows.DataPresenter.LabelPresenter();
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00032BAC File Offset: 0x00030DAC
		internal global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager GetCPLayoutManager(global::System.Windows.Size constrainedSize)
		{
			global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager cpgridBagLayoutManager = this._cachedCPLayoutManager;
			if (cpgridBagLayoutManager == null)
			{
				cpgridBagLayoutManager = new global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager(this, constrainedSize);
				cpgridBagLayoutManager.ExpandToFitHeight = true;
				cpgridBagLayoutManager.ExpandToFitWidth = true;
			}
			else
			{
				cpgridBagLayoutManager.ConstrainedSize = constrainedSize;
				this._cachedCPLayoutManager = null;
			}
			return cpgridBagLayoutManager;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00032BEC File Offset: 0x00030DEC
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
			if (this._owner != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = this._owner.FieldSettingsIfAllocated;
				if (fieldSettings != null)
				{
					T t = (T)((object)fieldSettings.GetValue(property));
					if (!object.Equals(defaultValue, t))
					{
						return t;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
				fieldSettings = ((dataPresenter != null) ? dataPresenter.FieldSettingsIfAllocated : null);
				if (fieldSettings != null)
				{
					T t = (T)((object)fieldSettings.GetValue(property));
					if (!object.Equals(defaultValue, t))
					{
						return t;
					}
				}
			}
			return defaultResolvedValue;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00032CA0 File Offset: 0x00030EA0
		internal global::Infragistics.Windows.DataPresenter.FieldSize GetResizeSize(bool label, bool width)
		{
			global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo explicitResizeInfoIfAllocated = this.ExplicitResizeInfoIfAllocated;
			if (explicitResizeInfoIfAllocated == null)
			{
				return global::Infragistics.Windows.DataPresenter.FieldSize.Empty;
			}
			return explicitResizeInfoIfAllocated.GetSize(label, width);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00032CC8 File Offset: 0x00030EC8
		internal void Initialize(global::Infragistics.Windows.DataPresenter.FieldLayout owner)
		{
			if (this._owner != null && this._owner != owner)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_9"));
			}
			this._owner = owner;
			this._cachedCellContentAlignmentResolved = null;
			this._cachedCellTextConverterInfo = null;
			this._cachedDataValueChangedHistoryLimitResolved = null;
			this._cachedDataValueChangedNotificationsActiveResolved = null;
			this._cachedDataValueChangedScopeResolved = null;
			this._cachedEditAsTypeResolved = null;
			this._cachedEditAsTypeResolvedUnderlying = null;
			this._cachedSupportDataErrorInfoResolved = -1;
			if (this.IsPlaceholderForTreeView)
			{
				this.Name = this.MappedTreeField.Name;
				return;
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities.SetCurrentValueIfSourceDefault(this, global::Infragistics.Windows.DataPresenter.Field.DataContextProperty, (this._owner != null) ? this._owner.DataContext : null);
			if (this._owner != null)
			{
				if (this._cellBindings != null)
				{
					this._cellBindings.ClearAddedAndRemovedLists();
				}
				if (this._settings != null && this._settings.HasFieldBinding)
				{
					this._settings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.DataContextProperty, this.DataContext);
				}
				if (this._isPrimary)
				{
					this._owner.PrimaryField = this;
				}
				if (this._isScrollTip)
				{
					this._owner.ScrollTipField = this;
				}
				if (this._owner.IsInitialized && (this._defaultLabel == null || this._defaultLabel == global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance))
				{
					string name = this.Name;
					if (name != null && name.Length > 0)
					{
						this.InitializeDefaultLabel(name);
					}
				}
				this.DirtyRecordFilterRelatedCache(true);
				this.OnPropertyChanged("Owner");
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00032E44 File Offset: 0x00031044
		protected internal virtual void InitializeEditorProperties(global::Infragistics.Windows.Editors.ValueEditor editor, bool isInFilterCell)
		{
			if (this._wasEverTreeField && (this._editorPropsSetBits & 20L) == 0L)
			{
				this.ClearEditorProperty(editor, 20);
			}
			if (this._editorPropsSetBits == 0L)
			{
				return;
			}
			long num = this._editorPropsSetBits;
			if (isInFilterCell)
			{
				if (this.FilterOperandUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
				{
					return;
				}
				long num2 = 16777216L;
				if (this.GetIsEditorPropSet(num2))
				{
					num &= ~num2;
				}
			}
			int num3 = 0;
			while (num != 0L)
			{
				long num4 = 1L << num3;
				if (this.GetIsEditorPropSet(num4))
				{
					num &= ~num4;
					this.SetEditorProperty(editor, num3);
				}
				num3++;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00032ED0 File Offset: 0x000310D0
		internal void InitializeFilterCellEditor(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this.SetFilterCellEditorStyle(editor);
			switch (this.FilterOperandUITypeResolved)
			{
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Disabled:
				editor.IsEnabled = false;
				break;
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.TextBox:
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.DropDownList:
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor:
				break;
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo:
			{
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = editor as global::Infragistics.Windows.Editors.XamComboEditor;
				if (xamComboEditor != null)
				{
					xamComboEditor.IsEditable = true;
					return;
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00032F24 File Offset: 0x00031124
		protected internal virtual void InitializeFrom(global::Infragistics.Windows.DataPresenter.Field source)
		{
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(source, global::Infragistics.Windows.DataPresenter.Field.DataContextProperty).BaseValueSource != global::System.Windows.BaseValueSource.Default)
			{
				this.DataContext = source.DataContext;
			}
			long num = source._editorPropsSetBits;
			int num2 = 0;
			while (num != 0L)
			{
				long num3 = 1L << num2;
				if (source.GetIsEditorPropSet(num3))
				{
					num &= ~num3;
					global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo editorPropertyInfo = global::Infragistics.Windows.DataPresenter.Field._EditorPropInfos[num2];
					global::System.Windows.DependencyProperty dependencyProperty = (editorPropertyInfo._fieldProperty != null) ? editorPropertyInfo._fieldProperty : editorPropertyInfo._editorProperty;
					if (dependencyProperty != null)
					{
						base.SetValue(dependencyProperty, source.GetValue(dependencyProperty));
					}
				}
				num2++;
			}
			this.AllowEdit = source.AllowEdit;
			this.AllowFixing = source.AllowFixing;
			this.AllowGroupBy = source.AllowGroupBy;
			this.AllowHiding = source.AllowHiding;
			this.AllowRecordFiltering = source.AllowRecordFiltering;
			this.AllowResize = source.AllowResize;
			this.AlternateBinding = source.AlternateBinding;
			this.AlternateBindingRetentionMode = source.AlternateBindingRetentionMode;
			this.BindingType = source.BindingType;
			if (source.HasCellBindings)
			{
				this.CellBindings.InitializeFrom(source.CellBindings);
			}
			this.CellValuePresenterStyle = source.CellValuePresenterStyle;
			this.ColumnSpan = source.ColumnSpan;
			this.Converter = source.Converter;
			this.ConverterCulture = source.ConverterCulture;
			this.ConverterParameter = source.ConverterParameter;
			this.DataType = source.DataType;
			this.EditAsType = source.EditAsType;
			this.EditorStyle = source.EditorStyle;
			this.EditorType = source.EditorType;
			this.GroupByMode = source.GroupByMode;
			this.IsEnabled = source.IsEnabled;
			this.IsEnabledInAddRecord = source.IsEnabledInAddRecord;
			this.IsExpandable = source.IsExpandable;
			this.IsPrimary = source.IsPrimary;
			this.IsScrollTipField = source.IsScrollTipField;
			this.IsTabStop = source.IsTabStop;
			this.IsTabStopInAddRecord = source.IsTabStopInAddRecord;
			if (source.HasLabel)
			{
				this.Label = source.Label;
			}
			this.Name = source.Name;
			this.Tag = source.Tag;
			this.Row = source.Row;
			this.RowSpan = source.RowSpan;
			this.SummaryStringFormats = source.SummaryStringFormats;
			this.Visibility = source.Visibility;
			this.Height = source.Height;
			this.Width = source.Width;
			this._dataTypeExplicitySet = source._dataTypeExplicitySet;
			this._cachedEditAsTypeResolved = null;
			this._cachedEditAsTypeResolvedUnderlying = null;
			this._cachedNonSpecificNotificationBehavior = global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default;
			if (source._explicitResizeInfo != null)
			{
				this._explicitResizeInfo = new global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo(this, source._explicitResizeInfo);
				this._hasPendingInitialAutoSize = source._hasPendingInitialAutoSize;
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000331D8 File Offset: 0x000313D8
		internal void InitializeIsBoundToRootProperty()
		{
			this._isBoundToRootProperty = false;
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = this as global::Infragistics.Windows.DataPresenter.UnboundField;
			if (unboundField != null)
			{
				global::System.Windows.PropertyPath propertyPath = unboundField.BindingPath;
				if (propertyPath == null)
				{
					global::System.Windows.Data.Binding binding = unboundField.Binding as global::System.Windows.Data.Binding;
					if (binding != null)
					{
						propertyPath = binding.Path;
					}
				}
				if (propertyPath != null)
				{
					string path = propertyPath.Path;
					if (path != null && path.Length > 0)
					{
						string[] array = path.Split(new char[]
						{
							'.',
							'[',
							'\0',
							'/'
						});
						this._isBoundToRootProperty = (array.Length == 1);
					}
				}
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00033252 File Offset: 0x00031452
		internal void InitializePropertyDescriptor(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, bool reinitialize)
		{
			if (!reinitialize && propertyDescriptor != null && !propertyDescriptor.IsBrowsable)
			{
				this.Visibility = global::System.Windows.Visibility.Collapsed;
			}
			this._dataTypeExplicitySet = false;
			this._isPropertyDescriptorInitialized = true;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00033277 File Offset: 0x00031477
		internal void InternalSelect(bool value)
		{
			if (this._selected != value)
			{
				this._selected = value;
				this.IsSelected = value;
			}
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00033290 File Offset: 0x00031490
		internal bool IsFixedLocationAllowed(global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation)
		{
			switch (this.AllowFixingResolved)
			{
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Near:
				return fixedFieldLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge;
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Far:
				return fixedFieldLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.NearOrFar:
				return true;
			}
			return false;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000332D4 File Offset: 0x000314D4
		internal void OnCellBindingsChanged()
		{
			try
			{
				if (this._owner != null && this._owner.DataPresenter != null)
				{
					this.OnPropertyChanged("CellBindings");
				}
			}
			finally
			{
				if (this._cellBindings != null)
				{
					this._cellBindings.ClearAddedAndRemovedLists();
				}
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0003332C File Offset: 0x0003152C
		internal void OnCurrentViewChanged(bool formatSettingsChanged)
		{
			if (this._cachedCellValuePresenters != null)
			{
				this._cachedCellValuePresenters.Clear();
			}
			this.VerifyFixedState();
			base.CoerceValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00033352 File Offset: 0x00031552
		internal void OnFieldLayoutTemplatesGenerated()
		{
			this.VerifyFixedState();
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003335C File Offset: 0x0003155C
		internal void OnPropertyDescriptorChanged(global::System.ComponentModel.PropertyDescriptor pd, global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			string value = null;
			if (this._owner != null)
			{
				value = this._owner.GetLabelFromPropertyDescriptor(pd, provider.Source);
			}
			this.Name = pd.Name;
			this.InitializeDefaultLabel(value);
			this.DataType = pd.PropertyType;
			this._dataTypeExplicitySet = false;
			this._nameExplicitySet = false;
			this.Initialize();
			this.InitializePropertyDescriptor(pd, true);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000333C4 File Offset: 0x000315C4
		internal bool PerformLabelClickAction(bool isInGroupByArea)
		{
			switch (this.LabelClickActionResolved)
			{
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnly:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByOneFieldOnlyTriState:
			case global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFieldsTriState:
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.SortingAction action = new global::Infragistics.Windows.DataPresenter.SortingAction(this, isInGroupByArea, global::System.Windows.Input.Keyboard.Modifiers);
				return dataPresenter.History.PerformAction(action, null);
			}
			}
			return false;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00033420 File Offset: 0x00031620
		private void PostDelayedInvalidation()
		{
			if (this._owner != null)
			{
				this._owner.PostDelayedInvalidation(true);
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00033438 File Offset: 0x00031638
		private void ProcessIsExpandableChanged()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter != null)
			{
				dataPresenter.BumpScrollCountRecalcVersion();
			}
			this.PostDelayedInvalidation();
			base.RaisePropertyChangedEvent("IsExpandableResolved");
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00033468 File Offset: 0x00031668
		internal static void ProcessFieldSettingsPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e, global::Infragistics.Windows.DataPresenter.FieldSettings settings, object settingsOwner, bool firstPassForPresenterFlag, bool firstPassForFieldLayoutFlag, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
		{
			if (presenter != null)
			{
				bool isInitialized = presenter.IsInitialized;
			}
			bool flag = false;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			bool flag2 = settingsOwner is global::Infragistics.Windows.DataPresenter.DataPresenterBase || settingsOwner is global::Infragistics.Windows.DataPresenter.FieldLayout;
			string propertyName = e.PropertyName;
			string key;
			switch (key = propertyName)
			{
			case "AllowGroupBy":
				if (presenter != null && firstPassForPresenterFlag)
				{
					presenter.BumpGroupByAreaStyleVersion();
				}
				flag = true;
				flag2 = false;
				break;
			case "CellValuePresenterStyleSelector":
				if (field != null)
				{
					field._hasCellValuePresenterStyleSelector = (null != field.GetResolvedValue<global::System.Windows.Controls.StyleSelector>(global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleSelectorProperty, null, null));
					if (field == settingsOwner)
					{
						field.RaisePropertyChangedEvent("CellValuePresenterStyleResolved");
					}
				}
				break;
			case "EditorStyleSelector":
				if (field != null)
				{
					field._hasEditorStyleSelector = (null != field.GetResolvedValue<global::System.Windows.Controls.StyleSelector>(global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleSelectorProperty, null, null));
					if (field == settingsOwner)
					{
						field.RaisePropertyChangedEvent("EditorStyleResolved");
					}
				}
				break;
			case "LabelPresenterStyleSelector":
				if (field != null && field == settingsOwner)
				{
					field.RaisePropertyChangedEvent("LabelPresenterStyleResolved");
				}
				break;
			case "CellValuePresenterStyle":
			case "ExpandedCellStyle":
			case "GroupByRecordPresenterStyle":
			case "LabelPresenterStyle":
				flag = true;
				break;
			case "LayoutDisplayMode":
			case "IsExpandable":
			case "CellContentAlignment":
				if (presenter != null && firstPassForPresenterFlag)
				{
					flag2 = true;
				}
				if (field != null)
				{
					if (propertyName == "CellContentAlignment")
					{
						field._cachedCellContentAlignmentResolved = null;
					}
					field.BumpLayoutItemVersion();
				}
				flag = true;
				break;
			case "CellMaxWidth":
				if (field != null)
				{
					double cellMaxWidthResolved = field.CellMaxWidthResolved;
					field.ProcessSizeChange(true, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Max, cellMaxWidthResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(false, true, double.NaN, cellMaxWidthResolved);
					}
				}
				flag = true;
				break;
			case "CellMinWidth":
				if (field != null)
				{
					double cellMinWidthResolved = field.CellMinWidthResolved;
					field.ProcessSizeChange(true, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Min, cellMinWidthResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(false, true, cellMinWidthResolved, double.NaN);
					}
				}
				flag = true;
				break;
			case "CellWidth":
				if (field != null)
				{
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.ClearExplicit(false, true);
					}
					field.ProcessSizeChange(true, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Size, field.CellWidthResolvedInternal);
				}
				flag = true;
				break;
			case "LabelMaxWidth":
				if (field != null)
				{
					double labelMaxWidthResolved = field.LabelMaxWidthResolved;
					field.ProcessSizeChange(false, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Max, labelMaxWidthResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(true, true, double.NaN, labelMaxWidthResolved);
					}
				}
				flag = true;
				break;
			case "LabelMinWidth":
				if (field != null)
				{
					double labelMinWidthResolved = field.LabelMinWidthResolved;
					field.ProcessSizeChange(false, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Min, labelMinWidthResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(true, true, labelMinWidthResolved, double.NaN);
					}
				}
				flag = true;
				break;
			case "LabelWidth":
				if (field != null)
				{
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.ClearExplicit(true, true);
					}
					field.ProcessSizeChange(false, true, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Size, field.LabelWidthResolvedInternal);
				}
				flag = true;
				break;
			case "CellHeight":
				if (field != null)
				{
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.ClearExplicit(false, false);
					}
					field.ProcessSizeChange(true, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Size, field.CellHeightResolvedInternal);
				}
				flag = true;
				break;
			case "CellMaxHeight":
				if (field != null)
				{
					double cellMaxHeightResolved = field.CellMaxHeightResolved;
					field.ProcessSizeChange(true, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Max, field.CellMaxHeightResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(false, false, double.NaN, cellMaxHeightResolved);
					}
				}
				flag = true;
				break;
			case "CellMinHeight":
				if (field != null)
				{
					double cellMinHeightResolved = field.CellMinHeightResolved;
					field.ProcessSizeChange(true, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Min, cellMinHeightResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(false, false, cellMinHeightResolved, double.NaN);
					}
				}
				flag = true;
				break;
			case "LabelHeight":
				if (field != null)
				{
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.ClearExplicit(true, false);
					}
					field.ProcessSizeChange(false, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Size, field.LabelHeightResolvedInternal);
				}
				flag = true;
				break;
			case "LabelMaxHeight":
				if (field != null)
				{
					double labelMaxHeightResolved = field.LabelMaxHeightResolved;
					field.ProcessSizeChange(false, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Max, labelMaxHeightResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(true, false, double.NaN, labelMaxHeightResolved);
					}
				}
				flag = true;
				break;
			case "LabelMinHeight":
				if (field != null)
				{
					double labelMinHeightResolved = field.LabelMinHeightResolved;
					field.ProcessSizeChange(false, false, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType.Min, labelMinHeightResolved);
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.Restrict(true, false, labelMinHeightResolved, double.NaN);
					}
				}
				flag = true;
				break;
			case "InvalidValueBehavior":
			case "LabelClickAction":
				flag = true;
				break;
			case "AllowSummaries":
			case "AllowHiding":
				flag = true;
				flag2 = false;
				if (firstPassForPresenterFlag && presenter != null)
				{
					presenter.DirtyFieldChooserFields();
				}
				break;
			case "SummaryUIType":
				flag = true;
				flag2 = false;
				list.Add("AllowSummariesResolved");
				break;
			case "SummaryDisplayArea":
				if (fieldLayout != null && firstPassForFieldLayoutFlag && fieldLayout.SummaryDefinitionsIfAllocated != null)
				{
					fieldLayout.SummaryDefinitionsIfAllocated.BumpSummariesVersion();
				}
				flag2 = false;
				break;
			case "AllowFixing":
				flag2 = false;
				if (fieldLayout != null && (field != null || firstPassForFieldLayoutFlag))
				{
					fieldLayout.DirtyFixedState();
					if (firstPassForFieldLayoutFlag || settingsOwner is global::Infragistics.Windows.DataPresenter.Field)
					{
						fieldLayout.InternalVersion++;
					}
				}
				if (field != null)
				{
					field.VerifyFixedState();
					flag = true;
				}
				break;
			case "AutoSizeOptions":
			case "AutoSizeScope":
				flag2 = false;
				if (firstPassForFieldLayoutFlag)
				{
					fieldLayout.AutoSizeInfo.OnAutoSizeSettingsChanged();
				}
				break;
			case "Width":
			case "Height":
				flag2 = false;
				if (field != null)
				{
					bool flag3 = propertyName == "Width";
					if (flag3)
					{
						field._cachedWidth = null;
					}
					else
					{
						field._cachedHeight = null;
					}
					if (field._explicitResizeInfo != null)
					{
						field._explicitResizeInfo.ClearExplicit(true, flag3);
						field._explicitResizeInfo.ClearExplicit(false, flag3);
					}
				}
				if (firstPassForFieldLayoutFlag)
				{
					fieldLayout.OnFieldWidthHeightChanged();
				}
				break;
			case "EditAsType":
			case "FilterOperatorDefaultValue":
			case "FilterOperatorDropDownItems":
				flag2 = (propertyName == "EditAsType");
				flag = true;
				if (field != null)
				{
					field._cachedEditAsTypeResolved = null;
					field._cachedEditAsTypeResolvedUnderlying = null;
					field.DirtyRecordFilterRelatedCache(true);
				}
				if (fieldLayout != null && firstPassForFieldLayoutFlag)
				{
					fieldLayout.InternalVersion++;
				}
				break;
			case "AllowRecordFiltering":
			case "FilterClearButtonVisibility":
			case "FilterEvaluationTrigger":
			case "FilterOperandUIType":
			case "FilterStringComparisonType":
				flag2 = false;
				flag = true;
				if (fieldLayout != null && firstPassForFieldLayoutFlag)
				{
					fieldLayout.BumpSpecialRecordsVersion();
					fieldLayout.InternalVersion++;
				}
				if (propertyName == "AllowRecordFiltering")
				{
					list.Add("FilterOperandUITypeResolved");
				}
				else if (fieldLayout != null && propertyName == "FilterStringComparisonType")
				{
					fieldLayout.BumpRecordFilterVersion();
				}
				if (field != null && "FilterOperandUIType" == propertyName)
				{
					field.DirtyRecordFilterRelatedCache(true);
				}
				break;
			case "FilterComparer":
			case "FilterEvaluator":
				flag = true;
				flag2 = false;
				if (fieldLayout != null && firstPassForFieldLayoutFlag)
				{
					fieldLayout.BumpRecordFilterVersion();
				}
				break;
			case "FilterCellValuePresenterStyle":
			case "FilterCellEditorStyle":
				flag = true;
				break;
			case "EditorType":
			case "EditorStyle":
				if (firstPassForFieldLayoutFlag && fieldLayout != null)
				{
					flag2 = true;
				}
				else if (field != null && field == settingsOwner)
				{
					flag = true;
				}
				break;
			case "SupportDataErrorInfo":
				flag = true;
				if (firstPassForPresenterFlag && presenter != null)
				{
					flag2 = true;
				}
				if (field != null)
				{
					field._cachedSupportDataErrorInfoResolved = -1;
				}
				break;
			case "GroupByEvaluator":
			case "SortComparisonType":
			case "GroupByMode":
				if (field != null)
				{
					field._cachedGroupByEvaluator = null;
				}
				flag = true;
				if ("GroupByEvaluator" != propertyName)
				{
					list.Add("GroupByEvaluatorResolved");
				}
				break;
			case "DataValueChangedScope":
			case "DataValueChangedNotificationsActive":
			case "DataValueChangedHistoryLimit":
				flag2 = false;
				if (fieldLayout != null)
				{
					fieldLayout.Fields.RefreshDataValueChangedCounts();
				}
				if (field != null)
				{
					field._cachedDataValueChangedHistoryLimitResolved = null;
					field._cachedDataValueChangedNotificationsActiveResolved = null;
					field._cachedDataValueChangedScopeResolved = null;
				}
				break;
			case "ExpandableFieldRecordExpansionMode":
			case "ExpandableFieldRecordHeaderDisplayMode":
				if (presenter != null)
				{
					presenter.BumpScrollCountRecalcVersion();
					flag = true;
				}
				break;
			case "AllowCollapseEmptyCells":
				flag2 = false;
				flag = true;
				if (firstPassForFieldLayoutFlag)
				{
					fieldLayout.BumpLayoutManagerVersion();
				}
				break;
			case "NonSpecificNotificationBehavior":
				flag2 = false;
				flag = true;
				if (field != null)
				{
					field._cachedNonSpecificNotificationBehavior = global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.Default;
				}
				break;
			case "FilterLabelIconDropDownType":
			case "FilterConditionOptimizationThreshold":
			case "ExcelStyleFilterSearchOperator":
				flag = true;
				flag2 = false;
				break;
			}
			if (flag2 && presenter != null && firstPassForPresenterFlag)
			{
				presenter.BumpGroupByAreaStyleVersion();
				if (fieldLayout == null)
				{
					presenter.InvalidateGeneratedStylesAsync(true);
				}
				else
				{
					fieldLayout.PostDelayedInvalidation(true);
				}
			}
			if (flag && field != null)
			{
				field.RaisePropertyChangedEvent(propertyName + "Resolved");
			}
			if (field != null)
			{
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					field.RaisePropertyChangedEvent(list[i]);
					i++;
				}
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0003402C File Offset: 0x0003222C
		internal static void RaisePropertyChangedEventHelper(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, string propertyName)
		{
			if (fields != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
				{
					field.RaisePropertyChangedEvent(propertyName);
				}
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00034078 File Offset: 0x00032278
		internal void ReleaseCPLayoutManager(global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager lm)
		{
			lm.Initialize(null, global::System.Windows.Rect.Empty, global::System.Windows.Rect.Empty, global::System.Windows.Rect.Empty);
			if (this._cachedCPLayoutManager == null)
			{
				this._cachedCPLayoutManager = lm;
			}
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0003409F File Offset: 0x0003229F
		internal void ReleaseCellValuePresenter(global::Infragistics.Windows.DataPresenter.CellValuePresenter presenter)
		{
			if (this._cachedCellValuePresenters == null)
			{
				this._cachedCellValuePresenters = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CellValuePresenter>();
			}
			if (presenter != null)
			{
				this._cachedCellValuePresenters.Push(presenter);
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000340C3 File Offset: 0x000322C3
		internal void ReleaseLabelPresenter(global::Infragistics.Windows.DataPresenter.LabelPresenter presenter)
		{
			if (this._cachedLabelPresenters == null)
			{
				this._cachedLabelPresenters = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.LabelPresenter>();
			}
			if (presenter != null)
			{
				this._cachedLabelPresenters.Push(presenter);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000340E8 File Offset: 0x000322E8
		internal void SetActualPosition(global::Infragistics.Windows.DataPresenter.FieldPosition position, bool ensureItemDoesntOverlap)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = owner.GetFieldLayoutInfo(true, false);
				if (layoutInfo == null)
				{
					layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(owner);
				}
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				if (layoutInfo.TryGetValue(this, out itemLayoutInfo))
				{
					itemLayoutInfo.SetPosition(position);
				}
				else
				{
					layoutInfo.Add(this, itemLayoutInfo = global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.Create(this, position));
				}
				itemLayoutInfo.UpdateExplicitSetPositionTimeStamp();
				if (ensureItemDoesntOverlap)
				{
					layoutInfo.EnsureItemDoesntOverlap(this);
				}
				owner.SetFieldLayoutInfo(layoutInfo, true, false);
				owner.InvalidateGeneratedStylesAsnyc(false, false);
				return;
			}
			this.Row = position.Row;
			this.Column = position.Column;
			this.RowSpan = position.RowSpan;
			this.ColumnSpan = position.ColumnSpan;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0003418C File Offset: 0x0003238C
		internal void SetFilterCellEditorStyle(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			if (editor == null)
			{
				return;
			}
			global::System.Windows.Style filterCellEditorStyleResolved = this.FilterCellEditorStyleResolved;
			if (filterCellEditorStyleResolved != null)
			{
				editor.SetValue(global::System.Windows.FrameworkElement.StyleProperty, filterCellEditorStyleResolved);
				return;
			}
			object obj = editor.ReadLocalValue(global::System.Windows.FrameworkElement.StyleProperty);
			if (obj != global::System.Windows.DependencyProperty.UnsetValue)
			{
				editor.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000341D4 File Offset: 0x000323D4
		internal void SetGridPositions(ref global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo rcInfo, ref global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo spanInfo)
		{
			this._cellPosition.Column = rcInfo.Column;
			this._cellPosition.ColumnSpan = spanInfo.ColumnSpan;
			this._cellPosition.Row = rcInfo.Row;
			this._cellPosition.RowSpan = spanInfo.RowSpan;
			global::Infragistics.Windows.DataPresenter.GridBagConstraint layoutConstraint = this.LayoutConstraint;
			layoutConstraint.Column = rcInfo.Column;
			layoutConstraint.ColumnSpan = spanInfo.ColumnSpan;
			layoutConstraint.Row = rcInfo.Row;
			layoutConstraint.RowSpan = spanInfo.RowSpan;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0003425C File Offset: 0x0003245C
		internal void SetFixedLocation(global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation)
		{
			bool flag = this.GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.SuppressFixedLocationInvalidate);
			this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.SuppressFixedLocationInvalidate, true);
			try
			{
				this.FixedLocation = fixedLocation;
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags.SuppressFixedLocationInvalidate, flag);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000342A0 File Offset: 0x000324A0
		internal void SetIsGroupBy(bool isGroupBy)
		{
			if (this._isGroupBy != isGroupBy)
			{
				this._isGroupBy = isGroupBy;
				base.RaisePropertyChangedEvent("IsGroupBy");
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000342BD File Offset: 0x000324BD
		internal void SetIsPrimaryInternal(bool isPrimary)
		{
			this._isPrimary = isPrimary;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000342C8 File Offset: 0x000324C8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return !this._autoGenerated || (this.ShouldSerializeSettings() || this.ShouldSerializeColumnSpan() || this.ShouldSerializeColumn() || this.ShouldSerializeDataType() || this.ShouldSerializeIsExpandable() || this.ShouldSerializeIsPrimary() || this.ShouldSerializeLabel() || this.ShouldSerializeName() || this.ShouldSerializeRow() || this.ShouldSerializeRowSpan() || this.ShouldSerializeVisibility()) || global::Infragistics.Windows.DataPresenter.GridUtilities.ShouldSerialize(this);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00034340 File Offset: 0x00032540
		protected internal virtual void SynchronizeEditorProperty(string propertyName, global::Infragistics.Windows.Editors.ValueEditor editor, bool isInFilterCell)
		{
			if (this._wasEverTreeField && (this._editorPropsSetBits & 20L) == 0L)
			{
				this.ClearEditorProperty(editor, 20);
			}
			if (this._editorPropsChangedBits == 0L)
			{
				return;
			}
			long num = this._editorPropsChangedBits;
			if (isInFilterCell)
			{
				if (this.FilterOperandUITypeResolved != global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
				{
					return;
				}
				long num2 = 16777216L;
				if (this.GetIsEditorPropChanged(num2))
				{
					num &= ~num2;
				}
			}
			int num3 = 0;
			while (num != 0L)
			{
				long num4 = 1L << num3;
				if (this.GetIsEditorPropChanged(num4))
				{
					num &= ~num4;
					if (this.GetIsEditorPropSet(num4))
					{
						this.SetEditorProperty(editor, num3);
					}
					else
					{
						this.ClearEditorProperty(editor, num3);
					}
				}
				num3++;
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000343E0 File Offset: 0x000325E0
		internal bool IsFilterCellEntryValid(object value, global::Infragistics.Windows.Controls.ComparisonOperator currentOperator, out global::System.Exception error)
		{
			error = null;
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(value))
			{
				return true;
			}
			if (value is global::Infragistics.Windows.Controls.ICondition || value is global::Infragistics.Windows.Controls.SpecialFilterOperandBase || value is global::System.Windows.Input.ICommand)
			{
				return true;
			}
			string message = null;
			global::System.Globalization.CultureInfo culture = global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetCulture(this);
			string format = global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase.GetFormat(this);
			if (!global::Infragistics.Windows.Controls.ComparisonCondition.IsCompareValueValid(currentOperator, value, culture, format, out error))
			{
				return false;
			}
			if (global::Infragistics.Windows.Controls.ComparisonCondition.IsQuantitativeComparison(currentOperator) && this.FilterEvaluatorResolved == null)
			{
				global::System.Type valueTypeForQuantitativeFilterComparison = global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.GetValueTypeForQuantitativeFilterComparison(this);
				global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = new global::Infragistics.Windows.Editors.ValueConstraint();
				if (!valueConstraint.Validate(value, valueTypeForQuantitativeFilterComparison, global::Infragistics.Windows.Editors.ValueConstraintFlags.All, culture, format, ref message))
				{
					if (!string.IsNullOrEmpty(value as string))
					{
						global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this);
						if (cachedConverter != null)
						{
							global::System.Exception ex;
							cachedConverter.ConvertDisplayText(value as string, out ex);
							if (ex == null)
							{
								return true;
							}
						}
					}
					error = new global::System.ArgumentException(message);
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000344A0 File Offset: 0x000326A0
		internal void ValidateBindingSetting(global::System.Windows.Data.BindingBase binding)
		{
			if (binding != null)
			{
				global::Infragistics.Windows.DataPresenter.UnboundField unboundField = this as global::Infragistics.Windows.DataPresenter.UnboundField;
				if (unboundField != null)
				{
					string text = null;
					if (unboundField.BindingPath != null)
					{
						text = "BindingPath";
					}
					else if (!object.Equals(unboundField.BindingMode, global::Infragistics.Windows.DataPresenter.UnboundField.BindingModeProperty.DefaultMetadata.DefaultValue))
					{
						text = "BindingMode";
					}
					if (text != null)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26B", new object[]
						{
							text
						}));
					}
				}
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00034514 File Offset: 0x00032714
		internal void VerifyFixedState()
		{
			bool flag = false;
			bool flag2 = false;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			if (owner != null)
			{
				flag = (this.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
				if (dataPresenter == null || !dataPresenter.IsFixedFieldsSupportedResolved)
				{
					flag = false;
				}
				else if (this.AllowFixingResolved != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No && global::Infragistics.Windows.DataPresenter.GridUtilities.IncludesFixedButton(owner.GetFixedFieldUITypeResolved(flag, true)))
				{
					flag2 = true;
				}
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedPropertyKey, flag ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
			base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityPropertyKey, flag2 ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000345A0 File Offset: 0x000327A0
		private void VerifyLayoutVersion()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
			int num = (owner != null) ? (owner.InternalVersion + owner.TemplateVersion) : -1;
			if (this._layoutVersion != num)
			{
				this._layoutVersion = num;
				this._cellElementKey = null;
				this._labelElementKey = null;
				this._filterCellElementKey = null;
				if (this._cachedCellValuePresenters != null)
				{
					this._cachedCellValuePresenters.Clear();
				}
				if (this._cachedLabelPresenters != null)
				{
					this._cachedLabelPresenters.Clear();
				}
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00034613 File Offset: 0x00032813
		private void CacheDataType(global::System.Type dataType)
		{
			this._cachedDataType = dataType;
			this._cachedDataTypeUnderlying = global::Infragistics.CoreUtilities.GetUnderlyingType(this._cachedDataType);
			this._cachedEditAsTypeResolved = null;
			this._cachedEditAsTypeResolvedUnderlying = null;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0003463B File Offset: 0x0003283B
		private void ClearEditorProperty(global::Infragistics.Windows.Editors.ValueEditor editor, int propIndex)
		{
			if (20 == propIndex && this.IsTreeField)
			{
				editor.SetValue(global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty, global::System.Windows.HorizontalAlignment.Stretch);
				return;
			}
			editor.ClearValue(global::Infragistics.Windows.DataPresenter.Field._EditorPropInfos[propIndex]._editorProperty);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00034678 File Offset: 0x00032878
		private static global::System.Collections.Hashtable CreateDefaultDataTable()
		{
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable(20);
			new global::System.Random();
			hashtable[typeof(global::System.DateTime)] = global::System.DateTime.MaxValue;
			hashtable[typeof(global::System.DayOfWeek)] = global::System.DayOfWeek.Wednesday;
			hashtable[typeof(int)] = int.MaxValue;
			hashtable[typeof(uint)] = uint.MaxValue;
			hashtable[typeof(short)] = short.MaxValue;
			hashtable[typeof(ushort)] = ushort.MaxValue;
			hashtable[typeof(long)] = long.MaxValue;
			hashtable[typeof(ulong)] = ulong.MaxValue;
			hashtable[typeof(float)] = 9999.889f;
			hashtable[typeof(double)] = 999999.8999999999;
			hashtable[typeof(decimal)] = 9999999.8999999999m;
			hashtable[typeof(byte)] = byte.MaxValue;
			hashtable[typeof(sbyte)] = sbyte.MaxValue;
			hashtable[typeof(string)] = "Text";
			hashtable[typeof(global::System.Windows.Media.Color)] = global::System.Windows.Media.Colors.White;
			hashtable[typeof(bool)] = false;
			return hashtable;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00034834 File Offset: 0x00032A34
		private bool GetAllowCellVirtualizationResolved(global::System.Windows.Controls.Orientation? orientation)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = null;
			if (this._owner != null)
			{
				dataPresenterBase = this._owner.DataPresenter;
			}
			if (dataPresenterBase != null && dataPresenterBase.IsReportControl)
			{
				return false;
			}
			bool? flag = null;
			if (this._settings != null)
			{
				flag = this._settings.AllowCellVirtualization;
			}
			if (dataPresenterBase != null && dataPresenterBase.IsTreeView && this._owner.TreeField == this)
			{
				return false;
			}
			if (flag == null && this._owner != null)
			{
				if (this._owner.HasFieldSettings)
				{
					flag = this._owner.FieldSettings.AllowCellVirtualization;
				}
				if (flag == null && dataPresenterBase != null && dataPresenterBase.HasFieldSettings)
				{
					flag = dataPresenterBase.FieldSettings.AllowCellVirtualization;
				}
			}
			return (flag == null || flag.Value) && (this._owner == null || this._owner.TemplateDataRecordCache.EditorAllowsVirtualization(this, orientation) || this.GetResolvedValue<bool?>(global::Infragistics.Windows.DataPresenter.FieldSettings.ForceCellVirtualizationProperty, null, new bool?(false)).Value || this.IsPlaceholderForTreeView);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0003494C File Offset: 0x00032B4C
		internal static object GetDefaultDataForType(global::System.Type type, global::System.Type dataType)
		{
			if (global::Infragistics.Windows.DataPresenter.Field.sampleData == null)
			{
				global::Infragistics.Windows.DataPresenter.Field.sampleData = global::Infragistics.Windows.DataPresenter.Field.CreateDefaultDataTable();
			}
			object obj = null;
			if (dataType != null && dataType != type && type == typeof(string))
			{
				obj = global::Infragistics.Windows.DataPresenter.Field.sampleData[dataType];
				if (obj != null)
				{
					obj = obj.ToString();
				}
			}
			if (obj == null)
			{
				obj = global::Infragistics.Windows.DataPresenter.Field.sampleData[type];
			}
			return obj;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000349B8 File Offset: 0x00032BB8
		private double GetDefaultHeight(bool isLabel)
		{
			if (this._owner == null)
			{
				return 32.0;
			}
			if (this._owner.IsAutoFitHeight)
			{
				if (this._owner.IsHorizontal && this.GetWidthOrHeight(false).IsStar)
				{
					return 0.0;
				}
				return double.NaN;
			}
			else if (this._owner.TemplateDataRecordCache.IsInitializingCache)
			{
				if (global::Infragistics.Windows.DataPresenter.Field.GetDefaultDataForType(this.EditAsTypeResolved, this.DataType) != null)
				{
					return double.NaN;
				}
				return 32.0;
			}
			else if (this._owner.StyleGenerator != null && this._owner.StyleGenerator.IsGeneratingTemplates)
			{
				if (!this._owner.IsHorizontal)
				{
					return double.NaN;
				}
				return 32.0;
			}
			else if (isLabel)
			{
				double labelPresenterHeight = this._owner.TemplateDataRecordCache.GetLabelPresenterHeight(this);
				if (!double.IsNaN(labelPresenterHeight))
				{
					return labelPresenterHeight;
				}
				return 0.0;
			}
			else
			{
				double num = this._owner.TemplateDataRecordCache.GetCellValuePresenterHeight(this);
				bool allowCellVirtualizationResolved = this.GetAllowCellVirtualizationResolved(new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Vertical));
				if (!double.IsNaN(num))
				{
					if (!allowCellVirtualizationResolved)
					{
						num = global::System.Math.Max(16.0, num);
					}
					return num;
				}
				if (!allowCellVirtualizationResolved)
				{
					return 32.0;
				}
				return 0.0;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00034B10 File Offset: 0x00032D10
		private double GetDefaultWidth(bool isLabel)
		{
			double num = 120.0;
			if (this._owner != null && this._owner.IsAutoFitWidth && !this._owner.IsHorizontal && this.GetWidthOrHeight(true).IsStar)
			{
				return 0.0;
			}
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = (this._owner != null) ? this._owner.TemplateDataRecordCache : null;
			if (templateDataRecordCache != null)
			{
				if (isLabel && this._owner != null && this._owner.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.CardView)
				{
					return templateDataRecordCache.GetLabelPresenterWidth(this);
				}
				num = templateDataRecordCache.GetDefaultCellWidth(this, num);
			}
			return num;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00034BAB File Offset: 0x00032DAB
		private bool GetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags flag)
		{
			return (flag & this._fieldFlags) != (global::Infragistics.Windows.DataPresenter.Field.FieldFlags)0;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00034BBB File Offset: 0x00032DBB
		private bool GetIsEditorPropChanged(long flag)
		{
			return (this._editorPropsChangedBits & flag) == flag;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00034BC8 File Offset: 0x00032DC8
		private bool GetIsEditorPropSet(long flag)
		{
			return (this._editorPropsSetBits & flag) == flag;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00034BD8 File Offset: 0x00032DD8
		internal static void OnEditorPropChangedCallback(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId propId, object newValue)
		{
			if (field == null)
			{
				return;
			}
			switch (propId)
			{
			case global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Format:
			case global::Infragistics.Windows.DataPresenter.Field.EditorPropId.FormatProvider:
				break;
			default:
				if (propId != global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Mask)
				{
					switch (propId)
					{
					case global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToTextConverter:
					case global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToDisplayTextConverter:
						break;
					default:
						goto IL_36;
					}
				}
				break;
			}
			field._cachedCellTextConverterInfo = null;
			IL_36:
			long flag = 1L << (int)propId;
			field.SetIsEditorPropChanged(flag, true);
			field.SetIsEditorPropSet(flag, newValue != null);
			field._lastEditorPropChanged = propId;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00034C40 File Offset: 0x00032E40
		private void OnMappedFieldPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "ActualPosition")
				{
					this.OnPropertyChanged(e.PropertyName);
					return;
				}
				if (propertyName == "FixedLocation")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedLocationProperty, this._mappedTreeField.FixedLocation);
					return;
				}
				if (propertyName == "IsFixed")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedPropertyKey, this._mappedTreeField.IsFixed);
					return;
				}
				if (propertyName == "IsFixedStateChanging")
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingPropertyKey, this._mappedTreeField.IsFixedStateChanging);
					return;
				}
				if (!(propertyName == "FixedButtonVisibility"))
				{
					return;
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityPropertyKey, this._mappedTreeField.FixedButtonVisibility);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00034D18 File Offset: 0x00032F18
		private void OnNewSettings()
		{
			if (this._settings != null)
			{
				this._settings.PropertyChanged += this.OnSettingsPropertyChanged;
				if (this._settings.HasFieldBinding && this._owner != null)
				{
					this._settings.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.DataContextProperty, this.DataContext);
				}
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00034D6F File Offset: 0x00032F6F
		private static void OnPromotedPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.ProcessResolvedFieldPropertyChanged(target as global::Infragistics.Windows.DataPresenter.Field, e);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00034D7D File Offset: 0x00032F7D
		private void OnSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.ProcessFieldSettingsPropertyChanged(e);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00034D88 File Offset: 0x00032F88
		private void PrepareForExplicitAutoSizeOperation()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._owner;
			if (owner != null)
			{
				owner.EnsureStyleGeneratorInitialized();
				owner.VerifyStyleGeneratorTemplates();
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00034DAC File Offset: 0x00032FAC
		private void ProcessFieldSettingsPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Owner;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (owner != null) ? owner.DataPresenter : null;
			global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, this._settings, this, null != dataPresenterBase, null != owner, this, owner, dataPresenterBase);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00034DEB File Offset: 0x00032FEB
		private static void ProcessResolvedFieldPropertyChanged(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (field == null || field.Owner == null || field.Owner.DataPresenter == null)
			{
				return;
			}
			field.ProcessFieldSettingsPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(e.Property.Name));
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00034E1D File Offset: 0x0003301D
		private void ProcessSizeChange(bool isCell, bool isWidth, global::Infragistics.Windows.DataPresenter.Field.SizeChangeType changeType, double value)
		{
			if (this._owner != null && this._owner.StyleGenerator != null)
			{
				this.BumpLayoutItemVersion();
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00034E3C File Offset: 0x0003303C
		private void SetEditorProperty(global::Infragistics.Windows.Editors.ValueEditor editor, int propIndex)
		{
			global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo editorPropertyInfo = global::Infragistics.Windows.DataPresenter.Field._EditorPropInfos[propIndex];
			object value = base.GetValue(editorPropertyInfo._fieldProperty);
			editor.SetValue(editorPropertyInfo._editorProperty, value);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00034E76 File Offset: 0x00033076
		private void SetFlag(global::Infragistics.Windows.DataPresenter.Field.FieldFlags flag, bool value)
		{
			if (value)
			{
				this._fieldFlags |= flag;
				return;
			}
			this._fieldFlags &= ~flag;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00034E99 File Offset: 0x00033099
		private void SetIsEditorPropChanged(long flag, bool value)
		{
			if (value)
			{
				this._editorPropsChangedBits |= flag;
				return;
			}
			this._editorPropsChangedBits &= ~flag;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00034EBC File Offset: 0x000330BC
		private void SetIsEditorPropSet(long flag, bool value)
		{
			if (value)
			{
				this._editorPropsSetBits |= flag;
				return;
			}
			this._editorPropsSetBits &= ~flag;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00034EE0 File Offset: 0x000330E0
		private void VerifyRecordFilterRelatedCache()
		{
			if (this._isFilterRecordCacheDirty)
			{
				this._isFilterRecordCacheDirty = false;
				this._cachedDefaultFilterOperatorVisibility = global::System.Windows.Visibility.Visible;
				global::System.Type editAsTypeResolved = this.EditAsTypeResolved;
				global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(editAsTypeResolved);
				this._cachedDefaultFilterOperatorDropDownItems = global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperators(editAsTypeResolved, out this._cachedDefaultFilterOperatorDefaultValue);
				if (this.IsEditAsTypeNumeric || typeof(global::System.DateTime) == underlyingType)
				{
					this._cachedDefaultFilterOperandUIType = global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo;
				}
				else if (typeof(bool) == underlyingType)
				{
					this._cachedDefaultFilterOperandUIType = global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor;
					this._cachedDefaultFilterOperatorVisibility = global::System.Windows.Visibility.Collapsed;
				}
				else
				{
					this._cachedDefaultFilterOperandUIType = global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Combo;
				}
				global::Infragistics.Windows.Controls.ComparisonOperatorFlags comparisonOperatorFlag = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorFlag(this.FilterOperatorDefaultValueResolved);
				this._cachedDefaultFilterOperatorDropDownItems |= comparisonOperatorFlag;
				if (((global::Infragistics.Windows.Controls.ComparisonOperatorFlags.In | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotIn) & this._cachedDefaultFilterOperatorDropDownItems) != global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None && global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor == this.FilterOperandUITypeResolved && typeof(global::Infragistics.Windows.Editors.XamTextEditor) != this.EditorTypeResolved)
				{
					this._cachedDefaultFilterOperatorDropDownItems &= ~(global::Infragistics.Windows.Controls.ComparisonOperatorFlags.In | global::Infragistics.Windows.Controls.ComparisonOperatorFlags.NotIn);
				}
				global::Infragistics.Windows.Controls.ComparisonOperatorFlags filterOperatorDropDownItemsResolved = this.FilterOperatorDropDownItemsResolved;
				global::Infragistics.Windows.Controls.ComparisonOperator[] comparisonOperators = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperators(filterOperatorDropDownItemsResolved);
				int num = comparisonOperators.Length;
				if (num <= 1)
				{
					this._cachedDefaultFilterOperatorVisibility = global::System.Windows.Visibility.Collapsed;
				}
				if ((global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorFlag(this._cachedDefaultFilterOperatorDefaultValue) & filterOperatorDropDownItemsResolved) == global::Infragistics.Windows.Controls.ComparisonOperatorFlags.None)
				{
					this._cachedDefaultFilterOperatorDefaultValue = global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperator(editAsTypeResolved, filterOperatorDropDownItemsResolved);
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._owner != null) ? this._owner.DataPresenter : null;
				if (dataPresenterBase != null && dataPresenterBase.IsReportControl)
				{
					this._cachedDefaultFilterOperatorVisibility = global::System.Windows.Visibility.Collapsed;
					this._cachedDefaultFilterOperandUIType = global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None;
				}
				base.RaisePropertyChangedEvent("FilterOperatorDropDownItemsResolved");
				base.RaisePropertyChangedEvent("FilterOperatorDefaultValueResolved");
				base.RaisePropertyChangedEvent("FilterOperandUITypeResolved");
				base.RaisePropertyChangedEvent("FilterOperatorVisibilityResolved");
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00035068 File Offset: 0x00033268
		protected internal virtual bool IsFieldEquatable(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return base.GetType() == field.GetType();
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0003507B File Offset: 0x0003327B
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return this._owner != null && global::Infragistics.Windows.DataPresenter.AllowFieldMoving.No != this._owner.AllowFieldMovingResolved;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00035098 File Offset: 0x00033298
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0003509B File Offset: 0x0003329B
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000350A3 File Offset: 0x000332A3
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040003FE RID: 1022
		internal const double AbsoluteMinimumExtent = 6.0;

		// Token: 0x040003FF RID: 1023
		internal const global::Infragistics.Windows.DataPresenter.CellClickAction DefaultCellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed;

		// Token: 0x04000400 RID: 1024
		internal const global::Infragistics.Windows.DataPresenter.LabelClickAction DefaultLabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.SortByMultipleFields;

		// Token: 0x04000401 RID: 1025
		internal const double FallbackDefaultHeight = 32.0;

		// Token: 0x04000402 RID: 1026
		internal const double FallbackDefaultWidth = 120.0;

		// Token: 0x04000403 RID: 1027
		internal static global::System.Type DEFAULT_DATA_TYPE = typeof(object);

		// Token: 0x04000404 RID: 1028
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x04000405 RID: 1029
		private bool _isPrimary;

		// Token: 0x04000406 RID: 1030
		private bool _autoGenerated;

		// Token: 0x04000407 RID: 1031
		private bool _dataTypeExplicitySet;

		// Token: 0x04000408 RID: 1032
		private bool _nameExplicitySet;

		// Token: 0x04000409 RID: 1033
		private global::Infragistics.Windows.DataPresenter.BindingType _cachedBindingType;

		// Token: 0x0400040A RID: 1034
		private global::System.Windows.Data.BindingBase _alternateBinding;

		// Token: 0x0400040B RID: 1035
		private bool _isBoundToRootProperty;

		// Token: 0x0400040C RID: 1036
		private long _editorPropsSetBits;

		// Token: 0x0400040D RID: 1037
		private long _editorPropsChangedBits;

		// Token: 0x0400040E RID: 1038
		private global::Infragistics.Windows.DataPresenter.Field.EditorPropId _lastEditorPropChanged;

		// Token: 0x0400040F RID: 1039
		private static readonly global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo[] _EditorPropInfos;

		// Token: 0x04000410 RID: 1040
		private global::Infragistics.Windows.DataPresenter.CellBindingCollection _cellBindings;

		// Token: 0x04000411 RID: 1041
		private object _defaultLabel = global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance;

		// Token: 0x04000412 RID: 1042
		private bool _selected;

		// Token: 0x04000413 RID: 1043
		private global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition _cellPosition = new global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition();

		// Token: 0x04000414 RID: 1044
		private global::Infragistics.Windows.DataPresenter.FieldSettings _settings;

		// Token: 0x04000415 RID: 1045
		private bool _isGroupBy;

		// Token: 0x04000416 RID: 1046
		private bool _isExpandableByDefault;

		// Token: 0x04000417 RID: 1047
		private global::System.Type _cachedDataType = global::Infragistics.Windows.DataPresenter.Field.DEFAULT_DATA_TYPE;

		// Token: 0x04000418 RID: 1048
		private global::System.Type _cachedDataTypeUnderlying = global::Infragistics.Windows.DataPresenter.Field.DEFAULT_DATA_TYPE;

		// Token: 0x04000419 RID: 1049
		private bool? _cachedIsExpandable = null;

		// Token: 0x0400041A RID: 1050
		private string _cachedName = string.Empty;

		// Token: 0x0400041B RID: 1051
		private int _index;

		// Token: 0x0400041C RID: 1052
		private int _layoutVersion;

		// Token: 0x0400041D RID: 1053
		private bool _isScrollTip;

		// Token: 0x0400041E RID: 1054
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.LabelPresenter> _cachedLabelPresenters;

		// Token: 0x0400041F RID: 1055
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.CellValuePresenter> _cachedCellValuePresenters;

		// Token: 0x04000420 RID: 1056
		private static global::System.Collections.Hashtable sampleData = null;

		// Token: 0x04000421 RID: 1057
		private int _templateCellIndex = -1;

		// Token: 0x04000422 RID: 1058
		private global::Infragistics.Windows.DataPresenter.CellElementKey _cellElementKey;

		// Token: 0x04000423 RID: 1059
		private global::Infragistics.Windows.DataPresenter.LabelElementKey _labelElementKey;

		// Token: 0x04000424 RID: 1060
		private global::Infragistics.Windows.DataPresenter.FilterCellElementKey _filterCellElementKey;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Data.IValueConverter _converter;

		// Token: 0x04000426 RID: 1062
		private object _converterParameter;

		// Token: 0x04000427 RID: 1063
		private global::System.Globalization.CultureInfo _converterCulture;

		// Token: 0x04000428 RID: 1064
		private global::System.Globalization.CultureInfo _converterCultureResolved;

		// Token: 0x04000429 RID: 1065
		private global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo _explicitResizeInfo;

		// Token: 0x0400042A RID: 1066
		private bool _isFilterRecordCacheDirty = true;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Visibility _cachedDefaultFilterOperatorVisibility;

		// Token: 0x0400042C RID: 1068
		private global::Infragistics.Windows.Controls.ComparisonOperator _cachedDefaultFilterOperatorDefaultValue;

		// Token: 0x0400042D RID: 1069
		private global::Infragistics.Windows.DataPresenter.FilterOperandUIType _cachedDefaultFilterOperandUIType;

		// Token: 0x0400042E RID: 1070
		private global::Infragistics.Windows.Controls.ComparisonOperatorFlags _cachedDefaultFilterOperatorDropDownItems;

		// Token: 0x0400042F RID: 1071
		private int _labelLineCount;

		// Token: 0x04000430 RID: 1072
		private global::Infragistics.Windows.DataPresenter.FieldLayoutItem _cellLayoutItem;

		// Token: 0x04000431 RID: 1073
		private global::Infragistics.Windows.DataPresenter.FieldLayoutItem _labelLayoutItem;

		// Token: 0x04000432 RID: 1074
		private global::Infragistics.Windows.DataPresenter.GridBagConstraint _layoutConstraint;

		// Token: 0x04000433 RID: 1075
		private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager _cachedCPLayoutManager;

		// Token: 0x04000434 RID: 1076
		private global::Infragistics.Windows.DataPresenter.Field.FieldFlags _fieldFlags;

		// Token: 0x04000435 RID: 1077
		private int _navigationIndex;

		// Token: 0x04000436 RID: 1078
		private int _navigationIndexCompressedCell;

		// Token: 0x04000437 RID: 1079
		private int _navigationIndexCompressedLabel;

		// Token: 0x04000438 RID: 1080
		private bool _hasCellValuePresenterStyleSelector;

		// Token: 0x04000439 RID: 1081
		private bool _hasEditorStyleSelector;

		// Token: 0x0400043A RID: 1082
		private global::System.Type _cachedEditAsTypeResolved;

		// Token: 0x0400043B RID: 1083
		private global::System.Type _cachedEditAsTypeResolvedUnderlying;

		// Token: 0x0400043C RID: 1084
		private global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior _cachedNonSpecificNotificationBehavior;

		// Token: 0x0400043D RID: 1085
		private global::Infragistics.Windows.DataPresenter.IGroupByEvaluator _cachedGroupByEvaluator;

		// Token: 0x0400043E RID: 1086
		internal global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _cachedCellTextConverterInfo;

		// Token: 0x0400043F RID: 1087
		private bool _ignoreFieldVisibilityOverrides;

		// Token: 0x04000440 RID: 1088
		private global::Infragistics.Windows.DataPresenter.FieldLength? _cachedWidth;

		// Token: 0x04000441 RID: 1089
		private global::Infragistics.Windows.DataPresenter.FieldLength? _cachedHeight;

		// Token: 0x04000442 RID: 1090
		internal bool _hasPendingInitialAutoSize = true;

		// Token: 0x04000443 RID: 1091
		private bool _isPropertyDescriptorInitialized;

		// Token: 0x04000444 RID: 1092
		private int _autoSizeVersion = 1;

		// Token: 0x04000445 RID: 1093
		private global::Infragistics.Windows.DataPresenter.FixedFieldLocation _cachedFixedLocation;

		// Token: 0x04000446 RID: 1094
		private bool? _cachedDataValueChangedNotificationsActiveResolved;

		// Token: 0x04000447 RID: 1095
		private int? _cachedDataValueChangedHistoryLimitResolved;

		// Token: 0x04000448 RID: 1096
		private int _cachedSupportDataErrorInfoResolved = -1;

		// Token: 0x04000449 RID: 1097
		private global::System.Collections.Generic.Dictionary<string, string> _cachedSummaryStringFormats;

		// Token: 0x0400044A RID: 1098
		private global::Infragistics.Windows.DataPresenter.DataValueChangedScope? _cachedDataValueChangedScopeResolved;

		// Token: 0x0400044B RID: 1099
		private global::System.Windows.Data.Binding _cellContentAlignmentBinding;

		// Token: 0x0400044C RID: 1100
		private global::System.Windows.Data.Binding _visibilityBinding;

		// Token: 0x0400044D RID: 1101
		private int _propertyDescriptorVersion;

		// Token: 0x0400044E RID: 1102
		private int _layoutItemVersion;

		// Token: 0x0400044F RID: 1103
		private global::Infragistics.Windows.DataPresenter.CellContentAlignment? _cachedCellContentAlignmentResolved;

		// Token: 0x04000450 RID: 1104
		private global::Infragistics.Windows.DataPresenter.Field _mappedTreeField;

		// Token: 0x04000451 RID: 1105
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.Field> _fieldsMappedToThisField;

		// Token: 0x04000452 RID: 1106
		private bool _cachedIsTreeField;

		// Token: 0x04000453 RID: 1107
		private bool _wasEverTreeField;

		// Token: 0x04000454 RID: 1108
		[global::System.ThreadStatic]
		internal static global::Infragistics.Windows.DataPresenter.Field _UnMappedField;

		// Token: 0x04000455 RID: 1109
		public static readonly global::System.Windows.DependencyProperty AcceptsArrowKeysInEditModeProperty = global::Infragistics.Windows.Editors.ValueEditor.AcceptsArrowKeysInEditModeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnAcceptsArrowKeysInEditModeChanged)));

		// Token: 0x04000456 RID: 1110
		public static readonly global::System.Windows.DependencyProperty AlternateBindingRetentionModeProperty = global::System.Windows.DependencyProperty.Register("AlternateBindingRetentionMode", typeof(global::Infragistics.Windows.DataPresenter.BindingRetentionMode), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingRetentionMode.AutoRelease));

		// Token: 0x04000457 RID: 1111
		public static readonly global::System.Windows.DependencyProperty AllowEditProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowEditProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x04000458 RID: 1112
		public static readonly global::System.Windows.DependencyProperty AllowFixingProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowFixingProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x04000459 RID: 1113
		public static readonly global::System.Windows.DependencyProperty AllowGroupByProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowGroupByProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400045A RID: 1114
		public static readonly global::System.Windows.DependencyProperty AllowHidingProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowHidingProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400045B RID: 1115
		public static readonly global::System.Windows.DependencyProperty AllowRecordFilteringProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowRecordFilteringProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400045C RID: 1116
		public static readonly global::System.Windows.DependencyProperty AllowResizeProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.AllowResizeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400045D RID: 1117
		public static readonly global::System.Windows.DependencyProperty AlwaysValidateProperty = global::Infragistics.Windows.Editors.ValueEditor.AlwaysValidateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnAlwaysValidateChanged)));

		// Token: 0x0400045E RID: 1118
		public static readonly global::System.Windows.DependencyProperty BindingTypeProperty = global::System.Windows.DependencyProperty.Register("BindingType", typeof(global::Infragistics.Windows.DataPresenter.BindingType), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnBindingTypeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.CoerceBindingType)));

		// Token: 0x0400045F RID: 1119
		public static readonly global::System.Windows.DependencyProperty CalculationSettingsProperty = global::System.Windows.DependencyProperty.Register("CalculationSettings", typeof(global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnCalculationSettingsChanged)));

		// Token: 0x04000460 RID: 1120
		private global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings _calculationSettings;

		// Token: 0x04000461 RID: 1121
		public static readonly global::System.Windows.DependencyProperty CellValuePresenterStyleProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnCellValuePresenterStyleChanged)));

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Style _cachedCellValuePresenterStyle;

		// Token: 0x04000463 RID: 1123
		public static readonly global::System.Windows.DependencyProperty ColumnProperty = global::System.Windows.DependencyProperty.Register("Column", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnRowOrColumnChange)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnValidateRowColumnSetting));

		// Token: 0x04000464 RID: 1124
		public static readonly global::System.Windows.DependencyProperty ColumnSpanProperty = global::System.Windows.DependencyProperty.Register("ColumnSpan", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnRowOrColumnChange), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnCoerceRowColumnSpan)));

		// Token: 0x04000465 RID: 1125
		public static readonly global::System.Windows.DependencyProperty ConverterProperty = global::System.Windows.DependencyProperty.Register("Converter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnConverterChanged)));

		// Token: 0x04000466 RID: 1126
		public static readonly global::System.Windows.DependencyProperty ConverterCultureProperty = global::System.Windows.DependencyProperty.Register("ConverterCulture", typeof(global::System.Globalization.CultureInfo), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnConverterCultureChanged)));

		// Token: 0x04000467 RID: 1127
		public static readonly global::System.Windows.DependencyProperty ConverterParameterProperty = global::System.Windows.DependencyProperty.Register("ConverterParameter", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnConverterParameterChanged)));

		// Token: 0x04000468 RID: 1128
		public static readonly global::System.Windows.DependencyProperty DataContextProperty;

		// Token: 0x04000469 RID: 1129
		public static readonly global::System.Windows.DependencyProperty DataTypeProperty = global::System.Windows.DependencyProperty.Register("DataType", typeof(global::System.Type), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.Field.DEFAULT_DATA_TYPE), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnValidateDataType));

		// Token: 0x0400046A RID: 1130
		public static readonly global::System.Windows.DependencyProperty DisallowModificationViaClipboardProperty = global::System.Windows.DependencyProperty.Register("DisallowModificationViaClipboard", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400046B RID: 1131
		public static readonly global::System.Windows.DependencyProperty EditorStyleProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400046C RID: 1132
		public static readonly global::System.Windows.DependencyProperty EditorTypeProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.EditorTypeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400046D RID: 1133
		public static readonly global::System.Windows.DependencyProperty EditAsTypeProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.EditAsTypeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x0400046E RID: 1134
		private static readonly global::System.Windows.DependencyPropertyKey FixedButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x0400046F RID: 1135
		public static readonly global::System.Windows.DependencyProperty FixedButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.Field.FixedButtonVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000470 RID: 1136
		public static readonly global::System.Windows.DependencyProperty FixedLocationProperty = global::System.Windows.DependencyProperty.Register("FixedLocation", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldLocation), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnFixedLocationChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.CoerceFixedLocation)));

		// Token: 0x04000471 RID: 1137
		private static object FixedFieldLocationScrollable = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;

		// Token: 0x04000472 RID: 1138
		private global::Infragistics.Windows.DataPresenter.FixedFieldLocation _actualFixedLocation;

		// Token: 0x04000473 RID: 1139
		public static readonly global::System.Windows.DependencyProperty FormatProperty = global::Infragistics.Windows.Editors.ValueEditor.FormatProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnFormatChanged)));

		// Token: 0x04000474 RID: 1140
		public static readonly global::System.Windows.DependencyProperty FormatProviderProperty = global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnFormatProviderChanged)));

		// Token: 0x04000475 RID: 1141
		public static readonly global::System.Windows.DependencyProperty GroupByModeProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByModeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnPromotedPropertyChanged), null));

		// Token: 0x04000476 RID: 1142
		public static readonly global::System.Windows.DependencyProperty HeightProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.HeightProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnWidthHeightChanged)));

		// Token: 0x04000477 RID: 1143
		public static readonly global::System.Windows.DependencyProperty HorizontalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("HorizontalContentAlignment", typeof(global::System.Windows.HorizontalAlignment?), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnHorizontalContentAlignmentChanged)));

		// Token: 0x04000478 RID: 1144
		public static readonly global::System.Windows.DependencyProperty InvalidValueBehaviorProperty = global::System.Windows.DependencyProperty.Register("InvalidValueBehavior", typeof(global::Infragistics.Windows.Editors.InvalidValueBehavior?), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnInvalidValueBehaviorChanged)));

		// Token: 0x04000479 RID: 1145
		public static readonly global::System.Windows.DependencyProperty IsEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400047A RID: 1146
		public static readonly global::System.Windows.DependencyProperty IsEnabledInAddRecordProperty = global::System.Windows.DependencyProperty.Register("IsEnabledInAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400047B RID: 1147
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public static readonly global::System.Windows.DependencyProperty IsExpandableProperty = global::System.Windows.DependencyProperty.Register("IsExpandable", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400047C RID: 1148
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400047D RID: 1149
		public static readonly global::System.Windows.DependencyProperty IsFixedProperty = global::Infragistics.Windows.DataPresenter.Field.IsFixedPropertyKey.DependencyProperty;

		// Token: 0x0400047E RID: 1150
		internal static readonly global::System.Windows.DependencyPropertyKey IsFixedStateChangingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedStateChanging", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400047F RID: 1151
		public static readonly global::System.Windows.DependencyProperty IsFixedStateChangingProperty = global::Infragistics.Windows.DataPresenter.Field.IsFixedStateChangingPropertyKey.DependencyProperty;

		// Token: 0x04000480 RID: 1152
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnIsReadOnlyChanged)));

		// Token: 0x04000481 RID: 1153
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnCoerceIsSelected)));

		// Token: 0x04000482 RID: 1154
		public static readonly global::System.Windows.DependencyProperty IsTabStopProperty = global::System.Windows.DependencyProperty.Register("IsTabStop", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000483 RID: 1155
		public static readonly global::System.Windows.DependencyProperty IsTabStopInAddRecordProperty = global::System.Windows.DependencyProperty.Register("IsTabStopInAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000484 RID: 1156
		private static readonly global::System.Windows.DependencyPropertyKey IsTreeFieldPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTreeField", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnIsTreeFieldChanged)));

		// Token: 0x04000485 RID: 1157
		public static readonly global::System.Windows.DependencyProperty IsTreeFieldProperty = global::Infragistics.Windows.DataPresenter.Field.IsTreeFieldPropertyKey.DependencyProperty;

		// Token: 0x04000486 RID: 1158
		protected static readonly global::System.Windows.DependencyPropertyKey IsUnboundPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUnbound", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000487 RID: 1159
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Obsolete("Use BindingType instead", false)]
		public static readonly global::System.Windows.DependencyProperty IsUnboundProperty = global::Infragistics.Windows.DataPresenter.Field.IsUnboundPropertyKey.DependencyProperty;

		// Token: 0x04000488 RID: 1160
		public static readonly global::System.Windows.DependencyProperty LabelProperty = global::System.Windows.DependencyProperty.Register("Label", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnLabelChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.CoerceLabel)));

		// Token: 0x04000489 RID: 1161
		private object _cachedLabel;

		// Token: 0x0400048A RID: 1162
		public static readonly global::System.Windows.DependencyProperty NameProperty = global::System.Windows.DependencyProperty.Register("Name", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnNameChanged)));

		// Token: 0x0400048B RID: 1163
		public static readonly global::System.Windows.DependencyProperty RowProperty = global::System.Windows.DependencyProperty.Register("Row", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnRowOrColumnChange)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnValidateRowColumnSetting));

		// Token: 0x0400048C RID: 1164
		public static readonly global::System.Windows.DependencyProperty RowSpanProperty = global::System.Windows.DependencyProperty.Register("RowSpan", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnRowOrColumnChange), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.Field.OnCoerceRowColumnSpan)));

		// Token: 0x0400048D RID: 1165
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatus", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnSortStatusChanged)));

		// Token: 0x0400048E RID: 1166
		private global::Infragistics.Windows.Controls.SortStatus _cachedSortStatus;

		// Token: 0x0400048F RID: 1167
		public static readonly global::System.Windows.DependencyProperty SortStatusProperty = global::Infragistics.Windows.DataPresenter.Field.SortStatusPropertyKey.DependencyProperty;

		// Token: 0x04000490 RID: 1168
		private static readonly global::System.Windows.DependencyPropertyKey SortStatusGroupByPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortStatusGroupBy", typeof(global::Infragistics.Windows.Controls.SortStatus), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SortStatus.NotSorted, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnSortStatusGroupByChanged)));

		// Token: 0x04000491 RID: 1169
		private global::Infragistics.Windows.Controls.SortStatus _cachedSortStatusGroupBy;

		// Token: 0x04000492 RID: 1170
		public static readonly global::System.Windows.DependencyProperty SortStatusGroupByProperty = global::Infragistics.Windows.DataPresenter.Field.SortStatusGroupByPropertyKey.DependencyProperty;

		// Token: 0x04000493 RID: 1171
		public static readonly global::System.Windows.DependencyProperty SummaryStringFormatsProperty = global::System.Windows.DependencyProperty.Register("SummaryStringFormats", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnSummaryStringFormatsChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.Field.ValidateSummaryStringFormats));

		// Token: 0x04000494 RID: 1172
		public static readonly global::System.Windows.DependencyProperty TagProperty = global::System.Windows.FrameworkElement.TagProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field));

		// Token: 0x04000495 RID: 1173
		public static readonly global::System.Windows.DependencyProperty ToolTipProperty = global::System.Windows.DependencyProperty.Register("ToolTip", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000496 RID: 1174
		public static readonly global::System.Windows.DependencyProperty ValueConstraintProperty = global::Infragistics.Windows.Editors.ValueEditor.ValueConstraintProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnValueConstraintChanged)));

		// Token: 0x04000497 RID: 1175
		public static readonly global::System.Windows.DependencyProperty ValueToTextConverterProperty = global::Infragistics.Windows.Editors.ValueEditor.ValueToTextConverterProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnValueToTextConverteChanged)));

		// Token: 0x04000498 RID: 1176
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.InvalidValueBehavior>))]
		public static readonly global::System.Windows.DependencyProperty VerticalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register("VerticalContentAlignment", typeof(global::System.Windows.VerticalAlignment?), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnVerticalContentAlignmentChanged)));

		// Token: 0x04000499 RID: 1177
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnVisibilityChanged)));

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Visibility _cachedVisibility;

		// Token: 0x0400049B RID: 1179
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::Infragistics.Windows.DataPresenter.FieldSettings.WidthProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Field.OnWidthHeightChanged)));

		// Token: 0x0400049C RID: 1180
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.Field));

		// Token: 0x020000D5 RID: 213
		private class ResizeValues
		{
			// Token: 0x040004A2 RID: 1186
			internal double LabelResizeWidth = double.NaN;

			// Token: 0x040004A3 RID: 1187
			internal double LabelResizeHeight = double.NaN;

			// Token: 0x040004A4 RID: 1188
			internal double CellResizeWidth = double.NaN;

			// Token: 0x040004A5 RID: 1189
			internal double CellResizeHeight = double.NaN;
		}

		// Token: 0x020000D6 RID: 214
		internal class FieldResizeInfo
		{
			// Token: 0x06000BDE RID: 3038 RVA: 0x000350F8 File Offset: 0x000332F8
			internal FieldResizeInfo(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
				this._field = field;
				this._labelWidth = (this._labelHeight = (this._cellWidth = (this._cellHeight = global::Infragistics.Windows.DataPresenter.FieldSize.Empty)));
			}

			// Token: 0x06000BDF RID: 3039 RVA: 0x0003513E File Offset: 0x0003333E
			internal FieldResizeInfo(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo initializeFrom) : this(field)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(initializeFrom);
				this._cellHeight = initializeFrom._cellHeight;
				this._cellWidth = initializeFrom._cellWidth;
				this._labelHeight = initializeFrom._labelHeight;
				this._labelWidth = initializeFrom._labelWidth;
			}

			// Token: 0x06000BE0 RID: 3040 RVA: 0x00035180 File Offset: 0x00033380
			public override int GetHashCode()
			{
				return this._field.GetHashCode() | this._cellHeight.GetHashCode() | this._cellWidth.GetHashCode() | this._labelHeight.GetHashCode() | this._labelWidth.GetHashCode();
			}

			// Token: 0x06000BE1 RID: 3041 RVA: 0x000351E0 File Offset: 0x000333E0
			public override bool Equals(object obj)
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo fieldResizeInfo = obj as global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo;
				return fieldResizeInfo != null && this._field == fieldResizeInfo._field && this._cellHeight.Equals(fieldResizeInfo._cellHeight) && this._cellWidth.Equals(fieldResizeInfo._cellWidth) && this._labelHeight.Equals(fieldResizeInfo._labelHeight) && this._labelWidth.Equals(fieldResizeInfo._labelWidth);
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00035251 File Offset: 0x00033451
			internal global::Infragistics.Windows.DataPresenter.Field Field
			{
				get
				{
					return this._field;
				}
			}

			// Token: 0x06000BE3 RID: 3043 RVA: 0x0003525C File Offset: 0x0003345C
			internal void ClearAuto(bool label, bool width)
			{
				if (this.GetSize(label, width).HasAutoModeSize)
				{
					this.SetSize(label, width, global::Infragistics.Windows.DataPresenter.FieldSize.Empty);
				}
			}

			// Token: 0x06000BE4 RID: 3044 RVA: 0x00035288 File Offset: 0x00033488
			internal void ClearExplicit(bool label, bool width)
			{
				if (this.GetSize(label, width).HasExplicitSize)
				{
					this.SetSize(label, width, global::Infragistics.Windows.DataPresenter.FieldSize.Empty);
				}
			}

			// Token: 0x06000BE5 RID: 3045 RVA: 0x000352B4 File Offset: 0x000334B4
			public global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo Clone()
			{
				return (global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo)base.MemberwiseClone();
			}

			// Token: 0x06000BE6 RID: 3046 RVA: 0x000352C1 File Offset: 0x000334C1
			internal global::Infragistics.Windows.DataPresenter.FieldSize GetSize(bool label, bool width)
			{
				if (label)
				{
					if (!width)
					{
						return this._labelHeight;
					}
					return this._labelWidth;
				}
				else
				{
					if (!width)
					{
						return this._cellHeight;
					}
					return this._cellWidth;
				}
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x000352E8 File Offset: 0x000334E8
			internal void InitializeFrom(global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo resizeInfo)
			{
				if (this.Equals(resizeInfo))
				{
					return;
				}
				this._cellHeight = resizeInfo._cellHeight;
				this._cellWidth = resizeInfo._cellWidth;
				this._labelHeight = resizeInfo._labelHeight;
				this._labelWidth = resizeInfo._labelWidth;
				this.OnPropertyChanged("");
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x0003533A File Offset: 0x0003353A
			private void OnPropertyChanged(string propertyName)
			{
				this._field.BumpLayoutItemVersion();
				this._field.RaisePropertyChangedEvent(propertyName);
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x00035353 File Offset: 0x00033553
			internal void Reset()
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo.ResetNonAutoMode(ref this._cellHeight);
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo.ResetNonAutoMode(ref this._cellWidth);
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo.ResetNonAutoMode(ref this._labelHeight);
				global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo.ResetNonAutoMode(ref this._labelWidth);
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x00035381 File Offset: 0x00033581
			private static void ResetNonAutoMode(ref global::Infragistics.Windows.DataPresenter.FieldSize size)
			{
				if (size.Type != global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode)
				{
					size = new global::Infragistics.Windows.DataPresenter.FieldSize(double.NaN);
				}
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x000353A0 File Offset: 0x000335A0
			internal void Restrict(bool label, bool width, double min, double max)
			{
				global::Infragistics.Windows.DataPresenter.FieldSize size = this.GetSize(label, width);
				double value = global::Infragistics.Windows.DataPresenter.Field.FieldResizeInfo.RestrictHelper(size.Value, min, max);
				if (!value.Equals(size.Value))
				{
					this.SetSize(label, width, new global::Infragistics.Windows.DataPresenter.FieldSize(value, size.Type));
				}
			}

			// Token: 0x06000BEC RID: 3052 RVA: 0x000353EB File Offset: 0x000335EB
			internal static double RestrictHelper(double val, double min, double max)
			{
				if (double.IsNaN(val))
				{
					return val;
				}
				if (!double.IsNaN(min))
				{
					val = global::System.Math.Max(min, val);
				}
				if (!double.IsNaN(max))
				{
					val = global::System.Math.Min(max, val);
				}
				return val;
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x0003541C File Offset: 0x0003361C
			internal void SetSize(bool label, bool width, global::Infragistics.Windows.DataPresenter.FieldSize size)
			{
				if (label)
				{
					if (width)
					{
						this.SetSize(ref this._labelWidth, size, "LabelWidthResolved");
						return;
					}
					this.SetSize(ref this._labelHeight, size, "LabelHeightResolved");
					return;
				}
				else
				{
					if (width)
					{
						this.SetSize(ref this._cellWidth, size, "CellWidthResolved");
						return;
					}
					this.SetSize(ref this._cellHeight, size, "CellHeightResolved");
					return;
				}
			}

			// Token: 0x06000BEE RID: 3054 RVA: 0x00035480 File Offset: 0x00033680
			private void SetSize(ref global::Infragistics.Windows.DataPresenter.FieldSize member, global::Infragistics.Windows.DataPresenter.FieldSize newValue, string propertyName)
			{
				if (!member.Equals(newValue))
				{
					if (member.IsAuto != newValue.IsAuto && this._field._owner != null)
					{
						this._field._owner.BumpLayoutManagerVersion();
					}
					member = newValue;
					this.OnPropertyChanged(propertyName);
				}
			}

			// Token: 0x040004A6 RID: 1190
			private global::Infragistics.Windows.DataPresenter.Field _field;

			// Token: 0x040004A7 RID: 1191
			private global::Infragistics.Windows.DataPresenter.FieldSize _labelWidth;

			// Token: 0x040004A8 RID: 1192
			private global::Infragistics.Windows.DataPresenter.FieldSize _labelHeight;

			// Token: 0x040004A9 RID: 1193
			private global::Infragistics.Windows.DataPresenter.FieldSize _cellWidth;

			// Token: 0x040004AA RID: 1194
			private global::Infragistics.Windows.DataPresenter.FieldSize _cellHeight;
		}

		// Token: 0x020000D7 RID: 215
		internal class FieldGridPosition
		{
			// Token: 0x06000BEF RID: 3055 RVA: 0x000354D0 File Offset: 0x000336D0
			public override string ToString()
			{
				return string.Format("{0},{1},{2},{3}", new object[]
				{
					this.Row,
					this.Column,
					this.RowSpan,
					this.ColumnSpan
				});
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00035527 File Offset: 0x00033727
			internal bool IsEmpty
			{
				get
				{
					return this.Row == 0 && this.Column == 0 && this.RowSpan == 0 && 0 == this.ColumnSpan;
				}
			}

			// Token: 0x040004AB RID: 1195
			internal int Row;

			// Token: 0x040004AC RID: 1196
			internal int Column;

			// Token: 0x040004AD RID: 1197
			internal int RowSpan;

			// Token: 0x040004AE RID: 1198
			internal int ColumnSpan;
		}

		// Token: 0x020000D8 RID: 216
		internal class DefaultValueMarker
		{
			// Token: 0x06000BF2 RID: 3058 RVA: 0x00035554 File Offset: 0x00033754
			public override string ToString()
			{
				return string.Empty;
			}

			// Token: 0x040004AF RID: 1199
			internal static global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker Instance = new global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker();
		}

		// Token: 0x020000D9 RID: 217
		[global::System.Flags]
		private enum FieldFlags
		{
			// Token: 0x040004B1 RID: 1201
			CellVirtualized = 1,
			// Token: 0x040004B2 RID: 1202
			LabelVirtualized = 2,
			// Token: 0x040004B3 RID: 1203
			FilterCellVirtualized = 4,
			// Token: 0x040004B4 RID: 1204
			IsInLayout = 8,
			// Token: 0x040004B5 RID: 1205
			SuppressFixedLocationInvalidate = 16
		}

		// Token: 0x020000DA RID: 218
		private enum SizeChangeType
		{
			// Token: 0x040004B7 RID: 1207
			Min,
			// Token: 0x040004B8 RID: 1208
			Max,
			// Token: 0x040004B9 RID: 1209
			Size
		}

		// Token: 0x020000DB RID: 219
		private class StringCellValueEqualityComparer : global::System.Collections.IEqualityComparer
		{
			// Token: 0x06000BF5 RID: 3061 RVA: 0x0003556F File Offset: 0x0003376F
			internal StringCellValueEqualityComparer(global::System.StringComparer comparer)
			{
				this._comparer = comparer;
			}

			// Token: 0x06000BF6 RID: 3062 RVA: 0x0003557E File Offset: 0x0003377E
			bool global::System.Collections.IEqualityComparer.Equals(object x, object y)
			{
				if (x is string && y is string)
				{
					return this._comparer.Equals(x, y);
				}
				return object.Equals(x, y);
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x000355A5 File Offset: 0x000337A5
			int global::System.Collections.IEqualityComparer.GetHashCode(object obj)
			{
				return this._comparer.GetHashCode(obj);
			}

			// Token: 0x040004BA RID: 1210
			private global::System.StringComparer _comparer;
		}

		// Token: 0x020000DC RID: 220
		internal enum EditorPropId : short
		{
			// Token: 0x040004BC RID: 1212
			AcceptsArrowKeysInEditMode,
			// Token: 0x040004BD RID: 1213
			AcceptsReturn,
			// Token: 0x040004BE RID: 1214
			AcceptsTab,
			// Token: 0x040004BF RID: 1215
			AllowDropDown,
			// Token: 0x040004C0 RID: 1216
			AllowShiftingAcrossSections,
			// Token: 0x040004C1 RID: 1217
			AlwaysValidate,
			// Token: 0x040004C2 RID: 1218
			AutoFillDate,
			// Token: 0x040004C3 RID: 1219
			ClipMode,
			// Token: 0x040004C4 RID: 1220
			ComboBoxStyle,
			// Token: 0x040004C5 RID: 1221
			DataMode,
			// Token: 0x040004C6 RID: 1222
			DisplayMemberPath,
			// Token: 0x040004C7 RID: 1223
			DisplayMode,
			// Token: 0x040004C8 RID: 1224
			DisplayTemplate,
			// Token: 0x040004C9 RID: 1225
			DisplayValueSource,
			// Token: 0x040004CA RID: 1226
			DropDownButtonDisplayMode,
			// Token: 0x040004CB RID: 1227
			DropDownButtonStyle,
			// Token: 0x040004CC RID: 1228
			DropDownResizeMode,
			// Token: 0x040004CD RID: 1229
			EditTemplate,
			// Token: 0x040004CE RID: 1230
			Format,
			// Token: 0x040004CF RID: 1231
			FormatProvider,
			// Token: 0x040004D0 RID: 1232
			HorizontalContentAlignment,
			// Token: 0x040004D1 RID: 1233
			HorizontalScrollbarVisibility,
			// Token: 0x040004D2 RID: 1234
			InvalidValueBehavior,
			// Token: 0x040004D3 RID: 1235
			IsEditable,
			// Token: 0x040004D4 RID: 1236
			IsReadOnly,
			// Token: 0x040004D5 RID: 1237
			IsThreeState,
			// Token: 0x040004D6 RID: 1238
			ItemsSource,
			// Token: 0x040004D7 RID: 1239
			LimitToList,
			// Token: 0x040004D8 RID: 1240
			Mask,
			// Token: 0x040004D9 RID: 1241
			MaxDropDownHeight,
			// Token: 0x040004DA RID: 1242
			MaxDropDownWidth,
			// Token: 0x040004DB RID: 1243
			MinDropDownWidth,
			// Token: 0x040004DC RID: 1244
			NullText,
			// Token: 0x040004DD RID: 1245
			PadChar,
			// Token: 0x040004DE RID: 1246
			PreDropDownAreaTemplate,
			// Token: 0x040004DF RID: 1247
			PromptChar,
			// Token: 0x040004E0 RID: 1248
			PostDropDownAreaTemplate,
			// Token: 0x040004E1 RID: 1249
			SelectAllBehavior,
			// Token: 0x040004E2 RID: 1250
			SpinButtonDisplayMode,
			// Token: 0x040004E3 RID: 1251
			SpinButtonStyle,
			// Token: 0x040004E4 RID: 1252
			SpinIncrement,
			// Token: 0x040004E5 RID: 1253
			SpinWrap,
			// Token: 0x040004E6 RID: 1254
			TabNavigation,
			// Token: 0x040004E7 RID: 1255
			TextWrapping,
			// Token: 0x040004E8 RID: 1256
			TextAlignment,
			// Token: 0x040004E9 RID: 1257
			TrimFractionalZeros,
			// Token: 0x040004EA RID: 1258
			ValueConstraint,
			// Token: 0x040004EB RID: 1259
			ValueToTextConverter,
			// Token: 0x040004EC RID: 1260
			ValueToDisplayTextConverter,
			// Token: 0x040004ED RID: 1261
			ValuePath,
			// Token: 0x040004EE RID: 1262
			VerticalContentAlignment,
			// Token: 0x040004EF RID: 1263
			VerticalScrollbarVisibility,
			// Token: 0x040004F0 RID: 1264
			LastValueMarker
		}

		// Token: 0x020000DD RID: 221
		private struct EditorPropertyInfo : global::System.IComparable<global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo>
		{
			// Token: 0x06000BF8 RID: 3064 RVA: 0x000355B3 File Offset: 0x000337B3
			internal EditorPropertyInfo(global::Infragistics.Windows.DataPresenter.Field.EditorPropId propId, global::System.Windows.DependencyProperty editorProperty, global::System.Windows.DependencyProperty fieldProperty)
			{
				this._index = (short)propId;
				this._bit = 1L << (int)this._index;
				this._editorProperty = editorProperty;
				this._fieldProperty = fieldProperty;
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x000355DC File Offset: 0x000337DC
			public int CompareTo(global::Infragistics.Windows.DataPresenter.Field.EditorPropertyInfo other)
			{
				return this._bit.CompareTo(other._bit);
			}

			// Token: 0x040004F1 RID: 1265
			internal readonly long _bit;

			// Token: 0x040004F2 RID: 1266
			internal readonly short _index;

			// Token: 0x040004F3 RID: 1267
			internal readonly global::System.Windows.DependencyProperty _editorProperty;

			// Token: 0x040004F4 RID: 1268
			internal readonly global::System.Windows.DependencyProperty _fieldProperty;
		}
	}
}
