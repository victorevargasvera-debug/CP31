using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Mapping.ViewGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A4 RID: 932
	internal class ExplicitDiscriminatorMap
	{
		// Token: 0x06002D44 RID: 11588 RVA: 0x00090BF0 File Offset: 0x0008EDF0
		internal ExplicitDiscriminatorMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap template)
		{
			this.m_typeMap = template.TypeMap;
			this.m_discriminatorProperty = template.Discriminator.Property;
			this.m_properties = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>((from propertyValuePair in template.PropertyMap
			select propertyValuePair.Key).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x00090C5A File Offset: 0x0008EE5A
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> TypeMap
		{
			get
			{
				return this.m_typeMap;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00090C62 File Offset: 0x0008EE62
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember DiscriminatorProperty
		{
			get
			{
				return this.m_discriminatorProperty;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x00090C6A File Offset: 0x0008EE6A
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Properties
		{
			get
			{
				return this.m_properties;
			}
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00090C74 File Offset: 0x0008EE74
		internal object GetTypeId(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			object result = null;
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType> keyValuePair in this.TypeMap)
			{
				if (keyValuePair.Value.EdmEquals(entityType))
				{
					result = keyValuePair.Key;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000F25 RID: 3877
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> m_typeMap;

		// Token: 0x04000F26 RID: 3878
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_discriminatorProperty;

		// Token: 0x04000F27 RID: 3879
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> m_properties;
	}
}
