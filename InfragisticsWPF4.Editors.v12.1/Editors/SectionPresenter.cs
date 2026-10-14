using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000088 RID: 136
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SectionPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x000254F8 File Offset: 0x000236F8
		static SectionPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00025587 File Offset: 0x00023787
		public void Initialize(global::Infragistics.Windows.Editors.SectionBase section)
		{
			base.SetValue(global::Infragistics.Windows.Editors.SectionPresenter.SectionPropertyKey, section);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00025595 File Offset: 0x00023795
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return (global::Infragistics.Windows.Editors.SectionBase)base.GetValue(global::Infragistics.Windows.Editors.SectionPresenter.SectionProperty);
			}
		}

		// Token: 0x040002B5 RID: 693
		private static readonly global::System.Windows.DependencyPropertyKey SectionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Section", typeof(global::Infragistics.Windows.Editors.SectionBase), typeof(global::Infragistics.Windows.Editors.SectionPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040002B6 RID: 694
		public static readonly global::System.Windows.DependencyProperty SectionProperty = global::Infragistics.Windows.Editors.SectionPresenter.SectionPropertyKey.DependencyProperty;
	}
}
