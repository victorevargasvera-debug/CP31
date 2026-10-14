using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000234 RID: 564
	public class DbRawSqlQuery<TElement> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06001DAE RID: 7598 RVA: 0x00052BB8 File Offset: 0x00050DB8
		internal DbRawSqlQuery(global::System.Data.Entity.Internal.InternalSqlQuery internalQuery)
		{
			this._internalQuery = internalQuery;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00052BC7 File Offset: 0x00050DC7
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public virtual global::System.Data.Entity.Infrastructure.DbRawSqlQuery<TElement> AsStreaming()
		{
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbRawSqlQuery<TElement>(this._internalQuery.AsStreaming());
			}
			return this;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00052BE3 File Offset: 0x00050DE3
		public virtual global::System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
		{
			return (global::System.Collections.Generic.IEnumerator<!0>)this.GetInternalQueryWithCheck("GetEnumerator").GetEnumerator();
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00052BFA File Offset: 0x00050DFA
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00052C02 File Offset: 0x00050E02
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement> global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>.GetAsyncEnumerator()
		{
			return (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement>)this.GetInternalQueryWithCheck("IDbAsyncEnumerable<TElement>.GetAsyncEnumerator").GetAsyncEnumerator();
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00052C19 File Offset: 0x00050E19
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this._internalQuery.GetAsyncEnumerator();
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00052C26 File Offset: 0x00050E26
		public global::System.Threading.Tasks.Task ForEachAsync(global::System.Action<TElement> action)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<TElement>>(action, "action");
			return this.ForEachAsync(action, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00052C40 File Offset: 0x00050E40
		public global::System.Threading.Tasks.Task ForEachAsync(global::System.Action<TElement> action, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<TElement>>(action, "action");
			return this.ForEachAsync(action, cancellationToken);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00052C56 File Offset: 0x00050E56
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TElement>> ToListAsync()
		{
			return this.ToListAsync<TElement>();
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00052C5E File Offset: 0x00050E5E
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TElement>> ToListAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ToListAsync(cancellationToken);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00052C67 File Offset: 0x00050E67
		public global::System.Threading.Tasks.Task<TElement[]> ToArrayAsync()
		{
			return this.ToArrayAsync<TElement>();
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00052C6F File Offset: 0x00050E6F
		public global::System.Threading.Tasks.Task<TElement[]> ToArrayAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ToArrayAsync(cancellationToken);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00052C78 File Offset: 0x00050E78
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TKey>(global::System.Func<TElement, TKey> keySelector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			return this.ToDictionaryAsync(keySelector);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00052C8D File Offset: 0x00050E8D
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TKey>(global::System.Func<TElement, TKey> keySelector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			return this.ToDictionaryAsync(keySelector, cancellationToken);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00052CA3 File Offset: 0x00050EA3
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TKey>(global::System.Func<TElement, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			return this.ToDictionaryAsync(keySelector, comparer);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00052CB9 File Offset: 0x00050EB9
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TKey>(global::System.Func<TElement, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			return this.ToDictionaryAsync(keySelector, comparer, cancellationToken);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00052CD0 File Offset: 0x00050ED0
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(global::System.Func<TElement, TKey> keySelector, global::System.Func<TElement, TResult> elementSelector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TResult>>(elementSelector, "elementSelector");
			return this.ToDictionaryAsync(keySelector, elementSelector);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00052CF2 File Offset: 0x00050EF2
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(global::System.Func<TElement, TKey> keySelector, global::System.Func<TElement, TResult> elementSelector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TResult>>(elementSelector, "elementSelector");
			return this.ToDictionaryAsync(keySelector, elementSelector, cancellationToken);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00052D15 File Offset: 0x00050F15
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(global::System.Func<TElement, TKey> keySelector, global::System.Func<TElement, TResult> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TResult>>(elementSelector, "elementSelector");
			return this.ToDictionaryAsync(keySelector, elementSelector, comparer);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00052D38 File Offset: 0x00050F38
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TResult>> ToDictionaryAsync<TKey, TResult>(global::System.Func<TElement, TKey> keySelector, global::System.Func<TElement, TResult> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, TResult>>(elementSelector, "elementSelector");
			return this.ToDictionaryAsync(keySelector, elementSelector, comparer, cancellationToken);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00052D5D File Offset: 0x00050F5D
		public global::System.Threading.Tasks.Task<TElement> FirstAsync()
		{
			return this.FirstAsync<TElement>();
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00052D65 File Offset: 0x00050F65
		public global::System.Threading.Tasks.Task<TElement> FirstAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.FirstAsync(cancellationToken);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00052D6E File Offset: 0x00050F6E
		public global::System.Threading.Tasks.Task<TElement> FirstAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.FirstAsync(predicate);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00052D83 File Offset: 0x00050F83
		public global::System.Threading.Tasks.Task<TElement> FirstAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.FirstAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00052D99 File Offset: 0x00050F99
		public global::System.Threading.Tasks.Task<TElement> FirstOrDefaultAsync()
		{
			return this.FirstOrDefaultAsync<TElement>();
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00052DA1 File Offset: 0x00050FA1
		public global::System.Threading.Tasks.Task<TElement> FirstOrDefaultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.FirstOrDefaultAsync(cancellationToken);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00052DAA File Offset: 0x00050FAA
		public global::System.Threading.Tasks.Task<TElement> FirstOrDefaultAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.FirstOrDefaultAsync(predicate);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00052DBF File Offset: 0x00050FBF
		public global::System.Threading.Tasks.Task<TElement> FirstOrDefaultAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.FirstOrDefaultAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00052DD5 File Offset: 0x00050FD5
		public global::System.Threading.Tasks.Task<TElement> SingleAsync()
		{
			return this.SingleAsync<TElement>();
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00052DDD File Offset: 0x00050FDD
		public global::System.Threading.Tasks.Task<TElement> SingleAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.SingleAsync(cancellationToken);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00052DE6 File Offset: 0x00050FE6
		public global::System.Threading.Tasks.Task<TElement> SingleAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.SingleAsync(predicate);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00052DFB File Offset: 0x00050FFB
		public global::System.Threading.Tasks.Task<TElement> SingleAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.SingleAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00052E11 File Offset: 0x00051011
		public global::System.Threading.Tasks.Task<TElement> SingleOrDefaultAsync()
		{
			return this.SingleOrDefaultAsync<TElement>();
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00052E19 File Offset: 0x00051019
		public global::System.Threading.Tasks.Task<TElement> SingleOrDefaultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.SingleOrDefaultAsync(cancellationToken);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00052E22 File Offset: 0x00051022
		public global::System.Threading.Tasks.Task<TElement> SingleOrDefaultAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.SingleOrDefaultAsync(predicate);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00052E37 File Offset: 0x00051037
		public global::System.Threading.Tasks.Task<TElement> SingleOrDefaultAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.SingleOrDefaultAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00052E4D File Offset: 0x0005104D
		public global::System.Threading.Tasks.Task<bool> ContainsAsync(TElement value)
		{
			return this.ContainsAsync(value);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00052E56 File Offset: 0x00051056
		public global::System.Threading.Tasks.Task<bool> ContainsAsync(TElement value, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ContainsAsync(value, cancellationToken);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00052E60 File Offset: 0x00051060
		public global::System.Threading.Tasks.Task<bool> AnyAsync()
		{
			return this.AnyAsync<TElement>();
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00052E68 File Offset: 0x00051068
		public global::System.Threading.Tasks.Task<bool> AnyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.AnyAsync(cancellationToken);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00052E71 File Offset: 0x00051071
		public global::System.Threading.Tasks.Task<bool> AnyAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.AnyAsync(predicate);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00052E86 File Offset: 0x00051086
		public global::System.Threading.Tasks.Task<bool> AnyAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.AnyAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00052E9C File Offset: 0x0005109C
		public global::System.Threading.Tasks.Task<bool> AllAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.AllAsync(predicate);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00052EB1 File Offset: 0x000510B1
		public global::System.Threading.Tasks.Task<bool> AllAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.AllAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00052EC7 File Offset: 0x000510C7
		public global::System.Threading.Tasks.Task<int> CountAsync()
		{
			return this.CountAsync<TElement>();
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00052ECF File Offset: 0x000510CF
		public global::System.Threading.Tasks.Task<int> CountAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.CountAsync(cancellationToken);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00052ED8 File Offset: 0x000510D8
		public global::System.Threading.Tasks.Task<int> CountAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.CountAsync(predicate);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00052EED File Offset: 0x000510ED
		public global::System.Threading.Tasks.Task<int> CountAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.CountAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00052F03 File Offset: 0x00051103
		public global::System.Threading.Tasks.Task<long> LongCountAsync()
		{
			return this.LongCountAsync<TElement>();
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00052F0B File Offset: 0x0005110B
		public global::System.Threading.Tasks.Task<long> LongCountAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.LongCountAsync(cancellationToken);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00052F14 File Offset: 0x00051114
		public global::System.Threading.Tasks.Task<long> LongCountAsync(global::System.Func<TElement, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.LongCountAsync(predicate);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00052F29 File Offset: 0x00051129
		public global::System.Threading.Tasks.Task<long> LongCountAsync(global::System.Func<TElement, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TElement, bool>>(predicate, "predicate");
			return this.LongCountAsync(predicate, cancellationToken);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00052F3F File Offset: 0x0005113F
		public global::System.Threading.Tasks.Task<TElement> MinAsync()
		{
			return this.MinAsync<TElement>();
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00052F47 File Offset: 0x00051147
		public global::System.Threading.Tasks.Task<TElement> MinAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MinAsync(cancellationToken);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00052F50 File Offset: 0x00051150
		public global::System.Threading.Tasks.Task<TElement> MaxAsync()
		{
			return this.MaxAsync<TElement>();
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00052F58 File Offset: 0x00051158
		public global::System.Threading.Tasks.Task<TElement> MaxAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MaxAsync(cancellationToken);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00052F61 File Offset: 0x00051161
		public override string ToString()
		{
			if (this._internalQuery != null)
			{
				return this._internalQuery.ToString();
			}
			return base.ToString();
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00052F7D File Offset: 0x0005117D
		internal global::System.Data.Entity.Internal.InternalSqlQuery InternalQuery
		{
			get
			{
				return this._internalQuery;
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00052F85 File Offset: 0x00051185
		private global::System.Data.Entity.Internal.InternalSqlQuery GetInternalQueryWithCheck(string memberName)
		{
			if (this._internalQuery == null)
			{
				throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.Infrastructure.DbSqlQuery<>).Name));
			}
			return this._internalQuery;
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00052FBB File Offset: 0x000511BB
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00052FBE File Offset: 0x000511BE
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			throw global::System.Data.Entity.Resources.Error.DbQuery_BindingToDbQueryNotSupported();
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00052FC5 File Offset: 0x000511C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00052FCE File Offset: 0x000511CE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00052FD6 File Offset: 0x000511D6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B27 RID: 2855
		private readonly global::System.Data.Entity.Internal.InternalSqlQuery _internalQuery;
	}
}
