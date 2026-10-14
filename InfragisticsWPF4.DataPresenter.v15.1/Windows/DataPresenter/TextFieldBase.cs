using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000DF RID: 223
	public abstract class TextFieldBase : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x06000C00 RID: 3072 RVA: 0x00035684 File Offset: 0x00033884
		private static void OnNullTextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.NullText, e.NewValue);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0003569A File Offset: 0x0003389A
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x000356AC File Offset: 0x000338AC
		[global::System.ComponentModel.Bindable(true)]
		public string NullText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.TextFieldBase.NullTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextFieldBase.NullTextProperty, value);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000356BA File Offset: 0x000338BA
		private static void OnValueToDisplayTextConverteChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ValueToDisplayTextConverter, e.NewValue);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000356D0 File Offset: 0x000338D0
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000356E2 File Offset: 0x000338E2
		public global::System.Windows.Data.IValueConverter ValueToDisplayTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Windows.DataPresenter.TextFieldBase.ValueToDisplayTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextFieldBase.ValueToDisplayTextConverterProperty, value);
			}
		}

		// Token: 0x040004F6 RID: 1270
		public static readonly global::System.Windows.DependencyProperty NullTextProperty = global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.TextFieldBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextFieldBase.OnNullTextChanged)));

		// Token: 0x040004F7 RID: 1271
		public static readonly global::System.Windows.DependencyProperty ValueToDisplayTextConverterProperty = global::Infragistics.Windows.Editors.TextEditorBase.ValueToDisplayTextConverterProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.TextFieldBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextFieldBase.OnValueToDisplayTextConverteChanged)));
	}
}
