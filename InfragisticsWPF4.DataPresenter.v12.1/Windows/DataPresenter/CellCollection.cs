using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000053 RID: 83
	public class CellCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x0000E603 File Offset: 0x0000C803
		internal CellCollection(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (record.FieldLayout == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_2"));
			}
			this._record = record;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000E638 File Offset: 0x0000C838
		public int Count
		{
			get
			{
				this.VerifyVersion();
				if (this._cellArray != null)
				{
					return this._cellArray.Length;
				}
				return this._cachedCount;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000E657 File Offset: 0x0000C857
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._record.DataPresenter;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000E664 File Offset: 0x0000C864
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000E66C File Offset: 0x0000C86C
		public bool Contains(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			int num = this.IndexOf(item);
			return num >= 0;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000E688 File Offset: 0x0000C888
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Cell[] array, int arrayIndex)
		{
			this.EnsureAllCellsAreAllocated();
			if (this._cellArray != null)
			{
				global::System.Array.Copy(this._cellArray, 0, array, arrayIndex, this._cellArray.Length);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			if (item.Record != this._record)
			{
				return -1;
			}
			global::Infragistics.Windows.DataPresenter.Field field = item.Field;
			if (field == null)
			{
				return -1;
			}
			return field.Index;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		public bool IsCellAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field.Owner != this._record.FieldLayout)
			{
				return false;
			}
			int index = field.Index;
			return index >= 0 && this.IsCellAllocated(index);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000E716 File Offset: 0x0000C916
		public bool IsCellAllocated(int index)
		{
			this.VerifyVersion();
			return this._cellArray != null && index >= 0 && index < this._cellArray.Length && this._cellArray[index] != null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000E748 File Offset: 0x0000C948
		internal global::Infragistics.Windows.DataPresenter.Cell AllocateNewCell(int index)
		{
			global::Infragistics.Windows.DataPresenter.Field fld = this._record.FieldLayout.Fields[index];
			this._allocatedRecordCount++;
			return this.CreateCell(fld);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000E784 File Offset: 0x0000C984
		internal void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.CellCollection associatedCollection)
		{
			if (associatedCollection._cellArray != null)
			{
				int num = associatedCollection._cellArray.Length;
				global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
				for (int i = 0; i < num; i++)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = associatedCollection._cellArray[i];
					if (cell != null && cell.HasCloneableSettings)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell2 = (dataPresenterExportControlBase != null) ? this[dataPresenterExportControlBase.GetClonedField(cell.Field)] : this[cell.Field.Name];
						if (cell2 != null)
						{
							cell2.CloneAssociatedCellSettings(cell);
						}
					}
				}
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000E804 File Offset: 0x0000CA04
		internal virtual global::Infragistics.Windows.DataPresenter.Cell CreateCell(global::Infragistics.Windows.DataPresenter.Field fld)
		{
			if (fld.IsUnbound)
			{
				return new global::Infragistics.Windows.DataPresenter.UnboundCell(this._record, fld);
			}
			return new global::Infragistics.Windows.DataPresenter.Cell(this._record, fld);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000E828 File Offset: 0x0000CA28
		internal void DirtyFieldAutoSizeVersion()
		{
			if (this._cellArray != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell in this._cellArray)
				{
					if (cell != null)
					{
						cell.DirtyFieldAutoSizeVersion();
					}
				}
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000E860 File Offset: 0x0000CA60
		internal void EnsureAllCellsAreAllocated()
		{
			int count = this.Count;
			if (count < 1 || count == this._allocatedRecordCount)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				this.GetItem(i);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000E898 File Offset: 0x0000CA98
		internal global::Infragistics.Windows.DataPresenter.Cell GetCellIfAllocated(global::Infragistics.Windows.DataPresenter.Field fld)
		{
			this.VerifyVersion();
			if (this._cellArray != null)
			{
				int index = fld.Index;
				if (index >= 0)
				{
					return this._cellArray[index];
				}
			}
			return null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		internal global::Infragistics.Windows.DataPresenter.Cell GetCellIfAllocated(int index)
		{
			this.VerifyVersion();
			if (this._cellArray == null)
			{
				return null;
			}
			return this._cellArray[index];
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		internal void VerifyVersion()
		{
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._record.FieldLayout.Fields;
			this._cachedCount = fields.Count;
			if (this._cellArray == null || this._fieldCollectionVersion == fields.InternalVersion)
			{
				return;
			}
			this._fieldCollectionVersion = fields.InternalVersion;
			bool flag = false;
			if (this._cachedCount != this._cellArray.Length)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < this._cachedCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = this._cellArray[i];
					if (cell != null && cell.Field != fields[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell[] cellArray = this._cellArray;
			this._cellArray = new global::Infragistics.Windows.DataPresenter.Cell[this._cachedCount];
			this._allocatedRecordCount = 0;
			for (int i = 0; i < cellArray.Length; i++)
			{
				if (cellArray[i] != null)
				{
					int index = cellArray[i].Field.Index;
					if (index >= 0)
					{
						this._allocatedRecordCount++;
						this._cellArray[index] = cellArray[i];
					}
				}
			}
		}

		// Token: 0x17000132 RID: 306
		public global::Infragistics.Windows.DataPresenter.Cell this[int index]
		{
			get
			{
				this.VerifyVersion();
				return this.GetItem(index);
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000EA00 File Offset: 0x0000CC00
		internal global::Infragistics.Windows.DataPresenter.Cell GetItem(int index)
		{
			if (this._cellArray == null)
			{
				this._cellArray = new global::Infragistics.Windows.DataPresenter.Cell[this._cachedCount];
			}
			if (this._cellArray[index] == null)
			{
				this._cellArray[index] = this.AllocateNewCell(index);
			}
			return this._cellArray[index];
		}

		// Token: 0x17000133 RID: 307
		public global::Infragistics.Windows.DataPresenter.Cell this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				int index;
				if (field.Owner == this._record.FieldLayout)
				{
					index = field.Index;
				}
				else
				{
					index = -1;
				}
				return this[index];
			}
		}

		// Token: 0x17000134 RID: 308
		public global::Infragistics.Windows.DataPresenter.Cell this[string name]
		{
			get
			{
				int num = this._record.FieldLayout.Fields.IndexOf(name);
				if (num < 0 && name != null && name.Trim().Length > 0)
				{
					if (int.TryParse(name, out num) && num >= 0)
					{
						return this[num];
					}
					num = -1;
				}
				return this[num];
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000EAFA File Offset: 0x0000CCFA
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.Contains(value as global::Infragistics.Windows.DataPresenter.Cell);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000EB08 File Offset: 0x0000CD08
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOf(value as global::Infragistics.Windows.DataPresenter.Cell);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000EB16 File Offset: 0x0000CD16
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000EB27 File Offset: 0x0000CD27
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000EB2D File Offset: 0x0000CD2D
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000EB3E File Offset: 0x0000CD3E
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000137 RID: 311
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000EB69 File Offset: 0x0000CD69
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.EnsureAllCellsAreAllocated();
			if (this._cellArray != null)
			{
				global::System.Array.Copy(this._cellArray, 0, array, index, this._cellArray.Length);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000EB8F File Offset: 0x0000CD8F
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000EB92 File Offset: 0x0000CD92
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000EB95 File Offset: 0x0000CD95
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.VerifyVersion();
			return new global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator(this);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000EBA3 File Offset: 0x0000CDA3
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>.Insert(int index, global::Infragistics.Windows.DataPresenter.Cell item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x1700013A RID: 314
		global::Infragistics.Windows.DataPresenter.Cell global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000EBDF File Offset: 0x0000CDDF
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000EBE2 File Offset: 0x0000CDE2
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Add(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000EBF3 File Offset: 0x0000CDF3
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000EC04 File Offset: 0x0000CE04
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Remove(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000EC15 File Offset: 0x0000CE15
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>.GetEnumerator()
		{
			this.VerifyVersion();
			return new global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator(this);
		}

		// Token: 0x04000105 RID: 261
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000106 RID: 262
		private global::Infragistics.Windows.DataPresenter.Cell[] _cellArray;

		// Token: 0x04000107 RID: 263
		private int _fieldCollectionVersion;

		// Token: 0x04000108 RID: 264
		private int _cachedCount;

		// Token: 0x04000109 RID: 265
		private int _allocatedRecordCount;

		// Token: 0x02000054 RID: 84
		internal class CellEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600043D RID: 1085 RVA: 0x0000EC23 File Offset: 0x0000CE23
			internal CellEnumerator(global::Infragistics.Windows.DataPresenter.CellCollection collection)
			{
				this._collection = collection;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker;
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0000EC44 File Offset: 0x0000CE44
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0000EC4C File Offset: 0x0000CE4C
			public bool MoveNext()
			{
				int count = this._collection.Count;
				if (this._currentPosition < count - 1)
				{
					this._currentPosition++;
					this._currentItem = this._collection.GetItem(this._currentPosition);
					return true;
				}
				this._currentPosition = count;
				this._currentItem = global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker;
				return false;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x0000ECAA File Offset: 0x0000CEAA
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker;
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000ECBE File Offset: 0x0000CEBE
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
			public global::Infragistics.Windows.DataPresenter.Cell Current
			{
				get
				{
					if (this._currentItem != global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker)
					{
						return this._currentItem as global::Infragistics.Windows.DataPresenter.Cell;
					}
					if (this._currentPosition == -1)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_25"));
					}
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26"));
				}
			}

			// Token: 0x0400010A RID: 266
			private global::Infragistics.Windows.DataPresenter.CellCollection _collection;

			// Token: 0x0400010B RID: 267
			private int _currentPosition;

			// Token: 0x0400010C RID: 268
			private object _currentItem;

			// Token: 0x0400010D RID: 269
			private static object UnsetObjectMarker = new object();
		}
	}
}
