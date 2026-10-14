using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000071 RID: 113
	internal static class CachedAttributeGetter<T> where T : global::System.Attribute
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x000195D8 File Offset: 0x000177D8
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T GetAttribute(object type)
		{
			return global::Newtonsoft.Json.Serialization.CachedAttributeGetter<T>.TypeAttributeCache.Get(type);
		}

		// Token: 0x0400020F RID: 527
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<object, T> TypeAttributeCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<object, T>(new global::System.Func<object, T>(global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<T>));
	}
}
