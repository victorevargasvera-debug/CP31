using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000403 RID: 1027
	public class PasswordRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002553 RID: 9555 RVA: 0x000706BB File Offset: 0x0006E8BB
		public PasswordRecord(int password)
		{
			this.field_1_password = password;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000706CA File Offset: 0x0006E8CA
		public PasswordRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_password = (int)in1.ReadShort();
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000706DE File Offset: 0x0006E8DE
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000706E6 File Offset: 0x0006E8E6
		public int Password
		{
			get
			{
				return this.field_1_password;
			}
			set
			{
				this.field_1_password = value;
			}
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000706F0 File Offset: 0x0006E8F0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PASSWORD]\n");
			stringBuilder.Append("    .password       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Password)).Append("\n");
			stringBuilder.Append("[/PASSWORD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00070745 File Offset: 0x0006E945
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_password);
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000199B2 File Offset: 0x00017BB2
		public override short Sid
		{
			get
			{
				return 19;
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00070753 File Offset: 0x0006E953
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PasswordRecord(this.field_1_password);
		}

		// Token: 0x04000FB5 RID: 4021
		public const short sid = 19;

		// Token: 0x04000FB6 RID: 4022
		private int field_1_password;
	}
}
