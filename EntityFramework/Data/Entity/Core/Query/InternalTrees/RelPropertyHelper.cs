using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D6 RID: 982
	internal sealed class RelPropertyHelper
	{
		// Token: 0x06002EC6 RID: 11974 RVA: 0x00093FD8 File Offset: 0x000921D8
		private void AddRelProperty(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember toEnd)
		{
			if (toEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				return;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.RelProperty item = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(associationType, fromEnd, toEnd);
			if (this._interestingRelProperties == null || !this._interestingRelProperties.Contains(item))
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)fromEnd.TypeUsage.EdmType).ElementType;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list;
			if (!this._relPropertyMap.TryGetValue(elementType, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
				this._relPropertyMap[elementType] = list;
			}
			list.Add(item);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00094050 File Offset: 0x00092250
		private void ProcessRelationship(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = relationshipType as global::System.Data.Entity.Core.Metadata.Edm.AssociationType;
			if (associationType == null)
			{
				return;
			}
			if (associationType.AssociationEndMembers.Count != 2)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = associationType.AssociationEndMembers[0];
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = associationType.AssociationEndMembers[1];
			this.AddRelProperty(associationType, associationEndMember, associationEndMember2);
			this.AddRelProperty(associationType, associationEndMember2, associationEndMember);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x000940A4 File Offset: 0x000922A4
		internal RelPropertyHelper(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace ws, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> interestingRelProperties)
		{
			this._relPropertyMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>>();
			this._interestingRelProperties = interestingRelProperties;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType in ws.GetItems<global::System.Data.Entity.Core.Metadata.Edm.RelationshipType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace))
			{
				this.ProcessRelationship(relationshipType);
			}
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x0009410C File Offset: 0x0009230C
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> GetDeclaredOnlyRelProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list;
			if (this._relPropertyMap.TryGetValue(entityType, out list))
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in list)
				{
					yield return relProperty;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>.Enumerator);
			}
			yield break;
			yield break;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00094123 File Offset: 0x00092323
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> GetRelProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> enumerator;
			if (entityType.BaseType != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in this.GetRelProperties(entityType.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase))
				{
					yield return relProperty;
				}
				enumerator = null;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty2 in this.GetDeclaredOnlyRelProperties(entityType))
			{
				yield return relProperty2;
			}
			enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x04000FC6 RID: 4038
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>> _relPropertyMap;

		// Token: 0x04000FC7 RID: 4039
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> _interestingRelProperties;
	}
}
