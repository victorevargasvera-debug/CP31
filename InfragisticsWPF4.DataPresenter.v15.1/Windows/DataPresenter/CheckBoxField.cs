using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000DE RID: 222
	public class CheckBoxField : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000355FE File Offset: 0x000337FE
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamCheckEditor);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0003560A File Offset: 0x0003380A
		private static void OnIsThreeStateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.IsThreeState, e.NewValue);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00035620 File Offset: 0x00033820
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00035632 File Offset: 0x00033832
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsThreeState
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.CheckBoxField.IsThreeStateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CheckBoxField.IsThreeStateProperty, value);
			}
		}

		// Token: 0x040004F5 RID: 1269
		public static readonly global::System.Windows.DependencyProperty IsThreeStateProperty = global::System.Windows.DependencyProperty.Register("IsThreeState", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.CheckBoxField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.CheckBoxField.OnIsThreeStateChanged)));
	}
}
