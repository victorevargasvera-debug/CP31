using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C7 RID: 967
	public class DimensionsRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x0005FE49 File Offset: 0x0005E049
		public DimensionsRecord()
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0006718C File Offset: 0x0006538C
		public DimensionsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_first_row = in1.ReadInt();
			this.field_2_last_row = in1.ReadInt();
			this.field_3_first_col = (int)in1.ReadShort();
			this.field_4_last_col = (int)in1.ReadShort();
			this.field_5_zero = in1.ReadShort();
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x000671DB File Offset: 0x000653DB
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x000671E3 File Offset: 0x000653E3
		public int FirstRow
		{
			get
			{
				return this.field_1_first_row;
			}
			set
			{
				this.field_1_first_row = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000671EC File Offset: 0x000653EC
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x000671F4 File Offset: 0x000653F4
		public int LastRow
		{
			get
			{
				return this.field_2_last_row;
			}
			set
			{
				this.field_2_last_row = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x000671FD File Offset: 0x000653FD
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x00067205 File Offset: 0x00065405
		public int FirstCol
		{
			get
			{
				return this.field_3_first_col;
			}
			set
			{
				this.field_3_first_col = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0006720E File Offset: 0x0006540E
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x00067216 File Offset: 0x00065416
		public int LastCol
		{
			get
			{
				return this.field_4_last_col;
			}
			set
			{
				this.field_4_last_col = value;
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00067220 File Offset: 0x00065420
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DIMENSIONS]\n");
			stringBuilder.Append("    .firstrow       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstRow)).Append("\n");
			stringBuilder.Append("    .lastrow        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastRow)).Append("\n");
			stringBuilder.Append("    .firstcol       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstCol)).Append("\n");
			stringBuilder.Append("    .lastcol        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastCol)).Append("\n");
			stringBuilder.Append("    .zero           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_5_zero)).Append("\n");
			stringBuilder.Append("[/DIMENSIONS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0006730D File Offset: 0x0006550D
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.FirstRow);
			out1.WriteInt(this.LastRow);
			out1.WriteShort(this.FirstCol);
			out1.WriteShort(this.LastCol);
			out1.WriteShort(0);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00018987 File Offset: 0x00016B87
		protected override int DataSize
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00067346 File Offset: 0x00065546
		public override short Sid
		{
			get
			{
				return 512;
			}
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00067350 File Offset: 0x00065550
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.DimensionsRecord
			{
				field_1_first_row = this.field_1_first_row,
				field_2_last_row = this.field_2_last_row,
				field_3_first_col = this.field_3_first_col,
				field_4_last_col = this.field_4_last_col,
				field_5_zero = this.field_5_zero
			};
		}

		// Token: 0x04000D52 RID: 3410
		public const short sid = 512;

		// Token: 0x04000D53 RID: 3411
		private int field_1_first_row;

		// Token: 0x04000D54 RID: 3412
		private int field_2_last_row;

		// Token: 0x04000D55 RID: 3413
		private int field_3_first_col;

		// Token: 0x04000D56 RID: 3414
		private int field_4_last_col;

		// Token: 0x04000D57 RID: 3415
		private short field_5_zero;
	}
}
