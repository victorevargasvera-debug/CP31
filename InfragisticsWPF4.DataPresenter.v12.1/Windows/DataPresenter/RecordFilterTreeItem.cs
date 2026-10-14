using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011F RID: 287
	public class RecordFilterTreeItem : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x000416E3 File Offset: 0x0003F8E3
		internal RecordFilterTreeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._itemType = itemType;
			this._dropDownItem = dropDownItem;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000416F9 File Offset: 0x0003F8F9
		public string DisplayText
		{
			get
			{
				return this.DisplayTextInternal;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00041701 File Offset: 0x0003F901
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00041709 File Offset: 0x0003F909
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00041714 File Offset: 0x0003F914
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0004171C File Offset: 0x0003F91C
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00041725 File Offset: 0x0003F925
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> Items
		{
			get
			{
				return this.ItemsInternal;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0004172D File Offset: 0x0003F92D
		internal virtual string DisplayTextInternal
		{
			get
			{
				return this._dropDownItem.DisplayText;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004173A File Offset: 0x0003F93A
		internal global::Infragistics.Windows.DataPresenter.FilterDropDownItem DropDownItem
		{
			get
			{
				return this._dropDownItem;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00041742 File Offset: 0x0003F942
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00041745 File Offset: 0x0003F945
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00041747 File Offset: 0x0003F947
		internal virtual int ItemsCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004174A File Offset: 0x0003F94A
		internal virtual global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> ItemsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x0004174D File Offset: 0x0003F94D
		internal virtual global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection ItemsSource
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00041750 File Offset: 0x0003F950
		internal global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType ItemType
		{
			get
			{
				return this._itemType;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00041758 File Offset: 0x0003F958
		internal global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem Parent
		{
			get
			{
				return this._parent;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00041760 File Offset: 0x0003F960
		internal virtual object Value
		{
			get
			{
				return this._dropDownItem.Value;
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004176D File Offset: 0x0003F96D
		internal virtual global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem(this._itemType, this._dropDownItem);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00041780 File Offset: 0x0003F980
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

		// Token: 0x06000F6F RID: 3951 RVA: 0x00041858 File Offset: 0x0003FA58
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

		// Token: 0x040005F0 RID: 1520
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType _itemType;

		// Token: 0x040005F1 RID: 1521
		private bool? _isChecked;

		// Token: 0x040005F2 RID: 1522
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _parent;

		// Token: 0x040005F3 RID: 1523
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x02000120 RID: 288
		internal class RecordFilterTreeItemCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>
		{
			// Token: 0x06000F70 RID: 3952 RVA: 0x0004186E File Offset: 0x0003FA6E
			internal RecordFilterTreeItemCollection(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent) : base(false, false)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(parent);
				this._parent = parent;
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x00041888 File Offset: 0x0003FA88
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

			// Token: 0x06000F72 RID: 3954 RVA: 0x000418C8 File Offset: 0x0003FAC8
			protected override void OnEndUpdate()
			{
				base.OnEndUpdate();
				this.OnItemsChanged();
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000418D6 File Offset: 0x0003FAD6
			protected override bool NotifyItemsChanged
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x000418D9 File Offset: 0x0003FAD9
			protected override void OnItemAdding(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem itemAdded)
			{
			}

			// Token: 0x06000F75 RID: 3957 RVA: 0x000418DC File Offset: 0x0003FADC
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

			// Token: 0x06000F76 RID: 3958 RVA: 0x0004195C File Offset: 0x0003FB5C
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

			// Token: 0x06000F77 RID: 3959 RVA: 0x000419D4 File Offset: 0x0003FBD4
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

			// Token: 0x06000F78 RID: 3960 RVA: 0x00041A14 File Offset: 0x0003FC14
			private void OnItemsChanged()
			{
				this._parent.InitializeIsChecked(this.CalculateIsChecked(), true, false);
			}

			// Token: 0x06000F79 RID: 3961 RVA: 0x00041A2C File Offset: 0x0003FC2C
			internal void InsertSorted(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem newItem, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> comparer)
			{
				int num = base.BinarySearch(newItem, comparer);
				if (num < 0)
				{
					num = ~num;
				}
				base.Insert(num, newItem);
			}

			// Token: 0x06000F7A RID: 3962 RVA: 0x00041A54 File Offset: 0x0003FC54
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

			// Token: 0x06000F7B RID: 3963 RVA: 0x00041B10 File Offset: 0x0003FD10
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

			// Token: 0x040005F4 RID: 1524
			private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _parent;

			// Token: 0x040005F5 RID: 1525
			private int _countChecked;

			// Token: 0x040005F6 RID: 1526
			private int _countUnchecked;
		}
	}
}
