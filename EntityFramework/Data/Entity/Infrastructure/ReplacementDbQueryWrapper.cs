using System;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200025B RID: 603
	public sealed class ReplacementDbQueryWrapper<TElement>
	{
		// Token: 0x06001ED9 RID: 7897 RVA: 0x00054C10 File Offset: 0x00052E10
		private ReplacementDbQueryWrapper(global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> query)
		{
			this._query = query;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00054C1F File Offset: 0x00052E1F
		internal static global::System.Data.Entity.Infrastructure.ReplacementDbQueryWrapper<TElement> Create(global::System.Data.Entity.Core.Objects.ObjectQuery query)
		{
			return new global::System.Data.Entity.Infrastructure.ReplacementDbQueryWrapper<TElement>((global::System.Data.Entity.Core.Objects.ObjectQuery<TElement>)query);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00054C2C File Offset: 0x00052E2C
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> Query
		{
			get
			{
				return this._query;
			}
		}

		// Token: 0x04000B3B RID: 2875
		private readonly global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> _query;
	}
}
