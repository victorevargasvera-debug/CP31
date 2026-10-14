using System;
using System.Collections;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D2 RID: 466
	internal class SparseList : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001B2F RID: 6959 RVA: 0x00074983 File Offset: 0x00072B83
		public SparseList()
		{
			this._ownerData = new global::System.Collections.Hashtable();
			this._sparseArray = new global::Infragistics.Windows.DataPresenter.SparseList.HashSparseArray(this);
		}

		// Token: 0x17000778 RID: 1912
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

		// Token: 0x06001B32 RID: 6962 RVA: 0x000749BF File Offset: 0x00072BBF
		public int Add(object value)
		{
			return this._sparseArray.Add(value);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000749CD File Offset: 0x00072BCD
		internal void AddRange(global::System.Collections.ICollection items)
		{
			this._sparseArray.AddRange(items);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000749DB File Offset: 0x00072BDB
		public void Clear()
		{
			this._sparseArray.Clear();
			this._ownerData.Clear();
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000749F3 File Offset: 0x00072BF3
		public bool Contains(object value)
		{
			return this._sparseArray.Contains(value);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00074A01 File Offset: 0x00072C01
		public void CopyTo(global::System.Array array, int index)
		{
			this._sparseArray.CopyTo(array, index);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00074A10 File Offset: 0x00072C10
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._sparseArray.GetEnumerator();
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00074A1D File Offset: 0x00072C1D
		public int IndexOf(object value)
		{
			return this._sparseArray.IndexOf(value);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00074A2B File Offset: 0x00072C2B
		public void Insert(int index, object value)
		{
			this._sparseArray.Insert(index, value);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00074A3A File Offset: 0x00072C3A
		public void Remove(object value)
		{
			this._sparseArray.Remove(value);
			this._ownerData.Remove(value);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00074A54 File Offset: 0x00072C54
		public void RemoveAt(int index)
		{
			this._sparseArray.RemoveAt(index);
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00074A62 File Offset: 0x00072C62
		public int Count
		{
			get
			{
				return this._sparseArray.Count;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00074A6F File Offset: 0x00072C6F
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00074A72 File Offset: 0x00072C72
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00074A75 File Offset: 0x00072C75
		public bool IsSynchronized
		{
			get
			{
				return this._sparseArray.IsSynchronized;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00074A82 File Offset: 0x00072C82
		public object SyncRoot
		{
			get
			{
				return this._sparseArray.SyncRoot;
			}
		}

		// Token: 0x04000B39 RID: 2873
		private global::Infragistics.Windows.DataPresenter.SparseList.HashSparseArray _sparseArray;

		// Token: 0x04000B3A RID: 2874
		private global::System.Collections.Hashtable _ownerData;

		// Token: 0x020001D3 RID: 467
		private class HashSparseArray : global::Infragistics.Collections.SparseArray
		{
			// Token: 0x06001B41 RID: 6977 RVA: 0x00074A8F File Offset: 0x00072C8F
			internal HashSparseArray(global::Infragistics.Windows.DataPresenter.SparseList owner) : base(20, 1f, true)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
				this._owner = owner;
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x00074AAC File Offset: 0x00072CAC
			protected override object GetOwnerData(object item)
			{
				return this._owner._ownerData[item];
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x00074ABF File Offset: 0x00072CBF
			protected override void SetOwnerData(object item, object ownerData)
			{
				if (ownerData == null)
				{
					this._owner._ownerData.Remove(item);
					return;
				}
				this._owner._ownerData[item] = ownerData;
			}

			// Token: 0x04000B3B RID: 2875
			private global::Infragistics.Windows.DataPresenter.SparseList _owner;
		}
	}
}
