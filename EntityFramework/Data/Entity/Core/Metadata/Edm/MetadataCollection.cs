using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Runtime.CompilerServices;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D9 RID: 1241
	internal class MetadataCollection<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable where T : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003D96 RID: 15766 RVA: 0x000CAFC3 File Offset: 0x000C91C3
		internal MetadataCollection()
		{
			this._metadataList = new global::System.Collections.Generic.List<T>();
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x000CAFD8 File Offset: 0x000C91D8
		internal MetadataCollection(global::System.Collections.Generic.IEnumerable<T> items)
		{
			this._metadataList = new global::System.Collections.Generic.List<T>();
			if (items != null)
			{
				foreach (T t in items)
				{
					if (t == null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("items"));
					}
					this.AddInternal(t);
				}
			}
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x000CB04C File Offset: 0x000C924C
		private MetadataCollection(global::System.Collections.Generic.List<T> items)
		{
			this._metadataList = items;
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x000CB05B File Offset: 0x000C925B
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> Wrap(global::System.Collections.Generic.List<T> items)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T>(items);
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x000CB063 File Offset: 0x000C9263
		public virtual int Count
		{
			get
			{
				return this._metadataList.Count;
			}
		}

		// Token: 0x17000C1A RID: 3098
		public virtual T this[int index]
		{
			get
			{
				return this._metadataList[index];
			}
			set
			{
				this.ThrowIfReadOnly();
				string identity = this._metadataList[index].Identity;
				this._metadataList[index] = value;
				this.HandleIdentityChange(value, identity, false);
			}
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000CB0C0 File Offset: 0x000C92C0
		internal void HandleIdentityChange(T item, string initialIdentity)
		{
			this.HandleIdentityChange(item, initialIdentity, true);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x000CB0CC File Offset: 0x000C92CC
		private void HandleIdentityChange(T item, string initialIdentity, bool validate)
		{
			T t;
			if (this._caseSensitiveDictionary != null && (!validate || (this._caseSensitiveDictionary.TryGetValue(initialIdentity, out t) && t == item)))
			{
				this.RemoveFromCaseSensitiveDictionary(initialIdentity);
				string identity = item.Identity;
				if (this._caseSensitiveDictionary.ContainsKey(identity))
				{
					this._caseSensitiveDictionary = null;
				}
				else
				{
					this._caseSensitiveDictionary.Add(identity, item);
				}
			}
			this._caseInsensitiveDictionary = null;
		}

		// Token: 0x17000C1B RID: 3099
		public virtual T this[string identity]
		{
			get
			{
				return this.GetValue(identity, false);
			}
			set
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
			}
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x000CB164 File Offset: 0x000C9364
		public virtual T GetValue(string identity, bool ignoreCase)
		{
			T result;
			if (!this.TryGetValue(identity, ignoreCase, out result))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemInvalidIdentity(identity), "identity");
			}
			return result;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x000CB18F File Offset: 0x000C938F
		public virtual bool TryGetValue(string identity, bool ignoreCase, out T item)
		{
			if (!ignoreCase)
			{
				return this.FindCaseSensitive(identity, out item);
			}
			return this.FindCaseInsensitive(identity, out item, false);
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x000CB1A6 File Offset: 0x000C93A6
		public virtual void Add(T item)
		{
			this.ThrowIfReadOnly();
			this.AddInternal(item);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x000CB1B8 File Offset: 0x000C93B8
		private void AddInternal(T item)
		{
			string identity = item.Identity;
			if (this.ContainsIdentityCaseSensitive(identity))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemDuplicateIdentity(identity), "item");
			}
			this._metadataList.Add(item);
			if (this._caseSensitiveDictionary != null)
			{
				this._caseSensitiveDictionary.Add(identity, item);
			}
			this._caseInsensitiveDictionary = null;
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x000CB21C File Offset: 0x000C941C
		internal void AddRange(global::System.Collections.Generic.IEnumerable<T> items)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<T>>(items, "items");
			foreach (T t in items)
			{
				if (t == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("items"));
				}
				this.AddInternal(t);
			}
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x000CB288 File Offset: 0x000C9488
		internal bool Remove(T item)
		{
			this.ThrowIfReadOnly();
			if (!this._metadataList.Remove(item))
			{
				return false;
			}
			if (this._caseSensitiveDictionary != null)
			{
				this.RemoveFromCaseSensitiveDictionary(item.Identity);
			}
			this._caseInsensitiveDictionary = null;
			return true;
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x000CB2C5 File Offset: 0x000C94C5
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(this._metadataList);
			}
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x000CB2D2 File Offset: 0x000C94D2
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T> AsReadOnlyMetadataCollection()
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>(this);
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x000CB2DA File Offset: 0x000C94DA
		public bool IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000CB2E2 File Offset: 0x000C94E2
		internal void ResetReadOnly()
		{
			this._readOnly = false;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x000CB2EC File Offset: 0x000C94EC
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<T> SetReadOnly()
		{
			for (int i = 0; i < this._metadataList.Count; i++)
			{
				this._metadataList[i].SetReadOnly();
			}
			this._readOnly = true;
			this._metadataList.TrimExcess();
			if (this._metadataList.Count <= 8)
			{
				this._caseSensitiveDictionary = null;
				this._caseInsensitiveDictionary = null;
			}
			return this;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x000CB358 File Offset: 0x000C9558
		void global::System.Collections.Generic.IList<!0>.Insert(int index, T item)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x000CB364 File Offset: 0x000C9564
		bool global::System.Collections.Generic.ICollection<!0>.Remove(T item)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x000CB370 File Offset: 0x000C9570
		void global::System.Collections.Generic.IList<!0>.RemoveAt(int index)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x000CB37C File Offset: 0x000C957C
		void global::System.Collections.Generic.ICollection<!0>.Clear()
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x000CB388 File Offset: 0x000C9588
		public bool Contains(T item)
		{
			T t;
			return this.TryGetValue(item.Identity, false, out t) && t == item;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x000CB3BB File Offset: 0x000C95BB
		public virtual bool ContainsIdentity(string identity)
		{
			return this.ContainsIdentityCaseSensitive(identity);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x000CB3C4 File Offset: 0x000C95C4
		public virtual int IndexOf(T item)
		{
			return this._metadataList.IndexOf(item);
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x000CB3D2 File Offset: 0x000C95D2
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			this._metadataList.CopyTo(array, arrayIndex);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x000CB3E1 File Offset: 0x000C95E1
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator GetEnumerator()
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator(this);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x000CB3E9 File Offset: 0x000C95E9
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x000CB3F6 File Offset: 0x000C95F6
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x000CB403 File Offset: 0x000C9603
		internal void InvalidateCache()
		{
			this._caseSensitiveDictionary = null;
			this._caseInsensitiveDictionary = null;
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x000CB417 File Offset: 0x000C9617
		internal bool HasCaseSensitiveDictionary
		{
			get
			{
				return this._caseSensitiveDictionary != null;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x000CB424 File Offset: 0x000C9624
		internal bool HasCaseInsensitiveDictionary
		{
			get
			{
				return this._caseInsensitiveDictionary != null;
			}
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000CB431 File Offset: 0x000C9631
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		internal global::System.Collections.Generic.Dictionary<string, T> GetCaseSensitiveDictionary()
		{
			if (this._caseSensitiveDictionary == null && this._metadataList.Count > 8)
			{
				this._caseSensitiveDictionary = this.CreateCaseSensitiveDictionary();
			}
			return this._caseSensitiveDictionary;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x000CB464 File Offset: 0x000C9664
		private global::System.Collections.Generic.Dictionary<string, T> CreateCaseSensitiveDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, T> dictionary = new global::System.Collections.Generic.Dictionary<string, T>(this._metadataList.Count, global::System.StringComparer.Ordinal);
			for (int i = 0; i < this._metadataList.Count; i++)
			{
				T t = this._metadataList[i];
				dictionary.Add(t.Identity, t);
			}
			return dictionary;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x000CB4BD File Offset: 0x000C96BD
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		internal global::System.Collections.Generic.Dictionary<string, int> GetCaseInsensitiveDictionary()
		{
			if (this._caseInsensitiveDictionary == null && this._metadataList.Count > 8)
			{
				this._caseInsensitiveDictionary = this.CreateCaseInsensitiveDictionary();
			}
			return this._caseInsensitiveDictionary;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x000CB4F0 File Offset: 0x000C96F0
		private global::System.Collections.Generic.Dictionary<string, int> CreateCaseInsensitiveDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>(this._metadataList.Count, global::System.StringComparer.OrdinalIgnoreCase)
			{
				{
					this._metadataList[0].Identity,
					0
				}
			};
			for (int i = 1; i < this._metadataList.Count; i++)
			{
				string identity = this._metadataList[i].Identity;
				int num;
				if (!dictionary.TryGetValue(identity, out num))
				{
					dictionary[identity] = i;
				}
				else if (num >= 0)
				{
					dictionary[identity] = -1;
				}
			}
			return dictionary;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x000CB580 File Offset: 0x000C9780
		private bool ContainsIdentityCaseSensitive(string identity)
		{
			global::System.Collections.Generic.Dictionary<string, T> caseSensitiveDictionary = this.GetCaseSensitiveDictionary();
			if (caseSensitiveDictionary != null)
			{
				return caseSensitiveDictionary.ContainsKey(identity);
			}
			return this.ListContainsIdentityCaseSensitive(identity);
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x000CB5A8 File Offset: 0x000C97A8
		private bool ListContainsIdentityCaseSensitive(string identity)
		{
			for (int i = 0; i < this._metadataList.Count; i++)
			{
				if (this._metadataList[i].Identity.Equals(identity, global::System.StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000CB5F0 File Offset: 0x000C97F0
		private bool FindCaseSensitive(string identity, out T item)
		{
			global::System.Collections.Generic.Dictionary<string, T> caseSensitiveDictionary = this.GetCaseSensitiveDictionary();
			if (caseSensitiveDictionary != null)
			{
				return caseSensitiveDictionary.TryGetValue(identity, out item);
			}
			return this.ListFindCaseSensitive(identity, out item);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x000CB620 File Offset: 0x000C9820
		private bool ListFindCaseSensitive(string identity, out T item)
		{
			for (int i = 0; i < this._metadataList.Count; i++)
			{
				T t = this._metadataList[i];
				if (t.Identity.Equals(identity, global::System.StringComparison.Ordinal))
				{
					item = t;
					return true;
				}
			}
			item = default(T);
			return false;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000CB678 File Offset: 0x000C9878
		private bool FindCaseInsensitive(string identity, out T item, bool throwOnMultipleMatches)
		{
			global::System.Collections.Generic.Dictionary<string, int> caseInsensitiveDictionary = this.GetCaseInsensitiveDictionary();
			if (caseInsensitiveDictionary != null)
			{
				int num;
				if (caseInsensitiveDictionary.TryGetValue(identity, out num))
				{
					if (num >= 0)
					{
						item = this._metadataList[num];
						return true;
					}
					if (throwOnMultipleMatches)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MoreThanOneItemMatchesIdentity(identity));
					}
				}
				item = default(T);
				return false;
			}
			return this.ListFindCaseInsensitive(identity, out item, throwOnMultipleMatches);
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000CB6D4 File Offset: 0x000C98D4
		private bool ListFindCaseInsensitive(string identity, out T item, bool throwOnMultipleMatches)
		{
			bool flag = false;
			item = default(T);
			for (int i = 0; i < this._metadataList.Count; i++)
			{
				T t = this._metadataList[i];
				if (t.Identity.Equals(identity, global::System.StringComparison.OrdinalIgnoreCase))
				{
					if (flag)
					{
						if (throwOnMultipleMatches)
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.MoreThanOneItemMatchesIdentity(identity));
						}
						item = default(T);
						return false;
					}
					else
					{
						flag = true;
						item = t;
					}
				}
			}
			return flag;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000CB746 File Offset: 0x000C9946
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private void RemoveFromCaseSensitiveDictionary(string identity)
		{
			this._caseSensitiveDictionary.Remove(identity);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000CB757 File Offset: 0x000C9957
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private void ThrowIfReadOnly()
		{
			if (this.IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyCollection);
			}
		}

		// Token: 0x04001505 RID: 5381
		internal const int UseDictionaryCrossover = 8;

		// Token: 0x04001506 RID: 5382
		private bool _readOnly;

		// Token: 0x04001507 RID: 5383
		private global::System.Collections.Generic.List<T> _metadataList;

		// Token: 0x04001508 RID: 5384
		private volatile global::System.Collections.Generic.Dictionary<string, T> _caseSensitiveDictionary;

		// Token: 0x04001509 RID: 5385
		private volatile global::System.Collections.Generic.Dictionary<string, int> _caseInsensitiveDictionary;
	}
}
