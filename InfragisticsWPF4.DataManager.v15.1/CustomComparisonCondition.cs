using System;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x02000034 RID: 52
	public class CustomComparisonCondition : global::Infragistics.ComparisonConditionBase
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000DA6D File Offset: 0x0000BC6D
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000DA75 File Offset: 0x0000BC75
		public global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				if (this._expression != value)
				{
					this._expression = value;
					this.OnPropertyChanged("Expression");
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000DA92 File Offset: 0x0000BC92
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000DA9A File Offset: 0x0000BC9A
		public object FilterValue
		{
			get
			{
				return this._filterValue;
			}
			set
			{
				if (this._filterValue != value)
				{
					this._filterValue = value;
					this.OnPropertyChanged("FilterValue");
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000DAB7 File Offset: 0x0000BCB7
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000DABF File Offset: 0x0000BCBF
		protected internal global::System.Type FilterOperand { get; set; }

		// Token: 0x06000275 RID: 629 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			return this.Expression;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			return this.Expression;
		}

		// Token: 0x040000FF RID: 255
		private global::System.Linq.Expressions.Expression _expression;

		// Token: 0x04000100 RID: 256
		private object _filterValue;
	}
}
