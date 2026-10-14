using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000649 RID: 1609
	internal static class CqlQuery
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00117610 File Offset: 0x00115810
		internal static global::System.Data.Entity.Core.Common.EntitySql.ParseResult Compile(string commandText, global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileCommon<global::System.Data.Entity.Core.Common.EntitySql.ParseResult>(commandText, parserOptions, (global::System.Data.Entity.Core.Common.EntitySql.AST.Node astCommand, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions validatedParserOptions) => global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.AnalyzeCommandSemantics(astCommand, perspective, validatedParserOptions, parameters));
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00117644 File Offset: 0x00115844
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda CompileQueryCommandLambda(string queryCommandText, global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileCommon<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(queryCommandText, parserOptions, (global::System.Data.Entity.Core.Common.EntitySql.AST.Node astCommand, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions validatedParserOptions) => global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.AnalyzeQueryExpressionSemantics(astCommand, perspective, validatedParserOptions, parameters, variables));
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00117680 File Offset: 0x00115880
		private static global::System.Data.Entity.Core.Common.EntitySql.AST.Node Parse(string commandText, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(commandText, "commandText");
			global::System.Data.Entity.Core.Common.EntitySql.AST.Node node = new global::System.Data.Entity.Core.Common.EntitySql.CqlParser(parserOptions, true).Parse(commandText);
			if (node == null)
			{
				throw global::System.Data.Entity.Core.EntitySqlException.Create(commandText, global::System.Data.Entity.Resources.Strings.InvalidEmptyQuery, 0, null, false, null);
			}
			return node;
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x001176BB File Offset: 0x001158BB
		private static TResult CompileCommon<TResult>(string commandText, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Func<global::System.Data.Entity.Core.Common.EntitySql.AST.Node, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions, TResult> compilationFunction) where TResult : class
		{
			parserOptions = (parserOptions ?? new global::System.Data.Entity.Core.Common.EntitySql.ParserOptions());
			return compilationFunction(global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.Parse(commandText, parserOptions), parserOptions);
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x001176D7 File Offset: 0x001158D7
		private static global::System.Data.Entity.Core.Common.EntitySql.ParseResult AnalyzeCommandSemantics(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.AnalyzeSemanticsCommon<global::System.Data.Entity.Core.Common.EntitySql.ParseResult>(astExpr, perspective, parserOptions, parameters, null, (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer analyzer, global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpression) => analyzer.AnalyzeCommand(astExpression));
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00117702 File Offset: 0x00115902
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda AnalyzeQueryExpressionSemantics(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astQueryCommand, global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.AnalyzeSemanticsCommon<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(astQueryCommand, perspective, parserOptions, parameters, variables, (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer analyzer, global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr) => analyzer.AnalyzeQueryCommand(astExpr));
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00117730 File Offset: 0x00115930
		private static TResult AnalyzeSemanticsCommon<TResult>(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> parameters, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables, global::System.Func<global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer, global::System.Data.Entity.Core.Common.EntitySql.AST.Node, TResult> analysisFunction) where TResult : class
		{
			TResult result = default(TResult);
			try
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer arg = new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.Create(perspective, parserOptions, parameters, variables));
				result = analysisFunction(arg, astExpr);
			}
			catch (global::System.Data.Entity.Core.MetadataException innerException)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.GeneralExceptionAsQueryInnerException("Metadata"), innerException);
			}
			catch (global::System.Data.Entity.Core.MappingException innerException2)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.GeneralExceptionAsQueryInnerException("Mapping"), innerException2);
			}
			return result;
		}
	}
}
