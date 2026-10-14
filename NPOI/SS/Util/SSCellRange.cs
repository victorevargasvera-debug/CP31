using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x0200002E RID: 46
	public class SSCellRange<K> : global::NPOI.SS.UserModel.ICellRange<K>, global::System.Collections.Generic.IEnumerable<K>, global::System.Collections.IEnumerable where K : global::NPOI.SS.UserModel.ICell
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00008A31 File Offset: 0x00006C31
		private SSCellRange(int firstRow, int firstColumn, int height, int width, K[] flattenedArray)
		{
			this._firstRow = firstRow;
			this._firstColumn = firstColumn;
			this._height = height;
			this._width = width;
			this._flattenedArray = (K[])flattenedArray.Clone();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008A68 File Offset: 0x00006C68
		public static global::NPOI.SS.Util.SSCellRange<K> Create(int firstRow, int firstColumn, int height, int width, global::System.Collections.Generic.List<K> flattenedList, global::System.Type cellClass)
		{
			int count = flattenedList.Count;
			if (height * width != count)
			{
				throw new global::System.ArgumentException("Array size mismatch.");
			}
			K[] flattenedArray = (K[])global::System.Array.CreateInstance(cellClass, count);
			flattenedArray = flattenedList.ToArray();
			return new global::NPOI.SS.Util.SSCellRange<K>(firstRow, firstColumn, height, width, flattenedArray);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008AB0 File Offset: 0x00006CB0
		public K GetCell(int relativeRowIndex, int relativeColumnIndex)
		{
			if (relativeRowIndex < 0 || relativeRowIndex >= this._height)
			{
				throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
				{
					"Specified row ",
					relativeRowIndex.ToString(),
					" is outside the allowable range (0..",
					(this._height - 1).ToString(),
					")."
				}));
			}
			if (relativeColumnIndex < 0 || relativeColumnIndex >= this._width)
			{
				throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
				{
					"Specified colummn ",
					relativeColumnIndex.ToString(),
					" is outside the allowable range (0..",
					(this._width - 1).ToString(),
					")."
				}));
			}
			int num = this._width * relativeRowIndex + relativeColumnIndex;
			return this._flattenedArray[num];
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00008B7A File Offset: 0x00006D7A
		public K TopLeftCell
		{
			get
			{
				return this._flattenedArray[0];
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00008B88 File Offset: 0x00006D88
		public K[] FlattenedCells
		{
			get
			{
				return (K[])this._flattenedArray.Clone();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00008B9C File Offset: 0x00006D9C
		public K[][] Cells
		{
			get
			{
				global::System.Type type = this._flattenedArray.GetType();
				K[][] result = (K[][])global::System.Array.CreateInstance(type, this._height);
				type = type.GetElementType();
				for (int i = this._height - 1; i >= 0; i--)
				{
					K[] destinationArray = (K[])global::System.Array.CreateInstance(type, this._width);
					int sourceIndex = this._width * i;
					global::System.Array.Copy(this._flattenedArray, sourceIndex, destinationArray, 0, this._width);
				}
				return result;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00008C13 File Offset: 0x00006E13
		public int Height
		{
			get
			{
				return this._height;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00008C1B File Offset: 0x00006E1B
		public int Width
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00008C23 File Offset: 0x00006E23
		public int Size
		{
			get
			{
				return this._height * this._width;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00008C32 File Offset: 0x00006E32
		public string ReferenceText
		{
			get
			{
				return new global::NPOI.SS.Util.CellRangeAddress(this._firstRow, this._firstRow + this._height - 1, this._firstColumn, this._firstColumn + this._width - 1).FormatAsString();
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008C68 File Offset: 0x00006E68
		public global::System.Collections.Generic.IEnumerator<K> GetEnumerator()
		{
			return new global::NPOI.SS.Util.SSCellRange<K>.ArrayIterator<K>(this._flattenedArray);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008C75 File Offset: 0x00006E75
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040000A7 RID: 167
		private int _height;

		// Token: 0x040000A8 RID: 168
		private int _width;

		// Token: 0x040000A9 RID: 169
		private K[] _flattenedArray;

		// Token: 0x040000AA RID: 170
		private int _firstRow;

		// Token: 0x040000AB RID: 171
		private int _firstColumn;

		// Token: 0x02000558 RID: 1368
		internal class ArrayIterator<D> : global::System.Collections.Generic.IEnumerator<D>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06003380 RID: 13184 RVA: 0x000A119C File Offset: 0x0009F39C
			public ArrayIterator(D[] array)
			{
				this._array = (D[])array.Clone();
				this._index = 0;
			}

			// Token: 0x06003381 RID: 13185 RVA: 0x000A11BC File Offset: 0x0009F3BC
			public bool MoveNext()
			{
				return this._index < this._array.Length;
			}

			// Token: 0x06003382 RID: 13186 RVA: 0x000A11CE File Offset: 0x0009F3CE
			public void Remove()
			{
				throw new global::System.NotSupportedException("Cannot remove cells from this CellRange.");
			}

			// Token: 0x06003383 RID: 13187 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Reset()
			{
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06003384 RID: 13188 RVA: 0x000A11DC File Offset: 0x0009F3DC
			public D Current
			{
				get
				{
					if (this._index >= this._array.Length)
					{
						throw new global::System.ArgumentNullException(this._index.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
					}
					D[] array = this._array;
					int index = this._index;
					this._index = index + 1;
					return array[index];
				}
			}

			// Token: 0x06003385 RID: 13189 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Dispose()
			{
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06003386 RID: 13190 RVA: 0x000A122B File Offset: 0x0009F42B
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x04001872 RID: 6258
			private D[] _array;

			// Token: 0x04001873 RID: 6259
			private int _index;
		}
	}
}
