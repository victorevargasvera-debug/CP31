using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F1 RID: 1009
	[global::System.Serializable]
	public class LabelSSTRecord : global::NPOI.HSSF.Record.CellRecord, global::System.ICloneable
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x00064026 File Offset: 0x00062226
		public LabelSSTRecord()
		{
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0006DA90 File Offset: 0x0006BC90
		public LabelSSTRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this.field_4_sst_index = in1.ReadInt();
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0006DAA5 File Offset: 0x0006BCA5
		protected override string RecordName
		{
			get
			{
				return "LABELSST";
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0006DAAC File Offset: 0x0006BCAC
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0006DAB4 File Offset: 0x0006BCB4
		public int SSTIndex
		{
			get
			{
				return this.field_4_sst_index;
			}
			set
			{
				this.field_4_sst_index = value;
			}
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0006DABD File Offset: 0x0006BCBD
		protected override void AppendValueText(global::System.Text.StringBuilder sb)
		{
			sb.Append("  .sstIndex = ");
			sb.Append(global::NPOI.Util.HexDump.ShortToHex(this.SSTIndex));
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0006DADD File Offset: 0x0006BCDD
		protected override void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.SSTIndex);
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x00018498 File Offset: 0x00016698
		protected override int ValueDataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0006DAEB File Offset: 0x0006BCEB
		public override short Sid
		{
			get
			{
				return 253;
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0006DAF4 File Offset: 0x0006BCF4
		public override object Clone()
		{
			global::NPOI.HSSF.Record.LabelSSTRecord labelSSTRecord = new global::NPOI.HSSF.Record.LabelSSTRecord();
			base.CopyBaseFields(labelSSTRecord);
			labelSSTRecord.field_4_sst_index = this.field_4_sst_index;
			return labelSSTRecord;
		}

		// Token: 0x04000F51 RID: 3921
		public const short sid = 253;

		// Token: 0x04000F52 RID: 3922
		private int field_4_sst_index;
	}
}
