using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000CD RID: 205
	internal class LayoutInfo
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x00029B4F File Offset: 0x00027D4F
		internal LayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
			this._info = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00029B70 File Offset: 0x00027D70
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

		// Token: 0x060009D8 RID: 2520 RVA: 0x00029B9C File Offset: 0x00027D9C
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
			if (this._fieldLayout.IsHorizontal)
			{
				return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(0, num2);
			}
			return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(num, 0);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00029CA8 File Offset: 0x00027EA8
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo Clone()
		{
			return this.Clone(false);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00029CB4 File Offset: 0x00027EB4
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

		// Token: 0x060009DB RID: 2523 RVA: 0x00029D3C File Offset: 0x00027F3C
		internal static global::Infragistics.Windows.DataPresenter.LayoutInfo Create(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(fieldLayout);
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.GetAllFields(true))
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

		// Token: 0x060009DC RID: 2524 RVA: 0x00029DD4 File Offset: 0x00027FD4
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal void DebugFixedLocations()
		{
			if (!this.AreFixedFieldsSupported)
			{
				return;
			}
			int column;
			int row;
			this.GetLogicalRowAndColumnCount(out column, out row);
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[,] array = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo[column, row];
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> keyValuePair in this._info)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value = keyValuePair.Value;
				if (!value.IsCollapsed && keyValuePair.Key.IsInLayout)
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

		// Token: 0x060009DD RID: 2525 RVA: 0x00029F34 File Offset: 0x00028134
		internal bool DoesItemOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo ignoreItem)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.DoesItemOverlap(item, this._info.Values, ignoreItem);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00029F48 File Offset: 0x00028148
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

		// Token: 0x060009DF RID: 2527 RVA: 0x00029FA4 File Offset: 0x000281A4
		private static bool DoItemsOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo xx, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo yy)
		{
			return xx != null && yy != null && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(xx.Column, xx.ColumnSpan, yy.Column, yy.ColumnSpan) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(xx.Row, xx.RowSpan, yy.Row, yy.RowSpan);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00029FF8 File Offset: 0x000281F8
		internal void EnsureFixedLocationsDontOverlap()
		{
			if (!this.AreFixedFieldsSupported)
			{
				return;
			}
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

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002A10C File Offset: 0x0002830C
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

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002A274 File Offset: 0x00028474
		internal void EnsureItemDoesntOverlap(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.EnsureItemDoesntOverlap(this[field], true, true, false);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002A286 File Offset: 0x00028486
		internal void EnsureItemDoesntOverlap(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo item, bool shiftRight, bool shiftBelow, bool shiftBelowFirst)
		{
			this.EnsureItemDoesntOverlapImpl(item, shiftRight, shiftBelow, shiftBelowFirst);
			this.EnsureFixedLocationsDontOverlap();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002A29C File Offset: 0x0002849C
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

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002A534 File Offset: 0x00028734
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
			this.EnsureItemsDontOverlap(array, true, true, this._fieldLayout.IsHorizontal);
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

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002A674 File Offset: 0x00028874
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

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002A6E8 File Offset: 0x000288E8
		internal void EnsureNewItemsDontOverlapHelper()
		{
			this.RemoveDeletedFields();
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
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
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(true))
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2;
				this._info.TryGetValue(field, out itemLayoutInfo2);
				if (field.IsVisibleInCellArea)
				{
					if (itemLayoutInfo2 == null)
					{
						list.Add(field);
					}
					else if (itemLayoutInfo2.IsCollapsed)
					{
						hashSet.Add(itemLayoutInfo2);
					}
				}
			}
			if (hashSet.Count > 0 || list.Count > 0)
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
				foreach (global::Infragistics.Windows.DataPresenter.Field field2 in list)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = layoutInfo.CalculatePositionOfNewField(field2);
					itemLayoutInfo3._fixedLocation = field2.FixedLocation;
					layoutInfo[field2] = itemLayoutInfo3;
					hashSet.Add(itemLayoutInfo3);
				}
				layoutInfo.EnsureItemsDontOverlap(hashSet.ToArray<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>(), true, true, this._fieldLayout.IsHorizontal);
				this.EnsureNewItemsDontOverlapHelper_CopyFromNewLayout(layoutInfo);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002A938 File Offset: 0x00028B38
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

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002AA04 File Offset: 0x00028C04
		internal void FlipFieldPositions()
		{
			if (this._info == null || this._info.Count == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in this._info.Values)
			{
				int row = itemLayoutInfo.Row;
				int rowSpan = itemLayoutInfo.RowSpan;
				itemLayoutInfo.Row = itemLayoutInfo.Column;
				itemLayoutInfo.RowSpan = itemLayoutInfo.ColumnSpan;
				itemLayoutInfo.Column = row;
				itemLayoutInfo.ColumnSpan = rowSpan;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002AAA0 File Offset: 0x00028CA0
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

		// Token: 0x060009EB RID: 2539 RVA: 0x0002AB0C File Offset: 0x00028D0C
		internal int GetLogicalColumnCount()
		{
			int result;
			int num;
			this.GetLogicalRowAndColumnCount(out result, out num);
			return result;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002AB24 File Offset: 0x00028D24
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

		// Token: 0x060009ED RID: 2541 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		internal int GetLogicalRowCount()
		{
			int num;
			int result;
			this.GetLogicalRowAndColumnCount(out num, out result);
			return result;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		private bool HasItemAtLogicalCell(int column, int row)
		{
			return null != this.GetItemAtLogicalCell(column, row);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002ABD0 File Offset: 0x00028DD0
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

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002AC7C File Offset: 0x00028E7C
		internal bool HasLogicalColumnOrRowChanged(global::Infragistics.Windows.DataPresenter.LayoutInfo newInfo)
		{
			bool flag;
			bool flag2;
			this.HasLogicalColumnOrRowChanged(newInfo, out flag, out flag2);
			return flag || flag2;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002AC9C File Offset: 0x00028E9C
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

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002AD38 File Offset: 0x00028F38
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

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002AE84 File Offset: 0x00029084
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

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002AFEC File Offset: 0x000291EC
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

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002B064 File Offset: 0x00029264
		internal static bool Intersects(int x1, int w1, int x2, int w2)
		{
			return (x1 > x2 && x1 < x2 + w2) || (x1 + w1 > x2 && x1 + w1 < x2 + w2) || (x2 > x1 && x2 < x1 + w1) || (x2 + w2 > x1 && x2 + w2 < x1 + w1) || (x1 == x2 && w1 == w2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002B0A1 File Offset: 0x000292A1
		internal bool IsSame(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.AreSame(this._info, layoutInfo._info);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002B0B4 File Offset: 0x000292B4
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

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002B138 File Offset: 0x00029338
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

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002B1FC File Offset: 0x000293FC
		internal void PackLayout()
		{
			this.PackLayout(true, true);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002B208 File Offset: 0x00029408
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

		// Token: 0x060009FB RID: 2555 RVA: 0x0002B3E8 File Offset: 0x000295E8
		internal void RemoveDeletedFields()
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(this._fieldLayout.GetAllFields(true));
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

		// Token: 0x060009FC RID: 2556 RVA: 0x0002B4A8 File Offset: 0x000296A8
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

		// Token: 0x060009FD RID: 2557 RVA: 0x0002B538 File Offset: 0x00029738
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

		// Token: 0x060009FE RID: 2558 RVA: 0x0002B5B0 File Offset: 0x000297B0
		internal void UpdateFixedLocation(global::Infragistics.Windows.DataPresenter.FixedFieldLocation oldLocation, global::Infragistics.Windows.DataPresenter.FixedFieldLocation newLocation, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> fields)
		{
			if (fields.Count == 0)
			{
				return;
			}
			if (!this.AreFixedFieldsSupported)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field key in fields)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
					if (this._info.TryGetValue(key, out itemLayoutInfo))
					{
						itemLayoutInfo._fixedLocation = newLocation;
					}
				}
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
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = this[field];
				if (itemLayoutInfo2 == null)
				{
					fields.RemoveAt(i);
				}
				else
				{
					list.Add(itemLayoutInfo2);
					dictionary[itemLayoutInfo2] = field;
					this._info.Remove(field);
					int num5 = isHorizontal ? itemLayoutInfo2.Row : itemLayoutInfo2.Column;
					int num6 = num5 + (isHorizontal ? itemLayoutInfo2.RowSpan : itemLayoutInfo2.ColumnSpan);
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
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = list[l];
						int row = (!isHorizontal) ? k : (j + num2);
						int column = (!isHorizontal) ? (j + num2) : k;
						if (itemLayoutInfo3.Contains(column, row))
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
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo4 = list[m];
						if (!isHorizontal && itemLayoutInfo4.Column > j + num2)
						{
							itemLayoutInfo4.Column--;
						}
						else if (isHorizontal && itemLayoutInfo4.Row > j + num2)
						{
							itemLayoutInfo4.Row--;
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
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo5 = list3[n];
				if (!itemLayoutInfo5.IsCollapsed)
				{
					int num11 = isHorizontal ? itemLayoutInfo5.Row : itemLayoutInfo5.Column;
					int num12 = num11 + (isHorizontal ? itemLayoutInfo5.RowSpan : itemLayoutInfo5.ColumnSpan);
					val = global::System.Math.Max(num12, val);
					switch (itemLayoutInfo5._fixedLocation)
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
				goto IL_396;
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
				num13 = num10;
				flag2 = false;
				goto IL_396;
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
			IL_396:
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
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo6 = list[num19];
						int num20 = num13;
						if (flag2)
						{
							num20 += -num14 + (((!isHorizontal) ? itemLayoutInfo6.Column : itemLayoutInfo6.Row) - num2);
						}
						else if (!flag2)
						{
							num20 += ((!isHorizontal) ? itemLayoutInfo6.Column : itemLayoutInfo6.Row) - num2;
						}
						int row2 = (!isHorizontal) ? itemLayoutInfo6.Row : itemLayoutInfo6.Column;
						if (isHorizontal)
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num20, ref row2);
						}
						itemLayoutInfo6.Column = num20;
						itemLayoutInfo6.Row = row2;
						itemLayoutInfo6._fixedLocation = newLocation;
						this._info[dictionary[itemLayoutInfo6]] = itemLayoutInfo6;
					}
					break;
				}
			}
			this.EnsureFixedLocationsDontOverlap();
			this.PackLayout();
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002BB80 File Offset: 0x00029D80
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

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002BC0C File Offset: 0x00029E0C
		public void Add(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo)
		{
			this._info.Add(field, itemLayoutInfo);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002BC1B File Offset: 0x00029E1B
		public bool ContainsKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._info.ContainsKey(field);
		}

		// Token: 0x17000244 RID: 580
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

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002BC5B File Offset: 0x00029E5B
		public bool TryGetValue(global::Infragistics.Windows.DataPresenter.Field key, out global::Infragistics.Windows.DataPresenter.ItemLayoutInfo value)
		{
			return this._info.TryGetValue(key, out value);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002BC6A File Offset: 0x00029E6A
		public int Count
		{
			get
			{
				return this._info.Count;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0002BC77 File Offset: 0x00029E77
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> Keys
		{
			get
			{
				return this._info.Keys;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002BC84 File Offset: 0x00029E84
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> Values
		{
			get
			{
				return this._info.Values;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002BC94 File Offset: 0x00029E94
		private bool AreFixedFieldsSupported
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				return dataPresenter != null && dataPresenter.IsFixedFieldsSupportedResolved;
			}
		}

		// Token: 0x040003E7 RID: 999
		private readonly global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040003E8 RID: 1000
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo> _info;

		// Token: 0x020000CE RID: 206
		internal class CollapsedItemsPositionManager
		{
			// Token: 0x06000A0A RID: 2570 RVA: 0x0002BCB8 File Offset: 0x00029EB8
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

			// Token: 0x06000A0B RID: 2571 RVA: 0x0002BDC4 File Offset: 0x00029FC4
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

			// Token: 0x06000A0C RID: 2572 RVA: 0x0002BF20 File Offset: 0x0002A120
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
							num4 = x._field.IndexForCompare.CompareTo(y._field.IndexForCompare);
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

			// Token: 0x040003EA RID: 1002
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo> _items = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo>();

			// Token: 0x040003EB RID: 1003
			private global::Infragistics.Windows.DataPresenter.LayoutInfo.CollapsedItemsPositionManager.ItemInfo _dragItemInfo;

			// Token: 0x040003EC RID: 1004
			private bool _onlyVisibilityChanged;

			// Token: 0x040003ED RID: 1005
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _newLayoutInfo;

			// Token: 0x040003EE RID: 1006
			private bool _verticalLayout;

			// Token: 0x020000CF RID: 207
			private class ItemInfo
			{
				// Token: 0x06000A0E RID: 2574 RVA: 0x0002C33F File Offset: 0x0002A53F
				internal ItemInfo(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo origItemInfo, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo newItemInfo, global::Infragistics.Windows.DataPresenter.Field field)
				{
					this._origItemInfo = origItemInfo;
					this._newItemInfo = newItemInfo;
					this._field = field;
				}

				// Token: 0x17000249 RID: 585
				// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0002C35C File Offset: 0x0002A55C
				internal bool HasPositionChanged
				{
					get
					{
						return !global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.HasSamePosition(this._origItemInfo, this._newItemInfo);
					}
				}

				// Token: 0x1700024A RID: 586
				// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002C372 File Offset: 0x0002A572
				internal int DeltaColumn
				{
					get
					{
						return this._origItemInfo.Column - this._newItemInfo.Column;
					}
				}

				// Token: 0x1700024B RID: 587
				// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002C38B File Offset: 0x0002A58B
				internal int DeltaRow
				{
					get
					{
						return this._origItemInfo.Row - this._newItemInfo.Row;
					}
				}

				// Token: 0x040003EF RID: 1007
				internal global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _origItemInfo;

				// Token: 0x040003F0 RID: 1008
				internal global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _newItemInfo;

				// Token: 0x040003F1 RID: 1009
				internal global::Infragistics.Windows.DataPresenter.Field _field;
			}
		}

		// Token: 0x020000D0 RID: 208
		internal class OriginComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>, global::System.Collections.IComparer
		{
			// Token: 0x06000A12 RID: 2578 RVA: 0x0002C3A4 File Offset: 0x0002A5A4
			public OriginComparer(bool rowWise, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo dragItem)
			{
				this._rowWise = rowWise;
				this._dragItem = dragItem;
			}

			// Token: 0x06000A13 RID: 2579 RVA: 0x0002C3BA File Offset: 0x0002A5BA
			public int Compare(object x, object y)
			{
				return this.Compare((global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)x, (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)y);
			}

			// Token: 0x06000A14 RID: 2580 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
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

			// Token: 0x040003F2 RID: 1010
			private bool _rowWise;

			// Token: 0x040003F3 RID: 1011
			private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _dragItem;
		}

		// Token: 0x020000D1 RID: 209
		private class FixedLocationComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.ItemLayoutInfo>
		{
			// Token: 0x06000A15 RID: 2581 RVA: 0x0002C466 File Offset: 0x0002A666
			internal FixedLocationComparer(bool byRow)
			{
				this._byRow = byRow;
			}

			// Token: 0x06000A16 RID: 2582 RVA: 0x0002C478 File Offset: 0x0002A678
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

			// Token: 0x040003F4 RID: 1012
			private bool _byRow;
		}
	}
}
