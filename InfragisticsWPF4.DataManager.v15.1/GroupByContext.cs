using System;
using System.Collections;
using System.Linq;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000008 RID: 8
	public abstract class GroupByContext
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000057E9 File Offset: 0x000039E9
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000057F1 File Offset: 0x000039F1
		public string PropertyName { get; protected set; }

		// Token: 0x06000070 RID: 112 RVA: 0x000057FC File Offset: 0x000039FC
		public static global::Infragistics.GroupByContext CreateGenericCustomGroup(global::Infragistics.CachedTypedInfo cti, string propertyName, object comparer)
		{
			global::System.Type cachedType = cti.CachedType;
			global::System.Type type = typeof(global::Infragistics.GroupByContext<>).MakeGenericType(new global::System.Type[]
			{
				global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(propertyName, cti)
			});
			return (global::Infragistics.GroupByContext)global::System.Activator.CreateInstance(type, new object[]
			{
				propertyName,
				comparer,
				cti
			});
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005854 File Offset: 0x00003A54
		public static global::Infragistics.GroupByContext CreateGenericCustomGroup(global::Infragistics.CachedTypedInfo cti, object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam)
		{
			global::System.Type cachedType = cti.CachedType;
			global::System.Type type = typeof(global::Infragistics.GroupByContext<>).MakeGenericType(new global::System.Type[]
			{
				cachedType
			});
			return (global::Infragistics.GroupByContext)global::System.Activator.CreateInstance(type, new object[]
			{
				comparer,
				converter,
				converterParam,
				cti
			});
		}

		// Token: 0x06000072 RID: 114
		public abstract global::System.Collections.IList Group<T>(global::System.Linq.IQueryable<T> query);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000058A7 File Offset: 0x00003AA7
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000058AF File Offset: 0x00003AAF
		protected internal global::Infragistics.SummaryDefinitionCollection Summaries { get; set; }
	}
}
