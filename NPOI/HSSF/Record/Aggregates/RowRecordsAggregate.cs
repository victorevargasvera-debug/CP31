using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.SS;
using NPOI.SS.Formula;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D8 RID: 1240
	public class RowRecordsAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x0008BC10 File Offset: 0x00089E10
		public RowRecordsAggregate() : this(global::NPOI.HSSF.Record.Aggregates.SharedValueManager.CreateEmpty())
		{
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x0008BC1D File Offset: 0x00089E1D
		private RowRecordsAggregate(global::NPOI.HSSF.Record.Aggregates.SharedValueManager svm)
		{
			this._rowRecords = new global::System.Collections.SortedList();
			this._valuesAgg = new global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate();
			this._unknownRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>();
			this._sharedValueManager = svm;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0008BC5C File Offset: 0x00089E5C
		private int VisitRowRecordsForBlock(int blockIndex, global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			int num = blockIndex * 32;
			int num2 = num + 32;
			global::System.Collections.IEnumerator enumerator = this._rowRecords.Values.GetEnumerator();
			int num3 = 0;
			while (num3 < num && enumerator.MoveNext())
			{
				num3++;
			}
			int num4 = 0;
			while (enumerator.MoveNext() && num3++ < num2)
			{
				global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)enumerator.Current;
				num4 += record.RecordSize;
				rv.VisitRecord(record);
			}
			return num4;
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x0008BCD0 File Offset: 0x00089ED0
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			global::NPOI.HSSF.Record.Aggregates.PositionTrackingVisitor positionTrackingVisitor = new global::NPOI.HSSF.Record.Aggregates.PositionTrackingVisitor(rv, 0);
			int rowBlockCount = this.RowBlockCount;
			for (int i = 0; i < rowBlockCount; i++)
			{
				int num = 0;
				int num2 = this.VisitRowRecordsForBlock(i, rv);
				num += num2;
				int startRowNumberForBlock = this.GetStartRowNumberForBlock(i);
				int endRowNumberForBlock = this.GetEndRowNumberForBlock(i);
				global::NPOI.HSSF.Record.DBCellRecord dbcellRecord = new global::NPOI.HSSF.Record.DBCellRecord();
				int num3 = num2 - 20;
				for (int j = startRowNumberForBlock; j <= endRowNumberForBlock; j++)
				{
					if (this._valuesAgg.RowHasCells(j))
					{
						positionTrackingVisitor.Position = 0;
						this._valuesAgg.VisitCellsForRow(j, positionTrackingVisitor);
						int position = positionTrackingVisitor.Position;
						num += position;
						dbcellRecord.AddCellOffset((short)num3);
						num3 = position;
					}
				}
				dbcellRecord.RowOffset = num;
				rv.VisitRecord(dbcellRecord);
			}
			foreach (global::NPOI.HSSF.Record.Record r in this._unknownRecords)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x0008BDD8 File Offset: 0x00089FD8
		public RowRecordsAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.SharedValueManager svm) : this(svm)
		{
			while (rs.HasNext())
			{
				global::NPOI.HSSF.Record.Record next = rs.GetNext();
				short sid = next.Sid;
				if (sid != 81)
				{
					if (sid != 215)
					{
						if (sid == 520)
						{
							this.InsertRow((global::NPOI.HSSF.Record.RowRecord)next);
						}
						else if (next is global::NPOI.HSSF.Record.UnknownRecord)
						{
							this.AddUnknownRecord((global::NPOI.HSSF.Record.UnknownRecord)next);
							while (rs.PeekNextSid() == 60)
							{
								this.AddUnknownRecord(rs.GetNext());
							}
						}
						else if (next is global::NPOI.HSSF.Record.MulBlankRecord)
						{
							this._valuesAgg.AddMultipleBlanks((global::NPOI.HSSF.Record.MulBlankRecord)next);
						}
						else if (!(next is global::NPOI.HSSF.Record.CellValueRecordInterface))
						{
							if (next.Sid != 4197)
							{
								throw new global::System.InvalidOperationException("Unexpected record type (" + next.GetType().Name + ")");
							}
							this.AddUnknownRecord(next);
						}
						else
						{
							this._valuesAgg.Construct((global::NPOI.HSSF.Record.CellValueRecordInterface)next, rs, svm);
						}
					}
				}
				else
				{
					this.AddUnknownRecord(next);
				}
			}
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x0008BED9 File Offset: 0x0008A0D9
		private void AddUnknownRecord(global::NPOI.HSSF.Record.Record rec)
		{
			this._unknownRecords.Add(rec);
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x0008BEE8 File Offset: 0x0008A0E8
		public void InsertRow(global::NPOI.HSSF.Record.RowRecord row)
		{
			this._rowRecords[row.RowNumber] = row;
			this._rowRecordValues = null;
			if (row.RowNumber < this.firstrow || this.firstrow == -1)
			{
				this.firstrow = row.RowNumber;
			}
			if (row.RowNumber > this.lastrow || this.lastrow == -1)
			{
				this.lastrow = row.RowNumber;
			}
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x0008BF5C File Offset: 0x0008A15C
		public void RemoveRow(global::NPOI.HSSF.Record.RowRecord row)
		{
			int rowNumber = row.RowNumber;
			this._valuesAgg.RemoveAllCellsValuesForRow(rowNumber);
			int num = rowNumber;
			global::NPOI.HSSF.Record.RowRecord rowRecord = (global::NPOI.HSSF.Record.RowRecord)this._rowRecords[num];
			this._rowRecords.Remove(num);
			if (rowRecord == null)
			{
				throw new global::System.Exception("Invalid row index (" + num.ToString() + ")");
			}
			if (row != rowRecord)
			{
				this._rowRecords[num] = rowRecord;
				throw new global::System.Exception("Attempt to remove row that does not belong to this sheet");
			}
			this._rowRecordValues = null;
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x0008BFED File Offset: 0x0008A1ED
		public void InsertCell(global::NPOI.HSSF.Record.CellValueRecordInterface cvRec)
		{
			this._valuesAgg.InsertCell(cvRec);
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x0008BFFB File Offset: 0x0008A1FB
		public void RemoveCell(global::NPOI.HSSF.Record.CellValueRecordInterface cvRec)
		{
			if (cvRec is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)
			{
				((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)cvRec).NotifyFormulaChanging();
			}
			this._valuesAgg.RemoveCell(cvRec);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x0008C01C File Offset: 0x0008A21C
		public global::NPOI.HSSF.Record.RowRecord GetRow(int rowIndex)
		{
			int lastRowIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;
			if (rowIndex < 0 || rowIndex > lastRowIndex)
			{
				throw new global::System.ArgumentException("The row number must be between 0 and " + lastRowIndex.ToString() + ", but had: " + rowIndex.ToString());
			}
			return (global::NPOI.HSSF.Record.RowRecord)this._rowRecords[rowIndex];
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x0008C075 File Offset: 0x0008A275
		public global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate CreateFormula(int row, int col)
		{
			return new global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate(new global::NPOI.HSSF.Record.FormulaRecord
			{
				Row = row,
				Column = (int)((short)col)
			}, null, this._sharedValueManager);
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x0008C097 File Offset: 0x0008A297
		public int PhysicalNumberOfRows
		{
			get
			{
				return this._rowRecords.Count;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x0008C0A4 File Offset: 0x0008A2A4
		public int FirstRowNum
		{
			get
			{
				return this.firstrow;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x0008C0AC File Offset: 0x0008A2AC
		public int LastRowNum
		{
			get
			{
				return this.lastrow;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x0008C0B4 File Offset: 0x0008A2B4
		public int RowBlockCount
		{
			get
			{
				int num = this._rowRecords.Count / 32;
				if (this._rowRecords.Count % 32 != 0)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x0008C0E5 File Offset: 0x0008A2E5
		public int GetRowBlockSize(int block)
		{
			return 20 * this.GetRowCountForBlock(block);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x0008C0F4 File Offset: 0x0008A2F4
		public int GetRowCountForBlock(int block)
		{
			int num = block * 32;
			int num2 = num + 32 - 1;
			if (num2 >= this._rowRecords.Count)
			{
				num2 = this._rowRecords.Count - 1;
			}
			return num2 - num + 1;
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x0008C130 File Offset: 0x0008A330
		public int GetStartRowNumberForBlock(int block)
		{
			int num = block * 32;
			if (this._rowRecordValues == null)
			{
				this._rowRecordValues = new global::NPOI.HSSF.Record.RowRecord[this._rowRecords.Count];
				this._rowRecords.Values.CopyTo(this._rowRecordValues, 0);
			}
			int rowNumber;
			try
			{
				rowNumber = this._rowRecordValues[num].RowNumber;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				throw new global::System.Exception("Did not find start row for block " + block.ToString());
			}
			return rowNumber;
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x0008C1B4 File Offset: 0x0008A3B4
		public int GetEndRowNumberForBlock(int block)
		{
			int num = (block + 1) * 32 - 1;
			if (num >= this._rowRecords.Count)
			{
				num = this._rowRecords.Count - 1;
			}
			if (this._rowRecordValues == null)
			{
				this._rowRecordValues = new global::NPOI.HSSF.Record.RowRecord[this._rowRecords.Count];
				this._rowRecords.Values.CopyTo(this._rowRecordValues, 0);
			}
			int rowNumber;
			try
			{
				rowNumber = this._rowRecordValues[num].RowNumber;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				throw new global::System.Exception("Did not find end row for block " + block.ToString());
			}
			return rowNumber;
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x0008C258 File Offset: 0x0008A458
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._rowRecords.Values.GetEnumerator();
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x0008C26C File Offset: 0x0008A46C
		public int FindStartOfRowOutlineGroup(int row)
		{
			int outlineLevel = (int)this.GetRow(row).OutlineLevel;
			int num = row;
			while (num >= 0 && this.GetRow(num) != null)
			{
				if ((int)this.GetRow(num).OutlineLevel < outlineLevel)
				{
					return num + 1;
				}
				num--;
			}
			return num + 1;
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x0008C2B4 File Offset: 0x0008A4B4
		public int FindEndOfRowOutlineGroup(int row)
		{
			int outlineLevel = (int)this.GetRow(row).OutlineLevel;
			int num = row;
			while (num < this.LastRowNum && this.GetRow(num) != null && (int)this.GetRow(num).OutlineLevel >= outlineLevel)
			{
				num++;
			}
			return num - 1;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x0008C2FC File Offset: 0x0008A4FC
		public int WriteHidden(global::NPOI.HSSF.Record.RowRecord rowRecord, int row, bool hidden)
		{
			int outlineLevel = (int)rowRecord.OutlineLevel;
			while (rowRecord != null && (int)this.GetRow(row).OutlineLevel >= outlineLevel)
			{
				rowRecord.ZeroHeight = hidden;
				row++;
				rowRecord = this.GetRow(row);
			}
			return row - 1;
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x0008C33C File Offset: 0x0008A53C
		public void CollapseRow(int rowNumber)
		{
			int num = this.FindStartOfRowOutlineGroup(rowNumber);
			global::NPOI.HSSF.Record.RowRecord row = this.GetRow(num);
			int num2 = this.WriteHidden(row, num, true);
			if (this.GetRow(num2 + 1) != null)
			{
				this.GetRow(num2 + 1).Colapsed = true;
				return;
			}
			global::NPOI.HSSF.Record.RowRecord rowRecord = global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate.CreateRow(num2 + 1);
			rowRecord.Colapsed = true;
			this.InsertRow(rowRecord);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x0008C398 File Offset: 0x0008A598
		public global::NPOI.HSSF.Record.DimensionsRecord CreateDimensions()
		{
			return new global::NPOI.HSSF.Record.DimensionsRecord
			{
				FirstRow = this.firstrow,
				LastRow = this.lastrow,
				FirstCol = this._valuesAgg.FirstCellNum,
				LastCol = this._valuesAgg.LastCellNum
			};
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0008C3E4 File Offset: 0x0008A5E4
		public static global::NPOI.HSSF.Record.RowRecord CreateRow(int rowNumber)
		{
			return new global::NPOI.HSSF.Record.RowRecord(rowNumber);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x0008C3EC File Offset: 0x0008A5EC
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.CellValueRecordInterface> GetCellValueEnumerator()
		{
			return this._valuesAgg.GetEnumerator();
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x0008C3FC File Offset: 0x0008A5FC
		public global::NPOI.HSSF.Record.IndexRecord CreateIndexRecord(int indexRecordOffset, int sizeOfInitialSheetRecords, int offsetDefaultColWidth)
		{
			global::NPOI.HSSF.Record.IndexRecord indexRecord = new global::NPOI.HSSF.Record.IndexRecord();
			indexRecord.FirstRow = this.firstrow;
			indexRecord.LastRowAdd1 = this.lastrow + 1;
			int rowBlockCount = this.RowBlockCount;
			int recordSizeForBlockCount = global::NPOI.HSSF.Record.IndexRecord.GetRecordSizeForBlockCount(rowBlockCount);
			int num = indexRecordOffset + recordSizeForBlockCount + sizeOfInitialSheetRecords;
			for (int i = 0; i < rowBlockCount; i++)
			{
				num += this.GetRowBlockSize(i);
				num += this._valuesAgg.GetRowCellBlockSize(this.GetStartRowNumberForBlock(i), this.GetEndRowNumberForBlock(i));
				indexRecord.AddDbcell(num);
				num += 8 + this.GetRowCountForBlock(i) * 2;
			}
			return indexRecord;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x0008C490 File Offset: 0x0008A690
		public bool IsRowGroupCollapsed(int row)
		{
			int rowIndex = this.FindEndOfRowOutlineGroup(row) + 1;
			return this.GetRow(rowIndex) != null && this.GetRow(rowIndex).Colapsed;
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x0008C4C0 File Offset: 0x0008A6C0
		public void ExpandRow(int rowNumber)
		{
			if (rowNumber == -1)
			{
				return;
			}
			if (!this.IsRowGroupCollapsed(rowNumber))
			{
				return;
			}
			int num = this.FindStartOfRowOutlineGroup(rowNumber);
			global::NPOI.HSSF.Record.RowRecord row = this.GetRow(num);
			int num2 = this.FindEndOfRowOutlineGroup(rowNumber);
			if (!this.IsRowGroupHiddenByParent(rowNumber))
			{
				for (int i = num; i <= num2; i++)
				{
					if (row.OutlineLevel == this.GetRow(i).OutlineLevel)
					{
						this.GetRow(i).ZeroHeight = false;
					}
					else if (!this.IsRowGroupCollapsed(i))
					{
						this.GetRow(i).ZeroHeight = false;
					}
				}
			}
			this.GetRow(num2 + 1).Colapsed = false;
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x0008C551 File Offset: 0x0008A751
		public void UpdateFormulasAfterRowShift(global::NPOI.SS.Formula.FormulaShifter formulaShifter, int currentExternSheetIndex)
		{
			this._valuesAgg.UpdateFormulasAfterRowShift(formulaShifter, currentExternSheetIndex);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x0008C560 File Offset: 0x0008A760
		public bool IsRowGroupHiddenByParent(int row)
		{
			int num = this.FindEndOfRowOutlineGroup(row);
			int num2;
			bool result;
			if (this.GetRow(num + 1) == null)
			{
				num2 = 0;
				result = false;
			}
			else
			{
				num2 = (int)this.GetRow(num + 1).OutlineLevel;
				result = this.GetRow(num + 1).ZeroHeight;
			}
			int num3 = this.FindStartOfRowOutlineGroup(row);
			int num4;
			bool result2;
			if (num3 - 1 < 0 || this.GetRow(num3 - 1) == null)
			{
				num4 = 0;
				result2 = false;
			}
			else
			{
				num4 = (int)this.GetRow(num3 - 1).OutlineLevel;
				result2 = this.GetRow(num3 - 1).ZeroHeight;
			}
			if (num2 > num4)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x04001485 RID: 5253
		private int firstrow = -1;

		// Token: 0x04001486 RID: 5254
		private int lastrow = -1;

		// Token: 0x04001487 RID: 5255
		private global::System.Collections.SortedList _rowRecords;

		// Token: 0x04001488 RID: 5256
		private global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate _valuesAgg;

		// Token: 0x04001489 RID: 5257
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> _unknownRecords;

		// Token: 0x0400148A RID: 5258
		private global::NPOI.HSSF.Record.Aggregates.SharedValueManager _sharedValueManager;

		// Token: 0x0400148B RID: 5259
		private global::NPOI.HSSF.Record.RowRecord[] _rowRecordValues;
	}
}
