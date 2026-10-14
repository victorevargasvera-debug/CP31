using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x02000461 RID: 1121
	public class FtrHeader : global::System.ICloneable
	{
		// Token: 0x06002977 RID: 10615 RVA: 0x0007CE4F File Offset: 0x0007B04F
		public FtrHeader()
		{
			this.associatedRange = new global::NPOI.SS.Util.CellRangeAddress(0, 0, 0, 0);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x0007CE66 File Offset: 0x0007B066
		public FtrHeader(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.recordType = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.associatedRange = new global::NPOI.SS.Util.CellRangeAddress(in1);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0007CE94 File Offset: 0x0007B094
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(" [FUTURE HEADER]\n");
			stringBuilder.Append("   type " + this.recordType.ToString());
			stringBuilder.Append("   flags " + this.grbitFrt.ToString());
			stringBuilder.Append(" [/FUTURE HEADER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0007CEFB File Offset: 0x0007B0FB
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.recordType);
			out1.WriteShort((int)this.grbitFrt);
			this.associatedRange.Serialize(out1);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000184AD File Offset: 0x000166AD
		public static int GetDataSize()
		{
			return 12;
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0007CF21 File Offset: 0x0007B121
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0007CF29 File Offset: 0x0007B129
		public short RecordType
		{
			get
			{
				return this.recordType;
			}
			set
			{
				this.recordType = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0007CF32 File Offset: 0x0007B132
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0007CF3A File Offset: 0x0007B13A
		public short GrbitFrt
		{
			get
			{
				return this.grbitFrt;
			}
			set
			{
				this.grbitFrt = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x0007CF43 File Offset: 0x0007B143
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x0007CF4B File Offset: 0x0007B14B
		public global::NPOI.SS.Util.CellRangeAddress AssociatedRange
		{
			get
			{
				return this.associatedRange;
			}
			set
			{
				this.associatedRange = value;
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0007CF54 File Offset: 0x0007B154
		public object Clone()
		{
			return new global::NPOI.HSSF.Record.Common.FtrHeader
			{
				recordType = this.recordType,
				grbitFrt = this.grbitFrt,
				associatedRange = this.associatedRange.Copy()
			};
		}

		// Token: 0x040011F1 RID: 4593
		private short recordType;

		// Token: 0x040011F2 RID: 4594
		private short grbitFrt;

		// Token: 0x040011F3 RID: 4595
		private global::NPOI.SS.Util.CellRangeAddress associatedRange;
	}
}
