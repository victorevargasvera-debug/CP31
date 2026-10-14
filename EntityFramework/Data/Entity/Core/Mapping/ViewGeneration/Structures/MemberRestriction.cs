using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AB RID: 1451
	internal abstract class MemberRestriction : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x000F8774 File Offset: 0x000F6974
		protected MemberRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value) : this(slot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
		{
			value
		})
		{
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x000F8787 File Offset: 0x000F6987
		protected MemberRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values)
		{
			this.m_restrictedMemberSlot = slot;
			this.m_domain = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(values, values);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x000F87A3 File Offset: 0x000F69A3
		protected MemberRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain)
		{
			this.m_restrictedMemberSlot = slot;
			this.m_domain = domain;
			this.m_isComplete = true;
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x000F87C0 File Offset: 0x000F69C0
		protected MemberRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleValues) : this(slot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(values, possibleValues))
		{
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x000F87D0 File Offset: 0x000F69D0
		internal bool IsComplete
		{
			get
			{
				return this.m_isComplete;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x000F87D8 File Offset: 0x000F69D8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot RestrictedMemberSlot
		{
			get
			{
				return this.m_restrictedMemberSlot;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x000F87E0 File Offset: 0x000F69E0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain Domain
		{
			get
			{
				return this.m_domain;
			}
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x000F87E8 File Offset: 0x000F69E8
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> GetDomainBoolExpression(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> result;
			if (domainMap != null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = domainMap.GetDomain(this.m_restrictedMemberSlot.MemberPath);
				result = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.MakeTermExpression(this, domain, this.m_domain.Values);
			}
			else
			{
				result = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral.MakeTermExpression(this, this.m_domain.AllPossibleValues, this.m_domain.Values);
			}
			return result;
		}

		// Token: 0x060046AB RID: 18091
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction CreateCompleteMemberRestriction(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleValues);

		// Token: 0x060046AC RID: 18092 RVA: 0x000F8840 File Offset: 0x000F6A40
		internal override void GetRequiredSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = this.RestrictedMemberSlot.MemberPath;
			int num = projectedSlotMap.IndexOf(memberPath);
			requiredSlots[num] = true;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x000F8868 File Offset: 0x000F6A68
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
			return memberRestriction != null && (this == memberRestriction || (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(this.m_restrictedMemberSlot, memberRestriction.m_restrictedMemberSlot) && this.m_domain.IsEqualTo(memberRestriction.m_domain)));
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x000F88B2 File Offset: 0x000F6AB2
		public override int GetHashCode()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.GetHashCode(this.m_restrictedMemberSlot) ^ this.m_domain.GetHash();
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x000F88D0 File Offset: 0x000F6AD0
		protected override bool IsIdentifierEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction memberRestriction = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction;
			return memberRestriction != null && (this == memberRestriction || global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.Equals(this.m_restrictedMemberSlot, memberRestriction.m_restrictedMemberSlot));
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x000F8905 File Offset: 0x000F6B05
		protected override int GetIdentifierHash()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.EqualityComparer.GetHashCode(this.m_restrictedMemberSlot);
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x000F8917 File Offset: 0x000F6B17
		internal override global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return this.AsEsql(builder, blockAlias, skipIsNotNull);
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x000F8922 File Offset: 0x000F6B22
		internal override global::System.Text.StringBuilder AsNegatedUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			builder.Append("NOT(");
			builder = this.AsUserString(builder, blockAlias, skipIsNotNull);
			builder.Append(")");
			return builder;
		}

		// Token: 0x04001928 RID: 6440
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot m_restrictedMemberSlot;

		// Token: 0x04001929 RID: 6441
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain m_domain;

		// Token: 0x0400192A RID: 6442
		private readonly bool m_isComplete;
	}
}
