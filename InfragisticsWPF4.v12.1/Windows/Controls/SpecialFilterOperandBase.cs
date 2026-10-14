using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200014A RID: 330
	public abstract class SpecialFilterOperandBase
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x00025068 File Offset: 0x00023268
		public SpecialFilterOperandBase()
		{
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00025070 File Offset: 0x00023270
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = obj as global::Infragistics.Windows.Controls.SpecialFilterOperandBase;
			if (specialFilterOperandBase == null)
			{
				return false;
			}
			if (specialFilterOperandBase is global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper && !(this is global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper))
			{
				return specialFilterOperandBase.EqualsOverride(this);
			}
			return this.EqualsOverride(specialFilterOperandBase);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000250A8 File Offset: 0x000232A8
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000250AC File Offset: 0x000232AC
		public override string ToString()
		{
			object displayContent = this.DisplayContent;
			string text = global::Infragistics.Windows.Controls.SpecialFilterOperandBase.GetString(displayContent);
			if (text == null)
			{
				text = (this.Description as string);
				if (text == null && displayContent != null)
				{
					text = displayContent.ToString();
				}
			}
			if (text == null)
			{
				return base.ToString();
			}
			return text;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B44 RID: 2884
		public abstract object Description { get; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B45 RID: 2885
		public abstract object DisplayContent { get; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B46 RID: 2886
		public abstract string Name { get; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B47 RID: 2887
		public abstract bool UsesAllValues { get; }

		// Token: 0x06000B48 RID: 2888 RVA: 0x000250EE File Offset: 0x000232EE
		protected virtual bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			return this == operand;
		}

		// Token: 0x06000B49 RID: 2889
		public abstract bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context);

		// Token: 0x06000B4A RID: 2890
		public abstract bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator);

		// Token: 0x06000B4B RID: 2891
		public abstract bool SupportsDataType(global::System.Type type);

		// Token: 0x06000B4C RID: 2892 RVA: 0x000250F4 File Offset: 0x000232F4
		private static string GetString(object value)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.FormattedSRValue formattedSRValue = value as global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand.FormattedSRValue;
			string result;
			if (formattedSRValue != null)
			{
				result = formattedSRValue.ToString();
			}
			else
			{
				result = (value as string);
			}
			return result;
		}
	}
}
