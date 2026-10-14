using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000596 RID: 1430
	internal class BoolExpression : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x0600452A RID: 17706 RVA: 0x000F37E6 File Offset: 0x000F19E6
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateLiteral(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(literal.GetDomainBoolExpression(memberDomainMap), memberDomainMap);
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x000F37F5 File Offset: 0x000F19F5
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(literal.GetDomainBoolExpression(this.m_memberDomainMap), this.m_memberDomainMap);
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x000F380E File Offset: 0x000F1A0E
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateNot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression expression)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Not, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				expression
			});
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x000F3820 File Offset: 0x000F1A20
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateAnd(params global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[] children)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And, children);
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x000F3829 File Offset: 0x000F1A29
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateOr(params global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[] children)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or, children);
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x000F3832 File Offset: 0x000F1A32
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateAndNot(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression e1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression e2)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				e1,
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(e2)
			});
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x000F384C File Offset: 0x000F1A4C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression Create(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(expression, this.m_memberDomainMap);
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x000F385A File Offset: 0x000F1A5A
		private BoolExpression(bool isTrue)
		{
			if (isTrue)
			{
				this.m_tree = global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
				return;
			}
			this.m_tree = global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x000F387C File Offset: 0x000F1A7C
		private BoolExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType opType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> children)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>(children);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression in children)
			{
				if (boolExpression.m_memberDomainMap != null)
				{
					this.m_memberDomainMap = boolExpression.m_memberDomainMap;
					break;
				}
			}
			switch (opType)
			{
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And:
				this.m_tree = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.ToBoolExprList(list));
				return;
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Not:
				this.m_tree = new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(list[0].m_tree);
				return;
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or:
				this.m_tree = new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.ToBoolExprList(list));
				return;
			default:
				return;
			}
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x000F3930 File Offset: 0x000F1B30
		internal BoolExpression(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
		{
			this.m_tree = expr;
			this.m_memberDomainMap = memberDomainMap;
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x000F3946 File Offset: 0x000F1B46
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> Atoms
		{
			get
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> terms = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.TermVisitor.GetTerms(this.m_tree, false);
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr in terms)
				{
					yield return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(expr, this.m_memberDomainMap);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x000F3958 File Offset: 0x000F1B58
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral AsLiteral
		{
			get
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> termExpr = this.m_tree as global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>;
				if (termExpr == null)
				{
					return null;
				}
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(termExpr);
			}
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x000F397C File Offset: 0x000F1B7C
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral GetBoolLiteral(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> term)
		{
			return term.Identifier.Variable.Identifier;
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x000F398E File Offset: 0x000F1B8E
		internal bool IsTrue
		{
			get
			{
				return this.m_tree.ExprType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.True;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x000F399E File Offset: 0x000F1B9E
		internal bool IsFalse
		{
			get
			{
				return this.m_tree.ExprType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.False;
			}
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x000F39AE File Offset: 0x000F1BAE
		internal bool IsAlwaysTrue()
		{
			this.InitializeConverter();
			return this.m_converter.Vertex.IsOne();
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x000F39C6 File Offset: 0x000F1BC6
		internal bool IsSatisfiable()
		{
			return !this.IsUnsatisfiable();
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x000F39D1 File Offset: 0x000F1BD1
		internal bool IsUnsatisfiable()
		{
			this.InitializeConverter();
			return this.m_converter.Vertex.IsZero();
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x000F39E9 File Offset: 0x000F1BE9
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> Tree
		{
			get
			{
				return this.m_tree;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x000F39F1 File Offset: 0x000F1BF1
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VariableConstraints
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.Boolean.LeafVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.GetLeaves(this.m_tree);
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x000F39FE File Offset: 0x000F1BFE
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> Variables
		{
			get
			{
				return from domainConstraint in this.VariableConstraints
				select domainConstraint.Variable;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x000F3A2A File Offset: 0x000F1C2A
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction> MemberRestrictions
		{
			get
			{
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainVariable in this.Variables)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = domainVariable.Identifier as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
					if (memberRestriction != null)
					{
						yield return memberRestriction;
					}
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> enumerator = null;
				yield break;
				yield break;
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000F3A3A File Offset: 0x000F1C3A
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> ToBoolExprList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> nodes)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression in nodes)
			{
				yield return boolExpression.m_tree;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x000F3A4A File Offset: 0x000F1C4A
		internal bool RepresentsAllTypeConditions
		{
			get
			{
				return this.MemberRestrictions.All((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction var) => var is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000F3A78 File Offset: 0x000F1C78
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression RemapLiterals(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral> remap)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.BooleanExpressionTermRewriter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> visitor = new global::System.Data.Entity.Core.Common.Utils.Boolean.BooleanExpressionTermRewriter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(delegate(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> term)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral boolLiteral;
				if (!remap.TryGetValue(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(term), out boolLiteral))
				{
					return term;
				}
				return boolLiteral.GetDomainBoolExpression(this.m_memberDomainMap);
			});
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(this.m_tree.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(visitor), this.m_memberDomainMap);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000F3AC0 File Offset: 0x000F1CC0
		internal virtual void GetRequiredSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RequiredSlotsVisitor.GetRequiredSlots(this.m_tree, projectedSlotMap, requiredSlots);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000F3ACF File Offset: 0x000F1CCF
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsEsqlVisitor.AsEsql(this.m_tree, builder, blockAlias);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000F3ADE File Offset: 0x000F1CDE
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsCqtVisitor.AsCqt(this.m_tree, row);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x000F3AEC File Offset: 0x000F1CEC
		internal global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool writeRoundtrippingMessage)
		{
			if (writeRoundtrippingMessage)
			{
				builder.AppendLine(global::System.Data.Entity.Resources.Strings.Viewgen_ConfigurationErrorMsg(blockAlias));
				builder.Append("  ");
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsUserStringVisitor.AsUserString(this.m_tree, builder, blockAlias);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x000F3B17 File Offset: 0x000F1D17
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CompactStringVisitor.ToBuilder(this.m_tree, builder);
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x000F3B26 File Offset: 0x000F1D26
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RemapBoolVisitor.RemapExtentTreeNodes(this.m_tree, this.m_memberDomainMap, remap), this.m_memberDomainMap);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x000F3B48 File Offset: 0x000F1D48
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> AddConjunctionToBools(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> bools, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conjunct)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression in bools)
			{
				if (boolExpression == null)
				{
					list.Add(null);
				}
				else
				{
					list.Add(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						boolExpression,
						conjunct
					}));
				}
			}
			return list;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000F3BBC File Offset: 0x000F1DBC
		private void InitializeConverter()
		{
			if (this.m_converter != null)
			{
				return;
			}
			this.m_converter = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(this.m_tree, global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext());
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000F3BE2 File Offset: 0x000F1DE2
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression MakeCopy()
		{
			return this.Create(this.m_tree.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression._copyVisitorInstance));
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000F3BFC File Offset: 0x000F1DFC
		internal void ExpensiveSimplify()
		{
			if (!this.IsFinal())
			{
				this.m_tree = this.m_tree.Simplify();
				return;
			}
			this.InitializeConverter();
			this.m_tree = this.m_tree.ExpensiveSimplify(out this.m_converter);
			this.FixDomainMap(this.m_memberDomainMap);
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x000F3C4C File Offset: 0x000F1E4C
		internal void FixDomainMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			this.m_tree = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.FixRangeVisitor.FixRange(this.m_tree, domainMap);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000F3C60 File Offset: 0x000F1E60
		private bool IsFinal()
		{
			return this.m_memberDomainMap != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.IsFinalVisitor.IsFinal(this.m_tree);
		}

		// Token: 0x040018DC RID: 6364
		private global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> m_tree;

		// Token: 0x040018DD RID: 6365
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_memberDomainMap;

		// Token: 0x040018DE RID: 6366
		private global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> m_converter;

		// Token: 0x040018DF RID: 6367
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.BoolComparer();

		// Token: 0x040018E0 RID: 6368
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression True = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(true);

		// Token: 0x040018E1 RID: 6369
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression False = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression(false);

		// Token: 0x040018E2 RID: 6370
		private static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CopyVisitor _copyVisitorInstance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CopyVisitor();

		// Token: 0x02000BA0 RID: 2976
		private class CopyVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
		{
		}

		// Token: 0x02000BA1 RID: 2977
		private class BoolComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>
		{
			// Token: 0x0600671B RID: 26395 RVA: 0x0016060B File Offset: 0x0015E80B
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression right)
			{
				return left == right || (left != null && right != null && left.m_tree.Equals(right.m_tree));
			}

			// Token: 0x0600671C RID: 26396 RVA: 0x0016062C File Offset: 0x0015E82C
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression expression)
			{
				return expression.m_tree.GetHashCode();
			}
		}

		// Token: 0x02000BA2 RID: 2978
		private class FixRangeVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
		{
			// Token: 0x0600671E RID: 26398 RVA: 0x00160641 File Offset: 0x0015E841
			private FixRangeVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
			{
				this.m_memberDomainMap = memberDomainMap;
			}

			// Token: 0x0600671F RID: 26399 RVA: 0x00160650 File Offset: 0x0015E850
			internal static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> FixRange(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.FixRangeVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.FixRangeVisitor(memberDomainMap);
				return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(visitor);
			}

			// Token: 0x06006720 RID: 26400 RVA: 0x0016066B File Offset: 0x0015E86B
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression).FixRange(expression.Identifier.Range, this.m_memberDomainMap);
			}

			// Token: 0x04002E61 RID: 11873
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_memberDomainMap;
		}

		// Token: 0x02000BA3 RID: 2979
		private class IsFinalVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, bool>
		{
			// Token: 0x06006721 RID: 26401 RVA: 0x0016068C File Offset: 0x0015E88C
			internal static bool IsFinal(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.IsFinalVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.IsFinalVisitor();
				return expression.Accept<bool>(visitor);
			}

			// Token: 0x06006722 RID: 26402 RVA: 0x001606A6 File Offset: 0x0015E8A6
			internal override bool VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return true;
			}

			// Token: 0x06006723 RID: 26403 RVA: 0x001606A9 File Offset: 0x0015E8A9
			internal override bool VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return true;
			}

			// Token: 0x06006724 RID: 26404 RVA: 0x001606AC File Offset: 0x0015E8AC
			internal override bool VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
				return memberRestriction == null || memberRestriction.IsComplete;
			}

			// Token: 0x06006725 RID: 26405 RVA: 0x001606D0 File Offset: 0x0015E8D0
			internal override bool VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return expression.Child.Accept<bool>(this);
			}

			// Token: 0x06006726 RID: 26406 RVA: 0x001606DE File Offset: 0x0015E8DE
			internal override bool VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression);
			}

			// Token: 0x06006727 RID: 26407 RVA: 0x001606E7 File Offset: 0x0015E8E7
			internal override bool VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression);
			}

			// Token: 0x06006728 RID: 26408 RVA: 0x001606F0 File Offset: 0x0015E8F0
			private bool VisitAndOr(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				bool flag = true;
				bool result = true;
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					if (!(boolExpr is global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>) && !(boolExpr is global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>))
					{
						bool flag2 = boolExpr.Accept<bool>(this);
						if (flag)
						{
							result = flag2;
						}
						flag = false;
					}
				}
				return result;
			}
		}

		// Token: 0x02000BA4 RID: 2980
		private class RemapBoolVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
		{
			// Token: 0x0600672A RID: 26410 RVA: 0x0016076C File Offset: 0x0015E96C
			private RemapBoolVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
			{
				this.m_remap = remap;
				this.m_memberDomainMap = memberDomainMap;
			}

			// Token: 0x0600672B RID: 26411 RVA: 0x00160784 File Offset: 0x0015E984
			internal static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> RemapExtentTreeNodes(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RemapBoolVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RemapBoolVisitor(memberDomainMap, remap);
				return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(visitor);
			}

			// Token: 0x0600672C RID: 26412 RVA: 0x001607A0 File Offset: 0x0015E9A0
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression).RemapBool(this.m_remap).GetDomainBoolExpression(this.m_memberDomainMap);
			}

			// Token: 0x04002E62 RID: 11874
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_remap;

			// Token: 0x04002E63 RID: 11875
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_memberDomainMap;
		}

		// Token: 0x02000BA5 RID: 2981
		private class RequiredSlotsVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
		{
			// Token: 0x0600672D RID: 26413 RVA: 0x001607BE File Offset: 0x0015E9BE
			private RequiredSlotsVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
			{
				this.m_projectedSlotMap = projectedSlotMap;
				this.m_requiredSlots = requiredSlots;
			}

			// Token: 0x0600672E RID: 26414 RVA: 0x001607D4 File Offset: 0x0015E9D4
			internal static void GetRequiredSlots(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RequiredSlotsVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.RequiredSlotsVisitor(projectedSlotMap, requiredSlots);
				expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(visitor);
			}

			// Token: 0x0600672F RID: 26415 RVA: 0x001607F1 File Offset: 0x0015E9F1
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression).GetRequiredSlots(this.m_projectedSlotMap, this.m_requiredSlots);
				return expression;
			}

			// Token: 0x04002E64 RID: 11876
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex m_projectedSlotMap;

			// Token: 0x04002E65 RID: 11877
			private readonly bool[] m_requiredSlots;
		}

		// Token: 0x02000BA6 RID: 2982
		private sealed class AsEsqlVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsCqlVisitor<global::System.Text.StringBuilder>
		{
			// Token: 0x06006730 RID: 26416 RVA: 0x0016080C File Offset: 0x0015EA0C
			internal static global::System.Text.StringBuilder AsEsql(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Text.StringBuilder builder, string blockAlias)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsEsqlVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsEsqlVisitor(builder, blockAlias);
				return expression.Accept<global::System.Text.StringBuilder>(visitor);
			}

			// Token: 0x06006731 RID: 26417 RVA: 0x00160828 File Offset: 0x0015EA28
			private AsEsqlVisitor(global::System.Text.StringBuilder builder, string blockAlias)
			{
				this.m_builder = builder;
				this.m_blockAlias = blockAlias;
			}

			// Token: 0x06006732 RID: 26418 RVA: 0x0016083E File Offset: 0x0015EA3E
			internal override global::System.Text.StringBuilder VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("True");
				return this.m_builder;
			}

			// Token: 0x06006733 RID: 26419 RVA: 0x00160857 File Offset: 0x0015EA57
			internal override global::System.Text.StringBuilder VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("False");
				return this.m_builder;
			}

			// Token: 0x06006734 RID: 26420 RVA: 0x00160870 File Offset: 0x0015EA70
			protected override global::System.Text.StringBuilder BooleanLiteralAsCql(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, bool skipIsNotNull)
			{
				return literal.AsEsql(this.m_builder, this.m_blockAlias, skipIsNotNull);
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x00160885 File Offset: 0x0015EA85
			protected override global::System.Text.StringBuilder NotExprAsCql(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("NOT(");
				expression.Child.Accept<global::System.Text.StringBuilder>(this);
				this.m_builder.Append(")");
				return this.m_builder;
			}

			// Token: 0x06006736 RID: 26422 RVA: 0x001608BC File Offset: 0x0015EABC
			internal override global::System.Text.StringBuilder VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And);
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x001608C6 File Offset: 0x0015EAC6
			internal override global::System.Text.StringBuilder VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or);
			}

			// Token: 0x06006738 RID: 26424 RVA: 0x001608D0 File Offset: 0x0015EAD0
			private global::System.Text.StringBuilder VisitAndOr(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType kind)
			{
				this.m_builder.Append('(');
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					if (!flag)
					{
						if (kind == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And)
						{
							this.m_builder.Append(" AND ");
						}
						else
						{
							this.m_builder.Append(" OR ");
						}
					}
					flag = false;
					boolExpr.Accept<global::System.Text.StringBuilder>(this);
				}
				this.m_builder.Append(')');
				return this.m_builder;
			}

			// Token: 0x04002E66 RID: 11878
			private readonly global::System.Text.StringBuilder m_builder;

			// Token: 0x04002E67 RID: 11879
			private readonly string m_blockAlias;
		}

		// Token: 0x02000BA7 RID: 2983
		private sealed class AsCqtVisitor : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsCqlVisitor<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>
		{
			// Token: 0x06006739 RID: 26425 RVA: 0x00160974 File Offset: 0x0015EB74
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsCqtVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsCqtVisitor(row);
				return expression.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(visitor);
			}

			// Token: 0x0600673A RID: 26426 RVA: 0x0016098F File Offset: 0x0015EB8F
			private AsCqtVisitor(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
			{
				this.m_row = row;
			}

			// Token: 0x0600673B RID: 26427 RVA: 0x0016099E File Offset: 0x0015EB9E
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
			}

			// Token: 0x0600673C RID: 26428 RVA: 0x001609A5 File Offset: 0x0015EBA5
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
			}

			// Token: 0x0600673D RID: 26429 RVA: 0x001609AC File Offset: 0x0015EBAC
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression BooleanLiteralAsCql(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, bool skipIsNotNull)
			{
				return literal.AsCqt(this.m_row, skipIsNotNull);
			}

			// Token: 0x0600673E RID: 26430 RVA: 0x001609BB File Offset: 0x0015EBBB
			protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression NotExprAsCql(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return expression.Child.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this).Not();
			}

			// Token: 0x0600673F RID: 26431 RVA: 0x001609CE File Offset: 0x0015EBCE
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.And));
			}

			// Token: 0x06006740 RID: 26432 RVA: 0x001609E3 File Offset: 0x0015EBE3
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Or));
			}

			// Token: 0x06006741 RID: 26433 RVA: 0x001609F8 File Offset: 0x0015EBF8
			private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitAndOr(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> op)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					if (dbExpression == null)
					{
						dbExpression = boolExpr.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this);
					}
					else
					{
						dbExpression = op(dbExpression, boolExpr.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this));
					}
				}
				return dbExpression;
			}

			// Token: 0x04002E68 RID: 11880
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression m_row;
		}

		// Token: 0x02000BA8 RID: 2984
		private abstract class AsCqlVisitor<T_Return> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, T_Return>
		{
			// Token: 0x06006742 RID: 26434 RVA: 0x00160A64 File Offset: 0x0015EC64
			protected AsCqlVisitor()
			{
				this.m_skipIsNotNull = true;
			}

			// Token: 0x06006743 RID: 26435 RVA: 0x00160A74 File Offset: 0x0015EC74
			internal override T_Return VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral boolLiteral = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression);
				return this.BooleanLiteralAsCql(boolLiteral, this.m_skipIsNotNull);
			}

			// Token: 0x06006744 RID: 26436
			protected abstract T_Return BooleanLiteralAsCql(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral literal, bool skipIsNotNull);

			// Token: 0x06006745 RID: 26437 RVA: 0x00160A95 File Offset: 0x0015EC95
			internal override T_Return VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_skipIsNotNull = false;
				return this.NotExprAsCql(expression);
			}

			// Token: 0x06006746 RID: 26438
			protected abstract T_Return NotExprAsCql(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression);

			// Token: 0x04002E69 RID: 11881
			private bool m_skipIsNotNull;
		}

		// Token: 0x02000BA9 RID: 2985
		private class AsUserStringVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Text.StringBuilder>
		{
			// Token: 0x06006747 RID: 26439 RVA: 0x00160AA5 File Offset: 0x0015ECA5
			private AsUserStringVisitor(global::System.Text.StringBuilder builder, string blockAlias)
			{
				this.m_builder = builder;
				this.m_blockAlias = blockAlias;
				this.m_skipIsNotNull = true;
			}

			// Token: 0x06006748 RID: 26440 RVA: 0x00160AC4 File Offset: 0x0015ECC4
			internal static global::System.Text.StringBuilder AsUserString(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Text.StringBuilder builder, string blockAlias)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsUserStringVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AsUserStringVisitor(builder, blockAlias);
				return expression.Accept<global::System.Text.StringBuilder>(visitor);
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x00160AE0 File Offset: 0x0015ECE0
			internal override global::System.Text.StringBuilder VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("True");
				return this.m_builder;
			}

			// Token: 0x0600674A RID: 26442 RVA: 0x00160AF9 File Offset: 0x0015ECF9
			internal override global::System.Text.StringBuilder VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("False");
				return this.m_builder;
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x00160B14 File Offset: 0x0015ED14
			internal override global::System.Text.StringBuilder VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral boolLiteral = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression);
				if (boolLiteral is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction || boolLiteral is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction)
				{
					return boolLiteral.AsUserString(this.m_builder, global::System.Data.Entity.Resources.Strings.ViewGen_EntityInstanceToken, this.m_skipIsNotNull);
				}
				return boolLiteral.AsUserString(this.m_builder, this.m_blockAlias, this.m_skipIsNotNull);
			}

			// Token: 0x0600674C RID: 26444 RVA: 0x00160B68 File Offset: 0x0015ED68
			internal override global::System.Text.StringBuilder VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_skipIsNotNull = false;
				global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> termExpr = expression.Child as global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>;
				if (termExpr != null)
				{
					return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(termExpr).AsNegatedUserString(this.m_builder, this.m_blockAlias, this.m_skipIsNotNull);
				}
				this.m_builder.Append("NOT(");
				expression.Child.Accept<global::System.Text.StringBuilder>(this);
				this.m_builder.Append(")");
				return this.m_builder;
			}

			// Token: 0x0600674D RID: 26445 RVA: 0x00160BDE File Offset: 0x0015EDDE
			internal override global::System.Text.StringBuilder VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And);
			}

			// Token: 0x0600674E RID: 26446 RVA: 0x00160BE8 File Offset: 0x0015EDE8
			internal override global::System.Text.StringBuilder VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or);
			}

			// Token: 0x0600674F RID: 26447 RVA: 0x00160BF4 File Offset: 0x0015EDF4
			private global::System.Text.StringBuilder VisitAndOr(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType kind)
			{
				this.m_builder.Append('(');
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					if (!flag)
					{
						if (kind == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And)
						{
							this.m_builder.Append(" AND ");
						}
						else
						{
							this.m_builder.Append(" OR ");
						}
					}
					flag = false;
					boolExpr.Accept<global::System.Text.StringBuilder>(this);
				}
				this.m_builder.Append(')');
				return this.m_builder;
			}

			// Token: 0x04002E6A RID: 11882
			private readonly global::System.Text.StringBuilder m_builder;

			// Token: 0x04002E6B RID: 11883
			private readonly string m_blockAlias;

			// Token: 0x04002E6C RID: 11884
			private bool m_skipIsNotNull;
		}

		// Token: 0x02000BAA RID: 2986
		private class TermVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>>
		{
			// Token: 0x06006750 RID: 26448 RVA: 0x00160C98 File Offset: 0x0015EE98
			private TermVisitor(bool allowAllOperators)
			{
			}

			// Token: 0x06006751 RID: 26449 RVA: 0x00160CA0 File Offset: 0x0015EEA0
			internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> GetTerms(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, bool allowAllOperators)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.TermVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.TermVisitor(allowAllOperators);
				return expression.Accept<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>>(visitor);
			}

			// Token: 0x06006752 RID: 26450 RVA: 0x00160CBB File Offset: 0x0015EEBB
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				yield break;
			}

			// Token: 0x06006753 RID: 26451 RVA: 0x00160CC4 File Offset: 0x0015EEC4
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				yield break;
			}

			// Token: 0x06006754 RID: 26452 RVA: 0x00160CCD File Offset: 0x0015EECD
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				yield return expression;
				yield break;
			}

			// Token: 0x06006755 RID: 26453 RVA: 0x00160CDD File Offset: 0x0015EEDD
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitTreeNode(expression);
			}

			// Token: 0x06006756 RID: 26454 RVA: 0x00160CE6 File Offset: 0x0015EEE6
			private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitTreeNode(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> termExpr in boolExpr.Accept<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>>(this))
					{
						yield return termExpr;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> enumerator2 = null;
				}
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>.Enumerator enumerator = default(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>.Enumerator);
				yield break;
				yield break;
			}

			// Token: 0x06006757 RID: 26455 RVA: 0x00160CFD File Offset: 0x0015EEFD
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitTreeNode(expression);
			}

			// Token: 0x06006758 RID: 26456 RVA: 0x00160D06 File Offset: 0x0015EF06
			internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitTreeNode(expression);
			}
		}

		// Token: 0x02000BAB RID: 2987
		private class CompactStringVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Text.StringBuilder>
		{
			// Token: 0x06006759 RID: 26457 RVA: 0x00160D0F File Offset: 0x0015EF0F
			private CompactStringVisitor(global::System.Text.StringBuilder builder)
			{
				this.m_builder = builder;
			}

			// Token: 0x0600675A RID: 26458 RVA: 0x00160D20 File Offset: 0x0015EF20
			internal static global::System.Text.StringBuilder ToBuilder(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, global::System.Text.StringBuilder builder)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CompactStringVisitor visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CompactStringVisitor(builder);
				return expression.Accept<global::System.Text.StringBuilder>(visitor);
			}

			// Token: 0x0600675B RID: 26459 RVA: 0x00160D3B File Offset: 0x0015EF3B
			internal override global::System.Text.StringBuilder VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("True");
				return this.m_builder;
			}

			// Token: 0x0600675C RID: 26460 RVA: 0x00160D54 File Offset: 0x0015EF54
			internal override global::System.Text.StringBuilder VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("False");
				return this.m_builder;
			}

			// Token: 0x0600675D RID: 26461 RVA: 0x00160D6D File Offset: 0x0015EF6D
			internal override global::System.Text.StringBuilder VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.GetBoolLiteral(expression).ToCompactString(this.m_builder);
				return this.m_builder;
			}

			// Token: 0x0600675E RID: 26462 RVA: 0x00160D86 File Offset: 0x0015EF86
			internal override global::System.Text.StringBuilder VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				this.m_builder.Append("NOT(");
				expression.Child.Accept<global::System.Text.StringBuilder>(this);
				this.m_builder.Append(")");
				return this.m_builder;
			}

			// Token: 0x0600675F RID: 26463 RVA: 0x00160DBD File Offset: 0x0015EFBD
			internal override global::System.Text.StringBuilder VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, "AND");
			}

			// Token: 0x06006760 RID: 26464 RVA: 0x00160DCB File Offset: 0x0015EFCB
			internal override global::System.Text.StringBuilder VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return this.VisitAndOr(expression, "OR");
			}

			// Token: 0x06006761 RID: 26465 RVA: 0x00160DDC File Offset: 0x0015EFDC
			private global::System.Text.StringBuilder VisitAndOr(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression, string opAsString)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Text.StringBuilder builder = this.m_builder;
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr in expression.Children)
				{
					this.m_builder = new global::System.Text.StringBuilder();
					boolExpr.Accept<global::System.Text.StringBuilder>(this);
					list.Add(this.m_builder.ToString());
				}
				this.m_builder = builder;
				this.m_builder.Append('(');
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedStringSorted(this.m_builder, list, " " + opAsString + " ");
				this.m_builder.Append(')');
				return this.m_builder;
			}

			// Token: 0x04002E6D RID: 11885
			private global::System.Text.StringBuilder m_builder;
		}
	}
}
