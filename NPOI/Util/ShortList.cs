using System;

namespace NPOI.Util
{
	// Token: 0x0200028F RID: 655
	public class ShortList
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00035577 File Offset: 0x00033777
		public ShortList() : this(global::NPOI.Util.ShortList._default_size)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00035584 File Offset: 0x00033784
		public ShortList(global::NPOI.Util.ShortList list) : this(list._array.Length)
		{
			global::System.Array.Copy(list._array, 0, this._array, 0, this._array.Length);
			this._limit = list._limit;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000355BB File Offset: 0x000337BB
		public ShortList(int InitialCapacity)
		{
			this._array = new short[InitialCapacity];
			this._limit = 0;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000355D8 File Offset: 0x000337D8
		public void Add(int index, short value)
		{
			if (index > this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (index == this._limit)
			{
				this.Add(value);
				return;
			}
			if (this._limit == this._array.Length)
			{
				this.GrowArray(this._limit * 2);
			}
			global::System.Array.Copy(this._array, index, this._array, index + 1, this._limit - index);
			this._array[index] = value;
			this._limit++;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00035658 File Offset: 0x00033858
		public bool Add(short value)
		{
			if (this._limit == this._array.Length)
			{
				this.GrowArray(this._limit * 2);
			}
			short[] array = this._array;
			int limit = this._limit;
			this._limit = limit + 1;
			array[limit] = value;
			return true;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000356A0 File Offset: 0x000338A0
		public bool AddAll(global::NPOI.Util.ShortList c)
		{
			if (c._limit != 0)
			{
				if (this._limit + c._limit > this._array.Length)
				{
					this.GrowArray(this._limit + c._limit);
				}
				global::System.Array.Copy(c._array, 0, this._array, this._limit, c._limit);
				this._limit += c._limit;
			}
			return true;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00035714 File Offset: 0x00033914
		public bool AddAll(int index, global::NPOI.Util.ShortList c)
		{
			if (index > this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (c._limit != 0)
			{
				if (this._limit + c._limit > this._array.Length)
				{
					this.GrowArray(this._limit + c._limit);
				}
				global::System.Array.Copy(this._array, index, this._array, index + c._limit, this._limit - index);
				global::System.Array.Copy(c._array, 0, this._array, index, c._limit);
				this._limit += c._limit;
			}
			return true;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000357B1 File Offset: 0x000339B1
		public void Clear()
		{
			this._limit = 0;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000357BC File Offset: 0x000339BC
		public bool Contains(short o)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < this._limit)
			{
				if (this._array[num] == o)
				{
					flag = true;
				}
				num++;
			}
			return flag;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000357F0 File Offset: 0x000339F0
		public bool ContainsAll(global::NPOI.Util.ShortList c)
		{
			bool flag = true;
			if (this != c)
			{
				int num = 0;
				while (flag && num < c._limit)
				{
					if (!this.Contains(c._array[num]))
					{
						flag = false;
					}
					num++;
				}
			}
			return flag;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0003582C File Offset: 0x00033A2C
		public override bool Equals(object o)
		{
			bool flag = this == o;
			if (!flag && o != null && o.GetType() == base.GetType())
			{
				global::NPOI.Util.ShortList shortList = (global::NPOI.Util.ShortList)o;
				if (shortList._limit == this._limit)
				{
					flag = true;
					int num = 0;
					while (flag && num < this._limit)
					{
						flag = (this._array[num] == shortList._array[num]);
						num++;
					}
				}
			}
			return flag;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00035896 File Offset: 0x00033A96
		public short Get(int index)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			return this._array[index];
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000358B0 File Offset: 0x00033AB0
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this._limit; i++)
			{
				num = 31 * num + (int)this._array[i];
			}
			return num;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000358E0 File Offset: 0x00033AE0
		public int IndexOf(short o)
		{
			int num = 0;
			while (num < this._limit && o != this._array[num])
			{
				num++;
			}
			if (num == this._limit)
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00035915 File Offset: 0x00033B15
		public bool IsEmpty()
		{
			return this._limit == 0;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00035920 File Offset: 0x00033B20
		public int LastIndexOf(short o)
		{
			int num = this._limit - 1;
			while (num >= 0 && o != this._array[num])
			{
				num--;
			}
			return num;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0003594C File Offset: 0x00033B4C
		public short Remove(int index)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			short result = this._array[index];
			global::System.Array.Copy(this._array, index + 1, this._array, index, this._limit - index);
			this._limit--;
			return result;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0003599C File Offset: 0x00033B9C
		public bool RemoveValue(short o)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < this._limit)
			{
				if (o == this._array[num])
				{
					global::System.Array.Copy(this._array, num + 1, this._array, num, this._limit - num);
					this._limit--;
					flag = true;
				}
				num++;
			}
			return flag;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x000359F8 File Offset: 0x00033BF8
		public bool RemoveAll(global::NPOI.Util.ShortList c)
		{
			bool result = false;
			for (int i = 0; i < c._limit; i++)
			{
				if (this.RemoveValue(c._array[i]))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00035A2C File Offset: 0x00033C2C
		public bool RetainAll(global::NPOI.Util.ShortList c)
		{
			bool result = false;
			int i = 0;
			while (i < this._limit)
			{
				if (!c.Contains(this._array[i]))
				{
					this.Remove(i);
					result = true;
				}
				else
				{
					i++;
				}
			}
			return result;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00035A69 File Offset: 0x00033C69
		public short Set(int index, short element)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			short result = this._array[index];
			this._array[index] = element;
			return result;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00035A8B File Offset: 0x00033C8B
		public int Size()
		{
			return this._limit;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00035A8B File Offset: 0x00033C8B
		public int Count
		{
			get
			{
				return this._limit;
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00035A94 File Offset: 0x00033C94
		public short[] ToArray()
		{
			short[] array = new short[this._limit];
			global::System.Array.Copy(this._array, 0, array, 0, this._limit);
			return array;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00035AC4 File Offset: 0x00033CC4
		public short[] ToArray(short[] a)
		{
			short[] result;
			if (a.Length == this._limit)
			{
				global::System.Array.Copy(this._array, 0, a, 0, this._limit);
				result = a;
			}
			else
			{
				result = this.ToArray();
			}
			return result;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00035AFC File Offset: 0x00033CFC
		private void GrowArray(int new_size)
		{
			short[] array = new short[(new_size == this._array.Length) ? (new_size + 1) : new_size];
			global::System.Array.Copy(this._array, 0, array, 0, this._limit);
			this._array = array;
		}

		// Token: 0x0400076C RID: 1900
		private short[] _array;

		// Token: 0x0400076D RID: 1901
		private int _limit;

		// Token: 0x0400076E RID: 1902
		private static int _default_size = 128;
	}
}
