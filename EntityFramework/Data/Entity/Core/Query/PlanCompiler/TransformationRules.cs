using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036E RID: 878
	internal static class TransformationRules
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0008AE20 File Offset: 0x00089020
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> AllRules
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules == null)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>();
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.SingleRowOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.SortOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ConstrainedSortOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.DistinctOpRules.Rules);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.allRules;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x0008AEEC File Offset: 0x000890EC
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> PostJoinEliminationRules
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules == null)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>();
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.DistinctOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rules);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules.AddRange(global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.NullabilityRules);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.postJoinEliminationRules;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x0008AF6C File Offset: 0x0008916C
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> NullabilityRules
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules == null)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>();
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverVarRef);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred1);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred2);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_SimplifyCase);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_NotOverConstantPred);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullabilityRules;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0008AFDC File Offset: 0x000891DC
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> NullSemanticsRules
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules == null)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>();
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverAnything);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_NullCast);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_EqualsOverConstant);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred1);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred2);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_OrOverConstantPred1);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_OrOverConstantPred2);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_NotOverConstantPred);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_LikeOverConstants);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_SimplifyCase);
					global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules.Add(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_FlattenCase);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.nullSemanticsRules;
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0008B0A8 File Offset: 0x000892A8
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> BuildLookupTableForRules(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Rule> rules)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule> readOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>(new global::System.Data.Entity.Core.Query.InternalTrees.Rule[0]);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>[] array = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>[73];
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Rule rule in rules)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> list = array[(int)rule.RuleOpType];
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule>();
					array[(int)rule.RuleOpType] = list;
				}
				list.Add(rule);
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>[] array2 = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					array2[i] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>(array[i].ToArray());
				}
				else
				{
					array2[i] = readOnlyCollection;
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>>(array2);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0008B168 File Offset: 0x00089368
		private static global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule> InitializeRulesRequiringProjectionPruning()
		{
			return new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule>
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverProject,
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverProject1,
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverProject2,
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverProject1,
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverProject2,
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_OuterJoinOverProject2,
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rule_ProjectWithNoLocalDefs,
				global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverProject,
				global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterWithConstantPredicate,
				global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOverProject,
				global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOpWithSimpleVarRedefinitions
			};
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0008B1FE File Offset: 0x000893FE
		private static global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule> InitializeRulesRequiringNullabilityRulesToBeReapplied()
		{
			return new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule>
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverLeftOuterJoin
			};
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0008B214 File Offset: 0x00089414
		internal static bool Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup rulesGroup)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> rulesTable = null;
			switch (rulesGroup)
			{
			case global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.All:
				rulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.AllRulesTable;
				break;
			case global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.Project:
				rulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.ProjectRulesTable;
				break;
			case global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.PostJoinElimination:
				rulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.PostJoinEliminationRulesTable;
				break;
			case global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.NullSemantics:
				rulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.NullSemanticsRulesTable;
				break;
			}
			bool flag;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.Process(compilerState, rulesTable, out flag))
			{
				bool flag2;
				global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.Process(compilerState, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.NullabilityRulesTable, out flag2);
				flag = (flag || flag2);
			}
			return flag;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0008B278 File Offset: 0x00089478
		private static bool Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> rulesTable, out bool projectionPruningRequired)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessor ruleProcessor = new global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessor();
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = new global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext(compilerState);
			compilerState.Command.Root = ruleProcessor.ApplyRulesToSubtree(transformationRulesContext, rulesTable, compilerState.Command.Root);
			projectionPruningRequired = transformationRulesContext.ProjectionPruningRequired;
			return transformationRulesContext.ReapplyNullabilityRules;
		}

		// Token: 0x04000EAF RID: 3759
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> AllRulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.BuildLookupTableForRules(global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.AllRules);

		// Token: 0x04000EB0 RID: 3760
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> ProjectRulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.BuildLookupTableForRules(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rules);

		// Token: 0x04000EB1 RID: 3761
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> PostJoinEliminationRulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.BuildLookupTableForRules(global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.PostJoinEliminationRules);

		// Token: 0x04000EB2 RID: 3762
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> NullabilityRulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.BuildLookupTableForRules(global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.NullabilityRules);

		// Token: 0x04000EB3 RID: 3763
		internal static readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule> RulesRequiringProjectionPruning = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.InitializeRulesRequiringProjectionPruning();

		// Token: 0x04000EB4 RID: 3764
		internal static readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Rule> RulesRequiringNullabilityRulesToBeReapplied = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.InitializeRulesRequiringNullabilityRulesToBeReapplied();

		// Token: 0x04000EB5 RID: 3765
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Query.InternalTrees.Rule>> NullSemanticsRulesTable = global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.BuildLookupTableForRules(global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.NullSemanticsRules);

		// Token: 0x04000EB6 RID: 3766
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> allRules;

		// Token: 0x04000EB7 RID: 3767
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> postJoinEliminationRules;

		// Token: 0x04000EB8 RID: 3768
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> nullabilityRules;

		// Token: 0x04000EB9 RID: 3769
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Rule> nullSemanticsRules;
	}
}
