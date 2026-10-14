using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F6 RID: 1526
	internal static class Helpers
	{
		// Token: 0x06004AB3 RID: 19123 RVA: 0x00107E2A File Offset: 0x0010602A
		internal static void FormatTraceLine(string format, params object[] args)
		{
			global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x00107E3D File Offset: 0x0010603D
		internal static void StringTrace(string arg)
		{
			global::System.Diagnostics.Trace.Write(arg);
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00107E45 File Offset: 0x00106045
		internal static void StringTraceLine(string arg)
		{
			global::System.Diagnostics.Trace.WriteLine(arg);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00107E50 File Offset: 0x00106050
		internal static bool IsSetEqual<Type>(global::System.Collections.Generic.IEnumerable<Type> list1, global::System.Collections.Generic.IEnumerable<Type> list2, global::System.Collections.Generic.IEqualityComparer<Type> comparer)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<Type> set = new global::System.Data.Entity.Core.Common.Utils.Set<Type>(list1, comparer);
			global::System.Data.Entity.Core.Common.Utils.Set<Type> equals = new global::System.Data.Entity.Core.Common.Utils.Set<Type>(list2, comparer);
			return set.SetEquals(equals);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00107E72 File Offset: 0x00106072
		internal static global::System.Collections.Generic.IEnumerable<SuperType> AsSuperTypeList<SubType, SuperType>(global::System.Collections.Generic.IEnumerable<SubType> values) where SubType : SuperType
		{
			foreach (SubType subType in values)
			{
				yield return (SuperType)((object)subType);
			}
			global::System.Collections.Generic.IEnumerator<SubType> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00107E84 File Offset: 0x00106084
		internal static TElement[] Prepend<TElement>(TElement[] args, TElement arg)
		{
			TElement[] array = new TElement[args.Length + 1];
			array[0] = arg;
			for (int i = 0; i < args.Length; i++)
			{
				array[i + 1] = args[i];
			}
			return array;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00107EC4 File Offset: 0x001060C4
		internal static TNode BuildBalancedTreeInPlace<TNode>(global::System.Collections.Generic.IList<TNode> nodes, global::System.Func<TNode, TNode, TNode> combinator)
		{
			if (nodes.Count == 1)
			{
				return nodes[0];
			}
			if (nodes.Count == 2)
			{
				return combinator(nodes[0], nodes[1]);
			}
			for (int num = nodes.Count; num != 1; num /= 2)
			{
				bool flag = (num & 1) == 1;
				if (flag)
				{
					num--;
				}
				int num2 = 0;
				for (int i = 0; i < num; i += 2)
				{
					nodes[num2++] = combinator(nodes[i], nodes[i + 1]);
				}
				if (flag)
				{
					int index = num2 - 1;
					nodes[index] = combinator(nodes[index], nodes[num]);
				}
			}
			return nodes[0];
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00107F7A File Offset: 0x0010617A
		internal static global::System.Collections.Generic.IEnumerable<TNode> GetLeafNodes<TNode>(TNode root, global::System.Func<TNode, bool> isLeaf, global::System.Func<TNode, global::System.Collections.Generic.IEnumerable<TNode>> getImmediateSubNodes)
		{
			global::System.Collections.Generic.Stack<TNode> nodes = new global::System.Collections.Generic.Stack<TNode>();
			nodes.Push(root);
			while (nodes.Count > 0)
			{
				TNode tnode = nodes.Pop();
				if (isLeaf(tnode))
				{
					yield return tnode;
				}
				else
				{
					global::System.Collections.Generic.List<TNode> list = new global::System.Collections.Generic.List<TNode>(getImmediateSubNodes(tnode));
					for (int i = list.Count - 1; i > -1; i--)
					{
						nodes.Push(list[i]);
					}
				}
			}
			yield break;
		}
	}
}
