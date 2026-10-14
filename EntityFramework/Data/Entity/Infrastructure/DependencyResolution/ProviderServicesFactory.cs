using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BA RID: 698
	internal class ProviderServicesFactory
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
		public virtual global::System.Data.Entity.Core.Common.DbProviderServices TryGetInstance(string providerTypeName)
		{
			global::System.Type type = global::System.Type.GetType(providerTypeName, false);
			if (!(type == null))
			{
				return global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory.GetInstance(type);
			}
			return null;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0005E7CA File Offset: 0x0005C9CA
		public virtual global::System.Data.Entity.Core.Common.DbProviderServices GetInstance(string providerTypeName, string providerInvariantName)
		{
			global::System.Type type = global::System.Type.GetType(providerTypeName, false);
			if (type == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EF6Providers_ProviderTypeMissing(providerTypeName, providerInvariantName));
			}
			return global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory.GetInstance(type);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0005E7F0 File Offset: 0x0005C9F0
		private static global::System.Data.Entity.Core.Common.DbProviderServices GetInstance(global::System.Type providerType)
		{
			global::System.Reflection.PropertyInfo propertyInfo = providerType.GetStaticProperty("Instance") ?? providerType.GetField("Instance", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			if (propertyInfo == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EF6Providers_InstanceMissing(providerType.AssemblyQualifiedName));
			}
			global::System.Data.Entity.Core.Common.DbProviderServices dbProviderServices = propertyInfo.GetValue() as global::System.Data.Entity.Core.Common.DbProviderServices;
			if (dbProviderServices == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EF6Providers_NotDbProviderServices(providerType.AssemblyQualifiedName));
			}
			return dbProviderServices;
		}
	}
}
