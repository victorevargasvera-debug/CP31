using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000505 RID: 1285
	public class VariantBool
	{
		// Token: 0x06002FF9 RID: 12281 RVA: 0x000916E4 File Offset: 0x0008F8E4
		public VariantBool(byte[] data, int offset)
		{
			short @short = global::NPOI.Util.LittleEndian.GetShort(data, offset);
			if (@short == -1)
			{
				this._value = true;
				return;
			}
			if (@short == 0)
			{
				this._value = false;
				return;
			}
			this._value = true;
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x0009171D File Offset: 0x0008F91D
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x00091725 File Offset: 0x0008F925
		public bool Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x0400157D RID: 5501
		public const int SIZE = 2;

		// Token: 0x0400157E RID: 5502
		private bool _value;
	}
}
