using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x020000AB RID: 171
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class Pool<T> : global::Infragistics.IIndexedPool<T>, global::Infragistics.IPool<T>
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x000233F8 File Offset: 0x000215F8
		public Pool()
		{
			this.Active = new global::System.Collections.Generic.List<T>();
			this.Inactive = new global::System.Collections.Generic.List<T>();
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00023416 File Offset: 0x00021616
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x0002341E File Offset: 0x0002161E
		public global::System.Func<T> Create { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00023427 File Offset: 0x00021627
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0002342F File Offset: 0x0002162F
		public global::System.Action<T> Disactivate { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00023438 File Offset: 0x00021638
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00023440 File Offset: 0x00021640
		public global::System.Action<T> Activate { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00023449 File Offset: 0x00021649
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00023451 File Offset: 0x00021651
		public global::System.Action<T> Destroy { get; set; }

		// Token: 0x170001B1 RID: 433
		public T this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					this.Count = index + 1;
				}
				return this.Active[index];
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0002347A File Offset: 0x0002167A
		public void Clear()
		{
			this.Count = 0;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00023483 File Offset: 0x00021683
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00023490 File Offset: 0x00021690
		public int Count
		{
			get
			{
				return this.Active.Count;
			}
			set
			{
				int num = this.Active.Count;
				while (value > this.Active.Count)
				{
					if (this.Inactive.Count <= 0)
					{
						break;
					}
					T t = this.Inactive[this.Inactive.Count - 1];
					this.Active.Add(t);
					this.Inactive.RemoveAt(this.Inactive.Count - 1);
					if (this.Activate != null)
					{
						this.Activate(t);
					}
				}
				while (value > this.Active.Count && this.Inactive.Count == 0)
				{
					T t2 = this.Create();
					this.Active.Add(t2);
					if (this.Activate != null)
					{
						this.Activate(t2);
					}
				}
				int num2 = 2;
				while (num != 0)
				{
					num >>= 1;
					num2 <<= 1;
				}
				while (value < this.Active.Count)
				{
					T t3 = this.Active[this.Active.Count - 1];
					this.Active.RemoveAt(this.Active.Count - 1);
					if (this.Disactivate != null)
					{
						this.Disactivate(t3);
					}
					if (this.Inactive.Count < num2)
					{
						this.Inactive.Add(t3);
					}
					else if (this.Destroy != null)
					{
						this.Destroy(t3);
					}
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00023655 File Offset: 0x00021855
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0002365D File Offset: 0x0002185D
		public global::System.Collections.Generic.List<T> Active { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00023666 File Offset: 0x00021866
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0002366E File Offset: 0x0002186E
		public global::System.Collections.Generic.List<T> Inactive { get; set; }

		// Token: 0x0600076B RID: 1899 RVA: 0x00023678 File Offset: 0x00021878
		public void DoToAll(global::System.Action<T> action)
		{
			for (int i = 0; i < this.Inactive.Count; i++)
			{
				action(this.Inactive[i]);
			}
			for (int j = 0; j < this.Active.Count; j++)
			{
				action(this.Active[j]);
			}
		}
	}
}
