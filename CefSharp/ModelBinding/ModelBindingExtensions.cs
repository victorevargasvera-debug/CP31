using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000C2 RID: 194
	internal static class ModelBindingExtensions
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00009186 File Offset: 0x00007386
		public static bool IsArray(this global::System.Type source)
		{
			return source.GetTypeInfo().BaseType == typeof(global::System.Array);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000091A4 File Offset: 0x000073A4
		public static bool IsCollection(this global::System.Type source)
		{
			global::System.Type collectionType = typeof(global::System.Collections.Generic.ICollection<>);
			return source.GetTypeInfo().IsGenericType && source.GetInterfaces().Any((global::System.Type i) => i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == collectionType);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000091F0 File Offset: 0x000073F0
		public static bool IsEnumerable(this global::System.Type source)
		{
			global::System.Type typeFromHandle = typeof(global::System.Collections.Generic.IEnumerable<>);
			return source.GetTypeInfo().IsGenericType && source.GetGenericTypeDefinition() == typeFromHandle;
		}
	}
}
