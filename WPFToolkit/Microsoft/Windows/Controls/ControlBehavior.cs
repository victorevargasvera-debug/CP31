using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000004 RID: 4
	public class ControlBehavior : global::Microsoft.Windows.Controls.VisualStateBehavior
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000023DC File Offset: 0x000005DC
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.Control);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002404 File Offset: 0x00000604
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			control.Loaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this.UpdateState(control, false);
			};
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsKeyboardFocusWithinProperty, typeof(global::System.Windows.Controls.Control), control, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002464 File Offset: 0x00000664
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsKeyboardFocusWithinProperty, typeof(global::System.Windows.Controls.Control), control, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000248C File Offset: 0x0000068C
		protected override void UpdateStateHandler(object o, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Control control = o as global::System.Windows.Controls.Control;
			if (control == null)
			{
				throw new global::System.InvalidOperationException("This should never be used on anything other than a control.");
			}
			this.UpdateState(control, true);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000024B6 File Offset: 0x000006B6
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			if (control.IsKeyboardFocusWithin)
			{
				global::System.Windows.VisualStateManager.GoToState(control, "Focused", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(control, "Unfocused", useTransitions);
		}
	}
}
