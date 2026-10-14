using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C6 RID: 1222
	internal class FilteredReadOnlyMetadataCollection<TDerived, TBase> : global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<TDerived>, global::System.Data.Entity.Core.Metadata.Edm.IBaseList<TBase>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable where TDerived : TBase where TBase : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003C77 RID: 15479 RVA: 0x000C7B28 File Offset: 0x000C5D28
		internal FilteredReadOnlyMetadataCollection(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<TBase> collection, global::System.Predicate<TBase> predicate) : base(global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<TDerived, TBase>.FilterCollection(collection, predicate))
		{
			this._source = collection;
			this._predicate = predicate;
		}

		// Token: 0x17000BE8 RID: 3048
		public override TDerived this[string identity]
		{
			get
			{
				TBase tbase = this._source[identity];
				if (this._predicate(tbase))
				{
					return (TDerived)((object)tbase);
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemInvalidIdentity(identity), "identity");
			}
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x000C7B8C File Offset: 0x000C5D8C
		public override TDerived GetValue(string identity, bool ignoreCase)
		{
			TBase value = this._source.GetValue(identity, ignoreCase);
			if (this._predicate(value))
			{
				return (TDerived)((object)value);
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemInvalidIdentity(identity), "identity");
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x000C7BD4 File Offset: 0x000C5DD4
		public override bool Contains(string identity)
		{
			TBase obj;
			return this._source.TryGetValue(identity, false, out obj) && this._predicate(obj);
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x000C7C00 File Offset: 0x000C5E00
		public override bool TryGetValue(string identity, bool ignoreCase, out TDerived item)
		{
			item = default(TDerived);
			TBase tbase;
			if (this._source.TryGetValue(identity, ignoreCase, out tbase) && this._predicate(tbase))
			{
				item = (TDerived)((object)tbase);
				return true;
			}
			return false;
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x000C7C48 File Offset: 0x000C5E48
		internal static global::System.Collections.Generic.List<TDerived> FilterCollection(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<TBase> collection, global::System.Predicate<TBase> predicate)
		{
			global::System.Collections.Generic.List<TDerived> list = new global::System.Collections.Generic.List<TDerived>(collection.Count);
			for (int i = 0; i < collection.Count; i++)
			{
				TBase tbase = collection[i];
				if (predicate(tbase))
				{
					list.Add((TDerived)((object)tbase));
				}
			}
			return list;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x000C7C98 File Offset: 0x000C5E98
		public override int IndexOf(TDerived value)
		{
			TBase tbase;
			if (this._source.TryGetValue(value.Identity, false, out tbase) && this._predicate(tbase))
			{
				return base.IndexOf((TDerived)((object)tbase));
			}
			return -1;
		}

		// Token: 0x17000BE9 RID: 3049
		TBase global::System.Data.Entity.Core.Metadata.Edm.IBaseList<!1>.this[string identity]
		{
			get
			{
				return (TBase)((object)this[identity]);
			}
		}

		// Token: 0x17000BEA RID: 3050
		TBase global::System.Data.Entity.Core.Metadata.Edm.IBaseList<!1>.this[int index]
		{
			get
			{
				return (TBase)((object)base[index]);
			}
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x000C7D07 File Offset: 0x000C5F07
		int global::System.Data.Entity.Core.Metadata.Edm.IBaseList<!1>.IndexOf(TBase item)
		{
			if (this._predicate(item))
			{
				return this.IndexOf((TDerived)((object)item));
			}
			return -1;
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x000C7D2A File Offset: 0x000C5F2A
		bool global::System.Collections.IList.get_IsReadOnly()
		{
			return base.IsReadOnly;
		}

		// Token: 0x040014D3 RID: 5331
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<TBase> _source;

		// Token: 0x040014D4 RID: 5332
		private readonly global::System.Predicate<TBase> _predicate;
	}
}
