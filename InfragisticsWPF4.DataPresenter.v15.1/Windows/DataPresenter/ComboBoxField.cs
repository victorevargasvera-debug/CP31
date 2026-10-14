using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E0 RID: 224
	[global::System.Windows.StyleTypedProperty(Property = "ComboBoxStyle", StyleTargetType = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	public class ComboBoxField : global::Infragistics.Windows.DataPresenter.TextFieldBase
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003575B File Offset: 0x0003395B
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamComboEditor);
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00035768 File Offset: 0x00033968
		protected internal override bool IsFieldEquatable(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.ComboBoxField comboBoxField = field as global::Infragistics.Windows.DataPresenter.ComboBoxField;
			if (comboBoxField == null)
			{
				return false;
			}
			if (base.IsFieldEquatable(field) && comboBoxField.ItemsSource == this.ItemsSource && comboBoxField.ValuePath == this.ValuePath && comboBoxField.DisplayMemberPath == this.DisplayMemberPath && comboBoxField.DisplayValueSource == this.DisplayValueSource && comboBoxField.IsEditable == this.IsEditable && comboBoxField.LimitToList == this.LimitToList)
			{
				double? maxDropDownHeight = comboBoxField.MaxDropDownHeight;
				double? maxDropDownHeight2 = this.MaxDropDownHeight;
				if (maxDropDownHeight.GetValueOrDefault() == maxDropDownHeight2.GetValueOrDefault() && maxDropDownHeight != null == (maxDropDownHeight2 != null))
				{
					double? maxDropDownWidth = comboBoxField.MaxDropDownWidth;
					double? maxDropDownWidth2 = this.MaxDropDownWidth;
					if (maxDropDownWidth.GetValueOrDefault() == maxDropDownWidth2.GetValueOrDefault() && maxDropDownWidth != null == (maxDropDownWidth2 != null))
					{
						double? minDropDownWidth = comboBoxField.MinDropDownWidth;
						double? minDropDownWidth2 = this.MinDropDownWidth;
						if (minDropDownWidth.GetValueOrDefault() == minDropDownWidth2.GetValueOrDefault() && minDropDownWidth != null == (minDropDownWidth2 != null) && comboBoxField.PreDropDownAreaTemplate == this.PreDropDownAreaTemplate)
						{
							return comboBoxField.PostDropDownAreaTemplate == this.PostDropDownAreaTemplate;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00035935 File Offset: 0x00033B35
		private static void OnComboBoxStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ComboBoxStyle, e.NewValue);
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003594A File Offset: 0x00033B4A
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0003595C File Offset: 0x00033B5C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ComboBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ComboBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ComboBoxStyleProperty, value);
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0003596A File Offset: 0x00033B6A
		private static void OnDisplayMemberPathChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayMemberPath, e.NewValue);
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00035980 File Offset: 0x00033B80
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00035992 File Offset: 0x00033B92
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000359A0 File Offset: 0x00033BA0
		private static void OnDisplayValueSourceChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayValueSource, e.NewValue);
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000359B6 File Offset: 0x00033BB6
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000359C8 File Offset: 0x00033BC8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.DisplayValueSource>))]
		public global::Infragistics.Windows.Editors.DisplayValueSource? DisplayValueSource
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DisplayValueSource?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayValueSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DisplayValueSourceProperty, value);
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000359DB File Offset: 0x00033BDB
		private static void OnDropDownButtonDisplayModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonDisplayMode, e.NewValue);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000359F1 File Offset: 0x00033BF1
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00035A03 File Offset: 0x00033C03
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.DropDownButtonDisplayMode>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.DropDownButtonDisplayMode? DropDownButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DropDownButtonDisplayMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00035A16 File Offset: 0x00033C16
		private static void OnDropDownButtonStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonStyle, e.NewValue);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00035A2C File Offset: 0x00033C2C
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00035A3E File Offset: 0x00033C3E
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00035A4C File Offset: 0x00033C4C
		private static void OnDropDownResizeModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownResizeMode, e.NewValue);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00035A62 File Offset: 0x00033C62
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00035A74 File Offset: 0x00033C74
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Controls.PopupResizeMode>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizeMode? DropDownResizeMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizeMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownResizeModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownResizeModeProperty, value);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00035A87 File Offset: 0x00033C87
		private static void OnIsEditableChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsEditable, e.NewValue);
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00035A9D File Offset: 0x00033C9D
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00035AAF File Offset: 0x00033CAF
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsEditable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.IsEditableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.IsEditableProperty, value);
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00035AC2 File Offset: 0x00033CC2
		private static void OnItemsSourceChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ItemsSource, e.NewValue);
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00035AD8 File Offset: 0x00033CD8
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00035AEA File Offset: 0x00033CEA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ItemsSourceProperty, value);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00035AF8 File Offset: 0x00033CF8
		private static void OnLimitToListChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.LimitToList, e.NewValue);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00035B0E File Offset: 0x00033D0E
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00035B20 File Offset: 0x00033D20
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? LimitToList
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.LimitToListProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.LimitToListProperty, value);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00035B33 File Offset: 0x00033D33
		private static void OnMinDropDownHeightChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MaxDropDownHeight, e.NewValue);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00035B49 File Offset: 0x00033D49
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x00035B5B File Offset: 0x00033D5B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<double>))]
		public double? MaxDropDownHeight
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownHeightProperty, value);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00035B70 File Offset: 0x00033D70
		private static bool ValidateMaxDropDownHeight(object objVal)
		{
			double? num = (double?)objVal;
			return num == null || num.Value >= 0.0;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00035BA4 File Offset: 0x00033DA4
		private static void OnMaxDropDownWidthChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MaxDropDownWidth, e.NewValue);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00035BBA File Offset: 0x00033DBA
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00035BCC File Offset: 0x00033DCC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<double>))]
		[global::System.ComponentModel.Bindable(true)]
		public double? MaxDropDownWidth
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MaxDropDownWidthProperty, value);
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00035BE0 File Offset: 0x00033DE0
		private static bool ValidateMaxDropDownWidth(object objVal)
		{
			double? num = (double?)objVal;
			return num == null || num.Value >= 0.0;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00035C14 File Offset: 0x00033E14
		private static void OnMinDropDownWidthChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.MinDropDownWidth, e.NewValue);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00035C2A File Offset: 0x00033E2A
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00035C3C File Offset: 0x00033E3C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<double>))]
		public double? MinDropDownWidth
		{
			get
			{
				return (double?)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MinDropDownWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.MinDropDownWidthProperty, value);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00035C4F File Offset: 0x00033E4F
		private static void OnPreDropDownAreaTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PreDropDownAreaTemplate, e.NewValue);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00035C65 File Offset: 0x00033E65
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00035C77 File Offset: 0x00033E77
		public global::System.Windows.DataTemplate PreDropDownAreaTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.PreDropDownAreaTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.PreDropDownAreaTemplateProperty, value);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00035C85 File Offset: 0x00033E85
		private static void OnPostDropDownAreaTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PostDropDownAreaTemplate, e.NewValue);
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00035C9B File Offset: 0x00033E9B
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00035CAD File Offset: 0x00033EAD
		public global::System.Windows.DataTemplate PostDropDownAreaTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.PostDropDownAreaTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.PostDropDownAreaTemplateProperty, value);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00035CBB File Offset: 0x00033EBB
		private static void OnValuePathChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValuePath, e.NewValue);
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00035CD1 File Offset: 0x00033ED1
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00035CE3 File Offset: 0x00033EE3
		[global::System.ComponentModel.Bindable(true)]
		public string ValuePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ValuePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.ComboBoxField.ValuePathProperty, value);
			}
		}

		// Token: 0x040004F8 RID: 1272
		public static readonly global::System.Windows.DependencyProperty ComboBoxStyleProperty = global::Infragistics.Windows.Editors.XamComboEditor.ComboBoxStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnComboBoxStyleChanged)));

		// Token: 0x040004F9 RID: 1273
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.DisplayMemberPathProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnDisplayMemberPathChanged)));

		// Token: 0x040004FA RID: 1274
		public static readonly global::System.Windows.DependencyProperty DisplayValueSourceProperty = global::System.Windows.DependencyProperty.Register("DisplayValueSource", typeof(global::Infragistics.Windows.Editors.DisplayValueSource?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnDisplayValueSourceChanged)));

		// Token: 0x040004FB RID: 1275
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("DropDownButtonDisplayMode", typeof(global::Infragistics.Windows.Editors.DropDownButtonDisplayMode?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnDropDownButtonDisplayModeChanged)));

		// Token: 0x040004FC RID: 1276
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnDropDownButtonStyleChanged)));

		// Token: 0x040004FD RID: 1277
		public static readonly global::System.Windows.DependencyProperty DropDownResizeModeProperty = global::System.Windows.DependencyProperty.Register("DropDownResizeMode", typeof(global::Infragistics.Windows.Controls.PopupResizeMode?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnDropDownResizeModeChanged)));

		// Token: 0x040004FE RID: 1278
		public static readonly global::System.Windows.DependencyProperty IsEditableProperty = global::System.Windows.DependencyProperty.Register("IsEditable", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnIsEditableChanged)));

		// Token: 0x040004FF RID: 1279
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ItemsSourceProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnItemsSourceChanged)));

		// Token: 0x04000500 RID: 1280
		public static readonly global::System.Windows.DependencyProperty LimitToListProperty = global::System.Windows.DependencyProperty.Register("LimitToList", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnLimitToListChanged)));

		// Token: 0x04000501 RID: 1281
		public static readonly global::System.Windows.DependencyProperty MaxDropDownHeightProperty = global::System.Windows.DependencyProperty.Register("MaxDropDownHeight", typeof(double?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnMinDropDownHeightChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.ValidateMaxDropDownHeight));

		// Token: 0x04000502 RID: 1282
		public static readonly global::System.Windows.DependencyProperty MaxDropDownWidthProperty = global::System.Windows.DependencyProperty.Register("MaxDropDownWidth", typeof(double?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnMaxDropDownWidthChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.ValidateMaxDropDownWidth));

		// Token: 0x04000503 RID: 1283
		public static readonly global::System.Windows.DependencyProperty MinDropDownWidthProperty = global::System.Windows.DependencyProperty.Register("MinDropDownWidth", typeof(double?), typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnMinDropDownWidthChanged)));

		// Token: 0x04000504 RID: 1284
		public static readonly global::System.Windows.DependencyProperty PreDropDownAreaTemplateProperty = global::Infragistics.Windows.Editors.XamComboEditor.PreDropDownAreaTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnPreDropDownAreaTemplateChanged)));

		// Token: 0x04000505 RID: 1285
		public static readonly global::System.Windows.DependencyProperty PostDropDownAreaTemplateProperty = global::Infragistics.Windows.Editors.XamComboEditor.PostDropDownAreaTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnPostDropDownAreaTemplateChanged)));

		// Token: 0x04000506 RID: 1286
		public static readonly global::System.Windows.DependencyProperty ValuePathProperty = global::Infragistics.Windows.Editors.ComboBoxItemsProvider.ValuePathProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.ComboBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.ComboBoxField.OnValuePathChanged)));
	}
}
