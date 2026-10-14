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
	// Token: 0x020005B6 RID: 1462
	internal sealed class WithRelationship : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004724 RID: 18212 RVA: 0x000FA65C File Offset: 0x000F885C
		internal WithRelationship(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromEndEntityType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember toEnd, global::System.Data.Entity.Core.Metadata.Edm.EntityType toEndEntityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> toEndEntityKeyMemberPaths)
		{
			this.m_associationSet = associationSet;
			this.m_fromEnd = fromEnd;
			this.m_fromEndEntityType = fromEndEntityType;
			this.m_toEnd = toEnd;
			this.m_toEndEntityType = toEndEntityType;
			this.m_toEndEntitySet = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(associationSet, toEnd);
			this.m_toEndEntityKeyMemberPaths = toEndEntityKeyMemberPaths;
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x000FA6AA File Offset: 0x000F88AA
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityType FromEndEntityType
		{
			get
			{
				return this.m_fromEndEntityType;
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x000FA6B4 File Offset: 0x000F88B4
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, int indentLevel)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.IndentNewLine(builder, indentLevel + 1);
			builder.Append("RELATIONSHIP(");
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			builder.Append("CREATEREF(");
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedQualifiedName(builder, this.m_toEndEntitySet.EntityContainer.Name, this.m_toEndEntitySet.Name);
			builder.Append(", ROW(");
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in this.m_toEndEntityKeyMemberPaths)
			{
				string qualifiedName = global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.GetQualifiedName(blockAlias, memberPath.CqlFieldAlias);
				list.Add(qualifiedName);
			}
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToSeparatedString(builder, list, ", ", null);
			builder.Append(')');
			builder.Append(",");
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, this.m_toEndEntityType);
			builder.Append(')');
			builder.Append(',');
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, this.m_associationSet.ElementType);
			builder.Append(',');
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, this.m_fromEnd.Name);
			builder.Append(',');
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, this.m_toEnd.Name);
			builder.Append(')');
			builder.Append(' ');
			return builder;
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x000FA7FC File Offset: 0x000F89FC
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRelatedEntityRef(this.m_fromEnd, this.m_toEnd, this.m_toEndEntitySet.CreateRef(this.m_toEndEntityType, from keyMember in this.m_toEndEntityKeyMemberPaths
			select row.Property(keyMember.CqlFieldAlias)));
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x000FA84F File Offset: 0x000F8A4F
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
		}

		// Token: 0x04001938 RID: 6456
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet m_associationSet;

		// Token: 0x04001939 RID: 6457
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember m_fromEnd;

		// Token: 0x0400193A RID: 6458
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType m_fromEndEntityType;

		// Token: 0x0400193B RID: 6459
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember m_toEnd;

		// Token: 0x0400193C RID: 6460
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType m_toEndEntityType;

		// Token: 0x0400193D RID: 6461
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_toEndEntitySet;

		// Token: 0x0400193E RID: 6462
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_toEndEntityKeyMemberPaths;
	}
}
