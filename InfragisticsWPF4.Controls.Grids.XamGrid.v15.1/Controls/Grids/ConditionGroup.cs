using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200007F RID: 127
	public class ConditionGroup : global::Infragistics.CustomComparisonCondition
	{
		// Token: 0x06000446 RID: 1094 RVA: 0x00013730 File Offset: 0x00011930
		public ConditionGroup(global::Infragistics.IRecordFilter parent)
		{
			this.Conditions.Parent = parent;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00013744 File Offset: 0x00011944
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.ConditionCollection Conditions
		{
			get
			{
				if (this._conditions == null)
				{
					this._conditions = new global::Infragistics.ConditionCollection();
				}
				return this._conditions;
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001375F File Offset: 0x0001195F
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return context.CreateExpression(this.Conditions);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001376D File Offset: 0x0001196D
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			return base.GetCurrentExpression();
		}

		// Token: 0x04000119 RID: 281
		private global::Infragistics.ConditionCollection _conditions;
	}
}
