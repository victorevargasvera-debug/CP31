using System;
using System.Collections.Generic;

namespace NPOI.Util
{
	// Token: 0x02000270 RID: 624
	public class IntMapper<T>
	{
		// Token: 0x0600107D RID: 4221 RVA: 0x0003286C File Offset: 0x00030A6C
		public IntMapper() : this(global::NPOI.Util.IntMapper<T>._default_size)
		{
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00032879 File Offset: 0x00030A79
		public IntMapper(int InitialCapacity)
		{
			this.elements = new global::System.Collections.Generic.List<T>(InitialCapacity);
			this.valueKeyMap = new global::System.Collections.Generic.Dictionary<T, int>(InitialCapacity);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0003289C File Offset: 0x00030A9C
		public bool Add(T value)
		{
			int count = this.elements.Count;
			this.elements.Add(value);
			if (this.valueKeyMap.ContainsKey(value))
			{
				this.valueKeyMap[value] = count;
			}
			else
			{
				this.valueKeyMap.Add(value, count);
			}
			return true;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x000328EC File Offset: 0x00030AEC
		public int Size
		{
			get
			{
				return this.elements.Count;
			}
		}

		// Token: 0x17000344 RID: 836
		public T this[int index]
		{
			get
			{
				return this.elements[index];
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00032907 File Offset: 0x00030B07
		public int GetIndex(T o)
		{
			if (!this.valueKeyMap.ContainsKey(o))
			{
				return -1;
			}
			return this.valueKeyMap[o];
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00032925 File Offset: 0x00030B25
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this.elements.GetEnumerator();
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00032937 File Offset: 0x00030B37
		public void Clear()
		{
			this.elements.Clear();
			this.valueKeyMap.Clear();
		}

		// Token: 0x04000733 RID: 1843
		private global::System.Collections.Generic.List<T> elements;

		// Token: 0x04000734 RID: 1844
		private global::System.Collections.Generic.Dictionary<T, int> valueKeyMap;

		// Token: 0x04000735 RID: 1845
		private static int _default_size = 10;
	}
}
