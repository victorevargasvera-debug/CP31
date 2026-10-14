using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000477 RID: 1143
	public class DefaultTextRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002A6C RID: 10860 RVA: 0x0005FE49 File Offset: 0x0005E049
		public DefaultTextRecord()
		{
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0007F21F File Offset: 0x0007D41F
		public DefaultTextRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_categoryDataType = in1.ReadShort();
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x0007F234 File Offset: 0x0007D434
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DEFAULTTEXT]\n");
			stringBuilder.Append("    .categoryDataType     = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex((short)this.FormatType)).Append(" (").Append(this.FormatType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/DEFAULTTEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x0007F2B9 File Offset: 0x0007D4B9
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_categoryDataType);
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x0007F2C7 File Offset: 0x0007D4C7
		public override short Sid
		{
			get
			{
				return 4132;
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0007F2CE File Offset: 0x0007D4CE
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.DefaultTextRecord
			{
				field_1_categoryDataType = this.field_1_categoryDataType
			};
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x0007F2E1 File Offset: 0x0007D4E1
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x0007F2E9 File Offset: 0x0007D4E9
		public global::NPOI.HSSF.Record.Chart.TextFormatInfo FormatType
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.TextFormatInfo)this.field_1_categoryDataType;
			}
			set
			{
				this.field_1_categoryDataType = (short)value;
			}
		}

		// Token: 0x0400125C RID: 4700
		public const short sid = 4132;

		// Token: 0x0400125D RID: 4701
		private short field_1_categoryDataType;
	}
}
