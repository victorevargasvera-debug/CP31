using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000438 RID: 1080
	public class UserSViewBegin : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060027E3 RID: 10211 RVA: 0x0007875C File Offset: 0x0007695C
		public UserSViewBegin(byte[] data)
		{
			this._rawData = data;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0007876B File Offset: 0x0007696B
		public UserSViewBegin(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._rawData = in1.ReadRemainder();
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0007877F File Offset: 0x0007697F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._rawData);
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x0007878D File Offset: 0x0007698D
		protected override int DataSize
		{
			get
			{
				return this._rawData.Length;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x00078797 File Offset: 0x00076997
		public override short Sid
		{
			get
			{
				return 426;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000787A0 File Offset: 0x000769A0
		public byte[] Guid
		{
			get
			{
				byte[] array = new byte[16];
				global::System.Array.Copy(this._rawData, 0, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000787C8 File Offset: 0x000769C8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[").Append("USERSVIEWBEGIN").Append("] (0x");
			stringBuilder.Append(global::NPOI.Util.StringUtil.ToHexString(426).ToUpper() + ")\n");
			stringBuilder.Append("  rawData=").Append(global::NPOI.Util.HexDump.ToHex(this._rawData)).Append("\n");
			stringBuilder.Append("[/").Append("USERSVIEWBEGIN").Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x040010F5 RID: 4341
		public const short sid = 426;

		// Token: 0x040010F6 RID: 4342
		private byte[] _rawData;
	}
}
