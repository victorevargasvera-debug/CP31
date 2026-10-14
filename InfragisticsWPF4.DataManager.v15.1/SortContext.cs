using System;
using System.Linq;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000012 RID: 18
	public abstract class SortContext
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00006EC6 File Offset: 0x000050C6
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00006ECE File Offset: 0x000050CE
		public string SortPropertyName { get; protected set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00006ED7 File Offset: 0x000050D7
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00006EDF File Offset: 0x000050DF
		public bool SortAscending { get; protected set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006EE8 File Offset: 0x000050E8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00006EF0 File Offset: 0x000050F0
		public global::System.Type PropertyType { get; protected set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006EF9 File Offset: 0x000050F9
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00006F01 File Offset: 0x00005101
		public global::System.Type DataType { get; protected set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006F0A File Offset: 0x0000510A
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00006F12 File Offset: 0x00005112
		public bool CaseSensitiveSort { get; protected set; }

		// Token: 0x060000FB RID: 251 RVA: 0x00006F1C File Offset: 0x0000511C
		public static global::Infragistics.SortContext CreateGenericSort(global::Infragistics.CachedTypedInfo cachedTypeInfo, string propertyName, bool sortAscending, bool isCaseSensitiveSort, object comparer)
		{
			global::System.Type cachedType = cachedTypeInfo.CachedType;
			global::System.Type type = typeof(global::Infragistics.SortContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(propertyName, cachedTypeInfo)
			});
			return (global::Infragistics.SortContext)global::System.Activator.CreateInstance(type, new object[]
			{
				propertyName,
				sortAscending,
				isCaseSensitiveSort,
				comparer,
				cachedTypeInfo
			});
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006F88 File Offset: 0x00005188
		public static global::Infragistics.SortContext CreateGenericSort(global::Infragistics.CachedTypedInfo cachedTypeInfo, bool sortAscending, object comparer, global::System.Windows.Data.IValueConverter converter, object converterParam)
		{
			global::System.Type cachedType = cachedTypeInfo.CachedType;
			global::System.Type type = typeof(global::Infragistics.SortContext<, >).MakeGenericType(new global::System.Type[]
			{
				cachedType,
				cachedType
			});
			return (global::Infragistics.SortContext)global::System.Activator.CreateInstance(type, new object[]
			{
				sortAscending,
				comparer,
				converter,
				converterParam,
				cachedTypeInfo
			});
		}

		// Token: 0x060000FD RID: 253
		public abstract global::System.Linq.IOrderedQueryable<T> Sort<T>(global::System.Linq.IQueryable<T> query);

		// Token: 0x060000FE RID: 254
		public abstract global::System.Linq.IOrderedQueryable<T> AppendSort<T>(global::System.Linq.IOrderedQueryable<T> query);
	}
}
