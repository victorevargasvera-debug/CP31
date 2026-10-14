using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B2 RID: 946
	public class CalcModeRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060020CA RID: 8394 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CalcModeRecord()
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x0006461E File Offset: 0x0006281E
		public CalcModeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_calcmode = in1.ReadShort();
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00064632 File Offset: 0x00062832
		public void SetCalcMode(short calcmode)
		{
			this.field_1_calcmode = calcmode;
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0006463B File Offset: 0x0006283B
		public short GetCalcMode()
		{
			return this.field_1_calcmode;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00064644 File Offset: 0x00062844
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CALCMODE]\n");
			stringBuilder.Append("    .calcmode       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.GetCalcMode())).Append("\n");
			stringBuilder.Append("[/CALCMODE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00064699 File Offset: 0x00062899
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.GetCalcMode());
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x000184E9 File Offset: 0x000166E9
		public override short Sid
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000646A7 File Offset: 0x000628A7
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.CalcModeRecord
			{
				field_1_calcmode = this.field_1_calcmode
			};
		}

		// Token: 0x04000CC9 RID: 3273
		public const short sid = 13;

		// Token: 0x04000CCA RID: 3274
		public const short MANUAL = 0;

		// Token: 0x04000CCB RID: 3275
		public const short AUTOMATIC = 1;

		// Token: 0x04000CCC RID: 3276
		public const short AUTOMATIC_EXCEPT_TABLES = -1;

		// Token: 0x04000CCD RID: 3277
		private short field_1_calcmode;
	}
}
