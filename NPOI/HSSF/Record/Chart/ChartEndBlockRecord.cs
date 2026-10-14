using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A2 RID: 1186
	public class ChartEndBlockRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ChartEndBlockRecord()
		{
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00083264 File Offset: 0x00081464
		public ChartEndBlockRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.iObjectKind = in1.ReadShort();
			if (in1.Available() == 0)
			{
				this.unused = new byte[0];
				return;
			}
			this.unused = new byte[6];
			in1.ReadFully(this.unused);
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000832C8 File Offset: 0x000814C8
		protected override int DataSize
		{
			get
			{
				return 6 + this.unused.Length;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x0007F394 File Offset: 0x0007D594
		public override short Sid
		{
			get
			{
				return 2131;
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000832D4 File Offset: 0x000814D4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.iObjectKind);
			out1.Write(this.unused);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00083308 File Offset: 0x00081508
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ENDBLOCK]\n");
			stringBuilder.Append("    .rt         =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt   =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.iObjectKind)).Append('\n');
			stringBuilder.Append("    .unused     =").Append(global::NPOI.Util.HexDump.ToHex(this.unused)).Append('\n');
			stringBuilder.Append("[/ENDBLOCK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000833C4 File Offset: 0x000815C4
		public global::NPOI.HSSF.Record.Chart.ChartEndBlockRecord clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ChartEndBlockRecord
			{
				rt = this.rt,
				grbitFrt = this.grbitFrt,
				iObjectKind = this.iObjectKind,
				unused = (byte[])this.unused.Clone()
			};
		}

		// Token: 0x0400133D RID: 4925
		public const short sid = 2131;

		// Token: 0x0400133E RID: 4926
		private short rt;

		// Token: 0x0400133F RID: 4927
		private short grbitFrt;

		// Token: 0x04001340 RID: 4928
		private short iObjectKind;

		// Token: 0x04001341 RID: 4929
		private byte[] unused;
	}
}
