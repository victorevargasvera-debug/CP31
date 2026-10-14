using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003D3 RID: 979
	public class Excel9FileRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002290 RID: 8848 RVA: 0x0005FE49 File Offset: 0x0005E049
		public Excel9FileRecord()
		{
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0005FE49 File Offset: 0x0005E049
		public Excel9FileRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00068D2F File Offset: 0x00066F2F
		public override short Sid
		{
			get
			{
				return 448;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x04000E5D RID: 3677
		public const short sid = 448;
	}
}
