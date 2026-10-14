using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000139 RID: 313
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpansionIndicator : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x000220E0 File Offset: 0x000202E0
		static ExpansionIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00022164 File Offset: 0x00020364
		protected override void OnToggle()
		{
			if (this.ToggleMode == global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode.Manual)
			{
				return;
			}
			base.OnToggle();
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00022176 File Offset: 0x00020376
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00022188 File Offset: 0x00020388
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

		// Token: 0x040004C3 RID: 1219
		public static readonly global::System.Windows.DependencyProperty ToggleModeProperty = global::System.Windows.DependencyProperty.Register("ToggleMode", typeof(global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode), typeof(global::Infragistics.Windows.Controls.ExpansionIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ExpansionIndicatorToggleMode.Automatic));
	}
}
