using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000314 RID: 788
	public class FieldSortDescriptionCollection : global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.FieldSortDescription>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x000A9E45 File Offset: 0x000A8045
		internal FieldSortDescriptionCollection(global::Infragistics.Windows.DataPresenter.FieldLayout owner, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> list)
		{
			this._owner = owner;
			this._list = list;
		}

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x0600260F RID: 9743 RVA: 0x000A9E5C File Offset: 0x000A805C
		// (remove) Token: 0x06002610 RID: 9744 RVA: 0x000A9E94 File Offset: 0x000A8094
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06002611 RID: 9745 RVA: 0x000A9ECC File Offset: 0x000A80CC
		// (remove) Token: 0x06002612 RID: 9746 RVA: 0x000A9F04 File Offset: 0x000A8104
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x000A9F39 File Offset: 0x000A8139
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000A9F48 File Offset: 0x000A8148
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

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000A9FB4 File Offset: 0x000A81B4
		public global::Infragistics.Windows.DataPresenter.FieldLayout Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000A9FBC File Offset: 0x000A81BC
		internal int GroupbyVersion
		{
			get
			{
				return this._groupbyVersion;
			}
		}

		// Token: 0x17000B61 RID: 2913
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return this[field, null];
			}
		}

		// Token: 0x17000B62 RID: 2914
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[global::Infragistics.Windows.DataPresenter.Field field, bool? isGroupBy]
		{
			get
			{
				int num = this.IndexOf(field, isGroupBy);
				if (num >= 0)
				{
					return this._list[num];
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_23"));
			}
		}

		// Token: 0x17000B63 RID: 2915
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[string fieldName]
		{
			get
			{
				return this[fieldName, null];
			}
		}

		// Token: 0x17000B64 RID: 2916
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription this[string fieldName, bool? isGroupBy]
		{
			get
			{
				int num = this.IndexOf(fieldName, isGroupBy);
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

		// Token: 0x17000B65 RID: 2917
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

		// Token: 0x0600261D RID: 9757 RVA: 0x000AA0C3 File Offset: 0x000A82C3
		public void Add(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.InsertItem(this._list.Count, item);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000AA0D8 File Offset: 0x000A82D8
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

		// Token: 0x0600261F RID: 9759 RVA: 0x000AA137 File Offset: 0x000A8337
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000AA140 File Offset: 0x000A8340
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
				this[index].Field.SortStatus = global::Infragistics.Windows.Controls.SortStatus.NotSorted;
				this._list.RemoveAt(index);
			}
			this.RaisePropertyChangedEvent("Count");
			this.RaisePropertyChangedEvent("Item[]");
			this.OnCollectionReset();
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000AA1BD File Offset: 0x000A83BD
		public bool Contains(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			return this._list.Contains(item);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000AA1CC File Offset: 0x000A83CC
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public bool Contains(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.IndexOf(field, null) >= 0;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000AA1EF File Offset: 0x000A83EF
		public bool Contains(global::Infragistics.Windows.DataPresenter.Field field, bool? isGroupBy)
		{
			return this.IndexOf(field, isGroupBy) >= 0;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000AA200 File Offset: 0x000A8400
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public bool Contains(string fieldName)
		{
			return this.IndexOf(fieldName, null) >= 0;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000AA223 File Offset: 0x000A8423
		public bool Contains(string fieldName, bool? isGroupBy)
		{
			return this.IndexOf(fieldName, isGroupBy) >= 0;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000AA233 File Offset: 0x000A8433
		public void CopyTo(global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array, int arrayIndex)
		{
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000AA244 File Offset: 0x000A8444
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

		// Token: 0x06002628 RID: 9768 RVA: 0x000AA2DE File Offset: 0x000A84DE
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FieldSortDescription> GetEnumerator()
		{
			this.VerifySortOrder();
			return this._list.GetEnumerator();
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000AA2F8 File Offset: 0x000A84F8
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.IndexOf(field, null);
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000AA318 File Offset: 0x000A8518
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Field field, bool? isGroupBy)
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
				if ((isGroupBy == null || !(isGroupBy != fieldSortDescription.IsGroupBy)) && field == fieldSortDescription.Field)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000AA3B0 File Offset: 0x000A85B0
		[global::System.Obsolete("Use overload that takes the 'isGroupBy' parameter", false)]
		public int IndexOf(string fieldName)
		{
			return this.IndexOf(fieldName, null);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000AA3D0 File Offset: 0x000A85D0
		public int IndexOf(string fieldName, bool? isGroupBy)
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
				if ((isGroupBy == null || !(isGroupBy != fieldSortDescription.IsGroupBy)) && fieldName == fieldSortDescription.FieldName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000AA46A File Offset: 0x000A866A
		public int IndexOf(global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.VerifySortOrder();
			return this._list.IndexOf(item);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000AA47E File Offset: 0x000A867E
		public void Insert(int index, global::Infragistics.Windows.DataPresenter.FieldSortDescription item)
		{
			this.InsertItem(index, item);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000AA488 File Offset: 0x000A8688
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

		// Token: 0x06002630 RID: 9776 RVA: 0x000AA4B0 File Offset: 0x000A86B0
		public void RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000AA4BC File Offset: 0x000A86BC
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

		// Token: 0x06002632 RID: 9778 RVA: 0x000AA520 File Offset: 0x000A8720
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

		// Token: 0x06002633 RID: 9779 RVA: 0x000AA568 File Offset: 0x000A8768
		internal bool IsFieldInCollectionTwice(global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			int num = this.IndexOf(fsd);
			if (num < 0)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Field field = fsd.Field;
			if (field != null)
			{
				return this.Contains(field, new bool?(!fsd.IsGroupBy));
			}
			return this.Contains(fsd.FieldName, new bool?(!fsd.IsGroupBy));
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000AA5C0 File Offset: 0x000A87C0
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

		// Token: 0x06002635 RID: 9781 RVA: 0x000AA62C File Offset: 0x000A882C
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

		// Token: 0x06002636 RID: 9782 RVA: 0x000AA694 File Offset: 0x000A8894
		internal int TryGetValue(global::Infragistics.Windows.DataPresenter.Field field, bool? isGroupBy, out global::Infragistics.Windows.DataPresenter.FieldSortDescription fsd)
		{
			int i = 0;
			int count = this.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[i];
				if ((isGroupBy == null || !(fieldSortDescription.IsGroupBy != isGroupBy)) && fieldSortDescription.Field == field)
				{
					fsd = fieldSortDescription;
					return i;
				}
				i++;
			}
			fsd = null;
			return -1;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000AA6FC File Offset: 0x000A88FC
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
					global::Infragistics.Windows.DataPresenter.Field field = fieldSortDescription.Field;
					if (field != null)
					{
						field.SetIsGroupBy(false);
						field.SortStatus = global::Infragistics.Windows.Controls.SortStatus.NotSorted;
						field.SortStatusGroupBy = global::Infragistics.Windows.Controls.SortStatus.NotSorted;
					}
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

		// Token: 0x06002638 RID: 9784 RVA: 0x000AA7C4 File Offset: 0x000A89C4
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
			if (fsd.IsGroupBy)
			{
				field.SetIsGroupBy(fsd.IsGroupBy);
				field.SortStatusGroupBy = sortStatus;
			}
			else
			{
				field.SortStatus = sortStatus;
			}
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

		// Token: 0x06002639 RID: 9785 RVA: 0x000AA880 File Offset: 0x000A8A80
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
				num = this.IndexOf(fsd.Field, new bool?(fsd.IsGroupBy));
			}
			else if (fsd.FieldName != null)
			{
				num = this.IndexOf(fsd.FieldName, new bool?(fsd.IsGroupBy));
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

		// Token: 0x0600263A RID: 9786 RVA: 0x000AA985 File Offset: 0x000A8B85
		private void OnCollectionReset()
		{
			this.RaiseCollectionChangedEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000AA993 File Offset: 0x000A8B93
		private void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._inBeginUpdate && this.CollectionChanged != null)
			{
				this.CollectionChanged(this, e);
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000AA9B2 File Offset: 0x000A8BB2
		private void RaisePropertyChangedEvent(string propertyName)
		{
			if (!this._inBeginUpdate && this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000AA9D8 File Offset: 0x000A8BD8
		private void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = this[index];
			bool flag = false;
			if (fieldSortDescription.Field != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fieldSortDescription.Field;
				if (field != null)
				{
					if (fieldSortDescription.IsGroupBy)
					{
						field.SetIsGroupBy(false);
						field.SortStatusGroupBy = global::Infragistics.Windows.Controls.SortStatus.NotSorted;
					}
					else
					{
						field.SortStatus = global::Infragistics.Windows.Controls.SortStatus.NotSorted;
					}
				}
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

		// Token: 0x0600263E RID: 9790 RVA: 0x000AAA94 File Offset: 0x000A8C94
		private void VerifySortOrder()
		{
			if (this._collectionDirty)
			{
				this._collectionDirty = false;
				this.Sort();
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000AAAAB File Offset: 0x000A8CAB
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			this.VerifySortOrder();
			return this._list.GetEnumerator();
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x000AAAC3 File Offset: 0x000A8CC3
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.FieldSortDescription>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000AAAC6 File Offset: 0x000A8CC6
		int global::System.Collections.IList.Add(object value)
		{
			this.Add(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
			return this.Count;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000AAADA File Offset: 0x000A8CDA
		void global::System.Collections.IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000AAAE2 File Offset: 0x000A8CE2
		bool global::System.Collections.IList.Contains(object value)
		{
			return this._list.Contains(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000AAAF5 File Offset: 0x000A8CF5
		int global::System.Collections.IList.IndexOf(object value)
		{
			this.VerifySortOrder();
			return this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000AAB0E File Offset: 0x000A8D0E
		void global::System.Collections.IList.Insert(int index, object value)
		{
			this.InsertItem(index, value as global::Infragistics.Windows.DataPresenter.FieldSortDescription);
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000AAB1D File Offset: 0x000A8D1D
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000AAB20 File Offset: 0x000A8D20
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000AAB23 File Offset: 0x000A8D23
		void global::System.Collections.IList.Remove(object value)
		{
			this.RemoveItem(this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.FieldSortDescription));
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000AAB3C File Offset: 0x000A8D3C
		void global::System.Collections.IList.RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x17000B69 RID: 2921
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

		// Token: 0x0600264C RID: 9804 RVA: 0x000AAB65 File Offset: 0x000A8D65
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.VerifySortOrder();
			this._list.CopyTo(array as global::Infragistics.Windows.DataPresenter.FieldSortDescription[], index);
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000AAB7F File Offset: 0x000A8D7F
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x000AAB82 File Offset: 0x000A8D82
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

		// Token: 0x040012F0 RID: 4848
		private int _countOfGroupByFields;

		// Token: 0x040012F1 RID: 4849
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _list;

		// Token: 0x040012F2 RID: 4850
		private bool _collectionDirty;

		// Token: 0x040012F3 RID: 4851
		private int _groupbyVersion;

		// Token: 0x040012F4 RID: 4852
		private object _syncRoot;

		// Token: 0x040012F5 RID: 4853
		private bool _inBeginUpdate;

		// Token: 0x040012F6 RID: 4854
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _oldGroupByFields;

		// Token: 0x040012F7 RID: 4855
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x02000315 RID: 789
		private class GroupBySortComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FieldSortDescription>
		{
			// Token: 0x0600264F RID: 9807 RVA: 0x000AABA4 File Offset: 0x000A8DA4
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
