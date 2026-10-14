using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004F8 RID: 1272
	internal class Blob
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x00090B68 File Offset: 0x0008ED68
		public Blob(byte[] data, int offset)
		{
			int @int = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			if (@int == 0)
			{
				this._value = new byte[0];
				return;
			}
			this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset + 4, @int);
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x00090BA3 File Offset: 0x0008EDA3
		public int Size
		{
			get
			{
				return 4 + this._value.Length;
			}
		}

		// Token: 0x04001562 RID: 5474
		private byte[] _value;
	}
}
