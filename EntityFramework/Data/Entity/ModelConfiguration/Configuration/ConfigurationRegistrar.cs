using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C1 RID: 449
	public class ConfigurationRegistrar
	{
		// Token: 0x060017DA RID: 6106 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		internal ConfigurationRegistrar(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._modelConfiguration = modelConfiguration;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0003FAE7 File Offset: 0x0003DCE7
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar AddFromAssembly(global::System.Reflection.Assembly assembly)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(assembly, "assembly");
			new global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypesFinder().AddConfigurationTypesToModel(assembly.GetAccessibleTypes(), this._modelConfiguration);
			return this;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0003FB0C File Offset: 0x0003DD0C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar Add<TEntityType>(global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> entityTypeConfiguration) where TEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType>>(entityTypeConfiguration, "entityTypeConfiguration");
			this._modelConfiguration.Add((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)entityTypeConfiguration.Configuration);
			return this;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0003FB31 File Offset: 0x0003DD31
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationRegistrar Add<TComplexType>(global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<TComplexType> complexTypeConfiguration) where TComplexType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<TComplexType>>(complexTypeConfiguration, "complexTypeConfiguration");
			this._modelConfiguration.Add((global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration)complexTypeConfiguration.Configuration);
			return this;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0003FB56 File Offset: 0x0003DD56
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Type> GetConfiguredTypes()
		{
			return this._modelConfiguration.ConfiguredTypes.ToList<global::System.Type>();
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0003FB68 File Offset: 0x0003DD68
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0003FB70 File Offset: 0x0003DD70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0003FB79 File Offset: 0x0003DD79
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0003FB81 File Offset: 0x0003DD81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A47 RID: 2631
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;
	}
}
