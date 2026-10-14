using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000020 RID: 32
	public class DataManager<T> : global::Infragistics.DataManagerBase
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000B322 File Offset: 0x00009522
		public DataManager()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000B32A File Offset: 0x0000952A
		public DataManager(global::System.Collections.Generic.IEnumerable<T> dataSource) : this()
		{
			this.SetDataSource(dataSource);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000B33C File Offset: 0x0000953C
		public override void RefreshSummaries()
		{
			this._needSummary = true;
			this._needSort = true;
			this._needPaging = (base.EnablePaging && base.PageSize > 0);
			this._needFiltering = true;
			this._needGroupBy = (base.GroupByObject != null);
			base.SummaryResultCollection.Clear();
			this.ApplyClientDataManipulations(false);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000B3AC File Offset: 0x000095AC
		protected override void SetDataSource(global::System.Collections.IEnumerable source)
		{
			if (source != null)
			{
				global::System.Collections.Generic.IEnumerable<T> enumerable = source as global::System.Collections.Generic.IEnumerable<T>;
				if (enumerable == null)
				{
					if (source is global::System.Windows.Data.CollectionView)
					{
						this._dataSource = (from object i in source
						where i != global::System.Windows.Data.CollectionView.NewItemPlaceholder
						select i).Cast<T>();
					}
					else
					{
						this._dataSource = source.Cast<T>();
					}
				}
				else
				{
					this._dataSource = enumerable;
				}
				base.OriginalDataSource = source;
			}
			else
			{
				this._dataSource = null;
				base.OriginalDataSource = null;
			}
			base.SetDataSource(this._dataSource);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000B43B File Offset: 0x0000963B
		protected override global::System.Collections.IEnumerable GetDataSource()
		{
			return this._dataSource;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000B444 File Offset: 0x00009644
		protected override object ResolveRecord(int recordIndex)
		{
			global::System.Linq.IQueryable<T> source = this._dataSource.AsQueryable<T>();
			return source.Skip(recordIndex).Take(1).ToList<T>()[0];
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000B480 File Offset: 0x00009680
		protected override int ResolveCount()
		{
			if (base.IListData != null)
			{
				return base.IListData.Count;
			}
			return (from a in this._dataSource
			select a).Count<T>();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000B4D0 File Offset: 0x000096D0
		protected internal override void OnResolvingData(global::Infragistics.DataAcquisitionEventArgs args)
		{
			base.OnResolvingData(args);
			if (args != null)
			{
				args.Handled = (args.DataSource != null);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000B4F0 File Offset: 0x000096F0
		protected override void ClearCachedDataSource(bool invalidateTotalRowCount)
		{
			this._cachedFilterSortedList = null;
			global::System.Collections.IList sortedFilteredDataSource = base.SortedFilteredDataSource;
			base.ClearCachedDataSource(invalidateTotalRowCount);
			if (sortedFilteredDataSource != null && base.SortedFilteredDataSource == null && !base.Defer)
			{
				this.OnDataUpdated();
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000B52C File Offset: 0x0000972C
		protected override void OnDataSourceCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (base.ICollectionViewData != null)
			{
				this.TotalRecordCount = -1;
				this.RecordCount = -1;
				this.OnCollectionChanged(e);
				if (base.ICollectionViewData.Groups != null)
				{
					this.ApplyServerGrouping();
				}
				if (!base.Defer && base.ICollectionViewData.Groups == null)
				{
					base.OnDataSourceCollectionChanged(e);
				}
				else
				{
					if (base.IPagedCollectionViewData != null)
					{
						this.ApplyServerPaging();
					}
					this.ApplyClientDataManipulations();
					this.OnDataUpdated();
				}
				base.Defer = false;
				return;
			}
			base.OnDataSourceCollectionChanged(e);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000B5B4 File Offset: 0x000097B4
		protected override void ResolveFilteredSortedPagedDataSource()
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool needPaging = false;
			bool flag9 = false;
			if (base.SummaryResultCollection != null)
			{
				base.SummaryResultCollection.Clear();
			}
			if (base.ICollectionViewData != null && base.AllowCollectionViewOverrides)
			{
				flag = base.ICollectionViewData.CanSort;
				flag4 = (flag5 = base.ICollectionViewData.CanGroup);
				if (flag)
				{
					global::System.ComponentModel.SortDescriptionCollection sortDescriptions = base.ICollectionViewData.SortDescriptions;
					int num = base.Sort.Count + ((base.GroupBySortContext != null) ? 1 : 0);
					num += base.MergeDataContexts.Count;
					if (sortDescriptions.Count != num)
					{
						flag6 = true;
					}
					else
					{
						int num2 = 0;
						if (base.GroupBySortContext != null)
						{
							global::System.ComponentModel.SortDescription sortDescription = sortDescriptions[0];
							bool flag10 = sortDescription.Direction == global::System.ComponentModel.ListSortDirection.Ascending;
							bool sortAscending = base.GroupBySortContext.SortAscending;
							if (flag10 != sortAscending || sortDescription.PropertyName != base.GroupBySortContext.SortPropertyName)
							{
								flag6 = true;
							}
							num2 = 1;
						}
						foreach (global::Infragistics.MergedDataContext mergedDataContext in base.MergeDataContexts)
						{
							global::System.ComponentModel.SortDescription sortDescription2 = sortDescriptions[num2];
							bool flag11 = sortDescription2.Direction == global::System.ComponentModel.ListSortDirection.Ascending;
							bool sortAscending2 = mergedDataContext.SortContext.SortAscending;
							if (flag11 != sortAscending2 || sortDescription2.PropertyName != mergedDataContext.SortContext.SortPropertyName)
							{
								flag6 = true;
							}
							num2++;
						}
						int count = base.Sort.Count;
						for (int i = 0; i < count; i++)
						{
							global::Infragistics.SortContext sortContext = base.Sort[i];
							global::System.ComponentModel.SortDescription sortDescription3 = sortDescriptions[i + num2];
							bool flag12 = sortDescription3.Direction == global::System.ComponentModel.ListSortDirection.Ascending;
							bool sortAscending3 = sortContext.SortAscending;
							if (sortAscending3 != flag12 || sortDescription3.PropertyName != sortContext.SortPropertyName)
							{
								flag6 = true;
								break;
							}
						}
					}
				}
				if (flag4)
				{
					if (base.GroupByObject != null)
					{
						if (base.ICollectionViewData.GroupDescriptions.Count == 0 || ((global::System.Windows.Data.PropertyGroupDescription)base.ICollectionViewData.GroupDescriptions[0]).PropertyName != base.GroupByObject.PropertyName)
						{
							flag7 = true;
						}
					}
					else if (base.ICollectionViewData.GroupDescriptions != null && base.ICollectionViewData.GroupDescriptions.Count > 0 && base.MergeDataContexts.Count == 0)
					{
						flag7 = true;
					}
				}
				if (flag5 && base.GroupByObject == null)
				{
					if (base.SummariesDirty && base.MergeDataContexts.Count > 0)
					{
						flag9 = true;
					}
					else if (base.MergeDataContexts.Count != base.ICollectionViewData.GroupDescriptions.Count)
					{
						flag9 = true;
					}
					else
					{
						int num3 = 0;
						foreach (global::Infragistics.MergedDataContext mergedDataContext2 in base.MergeDataContexts)
						{
							global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription = base.ICollectionViewData.GroupDescriptions[num3] as global::System.Windows.Data.PropertyGroupDescription;
							if (propertyGroupDescription == null || mergedDataContext2.PropertyName != propertyGroupDescription.PropertyName)
							{
								flag9 = true;
								break;
							}
							num3++;
						}
					}
				}
			}
			if (base.IFilteredCollectionViewData != null && base.Filters != null)
			{
				flag2 = base.IFilteredCollectionViewData.CanFilter;
				if (flag2 && base.Filters.Count == 0 && base.IFilteredCollectionViewData.FilterConditions != null && base.IFilteredCollectionViewData.FilterConditions.Count > 0)
				{
					flag8 = true;
				}
			}
			if (base.IPagedCollectionViewData != null)
			{
				flag3 = true;
			}
			if (flag6 || flag7 || flag8 || flag9)
			{
				if (flag6 && !flag7 && !flag8 && base.Sort.Count == 0 && base.GroupBySortContext == null && base.MergeDataContexts.Count == 0)
				{
					base.Defer = true;
					base.ICollectionViewData.SortDescriptions.Clear();
				}
				else
				{
					using (base.ICollectionViewData.DeferRefresh())
					{
						if (flag6)
						{
							base.ICollectionViewData.SortDescriptions.Clear();
							int count2 = base.Sort.Count;
							if (count2 != 0 || base.GroupBySortContext != null || base.MergeDataContexts.Count > 0)
							{
								int num4 = 0;
								if (base.GroupBySortContext != null)
								{
									base.ICollectionViewData.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(base.GroupBySortContext.SortPropertyName, base.GroupBySortContext.SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending));
								}
								else
								{
									if (base.MergeDataContexts.Count > 0)
									{
										using (global::System.Collections.Generic.List<global::Infragistics.MergedDataContext>.Enumerator enumerator = base.MergeDataContexts.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												global::Infragistics.MergedDataContext mergedDataContext3 = enumerator.Current;
												base.ICollectionViewData.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(mergedDataContext3.SortContext.SortPropertyName, mergedDataContext3.SortContext.SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending));
											}
											goto IL_529;
										}
									}
									base.ICollectionViewData.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(base.Sort[0].SortPropertyName, base.Sort[0].SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending));
									num4 = 1;
								}
								IL_529:
								for (int j = num4; j < count2; j++)
								{
									base.ICollectionViewData.SortDescriptions.Add(new global::System.ComponentModel.SortDescription(base.Sort[j].SortPropertyName, base.Sort[j].SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending));
								}
							}
						}
						this._needFiltering = false;
						if (flag7)
						{
							if (base.GroupByObject != null)
							{
								base.ICollectionViewData.GroupDescriptions.Clear();
								base.ICollectionViewData.GroupDescriptions.Add(new global::System.Windows.Data.PropertyGroupDescription(base.GroupByObject.PropertyName));
							}
							else
							{
								base.ICollectionViewData.GroupDescriptions.Clear();
							}
						}
						if (flag9)
						{
							base.ICollectionViewData.GroupDescriptions.Clear();
							foreach (global::Infragistics.MergedDataContext mergedDataContext4 in base.MergeDataContexts)
							{
								base.ICollectionViewData.GroupDescriptions.Add(new global::System.Windows.Data.PropertyGroupDescription(mergedDataContext4.PropertyName));
							}
						}
						base.Defer = true;
					}
				}
				flag8 = (flag6 = (flag7 = false));
			}
			bool flag13 = false;
			if (!flag && base.IBindingLisViewtData != null && base.IBindingLisViewtData.SupportsSorting && base.CachedTypedInfo.PropertyDescriptors != null && base.CachedTypedInfo.PropertyDescriptors.Count > 0)
			{
				flag = true;
				global::System.ComponentModel.ListSortDescriptionCollection sortDescriptions2 = base.IBindingLisViewtData.SortDescriptions;
				int num5 = base.Sort.Count + ((base.GroupBySortContext != null) ? 1 : 0);
				num5 += base.MergeDataContexts.Count;
				if (sortDescriptions2.Count != num5)
				{
					flag6 = true;
				}
				else
				{
					int num6 = 0;
					if (base.GroupBySortContext != null)
					{
						global::System.ComponentModel.ListSortDescription listSortDescription = sortDescriptions2[0];
						bool flag14 = listSortDescription.SortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
						bool sortAscending4 = base.GroupBySortContext.SortAscending;
						if (flag14 != sortAscending4 || listSortDescription.PropertyDescriptor.Name != base.GroupBySortContext.SortPropertyName)
						{
							flag6 = true;
						}
						num6 = 1;
					}
					foreach (global::Infragistics.MergedDataContext mergedDataContext5 in base.MergeDataContexts)
					{
						global::System.ComponentModel.ListSortDescription listSortDescription2 = sortDescriptions2[num6];
						bool flag15 = listSortDescription2.SortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
						bool sortAscending5 = mergedDataContext5.SortContext.SortAscending;
						if (flag15 != sortAscending5 || listSortDescription2.PropertyDescriptor.Name != mergedDataContext5.SortContext.SortPropertyName)
						{
							flag6 = true;
						}
						num6++;
					}
					int count3 = base.Sort.Count;
					for (int k = 0; k < count3; k++)
					{
						global::Infragistics.SortContext sortContext2 = base.Sort[k];
						global::System.ComponentModel.ListSortDescription listSortDescription3 = sortDescriptions2[k + num6];
						bool flag16 = listSortDescription3.SortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
						bool sortAscending6 = sortContext2.SortAscending;
						if (sortAscending6 != flag16 || listSortDescription3.PropertyDescriptor.Name != sortContext2.SortPropertyName)
						{
							flag6 = true;
							break;
						}
					}
				}
				if (flag6 && !base.DataType.Name.Equals("DataRowView"))
				{
					global::System.ComponentModel.ListSortDescriptionCollection sortDescriptions3 = base.IBindingLisViewtData.SortDescriptions;
					int count4 = sortDescriptions3.Count;
					for (int l = 0; l < count4; l++)
					{
						bool defer = base.Defer;
						base.Defer = true;
						base.IBindingLisViewtData.RemoveSort();
						base.Defer = defer;
					}
					global::Infragistics.CachedTypedInfo cachedTypedInfo = base.CachedTypedInfo;
					global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor> list = new global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor>();
					foreach (global::Infragistics.SortContext sortContext3 in base.Sort)
					{
						global::System.ComponentModel.PropertyDescriptor propertyDescriptor = cachedTypedInfo.PropertyDescriptors[sortContext3.SortPropertyName];
						if (propertyDescriptor != null)
						{
							list.Add(propertyDescriptor);
						}
					}
					int count5 = list.Count;
					global::System.ComponentModel.ListSortDescription[] array = null;
					if (count5 != 0 || base.GroupBySortContext != null || base.MergeDataContexts.Count > 0)
					{
						int num7 = 0;
						int num8 = 0;
						if (base.GroupBySortContext != null)
						{
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 = cachedTypedInfo.PropertyDescriptors[base.GroupBySortContext.SortPropertyName];
							if (propertyDescriptor2 != null)
							{
								array = new global::System.ComponentModel.ListSortDescription[count5 + 1];
								array[0] = new global::System.ComponentModel.ListSortDescription(propertyDescriptor2, base.GroupBySortContext.SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending);
								num8 = 1;
							}
							else
							{
								array = new global::System.ComponentModel.ListSortDescription[count5];
							}
						}
						else if (base.MergeDataContexts.Count > 0)
						{
							global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor> list2 = new global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor>();
							foreach (global::Infragistics.MergedDataContext mergedDataContext6 in base.MergeDataContexts)
							{
								global::System.ComponentModel.PropertyDescriptor propertyDescriptor3 = cachedTypedInfo.PropertyDescriptors[mergedDataContext6.SortContext.SortPropertyName];
								if (propertyDescriptor3 != null)
								{
									list2.Add(propertyDescriptor3);
								}
							}
							array = new global::System.ComponentModel.ListSortDescription[count5 + list2.Count];
							for (int m = 0; m < base.MergeDataContexts.Count; m++)
							{
								global::Infragistics.MergedDataContext mergedDataContext7 = base.MergeDataContexts[m];
								if (mergedDataContext7.SortContext.SortPropertyName == list2[m].Name)
								{
									array[m] = new global::System.ComponentModel.ListSortDescription(list2[m], mergedDataContext7.SortContext.SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending);
								}
							}
							num8 = list2.Count;
						}
						else
						{
							array = new global::System.ComponentModel.ListSortDescription[count5];
							array[num7] = new global::System.ComponentModel.ListSortDescription(list[num7], base.Sort[0].SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending);
							num7 = 1;
						}
						for (int n = num7; n < base.Sort.Count; n++)
						{
							global::Infragistics.SortContext sortContext4 = base.Sort[n];
							if (sortContext4.SortPropertyName == list[n].Name)
							{
								array[n + num8] = new global::System.ComponentModel.ListSortDescription(list[n], sortContext4.SortAscending ? global::System.ComponentModel.ListSortDirection.Ascending : global::System.ComponentModel.ListSortDirection.Descending);
							}
						}
					}
					if (array != null)
					{
						bool defer2 = base.Defer;
						base.Defer = true;
						flag8 = (flag6 = (flag7 = false));
						base.IBindingLisViewtData.ApplySort(new global::System.ComponentModel.ListSortDescriptionCollection(array));
						flag13 = true;
						base.Defer = defer2;
					}
				}
			}
			if (flag3 && !base.Defer)
			{
				this.ApplyServerPaging();
				needPaging = (base.Defer = base.IPagedCollectionViewData.IsPageChanging);
			}
			if (!base.SupportsDataManipulations)
			{
				flag6 = false;
			}
			else if (base.IPagedCollectionViewData == null && base.IFilteredCollectionViewData == null && base.ICollectionViewData == null)
			{
				global::Infragistics.DataAcquisitionEventArgs dataAcquisitionEventArgs = new global::Infragistics.DataAcquisitionEventArgs
				{
					CurrentPage = base.CurrentPage,
					EnablePaging = base.EnablePaging,
					PageSize = base.PageSize,
					CurrentSort = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SortContext>(),
					GroupByContext = base.GroupByObject,
					Filters = base.Filters
				};
				foreach (global::Infragistics.SortContext item in base.Sort)
				{
					dataAcquisitionEventArgs.CurrentSort.Add(item);
				}
				this.OnResolvingData(dataAcquisitionEventArgs);
				if (dataAcquisitionEventArgs.Handled)
				{
					this.SetSortedFilteredDataSource(dataAcquisitionEventArgs.DataSource);
					this.OnDataUpdated();
					return;
				}
			}
			if (!flag)
			{
				flag6 = (base.Sort.Count > 0 || base.GroupByObject != null || base.MergeDataContexts.Count > 0);
			}
			if (!flag2 && (!flag4 || (flag4 && base.GroupByObject == null)))
			{
				flag8 = (base.Filters != null && base.Filters.Count > 0);
			}
			if (!flag4)
			{
				flag7 = (base.GroupByObject != null);
			}
			if (!flag3)
			{
				needPaging = (base.EnablePaging && base.PageSize > 0);
			}
			this._needSummary = (base.Summaries != null && base.Summaries.Count > 0);
			this._needConditionalFormat = (base.ConditionalFormattingRules != null && base.ConditionalFormattingRules.Count > 0);
			if (!base.SupportsDataManipulations)
			{
				flag6 = false;
			}
			this._needFiltering = flag8;
			this._needGroupBy = flag7;
			this._needSort = flag6;
			this._needPaging = needPaging;
			this._needMerge = flag9;
			if (base.MergeDataContexts.Count > 0 && !flag5)
			{
				this._needMerge = true;
				this._needSort = true;
			}
			if (!base.Defer)
			{
				bool setSortedFilteredDataSource = base.UpdateDataSource;
				if (flag4 && (base.MergeDataContexts.Count > 0 || (base.ICollectionViewData.Groups != null && base.ICollectionViewData.Groups.Count > 0)))
				{
					this.ApplyServerGrouping();
					setSortedFilteredDataSource = false;
				}
				if (!this.ApplyClientDataManipulations(setSortedFilteredDataSource) && flag13)
				{
					this.OnDataUpdated();
				}
			}
			base.SummariesDirty = false;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000C48C File Offset: 0x0000A68C
		internal override int? ResolveIndexForInsertOrDelete(object data, bool isAdding)
		{
			if (base.IsSortedFilteredDataSourceCalculated && base.IsSorted && this._multiSortComparer != null)
			{
				global::System.Collections.Generic.List<T> list = base.SortedFilteredDataSource as global::System.Collections.Generic.List<T>;
				if (list != null && data is T)
				{
					return this.ResolveIndexForInsertOrDelete(list, (T)((object)data), isAdding);
				}
			}
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		private int? ResolveIndexForInsertOrDelete(global::System.Collections.Generic.List<T> list, T data, bool isAdding)
		{
			int? result = null;
			if (base.IsSortedFilteredDataSourceCalculated && base.IsSorted && this._multiSortComparer != null)
			{
				int num = list.BinarySearch(data, this._multiSortComparer);
				if (isAdding)
				{
					if (num < 0)
					{
						result = new int?(~num);
					}
				}
				else
				{
					bool flag = false;
					if (num < 0)
					{
						int count = list.Count;
						int num2 = ~num;
						int num3 = num2 - 1;
						int num4 = num2 + 1;
						bool flag2 = false;
						bool flag3 = false;
						while (!flag2 || !flag3)
						{
							if (num3 < 0)
							{
								flag2 = true;
							}
							else
							{
								object obj = list[num3];
								object obj2 = data;
								if (obj == obj2)
								{
									num = num3;
									flag = true;
									break;
								}
								num3--;
							}
							if (num4 >= count)
							{
								flag3 = true;
							}
							else
							{
								object obj3 = list[num4];
								object obj4 = data;
								if (obj3 == obj4)
								{
									num = num4;
									flag = true;
									break;
								}
								num4++;
							}
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						result = new int?(num);
					}
				}
			}
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		internal override bool UpdateCachedDataManipulations(object item, bool isAdding)
		{
			bool result = base.UpdateCachedDataManipulations(item, isAdding);
			if (this._cachedFilterSortedList != null && this._multiSortComparer != null && item is T)
			{
				bool flag = false;
				T t = (T)((object)item);
				int? num = this.ResolveIndexForInsertOrDelete(this._cachedFilterSortedList, t, isAdding);
				if (num != null)
				{
					if (isAdding)
					{
						this._cachedFilterSortedList.Insert(num.Value, t);
					}
					else
					{
						this._cachedFilterSortedList.RemoveAt(num.Value);
					}
					flag = true;
					result = true;
				}
				if (flag)
				{
					this._needSort = true;
					this._needPaging = true;
					this._needFiltering = true;
					this.ApplyClientDataManipulations(true);
				}
			}
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000C684 File Offset: 0x0000A884
		internal override global::System.Collections.IList FilterItems(global::System.Collections.IList items)
		{
			global::System.Linq.IQueryable<T> queryable = items.OfType<T>().AsQueryable<T>();
			queryable = this.ApplyFilter(queryable);
			return queryable.ToList<T>();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		internal override global::System.Collections.IList FilterItems(global::System.Collections.IEnumerable items, global::Infragistics.RecordFilterCollection filtersToUse)
		{
			global::System.Linq.IQueryable<T> source = items.OfType<T>().AsQueryable<T>();
			if (filtersToUse != null && filtersToUse.Count > 0)
			{
				global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(base.CachedTypedInfo, null, false, false);
				global::System.Linq.Expressions.Expression currentExpression = ((global::Infragistics.IExpressConditions)filtersToUse).GetCurrentExpression(context);
				if (currentExpression != null)
				{
					source = source.Where((global::System.Linq.Expressions.Expression<global::System.Func<T, bool>>)currentExpression);
				}
			}
			return source.ToList<T>();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000C6FE File Offset: 0x0000A8FE
		internal override global::System.Collections.IList SortedFilteredList
		{
			get
			{
				if (this._cachedFilterSortedList != null)
				{
					return this._cachedFilterSortedList;
				}
				return base.SortedFilteredList;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000C718 File Offset: 0x0000A918
		private global::System.Linq.IQueryable<T> ApplySort(global::System.Linq.IQueryable<T> query)
		{
			int count = base.Sort.Count;
			if (count == 0 && base.GroupBySortContext == null && base.MergeDataContexts.Count == 0)
			{
				return query;
			}
			global::System.Linq.IOrderedQueryable<T> orderedQueryable = null;
			global::System.Collections.Generic.List<global::Infragistics.SortContext> list = new global::System.Collections.Generic.List<global::Infragistics.SortContext>();
			if (base.GroupBySortContext != null)
			{
				orderedQueryable = base.GroupBySortContext.Sort<T>(query);
				list.Add(base.GroupBySortContext);
				if (count > 0)
				{
					orderedQueryable = base.Sort[0].AppendSort<T>(orderedQueryable);
					list.Add(base.Sort[0]);
				}
			}
			else if (base.MergeDataContexts.Count > 0)
			{
				int num = 0;
				foreach (global::Infragistics.MergedDataContext mergedDataContext in base.MergeDataContexts)
				{
					if (num == 0)
					{
						orderedQueryable = mergedDataContext.SortContext.Sort<T>(query);
					}
					else
					{
						orderedQueryable = mergedDataContext.SortContext.AppendSort<T>(orderedQueryable);
					}
					num++;
					list.Add(mergedDataContext.SortContext);
				}
				if (count > 0)
				{
					orderedQueryable = base.Sort[0].AppendSort<T>(orderedQueryable);
					list.Add(base.Sort[0]);
				}
			}
			else
			{
				orderedQueryable = base.Sort[0].Sort<T>(query);
				list.Add(base.Sort[0]);
			}
			for (int i = 1; i < count; i++)
			{
				orderedQueryable = base.Sort[i].AppendSort<T>(orderedQueryable);
				list.Add(base.Sort[i]);
			}
			this._multiSortComparer = new global::Infragistics.MultiSortComparer<T>(list, base.CachedTypedInfo);
			return orderedQueryable;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		private global::System.Linq.IQueryable<T> ApplyFilter(global::System.Linq.IQueryable<T> query)
		{
			if (base.Filters != null && base.Filters.Count > 0)
			{
				global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(base.CachedTypedInfo, null, false, false);
				global::System.Linq.Expressions.Expression currentExpression = ((global::Infragistics.IExpressConditions)base.Filters).GetCurrentExpression(context);
				if (currentExpression != null)
				{
					query = query.Where((global::System.Linq.Expressions.Expression<global::System.Func<T, bool>>)currentExpression);
				}
			}
			return query;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000C91C File Offset: 0x0000AB1C
		private void ApplySummary(global::System.Linq.IQueryable<T> query, global::Infragistics.SummaryExecution summaryExecution)
		{
			if (base.Summaries == null || base.SummaryResultCollection == null)
			{
				return;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition> definitionsBySummaryExecution = base.Summaries.GetDefinitionsBySummaryExecution(summaryExecution, summaryExecution == base.SummaryExecution);
			foreach (global::Infragistics.SummaryDefinition summaryDefinition in definitionsBySummaryExecution)
			{
				global::Infragistics.ISupportLinqSummaries supportLinqSummaries = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.ISupportLinqSummaries;
				if (supportLinqSummaries != null)
				{
					global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(base.CachedTypedInfo, summaryDefinition.ColumnKey, supportLinqSummaries.SummaryType);
					supportLinqSummaries.SummaryContext = summaryContext;
					base.SummaryResultCollection.Add(new global::Infragistics.SummaryResult(summaryDefinition, summaryContext.Execute(query)));
				}
				else
				{
					global::Infragistics.SynchronousSummaryCalculator synchronousSummaryCalculator = summaryDefinition.SummaryOperand.SummaryCalculator as global::Infragistics.SynchronousSummaryCalculator;
					if (synchronousSummaryCalculator != null)
					{
						base.SummaryResultCollection.Add(new global::Infragistics.SummaryResult(summaryDefinition, synchronousSummaryCalculator.Summarize(query, summaryDefinition.ColumnKey)));
					}
				}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000CA14 File Offset: 0x0000AC14
		private void ApplyServerPaging()
		{
			if (!base.IPagedCollectionViewData.IsPageChanging && base.IPagedCollectionViewData.TotalItemCount != -1)
			{
				int num = base.CurrentPage - 1;
				if (num != base.IPagedCollectionViewData.PageIndex && base.IPagedCollectionViewData.CanChangePage)
				{
					base.IPagedCollectionViewData.MoveToPage(num);
				}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000CA70 File Offset: 0x0000AC70
		private void ApplyServerGrouping()
		{
			if (base.ICollectionViewData.Groups != null)
			{
				if (base.MergeDataContexts.Count > 0)
				{
					global::Infragistics.MergedDataContext mdc = base.MergeDataContexts[0];
					global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo> list = new global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo>();
					this.BuildMergedGroupings(list, base.ICollectionViewData.Groups, new global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>(), mdc, new global::System.Collections.Generic.Dictionary<global::Infragistics.MergedColumnInfo, bool>());
					this.SetSortedFilteredDataSource(list);
					return;
				}
				global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext> list2 = new global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext>();
				foreach (object obj in base.ICollectionViewData.Groups)
				{
					global::System.Windows.Data.CollectionViewGroup collectionViewGroup = obj as global::System.Windows.Data.CollectionViewGroup;
					if (collectionViewGroup != null)
					{
						global::Infragistics.GroupByDataContext groupByDataContext = new global::Infragistics.GroupByDataContext();
						while (!collectionViewGroup.IsBottomLevel)
						{
							collectionViewGroup = (collectionViewGroup.Items[0] as global::System.Windows.Data.CollectionViewGroup);
						}
						groupByDataContext.Records = collectionViewGroup.Items;
						groupByDataContext.Value = collectionViewGroup.Name;
						list2.Add(groupByDataContext);
					}
				}
				this.SetSortedFilteredDataSource(list2);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private void GatherDataForConditionalFormatting(global::System.Linq.IQueryable<T> query, global::Infragistics.EvaluationStage stage)
		{
			if (base.ConditionalFormattingRules == null || base.ConditionalFormattingRules.Count == 0)
			{
				return;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.IRule> rulesForStage = base.ConditionalFormattingRules.GetRulesForStage(stage);
			if (rulesForStage.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.IRule rule in rulesForStage)
			{
				rule.GatherData(query);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		protected bool ApplyClientDataManipulations()
		{
			return this.ApplyClientDataManipulations(true);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		protected bool ApplyClientDataManipulations(bool setSortedFilteredDataSource)
		{
			bool flag = base.ICollectionViewData == null || base.ICollectionViewData.Groups == null || base.MergeDataContexts.Count > 0;
			if (flag && !base.SuspendInvalidateDataSource && (this._needSort || this._needMerge || this._needFiltering || this._needGroupBy || this._needPaging || this._needSummary || this._needConditionalFormat))
			{
				if (base.SummaryResultCollection != null)
				{
					base.SummaryResultCollection.Clear();
				}
				global::System.Collections.IList list = null;
				global::System.Linq.IQueryable<T> queryable = from item in this._dataSource.AsQueryable<T>()
				select item;
				this.ApplySummary(queryable, global::Infragistics.SummaryExecution.PriorToFilteringAndPaging);
				this.GatherDataForConditionalFormatting(queryable, global::Infragistics.EvaluationStage.PriorToFilteringAndPaging);
				global::System.Linq.IQueryable<T> queryable2 = queryable;
				global::System.Linq.IQueryable<global::Infragistics.GroupByDataContext> queryable3 = null;
				if (this._needFiltering)
				{
					queryable2 = this.ApplyFilter(queryable2);
				}
				base.IsSorted = false;
				if (this._needSort)
				{
					queryable2 = this.ApplySort(queryable2);
					base.IsSorted = true;
				}
				if (this._needGroupBy)
				{
					base.GroupByObject.Summaries = base.Summaries;
					list = base.GroupByObject.Group<T>(queryable2);
					queryable2 = null;
				}
				if (this._needMerge && base.MergeDataContexts.Count > 0)
				{
					list = base.MergeDataContexts[0].Merge(queryable2, base.MergeDataContexts, base.Summaries);
					queryable2 = null;
				}
				if (queryable2 != null)
				{
					this.ApplySummary(queryable2, global::Infragistics.SummaryExecution.AfterFilteringBeforePaging);
					this.GatherDataForConditionalFormatting(queryable2, global::Infragistics.EvaluationStage.AfterFilteringBeforePaging);
				}
				if (this._needPaging && base.IPagedCollectionViewData == null)
				{
					int num = this.TotalRecordCount;
					if (!this._needGroupBy && !this._needMerge)
					{
						if ((this._needSort || this._needFiltering) && this._cachedFilterSortedList == null)
						{
							this._cachedFilterSortedList = queryable2.ToList<T>();
						}
						if (this._needFiltering)
						{
							num = this._cachedFilterSortedList.Count;
						}
					}
					base.PageCount = (int)global::System.Math.Ceiling((double)num / (double)base.PageSize);
					int currentPage = base.CurrentPage;
					if (this._cachedFilterSortedList != null)
					{
						queryable2 = this._cachedFilterSortedList.Skip(base.PageSize * (currentPage - 1)).Take(base.PageSize).AsQueryable<T>();
					}
					else if (this._needGroupBy)
					{
						global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext> list2 = list as global::System.Collections.Generic.List<global::Infragistics.GroupByDataContext>;
						if (list2 != null)
						{
							base.PageCount = (int)global::System.Math.Ceiling((double)list.Count / (double)base.PageSize);
							currentPage = base.CurrentPage;
							queryable3 = list2.AsQueryable<global::Infragistics.GroupByDataContext>();
							queryable3 = queryable3.Skip(base.PageSize * (currentPage - 1)).Take(base.PageSize);
						}
					}
					else if (this._needMerge)
					{
						global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo> list3 = list as global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo>;
						if (list3 != null)
						{
							base.PageCount = (int)global::System.Math.Ceiling((double)list.Count / (double)base.PageSize);
							currentPage = base.CurrentPage;
							global::System.Linq.IQueryable<global::Infragistics.MergedRowInfo> source = list3.AsQueryable<global::Infragistics.MergedRowInfo>();
							source = source.Skip(base.PageSize * (currentPage - 1)).Take(base.PageSize);
							list = source.ToList<global::Infragistics.MergedRowInfo>();
						}
					}
					else
					{
						queryable2 = queryable2.Skip(base.PageSize * (currentPage - 1)).Take(base.PageSize);
					}
				}
				if (queryable3 != null)
				{
					list = queryable3.ToList<global::Infragistics.GroupByDataContext>();
				}
				else if (queryable2 != null)
				{
					this.ApplySummary(queryable2, global::Infragistics.SummaryExecution.AfterFilteringAndPaging);
					this.GatherDataForConditionalFormatting(queryable2, global::Infragistics.EvaluationStage.AfterFilteringAndPaging);
					list = queryable2.ToList<T>();
				}
				if (setSortedFilteredDataSource)
				{
					this.SetSortedFilteredDataSource(list);
					this.OnDataUpdated();
				}
				this._needSummary = (this._needSort = (this._needFiltering = (this._needGroupBy = (this._needPaging = (this._needMerge = false)))));
				return true;
			}
			return false;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		private global::System.Collections.Generic.List<object> BuildMergedGroupings(global::System.Collections.Generic.List<global::Infragistics.MergedRowInfo> mris, global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> groups, global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo> mcis, global::Infragistics.MergedDataContext mdc, global::System.Collections.Generic.Dictionary<global::Infragistics.MergedColumnInfo, bool> lastMciLookup)
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			int num = 0;
			int count = groups.Count;
			foreach (object obj in groups)
			{
				bool flag = num == count - 1;
				global::System.Windows.Data.CollectionViewGroup collectionViewGroup = obj as global::System.Windows.Data.CollectionViewGroup;
				if (collectionViewGroup != null)
				{
					global::Infragistics.MergedColumnInfo mergedColumnInfo = new global::Infragistics.MergedColumnInfo
					{
						Key = collectionViewGroup.Name,
						Summaries = base.Summaries,
						TypedInfo = base.CachedTypedInfo
					};
					if (mcis.Count > 0)
					{
						mergedColumnInfo.ParentMergedColumnInfo = mcis[mcis.Count - 1];
					}
					mergedColumnInfo.DataType = base.CachedType;
					global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo> list2 = new global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>(mcis);
					list2.Add(mergedColumnInfo);
					mergedColumnInfo.MergingObject = mdc.MergedObject;
					global::Infragistics.MergedDataContext mdc2 = null;
					int num2 = base.MergeDataContexts.IndexOf(mdc);
					if (num2 != base.MergeDataContexts.Count - 1)
					{
						mdc2 = base.MergeDataContexts[num2 + 1];
					}
					if (mergedColumnInfo.ParentMergedColumnInfo != null)
					{
						if (lastMciLookup.ContainsKey(mergedColumnInfo.ParentMergedColumnInfo))
						{
							lastMciLookup[mergedColumnInfo.ParentMergedColumnInfo] = flag;
						}
						else
						{
							lastMciLookup.Add(mergedColumnInfo.ParentMergedColumnInfo, flag);
						}
					}
					global::System.Collections.Generic.List<object> list3 = this.BuildMergedGroupings(mris, collectionViewGroup.Items, list2, mdc2, lastMciLookup);
					list.AddRange(list3);
					mergedColumnInfo.Children = list3;
				}
				else
				{
					global::Infragistics.MergedRowInfo mergedRowInfo = new global::Infragistics.MergedRowInfo
					{
						Data = obj
					};
					foreach (global::Infragistics.MergedColumnInfo mergedColumnInfo2 in mcis)
					{
						if (flag)
						{
							if (lastMciLookup.ContainsKey(mergedColumnInfo2))
							{
								mergedRowInfo.IsLastRowInGroup.Add(mergedColumnInfo2.MergingObject, lastMciLookup[mergedColumnInfo2]);
							}
							else
							{
								mergedRowInfo.IsLastRowInGroup.Add(mergedColumnInfo2.MergingObject, true);
							}
						}
						else
						{
							mergedRowInfo.IsLastRowInGroup.Add(mergedColumnInfo2.MergingObject, false);
						}
					}
					mergedRowInfo.MergedGroups = mcis;
					mris.Add(mergedRowInfo);
					list.Add(obj);
				}
				num++;
			}
			return list;
		}

		// Token: 0x0400009D RID: 157
		private global::System.Collections.Generic.IEnumerable<T> _dataSource;

		// Token: 0x0400009E RID: 158
		private global::System.Collections.Generic.List<T> _cachedFilterSortedList;

		// Token: 0x0400009F RID: 159
		private bool _needSort;

		// Token: 0x040000A0 RID: 160
		private bool _needGroupBy;

		// Token: 0x040000A1 RID: 161
		private bool _needPaging;

		// Token: 0x040000A2 RID: 162
		private bool _needFiltering;

		// Token: 0x040000A3 RID: 163
		private bool _needSummary;

		// Token: 0x040000A4 RID: 164
		private bool _needConditionalFormat;

		// Token: 0x040000A5 RID: 165
		private bool _needMerge;

		// Token: 0x040000A6 RID: 166
		private global::Infragistics.MultiSortComparer<T> _multiSortComparer;
	}
}
