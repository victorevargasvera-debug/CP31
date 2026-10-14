using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000479 RID: 1145
	public class EndBlockRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0007F2F9 File Offset: 0x0007D4F9
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0007F301 File Offset: 0x0007D501
		public global::NPOI.HSSF.Record.Chart.ObjectKind ObjectKind { get; set; }

		// Token: 0x06002A7B RID: 10875 RVA: 0x0007F30A File Offset: 0x0007D50A
		public EndBlockRecord()
		{
			this.rt = 2131;
			this.grbitFrt = 0;
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0007F324 File Offset: 0x0007D524
		public EndBlockRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.ObjectKind = (global::NPOI.HSSF.Record.Chart.ObjectKind)in1.ReadShort();
			if (in1.Available() == 0)
			{
				this.unused = new byte[0];
				return;
			}
			this.unused = new byte[6];
			in1.ReadFully(this.unused);
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0007F388 File Offset: 0x0007D588
		protected override int DataSize
		{
			get
			{
				return 6 + this.unused.Length;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x0007F394 File Offset: 0x0007D594
		public override short Sid
		{
			get
			{
				return 2131;
			}
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0007F39B File Offset: 0x0007D59B
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteShort((int)this.ObjectKind);
			out1.Write(this.unused);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0007F3D0 File Offset: 0x0007D5D0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ENDBLOCK]\n");
			stringBuilder.Append("    .rt         =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt   =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .iObjectKind=").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.ObjectKind)).Append('\n');
			stringBuilder.Append("[/ENDBLOCK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0007F468 File Offset: 0x0007D668
		public global::NPOI.HSSF.Record.Chart.EndBlockRecord clone()
		{
			return new global::NPOI.HSSF.Record.Chart.EndBlockRecord
			{
				rt = this.rt,
				grbitFrt = this.grbitFrt,
				ObjectKind = this.ObjectKind,
				unused = (byte[])this.unused.Clone()
			};
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0007F4B4 File Offset: 0x0007D6B4
		public static global::NPOI.HSSF.Record.Chart.EndBlockRecord CreateEndBlock(global::NPOI.HSSF.Record.Chart.ObjectKind objectKind)
		{
			return new global::NPOI.HSSF.Record.Chart.EndBlockRecord
			{
				ObjectKind = objectKind
			};
		}

		// Token: 0x0400125F RID: 4703
		public const short sid = 2131;

		// Token: 0x04001260 RID: 4704
		private short rt;

		// Token: 0x04001261 RID: 4705
		private short grbitFrt;

		// Token: 0x04001263 RID: 4707
		private byte[] unused;
	}
}
