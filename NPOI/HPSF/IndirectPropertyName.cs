using System;

namespace NPOI.HPSF
{
	// Token: 0x02000501 RID: 1281
	public class IndirectPropertyName
	{
		// Token: 0x06002FE8 RID: 12264 RVA: 0x0009102E File Offset: 0x0008F22E
		public IndirectPropertyName(byte[] data, int offset)
		{
			this._value = new global::NPOI.HPSF.CodePageString(data, offset);
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x00091043 File Offset: 0x0008F243
		public int Size
		{
			get
			{
				return this._value.Size;
			}
		}

		// Token: 0x04001578 RID: 5496
		private global::NPOI.HPSF.CodePageString _value;
	}
}
