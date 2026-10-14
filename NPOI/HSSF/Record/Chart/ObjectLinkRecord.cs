using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B2 RID: 1202
	public class ObjectLinkRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002CF4 RID: 11508 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ObjectLinkRecord()
		{
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000855F6 File Offset: 0x000837F6
		public ObjectLinkRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_anchorId = in1.ReadShort();
			this.field_2_link1 = in1.ReadShort();
			this.field_3_link2 = in1.ReadShort();
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00085624 File Offset: 0x00083824
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[OBJECTLINK]\n");
			stringBuilder.Append("    .AnchorId             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.AnchorId)).Append(" (").Append(this.AnchorId).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .link1                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Link1)).Append(" (").Append(this.Link1).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .link2                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Link2)).Append(" (").Append(this.Link2).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/OBJECTLINK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00085746 File Offset: 0x00083946
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_anchorId);
			out1.WriteShort((int)this.field_2_link1);
			out1.WriteShort((int)this.field_3_link2);
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x00017F5F File Offset: 0x0001615F
		protected override int DataSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x0008576C File Offset: 0x0008396C
		public override short Sid
		{
			get
			{
				return 4135;
			}
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00085773 File Offset: 0x00083973
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ObjectLinkRecord
			{
				field_1_anchorId = this.field_1_anchorId,
				field_2_link1 = this.field_2_link1,
				field_3_link2 = this.field_3_link2
			};
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x0008579E File Offset: 0x0008399E
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x000857A6 File Offset: 0x000839A6
		public short AnchorId
		{
			get
			{
				return this.field_1_anchorId;
			}
			set
			{
				this.field_1_anchorId = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000857AF File Offset: 0x000839AF
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x000857B7 File Offset: 0x000839B7
		public short Link1
		{
			get
			{
				return this.field_2_link1;
			}
			set
			{
				this.field_2_link1 = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000857C0 File Offset: 0x000839C0
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x000857C8 File Offset: 0x000839C8
		public short Link2
		{
			get
			{
				return this.field_3_link2;
			}
			set
			{
				this.field_3_link2 = value;
			}
		}

		// Token: 0x040013AF RID: 5039
		public const short sid = 4135;

		// Token: 0x040013B0 RID: 5040
		private short field_1_anchorId;

		// Token: 0x040013B1 RID: 5041
		public const short ANCHOR_ID_CHART_TITLE = 1;

		// Token: 0x040013B2 RID: 5042
		public const short ANCHOR_ID_Y_AXIS = 2;

		// Token: 0x040013B3 RID: 5043
		public const short ANCHOR_ID_X_AXIS = 3;

		// Token: 0x040013B4 RID: 5044
		public const short ANCHOR_ID_SERIES_OR_POINT = 4;

		// Token: 0x040013B5 RID: 5045
		public const short ANCHOR_ID_Z_AXIS = 7;

		// Token: 0x040013B6 RID: 5046
		private short field_2_link1;

		// Token: 0x040013B7 RID: 5047
		private short field_3_link2;
	}
}
