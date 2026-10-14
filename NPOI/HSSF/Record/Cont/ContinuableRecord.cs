using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Cont
{
	// Token: 0x02000452 RID: 1106
	public abstract class ContinuableRecord : global::NPOI.HSSF.Record.Record
	{
		// Token: 0x060028E2 RID: 10466
		protected abstract void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1);

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0007B890 File Offset: 0x00079A90
		public override int RecordSize
		{
			get
			{
				global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput continuableRecordOutput = global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput.CreateForCountingOnly();
				this.Serialize(continuableRecordOutput);
				continuableRecordOutput.Terminate();
				return continuableRecordOutput.TotalSize;
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0007B8B8 File Offset: 0x00079AB8
		public override int Serialize(int offset, byte[] data)
		{
			global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput continuableRecordOutput = new global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput(new global::NPOI.Util.LittleEndianByteArrayOutputStream(data, offset), (int)this.Sid);
			this.Serialize(continuableRecordOutput);
			continuableRecordOutput.Terminate();
			return continuableRecordOutput.TotalSize;
		}
	}
}
