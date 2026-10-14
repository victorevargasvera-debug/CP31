using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200002D RID: 45
	internal class DmlFunctionSqlGenerator
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0001067E File Offset: 0x0000E87E
		public DmlFunctionSqlGenerator(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlGenerator)
		{
			this._sqlGenerator = sqlGenerator;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00010690 File Offset: 0x0000E890
		public string GenerateInsert(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree> commandTrees)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree dbInsertCommandTree = commandTrees.First<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>();
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> list;
			stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateInsertSql(dbInsertCommandTree, this._sqlGenerator, out list, false, true, false));
			stringBuilder.AppendLine();
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)dbInsertCommandTree.Target.Expression).Target.ElementType;
			stringBuilder.Append(this.IntroduceRequiredLocalVariables(entityType, dbInsertCommandTree));
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree tree in commandTrees.Skip(1))
			{
				stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateInsertSql(tree, this._sqlGenerator, out list, false, true, false));
				stringBuilder.AppendLine();
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree> list2 = (from ct in commandTrees
			where ct.Returning != null
			select ct).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>();
			if (list2.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>())
			{
				global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.ReturningSelectSqlGenerator returningSelectSqlGenerator = new global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.ReturningSelectSqlGenerator();
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree dbInsertCommandTree2 in list2)
				{
					dbInsertCommandTree2.Target.Expression.Accept(returningSelectSqlGenerator);
					dbInsertCommandTree2.Returning.Accept(returningSelectSqlGenerator);
				}
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator3 = entityType.KeyProperties.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty keyProperty = enumerator3.Current;
						global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = (from global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause sc in dbInsertCommandTree.SetClauses
						where ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)sc.Property).Property == keyProperty
						select sc.Value).SingleOrDefault<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>() ?? keyProperty.TypeUsage.Parameter(keyProperty.Name);
						dbInsertCommandTree.Target.Variable.Property(keyProperty).Equal(right).Accept(returningSelectSqlGenerator);
					}
				}
				stringBuilder.Append(returningSelectSqlGenerator.Sql);
			}
			return stringBuilder.ToString().TrimEnd(new char[0]);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000108E8 File Offset: 0x0000EAE8
		private string IntroduceRequiredLocalVariables(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree commandTree)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = (from p in entityType.KeyProperties
			where p.IsStoreGeneratedIdentity
			select p).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder sqlStringBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlStringBuilder
			{
				UpperCaseKeywords = true
			};
			if (list.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in list)
				{
					sqlStringBuilder.Append((sqlStringBuilder.Length == 0) ? "DECLARE " : ", ");
					sqlStringBuilder.Append("@");
					sqlStringBuilder.Append(edmProperty.Name);
					sqlStringBuilder.Append(" ");
					sqlStringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GetVariableType(this._sqlGenerator, edmProperty));
				}
				sqlStringBuilder.AppendLine();
				global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator translator = new global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.ExpressionTranslator(sqlStringBuilder, commandTree, true, this._sqlGenerator, entityType.KeyProperties, true);
				global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateReturningSql(sqlStringBuilder, commandTree, entityType, translator, commandTree.Returning, global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.UseGeneratedValuesVariable(commandTree, this._sqlGenerator.SqlVersion));
				sqlStringBuilder.AppendLine();
				sqlStringBuilder.AppendLine();
			}
			return sqlStringBuilder.ToString();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00010A20 File Offset: 0x0000EC20
		public string GenerateUpdate(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree> commandTrees, string rowsAffectedParameter)
		{
			if (!commandTrees.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>())
			{
				return null;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> list;
			stringBuilder.AppendLine(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateUpdateSql(commandTrees.First<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>(), this._sqlGenerator, out list, false, true));
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree tree in commandTrees.Skip(1))
			{
				stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateUpdateSql(tree, this._sqlGenerator, out list, false, true));
				stringBuilder.AppendLine("AND @@ROWCOUNT > 0");
				stringBuilder.AppendLine();
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree> list2 = (from ct in commandTrees
			where ct.Returning != null
			select ct).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>();
			if (list2.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>())
			{
				global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.ReturningSelectSqlGenerator returningSelectSqlGenerator = new global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.ReturningSelectSqlGenerator();
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree dbUpdateCommandTree in list2)
				{
					dbUpdateCommandTree.Target.Expression.Accept(returningSelectSqlGenerator);
					dbUpdateCommandTree.Returning.Accept(returningSelectSqlGenerator);
					dbUpdateCommandTree.Predicate.Accept(returningSelectSqlGenerator);
				}
				stringBuilder.AppendLine(returningSelectSqlGenerator.Sql);
				stringBuilder.AppendLine();
			}
			global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.AppendSetRowsAffected(stringBuilder, rowsAffectedParameter);
			return stringBuilder.ToString().TrimEnd(new char[0]);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00010B88 File Offset: 0x0000ED88
		public string GenerateDelete(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree> commandTrees, string rowsAffectedParameter)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> list;
			stringBuilder.AppendLine(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateDeleteSql(commandTrees.First<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>(), this._sqlGenerator, out list, true, true));
			stringBuilder.AppendLine();
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree tree in commandTrees.Skip(1))
			{
				stringBuilder.AppendLine(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateDeleteSql(tree, this._sqlGenerator, out list, true, true));
				stringBuilder.AppendLine("AND @@ROWCOUNT > 0");
				stringBuilder.AppendLine();
			}
			global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator.AppendSetRowsAffected(stringBuilder, rowsAffectedParameter);
			return stringBuilder.ToString().TrimEnd(new char[0]);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00010C3C File Offset: 0x0000EE3C
		private static void AppendSetRowsAffected(global::System.Text.StringBuilder sql, string rowsAffectedParameter)
		{
			if (!string.IsNullOrWhiteSpace(rowsAffectedParameter))
			{
				sql.Append("SET @");
				sql.Append(rowsAffectedParameter);
				sql.AppendLine(" = @@ROWCOUNT");
				sql.AppendLine();
			}
		}

		// Token: 0x040000D9 RID: 217
		private readonly global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator _sqlGenerator;

		// Token: 0x02000082 RID: 130
		private sealed class ReturningSelectSqlGenerator : global::System.Data.Entity.Core.Common.CommandTrees.BasicExpressionVisitor
		{
			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001BF70 File Offset: 0x0001A170
			public string Sql
			{
				get
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.AppendLine(this._select.ToString());
					stringBuilder.AppendLine(this._from.ToString());
					stringBuilder.Append("WHERE @@ROWCOUNT > 0");
					stringBuilder.Append(this._where);
					return stringBuilder.ToString();
				}
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x0001BFC4 File Offset: 0x0001A1C4
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression newInstanceExpression)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)newInstanceExpression.ResultType.EdmType).Properties;
				for (int i = 0; i < properties.Count; i++)
				{
					this._select.Append((this._select.Length == 0) ? "SELECT " : ", ");
					this._nextPropertyAlias = properties[i].Name;
					newInstanceExpression.Arguments[i].Accept(this);
				}
				this._nextPropertyAlias = null;
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x0001C048 File Offset: 0x0001A248
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression scanExpression)
			{
				string targetTSql = global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.GetTargetTSql(scanExpression.Target);
				string str = " AS ";
				string str2 = "t";
				int aliasCount = this._aliasCount;
				this._aliasCount = aliasCount + 1;
				string value = targetTSql + str + (this._currentTableAlias = str2 + aliasCount.ToString());
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = scanExpression.Target.ElementType;
				if (this._from.Length == 0)
				{
					this._baseTable = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)elementType;
					this._from.Append("FROM ");
					this._from.Append(value);
					return;
				}
				this._from.AppendLine();
				this._from.Append("JOIN ");
				this._from.Append(value);
				this._from.Append(" ON ");
				for (int i = 0; i < elementType.KeyMembers.Count; i++)
				{
					if (i > 0)
					{
						this._from.Append(" AND ");
					}
					this._from.Append(this._currentTableAlias + ".");
					this._from.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(elementType.KeyMembers[i].Name));
					this._from.Append(" = t0.");
					this._from.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(this._baseTable.KeyMembers[i].Name));
				}
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression propertyExpression)
			{
				this._select.Append(this._currentTableAlias);
				this._select.Append(".");
				this._select.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(propertyExpression.Property.Name));
				if (!string.IsNullOrWhiteSpace(this._nextPropertyAlias) && !string.Equals(this._nextPropertyAlias, propertyExpression.Property.Name, global::System.StringComparison.Ordinal))
				{
					this._select.Append(" AS ");
					this._select.Append(this._nextPropertyAlias);
				}
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x0001C259 File Offset: 0x0001A459
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
			{
				this._where.Append("@" + expression.ParameterName);
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x0001C277 File Offset: 0x0001A477
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
			{
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x0001C27C File Offset: 0x0001A47C
			public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression comparisonExpression)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember property = ((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)comparisonExpression.Left).Property;
				if (this._baseTable.KeyMembers.Contains(property))
				{
					this._where.Append(" AND t0.");
					this._where.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(property.Name));
					this._where.Append(" = ");
					comparisonExpression.Right.Accept(this);
				}
			}

			// Token: 0x04000207 RID: 519
			private readonly global::System.Text.StringBuilder _select = new global::System.Text.StringBuilder();

			// Token: 0x04000208 RID: 520
			private readonly global::System.Text.StringBuilder _from = new global::System.Text.StringBuilder();

			// Token: 0x04000209 RID: 521
			private readonly global::System.Text.StringBuilder _where = new global::System.Text.StringBuilder();

			// Token: 0x0400020A RID: 522
			private int _aliasCount;

			// Token: 0x0400020B RID: 523
			private string _currentTableAlias;

			// Token: 0x0400020C RID: 524
			private global::System.Data.Entity.Core.Metadata.Edm.EntityType _baseTable;

			// Token: 0x0400020D RID: 525
			private string _nextPropertyAlias;
		}
	}
}
