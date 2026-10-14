using System;
using NPOI.HSSF.EventUserModel.DummyRecord;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x0200034D RID: 845
	public class MissingRecordAwareHSSFListener : global::NPOI.HSSF.EventUserModel.IHSSFListener
	{
		// Token: 0x0600192D RID: 6445 RVA: 0x0004D4FC File Offset: 0x0004B6FC
		public MissingRecordAwareHSSFListener(global::NPOI.HSSF.EventUserModel.IHSSFListener listener)
		{
			this.ResetCounts();
			this.childListener = listener;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0004D514 File Offset: 0x0004B714
		public void ProcessRecord(global::NPOI.HSSF.Record.Record record)
		{
			global::NPOI.HSSF.Record.CellValueRecordInterface[] array = null;
			int num;
			int num2;
			if (record is global::NPOI.HSSF.Record.CellValueRecordInterface)
			{
				global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = (global::NPOI.HSSF.Record.CellValueRecordInterface)record;
				num = cellValueRecordInterface.Row;
				num2 = cellValueRecordInterface.Column;
			}
			else
			{
				if (record is global::NPOI.HSSF.Record.StringRecord)
				{
					this.childListener.ProcessRecord(record);
					return;
				}
				num = -1;
				num2 = -1;
				short sid = record.Sid;
				if (sid <= 190)
				{
					if (sid != 28)
					{
						if (sid != 189)
						{
							if (sid == 190)
							{
								global::NPOI.HSSF.Record.CellValueRecordInterface[] array2 = global::NPOI.HSSF.Record.RecordFactory.ConvertBlankRecords((global::NPOI.HSSF.Record.MulBlankRecord)record);
								array = array2;
							}
						}
						else
						{
							global::NPOI.HSSF.Record.CellValueRecordInterface[] array2 = global::NPOI.HSSF.Record.RecordFactory.ConvertRKRecords((global::NPOI.HSSF.Record.MulRKRecord)record);
							array = array2;
						}
					}
					else
					{
						global::NPOI.HSSF.Record.NoteRecord noteRecord = (global::NPOI.HSSF.Record.NoteRecord)record;
						num = noteRecord.Row;
						num2 = noteRecord.Column;
					}
				}
				else if (sid != 520)
				{
					if (sid == 1212)
					{
						this.childListener.ProcessRecord(record);
						return;
					}
					if (sid == 2057)
					{
						global::NPOI.HSSF.Record.BOFRecord bofrecord = (global::NPOI.HSSF.Record.BOFRecord)record;
						if (bofrecord.Type == global::NPOI.HSSF.Record.BOFRecordType.Workbook || bofrecord.Type == global::NPOI.HSSF.Record.BOFRecordType.Worksheet)
						{
							this.ResetCounts();
						}
					}
				}
				else
				{
					global::NPOI.HSSF.Record.RowRecord rowRecord = (global::NPOI.HSSF.Record.RowRecord)record;
					if (this.lastRowRow + 1 < rowRecord.RowNumber)
					{
						for (int i = this.lastRowRow + 1; i < rowRecord.RowNumber; i++)
						{
							global::NPOI.HSSF.EventUserModel.DummyRecord.MissingRowDummyRecord record2 = new global::NPOI.HSSF.EventUserModel.DummyRecord.MissingRowDummyRecord(i);
							this.childListener.ProcessRecord(record2);
						}
					}
					this.lastRowRow = rowRecord.RowNumber;
				}
			}
			if (array != null && array.Length != 0)
			{
				num = array[0].Row;
				num2 = array[0].Column;
			}
			if (num != this.lastCellRow && this.lastCellRow > -1)
			{
				for (int j = this.lastCellRow; j < num; j++)
				{
					int lastColumnNumber = -1;
					if (j == this.lastCellRow)
					{
						lastColumnNumber = this.lastCellColumn;
					}
					this.childListener.ProcessRecord(new global::NPOI.HSSF.EventUserModel.DummyRecord.LastCellOfRowDummyRecord(j, lastColumnNumber));
				}
			}
			if (this.lastCellRow != -1 && this.lastCellColumn != -1 && num == -1)
			{
				this.childListener.ProcessRecord(new global::NPOI.HSSF.EventUserModel.DummyRecord.LastCellOfRowDummyRecord(this.lastCellRow, this.lastCellColumn));
				this.lastCellRow = -1;
				this.lastCellColumn = -1;
			}
			if (num != this.lastCellRow)
			{
				this.lastCellColumn = -1;
			}
			if (this.lastCellColumn != num2 - 1)
			{
				for (int k = this.lastCellColumn + 1; k < num2; k++)
				{
					this.childListener.ProcessRecord(new global::NPOI.HSSF.EventUserModel.DummyRecord.MissingCellDummyRecord(num, k));
				}
			}
			if (array != null && array.Length != 0)
			{
				num2 = array[array.Length - 1].Column;
			}
			if (num2 != -1)
			{
				this.lastCellColumn = num2;
				this.lastCellRow = num;
			}
			if (array != null && array.Length != 0)
			{
				foreach (global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface2 in array)
				{
					this.childListener.ProcessRecord((global::NPOI.HSSF.Record.Record)cellValueRecordInterface2);
				}
				return;
			}
			this.childListener.ProcessRecord(record);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0004D7D2 File Offset: 0x0004B9D2
		private void ResetCounts()
		{
			this.lastRowRow = -1;
			this.lastCellRow = -1;
			this.lastCellColumn = -1;
		}

		// Token: 0x04000A09 RID: 2569
		private global::NPOI.HSSF.EventUserModel.IHSSFListener childListener;

		// Token: 0x04000A0A RID: 2570
		private int lastRowRow;

		// Token: 0x04000A0B RID: 2571
		private int lastCellRow;

		// Token: 0x04000A0C RID: 2572
		private int lastCellColumn;
	}
}
