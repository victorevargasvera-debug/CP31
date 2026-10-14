using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x02000676 RID: 1654
	internal sealed class NodeList<T> : global::System.Data.Entity.Core.Common.EntitySql.AST.Node, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable where T : global::System.Data.Entity.Core.Common.EntitySql.AST.Node
	{
		// Token: 0x06004F24 RID: 20260 RVA: 0x0011EFED File Offset: 0x0011D1ED
		internal NodeList()
		{
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x0011F000 File Offset: 0x0011D200
		internal NodeList(T item)
		{
			this._list.Add(item);
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x0011F01F File Offset: 0x0011D21F
		internal global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<T> Add(T item)
		{
			this._list.Add(item);
			return this;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x0011F02E File Offset: 0x0011D22E
		internal int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x17000F43 RID: 3907
		internal T this[int index]
		{
			get
			{
				return this._list[index];
			}
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x0011F049 File Offset: 0x0011D249
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x0011F05B File Offset: 0x0011D25B
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x04001C9B RID: 7323
		private readonly global::System.Collections.Generic.List<T> _list = new global::System.Collections.Generic.List<T>();
	}
}
