using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200034A RID: 842
	internal class JoinElimination : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x00078D83 File Offset: 0x00076F83
		private global::System.Data.Entity.Core.Query.InternalTrees.Command Command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x00078D90 File Offset: 0x00076F90
		private global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager ConstraintManager
		{
			get
			{
				return this.m_compilerState.ConstraintManager;
			}
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00078DA0 File Offset: 0x00076FA0
		private JoinElimination(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			this.m_compilerState = compilerState;
			this.m_varRemapper = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(this.m_compilerState.Command);
			this.m_varRefManager = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager(this.m_compilerState.Command);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00078DF1 File Offset: 0x00076FF1
		internal static bool Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinElimination joinElimination = new global::System.Data.Entity.Core.Query.PlanCompiler.JoinElimination(compilerState);
			joinElimination.Process();
			return joinElimination.m_treeModified;
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00078E04 File Offset: 0x00077004
		private void Process()
		{
			this.Command.Root = base.VisitNode(this.Command.Root);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00078E22 File Offset: 0x00077022
		private bool NeedsJoinGraph(global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode)
		{
			return !this.m_joinGraphUnnecessaryMap.ContainsKey(joinNode);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00078E34 File Offset: 0x00077034
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProcessJoinGraph(global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = new global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph(this.Command, this.ConstraintManager, this.m_varRefManager, joinNode).DoJoinElimination(out varMap, out dictionary);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap)
			{
				this.m_varRemapper.AddMapping(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in dictionary.Keys)
			{
				this.m_joinGraphUnnecessaryMap[node] = node;
			}
			return result;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00078F00 File Offset: 0x00077100
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefaultForAllNodes(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			this.Command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00078F22 File Offset: 0x00077122
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_varRefManager.AddChildren(n);
			return this.VisitDefaultForAllNodes(n);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00078F38 File Offset: 0x00077138
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			if (this.NeedsJoinGraph(joinNode))
			{
				node = this.ProcessJoinGraph(joinNode);
				if (node != joinNode)
				{
					this.m_treeModified = true;
				}
			}
			else
			{
				node = joinNode;
			}
			return this.VisitDefaultForAllNodes(node);
		}

		// Token: 0x04000E07 RID: 3591
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000E08 RID: 3592
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_joinGraphUnnecessaryMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node>();

		// Token: 0x04000E09 RID: 3593
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper m_varRemapper;

		// Token: 0x04000E0A RID: 3594
		private bool m_treeModified;

		// Token: 0x04000E0B RID: 3595
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager m_varRefManager;
	}
}
