using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000588 RID: 1416
	internal class FragmentQueryProcessor : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileQueryProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>
	{
		// Token: 0x06004487 RID: 17543 RVA: 0x000F0668 File Offset: 0x000EE868
		public FragmentQueryProcessor(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport kb)
		{
			this._kb = kb;
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x000F0677 File Offset: 0x000EE877
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor Merge(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor qp1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor qp2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport fragmentQueryKBChaseSupport = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport();
			fragmentQueryKBChaseSupport.AddKnowledgeBase(qp1.KnowledgeBase);
			fragmentQueryKBChaseSupport.AddKnowledgeBase(qp2.KnowledgeBase);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor(fragmentQueryKBChaseSupport);
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x000F069B File Offset: 0x000EE89B
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKB KnowledgeBase
		{
			get
			{
				return this._kb;
			}
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x000F06A4 File Offset: 0x000EE8A4
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Union(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(q1.Attributes);
			hashSet.IntersectWith(q2.Attributes);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				q1.Condition,
				q2.Condition
			});
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(hashSet, whereClause);
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x000F06EE File Offset: 0x000EE8EE
		internal bool IsDisjointFrom(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2)
		{
			return !this.IsSatisfiable(this.Intersect(q1, q2));
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x000F0701 File Offset: 0x000EE901
		internal bool IsContainedIn(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2)
		{
			return !this.IsSatisfiable(this.Difference(q1, q2));
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x000F0714 File Offset: 0x000EE914
		internal bool IsEquivalentTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2)
		{
			return this.IsContainedIn(q1, q2) && this.IsContainedIn(q2, q1);
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x000F072C File Offset: 0x000EE92C
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Intersect(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(q1.Attributes);
			hashSet.IntersectWith(q2.Attributes);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				q1.Condition,
				q2.Condition
			});
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(hashSet, whereClause);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x000F0776 File Offset: 0x000EE976
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Difference(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery qA, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery qB)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.Create(qA.Attributes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAndNot(qA.Condition, qB.Condition));
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x000F0794 File Offset: 0x000EE994
		internal override bool IsSatisfiable(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery query)
		{
			return this.IsSatisfiable(query.Condition);
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x000F07A2 File Offset: 0x000EE9A2
		private bool IsSatisfiable(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition)
		{
			return this._kb.IsSatisfiable(condition.Tree);
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x000F07B8 File Offset: 0x000EE9B8
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery CreateDerivedViewBySelectingConstantAttributes(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery view)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainVariable in view.Condition.Variables)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = domainVariable.Identifier as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
				if (memberRestriction != null)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = memberRestriction.RestrictedMemberSlot.MemberPath;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain = memberRestriction.Domain;
					if (!view.Attributes.Contains(memberPath))
					{
						if (!domain.AllPossibleValues.Any((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant it) => it.HasNotNull()))
						{
							foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in domain.Values)
							{
								global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> identifier = new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domainVariable, new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
								{
									constant
								}, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer));
								global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition = view.Condition.Create(new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
								{
									view.Condition.Tree,
									new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(identifier))
								}));
								if (!this.IsSatisfiable(condition))
								{
									hashSet.Add(memberPath);
								}
							}
						}
					}
				}
			}
			if (hashSet.Count > 0)
			{
				hashSet.UnionWith(view.Attributes);
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "project({0})", new object[]
				{
					view.Description
				}), view.FromVariable, hashSet, view.Condition);
			}
			return null;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x000F097C File Offset: 0x000EEB7C
		public override string ToString()
		{
			return this._kb.ToString();
		}

		// Token: 0x040018AA RID: 6314
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport _kb;

		// Token: 0x02000B93 RID: 2963
		private class AttributeSetComparator : global::System.Collections.Generic.IEqualityComparer<global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>>
		{
			// Token: 0x060066CC RID: 26316 RVA: 0x0015F8D7 File Offset: 0x0015DAD7
			public bool Equals(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> x, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> y)
			{
				return x.SetEquals(y);
			}

			// Token: 0x060066CD RID: 26317 RVA: 0x0015F8E0 File Offset: 0x0015DAE0
			public int GetHashCode(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs)
			{
				int num = 123;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath obj in attrs)
				{
					num += global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.GetHashCode(obj) * 7;
				}
				return num;
			}
		}
	}
}
