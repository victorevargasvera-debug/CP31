using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Text;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D3 RID: 1491
	internal class UndirectedGraph<TVertex> : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060047F9 RID: 18425 RVA: 0x000FE51E File Offset: 0x000FC71E
		internal UndirectedGraph(global::System.Collections.Generic.IEqualityComparer<TVertex> comparer)
		{
			this.m_graph = new global::System.Data.Entity.Core.Mapping.Update.Internal.Graph<TVertex>(comparer);
			this.m_comparer = comparer;
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x000FE539 File Offset: 0x000FC739
		internal global::System.Collections.Generic.IEnumerable<TVertex> Vertices
		{
			get
			{
				return this.m_graph.Vertices;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x000FE546 File Offset: 0x000FC746
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TVertex, TVertex>> Edges
		{
			get
			{
				return this.m_graph.Edges;
			}
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x000FE553 File Offset: 0x000FC753
		internal void AddVertex(TVertex vertex)
		{
			this.m_graph.AddVertex(vertex);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000FE561 File Offset: 0x000FC761
		internal void AddEdge(TVertex first, TVertex second)
		{
			this.m_graph.AddEdge(first, second);
			this.m_graph.AddEdge(second, first);
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x000FE580 File Offset: 0x000FC780
		internal global::System.Data.Entity.Core.Common.Utils.KeyToListMap<int, TVertex> GenerateConnectedComponents()
		{
			int num = 0;
			global::System.Collections.Generic.Dictionary<TVertex, global::System.Data.Entity.Core.Mapping.Update.Internal.UndirectedGraph<TVertex>.ComponentNum> dictionary = new global::System.Collections.Generic.Dictionary<TVertex, global::System.Data.Entity.Core.Mapping.Update.Internal.UndirectedGraph<TVertex>.ComponentNum>(this.m_comparer);
			foreach (TVertex key in this.Vertices)
			{
				dictionary.Add(key, new global::System.Data.Entity.Core.Mapping.Update.Internal.UndirectedGraph<TVertex>.ComponentNum(num));
				num++;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<TVertex, TVertex> keyValuePair in this.Edges)
			{
				if (dictionary[keyValuePair.Key].componentNum != dictionary[keyValuePair.Value].componentNum)
				{
					int componentNum = dictionary[keyValuePair.Value].componentNum;
					int componentNum2 = dictionary[keyValuePair.Key].componentNum;
					dictionary[keyValuePair.Value].componentNum = componentNum2;
					foreach (TVertex key2 in dictionary.Keys)
					{
						if (dictionary[key2].componentNum == componentNum)
						{
							dictionary[key2].componentNum = componentNum2;
						}
					}
				}
			}
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<int, TVertex> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<int, TVertex>(global::System.Collections.Generic.EqualityComparer<int>.Default);
			foreach (TVertex tvertex in this.Vertices)
			{
				int componentNum3 = dictionary[tvertex].componentNum;
				keyToListMap.Add(componentNum3, tvertex);
			}
			return keyToListMap;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x000FE748 File Offset: 0x000FC948
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.m_graph);
		}

		// Token: 0x04001995 RID: 6549
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.Graph<TVertex> m_graph;

		// Token: 0x04001996 RID: 6550
		private readonly global::System.Collections.Generic.IEqualityComparer<TVertex> m_comparer;

		// Token: 0x02000C0E RID: 3086
		private class ComponentNum
		{
			// Token: 0x0600696F RID: 26991 RVA: 0x00167896 File Offset: 0x00165A96
			internal ComponentNum(int compNum)
			{
				this.componentNum = compNum;
			}

			// Token: 0x06006970 RID: 26992 RVA: 0x001678A5 File Offset: 0x00165AA5
			public override string ToString()
			{
				return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
				{
					this.componentNum
				});
			}

			// Token: 0x04002FBB RID: 12219
			internal int componentNum;
		}
	}
}
