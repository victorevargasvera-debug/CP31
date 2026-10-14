using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Conventions.Sets;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Mappers;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity
{
	// Token: 0x0200005F RID: 95
	public class DbModelBuilder
	{
		// Token: 0x0600030C RID: 780 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public DbModelBuilder() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration(), global::System.Data.Entity.DbModelBuilderVersion.Latest)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000A502 File Offset: 0x00008702
		public DbModelBuilder(global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion) : this(new global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration(), modelBuilderVersion)
		{
			if (!global::System.Enum.IsDefined(typeof(global::System.Data.Entity.DbModelBuilderVersion), modelBuilderVersion))
			{
				throw new global::System.ArgumentOutOfRangeException("modelBuilderVersion");
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000A532 File Offset: 0x00008732
		internal DbModelBuilder(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion = global::System.Data.Entity.DbModelBuilderVersion.Latest) : this(modelConfiguration, new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration(global::System.Data.Entity.DbModelBuilder.SelectConventionSet(modelBuilderVersion)), modelBuilderVersion)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000A547 File Offset: 0x00008747
		private static global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet SelectConventionSet(global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion)
		{
			switch (modelBuilderVersion)
			{
			case global::System.Data.Entity.DbModelBuilderVersion.Latest:
			case global::System.Data.Entity.DbModelBuilderVersion.V5_0_Net4:
			case global::System.Data.Entity.DbModelBuilderVersion.V5_0:
			case global::System.Data.Entity.DbModelBuilderVersion.V6_0:
				return global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V2ConventionSet.Conventions;
			case global::System.Data.Entity.DbModelBuilderVersion.V4_1:
				return global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet.Conventions;
			default:
				throw new global::System.ArgumentOutOfRangeException("modelBuilderVersion");
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000A57C File Offset: 0x0000877C
		private DbModelBuilder(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion = global::System.Data.Entity.DbModelBuilderVersion.Latest)
		{
			this._lock = new object();
			base..ctor();
			if (!global::System.Enum.IsDefined(typeof(global::System.Data.Entity.DbModelBuilderVersion), modelBuilderVersion))
			{
				throw new global::System.ArgumentOutOfRangeException("modelBuilderVersion");
			}
			this._modelConfiguration = modelConfiguration;
			this._conventionsConfiguration = conventionsConfiguration;
			this._modelBuilderVersion = modelBuilderVersion;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000A5D4 File Offset: 0x000087D4
		private DbModelBuilder(global::System.Data.Entity.DbModelBuilder source)
		{
			this._lock = new object();
			base..ctor();
			this._modelConfiguration = source._modelConfiguration.Clone();
			this._conventionsConfiguration = source._conventionsConfiguration.Clone();
			this._modelBuilderVersion = source._modelBuilderVersion;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000A620 File Offset: 0x00008820
		internal virtual global::System.Data.Entity.DbModelBuilder Clone()
		{
			object @lock = this._lock;
			global::System.Data.Entity.DbModelBuilder result;
			lock (@lock)
			{
				result = new global::System.Data.Entity.DbModelBuilder(this);
			}
			return result;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000A664 File Offset: 0x00008864
		internal global::System.Data.Entity.Infrastructure.DbModel BuildDynamicUpdateModel(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			global::System.Data.Entity.Infrastructure.DbModel dbModel = this.Build(providerInfo);
			global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping = dbModel.DatabaseMapping.EntityContainerMappings.Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>();
			entityContainerMapping.EntitySetMappings.Each(delegate(global::System.Data.Entity.Core.Mapping.EntitySetMapping esm)
			{
				esm.ClearModificationFunctionMappings();
			});
			entityContainerMapping.AssociationSetMappings.Each((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => asm.ModificationFunctionMapping = null);
			return dbModel;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000A6DB File Offset: 0x000088DB
		public virtual global::System.Data.Entity.DbModelBuilder Ignore<T>() where T : class
		{
			this._modelConfiguration.Ignore(typeof(T));
			return this;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000A6F3 File Offset: 0x000088F3
		public virtual global::System.Data.Entity.DbModelBuilder HasDefaultSchema(string schema)
		{
			this._modelConfiguration.DefaultSchema = schema;
			return this;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000A704 File Offset: 0x00008904
		public virtual global::System.Data.Entity.DbModelBuilder Ignore(global::System.Collections.Generic.IEnumerable<global::System.Type> types)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Type>>(types, "types");
			foreach (global::System.Type type in types)
			{
				this._modelConfiguration.Ignore(type);
			}
			return this;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000A760 File Offset: 0x00008960
		public virtual global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> Entity<TEntityType>() where TEntityType : class
		{
			return new global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType>(this._modelConfiguration.Entity(typeof(TEntityType), true));
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000A77D File Offset: 0x0000897D
		public virtual void RegisterEntityType(global::System.Type entityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(entityType, "entityType");
			this.Entity(entityType);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000A793 File Offset: 0x00008993
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration Entity(global::System.Type entityType)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = this._modelConfiguration.Entity(entityType);
			entityTypeConfiguration.IsReplaceable = true;
			return entityTypeConfiguration;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000A7A8 File Offset: 0x000089A8
		public virtual global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<TComplexType> ComplexType<TComplexType>() where TComplexType : class
		{
			return new global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<TComplexType>(this._modelConfiguration.ComplexType(typeof(TComplexType)));
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000A7C4 File Offset: 0x000089C4
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration Types()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration(this._conventionsConfiguration);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000A7D1 File Offset: 0x000089D1
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T> Types<T>() where T : class
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T>(this._conventionsConfiguration);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000A7DE File Offset: 0x000089DE
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration Properties()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration(this._conventionsConfiguration);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000A7EC File Offset: 0x000089EC
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration Properties<T>()
		{
			if (!typeof(T).IsValidEdmScalarType())
			{
				throw global::System.Data.Entity.Resources.Error.ModelBuilder_PropertyFilterTypeMustBePrimitive(typeof(T));
			}
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration(this._conventionsConfiguration).Where(delegate(global::System.Reflection.PropertyInfo p)
			{
				global::System.Type left;
				p.PropertyType.TryUnwrapNullableType(out left);
				return left == typeof(T);
			});
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000A849 File Offset: 0x00008A49
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration Conventions
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000A851 File Offset: 0x00008A51
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar Configurations
		{
			get
			{
				return new global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar(this._modelConfiguration);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A860 File Offset: 0x00008A60
		public virtual global::System.Data.Entity.Infrastructure.DbModel Build(global::System.Data.Common.DbConnection providerConnection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(providerConnection, "providerConnection");
			global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest;
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo = providerConnection.GetProviderInfo(out providerManifest);
			return this.Build(providerManifest, providerInfo);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A88C File Offset: 0x00008A8C
		public virtual global::System.Data.Entity.Infrastructure.DbModel Build(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbProviderInfo>(providerInfo, "providerInfo");
			global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest = global::System.Data.Entity.DbModelBuilder.GetProviderManifest(providerInfo);
			return this.Build(providerManifest, providerInfo);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		internal global::System.Data.Entity.DbModelBuilderVersion Version
		{
			get
			{
				return this._modelBuilderVersion;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000A8BC File Offset: 0x00008ABC
		private global::System.Data.Entity.Infrastructure.DbModel Build(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			double edmVersion = this._modelBuilderVersion.GetEdmVersion();
			global::System.Data.Entity.DbModelBuilder modelBuilder = this.Clone();
			global::System.Data.Entity.Infrastructure.DbModel dbModel = new global::System.Data.Entity.Infrastructure.DbModel(new global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping
			{
				Model = global::System.Data.Entity.Core.Metadata.Edm.EdmModel.CreateConceptualModel(edmVersion),
				Database = global::System.Data.Entity.Core.Metadata.Edm.EdmModel.CreateStoreModel(providerInfo, providerManifest, edmVersion)
			}, modelBuilder);
			dbModel.ConceptualModel.Container.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:UseClrTypes", "true");
			this._conventionsConfiguration.ApplyModelConfiguration(this._modelConfiguration);
			this._modelConfiguration.NormalizeConfigurations();
			this.MapTypes(dbModel.ConceptualModel);
			this._modelConfiguration.Configure(dbModel.ConceptualModel);
			this._conventionsConfiguration.ApplyConceptualModel(dbModel);
			dbModel.ConceptualModel.Validate();
			dbModel = new global::System.Data.Entity.Infrastructure.DbModel(dbModel.ConceptualModel.GenerateDatabaseMapping(providerInfo, providerManifest), modelBuilder);
			this._conventionsConfiguration.ApplyPluralizingTableNameConvention(dbModel);
			this._modelConfiguration.Configure(dbModel.DatabaseMapping, providerManifest);
			this._conventionsConfiguration.ApplyStoreModel(dbModel);
			this._conventionsConfiguration.ApplyMapping(dbModel.DatabaseMapping);
			dbModel.StoreModel.Validate();
			return dbModel;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A9C7 File Offset: 0x00008BC7
		private static global::System.Data.Entity.Core.Common.DbProviderManifest GetProviderManifest(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(providerInfo.ProviderInvariantName).GetProviderServices().GetProviderManifest(providerInfo.ProviderManifestToken);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A9EC File Offset: 0x00008BEC
		private void MapTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper typeMapper = new global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper(new global::System.Data.Entity.ModelConfiguration.Mappers.MappingContext(this._modelConfiguration, this._conventionsConfiguration, model, this._modelBuilderVersion, global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>()));
			global::System.Collections.Generic.IList<global::System.Type> list = (this._modelConfiguration.Entities as global::System.Collections.Generic.IList<global::System.Type>) ?? this._modelConfiguration.Entities.ToList<global::System.Type>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Type type = list[i];
				if (typeMapper.MapEntityType(type) == null)
				{
					throw global::System.Data.Entity.Resources.Error.InvalidEntityType(type);
				}
			}
			global::System.Collections.Generic.IList<global::System.Type> list2 = (this._modelConfiguration.ComplexTypes as global::System.Collections.Generic.IList<global::System.Type>) ?? this._modelConfiguration.ComplexTypes.ToList<global::System.Type>();
			for (int j = 0; j < list2.Count; j++)
			{
				global::System.Type type2 = list2[j];
				if (typeMapper.MapComplexType(type2, false) == null)
				{
					throw global::System.Data.Entity.Resources.Error.CodeFirstInvalidComplexType(type2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000AAC9 File Offset: 0x00008CC9
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration ModelConfiguration
		{
			get
			{
				return this._modelConfiguration;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000AAD1 File Offset: 0x00008CD1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000AAD9 File Offset: 0x00008CD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000AAE2 File Offset: 0x00008CE2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000AAEA File Offset: 0x00008CEA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040000B8 RID: 184
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;

		// Token: 0x040000B9 RID: 185
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x040000BA RID: 186
		private readonly global::System.Data.Entity.DbModelBuilderVersion _modelBuilderVersion;

		// Token: 0x040000BB RID: 187
		private readonly object _lock;
	}
}
