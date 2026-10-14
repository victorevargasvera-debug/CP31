using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046B RID: 1131
	public class AxisUsedRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002A0A RID: 10762 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxisUsedRecord()
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x0007E6EE File Offset: 0x0007C8EE
		public AxisUsedRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_numAxis = in1.ReadShort();
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0007E704 File Offset: 0x0007C904
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXISUSED]\n");
			stringBuilder.Append("    .numAxis              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.NumAxis)).Append(" (").Append(this.NumAxis).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AXISUSED]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0007E784 File Offset: 0x0007C984
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_numAxis);
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0007DDFA File Offset: 0x0007BFFA
		public override short Sid
		{
			get
			{
				return 4166;
			}
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0007E792 File Offset: 0x0007C992
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisUsedRecord
			{
				field_1_numAxis = this.field_1_numAxis
			};
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0007E7A5 File Offset: 0x0007C9A5
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0007E7AD File Offset: 0x0007C9AD
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

		// Token: 0x04001234 RID: 4660
		public const short sid = 4166;

		// Token: 0x04001235 RID: 4661
		private short field_1_numAxis;
	}
}
