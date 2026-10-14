using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041C RID: 1052
	public abstract class ObjectResult : global::System.Collections.IEnumerable, global::System.IDisposable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x0600329E RID: 12958 RVA: 0x000A1715 File Offset: 0x0009F915
		protected internal ObjectResult()
		{
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000A171D File Offset: 0x0009F91D
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this.GetAsyncEnumeratorInternal();
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000A1725 File Offset: 0x0009F925
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumeratorInternal();
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x000A172D File Offset: 0x0009F92D
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000A1730 File Offset: 0x0009F930
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			return this.GetIListSourceListInternal();
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060032A3 RID: 12963
		public abstract global::System.Type ElementType { get; }

		// Token: 0x060032A4 RID: 12964 RVA: 0x000A1738 File Offset: 0x0009F938
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060032A5 RID: 12965
		protected abstract void Dispose(bool disposing);

		// Token: 0x060032A6 RID: 12966 RVA: 0x000A1747 File Offset: 0x0009F947
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> GetNextResult<TElement>()
		{
			return this.GetNextResultInternal<TElement>();
		}

		// Token: 0x060032A7 RID: 12967
		internal abstract global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumeratorInternal();

		// Token: 0x060032A8 RID: 12968
		internal abstract global::System.Collections.IEnumerator GetEnumeratorInternal();

		// Token: 0x060032A9 RID: 12969
		internal abstract global::System.Collections.IList GetIListSourceListInternal();

		// Token: 0x060032AA RID: 12970
		internal abstract global::System.Data.Entity.Core.Objects.ObjectResult<TElement> GetNextResultInternal<TElement>();
	}
}
