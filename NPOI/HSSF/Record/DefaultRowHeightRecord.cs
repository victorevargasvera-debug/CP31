using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C5 RID: 965
	public class DefaultRowHeightRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060021E1 RID: 8673 RVA: 0x00066FDE File Offset: 0x000651DE
		public DefaultRowHeightRecord()
		{
			this.field_1_option_flags = 0;
			this.field_2_row_height = 255;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00066FF8 File Offset: 0x000651F8
		public DefaultRowHeightRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_option_flags = in1.ReadShort();
			this.field_2_row_height = in1.ReadShort();
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00067018 File Offset: 0x00065218
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x00067020 File Offset: 0x00065220
		internal short OptionFlags
		{
			get
			{
				return this.field_1_option_flags;
			}
			set
			{
				this.field_1_option_flags = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00067029 File Offset: 0x00065229
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x00067031 File Offset: 0x00065231
		public short RowHeight
		{
			get
			{
				return this.field_2_row_height;
			}
			set
			{
				this.field_2_row_height = value;
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0006703C File Offset: 0x0006523C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DEFAULTROWHEIGHT]\n");
			stringBuilder.Append("    .optionflags    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.OptionFlags)).Append("\n");
			stringBuilder.Append("    .rowheight      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RowHeight)).Append("\n");
			stringBuilder.Append("[/DEFAULTROWHEIGHT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000670B7 File Offset: 0x000652B7
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.OptionFlags);
			out1.WriteShort((int)this.RowHeight);
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x000670D1 File Offset: 0x000652D1
		public override short Sid
		{
			get
			{
				return 549;
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000670D8 File Offset: 0x000652D8
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.DefaultRowHeightRecord
			{
				field_1_option_flags = this.field_1_option_flags,
				field_2_row_height = this.field_2_row_height
			};
		}

		// Token: 0x04000D4B RID: 3403
		public const short sid = 549;

		// Token: 0x04000D4C RID: 3404
		private short field_1_option_flags;

		// Token: 0x04000D4D RID: 3405
		private short field_2_row_height;

		// Token: 0x04000D4E RID: 3406
		public const short DEFAULT_ROW_HEIGHT = 255;
	}
}
