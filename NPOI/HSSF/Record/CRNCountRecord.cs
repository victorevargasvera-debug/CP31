using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BF RID: 959
	public class CRNCountRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060021B0 RID: 8624 RVA: 0x00066A78 File Offset: 0x00064C78
		public CRNCountRecord()
		{
			throw new global::NPOI.Util.RuntimeException("incomplete code");
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00066A8A File Offset: 0x00064C8A
		public CRNCountRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_number_crn_records = (int)in1.ReadShort();
			if (this.field_1_number_crn_records < 0)
			{
				this.field_1_number_crn_records = (int)((short)(-(short)this.field_1_number_crn_records));
			}
			this.field_2_sheet_table_index = (int)in1.ReadShort();
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00066AC1 File Offset: 0x00064CC1
		public int NumberOfCRNs
		{
			get
			{
				return this.field_1_number_crn_records;
			}
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00066ACC File Offset: 0x00064CCC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append(" [XCT");
			stringBuilder.Append(" nCRNs=").Append(this.field_1_number_crn_records);
			stringBuilder.Append(" sheetIx=").Append(this.field_2_sheet_table_index);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00066B39 File Offset: 0x00064D39
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)((short)this.field_1_number_crn_records));
			out1.WriteShort((int)((short)this.field_2_sheet_table_index));
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00066B55 File Offset: 0x00064D55
		public override short Sid
		{
			get
			{
				return 89;
			}
		}

		// Token: 0x04000D38 RID: 3384
		public const short sid = 89;

		// Token: 0x04000D39 RID: 3385
		private const short DATA_SIZE = 4;

		// Token: 0x04000D3A RID: 3386
		private int field_1_number_crn_records;

		// Token: 0x04000D3B RID: 3387
		private int field_2_sheet_table_index;
	}
}
