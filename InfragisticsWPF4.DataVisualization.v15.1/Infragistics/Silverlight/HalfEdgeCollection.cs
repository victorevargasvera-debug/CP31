using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Silverlight
{
	// Token: 0x020000C0 RID: 192
	public class HalfEdgeCollection : global::System.Collections.Generic.IEnumerable<global::Infragistics.Silverlight.HalfEdge>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x000266E5 File Offset: 0x000248E5
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Silverlight.HalfEdge> GetEnumerator()
		{
			return this.edges.Keys.GetEnumerator();
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000266FC File Offset: 0x000248FC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00026704 File Offset: 0x00024904
		public void Add(global::Infragistics.Silverlight.HalfEdge edge)
		{
			this.edges.Add(edge, null);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00026713 File Offset: 0x00024913
		public void Remove(global::Infragistics.Silverlight.HalfEdge edge)
		{
			this.edges.Remove(edge);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00026722 File Offset: 0x00024922
		public void Clear()
		{
			this.edges.Clear();
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0002672F File Offset: 0x0002492F
		public int Count
		{
			get
			{
				return this.edges.Count;
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0002673C File Offset: 0x0002493C
		public bool Contains(global::Infragistics.Silverlight.HalfEdge edge)
		{
			return this.edges.ContainsKey(edge);
		}

		// Token: 0x040002FC RID: 764
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Silverlight.HalfEdge, object> edges = new global::System.Collections.Generic.Dictionary<global::Infragistics.Silverlight.HalfEdge, object>(new global::Infragistics.Silverlight.HalfEdgeCollection.EdgeComparer());

		// Token: 0x020000C1 RID: 193
		private class EdgeComparer : global::System.Collections.Generic.IEqualityComparer<global::Infragistics.Silverlight.HalfEdge>
		{
			// Token: 0x06000838 RID: 2104 RVA: 0x00026762 File Offset: 0x00024962
			public bool Equals(global::Infragistics.Silverlight.HalfEdge e1, global::Infragistics.Silverlight.HalfEdge e2)
			{
				return (e1.Beg == e2.Beg && e1.End == e2.End) || (e1.Beg == e2.End && e1.End == e2.Beg);
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x000267A0 File Offset: 0x000249A0
			public int GetHashCode(global::Infragistics.Silverlight.HalfEdge e1)
			{
				return 65536 * global::System.Math.Max(e1.Beg, e1.End) + global::System.Math.Min(e1.Beg, e1.End);
			}
		}
	}
}
