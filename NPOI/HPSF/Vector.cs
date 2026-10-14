using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000506 RID: 1286
	public class Vector
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x0009172E File Offset: 0x0008F92E
		public Vector(byte[] data, int startOffset, short type)
		{
			this._type = type;
			this.Read(data, startOffset);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x00091746 File Offset: 0x0008F946
		public Vector(short type)
		{
			this._type = type;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00091758 File Offset: 0x0008F958
		public int Read(byte[] data, int startOffset)
		{
			long @uint = global::NPOI.Util.LittleEndian.GetUInt(data, startOffset);
			int num = startOffset + 4;
			if (@uint > 2147483647L)
			{
				throw new global::System.InvalidOperationException("Vector is too long -- " + @uint.ToString());
			}
			int num2 = (int)@uint;
			this._values = new global::NPOI.HPSF.TypedPropertyValue[num2];
			if (this._type == 12)
			{
				for (int i = 0; i < num2; i++)
				{
					global::NPOI.HPSF.TypedPropertyValue typedPropertyValue = new global::NPOI.HPSF.TypedPropertyValue();
					num += typedPropertyValue.Read(data, num);
					this._values[i] = typedPropertyValue;
				}
			}
			else
			{
				for (int j = 0; j < num2; j++)
				{
					global::NPOI.HPSF.TypedPropertyValue typedPropertyValue2 = new global::NPOI.HPSF.TypedPropertyValue((int)this._type, null);
					num += typedPropertyValue2.ReadValue(data, num);
					this._values[j] = typedPropertyValue2;
				}
			}
			return num - startOffset;
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x0009180F File Offset: 0x0008FA0F
		public global::NPOI.HPSF.TypedPropertyValue[] Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x0400157F RID: 5503
		private short _type;

		// Token: 0x04001580 RID: 5504
		private global::NPOI.HPSF.TypedPropertyValue[] _values;
	}
}
