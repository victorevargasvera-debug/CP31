using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000056 RID: 86
	public class CellCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000FBF9 File Offset: 0x0000DDF9
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000FC18 File Offset: 0x0000DE18
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._record.DataPresenter;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000FC25 File Offset: 0x0000DE25
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000FC30 File Offset: 0x0000DE30
		internal bool HasSelectedCells
		{
			get
			{
				this.VerifyVersion();
				if (this._cellArray != null)
				{
					int num = this._cellArray.Length;
					for (int i = 0; i < num; i++)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell = this._cellArray[i];
						if (cell != null && cell.IsSelected)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000FC78 File Offset: 0x0000DE78
		public bool Contains(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			int num = this.IndexOf(item);
			return num >= 0;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Cell[] array, int arrayIndex)
		{
			this.EnsureAllCellsAreAllocated();
			if (this._cellArray != null)
			{
				global::System.Array.Copy(this._cellArray, 0, array, arrayIndex, this._cellArray.Length);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000FCBC File Offset: 0x0000DEBC
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

		// Token: 0x06000470 RID: 1136 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		public bool IsCellAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field.Owner != this._record.FieldLayout)
			{
				return false;
			}
			int index = field.Index;
			if (index < 0)
			{
				global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField = field as global::Infragistics.Windows.DataPresenter.PlaceholderField;
				if (placeholderField != null)
				{
					this.VerifyPlaceholderCells(false);
					if (this._placeholderCells != null)
					{
						return this._placeholderCells.IsCellAllocated(placeholderField);
					}
				}
				return false;
			}
			return this.IsCellAllocated(index);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000FD48 File Offset: 0x0000DF48
		public bool IsCellAllocated(int index)
		{
			this.VerifyVersion();
			return this._cellArray != null && index >= 0 && index < this._cellArray.Length && this._cellArray[index] != null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000FD78 File Offset: 0x0000DF78
		internal global::Infragistics.Windows.DataPresenter.Cell AllocateNewCell(int index)
		{
			global::Infragistics.Windows.DataPresenter.Field fld = this._record.FieldLayout.Fields[index];
			this._allocatedRecordCount++;
			return this.CreateCell(fld);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
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

		// Token: 0x06000474 RID: 1140 RVA: 0x0000FE34 File Offset: 0x0000E034
		internal virtual global::Infragistics.Windows.DataPresenter.Cell CreateCell(global::Infragistics.Windows.DataPresenter.Field fld)
		{
			if (fld.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding && !fld.IsPlaceholderForTreeView)
			{
				return new global::Infragistics.Windows.DataPresenter.UnboundCell(this._record, fld);
			}
			return new global::Infragistics.Windows.DataPresenter.Cell(this._record, fld);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000FE60 File Offset: 0x0000E060
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

		// Token: 0x06000476 RID: 1142 RVA: 0x0000FE98 File Offset: 0x0000E098
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

		// Token: 0x06000477 RID: 1143 RVA: 0x0000FED0 File Offset: 0x0000E0D0
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

		// Token: 0x06000478 RID: 1144 RVA: 0x0000FF00 File Offset: 0x0000E100
		internal global::Infragistics.Windows.DataPresenter.Cell GetCellIfAllocated(int index)
		{
			this.VerifyVersion();
			if (this._cellArray == null)
			{
				return null;
			}
			return this._cellArray[index];
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000FF1C File Offset: 0x0000E11C
		internal void VerifyVersion()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
			if (this._placeholderCells != null)
			{
				if (fieldLayout.PlaceholderFields == null)
				{
					this._placeholderCells = null;
				}
				else
				{
					this._placeholderCells.Verify(fieldLayout);
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = fieldLayout.Fields;
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

		// Token: 0x0600047A RID: 1146 RVA: 0x00010044 File Offset: 0x0000E244
		private void VerifyPlaceholderCells(bool createPlaceHolderCells)
		{
			if (this._placeholderCells == null && !createPlaceHolderCells)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
			if (fieldLayout.PlaceholderFields == null)
			{
				this._placeholderCells = null;
				return;
			}
			if (this._placeholderCells == null)
			{
				this._placeholderCells = new global::Infragistics.Windows.DataPresenter.CellCollection.PlaceholderFieldCells(this);
			}
			this._placeholderCells.Verify(fieldLayout);
		}

		// Token: 0x1700014D RID: 333
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

		// Token: 0x0600047D RID: 1149 RVA: 0x000100BC File Offset: 0x0000E2BC
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

		// Token: 0x1700014E RID: 334
		public global::Infragistics.Windows.DataPresenter.Cell this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				int num;
				if (field.Owner == this._record.FieldLayout)
				{
					num = field.Index;
					if (num < 0 && field.IsValid)
					{
						this.VerifyPlaceholderCells(true);
						if (this._placeholderCells != null)
						{
							return this._placeholderCells.GetCell(this._record, field as global::Infragistics.Windows.DataPresenter.PlaceholderField);
						}
						return null;
					}
				}
				else
				{
					num = -1;
				}
				return this[num];
			}
		}

		// Token: 0x1700014F RID: 335
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

		// Token: 0x06000480 RID: 1152 RVA: 0x000101C8 File Offset: 0x0000E3C8
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000101D9 File Offset: 0x0000E3D9
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000101EA File Offset: 0x0000E3EA
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.Contains(value as global::Infragistics.Windows.DataPresenter.Cell);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000101F8 File Offset: 0x0000E3F8
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOf(value as global::Infragistics.Windows.DataPresenter.Cell);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00010206 File Offset: 0x0000E406
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00010217 File Offset: 0x0000E417
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001021A File Offset: 0x0000E41A
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001021D File Offset: 0x0000E41D
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001022E File Offset: 0x0000E42E
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000152 RID: 338
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

		// Token: 0x0600048B RID: 1163 RVA: 0x00010259 File Offset: 0x0000E459
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.EnsureAllCellsAreAllocated();
			if (this._cellArray != null)
			{
				global::System.Array.Copy(this._cellArray, 0, array, index, this._cellArray.Length);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0001027F File Offset: 0x0000E47F
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00010282 File Offset: 0x0000E482
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00010285 File Offset: 0x0000E485
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.VerifyVersion();
			return new global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator(this);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00010293 File Offset: 0x0000E493
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>.Insert(int index, global::Infragistics.Windows.DataPresenter.Cell item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000102A4 File Offset: 0x0000E4A4
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Cell>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x17000155 RID: 341
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000102CF File Offset: 0x0000E4CF
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000102D2 File Offset: 0x0000E4D2
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Add(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000102E3 File Offset: 0x0000E4E3
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000102F4 File Offset: 0x0000E4F4
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Cell>.Remove(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00010305 File Offset: 0x0000E505
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>.GetEnumerator()
		{
			this.VerifyVersion();
			return new global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator(this);
		}

		// Token: 0x0400012C RID: 300
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x0400012D RID: 301
		private global::Infragistics.Windows.DataPresenter.Cell[] _cellArray;

		// Token: 0x0400012E RID: 302
		private int _fieldCollectionVersion;

		// Token: 0x0400012F RID: 303
		private int _cachedCount;

		// Token: 0x04000130 RID: 304
		private int _allocatedRecordCount;

		// Token: 0x04000131 RID: 305
		private global::Infragistics.Windows.DataPresenter.CellCollection.PlaceholderFieldCells _placeholderCells;

		// Token: 0x02000057 RID: 87
		internal class CellEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000498 RID: 1176 RVA: 0x00010313 File Offset: 0x0000E513
			internal CellEnumerator(global::Infragistics.Windows.DataPresenter.CellCollection collection)
			{
				this._collection = collection;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker;
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00010334 File Offset: 0x0000E534
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x0001033C File Offset: 0x0000E53C
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

			// Token: 0x0600049B RID: 1179 RVA: 0x0001039A File Offset: 0x0000E59A
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.DataPresenter.CellCollection.CellEnumerator.UnsetObjectMarker;
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x000103AE File Offset: 0x0000E5AE
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x000103B8 File Offset: 0x0000E5B8
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

			// Token: 0x04000132 RID: 306
			private global::Infragistics.Windows.DataPresenter.CellCollection _collection;

			// Token: 0x04000133 RID: 307
			private int _currentPosition;

			// Token: 0x04000134 RID: 308
			private object _currentItem;

			// Token: 0x04000135 RID: 309
			private static object UnsetObjectMarker = new object();
		}

		// Token: 0x02000058 RID: 88
		private class PlaceholderFieldCells
		{
			// Token: 0x0600049F RID: 1183 RVA: 0x00010412 File Offset: 0x0000E612
			internal PlaceholderFieldCells(global::Infragistics.Windows.DataPresenter.CellCollection owner)
			{
				this._owner = owner;
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x00010424 File Offset: 0x0000E624
			internal global::Infragistics.Windows.DataPresenter.Cell GetCell(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.PlaceholderField field)
			{
				int placeholderIndex = field.PlaceholderIndex;
				if (placeholderIndex < 0 || this._cells == null || this._cells.Length <= placeholderIndex)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Cell cell = this._cells[placeholderIndex];
				if (cell == null)
				{
					cell = this._owner.CreateCell(field);
					this._cells[placeholderIndex] = cell;
				}
				return cell;
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x00010474 File Offset: 0x0000E674
			public bool IsCellAllocated(global::Infragistics.Windows.DataPresenter.PlaceholderField field)
			{
				int placeholderIndex = field.PlaceholderIndex;
				return placeholderIndex >= 0 && this._cells != null && this._cells.Length > placeholderIndex && this._cells[placeholderIndex] != null;
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x000104B0 File Offset: 0x0000E6B0
			internal void Verify(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
			{
				if (this._cells != null && this._version == fieldLayout.PlaceholderFieldsVersion)
				{
					return;
				}
				this._version = fieldLayout.PlaceholderFieldsVersion;
				global::Infragistics.Windows.DataPresenter.Cell[] cells = this._cells;
				this._cells = new global::Infragistics.Windows.DataPresenter.Cell[fieldLayout.PlaceholderFields.Length];
				if (cells != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Cell cell in cells)
					{
						global::Infragistics.Windows.DataPresenter.PlaceholderField placeholderField = (cell != null) ? (cell.Field as global::Infragistics.Windows.DataPresenter.PlaceholderField) : null;
						int num = (placeholderField != null) ? placeholderField.PlaceholderIndex : -1;
						if (num >= this._cells.Length)
						{
							return;
						}
						if (num >= 0 && placeholderField == fieldLayout.PlaceholderFields[num])
						{
							this._cells[num] = cell;
						}
					}
				}
			}

			// Token: 0x04000136 RID: 310
			private int _version;

			// Token: 0x04000137 RID: 311
			private global::Infragistics.Windows.DataPresenter.Cell[] _cells;

			// Token: 0x04000138 RID: 312
			private global::Infragistics.Windows.DataPresenter.CellCollection _owner;
		}
	}
}
