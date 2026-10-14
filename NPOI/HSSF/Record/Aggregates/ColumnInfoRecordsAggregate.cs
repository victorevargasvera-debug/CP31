using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CD RID: 1229
	public class ColumnInfoRecordsAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate, global::System.ICloneable
	{
		// Token: 0x06002E84 RID: 11908 RVA: 0x000898D8 File Offset: 0x00087AD8
		public ColumnInfoRecordsAggregate()
		{
			this.records = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ColumnInfoRecord>();
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x000898EC File Offset: 0x00087AEC
		public ColumnInfoRecordsAggregate(global::NPOI.HSSF.Model.RecordStream rs) : this()
		{
			bool flag = true;
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = null;
			while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.ColumnInfoRecord))
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = (global::NPOI.HSSF.Record.ColumnInfoRecord)rs.GetNext();
				this.records.Add(columnInfoRecord2);
				if (columnInfoRecord != null && global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator.CompareColInfos(columnInfoRecord, columnInfoRecord2) > 0)
				{
					flag = false;
				}
				columnInfoRecord = columnInfoRecord2;
			}
			if (this.records.Count < 1)
			{
				throw new global::System.InvalidOperationException("No column info records found");
			}
			if (!flag)
			{
				this.records.Sort(global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator.instance);
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00089971 File Offset: 0x00087B71
		public override short Sid
		{
			get
			{
				return -1012;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00089978 File Offset: 0x00087B78
		public int NumColumns
		{
			get
			{
				return this.records.Count;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x00089988 File Offset: 0x00087B88
		public override int RecordSize
		{
			get
			{
				int num = 0;
				foreach (object obj in this.records)
				{
					num += ((global::NPOI.HSSF.Record.ColumnInfoRecord)obj).RecordSize;
				}
				return num;
			}
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000899C6 File Offset: 0x00087BC6
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.records.GetEnumerator();
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000899D8 File Offset: 0x00087BD8
		public object Clone()
		{
			global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate columnInfoRecordsAggregate = new global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate();
			for (int i = 0; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.records[i];
				columnInfoRecord = (global::NPOI.HSSF.Record.ColumnInfoRecord)columnInfoRecord.Clone();
				columnInfoRecordsAggregate.records.Add(columnInfoRecord);
			}
			return columnInfoRecordsAggregate;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00089A27 File Offset: 0x00087C27
		public void InsertColumn(global::NPOI.HSSF.Record.ColumnInfoRecord col)
		{
			this.records.Add(col);
			this.records.Sort(global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator.instance);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00089A45 File Offset: 0x00087C45
		public void InsertColumn(int idx, global::NPOI.HSSF.Record.ColumnInfoRecord col)
		{
			this.records.Insert(idx, col);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00089A54 File Offset: 0x00087C54
		public override int Serialize(int offset, byte[] data)
		{
			global::System.Collections.IEnumerator enumerator = this.records.GetEnumerator();
			int num = offset;
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				num += ((global::NPOI.HSSF.Record.Record)obj).Serialize(num, data);
			}
			return num - offset;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00089A98 File Offset: 0x00087C98
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			int count = this.records.Count;
			if (count < 1)
			{
				return;
			}
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = null;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = this.records[i];
				rv.VisitRecord(columnInfoRecord2);
				if (columnInfoRecord != null && global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator.CompareColInfos(columnInfoRecord, columnInfoRecord2) > 0)
				{
					throw new global::System.InvalidOperationException("Column info records are out of order");
				}
				columnInfoRecord = columnInfoRecord2;
			}
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00089AF4 File Offset: 0x00087CF4
		public int FindStartOfColumnOutlineGroup(int idx)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.records[idx];
			int outlineLevel = columnInfoRecord.OutlineLevel;
			while (idx != 0)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = this.records[idx - 1];
				if (columnInfoRecord.FirstColumn - 1 != columnInfoRecord2.LastColumn || columnInfoRecord2.OutlineLevel < outlineLevel)
				{
					break;
				}
				idx--;
				columnInfoRecord = columnInfoRecord2;
			}
			return idx;
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00089B4C File Offset: 0x00087D4C
		public int FindEndOfColumnOutlineGroup(int idx)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.records[idx];
			int outlineLevel = columnInfoRecord.OutlineLevel;
			while (idx < this.records.Count - 1)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = this.records[idx + 1];
				if (columnInfoRecord.LastColumn + 1 != columnInfoRecord2.FirstColumn || columnInfoRecord2.OutlineLevel < outlineLevel)
				{
					break;
				}
				idx++;
				columnInfoRecord = columnInfoRecord2;
			}
			return idx;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00089BAF File Offset: 0x00087DAF
		public global::NPOI.HSSF.Record.ColumnInfoRecord GetColInfo(int idx)
		{
			return this.records[idx];
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00089BC0 File Offset: 0x00087DC0
		public bool IsColumnGroupCollapsed(int idx)
		{
			int num = this.FindEndOfColumnOutlineGroup(idx);
			int num2 = num + 1;
			if (num2 >= this.records.Count)
			{
				return false;
			}
			global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(num2);
			return this.GetColInfo(num).IsAdjacentBefore(colInfo) && colInfo.IsCollapsed;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00089C08 File Offset: 0x00087E08
		public bool IsColumnGroupHiddenByParent(int idx)
		{
			int num = 0;
			bool result = false;
			int num2 = this.FindEndOfColumnOutlineGroup(idx);
			if (num2 < this.records.Count)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(num2 + 1);
				if (this.GetColInfo(num2).IsAdjacentBefore(colInfo))
				{
					num = colInfo.OutlineLevel;
					result = colInfo.IsHidden;
				}
			}
			int num3 = 0;
			bool result2 = false;
			int num4 = this.FindStartOfColumnOutlineGroup(idx);
			if (num4 > 0)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord colInfo2 = this.GetColInfo(num4 - 1);
				if (colInfo2.IsAdjacentBefore(this.GetColInfo(num4)))
				{
					num3 = colInfo2.OutlineLevel;
					result2 = colInfo2.IsHidden;
				}
			}
			if (num > num3)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00089CA4 File Offset: 0x00087EA4
		public void CollapseColumn(int columnNumber)
		{
			int num = this.FindColInfoIdx(columnNumber, 0);
			if (num == -1)
			{
				return;
			}
			int num2 = this.FindStartOfColumnOutlineGroup(num);
			global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(num2);
			int num3 = this.SetGroupHidden(num2, colInfo.OutlineLevel, true);
			this.SetColumn(num3 + 1, null, null, null, null, new bool?(true));
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00089D18 File Offset: 0x00087F18
		public void ExpandColumn(int columnNumber)
		{
			int num = this.FindColInfoIdx(columnNumber, 0);
			if (num == -1)
			{
				return;
			}
			if (!this.IsColumnGroupCollapsed(num))
			{
				return;
			}
			int num2 = this.FindStartOfColumnOutlineGroup(num);
			global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(num2);
			int num3 = this.FindEndOfColumnOutlineGroup(num);
			this.GetColInfo(num3);
			if (!this.IsColumnGroupHiddenByParent(num))
			{
				for (int i = num2; i <= num3; i++)
				{
					if (colInfo.OutlineLevel == this.GetColInfo(i).OutlineLevel)
					{
						this.GetColInfo(i).IsHidden = false;
					}
				}
			}
			this.SetColumn(colInfo.LastColumn + 1, null, null, null, null, new bool?(false));
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00089DD8 File Offset: 0x00087FD8
		private static void SetColumnInfoFields(global::NPOI.HSSF.Record.ColumnInfoRecord ci, short? xfStyle, int? width, int? level, bool? hidden, bool? collapsed)
		{
			if (xfStyle != null)
			{
				ci.XFIndex = (int)global::System.Convert.ToInt16(xfStyle, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			if (width != null)
			{
				ci.ColumnWidth = global::System.Convert.ToInt32(width, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			if (level != null)
			{
				ci.OutlineLevel = (int)((short)level.Value);
			}
			if (hidden != null)
			{
				ci.IsHidden = global::System.Convert.ToBoolean(hidden, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			if (collapsed != null)
			{
				ci.IsCollapsed = global::System.Convert.ToBoolean(collapsed, global::System.Globalization.CultureInfo.InvariantCulture);
			}
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00089E7C File Offset: 0x0008807C
		private void AttemptMergeColInfoRecords(int colInfoIx)
		{
			int count = this.records.Count;
			if (colInfoIx < 0 || colInfoIx >= count)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"colInfoIx ",
					colInfoIx.ToString(),
					" is out of range (0..",
					(count - 1).ToString(),
					")"
				}));
			}
			global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(colInfoIx);
			int num = colInfoIx + 1;
			if (num < count && global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.MergeColInfoRecords(colInfo, this.GetColInfo(num)))
			{
				this.records.RemoveAt(num);
			}
			if (colInfoIx > 0 && global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.MergeColInfoRecords(this.GetColInfo(colInfoIx - 1), colInfo))
			{
				this.records.RemoveAt(colInfoIx);
			}
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00089F2A File Offset: 0x0008812A
		private static bool MergeColInfoRecords(global::NPOI.HSSF.Record.ColumnInfoRecord ciA, global::NPOI.HSSF.Record.ColumnInfoRecord ciB)
		{
			if (ciA.IsAdjacentBefore(ciB) && ciA.FormatMatches(ciB))
			{
				ciA.LastColumn = ciB.LastColumn;
				return true;
			}
			return false;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00089F50 File Offset: 0x00088150
		private int SetGroupHidden(int pIdx, int level, bool hidden)
		{
			int i = pIdx;
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.GetColInfo(i);
			while (i < this.records.Count)
			{
				columnInfoRecord.IsHidden = hidden;
				if (i + 1 < this.records.Count)
				{
					global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(i + 1);
					if (!columnInfoRecord.IsAdjacentBefore(colInfo) || colInfo.OutlineLevel < level)
					{
						break;
					}
					columnInfoRecord = colInfo;
				}
				i++;
			}
			return columnInfoRecord.LastColumn;
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00089FB8 File Offset: 0x000881B8
		public void SetColumn(int targetColumnIx, short? xfIndex, int? width, int? level, bool? hidden, bool? collapsed)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = null;
			int i;
			for (i = 0; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = this.records[i];
				if (columnInfoRecord2.ContainsColumn(targetColumnIx))
				{
					columnInfoRecord = columnInfoRecord2;
					break;
				}
				if (columnInfoRecord2.FirstColumn > targetColumnIx)
				{
					break;
				}
			}
			if (columnInfoRecord == null)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord3 = new global::NPOI.HSSF.Record.ColumnInfoRecord();
				columnInfoRecord3.FirstColumn = targetColumnIx;
				columnInfoRecord3.LastColumn = targetColumnIx;
				global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.SetColumnInfoFields(columnInfoRecord3, xfIndex, width, level, hidden, collapsed);
				this.InsertColumn(i, columnInfoRecord3);
				this.AttemptMergeColInfoRecords(i);
				return;
			}
			int xfindex = columnInfoRecord.XFIndex;
			short? num = xfIndex;
			int? num2 = (num != null) ? new int?((int)num.GetValueOrDefault()) : null;
			bool flag = !(xfindex == num2.GetValueOrDefault() & num2 != null);
			int columnWidth = columnInfoRecord.ColumnWidth;
			num2 = width;
			bool flag2 = !(columnWidth == num2.GetValueOrDefault() & num2 != null);
			int outlineLevel = columnInfoRecord.OutlineLevel;
			num2 = level;
			bool flag3 = !(outlineLevel == num2.GetValueOrDefault() & num2 != null);
			bool isHidden = columnInfoRecord.IsHidden;
			bool? flag4 = hidden;
			bool flag5 = !(isHidden == flag4.GetValueOrDefault() & flag4 != null);
			bool isCollapsed = columnInfoRecord.IsCollapsed;
			flag4 = collapsed;
			bool flag6 = !(isCollapsed == flag4.GetValueOrDefault() & flag4 != null);
			if (!flag && !flag2 && !flag3 && !flag5 && !flag6)
			{
				return;
			}
			if (columnInfoRecord.FirstColumn == targetColumnIx && columnInfoRecord.LastColumn == targetColumnIx)
			{
				global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.SetColumnInfoFields(columnInfoRecord, xfIndex, width, level, hidden, collapsed);
				this.AttemptMergeColInfoRecords(i);
				return;
			}
			if (columnInfoRecord.FirstColumn == targetColumnIx || columnInfoRecord.LastColumn == targetColumnIx)
			{
				if (columnInfoRecord.FirstColumn == targetColumnIx)
				{
					columnInfoRecord.FirstColumn = targetColumnIx + 1;
				}
				else
				{
					columnInfoRecord.LastColumn = targetColumnIx - 1;
					i++;
				}
				global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord4 = this.CopyColInfo(columnInfoRecord);
				columnInfoRecord4.FirstColumn = targetColumnIx;
				columnInfoRecord4.LastColumn = targetColumnIx;
				global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.SetColumnInfoFields(columnInfoRecord4, xfIndex, width, level, hidden, collapsed);
				this.InsertColumn(i, columnInfoRecord4);
				this.AttemptMergeColInfoRecords(i);
				return;
			}
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord5 = columnInfoRecord;
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord6 = this.CopyColInfo(columnInfoRecord);
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord7 = this.CopyColInfo(columnInfoRecord);
			int lastColumn = columnInfoRecord.LastColumn;
			columnInfoRecord5.LastColumn = targetColumnIx - 1;
			columnInfoRecord6.FirstColumn = targetColumnIx;
			columnInfoRecord6.LastColumn = targetColumnIx;
			global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.SetColumnInfoFields(columnInfoRecord6, xfIndex, width, level, hidden, collapsed);
			this.InsertColumn(++i, columnInfoRecord6);
			columnInfoRecord7.FirstColumn = targetColumnIx + 1;
			columnInfoRecord7.LastColumn = lastColumn;
			this.InsertColumn(i + 1, columnInfoRecord7);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x0008A20D File Offset: 0x0008840D
		private global::NPOI.HSSF.Record.ColumnInfoRecord CopyColInfo(global::NPOI.HSSF.Record.ColumnInfoRecord ci)
		{
			return (global::NPOI.HSSF.Record.ColumnInfoRecord)ci.Clone();
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x0008A21A File Offset: 0x0008841A
		private void SetColumnInfoFields(global::NPOI.HSSF.Record.ColumnInfoRecord ci, short xfStyle, short width, int level, bool hidden, bool collapsed)
		{
			ci.XFIndex = (int)xfStyle;
			ci.ColumnWidth = (int)width;
			ci.OutlineLevel = (int)((short)level);
			ci.IsHidden = hidden;
			ci.IsCollapsed = collapsed;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0008A244 File Offset: 0x00088444
		[global::System.Obsolete("Not found in poi")]
		public void CollapseColInfoRecords(int columnIdx)
		{
			if (columnIdx == 0)
			{
				return;
			}
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.records[columnIdx - 1];
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord2 = this.records[columnIdx];
			if (columnInfoRecord.LastColumn != columnInfoRecord2.FirstColumn - 1)
			{
				return;
			}
			if (columnInfoRecord.XFIndex == columnInfoRecord2.XFIndex && columnInfoRecord.Options == columnInfoRecord2.Options && columnInfoRecord.ColumnWidth == columnInfoRecord2.ColumnWidth)
			{
				columnInfoRecord.LastColumn = columnInfoRecord2.LastColumn;
				this.records.RemoveAt(columnIdx);
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x0008A2CC File Offset: 0x000884CC
		public void GroupColumnRange(int fromColumnIx, int toColumnIx, bool indent)
		{
			int fromColInfoIdx = 0;
			for (int i = fromColumnIx; i <= toColumnIx; i++)
			{
				int num = 1;
				int num2 = this.FindColInfoIdx(i, fromColInfoIdx);
				if (num2 != -1)
				{
					num = this.GetColInfo(num2).OutlineLevel;
					if (indent)
					{
						num++;
					}
					else
					{
						num--;
					}
					num = global::System.Math.Max(0, num);
					num = global::System.Math.Min(7, num);
					fromColInfoIdx = global::System.Math.Max(0, num2 - 1);
				}
				this.SetColumn(i, null, null, new int?(num), null, null);
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x0008A360 File Offset: 0x00088560
		public global::NPOI.HSSF.Record.ColumnInfoRecord FindColumnInfo(int columnIndex)
		{
			int count = this.records.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(i);
				if (colInfo.ContainsColumn(columnIndex))
				{
					return colInfo;
				}
			}
			return null;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x0008A39C File Offset: 0x0008859C
		private int FindColInfoIdx(int columnIx, int fromColInfoIdx)
		{
			if (columnIx < 0)
			{
				throw new global::System.ArgumentException("column parameter out of range: " + columnIx.ToString());
			}
			if (fromColInfoIdx < 0)
			{
				throw new global::System.ArgumentException("fromIdx parameter out of range: " + fromColInfoIdx.ToString());
			}
			for (int i = fromColInfoIdx; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.ColumnInfoRecord colInfo = this.GetColInfo(i);
				if (colInfo.ContainsColumn(columnIx))
				{
					return i;
				}
				if (colInfo.FirstColumn > columnIx)
				{
					break;
				}
			}
			return -1;
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x0008A414 File Offset: 0x00088614
		public int MaxOutlineLevel
		{
			get
			{
				int num = 0;
				int count = this.records.Count;
				for (int i = 0; i < count; i++)
				{
					num = global::System.Math.Max(this.GetColInfo(i).OutlineLevel, num);
				}
				return num;
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x0008A450 File Offset: 0x00088650
		public int GetOutlineLevel(int columnIndex)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this.FindColumnInfo(columnIndex);
			if (columnInfoRecord != null)
			{
				return columnInfoRecord.OutlineLevel;
			}
			return 0;
		}

		// Token: 0x04001461 RID: 5217
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ColumnInfoRecord> records;

		// Token: 0x0200061C RID: 1564
		private class CIRComparator : global::System.Collections.Generic.IComparer<global::NPOI.HSSF.Record.ColumnInfoRecord>
		{
			// Token: 0x060036AC RID: 13996 RVA: 0x0000253E File Offset: 0x0000073E
			private CIRComparator()
			{
			}

			// Token: 0x060036AD RID: 13997 RVA: 0x000A6DA7 File Offset: 0x000A4FA7
			public static int CompareColInfos(global::NPOI.HSSF.Record.ColumnInfoRecord a, global::NPOI.HSSF.Record.ColumnInfoRecord b)
			{
				return a.FirstColumn - b.FirstColumn;
			}

			// Token: 0x060036AE RID: 13998 RVA: 0x000A6DB6 File Offset: 0x000A4FB6
			public int Compare(global::NPOI.HSSF.Record.ColumnInfoRecord x, global::NPOI.HSSF.Record.ColumnInfoRecord y)
			{
				return global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator.CompareColInfos(x, y);
			}

			// Token: 0x04001A96 RID: 6806
			public static global::System.Collections.Generic.IComparer<global::NPOI.HSSF.Record.ColumnInfoRecord> instance = new global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate.CIRComparator();
		}
	}
}
