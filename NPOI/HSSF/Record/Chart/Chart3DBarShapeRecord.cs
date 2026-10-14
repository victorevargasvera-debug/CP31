using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000470 RID: 1136
	public class Chart3DBarShapeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x0005FE49 File Offset: 0x0005E049
		public Chart3DBarShapeRecord()
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		public Chart3DBarShapeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_riser = (byte)in1.ReadByte();
			this.field_2_taper = (byte)in1.ReadByte();
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0007EEEC File Offset: 0x0007D0EC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[Chart3DBarShape]\n");
			stringBuilder.Append("    .axisType             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Riser)).Append(" (").Append(this.Riser).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .x                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Taper)).Append(" (").Append(this.Taper).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/Chart3DBarShape]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0007EFBD File Offset: 0x0007D1BD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.field_1_riser);
			out1.WriteByte((int)this.field_2_taper);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0007EFD7 File Offset: 0x0007D1D7
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.Chart3DBarShapeRecord
			{
				Riser = this.Riser,
				Taper = this.Taper
			};
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x0007EFF6 File Offset: 0x0007D1F6
		public override short Sid
		{
			get
			{
				return 4191;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0007EFFD File Offset: 0x0007D1FD
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0007F005 File Offset: 0x0007D205
		public byte Riser
		{
			get
			{
				return this.field_1_riser;
			}
			set
			{
				this.field_1_riser = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x0007F00E File Offset: 0x0007D20E
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0007F016 File Offset: 0x0007D216
		public byte Taper
		{
			get
			{
				return this.field_2_taper;
			}
			set
			{
				this.field_2_taper = value;
			}
		}

		// Token: 0x04001248 RID: 4680
		public const short sid = 4191;

		// Token: 0x04001249 RID: 4681
		private byte field_1_riser;

		// Token: 0x0400124A RID: 4682
		private byte field_2_taper;
	}
}
