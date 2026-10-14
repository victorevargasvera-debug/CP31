using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C9 RID: 969
	public class DrawingRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002210 RID: 8720 RVA: 0x00067554 File Offset: 0x00065754
		public DrawingRecord()
		{
			this.recordData = global::NPOI.HSSF.Record.DrawingRecord.EMPTY_BYTE_ARRAY;
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00067567 File Offset: 0x00065767
		public DrawingRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.recordData = in1.ReadRemainder();
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0006757B File Offset: 0x0006577B
		[global::System.Obsolete]
		public void ProcessContinueRecord(byte[] record)
		{
			this.contd = record;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00067584 File Offset: 0x00065784
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this.recordData);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00067592 File Offset: 0x00065792
		protected override int DataSize
		{
			get
			{
				return this.recordData.Length;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x0006759C File Offset: 0x0006579C
		public override short Sid
		{
			get
			{
				return 236;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000675A3 File Offset: 0x000657A3
		public byte[] RecordData
		{
			get
			{
				return this.recordData;
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000675AB File Offset: 0x000657AB
		public void SetData(byte[] thedata)
		{
			if (thedata == null)
			{
				throw new global::System.ArgumentException("data must not be null");
			}
			this.recordData = thedata;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000675C4 File Offset: 0x000657C4
		public override object Clone()
		{
			global::NPOI.HSSF.Record.DrawingRecord drawingRecord = new global::NPOI.HSSF.Record.DrawingRecord();
			drawingRecord.recordData = (byte[])this.recordData.Clone();
			if (this.contd != null)
			{
				drawingRecord.contd = (byte[])this.contd.Clone();
			}
			return drawingRecord;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0006760C File Offset: 0x0006580C
		public override string ToString()
		{
			return "DrawingRecord[" + this.recordData.Length.ToString() + "]";
		}

		// Token: 0x04000D5B RID: 3419
		public const short sid = 236;

		// Token: 0x04000D5C RID: 3420
		private static byte[] EMPTY_BYTE_ARRAY = new byte[0];

		// Token: 0x04000D5D RID: 3421
		private byte[] recordData;

		// Token: 0x04000D5E RID: 3422
		private byte[] contd;
	}
}
