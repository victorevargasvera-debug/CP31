using System;
using System.Collections.Concurrent;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000111 RID: 273
	internal static class ObjectContextTypeCache
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x00031671 File Offset: 0x0002F871
		public static global::System.Type GetObjectType(global::System.Type type)
		{
			return global::System.Data.Entity.Internal.ObjectContextTypeCache._typeCache.GetOrAdd(type, new global::System.Func<global::System.Type, global::System.Type>(global::System.Data.Entity.Core.Objects.ObjectContext.GetObjectType));
		}

		// Token: 0x0400094C RID: 2380
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Type> _typeCache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Type>();
	}
}
