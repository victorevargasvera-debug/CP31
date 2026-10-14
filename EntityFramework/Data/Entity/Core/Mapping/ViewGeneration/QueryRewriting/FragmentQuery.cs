using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000585 RID: 1413
	internal class FragmentQuery : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x000EF84E File Offset: 0x000EDA4E
		public global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> Attributes
		{
			get
			{
				return this.m_attributes;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000EF856 File Offset: 0x000EDA56
		public global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression Condition
		{
			get
			{
				return this.m_condition;
			}
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x000EF860 File Offset: 0x000EDA60
		public static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression fromVariable, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = cellQuery.WhereClause;
			boolExpression = boolExpression.MakeCopy();
			boolExpression.ExpensiveSimplify();
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(null, fromVariable, new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(cellQuery.GetProjectedMembers()), boolExpression);
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x000EF894 File Offset: 0x000EDA94
		public static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Create(string label, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean roleBoolean, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cellQuery)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = cellQuery.WhereClause.Create(roleBoolean);
			boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
			{
				boolExpression,
				cellQuery.WhereClause
			});
			boolExpression = boolExpression.MakeCopy();
			boolExpression.ExpensiveSimplify();
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(label, null, new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(), boolExpression);
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x000EF8E1 File Offset: 0x000EDAE1
		public static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Create(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(null, null, attrs, whereClause);
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x000EF8EC File Offset: 0x000EDAEC
		public static global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery Create(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery(null, null, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath[0], whereClause);
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x000EF8FC File Offset: 0x000EDAFC
		internal FragmentQuery(string label, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression fromVariable, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> attrs, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression condition)
		{
			this.m_label = label;
			this.m_fromVariable = fromVariable;
			this.m_condition = condition;
			this.m_attributes = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(attrs);
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x000EF926 File Offset: 0x000EDB26
		public global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression FromVariable
		{
			get
			{
				return this.m_fromVariable;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x000EF930 File Offset: 0x000EDB30
		public string Description
		{
			get
			{
				string text = this.m_label;
				if (text == null && this.m_fromVariable != null)
				{
					text = this.m_fromVariable.ToString();
				}
				return text;
			}
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x000EF95C File Offset: 0x000EDB5C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath value in this.Attributes)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(value);
			}
			if (this.Description != null && this.Description != stringBuilder.ToString())
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}: [{1} where {2}]", new object[]
				{
					this.Description,
					stringBuilder,
					this.Condition
				});
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0} where {1}]", new object[]
			{
				stringBuilder,
				this.Condition
			});
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x000EFA34 File Offset: 0x000EDC34
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateMemberCondition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant domainValue, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			if (domainValue is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(path), new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(domainValue, domainMap.GetDomain(path))), domainMap);
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(path), new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(domainValue, domainMap.GetDomain(path))), domainMap);
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x000EFA86 File Offset: 0x000EDC86
		internal static global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery> GetEqualityComparer(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor qp)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery.FragmentQueryEqualityComparer(qp);
		}

		// Token: 0x040018A0 RID: 6304
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_fromVariable;

		// Token: 0x040018A1 RID: 6305
		private readonly string m_label;

		// Token: 0x040018A2 RID: 6306
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_attributes;

		// Token: 0x040018A3 RID: 6307
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_condition;

		// Token: 0x02000B8D RID: 2957
		private class FragmentQueryEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery>
		{
			// Token: 0x060066BE RID: 26302 RVA: 0x0015F6E7 File Offset: 0x0015D8E7
			internal FragmentQueryEqualityComparer(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor qp)
			{
				this._qp = qp;
			}

			// Token: 0x060066BF RID: 26303 RVA: 0x0015F6F6 File Offset: 0x0015D8F6
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery x, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery y)
			{
				return x.Attributes.SetEquals(y.Attributes) && this._qp.IsEquivalentTo(x, y);
			}

			// Token: 0x060066C0 RID: 26304 RVA: 0x0015F71C File Offset: 0x0015D91C
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q)
			{
				int num = 0;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath obj in q.Attributes)
				{
					num ^= global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.GetHashCode(obj);
				}
				int num2 = 0;
				int num3 = 0;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction in q.Condition.MemberRestrictions)
				{
					num2 ^= global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.GetHashCode(memberRestriction.RestrictedMemberSlot.MemberPath);
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant obj2 in memberRestriction.Domain.Values)
					{
						num3 ^= global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.GetHashCode(obj2);
					}
				}
				return num * 13 + num2 * 7 + num3;
			}

			// Token: 0x04002E1E RID: 11806
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor _qp;
		}
	}
}
