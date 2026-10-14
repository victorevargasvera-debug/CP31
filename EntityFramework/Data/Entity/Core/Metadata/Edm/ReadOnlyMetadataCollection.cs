using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004EF RID: 1263
	public class ReadOnlyMetadataCollection<T> : global::System.Collections.ObjectModel.ReadOnlyCollection<T> where T : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003EDA RID: 16090 RVA: 0x000D04F4 File Offset: 0x000CE6F4
		internal ReadOnlyMetadataCollection() : base(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>())
		{
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x000D0501 File Offset: 0x000CE701
		internal ReadOnlyMetadataCollection(global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> collection) : base(collection)
		{
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x000D050A File Offset: 0x000CE70A
		internal ReadOnlyMetadataCollection(global::System.Collections.Generic.List<T> list) : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>.Wrap(list))
		{
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x000D0518 File Offset: 0x000CE718
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000C52 RID: 3154
		public virtual T this[string identity]
		{
			get
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>)base.Items)[identity];
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x000D0530 File Offset: 0x000CE730
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> Source
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> result;
				try
				{
					result = (global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>)base.Items;
				}
				finally
				{
					global::System.EventHandler sourceAccessed = this.SourceAccessed;
					if (sourceAccessed != null)
					{
						sourceAccessed(this, null);
					}
				}
				return result;
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06003EE0 RID: 16096 RVA: 0x000D0570 File Offset: 0x000CE770
		// (remove) Token: 0x06003EE1 RID: 16097 RVA: 0x000D05A8 File Offset: 0x000CE7A8
		internal event global::System.EventHandler SourceAccessed;

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000D05DD File Offset: 0x000CE7DD
		public virtual T GetValue(string identity, bool ignoreCase)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>)base.Items).GetValue(identity, ignoreCase);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000D05F1 File Offset: 0x000CE7F1
		public virtual bool Contains(string identity)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>)base.Items).ContainsIdentity(identity);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x000D0604 File Offset: 0x000CE804
		public virtual bool TryGetValue(string identity, bool ignoreCase, out T item)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>)base.Items).TryGetValue(identity, ignoreCase, out item);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x000D0619 File Offset: 0x000CE819
		public new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator GetEnumerator()
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator(base.Items);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x000D0626 File Offset: 0x000CE826
		public new virtual int IndexOf(T value)
		{
			return base.IndexOf(value);
		}

		// Token: 0x02000B0E RID: 2830
		public struct Enumerator : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06006467 RID: 25703 RVA: 0x0015A58D File Offset: 0x0015878D
			internal Enumerator(global::System.Collections.Generic.IList<T> collection)
			{
				this._parent = collection;
				this._nextIndex = 0;
				this._current = default(T);
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06006468 RID: 25704 RVA: 0x0015A5A9 File Offset: 0x001587A9
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x06006469 RID: 25705 RVA: 0x0015A5B1 File Offset: 0x001587B1
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x0600646A RID: 25706 RVA: 0x0015A5BE File Offset: 0x001587BE
			public void Dispose()
			{
			}

			// Token: 0x0600646B RID: 25707 RVA: 0x0015A5C0 File Offset: 0x001587C0
			public bool MoveNext()
			{
				if (this._nextIndex < this._parent.Count)
				{
					this._current = this._parent[this._nextIndex];
					this._nextIndex++;
					return true;
				}
				this._current = default(T);
				return false;
			}

			// Token: 0x0600646C RID: 25708 RVA: 0x0015A614 File Offset: 0x00158814
			public void Reset()
			{
				this._current = default(T);
				this._nextIndex = 0;
			}

			// Token: 0x04002CA2 RID: 11426
			private int _nextIndex;

			// Token: 0x04002CA3 RID: 11427
			private readonly global::System.Collections.Generic.IList<T> _parent;

			// Token: 0x04002CA4 RID: 11428
			private T _current;
		}
	}
}
