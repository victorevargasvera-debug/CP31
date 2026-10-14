using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A0 RID: 1184
	public class BeginRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C20 RID: 11296 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BeginRecord()
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BeginRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00083029 File Offset: 0x00081229
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BEGIN]\n");
			stringBuilder.Append("[/BEGIN]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x0008304D File Offset: 0x0008124D
		public override short Sid
		{
			get
			{
				return 4147;
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0004FE17 File Offset: 0x0004E017
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.BeginRecord();
		}

		// Token: 0x04001334 RID: 4916
		public const short sid = 4147;

		// Token: 0x04001335 RID: 4917
		public static global::NPOI.HSSF.Record.Chart.BeginRecord instance = new global::NPOI.HSSF.Record.Chart.BeginRecord();
	}
}
