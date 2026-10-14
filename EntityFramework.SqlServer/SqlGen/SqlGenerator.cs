using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000037 RID: 55
	internal class SqlGenerator : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000150A7 File Offset: 0x000132A7
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement CurrentSelectStatement
		{
			get
			{
				return this.selectStatementStack.Peek();
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000150B4 File Offset: 0x000132B4
		private bool IsParentAJoin
		{
			get
			{
				return this.isParentAJoinStack.Count != 0 && this.isParentAJoinStack.Peek();
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000150D0 File Offset: 0x000132D0
		internal global::System.Collections.Generic.Dictionary<string, int> AllExtentNames
		{
			get
			{
				return this.allExtentNames;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000150D8 File Offset: 0x000132D8
		internal global::System.Collections.Generic.Dictionary<string, int> AllColumnNames
		{
			get
			{
				return this.allColumnNames;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000150E0 File Offset: 0x000132E0
		public global::System.Collections.Generic.List<string> Targets
		{
			get
			{
				return this._targets;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000150E8 File Offset: 0x000132E8
		internal global::System.Data.Entity.SqlServer.SqlVersion SqlVersion
		{
			get
			{
				return this._sqlVersion;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000150F0 File Offset: 0x000132F0
		internal bool IsPreKatmai
		{
			get
			{
				return global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(this.SqlVersion);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00015100 File Offset: 0x00013300
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage IntegerType
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
				if ((result = this._integerType) == null)
				{
					result = (this._integerType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(this.StoreItemCollection.GetPrimitiveTypes().First((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType t) => t.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64)));
				}
				return result;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00015154 File Offset: 0x00013354
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection StoreItemCollection
		{
			get
			{
				return this._storeItemCollection;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001515C File Offset: 0x0001335C
		internal SqlGenerator()
		{
			this._sqlVersion = global::System.Data.Entity.SqlServer.SqlVersion.Sql11;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001518D File Offset: 0x0001338D
		internal SqlGenerator(global::System.Data.Entity.SqlServer.SqlVersion sqlVersion)
		{
			this._sqlVersion = sqlVersion;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000151C0 File Offset: 0x000133C0
		internal static string GenerateSql(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree tree, global::System.Data.Entity.SqlServer.SqlVersion sqlVersion, out global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> parameters, out global::System.Data.CommandType commandType, out global::System.Collections.Generic.HashSet<string> paramsToForceNonUnicode)
		{
			commandType = global::System.Data.CommandType.Text;
			parameters = null;
			paramsToForceNonUnicode = null;
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator = new global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator(sqlVersion);
			switch (tree.CommandTreeKind)
			{
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Query:
				return sqlGenerator.GenerateSql((global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree)tree, out paramsToForceNonUnicode);
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Update:
				return global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateUpdateSql((global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree)tree, sqlGenerator, out parameters, true, true);
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert:
				return global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateInsertSql((global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)tree, sqlGenerator, out parameters, true, true, true);
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete:
				return global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateDeleteSql((global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree)tree, sqlGenerator, out parameters, true, true);
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Function:
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GenerateFunctionSql((global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree)tree, out commandType);
			default:
				return null;
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00015250 File Offset: 0x00013450
		private static string GenerateFunctionSql(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree tree, out global::System.Data.CommandType commandType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = tree.EdmFunction;
			if (string.IsNullOrEmpty(edmFunction.CommandTextAttribute))
			{
				commandType = global::System.Data.CommandType.StoredProcedure;
				string name = string.IsNullOrEmpty(edmFunction.Schema) ? edmFunction.NamespaceName : edmFunction.Schema;
				string name2 = string.IsNullOrEmpty(edmFunction.StoreFunctionNameAttribute) ? edmFunction.Name : edmFunction.StoreFunctionNameAttribute;
				string str = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(name);
				string str2 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(name2);
				return str + "." + str2;
			}
			commandType = global::System.Data.CommandType.Text;
			return edmFunction.CommandTextAttribute;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000152D0 File Offset: 0x000134D0
		internal string GenerateSql(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree, out global::System.Collections.Generic.HashSet<string> paramsToForceNonUnicode)
		{
			this._targets = new global::System.Collections.Generic.List<string>();
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree = tree;
			if (this.SqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql8 && global::System.Data.Entity.SqlServer.SqlGen.Sql8ConformanceChecker.NeedsRewrite(tree.Query))
			{
				dbQueryCommandTree = global::System.Data.Entity.SqlServer.SqlGen.Sql8ExpressionRewriter.Rewrite(tree);
			}
			this._storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)dbQueryCommandTree.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			this.selectStatementStack = new global::System.Collections.Generic.Stack<global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement>();
			this.isParentAJoinStack = new global::System.Collections.Generic.Stack<bool>();
			this.allExtentNames = new global::System.Collections.Generic.Dictionary<string, int>(global::System.StringComparer.OrdinalIgnoreCase);
			this.allColumnNames = new global::System.Collections.Generic.Dictionary<string, int>(global::System.StringComparer.OrdinalIgnoreCase);
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlStatement;
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == dbQueryCommandTree.Query.ResultType.EdmType.BuiltInTypeKind)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitExpressionEnsureSqlStatement(dbQueryCommandTree.Query);
				sqlSelectStatement.IsTopMost = true;
				sqlStatement = sqlSelectStatement;
			}
			else
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				sqlBuilder.Append("SELECT ");
				sqlBuilder.Append(dbQueryCommandTree.Query.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				sqlStatement = sqlBuilder;
			}
			if (this.isVarRefSingle)
			{
				throw new global::System.NotSupportedException();
			}
			paramsToForceNonUnicode = new global::System.Collections.Generic.HashSet<string>(from p in this._candidateParametersToForceNonUnicode
			where p.Value
			select p into q
			select q.Key);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			using (global::System.Data.Entity.SqlServer.SqlGen.SqlWriter sqlWriter = new global::System.Data.Entity.SqlServer.SqlGen.SqlWriter(stringBuilder))
			{
				this.WriteSql(sqlWriter, sqlStatement);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00015448 File Offset: 0x00013648
		internal global::System.Data.Entity.SqlServer.SqlGen.SqlWriter WriteSql(global::System.Data.Entity.SqlServer.SqlGen.SqlWriter writer, global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlStatement)
		{
			sqlStatement.WriteSql(writer, this);
			return writer;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00015453 File Offset: 0x00013653
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(e, "e");
			return this.VisitBinaryExpression(" AND ", global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.And, e.Left, e.Right);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001547C File Offset: 0x0001367C
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(e, "e");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>();
			list.Add(e.Input);
			list.Add(e.Apply);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			string joinString;
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply)
				{
					throw new global::System.InvalidOperationException(string.Empty);
				}
				joinString = "OUTER APPLY";
			}
			else
			{
				joinString = "CROSS APPLY";
			}
			return this.VisitJoinExpression(list, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin, joinString, null);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000154EC File Offset: 0x000136EC
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(e, "e");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply)
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide)
				{
					return this.VisitBinaryExpression(" / ", e.ExpressionKind, e.Arguments[0], e.Arguments[1]);
				}
				switch (expressionKind)
				{
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus:
					return this.VisitBinaryExpression(" - ", e.ExpressionKind, e.Arguments[0], e.Arguments[1]);
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo:
					return this.VisitBinaryExpression(" % ", e.ExpressionKind, e.Arguments[0], e.Arguments[1]);
				case global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply:
					return this.VisitBinaryExpression(" * ", e.ExpressionKind, e.Arguments[0], e.Arguments[1]);
				}
			}
			else
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus)
				{
					return this.VisitBinaryExpression(" + ", e.ExpressionKind, e.Arguments[0], e.Arguments[1]);
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus)
				{
					global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
					sqlBuilder.Append(" -(");
					sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
					sqlBuilder.Append(")");
					return sqlBuilder;
				}
			}
			throw new global::System.InvalidOperationException(string.Empty);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001566C File Offset: 0x0001386C
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("CASE");
			for (int i = 0; i < e.When.Count; i++)
			{
				sqlBuilder.Append(" WHEN (");
				sqlBuilder.Append(e.When[i].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				sqlBuilder.Append(") THEN ");
				sqlBuilder.Append(e.Then[i].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			}
			if (e.Else != null && !(e.Else is global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression))
			{
				sqlBuilder.Append(" ELSE ");
				sqlBuilder.Append(e.Else.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			}
			sqlBuilder.Append(" END");
			return sqlBuilder;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00015730 File Offset: 0x00013930
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(e, "e");
			if (e.ResultType.IsSpatialType())
			{
				return e.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(" CAST( ");
			sqlBuilder.Append(e.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			sqlBuilder.Append(" AS ");
			sqlBuilder.Append(this.GetSqlPrimitiveType(e.ResultType));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000157B0 File Offset: 0x000139B0
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(e, "e");
			if (e.Left.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				this._forceNonUnicode = this.CheckIfForceNonUnicodeRequired(e);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals)
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals)
				{
					result = this.VisitComparisonExpression(" = ", e.Left, e.Right);
					goto IL_111;
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan)
				{
					result = this.VisitComparisonExpression(" > ", e.Left, e.Right);
					goto IL_111;
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals)
				{
					result = this.VisitComparisonExpression(" >= ", e.Left, e.Right);
					goto IL_111;
				}
			}
			else
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan)
				{
					result = this.VisitComparisonExpression(" < ", e.Left, e.Right);
					goto IL_111;
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals)
				{
					result = this.VisitComparisonExpression(" <= ", e.Left, e.Right);
					goto IL_111;
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals)
				{
					result = this.VisitComparisonExpression(" <> ", e.Left, e.Right);
					goto IL_111;
				}
			}
			throw new global::System.InvalidOperationException(string.Empty);
			IL_111:
			this._forceNonUnicode = false;
			return result;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000158D6 File Offset: 0x00013AD6
		private bool CheckIfForceNonUnicodeRequired(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			if (this._forceNonUnicode)
			{
				throw new global::System.NotSupportedException();
			}
			return this.MatchPatternForForcingNonUnicode(e);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000158F0 File Offset: 0x00013AF0
		private bool MatchPatternForForcingNonUnicode(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Like)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression dbLikeExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression)e;
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode(dbLikeExpression.Argument) && this.MatchTargetPatternForForcingNonUnicode(dbLikeExpression.Pattern) && this.MatchTargetPatternForForcingNonUnicode(dbLikeExpression.Escape);
			}
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.In)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression dbComparisonExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression)e;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = dbComparisonExpression.Left;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = dbComparisonExpression.Right;
				return (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode(left) && this.MatchTargetPatternForForcingNonUnicode(right)) || (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode(right) && this.MatchTargetPatternForForcingNonUnicode(left));
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode(((global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression)e).Item);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001598C File Offset: 0x00013B8C
		internal bool MatchTargetPatternForForcingNonUnicode(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
		{
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsConstParamOrNullExpressionUnicodeNotSpecified(expr))
			{
				return true;
			}
			if (expr.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression dbFunctionExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression)expr;
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function = dbFunctionExpression.Function;
				if (!function.IsCanonicalFunction() && !global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsStoreFunction(function))
				{
					return false;
				}
				string fullName = function.FullName;
				if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator._canonicalAndStoreStringFunctionsOneArg.Contains(fullName))
				{
					return this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[0]);
				}
				if ("Edm.Concat".Equals(fullName, global::System.StringComparison.Ordinal))
				{
					return this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[0]) && this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[1]);
				}
				if ("Edm.Replace".Equals(fullName, global::System.StringComparison.Ordinal) || "SqlServer.REPLACE".Equals(fullName, global::System.StringComparison.Ordinal))
				{
					return this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[0]) && this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[1]) && this.MatchTargetPatternForForcingNonUnicode(dbFunctionExpression.Arguments[2]);
				}
			}
			return false;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00015A88 File Offset: 0x00013C88
		private static bool MatchSourcePatternForForcingNonUnicode(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			bool flag;
			return argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property && argument.ResultType.TryGetIsUnicode(out flag) && !flag;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00015AB4 File Offset: 0x00013CB4
		internal static bool IsConstParamOrNullExpressionUnicodeNotSpecified(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = argument.ExpressionKind;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = argument.ResultType;
			bool flag;
			return resultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) && (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant || expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference || expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null) && !resultType.TryGetFacetValue("Unicode", out flag);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00015AFC File Offset: 0x00013CFC
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment VisitConstant(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e, bool isCastOptional)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = e.ResultType;
			if (resultType.IsPrimitiveType())
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = resultType.GetPrimitiveTypeKind();
				switch (primitiveTypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
					sqlBuilder.Append(" 0x");
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.ByteArrayToBinaryString((byte[])e.Value));
					sqlBuilder.Append(" ");
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(!isCastOptional, ((bool)e.Value) ? "1" : "0", "bit", sqlBuilder);
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(!isCastOptional, e.Value.ToString(), "tinyint", sqlBuilder);
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
					sqlBuilder.Append("convert(");
					sqlBuilder.Append(this.IsPreKatmai ? "datetime" : "datetime2");
					sqlBuilder.Append(", ");
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(((global::System.DateTime)e.Value).ToString(this.IsPreKatmai ? "yyyy-MM-dd HH:mm:ss.fff" : "yyyy-MM-dd HH:mm:ss.fffffff", global::System.Globalization.CultureInfo.InvariantCulture), false));
					sqlBuilder.Append(", 121)");
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				{
					string text = ((decimal)e.Value).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					bool cast = -1 == text.IndexOf('.') && text.TrimStart(new char[]
					{
						'-'
					}).Length < 20;
					string typeName = "decimal(" + global::System.Math.Max((byte)text.Length, 18).ToString(global::System.Globalization.CultureInfo.InvariantCulture) + ")";
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(cast, text, typeName, sqlBuilder);
					return sqlBuilder;
				}
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				{
					double value = (double)e.Value;
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AssertValidDouble(value);
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(true, value.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture), "float(53)", sqlBuilder);
					return sqlBuilder;
				}
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(true, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(e.Value.ToString(), false), "uniqueidentifier", sqlBuilder);
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				{
					float value2 = (float)e.Value;
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AssertValidSingle(value2);
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(true, value2.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture), "real", sqlBuilder);
					return sqlBuilder;
				}
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(!isCastOptional, e.Value.ToString(), "smallint", sqlBuilder);
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
					sqlBuilder.Append(e.Value.ToString());
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapWithCastIfNeeded(!isCastOptional, e.Value.ToString(), "bigint", sqlBuilder);
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				{
					bool isUnicode;
					if (!e.ResultType.TryGetIsUnicode(out isUnicode))
					{
						isUnicode = !this._forceNonUnicode;
					}
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(e.Value as string, isUnicode));
					return sqlBuilder;
				}
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
					this.AssertKatmaiOrNewer(primitiveTypeKind);
					sqlBuilder.Append("convert(");
					sqlBuilder.Append(e.ResultType.EdmType.Name);
					sqlBuilder.Append(", ");
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(e.Value.ToString(), false));
					sqlBuilder.Append(", 121)");
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
					this.AssertKatmaiOrNewer(primitiveTypeKind);
					sqlBuilder.Append("convert(");
					sqlBuilder.Append(e.ResultType.EdmType.Name);
					sqlBuilder.Append(", ");
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(((global::System.DateTimeOffset)e.Value).ToString("yyyy-MM-dd HH:mm:ss.fffffff zzz", global::System.Globalization.CultureInfo.InvariantCulture), false));
					sqlBuilder.Append(", 121)");
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
					this.AppendSpatialConstant(sqlBuilder, ((global::System.Data.Entity.Spatial.DbGeometry)e.Value).AsSpatialValue());
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
					this.AppendSpatialConstant(sqlBuilder, ((global::System.Data.Entity.Spatial.DbGeography)e.Value).AsSpatialValue());
					return sqlBuilder;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AppendHierarchyConstant(sqlBuilder, (global::System.Data.Entity.Hierarchy.HierarchyId)e.Value);
					return sqlBuilder;
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.NoStoreTypeForEdmType(resultType.EdmType.Name, ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)resultType.EdmType).PrimitiveTypeKind));
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00015F80 File Offset: 0x00014180
		private static void AppendHierarchyConstant(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result, global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId)
		{
			result.Append("cast(");
			result.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.EscapeSingleQuote(hierarchyId.ToString(), false));
			result.Append(" as hierarchyid)");
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00015FAC File Offset: 0x000141AC
		private void AppendSpatialConstant(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result, global::System.Data.Entity.SqlServer.IDbSpatialValue spatialValue)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression dbFunctionExpression = null;
			int? coordinateSystemId = spatialValue.CoordinateSystemId;
			if (coordinateSystemId != null)
			{
				string wellKnownText = spatialValue.WellKnownText;
				if (wellKnownText != null)
				{
					dbFunctionExpression = (spatialValue.IsGeography ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeographyFromText(wellKnownText, new int?(coordinateSystemId.Value)) : global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeometryFromText(wellKnownText, new int?(coordinateSystemId.Value)));
				}
				else
				{
					byte[] wellKnownBinary = spatialValue.WellKnownBinary;
					if (wellKnownBinary != null)
					{
						dbFunctionExpression = (spatialValue.IsGeography ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeographyFromBinary(wellKnownBinary, new int?(coordinateSystemId.Value)) : global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeometryFromBinary(wellKnownBinary, new int?(coordinateSystemId.Value)));
					}
					else
					{
						string gmlString = spatialValue.GmlString;
						if (gmlString != null)
						{
							dbFunctionExpression = (spatialValue.IsGeography ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeographyFromGml(gmlString, new int?(coordinateSystemId.Value)) : global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial.SpatialEdmFunctions.GeometryFromGml(gmlString, new int?(coordinateSystemId.Value)));
						}
					}
				}
			}
			if (dbFunctionExpression != null)
			{
				result.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.GenerateFunctionCallSql(this, dbFunctionExpression));
				return;
			}
			throw spatialValue.NotSqlCompatible();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000160D8 File Offset: 0x000142D8
		private static void AssertValidDouble(double value)
		{
			if (double.IsNaN(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedNaNNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double)));
			}
			if (double.IsPositiveInfinity(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedPositiveInfinityNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double), typeof(double).Name));
			}
			if (double.IsNegativeInfinity(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedNegativeInfinityNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double), typeof(double).Name));
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001617C File Offset: 0x0001437C
		private static void AssertValidSingle(float value)
		{
			if (float.IsNaN(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedNaNNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single)));
			}
			if (float.IsPositiveInfinity(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedPositiveInfinityNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single), typeof(float).Name));
			}
			if (float.IsNegativeInfinity(value))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_TypedNegativeInfinityNotSupported(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single), typeof(float).Name));
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001621F File Offset: 0x0001441F
		private static void WrapWithCastIfNeeded(bool cast, string value, string typeName, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			if (!cast)
			{
				result.Append(value);
				return;
			}
			result.Append("cast(");
			result.Append(value);
			result.Append(" as ");
			result.Append(typeName);
			result.Append(")");
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001625B File Offset: 0x0001445B
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(e, "e");
			return this.VisitConstant(e, false);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00016271 File Offset: 0x00014471
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00016284 File Offset: 0x00014484
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitExpressionEnsureSqlStatement(e.Argument);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = e.Argument.ResultType.GetElementTypeUsage();
				global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, "distinct", elementTypeUsage, out fromSymbol);
				this.AddFromSymbol(sqlSelectStatement, "distinct", fromSymbol, false);
			}
			sqlSelectStatement.Select.IsDistinct = true;
			return sqlSelectStatement;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000162F4 File Offset: 0x000144F4
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("(");
			sqlBuilder.Append(this.VisitExpressionEnsureSqlStatement(e.Argument));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001632F File Offset: 0x0001452F
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
			return this.VisitSetOpExpression(e, "EXCEPT");
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00016349 File Offset: 0x00014549
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(e, "e");
			throw new global::System.InvalidOperationException(string.Empty);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00016364 File Offset: 0x00014564
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(e, "e");
			string targetTSql = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GetTargetTSql(e.Target);
			if (this._targets != null)
			{
				this._targets.Add(targetTSql);
			}
			if (this.IsParentAJoin)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				sqlBuilder.Append(targetTSql);
				return sqlBuilder;
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
			sqlSelectStatement.From.Append(targetTSql);
			return sqlSelectStatement;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000163C4 File Offset: 0x000145C4
		internal static string GetTargetTSql(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			string metadataPropertyValue = entitySetBase.GetMetadataPropertyValue("DefiningQuery");
			if (metadataPropertyValue != null)
			{
				return "(" + metadataPropertyValue + ")";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(50);
			string metadataPropertyValue2 = entitySetBase.GetMetadataPropertyValue("Schema");
			if (!string.IsNullOrEmpty(metadataPropertyValue2))
			{
				stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(metadataPropertyValue2));
				stringBuilder.Append(".");
			}
			else
			{
				stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(entitySetBase.EntityContainer.Name));
				stringBuilder.Append(".");
			}
			string metadataPropertyValue3 = entitySetBase.GetMetadataPropertyValue("Table");
			stringBuilder.Append(string.IsNullOrEmpty(metadataPropertyValue3) ? global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(entitySetBase.Name) : global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(metadataPropertyValue3));
			return stringBuilder.ToString();
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001647F File Offset: 0x0001467F
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(e, "e");
			return this.VisitFilterExpression(e.Input, e.Predicate, false);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000164A0 File Offset: 0x000146A0
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(e, "e");
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.GenerateFunctionCallSql(this, e);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000164B5 File Offset: 0x000146B5
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000164C8 File Offset: 0x000146C8
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000164DB File Offset: 0x000146DB
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000164F0 File Offset: 0x000146F0
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol;
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitInputExpression(e.Input.Expression, e.Input.VariableName, e.Input.VariableType, out symbol);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, e.Input.VariableName, e.Input.VariableType, out symbol);
			}
			this.selectStatementStack.Push(sqlSelectStatement);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement, e.Input.VariableName, symbol);
			this.symbolTable.Add(e.Input.GroupVariableName, symbol);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)e.ResultType.EdmType).TypeUsage.EdmType;
			bool flag = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByAggregatesNeedInnerQuery(e.Aggregates, e.Input.GroupVariableName) || global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByKeysNeedInnerQuery(e.Keys, e.Input.VariableName);
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement2;
			if (flag)
			{
				sqlSelectStatement2 = this.CreateNewSelectStatement(sqlSelectStatement, e.Input.VariableName, e.Input.VariableType, false, out symbol);
				this.AddFromSymbol(sqlSelectStatement2, e.Input.VariableName, symbol, false);
			}
			else
			{
				sqlSelectStatement2 = sqlSelectStatement;
			}
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = rowType.Properties.GetEnumerator())
			{
				enumerator.MoveNext();
				string s = "";
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.Keys)
				{
					string s2 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(enumerator.Current.Name);
					sqlSelectStatement2.GroupBy.Append(s);
					global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment s3 = dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
					if (!flag)
					{
						sqlSelectStatement2.Select.Append(s);
						sqlSelectStatement2.Select.AppendLine();
						sqlSelectStatement2.Select.Append(s3);
						sqlSelectStatement2.Select.Append(" AS ");
						sqlSelectStatement2.Select.Append(s2);
						sqlSelectStatement2.GroupBy.Append(s3);
					}
					else
					{
						sqlSelectStatement.Select.Append(s);
						sqlSelectStatement.Select.AppendLine();
						sqlSelectStatement.Select.Append(s3);
						sqlSelectStatement.Select.Append(" AS ");
						sqlSelectStatement.Select.Append(s2);
						sqlSelectStatement2.Select.Append(s);
						sqlSelectStatement2.Select.AppendLine();
						sqlSelectStatement2.Select.Append(symbol);
						sqlSelectStatement2.Select.Append(".");
						sqlSelectStatement2.Select.Append(s2);
						sqlSelectStatement2.Select.Append(" AS ");
						sqlSelectStatement2.Select.Append(s2);
						sqlSelectStatement2.GroupBy.Append(s2);
					}
					s = ", ";
					enumerator.MoveNext();
				}
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate dbAggregate in e.Aggregates)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = enumerator.Current;
					string s4 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(edmProperty.Name);
					global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
					for (int i = 0; i < dbAggregate.Arguments.Count; i++)
					{
						global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment = dbAggregate.Arguments[i].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
						object item;
						if (flag)
						{
							string s5 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(edmProperty.Name + "_" + i.ToString());
							global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
							sqlBuilder.Append(symbol);
							sqlBuilder.Append(".");
							sqlBuilder.Append(s5);
							item = sqlBuilder;
							sqlSelectStatement.Select.Append(s);
							sqlSelectStatement.Select.AppendLine();
							sqlSelectStatement.Select.Append(sqlFragment);
							sqlSelectStatement.Select.Append(" AS ");
							sqlSelectStatement.Select.Append(s5);
						}
						else
						{
							item = sqlFragment;
						}
						list.Add(item);
					}
					global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment s6 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.VisitAggregate(dbAggregate, list);
					sqlSelectStatement2.Select.Append(s);
					sqlSelectStatement2.Select.AppendLine();
					sqlSelectStatement2.Select.Append(s6);
					sqlSelectStatement2.Select.Append(" AS ");
					sqlSelectStatement2.Select.Append(s4);
					s = ", ";
					enumerator.MoveNext();
				}
			}
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			return sqlSelectStatement2;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000169AC File Offset: 0x00014BAC
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
			return this.VisitSetOpExpression(e, "INTERSECT");
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000169C6 File Offset: 0x00014BC6
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(e, "e");
			return this.VisitIsEmptyExpression(e, false);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000169DC File Offset: 0x00014BDC
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(e, "e");
			return this.VisitIsNullExpression(e, false);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000169F2 File Offset: 0x00014BF2
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00016A05 File Offset: 0x00014C05
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(e, "e");
			return this.VisitJoinExpression(e.Inputs, e.ExpressionKind, "CROSS JOIN", null);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00016A2C File Offset: 0x00014C2C
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(e, "e");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			string joinString;
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin)
				{
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin)
					{
						joinString = null;
					}
					else
					{
						joinString = "LEFT OUTER JOIN";
					}
				}
				else
				{
					joinString = "INNER JOIN";
				}
			}
			else
			{
				joinString = "FULL OUTER JOIN";
			}
			return this.VisitJoinExpression(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(2)
			{
				e.Left,
				e.Right
			}, e.ExpressionKind, joinString, e.JoinCondition);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00016AAC File Offset: 0x00014CAC
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(e, "e");
			this._forceNonUnicode = this.CheckIfForceNonUnicodeRequired(e);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(e.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			sqlBuilder.Append(" LIKE ");
			sqlBuilder.Append(e.Pattern.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			if (e.Escape.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
			{
				sqlBuilder.Append(" ESCAPE ");
				sqlBuilder.Append(e.Escape.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			}
			this._forceNonUnicode = false;
			return sqlBuilder;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00016B3C File Offset: 0x00014D3C
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitExpressionEnsureSqlStatement(e.Argument, false, false);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = e.Argument.ResultType.GetElementTypeUsage();
				global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, "top", elementTypeUsage, out fromSymbol);
				this.AddFromSymbol(sqlSelectStatement, "top", fromSymbol, false);
			}
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment topCount = this.HandleCountExpression(e.Limit);
			sqlSelectStatement.Select.Top = new global::System.Data.Entity.SqlServer.SqlGen.TopClause(topCount, e.WithTies);
			return sqlSelectStatement;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00016BC6 File Offset: 0x00014DC6
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(e, "e");
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == e.ResultType.EdmType.BuiltInTypeKind)
			{
				return this.VisitCollectionConstructor(e);
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(e, "e");
			global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression dbNotExpression = e.Argument as global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression;
			if (dbNotExpression != null)
			{
				return dbNotExpression.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression dbIsEmptyExpression = e.Argument as global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression;
			if (dbIsEmptyExpression != null)
			{
				return this.VisitIsEmptyExpression(dbIsEmptyExpression, true);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression dbIsNullExpression = e.Argument as global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression;
			if (dbIsNullExpression != null)
			{
				return this.VisitIsNullExpression(dbIsNullExpression, true);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression dbComparisonExpression = e.Argument as global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression;
			if (dbComparisonExpression != null && dbComparisonExpression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals)
			{
				bool forceNonUnicode = this._forceNonUnicode;
				if (dbComparisonExpression.Left.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
				{
					this._forceNonUnicode = this.CheckIfForceNonUnicodeRequired(dbComparisonExpression);
				}
				global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment result = this.VisitComparisonExpression(" <> ", dbComparisonExpression.Left, dbComparisonExpression.Right);
				this._forceNonUnicode = forceNonUnicode;
				return result;
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(" NOT (");
			sqlBuilder.Append(e.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00016CE8 File Offset: 0x00014EE8
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("CAST(NULL AS ");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType = e.ResultType;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = (resultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType).PrimitiveTypeKind;
			if (primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
				{
					sqlBuilder.Append("varchar(1)");
				}
				else
				{
					sqlBuilder.Append(this.GetSqlPrimitiveType(resultType));
				}
			}
			else
			{
				sqlBuilder.Append("varbinary(1)");
			}
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00016D65 File Offset: 0x00014F65
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00016D78 File Offset: 0x00014F78
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment result = null;
			if (this.TryTranslateIntoIn(e, out result))
			{
				return result;
			}
			return this.VisitBinaryExpression(" OR ", e.ExpressionKind, e.Left, e.Right);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00016DC0 File Offset: 0x00014FC0
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(e, "e");
			if (e.List.Count == 0)
			{
				return this.Visit(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False);
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			if (e.Item.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				this._forceNonUnicode = this.CheckIfForceNonUnicodeRequired(e);
			}
			sqlBuilder.Append(e.Item.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			sqlBuilder.Append(" IN (");
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.List)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					sqlBuilder.Append(", ");
				}
				sqlBuilder.Append(dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			}
			sqlBuilder.Append(")");
			this._forceNonUnicode = false;
			return sqlBuilder;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00016EA4 File Offset: 0x000150A4
		internal static global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> HasBuiltMapForIn(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(new global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.KeyFieldExpressionComparer());
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.HasBuiltMapForIn(expression, dictionary))
			{
				return null;
			}
			return dictionary;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00016EC8 File Offset: 0x000150C8
		private bool TryTranslateIntoIn(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e, out global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment)
		{
			global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> dictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.HasBuiltMapForIn(e);
			if (dictionary == null)
			{
				sqlFragment = null;
				return false;
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in dictionary.Keys)
			{
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> source = dictionary[dbExpression];
				if (!flag)
				{
					sqlBuilder.Append(" OR ");
				}
				else
				{
					flag = false;
				}
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> enumerable = from v in source
				where v.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull
				select v;
				int num = enumerable.Count<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				bool flag2 = false;
				bool forceNonUnicodeOnKey = false;
				if (dbExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
				{
					flag2 = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode(dbExpression);
					forceNonUnicodeOnKey = (!flag2 && this.MatchTargetPatternForForcingNonUnicode(dbExpression) && enumerable.All(new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool>(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.MatchSourcePatternForForcingNonUnicode)));
				}
				if (num == 1)
				{
					this.HandleInKey(sqlBuilder, dbExpression, forceNonUnicodeOnKey);
					sqlBuilder.Append(" = ");
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = enumerable.First<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
					this.HandleInValue(sqlBuilder, dbExpression2, dbExpression.ResultType.EdmType == dbExpression2.ResultType.EdmType, flag2);
				}
				if (num > 1)
				{
					this.HandleInKey(sqlBuilder, dbExpression, forceNonUnicodeOnKey);
					sqlBuilder.Append(" IN (");
					bool flag3 = true;
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression3 in enumerable)
					{
						if (!flag3)
						{
							sqlBuilder.Append(",");
						}
						else
						{
							flag3 = false;
						}
						this.HandleInValue(sqlBuilder, dbExpression3, dbExpression.ResultType.EdmType == dbExpression3.ResultType.EdmType, flag2);
					}
					sqlBuilder.Append(")");
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression dbIsNullExpression = source.FirstOrDefault((global::System.Data.Entity.Core.Common.CommandTrees.DbExpression v) => v.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull) as global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression;
				if (dbIsNullExpression != null)
				{
					if (num > 0)
					{
						sqlBuilder.Append(" OR ");
					}
					sqlBuilder.Append(this.VisitIsNullExpression(dbIsNullExpression, false));
				}
			}
			sqlFragment = sqlBuilder;
			return true;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00017110 File Offset: 0x00015310
		private void HandleInValue(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value, bool isSameEdmType, bool forceNonUnicodeOnQualifyingValues)
		{
			this.ForcingNonUnicode(delegate
			{
				this.ParenthesizeExpressionWithoutRedundantConstantCasts(value, sqlBuilder, isSameEdmType);
			}, forceNonUnicodeOnQualifyingValues && this.MatchTargetPatternForForcingNonUnicode(value));
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00017164 File Offset: 0x00015364
		private void HandleInKey(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key, bool forceNonUnicodeOnKey)
		{
			this.ForcingNonUnicode(delegate
			{
				this.ParenthesizeExpressionIfNeeded(key, sqlBuilder);
			}, forceNonUnicodeOnKey);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000171A0 File Offset: 0x000153A0
		private void ForcingNonUnicode(global::System.Action action, bool forceNonUnicode)
		{
			bool flag = false;
			if (forceNonUnicode && !this._forceNonUnicode)
			{
				this._forceNonUnicode = true;
				flag = true;
			}
			action();
			if (flag)
			{
				this._forceNonUnicode = false;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000171D3 File Offset: 0x000153D3
		private void ParenthesizeExpressionWithoutRedundantConstantCasts(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder, bool isSameEdmType)
		{
			if (value.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				sqlBuilder.Append(this.VisitConstant((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)value, isSameEdmType));
				return;
			}
			this.ParenthesizeExpressionIfNeeded(value, sqlBuilder);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000171FA File Offset: 0x000153FA
		internal static bool IsKeyForIn(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			return e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property || e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference || e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001721C File Offset: 0x0001541C
		internal static bool TryAddExpressionForIn(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression e, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> values)
		{
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsKeyForIn(e.Left))
			{
				values.Add(e.Left, e.Right);
				return true;
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsKeyForIn(e.Right))
			{
				values.Add(e.Right, e.Left);
				return true;
			}
			return false;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001726C File Offset: 0x0001546C
		internal static bool HasBuiltMapForIn(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> values)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.TryAddExpressionForIn((global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression)e, values);
			}
			if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsNull)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression dbBinaryExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression)e;
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.HasBuiltMapForIn(dbBinaryExpression.Left, values) && global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.HasBuiltMapForIn(dbBinaryExpression.Right, values);
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument = ((global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression)e).Argument;
				if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsKeyForIn(argument))
				{
					values.Add(argument, e);
					return true;
				}
				return false;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000172E4 File Offset: 0x000154E4
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(e, "e");
			if (!this._ignoreForceNonUnicodeFlag)
			{
				if (!this._forceNonUnicode)
				{
					this._candidateParametersToForceNonUnicode[e.ParameterName] = false;
				}
				else if (!this._candidateParametersToForceNonUnicode.ContainsKey(e.ParameterName))
				{
					this._candidateParametersToForceNonUnicode[e.ParameterName] = true;
				}
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("@" + e.ParameterName);
			return sqlBuilder;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00017364 File Offset: 0x00015564
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitInputExpression(e.Input.Expression, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			bool flag = false;
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			}
			else if (this.SqlVersion == global::System.Data.Entity.SqlServer.SqlVersion.Sql8 && !sqlSelectStatement.OrderBy.IsEmpty)
			{
				flag = true;
			}
			this.selectStatementStack.Push(sqlSelectStatement);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement, e.Input.VariableName, fromSymbol);
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = e.Projection as global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression;
			if (dbNewInstanceExpression != null)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> outputColumns;
				sqlSelectStatement.Select.Append(this.VisitNewInstanceExpression(dbNewInstanceExpression, flag, out outputColumns));
				if (flag)
				{
					sqlSelectStatement.OutputColumnsRenamed = true;
				}
				sqlSelectStatement.OutputColumns = outputColumns;
			}
			else
			{
				sqlSelectStatement.Select.Append(e.Projection.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			}
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			return sqlSelectStatement;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00017484 File Offset: 0x00015684
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment = e.Instance.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
			if (e.Instance is global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)
			{
				this.isVarRefSingle = false;
			}
			global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = sqlFragment as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
			if (joinSymbol == null)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SymbolPair symbolPair = sqlFragment as global::System.Data.Entity.SqlServer.SqlGen.SymbolPair;
				global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder;
				if (symbolPair != null)
				{
					global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol2 = symbolPair.Column as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
					if (joinSymbol2 != null)
					{
						symbolPair.Column = joinSymbol2.NameToExtent[e.Property.Name];
						return symbolPair;
					}
					if (symbolPair.Column.Columns.ContainsKey(e.Property.Name))
					{
						sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
						sqlBuilder.Append(symbolPair.Source);
						sqlBuilder.Append(".");
						global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol = symbolPair.Column.Columns[e.Property.Name];
						this.optionalColumnUsageManager.MarkAsUsed(symbol);
						sqlBuilder.Append(symbol);
						return sqlBuilder;
					}
				}
				sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				sqlBuilder.Append(sqlFragment);
				sqlBuilder.Append(".");
				global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol2 = sqlFragment as global::System.Data.Entity.SqlServer.SqlGen.Symbol;
				global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol3;
				if (symbol2 != null && symbol2.OutputColumns.TryGetValue(e.Property.Name, out symbol3))
				{
					this.optionalColumnUsageManager.MarkAsUsed(symbol3);
					if (symbol2.OutputColumnsRenamed)
					{
						sqlBuilder.Append(symbol3);
					}
					else
					{
						sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(e.Property.Name));
					}
				}
				else
				{
					sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(e.Property.Name));
				}
				return sqlBuilder;
			}
			if (joinSymbol.IsNestedJoin)
			{
				return new global::System.Data.Entity.SqlServer.SqlGen.SymbolPair(joinSymbol, joinSymbol.NameToExtent[e.Property.Name]);
			}
			return joinSymbol.NameToExtent[e.Property.Name];
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00017640 File Offset: 0x00015840
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			bool negatePredicate = e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All;
			if (e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any)
			{
				sqlBuilder.Append("EXISTS (");
			}
			else
			{
				sqlBuilder.Append("NOT EXISTS (");
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitFilterExpression(e.Input, e.Predicate, negatePredicate);
			if (sqlSelectStatement.Select.IsEmpty)
			{
				this.AddDefaultColumns(sqlSelectStatement);
			}
			sqlBuilder.Append(sqlSelectStatement);
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000176C6 File Offset: 0x000158C6
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000176D9 File Offset: 0x000158D9
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000176EC File Offset: 0x000158EC
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitInputExpression(e.Input.Expression, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			}
			this.selectStatementStack.Push(sqlSelectStatement);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement, e.Input.VariableName, fromSymbol);
			if (this.SqlVersion >= global::System.Data.Entity.SqlServer.SqlVersion.Sql11)
			{
				sqlSelectStatement.Select.Skip = new global::System.Data.Entity.SqlServer.SqlGen.SkipClause(this.HandleCountExpression(e.Count));
				if (global::System.Data.Entity.SqlServer.SqlProviderServices.UseRowNumberOrderingInOffsetQueries)
				{
					sqlSelectStatement.OrderBy.Append("row_number() OVER (ORDER BY ");
					this.AddSortKeys(sqlSelectStatement.OrderBy, e.SortOrder);
					sqlSelectStatement.OrderBy.Append(")");
				}
				else
				{
					this.AddSortKeys(sqlSelectStatement.OrderBy, e.SortOrder);
				}
				this.symbolTable.ExitScope();
				this.selectStatementStack.Pop();
				return sqlSelectStatement;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> list = this.AddDefaultColumns(sqlSelectStatement);
			sqlSelectStatement.Select.Append("row_number() OVER (ORDER BY ");
			this.AddSortKeys(sqlSelectStatement.Select, e.SortOrder);
			sqlSelectStatement.Select.Append(") AS ");
			string row_numberName = "row_number";
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(row_numberName, this.IntegerType);
			if (list.Any((global::System.Data.Entity.SqlServer.SqlGen.Symbol c) => string.Equals(c.Name, row_numberName, global::System.StringComparison.OrdinalIgnoreCase)))
			{
				symbol.NeedsRenaming = true;
			}
			sqlSelectStatement.Select.Append(symbol);
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement2 = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
			sqlSelectStatement2.From.Append("( ");
			sqlSelectStatement2.From.Append(sqlSelectStatement);
			sqlSelectStatement2.From.AppendLine();
			sqlSelectStatement2.From.Append(") ");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol2 = null;
			if (sqlSelectStatement.FromExtents.Count == 1)
			{
				global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = sqlSelectStatement.FromExtents[0] as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
				if (joinSymbol != null)
				{
					symbol2 = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(e.Input.VariableName, e.Input.VariableType, joinSymbol.ExtentList)
					{
						IsNestedJoin = true,
						ColumnList = list,
						FlattenedExtentList = joinSymbol.FlattenedExtentList
					};
				}
			}
			if (symbol2 == null)
			{
				symbol2 = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(e.Input.VariableName, e.Input.VariableType, sqlSelectStatement.OutputColumns, false);
			}
			this.selectStatementStack.Push(sqlSelectStatement2);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement2, e.Input.VariableName, symbol2);
			sqlSelectStatement2.Where.Append(symbol2);
			sqlSelectStatement2.Where.Append(".");
			sqlSelectStatement2.Where.Append(symbol);
			sqlSelectStatement2.Where.Append(" > ");
			sqlSelectStatement2.Where.Append(this.HandleCountExpression(e.Count));
			this.AddSortKeys(sqlSelectStatement2.OrderBy, e.SortOrder);
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			return sqlSelectStatement2;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00017A34 File Offset: 0x00015C34
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(e, "e");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitInputExpression(e.Input.Expression, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, e.ExpressionKind))
			{
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, e.Input.VariableName, e.Input.VariableType, out fromSymbol);
			}
			this.selectStatementStack.Push(sqlSelectStatement);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement, e.Input.VariableName, fromSymbol);
			this.AddSortKeys(sqlSelectStatement.OrderBy, e.SortOrder);
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			return sqlSelectStatement;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00017AF9 File Offset: 0x00015CF9
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(e, "e");
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00017B0C File Offset: 0x00015D0C
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(e, "e");
			return this.VisitSetOpExpression(e, "UNION ALL");
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00017B28 File Offset: 0x00015D28
		public override global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(e, "e");
			if (this.isVarRefSingle)
			{
				throw new global::System.NotSupportedException();
			}
			this.isVarRefSingle = true;
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol = this.symbolTable.Lookup(e.VariableName);
			this.optionalColumnUsageManager.MarkAsUsed(symbol);
			if (!this.CurrentSelectStatement.FromExtents.Contains(symbol))
			{
				this.CurrentSelectStatement.OuterExtents[symbol] = true;
			}
			return symbol;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00017B9C File Offset: 0x00015D9C
		private static global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder VisitAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate aggregate, global::System.Collections.Generic.IList<object> aggregateArguments)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = aggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate;
			if (dbFunctionAggregate == null)
			{
				throw new global::System.NotSupportedException();
			}
			if (dbFunctionAggregate.Function.IsCanonicalFunction() && string.Equals(dbFunctionAggregate.Function.Name, "BigCount", global::System.StringComparison.Ordinal))
			{
				sqlBuilder.Append("COUNT_BIG");
			}
			else
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionName(sqlBuilder, dbFunctionAggregate.Function);
			}
			sqlBuilder.Append("(");
			global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate2 = dbFunctionAggregate;
			if (dbFunctionAggregate2 != null && dbFunctionAggregate2.Distinct)
			{
				sqlBuilder.Append("DISTINCT ");
			}
			string s = string.Empty;
			foreach (object s2 in aggregateArguments)
			{
				sqlBuilder.Append(s);
				sqlBuilder.Append(s2);
				s = ", ";
			}
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00017C84 File Offset: 0x00015E84
		internal void ParenthesizeExpressionIfNeeded(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsComplexExpression(e))
			{
				result.Append("(");
				result.Append(e.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				result.Append(")");
				return;
			}
			result.Append(e.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00017CC0 File Offset: 0x00015EC0
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder VisitBinaryExpression(string op, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.RemoveUnnecessaryCasts(ref left, ref right);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e in global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.FlattenAssociativeExpression(expressionKind, left, right))
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					sqlBuilder.Append(op);
				}
				this.ParenthesizeExpressionIfNeeded(e, sqlBuilder);
			}
			return sqlBuilder;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00017D34 File Offset: 0x00015F34
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> FlattenAssociativeExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			if (kind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or && kind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.And && kind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus && kind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply)
			{
				return new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					left,
					right
				};
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.ExtractAssociativeArguments(kind, list, left);
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.ExtractAssociativeArguments(kind, list, right);
			return list;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00017D7C File Offset: 0x00015F7C
		private static void ExtractAssociativeArguments(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> argumentList, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> leafNodes = expression.GetLeafNodes(expressionKind, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression dbBinaryExpression = exp as global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression;
				if (dbBinaryExpression != null)
				{
					return new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbBinaryExpression.Left,
						dbBinaryExpression.Right
					};
				}
				return ((global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression)exp).Arguments;
			});
			argumentList.AddRange(leafNodes);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00017DB8 File Offset: 0x00015FB8
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder VisitComparisonExpression(string op, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.RemoveUnnecessaryCasts(ref left, ref right);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			bool isCastOptional = left.ResultType.EdmType == right.ResultType.EdmType;
			if (left.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				sqlBuilder.Append(this.VisitConstant((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)left, isCastOptional));
			}
			else
			{
				this.ParenthesizeExpressionIfNeeded(left, sqlBuilder);
			}
			sqlBuilder.Append(op);
			if (right.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				sqlBuilder.Append(this.VisitConstant((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)right, isCastOptional));
			}
			else
			{
				this.ParenthesizeExpressionIfNeeded(right, sqlBuilder);
			}
			return sqlBuilder;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00017E44 File Offset: 0x00016044
		private static void RemoveUnnecessaryCasts(ref global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, ref global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			if (left.ResultType.EdmType != right.ResultType.EdmType)
			{
				return;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression dbCastExpression = left as global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression;
			if (dbCastExpression != null && dbCastExpression.Argument.ResultType.EdmType == left.ResultType.EdmType)
			{
				left = dbCastExpression.Argument;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression dbCastExpression2 = right as global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression;
			if (dbCastExpression2 != null && dbCastExpression2.Argument.ResultType.EdmType == left.ResultType.EdmType)
			{
				right = dbCastExpression2.Argument;
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00017ED0 File Offset: 0x000160D0
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement VisitInputExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inputExpression, string inputVarName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage inputVarType, out global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol)
		{
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment = inputExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = sqlFragment as global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement;
			if (sqlSelectStatement == null)
			{
				sqlSelectStatement = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
				global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapNonQueryExtent(sqlSelectStatement, sqlFragment, inputExpression.ExpressionKind);
			}
			if (sqlSelectStatement.FromExtents.Count == 0)
			{
				fromSymbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(inputVarName, inputVarType);
			}
			else if (sqlSelectStatement.FromExtents.Count == 1)
			{
				fromSymbol = sqlSelectStatement.FromExtents[0];
			}
			else
			{
				fromSymbol = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(inputVarName, inputVarType, sqlSelectStatement.FromExtents)
				{
					FlattenedExtentList = sqlSelectStatement.AllJoinExtents
				};
				sqlSelectStatement.FromExtents.Clear();
				sqlSelectStatement.FromExtents.Add(fromSymbol);
			}
			return sqlSelectStatement;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017F74 File Offset: 0x00016174
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder VisitIsEmptyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e, bool negate)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			if (!negate)
			{
				sqlBuilder.Append(" NOT");
			}
			sqlBuilder.Append(" EXISTS (");
			sqlBuilder.Append(this.VisitExpressionEnsureSqlStatement(e.Argument));
			sqlBuilder.AppendLine();
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00017FC4 File Offset: 0x000161C4
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment VisitCollectionConstructor(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
		{
			if (e.Arguments.Count == 1 && e.Arguments[0].ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression dbElementExpression = e.Arguments[0] as global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression;
				global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitExpressionEnsureSqlStatement(dbElementExpression.Argument);
				if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element))
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementTypeUsage = dbElementExpression.Argument.ResultType.GetElementTypeUsage();
					global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
					sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, "element", elementTypeUsage, out fromSymbol);
					this.AddFromSymbol(sqlSelectStatement, "element", fromSymbol, false);
				}
				sqlSelectStatement.Select.Top = new global::System.Data.Entity.SqlServer.SqlGen.TopClause(1, false);
				return sqlSelectStatement;
			}
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = (global::System.Data.Entity.Core.Metadata.Edm.CollectionType)e.ResultType.EdmType;
			bool flag = global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == collectionType.TypeUsage.EdmType.BuiltInTypeKind;
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			string s = "";
			if (e.Arguments.Count == 0)
			{
				sqlBuilder.Append(" SELECT CAST(null as ");
				sqlBuilder.Append(this.GetSqlPrimitiveType(collectionType.TypeUsage));
				sqlBuilder.Append(") AS X FROM (SELECT 1) AS Y WHERE 1=0");
			}
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.Arguments)
			{
				sqlBuilder.Append(s);
				sqlBuilder.Append(" SELECT ");
				sqlBuilder.Append(dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				if (flag)
				{
					sqlBuilder.Append(" AS X ");
				}
				s = " UNION ALL ";
			}
			return sqlBuilder;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001814C File Offset: 0x0001634C
		private global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder VisitIsNullExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e, bool negate)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			if (e.Argument.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
			{
				this._ignoreForceNonUnicodeFlag = true;
			}
			sqlBuilder.Append(e.Argument.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			this._ignoreForceNonUnicodeFlag = false;
			if (!negate)
			{
				sqlBuilder.Append(" IS NULL");
			}
			else
			{
				sqlBuilder.Append(" IS NOT NULL");
			}
			return sqlBuilder;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000181AC File Offset: 0x000163AC
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment VisitJoinExpression(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind joinKind, string joinString, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement;
			if (!this.IsParentAJoin)
			{
				sqlSelectStatement = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
				sqlSelectStatement.AllJoinExtents = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
				this.selectStatementStack.Push(sqlSelectStatement);
			}
			else
			{
				sqlSelectStatement = this.CurrentSelectStatement;
			}
			this.symbolTable.EnterScope();
			string text = "";
			bool flag = true;
			int count = inputs.Count;
			for (int i = 0; i < count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = inputs[i];
				if (text.Length != 0)
				{
					sqlSelectStatement.From.AppendLine();
				}
				sqlSelectStatement.From.Append(text + " ");
				bool item = dbExpressionBinding.Expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Scan || (flag && (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsJoinExpression(dbExpressionBinding.Expression) || global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsApplyExpression(dbExpressionBinding.Expression)));
				this.isParentAJoinStack.Push(item);
				int count2 = sqlSelectStatement.FromExtents.Count;
				global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment fromExtentFragment = dbExpressionBinding.Expression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
				this.isParentAJoinStack.Pop();
				this.ProcessJoinInputResult(fromExtentFragment, sqlSelectStatement, dbExpressionBinding, count2);
				text = joinString;
				flag = false;
			}
			if (joinKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin || joinKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin || joinKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin)
			{
				sqlSelectStatement.From.Append(" ON ");
				this.isParentAJoinStack.Push(false);
				sqlSelectStatement.From.Append(joinCondition.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				this.isParentAJoinStack.Pop();
			}
			this.symbolTable.ExitScope();
			if (!this.IsParentAJoin)
			{
				this.selectStatementStack.Pop();
			}
			return sqlSelectStatement;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00018338 File Offset: 0x00016538
		private void ProcessJoinInputResult(global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment fromExtentFragment, global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement result, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, int fromSymbolStart)
		{
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol = null;
			if (result != fromExtentFragment)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = fromExtentFragment as global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement;
				if (sqlSelectStatement != null)
				{
					if (sqlSelectStatement.Select.IsEmpty)
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnList = this.AddDefaultColumns(sqlSelectStatement);
						if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsJoinExpression(input.Expression) || global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsApplyExpression(input.Expression))
						{
							global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> fromExtents = sqlSelectStatement.FromExtents;
							symbol = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(input.VariableName, input.VariableType, fromExtents)
							{
								IsNestedJoin = true,
								ColumnList = columnList
							};
						}
						else
						{
							global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = sqlSelectStatement.FromExtents[0] as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
							if (joinSymbol != null)
							{
								symbol = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(input.VariableName, input.VariableType, joinSymbol.ExtentList)
								{
									IsNestedJoin = true,
									ColumnList = columnList,
									FlattenedExtentList = joinSymbol.FlattenedExtentList
								};
							}
							else
							{
								symbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(input.VariableName, input.VariableType, sqlSelectStatement.OutputColumns, sqlSelectStatement.OutputColumnsRenamed);
							}
						}
					}
					else
					{
						symbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(input.VariableName, input.VariableType, sqlSelectStatement.OutputColumns, sqlSelectStatement.OutputColumnsRenamed);
					}
					result.From.Append(" (");
					result.From.Append(sqlSelectStatement);
					result.From.Append(" )");
				}
				else if (input.Expression is global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)
				{
					result.From.Append(fromExtentFragment);
				}
				else
				{
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.WrapNonQueryExtent(result, fromExtentFragment, input.Expression.ExpressionKind);
				}
				if (symbol == null)
				{
					symbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(input.VariableName, input.VariableType);
				}
				this.AddFromSymbol(result, input.VariableName, symbol);
				result.AllJoinExtents.Add(symbol);
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> list = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
			for (int i = fromSymbolStart; i < result.FromExtents.Count; i++)
			{
				list.Add(result.FromExtents[i]);
			}
			result.FromExtents.RemoveRange(fromSymbolStart, result.FromExtents.Count - fromSymbolStart);
			symbol = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(input.VariableName, input.VariableType, list);
			result.FromExtents.Add(symbol);
			this.symbolTable.Add(input.VariableName, symbol);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00018554 File Offset: 0x00016754
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment VisitNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e, bool aliasesNeedRenaming, out global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> newColumns)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = e.ResultType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
			if (rowType != null)
			{
				newColumns = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>(e.Arguments.Count);
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = rowType.Properties;
				string s = "";
				for (int i = 0; i < e.Arguments.Count; i++)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = e.Arguments[i];
					if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == dbExpression.ResultType.EdmType.BuiltInTypeKind)
					{
						throw new global::System.NotSupportedException();
					}
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = properties[i];
					sqlBuilder.Append(s);
					sqlBuilder.AppendLine();
					sqlBuilder.Append(dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
					sqlBuilder.Append(" AS ");
					if (aliasesNeedRenaming)
					{
						global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(edmProperty.Name, edmProperty.TypeUsage);
						symbol.NeedsRenaming = true;
						symbol.NewName = "Internal_" + edmProperty.Name;
						sqlBuilder.Append(symbol);
						newColumns.Add(edmProperty.Name, symbol);
					}
					else
					{
						sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(edmProperty.Name));
					}
					s = ", ";
				}
				return sqlBuilder;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001868C File Offset: 0x0001688C
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment VisitSetOpExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression setOpExpression, string separator)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement> list = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement>();
			this.VisitAndGatherSetOpLeafExpressions(setOpExpression.ExpressionKind, setOpExpression.Left, list);
			this.VisitAndGatherSetOpLeafExpressions(setOpExpression.ExpressionKind, setOpExpression.Right, list);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			for (int i = 0; i < list.Count; i++)
			{
				if (i > 0)
				{
					sqlBuilder.AppendLine();
					sqlBuilder.Append(separator);
					sqlBuilder.AppendLine();
				}
				sqlBuilder.Append(list[i]);
			}
			if (!list[0].OutputColumnsRenamed)
			{
				return sqlBuilder;
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
			sqlSelectStatement.From.Append("( ");
			sqlSelectStatement.From.Append(sqlBuilder);
			sqlSelectStatement.From.AppendLine();
			sqlSelectStatement.From.Append(") ");
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol("X", setOpExpression.Left.ResultType.GetElementTypeUsage(), list[0].OutputColumns, true);
			this.AddFromSymbol(sqlSelectStatement, null, fromSymbol, false);
			return sqlSelectStatement;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00018784 File Offset: 0x00016984
		private void VisitAndGatherSetOpLeafExpressions(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement> leafSelectStatements)
		{
			if (this.SqlVersion > global::System.Data.Entity.SqlServer.SqlVersion.Sql8 && (kind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnionAll || kind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Intersect) && expression.ExpressionKind == kind)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression dbBinaryExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression)expression;
				this.VisitAndGatherSetOpLeafExpressions(kind, dbBinaryExpression.Left, leafSelectStatements);
				this.VisitAndGatherSetOpLeafExpressions(kind, dbBinaryExpression.Right, leafSelectStatements);
				return;
			}
			leafSelectStatements.Add(this.VisitExpressionEnsureSqlStatement(expression, true, true));
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000187E4 File Offset: 0x000169E4
		private void AddColumns(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement selectStatement, global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol, global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnList, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnDictionary)
		{
			global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = symbol as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
			if (joinSymbol != null)
			{
				if (!joinSymbol.IsNestedJoin)
				{
					using (global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>.Enumerator enumerator = joinSymbol.ExtentList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol2 = enumerator.Current;
							if (symbol2.Type != null && global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType != symbol2.Type.EdmType.BuiltInTypeKind)
							{
								this.AddColumns(selectStatement, symbol2, columnList, columnDictionary);
							}
						}
						return;
					}
				}
				using (global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>.Enumerator enumerator = joinSymbol.ColumnList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol3 = enumerator.Current;
						global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn optionalColumn = this.CreateOptionalColumn(null, symbol3);
						optionalColumn.Append(symbol);
						optionalColumn.Append(".");
						optionalColumn.Append(symbol3);
						selectStatement.Select.AddOptionalColumn(optionalColumn);
						if (columnDictionary.ContainsKey(symbol3.Name))
						{
							columnDictionary[symbol3.Name].NeedsRenaming = true;
							symbol3.NeedsRenaming = true;
						}
						else
						{
							columnDictionary[symbol3.Name] = symbol3;
						}
						columnList.Add(symbol3);
					}
					return;
				}
			}
			if (symbol.OutputColumnsRenamed)
			{
				selectStatement.OutputColumnsRenamed = true;
			}
			if (selectStatement.OutputColumns == null)
			{
				selectStatement.OutputColumns = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
			}
			if (symbol.Type == null || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == symbol.Type.EdmType.BuiltInTypeKind)
			{
				this.AddColumn(selectStatement, symbol, columnList, columnDictionary, "X");
				return;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in symbol.Type.GetProperties())
			{
				this.AddColumn(selectStatement, symbol, columnList, columnDictionary, edmProperty.Name);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000189C4 File Offset: 0x00016BC4
		private global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn CreateOptionalColumn(global::System.Data.Entity.SqlServer.SqlGen.Symbol inputColumnSymbol, global::System.Data.Entity.SqlServer.SqlGen.Symbol column)
		{
			if (!this.optionalColumnUsageManager.ContainsKey(column))
			{
				this.optionalColumnUsageManager.Add(inputColumnSymbol, column);
			}
			return new global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn(this.optionalColumnUsageManager, column);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000189F0 File Offset: 0x00016BF0
		private void AddColumn(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement selectStatement, global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol, global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnList, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnDictionary, string columnName)
		{
			this.allColumnNames[columnName] = 0;
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol2 = null;
			symbol.OutputColumns.TryGetValue(columnName, out symbol2);
			global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol3;
			if (!symbol.Columns.TryGetValue(columnName, out symbol3))
			{
				symbol3 = ((symbol2 != null && symbol.OutputColumnsRenamed) ? symbol2 : new global::System.Data.Entity.SqlServer.SqlGen.Symbol(columnName, null));
				symbol.Columns.Add(columnName, symbol3);
			}
			global::System.Data.Entity.SqlServer.SqlGen.OptionalColumn optionalColumn = this.CreateOptionalColumn(symbol2, symbol3);
			optionalColumn.Append(symbol);
			optionalColumn.Append(".");
			if (symbol.OutputColumnsRenamed)
			{
				optionalColumn.Append(symbol2);
			}
			else
			{
				optionalColumn.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(columnName));
			}
			optionalColumn.Append(" AS ");
			optionalColumn.Append(symbol3);
			selectStatement.Select.AddOptionalColumn(optionalColumn);
			if (!selectStatement.OutputColumns.ContainsKey(columnName))
			{
				selectStatement.OutputColumns.Add(columnName, symbol3);
			}
			if (columnDictionary.ContainsKey(columnName))
			{
				columnDictionary[columnName].NeedsRenaming = true;
				symbol3.NeedsRenaming = true;
			}
			else
			{
				columnDictionary[columnName] = symbol.Columns[columnName];
			}
			columnList.Add(symbol3);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00018B08 File Offset: 0x00016D08
		private global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> AddDefaultColumns(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement selectStatement)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> list = new global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol>();
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnDictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.Symbol>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (global::System.Data.Entity.SqlServer.SqlGen.Symbol symbol in selectStatement.FromExtents)
			{
				this.AddColumns(selectStatement, symbol, list, columnDictionary);
			}
			return list;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00018B70 File Offset: 0x00016D70
		private void AddFromSymbol(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement selectStatement, string inputVarName, global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol)
		{
			this.AddFromSymbol(selectStatement, inputVarName, fromSymbol, true);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00018B7C File Offset: 0x00016D7C
		private void AddFromSymbol(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement selectStatement, string inputVarName, global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol, bool addToSymbolTable)
		{
			if (selectStatement.FromExtents.Count == 0 || fromSymbol != selectStatement.FromExtents[0])
			{
				selectStatement.FromExtents.Add(fromSymbol);
				selectStatement.From.Append(" AS ");
				selectStatement.From.Append(fromSymbol);
				this.allExtentNames[fromSymbol.Name] = 0;
			}
			if (addToSymbolTable)
			{
				this.symbolTable.Add(inputVarName, fromSymbol);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00018BF0 File Offset: 0x00016DF0
		private void AddSortKeys(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder orderByClause, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortKeys)
		{
			string s = "";
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in sortKeys)
			{
				orderByClause.Append(s);
				orderByClause.Append(dbSortClause.Expression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
				if (!string.IsNullOrEmpty(dbSortClause.Collation))
				{
					orderByClause.Append(" COLLATE ");
					orderByClause.Append(dbSortClause.Collation);
				}
				orderByClause.Append(dbSortClause.Ascending ? " ASC" : " DESC");
				s = ", ";
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00018C94 File Offset: 0x00016E94
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement CreateNewSelectStatement(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement oldStatement, string inputVarName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage inputVarType, out global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol)
		{
			return this.CreateNewSelectStatement(oldStatement, inputVarName, inputVarType, true, out fromSymbol);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00018CA4 File Offset: 0x00016EA4
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement CreateNewSelectStatement(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement oldStatement, string inputVarName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage inputVarType, bool finalizeOldStatement, out global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol)
		{
			fromSymbol = null;
			if (finalizeOldStatement && oldStatement.Select.IsEmpty)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> columnList = this.AddDefaultColumns(oldStatement);
				global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol joinSymbol = oldStatement.FromExtents[0] as global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol;
				if (joinSymbol != null)
				{
					fromSymbol = new global::System.Data.Entity.SqlServer.SqlGen.JoinSymbol(inputVarName, inputVarType, joinSymbol.ExtentList)
					{
						IsNestedJoin = true,
						ColumnList = columnList,
						FlattenedExtentList = joinSymbol.FlattenedExtentList
					};
				}
			}
			if (fromSymbol == null)
			{
				fromSymbol = new global::System.Data.Entity.SqlServer.SqlGen.Symbol(inputVarName, inputVarType, oldStatement.OutputColumns, oldStatement.OutputColumnsRenamed);
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = new global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement();
			sqlSelectStatement.From.Append("( ");
			sqlSelectStatement.From.Append(oldStatement);
			sqlSelectStatement.From.AppendLine();
			sqlSelectStatement.From.Append(") ");
			return sqlSelectStatement;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00018D66 File Offset: 0x00016F66
		private static string EscapeSingleQuote(string s, bool isUnicode)
		{
			return (isUnicode ? "N'" : "'") + s.Replace("'", "''") + "'";
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00018D94 File Offset: 0x00016F94
		private string GetSqlPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = this._storeItemCollection.ProviderManifest.GetStoreType(type);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GenerateSqlForStoreType(this._sqlVersion, storeType);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00018DC0 File Offset: 0x00016FC0
		internal static string GenerateSqlForStoreType(global::System.Data.Entity.SqlServer.SqlVersion sqlVersion, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeTypeUsage)
		{
			string text = storeTypeUsage.EdmType.Name;
			int num = 0;
			byte b = 0;
			byte b2 = 0;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)storeTypeUsage.EdmType).PrimitiveTypeKind;
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				if (!storeTypeUsage.MustFacetBeConstant("MaxLength"))
				{
					storeTypeUsage.TryGetMaxLength(out num);
					text = text + "(" + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + ")";
				}
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				text = (global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(sqlVersion) ? "datetime" : "datetime2");
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				if (!storeTypeUsage.MustFacetBeConstant("Precision"))
				{
					storeTypeUsage.TryGetPrecision(out b);
					storeTypeUsage.TryGetScale(out b2);
					text = string.Concat(new string[]
					{
						text,
						"(",
						b.ToString(),
						",",
						b2.ToString(),
						")"
					});
				}
				break;
			default:
				switch (primitiveTypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
					if (!storeTypeUsage.MustFacetBeConstant("MaxLength"))
					{
						storeTypeUsage.TryGetMaxLength(out num);
						text = text + "(" + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + ")";
					}
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AssertKatmaiOrNewer(sqlVersion, primitiveTypeKind);
					text = "time";
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
					global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AssertKatmaiOrNewer(sqlVersion, primitiveTypeKind);
					text = "datetimeoffset";
					break;
				}
				break;
			}
			return text;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00018F30 File Offset: 0x00017130
		private global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCountExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment result;
			if (e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				sqlBuilder.Append(((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)e).Value.ToString());
				result = sqlBuilder;
			}
			else
			{
				result = e.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this);
			}
			return result;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00018F6D File Offset: 0x0001716D
		private static bool IsApplyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply == e.ExpressionKind;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00018F84 File Offset: 0x00017184
		private static bool IsJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin == e.ExpressionKind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin == e.ExpressionKind;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00018FB0 File Offset: 0x000171B0
		private static bool IsComplexExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			return expressionKind - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast > 1 && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00018FD8 File Offset: 0x000171D8
		private static bool IsCompatible(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement result, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind)
		{
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy)
			{
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Distinct)
					{
						return result.Select.Top == null && result.Select.Skip == null && result.OrderBy.IsEmpty;
					}
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Element)
					{
						goto IL_1D3;
					}
				}
				else
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter)
					{
						return result.Select.IsEmpty && result.Where.IsEmpty && result.GroupBy.IsEmpty && result.Select.Top == null && result.Select.Skip == null;
					}
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy)
					{
						goto IL_1D3;
					}
					return result.Select.IsEmpty && result.GroupBy.IsEmpty && result.OrderBy.IsEmpty && result.Select.Top == null && result.Select.Skip == null && !result.Select.IsDistinct;
				}
			}
			else if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Limit)
				{
					if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
					{
						goto IL_1D3;
					}
					return result.Select.IsEmpty && result.GroupBy.IsEmpty && !result.Select.IsDistinct;
				}
			}
			else
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Skip)
				{
					return result.Select.IsEmpty && result.Select.Skip == null && result.GroupBy.IsEmpty && result.OrderBy.IsEmpty && !result.Select.IsDistinct;
				}
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
				{
					goto IL_1D3;
				}
				return result.Select.IsEmpty && result.GroupBy.IsEmpty && result.OrderBy.IsEmpty && !result.Select.IsDistinct;
			}
			return result.Select.Top == null;
			IL_1D3:
			throw new global::System.InvalidOperationException(string.Empty);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000191C2 File Offset: 0x000173C2
		internal static string QuoteIdentifier(string name)
		{
			return "[" + name.Replace("]", "]]") + "]";
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000191E3 File Offset: 0x000173E3
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement VisitExpressionEnsureSqlStatement(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			return this.VisitExpressionEnsureSqlStatement(e, true, false);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000191F0 File Offset: 0x000173F0
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement VisitExpressionEnsureSqlStatement(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e, bool addDefaultColumns, bool markAllDefaultColumnsAsUsed)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = e.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GroupBy)
				{
					goto IL_3A;
				}
			}
			else if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project && expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Sort)
			{
				goto IL_3A;
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = e.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this) as global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement;
			goto IL_C6;
			IL_3A:
			string inputVarName = "c";
			this.symbolTable.EnterScope();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind2 = e.ExpressionKind;
			if (expressionKind2 <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin)
			{
				if (expressionKind2 - global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply > 1 && expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin && expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin)
				{
					goto IL_90;
				}
			}
			else if (expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin && expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply && expressionKind2 != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Scan)
			{
				goto IL_90;
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage inputVarType = e.ResultType.GetElementTypeUsage();
			goto IL_A6;
			IL_90:
			inputVarType = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)e.ResultType.EdmType).TypeUsage;
			IL_A6:
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
			sqlSelectStatement = this.VisitInputExpression(e, inputVarName, inputVarType, out fromSymbol);
			this.AddFromSymbol(sqlSelectStatement, inputVarName, fromSymbol);
			this.symbolTable.ExitScope();
			IL_C6:
			if (addDefaultColumns && sqlSelectStatement.Select.IsEmpty)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.SqlServer.SqlGen.Symbol> list = this.AddDefaultColumns(sqlSelectStatement);
				if (markAllDefaultColumnsAsUsed)
				{
					foreach (global::System.Data.Entity.SqlServer.SqlGen.Symbol key in list)
					{
						this.optionalColumnUsageManager.MarkAsUsed(key);
					}
				}
			}
			return sqlSelectStatement;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001932C File Offset: 0x0001752C
		private global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement VisitFilterExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate, bool negatePredicate)
		{
			global::System.Data.Entity.SqlServer.SqlGen.Symbol fromSymbol;
			global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement sqlSelectStatement = this.VisitInputExpression(input.Expression, input.VariableName, input.VariableType, out fromSymbol);
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.IsCompatible(sqlSelectStatement, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter))
			{
				sqlSelectStatement = this.CreateNewSelectStatement(sqlSelectStatement, input.VariableName, input.VariableType, out fromSymbol);
			}
			this.selectStatementStack.Push(sqlSelectStatement);
			this.symbolTable.EnterScope();
			this.AddFromSymbol(sqlSelectStatement, input.VariableName, fromSymbol);
			if (negatePredicate)
			{
				sqlSelectStatement.Where.Append("NOT (");
			}
			sqlSelectStatement.Where.Append(predicate.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this));
			if (negatePredicate)
			{
				sqlSelectStatement.Where.Append(")");
			}
			this.symbolTable.ExitScope();
			this.selectStatementStack.Pop();
			return sqlSelectStatement;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000193E9 File Offset: 0x000175E9
		private static void WrapNonQueryExtent(global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement result, global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment sqlFragment, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind)
		{
			if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function)
			{
				result.From.Append(sqlFragment);
				return;
			}
			result.From.Append(" (");
			result.From.Append(sqlFragment);
			result.From.Append(")");
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001942C File Offset: 0x0001762C
		private static string ByteArrayToBinaryString(byte[] binaryArray)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(binaryArray.Length * 2);
			for (int i = 0; i < binaryArray.Length; i++)
			{
				stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator._hexDigits[(binaryArray[i] & 240) >> 4]).Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator._hexDigits[(int)(binaryArray[i] & 15)]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00019484 File Offset: 0x00017684
		private static bool GroupByAggregatesNeedInnerQuery(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggregates, string inputVarRefName)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> enumerator = aggregates.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByAggregateNeedsInnerQuery(enumerator.Current.Arguments[0], inputVarRefName))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000194E0 File Offset: 0x000176E0
		private static bool GroupByAggregateNeedsInnerQuery(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, string inputVarRefName)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByExpressionNeedsInnerQuery(expression, inputVarRefName, true);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000194EC File Offset: 0x000176EC
		private static bool GroupByKeysNeedInnerQuery(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keys, string inputVarRefName)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> enumerator = keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByKeyNeedsInnerQuery(enumerator.Current, inputVarRefName))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001953C File Offset: 0x0001773C
		private static bool GroupByKeyNeedsInnerQuery(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, string inputVarRefName)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByExpressionNeedsInnerQuery(expression, inputVarRefName, false);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00019548 File Offset: 0x00017748
		private static bool GroupByExpressionNeedsInnerQuery(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, string inputVarRefName, bool allowConstants)
		{
			if (allowConstants && expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				return false;
			}
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByExpressionNeedsInnerQuery(((global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression)expression).Argument, inputVarRefName, allowConstants);
			}
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GroupByExpressionNeedsInnerQuery(((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)expression).Instance, inputVarRefName, allowConstants);
			}
			return expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference || !(expression as global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression).VariableName.Equals(inputVarRefName);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000195BC File Offset: 0x000177BC
		private void AssertKatmaiOrNewer(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.AssertKatmaiOrNewer(this._sqlVersion, primitiveTypeKind);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000195CA File Offset: 0x000177CA
		private static void AssertKatmaiOrNewer(global::System.Data.Entity.SqlServer.SqlVersion sqlVersion, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			if (global::System.Data.Entity.SqlServer.SqlVersionUtils.IsPreKatmai(sqlVersion))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_PrimitiveTypeNotSupportedPriorSql10(primitiveTypeKind));
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000195E5 File Offset: 0x000177E5
		internal void AssertKatmaiOrNewer(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			if (this.IsPreKatmai)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_CanonicalFunctionNotSupportedPriorSql10(e.Function.Name));
			}
		}

		// Token: 0x040000FA RID: 250
		private global::System.Collections.Generic.Stack<global::System.Data.Entity.SqlServer.SqlGen.SqlSelectStatement> selectStatementStack;

		// Token: 0x040000FB RID: 251
		private global::System.Collections.Generic.Stack<bool> isParentAJoinStack;

		// Token: 0x040000FC RID: 252
		private global::System.Collections.Generic.Dictionary<string, int> allExtentNames;

		// Token: 0x040000FD RID: 253
		private global::System.Collections.Generic.Dictionary<string, int> allColumnNames;

		// Token: 0x040000FE RID: 254
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SymbolTable symbolTable = new global::System.Data.Entity.SqlServer.SqlGen.SymbolTable();

		// Token: 0x040000FF RID: 255
		private bool isVarRefSingle;

		// Token: 0x04000100 RID: 256
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SymbolUsageManager optionalColumnUsageManager = new global::System.Data.Entity.SqlServer.SqlGen.SymbolUsageManager();

		// Token: 0x04000101 RID: 257
		private readonly global::System.Collections.Generic.Dictionary<string, bool> _candidateParametersToForceNonUnicode = new global::System.Collections.Generic.Dictionary<string, bool>();

		// Token: 0x04000102 RID: 258
		private bool _forceNonUnicode;

		// Token: 0x04000103 RID: 259
		private bool _ignoreForceNonUnicodeFlag;

		// Token: 0x04000104 RID: 260
		private const byte DefaultDecimalPrecision = 18;

		// Token: 0x04000105 RID: 261
		private static readonly char[] _hexDigits = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};

		// Token: 0x04000106 RID: 262
		private global::System.Collections.Generic.List<string> _targets;

		// Token: 0x04000107 RID: 263
		private static readonly global::System.Collections.Generic.ISet<string> _canonicalAndStoreStringFunctionsOneArg = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal)
		{
			"Edm.Trim",
			"Edm.RTrim",
			"Edm.LTrim",
			"Edm.Left",
			"Edm.Right",
			"Edm.Substring",
			"Edm.ToLower",
			"Edm.ToUpper",
			"Edm.Reverse",
			"SqlServer.RTRIM",
			"SqlServer.LTRIM",
			"SqlServer.LEFT",
			"SqlServer.RIGHT",
			"SqlServer.SUBSTRING",
			"SqlServer.LOWER",
			"SqlServer.UPPER",
			"SqlServer.REVERSE"
		};

		// Token: 0x04000108 RID: 264
		private readonly global::System.Data.Entity.SqlServer.SqlVersion _sqlVersion;

		// Token: 0x04000109 RID: 265
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _integerType;

		// Token: 0x0400010A RID: 266
		private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection _storeItemCollection;

		// Token: 0x0200008E RID: 142
		internal class KeyFieldExpressionComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
		{
			// Token: 0x0600073B RID: 1851 RVA: 0x0001CC4C File Offset: 0x0001AE4C
			public bool Equals(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression x, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression y)
			{
				if (x.ExpressionKind != y.ExpressionKind)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = x.ExpressionKind;
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression dbCastExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression)x;
						global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression dbCastExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression)y;
						return dbCastExpression.ResultType == dbCastExpression2.ResultType && this.Equals(dbCastExpression.Argument, dbCastExpression2.Argument);
					}
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
					{
						return ((global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)x).ParameterName == ((global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)y).ParameterName;
					}
				}
				else
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)x;
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)y;
						return dbPropertyExpression.Property == dbPropertyExpression2.Property && this.Equals(dbPropertyExpression.Instance, dbPropertyExpression2.Instance);
					}
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference)
					{
						return x == y;
					}
				}
				return false;
			}

			// Token: 0x0600073C RID: 1852 RVA: 0x0001CD1C File Offset: 0x0001AF1C
			public int GetHashCode(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression obj)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = obj.ExpressionKind;
				if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast)
					{
						return this.GetHashCode(((global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression)obj).Argument);
					}
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
					{
						return ((global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression)obj).ParameterName.GetHashCode() ^ int.MaxValue;
					}
				}
				else
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
					{
						return ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)obj).Property.GetHashCode();
					}
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference)
					{
						return ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)obj).VariableName.GetHashCode();
					}
				}
				return obj.GetHashCode();
			}
		}
	}
}
