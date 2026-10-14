using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B3 RID: 691
	internal class DefaultProviderServicesResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x0005E179 File Offset: 0x0005C379
		public virtual object GetService(global::System.Type type, object key)
		{
			if (type == typeof(global::System.Data.Entity.Core.Common.DbProviderServices))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EF6Providers_NoProviderFound(global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderServicesResolver.CheckKey(key)));
			}
			return null;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0005E19F File Offset: 0x0005C39F
		private static string CheckKey(object key)
		{
			string text = key as string;
			if (string.IsNullOrWhiteSpace(text))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_NoProviderInvariantName(typeof(global::System.Data.Entity.Core.Common.DbProviderServices).Name));
			}
			return text;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0005E1C9 File Offset: 0x0005C3C9
		public virtual global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			if (type == typeof(global::System.Data.Entity.Core.Common.DbProviderServices))
			{
				global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderServicesResolver.CheckKey(key);
			}
			return global::System.Linq.Enumerable.Empty<object>();
		}
	}
}
