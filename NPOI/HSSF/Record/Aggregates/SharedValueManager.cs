using System;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D9 RID: 1241
	[global::System.Serializable]
	public class SharedValueManager
	{
		// Token: 0x06002F3B RID: 12091 RVA: 0x0008C5F0 File Offset: 0x0008A7F0
		private SharedValueManager(global::NPOI.HSSF.Record.SharedFormulaRecord[] sharedFormulaRecords, global::NPOI.SS.Util.CellReference[] firstCells, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord> arrayRecords, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord> tableRecords)
		{
			int num = sharedFormulaRecords.Length;
			if (num != firstCells.Length)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"array sizes don't match: ",
					num.ToString(),
					"!=",
					firstCells.Length.ToString(),
					"."
				}));
			}
			this._arrayRecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord>();
			this._arrayRecords.AddRange(arrayRecords);
			this._tableRecords = tableRecords;
			global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.SharedFormulaRecord, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.SharedFormulaRecord, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup>(num * 3 / 2);
			for (int i = 0; i < num; i++)
			{
				global::NPOI.HSSF.Record.SharedFormulaRecord sharedFormulaRecord = sharedFormulaRecords[i];
				dictionary[sharedFormulaRecord] = new global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup(sharedFormulaRecord, firstCells[i]);
			}
			this._groupsBySharedFormulaRecord = dictionary;
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x0008C6AD File Offset: 0x0008A8AD
		public static global::NPOI.HSSF.Record.Aggregates.SharedValueManager CreateEmpty()
		{
			return new global::NPOI.HSSF.Record.Aggregates.SharedValueManager(new global::NPOI.HSSF.Record.SharedFormulaRecord[0], new global::NPOI.SS.Util.CellReference[0], new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord>(), new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord>());
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x0008C6CA File Offset: 0x0008A8CA
		public static global::NPOI.HSSF.Record.Aggregates.SharedValueManager Create(global::NPOI.HSSF.Record.SharedFormulaRecord[] sharedFormulaRecords, global::NPOI.SS.Util.CellReference[] firstCells, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord> arrayRecords, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord> tableRecords)
		{
			if (sharedFormulaRecords.Length + firstCells.Length + arrayRecords.Count + tableRecords.Count < 1)
			{
				return global::NPOI.HSSF.Record.Aggregates.SharedValueManager.EMPTY;
			}
			return new global::NPOI.HSSF.Record.Aggregates.SharedValueManager(sharedFormulaRecords, firstCells, arrayRecords, tableRecords);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x0008C6F4 File Offset: 0x0008A8F4
		public global::NPOI.HSSF.Record.SharedFormulaRecord LinkSharedFormulaRecord(global::NPOI.SS.Util.CellReference firstCell, global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate agg)
		{
			global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup sharedFormulaGroup = this.FindFormulaGroupForCell(firstCell);
			if (sharedFormulaGroup == null)
			{
				throw new global::NPOI.Util.RuntimeException("Failed to find a matching shared formula record");
			}
			sharedFormulaGroup.Add(agg);
			return sharedFormulaGroup.SFR;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x0008C724 File Offset: 0x0008A924
		private global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup FindFormulaGroupForCell(global::NPOI.SS.Util.CellReference cellRef)
		{
			if (this._groupsCache == null)
			{
				this._groupsCache = new global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup>(this._groupsBySharedFormulaRecord.Count);
				foreach (global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup sharedFormulaGroup in this._groupsBySharedFormulaRecord.Values)
				{
					this._groupsCache.Add(this.GetKeyForCache(sharedFormulaGroup.FirstCell), sharedFormulaGroup);
				}
			}
			int keyForCache = this.GetKeyForCache(cellRef);
			global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup result = null;
			if (this._groupsCache.ContainsKey(keyForCache))
			{
				result = this._groupsCache[keyForCache];
			}
			return result;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x0008C7D4 File Offset: 0x0008A9D4
		private int GetKeyForCache(global::NPOI.SS.Util.CellReference cellRef)
		{
			return (int)(cellRef.Col + 1) << 16 | cellRef.Row;
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x0008C7E8 File Offset: 0x0008A9E8
		public global::NPOI.HSSF.Record.SharedValueRecordBase GetRecordForFirstCell(global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate agg)
		{
			global::NPOI.SS.Util.CellReference expReference = agg.FormulaRecord.Formula.ExpReference;
			if (expReference == null)
			{
				return null;
			}
			int row = expReference.Row;
			int col = (int)expReference.Col;
			if (agg.Row != row || agg.Column != col)
			{
				return null;
			}
			if (this._groupsBySharedFormulaRecord.Count != 0)
			{
				global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup sharedFormulaGroup = this.FindFormulaGroupForCell(expReference);
				if (sharedFormulaGroup != null)
				{
					return sharedFormulaGroup.SFR;
				}
			}
			for (int i = 0; i < this._tableRecords.Count; i++)
			{
				global::NPOI.HSSF.Record.TableRecord tableRecord = this._tableRecords[i];
				if (tableRecord.IsFirstCell(row, col))
				{
					return tableRecord;
				}
			}
			foreach (global::NPOI.HSSF.Record.ArrayRecord arrayRecord in this._arrayRecords)
			{
				if (arrayRecord.IsFirstCell(row, col))
				{
					return arrayRecord;
				}
			}
			return null;
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x0008C8DC File Offset: 0x0008AADC
		public void Unlink(global::NPOI.HSSF.Record.SharedFormulaRecord sharedFormulaRecord)
		{
			global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup sharedFormulaGroup = this._groupsBySharedFormulaRecord[sharedFormulaRecord];
			this._groupsBySharedFormulaRecord.Remove(sharedFormulaRecord);
			this._groupsCache = null;
			if (sharedFormulaGroup == null)
			{
				throw new global::System.InvalidOperationException("Failed to find formulas for shared formula");
			}
			sharedFormulaGroup.UnlinkSharedFormulas();
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x0008C911 File Offset: 0x0008AB11
		public void AddArrayRecord(global::NPOI.HSSF.Record.ArrayRecord ar)
		{
			this._arrayRecords.Add(ar);
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x0008C920 File Offset: 0x0008AB20
		public global::NPOI.SS.Util.CellRangeAddress8Bit RemoveArrayFormula(int rowIndex, int columnIndex)
		{
			foreach (global::NPOI.HSSF.Record.ArrayRecord arrayRecord in this._arrayRecords)
			{
				if (arrayRecord.IsInRange(rowIndex, columnIndex))
				{
					this._arrayRecords.Remove(arrayRecord);
					return arrayRecord.Range;
				}
			}
			string str = new global::NPOI.SS.Util.CellReference(rowIndex, columnIndex, false, false).FormatAsString();
			throw new global::System.ArgumentException("Specified cell " + str + " is not part of an array formula.");
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x0008C9B4 File Offset: 0x0008ABB4
		public global::NPOI.HSSF.Record.ArrayRecord GetArrayRecord(int firstRow, int firstColumn)
		{
			foreach (global::NPOI.HSSF.Record.ArrayRecord arrayRecord in this._arrayRecords)
			{
				if (arrayRecord.IsFirstCell(firstRow, firstColumn))
				{
					return arrayRecord;
				}
			}
			return null;
		}

		// Token: 0x0400148C RID: 5260
		public static readonly global::NPOI.HSSF.Record.Aggregates.SharedValueManager EMPTY = new global::NPOI.HSSF.Record.Aggregates.SharedValueManager(new global::NPOI.HSSF.Record.SharedFormulaRecord[0], new global::NPOI.SS.Util.CellReference[0], new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord>(), new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord>());

		// Token: 0x0400148D RID: 5261
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ArrayRecord> _arrayRecords;

		// Token: 0x0400148E RID: 5262
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.TableRecord> _tableRecords;

		// Token: 0x0400148F RID: 5263
		private global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.SharedFormulaRecord, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup> _groupsBySharedFormulaRecord;

		// Token: 0x04001490 RID: 5264
		[global::System.NonSerialized]
		private global::System.Collections.Generic.Dictionary<int, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup> _groupsCache;

		// Token: 0x04001491 RID: 5265
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroupComparator SVGComparator = new global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroupComparator();

		// Token: 0x02000620 RID: 1568
		private class SharedFormulaGroup
		{
			// Token: 0x17000E2A RID: 3626
			// (get) Token: 0x060036B8 RID: 14008 RVA: 0x000A6ED5 File Offset: 0x000A50D5
			internal global::NPOI.SS.Util.CellReference FirstCell
			{
				get
				{
					return this._firstCell;
				}
			}

			// Token: 0x060036B9 RID: 14009 RVA: 0x000A6EE0 File Offset: 0x000A50E0
			public SharedFormulaGroup(global::NPOI.HSSF.Record.SharedFormulaRecord sfr, global::NPOI.SS.Util.CellReference firstCell)
			{
				if (!sfr.IsInRange(firstCell.Row, (int)firstCell.Col))
				{
					throw new global::System.ArgumentException(string.Concat(new string[]
					{
						"First formula cell ",
						firstCell.FormatAsString(),
						" is not shared formula range ",
						sfr.Range.ToString(),
						"."
					}));
				}
				this._sfr = sfr;
				this._firstCell = firstCell;
				int num = sfr.LastColumn - sfr.FirstColumn + 1;
				int num2 = sfr.LastRow - sfr.FirstRow + 1;
				this._frAggs = new global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate[num * num2];
				this._numberOfFormulas = 0;
			}

			// Token: 0x060036BA RID: 14010 RVA: 0x000A6F8C File Offset: 0x000A518C
			public void Add(global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate agg)
			{
				if (this._numberOfFormulas == 0 && (this._firstCell.Row != agg.Row || (int)this._firstCell.Col != agg.Column))
				{
					throw new global::System.InvalidOperationException("shared formula coding error");
				}
				if (this._numberOfFormulas >= this._frAggs.Length)
				{
					throw new global::System.Exception("Too many formula records for shared formula group");
				}
				global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate[] frAggs = this._frAggs;
				int numberOfFormulas = this._numberOfFormulas;
				this._numberOfFormulas = numberOfFormulas + 1;
				frAggs[numberOfFormulas] = agg;
			}

			// Token: 0x060036BB RID: 14011 RVA: 0x000A7008 File Offset: 0x000A5208
			public void UnlinkSharedFormulas()
			{
				for (int i = 0; i < this._numberOfFormulas; i++)
				{
					this._frAggs[i].UnlinkSharedFormula();
				}
			}

			// Token: 0x17000E2B RID: 3627
			// (get) Token: 0x060036BC RID: 14012 RVA: 0x000A7033 File Offset: 0x000A5233
			public global::NPOI.HSSF.Record.SharedFormulaRecord SFR
			{
				get
				{
					return this._sfr;
				}
			}

			// Token: 0x060036BD RID: 14013 RVA: 0x000A703C File Offset: 0x000A523C
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name).Append(" [");
				stringBuilder.Append(this._sfr.Range.ToString());
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x060036BE RID: 14014 RVA: 0x000A7094 File Offset: 0x000A5294
			public bool IsFirstCell(int row, int column)
			{
				return this._firstCell.Row == row && (int)this._firstCell.Col == column;
			}

			// Token: 0x04001A9F RID: 6815
			private global::NPOI.HSSF.Record.SharedFormulaRecord _sfr;

			// Token: 0x04001AA0 RID: 6816
			private global::NPOI.HSSF.Record.Aggregates.FormulaRecordAggregate[] _frAggs;

			// Token: 0x04001AA1 RID: 6817
			private int _numberOfFormulas;

			// Token: 0x04001AA2 RID: 6818
			private global::NPOI.SS.Util.CellReference _firstCell;
		}

		// Token: 0x02000621 RID: 1569
		private class SharedFormulaGroupComparator : global::System.Collections.Generic.Comparer<global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup>
		{
			// Token: 0x060036BF RID: 14015 RVA: 0x000A70B4 File Offset: 0x000A52B4
			public override int Compare(global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup a, global::NPOI.HSSF.Record.Aggregates.SharedValueManager.SharedFormulaGroup b)
			{
				global::NPOI.SS.Util.CellRangeAddress8Bit range = a.SFR.Range;
				global::NPOI.SS.Util.CellRangeAddress8Bit range2 = b.SFR.Range;
				int num = range.FirstRow - range2.FirstRow;
				if (num != 0)
				{
					return num;
				}
				num = range.FirstColumn - range2.FirstColumn;
				if (num != 0)
				{
					return num;
				}
				return 0;
			}
		}
	}
}
