using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C7 RID: 455
	internal class ConventionsTypeFilter
	{
		// Token: 0x0600180F RID: 6159 RVA: 0x00040815 File Offset: 0x0003EA15
		public virtual bool IsConvention(global::System.Type conventionType)
		{
			return global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConfigurationConvention(conventionType) || global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualModelConvention(conventionType) || global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsConceptualToStoreMappingConvention(conventionType) || global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter.IsStoreModelConvention(conventionType);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00040838 File Offset: 0x0003EA38
		public static bool IsConfigurationConvention(global::System.Type conventionType)
		{
			return typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention).IsAssignableFrom(conventionType) || typeof(global::System.Data.Entity.ModelConfiguration.Conventions.Convention).IsAssignableFrom(conventionType) || conventionType.GetGenericTypeImplementations(typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<>)).Any<global::System.Type>() || conventionType.GetGenericTypeImplementations(typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<, >)).Any<global::System.Type>();
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00040897 File Offset: 0x0003EA97
		public static bool IsConceptualModelConvention(global::System.Type conventionType)
		{
			return conventionType.GetGenericTypeImplementations(typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<>)).Any<global::System.Type>();
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000408AE File Offset: 0x0003EAAE
		public static bool IsStoreModelConvention(global::System.Type conventionType)
		{
			return conventionType.GetGenericTypeImplementations(typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<>)).Any<global::System.Type>();
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000408C5 File Offset: 0x0003EAC5
		public static bool IsConceptualToStoreMappingConvention(global::System.Type conventionType)
		{
			return typeof(global::System.Data.Entity.ModelConfiguration.Conventions.IDbMappingConvention).IsAssignableFrom(conventionType);
		}
	}
}
