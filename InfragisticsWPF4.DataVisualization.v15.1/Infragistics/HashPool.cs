using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics
{
	// Token: 0x020000AD RID: 173
	public class HashPool<TKey, TValue> : global::Infragistics.IHashPool<TKey, TValue>, global::Infragistics.IPool<TValue>
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x000236D5 File Offset: 0x000218D5
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000236DD File Offset: 0x000218DD
		protected global::System.Collections.Generic.List<TValue> Inactive { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000236E6 File Offset: 0x000218E6
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x000236EE File Offset: 0x000218EE
		protected global::System.Collections.Generic.Dictionary<TKey, TValue> Active { get; set; }

		// Token: 0x06000771 RID: 1905 RVA: 0x000236F7 File Offset: 0x000218F7
		public HashPool()
		{
			this.Inactive = new global::System.Collections.Generic.List<TValue>();
			this.Active = new global::System.Collections.Generic.Dictionary<TKey, TValue>();
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00023715 File Offset: 0x00021915
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0002371D File Offset: 0x0002191D
		public global::System.Func<TValue> Create { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00023726 File Offset: 0x00021926
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0002372E File Offset: 0x0002192E
		public global::System.Action<TValue> Disactivate { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00023737 File Offset: 0x00021937
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0002373F File Offset: 0x0002193F
		public global::System.Action<TValue> Activate { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00023748 File Offset: 0x00021948
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00023750 File Offset: 0x00021950
		public global::System.Action<TValue> Destroy { get; set; }

		// Token: 0x170001BC RID: 444
		public TValue this[TKey key]
		{
			get
			{
				TValue tvalue;
				if (!this.Active.TryGetValue(key, out tvalue))
				{
					if (this.Inactive.Count > 0)
					{
						tvalue = this.Inactive[this.Inactive.Count - 1];
						this.Inactive.RemoveAt(this.Inactive.Count - 1);
					}
					else
					{
						tvalue = this.Create();
					}
					if (this.Activate != null)
					{
						this.Activate(tvalue);
					}
					this.Active[key] = tvalue;
				}
				return tvalue;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000237E8 File Offset: 0x000219E8
		public global::System.Collections.Generic.IEnumerable<TKey> ActiveKeys
		{
			get
			{
				return this.Active.Keys;
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000237F5 File Offset: 0x000219F5
		public bool IsActiveKey(TKey key)
		{
			return this.Active.ContainsKey(key);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00023804 File Offset: 0x00021A04
		public void Remove(TKey key)
		{
			TValue tvalue;
			if (this.Active.TryGetValue(key, out tvalue))
			{
				this.Active.Remove(key);
				if (this.Disactivate != null)
				{
					this.Disactivate(tvalue);
				}
				this.Inactive.Add(tvalue);
				int num = this.Active.Count;
				int num2 = 2;
				while (num != 0)
				{
					num >>= 1;
					num2 <<= 1;
				}
				if (num2 < this.Inactive.Count)
				{
					for (int i = num2; i < this.Inactive.Count; i++)
					{
						this.Destroy(this.Inactive[i]);
					}
					this.Inactive.RemoveRange(num2, this.Inactive.Count - num2);
				}
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000238C0 File Offset: 0x00021AC0
		public void Clear()
		{
			global::System.Collections.Generic.List<TKey> list = new global::System.Collections.Generic.List<TKey>();
			foreach (TKey item in this.Active.Keys)
			{
				list.Add(item);
			}
			foreach (TKey key in list)
			{
				this.Remove(key);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0002395C File Offset: 0x00021B5C
		public int ActiveCount
		{
			get
			{
				return this.Active.Count;
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0002396C File Offset: 0x00021B6C
		public void DoToAll(global::System.Action<TValue> action)
		{
			for (int i = 0; i < this.Inactive.Count; i++)
			{
				action(this.Inactive[i]);
			}
			foreach (TValue obj in this.Active.Values.ToList<TValue>())
			{
				action(obj);
			}
		}
	}
}
