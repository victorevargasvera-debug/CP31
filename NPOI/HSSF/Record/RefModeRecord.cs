using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000414 RID: 1044
	public class RefModeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600261E RID: 9758 RVA: 0x0005FE49 File Offset: 0x0005E049
		public RefModeRecord()
		{
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000731DD File Offset: 0x000713DD
		public RefModeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_mode = in1.ReadShort();
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000731F1 File Offset: 0x000713F1
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x000731F9 File Offset: 0x000713F9
		public short Mode
		{
			get
			{
				return this.field_1_mode;
			}
			set
			{
				this.field_1_mode = value;
			}
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x00073204 File Offset: 0x00071404
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[REFMODE]\n");
			stringBuilder.Append("    .mode           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Mode)).Append("\n");
			stringBuilder.Append("[/REFMODE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x00073259 File Offset: 0x00071459
		public override short Sid
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x0007325D File Offset: 0x0007145D
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.RefModeRecord
			{
				field_1_mode = this.field_1_mode
			};
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00073270 File Offset: 0x00071470
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Mode);
		}

		// Token: 0x04000FF8 RID: 4088
		public const short sid = 15;

		// Token: 0x04000FF9 RID: 4089
		public const short USE_A1_MODE = 1;

		// Token: 0x04000FFA RID: 4090
		public const short USE_R1C1_MODE = 0;

		// Token: 0x04000FFB RID: 4091
		private short field_1_mode;
	}
}
