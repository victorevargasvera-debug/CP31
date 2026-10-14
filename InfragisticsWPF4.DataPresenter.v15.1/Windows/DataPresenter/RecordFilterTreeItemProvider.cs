using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013F RID: 319
	internal class RecordFilterTreeItemProvider : global::Infragistics.PropertyChangeNotifier, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060012ED RID: 4845 RVA: 0x000528A8 File Offset: 0x00050AA8
		internal RecordFilterTreeItemProvider(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl owner, bool? includeBlanks)
		{
			this._culture = global::System.Globalization.CultureInfo.CurrentCulture;
			this._includeBlanks = includeBlanks;
			this._selectAllItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.SelectAll, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeItem_SelectAll"), null, null);
			this._valuesItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Values, "Values", null, null);
			this._datesItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Dates, "Dates", null, null);
			this._suffixItems = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
			this._blanksOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.Blanks;
			this._owner = owner;
			this.Initialize();
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00052936 File Offset: 0x00050B36
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> AllItems
		{
			get
			{
				if (this._allItems == null)
				{
					this._allItems = new global::Infragistics.Collections.AggregateCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
					this.InitializeAllItems();
				}
				return this._allItems;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00052957 File Offset: 0x00050B57
		public bool HasSearchText
		{
			get
			{
				return !string.IsNullOrEmpty(this._searchText);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00052967 File Offset: 0x00050B67
		public bool IsEmptySearch
		{
			get
			{
				return this.HasSearchText && (this._selectAllSearchItem == null || this._selectAllSearchItem.ItemsSource.Count == 0);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00052990 File Offset: 0x00050B90
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00052998 File Offset: 0x00050B98
		public bool IsGroupingDates
		{
			get
			{
				return this._isGroupingDates;
			}
			set
			{
				if (value != this._isGroupingDates)
				{
					this._isGroupingDates = value;
					this.Clear();
					this.OnPropertyChanged("IsGroupingDates");
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000529BB File Offset: 0x00050BBB
		public global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? MostSpecificCreatedDateType
		{
			get
			{
				return this._mostSpecificCreatedDateType;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000529C3 File Offset: 0x00050BC3
		public global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope SearchScope
		{
			get
			{
				return this._searchScope;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000529CB File Offset: 0x00050BCB
		public string SearchText
		{
			get
			{
				return this._searchText;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x000529D4 File Offset: 0x00050BD4
		internal bool CanUpdateRecordFilter
		{
			get
			{
				if (!this.HasSearchText)
				{
					return this._selectAllItem.IsChecked != false;
				}
				return !this.IsEmptySearch && (this._selectAllSearchItem.IsChecked != false || this._addToFilterItem.IsChecked != false);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00052A5C File Offset: 0x00050C5C
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00052A64 File Offset: 0x00050C64
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo FilterInfo
		{
			get
			{
				return this._filterInfo;
			}
			set
			{
				if (value != this._filterInfo)
				{
					if (this._filterInfo != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._filterInfo, this, string.Empty);
					}
					this._filterInfo = value;
					if (this._filterInfo != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._filterInfo, this, string.Empty);
					}
					this.OnFilterInfoChanged();
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00052AB9 File Offset: 0x00050CB9
		internal bool IsUpdatingFilter
		{
			get
			{
				return this._isUpdatingFilter;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00052AC1 File Offset: 0x00050CC1
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00052AC9 File Offset: 0x00050CC9
		private global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return this._culture;
			}
			set
			{
				if (value != this._culture)
				{
					this._culture = value;
					this._hourFormat = null;
				}
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00052AE4 File Offset: 0x00050CE4
		public void SetSearchCriteria(string searchText, global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope, bool force)
		{
			bool flag = this._searchText != searchText;
			bool flag2 = this._searchScope != scope;
			if (!force && !flag && !flag2)
			{
				return;
			}
			bool hasSearchText = this.HasSearchText;
			bool isEmptySearch = this.IsEmptySearch;
			this._searchText = searchText;
			this._searchScope = scope;
			if (flag || this.HasSearchText)
			{
				this.OnSearchTextChanged();
			}
			if (flag)
			{
				this.OnPropertyChanged("SearchText");
			}
			if (flag2)
			{
				this.OnPropertyChanged("SearchScope");
			}
			if (hasSearchText != this.HasSearchText)
			{
				this.OnPropertyChanged("HasSearchText");
			}
			if (isEmptySearch != this.IsEmptySearch)
			{
				this.OnPropertyChanged("IsEmptySearch");
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00052B86 File Offset: 0x00050D86
		internal void AddBlanks()
		{
			if (this._includeBlanks == null && this._addedBlanks == null)
			{
				this.AddBlanksItem();
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00052BA8 File Offset: 0x00050DA8
		internal void AddRange(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> items, bool clearValues)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? mostSpecificCreatedDateType = this._mostSpecificCreatedDateType;
			this._valuesItem.ItemsSource.BeginUpdate();
			this._datesItem.ItemsSource.BeginUpdate();
			try
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> dictionary = null;
				if (clearValues && this._valuesItem.ItemsCount > 0)
				{
					dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterDropDownItem, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
					foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in this._valuesItem.ItemsSource)
					{
						dictionary[recordFilterTreeItem.DropDownItem] = recordFilterTreeItem;
					}
					this._valuesItem.ItemsSource.Clear();
				}
				if (items != null)
				{
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> enumerator2 = items.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterDropDownItem = enumerator2.Current;
							global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2;
							if (dictionary == null || !dictionary.TryGetValue(filterDropDownItem, out recordFilterTreeItem2))
							{
								this.AddItem(filterDropDownItem);
							}
							else
							{
								recordFilterTreeItem2.IsChecked = new bool?(this.IsOriginallyChecked(filterDropDownItem));
								this._valuesItem.ItemsSource.Add(recordFilterTreeItem2);
							}
						}
						goto IL_107;
					}
				}
				if (clearValues)
				{
					this._mostSpecificCreatedDateType = null;
				}
				IL_107:;
			}
			finally
			{
				this._valuesItem.ItemsSource.EndUpdate();
				this._datesItem.ItemsSource.EndUpdate();
			}
			if (mostSpecificCreatedDateType != this._mostSpecificCreatedDateType)
			{
				if (this._mostSpecificCreatedDateType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second)
				{
					this.EnsureDayNodesHaveSeconds();
				}
				this.OnPropertyChanged("MostSpecificCreatedDateType");
			}
			if (this.HasSearchText)
			{
				this.SetSearchCriteria(this._searchText, this._searchScope, true);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00052D88 File Offset: 0x00050F88
		internal void Clear()
		{
			bool flag = this._mostSpecificCreatedDateType != null;
			bool isEmptySearch = this.IsEmptySearch;
			this._selectAllItem.ItemsSource.Clear();
			this._datesItem.ItemsSource.Clear();
			this._valuesItem.ItemsSource.Clear();
			this._suffixItems.Clear();
			this._addedBlanks = null;
			this._mostSpecificCreatedDateType = null;
			this.Initialize();
			if (isEmptySearch != this.IsEmptySearch)
			{
				this.OnPropertyChanged("IsEmptySearch");
			}
			if (flag)
			{
				this.OnPropertyChanged("MostSpecificCreatedDateType");
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00052E24 File Offset: 0x00051024
		internal void ResetIsExpanded()
		{
			if (this.HasSearchText)
			{
				return;
			}
			if (this._datesItem == null || this._datesItem.ItemsCount == 0)
			{
				return;
			}
			int itemsCount = this._datesItem.ItemsCount;
			bool flag = itemsCount == 1;
			for (int i = 0; i < itemsCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = this._datesItem.Items[i];
				recordFilterTreeItem.IsExpanded = flag;
				int itemsCount2 = recordFilterTreeItem.ItemsCount;
				bool isExpanded = flag && itemsCount2 == 1;
				for (int j = 0; j < itemsCount2; j++)
				{
					recordFilterTreeItem.Items[j].IsExpanded = isExpanded;
				}
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00052EC0 File Offset: 0x000510C0
		internal void ResetIsChecked()
		{
			this.InitializeIsChecked();
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00052EC8 File Offset: 0x000510C8
		internal void UpdateRecordFilter()
		{
			global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = this._recordFilter;
			if (recordFilter == null)
			{
				return;
			}
			if (this.HasSearchText && this.CanUpdateRecordFilter)
			{
				if (this._addToFilterItem != null && this._addToFilterItem.IsChecked == false)
				{
					this._selectAllItem.IsChecked = new bool?(false);
				}
				else
				{
					this.InitializeIsChecked();
				}
				this.UpdateRootNodeFromSearchNodes();
			}
			if (!this.CanUpdateRecordFilter)
			{
				return;
			}
			global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
			this.UpdateRecordFilter(conditionGroup);
			if (conditionGroup.Count == 1 && conditionGroup[0] is global::Infragistics.Windows.Controls.ComparisonCondition)
			{
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = conditionGroup[0] as global::Infragistics.Windows.Controls.ComparisonCondition;
				recordFilter.CurrentUIOperator = comparisonCondition.Operator;
				recordFilter.CurrentUIOperand = comparisonCondition.Value;
			}
			else
			{
				recordFilter.CurrentUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
				recordFilter.CurrentUIOperand = conditionGroup;
			}
			bool isUpdatingFilter = this._isUpdatingFilter;
			this._isUpdatingFilter = true;
			try
			{
				recordFilter.ApplyPendingFilter(true, true);
			}
			finally
			{
				this._isUpdatingFilter = isUpdatingFilter;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00052FCC File Offset: 0x000511CC
		private void AddBlanksItem()
		{
			this._addedBlanks = new bool?(true);
			if (this._blanksItem == null)
			{
				string displayText = (this._blanksOperand == null) ? "(Blanks)" : this._blanksOperand.ToString();
				this._blanksItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Blanks, displayText, null, null)
				{
					IsChecked = new bool?(this.IsOriginallyChecked(null))
				};
			}
			this._selectAllItem.ItemsSource.Add(this._blanksItem);
			this._suffixItems.Add(this._blanksItem);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00053054 File Offset: 0x00051254
		private void AddDate(global::System.DateTime date, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent, global::Infragistics.Windows.DataPresenter.FilterDropDownItem filterItem)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType recordFilterTreeItemType = parent.ItemType;
			recordFilterTreeItemType++;
			int num;
			switch (recordFilterTreeItemType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Year:
				num = date.Year;
				break;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Month:
				num = date.Month;
				break;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day:
				num = date.Day;
				break;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Hour:
				num = date.Hour;
				break;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Minute:
				num = date.Minute;
				break;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second:
				num = date.Second;
				break;
			default:
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = null;
			int num2 = this.BinarySearchDateItem(parent, num);
			if (num2 >= 0)
			{
				recordFilterTreeItem = parent.ItemsSource[num2];
			}
			else
			{
				num2 = ~num2;
			}
			bool flag = recordFilterTreeItem == null;
			if (flag)
			{
				string dateValueFormat = this.GetDateValueFormat(recordFilterTreeItemType);
				bool flag2 = recordFilterTreeItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second || (recordFilterTreeItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day && date.TimeOfDay.Ticks == 0L && this._mostSpecificCreatedDateType != global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second);
				if (flag2)
				{
					recordFilterTreeItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx(recordFilterTreeItemType, date.ToString(dateValueFormat, this._culture), num, filterItem);
				}
				else
				{
					recordFilterTreeItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(recordFilterTreeItemType, date.ToString(dateValueFormat, this._culture), num, filterItem);
				}
				if (this._mostSpecificCreatedDateType == null || recordFilterTreeItemType > this._mostSpecificCreatedDateType)
				{
					this._mostSpecificCreatedDateType = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(recordFilterTreeItemType);
				}
			}
			try
			{
				if (recordFilterTreeItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day)
				{
					if (recordFilterTreeItem.ItemsSource == null)
					{
						if (date.TimeOfDay.Ticks == 0L && this._mostSpecificCreatedDateType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day)
						{
							if (flag)
							{
								recordFilterTreeItem.IsChecked = new bool?(this.IsOriginallyChecked(filterItem));
							}
							return;
						}
						if (!flag)
						{
							recordFilterTreeItem = this.ConvertLeafDayToSecond(date, parent, recordFilterTreeItem, num2);
						}
					}
				}
				else if (recordFilterTreeItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second)
				{
					if (flag)
					{
						recordFilterTreeItem.IsChecked = new bool?(this.IsOriginallyChecked(filterItem));
					}
					return;
				}
				this.AddDate(date, recordFilterTreeItem, filterItem);
			}
			finally
			{
				if (flag)
				{
					if (num2 < 0)
					{
						num2 = parent.ItemsSource.Count;
					}
					parent.ItemsSource.Insert(num2, recordFilterTreeItem);
				}
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0005328C File Offset: 0x0005148C
		private void AddItem(global::Infragistics.Windows.DataPresenter.FilterDropDownItem item)
		{
			object value = item.Value;
			if (this._includeBlanks == null && this._blanksOperand.IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, value, null))
			{
				if (this._addedBlanks == null)
				{
					this.AddBlanksItem();
				}
				return;
			}
			if (!(value is global::System.DateTime) || !this._isGroupingDates)
			{
				if (this._valuesItem.Parent == null)
				{
					this._selectAllItem.ItemsSource.InsertSorted(this._valuesItem, global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>(new global::System.Comparison<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.CompareByItems)));
				}
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Value, item);
				recordFilterTreeItem.IsChecked = new bool?(this.IsOriginallyChecked(item));
				this._valuesItem.ItemsSource.Add(recordFilterTreeItem);
				return;
			}
			if (this._datesItem.Parent == null)
			{
				this._selectAllItem.ItemsSource.InsertSorted(this._datesItem, global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>(new global::System.Comparison<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.CompareByItems)));
			}
			global::System.DateTime date = (global::System.DateTime)value;
			this.AddDate(date, this._datesItem, item);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0005338B File Offset: 0x0005158B
		private int BinarySearchDateItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent, int nextValue)
		{
			if (parent.ItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Dates)
			{
				return this.BinarySearchDateItem(parent.ItemsSource, nextValue, new global::System.Comparison<int>(this.CompareDescendingDates));
			}
			return this.BinarySearchDateItem(parent.ItemsSource, nextValue, new global::System.Comparison<int>(this.CompareAscendingDates));
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000533CC File Offset: 0x000515CC
		private int BinarySearchDateItem(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> items, int value, global::System.Comparison<int> comparer)
		{
			int i = 0;
			int num = items.Count - 1;
			while (i <= num)
			{
				int num2 = (i + num) / 2;
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = items[num2];
				int x = (int)recordFilterTreeItem.Value;
				int num3 = comparer(x, value);
				if (num3 > 0)
				{
					num = num2 - 1;
				}
				else
				{
					if (num3 >= 0)
					{
						return num2;
					}
					i = num2 + 1;
				}
			}
			return ~i;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0005342C File Offset: 0x0005162C
		internal void CloneMatchingDateItem(global::System.Predicate<string> isMatchCallback, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? typeToMatch, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> list)
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in this._datesItem.ItemsSource)
			{
				bool flag;
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 = this.CloneMatchingDateItem(recordFilterTreeItem, isMatchCallback, typeToMatch, false, out flag);
				if (recordFilterTreeItem2 != null)
				{
					recordFilterTreeItem2.IsChecked = new bool?(true);
					list.Add(recordFilterTreeItem2);
					this._searchToRootTable[recordFilterTreeItem2] = recordFilterTreeItem;
				}
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000534A8 File Offset: 0x000516A8
		internal global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CloneMatchingDateItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item, global::System.Predicate<string> isMatchCallback, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? typeToMatch, bool forceClone, out bool isMatch)
		{
			global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = null;
			isMatch = false;
			if (typeToMatch == null || typeToMatch.Value == item.ItemType)
			{
				isMatch = isMatchCallback(item.DisplayTextInternal);
				if (typeToMatch != null && !isMatch)
				{
					return null;
				}
				if (isMatch)
				{
					forceClone = true;
				}
			}
			if (forceClone)
			{
				recordFilterTreeItem = item.CreateNew();
			}
			if (item.Items != null)
			{
				bool flag = false;
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 in item.ItemsSource)
				{
					bool flag2 = false;
					global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem3 = this.CloneMatchingDateItem(recordFilterTreeItem2, isMatchCallback, typeToMatch, isMatch || forceClone, out flag2);
					if (recordFilterTreeItem3 != null)
					{
						if (recordFilterTreeItem == null)
						{
							recordFilterTreeItem = item.CreateNew();
						}
						if (flag2)
						{
							flag = true;
							recordFilterTreeItem.IsExpandedInternal = true;
						}
						this._searchToRootTable[recordFilterTreeItem3] = recordFilterTreeItem2;
						recordFilterTreeItem.ItemsSource.Add(recordFilterTreeItem3);
					}
				}
				if (flag)
				{
					isMatch = true;
				}
			}
			return recordFilterTreeItem;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000535A8 File Offset: 0x000517A8
		private int CompareDescendingDates(int itemYear, int newYearValue)
		{
			return newYearValue.CompareTo(itemYear);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000535B2 File Offset: 0x000517B2
		private int CompareAscendingDates(int itemYear, int newYearValue)
		{
			return itemYear.CompareTo(newYearValue);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000535BC File Offset: 0x000517BC
		private static int CompareByItems(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem x, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem y)
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
				return 1;
			}
			return x.ItemType.CompareTo(y.ItemType);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000535E9 File Offset: 0x000517E9
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem ConvertLeafDayToSecond(global::System.DateTime date, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem childItem, int childIndex)
		{
			childItem = (parent.ItemsSource[childIndex] = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day, childItem.DisplayText, childItem.Value, childItem.DropDownItem));
			this.AddDate(date.Date, childItem, childItem.DropDownItem);
			return childItem;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00053628 File Offset: 0x00051828
		private void EnsureDayNodesHaveSeconds()
		{
			int i = 0;
			int itemsCount = this._datesItem.ItemsCount;
			while (i < itemsCount)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem = this._datesItem.ItemsSource[i];
				int j = 0;
				int itemsCount2 = recordFilterTreeItem.ItemsCount;
				while (j < itemsCount2)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 = recordFilterTreeItem.ItemsSource[j];
					int k = 0;
					int itemsCount3 = recordFilterTreeItem2.ItemsCount;
					while (k < itemsCount3)
					{
						global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem3 = recordFilterTreeItem2.ItemsSource[k];
						if (recordFilterTreeItem3.ItemsSource == null)
						{
							global::System.DateTime date = (global::System.DateTime)recordFilterTreeItem3.DropDownItem.Value;
							this.ConvertLeafDayToSecond(date, recordFilterTreeItem2, recordFilterTreeItem3, k);
						}
						k++;
					}
					j++;
				}
				i++;
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000536E0 File Offset: 0x000518E0
		private static global::Infragistics.Windows.Controls.DateRangeScope GetDateRangeScope(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType)
		{
			switch (itemType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Year:
				return global::Infragistics.Windows.Controls.DateRangeScope.Year;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Month:
				return global::Infragistics.Windows.Controls.DateRangeScope.Month;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day:
				return global::Infragistics.Windows.Controls.DateRangeScope.Day;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Hour:
				return global::Infragistics.Windows.Controls.DateRangeScope.Hour;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Minute:
				return global::Infragistics.Windows.Controls.DateRangeScope.Minute;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second:
				return global::Infragistics.Windows.Controls.DateRangeScope.Second;
			default:
				return global::Infragistics.Windows.Controls.DateRangeScope.Year;
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00053720 File Offset: 0x00051920
		private static global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? GetDateScope(global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope scope)
		{
			switch (scope)
			{
			default:
				return null;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Year:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Year);
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Month:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Month);
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Day:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day);
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Hour:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Hour);
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Minute:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Minute);
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Second:
				return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType?(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00053788 File Offset: 0x00051988
		private string GetDateValueFormat(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType childType)
		{
			switch (childType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Year:
				return "yyyy";
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Month:
				return "MMMM";
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day:
				return "dd";
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Hour:
				if (this._hourFormat == null)
				{
					if (this._culture.DateTimeFormat.LongTimePattern.Contains("H"))
					{
						this._hourFormat = "HH";
					}
					else
					{
						this._hourFormat = "hh tt";
					}
				}
				return this._hourFormat;
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Minute:
				return ":mm";
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second:
				return ":ss";
			default:
				return "G";
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00053820 File Offset: 0x00051A20
		private void Initialize()
		{
			this._selectAllItem.IsChecked = new bool?(false);
			if (this._blanksOperand == null)
			{
				this._addedBlanks = new bool?(false);
				return;
			}
			if (this._includeBlanks == true)
			{
				this.AddBlanksItem();
				return;
			}
			this._addedBlanks = this._includeBlanks;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00053884 File Offset: 0x00051A84
		private void InitializeAllItems()
		{
			if (this._allItems == null)
			{
				return;
			}
			this._allItems.Collections = new global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>[]
			{
				new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem[]
				{
					this._selectAllItem
				},
				this._datesItem.ItemsSource,
				this._valuesItem.ItemsSource,
				this._suffixItems
			};
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000538E8 File Offset: 0x00051AE8
		private void InitializeIsChecked()
		{
			if (this._recordFilter == null || this._recordFilter.Conditions.Count == 0)
			{
				this._selectAllItem.IsChecked = new bool?(true);
				return;
			}
			if (this._blanksItem != null)
			{
				this._blanksItem.IsChecked = new bool?(this.IsOriginallyChecked(null));
			}
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in this._valuesItem.ItemsSource)
			{
				recordFilterTreeItem.IsChecked = new bool?(this.IsOriginallyChecked(recordFilterTreeItem.DropDownItem));
			}
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item in this._datesItem.ItemsSource)
			{
				this.InitializeIsChecked(item);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000539D8 File Offset: 0x00051BD8
		private void InitializeIsChecked(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item)
		{
			if (item.ItemsCount == 0)
			{
				item.IsChecked = new bool?(this.IsOriginallyChecked(item.DropDownItem));
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item2 in item.Items)
			{
				this.InitializeIsChecked(item2);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00053A48 File Offset: 0x00051C48
		private bool IsOriginallyChecked(global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			if (this._recordFilter == null || this._recordFilter.Conditions.Count == 0)
			{
				return true;
			}
			if (this._evaluationContext == null)
			{
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords = global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(this._filterInfo.RecordManager.Unsorted, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible(true));
				this._evaluationContext = new global::Infragistics.Windows.DataPresenter.FilterDropDownConditionEvaluationContext(this._filterInfo.Field, allValuesRecords);
			}
			if (dropDownItem == null)
			{
				dropDownItem = new global::Infragistics.Windows.DataPresenter.FilterDropDownItem(null, string.Empty, true);
			}
			this._evaluationContext.Initialize(dropDownItem);
			return this._recordFilter.Conditions.IsMatch(dropDownItem.Value, this._evaluationContext);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00053AE8 File Offset: 0x00051CE8
		private void OnFilterInfoChanged()
		{
			bool isEmptySearch = this.IsEmptySearch;
			this._recordFilter = ((this._filterInfo == null) ? null : this._filterInfo.RecordFilter);
			this._evaluationContext = null;
			global::Infragistics.Windows.DataPresenter.Field field = (this._filterInfo != null) ? this._filterInfo.Field : null;
			this.Culture = ((field == null) ? global::System.Globalization.CultureInfo.CurrentCulture : global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field));
			this.InitializeIsChecked();
			if (this.HasSearchText)
			{
				this.OnSearchTextChanged();
				if (isEmptySearch != this.IsEmptySearch)
				{
					this.OnPropertyChanged("IsEmptySearch");
				}
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00053B74 File Offset: 0x00051D74
		private void OnSearchTextChanged()
		{
			if (this._filterInfo == null)
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> allItems = this.AllItems;
			if (!this.HasSearchText)
			{
				if (this._selectAllSearchItem != null)
				{
					this._selectAllSearchItem.ItemsSource.Clear();
				}
				this.InitializeAllItems();
				if (this._addToFilterItem != null)
				{
					this._addToFilterItem.IsChecked = new bool?(false);
				}
				this.InitializeIsChecked();
				return;
			}
			if (this._searchToRootTable == null)
			{
				this._searchToRootTable = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
			}
			else
			{
				this._searchToRootTable.Clear();
			}
			if (this._selectAllSearchItem == null)
			{
				this._selectAllSearchItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.SelectAllSearchResults, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeItem_SelectAllSearch"), null, null);
			}
			try
			{
				this._selectAllSearchItem.ItemsSource.BeginUpdate();
				if (this._addToFilterItem == null)
				{
					this._addToFilterItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.AddCurrentSelectionToFilter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeItem_AddToFilter"), null, null);
					this._addToFilterItem.IsChecked = new bool?(false);
				}
				if (this._blanksItem != null && this._addedBlanks == true)
				{
					this._searchBlanks = this._blanksItem.CreateNew();
				}
				global::System.Predicate<string> predicate = global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.SearchHelper.CreateMatchCallback(this._searchText, this._filterInfo.Field.ExcelStyleFilterSearchOperatorResolved);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? dateScope = global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.GetDateScope(this._searchScope);
				this.CloneMatchingDateItem(predicate, dateScope, list);
				if (this._searchScope == global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.All || this._searchScope == global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope.Year)
				{
					foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in this._valuesItem.ItemsSource)
					{
						if (predicate(recordFilterTreeItem.DisplayTextInternal))
						{
							global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Value, recordFilterTreeItem.DropDownItem);
							recordFilterTreeItem2.IsChecked = new bool?(true);
							list.Add(recordFilterTreeItem2);
							this._searchToRootTable[recordFilterTreeItem2] = recordFilterTreeItem;
						}
					}
					if (this._blanksItem != null && this._addedBlanks == true && predicate(this._searchBlanks.DisplayTextInternal))
					{
						this._searchBlanks.IsChecked = new bool?(true);
						list.Add(this._searchBlanks);
						this._searchToRootTable[this._searchBlanks] = this._blanksItem;
					}
				}
				this._selectAllSearchItem.ItemsSource.ReInitialize(list);
				this._allItems.Collections = new global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>[]
				{
					new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem[]
					{
						this._selectAllSearchItem,
						this._addToFilterItem
					},
					this._selectAllSearchItem.ItemsSource
				};
			}
			finally
			{
				this._selectAllSearchItem.ItemsSource.EndUpdate();
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00053E58 File Offset: 0x00052058
		private void UpdateDateRecordFilter(global::Infragistics.Windows.Controls.ConditionGroup conditionGroup, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item)
		{
			if (item.IsChecked == false)
			{
				return;
			}
			if (item.IsChecked == true)
			{
				global::Infragistics.Windows.Controls.DateRangeScope dateRangeScope = global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.GetDateRangeScope(item.ItemType);
				global::System.DateTime relativeDate = (global::System.DateTime)item.DropDownItem.Value;
				conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, global::Infragistics.Windows.Controls.SpecialFilterOperands.CreateDateRangeOperand(relativeDate, dateRangeScope)));
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem item2 in item.ItemsSource)
			{
				this.UpdateDateRecordFilter(conditionGroup, item2);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00053F40 File Offset: 0x00052140
		private void UpdateRecordFilter(global::Infragistics.Windows.Controls.ConditionGroup conditionGroup)
		{
			conditionGroup.Clear();
			if (this._selectAllItem.IsChecked == true)
			{
				return;
			}
			conditionGroup.LogicalOperator = global::Infragistics.Windows.Controls.LogicalOperator.Or;
			if (this._addedBlanks == true && this._blanksItem.IsChecked == false)
			{
				bool flag = (this._valuesItem.IsChecked == true || this._valuesItem.ItemsSource.Count == 0) && (this._datesItem.IsChecked == true || this._datesItem.ItemsSource.Count == 0);
				if (flag)
				{
					conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals, this._blanksOperand));
					return;
				}
			}
			if (this._datesItem.IsChecked != false)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in this._datesItem.ItemsSource)
				{
					if (recordFilterTreeItem.IsChecked != false)
					{
						this.UpdateDateRecordFilter(conditionGroup, recordFilterTreeItem);
					}
				}
			}
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			int num = global::System.Math.Max(this.FilterInfo.Field.FilterConditionOptimizationThresholdResolved, 0);
			if (this._valuesItem.IsChecked != false)
			{
				bool flag2;
				if (typeof(string) == this.FilterInfo.Field.EditAsTypeResolved && num > 0)
				{
					flag2 = (this._valuesItem.ItemsSource.Count((global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem i) => i.IsChecked == true) >= num);
				}
				else
				{
					flag2 = false;
				}
				bool flag3 = flag2;
				global::System.Collections.Generic.List<string> list2 = flag3 ? new global::System.Collections.Generic.List<string>() : null;
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 in this._valuesItem.ItemsSource)
				{
					if (recordFilterTreeItem2.IsChecked == true)
					{
						if (flag3)
						{
							string originalDisplayText = this._owner.ValueLoader.GetOriginalDisplayText(recordFilterTreeItem2.DropDownItem);
							if (!string.IsNullOrEmpty(originalDisplayText))
							{
								list2.Add(originalDisplayText);
								continue;
							}
						}
						list.Add(recordFilterTreeItem2.Value);
					}
				}
				if (list2 != null && list2.Count > 0)
				{
					conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.In, global::Infragistics.Windows.Controls.ComparisonCondition.ConstructInOperand(list2)));
				}
			}
			if (this._addedBlanks == true && this._blanksItem.IsChecked == true)
			{
				list.Add(this._blanksOperand);
			}
			if (conditionGroup.Count > 0 || list.Count < num || num == 0)
			{
				using (global::System.Collections.Generic.List<object>.Enumerator enumerator3 = list.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						object value = enumerator3.Current;
						conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, value));
					}
					return;
				}
			}
			if (list.Count > 0)
			{
				conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, global::Infragistics.Windows.Controls.SpecialFilterOperands.CreateInOperand(list)));
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00054308 File Offset: 0x00052508
		private void UpdateRootNodeFromSearchNodes()
		{
			this.UpdateRootNodeFromSearchNodes(this._selectAllSearchItem);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00054318 File Offset: 0x00052518
		private void UpdateRootNodeFromSearchNodes(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem searchItem)
		{
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem in searchItem.ItemsSource)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2;
				if (recordFilterTreeItem.IsChecked == null)
				{
					this.UpdateRootNodeFromSearchNodes(recordFilterTreeItem);
				}
				else if (this._searchToRootTable.TryGetValue(recordFilterTreeItem, out recordFilterTreeItem2) && !(recordFilterTreeItem.IsChecked == recordFilterTreeItem2.IsChecked))
				{
					if (recordFilterTreeItem.ItemsCount > 0)
					{
						this.UpdateRootNodeFromSearchNodes(recordFilterTreeItem);
					}
					else
					{
						recordFilterTreeItem2.IsChecked = recordFilterTreeItem.IsChecked;
					}
				}
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000543E0 File Offset: 0x000525E0
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				string propertyName;
				if ((propertyName = propertyChangedEventArgs.PropertyName) != null)
				{
					if (!(propertyName == "") && !(propertyName == "RecordFilter"))
					{
						if (propertyName == "RecordFilterVersion")
						{
							if (!this.IsUpdatingFilter)
							{
								this.ResetIsChecked();
							}
						}
					}
					else
					{
						this.OnFilterInfoChanged();
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x0400079E RID: 1950
		private global::Infragistics.Collections.AggregateCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _allItems;

		// Token: 0x0400079F RID: 1951
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _selectAllItem;

		// Token: 0x040007A0 RID: 1952
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _blanksItem;

		// Token: 0x040007A1 RID: 1953
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _datesItem;

		// Token: 0x040007A2 RID: 1954
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _valuesItem;

		// Token: 0x040007A3 RID: 1955
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _suffixItems;

		// Token: 0x040007A4 RID: 1956
		private bool? _includeBlanks;

		// Token: 0x040007A5 RID: 1957
		private bool? _addedBlanks;

		// Token: 0x040007A6 RID: 1958
		private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _blanksOperand;

		// Token: 0x040007A7 RID: 1959
		private bool _isGroupingDates = true;

		// Token: 0x040007A8 RID: 1960
		private string _hourFormat;

		// Token: 0x040007A9 RID: 1961
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x040007AA RID: 1962
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;

		// Token: 0x040007AB RID: 1963
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

		// Token: 0x040007AC RID: 1964
		private global::Infragistics.Windows.DataPresenter.FilterDropDownConditionEvaluationContext _evaluationContext;

		// Token: 0x040007AD RID: 1965
		private bool _isUpdatingFilter;

		// Token: 0x040007AE RID: 1966
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _selectAllSearchItem;

		// Token: 0x040007AF RID: 1967
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _addToFilterItem;

		// Token: 0x040007B0 RID: 1968
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _searchBlanks;

		// Token: 0x040007B1 RID: 1969
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _searchToRootTable;

		// Token: 0x040007B2 RID: 1970
		private string _searchText;

		// Token: 0x040007B3 RID: 1971
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope _searchScope;

		// Token: 0x040007B4 RID: 1972
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? _mostSpecificCreatedDateType;

		// Token: 0x040007B5 RID: 1973
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl _owner;

		// Token: 0x02000140 RID: 320
		private class SearchHelper
		{
			// Token: 0x0600131F RID: 4895 RVA: 0x00054452 File Offset: 0x00052652
			private SearchHelper(string searchText)
			{
				this._searchText = searchText;
			}

			// Token: 0x06001320 RID: 4896 RVA: 0x00054461 File Offset: 0x00052661
			private bool IsMatch(string displayText)
			{
				return displayText != null && displayText.IndexOf(this._searchText, global::System.StringComparison.OrdinalIgnoreCase) >= 0;
			}

			// Token: 0x06001321 RID: 4897 RVA: 0x00054488 File Offset: 0x00052688
			internal static global::System.Predicate<string> CreateMatchCallback(string searchText, global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator searchOperator)
			{
				if (searchOperator == global::Infragistics.Windows.DataPresenter.ExcelStyleFilterSearchOperator.Contains || searchText.IndexOfAny(new char[]
				{
					'?',
					'*',
					'[',
					'#'
				}) < 0)
				{
					return new global::System.Predicate<string>(new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.SearchHelper(searchText).IsMatch);
				}
				global::System.Text.RegularExpressions.Regex regex = null;
				try
				{
					regex = global::Infragistics.CoreUtilities.WildcardToRegexConverter.Convert(searchText, true, true);
				}
				catch (global::System.ArgumentException)
				{
				}
				if (regex == null)
				{
					return (string text) => false;
				}
				return new global::System.Predicate<string>(regex.IsMatch);
			}

			// Token: 0x040007B7 RID: 1975
			private string _searchText;
		}
	}
}
