using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.SS.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D2 RID: 1234
	public class MergedCellsTable : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002ED7 RID: 11991 RVA: 0x0008ADC8 File Offset: 0x00088FC8
		public MergedCellsTable()
		{
			this._mergedRegions = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x0008ADDC File Offset: 0x00088FDC
		public void Read(global::NPOI.HSSF.Model.RecordStream rs)
		{
			while (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.MergeCellsRecord))
			{
				global::NPOI.HSSF.Record.MergeCellsRecord mergeCellsRecord = (global::NPOI.HSSF.Record.MergeCellsRecord)rs.GetNext();
				int numAreas = (int)mergeCellsRecord.NumAreas;
				for (int i = 0; i < numAreas; i++)
				{
					this._mergedRegions.Add(mergeCellsRecord.GetAreaAt(i));
				}
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x0008AE34 File Offset: 0x00089034
		public override int RecordSize
		{
			get
			{
				int count = this._mergedRegions.Count;
				if (count < 1)
				{
					return 0;
				}
				int num = count / 1027;
				int numberOfRanges = count % 1027;
				return num * (4 + global::NPOI.SS.Util.CellRangeAddressList.GetEncodedSize(1027)) + 4 + global::NPOI.SS.Util.CellRangeAddressList.GetEncodedSize(numberOfRanges);
			}
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x0008AE7C File Offset: 0x0008907C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			int count = this._mergedRegions.Count;
			if (count < 1)
			{
				return;
			}
			int num = count / 1027;
			int num2 = count % 1027;
			global::NPOI.SS.Util.CellRangeAddress[] regions = this._mergedRegions.ToArray();
			for (int i = 0; i < num; i++)
			{
				int startIndex = i * 1027;
				rv.VisitRecord(new global::NPOI.HSSF.Record.MergeCellsRecord(regions, startIndex, 1027));
			}
			if (num2 > 0)
			{
				int startIndex2 = num * 1027;
				rv.VisitRecord(new global::NPOI.HSSF.Record.MergeCellsRecord(regions, startIndex2, num2));
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x0008AF00 File Offset: 0x00089100
		public void AddRecords(global::NPOI.HSSF.Record.MergeCellsRecord[] mcrs)
		{
			for (int i = 0; i < mcrs.Length; i++)
			{
				this.AddMergeCellsRecord(mcrs[i]);
			}
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x0008AF24 File Offset: 0x00089124
		private void AddMergeCellsRecord(global::NPOI.HSSF.Record.MergeCellsRecord mcr)
		{
			int numAreas = (int)mcr.NumAreas;
			for (int i = 0; i < numAreas; i++)
			{
				this._mergedRegions.Add(mcr.GetAreaAt(i));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x0008AF56 File Offset: 0x00089156
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergedRegions
		{
			get
			{
				return this._mergedRegions;
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x0008AF5E File Offset: 0x0008915E
		public global::NPOI.SS.Util.CellRangeAddress Get(int index)
		{
			this.CheckIndex(index);
			return this._mergedRegions[index];
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x0008AF73 File Offset: 0x00089173
		public void Remove(int index)
		{
			this.CheckIndex(index);
			this._mergedRegions.RemoveAt(index);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x0008AF88 File Offset: 0x00089188
		private void CheckIndex(int index)
		{
			if (index < 0 || index >= this._mergedRegions.Count)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified CF index ",
					index.ToString(),
					" is outside the allowable range (0..",
					(this._mergedRegions.Count - 1).ToString(),
					")"
				}));
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0008AFF2 File Offset: 0x000891F2
		public void AddArea(int rowFrom, int colFrom, int rowTo, int colTo)
		{
			this._mergedRegions.Add(new global::NPOI.SS.Util.CellRangeAddress(rowFrom, rowTo, colFrom, colTo));
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x0008B009 File Offset: 0x00089209
		public int NumberOfMergedRegions
		{
			get
			{
				return this._mergedRegions.Count;
			}
		}

		// Token: 0x0400146E RID: 5230
		private const int MAX_MERGED_REGIONS = 1027;

		// Token: 0x0400146F RID: 5231
		private global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> _mergedRegions;
	}
}
