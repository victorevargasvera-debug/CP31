using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B6 RID: 1206
	public class PosRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D13 RID: 11539 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PosRecord()
		{
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00085950 File Offset: 0x00083B50
		public PosRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.mdTopLt = in1.ReadShort();
			this.mdBotRt = in1.ReadShort();
			this.x1 = in1.ReadShort();
			in1.ReadShort();
			this.y1 = in1.ReadShort();
			in1.ReadShort();
			this.x2 = in1.ReadShort();
			in1.ReadShort();
			this.y2 = in1.ReadShort();
			in1.ReadShort();
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000859C8 File Offset: 0x00083BC8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.mdTopLt);
			out1.WriteShort((int)this.mdBotRt);
			out1.WriteShort((int)this.x1);
			out1.WriteShort(0);
			out1.WriteShort((int)this.y1);
			out1.WriteShort(0);
			out1.WriteShort((int)this.x2);
			out1.WriteShort(0);
			out1.WriteShort((int)this.y2);
			out1.WriteShort(0);
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x00085A39 File Offset: 0x00083C39
		public override short Sid
		{
			get
			{
				return 4175;
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00085A40 File Offset: 0x00083C40
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.PosRecord
			{
				MdBotRt = this.MdBotRt,
				MDTopLt = this.MDTopLt,
				X1 = this.X1,
				X2 = this.X2,
				Y1 = this.Y1,
				Y2 = this.Y2
			};
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00085A9C File Offset: 0x00083C9C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[POS]\n");
			stringBuilder.Append("mdTopLt       = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.mdTopLt)).Append("\n");
			stringBuilder.Append("mdBotRt       = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.mdTopLt)).Append("\n");
			stringBuilder.Append("x1            = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.x1)).Append("\n");
			stringBuilder.Append("x2            = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.x2)).Append("\n");
			stringBuilder.Append("y1            = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.y1)).Append("\n");
			stringBuilder.Append("y2            = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.y2)).Append("\n");
			stringBuilder.Append("[/POS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00085BAF File Offset: 0x00083DAF
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00085BB7 File Offset: 0x00083DB7
		public global::NPOI.HSSF.Record.Chart.PositionMode MDTopLt
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.PositionMode)this.mdTopLt;
			}
			set
			{
				this.mdTopLt = (short)value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x00085BC0 File Offset: 0x00083DC0
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x00085BC8 File Offset: 0x00083DC8
		public global::NPOI.HSSF.Record.Chart.PositionMode MdBotRt
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.PositionMode)this.mdBotRt;
			}
			set
			{
				this.mdBotRt = (short)value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x00085BD1 File Offset: 0x00083DD1
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x00085BD9 File Offset: 0x00083DD9
		public short X1
		{
			get
			{
				return this.x1;
			}
			set
			{
				this.x1 = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x00085BE2 File Offset: 0x00083DE2
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x00085BEA File Offset: 0x00083DEA
		public short X2
		{
			get
			{
				return this.x2;
			}
			set
			{
				this.x2 = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00085BF3 File Offset: 0x00083DF3
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x00085BFB File Offset: 0x00083DFB
		public short Y1
		{
			get
			{
				return this.y1;
			}
			set
			{
				this.y1 = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x00085C04 File Offset: 0x00083E04
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x00085C0C File Offset: 0x00083E0C
		public short Y2
		{
			get
			{
				return this.y2;
			}
			set
			{
				this.y2 = value;
			}
		}

		// Token: 0x040013C2 RID: 5058
		public const short sid = 4175;

		// Token: 0x040013C3 RID: 5059
		private short mdTopLt;

		// Token: 0x040013C4 RID: 5060
		private short mdBotRt;

		// Token: 0x040013C5 RID: 5061
		private short x1;

		// Token: 0x040013C6 RID: 5062
		private short y1;

		// Token: 0x040013C7 RID: 5063
		private short x2;

		// Token: 0x040013C8 RID: 5064
		private short y2;
	}
}
