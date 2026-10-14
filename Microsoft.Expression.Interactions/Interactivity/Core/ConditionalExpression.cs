using System;
using System.Windows;
using System.Windows.Markup;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x0200000B RID: 11
	[global::System.Windows.Markup.ContentProperty("Conditions")]
	public class ConditionalExpression : global::System.Windows.Freezable, global::Microsoft.Expression.Interactivity.Core.ICondition
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000032FC File Offset: 0x000014FC
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::Microsoft.Expression.Interactivity.Core.ConditionalExpression();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003303 File Offset: 0x00001503
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003315 File Offset: 0x00001515
		public global::Microsoft.Expression.Interactivity.Core.ForwardChaining ForwardChaining
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Core.ForwardChaining)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression.ForwardChainingProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression.ForwardChainingProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003328 File Offset: 0x00001528
		public global::Microsoft.Expression.Interactivity.Core.ConditionCollection Conditions
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Core.ConditionCollection)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression.ConditionsProperty);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000333A File Offset: 0x0000153A
		public ConditionalExpression()
		{
			base.SetValue(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression.ConditionsProperty, new global::Microsoft.Expression.Interactivity.Core.ConditionCollection());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003354 File Offset: 0x00001554
		public bool Evaluate()
		{
			bool flag = false;
			foreach (global::Microsoft.Expression.Interactivity.Core.ComparisonCondition comparisonCondition in this.Conditions)
			{
				flag = comparisonCondition.Evaluate();
				if (!flag && this.ForwardChaining == global::Microsoft.Expression.Interactivity.Core.ForwardChaining.And)
				{
					return flag;
				}
				if (flag && this.ForwardChaining == global::Microsoft.Expression.Interactivity.Core.ForwardChaining.Or)
				{
					return flag;
				}
			}
			return flag;
		}

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty ConditionsProperty = global::System.Windows.DependencyProperty.Register("Conditions", typeof(global::Microsoft.Expression.Interactivity.Core.ConditionCollection), typeof(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty ForwardChainingProperty = global::System.Windows.DependencyProperty.Register("ForwardChaining", typeof(global::Microsoft.Expression.Interactivity.Core.ForwardChaining), typeof(global::Microsoft.Expression.Interactivity.Core.ConditionalExpression), new global::System.Windows.PropertyMetadata(global::Microsoft.Expression.Interactivity.Core.ForwardChaining.And));
	}
}
