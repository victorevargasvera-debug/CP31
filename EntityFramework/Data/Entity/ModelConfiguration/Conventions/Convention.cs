using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Conventions.Sets;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019D RID: 413
	public class Convention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x0003D168 File Offset: 0x0003B368
		public Convention()
		{
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0003D180 File Offset: 0x0003B380
		internal Convention(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration)
		{
			this._conventionsConfiguration = conventionsConfiguration;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0003D19F File Offset: 0x0003B39F
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration Types()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration(this._conventionsConfiguration);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0003D1AC File Offset: 0x0003B3AC
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T> Types<T>() where T : class
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T>(this._conventionsConfiguration);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0003D1B9 File Offset: 0x0003B3B9
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration Properties()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration(this._conventionsConfiguration);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
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

		// Token: 0x06001751 RID: 5969 RVA: 0x0003D225 File Offset: 0x0003B425
		internal virtual void ApplyModelConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._conventionsConfiguration.ApplyModelConfiguration(modelConfiguration);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0003D233 File Offset: 0x0003B433
		internal virtual void ApplyModelConfiguration(global::System.Type type, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._conventionsConfiguration.ApplyModelConfiguration(type, modelConfiguration);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0003D242 File Offset: 0x0003B442
		internal virtual void ApplyTypeConfiguration<TStructuralTypeConfiguration>(global::System.Type type, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			this._conventionsConfiguration.ApplyTypeConfiguration<TStructuralTypeConfiguration>(type, structuralTypeConfiguration, modelConfiguration);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0003D252 File Offset: 0x0003B452
		internal virtual void ApplyPropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._conventionsConfiguration.ApplyPropertyConfiguration(propertyInfo, modelConfiguration);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0003D261 File Offset: 0x0003B461
		internal virtual void ApplyPropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration> propertyConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._conventionsConfiguration.ApplyPropertyConfiguration(propertyInfo, propertyConfiguration, modelConfiguration);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0003D271 File Offset: 0x0003B471
		internal virtual void ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			this._conventionsConfiguration.ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(propertyInfo, structuralTypeConfiguration, modelConfiguration);
		}

		// Token: 0x04000A31 RID: 2609
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration(new global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet());
	}
}
