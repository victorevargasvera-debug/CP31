using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x020000F9 RID: 249
	public class WeakReferenceHelper<T> where T : class
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
		public global::System.Collections.Generic.List<global::System.WeakReference> Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
		public WeakReferenceHelper()
		{
			this._values = new global::System.Collections.Generic.List<global::System.WeakReference>();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
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

		// Token: 0x060008DE RID: 2270 RVA: 0x0001F013 File Offset: 0x0001D213
		public void Add(T item)
		{
			if (this._values.Count == this._values.Capacity)
			{
				this.CleanValues();
			}
			this._values.Add(new global::System.WeakReference(item));
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0001F049 File Offset: 0x0001D249
		public void AddRange(global::System.Collections.Generic.IEnumerable<global::System.WeakReference> items)
		{
			if (items != null)
			{
				this._values.AddRange(items);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0001F05C File Offset: 0x0001D25C
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

		// Token: 0x060008E1 RID: 2273 RVA: 0x0001F0BC File Offset: 0x0001D2BC
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

		// Token: 0x060008E2 RID: 2274 RVA: 0x0001F108 File Offset: 0x0001D308
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0001F16C File Offset: 0x0001D36C
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

		// Token: 0x1700016F RID: 367
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

		// Token: 0x060008E5 RID: 2277 RVA: 0x0001F244 File Offset: 0x0001D444
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

		// Token: 0x0400043F RID: 1087
		private readonly global::System.Collections.Generic.List<global::System.WeakReference> _values;
	}
}
