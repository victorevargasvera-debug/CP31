using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200002E RID: 46
	internal static class DmlSqlGenerator
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00010C70 File Offset: 0x0000EE70
		internal static string GenerateUpdateSql(global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree tree, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, out global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> parameters, bool generateReturningSql = true, bool upperCaseKeywords = true)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder sqlStringBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder(256)
			{
				UpperCaseKeywords = upperCaseKeywords
			};
			global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator expressionTranslator = new global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator(sqlStringBuilder, tree, tree.Returning != null, sqlGenerator, null, true);
			if (tree.SetClauses.Count == 0)
			{
				sqlStringBuilder.AppendKeyword("declare ");
				sqlStringBuilder.AppendLine("@p int");
			}
			sqlStringBuilder.AppendKeyword("update ");
			tree.Target.Expression.Accept(expressionTranslator);
			sqlStringBuilder.AppendLine();
			bool flag = true;
			sqlStringBuilder.AppendKeyword("set ");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in tree.SetClauses)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause dbSetClause = (global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)dbModificationClause;
				if (flag)
				{
					flag = false;
				}
				else
				{
					sqlStringBuilder.Append(", ");
				}
				dbSetClause.Property.Accept(expressionTranslator);
				sqlStringBuilder.Append(" = ");
				dbSetClause.Value.Accept(expressionTranslator);
			}
			if (flag)
			{
				sqlStringBuilder.Append("@p = 0");
			}
			sqlStringBuilder.AppendLine();
			sqlStringBuilder.AppendKeyword("where ");
			tree.Predicate.Accept(expressionTranslator);
			sqlStringBuilder.AppendLine();
			if (generateReturningSql)
			{
				global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateReturningSql(sqlStringBuilder, tree, null, expressionTranslator, tree.Returning, false);
			}
			parameters = expressionTranslator.Parameters;
			return sqlStringBuilder.ToString();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		internal static string GenerateDeleteSql(global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree tree, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, out global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> parameters, bool upperCaseKeywords = true, bool createParameters = true)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder sqlStringBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder(256);
			sqlStringBuilder.UpperCaseKeywords = upperCaseKeywords;
			global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator expressionTranslator = new global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator(sqlStringBuilder, tree, false, sqlGenerator, null, createParameters);
			sqlStringBuilder.AppendKeyword("delete ");
			tree.Target.Expression.Accept(expressionTranslator);
			sqlStringBuilder.AppendLine();
			sqlStringBuilder.AppendKeyword("where ");
			tree.Predicate.Accept(expressionTranslator);
			parameters = expressionTranslator.Parameters;
			return sqlStringBuilder.ToString();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00010E38 File Offset: 0x0000F038
		internal static string GenerateInsertSql(global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree tree, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, out global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> parameters, bool generateReturningSql = true, bool upperCaseKeywords = true, bool createParameters = true)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder sqlStringBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder(256)
			{
				UpperCaseKeywords = upperCaseKeywords
			};
			global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator expressionTranslator = new global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator(sqlStringBuilder, tree, tree.Returning != null, sqlGenerator, null, createParameters);
			bool flag = global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.UseGeneratedValuesVariable(tree, sqlGenerator.SqlVersion);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)tree.Target.Expression).Target.ElementType;
			if (flag)
			{
				sqlStringBuilder.AppendKeyword("declare ").Append("@generated_keys").Append(" table(");
				bool flag2 = true;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in entityType.KeyMembers)
				{
					if (flag2)
					{
						flag2 = false;
					}
					else
					{
						sqlStringBuilder.Append(", ");
					}
					sqlStringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateMemberTSql(edmMember)).Append(" ").Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GetVariableType(sqlGenerator, edmMember));
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
					if (edmMember.TypeUsage.Facets.TryGetValue("Collation", false, out facet))
					{
						string text = facet.Value as string;
						if (!string.IsNullOrEmpty(text))
						{
							sqlStringBuilder.AppendKeyword(" collate ").Append(text);
						}
					}
				}
				sqlStringBuilder.AppendLine(")");
			}
			sqlStringBuilder.AppendKeyword("insert ");
			tree.Target.Expression.Accept(expressionTranslator);
			if (0 < tree.SetClauses.Count)
			{
				sqlStringBuilder.Append("(");
				bool flag3 = true;
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in tree.SetClauses)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause dbSetClause = (global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)dbModificationClause;
					if (flag3)
					{
						flag3 = false;
					}
					else
					{
						sqlStringBuilder.Append(", ");
					}
					dbSetClause.Property.Accept(expressionTranslator);
				}
				sqlStringBuilder.AppendLine(")");
			}
			else
			{
				sqlStringBuilder.AppendLine();
			}
			if (flag)
			{
				sqlStringBuilder.AppendKeyword("output ");
				bool flag4 = true;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember member in entityType.KeyMembers)
				{
					if (flag4)
					{
						flag4 = false;
					}
					else
					{
						sqlStringBuilder.Append(", ");
					}
					sqlStringBuilder.Append("inserted.");
					sqlStringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateMemberTSql(member));
				}
				sqlStringBuilder.AppendKeyword(" into ").AppendLine("@generated_keys");
			}
			if (0 < tree.SetClauses.Count)
			{
				bool flag5 = true;
				sqlStringBuilder.AppendKeyword("values (");
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause2 in tree.SetClauses)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause dbSetClause2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)dbModificationClause2;
					if (flag5)
					{
						flag5 = false;
					}
					else
					{
						sqlStringBuilder.Append(", ");
					}
					dbSetClause2.Value.Accept(expressionTranslator);
					expressionTranslator.RegisterMemberValue(dbSetClause2.Property, dbSetClause2.Value);
				}
				sqlStringBuilder.AppendLine(")");
			}
			else
			{
				sqlStringBuilder.AppendKeyword("default values");
				sqlStringBuilder.AppendLine();
			}
			if (generateReturningSql)
			{
				global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateReturningSql(sqlStringBuilder, tree, entityType, expressionTranslator, tree.Returning, flag);
			}
			parameters = expressionTranslator.Parameters;
			return sqlStringBuilder.ToString();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000111B4 File Offset: 0x0000F3B4
		internal static string GetVariableType(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, global::System.Data.Entity.Core.Metadata.Edm.EdmMember column)
		{
			string text = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GenerateSqlForStoreType(sqlGenerator.SqlVersion, column.TypeUsage);
			if (text == "rowversion" || text == "timestamp")
			{
				text = "binary(8)";
			}
			return text;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000111F4 File Offset: 0x0000F3F4
		internal static bool UseGeneratedValuesVariable(global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree tree, global::System.Data.Entity.SqlServer.SqlVersion sqlVersion)
		{
			bool result = false;
			if (sqlVersion > global::System.Data.Entity.SqlServer.SqlVersion.Sql8 && tree.Returning != null)
			{
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(from global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause s in tree.SetClauses
				select ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)s.Property).Property);
				bool flag = false;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in ((global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)tree.Target.Expression).Target.ElementType.KeyMembers)
				{
					if (!hashSet.Contains(edmMember))
					{
						if (flag)
						{
							result = true;
							break;
						}
						flag = true;
						if (!global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.IsValidScopeIdentityColumnType(edmMember.TypeUsage))
						{
							result = true;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000112CC File Offset: 0x0000F4CC
		internal static string GenerateMemberTSql(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(member.Name);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000112DC File Offset: 0x0000F4DC
		internal static void GenerateReturningSql(global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder commandText, global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree tree, global::System.Data.Entity.Core.Metadata.Edm.EntityType tableType, global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator translator, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning, bool useGeneratedValuesVariable)
		{
			if (returning == null)
			{
				return;
			}
			commandText.AppendKeyword("select ");
			if (useGeneratedValuesVariable)
			{
				translator.PropertyAlias = "t";
			}
			returning.Accept(translator);
			if (useGeneratedValuesVariable)
			{
				translator.PropertyAlias = null;
			}
			commandText.AppendLine();
			if (useGeneratedValuesVariable)
			{
				commandText.AppendKeyword("from ");
				commandText.Append("@generated_keys");
				commandText.AppendKeyword(" as ");
				commandText.Append("g");
				commandText.AppendKeyword(" join ");
				tree.Target.Expression.Accept(translator);
				commandText.AppendKeyword(" as ");
				commandText.Append("t");
				commandText.AppendKeyword(" on ");
				string keyword = string.Empty;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember member in tableType.KeyMembers)
				{
					commandText.AppendKeyword(keyword);
					keyword = " and ";
					commandText.Append("g.");
					string s = global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateMemberTSql(member);
					commandText.Append(s);
					commandText.Append(" = t.");
					commandText.Append(s);
				}
				commandText.AppendLine();
				commandText.AppendKeyword("where @@ROWCOUNT > 0");
				return;
			}
			commandText.AppendKeyword("from ");
			tree.Target.Expression.Accept(translator);
			commandText.AppendLine();
			commandText.AppendKeyword("where @@ROWCOUNT > 0");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase target = ((global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)tree.Target.Expression).Target;
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in target.ElementType.KeyMembers)
			{
				commandText.AppendKeyword(" and ");
				commandText.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateMemberTSql(edmMember));
				commandText.Append(" = ");
				global::System.Data.SqlClient.SqlParameter sqlParameter;
				if (translator.MemberValues.TryGetValue(edmMember, out sqlParameter))
				{
					commandText.Append(sqlParameter.ParameterName);
				}
				else
				{
					if (flag)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.Update_NotSupportedServerGenKey(target.Name));
					}
					if (!global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.IsValidScopeIdentityColumnType(edmMember.TypeUsage))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.Update_NotSupportedIdentityType(edmMember.Name, edmMember.TypeUsage.ToString()));
					}
					commandText.Append("scope_identity()");
					flag = true;
				}
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00011558 File Offset: 0x0000F758
		private static bool IsValidScopeIdentityColumnType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (!global::System.Data.Entity.SqlServer.SqlProviderServices.UseScopeIdentity)
			{
				return false;
			}
			if (typeUsage.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				return false;
			}
			string name = typeUsage.EdmType.Name;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			return name == "tinyint" || name == "smallint" || name == "int" || name == "bigint" || ((name == "decimal" || name == "numeric") && typeUsage.Facets.TryGetValue("Scale", false, out facet) && global::System.Convert.ToInt32(facet.Value, global::System.Globalization.CultureInfo.InvariantCulture) == 0);
		}

		// Token: 0x040000DA RID: 218
		private const int CommandTextBuilderInitialCapacity = 256;

		// Token: 0x040000DB RID: 219
		private const string GeneratedValuesVariableName = "@generated_keys";

		// Token: 0x02000085 RID: 133
		internal class ExpressionTranslator : global::System.Data.Entity.Core.Common.CommandTrees.BasicExpressionVisitor
		{
			// Token: 0x060006E5 RID: 1765 RVA: 0x0001C378 File Offset: 0x0001A578
			internal ExpressionTranslator(global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder commandText, global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree commandTree, bool preserveMemberValues, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> localVariableBindings = null, bool createParameters = true)
			{
				this._commandText = commandText;
				this._commandTree = commandTree;
				this._sqlGenerator = sqlGenerator;
				this._localVariableBindings = localVariableBindings;
				this._parameters = new global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter>();
				this._memberValues = (preserveMemberValues ? new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.SqlClient.SqlParameter>() : null);
				this._createParameters = createParameters;
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0001C3CD File Offset: 0x0001A5CD
			internal global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> Parameters
			{
				get
				{
					return this._parameters;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001C3D5 File Offset: 0x0001A5D5
			internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.SqlClient.SqlParameter> MemberValues
			{
				get
				{
					return this._memberValues;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001C3DD File Offset: 0x0001A5DD
			// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0001C3E5 File Offset: 0x0001A5E5
			internal string PropertyAlias { get; set; }

			// Token: 0x060006EA RID: 1770 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
			internal global::System.Data.SqlClient.SqlParameter CreateParameter(object value, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name = null)
			{
				global::System.Data.SqlClient.SqlParameter sqlParameter = global::System.Data.Entity.SqlServer.SqlProviderServices.CreateSqlParameter(name ?? global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator.GetParameterName(this._parameters.Count), type, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In, value, true, this._sqlGenerator.SqlVersion);
				this._parameters.Add(sqlParameter);
				return sqlParameter;
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x0001C434 File Offset: 0x0001A634
			internal static string GetParameterName(int index)
			{
				return "@" + index.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x0001C44C File Offset: 0x0001A64C
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(expression, "expression");
				this.VisitBinary(expression, " and ");
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x0001C466 File Offset: 0x0001A666
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(expression, "expression");
				this.VisitBinary(expression, " or ");
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x0001C480 File Offset: 0x0001A680
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(expression, "expression");
				this.VisitBinary(expression, " = ");
				this.RegisterMemberValue(expression.Left, expression.Right);
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x0001C4AC File Offset: 0x0001A6AC
			internal void RegisterMemberValue(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression propertyExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
			{
				if (this._memberValues != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember property = ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)propertyExpression).Property;
					if (value.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
					{
						this._memberValues[property] = this._parameters[this._parameters.Count - 1];
					}
				}
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x0001C4FB File Offset: 0x0001A6FB
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(expression, "expression");
				expression.Argument.Accept(this);
				this._commandText.AppendKeyword(" is null");
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0001C526 File Offset: 0x0001A726
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(expression, "expression");
				this._commandText.AppendKeyword("not (");
				expression.Argument.Accept(this);
				this._commandText.Append(")");
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x0001C564 File Offset: 0x0001A764
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(expression, "expression");
				global::System.Data.SqlClient.SqlParameter sqlParameter = this.CreateParameter(expression.Value, expression.ResultType, null);
				if (this._createParameters)
				{
					this._commandText.Append(sqlParameter.ParameterName);
					return;
				}
				using (global::System.Data.Entity.SqlServer.SqlGen.SqlWriter sqlWriter = new global::System.Data.Entity.SqlServer.SqlGen.SqlWriter(this._commandText.InnerBuilder))
				{
					this._sqlGenerator.WriteSql(sqlWriter, expression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(this._sqlGenerator));
				}
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x0001C5F4 File Offset: 0x0001A7F4
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
				global::System.Data.SqlClient.SqlParameter sqlParameter = this.CreateParameter(global::System.DBNull.Value, expression.ResultType, "@" + expression.ParameterName);
				this._commandText.Append(sqlParameter.ParameterName);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x0001C644 File Offset: 0x0001A844
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(expression, "expression");
				if (expression.Target.GetMetadataPropertyValue("DefiningQuery") != null)
				{
					string p;
					if (this._commandTree is global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree)
					{
						p = "DeleteFunction";
					}
					else if (this._commandTree is global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)
					{
						p = "InsertFunction";
					}
					else
					{
						p = "UpdateFunction";
					}
					throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.SqlServer.Resources.Strings.Update_SqlEntitySetWithoutDmlFunctions(expression.Target.Name, p, "ModificationFunctionMapping"));
				}
				this._commandText.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GetTargetTSql(expression.Target));
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
				if (!string.IsNullOrEmpty(this.PropertyAlias))
				{
					this._commandText.Append(this.PropertyAlias);
					this._commandText.Append(".");
				}
				this._commandText.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateMemberTSql(expression.Property));
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x0001C734 File Offset: 0x0001A934
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(expression, "expression");
				this._commandText.AppendKeyword("null");
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x0001C754 File Offset: 0x0001A954
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
			{
				global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(expression, "expression");
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in expression.Arguments)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember property = ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbExpression).Property;
					string text = (this._localVariableBindings != null) ? (this._localVariableBindings.Contains(property) ? ("@" + property.Name + " = ") : null) : string.Empty;
					if (text != null)
					{
						if (flag)
						{
							flag = false;
						}
						else
						{
							this._commandText.Append(", ");
						}
						this._commandText.Append(text);
						dbExpression.Accept(this);
					}
				}
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0001C820 File Offset: 0x0001AA20
			private void VisitBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expression, string separator)
			{
				this._commandText.Append("(");
				expression.Left.Accept(this);
				this._commandText.AppendKeyword(separator);
				expression.Right.Accept(this);
				this._commandText.Append(")");
			}

			// Token: 0x04000214 RID: 532
			private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder _commandText;

			// Token: 0x04000215 RID: 533
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree _commandTree;

			// Token: 0x04000216 RID: 534
			private readonly global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> _parameters;

			// Token: 0x04000217 RID: 535
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.SqlClient.SqlParameter> _memberValues;

			// Token: 0x04000218 RID: 536
			private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator _sqlGenerator;

			// Token: 0x04000219 RID: 537
			private readonly global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _localVariableBindings;

			// Token: 0x0400021A RID: 538
			private readonly bool _createParameters;
		}
	}
}
