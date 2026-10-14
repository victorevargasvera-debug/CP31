using System;
using System.Collections;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001FA RID: 506
	internal class SparseList : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001F46 RID: 8006 RVA: 0x000889AF File Offset: 0x00086BAF
		public SparseList()
		{
			this._ownerData = new global::System.Collections.Hashtable();
			this._sparseArray = new global::Infragistics.Windows.DataPresenter.SparseList.HashSparseArray(this);
		}

		// Token: 0x170008FF RID: 2303
		public object this[int index]
		{
			get
			{
				return this._sparseArray[index];
			}
			set
			{
				this._sparseArray[index] = value;
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000889EB File Offset: 0x00086BEB
		public int Add(object value)
		{
			return this._sparseArray.Add(value);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000889F9 File Offset: 0x00086BF9
		internal void AddRange(global::System.Collections.ICollection items)
		{
			this._sparseArray.AddRange(items);
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00088A07 File Offset: 0x00086C07
		public void Clear()
		{
			this._sparseArray.Clear();
			this._ownerData.Clear();
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00088A1F File Offset: 0x00086C1F
		public bool Contains(object value)
		{
			return this._sparseArray.Contains(value);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00088A2D File Offset: 0x00086C2D
		public void CopyTo(global::System.Array array, int index)
		{
			this._sparseArray.CopyTo(array, index);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00088A3C File Offset: 0x00086C3C
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._sparseArray.GetEnumerator();
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00088A49 File Offset: 0x00086C49
		public int IndexOf(object value)
		{
			return this._sparseArray.IndexOf(value);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00088A57 File Offset: 0x00086C57
		public void Insert(int index, object value)
		{
			this._sparseArray.Insert(index, value);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00088A66 File Offset: 0x00086C66
		public void Remove(object value)
		{
			this._sparseArray.Remove(value);
			this._ownerData.Remove(value);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00088A80 File Offset: 0x00086C80
		public void RemoveAt(int index)
		{
			this._sparseArray.RemoveAt(index);
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00088A8E File Offset: 0x00086C8E
		public int Count
		{
			get
			{
				return this._sparseArray.Count;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00088A9B File Offset: 0x00086C9B
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00088A9E File Offset: 0x00086C9E
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00088AA1 File Offset: 0x00086CA1
		public bool IsSynchronized
		{
			get
			{
				return this._sparseArray.IsSynchronized;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00088AAE File Offset: 0x00086CAE
		public object SyncRoot
		{
			get
			{
				return this._sparseArray.SyncRoot;
			}
		}

		// Token: 0x04000D29 RID: 3369
		private global::Infragistics.Windows.DataPresenter.SparseList.HashSparseArray _sparseArray;

		// Token: 0x04000D2A RID: 3370
		private global::System.Collections.Hashtable _ownerData;

		// Token: 0x020001FB RID: 507
		private class HashSparseArray : global::Infragistics.Collections.SparseArray
		{
			// Token: 0x06001F58 RID: 8024 RVA: 0x00088ABB File Offset: 0x00086CBB
			internal HashSparseArray(global::Infragistics.Windows.DataPresenter.SparseList owner) : base(20, 1f, true)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
				this._owner = owner;
			}

			// Token: 0x06001F59 RID: 8025 RVA: 0x00088AD8 File Offset: 0x00086CD8
			protected override object GetOwnerData(object item)
			{
				return this._owner._ownerData[item];
			}

			// Token: 0x06001F5A RID: 8026 RVA: 0x00088AEB File Offset: 0x00086CEB
			protected override void SetOwnerData(object item, object ownerData)
			{
				if (ownerData == null)
				{
					this._owner._ownerData.Remove(item);
					return;
				}
				this._owner._ownerData[item] = ownerData;
			}

			// Token: 0x04000D2B RID: 3371
			private global::Infragistics.Windows.DataPresenter.SparseList _owner;
		}
	}
}
