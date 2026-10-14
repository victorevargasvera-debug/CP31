using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B1 RID: 1201
	public class NumberFormatIndexRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x0005FE49 File Offset: 0x0005E049
		public NumberFormatIndexRecord()
		{
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0008552D File Offset: 0x0008372D
		public NumberFormatIndexRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_formatIndex = in1.ReadShort();
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00085544 File Offset: 0x00083744
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[IFMT]\n");
			stringBuilder.Append("    .formatIndex          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatIndex)).Append(" (").Append(this.FormatIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/IFMT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000855C4 File Offset: 0x000837C4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_formatIndex);
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x0007F94A File Offset: 0x0007DB4A
		public override short Sid
		{
			get
			{
				return 4174;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000855D2 File Offset: 0x000837D2
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.NumberFormatIndexRecord
			{
				field_1_formatIndex = this.field_1_formatIndex
			};
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000855E5 File Offset: 0x000837E5
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x000855ED File Offset: 0x000837ED
		public short FormatIndex
		{
			get
			{
				return this.field_1_formatIndex;
			}
			set
			{
				this.field_1_formatIndex = value;
			}
		}

		// Token: 0x040013AD RID: 5037
		public const short sid = 4174;

		// Token: 0x040013AE RID: 5038
		private short field_1_formatIndex;
	}
}
