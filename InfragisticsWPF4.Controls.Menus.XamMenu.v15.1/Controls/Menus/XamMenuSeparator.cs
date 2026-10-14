using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000023 RID: 35
	[global::System.Windows.TemplateVisualState(GroupName = "OrientationState", Name = "Horizontal")]
	[global::System.Windows.TemplateVisualState(GroupName = "OrientationState", Name = "Vertical")]
	public class XamMenuSeparator : global::System.Windows.Controls.Control
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00009301 File Offset: 0x00007501
		public XamMenuSeparator()
		{
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Menus.XamMenuSeparator), this);
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Menus.XamMenuSeparator);
			base.IsTabStop = false;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00009331 File Offset: 0x00007531
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.SeparatorOrientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Horizontal", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Vertical", false);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000935C File Offset: 0x0000755C
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000936E File Offset: 0x0000756E
		public global::System.Windows.Controls.Orientation SeparatorOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Controls.Menus.XamMenuSeparator.SeparatorOrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenuSeparator.SeparatorOrientationProperty, value);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00009384 File Offset: 0x00007584
		private static void SeparatorOrientationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenuSeparator control = obj as global::Infragistics.Controls.Menus.XamMenuSeparator;
			if ((global::System.Windows.Controls.Orientation)e.NewValue == global::System.Windows.Controls.Orientation.Horizontal)
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Horizontal", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(control, "Vertical", false);
		}

		// Token: 0x040000B2 RID: 178
		private const string OrientationStateGroupName = "OrientationState";

		// Token: 0x040000B3 RID: 179
		private const string OrientationVertical = "Vertical";

		// Token: 0x040000B4 RID: 180
		private const string OrientationHorizontal = "Horizontal";

		// Token: 0x040000B5 RID: 181
		public static readonly global::System.Windows.DependencyProperty SeparatorOrientationProperty = global::System.Windows.DependencyProperty.Register("SeparatorOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Controls.Menus.XamMenuSeparator), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenuSeparator.SeparatorOrientationChanged)));
	}
}
