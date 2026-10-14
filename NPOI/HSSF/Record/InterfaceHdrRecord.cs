using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003EE RID: 1006
	public class InterfaceHdrRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600244D RID: 9293 RVA: 0x0006D675 File Offset: 0x0006B875
		public InterfaceHdrRecord(int codePage)
		{
			this._codepage = codePage;
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0006D684 File Offset: 0x0006B884
		public InterfaceHdrRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._codepage = (int)in1.ReadShort();
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0006D698 File Offset: 0x0006B898
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[INTERFACEHDR]\n");
			stringBuilder.Append("    .codepage        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this._codepage)).Append("\n");
			stringBuilder.Append("[/INTERFACEHDR]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0006D6ED File Offset: 0x0006B8ED
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._codepage);
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x0006D6FB File Offset: 0x0006B8FB
		public override short Sid
		{
			get
			{
				return 225;
			}
		}

		// Token: 0x04000F43 RID: 3907
		public const short sid = 225;

		// Token: 0x04000F44 RID: 3908
		private int _codepage;

		// Token: 0x04000F45 RID: 3909
		public const short CODEPAGE = 1200;
	}
}
