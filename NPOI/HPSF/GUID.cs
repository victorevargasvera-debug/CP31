using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FF RID: 1279
	public class GUID
	{
		// Token: 0x06002FE0 RID: 12256 RVA: 0x00090EF8 File Offset: 0x0008F0F8
		public GUID(byte[] data, int offset)
		{
			this._data1 = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			this._data2 = global::NPOI.Util.LittleEndian.GetShort(data, offset + 4);
			this._data3 = global::NPOI.Util.LittleEndian.GetShort(data, offset + 6);
			this._data4 = global::NPOI.Util.LittleEndian.GetLong(data, offset + 8);
		}

		// Token: 0x04001573 RID: 5491
		public const int SIZE = 16;

		// Token: 0x04001574 RID: 5492
		private int _data1;

		// Token: 0x04001575 RID: 5493
		private short _data2;

		// Token: 0x04001576 RID: 5494
		private short _data3;

		// Token: 0x04001577 RID: 5495
		private long _data4;
	}
}
