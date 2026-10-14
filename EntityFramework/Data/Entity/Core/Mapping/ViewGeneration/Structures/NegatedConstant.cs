using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005AC RID: 1452
	internal sealed class NegatedConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
	{
		// Token: 0x060046B3 RID: 18099 RVA: 0x000F8948 File Offset: 0x000F6B48
		internal NegatedConstant(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> values)
		{
			this.m_negatedDomain = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(values, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000F8961 File Offset: 0x000F6B61
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> Elements
		{
			get
			{
				return this.m_negatedDomain;
			}
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x000F8969 File Offset: 0x000F6B69
		internal bool Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant)
		{
			return this.m_negatedDomain.Contains(constant);
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x000F8977 File Offset: 0x000F6B77
		internal override bool IsNull()
		{
			return false;
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x000F897A File Offset: 0x000F6B7A
		internal override bool IsNotNull()
		{
			return this == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NotNull || (this.m_negatedDomain.Count == 1 && this.m_negatedDomain.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null));
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x000F89A6 File Offset: 0x000F6BA6
		internal override bool IsUndefined()
		{
			return false;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x000F89A9 File Offset: 0x000F6BA9
		internal override bool HasNotNull()
		{
			return this.m_negatedDomain.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x000F89BC File Offset: 0x000F6BBC
		public override int GetHashCode()
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant obj in this.m_negatedDomain)
			{
				num ^= global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer.GetHashCode(obj);
			}
			return num;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x000F8A1C File Offset: 0x000F6C1C
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant negatedConstant = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant;
			return negatedConstant != null && this.m_negatedDomain.SetEquals(negatedConstant.m_negatedDomain);
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x000F8A46 File Offset: 0x000F6C46
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
		{
			return null;
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x000F8A49 File Offset: 0x000F6C49
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return null;
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x000F8A4C File Offset: 0x000F6C4C
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool skipIsNotNull)
		{
			return this.ToStringHelper(builder, blockAlias, constants, outputMember, skipIsNotNull, false);
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x000F8A5C File Offset: 0x000F6C5C
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt = null;
			this.AsCql(delegate
			{
				cqt = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
			}, delegate
			{
				cqt = outputMember.AsCqt(row).IsNull().Not();
			}, delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = outputMember.AsCqt(row).NotEqual(constant.AsCqt(row, outputMember));
				if (cqt != null)
				{
					cqt = cqt.And(dbExpression);
					return;
				}
				cqt = dbExpression;
			}, constants, outputMember, skipIsNotNull);
			return cqt;
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x000F8ABD File Offset: 0x000F6CBD
		internal global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool skipIsNotNull)
		{
			return this.ToStringHelper(builder, blockAlias, constants, outputMember, skipIsNotNull, true);
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x000F8AD0 File Offset: 0x000F6CD0
		private void AsCql(global::System.Action trueLiteral, global::System.Action varIsNotNull, global::System.Action<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> varNotEqualsTo, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool skipIsNotNull)
		{
			bool isNullable = outputMember.IsNullable;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(this.Elements, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in constants)
			{
				if (!constant.Equals(this))
				{
					set.Remove(constant);
				}
			}
			if (set.Count == 0)
			{
				trueLiteral();
				return;
			}
			bool flag = set.Contains(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			set.Remove(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Null);
			if (flag || (isNullable && !skipIsNotNull))
			{
				varIsNotNull();
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant obj in set)
			{
				varNotEqualsTo(obj);
			}
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x000F8BB4 File Offset: 0x000F6DB4
		private global::System.Text.StringBuilder ToStringHelper(global::System.Text.StringBuilder builder, string blockAlias, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, bool skipIsNotNull, bool userString)
		{
			bool anyAdded = false;
			this.AsCql(delegate
			{
				builder.Append("true");
			}, delegate
			{
				if (userString)
				{
					outputMember.ToCompactString(builder, blockAlias);
					builder.Append(" is not NULL");
				}
				else
				{
					outputMember.AsEsql(builder, blockAlias);
					builder.Append(" IS NOT NULL");
				}
				anyAdded = true;
			}, delegate(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant)
			{
				if (anyAdded)
				{
					builder.Append(" AND ");
				}
				anyAdded = true;
				if (userString)
				{
					outputMember.ToCompactString(builder, blockAlias);
					builder.Append(" <>");
					constant.ToCompactString(builder);
					return;
				}
				outputMember.AsEsql(builder, blockAlias);
				builder.Append(" <>");
				constant.AsEsql(builder, outputMember, blockAlias);
			}, constants, outputMember, skipIsNotNull);
			return builder;
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x000F8C28 File Offset: 0x000F6E28
		internal override string ToUserString()
		{
			if (this.IsNotNull())
			{
				return global::System.Data.Entity.Resources.Strings.ViewGen_NotNull;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in this.m_negatedDomain)
			{
				if (this.m_negatedDomain.Count <= 1 || !constant.IsNull())
				{
					if (!flag)
					{
						stringBuilder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_CommaBlank);
					}
					flag = false;
					stringBuilder.Append(constant.ToUserString());
				}
			}
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			stringBuilder2.Append(global::System.Data.Entity.Resources.Strings.ViewGen_NegatedCellConstant(stringBuilder.ToString()));
			return stringBuilder2.ToString();
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x000F8CDC File Offset: 0x000F6EDC
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			if (this.IsNotNull())
			{
				builder.Append("NOT_NULL");
				return;
			}
			builder.Append("NOT(");
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, this.m_negatedDomain);
			builder.Append(")");
		}

		// Token: 0x0400192B RID: 6443
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> m_negatedDomain;
	}
}
