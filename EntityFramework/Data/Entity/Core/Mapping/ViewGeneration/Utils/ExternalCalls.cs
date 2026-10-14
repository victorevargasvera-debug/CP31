using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Utils
{
	// Token: 0x02000574 RID: 1396
	internal static class ExternalCalls
	{
		// Token: 0x060043EB RID: 17387 RVA: 0x000EBDF6 File Offset: 0x000E9FF6
		internal static bool IsReservedKeyword(string name)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsReservedKeyword(name);
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x000EBE00 File Offset: 0x000EA000
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree CompileView(string viewDef, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode compilationMode)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective = new global::System.Data.Entity.Core.Metadata.Edm.TargetPerspective(mappingItemCollection.Workspace);
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.Compile(viewDef, perspective, new global::System.Data.Entity.Core.Common.EntitySql.ParserOptions
			{
				ParserCompilationMode = compilationMode
			}, null).CommandTree;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x000EBE34 File Offset: 0x000EA034
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CompileFunctionView(string viewDef, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode compilationMode, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective = new global::System.Data.Entity.Core.Metadata.Edm.TargetPerspective(mappingItemCollection.Workspace);
			global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions = new global::System.Data.Entity.Core.Common.EntitySql.ParserOptions();
			parserOptions.ParserCompilationMode = compilationMode;
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileQueryCommandLambda(viewDef, perspective, parserOptions, null, from pInfo in parameters
			select pInfo.ResultType.Variable(pInfo.ParameterName)).Invoke(parameters);
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x000EBE90 File Offset: 0x000EA090
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda CompileFunctionDefinition(string functionDefinition, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> functionParameters, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective perspective = new global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective(new global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace(() => edmItemCollection, () => null, () => null));
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileQueryCommandLambda(functionDefinition, perspective, null, null, from pInfo in functionParameters
			select pInfo.TypeUsage.Variable(pInfo.Name));
		}
	}
}
