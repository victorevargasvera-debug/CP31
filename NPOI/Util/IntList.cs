using System;

namespace NPOI.Util
{
	// Token: 0x0200026F RID: 623
	public class IntList
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x0003220D File Offset: 0x0003040D
		public IntList() : this(global::NPOI.Util.IntList._default_size)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0003221A File Offset: 0x0003041A
		public IntList(int InitialCapacity) : this(InitialCapacity, 0)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00032224 File Offset: 0x00030424
		public IntList(global::NPOI.Util.IntList list) : this(list._array.Length)
		{
			global::System.Array.Copy(list._array, 0, this._array, 0, this._array.Length);
			this._limit = list._limit;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0003225B File Offset: 0x0003045B
		public IntList(int initialCapacity, int fillvalue)
		{
			this._array = new int[initialCapacity];
			if (this.fillval != 0)
			{
				this.fillval = fillvalue;
				this.FillArray(this.fillval, this._array, 0);
			}
			this._limit = 0;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00032298 File Offset: 0x00030498
		private void FillArray(int val, int[] array, int index)
		{
			for (int i = index; i < array.Length; i++)
			{
				array[i] = val;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000322B8 File Offset: 0x000304B8
		public void Add(int index, int value)
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
				this.growArray(this._limit * 2);
			}
			global::System.Array.Copy(this._array, index, this._array, index + 1, this._limit - index);
			this._array[index] = value;
			this._limit++;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00032338 File Offset: 0x00030538
		public bool Add(int value)
		{
			if (this._limit == this._array.Length)
			{
				this.growArray(this._limit * 2);
			}
			int[] array = this._array;
			int limit = this._limit;
			this._limit = limit + 1;
			array[limit] = value;
			return true;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00032380 File Offset: 0x00030580
		public bool AddAll(global::NPOI.Util.IntList c)
		{
			if (c._limit != 0)
			{
				if (this._limit + c._limit > this._array.Length)
				{
					this.growArray(this._limit + c._limit);
				}
				global::System.Array.Copy(c._array, 0, this._array, this._limit, c._limit);
				this._limit += c._limit;
			}
			return true;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000323F4 File Offset: 0x000305F4
		public bool AddAll(int index, global::NPOI.Util.IntList c)
		{
			if (index > this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (c._limit != 0)
			{
				if (this._limit + c._limit > this._array.Length)
				{
					this.growArray(this._limit + c._limit);
				}
				global::System.Array.Copy(this._array, index, this._array, index + c._limit, this._limit - index);
				global::System.Array.Copy(c._array, 0, this._array, index, c._limit);
				this._limit += c._limit;
			}
			return true;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00032491 File Offset: 0x00030691
		public void Clear()
		{
			this._limit = 0;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0003249C File Offset: 0x0003069C
		public bool Contains(int o)
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

		// Token: 0x0600106B RID: 4203 RVA: 0x000324D0 File Offset: 0x000306D0
		public bool ContainsAll(global::NPOI.Util.IntList c)
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

		// Token: 0x0600106C RID: 4204 RVA: 0x0003250C File Offset: 0x0003070C
		public override bool Equals(object o)
		{
			bool flag = this == o;
			if (!flag && o != null && o.GetType() == base.GetType())
			{
				global::NPOI.Util.IntList intList = (global::NPOI.Util.IntList)o;
				if (intList._limit == this._limit)
				{
					flag = true;
					int num = 0;
					while (flag && num < this._limit)
					{
						flag = (this._array[num] == intList._array[num]);
						num++;
					}
				}
			}
			return flag;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00032576 File Offset: 0x00030776
		public int Get(int index)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException(index.ToString() + " not accessible in a list of length " + this._limit.ToString());
			}
			return this._array[index];
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000325AC File Offset: 0x000307AC
		public override int GetHashCode()
		{
			int num = 0;
			for (int i = 0; i < this._limit; i++)
			{
				num = 31 * num + this._array[i];
			}
			return num;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000325DC File Offset: 0x000307DC
		public int IndexOf(int o)
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

		// Token: 0x06001070 RID: 4208 RVA: 0x00032611 File Offset: 0x00030811
		public bool IsEmpty()
		{
			return this._limit == 0;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0003261C File Offset: 0x0003081C
		public int LastIndexOf(int o)
		{
			int num = this._limit - 1;
			while (num >= 0 && o != this._array[num])
			{
				num--;
			}
			return num;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00032648 File Offset: 0x00030848
		public int Remove(int index)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			int result = this._array[index];
			global::System.Array.Copy(this._array, index + 1, this._array, index, this._limit - index);
			this._limit--;
			return result;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00032698 File Offset: 0x00030898
		public bool RemoveValue(int o)
		{
			bool flag = false;
			int num = 0;
			while (!flag && num < this._limit)
			{
				if (o == this._array[num])
				{
					if (num + 1 < this._limit)
					{
						global::System.Array.Copy(this._array, num + 1, this._array, num, this._limit - num);
					}
					this._limit--;
					flag = true;
				}
				num++;
			}
			return flag;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00032700 File Offset: 0x00030900
		public bool RemoveAll(global::NPOI.Util.IntList c)
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

		// Token: 0x06001075 RID: 4213 RVA: 0x00032734 File Offset: 0x00030934
		public bool RetainAll(global::NPOI.Util.IntList c)
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

		// Token: 0x06001076 RID: 4214 RVA: 0x00032771 File Offset: 0x00030971
		public int Set(int index, int element)
		{
			if (index >= this._limit)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			int result = this._array[index];
			this._array[index] = element;
			return result;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00032793 File Offset: 0x00030993
		public int Size()
		{
			return this._limit;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00032793 File Offset: 0x00030993
		public int Count
		{
			get
			{
				return this._limit;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0003279C File Offset: 0x0003099C
		public int[] ToArray()
		{
			int[] array = new int[this._limit];
			global::System.Array.Copy(this._array, 0, array, 0, this._limit);
			return array;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000327CC File Offset: 0x000309CC
		public int[] ToArray(int[] a)
		{
			int[] result;
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

		// Token: 0x0600107B RID: 4219 RVA: 0x00032804 File Offset: 0x00030A04
		private void growArray(int new_size)
		{
			int[] array = new int[(new_size == this._array.Length) ? (new_size + 1) : new_size];
			if (this.fillval != 0)
			{
				this.FillArray(this.fillval, array, this._array.Length);
			}
			global::System.Array.Copy(this._array, 0, array, 0, this._limit);
			this._array = array;
		}

		// Token: 0x0400072F RID: 1839
		private int[] _array;

		// Token: 0x04000730 RID: 1840
		private int _limit;

		// Token: 0x04000731 RID: 1841
		private int fillval;

		// Token: 0x04000732 RID: 1842
		private static int _default_size = 128;
	}
}
