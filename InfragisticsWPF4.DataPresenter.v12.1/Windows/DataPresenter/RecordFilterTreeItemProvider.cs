using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000123 RID: 291
	internal class RecordFilterTreeItemProvider : global::Infragistics.PropertyChangeNotifier, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06000F87 RID: 3975 RVA: 0x00041C8C File Offset: 0x0003FE8C
		internal RecordFilterTreeItemProvider(bool? includeBlanks)
		{
			this._culture = global::System.Globalization.CultureInfo.CurrentCulture;
			this._includeBlanks = includeBlanks;
			this._selectAllItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.SelectAll, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("RecordFilterTreeItem_SelectAll"), null, null);
			this._valuesItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Values, "Values", null, null);
			this._datesItem = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Dates, "Dates", null, null);
			this._suffixItems = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>();
			this._blanksOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.Blanks;
			this.Initialize();
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00041D13 File Offset: 0x0003FF13
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

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00041D34 File Offset: 0x0003FF34
		public bool HasSearchText
		{
			get
			{
				return !string.IsNullOrEmpty(this._searchText);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00041D44 File Offset: 0x0003FF44
		public bool IsEmptySearch
		{
			get
			{
				return this.HasSearchText && (this._selectAllSearchItem == null || this._selectAllSearchItem.ItemsSource.Count == 0);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00041D6D File Offset: 0x0003FF6D
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00041D75 File Offset: 0x0003FF75
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00041D98 File Offset: 0x0003FF98
		public global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? MostSpecificCreatedDateType
		{
			get
			{
				return this._mostSpecificCreatedDateType;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00041DA0 File Offset: 0x0003FFA0
		public global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope SearchScope
		{
			get
			{
				return this._searchScope;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		public string SearchText
		{
			get
			{
				return this._searchText;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00041DB0 File Offset: 0x0003FFB0
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00041E38 File Offset: 0x00040038
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00041E40 File Offset: 0x00040040
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00041E95 File Offset: 0x00040095
		internal bool IsUpdatingFilter
		{
			get
			{
				return this._isUpdatingFilter;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00041E9D File Offset: 0x0004009D
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00041EA5 File Offset: 0x000400A5
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

		// Token: 0x06000F96 RID: 3990 RVA: 0x00041EC0 File Offset: 0x000400C0
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

		// Token: 0x06000F97 RID: 3991 RVA: 0x00041F62 File Offset: 0x00040162
		internal void AddBlanks()
		{
			if (this._includeBlanks == null && this._addedBlanks == null)
			{
				this.AddBlanksItem();
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00041F84 File Offset: 0x00040184
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

		// Token: 0x06000F99 RID: 3993 RVA: 0x00042164 File Offset: 0x00040364
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

		// Token: 0x06000F9A RID: 3994 RVA: 0x00042200 File Offset: 0x00040400
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

		// Token: 0x06000F9B RID: 3995 RVA: 0x0004229C File Offset: 0x0004049C
		internal void ResetIsChecked()
		{
			this.InitializeIsChecked();
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000422A4 File Offset: 0x000404A4
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

		// Token: 0x06000F9D RID: 3997 RVA: 0x000423A8 File Offset: 0x000405A8
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

		// Token: 0x06000F9E RID: 3998 RVA: 0x00042430 File Offset: 0x00040630
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

		// Token: 0x06000F9F RID: 3999 RVA: 0x00042668 File Offset: 0x00040868
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

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00042767 File Offset: 0x00040967
		private int BinarySearchDateItem(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent, int nextValue)
		{
			if (parent.ItemType == global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Dates)
			{
				return this.BinarySearchDateItem(parent.ItemsSource, nextValue, new global::System.Comparison<int>(this.CompareDescendingDates));
			}
			return this.BinarySearchDateItem(parent.ItemsSource, nextValue, new global::System.Comparison<int>(this.CompareAscendingDates));
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000427A8 File Offset: 0x000409A8
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

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00042808 File Offset: 0x00040A08
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

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00042884 File Offset: 0x00040A84
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

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00042984 File Offset: 0x00040B84
		private int CompareDescendingDates(int itemYear, int newYearValue)
		{
			return newYearValue.CompareTo(itemYear);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0004298E File Offset: 0x00040B8E
		private int CompareAscendingDates(int itemYear, int newYearValue)
		{
			return itemYear.CompareTo(newYearValue);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00042998 File Offset: 0x00040B98
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

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000429C5 File Offset: 0x00040BC5
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem ConvertLeafDayToSecond(global::System.DateTime date, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem parent, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem childItem, int childIndex)
		{
			childItem = (parent.ItemsSource[childIndex] = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Day, childItem.DisplayText, childItem.Value, childItem.DropDownItem));
			this.AddDate(date.Date, childItem, childItem.DropDownItem);
			return childItem;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00042A04 File Offset: 0x00040C04
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

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00042ABC File Offset: 0x00040CBC
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

		// Token: 0x06000FAA RID: 4010 RVA: 0x00042AFC File Offset: 0x00040CFC
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

		// Token: 0x06000FAB RID: 4011 RVA: 0x00042B64 File Offset: 0x00040D64
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

		// Token: 0x06000FAC RID: 4012 RVA: 0x00042BFC File Offset: 0x00040DFC
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

		// Token: 0x06000FAD RID: 4013 RVA: 0x00042C60 File Offset: 0x00040E60
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

		// Token: 0x06000FAE RID: 4014 RVA: 0x00042CC4 File Offset: 0x00040EC4
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

		// Token: 0x06000FAF RID: 4015 RVA: 0x00042DB4 File Offset: 0x00040FB4
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

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00042E24 File Offset: 0x00041024
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

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00042EC4 File Offset: 0x000410C4
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

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00042F50 File Offset: 0x00041150
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
				global::System.Predicate<string> predicate = global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemProvider.SearchHelper.CreateMatchCallback(this._searchText);
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
						this._searchToRootTable[this._blanksItem] = this._searchBlanks;
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

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00043224 File Offset: 0x00041424
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

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000432E4 File Offset: 0x000414E4
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
			if (this._valuesItem.IsChecked != false)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem recordFilterTreeItem2 in this._valuesItem.ItemsSource)
				{
					if (recordFilterTreeItem2.IsChecked == true)
					{
						conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, recordFilterTreeItem2.Value));
					}
				}
			}
			if (this._addedBlanks == true && this._blanksItem.IsChecked == true)
			{
				conditionGroup.Add(new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Equals, this._blanksOperand));
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00043560 File Offset: 0x00041760
		private void UpdateRootNodeFromSearchNodes()
		{
			this.UpdateRootNodeFromSearchNodes(this._selectAllSearchItem);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00043570 File Offset: 0x00041770
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

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00043638 File Offset: 0x00041838
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

		// Token: 0x040005FC RID: 1532
		private global::Infragistics.Collections.AggregateCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _allItems;

		// Token: 0x040005FD RID: 1533
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _selectAllItem;

		// Token: 0x040005FE RID: 1534
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _blanksItem;

		// Token: 0x040005FF RID: 1535
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _datesItem;

		// Token: 0x04000600 RID: 1536
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _valuesItem;

		// Token: 0x04000601 RID: 1537
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _suffixItems;

		// Token: 0x04000602 RID: 1538
		private bool? _includeBlanks;

		// Token: 0x04000603 RID: 1539
		private bool? _addedBlanks;

		// Token: 0x04000604 RID: 1540
		private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _blanksOperand;

		// Token: 0x04000605 RID: 1541
		private bool _isGroupingDates = true;

		// Token: 0x04000606 RID: 1542
		private string _hourFormat;

		// Token: 0x04000607 RID: 1543
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x04000608 RID: 1544
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;

		// Token: 0x04000609 RID: 1545
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _filterInfo;

		// Token: 0x0400060A RID: 1546
		private global::Infragistics.Windows.DataPresenter.FilterDropDownConditionEvaluationContext _evaluationContext;

		// Token: 0x0400060B RID: 1547
		private bool _isUpdatingFilter;

		// Token: 0x0400060C RID: 1548
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _selectAllSearchItem;

		// Token: 0x0400060D RID: 1549
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _addToFilterItem;

		// Token: 0x0400060E RID: 1550
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem _searchBlanks;

		// Token: 0x0400060F RID: 1551
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem, global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _searchToRootTable;

		// Token: 0x04000610 RID: 1552
		private string _searchText;

		// Token: 0x04000611 RID: 1553
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeSearchScope _searchScope;

		// Token: 0x04000612 RID: 1554
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType? _mostSpecificCreatedDateType;

		// Token: 0x02000124 RID: 292
		private class SearchHelper
		{
			// Token: 0x06000FB8 RID: 4024 RVA: 0x000436AA File Offset: 0x000418AA
			private SearchHelper(string searchText)
			{
				this._searchText = searchText;
			}

			// Token: 0x06000FB9 RID: 4025 RVA: 0x000436B9 File Offset: 0x000418B9
			private bool IsMatch(string displayText)
			{
				return displayText != null && displayText.IndexOf(this._searchText, global::System.StringComparison.OrdinalIgnoreCase) >= 0;
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x000436E0 File Offset: 0x000418E0
			internal static global::System.Predicate<string> CreateMatchCallback(string searchText)
			{
				if (searchText.IndexOfAny(new char[]
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
					regex = global::Infragistics.Windows.Controls.ComparisonCondition.WildcardToRegexConverter.Convert(searchText, true);
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

			// Token: 0x04000613 RID: 1555
			private string _searchText;
		}
	}
}
