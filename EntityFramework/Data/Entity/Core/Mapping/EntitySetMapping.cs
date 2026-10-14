using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Diagnostics;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052D RID: 1325
	public class EntitySetMapping : global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping
	{
		// Token: 0x0600417B RID: 16763 RVA: 0x000DC7D8 File Offset: 0x000DA9D8
		public EntitySetMapping(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(containerMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			this._entitySet = entitySet;
			this._entityTypeMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			this._modificationFunctionMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>();
			this._implicitlyMappedAssociationSetEnds = new global::System.Lazy<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(new global::System.Func<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(this.InitializeImplicitlyMappedAssociationSetEnds));
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x000DC82C File Offset: 0x000DAA2C
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x000DC834 File Offset: 0x000DAA34
		internal override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Set
		{
			get
			{
				return this.EntitySet;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x000DC83C File Offset: 0x000DAA3C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> EntityTypeMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>(this._entityTypeMappings);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x000DC849 File Offset: 0x000DAA49
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> TypeMappings
		{
			get
			{
				return this._entityTypeMappings;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x000DC851 File Offset: 0x000DAA51
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> ModificationFunctionMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>(this._modificationFunctionMappings);
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x000DC85E File Offset: 0x000DAA5E
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> ImplicitlyMappedAssociationSetEnds
		{
			get
			{
				return this._implicitlyMappedAssociationSetEnds.Value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x000DC86B File Offset: 0x000DAA6B
		internal override bool HasNoContent
		{
			get
			{
				return this._modificationFunctionMappings.Count == 0 && base.HasNoContent;
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000DC882 File Offset: 0x000DAA82
		public void AddTypeMapping(global::System.Data.Entity.Core.Mapping.EntityTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._entityTypeMappings.Add(typeMapping);
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000DC8A2 File Offset: 0x000DAAA2
		public void RemoveTypeMapping(global::System.Data.Entity.Core.Mapping.EntityTypeMapping typeMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>(typeMapping, "typeMapping");
			base.ThrowIfReadOnly();
			this._entityTypeMappings.Remove(typeMapping);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000DC8C3 File Offset: 0x000DAAC3
		internal void ClearModificationFunctionMappings()
		{
			this._modificationFunctionMappings.Clear();
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x000DC8D0 File Offset: 0x000DAAD0
		public void AddModificationFunctionMapping(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>(modificationFunctionMapping, "modificationFunctionMapping");
			base.ThrowIfReadOnly();
			this._modificationFunctionMappings.Add(modificationFunctionMapping);
			if (this._implicitlyMappedAssociationSetEnds.IsValueCreated)
			{
				this._implicitlyMappedAssociationSetEnds = new global::System.Lazy<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(new global::System.Func<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(this.InitializeImplicitlyMappedAssociationSetEnds));
			}
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x000DC920 File Offset: 0x000DAB20
		public void RemoveModificationFunctionMapping(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>(modificationFunctionMapping, "modificationFunctionMapping");
			base.ThrowIfReadOnly();
			this._modificationFunctionMappings.Remove(modificationFunctionMapping);
			if (this._implicitlyMappedAssociationSetEnds.IsValueCreated)
			{
				this._implicitlyMappedAssociationSetEnds = new global::System.Lazy<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(new global::System.Func<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>>(this.InitializeImplicitlyMappedAssociationSetEnds));
			}
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000DC970 File Offset: 0x000DAB70
		internal override void SetReadOnly()
		{
			this._entityTypeMappings.TrimExcess();
			this._modificationFunctionMappings.TrimExcess();
			if (this._implicitlyMappedAssociationSetEnds.IsValueCreated)
			{
				this._implicitlyMappedAssociationSetEnds.Value.TrimExcess();
			}
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._entityTypeMappings);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._modificationFunctionMappings);
			base.SetReadOnly();
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000DC9CC File Offset: 0x000DABCC
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertModificationFunctionMappingInvariants(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in this._modificationFunctionMappings)
			{
			}
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000DCA18 File Offset: 0x000DAC18
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> InitializeImplicitlyMappedAssociationSetEnds()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>();
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in this._modificationFunctionMappings)
			{
				if (entityTypeModificationFunctionMapping.DeleteFunctionMapping != null)
				{
					list.AddRange(entityTypeModificationFunctionMapping.DeleteFunctionMapping.CollocatedAssociationSetEnds);
				}
				if (entityTypeModificationFunctionMapping.InsertFunctionMapping != null)
				{
					list.AddRange(entityTypeModificationFunctionMapping.InsertFunctionMapping.CollocatedAssociationSetEnds);
				}
				if (entityTypeModificationFunctionMapping.UpdateFunctionMapping != null)
				{
					list.AddRange(entityTypeModificationFunctionMapping.UpdateFunctionMapping.CollocatedAssociationSetEnds);
				}
			}
			if (base.IsReadOnly)
			{
				list.TrimExcess();
			}
			return list;
		}

		// Token: 0x040016B3 RID: 5811
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;

		// Token: 0x040016B4 RID: 5812
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> _entityTypeMappings;

		// Token: 0x040016B5 RID: 5813
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> _modificationFunctionMappings;

		// Token: 0x040016B6 RID: 5814
		private global::System.Lazy<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>> _implicitlyMappedAssociationSetEnds;
	}
}
