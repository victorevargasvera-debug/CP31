using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x020000DB RID: 219
	public class WeakReferenceHelper<T> where T : class
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0001B3F0 File Offset: 0x000195F0
		public global::System.Collections.Generic.List<global::System.WeakReference> Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001B3F8 File Offset: 0x000195F8
		public WeakReferenceHelper()
		{
			this._values = new global::System.Collections.Generic.List<global::System.WeakReference>();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001B40C File Offset: 0x0001960C
		public bool Contains(T item)
		{
			for (int i = 0; i < this._values.Count; i++)
			{
				if (this._values[i].Target == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0001B44B File Offset: 0x0001964B
		public void Add(T item)
		{
			if (this._values.Count == this._values.Capacity)
			{
				this.CleanValues();
			}
			this._values.Add(new global::System.WeakReference(item));
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001B481 File Offset: 0x00019681
		public void AddRange(global::System.Collections.Generic.IEnumerable<global::System.WeakReference> items)
		{
			if (items != null)
			{
				this._values.AddRange(items);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001B494 File Offset: 0x00019694
		public T RemoveLast()
		{
			int i = this._values.Count - 1;
			while (i >= 0)
			{
				global::System.WeakReference weakReference = this._values[i];
				this._values.RemoveAt(i);
				T t = weakReference.Target as T;
				if (t != null)
				{
					return t;
				}
			}
			return default(T);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001B4F4 File Offset: 0x000196F4
		public bool Remove(T item)
		{
			for (int i = 0; i < this._values.Count; i++)
			{
				if (this._values[i].Target == item)
				{
					this._values.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001B540 File Offset: 0x00019740
		public void ForEach(global::System.Func<T, bool> action)
		{
			int i = 0;
			while (i < this._values.Count)
			{
				global::System.WeakReference weakReference = this._values[i];
				T t = weakReference.Target as T;
				if (t != null)
				{
					if (!action(t))
					{
						return;
					}
					i++;
				}
				else
				{
					this._values.RemoveAt(i);
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001B5A4 File Offset: 0x000197A4
		public int Count
		{
			get
			{
				int num = 0;
				foreach (global::System.WeakReference weakReference in this._values)
				{
					if (weakReference.IsAlive)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x17000157 RID: 343
		public T this[int index]
		{
			get
			{
				int num = 0;
				foreach (global::System.WeakReference weakReference in this._values)
				{
					if (weakReference.IsAlive)
					{
						num++;
					}
					if (num - 1 == index)
					{
						return (T)((object)weakReference.Target);
					}
				}
				return default(T);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001B67C File Offset: 0x0001987C
		private void CleanValues()
		{
			for (int i = this._values.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = this._values[i];
				T t = weakReference.Target as T;
				if (t == null)
				{
					this._values.RemoveAt(i);
				}
			}
		}

		// Token: 0x0400038C RID: 908
		private readonly global::System.Collections.Generic.List<global::System.WeakReference> _values;
	}
}
