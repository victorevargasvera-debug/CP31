using System;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Markup;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x0200000C RID: 12
	[global::System.Windows.Markup.ContentProperty("Condition")]
	public class ConditionBehavior : global::System.Windows.Interactivity.Behavior<global::System.Windows.Interactivity.TriggerBase>
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003430 File Offset: 0x00001630
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00003442 File Offset: 0x00001642
		public global::Microsoft.Expression.Interactivity.Core.ICondition Condition
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Core.ICondition)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ConditionBehavior.ConditionProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ConditionBehavior.ConditionProperty, value);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003458 File Offset: 0x00001658
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.PreviewInvoke += this.OnPreviewInvoke;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003477 File Offset: 0x00001677
		protected override void OnDetaching()
		{
			base.AssociatedObject.PreviewInvoke -= this.OnPreviewInvoke;
			base.OnDetaching();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003496 File Offset: 0x00001696
		private void OnPreviewInvoke(object sender, global::System.Windows.Interactivity.PreviewInvokeEventArgs e)
		{
			if (this.Condition != null)
			{
				e.Cancelling = !this.Condition.Evaluate();
			}
		}

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty ConditionProperty = global::System.Windows.DependencyProperty.Register("Condition", typeof(global::Microsoft.Expression.Interactivity.Core.ICondition), typeof(global::Microsoft.Expression.Interactivity.Core.ConditionBehavior), new global::System.Windows.PropertyMetadata(null));
	}
}
