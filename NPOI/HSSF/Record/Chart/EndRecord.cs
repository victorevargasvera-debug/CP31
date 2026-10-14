using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AC RID: 1196
	public class EndRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C8B RID: 11403 RVA: 0x0005FE49 File Offset: 0x0005E049
		public EndRecord()
		{
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x0005FE49 File Offset: 0x0005E049
		public EndRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00084515 File Offset: 0x00082715
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[END]\n");
			stringBuilder.Append("[/END]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override int DataSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x00084539 File Offset: 0x00082739
		public override short Sid
		{
			get
			{
				return 4148;
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x0004FCC3 File Offset: 0x0004DEC3
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.EndRecord();
		}

		// Token: 0x04001371 RID: 4977
		public const short sid = 4148;

		// Token: 0x04001372 RID: 4978
		public static global::NPOI.HSSF.Record.Chart.EndRecord instance = new global::NPOI.HSSF.Record.Chart.EndRecord();
	}
}
