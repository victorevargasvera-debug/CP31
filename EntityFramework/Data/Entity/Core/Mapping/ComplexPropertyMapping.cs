using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000523 RID: 1315
	public class ComplexPropertyMapping : global::System.Data.Entity.Core.Mapping.PropertyMapping
	{
		// Token: 0x060040E9 RID: 16617 RVA: 0x000DA6DE File Offset: 0x000D88DE
		public ComplexPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property) : base(property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(property, "property");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(property.TypeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.StorageComplexPropertyMapping_OnlyComplexPropertyAllowed, "property");
			}
			this._typeMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>();
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x000DA71B File Offset: 0x000D891B
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping> TypeMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>(this._typeMappings);
			}
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x000DA728 File Offset: 0x000D8928
		public void AddTypeMapping(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._typeMappings.Add(typeMapping);
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x000DA748 File Offset: 0x000D8948
		public void RemoveTypeMapping(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._typeMappings.Remove(typeMapping);
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x000DA769 File Offset: 0x000D8969
		internal override void SetReadOnly()
		{
			this._typeMappings.TrimExcess();
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._typeMappings);
			base.SetReadOnly();
		}

		// Token: 0x04001686 RID: 5766
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping> _typeMappings;
	}
}
