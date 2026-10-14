using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000404 RID: 1028
	public class PasswordRev4Record : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600255C RID: 9564 RVA: 0x00070760 File Offset: 0x0006E960
		public PasswordRev4Record(int pw)
		{
			this.field_1_password = pw;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0007076F File Offset: 0x0006E96F
		public PasswordRev4Record(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_password = (int)in1.ReadShort();
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00070783 File Offset: 0x0006E983
		public void SetPassword(short pw)
		{
			this.field_1_password = (int)pw;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0007078C File Offset: 0x0006E98C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PROT4REVPASSWORD]\n");
			stringBuilder.Append("    .password       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field_1_password)).Append("\n");
			stringBuilder.Append("[/PROT4REVPASSWORD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000707E1 File Offset: 0x0006E9E1
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_1_password);
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000707EF File Offset: 0x0006E9EF
		public override short Sid
		{
			get
			{
				return 444;
			}
		}

		// Token: 0x04000FB7 RID: 4023
		public const short sid = 444;

		// Token: 0x04000FB8 RID: 4024
		private int field_1_password;
	}
}
