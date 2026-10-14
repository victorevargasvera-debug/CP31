using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000358 RID: 856
	internal static class PlanCompilerUtil
	{
		// Token: 0x0600296B RID: 10603 RVA: 0x00083948 File Offset: 0x00081B48
		internal static bool IsRowTypeCaseOpWithNullability(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out bool thenClauseIsNull)
		{
			thenClauseIsNull = false;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(op.Type))
			{
				return false;
			}
			if (n.Children.Count != 3)
			{
				return false;
			}
			if (!n.Child1.Op.Type.EdmEquals(op.Type) || !n.Child2.Op.Type.EdmEquals(op.Type))
			{
				return false;
			}
			if (n.Child1.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
			{
				thenClauseIsNull = true;
				return true;
			}
			return n.Child2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000839E1 File Offset: 0x00081BE1
		internal static bool IsCollectionAggregateFunction(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.Children.Count >= 1 && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(n.Child0.Op.Type) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsAggregateFunction(op.Function);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00083A15 File Offset: 0x00081C15
		internal static bool IsConstantBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType)
		{
			return opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant || opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant || opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null || opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel;
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00083A28 File Offset: 0x00081C28
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node CombinePredicates(global::System.Data.Entity.Core.Query.InternalTrees.Node predicate1, global::System.Data.Entity.Core.Query.InternalTrees.Node predicate2, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Node> enumerable = global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.BreakIntoAndParts(predicate1);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Node> enumerable2 = global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.BreakIntoAndParts(predicate2);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = predicate1;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in enumerable2)
			{
				bool flag = false;
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Node> enumerator2 = enumerable.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.IsEquivalent(node2))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					node = command.CreateNode(command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
			}
			return node;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00083AD4 File Offset: 0x00081CD4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Node> BreakIntoAndParts(global::System.Data.Entity.Core.Query.InternalTrees.Node predicate)
		{
			return global::System.Data.Entity.Core.Common.Utils.Helpers.GetLeafNodes<global::System.Data.Entity.Core.Query.InternalTrees.Node>(predicate, (global::System.Data.Entity.Core.Query.InternalTrees.Node node) => node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.And, (global::System.Data.Entity.Core.Query.InternalTrees.Node node) => new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				node.Child0,
				node.Child1
			});
		}
	}
}
