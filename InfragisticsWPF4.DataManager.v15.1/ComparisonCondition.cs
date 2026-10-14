using System;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x02000031 RID: 49
	public class ComparisonCondition : global::Infragistics.ComparisonConditionBase
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000D43D File Offset: 0x0000B63D
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0000D445 File Offset: 0x0000B645
		public global::Infragistics.ComparisonOperator Operator
		{
			get
			{
				return this._operator;
			}
			set
			{
				if (this._operator != value)
				{
					this._operator = value;
					this.OnPropertyChanged("Operator");
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000D462 File Offset: 0x0000B662
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000D46A File Offset: 0x0000B66A
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000D487 File Offset: 0x0000B687
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000D490 File Offset: 0x0000B690
		public bool? CaseSensitive
		{
			get
			{
				return this._caseSensitive;
			}
			set
			{
				if (this._caseSensitive != value)
				{
					this._caseSensitive = value;
					this.OnPropertyChanged("CaseSensitive");
				}
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			if (base.Parent == null)
			{
				return null;
			}
			if (context.FieldDataType != base.Parent.FieldType)
			{
				return this.GetCurrentExpression();
			}
			if (this.CaseSensitive == null)
			{
				return context.CreateExpression(base.Parent.FieldName, this.Operator, this.FilterValue);
			}
			return context.CreateExpression(base.Parent.FieldName, this.Operator, this.FilterValue, this.CaseSensitive.Value);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000D570 File Offset: 0x0000B770
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			if (base.Parent != null)
			{
				bool caseSensitive = false;
				if (this.CaseSensitive != null)
				{
					caseSensitive = this.CaseSensitive.Value;
				}
				global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(base.Parent.ObjectTypedInfo, base.Parent.FieldType, caseSensitive, base.Parent.FieldType == typeof(global::System.DateTime));
				return this.GetCurrentExpression(context);
			}
			return null;
		}

		// Token: 0x040000F8 RID: 248
		private global::Infragistics.ComparisonOperator _operator;

		// Token: 0x040000F9 RID: 249
		private object _filterValue;

		// Token: 0x040000FA RID: 250
		private bool? _caseSensitive = null;
	}
}
