using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200007C RID: 124
	public class ToggleButtonBehavior : global::Microsoft.Windows.Controls.ButtonBaseBehavior
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002795E File Offset: 0x00025B5E
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.Primitives.ToggleButton);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0002796C File Offset: 0x00025B6C
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			base.OnAttach(control);
			global::System.Windows.Controls.Primitives.ToggleButton instance = (global::System.Windows.Controls.Primitives.ToggleButton)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.ToggleButton);
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000279AC File Offset: 0x00025BAC
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			base.OnDetach(control);
			global::System.Windows.Controls.Primitives.ToggleButton instance = (global::System.Windows.Controls.Primitives.ToggleButton)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.ToggleButton);
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000279EC File Offset: 0x00025BEC
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			global::System.Windows.Controls.Primitives.ToggleButton toggleButton = (global::System.Windows.Controls.Primitives.ToggleButton)control;
			if (toggleButton.IsChecked == null)
			{
				global::System.Windows.VisualStateManager.GoToState(toggleButton, "Indeterminate", useTransitions);
			}
			else if (toggleButton.IsChecked.Value)
			{
				global::System.Windows.VisualStateManager.GoToState(toggleButton, "Checked", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(toggleButton, "Unchecked", useTransitions);
			}
			base.UpdateState(control, useTransitions);
		}
	}
}
