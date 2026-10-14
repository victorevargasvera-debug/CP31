using System;
using System.Collections;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x0200034A RID: 842
	public class HSSFRecordStream
	{
		// Token: 0x06001921 RID: 6433 RVA: 0x0004D1D5 File Offset: 0x0004B3D5
		public HSSFRecordStream(global::NPOI.HSSF.Record.RecordInputStream inp)
		{
			this.in1 = inp;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		public global::NPOI.HSSF.Record.Record NextRecord()
		{
			global::NPOI.HSSF.Record.Record record = null;
			while (record == null && !this.complete)
			{
				record = this.GetBonusRecord();
				if (record == null)
				{
					record = this.GetNextRecord();
				}
			}
			return record;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0004D21E File Offset: 0x0004B41E
		private global::NPOI.HSSF.Record.Record GetBonusRecord()
		{
			if (this.bonusRecords != null)
			{
				global::NPOI.HSSF.Record.Record result = (global::NPOI.HSSF.Record.Record)this.bonusRecords[0];
				this.bonusRecords.RemoveAt(0);
				if (this.bonusRecords.Count == 0)
				{
					this.bonusRecords = null;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0004D25C File Offset: 0x0004B45C
		private global::NPOI.HSSF.Record.Record GetNextRecord()
		{
			global::NPOI.HSSF.Record.Record result = null;
			if (this.in1.HasNextRecord)
			{
				this.in1.NextRecord();
				short sid = this.in1.Sid;
				if (sid == 0)
				{
					return null;
				}
				if (this.rec != null && sid != 60)
				{
					result = this.rec;
				}
				if (sid != 60)
				{
					global::NPOI.HSSF.Record.Record[] array = global::NPOI.HSSF.Record.RecordFactory.CreateRecord(this.in1);
					if (array.Length > 1)
					{
						this.bonusRecords = new global::System.Collections.ArrayList(array.Length - 1);
						for (int i = 0; i < array.Length - 1; i++)
						{
							this.bonusRecords.Add(array[i]);
						}
					}
					this.rec = array[array.Length - 1];
				}
				else
				{
					global::NPOI.HSSF.Record.ContinueRecord continueRecord = (global::NPOI.HSSF.Record.ContinueRecord)global::NPOI.HSSF.Record.RecordFactory.CreateRecord(this.in1)[0];
					if (this.lastRec is global::NPOI.HSSF.Record.ObjRecord || this.lastRec is global::NPOI.HSSF.Record.TextObjectRecord)
					{
						this.lastDrawingRecord.ProcessContinueRecord(continueRecord.Data);
						this.rec = this.lastDrawingRecord;
					}
					else if (this.lastRec is global::NPOI.HSSF.Record.DrawingGroupRecord)
					{
						((global::NPOI.HSSF.Record.DrawingGroupRecord)this.lastRec).ProcessContinueRecord(continueRecord.Data);
						this.rec = this.lastRec;
					}
					else if (!(this.rec is global::NPOI.HSSF.Record.UnknownRecord))
					{
						throw new global::NPOI.Util.RecordFormatException("Records should handle ContinueRecord internally. Should not see this exception");
					}
				}
				this.lastRec = this.rec;
				if (this.rec is global::NPOI.HSSF.Record.DrawingRecord)
				{
					this.lastDrawingRecord = (global::NPOI.HSSF.Record.DrawingRecord)this.rec;
				}
			}
			else
			{
				this.hitEOS = true;
			}
			if (this.hitEOS)
			{
				this.complete = true;
				if (this.rec != null)
				{
					result = this.rec;
					this.rec = null;
				}
			}
			return result;
		}

		// Token: 0x04000A01 RID: 2561
		private global::NPOI.HSSF.Record.RecordInputStream in1;

		// Token: 0x04000A02 RID: 2562
		private bool hitEOS;

		// Token: 0x04000A03 RID: 2563
		private bool complete;

		// Token: 0x04000A04 RID: 2564
		private global::System.Collections.ArrayList bonusRecords;

		// Token: 0x04000A05 RID: 2565
		private global::NPOI.HSSF.Record.Record rec;

		// Token: 0x04000A06 RID: 2566
		private global::NPOI.HSSF.Record.Record lastRec;

		// Token: 0x04000A07 RID: 2567
		private global::NPOI.HSSF.Record.DrawingRecord lastDrawingRecord = new global::NPOI.HSSF.Record.DrawingRecord();
	}
}
