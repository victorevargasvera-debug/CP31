using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000595 RID: 1429
	internal sealed class RoleBoolean : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TrueFalseLiteral
	{
		// Token: 0x0600451F RID: 17695 RVA: 0x000F3674 File Offset: 0x000F1874
		internal RoleBoolean(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			this.m_metadataItem = extent;
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x000F3683 File Offset: 0x000F1883
		internal RoleBoolean(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd end)
		{
			this.m_metadataItem = end;
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x000F3692 File Offset: 0x000F1892
		internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			return null;
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x000F3695 File Offset: 0x000F1895
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, bool skipIsNotNull)
		{
			return null;
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x000F3698 File Offset: 0x000F1898
		internal override global::System.Text.StringBuilder AsUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.m_metadataItem as global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd;
			if (associationSetEnd != null)
			{
				builder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_AssociationSet_AsUserString(blockAlias, associationSetEnd.Name, associationSetEnd.ParentAssociationSet));
			}
			else
			{
				builder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_EntitySet_AsUserString(blockAlias, this.m_metadataItem.ToString()));
			}
			return builder;
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x000F36E8 File Offset: 0x000F18E8
		internal override global::System.Text.StringBuilder AsNegatedUserString(global::System.Text.StringBuilder builder, string blockAlias, bool skipIsNotNull)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.m_metadataItem as global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd;
			if (associationSetEnd != null)
			{
				builder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_AssociationSet_AsUserString_Negated(blockAlias, associationSetEnd.Name, associationSetEnd.ParentAssociationSet));
			}
			else
			{
				builder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_EntitySet_AsUserString_Negated(blockAlias, this.m_metadataItem.ToString()));
			}
			return builder;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x000F3738 File Offset: 0x000F1938
		internal override void GetRequiredSlots(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, bool[] requiredSlots)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x000F3740 File Offset: 0x000F1940
		protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral right)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean roleBoolean = right as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean;
			return roleBoolean != null && this.m_metadataItem == roleBoolean.m_metadataItem;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x000F3767 File Offset: 0x000F1967
		public override int GetHashCode()
		{
			return this.m_metadataItem.GetHashCode();
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x000F3774 File Offset: 0x000F1974
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral RemapBool(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap)
		{
			return this;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x000F3778 File Offset: 0x000F1978
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = this.m_metadataItem as global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd;
			if (associationSetEnd != null)
			{
				string str = "InEnd:";
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = associationSetEnd.ParentAssociationSet;
				builder.Append(str + ((parentAssociationSet != null) ? parentAssociationSet.ToString() : null) + "_" + associationSetEnd.Name);
				return;
			}
			string str2 = "InSet:";
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem metadataItem = this.m_metadataItem;
			builder.Append(str2 + ((metadataItem != null) ? metadataItem.ToString() : null));
		}

		// Token: 0x040018DB RID: 6363
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataItem m_metadataItem;
	}
}
