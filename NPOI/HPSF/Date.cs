using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FC RID: 1276
	internal class Date
	{
		// Token: 0x06002FD8 RID: 12248 RVA: 0x00090DF5 File Offset: 0x0008EFF5
		public Date(byte[] data, int offset)
		{
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset, 8);
		}

		// Token: 0x04001568 RID: 5480
		public const int SIZE = 8;

		// Token: 0x04001569 RID: 5481
		private byte[] _value;
	}
}
