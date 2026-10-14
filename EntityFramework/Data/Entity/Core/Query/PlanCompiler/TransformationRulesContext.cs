using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036F RID: 879
	internal class TransformationRulesContext : global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0008B32C File Offset: 0x0008952C
		internal global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler PlanCompiler
		{
			get
			{
				return this.m_compilerState;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x0008B334 File Offset: 0x00089534
		internal bool ProjectionPruningRequired
		{
			get
			{
				return this.m_projectionPruningRequired;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x0008B33C File Offset: 0x0008953C
		internal bool ReapplyNullabilityRules
		{
			get
			{
				return this.m_reapplyNullabilityRules;
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0008B344 File Offset: 0x00089544
		internal void RemapSubtree(global::System.Data.Entity.Core.Query.InternalTrees.Node subTree)
		{
			this.m_remapper.RemapSubtree(subTree);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0008B352 File Offset: 0x00089552
		internal void AddVarMapping(global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar, global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			this.m_remapper.AddMapping(oldVar, newVar);
			this.m_remappedVars.Set(oldVar);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0008B370 File Offset: 0x00089570
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node ReMap(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.IsScalarOp, "Expected a scalarOp: Found " + global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString.ToString(node.Op.OpType));
			if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				for (int i = 0; i < node.Children.Count; i++)
				{
					node.Children[i] = this.ReMap(node.Children[i], varMap);
				}
				base.Command.RecomputeNodeInfo(node);
				return node;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = null;
			if (varMap.TryGetValue(varRefOp.Var, out node2))
			{
				node2 = this.Copy(node2);
				return node2;
			}
			return node;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0008B424 File Offset: 0x00089624
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
				return base.Command.CreateNode(base.Command.CreateVarRefOp(varRefOp.Var));
			}
			return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(base.Command, node);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0008B474 File Offset: 0x00089674
		internal bool IsScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			int num = 0;
			return this.IsScalarOpTree(node, null, ref num);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0008B490 File Offset: 0x00089690
		internal bool IsNonNullable(global::System.Data.Entity.Core.Query.InternalTrees.Var variable)
		{
			if (variable.VarType == global::System.Data.Entity.Core.Query.InternalTrees.VarType.Parameter && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(variable.Type))
			{
				return true;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n in this.m_relOpAncestors)
			{
				base.Command.RecomputeNodeInfo(n);
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = base.Command.GetExtendedNodeInfo(n);
				if (extendedNodeInfo.NonNullableVisibleDefinitions.IsSet(variable))
				{
					return true;
				}
				if (extendedNodeInfo.LocalDefinitions.IsSet(variable))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x0008B534 File Offset: 0x00089734
		internal bool CanChangeNullSentinelValue
		{
			get
			{
				if (this.m_compilerState.HasSortingOnNullSentinels)
				{
					return false;
				}
				if (this.m_relOpAncestors.Any((global::System.Data.Entity.Core.Query.InternalTrees.Node a) => global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.IsOpNotSafeForNullSentinelValueChange(a.Op.OpType)))
				{
					return false;
				}
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in from a in this.m_relOpAncestors
				where a.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply || a.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.OuterApply
				select a)
				{
					if (!this.m_relOpAncestors.Contains(node.Child1) && global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.HasOpNotSafeForNullSentinelValueChange(node.Child1))
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0008B604 File Offset: 0x00089804
		internal static bool IsOpNotSafeForNullSentinelValueChange(global::System.Data.Entity.Core.Query.InternalTrees.OpType optype)
		{
			return optype == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct || optype == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy || optype == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect || optype == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0008B61C File Offset: 0x0008981C
		internal static bool HasOpNotSafeForNullSentinelValueChange(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.IsOpNotSafeForNullSentinelValueChange(n.Op.OpType))
			{
				return true;
			}
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>.Enumerator enumerator = n.Children.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.HasOpNotSafeForNullSentinelValueChange(enumerator.Current))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0008B68C File Offset: 0x0008988C
		internal bool IsScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varRefMap != null, "Null varRef map");
			int num = 0;
			return this.IsScalarOpTree(node, varRefMap, ref num);
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0008B6B4 File Offset: 0x000898B4
		internal bool IncludeCustomFunctionOp(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap)
		{
			if (!this.m_compilerState.DisableFilterOverProjectionSimplificationForCustomFunctions)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varMap != null, "Null varRef map");
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Op;
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
				if (varMap.TryGetValue(varRefOp.Var, out node2))
				{
					return this.IncludeCustomFunctionOp(node2, varMap);
				}
			}
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function && !(node.Op as global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp).Function.BuiltInAttribute)
			{
				return true;
			}
			for (int i = 0; i < node.Children.Count; i++)
			{
				if (this.IncludeCustomFunctionOp(node.Children[i], varMap))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0008B768 File Offset: 0x00089968
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> GetVarMap(global::System.Data.Entity.Core.Query.InternalTrees.Node varDefListNode, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp varDefListOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp)varDefListNode.Op;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in varDefListNode.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op;
				int num = 0;
				int num2 = 0;
				if (!this.IsScalarOpTree(node.Child0, null, ref num))
				{
					return null;
				}
				if (num > 100 && varRefMap != null && varRefMap.TryGetValue(varDefOp.Var, out num2) && num2 > 2)
				{
					return null;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
				if (dictionary.TryGetValue(varDefOp.Var, out node2))
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node2 == node.Child0, "reusing varDef for different Node?");
				}
				else
				{
					dictionary.Add(varDefOp.Var, node.Child0);
				}
			}
			return dictionary;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0008B854 File Offset: 0x00089A54
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node BuildNullIfExpression(global::System.Data.Entity.Core.Query.InternalTrees.Var conditionVar, global::System.Data.Entity.Core.Query.InternalTrees.Node expr)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op = base.Command.CreateVarRefOp(conditionVar);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.Command.CreateNode(op);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.Command.CreateNode(base.Command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), arg);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.Command.CreateNode(base.Command.CreateNullOp(expr.Op.Type));
			return base.Command.CreateNode(base.Command.CreateCaseOp(expr.Op.Type), arg2, arg3, expr);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0008B8DF File Offset: 0x00089ADF
		internal void SuppressFilterPushdown(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_suppressions[n] = n;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0008B8EE File Offset: 0x00089AEE
		internal bool IsFilterPushdownSuppressed(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.m_suppressions.ContainsKey(n);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0008B8FC File Offset: 0x00089AFC
		internal static bool TryGetInt32Var(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> varList, out global::System.Data.Entity.Core.Query.InternalTrees.Var int32Var)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in varList)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
				if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(var.Type, out primitiveTypeKind) && primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32)
				{
					int32Var = var;
					return true;
				}
			}
			int32Var = null;
			return false;
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0008B960 File Offset: 0x00089B60
		internal TransformationRulesContext(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState) : base(compilerState.Command)
		{
			this.m_compilerState = compilerState;
			this.m_remapper = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(compilerState.Command);
			this.m_suppressions = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			this.m_remappedVars = compilerState.Command.CreateVarVec();
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0008B9B8 File Offset: 0x00089BB8
		internal override void PreProcess(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_remapper.RemapNode(n);
			base.Command.RecomputeNodeInfo(n);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0008B9D4 File Offset: 0x00089BD4
		internal override void PreProcessSubTree(global::System.Data.Entity.Core.Query.InternalTrees.Node subTree)
		{
			if (subTree.Op.IsRelOp)
			{
				this.m_relOpAncestors.Push(subTree);
			}
			if (this.m_remappedVars.IsEmpty)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in base.Command.GetNodeInfo(subTree).ExternalReferences)
			{
				if (this.m_remappedVars.IsSet(v))
				{
					this.m_remapper.RemapSubtree(subTree);
					break;
				}
			}
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0008BA68 File Offset: 0x00089C68
		internal override void PostProcessSubTree(global::System.Data.Entity.Core.Query.InternalTrees.Node subtree)
		{
			if (subtree.Op.IsRelOp)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_relOpAncestors.Count != 0, "The RelOp ancestors stack is empty when post processing a RelOp subtree");
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.m_relOpAncestors.Pop();
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(subtree == node, "The popped ancestor is not equal to the root of the subtree being post processed");
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0008BAB4 File Offset: 0x00089CB4
		internal override void PostProcess(global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Data.Entity.Core.Query.InternalTrees.Rule rule)
		{
			if (rule != null)
			{
				if (!this.m_projectionPruningRequired && global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.RulesRequiringProjectionPruning.Contains(rule))
				{
					this.m_projectionPruningRequired = true;
				}
				if (!this.m_reapplyNullabilityRules && global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.RulesRequiringNullabilityRulesToBeReapplied.Contains(rule))
				{
					this.m_reapplyNullabilityRules = true;
				}
				base.Command.RecomputeNodeInfo(n);
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0008BB08 File Offset: 0x00089D08
		internal override int GetHashCode(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return base.Command.GetNodeInfo(node).HashValue;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0008BB1C File Offset: 0x00089D1C
		private bool IsScalarOpTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap, ref int nonLeafNodeCount)
		{
			if (!node.Op.IsScalarOp)
			{
				return false;
			}
			if (node.HasChild0)
			{
				nonLeafNodeCount++;
			}
			if (varRefMap != null && node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)node.Op;
				int num;
				if (!varRefMap.TryGetValue(varRefOp.Var, out num))
				{
					num = 1;
				}
				else
				{
					num++;
				}
				varRefMap[varRefOp.Var] = num;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in node.Children)
			{
				if (!this.IsScalarOpTree(node2, varRefMap, ref nonLeafNodeCount))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000EBA RID: 3770
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000EBB RID: 3771
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper m_remapper;

		// Token: 0x04000EBC RID: 3772
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_suppressions;

		// Token: 0x04000EBD RID: 3773
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_remappedVars;

		// Token: 0x04000EBE RID: 3774
		private bool m_projectionPruningRequired;

		// Token: 0x04000EBF RID: 3775
		private bool m_reapplyNullabilityRules;

		// Token: 0x04000EC0 RID: 3776
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.Node> m_relOpAncestors = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
	}
}
