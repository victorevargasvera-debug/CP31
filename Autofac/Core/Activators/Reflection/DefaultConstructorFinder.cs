using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A8 RID: 168
	public class DefaultConstructorFinder : global::Autofac.Core.Activators.Reflection.IConstructorFinder
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		public DefaultConstructorFinder() : this(new global::System.Func<global::System.Type, global::System.Reflection.ConstructorInfo[]>(global::Autofac.Core.Activators.Reflection.DefaultConstructorFinder.GetDefaultPublicConstructors))
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000BCF5 File Offset: 0x00009EF5
		public DefaultConstructorFinder(global::System.Func<global::System.Type, global::System.Reflection.ConstructorInfo[]> finder)
		{
			if (finder == null)
			{
				throw new global::System.ArgumentNullException("finder");
			}
			this._finder = finder;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000BD12 File Offset: 0x00009F12
		public global::System.Reflection.ConstructorInfo[] FindConstructors(global::System.Type targetType)
		{
			return this._finder(targetType);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000BD20 File Offset: 0x00009F20
		private static global::System.Reflection.ConstructorInfo[] GetDefaultPublicConstructors(global::System.Type type)
		{
			global::System.Reflection.ConstructorInfo[] orAdd = global::Autofac.Core.Activators.Reflection.DefaultConstructorFinder.DefaultPublicConstructorsCache.GetOrAdd(type, (global::System.Type t) => (from c in t.GetTypeInfo().DeclaredConstructors
			where c.IsPublic
			select c).ToArray<global::System.Reflection.ConstructorInfo>());
			if (orAdd.Length == 0)
			{
				throw new global::Autofac.Core.Activators.Reflection.NoConstructorsFoundException(type);
			}
			return orAdd;
		}

		// Token: 0x04000107 RID: 263
		private readonly global::System.Func<global::System.Type, global::System.Reflection.ConstructorInfo[]> _finder;

		// Token: 0x04000108 RID: 264
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Reflection.ConstructorInfo[]> DefaultPublicConstructorsCache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Reflection.ConstructorInfo[]>();
	}
}
