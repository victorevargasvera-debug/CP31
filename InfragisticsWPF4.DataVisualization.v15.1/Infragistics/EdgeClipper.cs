using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006D RID: 109
	internal abstract class EdgeClipper : global::System.Collections.Generic.IList<global::System.Windows.Point>, global::System.Collections.Generic.ICollection<global::System.Windows.Point>, global::System.Collections.Generic.IEnumerable<global::System.Windows.Point>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000187A5 File Offset: 0x000169A5
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x000187AD File Offset: 0x000169AD
		public global::System.Collections.Generic.IList<global::System.Windows.Point> Dst
		{
			get
			{
				return this.dst;
			}
			set
			{
				if (this.dst != value)
				{
					this.init = true;
					this.dst = value;
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x000187C6 File Offset: 0x000169C6
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x000187CE File Offset: 0x000169CE
		public global::Infragistics.EdgeClipper NextClipper
		{
			get
			{
				return this._nextClipper;
			}
			set
			{
				this._nextClipper = value;
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000187D8 File Offset: 0x000169D8
		public void Add(global::System.Windows.Point cur)
		{
			bool flag = this.IsInside(cur);
			if (this.init)
			{
				this.init = false;
				this.First = cur;
			}
			else if (flag)
			{
				if (!this.PrevInside)
				{
					this.Dst.Add(this.Intersection(this.Prev, cur));
				}
				else if (!this.IsClosed && !this.IsOutput)
				{
					this.Dst.Add(this.Prev);
					this.IsOutput = true;
				}
				this.Dst.Add(cur);
			}
			else if (this.PrevInside)
			{
				if (!this.IsClosed && !this.IsOutput)
				{
					this.Dst.Add(this.Prev);
					this.IsOutput = true;
				}
				this.Dst.Add(this.Intersection(this.Prev, cur));
			}
			this.Prev = cur;
			this.PrevInside = flag;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000188B9 File Offset: 0x00016AB9
		public void Clear()
		{
			if (this.IsClosed && !this.init)
			{
				this.Add(this.First);
			}
			if (this._nextClipper != null)
			{
				this._nextClipper.Clear();
			}
			this.init = true;
			this.IsOutput = false;
		}

		// Token: 0x0600061B RID: 1563
		protected abstract bool IsInside(global::System.Windows.Point pt);

		// Token: 0x0600061C RID: 1564
		protected abstract global::System.Windows.Point Intersection(global::System.Windows.Point b, global::System.Windows.Point e);

		// Token: 0x0600061D RID: 1565 RVA: 0x000188F8 File Offset: 0x00016AF8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000188FB File Offset: 0x00016AFB
		public global::System.Collections.Generic.IEnumerator<global::System.Windows.Point> GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000188FE File Offset: 0x00016AFE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00018901 File Offset: 0x00016B01
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00018904 File Offset: 0x00016B04
		public bool Remove(global::System.Windows.Point pt)
		{
			return false;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00018907 File Offset: 0x00016B07
		public void RemoveAt(int n)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00018909 File Offset: 0x00016B09
		public void CopyTo(global::System.Windows.Point[] pt, int n)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001890B File Offset: 0x00016B0B
		public bool Contains(global::System.Windows.Point pt)
		{
			return false;
		}

		// Token: 0x1700017C RID: 380
		public global::System.Windows.Point this[int n]
		{
			get
			{
				return new global::System.Windows.Point(0.0, 0.0);
			}
			set
			{
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00018929 File Offset: 0x00016B29
		public void Insert(int n, global::System.Windows.Point pt)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001892B File Offset: 0x00016B2B
		public int IndexOf(global::System.Windows.Point pt)
		{
			return -1;
		}

		// Token: 0x04000269 RID: 617
		public global::System.Collections.Generic.IList<global::System.Windows.Point> dst;

		// Token: 0x0400026A RID: 618
		[global::System.Runtime.CompilerServices.DontObfuscate]
		private global::Infragistics.EdgeClipper _nextClipper;

		// Token: 0x0400026B RID: 619
		private bool init = true;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Point First;

		// Token: 0x0400026D RID: 621
		private global::System.Windows.Point Prev;

		// Token: 0x0400026E RID: 622
		private bool PrevInside;

		// Token: 0x0400026F RID: 623
		public bool IsClosed;

		// Token: 0x04000270 RID: 624
		private bool IsOutput;
	}
}
