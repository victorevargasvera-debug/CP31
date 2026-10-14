using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B8 RID: 1208
	public class SeriesIndexRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D30 RID: 11568 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SeriesIndexRecord()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00085CF1 File Offset: 0x00083EF1
		public SeriesIndexRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_index = in1.ReadShort();
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00085D08 File Offset: 0x00083F08
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SINDEX]\n");
			stringBuilder.Append("    .index                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Index)).Append(" (").Append(this.Index).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SINDEX]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00085D88 File Offset: 0x00083F88
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_index);
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00085D96 File Offset: 0x00083F96
		public override short Sid
		{
			get
			{
				return 4197;
			}
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00085D9D File Offset: 0x00083F9D
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesIndexRecord
			{
				field_1_index = this.field_1_index
			};
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x00085DB0 File Offset: 0x00083FB0
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x00085DB8 File Offset: 0x00083FB8
		public short Index
		{
			get
			{
				return this.field_1_index;
			}
			set
			{
				this.field_1_index = value;
			}
		}

		// Token: 0x040013CB RID: 5067
		public const short sid = 4197;

		// Token: 0x040013CC RID: 5068
		private short field_1_index;
	}
}
