using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041B RID: 1051
	public class SCLRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SCLRecord()
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00073D9D File Offset: 0x00071F9D
		public SCLRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_numerator = in1.ReadShort();
			this.field_2_denominator = in1.ReadShort();
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00073DC0 File Offset: 0x00071FC0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SCL]\n");
			stringBuilder.Append("    .numerator            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Numerator)).Append(" (").Append(this.Numerator).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .denominator          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Denominator)).Append(" (").Append(this.Denominator).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SCL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00073E91 File Offset: 0x00072091
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_numerator);
			out1.WriteShort((int)this.field_2_denominator);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00073EAB File Offset: 0x000720AB
		public override short Sid
		{
			get
			{
				return 160;
			}
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00073EB2 File Offset: 0x000720B2
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.SCLRecord
			{
				field_1_numerator = this.field_1_numerator,
				field_2_denominator = this.field_2_denominator
			};
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00073ED1 File Offset: 0x000720D1
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x00073ED9 File Offset: 0x000720D9
		public short Numerator
		{
			get
			{
				return this.field_1_numerator;
			}
			set
			{
				this.field_1_numerator = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x00073EE2 File Offset: 0x000720E2
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00073EEA File Offset: 0x000720EA
		public short Denominator
		{
			get
			{
				return this.field_2_denominator;
			}
			set
			{
				this.field_2_denominator = value;
			}
		}

		// Token: 0x04001020 RID: 4128
		public const short sid = 160;

		// Token: 0x04001021 RID: 4129
		private short field_1_numerator;

		// Token: 0x04001022 RID: 4130
		private short field_2_denominator;
	}
}
