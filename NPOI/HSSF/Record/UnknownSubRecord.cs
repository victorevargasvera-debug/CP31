using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042F RID: 1071
	public class UnknownSubRecord : global::NPOI.HSSF.Record.SubRecord
	{
		// Token: 0x0600276D RID: 10093 RVA: 0x000769A8 File Offset: 0x00074BA8
		public UnknownSubRecord(global::NPOI.Util.ILittleEndianInput in1, int sid, int size)
		{
			this._sid = sid;
			byte[] array = new byte[size];
			in1.ReadFully(array);
			this._data = array;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000769D7 File Offset: 0x00074BD7
		public override int DataSize
		{
			get
			{
				return this._data.Length;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000769E1 File Offset: 0x00074BE1
		public override short Sid
		{
			get
			{
				return (short)this._sid;
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000769EA File Offset: 0x00074BEA
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._sid);
			out1.WriteShort(this._data.Length);
			out1.Write(this._data);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00076A14 File Offset: 0x00074C14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append("sid=").Append(global::NPOI.Util.HexDump.ShortToHex(this._sid));
			stringBuilder.Append(" size=").Append(this._data.Length);
			stringBuilder.Append(" : ").Append(global::NPOI.Util.HexDump.ToHex(this._data));
			stringBuilder.Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040010A9 RID: 4265
		private int _sid;

		// Token: 0x040010AA RID: 4266
		private byte[] _data;
	}
}
