using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200004C RID: 76
	public class ButtonBaseBehavior : global::Microsoft.Windows.Controls.ControlBehavior
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001805E File Offset: 0x0001625E
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.Primitives.ButtonBase);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001806C File Offset: 0x0001626C
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			base.OnAttach(control);
			global::System.Windows.Controls.Primitives.ButtonBase instance = (global::System.Windows.Controls.Primitives.ButtonBase)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.ButtonBase);
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsEnabledProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.Controls.Primitives.ButtonBase.IsPressedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000180E0 File Offset: 0x000162E0
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			base.OnDetach(control);
			global::System.Windows.Controls.Primitives.ButtonBase instance = (global::System.Windows.Controls.Primitives.ButtonBase)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.ButtonBase);
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsEnabledProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.Controls.Primitives.ButtonBase.IsPressedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00018154 File Offset: 0x00016354
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			global::System.Windows.Controls.Primitives.ButtonBase buttonBase = (global::System.Windows.Controls.Primitives.ButtonBase)control;
			if (!buttonBase.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(buttonBase, "Disabled", useTransitions);
			}
			else if (buttonBase.IsPressed)
			{
				global::System.Windows.VisualStateManager.GoToState(buttonBase, "Pressed", useTransitions);
			}
			else if (buttonBase.IsMouseOver)
			{
				global::System.Windows.VisualStateManager.GoToState(buttonBase, "MouseOver", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(buttonBase, "Normal", useTransitions);
			}
			base.UpdateState(control, useTransitions);
		}
	}
}
