using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x0200044C RID: 1100
	public class ViewSourceRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060028AA RID: 10410 RVA: 0x0007ACFD File Offset: 0x00078EFD
		public ViewSourceRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.vs = (int)in1.ReadShort();
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0007AD11 File Offset: 0x00078F11
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.vs);
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0007AD1F File Offset: 0x00078F1F
		public override short Sid
		{
			get
			{
				return 227;
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0007AD28 File Offset: 0x00078F28
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXVS]\n");
			stringBuilder.Append("    .vs      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.vs)).Append('\n');
			stringBuilder.Append("[/SXVS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400117C RID: 4476
		public const short sid = 227;

		// Token: 0x0400117D RID: 4477
		private int vs;
	}
}
