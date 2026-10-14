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
	// Token: 0x020005B1 RID: 1457
	internal class ScalarRestriction : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction
	{
		// Token: 0x060046FD RID: 18173 RVA: 0x000F9CAE File Offset: 0x000F7EAE
		internal ScalarRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant value) : base(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member), value)
		{
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x000F9CBD File Offset: 0x000F7EBD
		internal ScalarRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleValues) : base(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(member), values, possibleValues)
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x000F9CCD File Offset: 0x000F7ECD
		internal ScalarRestriction(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot slot, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain) : base(slot, domain)
		{
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x000F9CD8 File Offset: 0x000F7ED8
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> FixRange(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> range, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap memberDomainMap)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domain = memberDomainMap.GetDomain(base.RestrictedMemberSlot.MemberPath);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(base.RestrictedMemberSlot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(range, domain)).GetDomainBoolExpression(memberDomainMap);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x000F9D0F File Offset: 0x000F7F0F
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(base.RestrictedMemberSlot.RemapSlot(remap), base.Domain);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x000F9D28 File Offset: 0x000F7F28
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberRestriction CreateCompleteMemberRestriction(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleValues)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(base.RestrictedMemberSlot, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(base.Domain.Values, possibleValues));
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x000F9D46 File Offset: 0x000F7F46
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return this.ToStringHelper(builder, blockAlias, skipIsNotNull, false);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x000F9D54 File Offset: 0x000F7F54
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt = null;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> <>9__4;
			this.AsCql(delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negated, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
			{
				cqt = negated.AsCqt(row, domainValues, this.RestrictedMemberSlot.MemberPath, skipIsNotNull);
			}, delegate(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
			{
				cqt = this.RestrictedMemberSlot.MemberPath.AsCqt(row);
				if (domainValues.Count == 1)
				{
					cqt = cqt.Equal(domainValues.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>().AsCqt(row, this.RestrictedMemberSlot.MemberPath));
					return;
				}
				global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> selector;
				if ((selector = <>9__4) == null)
				{
					selector = (<>9__4 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant c) => cqt.Equal(c.AsCqt(row, this.RestrictedMemberSlot.MemberPath))));
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> nodes = domainValues.Select(selector).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
				cqt = global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(nodes, (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prev, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression next) => prev.Or(next));
			}, delegate
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.RestrictedMemberSlot.MemberPath.AsCqt(row).IsNull().Not();
				cqt = ((cqt != null) ? cqt.And(dbExpression) : dbExpression);
			}, delegate
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.RestrictedMemberSlot.MemberPath.AsCqt(row).IsNull();
				cqt = ((cqt != null) ? dbExpression.Or(cqt) : dbExpression);
			}, skipIsNotNull);
			return cqt;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000F9DC5 File Offset: 0x000F7FC5
		internal override global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return this.ToStringHelper(builder, blockAlias, skipIsNotNull, true);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x000F9DD4 File Offset: 0x000F7FD4
		private global::System.Text.StringBuilder ToStringHelper(global::System.Text.StringBuilder inputBuilder, string blockAlias, bool skipIsNotNull, bool userString)
		{
			global::System.Text.StringBuilder builder = new global::System.Text.StringBuilder();
			this.AsCql(delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negated, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
			{
				if (userString)
				{
					negated.AsUserString(builder, blockAlias, domainValues, this.RestrictedMemberSlot.MemberPath, skipIsNotNull);
					return;
				}
				negated.AsEsql(builder, blockAlias, domainValues, this.RestrictedMemberSlot.MemberPath, skipIsNotNull);
			}, delegate(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainValues)
			{
				this.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
				if (domainValues.Count != 1)
				{
					builder.Append(" IN {");
					bool flag = true;
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in domainValues)
					{
						if (!flag)
						{
							builder.Append(", ");
						}
						if (userString)
						{
							constant.ToCompactString(builder);
						}
						else
						{
							constant.AsEsql(builder, this.RestrictedMemberSlot.MemberPath, blockAlias);
						}
						flag = false;
					}
					builder.Append('}');
					return;
				}
				builder.Append(" = ");
				if (userString)
				{
					domainValues.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>().ToCompactString(builder);
					return;
				}
				domainValues.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>().AsEsql(builder, this.RestrictedMemberSlot.MemberPath, blockAlias);
			}, delegate
			{
				bool flag = builder.Length == 0;
				builder.Insert(0, '(');
				if (!flag)
				{
					builder.Append(" AND ");
				}
				if (userString)
				{
					this.RestrictedMemberSlot.MemberPath.ToCompactString(builder, global::System.Data.Entity.Resources.Strings.ViewGen_EntityInstanceToken);
					builder.Append(" is not NULL)");
					return;
				}
				this.RestrictedMemberSlot.MemberPath.AsEsql(builder, blockAlias);
				builder.Append(" IS NOT NULL)");
			}, delegate
			{
				bool flag = builder.Length == 0;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				if (!flag)
				{
					stringBuilder.Append('(');
				}
				if (userString)
				{
					this.RestrictedMemberSlot.MemberPath.ToCompactString(stringBuilder, blockAlias);
					stringBuilder.Append(" is NULL");
				}
				else
				{
					this.RestrictedMemberSlot.MemberPath.AsEsql(stringBuilder, blockAlias);
					stringBuilder.Append(" IS NULL");
				}
				if (!flag)
				{
					stringBuilder.Append(" OR ");
				}
				builder.Insert(0, stringBuilder.ToString());
				if (!flag)
				{
					builder.Append(')');
				}
			}, skipIsNotNull);
			inputBuilder.Append(builder);
			return inputBuilder;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000F9E5C File Offset: 0x000F805C
		private void AsCql(global::System.Action<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> negatedConstantAsCql, global::System.Action<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> varInDomain, global::System.Action varIsNotNull, global::System.Action varIsNull, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant)base.Domain.Values.FirstOrDefault((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant c) => c is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant);
			if (negatedConstant != null)
			{
				negatedConstantAsCql(negatedConstant, base.Domain.Values);
				return;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(base.Domain.Values, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			bool flag = false;
			if (set.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null))
			{
				flag = true;
				set.Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			}
			if (set.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined))
			{
				flag = true;
				set.Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined);
			}
			bool flag2 = !skipIsNotNull && base.RestrictedMemberSlot.MemberPath.IsNullable;
			if (set.Count > 0)
			{
				varInDomain(set);
			}
			if (flag2)
			{
				varIsNotNull();
			}
			if (flag)
			{
				varIsNull();
			}
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000F9F39 File Offset: 0x000F8139
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			base.RestrictedMemberSlot.ToCompactString(builder);
			builder.Append(" IN (");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, base.Domain.Values);
			builder.Append(")");
		}
	}
}
