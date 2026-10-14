using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C9 RID: 1481
	internal class Graph<TVertex>
	{
		// Token: 0x060047A7 RID: 18343 RVA: 0x000FCEF8 File Offset: 0x000FB0F8
		internal Graph(global::System.Collections.Generic.IEqualityComparer<TVertex> comparer)
		{
			this.m_comparer = comparer;
			this.m_successorMap = new global::System.Collections.Generic.Dictionary<TVertex, global::System.Collections.Generic.HashSet<TVertex>>(comparer);
			this.m_predecessorCounts = new global::System.Collections.Generic.Dictionary<TVertex, int>(comparer);
			this.m_vertices = new global::System.Collections.Generic.HashSet<TVertex>(comparer);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000FCF2B File Offset: 0x000FB12B
		internal global::System.Collections.Generic.IEnumerable<TVertex> Vertices
		{
			get
			{
				return this.m_vertices;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x000FCF33 File Offset: 0x000FB133
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TVertex, TVertex>> Edges
		{
			get
			{
				foreach (global::System.Collections.Generic.KeyValuePair<TVertex, global::System.Collections.Generic.HashSet<TVertex>> successors in this.m_successorMap)
				{
					foreach (TVertex value in successors.Value)
					{
						yield return new global::System.Collections.Generic.KeyValuePair<TVertex, TVertex>(successors.Key, value);
					}
					global::System.Collections.Generic.HashSet<TVertex>.Enumerator enumerator2 = default(global::System.Collections.Generic.HashSet<TVertex>.Enumerator);
					successors = default(global::System.Collections.Generic.KeyValuePair<TVertex, global::System.Collections.Generic.HashSet<TVertex>>);
				}
				global::System.Collections.Generic.Dictionary<TVertex, global::System.Collections.Generic.HashSet<TVertex>>.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<TVertex, global::System.Collections.Generic.HashSet<TVertex>>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x000FCF43 File Offset: 0x000FB143
		internal void AddVertex(TVertex vertex)
		{
			this.m_vertices.Add(vertex);
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x000FCF54 File Offset: 0x000FB154
		internal void AddEdge(TVertex from, TVertex to)
		{
			if (this.m_vertices.Contains(from) && this.m_vertices.Contains(to))
			{
				global::System.Collections.Generic.HashSet<TVertex> hashSet;
				if (!this.m_successorMap.TryGetValue(from, out hashSet))
				{
					hashSet = new global::System.Collections.Generic.HashSet<TVertex>(this.m_comparer);
					this.m_successorMap.Add(from, hashSet);
				}
				if (hashSet.Add(to))
				{
					int num;
					if (!this.m_predecessorCounts.TryGetValue(to, out num))
					{
						num = 1;
					}
					else
					{
						num++;
					}
					this.m_predecessorCounts[to] = num;
				}
			}
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		internal bool TryTopologicalSort(out global::System.Collections.Generic.IEnumerable<TVertex> orderedVertices, out global::System.Collections.Generic.IEnumerable<TVertex> remainder)
		{
			global::System.Collections.Generic.SortedSet<TVertex> sortedSet = new global::System.Collections.Generic.SortedSet<TVertex>(global::System.Collections.Generic.Comparer<TVertex>.Default);
			foreach (TVertex tvertex in this.m_vertices)
			{
				int num;
				if (!this.m_predecessorCounts.TryGetValue(tvertex, out num) || num == 0)
				{
					sortedSet.Add(tvertex);
				}
			}
			TVertex[] array = new TVertex[this.m_vertices.Count];
			int count = 0;
			while (0 < sortedSet.Count)
			{
				TVertex min = sortedSet.Min;
				sortedSet.Remove(min);
				global::System.Collections.Generic.HashSet<TVertex> hashSet;
				if (this.m_successorMap.TryGetValue(min, out hashSet))
				{
					foreach (TVertex tvertex2 in hashSet)
					{
						int num2 = this.m_predecessorCounts[tvertex2] - 1;
						this.m_predecessorCounts[tvertex2] = num2;
						if (num2 == 0)
						{
							sortedSet.Add(tvertex2);
						}
					}
					this.m_successorMap.Remove(min);
				}
				array[count++] = min;
				this.m_vertices.Remove(min);
			}
			if (this.m_vertices.Count == 0)
			{
				orderedVertices = array;
				remainder = global::System.Linq.Enumerable.Empty<TVertex>();
				return true;
			}
			orderedVertices = array.Take(count);
			remainder = this.m_vertices;
			return false;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x000FD14C File Offset: 0x000FB34C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Collections.Generic.KeyValuePair<TVertex, global::System.Collections.Generic.HashSet<TVertex>> keyValuePair in this.m_successorMap)
			{
				bool flag = true;
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}] --> ", new object[]
				{
					keyValuePair.Key
				});
				foreach (TVertex tvertex in keyValuePair.Value)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}]", new object[]
					{
						tvertex
					});
				}
				stringBuilder.Append("; ");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001970 RID: 6512
		private readonly global::System.Collections.Generic.Dictionary<TVertex, global::System.Collections.Generic.HashSet<TVertex>> m_successorMap;

		// Token: 0x04001971 RID: 6513
		private readonly global::System.Collections.Generic.Dictionary<TVertex, int> m_predecessorCounts;

		// Token: 0x04001972 RID: 6514
		private readonly global::System.Collections.Generic.HashSet<TVertex> m_vertices;

		// Token: 0x04001973 RID: 6515
		private readonly global::System.Collections.Generic.IEqualityComparer<TVertex> m_comparer;
	}
}
