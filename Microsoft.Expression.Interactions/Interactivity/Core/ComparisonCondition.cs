using System;
using System.Windows;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000006 RID: 6
	public class ComparisonCondition : global::System.Windows.Freezable
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002F81 File Offset: 0x00001181
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::Microsoft.Expression.Interactivity.Core.ComparisonCondition();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002F95 File Offset: 0x00001195
		public object LeftOperand
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.LeftOperandProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.LeftOperandProperty, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FA3 File Offset: 0x000011A3
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002FB0 File Offset: 0x000011B0
		public object RightOperand
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.RightOperandProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.RightOperandProperty, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002FBE File Offset: 0x000011BE
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002FD0 File Offset: 0x000011D0
		public global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType Operator
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.OperatorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.OperatorProperty, value);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FE3 File Offset: 0x000011E3
		public bool Evaluate()
		{
			this.EnsureBindingUpToDate();
			return global::Microsoft.Expression.Interactivity.ComparisonLogic.EvaluateImpl(this.LeftOperand, this.Operator, this.RightOperand);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003002 File Offset: 0x00001202
		private void EnsureBindingUpToDate()
		{
			global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureBindingUpToDate(this, global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.LeftOperandProperty);
			global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureBindingUpToDate(this, global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.OperatorProperty);
			global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureBindingUpToDate(this, global::Microsoft.Expression.Interactivity.Core.ComparisonCondition.RightOperandProperty);
		}

		// Token: 0x0400000E RID: 14
		public static readonly global::System.Windows.DependencyProperty LeftOperandProperty = global::System.Windows.DependencyProperty.Register("LeftOperand", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400000F RID: 15
		public static readonly global::System.Windows.DependencyProperty OperatorProperty = global::System.Windows.DependencyProperty.Register("Operator", typeof(global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType), typeof(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition), new global::System.Windows.PropertyMetadata(global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType.Equal));

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Windows.DependencyProperty RightOperandProperty = global::System.Windows.DependencyProperty.Register("RightOperand", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.ComparisonCondition), new global::System.Windows.PropertyMetadata(null));
	}
}
