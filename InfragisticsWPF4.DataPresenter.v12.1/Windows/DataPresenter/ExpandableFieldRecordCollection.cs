using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000313 RID: 787
	public class ExpandableFieldRecordCollection : global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002589 RID: 9609 RVA: 0x000A17CD File Offset: 0x0009F9CD
		internal ExpandableFieldRecordCollection(global::Infragistics.Windows.DataPresenter.DataRecord owner, global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : base(owner, parentRecordManager, fieldLayout, false)
		{
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000A17E0 File Offset: 0x0009F9E0
		internal override global::Infragistics.Windows.DataPresenter.RecordType RecordsType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000AFC RID: 2812
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

		// Token: 0x17000AFD RID: 2813
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

		// Token: 0x0600258D RID: 9613 RVA: 0x000A186B File Offset: 0x0009FA6B
		public bool Exists(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.IndexOf(field) >= 0;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000A187A File Offset: 0x0009FA7A
		public bool Exists(string fieldName)
		{
			return this.IndexOf(fieldName) >= 0;
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000A188C File Offset: 0x0009FA8C
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

		// Token: 0x06002590 RID: 9616 RVA: 0x000A190C File Offset: 0x0009FB0C
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

		// Token: 0x06002591 RID: 9617 RVA: 0x000A1950 File Offset: 0x0009FB50
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

		// Token: 0x06002592 RID: 9618 RVA: 0x000A1984 File Offset: 0x0009FB84
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

		// Token: 0x06002593 RID: 9619 RVA: 0x000A1B9C File Offset: 0x0009FD9C
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

		// Token: 0x06002594 RID: 9620 RVA: 0x000A1BD0 File Offset: 0x0009FDD0
		public int IndexOf(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			return base.IndexOf(item);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000A1BD9 File Offset: 0x0009FDD9
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Insert(int index, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000A1BEA File Offset: 0x0009FDEA
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000AFE RID: 2814
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

		// Token: 0x06002599 RID: 9625 RVA: 0x000A1C1A File Offset: 0x0009FE1A
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Add(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000A1C2B File Offset: 0x0009FE2B
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000A1C3C File Offset: 0x0009FE3C
		public bool Contains(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			return base.Contains(item);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000A1C45 File Offset: 0x0009FE45
		public void CopyTo(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord[] array, int arrayIndex)
		{
			base.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000A1C4F File Offset: 0x0009FE4F
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000A1C52 File Offset: 0x0009FE52
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord>.Remove(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000A1C63 File Offset: 0x0009FE63
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.ExpandableFieldRecordEnumerator(base.SparseArray);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000A1C70 File Offset: 0x0009FE70
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return base.SparseArray.GetEnumerator(base.SparseArray);
		}

		// Token: 0x040011D5 RID: 4565
		private bool _inVerifyChildren;

		// Token: 0x040011D6 RID: 4566
		private int _verifiedFieldsVersion = -1;
	}
}
