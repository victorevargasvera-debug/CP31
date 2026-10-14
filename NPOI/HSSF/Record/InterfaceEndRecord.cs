using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003ED RID: 1005
	public class InterfaceEndRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x0005FE49 File Offset: 0x0005E049
		private InterfaceEndRecord()
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0006D60C File Offset: 0x0006B80C
		public static global::NPOI.HSSF.Record.Record Create(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int remaining = in1.Remaining;
			if (remaining == 0)
			{
				return global::NPOI.HSSF.Record.InterfaceEndRecord.Instance;
			}
			if (remaining != 2)
			{
				throw new global::NPOI.Util.RecordFormatException("Invalid record data size: " + in1.Remaining.ToString());
			}
			return new global::NPOI.HSSF.Record.InterfaceHdrRecord(in1);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0006D653 File Offset: 0x0006B853
		public override string ToString()
		{
			return "[INTERFACEEND/]\n";
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0006D65A File Offset: 0x0006B85A
		public int GetDataSize()
		{
			return this.DataSize;
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x0006D662 File Offset: 0x0006B862
		public override short Sid
		{
			get
			{
				return 226;
			}
		}

		// Token: 0x04000F41 RID: 3905
		public const short sid = 226;

		// Token: 0x04000F42 RID: 3906
		public static global::NPOI.HSSF.Record.InterfaceEndRecord Instance = new global::NPOI.HSSF.Record.InterfaceEndRecord();
	}
}
