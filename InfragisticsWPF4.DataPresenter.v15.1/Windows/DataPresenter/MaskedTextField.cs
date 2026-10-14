using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E1 RID: 225
	[global::System.Windows.StyleTypedProperty(Property = "SpinButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	public class MaskedTextField : global::Infragistics.Windows.DataPresenter.TextFieldBase
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00035FF5 File Offset: 0x000341F5
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamMaskedEditor);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00036001 File Offset: 0x00034201
		private static void OnAllowShiftingAcrossSectionsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AllowShiftingAcrossSections, e.NewValue);
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00036016 File Offset: 0x00034216
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00036028 File Offset: 0x00034228
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowShiftingAcrossSections
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.AllowShiftingAcrossSectionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.AllowShiftingAcrossSectionsProperty, value);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0003603B File Offset: 0x0003423B
		private static void OnAutoFillDateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AutoFillDate, e.NewValue);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00036050 File Offset: 0x00034250
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00036062 File Offset: 0x00034262
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.AutoFillDate>))]
		public global::Infragistics.Windows.Editors.AutoFillDate? AutoFillDate
		{
			get
			{
				return (global::Infragistics.Windows.Editors.AutoFillDate?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.AutoFillDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.AutoFillDateProperty, value);
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00036075 File Offset: 0x00034275
		private static void OnClipModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.ClipMode, e.NewValue);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003608A File Offset: 0x0003428A
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x0003609C File Offset: 0x0003429C
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.MaskMode>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.MaskMode? ClipMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.ClipModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.ClipModeProperty, value);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000360AF File Offset: 0x000342AF
		private static void OnDataModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DataMode, e.NewValue);
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000360C5 File Offset: 0x000342C5
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000360D7 File Offset: 0x000342D7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.MaskMode>))]
		public global::Infragistics.Windows.Editors.MaskMode? DataMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.DataModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.DataModeProperty, value);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000360EA File Offset: 0x000342EA
		private static void OnDisplayModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayMode, e.NewValue);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00036100 File Offset: 0x00034300
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00036112 File Offset: 0x00034312
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.MaskMode>))]
		public global::Infragistics.Windows.Editors.MaskMode? DisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.DisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.DisplayModeProperty, value);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00036125 File Offset: 0x00034325
		private static void OnMaskChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.Mask, e.NewValue);
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0003613B File Offset: 0x0003433B
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0003614D File Offset: 0x0003434D
		public string Mask
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.MaskProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.MaskProperty, value);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003615B File Offset: 0x0003435B
		private static void OnPadCharChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PadChar, e.NewValue);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00036171 File Offset: 0x00034371
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00036183 File Offset: 0x00034383
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<char>))]
		[global::System.ComponentModel.Bindable(true)]
		public char? PadChar
		{
			get
			{
				return (char?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.PadCharProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.PadCharProperty, value);
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00036196 File Offset: 0x00034396
		private static void OnPromptCharChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.PromptChar, e.NewValue);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000361AC File Offset: 0x000343AC
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x000361BE File Offset: 0x000343BE
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<char>))]
		public char? PromptChar
		{
			get
			{
				return (char?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.PromptCharProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.PromptCharProperty, value);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000361D1 File Offset: 0x000343D1
		private static void OnSelectAllBehaviorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SelectAllBehavior, e.NewValue);
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000361E7 File Offset: 0x000343E7
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000361F9 File Offset: 0x000343F9
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.MaskSelectAllBehavior>))]
		public global::Infragistics.Windows.Editors.MaskSelectAllBehavior? SelectAllBehavior
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskSelectAllBehavior?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SelectAllBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SelectAllBehaviorProperty, value);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0003620C File Offset: 0x0003440C
		private static void OnSpinButtonDisplayModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinButtonDisplayMode, e.NewValue);
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00036222 File Offset: 0x00034422
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00036234 File Offset: 0x00034434
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.SpinButtonDisplayMode>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.SpinButtonDisplayMode? SpinButtonDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SpinButtonDisplayMode?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonDisplayModeProperty, value);
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00036247 File Offset: 0x00034447
		private static void OnSpinButtonStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinButtonStyle, e.NewValue);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0003625D File Offset: 0x0003445D
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x0003626F File Offset: 0x0003446F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style SpinButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinButtonStyleProperty, value);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003627D File Offset: 0x0003447D
		private static void OnSpinIncrementChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinIncrement, e.NewValue);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00036293 File Offset: 0x00034493
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x000362A0 File Offset: 0x000344A0
		[global::System.ComponentModel.Bindable(true)]
		public object SpinIncrement
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinIncrementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinIncrementProperty, value);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000362AE File Offset: 0x000344AE
		private static void OnSpinWrapChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.SpinWrap, e.NewValue);
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000362C4 File Offset: 0x000344C4
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x000362D6 File Offset: 0x000344D6
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? SpinWrap
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinWrapProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.SpinWrapProperty, value);
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000362E9 File Offset: 0x000344E9
		private static void OnTabNavigationChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TabNavigation, e.NewValue);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000362FF File Offset: 0x000344FF
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00036311 File Offset: 0x00034511
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.Editors.MaskedEditTabNavigation>))]
		public global::Infragistics.Windows.Editors.MaskedEditTabNavigation? TabNavigation
		{
			get
			{
				return (global::Infragistics.Windows.Editors.MaskedEditTabNavigation?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.TabNavigationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.TabNavigationProperty, value);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00036324 File Offset: 0x00034524
		private static void OnTrimFractionalZerosChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TrimFractionalZeros, e.NewValue);
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0003633A File Offset: 0x0003453A
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0003634C File Offset: 0x0003454C
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? TrimFractionalZeros
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.TrimFractionalZerosProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.MaskedTextField.TrimFractionalZerosProperty, value);
			}
		}

		// Token: 0x04000507 RID: 1287
		public static readonly global::System.Windows.DependencyProperty AllowShiftingAcrossSectionsProperty = global::System.Windows.DependencyProperty.Register("AllowShiftingAcrossSections", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnAllowShiftingAcrossSectionsChanged)));

		// Token: 0x04000508 RID: 1288
		public static readonly global::System.Windows.DependencyProperty AutoFillDateProperty = global::System.Windows.DependencyProperty.Register("AutoFillDate", typeof(global::Infragistics.Windows.Editors.AutoFillDate?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnAutoFillDateChanged)));

		// Token: 0x04000509 RID: 1289
		public static readonly global::System.Windows.DependencyProperty ClipModeProperty = global::System.Windows.DependencyProperty.Register("ClipMode", typeof(global::Infragistics.Windows.Editors.MaskMode?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnClipModeChanged)));

		// Token: 0x0400050A RID: 1290
		public static readonly global::System.Windows.DependencyProperty DataModeProperty = global::System.Windows.DependencyProperty.Register("DataMode", typeof(global::Infragistics.Windows.Editors.MaskMode?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnDataModeChanged)));

		// Token: 0x0400050B RID: 1291
		public static readonly global::System.Windows.DependencyProperty DisplayModeProperty = global::System.Windows.DependencyProperty.Register("DisplayMode", typeof(global::Infragistics.Windows.Editors.MaskMode?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnDisplayModeChanged)));

		// Token: 0x0400050C RID: 1292
		public static readonly global::System.Windows.DependencyProperty MaskProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.MaskProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnMaskChanged)));

		// Token: 0x0400050D RID: 1293
		public static readonly global::System.Windows.DependencyProperty PadCharProperty = global::System.Windows.DependencyProperty.Register("PadChar", typeof(char?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnPadCharChanged)));

		// Token: 0x0400050E RID: 1294
		public static readonly global::System.Windows.DependencyProperty PromptCharProperty = global::System.Windows.DependencyProperty.Register("PromptChar", typeof(char?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnPromptCharChanged)));

		// Token: 0x0400050F RID: 1295
		public static readonly global::System.Windows.DependencyProperty SelectAllBehaviorProperty = global::System.Windows.DependencyProperty.Register("SelectAllBehavior", typeof(global::Infragistics.Windows.Editors.MaskSelectAllBehavior?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnSelectAllBehaviorChanged)));

		// Token: 0x04000510 RID: 1296
		public static readonly global::System.Windows.DependencyProperty SpinButtonDisplayModeProperty = global::System.Windows.DependencyProperty.Register("SpinButtonDisplayMode", typeof(global::Infragistics.Windows.Editors.SpinButtonDisplayMode?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnSpinButtonDisplayModeChanged)));

		// Token: 0x04000511 RID: 1297
		public static readonly global::System.Windows.DependencyProperty SpinButtonStyleProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SpinButtonStyleProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnSpinButtonStyleChanged)));

		// Token: 0x04000512 RID: 1298
		public static readonly global::System.Windows.DependencyProperty SpinIncrementProperty = global::Infragistics.Windows.Editors.XamMaskedEditor.SpinIncrementProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnSpinIncrementChanged)));

		// Token: 0x04000513 RID: 1299
		public static readonly global::System.Windows.DependencyProperty SpinWrapProperty = global::System.Windows.DependencyProperty.Register("SpinWrap", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnSpinWrapChanged)));

		// Token: 0x04000514 RID: 1300
		public static readonly global::System.Windows.DependencyProperty TabNavigationProperty = global::System.Windows.DependencyProperty.Register("TabNavigation", typeof(global::Infragistics.Windows.Editors.MaskedEditTabNavigation?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnTabNavigationChanged)));

		// Token: 0x04000515 RID: 1301
		public static readonly global::System.Windows.DependencyProperty TrimFractionalZerosProperty = global::System.Windows.DependencyProperty.Register("TrimFractionalZeros", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.MaskedTextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.MaskedTextField.OnTrimFractionalZerosChanged)));
	}
}
