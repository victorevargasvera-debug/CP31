using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B6 RID: 694
	public static class DbDependencyResolverExtensions
	{
		// Token: 0x060021D6 RID: 8662 RVA: 0x0005E2B6 File Offset: 0x0005C4B6
		public static T GetService<T>(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, object key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			return (T)((object)resolver.GetService(typeof(T), key));
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0005E2DA File Offset: 0x0005C4DA
		public static T GetService<T>(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			return (T)((object)resolver.GetService(typeof(T), null));
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0005E2FE File Offset: 0x0005C4FE
		public static object GetService(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			return resolver.GetService(type, null);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0005E320 File Offset: 0x0005C520
		public static global::System.Collections.Generic.IEnumerable<T> GetServices<T>(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, object key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			return resolver.GetServices(typeof(T), key).OfType<T>();
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0005E344 File Offset: 0x0005C544
		public static global::System.Collections.Generic.IEnumerable<T> GetServices<T>(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			return resolver.GetServices(typeof(T), null).OfType<T>();
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0005E368 File Offset: 0x0005C568
		public static global::System.Collections.Generic.IEnumerable<object> GetServices(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			return resolver.GetServices(type, null);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0005E38C File Offset: 0x0005C58C
		internal static global::System.Collections.Generic.IEnumerable<object> GetServiceAsServices(this global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver, global::System.Type type, object key)
		{
			object service = resolver.GetService(type, key);
			if (service != null)
			{
				return new object[]
				{
					service
				};
			}
			return global::System.Linq.Enumerable.Empty<object>();
		}
	}
}
