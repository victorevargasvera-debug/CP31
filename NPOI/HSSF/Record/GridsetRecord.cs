using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E3 RID: 995
	public class GridsetRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060023CA RID: 9162 RVA: 0x0005FE49 File Offset: 0x0005E049
		public GridsetRecord()
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
		public GridsetRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_gridset_flag = in1.ReadShort();
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x0006BFFC File Offset: 0x0006A1FC
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x0006C007 File Offset: 0x0006A207
		public bool Gridset
		{
			get
			{
				return this.field_1_gridset_flag == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_gridset_flag = 1;
					return;
				}
				this.field_1_gridset_flag = 0;
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0006C01C File Offset: 0x0006A21C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[GRIDSET]\n");
			stringBuilder.Append("    .gridset        = ").Append(this.Gridset).Append("\n");
			stringBuilder.Append("[/GRIDSET]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0006C06C File Offset: 0x0006A26C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_gridset_flag);
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x0006C07A File Offset: 0x0006A27A
		public override short Sid
		{
			get
			{
				return 130;
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0006C081 File Offset: 0x0006A281
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.GridsetRecord
			{
				field_1_gridset_flag = this.field_1_gridset_flag
			};
		}

		// Token: 0x04000F0D RID: 3853
		public const short sid = 130;

		// Token: 0x04000F0E RID: 3854
		public short field_1_gridset_flag;
	}
}
