using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000467 RID: 1127
	public class AxesUsedRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxesUsedRecord()
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x0007DD56 File Offset: 0x0007BF56
		public AxesUsedRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_numAxis = in1.ReadShort();
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0007DD6C File Offset: 0x0007BF6C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXISUSED]\n");
			stringBuilder.Append("    .numAxis              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.NumAxis)).Append(" (").Append(this.NumAxis).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AXISUSED]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0007DDEC File Offset: 0x0007BFEC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_numAxis);
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x0007DDFA File Offset: 0x0007BFFA
		public override short Sid
		{
			get
			{
				return 4166;
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0007DE01 File Offset: 0x0007C001
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxesUsedRecord
			{
				field_1_numAxis = this.field_1_numAxis
			};
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0007DE14 File Offset: 0x0007C014
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0007DE1C File Offset: 0x0007C01C
		public short NumAxis
		{
			get
			{
				return this.field_1_numAxis;
			}
			set
			{
				this.field_1_numAxis = value;
			}
		}

		// Token: 0x04001215 RID: 4629
		public const short sid = 4166;

		// Token: 0x04001216 RID: 4630
		private short field_1_numAxis;
	}
}
