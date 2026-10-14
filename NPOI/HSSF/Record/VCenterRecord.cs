using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043B RID: 1083
	public class VCenterRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027FA RID: 10234 RVA: 0x0005FE49 File Offset: 0x0005E049
		public VCenterRecord()
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000789FB File Offset: 0x00076BFB
		public VCenterRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_vcenter = in1.ReadShort();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x00078A0F File Offset: 0x00076C0F
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00078A1A File Offset: 0x00076C1A
		public bool VCenter
		{
			get
			{
				return this.field_1_vcenter == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_vcenter = 1;
					return;
				}
				this.field_1_vcenter = 0;
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00078A30 File Offset: 0x00076C30
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[VCENTER]\n");
			stringBuilder.Append("    .vcenter        = ").Append(this.VCenter).Append("\n");
			stringBuilder.Append("[/VCENTER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00078A80 File Offset: 0x00076C80
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_vcenter);
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00078A8E File Offset: 0x00076C8E
		public override short Sid
		{
			get
			{
				return 132;
			}
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00078A95 File Offset: 0x00076C95
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.VCenterRecord
			{
				field_1_vcenter = this.field_1_vcenter
			};
		}

		// Token: 0x040010FC RID: 4348
		public const short sid = 132;

		// Token: 0x040010FD RID: 4349
		private short field_1_vcenter;
	}
}
