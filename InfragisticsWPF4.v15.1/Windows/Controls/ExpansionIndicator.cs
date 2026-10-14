using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000158 RID: 344
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpansionIndicator : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x06000B80 RID: 2944 RVA: 0x00025CA8 File Offset: 0x00023EA8
		static ExpansionIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00025D2C File Offset: 0x00023F2C
		protected override void OnToggle()
		{
			if (this.ToggleMode == global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode.Manual)
			{
				return;
			}
			base.OnToggle();
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00025D3E File Offset: 0x00023F3E
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00025D50 File Offset: 0x00023F50
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode ToggleMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode)base.GetValue(global::Infragistics.Windows.Controls.ExpansionIndicator.ToggleModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ExpansionIndicator.ToggleModeProperty, value);
			}
		}

		// Token: 0x04000579 RID: 1401
		public static readonly global::System.Windows.DependencyProperty ToggleModeProperty = global::System.Windows.DependencyProperty.Register("ToggleMode", typeof(global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode), typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode.Automatic));
	}
}
