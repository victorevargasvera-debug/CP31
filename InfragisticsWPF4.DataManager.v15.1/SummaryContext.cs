using System;
using System.Linq;

namespace Infragistics
{
	// Token: 0x02000017 RID: 23
	public abstract class SummaryContext
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000077AC File Offset: 0x000059AC
		public static global::Infragistics.SummaryContext CreateGenericSummary(global::Infragistics.CachedTypedInfo cachedTypeInfo, string propertyName, global::Infragistics.LinqSummaryOperator linqSummary)
		{
			global::System.Type cachedType = cachedTypeInfo.CachedType;
			global::System.Type type = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(propertyName, cachedTypeInfo);
			global::System.Type type2 = typeof(global::Infragistics.SummaryContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				type
			});
			return (global::Infragistics.SummaryContext)global::System.Activator.CreateInstance(type2, new object[]
			{
				propertyName,
				linqSummary,
				cachedTypeInfo
			});
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00007811 File Offset: 0x00005A11
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00007819 File Offset: 0x00005A19
		public string FieldName { get; protected set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00007822 File Offset: 0x00005A22
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000782A File Offset: 0x00005A2A
		public global::Infragistics.LinqSummaryOperator LinqSummary { get; protected set; }

		// Token: 0x06000123 RID: 291 RVA: 0x00007834 File Offset: 0x00005A34
		public object Execute(global::System.Linq.IQueryable query)
		{
			object result = null;
			switch (this.LinqSummary)
			{
			case global::Infragistics.LinqSummaryOperator.Count:
				result = this.Count(query);
				break;
			case global::Infragistics.LinqSummaryOperator.Minimum:
				result = this.Minimum(query);
				break;
			case global::Infragistics.LinqSummaryOperator.Maximum:
				result = this.Maximum(query);
				break;
			case global::Infragistics.LinqSummaryOperator.Sum:
				result = this.Sum(query);
				break;
			case global::Infragistics.LinqSummaryOperator.Average:
				result = this.Average(query);
				break;
			}
			return result;
		}

		// Token: 0x06000124 RID: 292
		protected abstract object Maximum(global::System.Linq.IQueryable query);

		// Token: 0x06000125 RID: 293
		protected abstract object Minimum(global::System.Linq.IQueryable query);

		// Token: 0x06000126 RID: 294
		protected abstract object Sum(global::System.Linq.IQueryable query);

		// Token: 0x06000127 RID: 295
		protected abstract int Count(global::System.Linq.IQueryable query);

		// Token: 0x06000128 RID: 296
		protected abstract object Average(global::System.Linq.IQueryable query);
	}
}
