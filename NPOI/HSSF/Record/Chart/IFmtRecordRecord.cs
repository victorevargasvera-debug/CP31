using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047F RID: 1151
	public class IFmtRecordRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002AA9 RID: 10921 RVA: 0x0005FE49 File Offset: 0x0005E049
		public IFmtRecordRecord()
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0007F8A7 File Offset: 0x0007DAA7
		public IFmtRecordRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_formatIndex = in1.ReadShort();
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0007F8BC File Offset: 0x0007DABC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[IFMT]\n");
			stringBuilder.Append("    .formatIndex          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatIndex)).Append(" (").Append(this.FormatIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/IFMT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0007F93C File Offset: 0x0007DB3C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_formatIndex);
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x0007F94A File Offset: 0x0007DB4A
		public override short Sid
		{
			get
			{
				return 4174;
			}
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0007F951 File Offset: 0x0007DB51
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.IFmtRecordRecord
			{
				field_1_formatIndex = this.field_1_formatIndex
			};
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x0007F964 File Offset: 0x0007DB64
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x0007F96C File Offset: 0x0007DB6C
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

		// Token: 0x0400126F RID: 4719
		public const short sid = 4174;

		// Token: 0x04001270 RID: 4720
		private short field_1_formatIndex;
	}
}
