using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000025 RID: 37
	internal static class TypeExtensions
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		static TypeExtensions()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveTypes())
			{
				if (!global::System.Data.Entity.SqlServer.Utilities.TypeExtensions._primitiveTypesMap.ContainsKey(primitiveType.ClrEquivalentType))
				{
					global::System.Data.Entity.SqlServer.Utilities.TypeExtensions._primitiveTypesMap.Add(primitiveType.ClrEquivalentType, primitiveType);
				}
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000F43C File Offset: 0x0000D63C
		public static bool IsCollection(this global::System.Type type)
		{
			return type.IsCollection(out type);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000F446 File Offset: 0x0000D646
		public static bool IsCollection(this global::System.Type type, out global::System.Type elementType)
		{
			elementType = type.TryGetElementType(typeof(global::System.Collections.Generic.ICollection<>));
			if (elementType == null || type.IsArray)
			{
				elementType = type;
				return false;
			}
			return true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000F472 File Offset: 0x0000D672
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetNonIndexerProperties(this global::System.Type type)
		{
			return from p in type.GetRuntimeProperties()
			where p.IsPublic() && !p.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>()
			select p;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		public static global::System.Type TryGetElementType(this global::System.Type type, global::System.Type interfaceOrBaseType)
		{
			if (type.IsGenericTypeDefinition())
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Type> list = type.GetGenericTypeImplementations(interfaceOrBaseType).ToList<global::System.Type>();
			if (list.Count != 1)
			{
				return null;
			}
			return list[0].GetGenericArguments().FirstOrDefault<global::System.Type>();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetGenericTypeImplementations(this global::System.Type type, global::System.Type interfaceOrBaseType)
		{
			if (!type.IsGenericTypeDefinition())
			{
				global::System.Collections.Generic.IEnumerable<global::System.Type> first;
				if (!interfaceOrBaseType.IsInterface())
				{
					first = type.GetBaseTypes();
				}
				else
				{
					global::System.Collections.Generic.IEnumerable<global::System.Type> interfaces = type.GetInterfaces();
					first = interfaces;
				}
				return from t in first.Union(new global::System.Type[]
				{
					type
				})
				where t.IsGenericType() && t.GetGenericTypeDefinition() == interfaceOrBaseType
				select t;
			}
			return global::System.Linq.Enumerable.Empty<global::System.Type>();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000F545 File Offset: 0x0000D745
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetBaseTypes(this global::System.Type type)
		{
			type = type.BaseType();
			while (type != null)
			{
				yield return type;
				type = type.BaseType();
			}
			yield break;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000F558 File Offset: 0x0000D758
		public static global::System.Type GetTargetType(this global::System.Type type)
		{
			global::System.Type result;
			if (!type.IsCollection(out result))
			{
				result = type;
			}
			return result;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000F572 File Offset: 0x0000D772
		public static bool TryUnwrapNullableType(this global::System.Type type, out global::System.Type underlyingType)
		{
			underlyingType = (global::System.Nullable.GetUnderlyingType(type) ?? type);
			return underlyingType != type;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000F589 File Offset: 0x0000D789
		public static bool IsNullable(this global::System.Type type)
		{
			return !type.IsValueType() || global::System.Nullable.GetUnderlyingType(type) != null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public static bool IsValidStructuralType(this global::System.Type type)
		{
			return !type.IsGenericType() && !type.IsValueType() && !type.IsPrimitive() && !type.IsInterface() && !type.IsArray && !(type == typeof(string)) && !(type == typeof(global::System.Data.Entity.Spatial.DbGeography)) && !(type == typeof(global::System.Data.Entity.Spatial.DbGeometry)) && !(type == typeof(global::System.Data.Entity.Hierarchy.HierarchyId)) && type.IsValidStructuralPropertyType();
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000F62C File Offset: 0x0000D82C
		public static bool IsValidStructuralPropertyType(this global::System.Type type)
		{
			return !type.IsGenericTypeDefinition() && !type.IsPointer && !(type == typeof(object)) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.EntityKey).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference).IsAssignableFrom(type);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		public static bool IsPrimitiveType(this global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			return global::System.Data.Entity.SqlServer.Utilities.TypeExtensions._primitiveTypesMap.TryGetValue(type, out primitiveType);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		public static bool IsValidEdmScalarType(this global::System.Type type)
		{
			type.TryUnwrapNullableType(out type);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			return type.IsPrimitiveType(out primitiveType) || type.IsEnum();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		public static string NestingNamespace(this global::System.Type type)
		{
			if (!type.IsNested)
			{
				return type.Namespace;
			}
			string fullName = type.FullName;
			return fullName.Substring(0, fullName.Length - type.Name.Length - 1).Replace('+', '.');
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000F737 File Offset: 0x0000D937
		public static string FullNameWithNesting(this global::System.Type type)
		{
			if (!type.IsNested)
			{
				return type.FullName;
			}
			return type.FullName.Replace('+', '.');
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000F758 File Offset: 0x0000D958
		public static bool OverridesEqualsOrGetHashCode(this global::System.Type type)
		{
			while (type != typeof(object))
			{
				if (type.GetDeclaredMethods().Any((global::System.Reflection.MethodInfo m) => (m.Name == "Equals" || m.Name == "GetHashCode") && m.DeclaringType != typeof(object) && m.GetBaseDefinition().DeclaringType == typeof(object)))
				{
					return true;
				}
				type = type.BaseType();
			}
			return false;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		public static bool IsPublic(this global::System.Type type)
		{
			global::System.Reflection.TypeInfo typeInfo = type.GetTypeInfo();
			return typeInfo.IsPublic || (typeInfo.IsNestedPublic && type.DeclaringType.IsPublic());
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000F7E3 File Offset: 0x0000D9E3
		public static bool IsNotPublic(this global::System.Type type)
		{
			return !type.IsPublic();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000F7EE File Offset: 0x0000D9EE
		public static global::System.Reflection.MethodInfo GetOnlyDeclaredMethod(this global::System.Type type, string name)
		{
			return type.GetDeclaredMethods(name).SingleOrDefault<global::System.Reflection.MethodInfo>();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public static global::System.Reflection.MethodInfo GetDeclaredMethod(this global::System.Type type, string name, params global::System.Type[] parameterTypes)
		{
			return type.GetDeclaredMethods(name).SingleOrDefault((global::System.Reflection.MethodInfo m) => (from p in m.GetParameters()
			select p.ParameterType).SequenceEqual(parameterTypes));
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000F82E File Offset: 0x0000DA2E
		public static global::System.Reflection.MethodInfo GetPublicInstanceMethod(this global::System.Type type, string name, params global::System.Type[] parameterTypes)
		{
			return type.GetRuntimeMethod(name, (global::System.Reflection.MethodInfo m) => m.IsPublic && !m.IsStatic, parameterTypes);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000F858 File Offset: 0x0000DA58
		public static global::System.Reflection.MethodInfo GetRuntimeMethod(this global::System.Type type, string name, global::System.Func<global::System.Reflection.MethodInfo, bool> predicate, params global::System.Type[][] parameterTypes)
		{
			return (from t in parameterTypes
			select type.GetRuntimeMethod(name, predicate, t)).FirstOrDefault((global::System.Reflection.MethodInfo m) => m != null);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		private static global::System.Reflection.MethodInfo GetRuntimeMethod(this global::System.Type type, string name, global::System.Func<global::System.Reflection.MethodInfo, bool> predicate, global::System.Type[] parameterTypes)
		{
			global::System.Reflection.MethodInfo[] methods = type.GetRuntimeMethods().Where(delegate(global::System.Reflection.MethodInfo m)
			{
				if (name == m.Name && predicate(m))
				{
					return (from p in m.GetParameters()
					select p.ParameterType).SequenceEqual(parameterTypes);
				}
				return false;
			}).ToArray<global::System.Reflection.MethodInfo>();
			if (methods.Length == 1)
			{
				return methods[0];
			}
			return methods.SingleOrDefault((global::System.Reflection.MethodInfo m) => !methods.Any((global::System.Reflection.MethodInfo m2) => m2.DeclaringType.IsSubclassOf(m.DeclaringType)));
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000F92D File Offset: 0x0000DB2D
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetDeclaredMethods(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredMethods;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000F93A File Offset: 0x0000DB3A
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetDeclaredMethods(this global::System.Type type, string name)
		{
			return type.GetTypeInfo().GetDeclaredMethods(name);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000F948 File Offset: 0x0000DB48
		public static global::System.Reflection.PropertyInfo GetDeclaredProperty(this global::System.Type type, string name)
		{
			return type.GetTypeInfo().GetDeclaredProperty(name);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000F956 File Offset: 0x0000DB56
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetDeclaredProperties(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredProperties;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000F963 File Offset: 0x0000DB63
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetInstanceProperties(this global::System.Type type)
		{
			return from p in type.GetRuntimeProperties()
			where !p.IsStatic()
			select p;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000F990 File Offset: 0x0000DB90
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetNonHiddenProperties(this global::System.Type type)
		{
			return from property in type.GetRuntimeProperties()
			group property by property.Name into propertyGroup
			select global::System.Data.Entity.SqlServer.Utilities.TypeExtensions.MostDerived(propertyGroup);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		private static global::System.Reflection.PropertyInfo MostDerived(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> properties)
		{
			global::System.Reflection.PropertyInfo propertyInfo = null;
			foreach (global::System.Reflection.PropertyInfo propertyInfo2 in properties)
			{
				if (propertyInfo == null || (propertyInfo.DeclaringType != null && propertyInfo.DeclaringType.IsAssignableFrom(propertyInfo2.DeclaringType)))
				{
					propertyInfo = propertyInfo2;
				}
			}
			return propertyInfo;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		public static global::System.Reflection.PropertyInfo GetAnyProperty(this global::System.Type type, string name)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> source = (from p in type.GetRuntimeProperties()
			where p.Name == name
			select p).ToList<global::System.Reflection.PropertyInfo>();
			if (source.Count<global::System.Reflection.PropertyInfo>() > 1)
			{
				throw new global::System.Reflection.AmbiguousMatchException();
			}
			return source.SingleOrDefault<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		public static global::System.Reflection.PropertyInfo GetInstanceProperty(this global::System.Type type, string name)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> source = (from p in type.GetRuntimeProperties()
			where p.Name == name && !p.IsStatic()
			select p).ToList<global::System.Reflection.PropertyInfo>();
			if (source.Count<global::System.Reflection.PropertyInfo>() > 1)
			{
				throw new global::System.Reflection.AmbiguousMatchException();
			}
			return source.SingleOrDefault<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public static global::System.Reflection.PropertyInfo GetStaticProperty(this global::System.Type type, string name)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> source = (from p in type.GetRuntimeProperties()
			where p.Name == name && p.IsStatic()
			select p).ToList<global::System.Reflection.PropertyInfo>();
			if (source.Count<global::System.Reflection.PropertyInfo>() > 1)
			{
				throw new global::System.Reflection.AmbiguousMatchException();
			}
			return source.SingleOrDefault<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000FB40 File Offset: 0x0000DD40
		public static global::System.Reflection.PropertyInfo GetTopProperty(this global::System.Type type, string name)
		{
			global::System.Reflection.PropertyInfo declaredProperty;
			for (;;)
			{
				global::System.Reflection.TypeInfo typeInfo = type.GetTypeInfo();
				declaredProperty = typeInfo.GetDeclaredProperty(name);
				if (declaredProperty != null && !(declaredProperty.GetMethod ?? declaredProperty.SetMethod).IsStatic)
				{
					break;
				}
				type = typeInfo.BaseType;
				if (!(type != null))
				{
					goto Block_3;
				}
			}
			return declaredProperty;
			Block_3:
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000FB90 File Offset: 0x0000DD90
		public static global::System.Reflection.Assembly Assembly(this global::System.Type type)
		{
			return type.GetTypeInfo().Assembly;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000FB9D File Offset: 0x0000DD9D
		public static global::System.Type BaseType(this global::System.Type type)
		{
			return type.GetTypeInfo().BaseType;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000FBAA File Offset: 0x0000DDAA
		public static bool IsGenericType(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericType;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000FBB7 File Offset: 0x0000DDB7
		public static bool IsGenericTypeDefinition(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericTypeDefinition;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		public static global::System.Reflection.TypeAttributes Attributes(this global::System.Type type)
		{
			return type.GetTypeInfo().Attributes;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000FBD1 File Offset: 0x0000DDD1
		public static bool IsClass(this global::System.Type type)
		{
			return type.GetTypeInfo().IsClass;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000FBDE File Offset: 0x0000DDDE
		public static bool IsInterface(this global::System.Type type)
		{
			return type.GetTypeInfo().IsInterface;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000FBEB File Offset: 0x0000DDEB
		public static bool IsValueType(this global::System.Type type)
		{
			return type.GetTypeInfo().IsValueType;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		public static bool IsAbstract(this global::System.Type type)
		{
			return type.GetTypeInfo().IsAbstract;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000FC05 File Offset: 0x0000DE05
		public static bool IsSealed(this global::System.Type type)
		{
			return type.GetTypeInfo().IsSealed;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000FC12 File Offset: 0x0000DE12
		public static bool IsEnum(this global::System.Type type)
		{
			return type.GetTypeInfo().IsEnum;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000FC1F File Offset: 0x0000DE1F
		public static bool IsSerializable(this global::System.Type type)
		{
			return type.GetTypeInfo().IsSerializable;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		public static bool IsGenericParameter(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericParameter;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000FC39 File Offset: 0x0000DE39
		public static bool ContainsGenericParameters(this global::System.Type type)
		{
			return type.GetTypeInfo().ContainsGenericParameters;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000FC46 File Offset: 0x0000DE46
		public static bool IsPrimitive(this global::System.Type type)
		{
			return type.GetTypeInfo().IsPrimitive;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000FC53 File Offset: 0x0000DE53
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.ConstructorInfo> GetDeclaredConstructors(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredConstructors;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000FC60 File Offset: 0x0000DE60
		public static global::System.Reflection.ConstructorInfo GetDeclaredConstructor(this global::System.Type type, params global::System.Type[] parameterTypes)
		{
			return type.GetDeclaredConstructors().SingleOrDefault(delegate(global::System.Reflection.ConstructorInfo c)
			{
				if (!c.IsStatic)
				{
					return (from p in c.GetParameters()
					select p.ParameterType).SequenceEqual(parameterTypes);
				}
				return false;
			});
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public static global::System.Reflection.ConstructorInfo GetPublicConstructor(this global::System.Type type, params global::System.Type[] parameterTypes)
		{
			global::System.Reflection.ConstructorInfo declaredConstructor = type.GetDeclaredConstructor(parameterTypes);
			if (!(declaredConstructor != null) || !declaredConstructor.IsPublic)
			{
				return null;
			}
			return declaredConstructor;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public static global::System.Reflection.ConstructorInfo GetDeclaredConstructor(this global::System.Type type, global::System.Func<global::System.Reflection.ConstructorInfo, bool> predicate, params global::System.Type[][] parameterTypes)
		{
			return (from p in parameterTypes
			select type.GetDeclaredConstructor(p)).FirstOrDefault((global::System.Reflection.ConstructorInfo c) => c != null && predicate(c));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public static bool IsSubclassOf(this global::System.Type type, global::System.Type otherType)
		{
			return type.GetTypeInfo().IsSubclassOf(otherType);
		}

		// Token: 0x040000CD RID: 205
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypesMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
	}
}
