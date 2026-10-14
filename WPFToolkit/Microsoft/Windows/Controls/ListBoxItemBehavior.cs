using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200006B RID: 107
	public class ListBoxItemBehavior : global::Microsoft.Windows.Controls.ControlBehavior
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00022C05 File Offset: 0x00020E05
		protected internal override global::System.Type TargetType
		{
			get
			{
				return typeof(global::System.Windows.Controls.ListBoxItem);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00022C14 File Offset: 0x00020E14
		protected override void OnAttach(global::System.Windows.Controls.Control control)
		{
			base.OnAttach(control);
			global::System.Windows.Controls.ListBoxItem instance = (global::System.Windows.Controls.ListBoxItem)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.ListBoxItem);
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.AddValueChanged(global::System.Windows.Controls.ListBoxItem.IsSelectedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00022C70 File Offset: 0x00020E70
		protected override void OnDetach(global::System.Windows.Controls.Control control)
		{
			base.OnDetach(control);
			global::System.Windows.Controls.ListBoxItem instance = (global::System.Windows.Controls.ListBoxItem)control;
			global::System.Type typeFromHandle = typeof(global::System.Windows.Controls.ListBoxItem);
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.UIElement.IsMouseOverProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
			global::Microsoft.Windows.Controls.VisualStateBehavior.RemoveValueChanged(global::System.Windows.Controls.ListBoxItem.IsSelectedProperty, typeFromHandle, instance, new global::System.EventHandler(this.UpdateStateHandler));
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00022CCC File Offset: 0x00020ECC
		protected override void UpdateState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			global::System.Windows.Controls.ListBoxItem listBoxItem = (global::System.Windows.Controls.ListBoxItem)control;
			if (listBoxItem.IsMouseOver)
			{
				global::System.Windows.VisualStateManager.GoToState(listBoxItem, "MouseOver", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(listBoxItem, "Normal", useTransitions);
			}
			if (listBoxItem.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(listBoxItem, "Selected", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(listBoxItem, "Unselected", useTransitions);
			}
			base.UpdateState(control, useTransitions);
		}
	}
}
