using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000087 RID: 135
	public class DateFilterSelectionControl : global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x00018754 File Offset: 0x00016954
		static DateFilterSelectionControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl)));
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000187EC File Offset: 0x000169EC
		public DateFilterSelectionControl()
		{
			base.Unloaded += this.DateFilterSelectionControl_Unloaded;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00018814 File Offset: 0x00016A14
		private void DateFilterSelectionControl_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.CachedCheckedCount = (this.CachedUncheckedCount = 0);
			base.CachedUniqueValues.Clear();
			this.CachedFlatUniqueValues.Clear();
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00018847 File Offset: 0x00016A47
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00018859 File Offset: 0x00016A59
		public global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject DateFilterObjectTypeItem
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterObjectTypeItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterObjectTypeItemProperty, value);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00018868 File Offset: 0x00016A68
		private static void DateFilterObjectTypeItemChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl dateFilterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl)obj;
			dateFilterSelectionControl.OnPropertyChanged("DateFilterObjectTypeItem");
			if (!string.IsNullOrEmpty(dateFilterSelectionControl.FilterText))
			{
				dateFilterSelectionControl.FilterUniqueValue(dateFilterSelectionControl.FilterText);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000188A0 File Offset: 0x00016AA0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject> DateFilterTypeList
		{
			get
			{
				if (this._dateFilterTypeList == null)
				{
					this._dateFilterTypeList = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject>();
					this.SetupComboBox();
				}
				return this._dateFilterTypeList;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000188C1 File Offset: 0x00016AC1
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000188D3 File Offset: 0x00016AD3
		public global::Infragistics.Controls.Grids.Primitives.DateFilterHierarchicalDataTemplate DateFilterHierarchicalDataTemplate
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.DateFilterHierarchicalDataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterHierarchicalDataTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterHierarchicalDataTemplateProperty, value);
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000188E4 File Offset: 0x00016AE4
		private static void DateFilterHierarchicalDataTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl dateFilterSelectionControl = (global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl)obj;
			dateFilterSelectionControl.OnPropertyChanged("DateFilterHierarchicalDataTemplate");
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00018903 File Offset: 0x00016B03
		public override global::System.Collections.IEnumerable FilterableUniqueValues
		{
			get
			{
				if (this.UniqueValues == null)
				{
					return null;
				}
				return this.UniqueValues;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00018915 File Offset: 0x00016B15
		private global::Infragistics.Controls.Grids.Primitives.FilterItemCollection CachedFlatUniqueValues
		{
			get
			{
				if (this._cachedFlatUniqueValues == null)
				{
					this._cachedFlatUniqueValues = this.GetCollection();
				}
				return this._cachedFlatUniqueValues;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00018931 File Offset: 0x00016B31
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00018939 File Offset: 0x00016B39
		private int CachedCheckedCount { get; set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00018942 File Offset: 0x00016B42
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0001894A File Offset: 0x00016B4A
		private int CachedUncheckedCount { get; set; }

		// Token: 0x06000538 RID: 1336 RVA: 0x00018954 File Offset: 0x00016B54
		protected override void OnRawValuesSet()
		{
			this._addTime = false;
			foreach (object obj in base.RawValues)
			{
				if (obj != null)
				{
					global::System.DateTime dateTime = (global::System.DateTime)obj;
					if (dateTime.Hour != 0 || dateTime.Minute != 0 || dateTime.Second != 0)
					{
						this._addTime = true;
					}
				}
			}
			this.DateFilterTypeList.Clear();
			this.SetupComboBox();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000189E8 File Offset: 0x00016BE8
		protected internal override void AcceptChanges()
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			global::Infragistics.Controls.Grids.XamGrid grid = column.ColumnLayout.Grid;
			bool flag = !base.AppendFilters;
			if (columnLayout.Grid.FilteringSettings.FilterMenuSelectionListGeneration == global::Infragistics.Controls.Grids.FilterMenuCumulativeSelectionList.ExcelStyle)
			{
				foreach (global::Infragistics.IRecordFilter recordFilter in rowFiltersCollectionResolved)
				{
					global::Infragistics.Controls.Grids.RowsFilter rowsFilter2 = (global::Infragistics.Controls.Grids.RowsFilter)recordFilter;
					if (rowsFilter != rowsFilter2 && rowsFilter2.Conditions.Count > 0)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.Or;
				rowsFilter.Conditions.ClearSilently();
			}
			if (base.AppendFilters)
			{
				if (rowsFilter.Conditions.Count == 0)
				{
					rowsFilter.Conditions.LogicalOperator = global::Infragistics.LogicalOperator.And;
				}
				global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.XamGridFilterDate> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridFilterDate>();
				foreach (object obj in this.FilterableUniqueValues)
				{
					global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
					if (xamGridFilterDate.NullDate)
					{
						this.SynchornizeCachedValue(xamGridFilterDate, list);
					}
					else
					{
						foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate2 in xamGridFilterDate.Children)
						{
							foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate3 in xamGridFilterDate2.Children)
							{
								if (this._addTime)
								{
									using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridFilterDate>.Enumerator enumerator5 = xamGridFilterDate3.Children.GetEnumerator())
									{
										while (enumerator5.MoveNext())
										{
											global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate4 = enumerator5.Current;
											foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate5 in xamGridFilterDate4.Children)
											{
												foreach (global::Infragistics.Controls.Grids.XamGridFilterDate date in xamGridFilterDate5.Children)
												{
													this.SynchornizeCachedValue(date, list);
												}
											}
										}
										continue;
									}
								}
								this.SynchornizeCachedValue(xamGridFilterDate3, list);
							}
						}
					}
				}
				if (rowsFilter.Conditions.LogicalOperator == global::Infragistics.LogicalOperator.Or)
				{
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.XamGridFilterDate> enumerator8 = list.GetEnumerator())
					{
						while (enumerator8.MoveNext())
						{
							global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate6 = enumerator8.Current;
							base.ApplyNegativeFilterForItem(xamGridFilterDate6.Date, xamGridFilterDate6.IsChecked == true, column, columnLayout, rowsManager, rowsFilter, true);
						}
						goto IL_525;
					}
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.XamGridFilterDate> enumerator9 = list.GetEnumerator())
				{
					while (enumerator9.MoveNext())
					{
						global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate7 = enumerator9.Current;
						base.ApplyFilterForItem(xamGridFilterDate7.Date, xamGridFilterDate7.IsChecked == true, column, columnLayout, rowsManager, rowsFilter, true);
					}
					goto IL_525;
				}
			}
			if (string.IsNullOrEmpty(base.FilterText))
			{
				this.ProcessChanges(base.CheckedCount, base.UncheckedCount, this.FilterableUniqueValues);
			}
			else
			{
				int num = 0;
				foreach (object obj2 in this.FilterableUniqueValues)
				{
					global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate8 = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj2;
					if (xamGridFilterDate8.NullDate)
					{
						num++;
					}
					else
					{
						foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate9 in xamGridFilterDate8.Children)
						{
							foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate10 in xamGridFilterDate9.Children)
							{
								if (this._addTime)
								{
									using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridFilterDate>.Enumerator enumerator13 = xamGridFilterDate10.Children.GetEnumerator())
									{
										while (enumerator13.MoveNext())
										{
											global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate11 = enumerator13.Current;
											foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate12 in xamGridFilterDate11.Children)
											{
												foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate13 in xamGridFilterDate12.Children)
												{
													num++;
												}
											}
										}
										continue;
									}
								}
								num++;
							}
						}
					}
				}
				this.ProcessChanges(num, base.RawValues.Count - num, this.FilterableUniqueValues);
			}
			IL_525:
			cell.Row.ColumnLayout.InvalidateFiltering();
			grid.ResetPanelRows();
			grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00019268 File Offset: 0x00017468
		internal override void FilterUniqueValueInternal(string filterValue)
		{
			if (base.CachedUniqueValues != null && base.CachedUniqueValues.Count > 0)
			{
				if (string.IsNullOrEmpty(filterValue))
				{
					this._boolBuildCachedList = false;
					this._cacheCount = false;
					this.RefreshUniqueValues(this.CachedFlatUniqueValues);
					this._cacheCount = true;
					this._boolBuildCachedList = true;
					global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource> list = new global::System.Collections.Generic.List<global::System.Threading.CancellationTokenSource>(base.Phase2TokenSourceQueue);
					foreach (global::System.Threading.CancellationTokenSource cancellationTokenSource in list)
					{
						cancellationTokenSource.Cancel();
						base.Phase2TokenSourceQueue.Remove(cancellationTokenSource);
					}
					base.IsBusy = false;
					this.InvalidateShowAppendFilterButton(filterValue);
					this.EnsureCurrentState();
					return;
				}
				global::System.Threading.Tasks.TaskScheduler scheduler = global::System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();
				base.IsBusy = true;
				this.EnsureCurrentState();
				global::System.Threading.CancellationTokenSource source = new global::System.Threading.CancellationTokenSource();
				base.Phase2TokenSourceQueue.Add(source);
				global::Infragistics.Controls.Grids.DateFilterObjectType dateFilterObjectType = this.DateFilterObjectTypeItem.DateFilterObjectType;
				global::System.Threading.Tasks.Task<global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload>.Factory.StartNew(delegate()
				{
					global::Infragistics.DataManagerBase dataManagerBase = global::Infragistics.DataManagerBase.CreateDataManager(this.CachedFlatUniqueValues);
					dataManagerBase.Filters = new global::Infragistics.RecordFilterCollection();
					dataManagerBase.Filters.Add(new global::Infragistics.Controls.Grids.FilterValueProxyRowsFilter(typeof(global::Infragistics.Controls.Grids.XamGridFilterDate), dataManagerBase.CachedTypedInfo));
					dataManagerBase.Filters[0].Conditions.Add(new global::Infragistics.Controls.Grids.DateFilterObjectStringFilter
					{
						DateFilterObjectType = dateFilterObjectType,
						FilterValue = filterValue
					});
					dataManagerBase.UpdateData();
					return new global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload
					{
						CancellationTokenSource = source,
						FilteredList = dataManagerBase.SortedFilteredDataSource
					};
				}, source.Token).ContinueWith(delegate(global::System.Threading.Tasks.Task<global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl.Phase2Payload> result)
				{
					if (result.IsCanceled || result.Exception != null || result.Result.CancellationTokenSource.IsCancellationRequested)
					{
						return;
					}
					this.FilterText = filterValue;
					this._boolBuildCachedList = false;
					this._cacheCount = false;
					this.RefreshUniqueValues(result.Result.FilteredList);
					this._cacheCount = true;
					this._boolBuildCachedList = true;
					if (!string.IsNullOrEmpty(filterValue))
					{
						this.SetSelectAllCheckBox(new bool?(true));
					}
					this.InvalidateShowAppendFilterButton(filterValue);
					this.Phase2TokenSourceQueue.Remove(result.Result.CancellationTokenSource);
					if (this.Phase2TokenSourceQueue.Count == 0)
					{
						this.IsBusy = false;
					}
					this.EnsureCurrentState();
				}, scheduler);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000193E4 File Offset: 0x000175E4
		protected override global::Infragistics.Controls.Grids.Primitives.FilterItemCollection GetCollection()
		{
			return new global::Infragistics.Controls.Grids.XamGridFilterYearCollection();
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000193EC File Offset: 0x000175EC
		protected override void OnSelectAllCheckBoxChecked(global::System.Windows.Controls.CheckBox cbSender)
		{
			bool allCheckBoxValues = cbSender.IsChecked == true;
			this.SetAllCheckBoxValues(allCheckBoxValues);
			base.AllowFiltering = (cbSender.IsChecked != false);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001943E File Offset: 0x0001763E
		protected internal override void ClearExistingFilters()
		{
			base.ClearExistingFilters();
			this.SetAllCheckBoxValues(true);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00019450 File Offset: 0x00017650
		protected override void ControlLoaded()
		{
			this.CachedCheckedCount = (this.CachedUncheckedCount = 0);
			base.ControlLoaded();
			this.OnPropertyChanged("DateFilterObjectType");
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00019480 File Offset: 0x00017680
		private void SetupComboBox()
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject> dateFilterTypeList = this.DateFilterTypeList;
			global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject dateFilterListDisplayObject = new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
			{
				DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.All,
				Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_All")
			};
			dateFilterTypeList.Add(dateFilterListDisplayObject);
			this.DateFilterObjectTypeItem = dateFilterListDisplayObject;
			dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
			{
				DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Year,
				Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Year")
			});
			dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
			{
				DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Month,
				Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Month")
			});
			dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
			{
				DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Date,
				Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Date")
			});
			if (this._addTime)
			{
				dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
				{
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Hour,
					Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Hour")
				});
				dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
				{
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Minute,
					Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Minute")
				});
				dateFilterTypeList.Add(new global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject
				{
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Second,
					Name = global::Infragistics.SRGrid.GetString("DateFilterObjectType_Second")
				});
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000195B8 File Offset: 0x000177B8
		protected override int GenerateUniqueList(global::System.Collections.IList items, global::System.Collections.Generic.List<object> values, bool shouldCheck)
		{
			this.UniqueValuesClear();
			int num = 0;
			global::System.Type dataType = base.Cell.Column.DataType;
			foreach (object obj in items)
			{
				bool flag = false;
				foreach (object obj2 in values)
				{
					if (obj == obj2)
					{
						flag = true;
					}
					else if (obj != null)
					{
						flag = obj.Equals(obj2);
					}
					if (!flag && dataType == typeof(string) && string.IsNullOrEmpty((string)obj) && string.IsNullOrEmpty((string)obj2))
					{
						flag = true;
					}
					if (flag)
					{
						break;
					}
				}
				bool flag2 = shouldCheck ? flag : (!flag);
				if (flag2)
				{
					num++;
				}
				bool isChecked = shouldCheck ? flag : (!flag);
				this.AddUniqueValue(obj, isChecked, dataType);
			}
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
			this.SetUpIsExpanded();
			return num;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000196F4 File Offset: 0x000178F4
		protected override void CreateAllCheckBoxes(global::System.Collections.IList items, bool shouldCheck)
		{
			this.UniqueValuesClear();
			global::System.Type dataType = base.Cell.Column.DataType;
			foreach (object value in items)
			{
				this.AddUniqueValue(value, shouldCheck, dataType);
			}
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
			this.SetUpIsExpanded();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00019778 File Offset: 0x00017978
		protected override void AddUniqueValue(object value, bool isChecked, global::System.Type type)
		{
			if (value == null)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = new global::Infragistics.Controls.Grids.XamGridFilterDate();
				xamGridFilterDate.IsChecked = new bool?(isChecked);
				xamGridFilterDate.DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.None;
				this.UniqueValues.Add(xamGridFilterDate);
				xamGridFilterDate.PropertyChanged -= this.UniqueValue_PropertyChanged;
				xamGridFilterDate.PropertyChanged += this.UniqueValue_PropertyChanged;
				xamGridFilterDate = new global::Infragistics.Controls.Grids.XamGridFilterDate();
				xamGridFilterDate.IsChecked = new bool?(isChecked);
				if (this._boolBuildCachedList)
				{
					base.CachedUniqueValues.AddSilently(xamGridFilterDate);
					this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate);
					if (this._cacheCount)
					{
						if (isChecked)
						{
							this.CachedCheckedCount++;
							base.CheckedCount++;
							return;
						}
						this.CachedUncheckedCount++;
						base.UncheckedCount++;
					}
				}
				return;
			}
			string pattern = global::System.Text.RegularExpressions.Regex.Escape(base.FilterText);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			global::System.DateTime date = (global::System.DateTime)value;
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate2 = ((global::Infragistics.Controls.Grids.XamGridFilterYearCollection)this.UniqueValues).GetItemByYear(date);
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate3 = ((global::Infragistics.Controls.Grids.XamGridFilterYearCollection)base.CachedUniqueValues).GetItemByYear(date);
			if (xamGridFilterDate2 == null)
			{
				if (this._boolBuildCachedList)
				{
					xamGridFilterDate3 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						Date = date,
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Year
					};
					base.CachedUniqueValues.AddSilently(xamGridFilterDate3);
					this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate3);
				}
				xamGridFilterDate2 = new global::Infragistics.Controls.Grids.XamGridFilterDate
				{
					Date = date,
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Year
				};
				this.UniqueValues.AddSilently(xamGridFilterDate2);
			}
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate4 = xamGridFilterDate2.GetMonthByDate(date);
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate5 = xamGridFilterDate3.GetMonthByDate(date);
			if (xamGridFilterDate4 == null)
			{
				if (this._boolBuildCachedList)
				{
					xamGridFilterDate5 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Month,
						Date = date,
						Parent = xamGridFilterDate3
					};
					xamGridFilterDate3.Children.Add(xamGridFilterDate5);
					this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate5);
				}
				xamGridFilterDate4 = new global::Infragistics.Controls.Grids.XamGridFilterDate
				{
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Month,
					Date = date,
					Parent = xamGridFilterDate2
				};
				xamGridFilterDate2.Children.Add(xamGridFilterDate4);
				if ((this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.All || this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.Month) && !string.IsNullOrEmpty(base.FilterText) && regex.IsMatch(xamGridFilterDate4.ContentStringMonth))
				{
					xamGridFilterDate2.IsExpanded = true;
				}
			}
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate6 = xamGridFilterDate4.GetDayByDate(date);
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate7 = xamGridFilterDate5.GetDayByDate(date);
			if (xamGridFilterDate6 == null)
			{
				if (this._boolBuildCachedList)
				{
					xamGridFilterDate7 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						Date = date,
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Date,
						Parent = xamGridFilterDate5
					};
					xamGridFilterDate5.Children.Add(xamGridFilterDate7);
					this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate7);
				}
				xamGridFilterDate6 = new global::Infragistics.Controls.Grids.XamGridFilterDate
				{
					Date = date,
					DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Date,
					Parent = xamGridFilterDate4
				};
				xamGridFilterDate4.Children.Add(xamGridFilterDate6);
				if ((this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.All || this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.Date) && !string.IsNullOrEmpty(base.FilterText) && regex.IsMatch(xamGridFilterDate6.ContentString))
				{
					xamGridFilterDate4.IsExpanded = true;
					xamGridFilterDate2.IsExpanded = true;
				}
				if (!this._addTime)
				{
					xamGridFilterDate6.IsChecked = new bool?(isChecked);
					if (this._boolBuildCachedList)
					{
						xamGridFilterDate7.IsChecked = new bool?(isChecked);
					}
				}
			}
			if (this._addTime)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate8 = xamGridFilterDate6.GetHourByDate(date);
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate9 = xamGridFilterDate7.GetHourByDate(date);
				if (xamGridFilterDate8 == null)
				{
					if (this._boolBuildCachedList)
					{
						xamGridFilterDate9 = new global::Infragistics.Controls.Grids.XamGridFilterDate
						{
							Date = date,
							DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Hour,
							Parent = xamGridFilterDate7
						};
						xamGridFilterDate7.Children.Add(xamGridFilterDate9);
						this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate9);
					}
					xamGridFilterDate8 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						Date = date,
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Hour,
						Parent = xamGridFilterDate6
					};
					xamGridFilterDate6.Children.Add(xamGridFilterDate8);
					if ((this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.All || this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.Hour) && !string.IsNullOrEmpty(base.FilterText) && regex.IsMatch(xamGridFilterDate8.ContentString))
					{
						xamGridFilterDate6.IsExpanded = true;
						xamGridFilterDate4.IsExpanded = true;
						xamGridFilterDate2.IsExpanded = true;
					}
				}
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate10 = xamGridFilterDate8.GetMinuteByDate(date);
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate11 = xamGridFilterDate9.GetMinuteByDate(date);
				if (xamGridFilterDate10 == null)
				{
					if (this._boolBuildCachedList)
					{
						xamGridFilterDate11 = new global::Infragistics.Controls.Grids.XamGridFilterDate
						{
							Date = date,
							DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Minute,
							Parent = xamGridFilterDate9
						};
						xamGridFilterDate9.Children.Add(xamGridFilterDate11);
						this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate11);
					}
					xamGridFilterDate10 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						Date = date,
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Minute,
						Parent = xamGridFilterDate8
					};
					xamGridFilterDate8.Children.Add(xamGridFilterDate10);
					if ((this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.All || this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.Minute) && !string.IsNullOrEmpty(base.FilterText) && regex.IsMatch(xamGridFilterDate10.ContentString))
					{
						xamGridFilterDate8.IsExpanded = true;
						xamGridFilterDate6.IsExpanded = true;
						xamGridFilterDate4.IsExpanded = true;
						xamGridFilterDate2.IsExpanded = true;
					}
				}
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate12 = xamGridFilterDate10.GetSecondByDate(date);
				if (xamGridFilterDate12 == null)
				{
					if (this._boolBuildCachedList)
					{
						global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate13 = new global::Infragistics.Controls.Grids.XamGridFilterDate
						{
							Date = date,
							DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Second,
							Parent = xamGridFilterDate11
						};
						xamGridFilterDate11.Children.Add(xamGridFilterDate13);
						this.CachedFlatUniqueValues.AddSilently(xamGridFilterDate13);
						xamGridFilterDate13.IsChecked = new bool?(isChecked);
					}
					xamGridFilterDate12 = new global::Infragistics.Controls.Grids.XamGridFilterDate
					{
						Date = date,
						DateFilterObjectType = global::Infragistics.Controls.Grids.DateFilterObjectType.Second,
						Parent = xamGridFilterDate10
					};
					xamGridFilterDate10.Children.Add(xamGridFilterDate12);
					xamGridFilterDate12.IsChecked = new bool?(isChecked);
					if ((this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.All || this.DateFilterObjectTypeItem.DateFilterObjectType == global::Infragistics.Controls.Grids.DateFilterObjectType.Second) && !string.IsNullOrEmpty(base.FilterText) && regex.IsMatch(xamGridFilterDate12.ContentString))
					{
						xamGridFilterDate10.IsExpanded = true;
						xamGridFilterDate8.IsExpanded = true;
						xamGridFilterDate6.IsExpanded = true;
						xamGridFilterDate4.IsExpanded = true;
						xamGridFilterDate2.IsExpanded = true;
					}
				}
				xamGridFilterDate6 = xamGridFilterDate12;
			}
			if (this._cacheCount)
			{
				if (isChecked)
				{
					this.CachedCheckedCount++;
					base.CheckedCount++;
				}
				else
				{
					this.CachedUncheckedCount++;
					base.UncheckedCount++;
				}
			}
			xamGridFilterDate6.PropertyChanged -= this.UniqueValue_PropertyChanged;
			xamGridFilterDate6.PropertyChanged += this.UniqueValue_PropertyChanged;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00019E28 File Offset: 0x00018028
		private void SetUpIsExpanded()
		{
			if (this.FilterableUniqueValues != null && string.IsNullOrEmpty(base.FilterText))
			{
				int count = this.UniqueValues.Count;
				if (count == 1 && base.Cell.Column.DataType == typeof(global::System.DateTime))
				{
					this.SetUpIsExpandedHelper((global::Infragistics.Controls.Grids.XamGridFilterDate)this.UniqueValues[0]);
					return;
				}
				if (base.Cell.Column.DataType == typeof(global::System.DateTime?) && count > 0 && count <= 2)
				{
					if (count == 1)
					{
						this.SetUpIsExpandedHelper((global::Infragistics.Controls.Grids.XamGridFilterDate)this.UniqueValues[0]);
						return;
					}
					this.SetUpIsExpandedHelper((global::Infragistics.Controls.Grids.XamGridFilterDate)this.UniqueValues[1]);
				}
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00019EF8 File Offset: 0x000180F8
		private void SetUpIsExpandedHelper(global::Infragistics.Controls.Grids.XamGridFilterDate date)
		{
			date.IsExpanded = true;
			if (date.Children.Count == 1)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = date.Children[0];
				xamGridFilterDate.IsExpanded = true;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00019F30 File Offset: 0x00018130
		private void RefreshUniqueValues(global::System.Collections.IEnumerable values)
		{
			this.UniqueValuesClear();
			int num = 0;
			foreach (object obj in values)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
				if (++num > 10000)
				{
					base.IsLimited = true;
					break;
				}
				this.AddUniqueValue(xamGridFilterDate.NullDate ? null : xamGridFilterDate.Date, true, typeof(global::System.DateTime));
			}
			this.UniqueValues.RaiseCollectionChanged();
			this.OnPropertyChanged("FilterableUniqueValues");
			this.SetUpIsExpanded();
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00019FE0 File Offset: 0x000181E0
		private void ResetIsChecked(global::Infragistics.Controls.Grids.XamGridFilterDate date, bool isChecked)
		{
			date.PropertyChanged -= this.UniqueValue_PropertyChanged;
			date.ChangeSilent(new bool?(isChecked));
			date.PropertyChanged += this.UniqueValue_PropertyChanged;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001A014 File Offset: 0x00018214
		internal override void UniqueValuesClear()
		{
			if (this.UniqueValues != null)
			{
				global::System.Collections.IEnumerable list = this.UniqueValues.Cast<global::Infragistics.Controls.Grids.XamGridFilterDate>();
				this.UniqueValuesClear(list);
				this.UniqueValues.Clear();
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001A048 File Offset: 0x00018248
		internal override void UniqueValuesClear(global::System.Collections.IEnumerable list)
		{
			foreach (object obj in list)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
				xamGridFilterDate.PropertyChanged -= this.UniqueValue_PropertyChanged;
				this.UniqueValuesClear(xamGridFilterDate.Children);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001A0B4 File Offset: 0x000182B4
		private void SetAllCheckBoxValues(bool isChecked)
		{
			int num = 0;
			if (this.FilterableUniqueValues != null)
			{
				foreach (object obj in this.FilterableUniqueValues)
				{
					global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
					foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate2 in xamGridFilterDate.Children)
					{
						foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate3 in xamGridFilterDate2.Children)
						{
							if (xamGridFilterDate3.Children.Count > 0)
							{
								foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate4 in xamGridFilterDate3.Children)
								{
									foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate5 in xamGridFilterDate4.Children)
									{
										foreach (global::Infragistics.Controls.Grids.XamGridFilterDate date in xamGridFilterDate5.Children)
										{
											this.ResetIsChecked(date, isChecked);
											num++;
										}
										this.ResetIsChecked(xamGridFilterDate5, isChecked);
										num++;
									}
									this.ResetIsChecked(xamGridFilterDate4, isChecked);
									num++;
								}
							}
							this.ResetIsChecked(xamGridFilterDate3, isChecked);
							num++;
						}
						this.ResetIsChecked(xamGridFilterDate2, isChecked);
						num++;
					}
					this.ResetIsChecked(xamGridFilterDate, isChecked);
					num++;
				}
			}
			if (isChecked)
			{
				base.CheckedCount = num;
				base.UncheckedCount = 0;
				return;
			}
			base.UncheckedCount = num;
			base.CheckedCount = 0;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001A328 File Offset: 0x00018528
		private void SynchornizeCachedValue(global::Infragistics.Controls.Grids.XamGridFilterDate date, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.XamGridFilterDate> changedValues)
		{
			foreach (object obj in this.CachedFlatUniqueValues)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
				if (date.NullDate && xamGridFilterDate.NullDate)
				{
					if (!(xamGridFilterDate.IsChecked != date.IsChecked))
					{
						break;
					}
					if (xamGridFilterDate.IsChecked == true)
					{
						this.CachedCheckedCount--;
					}
					else
					{
						this.CachedUncheckedCount--;
					}
					xamGridFilterDate.IsChecked = date.IsChecked;
					changedValues.Add(xamGridFilterDate);
					if (xamGridFilterDate.IsChecked == true)
					{
						this.CachedCheckedCount++;
						break;
					}
					this.CachedUncheckedCount++;
					break;
				}
				else if (date.DateFilterObjectType == xamGridFilterDate.DateFilterObjectType && date.Date == xamGridFilterDate.Date)
				{
					if (!(xamGridFilterDate.IsChecked != date.IsChecked))
					{
						break;
					}
					if (xamGridFilterDate.IsChecked == true)
					{
						this.CachedCheckedCount--;
					}
					else
					{
						this.CachedUncheckedCount--;
					}
					xamGridFilterDate.IsChecked = date.IsChecked;
					changedValues.Add(xamGridFilterDate);
					if (xamGridFilterDate.IsChecked == true)
					{
						this.CachedCheckedCount++;
						break;
					}
					this.CachedUncheckedCount++;
					break;
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001A55C File Offset: 0x0001875C
		private void ProcessChanges(int checkedCount, int uncheckedCount, global::System.Collections.IEnumerable list)
		{
			global::Infragistics.Controls.Grids.CellBase cell = base.Cell;
			string key = cell.Column.Key;
			global::Infragistics.Controls.Grids.RowsManager rowsManager = cell.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[key];
			if (rowsFilter == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.Column column = base.Cell.Column;
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			if (checkedCount > uncheckedCount || checkedCount == 0)
			{
				using (global::System.Collections.IEnumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
						if (xamGridFilterDate.NullDate)
						{
							base.ApplyFilterForItem(null, xamGridFilterDate.IsChecked == true, column, columnLayout, rowsManager, rowsFilter, true);
						}
						else
						{
							foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate2 in xamGridFilterDate.Children)
							{
								foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate3 in xamGridFilterDate2.Children)
								{
									if (this._addTime)
									{
										using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridFilterDate>.Enumerator enumerator4 = xamGridFilterDate3.Children.GetEnumerator())
										{
											while (enumerator4.MoveNext())
											{
												global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate4 = enumerator4.Current;
												foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate5 in xamGridFilterDate4.Children)
												{
													foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate6 in xamGridFilterDate5.Children)
													{
														if (xamGridFilterDate6 != null && xamGridFilterDate6.IsChecked != null)
														{
															base.ApplyFilterForItem(xamGridFilterDate6.Date, xamGridFilterDate6.IsChecked.Value, column, columnLayout, rowsManager, rowsFilter, true);
														}
													}
												}
											}
											continue;
										}
									}
									if (xamGridFilterDate3 != null && xamGridFilterDate3.IsChecked != null)
									{
										base.ApplyFilterForItem(xamGridFilterDate3.Date, xamGridFilterDate3.IsChecked.Value, column, columnLayout, rowsManager, rowsFilter, true);
									}
								}
							}
						}
					}
					return;
				}
			}
			foreach (object obj2 in list)
			{
				global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate7 = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj2;
				if (xamGridFilterDate7.NullDate)
				{
					base.ApplyNegativeFilterForItem(null, xamGridFilterDate7.IsChecked == true, column, columnLayout, rowsManager, rowsFilter, true);
				}
				else
				{
					foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate8 in xamGridFilterDate7.Children)
					{
						foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate9 in xamGridFilterDate8.Children)
						{
							if (this._addTime)
							{
								using (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.XamGridFilterDate>.Enumerator enumerator10 = xamGridFilterDate9.Children.GetEnumerator())
								{
									while (enumerator10.MoveNext())
									{
										global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate10 = enumerator10.Current;
										foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate11 in xamGridFilterDate10.Children)
										{
											foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate12 in xamGridFilterDate11.Children)
											{
												if (xamGridFilterDate12 != null && xamGridFilterDate12.IsChecked != null)
												{
													base.ApplyNegativeFilterForItem(xamGridFilterDate12.Date, xamGridFilterDate12.IsChecked.Value, column, columnLayout, rowsManager, rowsFilter, true);
												}
											}
										}
									}
									continue;
								}
							}
							if (xamGridFilterDate9 != null && xamGridFilterDate9.IsChecked != null)
							{
								base.ApplyNegativeFilterForItem(xamGridFilterDate9.Date, xamGridFilterDate9.IsChecked.Value, column, columnLayout, rowsManager, rowsFilter, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001AB10 File Offset: 0x00018D10
		private void UniqueValue_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate = (global::Infragistics.Controls.Grids.XamGridFilterDate)sender;
			if (e.PropertyName == "IsChecked")
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				foreach (object obj in this.FilterableUniqueValues)
				{
					global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate2 = (global::Infragistics.Controls.Grids.XamGridFilterDate)obj;
					if (xamGridFilterDate2.IsChecked == true)
					{
						flag = true;
					}
					else if (xamGridFilterDate2.IsChecked == false)
					{
						flag2 = true;
					}
					else if (xamGridFilterDate2.IsChecked == null)
					{
						flag3 = true;
					}
					if ((flag && flag2) || (flag && flag3) || (flag2 && flag3))
					{
						break;
					}
				}
				if (xamGridFilterDate.IsChecked == true)
				{
					base.UncheckedCount--;
					base.CheckedCount++;
				}
				else
				{
					base.UncheckedCount++;
					base.CheckedCount--;
				}
				bool? selectAllCheckBox;
				if ((flag && flag2) || (flag && flag3) || (flag2 && flag3))
				{
					selectAllCheckBox = null;
				}
				else if (flag)
				{
					selectAllCheckBox = new bool?(true);
				}
				else if (flag2)
				{
					selectAllCheckBox = new bool?(false);
				}
				else
				{
					selectAllCheckBox = null;
				}
				this.SetSelectAllCheckBox(selectAllCheckBox);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0001AC98 File Offset: 0x00018E98
		protected override void OnUniqueValuesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("FilterableUniqueValues");
			this.EnsureCurrentState();
		}

		// Token: 0x0400016C RID: 364
		private bool _addTime;

		// Token: 0x0400016D RID: 365
		private bool _cacheCount = true;

		// Token: 0x0400016E RID: 366
		private bool _boolBuildCachedList = true;

		// Token: 0x0400016F RID: 367
		private global::Infragistics.Controls.Grids.Primitives.FilterItemCollection _cachedFlatUniqueValues;

		// Token: 0x04000170 RID: 368
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject> _dateFilterTypeList;

		// Token: 0x04000171 RID: 369
		public static readonly global::System.Windows.DependencyProperty DateFilterObjectTypeItemProperty = global::System.Windows.DependencyProperty.Register("DateFilterObjectTypeItem", typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject), typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterObjectTypeItemChanged)));

		// Token: 0x04000172 RID: 370
		public static readonly global::System.Windows.DependencyProperty DateFilterHierarchicalDataTemplateProperty = global::System.Windows.DependencyProperty.Register("DateFilterHierarchicalDataTemplate", typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterHierarchicalDataTemplate), typeof(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl.DateFilterHierarchicalDataTemplateChanged)));
	}
}
