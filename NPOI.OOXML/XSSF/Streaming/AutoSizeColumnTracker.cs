using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C2 RID: 194
	public class AutoSizeColumnTracker
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x0002C1B4 File Offset: 0x0002A3B4
		public AutoSizeColumnTracker(global::NPOI.SS.UserModel.ISheet sheet)
		{
			this.defaultCharWidth = global::NPOI.SS.Util.SheetUtil.GetDefaultCharWidth(sheet.Workbook);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0002C1EE File Offset: 0x0002A3EE
		public global::System.Collections.Generic.ISet<int> TrackedColumns
		{
			get
			{
				return new global::System.Collections.Generic.SortedSet<int>(this.maxColumnWidths.Keys);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002C200 File Offset: 0x0002A400
		public bool IsColumnTracked(int column)
		{
			return this.trackAllColumns || this.maxColumnWidths.ContainsKey(column);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002C218 File Offset: 0x0002A418
		public bool IsAllColumnsTracked()
		{
			return this.trackAllColumns;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0002C220 File Offset: 0x0002A420
		public void TrackAllColumns()
		{
			this.trackAllColumns = true;
			this.untrackedColumns.Clear();
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0002C234 File Offset: 0x0002A434
		public void UntrackAllColumns()
		{
			this.trackAllColumns = false;
			this.maxColumnWidths.Clear();
			this.untrackedColumns.Clear();
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002C254 File Offset: 0x0002A454
		public void TrackColumns(global::System.Collections.Generic.ICollection<int> columns)
		{
			foreach (int column in columns)
			{
				this.TrackColumn(column);
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		public bool TrackColumn(int column)
		{
			this.untrackedColumns.Remove(column);
			if (!this.maxColumnWidths.ContainsKey(column))
			{
				this.maxColumnWidths.Add(column, new global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair());
				return true;
			}
			return false;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002C2D1 File Offset: 0x0002A4D1
		private bool ImplicitlyTrackColumn(int column)
		{
			if (!this.untrackedColumns.Contains(column))
			{
				this.TrackColumn(column);
				return true;
			}
			return false;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		public bool UntrackColumns(global::System.Collections.Generic.ICollection<int> columns)
		{
			bool result = false;
			foreach (int num in columns)
			{
				this.untrackedColumns.Add(num);
				if (this.maxColumnWidths.ContainsKey(num))
				{
					result = this.maxColumnWidths.Remove(num);
				}
			}
			return result;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002C358 File Offset: 0x0002A558
		public bool UntrackColumn(int column)
		{
			bool result = false;
			if (this.maxColumnWidths.ContainsKey(column))
			{
				this.untrackedColumns.Add(column);
				result = this.maxColumnWidths.Remove(column);
			}
			this.untrackedColumns.Add(column);
			return result;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
		public int GetBestFitColumnWidth(int column, bool useMergedCells)
		{
			if (!this.maxColumnWidths.ContainsKey(column))
			{
				if (!this.trackAllColumns)
				{
					global::System.InvalidOperationException innerException = new global::System.InvalidOperationException("Column was never explicitly tracked and isAllColumnsTracked() is false (trackAllColumns() was never called or untrackAllColumns() was called after trackAllColumns() was called).");
					throw new global::System.InvalidOperationException("Cannot get best fit column width on untracked column " + column.ToString() + ". Either explicitly track the column or track all columns.", innerException);
				}
				if (!this.ImplicitlyTrackColumn(column))
				{
					global::System.InvalidOperationException innerException2 = new global::System.InvalidOperationException("Column was explicitly untracked after trackAllColumns() was called.");
					throw new global::System.InvalidOperationException("Cannot get best fit column width on explicitly untracked column " + column.ToString() + ". Either explicitly track the column or track all columns.", innerException2);
				}
			}
			double maxColumnWidth = this.maxColumnWidths[column].GetMaxColumnWidth(useMergedCells);
			return (int)(256.0 * maxColumnWidth);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0002C43C File Offset: 0x0002A63C
		public void UpdateColumnWidths(global::NPOI.SS.UserModel.IRow row)
		{
			this.ImplicitlyTrackColumnsInRow(row);
			if (this.maxColumnWidths.Count < row.PhysicalNumberOfCells)
			{
				using (global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair>.Enumerator enumerator = this.maxColumnWidths.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair> keyValuePair = enumerator.Current;
						int key = keyValuePair.Key;
						global::NPOI.SS.UserModel.ICell cell = row.GetCell(key);
						if (cell != null)
						{
							global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair value = keyValuePair.Value;
							this.UpdateColumnWidth(cell, value);
						}
					}
					return;
				}
			}
			foreach (global::NPOI.SS.UserModel.ICell cell2 in row)
			{
				int columnIndex = cell2.ColumnIndex;
				if (this.maxColumnWidths.ContainsKey(columnIndex))
				{
					global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair pair = this.maxColumnWidths[columnIndex];
					this.UpdateColumnWidth(cell2, pair);
				}
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0002C530 File Offset: 0x0002A730
		private void ImplicitlyTrackColumnsInRow(global::NPOI.SS.UserModel.IRow row)
		{
			if (this.trackAllColumns)
			{
				foreach (global::NPOI.SS.UserModel.ICell cell in row)
				{
					int columnIndex = cell.ColumnIndex;
					this.ImplicitlyTrackColumn(columnIndex);
				}
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0002C588 File Offset: 0x0002A788
		private void UpdateColumnWidth(global::NPOI.SS.UserModel.ICell cell, global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair pair)
		{
			double cellWidth = global::NPOI.SS.Util.SheetUtil.GetCellWidth(cell, this.defaultCharWidth, this.dataFormatter, false);
			double cellWidth2 = global::NPOI.SS.Util.SheetUtil.GetCellWidth(cell, this.defaultCharWidth, this.dataFormatter, true);
			pair.SetMaxColumnWidths(cellWidth, cellWidth2);
		}

		// Token: 0x040003CE RID: 974
		private int defaultCharWidth;

		// Token: 0x040003CF RID: 975
		private global::NPOI.SS.UserModel.DataFormatter dataFormatter = new global::NPOI.SS.UserModel.DataFormatter();

		// Token: 0x040003D0 RID: 976
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair> maxColumnWidths = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.Streaming.AutoSizeColumnTracker.ColumnWidthPair>();

		// Token: 0x040003D1 RID: 977
		private global::System.Collections.Generic.HashSet<int> untrackedColumns = new global::System.Collections.Generic.HashSet<int>();

		// Token: 0x040003D2 RID: 978
		private bool trackAllColumns;

		// Token: 0x02000145 RID: 325
		private class ColumnWidthPair
		{
			// Token: 0x06001046 RID: 4166 RVA: 0x00039114 File Offset: 0x00037314
			public ColumnWidthPair() : this(-1.0, -1.0)
			{
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x0003912E File Offset: 0x0003732E
			public ColumnWidthPair(double columnWidthSkipMergedCells, double columnWidthUseMergedCells)
			{
				this.withSkipMergedCells = columnWidthSkipMergedCells;
				this.withUseMergedCells = columnWidthUseMergedCells;
			}

			// Token: 0x06001048 RID: 4168 RVA: 0x00039144 File Offset: 0x00037344
			public double GetMaxColumnWidth(bool useMergedCells)
			{
				if (!useMergedCells)
				{
					return this.withSkipMergedCells;
				}
				return this.withUseMergedCells;
			}

			// Token: 0x06001049 RID: 4169 RVA: 0x00039156 File Offset: 0x00037356
			public void SetMaxColumnWidths(double unmergedWidth, double mergedWidth)
			{
				this.withUseMergedCells = global::System.Math.Max(this.withUseMergedCells, mergedWidth);
				this.withSkipMergedCells = global::System.Math.Max(this.withUseMergedCells, unmergedWidth);
			}

			// Token: 0x04000525 RID: 1317
			private double withSkipMergedCells;

			// Token: 0x04000526 RID: 1318
			private double withUseMergedCells;
		}
	}
}
