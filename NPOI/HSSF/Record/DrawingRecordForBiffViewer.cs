using System;
using System.IO;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CA RID: 970
	public class DrawingRecordForBiffViewer : global::NPOI.HSSF.Record.AbstractEscherHolderRecord
	{
		// Token: 0x0600221B RID: 8731 RVA: 0x0006739E File Offset: 0x0006559E
		public DrawingRecordForBiffViewer()
		{
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000673A6 File Offset: 0x000655A6
		public DrawingRecordForBiffViewer(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00067645 File Offset: 0x00065845
		public DrawingRecordForBiffViewer(global::NPOI.HSSF.Record.DrawingRecord r) : base(global::NPOI.HSSF.Record.DrawingRecordForBiffViewer.ConvertToInputStream(r))
		{
			base.ConvertRawBytesToEscherRecords();
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0006765C File Offset: 0x0006585C
		private static global::NPOI.HSSF.Record.RecordInputStream ConvertToInputStream(global::NPOI.HSSF.Record.DrawingRecord r)
		{
			global::NPOI.HSSF.Record.RecordInputStream result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(r.Serialize()))
			{
				global::NPOI.HSSF.Record.RecordInputStream recordInputStream = new global::NPOI.HSSF.Record.RecordInputStream(memoryStream);
				recordInputStream.NextRecord();
				result = recordInputStream;
			}
			return result;
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x000676A0 File Offset: 0x000658A0
		protected override string RecordName
		{
			get
			{
				return "MSODRAWING";
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x0006759C File Offset: 0x0006579C
		public override short Sid
		{
			get
			{
				return 236;
			}
		}

		// Token: 0x04000D5F RID: 3423
		public const short sid = 236;
	}
}
