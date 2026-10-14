using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005B0 RID: 1456
	internal sealed class ScalarConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
	{
		// Token: 0x060046F0 RID: 18160 RVA: 0x000F9A80 File Offset: 0x000F7C80
		internal ScalarConstant(object value)
		{
			this.m_scalar = value;
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x000F9A8F File Offset: 0x000F7C8F
		internal object Value
		{
			get
			{
				return this.m_scalar;
			}
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x000F9A97 File Offset: 0x000F7C97
		internal override bool IsNull()
		{
			return false;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000F9A9A File Offset: 0x000F7C9A
		internal override bool IsNotNull()
		{
			return false;
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x000F9A9D File Offset: 0x000F7C9D
		internal override bool IsUndefined()
		{
			return false;
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x000F9AA0 File Offset: 0x000F7CA0
		internal override bool HasNotNull()
		{
			return false;
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x000F9AA4 File Offset: 0x000F7CA4
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(outputMember.LeafEdmMember);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = modelTypeUsage.EdmType;
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == edmType.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).PrimitiveTypeKind;
				if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean)
				{
					bool flag = (bool)this.m_scalar;
					string value = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
					{
						flag
					});
					builder.Append(value);
					return builder;
				}
				if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
				{
					bool flag2;
					if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetIsUnicode(modelTypeUsage, out flag2))
					{
						flag2 = true;
					}
					if (flag2)
					{
						builder.Append('N');
					}
					this.AppendEscapedScalar(builder);
					return builder;
				}
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType == edmType.BuiltInTypeKind)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember = (global::System.Data.Entity.Core.Metadata.Edm.EnumMember)this.m_scalar;
				builder.Append(enumMember.Name);
				return builder;
			}
			builder.Append("CAST(");
			this.AppendEscapedScalar(builder);
			builder.Append(" AS ");
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, edmType);
			builder.Append(')');
			return builder;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x000F9B94 File Offset: 0x000F7D94
		private global::System.Text.StringBuilder AppendEscapedScalar(global::System.Text.StringBuilder builder)
		{
			string text = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}", new object[]
			{
				this.m_scalar
			});
			if (text.Contains("'"))
			{
				text = text.Replace("'", "''");
			}
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "'{0}'", new object[]
			{
				text
			});
			return builder;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x000F9BF0 File Offset: 0x000F7DF0
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(outputMember.LeafEdmMember).Constant(this.m_scalar);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x000F9C08 File Offset: 0x000F7E08
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant scalarConstant = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarConstant;
			return scalarConstant != null && global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(this.m_scalar, scalarConstant.m_scalar);
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x000F9C37 File Offset: 0x000F7E37
		public override int GetHashCode()
		{
			return this.m_scalar.GetHashCode();
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x000F9C44 File Offset: 0x000F7E44
		internal override string ToUserString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ToCompactString(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x000F9C64 File Offset: 0x000F7E64
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember = this.m_scalar as global::System.Data.Entity.Core.Metadata.Edm.EnumMember;
			if (enumMember != null)
			{
				builder.Append(enumMember.Name);
				return;
			}
			builder.Append(global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("'{0}'", new object[]
			{
				this.m_scalar
			}));
		}

		// Token: 0x04001933 RID: 6451
		private readonly object m_scalar;
	}
}
