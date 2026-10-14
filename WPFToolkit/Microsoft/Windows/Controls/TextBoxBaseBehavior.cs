using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000005 RID: 5
	public class TextBoxBaseBehavior : global::Microsoft.Windows.Controls.ControlBehavior
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000024E3 File Offset: 0x000006E3
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.Primitives.TextBoxBase);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000024F0 File Offset: 0x000006F0
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			base.OnAttach(control);
			global::System.Windows.Controls.Primitives.TextBoxBase instance = (global::System.Windows.Controls.Primitives.TextBoxBase)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.TextBoxBase);
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsEnabledProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002564 File Offset: 0x00000764
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			base.OnDetach(control);
			global::System.Windows.Controls.Primitives.TextBoxBase instance = (global::System.Windows.Controls.Primitives.TextBoxBase)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.Primitives.TextBoxBase);
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsEnabledProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000025D8 File Offset: 0x000007D8
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			global::System.Windows.Controls.Primitives.TextBoxBase textBoxBase = (global::System.Windows.Controls.Primitives.TextBoxBase)control;
			if (!textBoxBase.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(textBoxBase, "Disabled", useTransitions);
			}
			else if (textBoxBase.IsReadOnly)
			{
				global::System.Windows.VisualStateManager.GoToState(textBoxBase, "ReadOnly", useTransitions);
			}
			else if (textBoxBase.IsMouseOver)
			{
				global::System.Windows.VisualStateManager.GoToState(textBoxBase, "MouseOver", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(textBoxBase, "Normal", useTransitions);
			}
			base.UpdateState(control, useTransitions);
		}
	}
}
