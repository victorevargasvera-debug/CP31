using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A1 RID: 1185
	public class CatLabRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C28 RID: 11304 RVA: 0x00083060 File Offset: 0x00081260
		public CatLabRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.wOffset = in1.ReadShort();
			this.at = in1.ReadShort();
			this.grbit = in1.ReadShort();
			if (in1.Available() == 0)
			{
				this.unused = null;
				return;
			}
			this.unused = new short?(in1.ReadShort());
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x000830D5 File Offset: 0x000812D5
		protected override int DataSize
		{
			get
			{
				return 10 + ((this.unused == null) ? 0 : 2);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x000830EB File Offset: 0x000812EB
		public override short Sid
		{
			get
			{
				return 2134;
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000830F4 File Offset: 0x000812F4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.wOffset);
			out1.WriteShort((int)this.at);
			out1.WriteShort((int)this.grbit);
			if (this.unused != null)
			{
				out1.WriteShort((int)this.unused.Value);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0008315C File Offset: 0x0008135C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CATLAB]\n");
			stringBuilder.Append("    .rt      =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .wOffset =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.wOffset)).Append('\n');
			stringBuilder.Append("    .at      =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.at)).Append('\n');
			stringBuilder.Append("    .grbit   =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbit)).Append('\n');
			stringBuilder.Append("    .unused  =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.unused.Value)).Append('\n');
			stringBuilder.Append("[/CATLAB]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001336 RID: 4918
		public const short sid = 2134;

		// Token: 0x04001337 RID: 4919
		private short rt;

		// Token: 0x04001338 RID: 4920
		private short grbitFrt;

		// Token: 0x04001339 RID: 4921
		private short wOffset;

		// Token: 0x0400133A RID: 4922
		private short at;

		// Token: 0x0400133B RID: 4923
		private short grbit;

		// Token: 0x0400133C RID: 4924
		private short? unused;
	}
}
