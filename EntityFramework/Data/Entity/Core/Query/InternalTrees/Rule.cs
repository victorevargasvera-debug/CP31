using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D9 RID: 985
	internal abstract class Rule
	{
		// Token: 0x06002ED2 RID: 11986 RVA: 0x00094181 File Offset: 0x00092381
		protected Rule(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate nodeProcessDelegate)
		{
			this.m_opType = opType;
			this.m_nodeDelegate = nodeProcessDelegate;
		}

		// Token: 0x06002ED3 RID: 11987
		internal abstract bool Match(global::System.Data.Entity.Core.Query.InternalTrees.Node node);

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00094197 File Offset: 0x00092397
		internal bool Apply(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext ruleProcessingContext, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return this.m_nodeDelegate(ruleProcessingContext, node, out newNode);
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x000941A7 File Offset: 0x000923A7
		internal global::System.Data.Entity.Core.Query.InternalTrees.OpType RuleOpType
		{
			get
			{
				return this.m_opType;
			}
		}

		// Token: 0x04000FCE RID: 4046
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate m_nodeDelegate;

		// Token: 0x04000FCF RID: 4047
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.OpType m_opType;

		// Token: 0x02000A0A RID: 2570
		// (Invoke) Token: 0x060060CB RID: 24779
		internal delegate bool ProcessNodeDelegate(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node subTree, out global::System.Data.Entity.Core.Query.InternalTrees.Node newSubTree);
	}
}
