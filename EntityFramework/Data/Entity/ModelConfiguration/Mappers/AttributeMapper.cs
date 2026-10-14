using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x02000158 RID: 344
	internal sealed class AttributeMapper
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00037DF7 File Offset: 0x00035FF7
		public AttributeMapper(global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider)
		{
			this._attributeProvider = attributeProvider;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00037E06 File Offset: 0x00036006
		public void Map(global::System.Reflection.PropertyInfo propertyInfo, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> annotations)
		{
			annotations.SetClrAttributes(this._attributeProvider.GetAttributes(propertyInfo).ToList<global::System.Attribute>());
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00037E1F File Offset: 0x0003601F
		public void Map(global::System.Type type, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> annotations)
		{
			annotations.SetClrAttributes(this._attributeProvider.GetAttributes(type).ToList<global::System.Attribute>());
		}

		// Token: 0x040009F5 RID: 2549
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider;
	}
}
