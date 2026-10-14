using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AE RID: 686
	internal class DbConfigurationLoader
	{
		// Token: 0x060021B1 RID: 8625 RVA: 0x0005D8E0 File Offset: 0x0005BAE0
		public virtual global::System.Type TryLoadFromConfig(global::System.Data.Entity.Internal.AppConfig config)
		{
			string configurationTypeName = config.ConfigurationTypeName;
			if (string.IsNullOrWhiteSpace(configurationTypeName))
			{
				return null;
			}
			global::System.Type type;
			try
			{
				type = global::System.Type.GetType(configurationTypeName, true);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbConfigurationTypeNotFound(configurationTypeName), innerException);
			}
			if (!typeof(global::System.Data.Entity.DbConfiguration).IsAssignableFrom(type))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CreateInstance_BadDbConfigurationType(type.ToString(), typeof(global::System.Data.Entity.DbConfiguration).ToString()));
			}
			return type;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0005D95C File Offset: 0x0005BB5C
		public virtual bool AppConfigContainsDbConfigurationType(global::System.Data.Entity.Internal.AppConfig config)
		{
			return !string.IsNullOrWhiteSpace(config.ConfigurationTypeName);
		}
	}
}
