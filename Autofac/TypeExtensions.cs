using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Autofac.Util;

namespace Autofac
{
	// Token: 0x02000017 RID: 23
	public static class TypeExtensions
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00004380 File Offset: 0x00002580
		public static bool IsInNamespace(this global::System.Type @this, string @namespace)
		{
			if (@this == null)
			{
				throw new global::System.ArgumentNullException("this");
			}
			if (@namespace == null)
			{
				throw new global::System.ArgumentNullException("namespace");
			}
			return @this.Namespace != null && (@this.Namespace == @namespace || @this.Namespace.StartsWith(@namespace + ".", global::System.StringComparison.Ordinal));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000043E0 File Offset: 0x000025E0
		public static bool IsInNamespaceOf<T>(this global::System.Type @this)
		{
			if (@this == null)
			{
				throw new global::System.ArgumentNullException("this");
			}
			return @this.IsInNamespace(typeof(T).Namespace);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000440C File Offset: 0x0000260C
		public static bool IsClosedTypeOf(this global::System.Type @this, global::System.Type openGeneric)
		{
			if (@this == null)
			{
				throw new global::System.ArgumentNullException("this");
			}
			if (openGeneric == null)
			{
				throw new global::System.ArgumentNullException("openGeneric");
			}
			if (!openGeneric.GetTypeInfo().IsGenericTypeDefinition && !openGeneric.GetTypeInfo().ContainsGenericParameters)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.TypeExtensionsResources.NotOpenGenericType, new object[]
				{
					openGeneric.FullName
				}));
			}
			return @this.GetTypesThatClose(openGeneric).Any<global::System.Type>();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000448B File Offset: 0x0000268B
		public static bool IsAssignableTo<T>(this global::System.Type @this)
		{
			if (@this == null)
			{
				throw new global::System.ArgumentNullException("this");
			}
			return typeof(T).GetTypeInfo().IsAssignableFrom(@this.GetTypeInfo());
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000044BC File Offset: 0x000026BC
		public static global::System.Reflection.ConstructorInfo GetMatchingConstructor(this global::System.Type type, global::System.Type[] constructorParameterTypes)
		{
			return type.GetTypeInfo().DeclaredConstructors.FirstOrDefault((global::System.Reflection.ConstructorInfo c) => (from p in c.GetParameters()
			select p.ParameterType).SequenceEqual(constructorParameterTypes));
		}
	}
}
