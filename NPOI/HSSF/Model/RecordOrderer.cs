using System;
using System.Collections.Generic;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Aggregates;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000334 RID: 820
	public class RecordOrderer
	{
		// Token: 0x06001763 RID: 5987 RVA: 0x0000253E File Offset: 0x0000073E
		private RecordOrderer()
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0004603C File Offset: 0x0004423C
		public static void AddNewSheetRecord(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> sheetRecords, global::NPOI.HSSF.Record.RecordBase newRecord)
		{
			int index = global::NPOI.HSSF.Model.RecordOrderer.FindSheetInsertPos(sheetRecords, newRecord.GetType());
			sheetRecords.Insert(index, newRecord);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00046060 File Offset: 0x00044260
		private static int FindSheetInsertPos(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records, global::System.Type recClass)
		{
			if (recClass == typeof(global::NPOI.HSSF.Record.Aggregates.DataValidityTable))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.FindDataValidationTableInsertPos(records);
			}
			if (recClass == typeof(global::NPOI.HSSF.Record.Aggregates.MergedCellsTable))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.FindInsertPosForNewMergedRecordTable(records);
			}
			if (recClass == typeof(global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.FindInsertPosForNewCondFormatTable(records);
			}
			if (recClass == typeof(global::NPOI.HSSF.Record.GutsRecord))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.GetGutsRecordInsertPos(records);
			}
			if (recClass == typeof(global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.GetPageBreakRecordInsertPos(records);
			}
			if (recClass == typeof(global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock))
			{
				return global::NPOI.HSSF.Model.RecordOrderer.GetWorksheetProtectionBlockInsertPos(records);
			}
			throw new global::System.InvalidOperationException("Unexpected record class (" + recClass.Name + ")");
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00046120 File Offset: 0x00044320
		private static int GetWorksheetProtectionBlockInsertPos(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int i = global::NPOI.HSSF.Model.RecordOrderer.GetDimensionsIndex(records);
			while (i > 0)
			{
				i--;
				if (!global::NPOI.HSSF.Model.RecordOrderer.IsProtectionSubsequentRecord(records[i]))
				{
					return i + 1;
				}
			}
			throw new global::System.InvalidOperationException("did not find insert pos for protection block");
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0004615C File Offset: 0x0004435C
		private static bool IsProtectionSubsequentRecord(object rb)
		{
			if (rb is global::NPOI.HSSF.Record.Aggregates.ColumnInfoRecordsAggregate)
			{
				return true;
			}
			if (rb is global::NPOI.HSSF.Record.Record)
			{
				short sid = ((global::NPOI.HSSF.Record.Record)rb).Sid;
				if (sid == 85 || sid == 144)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00046198 File Offset: 0x00044398
		private static int GetPageBreakRecordInsertPos(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int i = global::NPOI.HSSF.Model.RecordOrderer.GetDimensionsIndex(records) - 1;
			while (i > 0)
			{
				i--;
				if (global::NPOI.HSSF.Model.RecordOrderer.IsPageBreakPriorRecord(records[i]))
				{
					return i + 1;
				}
			}
			throw new global::System.InvalidOperationException("Did not Find insert point for GUTS");
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000461D4 File Offset: 0x000443D4
		private static bool IsPageBreakPriorRecord(global::NPOI.HSSF.Record.RecordBase rb)
		{
			if (rb is global::NPOI.HSSF.Record.Record)
			{
				short sid = ((global::NPOI.HSSF.Record.Record)rb).Sid;
				if (sid <= 95)
				{
					if (sid <= 34)
					{
						if (sid - 12 > 5 && sid != 34)
						{
							return false;
						}
					}
					else if (sid - 42 > 1 && sid - 94 > 1)
					{
						return false;
					}
				}
				else if (sid <= 523)
				{
					if (sid - 129 > 1 && sid != 523)
					{
						return false;
					}
				}
				else if (sid != 549 && sid != 2057)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0004624C File Offset: 0x0004444C
		private static int FindInsertPosForNewCondFormatTable(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			for (int i = records.Count - 2; i >= 0; i--)
			{
				object obj = records[i];
				if (obj is global::NPOI.HSSF.Record.Aggregates.MergedCellsTable)
				{
					return i + 1;
				}
				if (!(obj is global::NPOI.HSSF.Record.Aggregates.DataValidityTable))
				{
					short sid = ((global::NPOI.HSSF.Record.Record)obj).Sid;
					if (sid <= 153)
					{
						if (sid != 29 && sid != 65 && sid != 153)
						{
							goto IL_7D;
						}
					}
					else if (sid <= 239)
					{
						if (sid != 160 && sid != 239)
						{
							goto IL_7D;
						}
					}
					else if (sid != 351 && sid != 574)
					{
						goto IL_7D;
					}
					return i + 1;
				}
				IL_7D:;
			}
			throw new global::System.InvalidOperationException("Did not Find Window2 record");
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000462E8 File Offset: 0x000444E8
		private static int FindInsertPosForNewMergedRecordTable(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			for (int i = records.Count - 2; i >= 0; i--)
			{
				object obj = records[i];
				if (obj is global::NPOI.HSSF.Record.Record)
				{
					short sid = ((global::NPOI.HSSF.Record.Record)obj).Sid;
					if (sid <= 65)
					{
						if (sid != 29 && sid != 65)
						{
							goto IL_54;
						}
					}
					else if (sid != 153 && sid != 160 && sid != 574)
					{
						goto IL_54;
					}
					return i + 1;
				}
				IL_54:;
			}
			throw new global::System.InvalidOperationException("Did not Find Window2 record");
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0004635C File Offset: 0x0004455C
		private static int FindDataValidationTableInsertPos(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int i = records.Count - 1;
			if (!(records[i] is global::NPOI.HSSF.Record.EOFRecord))
			{
				throw new global::System.InvalidOperationException("Last sheet record should be EOFRecord");
			}
			while (i > 0)
			{
				i--;
				global::NPOI.HSSF.Record.RecordBase recordBase = records[i];
				if (global::NPOI.HSSF.Model.RecordOrderer.IsDVTPriorRecord(recordBase))
				{
					global::NPOI.HSSF.Record.Record record = (global::NPOI.HSSF.Record.Record)records[i + 1];
					if (!global::NPOI.HSSF.Model.RecordOrderer.IsDVTSubsequentRecord(record.Sid))
					{
						throw new global::System.InvalidOperationException(string.Concat(new string[]
						{
							"Unexpected (",
							record.GetType().Name,
							") found after (",
							recordBase.GetType().Name,
							")"
						}));
					}
					return i + 1;
				}
				else
				{
					global::NPOI.HSSF.Record.Record record2 = (global::NPOI.HSSF.Record.Record)recordBase;
					if (!global::NPOI.HSSF.Model.RecordOrderer.IsDVTSubsequentRecord(record2.Sid))
					{
						throw new global::System.InvalidOperationException("Unexpected (" + record2.GetType().Name + ") while looking for DV Table insert pos");
					}
				}
			}
			return 0;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00046444 File Offset: 0x00044644
		private static bool IsDVTPriorRecord(global::NPOI.HSSF.Record.RecordBase rb)
		{
			if (rb is global::NPOI.HSSF.Record.Aggregates.MergedCellsTable || rb is global::NPOI.HSSF.Record.Aggregates.ConditionalFormattingTable)
			{
				return true;
			}
			short sid = ((global::NPOI.HSSF.Record.Record)rb).Sid;
			if (sid <= 160)
			{
				if (sid <= 65)
				{
					if (sid != 29 && sid != 65)
					{
						return false;
					}
				}
				else if (sid != 153 && sid != 160)
				{
					return false;
				}
			}
			else if (sid <= 351)
			{
				if (sid != 239 && sid != 351)
				{
					return false;
				}
			}
			else if (sid != 440 && sid != 574 && sid != 2048)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000464CF File Offset: 0x000446CF
		private static bool IsDVTSubsequentRecord(short sid)
		{
			if (sid <= 2146)
			{
				if (sid != 10 && sid != 2146)
				{
					return false;
				}
			}
			else if (sid - 2151 > 1 && sid != 2248)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00046500 File Offset: 0x00044700
		private static int GetDimensionsIndex(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int count = records.Count;
			for (int i = 0; i < count; i++)
			{
				if (records[i] is global::NPOI.HSSF.Record.DimensionsRecord)
				{
					return i;
				}
			}
			throw new global::System.InvalidOperationException("DimensionsRecord not found");
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0004653C File Offset: 0x0004473C
		private static int GetGutsRecordInsertPos(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> records)
		{
			int i = global::NPOI.HSSF.Model.RecordOrderer.GetDimensionsIndex(records) - 1;
			while (i > 0)
			{
				i--;
				if (global::NPOI.HSSF.Model.RecordOrderer.IsGutsPriorRecord(records[i]))
				{
					return i + 1;
				}
			}
			throw new global::System.InvalidOperationException("Did not Find insert point for GUTS");
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00046578 File Offset: 0x00044778
		private static bool IsGutsPriorRecord(global::NPOI.HSSF.Record.RecordBase rb)
		{
			if (rb is global::NPOI.HSSF.Record.Record)
			{
				short sid = ((global::NPOI.HSSF.Record.Record)rb).Sid;
				if (sid <= 43)
				{
					if (sid - 12 > 5 && sid != 34 && sid - 42 > 1)
					{
						return false;
					}
				}
				else if (sid <= 130)
				{
					if (sid - 94 > 1 && sid != 130)
					{
						return false;
					}
				}
				else if (sid != 523 && sid != 2057)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000465E0 File Offset: 0x000447E0
		public static bool IsEndOfRowBlock(int sid)
		{
			if (sid <= 128)
			{
				if (sid <= 61)
				{
					if (sid == 10)
					{
						throw new global::System.InvalidOperationException("Found EOFRecord before WindowTwoRecord was encountered");
					}
					if (sid != 61)
					{
						goto IL_70;
					}
				}
				else if (sid != 93 && sid != 125 && sid != 128)
				{
					goto IL_70;
				}
			}
			else if (sid <= 237)
			{
				if (sid != 176 && sid - 236 > 1)
				{
					goto IL_70;
				}
			}
			else
			{
				if (sid == 434)
				{
					return true;
				}
				if (sid != 438 && sid != 574)
				{
					goto IL_70;
				}
			}
			return true;
			IL_70:
			return global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.IsComponentRecord(sid);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00046664 File Offset: 0x00044864
		public static bool IsRowBlockRecord(int sid)
		{
			if (sid <= 520)
			{
				if (sid != 6 && sid != 253)
				{
					switch (sid)
					{
					case 513:
					case 515:
					case 516:
					case 517:
					case 520:
						break;
					case 514:
					case 518:
					case 519:
						return false;
					default:
						return false;
					}
				}
			}
			else if (sid <= 566)
			{
				if (sid != 545 && sid != 566)
				{
					return false;
				}
			}
			else if (sid != 638 && sid != 1212)
			{
				return false;
			}
			return true;
		}
	}
}
