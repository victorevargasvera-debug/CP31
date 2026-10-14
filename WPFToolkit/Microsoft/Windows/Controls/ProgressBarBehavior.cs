using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200007D RID: 125
	public class ProgressBarBehavior : global::Microsoft.Windows.Controls.ControlBehavior
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00027A5B File Offset: 0x00025C5B
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.ProgressBar);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00027A68 File Offset: 0x00025C68
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			base.OnAttach(control);
			global::System.Windows.Controls.ProgressBar instance = (global::System.Windows.Controls.ProgressBar)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.ProgressBar);
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.Controls.ProgressBar.IsIndeterminateProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00027AA8 File Offset: 0x00025CA8
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			base.OnDetach(control);
			global::System.Windows.Controls.ProgressBar instance = (global::System.Windows.Controls.ProgressBar)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.ProgressBar);
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.Controls.ProgressBar.IsIndeterminateProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00027AE8 File Offset: 0x00025CE8
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			global::System.Windows.Controls.ProgressBar progressBar = (global::System.Windows.Controls.ProgressBar)control;
			if (!progressBar.IsIndeterminate)
			{
				global::System.Windows.VisualStateManager.GoToState(progressBar, "Determinate", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(progressBar, "Indeterminate", useTransitions);
			}
			base.UpdateState(control, useTransitions);
		}
	}
}
