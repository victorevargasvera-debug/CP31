using System;
using System.Text;
using NPOI.SS.Formula.Constant;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C0 RID: 960
	public class CRNRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060021B7 RID: 8631 RVA: 0x00066B59 File Offset: 0x00064D59
		public CRNRecord()
		{
			throw new global::System.NotImplementedException("incomplete code");
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00066B6C File Offset: 0x00064D6C
		public CRNRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_last_column_index = (in1.ReadByte() & 255);
			this.field_2_first_column_index = (in1.ReadByte() & 255);
			this.field_3_row_index = (int)in1.ReadShort();
			int nValues = this.field_1_last_column_index - this.field_2_first_column_index + 1;
			this.field_4_constant_values = global::NPOI.SS.Formula.Constant.ConstantValueParser.Parse(in1, nValues);
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00066BCC File Offset: 0x00064DCC
		public int NumberOfCRNs
		{
			get
			{
				return this.field_1_last_column_index;
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00066BD4 File Offset: 0x00064DD4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append(" [CRN");
			stringBuilder.Append(" rowIx=").Append(this.field_3_row_index);
			stringBuilder.Append(" firstColIx=").Append(this.field_2_first_column_index);
			stringBuilder.Append(" lastColIx=").Append(this.field_1_last_column_index);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00066C58 File Offset: 0x00064E58
		protected override int DataSize
		{
			get
			{
				return 4 + global::NPOI.SS.Formula.Constant.ConstantValueParser.GetEncodedSize(this.field_4_constant_values);
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00066C67 File Offset: 0x00064E67
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte(this.field_1_last_column_index);
			out1.WriteByte(this.field_2_first_column_index);
			out1.WriteShort(this.field_3_row_index);
			global::NPOI.SS.Formula.Constant.ConstantValueParser.Encode(out1, this.field_4_constant_values);
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00066C99 File Offset: 0x00064E99
		public override short Sid
		{
			get
			{
				return 90;
			}
		}

		// Token: 0x04000D3C RID: 3388
		public const short sid = 90;

		// Token: 0x04000D3D RID: 3389
		private int field_1_last_column_index;

		// Token: 0x04000D3E RID: 3390
		private int field_2_first_column_index;

		// Token: 0x04000D3F RID: 3391
		private int field_3_row_index;

		// Token: 0x04000D40 RID: 3392
		private object[] field_4_constant_values;
	}
}
