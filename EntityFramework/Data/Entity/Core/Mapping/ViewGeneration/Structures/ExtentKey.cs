using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005B7 RID: 1463
	internal class ExtentKey : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004729 RID: 18217 RVA: 0x000FA851 File Offset: 0x000F8A51
		internal ExtentKey(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> keyFields)
		{
			this.m_keyFields = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(keyFields);
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x000FA865 File Offset: 0x000F8A65
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> KeyFields
		{
			get
			{
				return this.m_keyFields;
			}
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x000FA870 File Offset: 0x000F8A70
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey> GetKeysForEntityType(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey primaryKeyForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(prefix, entityType);
			return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey>
			{
				primaryKeyForEntityType
			};
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x000FA894 File Offset: 0x000F8A94
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey GetPrimaryKeyForEntityType(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember last in entityType.KeyMembers)
			{
				list.Add(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(prefix, last));
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey(list);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x000FA8FC File Offset: 0x000F8AFC
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey GetKeyForRelationType(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix, global::System.Data.Entity.Core.Metadata.Edm.AssociationType relationType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in relationType.AssociationEndMembers)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(prefix, associationEndMember);
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityTypeForEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(associationEndMember);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey primaryKeyForEntityType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey.GetPrimaryKeyForEntityType(prefix2, entityTypeForEnd);
				list.AddRange(primaryKeyForEntityType.KeyFields);
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ExtentKey(list);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x000FA978 File Offset: 0x000F8B78
		internal string ToUserString()
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(this.m_keyFields);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x000FA985 File Offset: 0x000F8B85
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(builder, this.m_keyFields);
		}

		// Token: 0x0400193F RID: 6463
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> m_keyFields;
	}
}
