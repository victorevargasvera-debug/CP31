using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000636 RID: 1590
	internal class CompensatingCollection<TElement> : global::System.Linq.IOrderedQueryable<TElement>, global::System.Linq.IQueryable<TElement>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Linq.IOrderedQueryable, global::System.Linq.IOrderedEnumerable<TElement>
	{
		// Token: 0x06004CA6 RID: 19622 RVA: 0x0010DFA9 File Offset: 0x0010C1A9
		public CompensatingCollection(global::System.Collections.Generic.IEnumerable<TElement> source)
		{
			this._source = source;
			this._expression = global::System.Linq.Expressions.Expression.Constant(source);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x0010DFC4 File Offset: 0x0010C1C4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._source.GetEnumerator();
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x0010DFD1 File Offset: 0x0010C1D1
		global::System.Collections.Generic.IEnumerator<TElement> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this._source.GetEnumerator();
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x0010DFDE File Offset: 0x0010C1DE
		global::System.Linq.IOrderedEnumerable<TElement> global::System.Linq.IOrderedEnumerable<!0>.CreateOrderedEnumerable<K>(global::System.Func<TElement, K> keySelector, global::System.Collections.Generic.IComparer<K> comparer, bool descending)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_CreateOrderedEnumerableNotSupported);
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x0010DFEA File Offset: 0x0010C1EA
		global::System.Type global::System.Linq.IQueryable.ElementType
		{
			get
			{
				return typeof(TElement);
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x0010DFF6 File Offset: 0x0010C1F6
		global::System.Linq.Expressions.Expression global::System.Linq.IQueryable.Expression
		{
			get
			{
				return this._expression;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06004CAC RID: 19628 RVA: 0x0010DFFE File Offset: 0x0010C1FE
		global::System.Linq.IQueryProvider global::System.Linq.IQueryable.Provider
		{
			get
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedQueryableMethod);
			}
		}

		// Token: 0x04001B18 RID: 6936
		private readonly global::System.Collections.Generic.IEnumerable<TElement> _source;

		// Token: 0x04001B19 RID: 6937
		private readonly global::System.Linq.Expressions.Expression _expression;
	}
}
