using System;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C2 RID: 450
	internal class ConfigurationTypeActivator
	{
		// Token: 0x060017E3 RID: 6115 RVA: 0x0003FB8C File Offset: 0x0003DD8C
		public virtual TStructuralTypeConfiguration Activate<TStructuralTypeConfiguration>(global::System.Type type) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			if (type.GetDeclaredConstructor(new global::System.Type[0]) == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CreateConfigurationType_NoParameterlessConstructor(type.Name));
			}
			return (TStructuralTypeConfiguration)((object)typeof(global::System.Data.Entity.ModelConfiguration.Configuration.StructuralTypeConfiguration<>).MakeGenericType(new global::System.Type[]
			{
				type.TryGetElementType(typeof(global::System.Data.Entity.ModelConfiguration.Configuration.StructuralTypeConfiguration<>))
			}).GetDeclaredProperty("Configuration").GetValue(global::System.Activator.CreateInstance(type, true), null));
		}
	}
}
