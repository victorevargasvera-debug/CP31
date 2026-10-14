using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000433 RID: 1075
	public class TableStylesRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027AB RID: 10155 RVA: 0x00077490 File Offset: 0x00075690
		public TableStylesRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadUShort();
			this.grbitFrt = in1.ReadUShort();
			in1.ReadFully(this.unused);
			this.cts = in1.ReadInt();
			int requestedLength = in1.ReadUShort();
			int requestedLength2 = in1.ReadUShort();
			this.rgchDefListStyle = in1.ReadUnicodeLEString(requestedLength);
			this.rgchDefPivotStyle = in1.ReadUnicodeLEString(requestedLength2);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00077508 File Offset: 0x00075708
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.rt);
			out1.WriteShort(this.grbitFrt);
			out1.Write(this.unused);
			out1.WriteInt(this.cts);
			out1.WriteShort(this.rgchDefListStyle.Length);
			out1.WriteShort(this.rgchDefPivotStyle.Length);
			global::NPOI.Util.StringUtil.PutUnicodeLE(this.rgchDefListStyle, out1);
			global::NPOI.Util.StringUtil.PutUnicodeLE(this.rgchDefPivotStyle, out1);
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x0007757F File Offset: 0x0007577F
		protected override int DataSize
		{
			get
			{
				return 20 + 2 * this.rgchDefListStyle.Length + 2 * this.rgchDefPivotStyle.Length;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x0007759F File Offset: 0x0007579F
		public override short Sid
		{
			get
			{
				return 2190;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000775A8 File Offset: 0x000757A8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TABLESTYLES]\n");
			stringBuilder.Append("    .rt      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt=").Append(global::NPOI.Util.HexDump.ShortToHex(this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .unused  =").Append(global::NPOI.Util.HexDump.ToHex(this.unused)).Append('\n');
			stringBuilder.Append("    .cts=").Append(global::NPOI.Util.HexDump.IntToHex(this.cts)).Append('\n');
			stringBuilder.Append("    .rgchDefListStyle=").Append(this.rgchDefListStyle).Append('\n');
			stringBuilder.Append("    .rgchDefPivotStyle=").Append(this.rgchDefPivotStyle).Append('\n');
			stringBuilder.Append("[/TABLESTYLES]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040010CD RID: 4301
		public const short sid = 2190;

		// Token: 0x040010CE RID: 4302
		private int rt;

		// Token: 0x040010CF RID: 4303
		private int grbitFrt;

		// Token: 0x040010D0 RID: 4304
		private byte[] unused = new byte[8];

		// Token: 0x040010D1 RID: 4305
		private int cts;

		// Token: 0x040010D2 RID: 4306
		private string rgchDefListStyle;

		// Token: 0x040010D3 RID: 4307
		private string rgchDefPivotStyle;
	}
}
