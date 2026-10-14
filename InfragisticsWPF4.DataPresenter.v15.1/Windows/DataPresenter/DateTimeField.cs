using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E3 RID: 227
	[global::System.Windows.StyleTypedProperty(Property = "DropDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ToggleButton))]
	public class DateTimeField : global::Infragistics.Windows.DataPresenter.MaskedTextField
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00036692 File Offset: 0x00034892
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0003669E File Offset: 0x0003489E
		private static void OnAllowDropDownChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AllowDropDown, e.NewValue);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000366B3 File Offset: 0x000348B3
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x000366C5 File Offset: 0x000348C5
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowDropDown
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamDateTimeEditor.AllowDropDownProperty, value);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000366D8 File Offset: 0x000348D8
		private static void OnDropDownButtonDisplayModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonDisplayMode, e.NewValue);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000366EE File Offset: 0x000348EE
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00036700 File Offset: 0x00034900
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.DropDownButtonDisplayMode>))]
		public global::Infragistics.Windows.Editors.DropDownButtonDisplayMode? DropDownButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DropDownButtonDisplayMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.DateTimeField.DropDownButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DateTimeField.DropDownButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00036713 File Offset: 0x00034913
		private static void OnDropDownButtonStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DropDownButtonStyle, e.NewValue);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00036729 File Offset: 0x00034929
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0003673B File Offset: 0x0003493B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DateTimeField.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DateTimeField.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x04000516 RID: 1302
		public static readonly global::System.Windows.DependencyProperty AllowDropDownProperty = global::System.Windows.DependencyProperty.Register("AllowDropDown", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.DateTimeField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DateTimeField.OnAllowDropDownChanged)));

		// Token: 0x04000517 RID: 1303
		public static readonly global::System.Windows.DependencyProperty DropDownButtonDisplayModeProperty = global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonDisplayModeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DateTimeField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DateTimeField.OnDropDownButtonDisplayModeChanged)));

		// Token: 0x04000518 RID: 1304
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::Infragistics.Windows.DataPresenter.ComboBoxField.DropDownButtonStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DateTimeField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DateTimeField.OnDropDownButtonStyleChanged)));
	}
}
