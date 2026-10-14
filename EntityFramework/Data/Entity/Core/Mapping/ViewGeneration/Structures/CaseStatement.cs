using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000598 RID: 1432
	internal sealed class CaseStatement : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x0600455F RID: 17759 RVA: 0x000F3D3C File Offset: 0x000F1F3C
		internal CaseStatement(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath)
		{
			this.m_memberPath = memberPath;
			this.m_clauses = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>();
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x000F3D56 File Offset: 0x000F1F56
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath MemberPath
		{
			get
			{
				return this.m_memberPath;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x000F3D5E File Offset: 0x000F1F5E
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen> Clauses
		{
			get
			{
				return this.m_clauses;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x000F3D66 File Offset: 0x000F1F66
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot ElseValue
		{
			get
			{
				return this.m_elseValue;
			}
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x000F3D70 File Offset: 0x000F1F70
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement DeepQualify(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement(this.m_memberPath);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in this.m_clauses)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen item = whenThen.ReplaceWithQualifiedSlot(block);
				caseStatement.m_clauses.Add(item);
			}
			if (this.m_elseValue != null)
			{
				caseStatement.m_elseValue = this.m_elseValue.DeepQualify(block);
			}
			caseStatement.m_simplified = this.m_simplified;
			return caseStatement;
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x000F3E04 File Offset: 0x000F2004
		internal void AddWhenThen(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot value)
		{
			condition.ExpensiveSimplify();
			this.m_clauses.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen(condition, value));
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x000F3E20 File Offset: 0x000F2020
		internal bool DependsOnMemberValue
		{
			get
			{
				if (this.m_elseValue is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)
				{
					return true;
				}
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>.Enumerator enumerator = this.m_clauses.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Value is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x000F3E90 File Offset: 0x000F2090
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> InstantiatedTypes
		{
			get
			{
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>.Enumerator enumerator = this.m_clauses.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
						if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.TryGetInstantiatedType(enumerator.Current.Value, out edmType))
						{
							yield return edmType;
						}
					}
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>.Enumerator);
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2;
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.TryGetInstantiatedType(this.m_elseValue, out edmType2))
				{
					yield return edmType2;
				}
				yield break;
				yield break;
			}
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000F3EA0 File Offset: 0x000F20A0
		private static bool TryGetInstantiatedType(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot, out global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			type = null;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = slot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot;
			if (constantProjectedSlot != null)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constantProjectedSlot.CellConstant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
				if (typeConstant != null)
				{
					type = typeConstant.EdmType;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x000F3ED4 File Offset: 0x000F20D4
		internal void Simplify()
		{
			if (this.m_simplified)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen>();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in this.m_clauses)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot constantProjectedSlot = whenThen.Value as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot;
				if (constantProjectedSlot != null && (constantProjectedSlot.CellConstant.IsNull() || constantProjectedSlot.CellConstant.IsUndefined()))
				{
					flag = true;
				}
				else
				{
					list.Add(whenThen);
					if (whenThen.Condition.IsTrue)
					{
						break;
					}
				}
			}
			if (flag && list.Count == 0)
			{
				this.m_elseValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			}
			if (list.Count > 0 && !flag)
			{
				int index = list.Count - 1;
				this.m_elseValue = list[index].Value;
				list.RemoveAt(index);
			}
			this.m_clauses = list;
			this.m_simplified = true;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x000F3FD4 File Offset: 0x000F21D4
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships, string blockAlias, int indentLevel)
		{
			if (this.Clauses.Count == 0)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.CaseSlotValueAsEsql(builder, this.ElseValue, this.MemberPath, blockAlias, withRelationships, indentLevel);
				return builder;
			}
			builder.Append("CASE");
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in this.Clauses)
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 2);
				builder.Append("WHEN ");
				whenThen.Condition.AsEsql(builder, blockAlias);
				builder.Append(" THEN ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.CaseSlotValueAsEsql(builder, whenThen.Value, this.MemberPath, blockAlias, withRelationships, indentLevel + 2);
			}
			if (this.ElseValue != null)
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 2);
				builder.Append("ELSE ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.CaseSlotValueAsEsql(builder, this.ElseValue, this.MemberPath, blockAlias, withRelationships, indentLevel + 2);
			}
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
			builder.Append("END");
			return builder;
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x000F40EC File Offset: 0x000F22EC
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in this.Clauses)
			{
				list.Add(whenThen.Condition.AsCqt(row));
				list2.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.CaseSlotValueAsCqt(row, whenThen.Value, this.MemberPath, withRelationships));
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = (this.ElseValue != null) ? global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.CaseSlotValueAsCqt(row, this.ElseValue, this.MemberPath, withRelationships) : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null.AsCqt(row, this.MemberPath);
			if (this.Clauses.Count > 0)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list, list2, dbExpression);
			}
			return dbExpression;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000F41BC File Offset: 0x000F23BC
		private static global::System.Text.StringBuilder CaseSlotValueAsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships, int indentLevel)
		{
			slot.AsEsql(builder, outputMember, blockAlias, 1);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WithRelationshipsClauseAsEsql(builder, withRelationships, blockAlias, indentLevel, slot);
			return builder;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x000F41D6 File Offset: 0x000F23D6
		private static void WithRelationshipsClauseAsEsql(global::System.Text.StringBuilder builder, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships, string blockAlias, int indentLevel, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot)
		{
			bool first = true;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WithRelationshipsClauseAsCql(delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship withRelationship)
			{
				if (first)
				{
					builder.Append(" WITH ");
					first = false;
				}
				withRelationship.AsEsql(builder, blockAlias, indentLevel);
			}, withRelationships, slot);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x000F420C File Offset: 0x000F240C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CaseSlotValueAsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression slotValueExpr = slot.AsCqt(row, outputMember);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WithRelationshipsClauseAsCqt(row, slotValueExpr, withRelationships, slot);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x000F4230 File Offset: 0x000F2430
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression WithRelationshipsClauseAsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression slotValueExpr, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relatedEntityRefs = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WithRelationshipsClauseAsCql(delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship withRelationship)
			{
				relatedEntityRefs.Add(withRelationship.AsCqt(row));
			}, withRelationships, slot);
			if (relatedEntityRefs.Count > 0)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = slotValueExpr as global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression;
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewEntityWithRelationshipsExpression((global::System.Data.Entity.Core.Metadata.Edm.EntityType)dbNewInstanceExpression.ResultType.EdmType, dbNewInstanceExpression.Arguments, relatedEntityRefs);
			}
			return slotValueExpr;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x000F42A0 File Offset: 0x000F24A0
		private static void WithRelationshipsClauseAsCql(global::System.Action<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> emitWithRelationship, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slot)
		{
			if (withRelationships != null && withRelationships.Count<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship>() > 0)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = ((slot as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot).CellConstant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant).EdmType;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship withRelationship in withRelationships)
				{
					if (withRelationship.FromEndEntityType.IsAssignableFrom(edmType))
					{
						emitWithRelationship(withRelationship);
					}
				}
			}
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x000F4318 File Offset: 0x000F2518
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.AppendLine("CASE");
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in this.m_clauses)
			{
				builder.Append(" WHEN ");
				whenThen.Condition.ToCompactString(builder);
				builder.Append(" THEN ");
				whenThen.Value.ToCompactString(builder);
				builder.AppendLine();
			}
			if (this.m_elseValue != null)
			{
				builder.Append(" ELSE ");
				this.m_elseValue.ToCompactString(builder);
				builder.AppendLine();
			}
			builder.Append(" END AS ");
			this.m_memberPath.ToCompactString(builder);
		}

		// Token: 0x040018E5 RID: 6373
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m_memberPath;

		// Token: 0x040018E6 RID: 6374
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen> m_clauses;

		// Token: 0x040018E7 RID: 6375
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot m_elseValue;

		// Token: 0x040018E8 RID: 6376
		private bool m_simplified;

		// Token: 0x02000BB3 RID: 2995
		internal sealed class WhenThen : global::System.Data.Entity.Core.Common.Utils.InternalBase
		{
			// Token: 0x06006789 RID: 26505 RVA: 0x001613DB File Offset: 0x0015F5DB
			internal WhenThen(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot value)
			{
				this.m_condition = condition;
				this.m_value = value;
			}

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x0600678A RID: 26506 RVA: 0x001613F1 File Offset: 0x0015F5F1
			internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression Condition
			{
				get
				{
					return this.m_condition;
				}
			}

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x0600678B RID: 26507 RVA: 0x001613F9 File Offset: 0x0015F5F9
			internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot Value
			{
				get
				{
					return this.m_value;
				}
			}

			// Token: 0x0600678C RID: 26508 RVA: 0x00161404 File Offset: 0x0015F604
			internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen ReplaceWithQualifiedSlot(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock block)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot value = this.m_value.DeepQualify(block);
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen(this.m_condition, value);
			}

			// Token: 0x0600678D RID: 26509 RVA: 0x0016142A File Offset: 0x0015F62A
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append("WHEN ");
				this.m_condition.ToCompactString(builder);
				builder.Append("THEN ");
				this.m_value.ToCompactString(builder);
			}

			// Token: 0x04002E83 RID: 11907
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_condition;

			// Token: 0x04002E84 RID: 11908
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot m_value;
		}
	}
}
