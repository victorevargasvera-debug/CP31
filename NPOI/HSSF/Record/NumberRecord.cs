using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FC RID: 1020
	public class NumberRecord : global::NPOI.HSSF.Record.CellRecord, global::System.ICloneable
	{
		// Token: 0x06002504 RID: 9476 RVA: 0x00064026 File Offset: 0x00062226
		public NumberRecord()
		{
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0006F3AF File Offset: 0x0006D5AF
		public NumberRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this.field_4_value = in1.ReadDouble();
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x0006F3C4 File Offset: 0x0006D5C4
		protected override string RecordName
		{
			get
			{
				return "NUMBER";
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0006F3CB File Offset: 0x0006D5CB
		protected override void AppendValueText(global::System.Text.StringBuilder sb)
		{
			sb.Append("  .value= ").Append(global::NPOI.SS.Util.NumberToTextConverter.ToText(this.field_4_value));
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0006F3E9 File Offset: 0x0006D5E9
		protected override void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.Value);
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int ValueDataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x0006F3F7 File Offset: 0x0006D5F7
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x0006F3FF File Offset: 0x0006D5FF
		public double Value
		{
			get
			{
				return this.field_4_value;
			}
			set
			{
				this.field_4_value = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x0006F408 File Offset: 0x0006D608
		public override short Sid
		{
			get
			{
				return 515;
			}
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0006F410 File Offset: 0x0006D610
		public override object Clone()
		{
			global::NPOI.HSSF.Record.NumberRecord numberRecord = new global::NPOI.HSSF.Record.NumberRecord();
			base.CopyBaseFields(numberRecord);
			numberRecord.field_4_value = this.field_4_value;
			return numberRecord;
		}

		// Token: 0x04000F94 RID: 3988
		public const short sid = 515;

		// Token: 0x04000F95 RID: 3989
		private double field_4_value;
	}
}
