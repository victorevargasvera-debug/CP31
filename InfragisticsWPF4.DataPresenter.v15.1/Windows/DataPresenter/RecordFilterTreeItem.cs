using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013B RID: 315
	public class RecordFilterTreeItem : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060012C2 RID: 4802 RVA: 0x000522FF File Offset: 0x000504FF
		internal RecordFilterTreeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._itemType = itemType;
			this._dropDownItem = dropDownItem;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00052315 File Offset: 0x00050515
		public string DisplayText
		{
			get
			{
				return this.DisplayTextInternal;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0005231D File Offset: 0x0005051D
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x00052325 File Offset: 0x00050525
		public bool? IsChecked
		{
			get
			{
				return this._isChecked;
			}
			set
			{
				this.InitializeIsChecked(value, true, true);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00052330 File Offset: 0x00050530
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x00052338 File Offset: 0x00050538
		public bool IsExpanded
		{
			get
			{
				return this.IsExpandedInternal;
			}
			set
			{
				this.IsExpandedInternal = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00052341 File Offset: 0x00050541
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> Items
		{
			get
			{
				return this.ItemsInternal;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00052349 File Offset: 0x00050549
		internal virtual string DisplayTextInternal
		{
			get
			{
				return this._dropDownItem.DisplayText;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00052356 File Offset: 0x00050556
		internal global::Infragistics.Windows.DataPresenter.FilterDropDownItem DropDownItem
		{
			get
			{
				return this._dropDownItem;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0005235E File Offset: 0x0005055E
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00052361 File Offset: 0x00050561
		internal virtual bool IsExpandedInternal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00052363 File Offset: 0x00050563
		internal virtual int ItemsCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00052366 File Offset: 0x00050566
		internal virtual global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> ItemsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00052369 File Offset: 0x00050569
		internal virtual global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection ItemsSource
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x0005236C File Offset: 0x0005056C
		internal global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType ItemType
		{
			get
			{
				return this._itemType;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00052374 File Offset: 0x00050574
		internal global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem Parent
		{
			get
			{
				return this._parent;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x0005237C File Offset: 0x0005057C
		internal virtual object Value
		{
			get
			{
				return this._dropDownItem.Value;
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00052389 File Offset: 0x00050589
		internal virtual global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem(this._itemType, this._dropDownItem);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0005239C File Offset: 0x0005059C
		private void InitializeIsChecked(bool? newValue, bool notifyParents, bool notifyChildren)
		{
			if (newValue == this._isChecked)
			{
				return;
			}
			bool? isChecked = this._isChecked;
			this._isChecked = newValue;
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection itemsSource = this.ItemsSource;
			if (notifyChildren && itemsSource != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in itemsSource)
				{
					recordFilterTreeItem.InitializeIsChecked(newValue, false, true);
				}
			}
			if (this._parent != null && notifyParents)
			{
				this._parent.ItemsSource.OnChildIsCheckedChanged(this, isChecked, newValue);
			}
			if (newValue != null && itemsSource != null)
			{
				itemsSource.UpdateCheckedCount();
			}
			this.OnPropertyChanged("IsChecked");
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00052474 File Offset: 0x00050674
		internal bool IsAncestorOf(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item)
		{
			while (item != null)
			{
				if (item == this)
				{
					return true;
				}
				item = item._parent;
			}
			return false;
		}

		// Token: 0x04000792 RID: 1938
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType _itemType;

		// Token: 0x04000793 RID: 1939
		private bool? _isChecked;

		// Token: 0x04000794 RID: 1940
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _parent;

		// Token: 0x04000795 RID: 1941
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x0200013C RID: 316
		internal class RecordFilterTreeItemCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>
		{
			// Token: 0x060012D6 RID: 4822 RVA: 0x0005248A File Offset: 0x0005068A
			internal RecordFilterTreeItemCollection(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent) : base(false, false)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(parent);
				this._parent = parent;
			}

			// Token: 0x060012D7 RID: 4823 RVA: 0x000524A4 File Offset: 0x000506A4
			protected override void ClearItems()
			{
				if (base.Items.Count == 0)
				{
					return;
				}
				base.BeginUpdate();
				try
				{
					base.ClearItems();
				}
				finally
				{
					base.EndUpdate();
				}
			}

			// Token: 0x060012D8 RID: 4824 RVA: 0x000524E4 File Offset: 0x000506E4
			protected override void OnEndUpdate()
			{
				base.OnEndUpdate();
				this.OnItemsChanged();
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000524F2 File Offset: 0x000506F2
			protected override bool NotifyItemsChanged
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060012DA RID: 4826 RVA: 0x000524F5 File Offset: 0x000506F5
			protected override void OnItemAdding(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem itemAdded)
			{
			}

			// Token: 0x060012DB RID: 4827 RVA: 0x000524F8 File Offset: 0x000506F8
			protected override void OnItemAdded(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem itemAdded)
			{
				if (itemAdded._isChecked == true)
				{
					this._countChecked++;
				}
				else if (itemAdded._isChecked == false)
				{
					this._countUnchecked++;
				}
				itemAdded._parent = this._parent;
				if (!base.IsUpdating)
				{
					this.OnItemsChanged();
				}
			}

			// Token: 0x060012DC RID: 4828 RVA: 0x00052578 File Offset: 0x00050778
			protected override void OnItemRemoved(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem itemRemoved)
			{
				if (itemRemoved._isChecked == true)
				{
					this._countChecked--;
				}
				else if (itemRemoved._isChecked == false)
				{
					this._countUnchecked--;
				}
				itemRemoved._parent = null;
				if (!base.IsUpdating)
				{
					this.OnItemsChanged();
				}
			}

			// Token: 0x060012DD RID: 4829 RVA: 0x000525F0 File Offset: 0x000507F0
			private bool? CalculateIsChecked()
			{
				if (this._countUnchecked == base.Count)
				{
					return new bool?(false);
				}
				if (this._countChecked == base.Count)
				{
					return new bool?(true);
				}
				return null;
			}

			// Token: 0x060012DE RID: 4830 RVA: 0x00052630 File Offset: 0x00050830
			private void OnItemsChanged()
			{
				this._parent.InitializeIsChecked(this.CalculateIsChecked(), true, false);
			}

			// Token: 0x060012DF RID: 4831 RVA: 0x00052648 File Offset: 0x00050848
			internal void InsertSorted(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem newItem, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> comparer)
			{
				int num = base.BinarySearch(newItem, comparer);
				if (num < 0)
				{
					num = ~num;
				}
				base.Insert(num, newItem);
			}

			// Token: 0x060012E0 RID: 4832 RVA: 0x00052670 File Offset: 0x00050870
			internal void OnChildIsCheckedChanged(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem child, bool? oldValue, bool? newValue)
			{
				if (oldValue == false)
				{
					this._countUnchecked--;
				}
				else if (oldValue == true)
				{
					this._countChecked--;
				}
				if (newValue == false)
				{
					this._countUnchecked++;
				}
				else if (newValue == true)
				{
					this._countChecked++;
				}
				bool? newValue2 = this.CalculateIsChecked();
				this._parent.InitializeIsChecked(newValue2, true, false);
			}

			// Token: 0x060012E1 RID: 4833 RVA: 0x0005272C File Offset: 0x0005092C
			internal void UpdateCheckedCount()
			{
				bool? isChecked = this._parent._isChecked;
				if (isChecked == true)
				{
					this._countChecked = base.Count;
					this._countUnchecked = 0;
					return;
				}
				if (isChecked == false)
				{
					this._countUnchecked = base.Count;
					this._countChecked = 0;
				}
			}

			// Token: 0x04000796 RID: 1942
			private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _parent;

			// Token: 0x04000797 RID: 1943
			private int _countChecked;

			// Token: 0x04000798 RID: 1944
			private int _countUnchecked;
		}
	}
}
