using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004F7 RID: 1271
	public class Array
	{
		// Token: 0x06002FC7 RID: 12231 RVA: 0x0000253E File Offset: 0x0000073E
		public Array()
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00090A8F File Offset: 0x0008EC8F
		public Array(byte[] data, int offset)
		{
			this.Read(data, offset);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		public int Read(byte[] data, int startOffset)
		{
			this._header = new global::NPOI.HPSF.Array.ArrayHeader(data, startOffset);
			int num = startOffset + this._header.Size;
			long numberOfScalarValues = this._header.NumberOfScalarValues;
			if (numberOfScalarValues > 2147483647L)
			{
				throw new global::System.InvalidOperationException("Sorry, but POI can't store array of properties with size of " + numberOfScalarValues.ToString() + " in memory");
			}
			int num2 = (int)numberOfScalarValues;
			this._values = new global::NPOI.HPSF.TypedPropertyValue[num2];
			int type = this._header._type;
			if (type == 12)
			{
				for (int i = 0; i < num2; i++)
				{
					global::NPOI.HPSF.TypedPropertyValue typedPropertyValue = new global::NPOI.HPSF.TypedPropertyValue();
					num += typedPropertyValue.Read(data, num);
				}
			}
			else
			{
				for (int j = 0; j < num2; j++)
				{
					global::NPOI.HPSF.TypedPropertyValue typedPropertyValue2 = new global::NPOI.HPSF.TypedPropertyValue(type, null);
					num += typedPropertyValue2.ReadValuePadded(data, num);
				}
			}
			return num - startOffset;
		}

		// Token: 0x04001560 RID: 5472
		private global::NPOI.HPSF.Array.ArrayHeader _header;

		// Token: 0x04001561 RID: 5473
		private global::NPOI.HPSF.TypedPropertyValue[] _values;

		// Token: 0x02000627 RID: 1575
		internal class ArrayDimension
		{
			// Token: 0x060036D8 RID: 14040 RVA: 0x000A787B File Offset: 0x000A5A7B
			public ArrayDimension(byte[] data, int offset)
			{
				this._size = global::NPOI.Util.LittleEndian.GetUInt(data, offset);
				this._indexOffset = global::NPOI.Util.LittleEndian.GetInt(data, offset + 4);
			}

			// Token: 0x04001AB9 RID: 6841
			public const int SIZE = 8;

			// Token: 0x04001ABA RID: 6842
			private int _indexOffset;

			// Token: 0x04001ABB RID: 6843
			internal long _size;
		}

		// Token: 0x02000628 RID: 1576
		internal class ArrayHeader
		{
			// Token: 0x060036D9 RID: 14041 RVA: 0x000A78A0 File Offset: 0x000A5AA0
			public ArrayHeader(byte[] data, int startOffset)
			{
				this._type = global::NPOI.Util.LittleEndian.GetInt(data, startOffset);
				int num = startOffset + 4;
				long @uint = global::NPOI.Util.LittleEndian.GetUInt(data, num);
				num += 4;
				if (1L > @uint || @uint > 31L)
				{
					throw new global::NPOI.HPSF.IllegalPropertySetDataException("Array dimension number " + @uint.ToString() + " is not in [1; 31] range");
				}
				int num2 = (int)@uint;
				this._dimensions = new global::NPOI.HPSF.Array.ArrayDimension[num2];
				for (int i = 0; i < num2; i++)
				{
					this._dimensions[i] = new global::NPOI.HPSF.Array.ArrayDimension(data, num);
					num += 8;
				}
			}

			// Token: 0x17000E30 RID: 3632
			// (get) Token: 0x060036DA RID: 14042 RVA: 0x000A7928 File Offset: 0x000A5B28
			public long NumberOfScalarValues
			{
				get
				{
					long num = 1L;
					foreach (global::NPOI.HPSF.Array.ArrayDimension arrayDimension in this._dimensions)
					{
						num *= arrayDimension._size;
					}
					return num;
				}
			}

			// Token: 0x17000E31 RID: 3633
			// (get) Token: 0x060036DB RID: 14043 RVA: 0x000A795B File Offset: 0x000A5B5B
			public int Size
			{
				get
				{
					return 8 + this._dimensions.Length * 8;
				}
			}

			// Token: 0x17000E32 RID: 3634
			// (get) Token: 0x060036DC RID: 14044 RVA: 0x000A7969 File Offset: 0x000A5B69
			public int Type
			{
				get
				{
					return this._type;
				}
			}

			// Token: 0x04001ABC RID: 6844
			private global::NPOI.HPSF.Array.ArrayDimension[] _dimensions;

			// Token: 0x04001ABD RID: 6845
			internal int _type;
		}
	}
}
