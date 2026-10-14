using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E5 RID: 229
	public class TemplateField : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000368EF File Offset: 0x00034AEF
		protected override global::System.Type DefaultEditAsType
		{
			get
			{
				return typeof(object);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000368FB File Offset: 0x00034AFB
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.TemplateEditor);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00036907 File Offset: 0x00034B07
		private static void OnDisplayTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.DisplayTemplate, e.NewValue);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0003691D File Offset: 0x00034B1D
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0003692F File Offset: 0x00034B2F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate DisplayTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.TemplateField.DisplayTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TemplateField.DisplayTemplateProperty, value);
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003693D File Offset: 0x00034B3D
		private static void OnEditTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.EditTemplate, e.NewValue);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00036953 File Offset: 0x00034B53
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00036965 File Offset: 0x00034B65
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate EditTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.TemplateField.EditTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TemplateField.EditTemplateProperty, value);
			}
		}

		// Token: 0x04000519 RID: 1305
		public static readonly global::System.Windows.DependencyProperty DisplayTemplateProperty = global::System.Windows.DependencyProperty.Register("DisplayTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.TemplateField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TemplateField.OnDisplayTemplateChanged)));

		// Token: 0x0400051A RID: 1306
		public static readonly global::System.Windows.DependencyProperty EditTemplateProperty = global::System.Windows.DependencyProperty.Register("EditTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.TemplateField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TemplateField.OnEditTemplateChanged)));
	}
}
