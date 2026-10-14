using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E5 RID: 997
	public class HCenterRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060023E2 RID: 9186 RVA: 0x0005FE49 File Offset: 0x0005E049
		public HCenterRecord()
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0006C247 File Offset: 0x0006A447
		public HCenterRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_hcenter = in1.ReadShort();
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0006C25B File Offset: 0x0006A45B
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0006C266 File Offset: 0x0006A466
		public bool HCenter
		{
			get
			{
				return this.field_1_hcenter == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_hcenter = 1;
					return;
				}
				this.field_1_hcenter = 0;
			}
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0006C27C File Offset: 0x0006A47C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[HCENTER]\n");
			stringBuilder.Append("    .hcenter        = ").Append(this.HCenter).Append("\n");
			stringBuilder.Append("[/HCENTER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0006C2CC File Offset: 0x0006A4CC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_hcenter);
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0006C2DA File Offset: 0x0006A4DA
		public override short Sid
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0006C2E1 File Offset: 0x0006A4E1
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.HCenterRecord
			{
				field_1_hcenter = this.field_1_hcenter
			};
		}

		// Token: 0x04000F14 RID: 3860
		public const short sid = 131;

		// Token: 0x04000F15 RID: 3861
		private short field_1_hcenter;
	}
}
