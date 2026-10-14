using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000419 RID: 1049
	public class SaveRecalcRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002673 RID: 9843 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SaveRecalcRecord()
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00073C4B File Offset: 0x00071E4B
		public SaveRecalcRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_recalc = in1.ReadShort();
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x00073C5F File Offset: 0x00071E5F
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x00073C6A File Offset: 0x00071E6A
		public bool Recalc
		{
			get
			{
				return this.field_1_recalc == 1;
			}
			set
			{
				this.field_1_recalc = (value ? 1 : 0);
			}
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00073C7C File Offset: 0x00071E7C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SAVERECALC]\n");
			stringBuilder.Append("    .recalc         = ").Append(this.Recalc).Append("\n");
			stringBuilder.Append("[/SAVERECALC]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00073CCC File Offset: 0x00071ECC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_recalc);
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x00073CDA File Offset: 0x00071EDA
		public override short Sid
		{
			get
			{
				return 95;
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00073CDE File Offset: 0x00071EDE
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.SaveRecalcRecord
			{
				field_1_recalc = this.field_1_recalc
			};
		}

		// Token: 0x0400101C RID: 4124
		public const short sid = 95;

		// Token: 0x0400101D RID: 4125
		private short field_1_recalc;
	}
}
