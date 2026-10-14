using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004DA RID: 1242
	public class ValueRecordsAggregate : global::System.Collections.Generic.IEnumerable<global::NPOI.HSSF.Record.CellValueRecordInterface>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002F47 RID: 12103 RVA: 0x0008CA36 File Offset: 0x0008AC36
		public ValueRecordsAggregate() : this(-1, -1, new global::NPOI.HSSF.Record.CellValueRecordInterface[30][])
		{
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0008CA47 File Offset: 0x0008AC47
		private ValueRecordsAggregate(int firstCellIx, int lastCellIx, global::NPOI.HSSF.Record.CellValueRecordInterface[][] pRecords)
		{
			this.firstcell = firstCellIx;
			this.lastcell = lastCellIx;
			this.records = pRecords;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0008CA74 File Offset: 0x0008AC74
		public void InsertCell(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			int column = cell.Column;
			int row = cell.Row;
			if (row >= this.records.Length)
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface[][] array = this.records;
				int num = array.Length * 2;
				if (num < row + 1)
				{
					num = row + 1;
				}
				this.records = new global::NPOI.HSSF.Record.CellValueRecordInterface[num][];
				global::System.Array.Copy(array, 0, this.records, 0, array.Length);
			}
			object obj = this.records[row];
			if (obj == null)
			{
				int num2 = column + 1;
				if (num2 < 10)
				{
					num2 = 10;
				}
				obj = new global::NPOI.HSSF.Record.CellValueRecordInterface[num2];
				this.records[row] = (global::NPOI.HSSF.Record.CellValueRecordInterface[])obj;
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface[] array2 = (global::NPOI.HSSF.Record.CellValueRecordInterface[])obj;
			if (column >= array2.Length)
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface[] array3 = array2;
				int num3 = array3.Length * 2;
				if (num3 < column + 1)
				{
					num3 = column + 1;
				}
				array2 = new global::NPOI.HSSF.Record.CellValueRecordInterface[num3];
				global::System.Array.Copy(array3, 0, array2, 0, array3.Length);
				this.records[row] = array2;
			}
			array2[column] = cell;
			if (column < this.firstcell || this.firstcell == -1)
			{
				this.firstcell = column;
			}
			if (column > this.lastcell || this.lastcell == -1)
			{
				this.lastcell = column;
			}
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x0008CB80 File Offset: 0x0008AD80
		public void RemoveCell(global::NPOI.HSSF.Record.CellValueRecordInterface cell)
		{
			if (cell == null)
			{
				throw new global::System.ArgumentException("cell must not be null");
			}
			int row = cell.Row;
			if (row >= this.records.Length)
			{
				throw new global::System.Exception("cell row is out of range");
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface[] array = this.records[row];
			if (array == null)
			{
				throw new global::System.Exception("cell row is already empty");
			}
			int column = cell.Column;
			if (column >= array.Length)
			{
				throw new global::System.Exception("cell column is out of range");
			}
			array[column] = null;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0008CBEC File Offset: 0x0008ADEC
		public void RemoveAllCellsValuesForRow(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex > 65535)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified rowIndex ",
					rowIndex.ToString(),
					" is outside the allowable range (0..",
					65535.ToString(),
					")"
				}));
			}
			if (rowIndex >= this.records.Length)
			{
				return;
			}
			this.records[rowIndex] = null;
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x0008CC60 File Offset: 0x0008AE60
		public int PhysicalNumberOfCells
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.records.Length; i++)
				{
					global::NPOI.HSSF.Record.CellValueRecordInterface[] array = this.records[i];
					if (array != null)
					{
						short num2 = 0;
						while ((int)num2 < array.Length)
						{
							if (array[(int)num2] != null)
							{
								num++;
							}
							num2 += 1;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0008CCA7 File Offset: 0x0008AEA7
		public int FirstCellNum
		{
			get
			{
				return this.firstcell;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x0008CCAF File Offset: 0x0008AEAF
		public int LastCellNum
		{
			get
			{
				return this.lastcell;
			}
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0008CCB8 File Offset: 0x0008AEB8
		public void AddMultipleBlanks(global::NPOI.HSSF.Record.MulBlankRecord mbr)
		{
			for (int i = 0; i < mbr.NumColumns; i++)
			{
				this.InsertCell(new global::NPOI.HSSF.Record.BlankRecord
				{
					Column = i + mbr.FirstColumn,
					Row = mbr.Row,
					XFIndex = mbr.GetXFAt(i)
				});
			}
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x0008CD0C File Offset: 0x0008AF0C
		private global::NPOI.HSSF.Record.MulBlankRecord CreateMBR(global::NPOI.HSSF.Record.CellValueRecordInterface[] cellValues, int startIx, int nBlank)
		{
			short[] array = new short[nBlank];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ((global::NPOI.HSSF.Record.BlankRecord)cellValues[startIx + i]).XFIndex;
			}
			return new global::NPOI.HSSF.Record.MulBlankRecord(cellValues[startIx].Row, startIx, array);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x0008CD50 File Offset: 0x0008AF50
		public void Construct(global::NPOI.HSSF.Record.CellValueRecordInterface rec, global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.SharedValueManager sfh)
		{
			if (rec is global::NPOI.HSSF.Record.FormulaRecord)
			{
				global::NPOI.HSSF.Record.FormulaRecord formulaRec = (global::NPOI.HSSF.Record.FormulaRecord)rec;
				global::NPOI.HSSF.Record.StringRecord stringRec;
				if (rs.PeekNextClass() == typeof(global::NPOI.HSSF.Record.StringRecord))
				{
					stringRec = (global::NPOI.HSSF.Record.StringRecord)rs.GetNext();
				}
				else
				{
					stringRec = null;
				}
				this.InsertCell(new global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate(formulaRec, stringRec, sfh));
				return;
			}
			this.InsertCell(rec);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00019A7F File Offset: 0x00017C7F
		private static void HandleMissingSharedFormulaRecord(global::NPOI.HSSF.Record.FormulaRecord formula)
		{
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x0008CDAC File Offset: 0x0008AFAC
		public int GetRowCellBlockSize(int startRow, int endRow)
		{
			global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.ValueEnumerator valueEnumerator = new global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.ValueEnumerator(ref this.records, startRow, endRow);
			int num = 0;
			while (valueEnumerator.MoveNext())
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = valueEnumerator.Current;
				int row = cellValueRecordInterface.Row;
				if (row > endRow)
				{
					break;
				}
				if (row >= startRow && row <= endRow)
				{
					num += ((global::NPOI.HSSF.Record.RecordBase)cellValueRecordInterface).RecordSize;
				}
			}
			return num;
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x0008CDFC File Offset: 0x0008AFFC
		public bool RowHasCells(int row)
		{
			if (row > this.records.Length - 1)
			{
				return false;
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface[] array = this.records[row];
			if (array == null)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x0008CE3C File Offset: 0x0008B03C
		public void UpdateFormulasAfterRowShift(global::NPOI.SS.Formula.FormulaShifter shifter, int currentExternSheetIndex)
		{
			for (int i = 0; i < this.records.Length; i++)
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface[] array = this.records[i];
				if (array != null)
				{
					foreach (global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface in array)
					{
						if (cellValueRecordInterface is global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)
						{
							global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate formulaRecordAggregate = (global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)cellValueRecordInterface;
							global::NPOI.SS.Formula.PTG.Ptg[] formulaTokens = formulaRecordAggregate.FormulaTokens;
							global::NPOI.SS.Formula.PTG.Ptg[] parsedExpression = ((global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate)cellValueRecordInterface).FormulaRecord.ParsedExpression;
							if (shifter.AdjustFormula(formulaTokens, currentExternSheetIndex))
							{
								formulaRecordAggregate.SetParsedExpression(formulaTokens);
							}
						}
					}
				}
			}
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x0008CEB8 File Offset: 0x0008B0B8
		public void VisitCellsForRow(int rowIndex, global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			global::NPOI.HSSF.Record.CellValueRecordInterface[] array = this.records[rowIndex];
			if (array == null)
			{
				throw new global::System.ArgumentException("Row [" + rowIndex.ToString() + "] is empty");
			}
			for (int i = 0; i < array.Length; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = (global::NPOI.HSSF.Record.RecordBase)array[i];
				if (recordBase != null)
				{
					int num = global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.CountBlanks(array, i);
					if (num > 1)
					{
						rv.VisitRecord(this.CreateMBR(array, i, num));
						i += num - 1;
					}
					else if (recordBase is global::NPOI.HSSF.Record.Aggregates.RecordAggregate)
					{
						((global::NPOI.HSSF.Record.Aggregates.RecordAggregate)recordBase).VisitContainedRecords(rv);
					}
					else
					{
						rv.VisitRecord((global::NPOI.HSSF.Record.Record)recordBase);
					}
				}
			}
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x0008CF4C File Offset: 0x0008B14C
		private static int CountBlanks(global::NPOI.HSSF.Record.CellValueRecordInterface[] rowCellValues, int startIx)
		{
			int num = startIx;
			while (num < rowCellValues.Length && rowCellValues[num] is global::NPOI.HSSF.Record.BlankRecord)
			{
				num++;
			}
			return num - startIx;
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x0008CF74 File Offset: 0x0008B174
		public int SerializeCellRow(int row, int offset, byte[] data)
		{
			global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.ValueEnumerator valueEnumerator = new global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.ValueEnumerator(ref this.records, row, row);
			int num = offset;
			while (valueEnumerator.MoveNext())
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = valueEnumerator.Current;
				if (cellValueRecordInterface.Row != row)
				{
					break;
				}
				num += ((global::NPOI.HSSF.Record.RecordBase)cellValueRecordInterface).Serialize(num, data);
			}
			return num - offset;
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x0008CFBE File Offset: 0x0008B1BE
		public global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.CellValueRecordInterface> GetEnumerator()
		{
			return new global::NPOI.HSSF.Record.Aggregates.ValueRecordsAggregate.ValueEnumerator(ref this.records);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x0008CFCB File Offset: 0x0008B1CB
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04001492 RID: 5266
		private const int MAX_ROW_INDEX = 65535;

		// Token: 0x04001493 RID: 5267
		private const int INDEX_NOT_SET = -1;

		// Token: 0x04001494 RID: 5268
		public const short sid = -1001;

		// Token: 0x04001495 RID: 5269
		private int firstcell = -1;

		// Token: 0x04001496 RID: 5270
		private int lastcell = -1;

		// Token: 0x04001497 RID: 5271
		private global::NPOI.HSSF.Record.CellValueRecordInterface[][] records;

		// Token: 0x02000622 RID: 1570
		private class ValueEnumerator : global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.CellValueRecordInterface>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060036C1 RID: 14017 RVA: 0x000A7108 File Offset: 0x000A5308
			public ValueEnumerator(ref global::NPOI.HSSF.Record.CellValueRecordInterface[][] _records)
			{
				this.records = _records;
				this.nextRow = 0;
				this.lastRow = _records.Length - 1;
			}

			// Token: 0x060036C2 RID: 14018 RVA: 0x000A7132 File Offset: 0x000A5332
			public ValueEnumerator(ref global::NPOI.HSSF.Record.CellValueRecordInterface[][] _records, int firstRow, int lastRow)
			{
				this.records = _records;
				this.nextRow = firstRow;
				this.lastRow = lastRow;
			}

			// Token: 0x060036C3 RID: 14019 RVA: 0x000A7157 File Offset: 0x000A5357
			public bool MoveNext()
			{
				this.FindNext();
				return this.nextRow <= this.lastRow;
			}

			// Token: 0x17000E2C RID: 3628
			// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000A7170 File Offset: 0x000A5370
			public global::NPOI.HSSF.Record.CellValueRecordInterface Current
			{
				get
				{
					return this.records[this.nextRow][(int)this.nextColumn];
				}
			}

			// Token: 0x17000E2D RID: 3629
			// (get) Token: 0x060036C5 RID: 14021 RVA: 0x000A7186 File Offset: 0x000A5386
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060036C6 RID: 14022 RVA: 0x000A718E File Offset: 0x000A538E
			public void Remove()
			{
				throw new global::System.InvalidOperationException("gibt's noch nicht");
			}

			// Token: 0x060036C7 RID: 14023 RVA: 0x000A719C File Offset: 0x000A539C
			private void FindNext()
			{
				this.nextColumn += 1;
				while (this.nextRow <= this.lastRow)
				{
					global::NPOI.HSSF.Record.CellValueRecordInterface[] array = (this.nextRow < this.records.Length) ? this.records[this.nextRow] : null;
					if (array == null)
					{
						this.nextColumn = 0;
					}
					else
					{
						while ((int)this.nextColumn < array.Length)
						{
							if (array[(int)this.nextColumn] != null)
							{
								return;
							}
							this.nextColumn += 1;
						}
						this.nextColumn = 0;
					}
					this.nextRow++;
				}
			}

			// Token: 0x060036C8 RID: 14024 RVA: 0x000A722F File Offset: 0x000A542F
			public void Reset()
			{
				this.nextColumn = -1;
				this.nextRow = 0;
			}

			// Token: 0x060036C9 RID: 14025 RVA: 0x000A723F File Offset: 0x000A543F
			public void Dispose()
			{
				this.records = null;
			}

			// Token: 0x04001AA3 RID: 6819
			private short nextColumn = -1;

			// Token: 0x04001AA4 RID: 6820
			private int nextRow;

			// Token: 0x04001AA5 RID: 6821
			private int lastRow;

			// Token: 0x04001AA6 RID: 6822
			private global::NPOI.HSSF.Record.CellValueRecordInterface[][] records;
		}
	}
}
