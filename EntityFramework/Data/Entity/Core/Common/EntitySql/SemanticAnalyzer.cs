using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066A RID: 1642
	internal sealed class SemanticAnalyzer
	{
		// Token: 0x06004E5B RID: 20059 RVA: 0x001184F9 File Offset: 0x001166F9
		internal SemanticAnalyzer(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			this._sr = sr;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x00118508 File Offset: 0x00116708
		internal global::System.Data.Entity.Core.Common.EntitySql.ParseResult AnalyzeCommand(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.Command command = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateQueryCommandAst(astExpr);
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertAndRegisterNamespaceImports(command.NamespaceImportList, command.ErrCtx, this._sr);
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertStatement(command.Statement, this._sr);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00118544 File Offset: 0x00116744
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbLambda AnalyzeQueryCommand(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.Command command = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateQueryCommandAst(astExpr);
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertAndRegisterNamespaceImports(command.NamespaceImportList, command.ErrCtx, this._sr);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> list;
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertQueryStatementToDbExpression(command.Statement, this._sr, out list), this._sr.Variables.Values);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00118598 File Offset: 0x00116798
		private static global::System.Data.Entity.Core.Common.EntitySql.AST.Command ValidateQueryCommandAst(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.Command command = astExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.Command;
			if (command == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnknownAstCommandExpression);
			}
			if (!(command.Statement is global::System.Data.Entity.Core.Common.EntitySql.AST.QueryStatement))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnknownAstExpressionType);
			}
			return command;
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x001185D4 File Offset: 0x001167D4
		private static void ConvertAndRegisterNamespaceImports(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport> nsImportList, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext cmdErrCtx, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Collections.Generic.List<global::System.Tuple<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>> list = new global::System.Collections.Generic.List<global::System.Tuple<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>> list2 = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>>();
			if (nsImportList != null)
			{
				foreach (global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport namespaceImport in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.AST.NamespaceImport>)nsImportList))
				{
					string[] array = null;
					global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = namespaceImport.NamespaceName as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
					if (identifier != null)
					{
						array = new string[]
						{
							identifier.Name
						};
					}
					global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = namespaceImport.NamespaceName as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
					if (dotExpr != null)
					{
						dotExpr.IsMultipartIdentifier(out array);
					}
					if (array == null)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = namespaceImport.NamespaceName.ErrCtx;
						string invalidMetadataMemberName = global::System.Data.Entity.Resources.Strings.InvalidMetadataMemberName;
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidMetadataMemberName, null);
					}
					string text = (namespaceImport.Alias != null) ? namespaceImport.Alias.Name : null;
					global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember = sr.ResolveMetadataMemberName(array, namespaceImport.NamespaceName.ErrCtx);
					if (metadataMember.MetadataMemberClass != global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Namespace)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = namespaceImport.NamespaceName.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidMetadataMemberClassResolution(metadataMember.Name, metadataMember.MetadataMemberClassName, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace.NamespaceClassName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage, null);
					}
					global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace metadataNamespace = (global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace)metadataMember;
					if (text != null)
					{
						list.Add(global::System.Tuple.Create<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>(text, metadataNamespace, namespaceImport.ErrCtx));
					}
					else
					{
						list2.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>(metadataNamespace, namespaceImport.ErrCtx));
					}
				}
			}
			sr.TypeResolver.AddNamespaceImport(new global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace("Edm"), (nsImportList != null) ? nsImportList.ErrCtx : cmdErrCtx);
			foreach (global::System.Tuple<string, global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext> tuple in list)
			{
				sr.TypeResolver.AddAliasedNamespaceImport(tuple.Item1, tuple.Item2, tuple.Item3);
			}
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Common.EntitySql.MetadataNamespace, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext> tuple2 in list2)
			{
				sr.TypeResolver.AddNamespaceImport(tuple2.Item1, tuple2.Item2);
			}
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x0011881C File Offset: 0x00116A1C
		private static global::System.Data.Entity.Core.Common.EntitySql.ParseResult ConvertStatement(global::System.Data.Entity.Core.Common.EntitySql.AST.Statement astStatement, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (astStatement is global::System.Data.Entity.Core.Common.EntitySql.AST.QueryStatement)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.StatementConverter statementConverter = new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.StatementConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertQueryStatementToDbCommandTree);
				return statementConverter(astStatement, sr);
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnknownAstExpressionType);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00118854 File Offset: 0x00116A54
		private static global::System.Data.Entity.Core.Common.EntitySql.ParseResult ConvertQueryStatementToDbCommandTree(global::System.Data.Entity.Core.Common.EntitySql.AST.Statement astStatement, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> functionDefs;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertQueryStatementToDbExpression(astStatement, sr, out functionDefs);
			return new global::System.Data.Entity.Core.Common.EntitySql.ParseResult(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(sr.TypeResolver.Perspective.MetadataWorkspace, sr.TypeResolver.Perspective.TargetDataspace, query, true, false), functionDefs);
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x0011889C File Offset: 0x00116A9C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertQueryStatementToDbExpression(global::System.Data.Entity.Core.Common.EntitySql.AST.Statement astStatement, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> functionDefs)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.QueryStatement queryStatement = astStatement as global::System.Data.Entity.Core.Common.EntitySql.AST.QueryStatement;
			if (queryStatement == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnknownAstExpressionType);
			}
			functionDefs = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertInlineFunctionDefinitions(queryStatement.FunctionDefList, sr);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(queryStatement.Expr, sr);
			if (dbExpression == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = queryStatement.Expr.ErrCtx;
				string resultingExpressionTypeCannotBeNull = global::System.Data.Entity.Resources.Strings.ResultingExpressionTypeCannotBeNull;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, resultingExpressionTypeCannotBeNull, null);
			}
			if (dbExpression is global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(sr.GenerateInternalName("extent"));
				dbExpression = dbExpressionBinding.Project(dbExpressionBinding.Variable);
			}
			if (sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.NormalMode)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateQueryResultType(dbExpression.ResultType, queryStatement.Expr.ErrCtx);
			}
			return dbExpression;
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00118940 File Offset: 0x00116B40
		private static void ValidateQueryResultType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(resultType.EdmType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateQueryResultType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)resultType.EdmType).TypeUsage, errCtx);
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(resultType.EdmType))
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)resultType.EdmType).Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = enumerator.Current;
						global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateQueryResultType(edmProperty.TypeUsage, errCtx);
					}
					return;
				}
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(resultType.EdmType))
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidQueryResultType(resultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x001189F8 File Offset: 0x00116BF8
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> ConvertInlineFunctionDefinitions(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition> functionDefList, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition>();
			if (functionDefList != null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo>();
				foreach (global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition functionDefinition in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition>)functionDefList))
				{
					string name = functionDefinition.Name;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> parameters = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertInlineFunctionParameterDefs(functionDefinition.Parameters, sr);
					global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo inlineFunctionInfo = new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.InlineFunctionInfoImpl(functionDefinition, parameters);
					list2.Add(inlineFunctionInfo);
					sr.TypeResolver.DeclareInlineFunction(name, inlineFunctionInfo);
				}
				foreach (global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo inlineFunctionInfo2 in list2)
				{
					list.Add(new global::System.Data.Entity.Core.Common.EntitySql.FunctionDefinition(inlineFunctionInfo2.FunctionDefAst.Name, inlineFunctionInfo2.GetLambda(sr), inlineFunctionInfo2.FunctionDefAst.StartPosition, inlineFunctionInfo2.FunctionDefAst.EndPosition));
				}
			}
			return list;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00118AF0 File Offset: 0x00116CF0
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> ConvertInlineFunctionParameterDefs(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition> parameterDefs, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>();
			if (parameterDefs != null)
			{
				foreach (global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition propDefinition in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.AST.PropDefinition>)parameterDefs))
				{
					string name = propDefinition.Name.Name;
					if (list.Exists((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression arg) => sr.NameComparer.Compare(arg.VariableName, name) == 0))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = propDefinition.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.MultipleDefinitionsOfParameter(name);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression item = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeDefinition(propDefinition.Type, sr), name);
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00118BD4 File Offset: 0x00116DD4
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda ConvertInlineFunctionDefinition(global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo functionInfo, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			sr.EnterScope();
			functionInfo.Parameters.Each((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression p) => sr.CurrentScope.Add(p.VariableName, new global::System.Data.Entity.Core.Common.EntitySql.FreeVariableScopeEntry(p)));
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(functionInfo.FunctionDefAst.Body, sr);
			sr.LeaveScope();
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(body, functionInfo.Parameters);
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x00118C3C File Offset: 0x00116E3C
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution Convert(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter astExprConverter = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer._astExprConverters[astExpr.GetType()];
			if (astExprConverter == null)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.UnknownAstExpressionType);
			}
			return astExprConverter(astExpr, sr);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x00118C64 File Offset: 0x00116E64
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertValueExpression(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(astExpr, sr);
			if (dbExpression == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astExpr.ErrCtx;
				string expressionCannotBeNull = global::System.Data.Entity.Resources.Strings.ExpressionCannotBeNull;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionCannotBeNull, null);
			}
			return dbExpression;
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x00118C90 File Offset: 0x00116E90
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertValueExpressionAllowUntypedNulls(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution expressionResolution = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.Convert(astExpr, sr);
			if (expressionResolution.ExpressionClass == global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.Value)
			{
				return ((global::System.Data.Entity.Core.Common.EntitySql.ValueExpression)expressionResolution).Value;
			}
			if (expressionResolution.ExpressionClass == global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.MetadataMember)
			{
				global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember = (global::System.Data.Entity.Core.Common.EntitySql.MetadataMember)expressionResolution;
				if (metadataMember.MetadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.EnumMember)
				{
					global::System.Data.Entity.Core.Common.EntitySql.MetadataEnumMember metadataEnumMember = (global::System.Data.Entity.Core.Common.EntitySql.MetadataEnumMember)metadataMember;
					return metadataEnumMember.EnumType.Constant(metadataEnumMember.EnumMember.Value);
				}
			}
			string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidExpressionResolutionClass(expressionResolution.ExpressionClassName, global::System.Data.Entity.Core.Common.EntitySql.ValueExpression.ValueClassName);
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = astExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			if (identifier != null)
			{
				errorMessage = global::System.Data.Entity.Resources.Strings.CouldNotResolveIdentifier(identifier.Name);
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = astExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
			string[] names;
			if (dotExpr != null && dotExpr.IsMultipartIdentifier(out names))
			{
				errorMessage = global::System.Data.Entity.Resources.Strings.CouldNotResolveIdentifier(global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(names));
			}
			throw global::System.Data.Entity.Core.EntitySqlException.Create(astExpr.ErrCtx, errorMessage, null);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00118D4C File Offset: 0x00116F4C
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertValueExpressionsWithUntypedNulls(global::System.Data.Entity.Core.Common.EntitySql.AST.Node leftAst, global::System.Data.Entity.Core.Common.EntitySql.AST.Node rightAst, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Func<string> formatMessage, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = (leftAst != null) ? global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(leftAst, sr) : null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = (rightAst != null) ? global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(rightAst, sr) : null;
			if (dbExpression == null)
			{
				if (dbExpression2 == null)
				{
					string errorMessage = formatMessage();
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				dbExpression = dbExpression2.ResultType.Null();
			}
			else if (dbExpression2 == null)
			{
				dbExpression2 = dbExpression.ResultType.Null();
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbExpression, dbExpression2);
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00118DB4 File Offset: 0x00116FB4
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertLiteral(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.Literal literal = (global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)expr;
			if (literal.IsNullLiteral)
			{
				return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(null);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GetLiteralTypeUsage(literal).Constant(literal.Value));
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00118DF0 File Offset: 0x00116FF0
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetLiteralTypeUsage(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal literal)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = null;
			if (!global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(literal.Type, out primitiveType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = literal.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.LiteralTypeNotFoundInMetadata(literal.OriginalValue);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetLiteralTypeUsage(primitiveType.PrimitiveTypeKind, literal.IsUnicodeString);
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00118E3E File Offset: 0x0011703E
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertIdentifier(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertIdentifier((global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier)expr, false, sr);
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00118E4D File Offset: 0x0011704D
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertIdentifier(global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier, bool leftHandSideOfMemberAccess, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			return sr.ResolveSimpleName(identifier.Name, leftHandSideOfMemberAccess, identifier.ErrCtx);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x00118E64 File Offset: 0x00117064
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertDotExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr)expr;
			global::System.Data.Entity.Core.Common.EntitySql.ValueExpression result;
			if (sr.TryResolveDotExprAsGroupKeyAlternativeName(dotExpr, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = dotExpr.Left as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution expressionResolution;
			if (identifier != null)
			{
				expressionResolution = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertIdentifier(identifier, true, sr);
			}
			else
			{
				expressionResolution = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.Convert(dotExpr.Left, sr);
			}
			switch (expressionResolution.ExpressionClass)
			{
			case global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.Value:
				return sr.ResolvePropertyAccess(((global::System.Data.Entity.Core.Common.EntitySql.ValueExpression)expressionResolution).Value, dotExpr.Identifier.Name, dotExpr.Identifier.ErrCtx);
			case global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.EntityContainer:
				return sr.ResolveEntityContainerMemberAccess(((global::System.Data.Entity.Core.Common.EntitySql.EntityContainerExpression)expressionResolution).EntityContainer, dotExpr.Identifier.Name, dotExpr.Identifier.ErrCtx);
			case global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.MetadataMember:
				return sr.ResolveMetadataMemberAccess((global::System.Data.Entity.Core.Common.EntitySql.MetadataMember)expressionResolution, dotExpr.Identifier.Name, dotExpr.Identifier.ErrCtx);
			default:
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = dotExpr.Left.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.UnknownExpressionResolutionClass(expressionResolution.ExpressionClass);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00118F61 File Offset: 0x00117161
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertParenExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(((global::System.Data.Entity.Core.Common.EntitySql.AST.ParenExpr)astExpr).Expr, sr));
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00118F7C File Offset: 0x0011717C
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertGroupPartitionExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.GroupPartitionExpr groupPartitionExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.GroupPartitionExpr)astExpr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = null;
			if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.TryConvertAsResolvedGroupAggregate(groupPartitionExpr, sr, out value))
			{
				if (!sr.IsInAnyGroupScope())
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astExpr.ErrCtx;
					string groupPartitionOutOfContext = global::System.Data.Entity.Resources.Strings.GroupPartitionOutOfContext;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, groupPartitionOutOfContext, null);
				}
				global::System.Data.Entity.Core.Common.EntitySql.GroupPartitionInfo groupPartitionInfo;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
				using (sr.EnterGroupPartition(groupPartitionExpr, groupPartitionExpr.ErrCtx, out groupPartitionInfo))
				{
					dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(groupPartitionExpr.ArgExpr, sr);
				}
				if (dbExpression == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = groupPartitionExpr.ArgExpr.ErrCtx;
					string resultingExpressionTypeCannotBeNull = global::System.Data.Entity.Resources.Strings.ResultingExpressionTypeCannotBeNull;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, resultingExpressionTypeCannotBeNull, null);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = groupPartitionInfo.EvaluatingScopeRegion.GroupAggregateBinding.Project(dbExpression);
				if (groupPartitionExpr.DistinctKind == global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.Distinct)
				{
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateDistinctProjection(dbExpression2.ResultType, groupPartitionExpr.ArgExpr.ErrCtx, null);
					dbExpression2 = dbExpression2.Distinct();
				}
				groupPartitionInfo.AttachToAstNode(sr.GenerateInternalName("groupPartition"), dbExpression2);
				groupPartitionInfo.EvaluatingScopeRegion.GroupAggregateInfos.Add(groupPartitionInfo);
				value = groupPartitionInfo.AggregateStubExpression;
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00119088 File Offset: 0x00117288
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertMethodExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMethodExpr((global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr)expr, true, sr);
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00119098 File Offset: 0x00117298
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertMethodExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, bool includeInlineFunctions, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution expressionResolution;
			using (sr.TypeResolver.EnterFunctionNameResolution(includeInlineFunctions))
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = methodExpr.Expr as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
				if (identifier != null)
				{
					expressionResolution = sr.ResolveSimpleFunctionName(identifier.Name, identifier.ErrCtx);
				}
				else
				{
					global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr leftExpr = methodExpr.Expr as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
					using (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMethodExpr_TryEnterIgnoreEntityContainerNameResolution(leftExpr, sr))
					{
						using (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMethodExpr_TryEnterV1ViewGenBackwardCompatibilityResolution(leftExpr, sr))
						{
							expressionResolution = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.Convert(methodExpr.Expr, sr);
						}
					}
				}
			}
			if (expressionResolution.ExpressionClass != global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolutionClass.MetadataMember)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string methodInvocationNotSupported = global::System.Data.Entity.Resources.Strings.MethodInvocationNotSupported;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, methodInvocationNotSupported, null);
			}
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember = (global::System.Data.Entity.Core.Common.EntitySql.MetadataMember)expressionResolution;
			if (metadataMember.MetadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.InlineFunctionGroup)
			{
				methodExpr.ErrCtx.ErrorContextInfo = global::System.Data.Entity.Resources.Strings.CtxFunction(metadataMember.Name);
				methodExpr.ErrCtx.UseContextInfoAsResourceIdentifier = false;
				global::System.Data.Entity.Core.Common.EntitySql.ValueExpression result;
				if (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.TryConvertInlineFunctionCall((global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup)metadataMember, methodExpr, sr, out result))
				{
					return result;
				}
				return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMethodExpr(methodExpr, false, sr);
			}
			else
			{
				global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass metadataMemberClass = metadataMember.MetadataMemberClass;
				if (metadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Type)
				{
					methodExpr.ErrCtx.ErrorContextInfo = global::System.Data.Entity.Resources.Strings.CtxTypeCtor(metadataMember.Name);
					methodExpr.ErrCtx.UseContextInfoAsResourceIdentifier = false;
					return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeConstructorCall((global::System.Data.Entity.Core.Common.EntitySql.MetadataType)metadataMember, methodExpr, sr);
				}
				if (metadataMemberClass != global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.FunctionGroup)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = methodExpr.Expr.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.CannotResolveNameToTypeOrFunction(metadataMember.Name);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage, null);
				}
				methodExpr.ErrCtx.ErrorContextInfo = global::System.Data.Entity.Resources.Strings.CtxFunction(metadataMember.Name);
				methodExpr.ErrCtx.UseContextInfoAsResourceIdentifier = false;
				return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertModelFunctionCall((global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup)metadataMember, methodExpr, sr);
			}
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x0011925C File Offset: 0x0011745C
		private static global::System.IDisposable ConvertMethodExpr_TryEnterIgnoreEntityContainerNameResolution(global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr leftExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (leftExpr == null || !(leftExpr.Left is global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier))
			{
				return null;
			}
			return sr.EnterIgnoreEntityContainerNameResolution();
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00119278 File Offset: 0x00117478
		private static global::System.IDisposable ConvertMethodExpr_TryEnterV1ViewGenBackwardCompatibilityResolution(global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr leftExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (leftExpr != null && leftExpr.Left is global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier && (sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode || sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.UserViewGenerationMode) && (sr.TypeResolver.Perspective.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace) as global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection).MappingVersion < 2.0)
			{
				return sr.TypeResolver.EnterBackwardCompatibilityResolution();
			}
			return null;
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x001192EC File Offset: 0x001174EC
		private static bool TryConvertInlineFunctionCall(global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionGroup inlineFunctionGroup, global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Data.Entity.Core.Common.EntitySql.ValueExpression inlineFunctionCall)
		{
			inlineFunctionCall = null;
			if (methodExpr.DistinctKind != global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.None)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertFunctionArguments(methodExpr.Args, sr, out argTypes);
			bool flag = false;
			global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo inlineFunctionInfo = global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ResolveFunctionOverloads<global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(inlineFunctionGroup.FunctionMetadata, argTypes, (global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo lambdaOverload) => lambdaOverload.Parameters, (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef) => varRef.ResultType, (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef) => global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In, false, out flag);
			if (flag)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string ambiguousFunctionArguments = global::System.Data.Entity.Resources.Strings.AmbiguousFunctionArguments;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, ambiguousFunctionArguments, null);
			}
			if (inlineFunctionInfo == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertUntypedNullsInArguments<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(list, inlineFunctionInfo.Parameters, (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression formal) => formal.ResultType);
			inlineFunctionCall = new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(inlineFunctionInfo.GetLambda(sr).Invoke(list));
			return true;
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x001193E4 File Offset: 0x001175E4
		private static global::System.Data.Entity.Core.Common.EntitySql.ValueExpression ConvertTypeConstructorCall(global::System.Data.Entity.Core.Common.EntitySql.MetadataType metadataType, global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(metadataType.TypeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(metadataType.TypeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRelationshipType(metadataType.TypeUsage))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidCtorUseOnType(metadataType.TypeUsage.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (metadataType.TypeUsage.EdmType.Abstract)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = methodExpr.ErrCtx;
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.CannotInstantiateAbstractType(metadataType.TypeUsage.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
			}
			if (methodExpr.DistinctKind != global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.None)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = methodExpr.ErrCtx;
				string invalidDistinctArgumentInCtor = global::System.Data.Entity.Resources.Strings.InvalidDistinctArgumentInCtor;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, invalidDistinctArgumentInCtor, null);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> list = null;
			if (methodExpr.HasRelationships)
			{
				if (sr.ParserOptions.ParserCompilationMode != global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode && sr.ParserOptions.ParserCompilationMode != global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.UserViewGenerationMode)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = methodExpr.Relationships.ErrCtx;
					string invalidModeForWithRelationshipClause = global::System.Data.Entity.Resources.Strings.InvalidModeForWithRelationshipClause;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, invalidModeForWithRelationshipClause, null);
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = metadataType.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
				if (entityType == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = methodExpr.Relationships.ErrCtx;
					string invalidTypeForWithRelationshipClause = global::System.Data.Entity.Resources.Strings.InvalidTypeForWithRelationshipClause;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, invalidTypeForWithRelationshipClause, null);
				}
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(methodExpr.Relationships.Count);
				for (int i = 0; i < methodExpr.Relationships.Count; i++)
				{
					global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr relshipNavigationExpr = methodExpr.Relationships[i];
					global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertRelatedEntityRef(relshipNavigationExpr, entityType, sr);
					string text = string.Join(":", new string[]
					{
						dbRelatedEntityRef.TargetEnd.DeclaringType.Identity,
						dbRelatedEntityRef.TargetEnd.Identity
					});
					if (hashSet.Contains(text))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = relshipNavigationExpr.ErrCtx;
						string errorMessage3 = global::System.Data.Entity.Resources.Strings.RelationshipTargetMustBeUnique(text);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, errorMessage3, null);
					}
					hashSet.Add(text);
					list.Add(dbRelatedEntityRef);
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list2;
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateConstructorCallExpression(methodExpr, metadataType.TypeUsage, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertFunctionArguments(methodExpr.Args, sr, out list2), list, sr));
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x001195E4 File Offset: 0x001177E4
		private static global::System.Data.Entity.Core.Common.EntitySql.ValueExpression ConvertModelFunctionCall(global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup, global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (metadataFunctionGroup.FunctionMetadata.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmFunction f) => !f.IsComposableAttribute))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.CannotCallNoncomposableFunction(metadataFunctionGroup.Name);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsAggregateFunction(metadataFunctionGroup.FunctionMetadata[0]) && sr.IsInAnyGroupScope())
			{
				return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertAggregateFunctionInGroupScope(methodExpr, metadataFunctionGroup, sr));
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateModelFunctionCallExpression(methodExpr, metadataFunctionGroup, sr));
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00119670 File Offset: 0x00117870
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertAggregateFunctionInGroupScope(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = null;
			if (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.TryConvertAsResolvedGroupAggregate(methodExpr, sr, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion innermostReferencedScopeRegion = (sr.CurrentGroupAggregateInfo != null) ? sr.CurrentGroupAggregateInfo.InnermostReferencedScopeRegion : null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes;
			if (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.TryConvertAsCollectionFunction(methodExpr, metadataFunctionGroup, sr, out argTypes, out result))
			{
				return result;
			}
			if (sr.CurrentGroupAggregateInfo != null)
			{
				sr.CurrentGroupAggregateInfo.InnermostReferencedScopeRegion = innermostReferencedScopeRegion;
			}
			if (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.TryConvertAsFunctionAggregate(methodExpr, metadataFunctionGroup, argTypes, sr, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
			string errorMessage = global::System.Data.Entity.Resources.Strings.FailedToResolveAggregateFunction(metadataFunctionGroup.Name);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x001196F0 File Offset: 0x001178F0
		private static bool TryConvertAsResolvedGroupAggregate(global::System.Data.Entity.Core.Common.EntitySql.AST.GroupAggregateExpr groupAggregateExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression converted)
		{
			converted = null;
			if (groupAggregateExpr.AggregateInfo == null)
			{
				return false;
			}
			groupAggregateExpr.AggregateInfo.SetContainingAggregate(sr.CurrentGroupAggregateInfo);
			if (!sr.TryResolveInternalAggregateName(groupAggregateExpr.AggregateInfo.AggregateName, groupAggregateExpr.AggregateInfo.ErrCtx, out converted))
			{
				converted = groupAggregateExpr.AggregateInfo.AggregateStubExpression;
			}
			return true;
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00119748 File Offset: 0x00117948
		private static bool TryConvertAsCollectionFunction(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression converted)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertFunctionArguments(methodExpr.Args, sr, out argTypes);
			bool flag = false;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ResolveFunctionOverloads(metadataFunctionGroup.FunctionMetadata, argTypes, false, out flag);
			if (flag)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string ambiguousFunctionArguments = global::System.Data.Entity.Resources.Strings.AmbiguousFunctionArguments;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, ambiguousFunctionArguments, null);
			}
			if (edmFunction != null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertUntypedNullsInArguments<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(list, edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter) => parameter.TypeUsage);
				converted = edmFunction.Invoke(list);
				return true;
			}
			converted = null;
			return false;
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x001197CC File Offset: 0x001179CC
		private static bool TryConvertAsFunctionAggregate(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression converted)
		{
			converted = null;
			bool flag = false;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ResolveFunctionOverloads(metadataFunctionGroup.FunctionMetadata, argTypes, true, out flag);
			if (flag)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string ambiguousFunctionArguments = global::System.Data.Entity.Resources.Strings.AmbiguousFunctionArguments;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, ambiguousFunctionArguments, null);
			}
			if (edmFunction == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportFunctionOverloadError(methodExpr, metadataFunctionGroup.FunctionMetadata[0], argTypes);
			}
			global::System.Data.Entity.Core.Common.EntitySql.FunctionAggregateInfo functionAggregateInfo;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list;
			using (sr.EnterFunctionAggregate(methodExpr, methodExpr.ErrCtx, out functionAggregateInfo))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list2;
				list = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertFunctionArguments(methodExpr.Args, sr, out list2);
			}
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertUntypedNullsInArguments<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(list, edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter) => global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(parameter.TypeUsage));
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate aggregateDefinition;
			if (methodExpr.DistinctKind == global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.Distinct)
			{
				aggregateDefinition = edmFunction.AggregateDistinct(list);
			}
			else
			{
				aggregateDefinition = edmFunction.Aggregate(list);
			}
			functionAggregateInfo.AttachToAstNode(sr.GenerateInternalName("groupAgg" + edmFunction.Name), aggregateDefinition);
			functionAggregateInfo.EvaluatingScopeRegion.GroupAggregateInfos.Add(functionAggregateInfo);
			converted = functionAggregateInfo.AggregateStubExpression;
			return true;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x001198E0 File Offset: 0x00117AE0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateConstructorCallExpression(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relshipExprList, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			int num = 0;
			int count = args.Count;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)type.EdmType;
			foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(structuralType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember);
				if (count <= num)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.NumberOfTypeCtorIsLessThenFormalSpec(edmMember.Name);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				if (args[num] == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
					if (edmProperty != null && !edmProperty.Nullable)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = methodExpr.Args[num].ErrCtx;
						string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidNullLiteralForNonNullableMember(edmMember.Name, structuralType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
					}
					args[num] = modelTypeUsage.Null();
				}
				bool flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(args[num].ResultType, modelTypeUsage);
				if (global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode == sr.ParserOptions.ParserCompilationMode || global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.UserViewGenerationMode == sr.ParserOptions.ParserCompilationMode)
				{
					if (!flag && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(modelTypeUsage, args[num].ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = methodExpr.Args[num].ErrCtx;
						string errorMessage3 = global::System.Data.Entity.Resources.Strings.InvalidCtorArgumentType(args[num].ResultType.EdmType.FullName, edmMember.Name, modelTypeUsage.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage3, null);
					}
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(modelTypeUsage.EdmType) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(args[num].ResultType, modelTypeUsage))
					{
						args[num] = args[num].CastTo(modelTypeUsage);
					}
				}
				else if (!flag)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = methodExpr.Args[num].ErrCtx;
					string errorMessage4 = global::System.Data.Entity.Resources.Strings.InvalidCtorArgumentType(args[num].ResultType.EdmType.FullName, edmMember.Name, modelTypeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage4, null);
				}
				num++;
			}
			if (num != count)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = methodExpr.ErrCtx;
				string errorMessage5 = global::System.Data.Entity.Resources.Strings.NumberOfTypeCtorIsMoreThenFormalSpec(structuralType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, errorMessage5, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
			if (relshipExprList != null && relshipExprList.Count > 0)
			{
				result = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewEntityWithRelationshipsExpression((global::System.Data.Entity.Core.Metadata.Edm.EntityType)type.EdmType, args, relshipExprList);
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(type).New(args);
			}
			return result;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00119B5C File Offset: 0x00117D5C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CreateModelFunctionCallExpression(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr, global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			bool flag = false;
			if (methodExpr.DistinctKind != global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.None)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = methodExpr.ErrCtx;
				string invalidDistinctArgumentInNonAggFunction = global::System.Data.Entity.Resources.Strings.InvalidDistinctArgumentInNonAggFunction;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidDistinctArgumentInNonAggFunction, null);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertFunctionArguments(methodExpr.Args, sr, out argTypes);
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ResolveFunctionOverloads(metadataFunctionGroup.FunctionMetadata, argTypes, false, out flag);
			if (flag)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = methodExpr.ErrCtx;
				string ambiguousFunctionArguments = global::System.Data.Entity.Resources.Strings.AmbiguousFunctionArguments;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, ambiguousFunctionArguments, null);
			}
			if (edmFunction == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportFunctionOverloadError(methodExpr, metadataFunctionGroup.FunctionMetadata[0], argTypes);
			}
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertUntypedNullsInArguments<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(list, edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter) => parameter.TypeUsage);
			return edmFunction.Invoke(list);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00119C0C File Offset: 0x00117E0C
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertFunctionArguments(global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> astExprList, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			if (astExprList != null)
			{
				for (int i = 0; i < astExprList.Count; i++)
				{
					list.Add(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(astExprList[i], sr));
				}
			}
			argTypes = list.Select(delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression a)
			{
				if (a == null)
				{
					return null;
				}
				return a.ResultType;
			}).ToList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			return list;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00119C74 File Offset: 0x00117E74
		private static void ConvertUntypedNullsInArguments<TParameterMetadata>(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, global::System.Collections.Generic.IList<TParameterMetadata> parametersMetadata, global::System.Func<TParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> getParameterTypeUsage)
		{
			for (int i = 0; i < args.Count; i++)
			{
				if (args[i] == null)
				{
					args[i] = getParameterTypeUsage(parametersMetadata[i]).Null();
				}
			}
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00119CB4 File Offset: 0x00117EB4
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertParameter(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.QueryParameter queryParameter = (global::System.Data.Entity.Core.Common.EntitySql.AST.QueryParameter)expr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression value;
			if (sr.Parameters == null || !sr.Parameters.TryGetValue(queryParameter.Name, out value))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = queryParameter.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.ParameterWasNotDefined(queryParameter.Name);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x00119D08 File Offset: 0x00117F08
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef ConvertRelatedEntityRef(global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr relshipExpr, global::System.Data.Entity.Core.Metadata.Edm.EntityType driverEntityType, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(relshipExpr.TypeName, sr).EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType = edmType as global::System.Data.Entity.Core.Metadata.Edm.RelationshipType;
			if (relationshipType == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = relshipExpr.TypeName.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.RelationshipTypeExpected(edmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(relshipExpr.RefExpr, sr);
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = dbExpression.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
			if (refType == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = relshipExpr.RefExpr.ErrCtx;
				string relatedEndExprTypeMustBeReference = global::System.Data.Entity.Resources.Strings.RelatedEndExprTypeMustBeReference;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, relatedEndExprTypeMustBeReference, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd;
			if (relshipExpr.ToEndIdentifier != null)
			{
				toEnd = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmMember m) => m.Name.Equals(relshipExpr.ToEndIdentifier.Name, global::System.StringComparison.OrdinalIgnoreCase));
				if (toEnd == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = relshipExpr.ToEndIdentifier.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidRelationshipMember(relshipExpr.ToEndIdentifier.Name, relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
				}
				if (toEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && toEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = relshipExpr.ToEndIdentifier.ErrCtx;
					string errorMessage3 = global::System.Data.Entity.Resources.Strings.InvalidWithRelationshipTargetEndMultiplicity(toEnd.Name, toEnd.RelationshipMultiplicity.ToString());
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage3, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(refType, toEnd.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = relshipExpr.RefExpr.ErrCtx;
					string errorMessage4 = global::System.Data.Entity.Resources.Strings.RelatedEndExprTypeMustBePromotoableToToEnd(refType.FullName, toEnd.TypeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, errorMessage4, null);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember[] array = (from m in relationshipType.Members
				select (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)m into e
				where global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(refType, e.TypeUsage.EdmType) && (e.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One || e.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
				select e).ToArray<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>();
				int num = array.Length;
				if (num == 0)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = relshipExpr.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.InvalidImplicitRelationshipToEnd(relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, errorMessage5, null);
				}
				if (num != 1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = relshipExpr.ErrCtx;
					string relationshipToEndIsAmbiguos = global::System.Data.Entity.Resources.Strings.RelationshipToEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, relationshipToEndIsAmbiguos, null);
				}
				toEnd = array[0];
			}
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember;
			if (relshipExpr.FromEndIdentifier != null)
			{
				relationshipEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmMember m) => m.Name.Equals(relshipExpr.FromEndIdentifier.Name, global::System.StringComparison.OrdinalIgnoreCase));
				if (relationshipEndMember == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx8 = relshipExpr.FromEndIdentifier.ErrCtx;
					string errorMessage6 = global::System.Data.Entity.Resources.Strings.InvalidRelationshipMember(relshipExpr.FromEndIdentifier.Name, relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx8, errorMessage6, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(driverEntityType.GetReferenceType(), relationshipEndMember.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx9 = relshipExpr.FromEndIdentifier.ErrCtx;
					string errorMessage7 = global::System.Data.Entity.Resources.Strings.SourceTypeMustBePromotoableToFromEndRelationType(driverEntityType.FullName, relationshipEndMember.TypeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx9, errorMessage7, null);
				}
				if (relationshipEndMember.EdmEquals(toEnd))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx10 = relshipExpr.ErrCtx;
					string relationshipFromEndIsAmbiguos = global::System.Data.Entity.Resources.Strings.RelationshipFromEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx10, relationshipFromEndIsAmbiguos, null);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember[] array2 = (from m in relationshipType.Members
				select (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)m into e
				where global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(driverEntityType.GetReferenceType(), e.TypeUsage.EdmType) && !e.EdmEquals(toEnd)
				select e).ToArray<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>();
				int num = array2.Length;
				if (num == 0)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx11 = relshipExpr.ErrCtx;
					string errorMessage8 = global::System.Data.Entity.Resources.Strings.InvalidImplicitRelationshipFromEnd(relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx11, errorMessage8, null);
				}
				if (num != 1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx12 = relshipExpr.ErrCtx;
					string relationshipFromEndIsAmbiguos2 = global::System.Data.Entity.Resources.Strings.RelationshipFromEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx12, relationshipFromEndIsAmbiguos2, null);
				}
				relationshipEndMember = array2[0];
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRelatedEntityRef(relationshipEndMember, toEnd, dbExpression);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x0011A11C File Offset: 0x0011831C
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertRelshipNavigationExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr relshipExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr)astExpr;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(relshipExpr.TypeName, sr).EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType = edmType as global::System.Data.Entity.Core.Metadata.Edm.RelationshipType;
			if (relationshipType == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = relshipExpr.TypeName.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.RelationshipTypeExpected(edmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(relshipExpr.RefExpr, sr);
			global::System.Data.Entity.Core.Metadata.Edm.RefType sourceRefType = dbExpression.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
			if (sourceRefType == null)
			{
				if (!(dbExpression.ResultType.EdmType is global::System.Data.Entity.Core.Metadata.Edm.EntityType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = relshipExpr.RefExpr.ErrCtx;
					string relatedEndExprTypeMustBeReference = global::System.Data.Entity.Resources.Strings.RelatedEndExprTypeMustBeReference;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, relatedEndExprTypeMustBeReference, null);
				}
				dbExpression = dbExpression.GetEntityRef();
				sourceRefType = (global::System.Data.Entity.Core.Metadata.Edm.RefType)dbExpression.ResultType.EdmType;
			}
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd;
			if (relshipExpr.ToEndIdentifier != null)
			{
				toEnd = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmMember m) => m.Name.Equals(relshipExpr.ToEndIdentifier.Name, global::System.StringComparison.OrdinalIgnoreCase));
				if (toEnd == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = relshipExpr.ToEndIdentifier.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidRelationshipMember(relshipExpr.ToEndIdentifier.Name, relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
				}
			}
			else
			{
				toEnd = null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd;
			if (relshipExpr.FromEndIdentifier != null)
			{
				fromEnd = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmMember m) => m.Name.Equals(relshipExpr.FromEndIdentifier.Name, global::System.StringComparison.OrdinalIgnoreCase));
				if (fromEnd == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = relshipExpr.FromEndIdentifier.ErrCtx;
					string errorMessage3 = global::System.Data.Entity.Resources.Strings.InvalidRelationshipMember(relshipExpr.FromEndIdentifier.Name, relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage3, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(sourceRefType, fromEnd.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = relshipExpr.FromEndIdentifier.ErrCtx;
					string errorMessage4 = global::System.Data.Entity.Resources.Strings.SourceTypeMustBePromotoableToFromEndRelationType(sourceRefType.FullName, fromEnd.TypeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, errorMessage4, null);
				}
				if (toEnd != null && fromEnd.EdmEquals(toEnd))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = relshipExpr.ErrCtx;
					string relationshipFromEndIsAmbiguos = global::System.Data.Entity.Resources.Strings.RelationshipFromEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, relationshipFromEndIsAmbiguos, null);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember[] array = (from m in relationshipType.Members
				select (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)m into e
				where global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(sourceRefType, e.TypeUsage.EdmType) && (toEnd == null || !e.EdmEquals(toEnd))
				select e).ToArray<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>();
				int num = array.Length;
				if (num == 0)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = relshipExpr.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.InvalidImplicitRelationshipFromEnd(relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage5, null);
				}
				if (num != 1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx8 = relshipExpr.ErrCtx;
					string relationshipFromEndIsAmbiguos2 = global::System.Data.Entity.Resources.Strings.RelationshipFromEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx8, relationshipFromEndIsAmbiguos2, null);
				}
				fromEnd = array[0];
			}
			if (toEnd == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember[] array2 = (from m in relationshipType.Members
				select (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)m into e
				where !e.EdmEquals(fromEnd)
				select e).ToArray<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>();
				int num = array2.Length;
				if (num == 0)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx9 = relshipExpr.ErrCtx;
					string errorMessage6 = global::System.Data.Entity.Resources.Strings.InvalidImplicitRelationshipToEnd(relationshipType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx9, errorMessage6, null);
				}
				if (num != 1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx10 = relshipExpr.ErrCtx;
					string relationshipToEndIsAmbiguos = global::System.Data.Entity.Resources.Strings.RelationshipToEndIsAmbiguos;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx10, relationshipToEndIsAmbiguos, null);
				}
				toEnd = array2[0];
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(dbExpression.Navigate(fromEnd, toEnd));
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x0011A4D4 File Offset: 0x001186D4
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertRefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.RefExpr refExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.RefExpr)astExpr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(refExpr.ArgExpr, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = refExpr.ArgExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.RefArgIsNotOfEntityType(dbExpression.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			dbExpression = dbExpression.GetEntityRef();
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(dbExpression);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x0011A538 File Offset: 0x00118738
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertDeRefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.DerefExpr derefExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.DerefExpr)astExpr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(derefExpr.ArgExpr, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = derefExpr.ArgExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.DeRefArgIsNotOfRefType(dbExpression.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			dbExpression = dbExpression.Deref();
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(dbExpression);
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x0011A5A0 File Offset: 0x001187A0
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertCreateRefExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.CreateRefExpr createRefExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.CreateRefExpr)astExpr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression dbScanExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(createRefExpr.EntitySet, sr) as global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression;
			if (dbScanExpression == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = createRefExpr.EntitySet.ErrCtx;
				string exprIsNotValidEntitySetForCreateRef = global::System.Data.Entity.Resources.Strings.ExprIsNotValidEntitySetForCreateRef;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, exprIsNotValidEntitySetForCreateRef, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = dbScanExpression.Target as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			if (entitySet == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = createRefExpr.EntitySet.ErrCtx;
				string exprIsNotValidEntitySetForCreateRef2 = global::System.Data.Entity.Resources.Strings.ExprIsNotValidEntitySetForCreateRef;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, exprIsNotValidEntitySetForCreateRef2, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(createRefExpr.Keys, sr);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = dbExpression.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
			if (rowType == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = createRefExpr.Keys.ErrCtx;
				string invalidCreateRefKeyType = global::System.Data.Entity.Resources.Strings.InvalidCreateRefKeyType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, invalidCreateRefKeyType, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = global::System.Data.Entity.Core.Common.TypeHelpers.CreateKeyRowType(entitySet.ElementType);
			if (rowType2.Members.Count != rowType.Members.Count)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = createRefExpr.Keys.ErrCtx;
				string imcompatibleCreateRefKeyType = global::System.Data.Entity.Resources.Strings.ImcompatibleCreateRefKeyType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, imcompatibleCreateRefKeyType, null);
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(dbExpression.ResultType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(rowType2)))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = createRefExpr.Keys.ErrCtx;
				string imcompatibleCreateRefKeyElementType = global::System.Data.Entity.Resources.Strings.ImcompatibleCreateRefKeyElementType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, imcompatibleCreateRefKeyElementType, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value;
			if (createRefExpr.TypeIdentifier != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(createRefExpr.TypeIdentifier, sr);
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = createRefExpr.TypeIdentifier.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.CreateRefTypeIdentifierMustSpecifyAnEntityType(typeUsage.EdmType.FullName, typeUsage.EdmType.BuiltInTypeKind.ToString());
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, errorMessage, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(entitySet.ElementType, typeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = createRefExpr.TypeIdentifier.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.CreateRefTypeIdentifierMustBeASubOrSuperType(entitySet.ElementType.FullName, typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage2, null);
				}
				value = entitySet.RefFromKey(dbExpression, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)typeUsage.EdmType);
			}
			else
			{
				value = entitySet.RefFromKey(dbExpression);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x0011A78C File Offset: 0x0011898C
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertKeyExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.KeyExpr keyExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.KeyExpr)astExpr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(keyExpr.ArgExpr, sr);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(dbExpression.ResultType))
			{
				dbExpression = dbExpression.GetEntityRef();
			}
			else if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = keyExpr.ArgExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidKeyArgument(dbExpression.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			dbExpression = dbExpression.GetRefKey();
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(dbExpression);
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x0011A808 File Offset: 0x00118A08
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertBuiltIn(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr builtInExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr)astExpr;
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter builtInExprConverter = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer._builtInExprConverter[builtInExpr.Kind];
			if (builtInExprConverter == null)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.UnknownBuiltInAstExpressionType);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(builtInExprConverter(builtInExpr, sr));
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x0011A848 File Offset: 0x00118A48
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertArithmeticArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionsWithUntypedNulls(astBuiltInExpr.Arg1, astBuiltInExpr.Arg2, astBuiltInExpr.ErrCtx, () => global::System.Data.Entity.Resources.Strings.InvalidNullArithmetic, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(pair.Left.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.Arg1.ErrCtx;
				string expressionMustBeNumericType = global::System.Data.Entity.Resources.Strings.ExpressionMustBeNumericType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionMustBeNumericType, null);
			}
			if (pair.Right != null)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(pair.Right.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = astBuiltInExpr.Arg2.ErrCtx;
					string expressionMustBeNumericType2 = global::System.Data.Entity.Resources.Strings.ExpressionMustBeNumericType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, expressionMustBeNumericType2, null);
				}
				if (global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(pair.Left.ResultType, pair.Right.ResultType) == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = astBuiltInExpr.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.ArgumentTypesAreIncompatible(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage, null);
				}
			}
			return pair;
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x0011A94C File Offset: 0x00118B4C
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertPlusOperands(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionsWithUntypedNulls(astBuiltInExpr.Arg1, astBuiltInExpr.Arg2, astBuiltInExpr.ErrCtx, () => global::System.Data.Entity.Resources.Strings.InvalidNullArithmetic, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(pair.Left.ResultType) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(pair.Left.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.Arg1.ErrCtx;
				string plusLeftExpressionInvalidType = global::System.Data.Entity.Resources.Strings.PlusLeftExpressionInvalidType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, plusLeftExpressionInvalidType, null);
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(pair.Right.ResultType) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(pair.Right.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = astBuiltInExpr.Arg2.ErrCtx;
				string plusRightExpressionInvalidType = global::System.Data.Entity.Resources.Strings.PlusRightExpressionInvalidType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, plusRightExpressionInvalidType, null);
			}
			if (global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(pair.Left.ResultType, pair.Right.ResultType) == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = astBuiltInExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.ArgumentTypesAreIncompatible(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage, null);
			}
			return pair;
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x0011AA6C File Offset: 0x00118C6C
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertLogicalArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(astBuiltInExpr.Arg1, sr);
			if (dbExpression == null)
			{
				dbExpression = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.BooleanType.Null();
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = null;
			if (astBuiltInExpr.Arg2 != null)
			{
				dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(astBuiltInExpr.Arg2, sr);
				if (dbExpression2 == null)
				{
					dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.BooleanType.Null();
				}
			}
			if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsBooleanType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.Arg1.ErrCtx;
				string expressionTypeMustBeBoolean = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeBoolean;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionTypeMustBeBoolean, null);
			}
			if (dbExpression2 != null && !global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsBooleanType(dbExpression2.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = astBuiltInExpr.Arg2.ErrCtx;
				string expressionTypeMustBeBoolean2 = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeBoolean;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, expressionTypeMustBeBoolean2, null);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbExpression, dbExpression2);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x0011AB10 File Offset: 0x00118D10
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertEqualCompArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionsWithUntypedNulls(astBuiltInExpr.Arg1, astBuiltInExpr.Arg2, astBuiltInExpr.ErrCtx, () => global::System.Data.Entity.Resources.Strings.InvalidNullComparison, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparableTo(pair.Left.ResultType, pair.Right.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.ArgumentTypesAreIncompatible(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			return pair;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x0011ABB4 File Offset: 0x00118DB4
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertOrderCompArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionsWithUntypedNulls(astBuiltInExpr.Arg1, astBuiltInExpr.Arg2, astBuiltInExpr.ErrCtx, () => global::System.Data.Entity.Resources.Strings.InvalidNullComparison, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparableTo(pair.Left.ResultType, pair.Right.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.ArgumentTypesAreIncompatible(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			return pair;
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x0011AC58 File Offset: 0x00118E58
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertSetArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(astBuiltInExpr.Arg1, sr);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = null;
			if (astBuiltInExpr.Arg2 != null)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.Arg1.ErrCtx;
					string leftSetExpressionArgsMustBeCollection = global::System.Data.Entity.Resources.Strings.LeftSetExpressionArgsMustBeCollection;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, leftSetExpressionArgsMustBeCollection, null);
				}
				dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(astBuiltInExpr.Arg2, sr);
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression2.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = astBuiltInExpr.Arg2.ErrCtx;
					string rightSetExpressionArgsMustBeCollection = global::System.Data.Entity.Resources.Strings.RightSetExpressionArgsMustBeCollection;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, rightSetExpressionArgsMustBeCollection, null);
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression2.ResultType);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(elementTypeUsage, elementTypeUsage2, out typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportIncompatibleCommonType(astBuiltInExpr.ErrCtx, elementTypeUsage, elementTypeUsage2);
				}
				if (astBuiltInExpr.Kind != global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.UnionAll)
				{
					if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType)))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = astBuiltInExpr.Arg1.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.PlaceholderSetArgTypeIsNotEqualComparable(global::System.Data.Entity.Resources.Strings.LocalizedLeft, astBuiltInExpr.Kind.ToString().ToUpperInvariant(), global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType).EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage, null);
					}
					if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression2.ResultType)))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = astBuiltInExpr.Arg2.ErrCtx;
						string errorMessage2 = global::System.Data.Entity.Resources.Strings.PlaceholderSetArgTypeIsNotEqualComparable(global::System.Data.Entity.Resources.Strings.LocalizedRight, astBuiltInExpr.Kind.ToString().ToUpperInvariant(), global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression2.ResultType).EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage2, null);
					}
				}
				else
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(elementTypeUsage.EdmType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = astBuiltInExpr.Arg1.ErrCtx;
						string errorMessage3 = global::System.Data.Entity.Resources.Strings.InvalidAssociationTypeForUnion(elementTypeUsage.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, errorMessage3, null);
					}
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(elementTypeUsage2.EdmType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = astBuiltInExpr.Arg2.ErrCtx;
						string errorMessage4 = global::System.Data.Entity.Resources.Strings.InvalidAssociationTypeForUnion(elementTypeUsage2.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, errorMessage4, null);
					}
				}
			}
			else
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = astBuiltInExpr.Arg1.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.InvalidUnarySetOpArgument(astBuiltInExpr.Name);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage5, null);
				}
				if (astBuiltInExpr.Kind == global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Distinct && !global::System.Data.Entity.Core.Common.TypeHelpers.IsValidDistinctOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType)))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx8 = astBuiltInExpr.Arg1.ErrCtx;
					string expressionTypeMustBeEqualComparable = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeEqualComparable;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx8, expressionTypeMustBeEqualComparable, null);
				}
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbExpression, dbExpression2);
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x0011AEB0 File Offset: 0x001190B0
		private static global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> ConvertInExprArgs(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBuiltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(astBuiltInExpr.Arg2, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = astBuiltInExpr.Arg2.ErrCtx;
				string rightSetExpressionArgsMustBeCollection = global::System.Data.Entity.Resources.Strings.RightSetExpressionArgsMustBeCollection;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, rightSetExpressionArgsMustBeCollection, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(astBuiltInExpr.Arg1, sr);
			if (dbExpression2 == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType);
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateTypeForNullExpression(elementTypeUsage, astBuiltInExpr.Arg1.ErrCtx);
				dbExpression2 = elementTypeUsage.Null();
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression2.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = astBuiltInExpr.Arg1.ErrCtx;
				string expressionTypeMustNotBeCollection = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustNotBeCollection;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, expressionTypeMustNotBeCollection, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(dbExpression2.ResultType, global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType));
			if (commonTypeUsage == null || !global::System.Data.Entity.Core.Common.TypeHelpers.IsValidInOpType(commonTypeUsage))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = astBuiltInExpr.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidInExprArgs(dbExpression2.ResultType.EdmType.FullName, dbExpression.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage, null);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbExpression2, dbExpression);
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x0011AFAC File Offset: 0x001191AC
		private static void ValidateTypeForNullExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(type))
			{
				string nullLiteralCannotBePromotedToCollectionOfNulls = global::System.Data.Entity.Resources.Strings.NullLiteralCannotBePromotedToCollectionOfNulls;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, nullLiteralCannotBePromotedToCollectionOfNulls, null);
			}
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x0011AFD0 File Offset: 0x001191D0
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ConvertTypeName(global::System.Data.Entity.Core.Common.EntitySql.AST.Node typeName, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			string[] array = null;
			global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> nodeList = null;
			global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr methodExpr = typeName as global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr;
			if (methodExpr != null)
			{
				typeName = methodExpr.Expr;
				typeName.ErrCtx.ErrorContextInfo = methodExpr.ErrCtx.ErrorContextInfo;
				typeName.ErrCtx.UseContextInfoAsResourceIdentifier = methodExpr.ErrCtx.UseContextInfoAsResourceIdentifier;
				nodeList = methodExpr.Args;
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = typeName as global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier;
			if (identifier != null)
			{
				array = new string[]
				{
					identifier.Name
				};
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = typeName as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
			if (dotExpr != null)
			{
				dotExpr.IsMultipartIdentifier(out array);
			}
			if (array == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = typeName.ErrCtx;
				string invalidMetadataMemberName = global::System.Data.Entity.Resources.Strings.InvalidMetadataMemberName;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidMetadataMemberName, null);
			}
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMember metadataMember = sr.ResolveMetadataMemberName(array, typeName.ErrCtx);
			global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass metadataMemberClass = metadataMember.MetadataMemberClass;
			if (metadataMemberClass == global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Type)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = ((global::System.Data.Entity.Core.Common.EntitySql.MetadataType)metadataMember).TypeUsage;
				if (nodeList != null)
				{
					typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeSpecArgs(typeUsage, nodeList, typeName.ErrCtx);
				}
				return typeUsage;
			}
			if (metadataMemberClass != global::System.Data.Entity.Core.Common.EntitySql.MetadataMemberClass.Namespace)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = typeName.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidMetadataMemberClassResolution(metadataMember.Name, metadataMember.MetadataMemberClassName, global::System.Data.Entity.Core.Common.EntitySql.MetadataType.TypeClassName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage, null);
			}
			global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = typeName.ErrCtx;
			string errorMessage2 = global::System.Data.Entity.Resources.Strings.TypeNameNotFound(metadataMember.Name);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x0011B0FC File Offset: 0x001192FC
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ConvertTypeSpecArgs(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage parameterizedType, global::System.Data.Entity.Core.Common.EntitySql.AST.NodeList<global::System.Data.Entity.Core.Common.EntitySql.AST.Node> typeSpecArgs, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			foreach (global::System.Data.Entity.Core.Common.EntitySql.AST.Node node in ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.AST.Node>)typeSpecArgs))
			{
				if (!(node is global::System.Data.Entity.Core.Common.EntitySql.AST.Literal))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = node.ErrCtx;
					string typeArgumentMustBeLiteral = global::System.Data.Entity.Resources.Strings.TypeArgumentMustBeLiteral;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, typeArgumentMustBeLiteral, null);
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = parameterizedType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType == null || primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.TypeDoesNotSupportSpec(primitiveType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (typeSpecArgs.Count > 2)
			{
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.TypeArgumentCountMismatch(primitiveType.FullName, 2);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
			}
			byte b;
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeFacetValue(primitiveType, (global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)typeSpecArgs[0], "Precision", out b);
			byte b2 = 0;
			if (typeSpecArgs.Count == 2)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeFacetValue(primitiveType, (global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)typeSpecArgs[1], "Scale", out b2);
			}
			if (b < b2)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = typeSpecArgs[0].ErrCtx;
				string errorMessage3 = global::System.Data.Entity.Resources.Strings.PrecisionMustBeGreaterThanScale(b, b2);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage3, null);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDecimalTypeUsage(primitiveType, b, b2);
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0011B224 File Offset: 0x00119424
		private static void ConvertTypeFacetValue(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type, global::System.Data.Entity.Core.Common.EntitySql.AST.Literal value, string facetName, out byte byteValue)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facet = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(type.ProviderManifest.GetFacetDescriptions(type), facetName);
			if (facet == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = value.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.TypeDoesNotSupportFacet(type.FullName, facetName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (!value.IsNumber || !byte.TryParse(value.OriginalValue, out byteValue))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = value.ErrCtx;
				string typeArgumentIsNotValid = global::System.Data.Entity.Resources.Strings.TypeArgumentIsNotValid;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, typeArgumentIsNotValid, null);
			}
			if (facet.MaxValue != null && (int)byteValue > facet.MaxValue.Value)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = value.ErrCtx;
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.TypeArgumentExceedsMax(facetName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
			}
			if (facet.MinValue != null && (int)byteValue < facet.MinValue.Value)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = value.ErrCtx;
				string errorMessage3 = global::System.Data.Entity.Resources.Strings.TypeArgumentBelowMin(facetName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage3, null);
			}
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0011B300 File Offset: 0x00119500
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ConvertTypeDefinition(global::System.Data.Entity.Core.Common.EntitySql.AST.Node typeDefinitionExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.CollectionTypeDefinition collectionTypeDefinition = typeDefinitionExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.CollectionTypeDefinition;
			global::System.Data.Entity.Core.Common.EntitySql.AST.RefTypeDefinition refTypeDefinition = typeDefinitionExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.RefTypeDefinition;
			global::System.Data.Entity.Core.Common.EntitySql.AST.RowTypeDefinition rowTypeDefinition = typeDefinitionExpr as global::System.Data.Entity.Core.Common.EntitySql.AST.RowTypeDefinition;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (collectionTypeDefinition != null)
			{
				result = global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeDefinition(collectionTypeDefinition.ElementTypeDef, sr));
			}
			else if (refTypeDefinition != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(refTypeDefinition.RefTypeIdentifier, sr);
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = refTypeDefinition.RefTypeIdentifier.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.RefTypeIdentifierMustSpecifyAnEntityType(typeUsage.EdmType.FullName, typeUsage.EdmType.BuiltInTypeKind.ToString());
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				result = global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceTypeUsage((global::System.Data.Entity.Core.Metadata.Edm.EntityType)typeUsage.EdmType);
			}
			else if (rowTypeDefinition != null)
			{
				result = global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowTypeUsage(from p in rowTypeDefinition.Properties
				select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(p.Name.Name, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeDefinition(p.Type, sr)));
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(typeDefinitionExpr, sr);
			}
			return result;
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x0011B3F8 File Offset: 0x001195F8
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertRowConstructor(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.RowConstructorExpr rowConstructorExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.RowConstructorExpr)expr;
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(sr.NameComparer);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(rowConstructorExpr.AliasedExprList.Count);
			for (int i = 0; i < rowConstructorExpr.AliasedExprList.Count; i++)
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr = rowConstructorExpr.AliasedExprList[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(aliasedExpr.Expr, sr);
				if (dbExpression == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = aliasedExpr.Expr.ErrCtx;
					string rowCtorElementCannotBeNull = global::System.Data.Entity.Resources.Strings.RowCtorElementCannotBeNull;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, rowCtorElementCannotBeNull, null);
				}
				string text = sr.InferAliasName(aliasedExpr, dbExpression);
				if (dictionary.ContainsKey(text))
				{
					if (aliasedExpr.Alias != null)
					{
						global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(text, aliasedExpr.Alias.ErrCtx, global::System.Data.Entity.Resources.Strings.InRowCtor);
					}
					else
					{
						text = sr.GenerateInternalName("autoRowCol");
					}
				}
				dictionary.Add(text, dbExpression.ResultType);
				list.Add(dbExpression);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowTypeUsage(dictionary).New(list));
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0011B4F0 File Offset: 0x001196F0
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertMultisetConstructor(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.MultisetConstructorExpr multisetConstructorExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.MultisetConstructorExpr)expr;
			if (multisetConstructorExpr.ExprList == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = expr.ErrCtx;
				string cannotCreateEmptyMultiset = global::System.Data.Entity.Resources.Strings.CannotCreateEmptyMultiset;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, cannotCreateEmptyMultiset, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] array = (from e in multisetConstructorExpr.ExprList
			select global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(e, sr)).ToArray<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] array2 = (from e in array
			where e != null
			select e.ResultType).ToArray<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			if (array2.Length == 0)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = expr.ErrCtx;
				string cannotCreateMultisetofNulls = global::System.Data.Entity.Resources.Strings.CannotCreateMultisetofNulls;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, cannotCreateMultisetofNulls, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(array2);
			if (typeUsage == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = expr.ErrCtx;
				string multisetElemsAreNotTypeCompatible = global::System.Data.Entity.Resources.Strings.MultisetElemsAreNotTypeCompatible;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, multisetElemsAreNotTypeCompatible, null);
			}
			typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateTypeForNullExpression(typeUsage, multisetConstructorExpr.ExprList[i].ErrCtx);
					array[i] = typeUsage.Null();
				}
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(typeUsage).New(array));
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x0011B628 File Offset: 0x00119828
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertCaseExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.CaseExpr caseExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.CaseExpr)expr;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(caseExpr.WhenThenExprList.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(caseExpr.WhenThenExprList.Count);
			for (int i = 0; i < caseExpr.WhenThenExprList.Count; i++)
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.WhenThenExpr whenThenExpr = caseExpr.WhenThenExprList[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(whenThenExpr.WhenExpr, sr);
				if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsBooleanType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = whenThenExpr.WhenExpr.ErrCtx;
					string expressionTypeMustBeBoolean = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeBoolean;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionTypeMustBeBoolean, null);
				}
				list.Add(dbExpression);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(whenThenExpr.ThenExpr, sr);
				list2.Add(item);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = (caseExpr.ElseExpr != null) ? global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(caseExpr.ElseExpr, sr) : null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list3 = (from e in list2
			where e != null
			select e.ResultType).ToList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			if (dbExpression2 != null)
			{
				list3.Add(dbExpression2.ResultType);
			}
			if (list3.Count == 0)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = caseExpr.ElseExpr.ErrCtx;
				string invalidCaseWhenThenNullType = global::System.Data.Entity.Resources.Strings.InvalidCaseWhenThenNullType;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, invalidCaseWhenThenNullType, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(list3);
			if (commonTypeUsage == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = caseExpr.WhenThenExprList[0].ThenExpr.ErrCtx;
				string invalidCaseResultTypes = global::System.Data.Entity.Resources.Strings.InvalidCaseResultTypes;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, invalidCaseResultTypes, null);
			}
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateTypeForNullExpression(commonTypeUsage, caseExpr.WhenThenExprList[j].ThenExpr.ErrCtx);
					list2[j] = commonTypeUsage.Null();
				}
			}
			if (dbExpression2 == null)
			{
				if (caseExpr.ElseExpr == null && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(commonTypeUsage))
				{
					dbExpression2 = commonTypeUsage.NewEmptyCollection();
				}
				else
				{
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateTypeForNullExpression(commonTypeUsage, (caseExpr.ElseExpr ?? caseExpr).ErrCtx);
					dbExpression2 = commonTypeUsage.Null();
				}
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list, list2, dbExpression2));
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x0011B844 File Offset: 0x00119A44
		private static global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution ConvertQueryExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.Node expr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr queryExpr = (global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr)expr;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value = null;
			bool flag = global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode == sr.ParserOptions.ParserCompilationMode;
			if (queryExpr.HavingClause != null && queryExpr.GroupByClause == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = queryExpr.ErrCtx;
				string havingRequiresGroupClause = global::System.Data.Entity.Resources.Strings.HavingRequiresGroupClause;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, havingRequiresGroupClause, null);
			}
			if (queryExpr.SelectClause.TopExpr != null)
			{
				if (queryExpr.OrderByClause != null && queryExpr.OrderByClause.LimitSubClause != null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = queryExpr.SelectClause.TopExpr.ErrCtx;
					string topAndLimitCannotCoexist = global::System.Data.Entity.Resources.Strings.TopAndLimitCannotCoexist;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, topAndLimitCannotCoexist, null);
				}
				if (queryExpr.OrderByClause != null && queryExpr.OrderByClause.SkipSubClause != null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = queryExpr.SelectClause.TopExpr.ErrCtx;
					string topAndSkipCannotCoexist = global::System.Data.Entity.Resources.Strings.TopAndSkipCannotCoexist;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, topAndSkipCannotCoexist, null);
				}
			}
			using (sr.EnterScopeRegion())
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClause(queryExpr.FromClause, sr);
				source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessWhereClause(source, queryExpr.WhereClause, sr);
				bool queryProjectionProcessed = false;
				if (!flag)
				{
					source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessGroupByClause(source, queryExpr, sr);
					source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessHavingClause(source, queryExpr.HavingClause, sr);
					source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessOrderByClause(source, queryExpr, out queryProjectionProcessed, sr);
				}
				value = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessSelectClause(source, queryExpr, queryProjectionProcessed, sr);
			}
			return new global::System.Data.Entity.Core.Common.EntitySql.ValueExpression(value);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x0011B988 File Offset: 0x00119B88
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ProcessSelectClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr queryExpr, bool queryProjectionProcessed, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause = queryExpr.SelectClause;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			if (queryProjectionProcessed)
			{
				dbExpression = source.Expression;
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> projectionItems = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSelectClauseItems(queryExpr, sr);
				dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateProjectExpression(source, selectClause, projectionItems);
			}
			if (selectClause.TopExpr != null || (queryExpr.OrderByClause != null && queryExpr.OrderByClause.LimitSubClause != null))
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.Node node;
				string exprName;
				if (selectClause.TopExpr != null)
				{
					node = selectClause.TopExpr;
					exprName = "TOP";
				}
				else
				{
					node = queryExpr.OrderByClause.LimitSubClause;
					exprName = "LIMIT";
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(node, sr);
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateExpressionIsCommandParamOrNonNegativeIntegerConstant(dbExpression2, node.ErrCtx, exprName);
				dbExpression = dbExpression.Limit(dbExpression2);
			}
			return dbExpression;
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0011BA24 File Offset: 0x00119C24
		private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> ConvertSelectClauseItems(global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr queryExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause = queryExpr.SelectClause;
			if (selectClause.SelectKind == global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind.Value)
			{
				if (selectClause.Items.Count != 1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = selectClause.ErrCtx;
					string invalidSelectValueList = global::System.Data.Entity.Resources.Strings.InvalidSelectValueList;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidSelectValueList, null);
				}
				if (selectClause.Items[0].Alias != null && queryExpr.OrderByClause == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = selectClause.Items[0].ErrCtx;
					string invalidSelectValueAliasedExpression = global::System.Data.Entity.Resources.Strings.InvalidSelectValueAliasedExpression;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, invalidSelectValueAliasedExpression, null);
				}
			}
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(sr.NameComparer);
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(selectClause.Items.Count);
			for (int i = 0; i < selectClause.Items.Count; i++)
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr = selectClause.Items[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr.Expr, sr);
				string text = sr.InferAliasName(aliasedExpr, dbExpression);
				if (hashSet.Contains(text))
				{
					if (aliasedExpr.Alias != null)
					{
						global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(text, aliasedExpr.Alias.ErrCtx, global::System.Data.Entity.Resources.Strings.InSelectProjectionList);
					}
					else
					{
						text = sr.GenerateInternalName("autoProject");
					}
				}
				hashSet.Add(text);
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(text, dbExpression));
			}
			return list;
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x0011BB58 File Offset: 0x00119D58
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateProjectExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> projectionItems)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
			if (selectClause.SelectKind == global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind.Value)
			{
				dbExpression = source.Project(projectionItems[0].Value);
			}
			else
			{
				dbExpression = source.Project(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(projectionItems));
			}
			if (selectClause.DistinctKind == global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.Distinct)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateDistinctProjection(dbExpression.ResultType, selectClause);
				dbExpression = dbExpression.Distinct();
			}
			return dbExpression;
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0011BBB0 File Offset: 0x00119DB0
		private static void ValidateDistinctProjection(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage projectExpressionResultType, global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = selectClause.Items[0].Expr.ErrCtx;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.ErrorContext> projectionItemErrCtxs;
			if (selectClause.SelectKind != global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind.Row)
			{
				projectionItemErrCtxs = null;
			}
			else
			{
				projectionItemErrCtxs = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.ErrorContext>(from item in selectClause.Items
				select item.Expr.ErrCtx);
			}
			global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateDistinctProjection(projectExpressionResultType, errCtx, projectionItemErrCtxs);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x0011BC14 File Offset: 0x00119E14
		private static void ValidateDistinctProjection(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage projectExpressionResultType, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext defaultErrCtx, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.ErrorContext> projectionItemErrCtxs)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(projectExpressionResultType);
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidDistinctOpType(elementTypeUsage))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = defaultErrCtx;
				if (projectionItemErrCtxs != null && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(elementTypeUsage))
				{
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = elementTypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
					for (int i = 0; i < rowType.Members.Count; i++)
					{
						if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidDistinctOpType(rowType.Members[i].TypeUsage))
						{
							errCtx = projectionItemErrCtxs[i];
							break;
						}
					}
				}
				string selectDistinctMustBeEqualComparable = global::System.Data.Entity.Resources.Strings.SelectDistinctMustBeEqualComparable;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, selectDistinctMustBeEqualComparable, null);
			}
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0011BC98 File Offset: 0x00119E98
		private static void ValidateExpressionIsCommandParamOrNonNegativeIntegerConstant(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string exprName)
		{
			if (expr.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && expr.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
			{
				string errorMessage = global::System.Data.Entity.Resources.Strings.PlaceholderExpressionMustBeConstant(exprName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(expr.ResultType, global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.Int64Type))
			{
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.PlaceholderExpressionMustBeCompatibleWithEdm64(exprName, expr.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage2, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = expr as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
			if (dbConstantExpression != null && global::System.Convert.ToInt64(dbConstantExpression.Value, global::System.Globalization.CultureInfo.InvariantCulture) < 0L)
			{
				string errorMessage3 = global::System.Data.Entity.Resources.Strings.PlaceholderExpressionMustBeGreaterThanOrEqualToZero(exprName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage3, null);
			}
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0011BD28 File Offset: 0x00119F28
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessFromClause(global::System.Data.Entity.Core.Common.EntitySql.AST.FromClause fromClause, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding fromBinding = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry>();
			global::System.Func<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry, global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> <>9__0;
			for (int i = 0; i < fromClause.FromClauseItems.Count; i++)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> collection;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClauseItem(fromClause.FromClauseItems[i], sr, out collection);
				list.AddRange(collection);
				if (fromBinding == null)
				{
					fromBinding = dbExpressionBinding;
				}
				else
				{
					fromBinding = fromBinding.CrossApply(dbExpressionBinding).BindAs(sr.GenerateInternalName("lcapply"));
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> ts = list;
					global::System.Func<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry, global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> action;
					if ((action = <>9__0) == null)
					{
						action = (<>9__0 = ((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry scopeEntry) => scopeEntry.AddParentVar(fromBinding.Variable)));
					}
					ts.Each(action);
				}
			}
			return fromBinding;
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x0011BDE0 File Offset: 0x00119FE0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessFromClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItem fromClauseItem, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> scopeEntries)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind fromClauseItemKind = fromClauseItem.FromClauseItemKind;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding result;
			if (fromClauseItemKind != global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind.AliasedFromClause)
			{
				if (fromClauseItemKind != global::System.Data.Entity.Core.Common.EntitySql.AST.FromClauseItemKind.JoinFromClause)
				{
					result = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessApplyClauseItem((global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyClauseItem)fromClauseItem.FromExpr, sr, out scopeEntries);
				}
				else
				{
					result = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessJoinClauseItem((global::System.Data.Entity.Core.Common.EntitySql.AST.JoinClauseItem)fromClauseItem.FromExpr, sr, out scopeEntries);
				}
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessAliasedFromClauseItem((global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr)fromClauseItem.FromExpr, sr, out scopeEntries);
			}
			return result;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x0011BE40 File Offset: 0x0011A040
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessAliasedFromClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> scopeEntries)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr.Expr, sr);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = aliasedExpr.Expr.ErrCtx;
				string expressionMustBeCollection = global::System.Data.Entity.Resources.Strings.ExpressionMustBeCollection;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionMustBeCollection, null);
			}
			string text = sr.InferAliasName(aliasedExpr, dbExpression);
			if (sr.CurrentScope.Contains(text))
			{
				if (aliasedExpr.Alias != null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(text, aliasedExpr.Alias.ErrCtx, global::System.Data.Entity.Resources.Strings.InFromClause);
				}
				else
				{
					text = sr.GenerateInternalName("autoFrom");
				}
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(text);
			global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry sourceScopeEntry = new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(dbExpressionBinding.Variable);
			sr.CurrentScope.Add(dbExpressionBinding.Variable.VariableName, sourceScopeEntry);
			scopeEntries = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry>();
			scopeEntries.Add(sourceScopeEntry);
			return dbExpressionBinding;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x0011BF04 File Offset: 0x0011A104
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessJoinClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.JoinClauseItem joinClause, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> scopeEntries)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding joinBinding = null;
			if (joinClause.OnExpr == null)
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind.Inner == joinClause.JoinKind)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = joinClause.ErrCtx;
					string innerJoinMustHaveOnPredicate = global::System.Data.Entity.Resources.Strings.InnerJoinMustHaveOnPredicate;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, innerJoinMustHaveOnPredicate, null);
				}
			}
			else if (joinClause.JoinKind == global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind.Cross)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = joinClause.OnExpr.ErrCtx;
				string invalidPredicateForCrossJoin = global::System.Data.Entity.Resources.Strings.InvalidPredicateForCrossJoin;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, invalidPredicateForCrossJoin, null);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> list;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClauseItem(joinClause.LeftExpr, sr, out list);
			list.Each((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry scopeEntry) => scopeEntry.IsJoinClauseLeftExpr = true);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> collection;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClauseItem(joinClause.RightExpr, sr, out collection);
			list.Each((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry scopeEntry) => scopeEntry.IsJoinClauseLeftExpr = false);
			if (joinClause.JoinKind == global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind.RightOuter)
			{
				joinClause.JoinKind = global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind.LeftOuter;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = dbExpressionBinding;
				dbExpressionBinding = dbExpressionBinding2;
				dbExpressionBinding2 = dbExpressionBinding3;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind dbExpressionKind = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.MapJoinKind(joinClause.JoinKind);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition = null;
			if (joinClause.OnExpr == null)
			{
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin != dbExpressionKind)
				{
					joinCondition = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
				}
			}
			else
			{
				joinCondition = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(joinClause.OnExpr, sr);
			}
			joinBinding = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateJoinExpressionByKind(dbExpressionKind, joinCondition, dbExpressionBinding, dbExpressionBinding2).BindAs(sr.GenerateInternalName("join"));
			scopeEntries = list;
			scopeEntries.AddRange(collection);
			scopeEntries.Each((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry scopeEntry) => scopeEntry.AddParentVar(joinBinding.Variable));
			return joinBinding;
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x0011C061 File Offset: 0x0011A261
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind MapJoinKind(global::System.Data.Entity.Core.Common.EntitySql.AST.JoinKind joinKind)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer._joinMap[(int)joinKind];
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0011C06C File Offset: 0x0011A26C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessApplyClauseItem(global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyClauseItem applyClause, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> scopeEntries)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding applyBinding = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> list;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClauseItem(applyClause.LeftExpr, sr, out list);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry> collection;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessFromClauseItem(applyClause.RightExpr, sr, out collection);
			applyBinding = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApplyExpressionByKind(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.MapApplyKind(applyClause.ApplyKind), input, apply).BindAs(sr.GenerateInternalName("apply"));
			scopeEntries = list;
			scopeEntries.AddRange(collection);
			scopeEntries.Each((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry scopeEntry) => scopeEntry.AddParentVar(applyBinding.Variable));
			return applyBinding;
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x0011C0F2 File Offset: 0x0011A2F2
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind MapApplyKind(global::System.Data.Entity.Core.Common.EntitySql.AST.ApplyKind applyKind)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer._applyMap[(int)applyKind];
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0011C0FB File Offset: 0x0011A2FB
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessWhereClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.Node whereClause, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (whereClause == null)
			{
				return source;
			}
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessWhereHavingClausePredicate(source, whereClause, whereClause.ErrCtx, "where", sr);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x0011C115 File Offset: 0x0011A315
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessHavingClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.HavingClause havingClause, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			if (havingClause == null)
			{
				return source;
			}
			return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessWhereHavingClausePredicate(source, havingClause.HavingPredicate, havingClause.ErrCtx, "having", sr);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x0011C134 File Offset: 0x0011A334
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessWhereHavingClausePredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.Node predicate, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string bindingNameTemplate, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding whereBinding = null;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(predicate, sr);
			if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsBooleanType(dbExpression.ResultType))
			{
				string expressionTypeMustBeBoolean = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeBoolean;
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionTypeMustBeBoolean, null);
			}
			whereBinding = source.Filter(dbExpression).BindAs(sr.GenerateInternalName(bindingNameTemplate));
			sr.CurrentScopeRegion.ApplyToScopeEntries(delegate(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry)
			{
				if (scopeEntry.EntryKind == global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.SourceVar)
				{
					((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry)scopeEntry).ReplaceParentVar(whereBinding.Variable);
				}
			});
			return whereBinding;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x0011C1AC File Offset: 0x0011A3AC
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessGroupByClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr queryExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.AST.GroupByClause groupByClause = queryExpr.GroupByClause;
			int num = (groupByClause != null) ? groupByClause.GroupItems.Count : 0;
			bool flag = num == 0;
			if (flag && !queryExpr.HasMethodCall)
			{
				return source;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding groupInputBinding = source.Expression.GroupBindAs(sr.GenerateInternalName("geb"), sr.GenerateInternalName("group"));
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate groupAggregate = groupInputBinding.GroupAggregate;
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = groupAggregate.ResultType.Variable(sr.GenerateInternalName("groupAggregate"));
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding groupAggregateBinding = dbVariableReferenceExpression.BindAs(sr.GenerateInternalName("groupPartitionItem"));
			sr.CurrentScopeRegion.EnterGroupOperation(groupAggregateBinding);
			sr.CurrentScopeRegion.ApplyToScopeEntries(delegate(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry)
			{
				((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry)scopeEntry).AdjustToGroupVar(groupInputBinding.Variable, groupInputBinding.GroupVariable, groupAggregateBinding.Variable);
			});
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(sr.NameComparer);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo>(num);
			if (!flag)
			{
				for (int i = 0; i < num; i++)
				{
					global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr = groupByClause.GroupItems[i];
					sr.CurrentScopeRegion.WasResolutionCorrelated = false;
					global::System.Data.Entity.Core.Common.EntitySql.GroupKeyAggregateInfo groupKeyAggregateInfo;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
					using (sr.EnterGroupKeyDefinition(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.GroupKey, aliasedExpr.ErrCtx, out groupKeyAggregateInfo))
					{
						dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr.Expr, sr);
					}
					if (!sr.CurrentScopeRegion.WasResolutionCorrelated)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = aliasedExpr.Expr.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.KeyMustBeCorrelated("GROUP BY");
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidGroupKeyType(dbExpression.ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = aliasedExpr.Expr.ErrCtx;
						string groupingKeysMustBeEqualComparable = global::System.Data.Entity.Resources.Strings.GroupingKeysMustBeEqualComparable;
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, groupingKeysMustBeEqualComparable, null);
					}
					global::System.Data.Entity.Core.Common.EntitySql.GroupKeyAggregateInfo groupKeyAggregateInfo2;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupVarBasedKeyExpr;
					using (sr.EnterGroupKeyDefinition(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Function, aliasedExpr.ErrCtx, out groupKeyAggregateInfo2))
					{
						groupVarBasedKeyExpr = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr.Expr, sr);
					}
					global::System.Data.Entity.Core.Common.EntitySql.GroupKeyAggregateInfo groupKeyAggregateInfo3;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupAggBasedKeyExpr;
					using (sr.EnterGroupKeyDefinition(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Partition, aliasedExpr.ErrCtx, out groupKeyAggregateInfo3))
					{
						groupAggBasedKeyExpr = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr.Expr, sr);
					}
					string text = sr.InferAliasName(aliasedExpr, dbExpression);
					if (hashSet.Contains(text))
					{
						if (aliasedExpr.Alias != null)
						{
							global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(text, aliasedExpr.Alias.ErrCtx, global::System.Data.Entity.Resources.Strings.InGroupClause);
						}
						else
						{
							text = sr.GenerateInternalName("autoGroup");
						}
					}
					hashSet.Add(text);
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo groupKeyInfo = new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo(text, dbExpression, groupVarBasedKeyExpr, groupAggBasedKeyExpr);
					list.Add(groupKeyInfo);
					if (aliasedExpr.Alias == null)
					{
						global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr dotExpr = aliasedExpr.Expr as global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr;
						string[] array;
						if (dotExpr != null && dotExpr.IsMultipartIdentifier(out array))
						{
							groupKeyInfo.AlternativeName = array;
							string fullName = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(array);
							if (hashSet.Contains(fullName))
							{
								global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(fullName, dotExpr.ErrCtx, global::System.Data.Entity.Resources.Strings.InGroupClause);
							}
							hashSet.Add(fullName);
						}
					}
				}
			}
			int currentScopeIndex = sr.CurrentScopeIndex;
			sr.EnterScope();
			foreach (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo groupKeyInfo2 in list)
			{
				sr.CurrentScope.Add(groupKeyInfo2.Name, new global::System.Data.Entity.Core.Common.EntitySql.GroupKeyDefinitionScopeEntry(groupKeyInfo2.VarBasedKeyExpr, groupKeyInfo2.GroupVarBasedKeyExpr, groupKeyInfo2.GroupAggBasedKeyExpr, null));
				if (groupKeyInfo2.AlternativeName != null)
				{
					string fullName2 = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(groupKeyInfo2.AlternativeName);
					sr.CurrentScope.Add(fullName2, new global::System.Data.Entity.Core.Common.EntitySql.GroupKeyDefinitionScopeEntry(groupKeyInfo2.VarBasedKeyExpr, groupKeyInfo2.GroupVarBasedKeyExpr, groupKeyInfo2.GroupAggBasedKeyExpr, groupKeyInfo2.AlternativeName));
				}
			}
			if (queryExpr.HavingClause != null && queryExpr.HavingClause.HasMethodCall)
			{
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(queryExpr.HavingClause.HavingPredicate, sr);
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary = null;
			if (queryExpr.OrderByClause != null || queryExpr.SelectClause.HasMethodCall)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(queryExpr.SelectClause.Items.Count, sr.NameComparer);
				for (int j = 0; j < queryExpr.SelectClause.Items.Count; j++)
				{
					global::System.Data.Entity.Core.Common.EntitySql.AST.AliasedExpr aliasedExpr2 = queryExpr.SelectClause.Items[j];
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(aliasedExpr2.Expr, sr);
					dbExpression2 = ((dbExpression2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null) ? dbExpression2 : dbExpression2.ResultType.Null());
					string text2 = sr.InferAliasName(aliasedExpr2, dbExpression2);
					if (dictionary.ContainsKey(text2))
					{
						if (aliasedExpr2.Alias != null)
						{
							global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportAliasAlreadyUsedError(text2, aliasedExpr2.Alias.ErrCtx, global::System.Data.Entity.Resources.Strings.InSelectProjectionList);
						}
						else
						{
							text2 = sr.GenerateInternalName("autoProject");
						}
					}
					dictionary.Add(text2, dbExpression2);
				}
			}
			if (queryExpr.OrderByClause != null && queryExpr.OrderByClause.HasMethodCall)
			{
				sr.EnterScope();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair in dictionary)
				{
					sr.CurrentScope.Add(keyValuePair.Key, new global::System.Data.Entity.Core.Common.EntitySql.ProjectionItemDefinitionScopeEntry(keyValuePair.Value));
				}
				for (int k = 0; k < queryExpr.OrderByClause.OrderByClauseItem.Count; k++)
				{
					global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClauseItem orderByClauseItem = queryExpr.OrderByClause.OrderByClauseItem[k];
					sr.CurrentScopeRegion.WasResolutionCorrelated = false;
					global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(orderByClauseItem.OrderExpr, sr);
					if (!sr.CurrentScopeRegion.WasResolutionCorrelated)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = orderByClauseItem.ErrCtx;
						string errorMessage2 = global::System.Data.Entity.Resources.Strings.KeyMustBeCorrelated("ORDER BY");
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
					}
				}
				sr.LeaveScope();
			}
			if (flag && sr.CurrentScopeRegion.GroupAggregateInfos.Count == 0)
			{
				sr.RollbackToScope(currentScopeIndex);
				sr.CurrentScopeRegion.ApplyToScopeEntries(delegate(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry)
				{
					((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry)scopeEntry).RollbackAdjustmentToGroupVar(source.Variable);
				});
				sr.CurrentScopeRegion.RollbackGroupOperation();
				return source;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>(sr.CurrentScopeRegion.GroupAggregateInfos.Count);
			bool flag2 = false;
			foreach (global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo3 in sr.CurrentScopeRegion.GroupAggregateInfos)
			{
				global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind aggregateKind = groupAggregateInfo3.AggregateKind;
				if (aggregateKind != global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Function)
				{
					if (aggregateKind == global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Partition)
					{
						flag2 = true;
					}
				}
				else
				{
					list2.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(groupAggregateInfo3.AggregateName, ((global::System.Data.Entity.Core.Common.EntitySql.FunctionAggregateInfo)groupAggregateInfo3).AggregateDefinition));
				}
			}
			if (flag2)
			{
				list2.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(dbVariableReferenceExpression.VariableName, groupAggregate));
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression input = groupInputBinding.GroupBy(from keyInfo in list
			select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyInfo.Name, keyInfo.VarBasedKeyExpr), list2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding groupBinding = input.BindAs(sr.GenerateInternalName("group"));
			if (flag2)
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list3 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ProcessGroupPartitionDefinitions(sr.CurrentScopeRegion.GroupAggregateInfos, dbVariableReferenceExpression, groupBinding);
				if (list3 != null)
				{
					list3.AddRange(from keyInfo in list
					select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyInfo.Name, groupBinding.Variable.Property(keyInfo.Name)));
					list3.AddRange(from groupAggregateInfo in sr.CurrentScopeRegion.GroupAggregateInfos
					where groupAggregateInfo.AggregateKind == global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Function
					select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(groupAggregateInfo.AggregateName, groupBinding.Variable.Property(groupAggregateInfo.AggregateName)));
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list3);
					groupBinding = groupBinding.Project(projection).BindAs(sr.GenerateInternalName("groupPartitionDefs"));
				}
			}
			sr.RollbackToScope(currentScopeIndex);
			sr.CurrentScopeRegion.ApplyToScopeEntries((global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry) => new global::System.Data.Entity.Core.Common.EntitySql.InvalidGroupInputRefScopeEntry());
			sr.EnterScope();
			foreach (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.GroupKeyInfo groupKeyInfo3 in list)
			{
				sr.CurrentScope.Add(groupKeyInfo3.VarRef.VariableName, new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(groupKeyInfo3.VarRef).AddParentVar(groupBinding.Variable));
				if (groupKeyInfo3.AlternativeName != null)
				{
					string fullName3 = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.GetFullName(groupKeyInfo3.AlternativeName);
					sr.CurrentScope.Add(fullName3, new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(groupKeyInfo3.VarRef, groupKeyInfo3.AlternativeName).AddParentVar(groupBinding.Variable));
				}
			}
			foreach (global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo2 in sr.CurrentScopeRegion.GroupAggregateInfos)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression2 = groupAggregateInfo2.AggregateStubExpression.ResultType.Variable(groupAggregateInfo2.AggregateName);
				if (!sr.CurrentScope.Contains(dbVariableReferenceExpression2.VariableName))
				{
					sr.CurrentScope.Add(dbVariableReferenceExpression2.VariableName, new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(dbVariableReferenceExpression2).AddParentVar(groupBinding.Variable));
					sr.CurrentScopeRegion.RegisterGroupAggregateName(dbVariableReferenceExpression2.VariableName);
				}
				groupAggregateInfo2.AggregateStubExpression = null;
			}
			return groupBinding;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x0011CB1C File Offset: 0x0011AD1C
		private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> ProcessGroupPartitionDefinitions(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo> groupAggregateInfos, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression groupAggregateVarRef, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding groupBinding)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]
			{
				groupAggregateVarRef
			});
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo in groupAggregateInfos)
			{
				if (groupAggregateInfo.AggregateKind == global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind.Partition)
				{
					global::System.Data.Entity.Core.Common.EntitySql.GroupPartitionInfo groupPartitionInfo = (global::System.Data.Entity.Core.Common.EntitySql.GroupPartitionInfo)groupAggregateInfo;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression aggregateDefinition = groupPartitionInfo.AggregateDefinition;
					if (global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsTrivialInputProjection(groupAggregateVarRef, aggregateDefinition))
					{
						groupAggregateInfo.AggregateName = groupAggregateVarRef.VariableName;
						flag = true;
					}
					else
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda = new global::System.Data.Entity.Core.Common.CommandTrees.DbLambda(variables, groupPartitionInfo.AggregateDefinition);
						list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(groupAggregateInfo.AggregateName, lambda.Invoke(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							groupBinding.Variable.Property(groupAggregateVarRef.VariableName)
						})));
					}
				}
			}
			if (flag)
			{
				if (list.Count > 0)
				{
					list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(groupAggregateVarRef.VariableName, groupBinding.Variable.Property(groupAggregateVarRef.VariableName)));
				}
				else
				{
					list = null;
				}
			}
			return list;
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x0011CC30 File Offset: 0x0011AE30
		private static bool IsTrivialInputProjection(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression lambdaVariable, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lambdaBody)
		{
			if (lambdaBody.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)lambdaBody;
			if (dbProjectExpression.Input.Expression != lambdaVariable)
			{
				return false;
			}
			if (dbProjectExpression.Projection.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference)
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)dbProjectExpression.Projection == dbProjectExpression.Input.Variable;
			}
			if (dbProjectExpression.Projection.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(dbProjectExpression.Projection.ResultType))
			{
				return false;
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(dbProjectExpression.Projection.ResultType, dbProjectExpression.Input.Variable.ResultType))
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(dbProjectExpression.Input.Variable.ResultType);
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression.Projection;
			for (int i = 0; i < dbNewInstanceExpression.Arguments.Count; i++)
			{
				if (dbNewInstanceExpression.Arguments[i].ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbNewInstanceExpression.Arguments[i];
				if (dbPropertyExpression.Instance != dbProjectExpression.Input.Variable || dbPropertyExpression.Property != allStructuralMembers[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x0011CD60 File Offset: 0x0011AF60
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ProcessOrderByClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding source, global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr queryExpr, out bool queryProjectionProcessed, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			queryProjectionProcessed = false;
			if (queryExpr.OrderByClause == null)
			{
				return source;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding sortBinding = null;
			global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClause orderByClause = queryExpr.OrderByClause;
			global::System.Data.Entity.Core.Common.EntitySql.AST.SelectClause selectClause = queryExpr.SelectClause;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
			if (orderByClause.SkipSubClause != null)
			{
				dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(orderByClause.SkipSubClause, sr);
				global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ValidateExpressionIsCommandParamOrNonNegativeIntegerConstant(dbExpression, orderByClause.SkipSubClause.ErrCtx, "SKIP");
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSelectClauseItems(queryExpr, sr);
			if (selectClause.DistinctKind == global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.Distinct)
			{
				sr.CurrentScopeRegion.RollbackAllScopes();
			}
			int currentScopeIndex = sr.CurrentScopeIndex;
			sr.EnterScope();
			list.Each((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> projectionItem) => sr.CurrentScope.Add(projectionItem.Key, new global::System.Data.Entity.Core.Common.EntitySql.ProjectionItemDefinitionScopeEntry(projectionItem.Value)));
			if (selectClause.DistinctKind == global::System.Data.Entity.Core.Common.EntitySql.AST.DistinctKind.Distinct)
			{
				source = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateProjectExpression(source, selectClause, list).BindAs(sr.GenerateInternalName("distinct"));
				if (selectClause.SelectKind == global::System.Data.Entity.Core.Common.EntitySql.AST.SelectKind.Value)
				{
					sr.CurrentScope.Replace(list[0].Key, new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(source.Variable));
				}
				else
				{
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair in list)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = keyValuePair.Value.ResultType.Variable(keyValuePair.Key);
						sr.CurrentScope.Replace(dbVariableReferenceExpression.VariableName, new global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry(dbVariableReferenceExpression).AddParentVar(source.Variable));
					}
				}
				queryProjectionProcessed = true;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(orderByClause.OrderByClauseItem.Count);
			for (int i = 0; i < orderByClause.OrderByClauseItem.Count; i++)
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.OrderByClauseItem orderByClauseItem = orderByClause.OrderByClauseItem[i];
				sr.CurrentScopeRegion.WasResolutionCorrelated = false;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(orderByClauseItem.OrderExpr, sr);
				if (!sr.CurrentScopeRegion.WasResolutionCorrelated)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = orderByClauseItem.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.KeyMustBeCorrelated("ORDER BY");
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidSortOpKeyType(dbExpression2.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = orderByClauseItem.OrderExpr.ErrCtx;
					string orderByKeyIsNotOrderComparable = global::System.Data.Entity.Resources.Strings.OrderByKeyIsNotOrderComparable;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, orderByKeyIsNotOrderComparable, null);
				}
				bool flag = orderByClauseItem.OrderKind == global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind.None || orderByClauseItem.OrderKind == global::System.Data.Entity.Core.Common.EntitySql.AST.OrderKind.Asc;
				string text = null;
				if (orderByClauseItem.Collation != null)
				{
					if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsStringType(dbExpression2.ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = orderByClauseItem.OrderExpr.ErrCtx;
						string errorMessage2 = global::System.Data.Entity.Resources.Strings.InvalidKeyTypeForCollation(dbExpression2.ResultType.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
					}
					text = orderByClauseItem.Collation.Name;
				}
				if (string.IsNullOrEmpty(text))
				{
					list2.Add(flag ? dbExpression2.ToSortClause() : dbExpression2.ToSortClauseDescending());
				}
				else
				{
					list2.Add(flag ? dbExpression2.ToSortClause(text) : dbExpression2.ToSortClauseDescending(text));
				}
			}
			sr.RollbackToScope(currentScopeIndex);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input;
			if (dbExpression != null)
			{
				input = source.Skip(list2, dbExpression);
			}
			else
			{
				input = source.Sort(list2);
			}
			sortBinding = input.BindAs(sr.GenerateInternalName("sort"));
			if (!queryProjectionProcessed)
			{
				sr.CurrentScopeRegion.ApplyToScopeEntries(delegate(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry scopeEntry)
				{
					if (scopeEntry.EntryKind == global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.SourceVar)
					{
						((global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry)scopeEntry).ReplaceParentVar(sortBinding.Variable);
					}
				});
			}
			return sortBinding;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x0011D0E4 File Offset: 0x0011B2E4
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertSimpleInExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)right;
			if (dbNewInstanceExpression.Arguments.Count == 0)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
			}
			return global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(from arg in dbNewInstanceExpression.Arguments
			select left.Equal(arg)), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.Or(next));
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0011D158 File Offset: 0x0011B358
		private static bool IsStringType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x0011D162 File Offset: 0x0011B362
		private static bool IsBooleanType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x0011D16B File Offset: 0x0011B36B
		private static bool IsSubOrSuperType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(type1, type2) || type1.IsSubtypeOf(type2) || type2.IsSubtypeOf(type1);
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x0011D188 File Offset: 0x0011B388
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter> CreateAstExprConverters()
		{
			return new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter>(17)
			{
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.Literal),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertLiteral)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.QueryParameter),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertParameter)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertIdentifier)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.DotExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertDotExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertBuiltIn)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.QueryExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertQueryExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.ParenExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertParenExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.RowConstructorExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertRowConstructor)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.MultisetConstructorExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMultisetConstructor)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.CaseExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertCaseExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.RelshipNavigationExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertRelshipNavigationExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.RefExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertRefExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.DerefExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertDeRefExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertMethodExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.CreateRefExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertCreateRefExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.KeyExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertKeyExpr)
				},
				{
					typeof(global::System.Data.Entity.Core.Common.EntitySql.AST.GroupPartitionExpr),
					new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertGroupPartitionExpr)
				}
			};
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0011D378 File Offset: 0x0011B578
		private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter> CreateBuiltInExprConverter()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter>(4);
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Plus, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertPlusOperands(bltInExpr, sr);
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(pair.Left.ResultType))
				{
					return pair.Left.Plus(pair.Right);
				}
				global::System.Data.Entity.Core.Common.EntitySql.MetadataFunctionGroup metadataFunctionGroup;
				if (!sr.TypeResolver.TryGetFunctionFromMetadata("Edm", "Concat", out metadataFunctionGroup))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.ErrCtx;
					string concatBuiltinNotSupported = global::System.Data.Entity.Resources.Strings.ConcatBuiltinNotSupported;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, concatBuiltinNotSupported, null);
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(2);
				list.Add(pair.Left.ResultType);
				list.Add(pair.Right.ResultType);
				bool flag = false;
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver.ResolveFunctionOverloads(metadataFunctionGroup.FunctionMetadata, list, false, out flag);
				if (edmFunction == null || flag)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.ErrCtx;
					string concatBuiltinNotSupported2 = global::System.Data.Entity.Resources.Strings.ConcatBuiltinNotSupported;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, concatBuiltinNotSupported2, null);
				}
				return edmFunction.Invoke(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					pair.Left,
					pair.Right
				});
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Minus, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr);
				return pair.Left.Minus(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Multiply, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr);
				return pair.Left.Multiply(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Divide, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr);
				return pair.Left.Divide(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Modulus, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr);
				return pair.Left.Modulo(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.UnaryMinus, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr).Left;
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsUnsignedNumericType(left.ResultType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
					if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetClosestPromotableType(left.ResultType, out typeUsage))
					{
						throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidUnsignedTypeForUnaryMinusOperation(left.ResultType.EdmType.FullName));
					}
				}
				return left.UnaryMinus();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.UnaryPlus, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertArithmeticArgs(bltInExpr, sr).Left);
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.And, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertLogicalArgs(bltInExpr, sr);
				return pair.Left.And(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Or, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertLogicalArgs(bltInExpr, sr);
				return pair.Left.Or(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Not, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertLogicalArgs(bltInExpr, sr).Left.Not());
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Equal, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertEqualCompArgs(bltInExpr, sr);
				return pair.Left.Equal(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.NotEqual, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertEqualCompArgs(bltInExpr, sr);
				return pair.Left.Equal(pair.Right).Not();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.GreaterEqual, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertOrderCompArgs(bltInExpr, sr);
				return pair.Left.GreaterThanOrEqual(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.GreaterThan, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertOrderCompArgs(bltInExpr, sr);
				return pair.Left.GreaterThan(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.LessEqual, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertOrderCompArgs(bltInExpr, sr);
				return pair.Left.LessThanOrEqual(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.LessThan, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertOrderCompArgs(bltInExpr, sr);
				return pair.Left.LessThan(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Union, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr);
				return pair.Left.UnionAll(pair.Right).Distinct();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.UnionAll, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr);
				return pair.Left.UnionAll(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Intersect, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr);
				return pair.Left.Intersect(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Overlaps, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr);
				return pair.Left.Intersect(pair.Right).IsEmpty().Not();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.AnyElement, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr).Left.Element());
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Element, delegate
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ElementOperatorIsNotSupported);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Except, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr);
				return pair.Left.Except(pair.Right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Exists, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr).Left.IsEmpty().Not());
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Flatten, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(bltInExpr.Arg1, sr);
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string invalidFlattenArgument = global::System.Data.Entity.Resources.Strings.InvalidFlattenArgument;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidFlattenArgument, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType)))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg1.ErrCtx;
					string invalidFlattenArgument2 = global::System.Data.Entity.Resources.Strings.InvalidFlattenArgument;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, invalidFlattenArgument2, null);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbExpression.BindAs(sr.GenerateInternalName("l_flatten"));
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = dbExpressionBinding.Variable.BindAs(sr.GenerateInternalName("r_flatten"));
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = dbExpressionBinding.CrossApply(dbExpressionBinding2).BindAs(sr.GenerateInternalName("flatten"));
				return dbExpressionBinding3.Project(dbExpressionBinding3.Variable.Property(dbExpressionBinding2.VariableName));
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.In, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertInExprArgs(bltInExpr, sr);
				if (pair.Right.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
				{
					return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSimpleInExpression(pair.Left, pair.Right);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = pair.Right.BindAs(sr.GenerateInternalName("in-filter"));
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = pair.Left;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression variable = dbExpressionBinding.Variable;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = dbExpressionBinding.Filter(left.Equal(variable)).IsEmpty().Not();
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					left.IsNull()
				}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.BooleanType.Null()
				}, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False).Or(right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.NotIn, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertInExprArgs(bltInExpr, sr);
				if (pair.Right.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
				{
					return global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSimpleInExpression(pair.Left, pair.Right).Not();
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = pair.Right.BindAs(sr.GenerateInternalName("in-filter"));
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = pair.Left;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression variable = dbExpressionBinding.Variable;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = dbExpressionBinding.Filter(left.Equal(variable)).IsEmpty();
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					left.IsNull()
				}, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(1)
				{
					global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.BooleanType.Null()
				}, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True).And(right);
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Distinct, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertSetArgs(bltInExpr, sr).Left.Distinct());
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.IsNull, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
				if (dbExpression != null && !global::System.Data.Entity.Core.Common.TypeHelpers.IsValidIsNullOpType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string isNullInvalidType = global::System.Data.Entity.Resources.Strings.IsNullInvalidType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, isNullInvalidType, null);
				}
				if (dbExpression == null)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
				}
				return dbExpression.IsNull();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.IsNotNull, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
				if (dbExpression != null && !global::System.Data.Entity.Core.Common.TypeHelpers.IsValidIsNullOpType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string isNullInvalidType = global::System.Data.Entity.Resources.Strings.IsNullInvalidType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, isNullInvalidType, null);
				}
				if (dbExpression == null)
				{
					return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
				}
				return dbExpression.IsNull().Not();
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.IsOf, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(bltInExpr.Arg1, sr);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(bltInExpr.Arg2, sr);
				bool flag = (bool)((global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)bltInExpr.Arg3).Value;
				bool flag2 = (bool)((global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)bltInExpr.Arg4).Value;
				bool flag3 = sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode;
				if (!flag3 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeEntityType(global::System.Data.Entity.Resources.Strings.CtxIsOf, dbExpression.ResultType.EdmType.BuiltInTypeKind.ToString(), dbExpression.ResultType.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				if (flag3 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg1.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeNominalType(global::System.Data.Entity.Resources.Strings.CtxIsOf, dbExpression.ResultType.EdmType.BuiltInTypeKind.ToString(), dbExpression.ResultType.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
				}
				if (!flag3 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg2.ErrCtx;
					string errorMessage3 = global::System.Data.Entity.Resources.Strings.TypeMustBeEntityType(global::System.Data.Entity.Resources.Strings.CtxIsOf, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage3, null);
				}
				if (flag3 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = bltInExpr.Arg2.ErrCtx;
					string errorMessage4 = global::System.Data.Entity.Resources.Strings.TypeMustBeNominalType(global::System.Data.Entity.Resources.Strings.CtxIsOf, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage4, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = bltInExpr.Arg1.ErrCtx;
					string typeMustBeInheritableType = global::System.Data.Entity.Resources.Strings.TypeMustBeInheritableType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, typeMustBeInheritableType, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = bltInExpr.Arg2.ErrCtx;
					string typeMustBeInheritableType2 = global::System.Data.Entity.Resources.Strings.TypeMustBeInheritableType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, typeMustBeInheritableType2, null);
				}
				if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsSubOrSuperType(dbExpression.ResultType, typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = bltInExpr.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.NotASuperOrSubType(dbExpression.ResultType.EdmType.FullName, typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage5, null);
				}
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2;
				if (flag)
				{
					dbExpression2 = dbExpression.IsOfOnly(typeUsage);
				}
				else
				{
					dbExpression2 = dbExpression.IsOf(typeUsage);
				}
				if (flag2)
				{
					dbExpression2 = dbExpression2.Not();
				}
				return dbExpression2;
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Treat, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(bltInExpr.Arg2, sr);
				bool flag = sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode;
				if (!flag && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg2.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.TypeMustBeEntityType(global::System.Data.Entity.Resources.Strings.CtxTreat, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				if (flag && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg2.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.TypeMustBeNominalType(global::System.Data.Entity.Resources.Strings.CtxTreat, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
				}
				if (dbExpression == null)
				{
					dbExpression = typeUsage.Null();
				}
				else
				{
					if (!flag && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(dbExpression.ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg1.ErrCtx;
						string errorMessage3 = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeEntityType(global::System.Data.Entity.Resources.Strings.CtxTreat, dbExpression.ResultType.EdmType.BuiltInTypeKind.ToString(), dbExpression.ResultType.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage3, null);
					}
					if (flag && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(dbExpression.ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = bltInExpr.Arg1.ErrCtx;
						string errorMessage4 = global::System.Data.Entity.Resources.Strings.ExpressionTypeMustBeNominalType(global::System.Data.Entity.Resources.Strings.CtxTreat, dbExpression.ResultType.EdmType.BuiltInTypeKind.ToString(), dbExpression.ResultType.EdmType.FullName);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage4, null);
					}
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = bltInExpr.Arg1.ErrCtx;
					string typeMustBeInheritableType = global::System.Data.Entity.Resources.Strings.TypeMustBeInheritableType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, typeMustBeInheritableType, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = bltInExpr.Arg2.ErrCtx;
					string typeMustBeInheritableType2 = global::System.Data.Entity.Resources.Strings.TypeMustBeInheritableType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, typeMustBeInheritableType2, null);
				}
				if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsSubOrSuperType(dbExpression.ResultType, typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = bltInExpr.Arg1.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.NotASuperOrSubType(dbExpression.ResultType.EdmType.FullName, typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage5, null);
				}
				return dbExpression.TreatAs(global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage));
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Cast, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(bltInExpr.Arg2, sr);
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg2.ErrCtx;
					string invalidCastType = global::System.Data.Entity.Resources.Strings.InvalidCastType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, invalidCastType, null);
				}
				if (dbExpression == null)
				{
					return typeUsage.Null();
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg1.ErrCtx;
					string invalidCastExpressionType = global::System.Data.Entity.Resources.Strings.InvalidCastExpressionType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, invalidCastExpressionType, null);
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCastAllowed(dbExpression.ResultType, typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg1.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.InvalidCast(dbExpression.ResultType.EdmType.FullName, typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage, null);
				}
				return dbExpression.CastTo(global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage));
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.OfType, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpression(bltInExpr.Arg1, sr);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertTypeName(bltInExpr.Arg2, sr);
				bool flag = (bool)((global::System.Data.Entity.Core.Common.EntitySql.AST.Literal)bltInExpr.Arg3).Value;
				bool flag2 = sr.ParserOptions.ParserCompilationMode == global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode;
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string expressionMustBeCollection = global::System.Data.Entity.Resources.Strings.ExpressionMustBeCollection;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, expressionMustBeCollection, null);
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(dbExpression.ResultType);
				if (!flag2 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(elementTypeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg1.ErrCtx;
					string errorMessage = global::System.Data.Entity.Resources.Strings.OfTypeExpressionElementTypeMustBeEntityType(elementTypeUsage.EdmType.BuiltInTypeKind.ToString(), elementTypeUsage);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage, null);
				}
				if (flag2 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(elementTypeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg1.ErrCtx;
					string errorMessage2 = global::System.Data.Entity.Resources.Strings.OfTypeExpressionElementTypeMustBeNominalType(elementTypeUsage.EdmType.BuiltInTypeKind.ToString(), elementTypeUsage);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage2, null);
				}
				if (!flag2 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx4 = bltInExpr.Arg2.ErrCtx;
					string errorMessage3 = global::System.Data.Entity.Resources.Strings.TypeMustBeEntityType(global::System.Data.Entity.Resources.Strings.CtxOfType, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx4, errorMessage3, null);
				}
				if (flag2 && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx5 = bltInExpr.Arg2.ErrCtx;
					string errorMessage4 = global::System.Data.Entity.Resources.Strings.TypeMustBeNominalType(global::System.Data.Entity.Resources.Strings.CtxOfType, typeUsage.EdmType.BuiltInTypeKind.ToString(), typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx5, errorMessage4, null);
				}
				if (flag && typeUsage.EdmType.Abstract)
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx6 = bltInExpr.Arg2.ErrCtx;
					string errorMessage5 = global::System.Data.Entity.Resources.Strings.OfTypeOnlyTypeArgumentCannotBeAbstract(typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx6, errorMessage5, null);
				}
				if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsSubOrSuperType(elementTypeUsage, typeUsage))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx7 = bltInExpr.Arg1.ErrCtx;
					string errorMessage6 = global::System.Data.Entity.Resources.Strings.NotASuperOrSubType(elementTypeUsage.EdmType.FullName, typeUsage.EdmType.FullName);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx7, errorMessage6, null);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
				if (flag)
				{
					result = dbExpression.OfTypeOnly(global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage));
				}
				else
				{
					result = dbExpression.OfType(global::System.Data.Entity.Core.Common.TypeHelpers.GetReadOnlyType(typeUsage));
				}
				return result;
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Like, delegate(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
				if (dbExpression == null)
				{
					dbExpression = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.StringType.Null();
				}
				else if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsStringType(dbExpression.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
					string likeArgMustBeStringType = global::System.Data.Entity.Resources.Strings.LikeArgMustBeStringType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, likeArgMustBeStringType, null);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg2, sr);
				if (dbExpression2 == null)
				{
					dbExpression2 = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.StringType.Null();
				}
				else if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsStringType(dbExpression2.ResultType))
				{
					global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg2.ErrCtx;
					string likeArgMustBeStringType2 = global::System.Data.Entity.Resources.Strings.LikeArgMustBeStringType;
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, likeArgMustBeStringType2, null);
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
				if (3 == bltInExpr.ArgCount)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg3, sr);
					if (dbExpression3 == null)
					{
						dbExpression3 = global::System.Data.Entity.Core.Common.EntitySql.TypeResolver.StringType.Null();
					}
					else if (!global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.IsStringType(dbExpression3.ResultType))
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg3.ErrCtx;
						string likeArgMustBeStringType3 = global::System.Data.Entity.Resources.Strings.LikeArgMustBeStringType;
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, likeArgMustBeStringType3, null);
					}
					result = dbExpression.Like(dbExpression2, dbExpression3);
				}
				else
				{
					result = dbExpression.Like(dbExpression2);
				}
				return result;
			});
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.Between, new global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter(global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertBetweenExpr));
			dictionary.Add(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind.NotBetween, (global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr) => global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertBetweenExpr(bltInExpr, sr).Not());
			return dictionary;
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x0011D914 File Offset: 0x0011BB14
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ConvertBetweenExpr(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr bltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.Pair<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pair = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionsWithUntypedNulls(bltInExpr.Arg2, bltInExpr.Arg3, bltInExpr.Arg1.ErrCtx, () => global::System.Data.Entity.Resources.Strings.BetweenLimitsCannotBeUntypedNulls, sr);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(pair.Left.ResultType, pair.Right.ResultType);
			if (commonTypeUsage == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = bltInExpr.Arg1.ErrCtx;
				string errorMessage = global::System.Data.Entity.Resources.Strings.BetweenLimitsTypesAreNotCompatible(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparableTo(pair.Left.ResultType, pair.Right.ResultType))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx2 = bltInExpr.Arg1.ErrCtx;
				string errorMessage2 = global::System.Data.Entity.Resources.Strings.BetweenLimitsTypesAreNotOrderComparable(pair.Left.ResultType.EdmType.FullName, pair.Right.ResultType.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx2, errorMessage2, null);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertValueExpressionAllowUntypedNulls(bltInExpr.Arg1, sr);
			if (dbExpression == null)
			{
				dbExpression = commonTypeUsage.Null();
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparableTo(dbExpression.ResultType, commonTypeUsage))
			{
				global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx3 = bltInExpr.Arg1.ErrCtx;
				string errorMessage3 = global::System.Data.Entity.Resources.Strings.BetweenValueIsNotOrderComparable(dbExpression.ResultType.EdmType.FullName, commonTypeUsage.EdmType.FullName);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx3, errorMessage3, null);
			}
			return dbExpression.GreaterThanOrEqual(pair.Left).And(dbExpression.LessThanOrEqual(pair.Right));
		}

		// Token: 0x04001C72 RID: 7282
		private readonly global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver _sr;

		// Token: 0x04001C73 RID: 7283
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind[] _joinMap = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind[]
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin,
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin,
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin,
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin
		};

		// Token: 0x04001C74 RID: 7284
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind[] _applyMap = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind[]
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply,
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply
		};

		// Token: 0x04001C75 RID: 7285
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.AstExprConverter> _astExprConverters = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateAstExprConverters();

		// Token: 0x04001C76 RID: 7286
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInKind, global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.BuiltInExprConverter> _builtInExprConverter = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.CreateBuiltInExprConverter();

		// Token: 0x02000C77 RID: 3191
		// (Invoke) Token: 0x06006B70 RID: 27504
		private delegate global::System.Data.Entity.Core.Common.EntitySql.ParseResult StatementConverter(global::System.Data.Entity.Core.Common.EntitySql.AST.Statement astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr);

		// Token: 0x02000C78 RID: 3192
		private sealed class InlineFunctionInfoImpl : global::System.Data.Entity.Core.Common.EntitySql.InlineFunctionInfo
		{
			// Token: 0x06006B73 RID: 27507 RVA: 0x0016E7DA File Offset: 0x0016C9DA
			internal InlineFunctionInfoImpl(global::System.Data.Entity.Core.Common.EntitySql.AST.FunctionDefinition functionDef, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> parameters) : base(functionDef, parameters)
			{
			}

			// Token: 0x06006B74 RID: 27508 RVA: 0x0016E7E4 File Offset: 0x0016C9E4
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbLambda GetLambda(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
			{
				if (this._convertedDefinition == null)
				{
					if (this._convertingDefinition)
					{
						global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx = this.FunctionDefAst.ErrCtx;
						string errorMessage = global::System.Data.Entity.Resources.Strings.Cqt_UDF_FunctionDefinitionWithCircularReference(this.FunctionDefAst.Name);
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr2 = sr.CloneForInlineFunctionConversion();
					this._convertingDefinition = true;
					this._convertedDefinition = global::System.Data.Entity.Core.Common.EntitySql.SemanticAnalyzer.ConvertInlineFunctionDefinition(this, sr2);
					this._convertingDefinition = false;
				}
				return this._convertedDefinition;
			}

			// Token: 0x0400313C RID: 12604
			private global::System.Data.Entity.Core.Common.CommandTrees.DbLambda _convertedDefinition;

			// Token: 0x0400313D RID: 12605
			private bool _convertingDefinition;
		}

		// Token: 0x02000C79 RID: 3193
		private sealed class GroupKeyInfo
		{
			// Token: 0x06006B75 RID: 27509 RVA: 0x0016E84D File Offset: 0x0016CA4D
			internal GroupKeyInfo(string name, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression varBasedKeyExpr, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupVarBasedKeyExpr, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupAggBasedKeyExpr)
			{
				this.Name = name;
				this.VarRef = varBasedKeyExpr.ResultType.Variable(name);
				this.VarBasedKeyExpr = varBasedKeyExpr;
				this.GroupVarBasedKeyExpr = groupVarBasedKeyExpr;
				this.GroupAggBasedKeyExpr = groupAggBasedKeyExpr;
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x06006B76 RID: 27510 RVA: 0x0016E884 File Offset: 0x0016CA84
			// (set) Token: 0x06006B77 RID: 27511 RVA: 0x0016E88C File Offset: 0x0016CA8C
			internal string[] AlternativeName
			{
				get
				{
					return this._alternativeName;
				}
				set
				{
					this._alternativeName = value;
				}
			}

			// Token: 0x0400313E RID: 12606
			internal readonly string Name;

			// Token: 0x0400313F RID: 12607
			private string[] _alternativeName;

			// Token: 0x04003140 RID: 12608
			internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression VarRef;

			// Token: 0x04003141 RID: 12609
			internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VarBasedKeyExpr;

			// Token: 0x04003142 RID: 12610
			internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GroupVarBasedKeyExpr;

			// Token: 0x04003143 RID: 12611
			internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GroupAggBasedKeyExpr;
		}

		// Token: 0x02000C7A RID: 3194
		// (Invoke) Token: 0x06006B79 RID: 27513
		private delegate global::System.Data.Entity.Core.Common.EntitySql.ExpressionResolution AstExprConverter(global::System.Data.Entity.Core.Common.EntitySql.AST.Node astExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr);

		// Token: 0x02000C7B RID: 3195
		// (Invoke) Token: 0x06006B7D RID: 27517
		private delegate global::System.Data.Entity.Core.Common.CommandTrees.DbExpression BuiltInExprConverter(global::System.Data.Entity.Core.Common.EntitySql.AST.BuiltInExpr astBltInExpr, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr);
	}
}
