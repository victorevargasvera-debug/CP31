using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D5 RID: 725
	public class FieldSortDescriptionCollection : global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06002276 RID: 8822 RVA: 0x000967DD File Offset: 0x000949DD
		internal FieldSortDescriptionCollection(global::Infragistics.Windows.DataPresenter.FieldLayout owner, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> list)
		{
			this._owner = owner;
			this._list = list;
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06002277 RID: 8823 RVA: 0x000967F4 File Offset: 0x000949F4
		// (remove) Token: 0x06002278 RID: 8824 RVA: 0x0009682C File Offset: 0x00094A2C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06002279 RID: 8825 RVA: 0x00096864 File Offset: 0x00094A64
		// (remove) Token: 0x0600227A RID: 8826 RVA: 0x0009689C File Offset: 0x00094A9C
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000968D1 File Offset: 0x00094AD1
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000968E0 File Offset: 0x00094AE0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public int CountOfGroupByFields
		{
			get
			{
				if (!this._owner.AreFieldsInitialized)
				{
					int count = this.Count;
					int num = 0;
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[i];
						if (!fieldSortDescription.IsGroupBy)
						{
							break;
						}
						num++;
						if (fieldSortDescription.Field == null)
						{
							this.InitializeFieldStatus(fieldSortDescription);
							if (fieldSortDescription.Field == null)
							{
								return 0;
							}
						}
					}
					return num;
				}
				return this._countOfGroupByFields;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0009694C File Offset: 0x00094B4C
		public global::Infragistics.Windows.DataPresenter.FieldLayout Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00096954 File Offset: 0x00094B54
		internal int GroupbyVersion
		{
			get
			{
				return this._groupbyVersion;
			}
		}

		// Token: 0x17000A36 RID: 2614
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				int num = this.IndexOf(field);
				if (num >= 0)
				{
					return this._list[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_23"));
			}
		}

		// Token: 0x17000A37 RID: 2615
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[string fieldName]
		{
			get
			{
				int num = this.IndexOf(fieldName);
				if (num >= 0)
				{
					return this._list[num];
				}
				if (fieldName != null && fieldName.Trim().Length > 0 && int.TryParse(fieldName, out num) && num >= 0)
				{
					return this._list[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_24"));
			}
		}

		// Token: 0x17000A38 RID: 2616
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[int index]
		{
			get
			{
				this.VerifySortOrder();
				return this._list[index];
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_10"));
			}
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00096A1A File Offset: 0x00094C1A
		public void Add(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.InsertItem(this._list.Count, item);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00096A30 File Offset: 0x00094C30
		public void BeginUpdate()
		{
			if (this._inBeginUpdate)
			{
				return;
			}
			int countOfGroupByFields = this.CountOfGroupByFields;
			if (countOfGroupByFields == 0)
			{
				this._oldGroupByFields = null;
			}
			else
			{
				this._oldGroupByFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription>(countOfGroupByFields);
				for (int i = 0; i < countOfGroupByFields; i++)
				{
					this._oldGroupByFields.Add(this._list[i]);
				}
			}
			this._inBeginUpdate = true;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00096A8F File Offset: 0x00094C8F
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00096A98 File Offset: 0x00094C98
		public void ClearNonGroupByFields()
		{
			if (this.CountOfGroupByFields == this.Count)
			{
				return;
			}
			if (this.CountOfGroupByFields < 1)
			{
				this.Clear();
				return;
			}
			while (this.CountOfGroupByFields < this.Count)
			{
				int index = this.Count - 1;
				this[index].Field.SetSortingStatus(global::Infragistics.Windows.Controls.SortStatus.NotSorted, false);
				this._list.RemoveAt(index);
			}
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.OnCollectionReset();
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00096B16 File Offset: 0x00094D16
		public bool Contains(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			return this._list.Contains(item);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00096B24 File Offset: 0x00094D24
		public bool Contains(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.IndexOf(field) >= 0;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00096B33 File Offset: 0x00094D33
		public bool Contains(string fieldName)
		{
			return this.IndexOf(fieldName) >= 0;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00096B42 File Offset: 0x00094D42
		public void CopyTo(global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array, int arrayIndex)
		{
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00096B54 File Offset: 0x00094D54
		public void EndUpdate()
		{
			this._inBeginUpdate = false;
			bool flag = false;
			int countOfGroupByFields = this.CountOfGroupByFields;
			if (this._oldGroupByFields == null)
			{
				flag = (countOfGroupByFields > 0);
			}
			else if (this._oldGroupByFields.Count != countOfGroupByFields)
			{
				flag = true;
			}
			else
			{
				for (int i = 0; i < countOfGroupByFields; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[i];
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2 = this._oldGroupByFields[i];
					if (fieldSortDescription != fieldSortDescription2)
					{
						flag = true;
						break;
					}
				}
			}
			this._oldGroupByFields = null;
			this.RaisePropertyChangedEvent("Count");
			if (flag)
			{
				this.RaisePropertyChangedEvent("CountOfGroupByFields");
			}
			this.RaisePropertyChangedEvent("Item[]");
			this.OnCollectionReset();
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00096BEE File Offset: 0x00094DEE
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldSortDescription> GetEnumerator()
		{
			this.VerifySortOrder();
			return this._list.GetEnumerator();
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00096C08 File Offset: 0x00094E08
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_3", new object[]
				{
					"field"
				}));
			}
			this.VerifySortOrder();
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this._list[i];
				if (field == fieldSortDescription.Field)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00096C70 File Offset: 0x00094E70
		public int IndexOf(string fieldName)
		{
			if (fieldName == null)
			{
				throw new global::System.ArgumentNullException("fieldName", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_3", new object[]
				{
					"fieldName"
				}));
			}
			this.VerifySortOrder();
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this._list[i];
				if (fieldName == fieldSortDescription.FieldName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00096CDC File Offset: 0x00094EDC
		public int IndexOf(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.VerifySortOrder();
			return this._list.IndexOf(item);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00096CF0 File Offset: 0x00094EF0
		public void Insert(int index, global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.InsertItem(index, item);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00096CFC File Offset: 0x00094EFC
		public bool Remove(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			int num = this._list.IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			this.RemoveItem(num);
			return true;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00096D24 File Offset: 0x00094F24
		public void RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00096D30 File Offset: 0x00094F30
		internal void AddRange(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.FieldSortDescription> items)
		{
			bool flag = false;
			if (!this._inBeginUpdate)
			{
				this.BeginUpdate();
				flag = true;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription item in items)
			{
				this.Add(item);
			}
			if (flag)
			{
				this.EndUpdate();
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00096D94 File Offset: 0x00094F94
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescription[] CloneNonGroupBy()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription>();
			for (int i = 0; i < this.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[i];
				if (!fieldSortDescription.IsGroupBy)
				{
					list.Add(fieldSortDescription.Clone());
				}
			}
			return list.ToArray();
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00096DDC File Offset: 0x00094FDC
		internal void OnOwnerInitialized()
		{
			int countOfGroupByFields = this._countOfGroupByFields;
			this._countOfGroupByFields = 0;
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd in this)
			{
				this.InitializeFieldStatus(fsd);
			}
			if (this._countOfGroupByFields == 0 && countOfGroupByFields != 0)
			{
				this.RaisePropertyChangedEvent("CountOfGroupByFields");
			}
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00096E48 File Offset: 0x00095048
		internal void Sort()
		{
			if (this.Count < 2)
			{
				return;
			}
			int num = 0;
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this)
			{
				fieldSortDescription.PreSortIndex = num++;
			}
			this._list.Sort(new global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection.GroupBySortComparer());
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00096EB0 File Offset: 0x000950B0
		internal int TryGetValue(global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			int i = 0;
			int count = this.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[i];
				if (fieldSortDescription.Field == field)
				{
					fsd = fieldSortDescription;
					return i;
				}
				i++;
			}
			fsd = null;
			return -1;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00096EEC File Offset: 0x000950EC
		private void ClearItems()
		{
			if (this._list.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this)
			{
				if (fieldSortDescription.Field != null)
				{
					fieldSortDescription.Field.SetSortingStatus(global::Infragistics.Windows.Controls.SortStatus.NotSorted, false);
				}
			}
			this._list.Clear();
			if (this._countOfGroupByFields != 0)
			{
				this._groupbyVersion++;
				this._countOfGroupByFields = 0;
				this.RaisePropertyChangedEvent("CountOfGroupByFields");
			}
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.OnCollectionReset();
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00096FA0 File Offset: 0x000951A0
		private void InitializeFieldStatus(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			global::Infragistics.Windows.DataPresenter.Field field = fsd.Field;
			if (field == null)
			{
				int num = this._owner.Fields.IndexOf(fsd.FieldName);
				if (num < 0)
				{
					return;
				}
				field = this._owner.Fields[num];
				fsd.Field = field;
			}
			global::Infragistics.Windows.Controls.SortStatus sortStatus;
			if (fsd.Direction == global::System.ComponentModel.ListSortDirection.Ascending)
			{
				sortStatus = global::Infragistics.Windows.Controls.SortStatus.Ascending;
			}
			else
			{
				sortStatus = global::Infragistics.Windows.Controls.SortStatus.Descending;
			}
			field.SetSortingStatus(sortStatus, fsd.IsGroupBy);
			if (!fsd.IsSealed)
			{
				fsd.Seal();
			}
			if (fsd.IsGroupBy)
			{
				this._countOfGroupByFields++;
				this._groupbyVersion++;
				this.RaisePropertyChangedEvent("CountOfGroupByFields");
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00097044 File Offset: 0x00095244
		private void InsertItem(int index, global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			if (fsd == null)
			{
				throw new global::System.ArgumentNullException("fsd", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_3", new object[]
				{
					"FieldSortDescription"
				}));
			}
			if (fsd.Field != null && fsd.Field.Owner != this._owner)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_25"));
			}
			int num = -1;
			if (fsd.Field != null)
			{
				num = this.IndexOf(fsd.Field);
			}
			else if (fsd.FieldName != null)
			{
				num = this.IndexOf(fsd.FieldName);
			}
			if (num >= 0)
			{
				this.RemoveAt(num);
				if (num < index)
				{
					index--;
				}
			}
			this._list.Insert(index, fsd);
			if (fsd.Field != null)
			{
				fsd.Seal();
			}
			this._collectionDirty = true;
			this.InitializeFieldStatus(fsd);
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.RaiseCollectionChangedEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, fsd, index));
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00097133 File Offset: 0x00095333
		private void OnCollectionReset()
		{
			this.RaiseCollectionChangedEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00097141 File Offset: 0x00095341
		private void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._inBeginUpdate && this.CollectionChanged != null)
			{
				this.CollectionChanged(this, e);
			}
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00097160 File Offset: 0x00095360
		private void RaisePropertyChangedEvent(string propertyName)
		{
			if (!this._inBeginUpdate && this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00097184 File Offset: 0x00095384
		private void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[index];
			bool flag = false;
			if (fieldSortDescription.Field != null)
			{
				fieldSortDescription.Field.SetSortingStatus(global::Infragistics.Windows.Controls.SortStatus.NotSorted, false);
				this._collectionDirty = true;
				if (fieldSortDescription.IsGroupBy)
				{
					if (this._countOfGroupByFields > 0)
					{
						this._countOfGroupByFields--;
					}
					this._groupbyVersion++;
					flag = true;
				}
			}
			this._list.RemoveAt(index);
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			if (flag)
			{
				this.RaisePropertyChangedEvent("CountOfGroupByFields");
			}
			this.RaiseCollectionChangedEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, fieldSortDescription, index));
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00097224 File Offset: 0x00095424
		private void VerifySortOrder()
		{
			if (this._collectionDirty)
			{
				this._collectionDirty = false;
				this.Sort();
			}
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0009723B File Offset: 0x0009543B
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.VerifySortOrder();
			return this._list.GetEnumerator();
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00097253 File Offset: 0x00095453
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.FieldSortDescription>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00097256 File Offset: 0x00095456
		int global::System.Collections.IList.Add(object value)
		{
			this.Add(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
			return this.Count;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0009726A File Offset: 0x0009546A
		void global::System.Collections.IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00097272 File Offset: 0x00095472
		bool global::System.Collections.IList.Contains(object value)
		{
			return this._list.Contains(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00097285 File Offset: 0x00095485
		int global::System.Collections.IList.IndexOf(object value)
		{
			this.VerifySortOrder();
			return this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0009729E File Offset: 0x0009549E
		void global::System.Collections.IList.Insert(int index, object value)
		{
			this.InsertItem(index, value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000972AD File Offset: 0x000954AD
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000972B0 File Offset: 0x000954B0
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000972B3 File Offset: 0x000954B3
		void global::System.Collections.IList.Remove(object value)
		{
			this.RemoveItem(this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription));
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000972CC File Offset: 0x000954CC
		void global::System.Collections.IList.RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x17000A3C RID: 2620
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				this.VerifySortOrder();
				return this[index];
			}
			set
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_10"));
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000972F5 File Offset: 0x000954F5
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.VerifySortOrder();
			this._list.CopyTo(array as global::Infragistics.Windows.DataPresenter.FieldSortDescription[], index);
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0009730F File Offset: 0x0009550F
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x00097312 File Offset: 0x00095512
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					global::System.Threading.Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x040010D7 RID: 4311
		private int _countOfGroupByFields;

		// Token: 0x040010D8 RID: 4312
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _list;

		// Token: 0x040010D9 RID: 4313
		private bool _collectionDirty;

		// Token: 0x040010DA RID: 4314
		private int _groupbyVersion;

		// Token: 0x040010DB RID: 4315
		private object _syncRoot;

		// Token: 0x040010DC RID: 4316
		private bool _inBeginUpdate;

		// Token: 0x040010DD RID: 4317
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _oldGroupByFields;

		// Token: 0x040010DE RID: 4318
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x020002D6 RID: 726
		private class GroupBySortComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FieldSortDescription>
		{
			// Token: 0x060022B0 RID: 8880 RVA: 0x00097334 File Offset: 0x00095534
			int global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FieldSortDescription>.Compare(global::Infragistics.Windows.DataPresenter.FieldSortDescription x, global::Infragistics.Windows.DataPresenter.FieldSortDescription y)
			{
				if (x == y)
				{
					return 0;
				}
				if (x == null)
				{
					return -1;
				}
				if (y == null)
				{
					return -1;
				}
				if (y.IsGroupBy != x.IsGroupBy)
				{
					if (x.IsGroupBy)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					if (x.PreSortIndex < y.PreSortIndex)
					{
						return -1;
					}
					return 1;
				}
			}
		}
	}
}
