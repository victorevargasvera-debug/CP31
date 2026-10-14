using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C3 RID: 451
	internal class ConfigurationTypeFilter
	{
		// Token: 0x060017E5 RID: 6117 RVA: 0x0003FC0A File Offset: 0x0003DE0A
		public virtual bool IsEntityTypeConfiguration(global::System.Type type)
		{
			return global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeFilter.IsStructuralTypeConfiguration(type, typeof(global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<>));
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0003FC1C File Offset: 0x0003DE1C
		public virtual bool IsComplexTypeConfiguration(global::System.Type type)
		{
			return global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeFilter.IsStructuralTypeConfiguration(type, typeof(global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<>));
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0003FC2E File Offset: 0x0003DE2E
		private static bool IsStructuralTypeConfiguration(global::System.Type type, global::System.Type structuralTypeConfiguration)
		{
			return !type.IsAbstract() && type.TryGetElementType(structuralTypeConfiguration) != null;
		}
	}
}
