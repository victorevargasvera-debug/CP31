using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FE RID: 1278
	public class Filetime
	{
		// Token: 0x06002FDA RID: 12250 RVA: 0x00090E6E File Offset: 0x0008F06E
		public Filetime(byte[] data, int offset)
		{
			this._dwLowDateTime = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			this._dwHighDateTime = global::NPOI.Util.LittleEndian.GetInt(data, offset + 4);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00090E92 File Offset: 0x0008F092
		public Filetime(int low, int high)
		{
			this._dwLowDateTime = low;
			this._dwHighDateTime = high;
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x00090EA8 File Offset: 0x0008F0A8
		public long High
		{
			get
			{
				return (long)this._dwHighDateTime;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00090EB1 File Offset: 0x0008F0B1
		public long Low
		{
			get
			{
				return (long)this._dwLowDateTime;
			}
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00090EBA File Offset: 0x0008F0BA
		public byte[] ToByteArray()
		{
			byte[] array = new byte[8];
			global::NPOI.Util.LittleEndian.PutInt(array, 0, this._dwLowDateTime);
			global::NPOI.Util.LittleEndian.PutInt(array, 4, this._dwHighDateTime);
			return array;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00090EDC File Offset: 0x0008F0DC
		public int Write(global::System.IO.Stream out1)
		{
			global::NPOI.Util.LittleEndian.PutInt(this._dwLowDateTime, out1);
			global::NPOI.Util.LittleEndian.PutInt(this._dwHighDateTime, out1);
			return 8;
		}

		// Token: 0x04001570 RID: 5488
		public const int SIZE = 8;

		// Token: 0x04001571 RID: 5489
		private int _dwHighDateTime;

		// Token: 0x04001572 RID: 5490
		private int _dwLowDateTime;
	}
}
