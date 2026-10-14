using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x020000BA RID: 186
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class StackPool<T>
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x00025BA4 File Offset: 0x00023DA4
		public T Pop()
		{
			T t;
			if (this.limbo.Count != 0)
			{
				t = this.limbo.Pop();
			}
			else
			{
				t = ((this.inactive.Count != 0) ? this.inactive.Pop() : this.Create());
				this.Activate(t);
			}
			this.active.Add(t, null);
			return t;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00025C0C File Offset: 0x00023E0C
		public void Push(T t)
		{
			this.active.Remove(t);
			if (this.DeferDisactivate)
			{
				this.limbo.Push(t);
				return;
			}
			this.Deactivate(t);
			int num = global::Infragistics.StackPool<T>.RoundUp(this.active.Count);
			if (this.inactive.Count < num)
			{
				this.Destroy(t);
				return;
			}
			this.inactive.Push(t);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00025C7F File Offset: 0x00023E7F
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00025C88 File Offset: 0x00023E88
		public bool DeferDisactivate
		{
			get
			{
				return this.deferDisactivate;
			}
			set
			{
				if (this.deferDisactivate != value)
				{
					this.deferDisactivate = value;
					if (!this.deferDisactivate)
					{
						int num = global::Infragistics.StackPool<T>.RoundUp(this.active.Count);
						while (this.limbo.Count > 0)
						{
							if (this.inactive.Count > num)
							{
								break;
							}
							T t = this.limbo.Pop();
							this.Deactivate(t);
							this.inactive.Push(t);
						}
						while (this.limbo.Count > 0)
						{
							T obj = this.limbo.Pop();
							this.Deactivate(obj);
							this.Destroy(obj);
						}
						while (this.inactive.Count > num)
						{
							this.Destroy(this.inactive.Pop());
						}
					}
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00025D60 File Offset: 0x00023F60
		public int ActiveCount
		{
			get
			{
				return this.active.Count;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00025D6D File Offset: 0x00023F6D
		public int InactiveCount
		{
			get
			{
				return this.inactive.Count;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00025D7A File Offset: 0x00023F7A
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00025D82 File Offset: 0x00023F82
		public global::System.Func<T> Create { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00025D8B File Offset: 0x00023F8B
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00025D93 File Offset: 0x00023F93
		public global::System.Action<T> Deactivate { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00025D9C File Offset: 0x00023F9C
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00025DA4 File Offset: 0x00023FA4
		public global::System.Action<T> Activate { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00025DAD File Offset: 0x00023FAD
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public global::System.Action<T> Destroy { get; set; }

		// Token: 0x0600080C RID: 2060 RVA: 0x00025DC0 File Offset: 0x00023FC0
		private static int RoundUp(int a)
		{
			int num = 2;
			while (a > num)
			{
				num <<= 1;
			}
			return num;
		}

		// Token: 0x040002EB RID: 747
		private bool deferDisactivate;

		// Token: 0x040002EC RID: 748
		private global::System.Collections.Generic.Dictionary<T, object> active = new global::System.Collections.Generic.Dictionary<T, object>();

		// Token: 0x040002ED RID: 749
		private global::System.Collections.Generic.Stack<T> limbo = new global::System.Collections.Generic.Stack<T>();

		// Token: 0x040002EE RID: 750
		private global::System.Collections.Generic.Stack<T> inactive = new global::System.Collections.Generic.Stack<T>();
	}
}
