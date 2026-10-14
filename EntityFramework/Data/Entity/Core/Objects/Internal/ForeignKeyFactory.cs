using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000445 RID: 1093
	internal class ForeignKeyFactory
	{
		// Token: 0x06003564 RID: 13668 RVA: 0x000AAD35 File Offset: 0x000A8F35
		public static bool IsConceptualNullKey(global::System.Data.Entity.Core.EntityKey key)
		{
			return !(key == null) && string.Equals(key.EntityContainerName, "EntityHasNullForeignKey") && string.Equals(key.EntitySetName, "EntityHasNullForeignKey");
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000AAD66 File Offset: 0x000A8F66
		public static bool IsConceptualNullKeyChanged(global::System.Data.Entity.Core.EntityKey conceptualNullKey, global::System.Data.Entity.Core.EntityKey realKey)
		{
			return realKey == null || !global::System.Data.Entity.Core.EntityKey.InternalEquals(conceptualNullKey, realKey, false);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000AAD7E File Offset: 0x000A8F7E
		public static global::System.Data.Entity.Core.EntityKey CreateConceptualNullKey(global::System.Data.Entity.Core.EntityKey originalKey)
		{
			return new global::System.Data.Entity.Core.EntityKey("EntityHasNullForeignKey.EntityHasNullForeignKey", originalKey.EntityKeyValues);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000AAD90 File Offset: 0x000A8F90
		public static global::System.Data.Entity.Core.EntityKey CreateKeyFromForeignKeyValues(global::System.Data.Entity.Core.Objects.EntityEntry dependentEntry, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)relatedEnd.RelationMetadata).ReferentialConstraints.First<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
			return global::System.Data.Entity.Core.Objects.Internal.ForeignKeyFactory.CreateKeyFromForeignKeyValues(dependentEntry, constraint, relatedEnd.GetTargetEntitySetFromRelationshipSet(), false);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x000AADC4 File Offset: 0x000A8FC4
		public static global::System.Data.Entity.Core.EntityKey CreateKeyFromForeignKeyValues(global::System.Data.Entity.Core.Objects.EntityEntry dependentEntry, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint, global::System.Data.Entity.Core.Metadata.Edm.EntitySet principalEntitySet, bool useOriginalValues)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties = constraint.ToProperties;
			int count = toProperties.Count;
			if (count != 1)
			{
				string[] keyMemberNames = principalEntitySet.ElementType.KeyMemberNames;
				object[] array = new object[count];
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fromProperties = constraint.FromProperties;
				for (int i = 0; i < count; i++)
				{
					object obj = useOriginalValues ? dependentEntry.GetOriginalEntityValue(toProperties[i].Name) : dependentEntry.GetCurrentEntityValue(toProperties[i].Name);
					if (obj == global::System.DBNull.Value)
					{
						return null;
					}
					int num = global::System.Array.IndexOf<string>(keyMemberNames, fromProperties[i].Name);
					array[num] = obj;
				}
				return new global::System.Data.Entity.Core.EntityKey(principalEntitySet, array);
			}
			object obj2 = useOriginalValues ? dependentEntry.GetOriginalEntityValue(toProperties.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Name) : dependentEntry.GetCurrentEntityValue(toProperties.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Name);
			if (obj2 != global::System.DBNull.Value)
			{
				return new global::System.Data.Entity.Core.EntityKey(principalEntitySet, obj2);
			}
			return null;
		}

		// Token: 0x04001143 RID: 4419
		private const string s_NullPart = "EntityHasNullForeignKey";

		// Token: 0x04001144 RID: 4420
		private const string s_NullForeignKey = "EntityHasNullForeignKey.EntityHasNullForeignKey";
	}
}
