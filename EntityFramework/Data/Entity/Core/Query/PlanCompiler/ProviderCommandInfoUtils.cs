using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000361 RID: 865
	internal static class ProviderCommandInfoUtils
	{
		// Token: 0x06002A1D RID: 10781 RVA: 0x00088440 File Offset: 0x00086640
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo Create(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(physicalProjectOp != null, "Expected root Op to be a physical Project");
			global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree dbCommandTree = global::System.Data.Entity.Core.Query.PlanCompiler.CTreeGenerator.Generate(command, node);
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree = dbCommandTree as global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dbQueryCommandTree != null, "null query command tree");
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(dbQueryCommandTree.Query.ResultType);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(edmType.TypeUsage), "command rowtype is not a record");
			global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfoUtils.BuildOutputVarMap(physicalProjectOp, edmType.TypeUsage);
			return new global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo(dbCommandTree);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000884BC File Offset: 0x000866BC
		private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> BuildOutputVarMap(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp projectOp, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage outputType)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(outputType), "PhysicalProjectOp result type is not a RowType?");
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(outputType).Properties.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator2 = projectOp.Outputs.GetEnumerator();
			for (;;)
			{
				bool flag = enumerator.MoveNext();
				bool flag2 = enumerator2.MoveNext();
				if (flag != flag2)
				{
					break;
				}
				if (!flag)
				{
					return dictionary;
				}
				dictionary[enumerator2.Current] = enumerator.Current;
			}
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.ColumnCountMismatch, 1, null);
		}
	}
}
