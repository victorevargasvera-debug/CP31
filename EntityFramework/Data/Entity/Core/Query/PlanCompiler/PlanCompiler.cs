using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Diagnostics;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000356 RID: 854
	internal class PlanCompiler
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x00083498 File Offset: 0x00081698
		private static bool applyTransformationsRegardlessOfSize
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._applyTransformationsRegardlessOfSize == null)
				{
					string value = global::System.Configuration.ConfigurationManager.AppSettings["EntityFramework_EntityClient_IgnoreOptimizationLimit"];
					bool flag;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._applyTransformationsRegardlessOfSize = new bool?(bool.TryParse(value, out flag) && flag);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._applyTransformationsRegardlessOfSize.Value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000834E0 File Offset: 0x000816E0
		private static bool disableTransformationsRegardlessOfSize
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._disableTransformationsRegardlessOfSize == null)
				{
					string value = global::System.Configuration.ConfigurationManager.AppSettings["EntityFramework_EntityClient_DisableOptimization"];
					bool flag;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._disableTransformationsRegardlessOfSize = new bool?(bool.TryParse(value, out flag) && flag);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._disableTransformationsRegardlessOfSize.Value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x00083528 File Offset: 0x00081728
		private static int maxNodeCountForTransformations
		{
			get
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._maxNodeCountForTransformations == null)
				{
					string s = global::System.Configuration.ConfigurationManager.AppSettings["EntityFramework_EntityClient_MaxNodeCountForTransformations"];
					int num;
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._maxNodeCountForTransformations = new int?(int.TryParse(s, out num) ? num : 10000);
				}
				return global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._maxNodeCountForTransformations.Value;
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00083577 File Offset: 0x00081777
		private PlanCompiler(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree ctree)
		{
			this.m_ctree = ctree;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00083586 File Offset: 0x00081786
		internal static void Assert(bool condition, string message)
		{
			if (!condition)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.AssertionFailed, 0, message);
			}
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00083598 File Offset: 0x00081798
		internal static void Compile(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree ctree, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo> providerCommands, out global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap resultColumnMap, out int columnCount, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(ctree != null, "Expected a valid, non-null Command Tree input");
			new global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler(ctree).Compile(out providerCommands, out resultColumnMap, out columnCount, out entitySets);
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x000835B8 File Offset: 0x000817B8
		internal global::System.Data.Entity.Core.Query.InternalTrees.Command Command
		{
			get
			{
				return this.m_command;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000835C0 File Offset: 0x000817C0
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x000835C8 File Offset: 0x000817C8
		internal bool HasSortingOnNullSentinels { get; set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000835D1 File Offset: 0x000817D1
		internal global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager ConstraintManager
		{
			get
			{
				if (this.m_constraintManager == null)
				{
					this.m_constraintManager = new global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager();
				}
				return this.m_constraintManager;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000835EC File Offset: 0x000817EC
		internal bool DisableFilterOverProjectionSimplificationForCustomFunctions
		{
			get
			{
				return this.m_ctree.DisableFilterOverProjectionSimplificationForCustomFunctions;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000835F9 File Offset: 0x000817F9
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this.m_ctree.MetadataWorkspace;
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00083606 File Offset: 0x00081806
		internal bool IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase phase)
		{
			return (this.m_neededPhases & 1 << (int)phase) != 0;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00083618 File Offset: 0x00081818
		internal void MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase phase)
		{
			this.m_neededPhases |= 1 << (int)phase;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0008362D File Offset: 0x0008182D
		internal bool IsAfterPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase phase)
		{
			return (this._precedingPhases & 1 << (int)phase) != 0;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00083640 File Offset: 0x00081840
		private void Compile(out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo> providerCommands, out global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap resultColumnMap, out int columnCount, out global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets)
		{
			this.Initialize();
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			string empty4 = string.Empty;
			string empty5 = string.Empty;
			string empty6 = string.Empty;
			string empty7 = string.Empty;
			string empty8 = string.Empty;
			string empty9 = string.Empty;
			string empty10 = string.Empty;
			string empty11 = string.Empty;
			string empty12 = string.Empty;
			string empty13 = string.Empty;
			string empty14 = string.Empty;
			string empty15 = string.Empty;
			this.m_neededPhases = 593;
			this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.PreProcessor);
			global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo structuredTypeInfo;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> tvfResultKeys;
			global::System.Data.Entity.Core.Query.PlanCompiler.PreProcessor.Process(this, out structuredTypeInfo, out tvfResultKeys);
			entitySets = structuredTypeInfo.GetEntitySets();
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.AggregatePushdown))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.AggregatePushdown);
				global::System.Data.Entity.Core.Query.PlanCompiler.AggregatePushdown.Process(this);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Normalization))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Normalization);
				global::System.Data.Entity.Core.Query.PlanCompiler.Normalizer.Process(this);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NTE))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NTE);
				global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.Process(this, structuredTypeInfo, tvfResultKeys);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.ProjectionPruning))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.ProjectionPruning);
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.Process(this);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NestPullup))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NestPullup);
				global::System.Data.Entity.Core.Query.PlanCompiler.NestPullup.Process(this);
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.ProjectionPruning);
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.Process(this);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Transformations) && this.ApplyTransformations(ref empty8, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.All))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.ProjectionPruning);
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.Process(this);
				this.ApplyTransformations(ref empty10, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.Project);
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NullSemantics))
			{
				this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NullSemantics);
				if (!this.m_ctree.UseDatabaseNullSemantics && global::System.Data.Entity.Core.Query.PlanCompiler.NullSemantics.Process(this.Command))
				{
					this.ApplyTransformations(ref empty12, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.NullSemantics);
				}
			}
			if (this.IsPhaseNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination))
			{
				for (int i = 0; i < 10; i++)
				{
					this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination);
					if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinElimination.Process(this) && !this.TransformationsDeferred)
					{
						break;
					}
					this.TransformationsDeferred = false;
					this.ApplyTransformations(ref empty14, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup.PostJoinElimination);
				}
			}
			this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.CodeGen);
			global::System.Data.Entity.Core.Query.PlanCompiler.CodeGen.Process(this, out providerCommands, out resultColumnMap, out columnCount);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0008380F File Offset: 0x00081A0F
		private bool ApplyTransformations(ref string dumpString, global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesGroup rulesGroup)
		{
			if (this.MayApplyTransformationRules)
			{
				dumpString = this.SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.Transformations);
				return global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRules.Process(this, rulesGroup);
			}
			return false;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0008382B File Offset: 0x00081A2B
		private string SwitchToPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase newPhase)
		{
			string empty = string.Empty;
			if (newPhase != this.m_phase)
			{
				this._precedingPhases |= 1 << (int)this.m_phase;
			}
			this.m_phase = newPhase;
			return empty;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0008385A File Offset: 0x00081A5A
		private bool MayApplyTransformationRules
		{
			get
			{
				if (this.m_mayApplyTransformationRules == null)
				{
					this.m_mayApplyTransformationRules = new bool?(this.ComputeMayApplyTransformations());
				}
				return this.m_mayApplyTransformationRules.Value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x00083885 File Offset: 0x00081A85
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x0008388D File Offset: 0x00081A8D
		internal bool TransformationsDeferred { get; set; }

		// Token: 0x06002968 RID: 10600 RVA: 0x00083898 File Offset: 0x00081A98
		private bool ComputeMayApplyTransformations()
		{
			return !global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.disableTransformationsRegardlessOfSize && (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.applyTransformationsRegardlessOfSize || global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler._legacyApplyTransformationsRegardlessOfSize.Enabled || this.m_command.NextNodeId < global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.maxNodeCountForTransformations || global::System.Data.Entity.Core.Query.InternalTrees.NodeCounter.Count(this.m_command.Root) < global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.maxNodeCountForTransformations);
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000838EC File Offset: 0x00081AEC
		private void Initialize()
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree = this.m_ctree as global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbQueryCommandTree != null, "Unexpected command tree kind. Only query command tree is supported.");
			this.m_command = global::System.Data.Entity.Core.Query.PlanCompiler.ITreeGenerator.Generate(dbQueryCommandTree);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_command != null, "Unable to generate internal tree from Command Tree");
		}

		// Token: 0x04000E3E RID: 3646
		private static readonly global::System.Diagnostics.BooleanSwitch _legacyApplyTransformationsRegardlessOfSize = new global::System.Diagnostics.BooleanSwitch("System.Data.Entity.Core.EntityClient.IgnoreOptimizationLimit", "The Entity Framework should try to optimize the query regardless of its size");

		// Token: 0x04000E3F RID: 3647
		private static bool? _applyTransformationsRegardlessOfSize;

		// Token: 0x04000E40 RID: 3648
		private static bool? _disableTransformationsRegardlessOfSize;

		// Token: 0x04000E41 RID: 3649
		private static int? _maxNodeCountForTransformations;

		// Token: 0x04000E42 RID: 3650
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree m_ctree;

		// Token: 0x04000E43 RID: 3651
		private global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x04000E44 RID: 3652
		private global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase m_phase;

		// Token: 0x04000E45 RID: 3653
		private int _precedingPhases;

		// Token: 0x04000E46 RID: 3654
		private int m_neededPhases;

		// Token: 0x04000E47 RID: 3655
		private global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager m_constraintManager;

		// Token: 0x04000E48 RID: 3656
		private bool? m_mayApplyTransformationRules;
	}
}
