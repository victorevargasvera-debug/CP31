using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000355 RID: 853
	internal class OpCopierTrackingCollectionVars : global::System.Data.Entity.Core.Query.InternalTrees.OpCopier
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x000833F4 File Offset: 0x000815F4
		private OpCopierTrackingCollectionVars(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd) : base(cmd)
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00083408 File Offset: 0x00081608
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> newCollectionVarDefinitions)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.OpCopierTrackingCollectionVars opCopierTrackingCollectionVars = new global::System.Data.Entity.Core.Query.PlanCompiler.OpCopierTrackingCollectionVars(cmd);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = opCopierTrackingCollectionVars.CopyNode(n);
			varMap = opCopierTrackingCollectionVars.m_varMap;
			newCollectionVarDefinitions = opCopierTrackingCollectionVars.m_newCollectionVarDefinitions;
			return result;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00083434 File Offset: 0x00081634
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.Visit(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp multiStreamNestOp = (global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp)node.Op;
			for (int i = 0; i < multiStreamNestOp.CollectionInfo.Count; i++)
			{
				this.m_newCollectionVarDefinitions.Add(multiStreamNestOp.CollectionInfo[i].CollectionVar, node.Children[i + 1]);
			}
			return node;
		}

		// Token: 0x04000E3D RID: 3645
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_newCollectionVarDefinitions = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
	}
}
