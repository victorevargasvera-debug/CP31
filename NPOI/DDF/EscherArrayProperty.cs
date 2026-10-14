using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000530 RID: 1328
	public class EscherArrayProperty : global::NPOI.DDF.EscherComplexProperty, global::System.Collections.Generic.IEnumerable<byte[]>, global::System.Collections.IEnumerable
	{
		// Token: 0x060031D0 RID: 12752 RVA: 0x00096CCF File Offset: 0x00094ECF
		public EscherArrayProperty(short id, byte[] complexData) : base(id, global::NPOI.DDF.EscherArrayProperty.CheckComplexData(complexData))
		{
			this.emptyComplexPart = (complexData.Length == 0);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00096CF0 File Offset: 0x00094EF0
		public EscherArrayProperty(short propertyNumber, bool isBlipId, byte[] complexData) : base(propertyNumber, isBlipId, global::NPOI.DDF.EscherArrayProperty.CheckComplexData(complexData))
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00096D07 File Offset: 0x00094F07
		private static byte[] CheckComplexData(byte[] complexData)
		{
			if (complexData == null || complexData.Length == 0)
			{
				complexData = new byte[6];
			}
			return complexData;
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x00096D19 File Offset: 0x00094F19
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x00096D34 File Offset: 0x00094F34
		public int NumberOfElementsInArray
		{
			get
			{
				if (this.emptyComplexPart)
				{
					return 0;
				}
				return global::NPOI.Util.LittleEndian.GetUShort(this._complexData, 0);
			}
			set
			{
				int num = value * global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(this.SizeOfElements) + 6;
				if (num != this._complexData.Length)
				{
					byte[] array = new byte[num];
					global::System.Array.Copy(this._complexData, 0, array, 0, this._complexData.Length);
					this._complexData = array;
				}
				global::NPOI.Util.LittleEndian.PutShort(this._complexData, 0, (short)value);
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x00096D8E File Offset: 0x00094F8E
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x00096D9C File Offset: 0x00094F9C
		public int NumberOfElementsInMemory
		{
			get
			{
				return global::NPOI.Util.LittleEndian.GetUShort(this._complexData, 2);
			}
			set
			{
				int num = value * global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(this.SizeOfElements) + 6;
				if (num != this._complexData.Length)
				{
					byte[] array = new byte[num];
					global::System.Array.Copy(this._complexData, 0, array, 0, num);
					this._complexData = array;
				}
				global::NPOI.Util.LittleEndian.PutShort(this._complexData, 2, (short)value);
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x00096DEF File Offset: 0x00094FEF
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x00096E00 File Offset: 0x00095000
		public short SizeOfElements
		{
			get
			{
				return global::NPOI.Util.LittleEndian.GetShort(this._complexData, 4);
			}
			set
			{
				global::NPOI.Util.LittleEndian.PutShort(this._complexData, 4, value);
				int num = this.NumberOfElementsInArray * global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(this.SizeOfElements) + 6;
				if (num != this._complexData.Length)
				{
					byte[] array = new byte[num];
					global::System.Array.Copy(this._complexData, 0, array, 0, 6);
					this._complexData = array;
				}
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00096E58 File Offset: 0x00095058
		public byte[] GetElement(int index)
		{
			int actualSizeOfElements = global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(this.SizeOfElements);
			byte[] array = new byte[actualSizeOfElements];
			global::System.Array.Copy(this._complexData, 6 + index * actualSizeOfElements, array, 0, array.Length);
			return array;
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00096E90 File Offset: 0x00095090
		public void SetElement(int index, byte[] element)
		{
			int actualSizeOfElements = global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(this.SizeOfElements);
			global::System.Array.Copy(element, 0, this._complexData, 6 + index * actualSizeOfElements, actualSizeOfElements);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00096EBC File Offset: 0x000950BC
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    {EscherArrayProperty:" + newLine);
			stringBuilder.Append("     Num Elements: " + this.NumberOfElementsInArray.ToString() + newLine);
			stringBuilder.Append("     Num Elements In Memory: " + this.NumberOfElementsInMemory.ToString() + newLine);
			stringBuilder.Append("     Size of elements: " + this.SizeOfElements.ToString() + newLine);
			for (int i = 0; i < this.NumberOfElementsInArray; i++)
			{
				stringBuilder.Append(string.Concat(new string[]
				{
					"     Element ",
					i.ToString(),
					": ",
					global::NPOI.Util.HexDump.ToHex(this.GetElement(i)),
					newLine
				}));
			}
			stringBuilder.Append("}" + newLine);
			return string.Concat(new string[]
			{
				"propNum: ",
				this.PropertyNumber.ToString(),
				", propName: ",
				global::NPOI.DDF.EscherProperties.GetPropertyName(this.PropertyNumber),
				", complex: ",
				this.IsComplex.ToString(),
				", blipId: ",
				this.IsBlipId.ToString(),
				", data: ",
				newLine,
				stringBuilder.ToString()
			});
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00097034 File Offset: 0x00095234
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append("\" name=\"").Append(this.Name).Append("\" blipId=\"").Append(this.IsBlipId.ToString().ToLower()).Append("\">\n");
			for (int i = 0; i < this.NumberOfElementsInArray; i++)
			{
				stringBuilder.Append("\t").Append(tab).Append("<Element>").Append(global::NPOI.Util.HexDump.ToHex(this.GetElement(i))).Append("</Element>\n");
			}
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00097140 File Offset: 0x00095340
		public int SetArrayData(byte[] data, int offset)
		{
			if (this.emptyComplexPart)
			{
				this._complexData = new byte[0];
			}
			else
			{
				short @short = global::NPOI.Util.LittleEndian.GetShort(data, offset);
				int num = global::NPOI.DDF.EscherArrayProperty.GetActualSizeOfElements(global::NPOI.Util.LittleEndian.GetShort(data, offset + 4)) * (int)@short;
				if (num == this._complexData.Length)
				{
					this._complexData = new byte[num + 6];
					this.sizeIncludesHeaderSize = false;
				}
				global::System.Array.Copy(data, offset, this._complexData, 0, this._complexData.Length);
			}
			return this._complexData.Length;
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000971BC File Offset: 0x000953BC
		public override int SerializeSimplePart(byte[] data, int pos)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, pos, this.Id);
			int num = this._complexData.Length;
			if (!this.sizeIncludesHeaderSize)
			{
				num -= 6;
			}
			global::NPOI.Util.LittleEndian.PutInt(data, pos + 2, num);
			return 6;
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000971F6 File Offset: 0x000953F6
		public static int GetActualSizeOfElements(short sizeOfElements)
		{
			if (sizeOfElements < 0)
			{
				return (int)((short)(-sizeOfElements >> 2));
			}
			return (int)sizeOfElements;
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00097203 File Offset: 0x00095403
		public global::System.Collections.Generic.IEnumerator<byte[]> GetEnumerator()
		{
			return new global::NPOI.DDF.EscherArrayProperty.EscherArrayEnumerator(this);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0009720B File Offset: 0x0009540B
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400163E RID: 5694
		private const int FIXED_SIZE = 6;

		// Token: 0x0400163F RID: 5695
		private bool sizeIncludesHeaderSize = true;

		// Token: 0x04001640 RID: 5696
		private bool emptyComplexPart;

		// Token: 0x0200062D RID: 1581
		private class EscherArrayEnumerator : global::System.Collections.Generic.IEnumerator<byte[]>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060036E8 RID: 14056 RVA: 0x000A7B50 File Offset: 0x000A5D50
			public EscherArrayEnumerator(global::NPOI.DDF.EscherArrayProperty eap)
			{
				this.dataHolder = eap;
			}

			// Token: 0x17000E33 RID: 3635
			// (get) Token: 0x060036E9 RID: 14057 RVA: 0x000A7B66 File Offset: 0x000A5D66
			public byte[] Current
			{
				get
				{
					if (this.idx < 0 || this.idx > this.dataHolder.NumberOfElementsInArray)
					{
						throw new global::System.IndexOutOfRangeException();
					}
					return this.dataHolder.GetElement(this.idx);
				}
			}

			// Token: 0x060036EA RID: 14058 RVA: 0x00008C75 File Offset: 0x00006E75
			public void Dispose()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x17000E34 RID: 3636
			// (get) Token: 0x060036EB RID: 14059 RVA: 0x000A7B9B File Offset: 0x000A5D9B
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060036EC RID: 14060 RVA: 0x000A7BA3 File Offset: 0x000A5DA3
			public bool MoveNext()
			{
				this.idx++;
				return this.idx < this.dataHolder.NumberOfElementsInArray;
			}

			// Token: 0x060036ED RID: 14061 RVA: 0x00008C75 File Offset: 0x00006E75
			public void Reset()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04001AC1 RID: 6849
			private global::NPOI.DDF.EscherArrayProperty dataHolder;

			// Token: 0x04001AC2 RID: 6850
			private int idx = -1;
		}
	}
}
