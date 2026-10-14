using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000337 RID: 823
	[global::System.Serializable]
	public class InternalSheet
	{
		// Token: 0x06001781 RID: 6017 RVA: 0x00046A60 File Offset: 0x00044C60
		public global::NPOI.HSSF.Model.InternalSheet CloneSheet()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>(this.records.Count);
			for (int i = 0; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this.records[i];
				if (recordBase is global::NPOI.HSSF.Record.Aggregates.RecordAggregate)
				{
					((global::NPOI.HSSF.Record.Aggregates.RecordAggregate)recordBase).VisitContainedRecords(new global::NPOI.HSSF.Model.InternalSheet.RecordCloner(list));
				}
				else
				{
					if (recordBase is global::NPOI.HSSF.Record.EscherAggregate)
					{
						recordBase = new global::NPOI.HSSF.Record.DrawingRecord();
					}
					try
					{
						global::NPOI.HSSF.Record.Record item = (global::NPOI.HSSF.Record.Record)((global::NPOI.HSSF.Record.Record)recordBase).Clone();
						list.Add(item);
					}
					catch (global::System.NotSupportedException ex)
					{
						throw new global::NPOI.Util.RecordFormatException(ex);
					}
				}
			}
			return global::NPOI.HSSF.Model.InternalSheet.CreateSheet(new global::NPOI.HSSF.Model.RecordStream(list, 0));
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00046B08 File Offset: 0x00044D08
		public global::NPOI.HSSF.Record.WindowTwoRecord WindowTwo
		{
			get
			{
				return this.windowTwo;
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00046B10 File Offset: 0x00044D10
		public static global::NPOI.HSSF.Model.InternalSheet CreateSheet(global::NPOI.HSSF.Model.RecordStream rs)
		{
			return new global::NPOI.HSSF.Model.InternalSheet(rs);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00046B18 File Offset: 0x00044D18
		private InternalSheet(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._mergedCellsTable = new global::NPOI.HSSF.Record.Aggregates.MergedCellsTable();
			global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate rowRecordsAggregate = null;
			this.records = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>(128);
			int num = -1;
			if (rs.PeekNextSid() != 2057)
			{
				throw new global::NPOI.Util.RecordFormatException("BOF record expected");
			}
			global::NPOI.HSSF.Record.BOFRecord bofrecord = (global::NPOI.HSSF.Record.BOFRecord)rs.GetNext();
			if (bofrecord.Type != global::NPOI.HSSF.Record.BOFRecordType.Worksheet && bofrecord.Type != global::NPOI.HSSF.Record.BOFRecordType.Chart)
			{
				if (bofrecord.Type != global::NPOI.HSSF.Record.BOFRecordType.Excel4Macro)
				{
					while (rs.HasNext() && !(rs.GetNext() is global::NPOI.HSSF.Record.EOFRecord))
					{
					}
					throw new global::NPOI.HSSF.Model.UnsupportedBOFType(bofrecord.Type);
				}
			}
			this.records.Add(bofrecord);
			while (rs.HasNext())
			{
				int num2 = rs.PeekNextSid();
				if (num2 == (int)global::NPOI.HSSF.Record.CFHeaderRecord.sid || num2 == (int)global::NPOI.HSSF.Record.CFHeader12Record.sid)
				{
					this.condFormatting = new global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable(rs);
					this.records.Add(this.condFormatting);
				}
				else if (num2 == 125)
				{
					this._columnInfos = new global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate(rs);
					this.records.Add(this._columnInfos);
				}
				else if (num2 == 434)
				{
					this._dataValidityTable = new global::NPOI.HSSF.Record.Aggregates.DataValidityTable(rs);
					this.records.Add(this._dataValidityTable);
				}
				else if (global::NPOI.HSSF.Model.RecordOrderer.IsRowBlockRecord(num2))
				{
					if (rowRecordsAggregate != null)
					{
						throw new global::System.InvalidOperationException("row/cell records found in the wrong place");
					}
					global::NPOI.HSSF.Model.RowBlocksReader rowBlocksReader = new global::NPOI.HSSF.Model.RowBlocksReader(rs);
					this._mergedCellsTable.AddRecords(rowBlocksReader.LooseMergedCells);
					rowRecordsAggregate = new global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate(rowBlocksReader.PlainRecordStream, rowBlocksReader.SharedFormulaManager);
					this.records.Add(rowRecordsAggregate);
				}
				else if (global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate.IsBeginRecord(num2))
				{
					this.records.Add(new global::NPOI.HSSF.Record.Aggregates.CustomViewSettingsRecordAggregate(rs));
				}
				else if (global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.IsComponentRecord(num2))
				{
					if (this._psBlock == null)
					{
						this._psBlock = new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock(rs);
						this.records.Add(this._psBlock);
					}
					else
					{
						this._psBlock.AddLateRecords(rs);
					}
					this._psBlock.PositionRecords(this.records);
				}
				else if (global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.IsComponentRecord(num2))
				{
					this._protectionBlock.AddRecords(rs);
				}
				else if (num2 == 229)
				{
					this._mergedCellsTable.Read(rs);
				}
				else if (num2 == 2057)
				{
					global::NPOI.HSSF.Model.InternalSheet.SpillAggregate(new global::NPOI.HSSF.Record.Aggregates.ChartSubstreamRecordAggregate(rs), this.records);
				}
				else
				{
					global::NPOI.HSSF.Record.Record next = rs.GetNext();
					if (num2 != 523)
					{
						if (num2 == 94)
						{
							this._isUncalced = true;
						}
						else if (num2 == 2152 || num2 == 2151)
						{
							this.records.Add(next);
						}
						else
						{
							if (num2 == 10)
							{
								this.records.Add(next);
								break;
							}
							if (num2 == 512)
							{
								if (this._columnInfos == null)
								{
									this._columnInfos = new global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate();
									this.records.Add(this._columnInfos);
								}
								this._dimensions = (global::NPOI.HSSF.Record.DimensionsRecord)next;
								num = this.records.Count;
							}
							else if (num2 == 85)
							{
								this.defaultcolwidth = (global::NPOI.HSSF.Record.DefaultColWidthRecord)next;
							}
							else if (num2 == 549)
							{
								this.defaultrowheight = (global::NPOI.HSSF.Record.DefaultRowHeightRecord)next;
							}
							else if (num2 == 43)
							{
								this.printGridlines = (global::NPOI.HSSF.Record.PrintGridlinesRecord)next;
							}
							else if (num2 == 42)
							{
								this.printHeaders = (global::NPOI.HSSF.Record.PrintHeadersRecord)next;
							}
							else if (num2 == 130)
							{
								this.gridset = (global::NPOI.HSSF.Record.GridsetRecord)next;
							}
							else if (num2 == 29)
							{
								this._selection = (global::NPOI.HSSF.Record.SelectionRecord)next;
							}
							else if (num2 == 574)
							{
								this.windowTwo = (global::NPOI.HSSF.Record.WindowTwoRecord)next;
							}
							else if (num2 == 2146)
							{
								this.sheetext = (global::NPOI.HSSF.Record.SheetExtRecord)next;
							}
							else if (num2 == 128)
							{
								this._gutsRecord = (global::NPOI.HSSF.Record.GutsRecord)next;
							}
							this.records.Add(next);
						}
					}
				}
			}
			if (this.windowTwo == null)
			{
				throw new global::NPOI.Util.RecordFormatException("WINDOW2 was not found");
			}
			if (this._dimensions == null)
			{
				if (rowRecordsAggregate == null)
				{
					rowRecordsAggregate = new global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate();
				}
				num = this.FindFirstRecordLocBySid(574);
				this._dimensions = rowRecordsAggregate.CreateDimensions();
				this.records.Insert(num, this._dimensions);
			}
			if (rowRecordsAggregate == null)
			{
				rowRecordsAggregate = new global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate();
				this.records.Insert(num + 1, rowRecordsAggregate);
			}
			this._rowsAggregate = rowRecordsAggregate;
			global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, this._mergedCellsTable);
			global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, this._protectionBlock);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00046F9E File Offset: 0x0004519E
		private static void SpillAggregate(global::NPOI.HSSF.Record.Aggregates.RecordAggregate ra, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> recs)
		{
			ra.VisitContainedRecords(new global::NPOI.HSSF.Model.InternalSheet.RecordVisitor1(recs));
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00046FAC File Offset: 0x000451AC
		public static global::NPOI.HSSF.Model.InternalSheet CreateSheet()
		{
			return new global::NPOI.HSSF.Model.InternalSheet();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00046FB4 File Offset: 0x000451B4
		private InternalSheet()
		{
			this._mergedCellsTable = new global::NPOI.HSSF.Record.Aggregates.MergedCellsTable();
			this.records = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>(32);
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateBOF());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateCalcMode());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateCalcCount());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateRefMode());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateIteration());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateDelta());
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateSaveRecalc());
			this.printHeaders = global::NPOI.HSSF.Model.InternalSheet.CreatePrintHeaders();
			this.records.Add(this.printHeaders);
			this.printGridlines = global::NPOI.HSSF.Model.InternalSheet.CreatePrintGridlines();
			this.records.Add(this.printGridlines);
			this.gridset = global::NPOI.HSSF.Model.InternalSheet.CreateGridset();
			this.records.Add(this.gridset);
			this._gutsRecord = global::NPOI.HSSF.Model.InternalSheet.CreateGuts();
			this.records.Add(this._gutsRecord);
			this.defaultrowheight = global::NPOI.HSSF.Model.InternalSheet.CreateDefaultRowHeight();
			this.records.Add(this.defaultrowheight);
			this.records.Add(global::NPOI.HSSF.Model.InternalSheet.CreateWSBool());
			this._psBlock = new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock();
			this.records.Add(this._psBlock);
			this.records.Add(this._protectionBlock);
			this.defaultcolwidth = global::NPOI.HSSF.Model.InternalSheet.CreateDefaultColWidth();
			this.records.Add(this.defaultcolwidth);
			global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate columnInfoRecordsAggregate = new global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate();
			this.records.Add(columnInfoRecordsAggregate);
			this._columnInfos = columnInfoRecordsAggregate;
			this._dimensions = global::NPOI.HSSF.Model.InternalSheet.CreateDimensions();
			this.records.Add(this._dimensions);
			this._rowsAggregate = new global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate();
			this.records.Add(this._rowsAggregate);
			this.records.Add(this.windowTwo = global::NPOI.HSSF.Model.InternalSheet.CreateWindowTwo());
			this._selection = global::NPOI.HSSF.Model.InternalSheet.CreateSelection();
			this.records.Add(this._selection);
			this.records.Add(this._mergedCellsTable);
			this.sheetext = new global::NPOI.HSSF.Record.SheetExtRecord();
			this.records.Add(this.sheetext);
			this.records.Add(global::NPOI.HSSF.Record.EOFRecord.instance);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00047220 File Offset: 0x00045420
		public int AddMergedRegion(int rowFrom, int colFrom, int rowTo, int colTo)
		{
			if (rowTo < rowFrom)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"The 'to' row (",
					rowTo.ToString(),
					") must not be less than the 'from' row (",
					rowFrom.ToString(),
					")"
				}));
			}
			if (colTo < colFrom)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"The 'to' col (",
					colTo.ToString(),
					") must not be less than the 'from' col (",
					colFrom.ToString(),
					")"
				}));
			}
			global::NPOI.HSSF.Record.Aggregates.MergedCellsTable mergedRecords = this.MergedRecords;
			mergedRecords.AddArea(rowFrom, colFrom, rowTo, colTo);
			return mergedRecords.NumberOfMergedRegions - 1;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x000472C8 File Offset: 0x000454C8
		public void RemoveMergedRegion(int index)
		{
			global::NPOI.HSSF.Record.Aggregates.MergedCellsTable mergedRecords = this.MergedRecords;
			if (index >= mergedRecords.NumberOfMergedRegions)
			{
				return;
			}
			mergedRecords.Remove(index);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000472ED File Offset: 0x000454ED
		public global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate ColumnInfos
		{
			get
			{
				return this._columnInfos;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000472F5 File Offset: 0x000454F5
		internal global::NPOI.HSSF.Record.Aggregates.MergedCellsTable MergedRecords
		{
			get
			{
				return this._mergedCellsTable;
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00047300 File Offset: 0x00045500
		public global::NPOI.SS.Util.CellRangeAddress GetMergedRegionAt(int index)
		{
			global::NPOI.HSSF.Record.Aggregates.MergedCellsTable mergedRecords = this.MergedRecords;
			if (index >= mergedRecords.NumberOfMergedRegions)
			{
				return null;
			}
			return mergedRecords.Get(index);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00047326 File Offset: 0x00045526
		public int NumMergedRegions
		{
			get
			{
				return this.MergedRecords.NumberOfMergedRegions;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00047333 File Offset: 0x00045533
		public int NumConditionalFormattings
		{
			get
			{
				return this.condFormatting.Count;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00047340 File Offset: 0x00045540
		public void SetDimensions(int firstrow, short firstcol, int lastrow, short lastcol)
		{
			this.dims.FirstCol = (int)firstcol;
			this.dims.FirstRow = firstrow;
			this.dims.LastCol = (int)lastcol;
			this.dims.LastRow = lastrow;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00047373 File Offset: 0x00045573
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0004737B File Offset: 0x0004557B
		public int PreOffset
		{
			get
			{
				return this.preoffset;
			}
			set
			{
				this.preoffset = value;
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00047384 File Offset: 0x00045584
		public global::NPOI.HSSF.Record.RowRecord CreateRow(int row)
		{
			return global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate.CreateRow(row);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0004738C File Offset: 0x0004558C
		public global::NPOI.HSSF.Record.LabelSSTRecord CreateLabelSST(int row, short col, int index)
		{
			return new global::NPOI.HSSF.Record.LabelSSTRecord
			{
				Row = row,
				Column = (int)col,
				SSTIndex = index,
				XFIndex = 15
			};
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000473B0 File Offset: 0x000455B0
		public global::NPOI.HSSF.Record.NumberRecord CreateNumber(int row, short col, double value)
		{
			return new global::NPOI.HSSF.Record.NumberRecord
			{
				Row = row,
				Column = (int)col,
				Value = value,
				XFIndex = 15
			};
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x000473D4 File Offset: 0x000455D4
		public global::NPOI.HSSF.Record.BlankRecord CreateBlank(int row, short col)
		{
			return new global::NPOI.HSSF.Record.BlankRecord
			{
				Row = row,
				Column = (int)col,
				XFIndex = 15
			};
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000473F4 File Offset: 0x000455F4
		public void AddValueRecord(int row, global::NPOI.HSSF.Record.CellValueRecordInterface col)
		{
			global::NPOI.HSSF.Record.DimensionsRecord dimensions = this._dimensions;
			if (col.Column >= dimensions.LastCol)
			{
				dimensions.LastCol = (int)((short)(col.Column + 1));
			}
			if (col.Column < dimensions.FirstCol)
			{
				dimensions.FirstCol = col.Column;
			}
			this._rowsAggregate.InsertCell(col);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0004744B File Offset: 0x0004564B
		public void RemoveValueRecord(int row, global::NPOI.HSSF.Record.CellValueRecordInterface col)
		{
			global::NPOI.HSSF.Model.InternalSheet.log.Log(1, "Remove value record row " + row.ToString());
			this._rowsAggregate.RemoveCell(col);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00047475 File Offset: 0x00045675
		public void ReplaceValueRecord(global::NPOI.HSSF.Record.CellValueRecordInterface newval)
		{
			this._rowsAggregate.RemoveCell(newval);
			this._rowsAggregate.InsertCell(newval);
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00047490 File Offset: 0x00045690
		public void AddRow(global::NPOI.HSSF.Record.RowRecord row)
		{
			global::NPOI.HSSF.Record.DimensionsRecord dimensions = this._dimensions;
			if (row.RowNumber >= dimensions.LastRow)
			{
				dimensions.LastRow = row.RowNumber + 1;
			}
			if (row.RowNumber < dimensions.FirstRow)
			{
				dimensions.FirstRow = row.RowNumber;
			}
			global::NPOI.HSSF.Record.RowRecord row2 = this._rowsAggregate.GetRow(row.RowNumber);
			if (row2 != null)
			{
				this._rowsAggregate.RemoveRow(row2);
			}
			this._rowsAggregate.InsertRow(row);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00047507 File Offset: 0x00045707
		public void RemoveRow(global::NPOI.HSSF.Record.RowRecord row)
		{
			this._rowsAggregate.RemoveRow(row);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00047515 File Offset: 0x00045715
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.CellValueRecordInterface> GetCellValueIterator()
		{
			return this._rowsAggregate.GetCellValueEnumerator();
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00047522 File Offset: 0x00045722
		public global::NPOI.HSSF.Record.RowRecord NextRow
		{
			get
			{
				if (this.rowRecEnumerator == null)
				{
					this.rowRecEnumerator = this._rowsAggregate.GetEnumerator();
				}
				if (!this.rowRecEnumerator.MoveNext())
				{
					return null;
				}
				return (global::NPOI.HSSF.Record.RowRecord)this.rowRecEnumerator.Current;
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0004755C File Offset: 0x0004575C
		public global::NPOI.HSSF.Record.RowRecord GetRow(int rownum)
		{
			return this._rowsAggregate.GetRow(rownum);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0004756A File Offset: 0x0004576A
		public global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock PageSettings
		{
			get
			{
				if (this._psBlock == null)
				{
					this._psBlock = new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock();
					global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, this._psBlock);
				}
				return this._psBlock;
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00047598 File Offset: 0x00045798
		public static global::NPOI.HSSF.Record.BOFRecord CreateBOF()
		{
			return new global::NPOI.HSSF.Record.BOFRecord
			{
				Version = 1536,
				Type = global::NPOI.HSSF.Record.BOFRecordType.Worksheet,
				Build = 3515,
				BuildYear = 1996,
				HistoryBitMask = 193,
				RequiredVersion = 6
			};
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x000475E5 File Offset: 0x000457E5
		private static global::NPOI.HSSF.Record.IndexRecord CreateIndex()
		{
			return new global::NPOI.HSSF.Record.IndexRecord
			{
				FirstRow = 0,
				LastRowAdd1 = 0
			};
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000475FA File Offset: 0x000457FA
		private static global::NPOI.HSSF.Record.CalcModeRecord CreateCalcMode()
		{
			global::NPOI.HSSF.Record.CalcModeRecord calcModeRecord = new global::NPOI.HSSF.Record.CalcModeRecord();
			calcModeRecord.SetCalcMode(1);
			return calcModeRecord;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00047608 File Offset: 0x00045808
		private static global::NPOI.HSSF.Record.CalcCountRecord CreateCalcCount()
		{
			return new global::NPOI.HSSF.Record.CalcCountRecord
			{
				Iterations = 100
			};
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00047617 File Offset: 0x00045817
		private static global::NPOI.HSSF.Record.RefModeRecord CreateRefMode()
		{
			return new global::NPOI.HSSF.Record.RefModeRecord
			{
				Mode = 1
			};
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00047625 File Offset: 0x00045825
		private static global::NPOI.HSSF.Record.IterationRecord CreateIteration()
		{
			return new global::NPOI.HSSF.Record.IterationRecord(false);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0004762D File Offset: 0x0004582D
		private static global::NPOI.HSSF.Record.DeltaRecord CreateDelta()
		{
			return new global::NPOI.HSSF.Record.DeltaRecord(0.001);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0004763D File Offset: 0x0004583D
		private static global::NPOI.HSSF.Record.SaveRecalcRecord CreateSaveRecalc()
		{
			return new global::NPOI.HSSF.Record.SaveRecalcRecord
			{
				Recalc = true
			};
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0004764B File Offset: 0x0004584B
		private static global::NPOI.HSSF.Record.PrintHeadersRecord CreatePrintHeaders()
		{
			return new global::NPOI.HSSF.Record.PrintHeadersRecord
			{
				PrintHeaders = false
			};
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00047659 File Offset: 0x00045859
		private static global::NPOI.HSSF.Record.PrintGridlinesRecord CreatePrintGridlines()
		{
			return new global::NPOI.HSSF.Record.PrintGridlinesRecord
			{
				PrintGridlines = false
			};
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00047667 File Offset: 0x00045867
		private static global::NPOI.HSSF.Record.GridsetRecord CreateGridset()
		{
			return new global::NPOI.HSSF.Record.GridsetRecord
			{
				Gridset = true
			};
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00047675 File Offset: 0x00045875
		private static global::NPOI.HSSF.Record.GutsRecord CreateGuts()
		{
			return new global::NPOI.HSSF.Record.GutsRecord
			{
				LeftRowGutter = 0,
				TopColGutter = 0,
				RowLevelMax = 0,
				ColLevelMax = 0
			};
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00047698 File Offset: 0x00045898
		private static global::NPOI.HSSF.Record.DefaultRowHeightRecord CreateDefaultRowHeight()
		{
			return new global::NPOI.HSSF.Record.DefaultRowHeightRecord
			{
				OptionFlags = 0,
				RowHeight = 255
			};
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000476B1 File Offset: 0x000458B1
		private static global::NPOI.HSSF.Record.WSBoolRecord CreateWSBool()
		{
			return new global::NPOI.HSSF.Record.WSBoolRecord
			{
				WSBool1 = 4,
				WSBool2 = 1
			};
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x000476C6 File Offset: 0x000458C6
		private static global::NPOI.HSSF.Record.HCenterRecord CreateHCenter()
		{
			return new global::NPOI.HSSF.Record.HCenterRecord
			{
				HCenter = false
			};
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000476D4 File Offset: 0x000458D4
		private static global::NPOI.HSSF.Record.VCenterRecord CreateVCenter()
		{
			return new global::NPOI.HSSF.Record.VCenterRecord
			{
				VCenter = false
			};
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000476E4 File Offset: 0x000458E4
		private static global::NPOI.HSSF.Record.PrintSetupRecord CreatePrintSetup()
		{
			return new global::NPOI.HSSF.Record.PrintSetupRecord
			{
				PaperSize = 1,
				Scale = 100,
				PageStart = 1,
				FitWidth = 1,
				FitHeight = 1,
				Options = 2,
				HResolution = 300,
				VResolution = 300,
				HeaderMargin = 0.5,
				FooterMargin = 0.5,
				Copies = 0
			};
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0004775C File Offset: 0x0004595C
		private static global::NPOI.HSSF.Record.DefaultColWidthRecord CreateDefaultColWidth()
		{
			return new global::NPOI.HSSF.Record.DefaultColWidthRecord
			{
				ColWidth = 8
			};
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0004776A File Offset: 0x0004596A
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00047777 File Offset: 0x00045977
		public int DefaultColumnWidth
		{
			get
			{
				return this.defaultcolwidth.ColWidth;
			}
			set
			{
				this.defaultcolwidth.ColWidth = (int)((short)value);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00047786 File Offset: 0x00045986
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00047793 File Offset: 0x00045993
		public short DefaultRowHeight
		{
			get
			{
				return this.defaultrowheight.RowHeight;
			}
			set
			{
				this.defaultrowheight.RowHeight = value;
				this.defaultrowheight.OptionFlags = 1;
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000477B0 File Offset: 0x000459B0
		public int GetColumnWidth(int columnIndex)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this._columnInfos.FindColumnInfo(columnIndex);
			if (columnInfoRecord != null)
			{
				return columnInfoRecord.ColumnWidth;
			}
			return 256 * this.defaultcolwidth.ColWidth;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000477E8 File Offset: 0x000459E8
		public short GetXFIndexForColAt(short columnIndex)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this._columnInfos.FindColumnInfo((int)columnIndex);
			if (columnInfoRecord != null)
			{
				return (short)columnInfoRecord.XFIndex;
			}
			return 15;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00047810 File Offset: 0x00045A10
		public void SetColumnWidth(int column, int width)
		{
			if (width > 65280)
			{
				throw new global::System.ArgumentException("The maximum column width for an individual cell is 255 characters.");
			}
			this.SetColumn(column, null, new int?(width), null, null, null);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00047864 File Offset: 0x00045A64
		public bool IsColumnHidden(int columnIndex)
		{
			global::NPOI.HSSF.Record.ColumnInfoRecord columnInfoRecord = this._columnInfos.FindColumnInfo(columnIndex);
			return columnInfoRecord != null && columnInfoRecord.IsHidden;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0004788C File Offset: 0x00045A8C
		public void SetColumnHidden(int column, bool hidden)
		{
			this.SetColumn(column, null, null, null, new bool?(hidden), null);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000478CC File Offset: 0x00045ACC
		public void SetDefaultColumnStyle(int column, int styleIndex)
		{
			this.SetColumn(column, new short?((short)styleIndex), null, null, null, null);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0004790B File Offset: 0x00045B0B
		public void SetColumn(int column, int width, int level, bool hidden, bool collapsed)
		{
			this._columnInfos.SetColumn(column, new short?(0), new int?(width), new int?(level), new bool?(hidden), new bool?(collapsed));
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00047939 File Offset: 0x00045B39
		public void SetColumn(int column, short? xfStyle, int? width, int? level, bool? hidden, bool? collapsed)
		{
			this._columnInfos.SetColumn(column, xfStyle, width, level, hidden, collapsed);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00047950 File Offset: 0x00045B50
		private global::NPOI.HSSF.Record.GutsRecord GetGutsRecord()
		{
			if (this._gutsRecord == null)
			{
				global::NPOI.HSSF.Record.GutsRecord gutsRecord = global::NPOI.HSSF.Model.InternalSheet.CreateGuts();
				global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, gutsRecord);
				this._gutsRecord = gutsRecord;
			}
			return this._gutsRecord;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00047984 File Offset: 0x00045B84
		public void GroupColumnRange(int fromColumn, int toColumn, bool indent)
		{
			this._columnInfos.GroupColumnRange(fromColumn, toColumn, indent);
			int maxOutlineLevel = this._columnInfos.MaxOutlineLevel;
			global::NPOI.HSSF.Record.GutsRecord gutsRecord = this.GetGutsRecord();
			gutsRecord.ColLevelMax = (short)(maxOutlineLevel + 1);
			if (maxOutlineLevel == 0)
			{
				gutsRecord.TopColGutter = 0;
				return;
			}
			gutsRecord.TopColGutter = (short)(29 + 12 * (maxOutlineLevel - 1));
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000479D7 File Offset: 0x00045BD7
		private static global::NPOI.HSSF.Record.DimensionsRecord CreateDimensions()
		{
			return new global::NPOI.HSSF.Record.DimensionsRecord
			{
				FirstCol = 0,
				LastRow = 1,
				FirstRow = 0,
				LastCol = 1
			};
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000479FA File Offset: 0x00045BFA
		private static global::NPOI.HSSF.Record.WindowTwoRecord CreateWindowTwo()
		{
			return new global::NPOI.HSSF.Record.WindowTwoRecord
			{
				Options = 1718,
				TopRow = 0,
				LeftCol = 0,
				HeaderColor = 64,
				PageBreakZoom = 0,
				NormalZoom = 0
			};
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00047A30 File Offset: 0x00045C30
		private static global::NPOI.HSSF.Record.SelectionRecord CreateSelection()
		{
			return new global::NPOI.HSSF.Record.SelectionRecord(0, 0);
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00047A39 File Offset: 0x00045C39
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00047A50 File Offset: 0x00045C50
		public short TopRow
		{
			get
			{
				if (this.windowTwo != null)
				{
					return this.windowTwo.TopRow;
				}
				return 0;
			}
			set
			{
				if (this.windowTwo != null)
				{
					this.windowTwo.TopRow = value;
				}
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00047A66 File Offset: 0x00045C66
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00047A7D File Offset: 0x00045C7D
		public short LeftCol
		{
			get
			{
				if (this.windowTwo != null)
				{
					return this.windowTwo.LeftCol;
				}
				return 0;
			}
			set
			{
				if (this.windowTwo != null)
				{
					this.windowTwo.LeftCol = value;
				}
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00047A93 File Offset: 0x00045C93
		public void SetActiveCell(int row, int column)
		{
			this.SetActiveCellRange(row, row, column, column);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00047AA0 File Offset: 0x00045CA0
		public void SetActiveCellRange(int firstRow, int lastRow, int firstColumn, int lastColumn)
		{
			this.SetActiveCellRange(new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit>
			{
				new global::NPOI.SS.Util.CellRangeAddress8Bit(firstRow, lastRow, firstColumn, lastColumn)
			}, 0, firstRow, firstColumn);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00047ACD File Offset: 0x00045CCD
		public void SetActiveCellRange(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress8Bit> cellranges, int activeRange, int activeRow, int activeColumn)
		{
			this._selection.ActiveCellCol = activeColumn;
			this._selection.ActiveCellRow = activeRow;
			this._selection.ActiveCellRef = activeRange;
			this._selection.CellReferences = cellranges.ToArray();
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00047B05 File Offset: 0x00045D05
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x00047B1C File Offset: 0x00045D1C
		public int ActiveCellRow
		{
			get
			{
				if (this._selection == null)
				{
					return 0;
				}
				return this._selection.ActiveCellRow;
			}
			set
			{
				if (this._selection != null)
				{
					this._selection.ActiveCellRow = value;
				}
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x00047B32 File Offset: 0x00045D32
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x00047B49 File Offset: 0x00045D49
		public int ActiveCellCol
		{
			get
			{
				if (this._selection == null)
				{
					return 0;
				}
				return this._selection.ActiveCellCol;
			}
			set
			{
				if (this._selection != null)
				{
					this._selection.ActiveCellCol = value;
				}
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00047B5F File Offset: 0x00045D5F
		protected global::NPOI.HSSF.Record.Record CreateEOF()
		{
			return new global::NPOI.HSSF.Record.EOFRecord();
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00047B66 File Offset: 0x00045D66
		public global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> Records
		{
			get
			{
				return this.records;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00047B6E File Offset: 0x00045D6E
		public global::NPOI.HSSF.Record.GridsetRecord GridsetRecord
		{
			get
			{
				return this.gridset;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00047B78 File Offset: 0x00045D78
		private global::NPOI.HSSF.Record.GutsRecord GutsRecord
		{
			get
			{
				if (this._gutsRecord == null)
				{
					global::NPOI.HSSF.Record.GutsRecord gutsRecord = global::NPOI.HSSF.Model.InternalSheet.CreateGuts();
					global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, gutsRecord);
					this._gutsRecord = gutsRecord;
				}
				return this._gutsRecord;
			}
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00047BAC File Offset: 0x00045DAC
		public global::NPOI.HSSF.Record.Record FindFirstRecordBySid(short sid)
		{
			int num = this.FindFirstRecordLocBySid(sid);
			if (num < 0)
			{
				return null;
			}
			return (global::NPOI.HSSF.Record.Record)this.records[num];
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00047BD8 File Offset: 0x00045DD8
		public void SetSCLRecord(global::NPOI.HSSF.Record.SCLRecord sclRecord)
		{
			int num = this.FindFirstRecordLocBySid(160);
			if (num == -1)
			{
				int num2 = this.FindFirstRecordLocBySid(574);
				this.records.Insert(num2 + 1, sclRecord);
				return;
			}
			this.records[num] = sclRecord;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00047C20 File Offset: 0x00045E20
		public int FindFirstRecordLocBySid(short sid)
		{
			int count = this.records.Count;
			for (int i = 0; i < count; i++)
			{
				object obj = this.records[i];
				if (obj is global::NPOI.HSSF.Record.Record && ((global::NPOI.HSSF.Record.Record)obj).Sid == sid)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00047C6B File Offset: 0x00045E6B
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00047C73 File Offset: 0x00045E73
		public global::NPOI.HSSF.Record.HeaderRecord Header
		{
			get
			{
				return this.header;
			}
			set
			{
				this.header = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00047C7C File Offset: 0x00045E7C
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00047C89 File Offset: 0x00045E89
		public bool IsAutoTabColor
		{
			get
			{
				return this.sheetext.IsAutoColor;
			}
			set
			{
				this.sheetext.IsAutoColor = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00047C97 File Offset: 0x00045E97
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x00047CA4 File Offset: 0x00045EA4
		public short TabColorIndex
		{
			get
			{
				return this.sheetext.TabColorIndex;
			}
			set
			{
				if ((value <= 8 || value >= 63) && value != 127)
				{
					throw new global::System.ArgumentException("invalid color index");
				}
				this.sheetext.TabColorIndex = value;
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00046B08 File Offset: 0x00044D08
		public global::NPOI.HSSF.Record.WindowTwoRecord GetWindowTwo()
		{
			return this.windowTwo;
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00047CCB File Offset: 0x00045ECB
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00047CD3 File Offset: 0x00045ED3
		public global::NPOI.HSSF.Record.FooterRecord Footer
		{
			get
			{
				return this.footer;
			}
			set
			{
				this.footer = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00047CDC File Offset: 0x00045EDC
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00047CE4 File Offset: 0x00045EE4
		public global::NPOI.HSSF.Record.PrintSetupRecord PrintSetup
		{
			get
			{
				return this.printSetup;
			}
			set
			{
				this.printSetup = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00047CF0 File Offset: 0x00045EF0
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00047D39 File Offset: 0x00045F39
		public bool IsGridsPrinted
		{
			get
			{
				if (this.gridset == null)
				{
					this.gridset = global::NPOI.HSSF.Model.InternalSheet.CreateGridset();
					int index = this.FindFirstRecordLocBySid(10);
					this.records.Insert(index, this.gridset);
				}
				return !this.gridset.Gridset;
			}
			set
			{
				this.gridset.Gridset = !value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00047D4A File Offset: 0x00045F4A
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00047D52 File Offset: 0x00045F52
		public global::NPOI.HSSF.Record.PrintGridlinesRecord PrintGridlines
		{
			get
			{
				return this.printGridlines;
			}
			set
			{
				this.printGridlines = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00047D5B File Offset: 0x00045F5B
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x00047D63 File Offset: 0x00045F63
		public global::NPOI.HSSF.Record.PrintHeadersRecord PrintHeaders
		{
			get
			{
				return this.printHeaders;
			}
			set
			{
				this.printHeaders = value;
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00047D6C File Offset: 0x00045F6C
		public void SetSelected(bool sel)
		{
			this.windowTwo.IsSelected = sel;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00047D7C File Offset: 0x00045F7C
		public void CreateFreezePane(int colSplit, int rowSplit, int topRow, int leftmostColumn)
		{
			int num = this.FindFirstRecordLocBySid(65);
			if (num != -1)
			{
				this.records.RemoveAt(num);
			}
			if (colSplit == 0 && rowSplit == 0)
			{
				this.windowTwo.FreezePanes = false;
				this.windowTwo.FreezePanesNoSplit = false;
				((global::NPOI.HSSF.Record.SelectionRecord)this.FindFirstRecordBySid(29)).Pane = 3;
				return;
			}
			int num2 = this.FindFirstRecordLocBySid(574);
			global::NPOI.HSSF.Record.PaneRecord paneRecord = new global::NPOI.HSSF.Record.PaneRecord();
			paneRecord.X = (short)colSplit;
			paneRecord.Y = (short)rowSplit;
			paneRecord.TopRow = (short)topRow;
			paneRecord.LeftColumn = (short)leftmostColumn;
			if (rowSplit == 0)
			{
				paneRecord.TopRow = 0;
				paneRecord.ActivePane = 1;
			}
			else if (colSplit == 0)
			{
				paneRecord.LeftColumn = 0;
				paneRecord.ActivePane = 2;
			}
			else
			{
				paneRecord.ActivePane = 0;
			}
			this.records.Insert(num2 + 1, paneRecord);
			this.windowTwo.FreezePanes = true;
			this.windowTwo.FreezePanesNoSplit = true;
			((global::NPOI.HSSF.Record.SelectionRecord)this.FindFirstRecordBySid(29)).Pane = (byte)paneRecord.ActivePane;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00047E74 File Offset: 0x00046074
		public void CreateSplitPane(int xSplitPos, int ySplitPos, int topRow, int leftmostColumn, global::NPOI.SS.UserModel.PanePosition activePane)
		{
			int num = this.FindFirstRecordLocBySid(65);
			if (num != -1)
			{
				this.records.RemoveAt(num);
			}
			int num2 = this.FindFirstRecordLocBySid(574);
			global::NPOI.HSSF.Record.PaneRecord paneRecord = new global::NPOI.HSSF.Record.PaneRecord();
			paneRecord.X = (short)xSplitPos;
			paneRecord.Y = (short)ySplitPos;
			paneRecord.TopRow = (short)topRow;
			paneRecord.LeftColumn = (short)leftmostColumn;
			paneRecord.ActivePane = (short)activePane;
			this.records.Insert(num2 + 1, paneRecord);
			this.windowTwo.FreezePanes = false;
			this.windowTwo.FreezePanesNoSplit = false;
			((global::NPOI.HSSF.Record.SelectionRecord)this.FindFirstRecordBySid(29)).Pane = 0;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00047F10 File Offset: 0x00046110
		public global::NPOI.SS.Util.PaneInformation PaneInformation
		{
			get
			{
				global::NPOI.HSSF.Record.PaneRecord paneRecord = (global::NPOI.HSSF.Record.PaneRecord)this.FindFirstRecordBySid(65);
				if (paneRecord == null)
				{
					return null;
				}
				return new global::NPOI.SS.Util.PaneInformation(paneRecord.X, paneRecord.Y, paneRecord.TopRow, paneRecord.LeftColumn, (byte)paneRecord.ActivePane, this.windowTwo.FreezePanes);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00047F5F File Offset: 0x0004615F
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x00047F67 File Offset: 0x00046167
		public global::NPOI.HSSF.Record.SelectionRecord Selection
		{
			get
			{
				return this._selection;
			}
			set
			{
				this._selection = value;
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00047F70 File Offset: 0x00046170
		protected static global::NPOI.HSSF.Record.PasswordRecord CreatePassword()
		{
			return new global::NPOI.HSSF.Record.PasswordRecord(0);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00047F78 File Offset: 0x00046178
		protected global::NPOI.HSSF.Record.ProtectRecord CreateProtect()
		{
			return new global::NPOI.HSSF.Record.ProtectRecord(false);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00047F80 File Offset: 0x00046180
		protected global::NPOI.HSSF.Record.ObjectProtectRecord CreateObjectProtect()
		{
			return new global::NPOI.HSSF.Record.ObjectProtectRecord
			{
				Protect = false
			};
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00047F8E File Offset: 0x0004618E
		protected global::NPOI.HSSF.Record.ScenarioProtectRecord CreateScenarioProtect()
		{
			return new global::NPOI.HSSF.Record.ScenarioProtectRecord
			{
				Protect = false
			};
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00047F9C File Offset: 0x0004619C
		public global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock ProtectionBlock
		{
			get
			{
				return this._protectionBlock;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00047FA4 File Offset: 0x000461A4
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00047FB1 File Offset: 0x000461B1
		public bool DisplayGridlines
		{
			get
			{
				return this.windowTwo.DisplayGridlines;
			}
			set
			{
				this.windowTwo.DisplayGridlines = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00047FBF File Offset: 0x000461BF
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00047FCC File Offset: 0x000461CC
		public bool DisplayFormulas
		{
			get
			{
				return this.windowTwo.DisplayFormulas;
			}
			set
			{
				this.windowTwo.DisplayFormulas = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00047FDA File Offset: 0x000461DA
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x00047FE7 File Offset: 0x000461E7
		public bool DisplayRowColHeadings
		{
			get
			{
				return this.windowTwo.DisplayRowColHeadings;
			}
			set
			{
				this.windowTwo.DisplayRowColHeadings = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00047FDA File Offset: 0x000461DA
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00047FE7 File Offset: 0x000461E7
		public bool IsPrintRowColHeadings
		{
			get
			{
				return this.windowTwo.DisplayRowColHeadings;
			}
			set
			{
				this.windowTwo.DisplayRowColHeadings = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00047FF5 File Offset: 0x000461F5
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00047FFD File Offset: 0x000461FD
		public bool IsUncalced
		{
			get
			{
				return this._isUncalced;
			}
			set
			{
				this._isUncalced = value;
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00048008 File Offset: 0x00046208
		public int AggregateDrawingRecords(global::NPOI.HSSF.Model.DrawingManager2 drawingManager, bool CreateIfMissing)
		{
			int num = this.FindFirstRecordLocBySid(236);
			if (num != -1)
			{
				global::NPOI.HSSF.Record.EscherAggregate.CreateAggregate(this.records, num);
				return num;
			}
			if (!CreateIfMissing)
			{
				return -1;
			}
			global::NPOI.HSSF.Record.EscherAggregate item = new global::NPOI.HSSF.Record.EscherAggregate(true);
			num = this.FindFirstRecordLocBySid(9876);
			if (num == -1)
			{
				num = this.FindFirstRecordLocBySid(574);
			}
			else
			{
				this.Records.RemoveAt(num);
			}
			this.Records.Insert(num, item);
			return num;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0004807C File Offset: 0x0004627C
		public void Preserialize()
		{
			foreach (object obj in this.Records)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = (global::NPOI.HSSF.Record.RecordBase)obj;
				if (recordBase is global::NPOI.HSSF.Record.EscherAggregate)
				{
					int recordSize = recordBase.RecordSize;
				}
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000480C0 File Offset: 0x000462C0
		public void ShiftBreaks(global::NPOI.HSSF.Record.PageBreakRecord breaks, short start, short stop, int count)
		{
			if (this.rowBreaks == null)
			{
				return;
			}
			global::System.Collections.IEnumerator enumerator = breaks.GetBreaksEnumerator();
			global::System.Collections.IList list = new global::System.Collections.ArrayList();
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = (global::NPOI.HSSF.Record.PageBreakRecord.Break)obj;
				int main = @break.main;
				bool flag = main >= (int)start;
				bool flag2 = main <= (int)stop;
				if (flag && flag2)
				{
					list.Add(@break);
				}
			}
			foreach (object obj2 in list)
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break break2 = (global::NPOI.HSSF.Record.PageBreakRecord.Break)obj2;
				breaks.RemoveBreak(break2.main);
				breaks.AddBreak(break2.main + count, break2.subFrom, break2.subTo);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00048166 File Offset: 0x00046366
		public void ShiftRowBreaks(int startingRow, int endingRow, int count)
		{
			this.ShiftBreaks(this.rowBreaks, (short)startingRow, (short)endingRow, (int)((short)count));
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0004817A File Offset: 0x0004637A
		public void ShiftColumnBreaks(short startingCol, short endingCol, short count)
		{
			this.ShiftBreaks(this.colBreaks, startingCol, endingCol, (int)count);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0004818B File Offset: 0x0004638B
		public void SetColumnGroupCollapsed(int columnNumber, bool collapsed)
		{
			if (collapsed)
			{
				this._columnInfos.CollapseColumn(columnNumber);
				return;
			}
			this._columnInfos.ExpandColumn(columnNumber);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x000481A9 File Offset: 0x000463A9
		public global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate RowsAggregate
		{
			get
			{
				return this._rowsAggregate;
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000481B1 File Offset: 0x000463B1
		public void UpdateFormulasAfterCellShift(global::NPOI.SS.Formula.FormulaShifter shifter, int externSheetIndex)
		{
			this.RowsAggregate.UpdateFormulasAfterRowShift(shifter, externSheetIndex);
			if (this.condFormatting != null)
			{
				this.ConditionalFormattingTable.UpdateFormulasAfterCellShift(shifter, externSheetIndex);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x000481D5 File Offset: 0x000463D5
		public global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable ConditionalFormattingTable
		{
			get
			{
				if (this.condFormatting == null)
				{
					this.condFormatting = new global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable();
					global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, this.condFormatting);
				}
				return this.condFormatting;
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00048204 File Offset: 0x00046404
		public void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv, int offset)
		{
			global::NPOI.HSSF.Record.Aggregates.PositionTrackingVisitor positionTrackingVisitor = new global::NPOI.HSSF.Record.Aggregates.PositionTrackingVisitor(rv, offset);
			bool flag = false;
			int num = offset;
			for (int i = 0; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this.records[i];
				if (recordBase is global::NPOI.HSSF.Record.Aggregates.RecordAggregate)
				{
					global::NPOI.HSSF.Record.Aggregates.RecordAggregate recordAggregate = (global::NPOI.HSSF.Record.Aggregates.RecordAggregate)recordBase;
					recordAggregate.VisitContainedRecords(positionTrackingVisitor);
					num += recordAggregate.RecordSize;
				}
				else
				{
					if (recordBase is global::NPOI.HSSF.Record.DefaultColWidthRecord)
					{
						((global::NPOI.HSSF.Record.DefaultColWidthRecord)recordBase).offsetForFilePointer = num;
					}
					positionTrackingVisitor.VisitRecord((global::NPOI.HSSF.Record.Record)recordBase);
					num += recordBase.RecordSize;
				}
				if (recordBase is global::NPOI.HSSF.Record.BOFRecord && !flag)
				{
					flag = true;
					if (this._isUncalced)
					{
						global::NPOI.HSSF.Record.UncalcedRecord uncalcedRecord = new global::NPOI.HSSF.Record.UncalcedRecord();
						positionTrackingVisitor.VisitRecord(uncalcedRecord);
						num += uncalcedRecord.RecordSize;
					}
					if (this._rowsAggregate != null)
					{
						int sizeOfInitialSheetRecords = this.GetSizeOfInitialSheetRecords(i);
						int position = positionTrackingVisitor.Position;
						global::NPOI.HSSF.Record.IndexRecord indexRecord = this._rowsAggregate.CreateIndexRecord(position, sizeOfInitialSheetRecords, 0);
						positionTrackingVisitor.VisitRecord(indexRecord);
						num += indexRecord.RecordSize;
					}
				}
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00048308 File Offset: 0x00046508
		private int GetSizeOfInitialSheetRecords(int bofRecordIndex)
		{
			int num = 0;
			for (int i = bofRecordIndex + 1; i < this.records.Count; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this.records[i];
				if (recordBase is global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate)
				{
					break;
				}
				num += recordBase.RecordSize;
			}
			if (this._isUncalced)
			{
				num += global::NPOI.HSSF.Record.UncalcedRecord.StaticRecordSize;
			}
			return num;
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00048360 File Offset: 0x00046560
		public void GroupRowRange(int fromRow, int toRow, bool indent)
		{
			for (int i = fromRow; i <= toRow; i++)
			{
				global::NPOI.HSSF.Record.RowRecord rowRecord = this.GetRow(i);
				if (rowRecord == null)
				{
					rowRecord = this.CreateRow(i);
					this.AddRow(rowRecord);
				}
				int num = (int)rowRecord.OutlineLevel;
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
				rowRecord.OutlineLevel = (short)num;
			}
			this.RecalcRowGutter();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000483C8 File Offset: 0x000465C8
		private void RecalcRowGutter()
		{
			int num = 0;
			foreach (object obj in this._rowsAggregate)
			{
				num = global::System.Math.Max((int)((global::NPOI.HSSF.Record.RowRecord)obj).OutlineLevel, num);
			}
			global::NPOI.HSSF.Record.GutsRecord gutsRecord = this.GetGutsRecord();
			if (gutsRecord == null)
			{
				gutsRecord = new global::NPOI.HSSF.Record.GutsRecord();
				this.records.Add(gutsRecord);
			}
			gutsRecord.RowLevelMax = (short)(num + 1);
			gutsRecord.LeftRowGutter = (short)(29 + 12 * num);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00048438 File Offset: 0x00046638
		public global::NPOI.HSSF.Record.Aggregates.DataValidityTable GetOrCreateDataValidityTable()
		{
			if (this._dataValidityTable == null)
			{
				this._dataValidityTable = new global::NPOI.HSSF.Record.Aggregates.DataValidityTable();
				global::NPOI.HSSF.Model.RecordOrderer.AddNewSheetRecord(this.records, this._dataValidityTable);
			}
			return this._dataValidityTable;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00048464 File Offset: 0x00046664
		public global::NPOI.HSSF.Record.NoteRecord[] GetNoteRecords()
		{
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.NoteRecord> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.NoteRecord>();
			for (int i = this.records.Count - 1; i >= 0; i--)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this.records[i];
				if (recordBase is global::NPOI.HSSF.Record.NoteRecord)
				{
					list.Add((global::NPOI.HSSF.Record.NoteRecord)recordBase);
				}
			}
			if (list.Count < 1)
			{
				return global::NPOI.HSSF.Record.NoteRecord.EMPTY_ARRAY;
			}
			new global::NPOI.HSSF.Record.NoteRecord[list.Count];
			return list.ToArray();
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000484D1 File Offset: 0x000466D1
		public int GetColumnOutlineLevel(int columnIndex)
		{
			return this._columnInfos.GetOutlineLevel(columnIndex);
		}

		// Token: 0x040009A8 RID: 2472
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Model.InternalSheet));

		// Token: 0x040009A9 RID: 2473
		private int preoffset;

		// Token: 0x040009AA RID: 2474
		protected int dimsloc = -1;

		// Token: 0x040009AB RID: 2475
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.DimensionsRecord dims;

		// Token: 0x040009AC RID: 2476
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.DefaultColWidthRecord defaultcolwidth = new global::NPOI.HSSF.Record.DefaultColWidthRecord();

		// Token: 0x040009AD RID: 2477
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.DefaultRowHeightRecord defaultrowheight = new global::NPOI.HSSF.Record.DefaultRowHeightRecord();

		// Token: 0x040009AE RID: 2478
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.GridsetRecord gridset;

		// Token: 0x040009AF RID: 2479
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.PrintSetupRecord printSetup;

		// Token: 0x040009B0 RID: 2480
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.HeaderRecord header;

		// Token: 0x040009B1 RID: 2481
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.FooterRecord footer;

		// Token: 0x040009B2 RID: 2482
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.PrintGridlinesRecord printGridlines;

		// Token: 0x040009B3 RID: 2483
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.PrintHeadersRecord printHeaders;

		// Token: 0x040009B4 RID: 2484
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.WindowTwoRecord windowTwo;

		// Token: 0x040009B5 RID: 2485
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.MergeCellsRecord merged;

		// Token: 0x040009B6 RID: 2486
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.Aggregates.MergedCellsTable _mergedCellsTable;

		// Token: 0x040009B7 RID: 2487
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.Aggregates.RowRecordsAggregate _rowsAggregate;

		// Token: 0x040009B8 RID: 2488
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psBlock;

		// Token: 0x040009B9 RID: 2489
		protected global::NPOI.HSSF.Record.IMargin[] margins;

		// Token: 0x040009BA RID: 2490
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.SelectionRecord _selection;

		// Token: 0x040009BB RID: 2491
		[global::System.NonSerialized]
		internal global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate _columnInfos;

		// Token: 0x040009BC RID: 2492
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.DimensionsRecord _dimensions;

		// Token: 0x040009BD RID: 2493
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.Aggregates.DataValidityTable _dataValidityTable;

		// Token: 0x040009BE RID: 2494
		private global::System.Collections.IEnumerator rowRecEnumerator;

		// Token: 0x040009BF RID: 2495
		protected int eofLoc;

		// Token: 0x040009C0 RID: 2496
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.GutsRecord _gutsRecord;

		// Token: 0x040009C1 RID: 2497
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.PageBreakRecord rowBreaks;

		// Token: 0x040009C2 RID: 2498
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.PageBreakRecord colBreaks;

		// Token: 0x040009C3 RID: 2499
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable condFormatting;

		// Token: 0x040009C4 RID: 2500
		[global::System.NonSerialized]
		protected global::NPOI.HSSF.Record.SheetExtRecord sheetext;

		// Token: 0x040009C5 RID: 2501
		protected global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records;

		// Token: 0x040009C6 RID: 2502
		protected bool _isUncalced;

		// Token: 0x040009C7 RID: 2503
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock _protectionBlock = new global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock();

		// Token: 0x020005C6 RID: 1478
		private class RecordCloner : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x060034F9 RID: 13561 RVA: 0x000A4B53 File Offset: 0x000A2D53
			public RecordCloner(global::System.Collections.Generic.IList<global::NPOI.HSSF.Record.Record> destList)
			{
				this._destList = destList;
			}

			// Token: 0x060034FA RID: 13562 RVA: 0x000A4B64 File Offset: 0x000A2D64
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				try
				{
					this._destList.Add((global::NPOI.HSSF.Record.Record)r.Clone());
				}
				catch (global::System.NotSupportedException ex)
				{
					throw new global::NPOI.Util.RecordFormatException(ex);
				}
			}

			// Token: 0x0400197E RID: 6526
			private global::System.Collections.Generic.IList<global::NPOI.HSSF.Record.Record> _destList;
		}

		// Token: 0x020005C7 RID: 1479
		private class RecordVisitor1 : global::NPOI.HSSF.Record.Aggregates.RecordVisitor
		{
			// Token: 0x060034FB RID: 13563 RVA: 0x000A4BA0 File Offset: 0x000A2DA0
			public RecordVisitor1(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> recs)
			{
				this._records = recs;
			}

			// Token: 0x060034FC RID: 13564 RVA: 0x000A4BAF File Offset: 0x000A2DAF
			public void VisitRecord(global::NPOI.HSSF.Record.Record r)
			{
				this._records.Add(r);
			}

			// Token: 0x0400197F RID: 6527
			private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> _records;
		}
	}
}
