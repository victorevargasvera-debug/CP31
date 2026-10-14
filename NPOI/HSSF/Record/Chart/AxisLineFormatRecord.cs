using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000469 RID: 1129
	public class AxisLineFormatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060029D5 RID: 10709 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxisLineFormatRecord()
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0007DE25 File Offset: 0x0007C025
		public AxisLineFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_axisType = in1.ReadShort();
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0007DE3C File Offset: 0x0007C03C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXISLINEFORMAT]\n");
			stringBuilder.Append("    .axisType             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.AxisType)).Append(" (").Append(this.AxisType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AXISLINEFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0007DEBC File Offset: 0x0007C0BC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_axisType);
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x0007DECA File Offset: 0x0007C0CA
		public override short Sid
		{
			get
			{
				return 4129;
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x0007DED1 File Offset: 0x0007C0D1
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord
			{
				field_1_axisType = this.field_1_axisType
			};
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		// (set) Token: 0x060029DD RID: 10717 RVA: 0x0007DEEC File Offset: 0x0007C0EC
		public short AxisType
		{
			get
			{
				return this.field_1_axisType;
			}
			set
			{
				this.field_1_axisType = value;
			}
		}

		// Token: 0x0400121C RID: 4636
		public const short sid = 4129;

		// Token: 0x0400121D RID: 4637
		private short field_1_axisType;

		// Token: 0x0400121E RID: 4638
		public static short AXIS_TYPE_AXIS_LINE = 0;

		// Token: 0x0400121F RID: 4639
		public static short AXIS_TYPE_MAJOR_GRID_LINE = 1;

		// Token: 0x04001220 RID: 4640
		public static short AXIS_TYPE_MINOR_GRID_LINE = 2;

		// Token: 0x04001221 RID: 4641
		public static short AXIS_TYPE_WALLS_OR_FLOOR = 3;
	}
}
