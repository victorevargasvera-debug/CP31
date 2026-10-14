using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A8 RID: 1192
	public class CrtLinkRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C5C RID: 11356 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CrtLinkRecord()
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00083E7D File Offset: 0x0008207D
		public CrtLinkRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			in1.ReadInt();
			in1.ReadInt();
			in1.ReadShort();
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x00018662 File Offset: 0x00016862
		protected override int DataSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00083E9A File Offset: 0x0008209A
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(0);
			out1.WriteInt(0);
			out1.WriteShort(0);
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00083EB1 File Offset: 0x000820B1
		public override short Sid
		{
			get
			{
				return 4130;
			}
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00083EB8 File Offset: 0x000820B8
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.CrtLinkRecord();
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00083EBF File Offset: 0x000820BF
		public override string ToString()
		{
			return "[CrtLink]Unused[/CrtLink]";
		}

		// Token: 0x04001360 RID: 4960
		public const short sid = 4130;
	}
}
