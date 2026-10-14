using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200017D RID: 381
	internal interface IConfigurationConvention<TMemberInfo> : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention where TMemberInfo : global::System.Reflection.MemberInfo
	{
		// Token: 0x060016EC RID: 5868
		void Apply(TMemberInfo memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);
	}
}
