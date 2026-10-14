using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001DB RID: 475
	internal class ModificationStoredProceduresConfiguration
	{
		// Token: 0x060018DD RID: 6365 RVA: 0x00042437 File Offset: 0x00040637
		public ModificationStoredProceduresConfiguration()
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00042440 File Offset: 0x00040640
		private ModificationStoredProceduresConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration source)
		{
			if (source._insertModificationStoredProcedureConfiguration != null)
			{
				this._insertModificationStoredProcedureConfiguration = source._insertModificationStoredProcedureConfiguration.Clone();
			}
			if (source._updateModificationStoredProcedureConfiguration != null)
			{
				this._updateModificationStoredProcedureConfiguration = source._updateModificationStoredProcedureConfiguration.Clone();
			}
			if (source._deleteModificationStoredProcedureConfiguration != null)
			{
				this._deleteModificationStoredProcedureConfiguration = source._deleteModificationStoredProcedureConfiguration.Clone();
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0004249E File Offset: 0x0004069E
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration(this);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000424A6 File Offset: 0x000406A6
		public virtual void Insert(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration modificationStoredProcedureConfiguration)
		{
			this._insertModificationStoredProcedureConfiguration = modificationStoredProcedureConfiguration;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000424AF File Offset: 0x000406AF
		public virtual void Update(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration modificationStoredProcedureConfiguration)
		{
			this._updateModificationStoredProcedureConfiguration = modificationStoredProcedureConfiguration;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000424B8 File Offset: 0x000406B8
		public virtual void Delete(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration modificationStoredProcedureConfiguration)
		{
			this._deleteModificationStoredProcedureConfiguration = modificationStoredProcedureConfiguration;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x000424C1 File Offset: 0x000406C1
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration InsertModificationStoredProcedureConfiguration
		{
			get
			{
				return this._insertModificationStoredProcedureConfiguration;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x000424C9 File Offset: 0x000406C9
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration UpdateModificationStoredProcedureConfiguration
		{
			get
			{
				return this._updateModificationStoredProcedureConfiguration;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x000424D1 File Offset: 0x000406D1
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration DeleteModificationStoredProcedureConfiguration
		{
			get
			{
				return this._deleteModificationStoredProcedureConfiguration;
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000424DC File Offset: 0x000406DC
		public virtual void Configure(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationStoredProcedureMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this._insertModificationStoredProcedureConfiguration != null)
			{
				this._insertModificationStoredProcedureConfiguration.Configure(modificationStoredProcedureMapping.InsertFunctionMapping, providerManifest);
			}
			if (this._updateModificationStoredProcedureConfiguration != null)
			{
				this._updateModificationStoredProcedureConfiguration.Configure(modificationStoredProcedureMapping.UpdateFunctionMapping, providerManifest);
			}
			if (this._deleteModificationStoredProcedureConfiguration != null)
			{
				this._deleteModificationStoredProcedureConfiguration.Configure(modificationStoredProcedureMapping.DeleteFunctionMapping, providerManifest);
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00042537 File Offset: 0x00040737
		public void Configure(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationStoredProcedureMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this._insertModificationStoredProcedureConfiguration != null)
			{
				this._insertModificationStoredProcedureConfiguration.Configure(modificationStoredProcedureMapping.InsertFunctionMapping, providerManifest);
			}
			if (this._deleteModificationStoredProcedureConfiguration != null)
			{
				this._deleteModificationStoredProcedureConfiguration.Configure(modificationStoredProcedureMapping.DeleteFunctionMapping, providerManifest);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00042570 File Offset: 0x00040770
		public bool IsCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration other)
		{
			return (this._insertModificationStoredProcedureConfiguration == null || other._insertModificationStoredProcedureConfiguration == null || this._insertModificationStoredProcedureConfiguration.IsCompatibleWith(other._insertModificationStoredProcedureConfiguration)) && (this._deleteModificationStoredProcedureConfiguration == null || other._deleteModificationStoredProcedureConfiguration == null || this._deleteModificationStoredProcedureConfiguration.IsCompatibleWith(other._deleteModificationStoredProcedureConfiguration));
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000425C8 File Offset: 0x000407C8
		public void Merge(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration modificationStoredProceduresConfiguration, bool allowOverride)
		{
			if (this._insertModificationStoredProcedureConfiguration == null)
			{
				this._insertModificationStoredProcedureConfiguration = modificationStoredProceduresConfiguration.InsertModificationStoredProcedureConfiguration;
			}
			else if (modificationStoredProceduresConfiguration.InsertModificationStoredProcedureConfiguration != null)
			{
				this._insertModificationStoredProcedureConfiguration.Merge(modificationStoredProceduresConfiguration.InsertModificationStoredProcedureConfiguration, allowOverride);
			}
			if (this._updateModificationStoredProcedureConfiguration == null)
			{
				this._updateModificationStoredProcedureConfiguration = modificationStoredProceduresConfiguration.UpdateModificationStoredProcedureConfiguration;
			}
			else if (modificationStoredProceduresConfiguration.UpdateModificationStoredProcedureConfiguration != null)
			{
				this._updateModificationStoredProcedureConfiguration.Merge(modificationStoredProceduresConfiguration.UpdateModificationStoredProcedureConfiguration, allowOverride);
			}
			if (this._deleteModificationStoredProcedureConfiguration == null)
			{
				this._deleteModificationStoredProcedureConfiguration = modificationStoredProceduresConfiguration.DeleteModificationStoredProcedureConfiguration;
				return;
			}
			if (modificationStoredProceduresConfiguration.DeleteModificationStoredProcedureConfiguration != null)
			{
				this._deleteModificationStoredProcedureConfiguration.Merge(modificationStoredProceduresConfiguration.DeleteModificationStoredProcedureConfiguration, allowOverride);
			}
		}

		// Token: 0x04000A70 RID: 2672
		private global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration _insertModificationStoredProcedureConfiguration;

		// Token: 0x04000A71 RID: 2673
		private global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration _updateModificationStoredProcedureConfiguration;

		// Token: 0x04000A72 RID: 2674
		private global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration _deleteModificationStoredProcedureConfiguration;
	}
}
