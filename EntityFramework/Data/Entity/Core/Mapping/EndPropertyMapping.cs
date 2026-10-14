using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000528 RID: 1320
	public class EndPropertyMapping : global::System.Data.Entity.Core.Mapping.PropertyMapping
	{
		// Token: 0x0600412A RID: 16682 RVA: 0x000DBED2 File Offset: 0x000DA0D2
		public EndPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEnd)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(associationEnd, "associationEnd");
			this._associationEnd = associationEnd;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x000DBEF8 File Offset: 0x000DA0F8
		internal EndPropertyMapping()
		{
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x000DBF0B File Offset: 0x000DA10B
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x000DBF13 File Offset: 0x000DA113
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember AssociationEnd
		{
			get
			{
				return this._associationEnd;
			}
			internal set
			{
				this._associationEnd = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x000DBF1C File Offset: 0x000DA11C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> PropertyMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>(this._properties);
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x000DBF29 File Offset: 0x000DA129
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> StoreProperties
		{
			get
			{
				return from propertyMap in this.PropertyMappings
				select propertyMap.Column;
			}
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x000DBF55 File Offset: 0x000DA155
		public void AddPropertyMapping(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this._properties.Add(propertyMapping);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x000DBF75 File Offset: 0x000DA175
		public void RemovePropertyMapping(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this._properties.Remove(propertyMapping);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000DBF96 File Offset: 0x000DA196
		internal override void SetReadOnly()
		{
			this._properties.TrimExcess();
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._properties);
			base.SetReadOnly();
		}

		// Token: 0x04001697 RID: 5783
		private global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember _associationEnd;

		// Token: 0x04001698 RID: 5784
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> _properties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>();
	}
}
