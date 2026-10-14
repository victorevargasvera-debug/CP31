using System;
using System.Globalization;
using System.Windows;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x0200001E RID: 30
	public class GoToStateAction : global::System.Windows.Interactivity.TargetedTriggerAction<global::System.Windows.FrameworkElement>
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00007618 File Offset: 0x00005818
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000762A File Offset: 0x0000582A
		public bool UseTransitions
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Core.GoToStateAction.UseTransitionsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.GoToStateAction.UseTransitionsProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000763D File Offset: 0x0000583D
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000764F File Offset: 0x0000584F
		public string StateName
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.GoToStateAction.StateNameProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.GoToStateAction.StateNameProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000765D File Offset: 0x0000585D
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00007665 File Offset: 0x00005865
		private global::System.Windows.FrameworkElement StateTarget { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00007670 File Offset: 0x00005870
		private bool IsTargetObjectSet
		{
			get
			{
				return base.ReadLocalValue(global::System.Windows.Interactivity.TargetedTriggerAction.TargetObjectProperty) != global::System.Windows.DependencyProperty.UnsetValue;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007694 File Offset: 0x00005894
		protected override void OnTargetChanged(global::System.Windows.FrameworkElement oldTarget, global::System.Windows.FrameworkElement newTarget)
		{
			base.OnTargetChanged(oldTarget, newTarget);
			global::System.Windows.FrameworkElement frameworkElement = null;
			if (string.IsNullOrEmpty(base.TargetName) && !this.IsTargetObjectSet)
			{
				if (!global::Microsoft.Expression.Interactivity.VisualStateUtilities.TryFindNearestStatefulControl(base.AssociatedObject as global::System.Windows.FrameworkElement, out frameworkElement) && frameworkElement != null)
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.GoToStateActionTargetHasNoStateGroups, new object[]
					{
						frameworkElement.Name
					}));
				}
			}
			else
			{
				frameworkElement = base.Target;
			}
			this.StateTarget = frameworkElement;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000770D File Offset: 0x0000590D
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null)
			{
				this.InvokeImpl(this.StateTarget);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007723 File Offset: 0x00005923
		internal void InvokeImpl(global::System.Windows.FrameworkElement stateTarget)
		{
			if (stateTarget != null)
			{
				global::Microsoft.Expression.Interactivity.VisualStateUtilities.GoToState(stateTarget, this.StateName, this.UseTransitions);
			}
		}

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty UseTransitionsProperty = global::System.Windows.DependencyProperty.Register("UseTransitions", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Core.GoToStateAction), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x04000060 RID: 96
		public static readonly global::System.Windows.DependencyProperty StateNameProperty = global::System.Windows.DependencyProperty.Register("StateName", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.GoToStateAction), new global::System.Windows.PropertyMetadata(string.Empty));
	}
}
