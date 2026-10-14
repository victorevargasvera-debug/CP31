using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000C4 RID: 196
	internal class LayoutInfo
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x00026048 File Offset: 0x00024248
		internal LayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
			this._info = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>();
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00026068 File Offset: 0x00024268
		private static void SetMaxValue(int[] arr, int startIndex, int count, int value)
		{
			int i = startIndex;
			int num = startIndex + count - 1;
			while (i <= num)
			{
				arr[i] = global::System.Math.Max(arr[i], value);
				i++;
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00026094 File Offset: 0x00024294
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo CalculatePositionOfNewField(global::Infragistics.Windows.DataPresenter.Field field)
		{
			int num;
			int num2;
			this.GetLogicalRowAndColumnCount(out num, out num2);
			int[] array = new int[num];
			int[] array2 = new int[num2];
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in this._info.Values)
			{
				global::Infragistics.Windows.DataPresenter.LayoutInfo.SetMaxValue(array, itemLayoutInfo.Column, itemLayoutInfo.ColumnSpan, itemLayoutInfo.Row + itemLayoutInfo.RowSpan - 1);
				global::Infragistics.Windows.DataPresenter.LayoutInfo.SetMaxValue(array2, itemLayoutInfo.Row, itemLayoutInfo.RowSpan, itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan - 1);
			}
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					if (j > array2[i] && i > array[j])
					{
						return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(j, i);
					}
				}
			}
			return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(num, 0);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0002618C File Offset: 0x0002438C
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo Clone()
		{
			return this.Clone(false);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00026198 File Offset: 0x00024398
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo Clone(bool excludeCollapsedEntries)
		{
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				if (!excludeCollapsedEntries || !keyValuePair.Value.IsCollapsed)
				{
					layoutInfo._info.Add(keyValuePair.Key, keyValuePair.Value.Clone());
				}
			}
			return layoutInfo;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00026220 File Offset: 0x00024420
		internal static global::Infragistics.Windows.DataPresenter.LayoutInfo Create(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(fieldLayout);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
			{
				if (field.IsVisibleInCellArea)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
					layoutInfo.Add(field, new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(gridPosition.Column, gridPosition.Row, gridPosition.ColumnSpan, gridPosition.RowSpan)
					{
						_fixedLocation = field.FixedLocation
					});
				}
			}
			return layoutInfo;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000262B4 File Offset: 0x000244B4
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal void DebugFixedLocations()
		{
			int column;
			int row;
			this.GetLogicalRowAndColumnCount(out column, out row);
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[,] array = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[column, row];
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (!value.IsCollapsed)
				{
					int i = value.Column;
					int num = i + value.ColumnSpan;
					while (i < num)
					{
						int j = value.Row;
						int num2 = j + value.RowSpan;
						while (j < num2)
						{
							array[i, j] = value;
							j++;
						}
						i++;
					}
				}
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			int length = array.GetLength(isHorizontal ? 1 : 0);
			int length2 = array.GetLength(isHorizontal ? 0 : 1);
			for (int k = 0; k < length; k++)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = null;
				for (int l = 0; l < length2; l++)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = isHorizontal ? array[l, k] : array[k, l];
					if (itemLayoutInfo2 != itemLayoutInfo)
					{
						if (itemLayoutInfo == null)
						{
							itemLayoutInfo = itemLayoutInfo2;
						}
					}
				}
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000263F8 File Offset: 0x000245F8
		internal bool DoesItemOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo ignoreItem)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.DoesItemOverlap(item, this._info.Values, ignoreItem);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0002640C File Offset: 0x0002460C
		private static bool DoesItemOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> items, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo ignoreItem)
		{
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in items)
			{
				if (itemLayoutInfo != item && itemLayoutInfo != ignoreItem && global::Infragistics.Windows.DataPresenter.LayoutInfo.DoItemsOverlap(itemLayoutInfo, item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00026468 File Offset: 0x00024668
		private static bool DoItemsOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo xx, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo yy)
		{
			return xx != null && yy != null && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(xx.Column, xx.ColumnSpan, yy.Column, yy.ColumnSpan) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(xx.Row, xx.RowSpan, yy.Row, yy.RowSpan);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000264BC File Offset: 0x000246BC
		internal void EnsureFixedLocationsDontOverlap()
		{
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(this._info.Values);
			list.Sort(new global::Infragistics.Windows.DataPresenter.LayoutInfo.FixedLocationComparer(isHorizontal));
			int num = 0;
			int num2 = -1;
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in list)
			{
				int num3 = isHorizontal ? itemLayoutInfo.Row : itemLayoutInfo.Column;
				if (fixedFieldLocation != itemLayoutInfo._fixedLocation)
				{
					fixedFieldLocation = itemLayoutInfo._fixedLocation;
					if (num3 < num2)
					{
						fixedFieldLocation = itemLayoutInfo._fixedLocation;
						num += num2 - num3;
					}
				}
				if (isHorizontal)
				{
					itemLayoutInfo.Row += num;
				}
				else
				{
					itemLayoutInfo.Column += num;
				}
				num2 = global::System.Math.Max(num2, isHorizontal ? (itemLayoutInfo.Row + itemLayoutInfo.RowSpan) : (itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan));
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000265C8 File Offset: 0x000247C8
		internal void EnsureFixedLocationsInSync()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				if (keyValuePair.Key.FixedLocation != keyValuePair.Value._fixedLocation)
				{
					list.Add(keyValuePair.Key);
				}
			}
			if (list.Count > 0)
			{
				global::System.Array values = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.DataPresenter.FixedFieldLocation));
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
				for (int i = 0; i < values.Length; i++)
				{
					for (int j = 0; j < values.Length; j++)
					{
						if (j != i)
						{
							global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation = (global::Infragistics.Windows.DataPresenter.FixedFieldLocation)values.GetValue(i);
							global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation2 = (global::Infragistics.Windows.DataPresenter.FixedFieldLocation)values.GetValue(j);
							list2.Clear();
							for (int k = list.Count - 1; k >= 0; k--)
							{
								global::Infragistics.Windows.DataPresenter.Field field = list[k];
								if (field.FixedLocation == fixedFieldLocation2 && this._info[field]._fixedLocation == fixedFieldLocation)
								{
									list.RemoveAt(k);
									list2.Add(field);
								}
							}
							if (list2.Count > 0)
							{
								this.UpdateFixedLocation(fixedFieldLocation, fixedFieldLocation2, list2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00026730 File Offset: 0x00024930
		internal void EnsureItemDoesntOverlap(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.EnsureItemDoesntOverlap(this[field], true, true, false);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00026742 File Offset: 0x00024942
		internal void EnsureItemDoesntOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, bool shiftRight, bool shiftBelow, bool shiftBelowFirst)
		{
			this.EnsureItemDoesntOverlapImpl(item, shiftRight, shiftBelow, shiftBelowFirst);
			this.EnsureFixedLocationsDontOverlap();
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00026758 File Offset: 0x00024958
		private void EnsureItemDoesntOverlapImpl(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, bool shiftRight, bool shiftBelow, bool shiftBelowFirst)
		{
			if (shiftRight && shiftBelow && shiftBelowFirst)
			{
				this.EnsureItemDoesntOverlap(item, false, true, false);
				this.EnsureItemDoesntOverlap(item, true, false, false);
				return;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(this._info.Values);
			if (shiftRight)
			{
				list.Sort(new global::Infragistics.Windows.DataPresenter.LayoutInfo.OriginComparer(false, item));
				int num = item.Row;
				int num2 = item.RowSpan;
				int num3 = 0;
				int num4 = list.IndexOf(item);
				for (int i = 1 + num4; i < list.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = list[i];
					if (global::Infragistics.Windows.DataPresenter.LayoutInfo.DoItemsOverlap(item, itemLayoutInfo))
					{
						num3 = global::System.Math.Max(num3, item.Column + item.ColumnSpan - itemLayoutInfo.Column);
					}
				}
				num3 = global::System.Math.Min(num3, item.ColumnSpan);
				if (num3 > 0)
				{
					for (int j = 1 + num4; j < list.Count; j++)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = list[j];
						if (itemLayoutInfo2._fixedLocation == item._fixedLocation && global::Infragistics.Windows.DataPresenter.LayoutInfo.DoesItemOverlap(itemLayoutInfo2, list, null) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(num, num2, itemLayoutInfo2.Row, itemLayoutInfo2.RowSpan))
						{
							int num5 = global::System.Math.Min(num, itemLayoutInfo2.Row);
							num2 = global::System.Math.Max(num + num2, itemLayoutInfo2.Row + itemLayoutInfo2.RowSpan) - num5;
							num = num5;
							itemLayoutInfo2.Column += num3;
						}
					}
				}
			}
			if (shiftBelow)
			{
				list.Sort(new global::Infragistics.Windows.DataPresenter.LayoutInfo.OriginComparer(true, item));
				int num6 = item.Column;
				int num7 = item.ColumnSpan;
				int num8 = 0;
				int num9 = list.IndexOf(item);
				for (int k = 1 + num9; k < list.Count; k++)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = list[k];
					if (global::Infragistics.Windows.DataPresenter.LayoutInfo.DoItemsOverlap(item, itemLayoutInfo3))
					{
						num8 = global::System.Math.Max(num8, item.Row + item.RowSpan - itemLayoutInfo3.Row);
					}
				}
				num8 = global::System.Math.Min(num8, item.RowSpan);
				if (num8 > 0)
				{
					for (int l = 1 + num9; l < list.Count; l++)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo4 = list[l];
						if (itemLayoutInfo4._fixedLocation == item._fixedLocation && global::Infragistics.Windows.DataPresenter.LayoutInfo.DoesItemOverlap(itemLayoutInfo4, list, null) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(num6, num7, itemLayoutInfo4.Column, itemLayoutInfo4.ColumnSpan))
						{
							int num10 = global::System.Math.Min(num6, itemLayoutInfo4.Column);
							num7 = global::System.Math.Max(num6 + num7, itemLayoutInfo4.Column + itemLayoutInfo4.ColumnSpan) - num10;
							num6 = num10;
							itemLayoutInfo4.Row += num8;
						}
					}
				}
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000269F0 File Offset: 0x00024BF0
		internal bool EnsureItemsDontOverlap()
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value.Clone();
			}
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[] array = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>[]
			{
				this._info.Values
			});
			global::System.Array.Sort<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(array, (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y) => -x._explicitSetPositionTimeStamp.CompareTo(y._explicitSetPositionTimeStamp));
			this.EnsureItemsDontOverlap(array, true, true, false);
			if (dictionary.Count != this._info.Count)
			{
				return true;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair2 in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x2;
				if (!dictionary.TryGetValue(keyValuePair2.Key, out x2) || !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.AreEqual(x2, keyValuePair2.Value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00026B24 File Offset: 0x00024D24
		internal void EnsureItemsDontOverlap(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> items, bool shiftRight, bool shiftBelow, bool shiftBelowFirst)
		{
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[] array = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>[]
			{
				items
			});
			global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>[] array2 = new global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>[]
			{
				new global::Infragistics.Windows.DataPresenter.LayoutInfo.OriginComparer(false, null),
				new global::Infragistics.Windows.DataPresenter.LayoutInfo.OriginComparer(true, null)
			};
			if (shiftBelowFirst)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.Swap(array2, 0, 1);
			}
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(array, new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(array2));
			for (int i = 0; i < array.Length; i++)
			{
				this.EnsureItemDoesntOverlap(array[i], shiftRight, shiftBelow, shiftBelowFirst);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00026B98 File Offset: 0x00024D98
		internal void EnsureNewItemsDontOverlapHelper()
		{
			this.RemoveDeletedFields();
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			global::Infragistics.Windows.Helpers.HashSet hashSet2 = new global::Infragistics.Windows.Helpers.HashSet();
			if (this._fieldLayout._autoGeneratedPositions != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._fieldLayout._autoGeneratedPositions._info)
				{
					if (!this._info.ContainsKey(keyValuePair.Key))
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = keyValuePair.Value.Clone();
						itemLayoutInfo.IsCollapsed = true;
						this._info[keyValuePair.Key] = itemLayoutInfo;
					}
				}
				this._fieldLayout._autoGeneratedPositions = null;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(this._fieldLayout);
			int i = 0;
			int count = fields.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fields[i];
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2;
				this._info.TryGetValue(field, out itemLayoutInfo2);
				if (field.IsVisibleInCellArea)
				{
					if (itemLayoutInfo2 == null)
					{
						hashSet2.Add(field);
					}
					else if (itemLayoutInfo2.IsCollapsed)
					{
						hashSet.Add(itemLayoutInfo2);
					}
				}
				i++;
			}
			if (hashSet.Count > 0 || hashSet2.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair2 in this._info)
				{
					global::Infragistics.Windows.DataPresenter.Field key = keyValuePair2.Key;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair2.Value;
					if (!value.IsCollapsed || hashSet.Exists(value))
					{
						layoutInfo[key] = value;
					}
				}
				foreach (object obj in hashSet2)
				{
					global::Infragistics.Windows.DataPresenter.Field field2 = (global::Infragistics.Windows.DataPresenter.Field)obj;
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = layoutInfo.CalculatePositionOfNewField(field2);
					itemLayoutInfo3._fixedLocation = field2.FixedLocation;
					layoutInfo[field2] = itemLayoutInfo3;
					hashSet.Add(itemLayoutInfo3);
				}
				layoutInfo.EnsureItemsDontOverlap(hashSet.ToArray<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(), true, true, false);
				this.EnsureNewItemsDontOverlapHelper_CopyFromNewLayout(layoutInfo);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00026DDC File Offset: 0x00024FDC
		internal void EnsureNewItemsDontOverlapHelper_CopyFromNewLayout(global::Infragistics.Windows.DataPresenter.LayoutInfo newLayoutInfo)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in newLayoutInfo._info)
			{
				this._info[keyValuePair.Key] = keyValuePair.Value;
				keyValuePair.Value.IsCollapsed = false;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair2 in this._info)
			{
				if (!newLayoutInfo.ContainsKey(keyValuePair2.Key))
				{
					keyValuePair2.Value.IsCollapsed = true;
				}
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00026EA8 File Offset: 0x000250A8
		private global::Infragistics.Windows.DataPresenter.Field GetItemAtLogicalCell(int column, int row)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (value.Contains(column, row))
				{
					return keyValuePair.Key;
				}
			}
			return null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00026F14 File Offset: 0x00025114
		internal int GetLogicalColumnCount()
		{
			int result;
			int num;
			this.GetLogicalRowAndColumnCount(out result, out num);
			return result;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00026F2C File Offset: 0x0002512C
		internal void GetLogicalRowAndColumnCount(out int columnCount, out int rowCount)
		{
			int num = 0;
			int num2 = 0;
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in this._info.Values)
			{
				num = global::System.Math.Max(num, itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan);
				num2 = global::System.Math.Max(num2, itemLayoutInfo.Row + itemLayoutInfo.RowSpan);
			}
			columnCount = num;
			rowCount = num2;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00026FB0 File Offset: 0x000251B0
		internal int GetLogicalRowCount()
		{
			int num;
			int result;
			this.GetLogicalRowAndColumnCount(out num, out result);
			return result;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00026FC8 File Offset: 0x000251C8
		private bool HasItemAtLogicalCell(int column, int row)
		{
			return null != this.GetItemAtLogicalCell(column, row);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00026FD8 File Offset: 0x000251D8
		internal bool HasOverlappingItem(int column, int row, int columnSpan, int rowSpan, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemToIgnore, global::Infragistics.Windows.DataPresenter.FixedFieldLocation? location)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (!value.IsCollapsed && value != itemToIgnore && (location == null || location.Value == value._fixedLocation) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(value.Column, value.ColumnSpan, column, columnSpan) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(value.Row, value.RowSpan, row, rowSpan))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00027084 File Offset: 0x00025284
		internal bool HasLogicalColumnOrRowChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
		{
			bool flag;
			bool flag2;
			this.HasLogicalColumnOrRowChanged(newInfo, out flag, out flag2);
			return flag || flag2;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000270A4 File Offset: 0x000252A4
		internal void HasLogicalColumnOrRowChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo, out bool logicalColumnChanged, out bool logicalRowChanged)
		{
			logicalColumnChanged = (logicalRowChanged = false);
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				newInfo.TryGetValue(keyValuePair.Key, out itemLayoutInfo);
				if (itemLayoutInfo != null)
				{
					if (value.Row != itemLayoutInfo.Row)
					{
						logicalRowChanged = true;
					}
					if (value.Column != itemLayoutInfo.Column)
					{
						logicalColumnChanged = true;
					}
					if (logicalRowChanged && logicalColumnChanged)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00027140 File Offset: 0x00025340
		private bool HasOverlappingFixedAreas()
		{
			int[][] array = new int[3][];
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (!value.IsCollapsed)
				{
					int fixedLocation = (int)keyValuePair.Key.FixedLocation;
					int[] array2 = array[fixedLocation];
					int num = isHorizontal ? value.Row : value.Column;
					int num2 = isHorizontal ? value.RowBottom : value.ColumnRight;
					if (array2 == null)
					{
						int[] array3 = array[fixedLocation] = new int[]
						{
							num,
							num2
						};
					}
					else
					{
						array2[0] = global::System.Math.Min(array2[0], num);
						array2[1] = global::System.Math.Max(array2[1], num2);
					}
				}
			}
			for (int i = 0; i < array.Length - 1; i++)
			{
				int[] array4 = array[i];
				if (array4 != null)
				{
					for (int j = i + 1; j < array.Length; j++)
					{
						int[] array5 = array[j];
						if (array5 != null && array5[1] >= array4[0] && array5[0] <= array4[1])
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002728C File Offset: 0x0002548C
		private bool HasOverlappingItems()
		{
			int num = int.MaxValue;
			int num2 = int.MaxValue;
			int num3 = int.MinValue;
			int num4 = int.MinValue;
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in this.Values)
			{
				if (!itemLayoutInfo.IsCollapsed)
				{
					num = global::System.Math.Min(num, itemLayoutInfo.Column);
					num3 = global::System.Math.Max(num3, itemLayoutInfo.ColumnRight);
					num2 = global::System.Math.Min(num2, itemLayoutInfo.Row);
					num4 = global::System.Math.Max(num4, itemLayoutInfo.RowBottom);
				}
			}
			bool[,] array = new bool[1 + num3 - num, 1 + num4 - num2];
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 in this.Values)
			{
				if (!itemLayoutInfo2.IsCollapsed)
				{
					int i = itemLayoutInfo2.Column - num;
					int num5 = itemLayoutInfo2.ColumnRight - num;
					while (i <= num5)
					{
						int j = itemLayoutInfo2.Row - num2;
						int num6 = itemLayoutInfo2.RowBottom - num2;
						while (j <= num6)
						{
							if (array[i, j])
							{
								return true;
							}
							array[i, j] = true;
							j++;
						}
						i++;
					}
				}
			}
			return false;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000273F4 File Offset: 0x000255F4
		private bool HasPositionsChanged()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (!value.IsCollapsed && !value.HasSamePosition(keyValuePair.Key.GridPosition))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002746C File Offset: 0x0002566C
		internal static bool Intersects(int x1, int w1, int x2, int w2)
		{
			return (x1 > x2 && x1 < x2 + w2) || (x1 + w1 > x2 && x1 + w1 < x2 + w2) || (x2 > x1 && x2 < x1 + w1) || (x2 + w2 > x1 && x2 + w2 < x1 + w1) || (x1 == x2 && w1 == w2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000274A9 File Offset: 0x000256A9
		internal bool IsSame(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.AreSame(this._info, layoutInfo._info);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000274BC File Offset: 0x000256BC
		private static bool AreSame(global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> xxInfo, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> yyInfo)
		{
			if (xxInfo.Count != yyInfo.Count)
			{
				return false;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field key in xxInfo.Keys)
			{
				if (!yyInfo.ContainsKey(key) || !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.AreEqual(xxInfo[key], yyInfo[key]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00027540 File Offset: 0x00025740
		internal void Merge(global::Infragistics.Windows.DataPresenter.LayoutInfo source, bool markCollapsedFieldsNotInSource)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in source._info)
			{
				this._info[keyValuePair.Key] = keyValuePair.Value;
			}
			if (markCollapsedFieldsNotInSource)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair2 in this._info)
				{
					if (!source._info.ContainsKey(keyValuePair2.Key))
					{
						keyValuePair2.Value.IsCollapsed = true;
					}
				}
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00027604 File Offset: 0x00025804
		internal void PackLayout()
		{
			this.PackLayout(true, true);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00027610 File Offset: 0x00025810
		internal void PackLayout(bool packColumns, bool packRows)
		{
			int num = 0;
			int num2 = 0;
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in this._info.Values)
			{
				num = global::System.Math.Max(num, itemLayoutInfo.Row + itemLayoutInfo.RowSpan);
				num2 = global::System.Math.Max(num2, itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan);
			}
			if (num == 0 || num2 == 0)
			{
				return;
			}
			bool[] array = new bool[num];
			bool[] array2 = new bool[num2];
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 in this._info.Values)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetValue(array, itemLayoutInfo2.Row, itemLayoutInfo2.RowSpan, true);
				global::Infragistics.Windows.DataPresenter.GridUtilities.SetValue(array2, itemLayoutInfo2.Column, itemLayoutInfo2.ColumnSpan, true);
			}
			int[] array3 = new int[array.Length];
			int[] array4 = new int[array2.Length];
			if (packRows)
			{
				int i = 0;
				int num3 = 0;
				while (i < array.Length)
				{
					if (!array[i])
					{
						num3++;
					}
					array3[i] = num3;
					i++;
				}
			}
			if (packColumns)
			{
				int j = 0;
				int num4 = 0;
				while (j < array2.Length)
				{
					if (!array2[j])
					{
						num4++;
					}
					array4[j] = num4;
					j++;
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 in this._info.Values)
			{
				itemLayoutInfo3.Column -= array4[itemLayoutInfo3.Column];
				itemLayoutInfo3.Row -= array3[itemLayoutInfo3.Row];
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000277F0 File Offset: 0x000259F0
		private void RemoveDeletedFields()
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(this._fieldLayout));
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			foreach (global::Infragistics.Windows.DataPresenter.Field item in this.Keys)
			{
				if (!hashSet.Exists(item))
				{
					list.Add(item);
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field key in list)
			{
				this._info.Remove(key);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000278AC File Offset: 0x00025AAC
		internal void ShiftItems(bool insertColumns, int startingOrigin, int delta)
		{
			if (delta != 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
					if (insertColumns && value.Column >= startingOrigin)
					{
						value.Column += delta;
					}
					else if (!insertColumns && value.Row >= startingOrigin)
					{
						value.Row += delta;
					}
				}
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0002793C File Offset: 0x00025B3C
		internal void SynchronizeFieldVisibility()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::System.Windows.Visibility visibilityInCellArea = keyValuePair.Key.VisibilityInCellArea;
				global::System.Windows.Visibility visibility = keyValuePair.Value.Visibility;
				if (visibilityInCellArea != visibility)
				{
					keyValuePair.Key.Visibility = visibility;
				}
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000279B4 File Offset: 0x00025BB4
		internal void UpdateFixedLocation(global::Infragistics.Windows.DataPresenter.FixedFieldLocation oldLocation, global::Infragistics.Windows.DataPresenter.FixedFieldLocation newLocation, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> fields)
		{
			if (fields.Count == 0)
			{
				return;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::Infragistics.Windows.DataPresenter.LayoutInfo.FixedLocationComparer comparer = new global::Infragistics.Windows.DataPresenter.LayoutInfo.FixedLocationComparer(isHorizontal);
			int num = isHorizontal ? this.GetLogicalColumnCount() : this.GetLogicalRowCount();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo, global::Infragistics.Windows.DataPresenter.Field> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo, global::Infragistics.Windows.DataPresenter.Field>();
			int num2 = 0;
			int num3 = 0;
			int num4 = fields.Count - 1;
			for (int i = num4; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fields[i];
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = this[field];
				if (itemLayoutInfo == null)
				{
					fields.RemoveAt(i);
				}
				else
				{
					list.Add(itemLayoutInfo);
					dictionary[itemLayoutInfo] = field;
					this._info.Remove(field);
					int num5 = isHorizontal ? itemLayoutInfo.Row : itemLayoutInfo.Column;
					int num6 = num5 + (isHorizontal ? itemLayoutInfo.RowSpan : itemLayoutInfo.ColumnSpan);
					if (i == num4)
					{
						num2 = num5;
						num3 = num6;
					}
					else
					{
						num2 = global::System.Math.Min(num2, num5);
						num3 = global::System.Math.Max(num3, num6);
					}
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			list.Sort(comparer);
			global::System.Collections.Generic.List<bool[]> list2 = new global::System.Collections.Generic.List<bool[]>();
			int num7 = num;
			for (int j = num3 - num2 - 1; j >= 0; j--)
			{
				bool[] array = new bool[num7];
				bool flag = false;
				for (int k = 0; k < num7; k++)
				{
					for (int l = 0; l < list.Count; l++)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = list[l];
						int row = (!isHorizontal) ? k : (j + num2);
						int column = (!isHorizontal) ? (j + num2) : k;
						if (itemLayoutInfo2.Contains(column, row))
						{
							array[k] = true;
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					list2.Insert(0, array);
				}
				else
				{
					for (int m = 0; m < list.Count; m++)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = list[m];
						if (!isHorizontal && itemLayoutInfo3.Column > j + num2)
						{
							itemLayoutInfo3.Column--;
						}
						else if (isHorizontal && itemLayoutInfo3.Row > j + num2)
						{
							itemLayoutInfo3.Row--;
						}
					}
				}
			}
			num3 = list2.Count + num2;
			int num8 = num3 - num2;
			this.PackLayout(!isHorizontal, isHorizontal);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(this.Values);
			list3.Sort(comparer);
			int num9 = 0;
			int num10 = 0;
			int val = 0;
			int n = 0;
			int count = list3.Count;
			while (n < count)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo4 = list3[n];
				if (!itemLayoutInfo4.IsCollapsed)
				{
					int num11 = isHorizontal ? itemLayoutInfo4.Row : itemLayoutInfo4.Column;
					int num12 = num11 + (isHorizontal ? itemLayoutInfo4.RowSpan : itemLayoutInfo4.ColumnSpan);
					val = global::System.Math.Max(num12, val);
					switch (itemLayoutInfo4._fixedLocation)
					{
					case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
						num9 = global::System.Math.Min(num9, num11);
						num10 = global::System.Math.Max(num10, num12);
						break;
					case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
						num9 = global::System.Math.Max(num9, num12);
						num10 = global::System.Math.Max(num10, num12);
						break;
					}
				}
				n++;
			}
			int num13 = 0;
			bool flag2;
			switch (newLocation)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
				num13 = num9;
				flag2 = true;
				goto IL_343;
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
				num13 = num10;
				flag2 = false;
				goto IL_343;
			}
			if (oldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge)
			{
				num13 = num10;
				flag2 = true;
			}
			else
			{
				num13 = num9;
				flag2 = false;
			}
			IL_343:
			for (int num14 = num8; num14 >= 0; num14--)
			{
				bool flag3 = true;
				for (int num15 = 0; num15 < list2.Count; num15++)
				{
					if ((!flag2 || num15 < num14) && (flag2 || num15 >= num8 - num14))
					{
						bool[] array2 = list2[num15];
						for (int num16 = 0; num16 < array2.Length; num16++)
						{
							if (array2[num16])
							{
								int num17 = num13;
								if (flag2)
								{
									num17 += -num14 + num15;
								}
								else if (!flag2)
								{
									num17 += num15 - (num8 - num14);
								}
								int num18 = num16;
								if (isHorizontal)
								{
									global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num17, ref num18);
								}
								if (num17 < 0 || num18 < 0)
								{
									flag3 = false;
									break;
								}
								foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
								{
									global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
									if (!value.IsCollapsed && value.Contains(num17, num18))
									{
										flag3 = false;
										break;
									}
								}
								if (!flag3)
								{
									break;
								}
							}
						}
						if (!flag3)
						{
							break;
						}
					}
				}
				if (flag3)
				{
					int delta = num8 - num14;
					int startingOrigin = num13;
					this.ShiftItems(!isHorizontal, startingOrigin, delta);
					for (int num19 = 0; num19 < list.Count; num19++)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo5 = list[num19];
						int num20 = num13;
						if (flag2)
						{
							num20 += -num14 + (((!isHorizontal) ? itemLayoutInfo5.Column : itemLayoutInfo5.Row) - num2);
						}
						else if (!flag2)
						{
							num20 += ((!isHorizontal) ? itemLayoutInfo5.Column : itemLayoutInfo5.Row) - num2;
						}
						int row2 = (!isHorizontal) ? itemLayoutInfo5.Row : itemLayoutInfo5.Column;
						if (isHorizontal)
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num20, ref row2);
						}
						itemLayoutInfo5.Column = num20;
						itemLayoutInfo5.Row = row2;
						itemLayoutInfo5._fixedLocation = newLocation;
						this._info[dictionary[itemLayoutInfo5]] = itemLayoutInfo5;
					}
					break;
				}
			}
			this.EnsureFixedLocationsDontOverlap();
			this.PackLayout();
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00027F24 File Offset: 0x00026124
		internal void VerifyTemplateGeneratorLayout()
		{
			if (this.HasPositionsChanged() && !this.HasOverlappingItems() && !this.HasOverlappingFixedAreas())
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
				{
					keyValuePair.Value._fixedLocation = keyValuePair.Key.FixedLocation;
				}
				return;
			}
			this.EnsureFixedLocationsDontOverlap();
			this.EnsureFixedLocationsInSync();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00027FB0 File Offset: 0x000261B0
		public void Add(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo)
		{
			this._info.Add(field, itemLayoutInfo);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00027FBF File Offset: 0x000261BF
		public bool ContainsKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._info.ContainsKey(field);
		}

		// Token: 0x17000217 RID: 535
		public global::Infragistics.Windows.DataPresenter.ItemLayoutInfo this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo result;
				if (this._info.TryGetValue(field, out result))
				{
					return result;
				}
				return null;
			}
			set
			{
				this._info[field] = value;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00027FFF File Offset: 0x000261FF
		public bool TryGetValue(global::Infragistics.Windows.DataPresenter.Field key, out global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value)
		{
			return this._info.TryGetValue(key, out value);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002800E File Offset: 0x0002620E
		public int Count
		{
			get
			{
				return this._info.Count;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0002801B File Offset: 0x0002621B
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> Keys
		{
			get
			{
				return this._info.Keys;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00028028 File Offset: 0x00026228
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> Values
		{
			get
			{
				return this._info.Values;
			}
		}

		// Token: 0x0400038B RID: 907
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400038C RID: 908
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> _info;

		// Token: 0x020000C5 RID: 197
		internal class CollapsedItemsPositionManager
		{
			// Token: 0x0600095A RID: 2394 RVA: 0x00028038 File Offset: 0x00026238
			internal CollapsedItemsPositionManager(global::Infragistics.Windows.DataPresenter.LayoutInfo newLayoutInfo, global::Infragistics.Windows.DataPresenter.Field dragField, bool onlyVisibilityChanged)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (newLayoutInfo != null) ? newLayoutInfo._fieldLayout : null;
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = (fieldLayout != null) ? fieldLayout.GetFieldLayoutInfo(true, false) : null;
				this._onlyVisibilityChanged = onlyVisibilityChanged;
				this._newLayoutInfo = newLayoutInfo;
				this._verticalLayout = (newLayoutInfo != null && global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom == newLayoutInfo._fieldLayout.AutoArrangeCellsResolved);
				if (newLayoutInfo != null && layoutInfo != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in layoutInfo._info)
					{
						global::Infragistics.Windows.DataPresenter.Field key = keyValuePair.Key;
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = newLayoutInfo[key];
						if (itemLayoutInfo == null)
						{
							itemLayoutInfo = value.Clone();
							itemLayoutInfo.IsCollapsed = true;
							newLayoutInfo[key] = itemLayoutInfo;
						}
						global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo(value, itemLayoutInfo, key);
						this._items.Add(itemInfo);
						if (key == dragField)
						{
							this._dragItemInfo = itemInfo;
						}
					}
				}
			}

			// Token: 0x0600095B RID: 2395 RVA: 0x00028144 File Offset: 0x00026344
			private int GetItemPrevNext(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo> list, int index, bool prev)
			{
				int count = list.Count;
				global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo = list[index];
				int num = prev ? -1 : 1;
				index += num;
				while (index >= 0 && index < count)
				{
					global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo2 = list[index];
					if (this._verticalLayout ? (itemInfo2._origItemInfo.Column != itemInfo._origItemInfo.Column) : (itemInfo2._origItemInfo.Row != itemInfo._origItemInfo.Row))
					{
						break;
					}
					if (!itemInfo2._origItemInfo.IsCollapsed && itemInfo2 != this._dragItemInfo)
					{
						return index;
					}
					index += num;
				}
				return -1;
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x000282A0 File Offset: 0x000264A0
			internal void OffsetCollapsedItems()
			{
				if (this._dragItemInfo != null)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo> items = this._items;
					global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo>(items, global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo>(delegate(global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo x, global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo y)
					{
						int num4;
						if (this._verticalLayout)
						{
							num4 = x._origItemInfo.Column.CompareTo(y._origItemInfo.Column);
							if (num4 == 0)
							{
								num4 = x._origItemInfo.Row.CompareTo(y._origItemInfo.Row);
							}
						}
						else
						{
							num4 = x._origItemInfo.Row.CompareTo(y._origItemInfo.Row);
							if (num4 == 0)
							{
								num4 = x._origItemInfo.Column.CompareTo(y._origItemInfo.Column);
							}
						}
						if (num4 == 0)
						{
							num4 = x._field.Index.CompareTo(y._field.Index);
						}
						return num4;
					}));
					int num = items.IndexOf(this._dragItemInfo);
					int i = 0;
					int count = items.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo = items[i];
						if (itemInfo != this._dragItemInfo && itemInfo._origItemInfo.IsCollapsed && global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.AreEqual(itemInfo._origItemInfo, itemInfo._newItemInfo))
						{
							bool flag = false;
							int itemPrevNext = this.GetItemPrevNext(items, i, true);
							int itemPrevNext2 = this.GetItemPrevNext(items, i, false);
							global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo2 = (itemPrevNext >= 0) ? items[itemPrevNext] : null;
							global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo3 = (itemPrevNext2 >= 0) ? items[itemPrevNext2] : null;
							if (this._onlyVisibilityChanged)
							{
								if (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(this._dragItemInfo._origItemInfo, itemInfo._origItemInfo) && (itemPrevNext < 0 || num >= itemPrevNext) && (itemPrevNext2 < 0 || num <= itemPrevNext2))
								{
									if (this._verticalLayout)
									{
										int val = (i > num) ? (this._dragItemInfo._newItemInfo.RowBottom + 1) : this._dragItemInfo._newItemInfo.Row;
										itemInfo._newItemInfo.Row = global::System.Math.Max(0, val);
									}
									else
									{
										int val2 = (i > num) ? (this._dragItemInfo._newItemInfo.ColumnRight + 1) : this._dragItemInfo._newItemInfo.Column;
										itemInfo._newItemInfo.Column = global::System.Math.Max(0, val2);
									}
									flag = true;
								}
								if (!flag)
								{
									int num2 = 0;
									int num3 = 0;
									if (itemInfo2 != null && global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(itemInfo._origItemInfo, itemInfo2._origItemInfo))
									{
										num2 = itemInfo2.DeltaColumn;
										num3 = itemInfo2.DeltaRow;
									}
									else if (itemInfo3 != null && global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(itemInfo._origItemInfo, itemInfo3._origItemInfo))
									{
										num2 = itemInfo3.DeltaColumn;
										num3 = itemInfo3.DeltaRow;
									}
									else if (itemInfo2 != null && itemInfo3 != null && itemInfo2.DeltaRow == itemInfo3.DeltaRow && itemInfo2.DeltaColumn == itemInfo3.DeltaColumn && (this._verticalLayout ? (global::System.Math.Abs(itemInfo2._origItemInfo.Row - itemInfo3._origItemInfo.Row) <= global::System.Math.Abs(itemInfo2._newItemInfo.Row - itemInfo3._newItemInfo.Row)) : (global::System.Math.Abs(itemInfo2._origItemInfo.Column - itemInfo3._origItemInfo.Column) <= global::System.Math.Abs(itemInfo2._newItemInfo.Column - itemInfo3._newItemInfo.Column))))
									{
										num2 = itemInfo2.DeltaColumn;
										num3 = itemInfo2.DeltaRow;
									}
									else
									{
										global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo itemInfo4 = (itemInfo3 != null) ? itemInfo3 : itemInfo2;
										if (itemInfo2 != null && itemInfo3 != null && (this._verticalLayout ? (global::System.Math.Abs(itemInfo._origItemInfo.Row - itemInfo2._origItemInfo.Row) < global::System.Math.Abs(itemInfo3._origItemInfo.Row - itemInfo._origItemInfo.Row)) : (global::System.Math.Abs(itemInfo._origItemInfo.Column - itemInfo2._origItemInfo.Column) < global::System.Math.Abs(itemInfo3._origItemInfo.Column - itemInfo._origItemInfo.Column))))
										{
											itemInfo4 = itemInfo2;
										}
										if (this._verticalLayout)
										{
											if (itemInfo4 != null && itemInfo4.DeltaColumn == itemInfo.DeltaColumn)
											{
												num3 = itemInfo4.DeltaRow;
											}
										}
										else if (itemInfo4 != null && itemInfo4.DeltaRow == itemInfo.DeltaRow)
										{
											num2 = itemInfo4.DeltaColumn;
										}
									}
									itemInfo._newItemInfo.Column = global::System.Math.Max(0, itemInfo._origItemInfo.Column - num2);
									itemInfo._newItemInfo.Row = global::System.Math.Max(0, itemInfo._origItemInfo.Row - num3);
								}
							}
						}
						i++;
					}
				}
			}

			// Token: 0x0400038E RID: 910
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo> _items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo>();

			// Token: 0x0400038F RID: 911
			private global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo _dragItemInfo;

			// Token: 0x04000390 RID: 912
			private bool _onlyVisibilityChanged;

			// Token: 0x04000391 RID: 913
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _newLayoutInfo;

			// Token: 0x04000392 RID: 914
			private bool _verticalLayout;

			// Token: 0x020000C6 RID: 198
			private class ItemInfo
			{
				// Token: 0x0600095E RID: 2398 RVA: 0x000286BF File Offset: 0x000268BF
				internal ItemInfo(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo origItemInfo, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo newItemInfo, global::Infragistics.Windows.DataPresenter.Field field)
				{
					this._origItemInfo = origItemInfo;
					this._newItemInfo = newItemInfo;
					this._field = field;
				}

				// Token: 0x1700021B RID: 539
				// (get) Token: 0x0600095F RID: 2399 RVA: 0x000286DC File Offset: 0x000268DC
				internal bool HasPositionChanged
				{
					get
					{
						return !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(this._origItemInfo, this._newItemInfo);
					}
				}

				// Token: 0x1700021C RID: 540
				// (get) Token: 0x06000960 RID: 2400 RVA: 0x000286F2 File Offset: 0x000268F2
				internal int DeltaColumn
				{
					get
					{
						return this._origItemInfo.Column - this._newItemInfo.Column;
					}
				}

				// Token: 0x1700021D RID: 541
				// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002870B File Offset: 0x0002690B
				internal int DeltaRow
				{
					get
					{
						return this._origItemInfo.Row - this._newItemInfo.Row;
					}
				}

				// Token: 0x04000393 RID: 915
				internal global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _origItemInfo;

				// Token: 0x04000394 RID: 916
				internal global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _newItemInfo;

				// Token: 0x04000395 RID: 917
				internal global::Infragistics.Windows.DataPresenter.Field _field;
			}
		}

		// Token: 0x020000C7 RID: 199
		internal class OriginComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>, global::System.Collections.IComparer
		{
			// Token: 0x06000962 RID: 2402 RVA: 0x00028724 File Offset: 0x00026924
			public OriginComparer(bool rowWise, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo dragItem)
			{
				this._rowWise = rowWise;
				this._dragItem = dragItem;
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x0002873A File Offset: 0x0002693A
			public int Compare(object x, object y)
			{
				return this.Compare((global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)x, (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)y);
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x00028750 File Offset: 0x00026950
			public int Compare(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
			{
				int num = this._rowWise ? x.Row.CompareTo(y.Row) : x.Column.CompareTo(y.Column);
				if (num == 0 && x != y)
				{
					if (x == this._dragItem)
					{
						num = -1;
					}
					else if (y == this._dragItem)
					{
						num = 1;
					}
					else
					{
						num = (this._rowWise ? x.RowSpan.CompareTo(y.RowSpan) : x.ColumnSpan.CompareTo(y.ColumnSpan));
					}
				}
				return num;
			}

			// Token: 0x04000396 RID: 918
			private bool _rowWise;

			// Token: 0x04000397 RID: 919
			private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _dragItem;
		}

		// Token: 0x020000C8 RID: 200
		private class FixedLocationComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>
		{
			// Token: 0x06000965 RID: 2405 RVA: 0x000287E6 File Offset: 0x000269E6
			internal FixedLocationComparer(bool byRow)
			{
				this._byRow = byRow;
			}

			// Token: 0x06000966 RID: 2406 RVA: 0x000287F8 File Offset: 0x000269F8
			int global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>.Compare(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
			{
				int num = global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(x._fixedLocation, y._fixedLocation);
				if (num == 0)
				{
					num = (this._byRow ? x.Row.CompareTo(y.Row) : x.Column.CompareTo(y.Column));
					if (num == 0)
					{
						num = (this._byRow ? x.RowSpan.CompareTo(y.RowSpan) : x.ColumnSpan.CompareTo(y.ColumnSpan));
					}
				}
				return num;
			}

			// Token: 0x04000398 RID: 920
			private bool _byRow;
		}
	}
}
