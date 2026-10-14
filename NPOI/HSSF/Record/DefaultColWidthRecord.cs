using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C4 RID: 964
	public class DefaultColWidthRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060021D8 RID: 8664 RVA: 0x00066F30 File Offset: 0x00065130
		public DefaultColWidthRecord()
		{
			this.field_1_col_width = 8;
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00066F3F File Offset: 0x0006513F
		public DefaultColWidthRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_col_width = in1.ReadUShort();
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00066F53 File Offset: 0x00065153
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00066F5B File Offset: 0x0006515B
		public int ColWidth
		{
			get
			{
				return this.field_1_col_width;
			}
			set
			{
				this.field_1_col_width = value;
			}
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00066F64 File Offset: 0x00065164
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DEFAULTCOLWIDTH]\n");
			stringBuilder.Append("    .colwidth      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ColWidth)).Append("\n");
			stringBuilder.Append("[/DEFAULTCOLWIDTH]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00066FB9 File Offset: 0x000651B9
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.ColWidth);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00066FC7 File Offset: 0x000651C7
		public override short Sid
		{
			get
			{
				return 85;
			}
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00066FCB File Offset: 0x000651CB
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.DefaultColWidthRecord
			{
				field_1_col_width = this.field_1_col_width
			};
		}

		// Token: 0x04000D47 RID: 3399
		public const short sid = 85;

		// Token: 0x04000D48 RID: 3400
		private int field_1_col_width;

		// Token: 0x04000D49 RID: 3401
		public const int DEFAULT_COLUMN_WIDTH = 8;

		// Token: 0x04000D4A RID: 3402
		internal int offsetForFilePointer;
	}
}
