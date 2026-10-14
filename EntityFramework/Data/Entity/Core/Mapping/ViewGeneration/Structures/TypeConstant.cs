using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005B3 RID: 1459
	internal sealed class TypeConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
	{
		// Token: 0x0600470C RID: 18188 RVA: 0x000FA01C File Offset: 0x000F821C
		internal TypeConstant(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			this.m_edmType = type;
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x000FA02B File Offset: 0x000F822B
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmType EdmType
		{
			get
			{
				return this.m_edmType;
			}
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x000FA033 File Offset: 0x000F8233
		internal override bool IsNull()
		{
			return false;
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x000FA036 File Offset: 0x000F8236
		internal override bool IsNotNull()
		{
			return false;
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x000FA039 File Offset: 0x000F8239
		internal override bool IsUndefined()
		{
			return false;
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x000FA03C File Offset: 0x000F823C
		internal override bool HasNotNull()
		{
			return false;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x000FA040 File Offset: 0x000F8240
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant typeConstant = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant;
			return typeConstant != null && this.m_edmType == typeConstant.m_edmType;
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x000FA067 File Offset: 0x000F8267
		public override int GetHashCode()
		{
			if (this.m_edmType == null)
			{
				return 0;
			}
			return this.m_edmType.GetHashCode();
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x000FA080 File Offset: 0x000F8280
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
		{
			this.AsCql(delegate(global::System.Data.Entity.Core.Metadata.Edm.EntitySet refScopeEntitySet, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> keyMemberOutputPaths)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType type = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)outputMember.EdmType).ElementType;
				builder.Append("CreateRef(");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedQualifiedName(builder, refScopeEntitySet.EntityContainer.Name, refScopeEntitySet.Name);
				builder.Append(", row(");
				for (int i = 0; i < keyMemberOutputPaths.Count; i++)
				{
					if (i > 0)
					{
						builder.Append(", ");
					}
					string qualifiedName = global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(blockAlias, keyMemberOutputPaths[i].CqlFieldAlias);
					builder.Append(qualifiedName);
				}
				builder.Append("), ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, type);
				builder.Append(')');
			}, delegate(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> membersOutputPaths)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, this.m_edmType);
				builder.Append('(');
				for (int i = 0; i < membersOutputPaths.Count; i++)
				{
					if (i > 0)
					{
						builder.Append(", ");
					}
					string qualifiedName = global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(blockAlias, membersOutputPaths[i].CqlFieldAlias);
					builder.Append(qualifiedName);
				}
				builder.Append(')');
			}, outputMember);
			return builder;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x000FA0DC File Offset: 0x000F82DC
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression cqt = null;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> <>9__2;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> <>9__3;
			this.AsCql(delegate(global::System.Data.Entity.Core.Metadata.Edm.EntitySet refScopeEntitySet, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> keyMemberOutputPaths)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)outputMember.EdmType).ElementType;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = entityType;
				global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> selector;
				if ((selector = <>9__2) == null)
				{
					selector = (<>9__2 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath km) => row.Property(km.CqlFieldAlias)));
				}
				cqt = refScopeEntitySet.CreateRef(entityType2, keyMemberOutputPaths.Select(selector));
			}, delegate(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> membersOutputPaths)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(this.m_edmType);
				global::System.Func<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> selector;
				if ((selector = <>9__3) == null)
				{
					selector = (<>9__3 = ((global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath m) => row.Property(m.CqlFieldAlias)));
				}
				cqt = instanceType.New(membersOutputPaths.Select(selector));
			}, outputMember);
			return cqt;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x000FA138 File Offset: 0x000F8338
		private void AsCql(global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>> createRef, global::System.Action<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>> createType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet scopeOfRelationEnd = outputMember.GetScopeOfRelationEnd();
			if (scopeOfRelationEnd != null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> arg = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(from km in scopeOfRelationEnd.ElementType.KeyMembers
				select new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(outputMember, km));
				createRef(scopeOfRelationEnd, arg);
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (object obj in global::System.Data.Entity.Core.Metadata.Edm.Helper.GetAllStructuralMembers(this.m_edmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember last = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				list.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(outputMember, last));
			}
			createType(list);
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x000FA200 File Offset: 0x000F8400
		internal override string ToUserString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ToCompactString(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x000FA220 File Offset: 0x000F8420
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.m_edmType.Name);
		}

		// Token: 0x04001934 RID: 6452
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType m_edmType;
	}
}
