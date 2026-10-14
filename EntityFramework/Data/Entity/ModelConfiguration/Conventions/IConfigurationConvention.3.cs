using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200017E RID: 382
	internal interface IConfigurationConvention<TMemberInfo, TConfiguration> : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention where TMemberInfo : global::System.Reflection.MemberInfo where TConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationBase
	{
		// Token: 0x060016ED RID: 5869
		void Apply(TMemberInfo memberInfo, global::System.Func<TConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);
	}
}
