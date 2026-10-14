using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200008F RID: 143
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SectionPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00027294 File Offset: 0x00025494
		static SectionPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00027323 File Offset: 0x00025523
		public void Initialize(global::Infragistics.Windows.Editors.SectionBase section)
		{
			base.SetValue(global::Infragistics.Windows.Editors.SectionPresenter.SectionPropertyKey, section);
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00027331 File Offset: 0x00025531
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SectionBase)base.GetValue(global::Infragistics.Windows.Editors.SectionPresenter.SectionProperty);
			}
		}

		// Token: 0x040002EB RID: 747
		private static readonly global::System.Windows.DependencyPropertyKey SectionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Section", typeof(global::Infragistics.Windows.Editors.SectionBase), typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040002EC RID: 748
		public static readonly global::System.Windows.DependencyProperty SectionProperty = global::Infragistics.Windows.Editors.SectionPresenter.SectionPropertyKey.DependencyProperty;
	}
}
