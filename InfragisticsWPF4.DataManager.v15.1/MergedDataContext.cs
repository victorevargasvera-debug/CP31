using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x0200000D RID: 13
	public abstract class MergedDataContext
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000066BC File Offset: 0x000048BC
		public string PropertyName { get; protected set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000066C5 File Offset: 0x000048C5
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000066CD File Offset: 0x000048CD
		public global::Infragistics.SortContext SortContext { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000066D6 File Offset: 0x000048D6
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000066DE File Offset: 0x000048DE
		public bool SortAscending { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000066E7 File Offset: 0x000048E7
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000066EF File Offset: 0x000048EF
		public object MergedObject { get; set; }

		// Token: 0x060000BF RID: 191 RVA: 0x000066F8 File Offset: 0x000048F8
		public static global::Infragistics.MergedDataContext CreateGenericCustomMerge(global::Infragistics.CachedTypedInfo cti, string propertyName, object comparer)
		{
			global::System.Type cachedType = cti.CachedType;
			global::System.Type type = typeof(global::Infragistics.MergedDataContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(propertyName, cti)
			});
			return (global::Infragistics.MergedDataContext)global::System.Activator.CreateInstance(type, new object[]
			{
				propertyName,
				comparer,
				cti
			});
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006754 File Offset: 0x00004954
		public static global::Infragistics.MergedDataContext CreateGenericCustomMerge(global::Infragistics.CachedTypedInfo cti, object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam)
		{
			global::System.Type cachedType = cti.CachedType;
			global::System.Type type = typeof(global::Infragistics.MergedDataContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				cachedType
			});
			return (global::Infragistics.MergedDataContext)global::System.Activator.CreateInstance(type, new object[]
			{
				comparer,
				converter,
				converterParam,
				cti
			});
		}

		// Token: 0x060000C1 RID: 193
		public abstract global::System.Collections.IList Merge(global::System.Linq.IQueryable query, global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> mdcs, global::Infragistics.SummaryDefinitionCollection summaries);

		// Token: 0x060000C2 RID: 194
		protected internal abstract global::System.Collections.IList Merge(global::System.Linq.IQueryable q, global::System.Collections.Generic.List<global::Infragistics.MergedDataContext> mdcs, global::Infragistics.MergeDelegate<object, global::System.Collections.IEnumerable, global::Infragistics.MergedDataContext, object, global::Infragistics.MergedColumnInfo, object> method, global::Infragistics.MergedColumnInfo parentMCI);
	}
}
