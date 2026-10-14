using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DC RID: 988
	internal class RuleProcessor
	{
		// Token: 0x06002EDF RID: 11999 RVA: 0x000941E2 File Offset: 0x000923E2
		internal RuleProcessor()
		{
			this.m_processedNodeMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId, global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId>();
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000941F8 File Offset: 0x000923F8
		private static bool ApplyRulesToNode(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> rules, global::System.Data.Entity.Core.Query.InternalTrees.Node currentNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = currentNode;
			context.PreProcess(currentNode);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Rule rule in rules[(int)currentNode.Op.OpType])
			{
				if (rule.Match(currentNode) && rule.Apply(context, currentNode, out newNode))
				{
					context.PostProcess(newNode, rule);
					return true;
				}
			}
			context.PostProcess(currentNode, null);
			return false;
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00094280 File Offset: 0x00092480
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ApplyRulesToSubtree(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> rules, global::System.Data.Entity.Core.Query.InternalTrees.Node subTreeRoot, global::System.Data.Entity.Core.Query.InternalTrees.Node parent, int childIndexInParent)
		{
			int num = 0;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId, global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId, global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId>();
			global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId subTreeId;
			for (;;)
			{
				num++;
				context.PreProcessSubTree(subTreeRoot);
				subTreeId = new global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId(context, subTreeRoot, parent, childIndexInParent);
				if (this.m_processedNodeMap.ContainsKey(subTreeId))
				{
					goto IL_C7;
				}
				if (dictionary.ContainsKey(subTreeId))
				{
					break;
				}
				dictionary[subTreeId] = subTreeId;
				for (int i = 0; i < subTreeRoot.Children.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node node = subTreeRoot.Children[i];
					if (global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessor.ShouldApplyRules(node, subTreeRoot))
					{
						subTreeRoot.Children[i] = this.ApplyRulesToSubtree(context, rules, node, subTreeRoot, i);
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
				if (!global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessor.ApplyRulesToNode(context, rules, subTreeRoot, out node2))
				{
					goto Block_5;
				}
				context.PostProcessSubTree(subTreeRoot);
				subTreeRoot = node2;
			}
			this.m_processedNodeMap[subTreeId] = subTreeId;
			goto IL_C7;
			Block_5:
			this.m_processedNodeMap[subTreeId] = subTreeId;
			IL_C7:
			context.PostProcessSubTree(subTreeRoot);
			return subTreeRoot;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x0009435C File Offset: 0x0009255C
		private static bool ShouldApplyRules(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Node parent)
		{
			return parent.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.In || node.Op.OpType > global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x0009437D File Offset: 0x0009257D
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node ApplyRulesToSubtree(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> rules, global::System.Data.Entity.Core.Query.InternalTrees.Node subTreeRoot)
		{
			return this.ApplyRulesToSubtree(context, rules, subTreeRoot, null, 0);
		}

		// Token: 0x04000FD1 RID: 4049
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId, global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId> m_processedNodeMap;
	}
}
