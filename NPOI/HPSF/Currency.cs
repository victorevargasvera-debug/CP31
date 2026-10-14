using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FB RID: 1275
	internal class Currency
	{
		// Token: 0x06002FD7 RID: 12247 RVA: 0x00090DDF File Offset: 0x0008EFDF
		public Currency(byte[] data, int offset)
		{
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset, 8);
		}

		// Token: 0x04001566 RID: 5478
		public const int SIZE = 8;

		// Token: 0x04001567 RID: 5479
		private byte[] _value;
	}
}
