using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000439 RID: 1081
	public class UserSViewEnd : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027EB RID: 10219 RVA: 0x00078865 File Offset: 0x00076A65
		public UserSViewEnd(byte[] data)
		{
			this._rawData = data;
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00078874 File Offset: 0x00076A74
		public UserSViewEnd(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._rawData = in1.ReadRemainder();
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00078888 File Offset: 0x00076A88
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._rawData);
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x00078896 File Offset: 0x00076A96
		protected override int DataSize
		{
			get
			{
				return this._rawData.Length;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x000788A0 File Offset: 0x00076AA0
		public override short Sid
		{
			get
			{
				return 427;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000788A8 File Offset: 0x00076AA8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[").Append("USERSVIEWEND").Append("] (0x");
			stringBuilder.Append(global::NPOI.Util.StringUtil.ToHexString(427).ToUpper() + ")\n");
			stringBuilder.Append("  rawData=").Append(global::NPOI.Util.HexDump.ToHex(this._rawData)).Append("\n");
			stringBuilder.Append("[/").Append("USERSVIEWEND").Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x040010F7 RID: 4343
		public const short sid = 427;

		// Token: 0x040010F8 RID: 4344
		private byte[] _rawData;
	}
}
