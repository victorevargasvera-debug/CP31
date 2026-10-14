using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000350 RID: 848
	internal class NestPullup : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x060028AE RID: 10414 RVA: 0x0007C9CE File Offset: 0x0007ABCE
		private NestPullup(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			this.m_compilerState = compilerState;
			this.m_varRemapper = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(compilerState.Command);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0007CA04 File Offset: 0x0007AC04
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			new global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup(compilerState).Process();
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0007CA14 File Offset: 0x0007AC14
		private void Process()
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.Command.Root.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "root node is not physicalProject?");
			this.Command.Root = base.VisitNode(this.Command.Root);
			if (this.m_foundSortUnderUnnest)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.SortRemover.Process(this.Command);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0007CA73 File Offset: 0x0007AC73
		private global::System.Data.Entity.Core.Query.InternalTrees.Command Command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0007CA80 File Offset: 0x0007AC80
		private static bool IsNestOpNode(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleStreamNest, "illegal singleStreamNest?");
			return n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleStreamNest || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0007CAC0 File Offset: 0x0007ACC0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node NestingNotSupported(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(node))
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_NestingNotSupported(op.OpType.ToString(), node.Op.OpType.ToString()));
				}
			}
			return n;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0007CB60 File Offset: 0x0007AD60
		private global::System.Data.Entity.Core.Query.InternalTrees.Var ResolveVarReference(global::System.Data.Entity.Core.Query.InternalTrees.Var refVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = refVar;
			while (this.m_varRefMap.TryGetValue(var, out var))
			{
				refVar = var;
			}
			return refVar;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0007CB88 File Offset: 0x0007AD88
		private void UpdateReplacementVarMap(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> fromVars, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> toVars)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = toVars.GetEnumerator();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar in fromVars)
			{
				if (!enumerator.MoveNext())
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 2, null);
				}
				this.m_varRemapper.AddMapping(oldVar, enumerator.Current);
			}
			if (enumerator.MoveNext())
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 3, null);
			}
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0007CC0C File Offset: 0x0007AE0C
		private static void RemapSortKeys(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			if (sortKeys != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var;
					if (varMap.TryGetValue(sortKey.Var, out var))
					{
						sortKey.Var = var;
					}
				}
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0007CC70 File Offset: 0x0007AE70
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> RemapVars(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in vars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				if (varMap.TryGetValue(var, out var2))
				{
					yield return var2;
				}
				else
				{
					yield return var;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0007CC87 File Offset: 0x0007AE87
		private static global::System.Data.Entity.Core.Query.InternalTrees.VarList RemapVarList(global::System.Data.Entity.Core.Query.InternalTrees.VarList varList, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapVars(varList, varMap));
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x0007CC95 File Offset: 0x0007AE95
		private global::System.Data.Entity.Core.Query.InternalTrees.VarVec RemapVarVec(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			return this.Command.CreateVarVec(global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapVars(varVec, varMap));
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x0007CCAC File Offset: 0x0007AEAC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			if (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				this.m_varRefMap.Add(op.Var, ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)n.Child0.Op).Var);
			}
			return n;
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0007CD06 File Offset: 0x0007AF06
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			return n;
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x0007CD1C File Offset: 0x0007AF1C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_NestingNotSupported(op.OpType.ToString(), node.Op.OpType.ToString()));
				}
				if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Op).Var;
					if (this.m_definingNodeMap.ContainsKey(var))
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_NestingNotSupported(op.OpType.ToString(), node.Op.OpType.ToString()));
					}
				}
			}
			return this.VisitDefault(n);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0007CE24 File Offset: 0x0007B024
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var first = ((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Child0.Op).Outputs.First;
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs = ((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Child0.Op).Outputs;
			if (outputs.Count > 1)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(outputs.IsSet(first), "The constant var is not present after NestPull up over the input of ExistsOp.");
				outputs.Clear();
				outputs.Set(first);
			}
			return n;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0007CE91 File Offset: 0x0007B091
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.NestingNotSupported(op, n);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0007CE9C File Offset: 0x0007B09C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ApplyOpJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
				if (nestBaseOp != null)
				{
					num++;
					if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleStreamNest == node.Op.OpType)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1012));
					}
				}
			}
			if (num == 0)
			{
				return n;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in n.Children)
			{
				if (op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest && node2.Op.IsRelOp)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.KeyVec keyVec = this.Command.PullupKeys(node2);
					if (keyVec == null || keyVec.NoKeys)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_KeysRequiredForJoinOverNest(op.OpType.ToString()));
					}
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node3 in n.Children)
			{
				if (node3.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest)
				{
					list3.AddRange(((global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp)node3.Op).CollectionInfo);
					if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin || ((op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.OuterApply) && n.Child1.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest))
					{
						global::System.Data.Entity.Core.Query.InternalTrees.Var sentinelVar = null;
						list2.Add(this.AugmentNodeWithConstant(node3.Child0, () => this.Command.CreateNullSentinelOp(), out sentinelVar));
						foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in ((global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp)node3.Op).CollectionInfo)
						{
							this.m_definingNodeMap[collectionInfo.CollectionVar].Child0 = this.ApplyIsNotNullFilter(this.m_definingNodeMap[collectionInfo.CollectionVar].Child0, sentinelVar);
						}
						for (int i = 1; i < node3.Children.Count; i++)
						{
							global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.ApplyIsNotNullFilter(node3.Children[i], sentinelVar);
							list.Add(item);
						}
					}
					else
					{
						list2.Add(node3.Child0);
						for (int j = 1; j < node3.Children.Count; j++)
						{
							list.Add(node3.Children[j]);
						}
					}
				}
				else
				{
					list2.Add(node3);
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this.Command.CreateNode(op, list2);
			list.Insert(0, node4);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = node4.GetExtendedNodeInfo(this.Command);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec(extendedNodeInfo.Definitions);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo2 in list3)
			{
				varVec.Set(collectionInfo2.CollectionVar);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op2 = this.Command.CreateMultiStreamNestOp(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>(), varVec, list3);
			return this.Command.CreateNode(op2, list);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0007D280 File Offset: 0x0007B480
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ApplyIsNotNullFilter(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Var sentinelVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = node;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = null;
			while (node2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest)
			{
				node3 = node2;
				node2 = node2.Child0;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this.CapWithIsNotNullFilter(node2, sentinelVar);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (node3 != null)
			{
				node3.Child0 = node4;
				result = node;
			}
			else
			{
				result = node4;
			}
			return result;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0007D2C8 File Offset: 0x0007B4C8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CapWithIsNotNullFilter(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Query.InternalTrees.Var var)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.Command.CreateNode(this.Command.CreateVarRefOp(var));
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this.Command.CreateNode(this.Command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), this.Command.CreateNode(this.Command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), arg));
			return this.Command.CreateNode(this.Command.CreateFilterOp(), input, arg2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0007D337 File Offset: 0x0007B537
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.ApplyOpJoinOp(op, n);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0007D341 File Offset: 0x0007B541
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.NestingNotSupported(op, n);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0007D34C File Offset: 0x0007B54C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
			if (nestBaseOp != null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
				global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child0;
				n.Child0 = child2;
				child.Child0 = n;
				this.Command.RecomputeNodeInfo(n);
				this.Command.RecomputeNodeInfo(child);
				return child;
			}
			return n;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0007D3AB File Offset: 0x0007B5AB
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.NestingNotSupported(op, n);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0007D3B8 File Offset: 0x0007B5B8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.HasChild3 && n.Child3.Children.Count > 0, "GroupByIntoOp with no group aggregates?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child3;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars = this.Command.CreateVarVec(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs = op.Outputs;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in child.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				outputs.Clear(varDefOp.Var);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.Command.CreateNode(this.Command.CreateGroupByOp(op.Keys, outputs), n.Child0, n.Child1, n.Child2);
			global::System.Data.Entity.Core.Query.InternalTrees.Node n2 = this.Command.CreateNode(this.Command.CreateProjectOp(vars), arg, child);
			return base.VisitNode(n2);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007D4B8 File Offset: 0x0007B6B8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.ApplyOpJoinOp(op, n);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in ((global::System.Data.Entity.Core.Query.InternalTrees.SortOp)child.Op).Keys)
				{
					if (!this.Command.GetExtendedNodeInfo(child).ExternalReferences.IsSet(sortKey.Var))
					{
						op.Outputs.Set(sortKey.Var);
					}
				}
				n.Child0 = child.Child0;
				this.Command.RecomputeNodeInfo(n);
				child.Child0 = this.HandleProjectNode(n);
				this.Command.RecomputeNodeInfo(child);
				result = child;
			}
			else
			{
				result = this.HandleProjectNode(n);
			}
			return result;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node HandleProjectNode(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.ProjectOpCase1(n);
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project && global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(node.Child0))
			{
				node = this.ProjectOpCase2(node);
			}
			return this.MergeNestedNestOps(node);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0007D5FC File Offset: 0x0007B7FC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node MergeNestedNestOps(global::System.Data.Entity.Core.Query.InternalTrees.Node nestNode)
		{
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(nestNode) || !global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(nestNode.Child0))
			{
				return nestNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = (global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp)nestNode.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = nestNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp2 = (global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp)child.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in nestBaseOp.CollectionInfo)
			{
				varVec.Set(collectionInfo.CollectionVar);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.Command.CreateVarVec(nestBaseOp.Outputs);
			list.Add(child.Child0);
			for (int i = 1; i < child.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo2 = nestBaseOp2.CollectionInfo[i - 1];
				if (varVec.IsSet(collectionInfo2.CollectionVar) || varVec2.IsSet(collectionInfo2.CollectionVar))
				{
					list2.Add(collectionInfo2);
					list.Add(child.Children[i]);
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varVec2.IsSet(collectionInfo2.CollectionVar), "collectionVar not in output Vars?");
				}
			}
			for (int j = 1; j < nestNode.Children.Count; j++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo3 = nestBaseOp.CollectionInfo[j - 1];
				list2.Add(collectionInfo3);
				list.Add(nestNode.Children[j]);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varVec2.IsSet(collectionInfo3.CollectionVar), "collectionVar not in output Vars?");
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list3 = this.ConsolidateSortKeys(nestBaseOp.PrefixSortKeys, nestBaseOp2.PrefixSortKeys);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in list3)
			{
				varVec2.Set(sortKey.Var);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op = this.Command.CreateMultiStreamNestOp(list3, varVec2, list2);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.Command.CreateNode(op, list);
			this.Command.RecomputeNodeInfo(node);
			return node;
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0007D834 File Offset: 0x0007BA34
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProjectOpCase1(global::System.Data.Entity.Core.Query.InternalTrees.Node projectNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)projectNode.Op;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.Command.CreateVarVec();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in projectNode.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op;
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = node.Child0;
				if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect == child.Op.OpType)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(child.HasChild0, "collect without input?");
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject == child.Child0.Op.OpType, "collect without physicalProject?");
					global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child0;
					this.m_definingNodeMap.Add(varDefOp.Var, child2);
					this.ConvertToNestOpInput(child2, varDefOp.Var, collectionInfoList, list2, varVec, varVec2);
				}
				else if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef == child.Op.OpType)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)child.Op).Var;
					global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
					if (this.m_definingNodeMap.TryGetValue(var, out node2))
					{
						node2 = this.CopyCollectionVarDefinition(node2);
						this.m_definingNodeMap.Add(varDefOp.Var, node2);
						this.ConvertToNestOpInput(node2, varDefOp.Var, collectionInfoList, list2, varVec, varVec2);
					}
					else
					{
						list4.Add(node);
						list.Add(node);
					}
				}
				else
				{
					list3.Add(node);
					list.Add(node);
				}
			}
			if (list2.Count == 0)
			{
				return projectNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = this.Command.CreateVarVec(projectOp.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec4 = this.Command.CreateVarVec(projectOp.Outputs);
			varVec4.Minus(varVec2);
			varVec4.Or(varVec);
			if (!varVec4.IsEmpty)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(projectNode.Child0))
				{
					if (list3.Count == 0 && list4.Count == 0)
					{
						projectNode = projectNode.Child0;
						this.EnsureReferencedVarsAreRemoved(list4, varVec3);
					}
					else
					{
						global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = (global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp)projectNode.Child0.Op;
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list5 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
						list5.Add(projectNode.Child0.Child0);
						list4.AddRange(list3);
						list5.Add(this.Command.CreateNode(this.Command.CreateVarDefListOp(), list4));
						global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec5 = this.Command.CreateVarVec(nestBaseOp.Outputs);
						foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in nestBaseOp.CollectionInfo)
						{
							varVec5.Clear(collectionInfo.CollectionVar);
						}
						foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node3 in list4)
						{
							varVec5.Set(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node3.Op).Var);
						}
						global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.Command.CreateNode(this.Command.CreateProjectOp(varVec5), list5);
						global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec6 = this.Command.CreateVarVec(varVec5);
						varVec6.Or(nestBaseOp.Outputs);
						global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op = this.Command.CreateMultiStreamNestOp(nestBaseOp.PrefixSortKeys, varVec6, nestBaseOp.CollectionInfo);
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list6 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
						list6.Add(item);
						for (int i = 1; i < projectNode.Child0.Children.Count; i++)
						{
							list6.Add(projectNode.Child0.Children[i]);
						}
						projectNode = this.Command.CreateNode(op, list6);
					}
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this.Command.CreateProjectOp(varVec4);
					projectNode.Child1 = this.Command.CreateNode(projectNode.Child1.Op, list);
					projectNode.Op = op2;
					this.EnsureReferencedVarsAreRemapped(list4);
				}
			}
			else
			{
				projectNode = projectNode.Child0;
				this.EnsureReferencedVarsAreRemoved(list4, varVec3);
			}
			varVec.And(projectNode.GetExtendedNodeInfo(this.Command).Definitions);
			varVec3.Or(varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op3 = this.Command.CreateMultiStreamNestOp(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>(), varVec3, collectionInfoList);
			list2.Insert(0, projectNode);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this.Command.CreateNode(op3, list2);
			this.Command.RecomputeNodeInfo(projectNode);
			this.Command.RecomputeNodeInfo(node4);
			return node4;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0007DD08 File Offset: 0x0007BF08
		private void EnsureReferencedVarsAreRemoved(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> referencedVars, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in referencedVars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var;
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2 = this.ResolveVarReference(var);
				this.m_varRemapper.AddMapping(var, var2);
				outputVars.Clear(var);
				outputVars.Set(var2);
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0007DD84 File Offset: 0x0007BF84
		private void EnsureReferencedVarsAreRemapped(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> referencedVars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in referencedVars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var;
				global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar = this.ResolveVarReference(var);
				this.m_varRemapper.AddMapping(oldVar, var);
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
		private void ConvertToNestOpInput(global::System.Data.Entity.Core.Query.InternalTrees.Node physicalProjectNode, global::System.Data.Entity.Core.Query.InternalTrees.Var collectionVar, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> collectionNodes, global::System.Data.Entity.Core.Query.InternalTrees.VarVec externalReferences, global::System.Data.Entity.Core.Query.InternalTrees.VarVec collectionReferences)
		{
			externalReferences.Or(this.Command.GetNodeInfo(physicalProjectNode).ExternalReferences);
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = physicalProjectNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)physicalProjectNode.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(physicalProjectOp.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec(varList);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = null;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort == child.Op.OpType)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SortOp sortOp = (global::System.Data.Entity.Core.Query.InternalTrees.SortOp)child.Op;
				list = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this.Command, sortOp.Keys);
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey = enumerator.Current;
						if (!varVec.IsSet(sortKey.Var))
						{
							varList.Add(sortKey.Var);
							varVec.Set(sortKey.Var);
						}
					}
					goto IL_D4;
				}
			}
			list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			IL_D4:
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars = this.Command.GetExtendedNodeInfo(child).Keys.KeyVars;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = keyVars.Clone();
			varVec2.Minus(varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys = varVec2.IsEmpty ? keyVars.Clone() : this.Command.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateCollectionInfo(collectionVar, physicalProjectOp.ColumnMap.Element, varList, keys, list, null);
			collectionInfoList.Add(item);
			collectionNodes.Add(child);
			collectionReferences.Set(collectionVar);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0007DF58 File Offset: 0x0007C158
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ProjectOpCase2(global::System.Data.Entity.Core.Query.InternalTrees.Node projectNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)projectNode.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = projectNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in nestBaseOp.CollectionInfo)
			{
				varVec.Set(collectionInfo.CollectionVar);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.Command.CreateVarVec(nestBaseOp.Outputs);
			varVec2.Minus(varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = this.Command.CreateVarVec(projectOp.Outputs);
			varVec3.Minus(varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec4 = this.Command.CreateVarVec(projectOp.Outputs);
			varVec4.Minus(varVec3);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec5 = this.Command.CreateVarVec(varVec);
			varVec5.Minus(varVec4);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> list;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			if (varVec5.IsEmpty)
			{
				list = nestBaseOp.CollectionInfo;
				list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(node.Children);
			}
			else
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
				list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				list2.Add(node.Child0);
				int num = 1;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo2 in nestBaseOp.CollectionInfo)
				{
					if (!varVec5.IsSet(collectionInfo2.CollectionVar))
					{
						list.Add(collectionInfo2);
						list2.Add(node.Children[num]);
					}
					num++;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec6 = this.Command.CreateVarVec();
			for (int i = 1; i < node.Children.Count; i++)
			{
				varVec6.Or(node.Children[i].GetExtendedNodeInfo(this.Command).ExternalReferences);
			}
			varVec6.And(node.Child0.GetExtendedNodeInfo(this.Command).Definitions);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec7 = this.Command.CreateVarVec(varVec3);
			varVec7.Or(varVec2);
			varVec7.Or(varVec6);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(projectNode.Child1.Children.Count);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in projectNode.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node2.Op;
				if (varVec7.IsSet(varDefOp.Var))
				{
					list3.Add(node2);
				}
			}
			if (list.Count != 0 && varVec7.IsEmpty)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list3.Count == 0, "outputs is empty with non-zero count of children?");
				global::System.Data.Entity.Core.Query.InternalTrees.NullOp op = this.Command.CreateNullOp(this.Command.StringType);
				global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.Command.CreateNode(op);
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.Command.CreateVarDefNode(definingExpr, out v);
				list3.Add(item);
				varVec7.Set(v);
			}
			projectNode.Op = this.Command.CreateProjectOp(this.Command.CreateVarVec(varVec7));
			projectNode.Child1 = this.Command.CreateNode(projectNode.Child1.Op, list3);
			if (list.Count == 0)
			{
				projectNode.Child0 = node.Child0;
				node = projectNode;
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec8 = this.Command.CreateVarVec(projectOp.Outputs);
				for (int j = 1; j < list2.Count; j++)
				{
					varVec8.Or(list2[j].GetNodeInfo(this.Command).ExternalReferences);
				}
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in nestBaseOp.PrefixSortKeys)
				{
					varVec8.Set(sortKey.Var);
				}
				node.Op = this.Command.CreateMultiStreamNestOp(nestBaseOp.PrefixSortKeys, varVec8, list);
				node = this.Command.CreateNode(node.Op, list2);
				projectNode.Child0 = node.Child0;
				node.Child0 = projectNode;
				this.Command.RecomputeNodeInfo(projectNode);
			}
			this.Command.RecomputeNodeInfo(node);
			return node;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.NestingNotSupported(op, n);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0007E3C4 File Offset: 0x0007C5C4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			if (global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(n.Child0))
			{
				n = n.Child0;
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = this.Command.CreateNode(op, n.Child0);
				n.Child0 = child;
				this.Command.RecomputeNodeInfo(n);
			}
			return n;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0007E414 File Offset: 0x0007C614
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
			if (nestBaseOp != null)
			{
				n.Child0.Op = this.GetNestOpWithConsolidatedSortKeys(nestBaseOp, op.Keys);
				return n.Child0;
			}
			return n;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0007E468 File Offset: 0x0007C668
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
			if (nestBaseOp != null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
				n.Child0 = child.Child0;
				child.Child0 = n;
				child.Op = this.GetNestOpWithConsolidatedSortKeys(nestBaseOp, op.Keys);
				n = child;
			}
			return n;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0007E4C4 File Offset: 0x0007C6C4
		private global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp GetNestOpWithConsolidatedSortKeys(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp inputNestOp, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp result;
			if (inputNestOp.PrefixSortKeys.Count == 0)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys)
				{
					inputNestOp.PrefixSortKeys.Add(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(sortKey.Var, sortKey.AscendingSort, sortKey.Collation));
				}
				result = inputNestOp;
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys = this.ConsolidateSortKeys(sortKeys, inputNestOp.PrefixSortKeys);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputNestOp is global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp, "Unexpected SingleStreamNestOp?");
				result = this.Command.CreateMultiStreamNestOp(prefixSortKeys, inputNestOp.Outputs, inputNestOp.CollectionInfo);
			}
			return result;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0007E57C File Offset: 0x0007C77C
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> ConsolidateSortKeys(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeyList1, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeyList2)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeyList1)
			{
				if (!varVec.IsSet(sortKey.Var))
				{
					varVec.Set(sortKey.Var);
					list.Add(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(sortKey.Var, sortKey.AscendingSort, sortKey.Collation));
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey2 in sortKeyList2)
			{
				if (!varVec.IsSet(sortKey2.Var))
				{
					varVec.Set(sortKey2.Var);
					list.Add(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(sortKey2.Var, sortKey2.AscendingSort, sortKey2.Collation));
				}
			}
			return list;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0007E680 File Offset: 0x0007C880
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef, "Un-nest without VarDef input?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)n.Child0.Op).Var == op.Var, "Un-nest var not found?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Child0.HasChild0, "VarDef without input?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Child0.Child0;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function == node.Op.OpType)
			{
				return n;
			}
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect == node.Op.OpType)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.HasChild0, "collect without input?");
				node = node.Child0;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "collect without physicalProject?");
				this.m_definingNodeMap.Add(op.Var, node);
			}
			else
			{
				if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef != node.Op.OpType)
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.InvalidInternalTree, 2, node.Op.OpType);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Op).Var;
				global::System.Data.Entity.Core.Query.InternalTrees.Node refVarDefiningNode;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_definingNodeMap.TryGetValue(var, out refVarDefiningNode), "Could not find a definition for a referenced collection var");
				node = this.CopyCollectionVarDefinition(refVarDefiningNode);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "driving node is not physicalProject?");
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> outputs = ((global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)node.Op).Outputs;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.HasChild0, "physicalProject without input?");
			node = node.Child0;
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort)
			{
				this.m_foundSortUnderUnnest = true;
			}
			this.UpdateReplacementVarMap(op.Table.Columns, outputs);
			return node;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0007E828 File Offset: 0x0007CA28
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CopyCollectionVarDefinition(global::System.Data.Entity.Core.Query.InternalTrees.Node refVarDefiningNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = global::System.Data.Entity.Core.Query.PlanCompiler.OpCopierTrackingCollectionVars.Copy(this.Command, refVarDefiningNode, out varMap, out dictionary);
			if (dictionary.Count != 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarMap reverseMap = varMap.GetReverseMap();
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> keyValuePair in dictionary)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var key = reverseMap[keyValuePair.Key];
					global::System.Data.Entity.Core.Query.InternalTrees.Node node;
					if (this.m_definingNodeMap.TryGetValue(key, out node))
					{
						global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)node.Op;
						global::System.Data.Entity.Core.Query.InternalTrees.VarList outputVars = global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper.RemapVarList(this.Command, varMap, physicalProjectOp.Outputs);
						global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap)global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier.Copy(physicalProjectOp.ColumnMap, varMap);
						global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op = this.Command.CreatePhysicalProjectOp(outputVars, columnMap);
						global::System.Data.Entity.Core.Query.InternalTrees.Node value = this.Command.CreateNode(op, keyValuePair.Value);
						this.m_definingNodeMap.Add(keyValuePair.Key, value);
					}
				}
			}
			return result;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007E930 File Offset: 0x0007CB30
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>.Enumerator enumerator = n.Children.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(enumerator.Current))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1002));
					}
				}
			}
			return n;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0007E9A0 File Offset: 0x0007CBA0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Children.Count == 1, "multiple inputs to physicalProject?");
			this.VisitChildren(n);
			this.m_varRemapper.RemapNode(n);
			if (n != this.Command.Root || !global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.IsNestOpNode(n.Child0))
			{
				return n;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Child0;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(from v in op.Outputs
			where v.VarType == global::System.Data.Entity.Core.Query.InternalTrees.VarType.Parameter
			select v);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keys;
			node = this.ConvertToSingleStreamNest(node, dictionary, varList, out keys);
			global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp ssnOp = (global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp)node.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = this.BuildSortForNestElimination(ssnOp, node);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap simpleCollectionColumnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap)global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(((global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)n.Op).ColumnMap, dictionary);
			simpleCollectionColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(simpleCollectionColumnMap.Type, simpleCollectionColumnMap.Name, simpleCollectionColumnMap.Element, keys, null);
			n.Op = this.Command.CreatePhysicalProjectOp(varList, simpleCollectionColumnMap);
			n.Child0 = child;
			return n;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0007EAB0 File Offset: 0x0007CCB0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildSortForNestElimination(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp ssnOp, global::System.Data.Entity.Core.Query.InternalTrees.Node nestNode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = this.BuildSortKeyList(ssnOp);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (list.Count > 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SortOp op = this.Command.CreateSortOp(list);
				result = this.Command.CreateNode(op, nestNode.Child0);
			}
			else
			{
				result = nestNode.Child0;
			}
			return result;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0007EAF8 File Offset: 0x0007CCF8
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> BuildSortKeyList(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp ssnOp)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in ssnOp.PrefixSortKeys)
			{
				if (!varVec.IsSet(sortKey.Var))
				{
					varVec.Set(sortKey.Var);
					list.Add(sortKey);
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in ssnOp.Keys)
			{
				if (!varVec.IsSet(v))
				{
					varVec.Set(v);
					global::System.Data.Entity.Core.Query.InternalTrees.SortKey item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(v);
					list.Add(item);
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!varVec.IsSet(ssnOp.Discriminator), "prefix sort on discriminator?");
			list.Add(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(ssnOp.Discriminator));
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey2 in ssnOp.PostfixSortKeys)
			{
				if (!varVec.IsSet(sortKey2.Var))
				{
					varVec.Set(sortKey2.Var);
					list.Add(sortKey2);
				}
			}
			return list;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0007EC60 File Offset: 0x0007CE60
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ConvertToSingleStreamNest(global::System.Data.Entity.Core.Query.InternalTrees.Node nestNode, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> varRefReplacementMap, global::System.Data.Entity.Core.Query.InternalTrees.VarList flattenedOutputVarList, out global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] parentKeyColumnMaps)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp multiStreamNestOp = (global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp)nestNode.Op;
			for (int i = 1; i < nestNode.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = nestNode.Children[i];
				if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo = multiStreamNestOp.CollectionInfo[i - 1];
					global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
					global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array;
					nestNode.Children[i] = this.ConvertToSingleStreamNest(node, varRefReplacementMap, varList, out array);
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(collectionInfo.ColumnMap, varRefReplacementMap);
					global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys = this.Command.CreateVarVec(((global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp)nestNode.Children[i].Op).Keys);
					multiStreamNestOp.CollectionInfo[i - 1] = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateCollectionInfo(collectionInfo.CollectionVar, columnMap, varList, keys, collectionInfo.SortKeys, null);
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = nestNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.KeyVec keyVec = this.Command.PullupKeys(child);
			if (keyVec.NoKeys)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_KeysRequiredForNesting);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList2 = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(this.Command.GetExtendedNodeInfo(child).Definitions);
			global::System.Data.Entity.Core.Query.InternalTrees.VarList discriminatorVarList;
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>> list;
			this.NormalizeNestOpInputs(multiStreamNestOp, nestNode, out discriminatorVarList, out list);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>> list2;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.BuildUnionAllSubqueryForNestOp(multiStreamNestOp, nestNode, varList2, discriminatorVarList, out var, out list2);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> dictionary = list2[0];
			flattenedOutputVarList.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapVars(varList2, dictionary));
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec(flattenedOutputVarList);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.Command.CreateVarVec(varVec);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in dictionary)
			{
				if (keyValuePair.Key != keyValuePair.Value)
				{
					varRefReplacementMap[keyValuePair.Key] = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(keyValuePair.Value);
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapSortKeys(multiStreamNestOp.PrefixSortKeys, dictionary);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap discriminator = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(var);
			varVec2.Set(var);
			if (!varVec.IsSet(var))
			{
				flattenedOutputVarList.Add(var);
				varVec.Set(var);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = this.RemapVarVec(keyVec.KeyVars, dictionary);
			parentKeyColumnMaps = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[varVec3.Count];
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var2 in varVec3)
			{
				parentKeyColumnMaps[num] = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(var2);
				num++;
				if (!varVec.IsSet(var2))
				{
					flattenedOutputVarList.Add(var2);
					varVec.Set(var2);
				}
			}
			for (int j = 1; j < nestNode.Children.Count; j++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo2 = multiStreamNestOp.CollectionInfo[j - 1];
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list5 = list[j];
				global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapSortKeys(list5, list2[j]);
				list3.AddRange(list5);
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(collectionInfo2.ColumnMap, list2[j]);
				global::System.Data.Entity.Core.Query.InternalTrees.VarList varList3 = global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapVarList(collectionInfo2.FlattenedElementVars, list2[j]);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys2 = this.RemapVarVec(collectionInfo2.Keys, list2[j]);
				global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.RemapSortKeys(collectionInfo2.SortKeys, list2[j]);
				global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo3 = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateCollectionInfo(collectionInfo2.CollectionVar, columnMap2, varList3, keys2, collectionInfo2.SortKeys, j);
				list4.Add(collectionInfo3);
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var3 in varList3)
				{
					if (!varVec.IsSet(var3))
					{
						flattenedOutputVarList.Add(var3);
						varVec.Set(var3);
					}
				}
				varVec2.Set(collectionInfo2.CollectionVar);
				int num2 = 0;
				global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] array2 = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[collectionInfo3.Keys.Count];
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in collectionInfo3.Keys)
				{
					array2[num2] = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(v);
					num2++;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap value = new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.CreateCollectionType(collectionInfo3.ColumnMap.Type), collectionInfo3.ColumnMap.Name, collectionInfo3.ColumnMap, array2, parentKeyColumnMaps, discriminator, collectionInfo3.DiscriminatorValue);
				varRefReplacementMap[collectionInfo2.CollectionVar] = value;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op = this.Command.CreateSingleStreamNestOp(varVec3, multiStreamNestOp.PrefixSortKeys, list3, varVec2, list4, var);
			return this.Command.CreateNode(op, arg);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0007F12C File Offset: 0x0007D32C
		private void NormalizeNestOpInputs(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestOp, global::System.Data.Entity.Core.Query.InternalTrees.Node nestNode, out global::System.Data.Entity.Core.Query.InternalTrees.VarList discriminatorVarList, out global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>> sortKeys)
		{
			discriminatorVarList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			discriminatorVarList.Add(null);
			sortKeys = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>>();
			sortKeys.Add(nestOp.PrefixSortKeys);
			for (int i = 1; i < nestNode.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = nestNode.Children[i];
				global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp singleStreamNestOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp;
				if (singleStreamNestOp != null)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> item = this.BuildSortKeyList(singleStreamNestOp);
					sortKeys.Add(item);
					node = node.Child0;
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.SortOp sortOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.SortOp;
					if (sortOp != null)
					{
						node = node.Child0;
						sortKeys.Add(sortOp.Keys);
					}
					else
					{
						sortKeys.Add(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>());
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.VarList flattenedElementVars = nestOp.CollectionInfo[i - 1].FlattenedElementVars;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys[i])
				{
					if (!flattenedElementVars.Contains(sortKey.Var))
					{
						flattenedElementVars.Add(sortKey.Var);
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node value = this.AugmentNodeWithInternalIntegerConstant(node, i, out item2);
				nestNode.Children[i] = value;
				discriminatorVarList.Add(item2);
			}
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0007F280 File Offset: 0x0007D480
		private global::System.Data.Entity.Core.Query.InternalTrees.Node AugmentNodeWithInternalIntegerConstant(global::System.Data.Entity.Core.Query.InternalTrees.Node input, int value, out global::System.Data.Entity.Core.Query.InternalTrees.Var internalConstantVar)
		{
			return this.AugmentNodeWithConstant(input, () => this.Command.CreateInternalConstantOp(this.Command.IntegerType, value), out internalConstantVar);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0007F2B8 File Offset: 0x0007D4B8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node AugmentNodeWithConstant(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Func<global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp> createOp, out global::System.Data.Entity.Core.Query.InternalTrees.Var constantVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op = createOp();
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.Command.CreateNode(op);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.Command.CreateVarDefListNode(definingExpr, out constantVar);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.Command.GetExtendedNodeInfo(input);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.Command.CreateVarVec(extendedNodeInfo.Definitions);
			varVec.Set(constantVar);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this.Command.CreateProjectOp(varVec);
			return this.Command.CreateNode(op2, input, arg);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0007F330 File Offset: 0x0007D530
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildUnionAllSubqueryForNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestOp, global::System.Data.Entity.Core.Query.InternalTrees.Node nestNode, global::System.Data.Entity.Core.Query.InternalTrees.VarList drivingNodeVars, global::System.Data.Entity.Core.Query.InternalTrees.VarList discriminatorVarList, out global::System.Data.Entity.Core.Query.InternalTrees.Var discriminatorVar, out global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>> varMapList)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = nestNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = null;
			for (int i = 1; i < nestNode.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarList varList2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg;
				global::System.Data.Entity.Core.Query.InternalTrees.VarList collection;
				global::System.Data.Entity.Core.Query.InternalTrees.Op op;
				if (i > 1)
				{
					arg = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this.Command, child, drivingNodeVars, out varList2);
					global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper varRemapper = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(this.Command);
					for (int j = 0; j < drivingNodeVars.Count; j++)
					{
						varRemapper.AddMapping(drivingNodeVars[j], varList2[j]);
					}
					varRemapper.RemapSubtree(nestNode.Children[i]);
					collection = varRemapper.RemapVarList(nestOp.CollectionInfo[i - 1].FlattenedElementVars);
					op = this.Command.CreateCrossApplyOp();
				}
				else
				{
					arg = child;
					varList2 = drivingNodeVars;
					collection = nestOp.CollectionInfo[i - 1].FlattenedElementVars;
					op = this.Command.CreateOuterApplyOp();
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this.Command.CreateNode(op, arg, nestNode.Children[i]);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Data.Entity.Core.Query.InternalTrees.VarList varList3 = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
				varList3.Add(discriminatorVarList[i]);
				varList3.AddRange(varList2);
				for (int k = 1; k < nestNode.Children.Count; k++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo = nestOp.CollectionInfo[k - 1];
					if (i == k)
					{
						varList3.AddRange(collection);
					}
					else
					{
						foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in collectionInfo.FlattenedElementVars)
						{
							global::System.Data.Entity.Core.Query.InternalTrees.NullOp op2 = this.Command.CreateNullOp(var.Type);
							global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.Command.CreateNode(op2);
							global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
							global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.Command.CreateVarDefNode(definingExpr, out item2);
							list.Add(item);
							varList3.Add(item2);
						}
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = this.Command.CreateNode(this.Command.CreateVarDefListOp(), list);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars = this.Command.CreateVarVec(varList3);
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op3 = this.Command.CreateProjectOp(vars);
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.Command.CreateNode(op3, arg2, arg3);
				if (node == null)
				{
					node = node2;
					varList = varList3;
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
					global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
					for (int l = 0; l < varList.Count; l++)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.Var key = this.Command.CreateSetOpVar(varList[l].Type);
						varMap.Add(key, varList[l]);
						varMap2.Add(key, varList3[l]);
					}
					global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp unionAllOp = this.Command.CreateUnionAllOp(varMap, varMap2);
					node = this.Command.CreateNode(unionAllOp, node, node2);
					varList = global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.GetUnionOutputs(unionAllOp, varList);
				}
			}
			varMapList = new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>>();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator2 = varList.GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 4, null);
			}
			discriminatorVar = enumerator2.Current;
			for (int m = 0; m < nestNode.Children.Count; m++)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key2 in ((m == 0) ? drivingNodeVars : nestOp.CollectionInfo[m - 1].FlattenedElementVars))
				{
					if (!enumerator2.MoveNext())
					{
						throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 5, null);
					}
					dictionary[key2] = enumerator2.Current;
				}
				varMapList.Add(dictionary);
			}
			if (enumerator2.MoveNext())
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 6, null);
			}
			return node;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0007F708 File Offset: 0x0007D908
		private static global::System.Data.Entity.Core.Query.InternalTrees.VarList GetUnionOutputs(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp unionOp, global::System.Data.Entity.Core.Query.InternalTrees.VarList leftVars)
		{
			global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> reverseMap = unionOp.VarMap[0].GetReverseMap();
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in leftVars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item = reverseMap[key];
				varList.Add(item);
			}
			return varList;
		}

		// Token: 0x04000E2B RID: 3627
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000E2C RID: 3628
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_definingNodeMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>();

		// Token: 0x04000E2D RID: 3629
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper m_varRemapper;

		// Token: 0x04000E2E RID: 3630
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> m_varRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>();

		// Token: 0x04000E2F RID: 3631
		private bool m_foundSortUnderUnnest;
	}
}
