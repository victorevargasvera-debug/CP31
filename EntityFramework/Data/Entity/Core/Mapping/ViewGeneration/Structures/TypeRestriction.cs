using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005B4 RID: 1460
	internal class TypeRestriction : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction
	{
		// Token: 0x06004719 RID: 18201 RVA: 0x000FA234 File Offset: 0x000F8434
		internal TypeRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> values) : base(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member), global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction.CreateTypeConstants(values))
		{
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x000FA248 File Offset: 0x000F8448
		internal TypeRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value) : base(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member), value)
		{
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x000FA257 File Offset: 0x000F8457
		internal TypeRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain) : base(slot, domain)
		{
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x000FA264 File Offset: 0x000F8464
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> FixRange(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = memberDomainMap.GetDomain(base.RestrictedMemberSlot.MemberPath);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(base.RestrictedMemberSlot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(range, domain)).GetDomainBoolExpression(memberDomainMap);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x000FA29B File Offset: 0x000F849B
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(base.RestrictedMemberSlot.RemapSlot(remap), base.Domain);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000FA2B4 File Offset: 0x000F84B4
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction CreateCompleteMemberRestriction(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleValues)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(base.RestrictedMemberSlot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(base.Domain.Values, possibleValues));
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x000FA2D4 File Offset: 0x000F84D4
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			if (base.Domain.Count > 1)
			{
				builder.Append('(');
			}
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in base.Domain.Values)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
				if (!flag)
				{
					builder.Append(" OR ");
				}
				flag = false;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(base.RestrictedMemberSlot.MemberPath.EdmType))
				{
					builder.Append("Deref(");
					base.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
					builder.Append(')');
				}
				else
				{
					base.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
				}
				if (constant.IsNull())
				{
					builder.Append(" IS NULL");
				}
				else
				{
					builder.Append(" IS OF (ONLY ");
					global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, typeConstant.EdmType);
					builder.Append(')');
				}
			}
			if (base.Domain.Count > 1)
			{
				builder.Append(')');
			}
			return builder;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x000FA3F8 File Offset: 0x000F85F8
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt = base.RestrictedMemberSlot.MemberPath.AsCqt(row);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(base.RestrictedMemberSlot.MemberPath.EdmType))
			{
				cqt = cqt.Deref();
			}
			if (base.Domain.Count == 1)
			{
				cqt = cqt.IsOfOnly(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant)base.Domain.Values.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>()).EdmType));
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> nodes = (from t in base.Domain.Values
				select cqt.IsOfOnly(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant)t).EdmType))).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				cqt = global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(nodes, (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.Or(next));
			}
			return cqt;
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x000FA4E0 File Offset: 0x000F86E0
		internal override global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(base.RestrictedMemberSlot.MemberPath.EdmType))
			{
				builder.Append("Deref(");
				base.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
				builder.Append(')');
			}
			else
			{
				base.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
			}
			if (base.Domain.Count > 1)
			{
				builder.Append(" is a (");
			}
			else
			{
				builder.Append(" is type ");
			}
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in base.Domain.Values)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = constant as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
				if (!flag)
				{
					builder.Append(" OR ");
				}
				if (constant.IsNull())
				{
					builder.Append(" NULL");
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, typeConstant.EdmType);
				}
				flag = false;
			}
			if (base.Domain.Count > 1)
			{
				builder.Append(')');
			}
			return builder;
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x000FA5FC File Offset: 0x000F87FC
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> CreateTypeConstants(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> types)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in types)
			{
				if (edmType == null)
				{
					yield return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null;
				}
				else
				{
					yield return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant(edmType);
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmType> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x000FA60C File Offset: 0x000F880C
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("type(");
			base.RestrictedMemberSlot.ToCompactString(builder);
			builder.Append(") IN (");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, base.Domain.Values);
			builder.Append(")");
		}
	}
}
