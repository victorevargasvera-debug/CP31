using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000441 RID: 1089
	public class WriteProtectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600286A RID: 10346 RVA: 0x0005FE49 File Offset: 0x0005E049
		public WriteProtectRecord()
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0005FE49 File Offset: 0x0005E049
		public WriteProtectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00079B26 File Offset: 0x00077D26
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WritePROTECT]\n");
			stringBuilder.Append("[/WritePROTECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x00079B4A File Offset: 0x00077D4A
		public override short Sid
		{
			get
			{
				return 134;
			}
		}

		// Token: 0x0400112B RID: 4395
		public const short sid = 134;
	}
}
