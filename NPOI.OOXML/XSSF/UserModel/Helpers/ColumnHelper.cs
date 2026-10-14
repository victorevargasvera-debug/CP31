using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.Util.Collections;
using NPOI.XSSF.Util;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000A9 RID: 169
	public class ColumnHelper
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x000289CD File Offset: 0x00026BCD
		public ColumnHelper(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheet)
		{
			this.worksheet = worksheet;
			this.CleanColumns();
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000289E4 File Offset: 0x00026BE4
		public void CleanColumns()
		{
			global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> treeSet = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>(global::NPOI.XSSF.Util.CTColComparator.BY_MIN_MAX);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols ct_Cols = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols[] array = this.worksheet.GetColsList().ToArray();
			int i;
			for (i = 0; i < array.Length; i++)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col newCol in array[i].GetColList().ToArray())
				{
					this.AddCleanColIntoCols(ct_Cols, newCol, treeSet);
				}
			}
			for (int k = i - 1; k >= 0; k--)
			{
				this.worksheet.RemoveCols(k);
			}
			ct_Cols.SetColArray(treeSet.ToArray(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[treeSet.Count]));
			this.worksheet.AddNewCols();
			this.worksheet.SetColsArray(0, ct_Cols);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00028AA8 File Offset: 0x00026CA8
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols AddCleanColIntoCols(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col newCol)
		{
			global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> treeSet = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>(global::NPOI.XSSF.Util.CTColComparator.BY_MIN_MAX);
			treeSet.AddAll(cols.GetColList());
			this.AddCleanColIntoCols(cols, newCol, treeSet);
			cols.SetColArray(treeSet.ToArray(new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[0]));
			return cols;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00028AE8 File Offset: 0x00026CE8
		private void AddCleanColIntoCols(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col newCol, global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> trackedCols)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> overlappingCols = this.GetOverlappingCols(newCol, trackedCols);
			if (overlappingCols.Count == 0)
			{
				trackedCols.Add(this.CloneCol(cols, newCol));
				return;
			}
			trackedCols.RemoveAll(overlappingCols);
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in overlappingCols)
			{
				long[] overlap = this.GetOverlap(newCol, ct_Col);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col2 = this.CloneCol(cols, ct_Col, overlap);
				this.SetColumnAttributes(newCol, ct_Col2);
				trackedCols.Add(ct_Col2);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col = (ct_Col.min < newCol.min) ? ct_Col : newCol;
				long[] array = new long[]
				{
					(long)((ulong)global::System.Math.Min(ct_Col.min, newCol.min)),
					overlap[0] - 1L
				};
				if (array[0] <= array[1])
				{
					trackedCols.Add(this.CloneCol(cols, col, array));
				}
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2 = (ct_Col.max > newCol.max) ? ct_Col : newCol;
				long[] array2 = new long[]
				{
					overlap[1] + 1L,
					(long)((ulong)global::System.Math.Max(ct_Col.max, newCol.max))
				};
				if (array2[0] <= array2[1])
				{
					trackedCols.Add(this.CloneCol(cols, col2, array2));
				}
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00028C2C File Offset: 0x00026E2C
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col CloneCol(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col, long[] newRange)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = this.CloneCol(cols, col);
			ct_Col.min = (uint)newRange[0];
			ct_Col.max = (uint)newRange[1];
			return ct_Col;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00028C4A File Offset: 0x00026E4A
		private long[] GetOverlap(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2)
		{
			return this.GetOverlappingRange(col1, col2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00028C54 File Offset: 0x00026E54
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> GetOverlappingCols(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col newCol, global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> trackedCols)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = trackedCols.Lower(newCol);
			global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> treeSet = (ct_Col == null) ? trackedCols : trackedCols.TailSet(ct_Col, this.Overlaps(ct_Col, newCol));
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col2 in treeSet)
			{
				if (!this.Overlaps(newCol, ct_Col2))
				{
					break;
				}
				list.Add(ct_Col2);
			}
			return list;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00028CCC File Offset: 0x00026ECC
		private bool Overlaps(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2)
		{
			return global::NPOI.XSSF.Util.NumericRanges.GetOverlappingType(this.ToRange(col1), this.ToRange(col2)) != -1;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00028CE7 File Offset: 0x00026EE7
		private long[] GetOverlappingRange(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2)
		{
			return global::NPOI.XSSF.Util.NumericRanges.GetOverlappingRange(this.ToRange(col1), this.ToRange(col2));
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00028CFC File Offset: 0x00026EFC
		private long[] ToRange(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col)
		{
			return new long[]
			{
				(long)((ulong)col.min),
				(long)((ulong)col.max)
			};
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00028D18 File Offset: 0x00026F18
		public static void SortColumns(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols newCols)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> colList = newCols.GetColList();
			colList.Sort(new global::NPOI.XSSF.Util.CTColComparator());
			newCols.SetColArray(colList);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00028D40 File Offset: 0x00026F40
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col CloneCol(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = cols.AddNewCol();
			ct_Col.min = col.min;
			ct_Col.max = col.max;
			this.SetColumnAttributes(col, ct_Col);
			return ct_Col;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00028D75 File Offset: 0x00026F75
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col GetColumn(long index, bool splitColumns)
		{
			return this.GetColumn1Based(index + 1L, splitColumns);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00028D84 File Offset: 0x00026F84
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col GetColumn1Based(long index1, bool splitColumns)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols colsArray = this.worksheet.GetColsArray(0);
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col in colsArray.GetColList().ToArray())
			{
				long num = (long)((ulong)ct_Col.min);
				long num2 = (long)((ulong)ct_Col.max);
				if (num <= index1 && num2 >= index1)
				{
					if (splitColumns)
					{
						if (num < index1)
						{
							this.InsertCol(colsArray, num, index1 - 1L, new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[]
							{
								ct_Col
							});
						}
						if (num2 > index1)
						{
							this.InsertCol(colsArray, index1 + 1L, num2, new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[]
							{
								ct_Col
							});
						}
						ct_Col.min = (uint)index1;
						ct_Col.max = (uint)index1;
					}
					return ct_Col;
				}
			}
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00028E28 File Offset: 0x00027028
		private void SweepCleanColumns(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] flattenedColsArray, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col overrideColumn)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> list = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>(flattenedColsArray);
			global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> treeSet = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>(global::NPOI.XSSF.Util.CTColComparator.BY_MAX);
			list.GetEnumerator();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col overrideColumn2 = null;
			long num = 0L;
			long num2 = 0L;
			global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> list2 = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
			int num3 = -1;
			while (num3 + 1 < list.Count)
			{
				num3++;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = list[num3];
				long num4 = (long)((ulong)ct_Col.min);
				long num5 = (long)((ulong)ct_Col.max);
				long num6 = (num5 > num2) ? num5 : num2;
				if (num3 + 1 < list.Count)
				{
					num6 = (long)((ulong)list[num3 + 1].min);
				}
				global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> enumerator = treeSet.GetEnumerator();
				list2.Clear();
				while (enumerator.MoveNext())
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col2 = enumerator.Current;
					if (num4 <= (long)((ulong)ct_Col2.max))
					{
						break;
					}
					list2.Add(ct_Col2);
				}
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col item in list2)
				{
					treeSet.Remove(item);
				}
				if (treeSet.Count != 0 && num < num4)
				{
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[treeSet.Count];
					treeSet.CopyTo(array);
					this.InsertCol(cols, num, num4 - 1L, array, true, overrideColumn2);
				}
				treeSet.Add(ct_Col);
				if (num5 > num2)
				{
					num2 = num5;
				}
				if (ct_Col.Equals(overrideColumn))
				{
					overrideColumn2 = overrideColumn;
				}
				while (num4 <= num6 && treeSet.Count != 0)
				{
					global::NPOI.Util.Collections.HashSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> hashSet = new global::NPOI.Util.Collections.HashSet<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>();
					global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col3 = treeSet.First();
					long num7 = (long)((ulong)ct_Col3.max);
					hashSet.Add(ct_Col3);
					for (;;)
					{
						global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col4 = treeSet.Higher(ct_Col3);
						if (ct_Col4 == null || (ulong)ct_Col4.max != (ulong)num7)
						{
							break;
						}
						ct_Col3 = ct_Col4;
						hashSet.Add(ct_Col3);
						if (num5 > num2)
						{
							num2 = num5;
						}
						if (ct_Col.Equals(overrideColumn))
						{
							overrideColumn2 = overrideColumn;
						}
					}
					if (num7 < num6 || num3 + 1 >= list.Count)
					{
						global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] array2 = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[treeSet.Count];
						treeSet.CopyTo(array2);
						this.InsertCol(cols, num4, num7, array2, true, overrideColumn2);
						if (num3 + 1 < list.Count)
						{
							if (num6 > num7)
							{
								foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col item2 in hashSet)
								{
									treeSet.Remove(item2);
								}
								if (hashSet.Contains(overrideColumn))
								{
									overrideColumn2 = null;
								}
							}
						}
						else
						{
							foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col item3 in hashSet)
							{
								treeSet.Remove(item3);
							}
							if (hashSet.Contains(overrideColumn))
							{
								overrideColumn2 = null;
							}
						}
						num4 = (num = num7 + 1L);
					}
					else
					{
						num = num4;
						num4 = num6 + 1L;
					}
				}
			}
			global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.SortColumns(cols);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00029114 File Offset: 0x00027314
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col InsertCol(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, long min, long max, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] colsWithAttributes)
		{
			return this.InsertCol(cols, min, max, colsWithAttributes, false, null);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00029124 File Offset: 0x00027324
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col InsertCol(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, long min, long max, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col[] colsWithAttributes, bool ignoreExistsCheck, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col overrideColumn)
		{
			if (ignoreExistsCheck || !this.ColumnExists(cols, min, max))
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = cols.InsertNewCol(0);
				ct_Col.min = (uint)min;
				ct_Col.max = (uint)max;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col fromCol in colsWithAttributes)
				{
					this.SetColumnAttributes(fromCol, ct_Col);
				}
				if (overrideColumn != null)
				{
					this.SetColumnAttributes(overrideColumn, ct_Col);
				}
				return ct_Col;
			}
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00029185 File Offset: 0x00027385
		public bool ColumnExists(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, long index)
		{
			return this.ColumnExists1Based(cols, index + 1L);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00029194 File Offset: 0x00027394
		private bool ColumnExists1Based(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, long index1)
		{
			for (int i = 0; i < cols.sizeOfColArray(); i++)
			{
				if ((ulong)cols.GetColArray(i).min == (ulong)index1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000291C8 File Offset: 0x000273C8
		public void SetColumnAttributes(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col fromCol, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col toCol)
		{
			if (fromCol.IsSetBestFit())
			{
				toCol.bestFit = fromCol.bestFit;
			}
			if (fromCol.IsSetCustomWidth())
			{
				toCol.customWidth = fromCol.customWidth;
			}
			if (fromCol.IsSetHidden())
			{
				toCol.hidden = fromCol.hidden;
			}
			if (fromCol.IsSetStyle())
			{
				toCol.style = fromCol.style;
			}
			if (fromCol.IsSetWidth())
			{
				toCol.width = fromCol.width;
				toCol.widthSpecified = fromCol.widthSpecified;
			}
			if (fromCol.IsSetCollapsed())
			{
				toCol.collapsed = fromCol.collapsed;
				toCol.collapsedSpecified = fromCol.collapsedSpecified;
			}
			if (fromCol.IsSetPhonetic())
			{
				toCol.phonetic = fromCol.phonetic;
			}
			if (fromCol.IsSetOutlineLevel())
			{
				toCol.outlineLevel = fromCol.outlineLevel;
			}
			if (fromCol.IsSetCollapsed())
			{
				toCol.collapsed = fromCol.collapsed;
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000292A1 File Offset: 0x000274A1
		public void SetColBestFit(long index, bool bestFit)
		{
			this.GetOrCreateColumn1Based(index + 1L, false).bestFit = bestFit;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000292B4 File Offset: 0x000274B4
		public void SetCustomWidth(long index, bool width)
		{
			this.GetOrCreateColumn1Based(index + 1L, true).customWidth = width;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000292C7 File Offset: 0x000274C7
		public void SetColWidth(long index, double width)
		{
			this.GetOrCreateColumn1Based(index + 1L, true).width = width;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000292DA File Offset: 0x000274DA
		public void SetColHidden(long index, bool hidden)
		{
			this.GetOrCreateColumn1Based(index + 1L, true).hidden = hidden;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000292F0 File Offset: 0x000274F0
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col GetOrCreateColumn1Based(long index1, bool splitColumns)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = this.GetColumn1Based(index1, splitColumns);
			if (ct_Col == null)
			{
				ct_Col = this.worksheet.GetColsArray(0).AddNewCol();
				ct_Col.min = (uint)index1;
				ct_Col.max = (uint)index1;
			}
			return ct_Col;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002932C File Offset: 0x0002752C
		public void SetColDefaultStyle(long index, global::NPOI.SS.UserModel.ICellStyle style)
		{
			this.SetColDefaultStyle(index, (int)style.Index);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002933B File Offset: 0x0002753B
		public void SetColDefaultStyle(long index, int styleId)
		{
			this.GetOrCreateColumn1Based(index + 1L, true).style = new uint?((uint)styleId);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00029354 File Offset: 0x00027554
		public int GetColDefaultStyle(long index)
		{
			if (this.GetColumn(index, false) != null)
			{
				return (int)this.GetColumn(index, false).style.Value;
			}
			return -1;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00029384 File Offset: 0x00027584
		private bool ColumnExists(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, long min, long max)
		{
			for (int i = 0; i < cols.sizeOfColArray(); i++)
			{
				if ((ulong)cols.GetColArray(i).min == (ulong)min && (ulong)cols.GetColArray(i).max == (ulong)max)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000293C8 File Offset: 0x000275C8
		public int GetIndexOfColumn(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cols cols, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col)
		{
			for (int i = 0; i < cols.sizeOfColArray(); i++)
			{
				if (cols.GetColArray(i).min == col.min && cols.GetColArray(i).max == col.max)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x040003A2 RID: 930
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Worksheet worksheet;

		// Token: 0x02000141 RID: 321
		public class TreeSet<T>
		{
			// Token: 0x06001024 RID: 4132 RVA: 0x00038AA3 File Offset: 0x00036CA3
			public TreeSet(global::System.Collections.Generic.IComparer<T> comparer)
			{
				this.comparer = comparer;
				this.innerObj = new global::System.Collections.Generic.SortedList<T, object>(comparer);
			}

			// Token: 0x06001025 RID: 4133 RVA: 0x00038AC0 File Offset: 0x00036CC0
			public T First()
			{
				global::System.Collections.Generic.IEnumerator<T> enumerator = this.innerObj.Keys.GetEnumerator();
				if (enumerator.MoveNext())
				{
					return enumerator.Current;
				}
				return default(T);
			}

			// Token: 0x06001026 RID: 4134 RVA: 0x00038AF8 File Offset: 0x00036CF8
			public T Higher(T element)
			{
				global::System.Collections.Generic.IEnumerator<T> enumerator = this.innerObj.Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (this.innerObj.Comparer.Compare(enumerator.Current, element) > 0)
					{
						return enumerator.Current;
					}
				}
				return default(T);
			}

			// Token: 0x06001027 RID: 4135 RVA: 0x00038B4A File Offset: 0x00036D4A
			public void Add(T item)
			{
				if (!this.innerObj.ContainsKey(item))
				{
					this.innerObj.Add(item, null);
				}
			}

			// Token: 0x06001028 RID: 4136 RVA: 0x00038B67 File Offset: 0x00036D67
			public bool Remove(T item)
			{
				return this.innerObj.Remove(item);
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06001029 RID: 4137 RVA: 0x00038B75 File Offset: 0x00036D75
			public int Count
			{
				get
				{
					return this.innerObj.Count;
				}
			}

			// Token: 0x0600102A RID: 4138 RVA: 0x00038B84 File Offset: 0x00036D84
			public void CopyTo(T[] target)
			{
				for (int i = 0; i < this.innerObj.Count; i++)
				{
					target[i] = this.innerObj.Keys[i];
				}
			}

			// Token: 0x0600102B RID: 4139 RVA: 0x00038BBF File Offset: 0x00036DBF
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return this.innerObj.Keys.GetEnumerator();
			}

			// Token: 0x0600102C RID: 4140 RVA: 0x00038BD4 File Offset: 0x00036DD4
			public T[] ToArray(T[] a)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				list.AddRange(this.innerObj.Keys);
				if (a.Length < this.Count)
				{
					return list.ToArray();
				}
				global::System.Array.Copy(list.ToArray(), 0, a, 0, this.Count);
				if (a.Length > this.Count)
				{
					a[this.Count] = default(T);
				}
				return a;
			}

			// Token: 0x0600102D RID: 4141 RVA: 0x00038C40 File Offset: 0x00036E40
			internal void AddAll(global::System.Collections.Generic.List<T> list)
			{
				foreach (T key in list)
				{
					if (!this.innerObj.ContainsKey(key))
					{
						this.innerObj.Add(key, null);
					}
				}
			}

			// Token: 0x0600102E RID: 4142 RVA: 0x00038CA4 File Offset: 0x00036EA4
			internal void RemoveAll(global::System.Collections.Generic.List<T> list)
			{
				foreach (T key in list)
				{
					this.innerObj.Remove(key);
				}
			}

			// Token: 0x0600102F RID: 4143 RVA: 0x00038CF8 File Offset: 0x00036EF8
			internal T Lower(T element)
			{
				global::System.Collections.Generic.IEnumerator<T> enumerator = this.innerObj.Keys.GetEnumerator();
				T result = default(T);
				while (enumerator.MoveNext())
				{
					if (this.innerObj.Comparer.Compare(enumerator.Current, element) >= 0)
					{
						return result;
					}
					result = enumerator.Current;
				}
				return result;
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x00038D4C File Offset: 0x00036F4C
			internal global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<T> TailSet(T fromElement, bool inclusive)
			{
				global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<T> treeSet = new global::NPOI.XSSF.UserModel.Helpers.ColumnHelper.TreeSet<T>(this.comparer);
				global::System.Collections.Generic.IEnumerator<T> enumerator = this.innerObj.Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (inclusive)
					{
						if (this.innerObj.Comparer.Compare(enumerator.Current, fromElement) >= 0)
						{
							treeSet.Add(enumerator.Current);
						}
					}
					else if (this.innerObj.Comparer.Compare(enumerator.Current, fromElement) > 0)
					{
						treeSet.Add(enumerator.Current);
					}
				}
				return treeSet;
			}

			// Token: 0x04000514 RID: 1300
			private global::System.Collections.Generic.SortedList<T, object> innerObj;

			// Token: 0x04000515 RID: 1301
			private global::System.Collections.Generic.IComparer<T> comparer;
		}
	}
}
