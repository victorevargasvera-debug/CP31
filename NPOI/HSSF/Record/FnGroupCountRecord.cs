using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DD RID: 989
	public class FnGroupCountRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600235D RID: 9053 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FnGroupCountRecord()
		{
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0006AF15 File Offset: 0x00069115
		public FnGroupCountRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_count = in1.ReadShort();
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0006AF29 File Offset: 0x00069129
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x0006AF31 File Offset: 0x00069131
		public short Count
		{
			get
			{
				return this.field_1_count;
			}
			set
			{
				this.field_1_count = value;
			}
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0006AF3C File Offset: 0x0006913C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FNGROUPCOUNT]\n");
			stringBuilder.Append("    .count            = ").Append(this.Count).Append("\n");
			stringBuilder.Append("[/FNGROUPCOUNT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0006AF8C File Offset: 0x0006918C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Count);
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0006AF9A File Offset: 0x0006919A
		public override short Sid
		{
			get
			{
				return 156;
			}
		}

		// Token: 0x04000EE4 RID: 3812
		public const short sid = 156;

		// Token: 0x04000EE5 RID: 3813
		public const short COUNT = 14;

		// Token: 0x04000EE6 RID: 3814
		private short field_1_count;
	}
}
