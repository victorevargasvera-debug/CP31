using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E9 RID: 1001
	public class HideObjRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002401 RID: 9217 RVA: 0x0005FE49 File Offset: 0x0005E049
		public HideObjRecord()
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0006C5DD File Offset: 0x0006A7DD
		public HideObjRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_hide_obj = in1.ReadShort();
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0006C5F1 File Offset: 0x0006A7F1
		public void SetHideObj(short hide)
		{
			this.field_1_hide_obj = hide;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0006C5FA File Offset: 0x0006A7FA
		public short GetHideObj()
		{
			return this.field_1_hide_obj;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0006C604 File Offset: 0x0006A804
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[HIDEOBJ]\n");
			stringBuilder.Append("    .hideobj         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.GetHideObj())).Append("\n");
			stringBuilder.Append("[/HIDEOBJ]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0006C659 File Offset: 0x0006A859
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.GetHideObj());
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x0006C667 File Offset: 0x0006A867
		public override short Sid
		{
			get
			{
				return 141;
			}
		}

		// Token: 0x04000F1C RID: 3868
		public const short sid = 141;

		// Token: 0x04000F1D RID: 3869
		public const short HIDE_ALL = 2;

		// Token: 0x04000F1E RID: 3870
		public const short SHOW_PLACEHOLDERS = 1;

		// Token: 0x04000F1F RID: 3871
		public const short SHOW_ALL = 0;

		// Token: 0x04000F20 RID: 3872
		private short field_1_hide_obj;
	}
}
