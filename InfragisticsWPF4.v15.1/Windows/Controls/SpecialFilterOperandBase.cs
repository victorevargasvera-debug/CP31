using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000168 RID: 360
	public abstract class SpecialFilterOperandBase
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x00028CDD File Offset: 0x00026EDD
		public SpecialFilterOperandBase()
		{
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00028CE8 File Offset: 0x00026EE8
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

		// Token: 0x06000C47 RID: 3143 RVA: 0x00028D20 File Offset: 0x00026F20
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00028D24 File Offset: 0x00026F24
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000C49 RID: 3145
		public abstract object Description { get; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000C4A RID: 3146
		public abstract object DisplayContent { get; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000C4B RID: 3147
		public abstract string Name { get; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C4C RID: 3148
		public abstract bool UsesAllValues { get; }

		// Token: 0x06000C4D RID: 3149 RVA: 0x00028D66 File Offset: 0x00026F66
		protected virtual bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			return this == operand;
		}

		// Token: 0x06000C4E RID: 3150
		public abstract bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context);

		// Token: 0x06000C4F RID: 3151
		public abstract bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator);

		// Token: 0x06000C50 RID: 3152
		public abstract bool SupportsDataType(global::System.Type type);

		// Token: 0x06000C51 RID: 3153 RVA: 0x00028D6C File Offset: 0x00026F6C
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
