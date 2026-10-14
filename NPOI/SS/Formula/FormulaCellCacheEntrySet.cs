using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C6 RID: 198
	internal class FormulaCellCacheEntrySet
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x0000F4FE File Offset: 0x0000D6FE
		public FormulaCellCacheEntrySet()
		{
			this._arr = global::NPOI.SS.Formula.FormulaCellCacheEntry.EMPTY_ARRAY;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000F514 File Offset: 0x0000D714
		public global::NPOI.SS.Formula.FormulaCellCacheEntry[] ToArray()
		{
			int size = this._size;
			if (size < 1)
			{
				return global::NPOI.SS.Formula.FormulaCellCacheEntry.EMPTY_ARRAY;
			}
			global::NPOI.SS.Formula.FormulaCellCacheEntry[] array = new global::NPOI.SS.Formula.FormulaCellCacheEntry[size];
			int num = 0;
			for (int i = 0; i < this._arr.Length; i++)
			{
				global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._arr[i];
				if (formulaCellCacheEntry != null)
				{
					array[num++] = formulaCellCacheEntry;
				}
			}
			if (num != size)
			{
				throw new global::System.InvalidOperationException("size mismatch");
			}
			return array;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0000F578 File Offset: 0x0000D778
		public void Add(global::NPOI.SS.Formula.CellCacheEntry cce)
		{
			global::NPOI.SS.Formula.CellCacheEntry[] arr2;
			if (this._size * 3 >= this._arr.Length * 2)
			{
				global::NPOI.SS.Formula.FormulaCellCacheEntry[] arr = this._arr;
				global::NPOI.SS.Formula.FormulaCellCacheEntry[] array = new global::NPOI.SS.Formula.FormulaCellCacheEntry[4 + this._arr.Length * 3 / 2];
				for (int i = 0; i < arr.Length; i++)
				{
					global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._arr[i];
					if (formulaCellCacheEntry != null)
					{
						arr2 = array;
						global::NPOI.SS.Formula.FormulaCellCacheEntrySet.AddInternal(arr2, formulaCellCacheEntry);
					}
				}
				this._arr = array;
			}
			arr2 = this._arr;
			if (global::NPOI.SS.Formula.FormulaCellCacheEntrySet.AddInternal(arr2, cce))
			{
				this._size++;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000F604 File Offset: 0x0000D804
		private static bool AddInternal(global::NPOI.SS.Formula.CellCacheEntry[] arr, global::NPOI.SS.Formula.CellCacheEntry cce)
		{
			int num = cce.GetHashCode() % arr.Length;
			for (int i = num; i < arr.Length; i++)
			{
				global::NPOI.SS.Formula.CellCacheEntry cellCacheEntry = arr[i];
				if (cellCacheEntry == cce)
				{
					return false;
				}
				if (cellCacheEntry == null)
				{
					arr[i] = cce;
					return true;
				}
			}
			for (int j = 0; j < num; j++)
			{
				global::NPOI.SS.Formula.CellCacheEntry cellCacheEntry2 = arr[j];
				if (cellCacheEntry2 == cce)
				{
					return false;
				}
				if (cellCacheEntry2 == null)
				{
					arr[j] = cce;
					return true;
				}
			}
			throw new global::System.InvalidOperationException("No empty space found");
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000F66C File Offset: 0x0000D86C
		public bool Remove(global::NPOI.SS.Formula.CellCacheEntry cce)
		{
			global::NPOI.SS.Formula.FormulaCellCacheEntry[] arr = this._arr;
			if (this._size * 3 < this._arr.Length && this._arr.Length > 8)
			{
				bool result = false;
				global::NPOI.SS.Formula.FormulaCellCacheEntry[] arr2 = this._arr;
				global::NPOI.SS.Formula.FormulaCellCacheEntry[] array = new global::NPOI.SS.Formula.FormulaCellCacheEntry[this._arr.Length / 2];
				for (int i = 0; i < arr2.Length; i++)
				{
					global::NPOI.SS.Formula.FormulaCellCacheEntry formulaCellCacheEntry = this._arr[i];
					if (formulaCellCacheEntry != null)
					{
						if (formulaCellCacheEntry == cce)
						{
							result = true;
							this._size--;
						}
						else
						{
							global::NPOI.SS.Formula.CellCacheEntry[] arr3 = array;
							global::NPOI.SS.Formula.FormulaCellCacheEntrySet.AddInternal(arr3, formulaCellCacheEntry);
						}
					}
				}
				this._arr = array;
				return result;
			}
			int num = cce.GetHashCode() % arr.Length;
			for (int j = num; j < arr.Length; j++)
			{
				if (arr[j] == cce)
				{
					arr[j] = null;
					this._size--;
					return true;
				}
			}
			for (int k = 0; k < num; k++)
			{
				if (arr[k] == cce)
				{
					arr[k] = null;
					this._size--;
					return true;
				}
			}
			return false;
		}

		// Token: 0x040003B0 RID: 944
		private int _size;

		// Token: 0x040003B1 RID: 945
		private global::NPOI.SS.Formula.FormulaCellCacheEntry[] _arr;
	}
}
