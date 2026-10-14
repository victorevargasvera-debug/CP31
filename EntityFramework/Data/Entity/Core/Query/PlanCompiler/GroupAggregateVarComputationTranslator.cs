using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000343 RID: 835
	internal class GroupAggregateVarComputationTranslator : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x060027C7 RID: 10183 RVA: 0x00074950 File Offset: 0x00072B50
		private GroupAggregateVarComputationTranslator(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfoManager groupAggregateVarInfoManager)
		{
			this._command = command;
			this._groupAggregateVarInfoManager = groupAggregateVarInfoManager;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00074968 File Offset: 0x00072B68
		public static bool TryTranslateOverGroupAggregateVar(global::System.Data.Entity.Core.Query.InternalTrees.Node subtree, bool isVarDefinition, global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfoManager groupAggregateVarInfoManager, out global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo, out global::System.Data.Entity.Core.Query.InternalTrees.Node templateNode, out bool isUnnested)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator groupAggregateVarComputationTranslator = new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator(command, groupAggregateVarInfoManager);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = subtree;
			global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp softCastOp = null;
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast)
			{
				softCastOp = (global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp)node.Op;
				node = node.Child0;
			}
			bool flag;
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect)
			{
				templateNode = groupAggregateVarComputationTranslator.VisitCollect(node);
				flag = true;
			}
			else
			{
				templateNode = groupAggregateVarComputationTranslator.VisitNode(node);
				flag = false;
			}
			groupAggregateVarInfo = groupAggregateVarComputationTranslator._targetGroupAggregateVarInfo;
			isUnnested = groupAggregateVarComputationTranslator._isUnnested;
			if (groupAggregateVarComputationTranslator._targetGroupAggregateVarInfo == null || templateNode == null)
			{
				return false;
			}
			if (softCastOp != null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op;
				if (flag || (!isVarDefinition && global::System.Data.Entity.Core.Query.PlanCompiler.AggregatePushdownUtil.IsVarRefOverGivenVar(templateNode, groupAggregateVarComputationTranslator._targetGroupAggregateVarInfo.GroupAggregateVar)))
				{
					op = command.CreateSoftCastOp(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(softCastOp.Type).TypeUsage);
				}
				else
				{
					op = softCastOp;
				}
				templateNode = command.CreateNode(op, templateNode);
			}
			return true;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00074A37 File Offset: 0x00072C37
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.TranslateOverGroupAggregateVar(op.Var, null);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00074A48 File Offset: 0x00072C48
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				return base.Visit(op, n);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)n.Child0.Op;
			return this.TranslateOverGroupAggregateVar(varRefOp.Var, op.PropertyInfo);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00074A94 File Offset: 0x00072C94
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitCollect(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			while (child.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				child = child.Child0;
				if (this.VisitDefault(child.Child1) == null)
				{
					return null;
				}
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in child.Child1.Children)
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator.IsConstant(node.Child0))
					{
						dictionary.Add(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var, node.Child0);
					}
				}
			}
			if (child.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Unnest)
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = (global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp)child.Child0.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo;
			if (!this._groupAggregateVarInfoManager.TryGetReferencedGroupAggregateVarInfo(unnestOp.Var, out groupAggregateVarRefInfo))
			{
				return null;
			}
			if (this._targetGroupAggregateVarInfo == null)
			{
				this._targetGroupAggregateVarInfo = groupAggregateVarRefInfo.GroupAggregateVarInfo;
			}
			else if (this._targetGroupAggregateVarInfo != groupAggregateVarRefInfo.GroupAggregateVarInfo)
			{
				return null;
			}
			if (!this._isUnnested)
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)n.Child0.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(physicalProjectOp.Outputs.Count == 1, "Physical project should only have one output at this stage");
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = physicalProjectOp.Outputs[0];
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.TranslateOverGroupAggregateVar(var, null);
			if (node2 != null)
			{
				this._isUnnested = true;
				return node2;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (dictionary.TryGetValue(var, out result))
			{
				this._isUnnested = true;
				return result;
			}
			return null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00074C24 File Offset: 0x00072E24
		private static bool IsConstant(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = node;
			while (node2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Cast)
			{
				node2 = node2.Child0;
			}
			return global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsConstantBaseOp(node2.Op.OpType);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00074C5C File Offset: 0x00072E5C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node TranslateOverGroupAggregateVar(global::System.Data.Entity.Core.Query.InternalTrees.Var var, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo;
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			if (this._groupAggregateVarInfoManager.TryGetReferencedGroupAggregateVarInfo(var, out groupAggregateVarRefInfo))
			{
				edmMember = property;
			}
			else
			{
				if (!this._groupAggregateVarInfoManager.TryGetReferencedGroupAggregateVarInfo(var, property, out groupAggregateVarRefInfo))
				{
					return null;
				}
				edmMember = null;
			}
			if (this._targetGroupAggregateVarInfo == null)
			{
				this._targetGroupAggregateVarInfo = groupAggregateVarRefInfo.GroupAggregateVarInfo;
				this._isUnnested = groupAggregateVarRefInfo.IsUnnested;
			}
			else if (this._targetGroupAggregateVarInfo != groupAggregateVarRefInfo.GroupAggregateVarInfo || this._isUnnested != groupAggregateVarRefInfo.IsUnnested)
			{
				return null;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = groupAggregateVarRefInfo.Computation;
			if (edmMember != null)
			{
				node = this._command.CreateNode(this._command.CreatePropertyOp(edmMember), node);
			}
			return node;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00074CF8 File Offset: 0x00072EF8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(n.Children.Count);
			bool flag = false;
			for (int i = 0; i < n.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.VisitNode(n.Children[i]);
				if (node == null)
				{
					return null;
				}
				if (!flag && n.Children[i] != node)
				{
					flag = true;
				}
				list.Add(node);
			}
			if (!flag)
			{
				return n;
			}
			return this._command.CreateNode(n.Op, list);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00074D78 File Offset: 0x00072F78
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return null;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00074D7B File Offset: 0x00072F7B
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return null;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00074D7E File Offset: 0x00072F7E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00074D81 File Offset: 0x00072F81
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return null;
		}

		// Token: 0x04000DE4 RID: 3556
		private global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo _targetGroupAggregateVarInfo;

		// Token: 0x04000DE5 RID: 3557
		private bool _isUnnested;

		// Token: 0x04000DE6 RID: 3558
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _command;

		// Token: 0x04000DE7 RID: 3559
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfoManager _groupAggregateVarInfoManager;
	}
}
