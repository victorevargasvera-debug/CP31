using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000354 RID: 852
	public class ExpandableFieldRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600293B RID: 10555 RVA: 0x000B57BD File Offset: 0x000B39BD
		internal ExpandableFieldRecordCollection(global::Infragistics.Windows.DataPresenter.DataRecord owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : base(owner, parentRecordManager, fieldLayout, false)
		{
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000B57D0 File Offset: 0x000B39D0
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000C2D RID: 3117
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				int num = this.IndexOf(field);
				if (num >= 0)
				{
					return this[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_23"));
			}
		}

		// Token: 0x17000C2E RID: 3118
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord this[string fieldName]
		{
			get
			{
				int num = this.IndexOf(fieldName);
				if (num >= 0)
				{
					return this[num];
				}
				if (fieldName != null && fieldName.Trim().Length > 0 && int.TryParse(fieldName, out num) && num >= 0)
				{
					return this[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_24"));
			}
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000B585B File Offset: 0x000B3A5B
		public bool Exists(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.IndexOf(field) >= 0;
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000B586A File Offset: 0x000B3A6A
		public bool Exists(string fieldName)
		{
			return this.IndexOf(fieldName) >= 0;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000B587C File Offset: 0x000B3A7C
		public global::Infragistics.Windows.DataPresenter.DataRecord GetDataRecordFromDataItem(object dataItem, bool recursive)
		{
			if (dataItem == null)
			{
				throw new global::System.ArgumentNullException("dataItem");
			}
			foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in this)
			{
				if (expandableFieldRecord.HasChildren)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
					if (childRecordManagerIfNeeded != null)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecordFromDataItem = childRecordManagerIfNeeded.Sorted.GetDataRecordFromDataItem(dataItem, recursive);
						if (dataRecordFromDataItem != null)
						{
							return dataRecordFromDataItem;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000B58FC File Offset: 0x000B3AFC
		public int IndexOf(string name)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this[i].Field;
				if (field != null && field.Name == name)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000B5940 File Offset: 0x000B3B40
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Field field)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				if (field == this[i].Field)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000B5974 File Offset: 0x000B3B74
		internal void VerifyChildren()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			if (fieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = fieldLayout.Fields;
			if (fields.Version == this._verifiedFieldsVersion)
			{
				return;
			}
			this._verifiedFieldsVersion = fields.Version;
			if (this._inVerifyChildren)
			{
				return;
			}
			this._inVerifyChildren = true;
			try
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
				int expandableFieldsCount = fields.ExpandableFieldsCount;
				if (expandableFieldsCount > 0)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
					{
						if (field.IsExpandableResolved)
						{
							list.Add(field);
							if (expandableFieldsCount == list.Count)
							{
								break;
							}
						}
					}
				}
				int count = list.Count;
				if (count == base.Count)
				{
					bool flag = true;
					for (int i = 0; i < count; i++)
					{
						if (list[i] != this[i].Field)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return;
					}
				}
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>();
				foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in this)
				{
					dictionary.Add(expandableFieldRecord.Field, expandableFieldRecord);
				}
				base.BeginUpdate();
				try
				{
					base.SparseArray.Clear();
					for (int j = 0; j < count; j++)
					{
						global::Infragistics.Windows.DataPresenter.Field field2 = list[j];
						if (dictionary.ContainsKey(field2))
						{
							base.SparseArray.Add(dictionary[field2]);
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 = new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord(this, field2);
							base.SparseArray.Add(expandableFieldRecord2);
							expandableFieldRecord2.Initialize();
						}
					}
				}
				finally
				{
					base.EndUpdate(false);
				}
				base.RaiseChangeEvents(true);
			}
			finally
			{
				this._inVerifyChildren = false;
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000B5B8C File Offset: 0x000B3D8C
		internal global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord GetItemIfExists(global::Infragistics.Windows.DataPresenter.Field field)
		{
			int i = 0;
			int count = base.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = this[i];
				if (field == expandableFieldRecord.Field)
				{
					return expandableFieldRecord;
				}
				i++;
			}
			return null;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000B5BC0 File Offset: 0x000B3DC0
		internal void LoadDataItemRecordMap(global::Infragistics.Windows.DataPresenter.DataItemRecordMap dataItemRecordMap, bool recursive)
		{
			foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in this)
			{
				if (expandableFieldRecord.HasChildren)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
					if (childRecordManagerIfNeeded != null)
					{
						childRecordManagerIfNeeded.Sorted.LoadDataItemRecordMap(dataItemRecordMap, recursive);
						if (dataItemRecordMap._itemsRemainingToBeMapped < 1)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		public int IndexOf(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			return base.IndexOf(item);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000B5C35 File Offset: 0x000B3E35
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000B5C46 File Offset: 0x000B3E46
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000C2F RID: 3119
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord this[int index]
		{
			get
			{
				return base[index] as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000B5C76 File Offset: 0x000B3E76
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Add(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000B5C87 File Offset: 0x000B3E87
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000B5C98 File Offset: 0x000B3E98
		public bool Contains(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			return base.Contains(item);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000B5CA1 File Offset: 0x000B3EA1
		public void CopyTo(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000B5CAB File Offset: 0x000B3EAB
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000B5CAE File Offset: 0x000B3EAE
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Remove(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000B5CBF File Offset: 0x000B3EBF
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.ExpandableFieldRecordEnumerator(base.SparseArray);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000B5CCC File Offset: 0x000B3ECC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}

		// Token: 0x040013F5 RID: 5109
		private bool _inVerifyChildren;

		// Token: 0x040013F6 RID: 5110
		private int _verifiedFieldsVersion = -1;
	}
}
