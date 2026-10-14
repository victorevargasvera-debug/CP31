using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047C RID: 1148
	public class FontIndexRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002A98 RID: 10904 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FontIndexRecord()
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0007F7CB File Offset: 0x0007D9CB
		public FontIndexRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_fontIndex = in1.ReadShort();
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0007F7E0 File Offset: 0x0007D9E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FONTX]\n");
			stringBuilder.Append("    .fontIndex            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FontIndex)).Append(" (").Append(this.FontIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/FONTX]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0007F860 File Offset: 0x0007DA60
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_fontIndex);
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x0007F86E File Offset: 0x0007DA6E
		public override short Sid
		{
			get
			{
				return 4134;
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0007F875 File Offset: 0x0007DA75
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.FontIndexRecord
			{
				field_1_fontIndex = this.field_1_fontIndex
			};
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x0007F888 File Offset: 0x0007DA88
		// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x0007F890 File Offset: 0x0007DA90
		public short FontIndex
		{
			get
			{
				return this.field_1_fontIndex;
			}
			set
			{
				this.field_1_fontIndex = value;
			}
		}

		// Token: 0x0400126B RID: 4715
		public const short sid = 4134;

		// Token: 0x0400126C RID: 4716
		private short field_1_fontIndex;
	}
}
