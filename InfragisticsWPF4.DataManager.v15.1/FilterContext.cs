using System;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x02000005 RID: 5
	public abstract class FilterContext
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000024AC File Offset: 0x000006AC
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000024B4 File Offset: 0x000006B4
		public bool CaseSensitive { get; protected set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000024BD File Offset: 0x000006BD
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000024C5 File Offset: 0x000006C5
		public global::System.Type FieldDataType { get; protected set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000024CE File Offset: 0x000006CE
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000024D6 File Offset: 0x000006D6
		protected bool FromDateColumn { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000024DF File Offset: 0x000006DF
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000024E7 File Offset: 0x000006E7
		protected global::Infragistics.CachedTypedInfo CachedTypedInfo { get; set; }

		// Token: 0x0600001B RID: 27 RVA: 0x000024F0 File Offset: 0x000006F0
		public static global::Infragistics.FilterContext CreateGenericFilter(global::Infragistics.CachedTypedInfo cachedTypeInfo, global::System.Type fieldDataType, bool caseSensitive, bool fromDateColumn)
		{
			global::System.Type cachedType = cachedTypeInfo.CachedType;
			global::System.Type type = typeof(global::Infragistics.FilterContext<>).MakeGenericType(new global::System.Type[]
			{
				cachedType
			});
			return (global::Infragistics.FilterContext)global::System.Activator.CreateInstance(type, new object[]
			{
				fieldDataType,
				caseSensitive,
				fromDateColumn,
				cachedTypeInfo
			});
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000254D File Offset: 0x0000074D
		public virtual global::System.Linq.Expressions.Expression CreateExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value, bool caseSensitive)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002550 File Offset: 0x00000750
		public virtual global::System.Linq.Expressions.Expression CreateExpression(string fieldName, global::Infragistics.ComparisonOperator op, object value)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002553 File Offset: 0x00000753
		public virtual global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.ConditionCollection conditionGroup)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002556 File Offset: 0x00000756
		public virtual global::System.Linq.Expressions.Expression CreateExpression(global::Infragistics.RecordFilterCollection conditionGroup)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32
		internal abstract global::System.Linq.Expressions.Expression And(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right);

		// Token: 0x06000021 RID: 33
		internal abstract global::System.Linq.Expressions.Expression Or(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right);
	}
}
