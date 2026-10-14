using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CD RID: 973
	public class DVALRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600222E RID: 8750 RVA: 0x00067777 File Offset: 0x00065977
		public DVALRecord()
		{
			this.field_cbo_id = -1;
			this.field_5_dv_no = 0;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00067790 File Offset: 0x00065990
		public DVALRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_options = in1.ReadShort();
			this.field_2_horiz_pos = in1.ReadInt();
			this.field_3_vert_pos = in1.ReadInt();
			this.field_cbo_id = in1.ReadInt();
			this.field_5_dv_no = in1.ReadInt();
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000677DF File Offset: 0x000659DF
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x000677E7 File Offset: 0x000659E7
		public short Options
		{
			get
			{
				return this.field_1_options;
			}
			set
			{
				this.field_1_options = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x000677F0 File Offset: 0x000659F0
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x000677F8 File Offset: 0x000659F8
		public int HorizontalPos
		{
			get
			{
				return this.field_2_horiz_pos;
			}
			set
			{
				this.field_2_horiz_pos = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00067801 File Offset: 0x00065A01
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00067809 File Offset: 0x00065A09
		public int VerticalPos
		{
			get
			{
				return this.field_3_vert_pos;
			}
			set
			{
				this.field_3_vert_pos = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00067812 File Offset: 0x00065A12
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0006781A File Offset: 0x00065A1A
		public int ObjectID
		{
			get
			{
				return this.field_cbo_id;
			}
			set
			{
				this.field_cbo_id = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00067823 File Offset: 0x00065A23
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0006782B File Offset: 0x00065A2B
		public int DVRecNo
		{
			get
			{
				return this.field_5_dv_no;
			}
			set
			{
				this.field_5_dv_no = value;
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00067834 File Offset: 0x00065A34
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DVAL]\n");
			stringBuilder.Append("    .options      = ").Append(this.Options).Append('\n');
			stringBuilder.Append("    .horizPos     = ").Append(this.HorizontalPos).Append('\n');
			stringBuilder.Append("    .vertPos      = ").Append(this.VerticalPos).Append('\n');
			stringBuilder.Append("    .comboObjectID   = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ObjectID)).Append("\n");
			stringBuilder.Append("    .DVRecordsNumber = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.DVRecNo)).Append("\n");
			stringBuilder.Append("[/DVAL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00067909 File Offset: 0x00065B09
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Options);
			out1.WriteInt(this.HorizontalPos);
			out1.WriteInt(this.VerticalPos);
			out1.WriteInt(this.ObjectID);
			out1.WriteInt(this.DVRecNo);
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x00067947 File Offset: 0x00065B47
		public override short Sid
		{
			get
			{
				return 434;
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00067950 File Offset: 0x00065B50
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.DVALRecord
			{
				field_1_options = this.field_1_options,
				field_2_horiz_pos = this.field_2_horiz_pos,
				field_3_vert_pos = this.field_3_vert_pos,
				field_cbo_id = this.field_cbo_id,
				field_5_dv_no = this.field_5_dv_no
			};
		}

		// Token: 0x04000D64 RID: 3428
		public const short sid = 434;

		// Token: 0x04000D65 RID: 3429
		private short field_1_options;

		// Token: 0x04000D66 RID: 3430
		private int field_2_horiz_pos;

		// Token: 0x04000D67 RID: 3431
		private int field_3_vert_pos;

		// Token: 0x04000D68 RID: 3432
		private int field_cbo_id;

		// Token: 0x04000D69 RID: 3433
		private int field_5_dv_no;
	}
}
