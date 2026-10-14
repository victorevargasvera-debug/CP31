using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BA RID: 954
	public class UnitsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600216E RID: 8558 RVA: 0x0005FE49 File Offset: 0x0005E049
		public UnitsRecord()
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000662E8 File Offset: 0x000644E8
		public UnitsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_units = in1.ReadShort();
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000662FC File Offset: 0x000644FC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[UNITS]\n");
			stringBuilder.Append("    .units                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Units)).Append(" (").Append(this.Units).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/UNITS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0006637C File Offset: 0x0006457C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_units);
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x0006638A File Offset: 0x0006458A
		public override short Sid
		{
			get
			{
				return 4097;
			}
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00066391 File Offset: 0x00064591
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.UnitsRecord
			{
				field_1_units = this.field_1_units
			};
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000663A4 File Offset: 0x000645A4
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x000663AC File Offset: 0x000645AC
		public short Units
		{
			get
			{
				return this.field_1_units;
			}
			set
			{
				this.field_1_units = value;
			}
		}

		// Token: 0x04000D24 RID: 3364
		public const short sid = 4097;

		// Token: 0x04000D25 RID: 3365
		private short field_1_units;
	}
}
