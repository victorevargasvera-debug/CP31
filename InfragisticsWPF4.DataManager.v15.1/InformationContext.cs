using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Infragistics
{
	// Token: 0x0200000B RID: 11
	public abstract class InformationContext
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005F7F File Offset: 0x0000417F
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00005F87 File Offset: 0x00004187
		public string PropertyName { get; protected set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005F90 File Offset: 0x00004190
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00005F98 File Offset: 0x00004198
		public global::System.Type DataType { get; protected set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005FA1 File Offset: 0x000041A1
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00005FA9 File Offset: 0x000041A9
		public global::System.Type PropertyType { get; protected set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00005FB2 File Offset: 0x000041B2
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00005FBA File Offset: 0x000041BA
		public bool CaseSensitive { get; protected set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005FC3 File Offset: 0x000041C3
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00005FCB File Offset: 0x000041CB
		public bool SortAscending { get; protected set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005FD4 File Offset: 0x000041D4
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005FDC File Offset: 0x000041DC
		public object Comparer { get; protected set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005FE5 File Offset: 0x000041E5
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00005FED File Offset: 0x000041ED
		public global::System.Linq.Expressions.LambdaExpression Lambda { get; protected set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005FF6 File Offset: 0x000041F6
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00005FFE File Offset: 0x000041FE
		protected bool FromDateColumn { get; set; }

		// Token: 0x060000A4 RID: 164 RVA: 0x00006008 File Offset: 0x00004208
		public static global::Infragistics.InformationContext CreateGenericInformationContext(global::Infragistics.CachedTypedInfo cti, string propertyName, bool sortAscending, bool caseSensitive, object comparer, bool fromDateColumn)
		{
			global::System.Type cachedType = cti.CachedType;
			global::System.Type type = typeof(global::Infragistics.InformationContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(propertyName, cti)
			});
			return (global::Infragistics.InformationContext)global::System.Activator.CreateInstance(type, new object[]
			{
				propertyName,
				sortAscending,
				caseSensitive,
				comparer,
				fromDateColumn,
				cti
			});
		}

		// Token: 0x060000A5 RID: 165
		public abstract global::System.Collections.IList GetDistinctValues(global::System.Collections.IEnumerable list);

		// Token: 0x060000A6 RID: 166
		internal abstract global::System.Threading.Tasks.Task<global::System.Collections.IList> GetDistinctValuesAsync(global::System.Collections.IEnumerable list, global::System.Threading.CancellationToken token, bool runAsync);

		// Token: 0x060000A7 RID: 167
		public abstract global::System.Collections.IList GetCompleteValuesList(global::System.Collections.IEnumerable list);

		// Token: 0x0400001B RID: 27
		protected static readonly global::System.Reflection.MethodInfo IsNullOrEmptyMethod = typeof(string).GetMethod("IsNullOrEmpty", new global::System.Type[]
		{
			typeof(string)
		});
	}
}
