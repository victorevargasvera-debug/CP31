using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000090 RID: 144
	internal static class TypeExtensions
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x0000FFDC File Offset: 0x0000E1DC
		static TypeExtensions()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveTypes())
			{
				if (!global::System.Data.Entity.Utilities.TypeExtensions._primitiveTypesMap.ContainsKey(primitiveType.ClrEquivalentType))
				{
					global::System.Data.Entity.Utilities.TypeExtensions._primitiveTypesMap.Add(primitiveType.ClrEquivalentType, primitiveType);
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00010050 File Offset: 0x0000E250
		public static bool IsCollection(this global::System.Type type)
		{
			return type.IsCollection(out type);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001005A File Offset: 0x0000E25A
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

		// Token: 0x0600049E RID: 1182 RVA: 0x00010086 File Offset: 0x0000E286
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetNonIndexerProperties(this global::System.Type type)
		{
			return from p in type.GetRuntimeProperties()
			where p.IsPublic() && !p.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>()
			select p;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000100B4 File Offset: 0x0000E2B4
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

		// Token: 0x060004A0 RID: 1184 RVA: 0x000100F4 File Offset: 0x0000E2F4
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

		// Token: 0x060004A1 RID: 1185 RVA: 0x00010159 File Offset: 0x0000E359
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

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001016C File Offset: 0x0000E36C
		public static global::System.Type GetTargetType(this global::System.Type type)
		{
			global::System.Type result;
			if (!type.IsCollection(out result))
			{
				result = type;
			}
			return result;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00010186 File Offset: 0x0000E386
		public static bool TryUnwrapNullableType(this global::System.Type type, out global::System.Type underlyingType)
		{
			underlyingType = (global::System.Nullable.GetUnderlyingType(type) ?? type);
			return underlyingType != type;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001019D File Offset: 0x0000E39D
		public static bool IsNullable(this global::System.Type type)
		{
			return !type.IsValueType() || global::System.Nullable.GetUnderlyingType(type) != null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public static bool IsValidStructuralType(this global::System.Type type)
		{
			return !type.IsGenericType() && !type.IsValueType() && !type.IsPrimitive() && !type.IsInterface() && !type.IsArray && !(type == typeof(string)) && !(type == typeof(global::System.Data.Entity.Spatial.DbGeography)) && !(type == typeof(global::System.Data.Entity.Spatial.DbGeometry)) && !(type == typeof(global::System.Data.Entity.Hierarchy.HierarchyId)) && type.IsValidStructuralPropertyType();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00010240 File Offset: 0x0000E440
		public static bool IsValidStructuralPropertyType(this global::System.Type type)
		{
			return !type.IsGenericTypeDefinition() && !type.IsPointer && !(type == typeof(object)) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.EntityKey).IsAssignableFrom(type) && !typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference).IsAssignableFrom(type);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000102CC File Offset: 0x0000E4CC
		public static bool IsPrimitiveType(this global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			return global::System.Data.Entity.Utilities.TypeExtensions._primitiveTypesMap.TryGetValue(type, out primitiveType);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000102DC File Offset: 0x0000E4DC
		public static T CreateInstance<T>(this global::System.Type type, global::System.Func<string, string, string> typeMessageFactory, global::System.Func<string, global::System.Exception> exceptionFactory = null)
		{
			global::System.Func<string, global::System.Exception> func;
			if ((func = exceptionFactory) == null && (func = global::System.Data.Entity.Utilities.TypeExtensions.<>c__14<T>.<>9__14_0) == null)
			{
				func = (global::System.Data.Entity.Utilities.TypeExtensions.<>c__14<T>.<>9__14_0 = ((string s) => new global::System.InvalidOperationException(s)));
			}
			exceptionFactory = func;
			if (!typeof(T).IsAssignableFrom(type))
			{
				throw exceptionFactory(typeMessageFactory(type.ToString(), typeof(T).ToString()));
			}
			return type.CreateInstance(exceptionFactory);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001034C File Offset: 0x0000E54C
		public static T CreateInstance<T>(this global::System.Type type, global::System.Func<string, global::System.Exception> exceptionFactory = null)
		{
			global::System.Func<string, global::System.Exception> func;
			if ((func = exceptionFactory) == null && (func = global::System.Data.Entity.Utilities.TypeExtensions.<>c__15<T>.<>9__15_0) == null)
			{
				func = (global::System.Data.Entity.Utilities.TypeExtensions.<>c__15<T>.<>9__15_0 = ((string s) => new global::System.InvalidOperationException(s)));
			}
			exceptionFactory = func;
			if (type.GetDeclaredConstructor(new global::System.Type[0]) == null)
			{
				throw exceptionFactory(global::System.Data.Entity.Resources.Strings.CreateInstance_NoParameterlessConstructor(type));
			}
			if (type.IsAbstract())
			{
				throw exceptionFactory(global::System.Data.Entity.Resources.Strings.CreateInstance_AbstractType(type));
			}
			if (type.IsGenericType())
			{
				throw exceptionFactory(global::System.Data.Entity.Resources.Strings.CreateInstance_GenericType(type));
			}
			return (T)((object)global::System.Activator.CreateInstance(type, true));
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000103D8 File Offset: 0x0000E5D8
		public static bool IsValidEdmScalarType(this global::System.Type type)
		{
			type.TryUnwrapNullableType(out type);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			return type.IsPrimitiveType(out primitiveType) || type.IsEnum();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00010400 File Offset: 0x0000E600
		public static string NestingNamespace(this global::System.Type type)
		{
			if (!type.IsNested)
			{
				return type.Namespace;
			}
			string fullName = type.FullName;
			return fullName.Substring(0, fullName.Length - type.Name.Length - 1).Replace('+', '.');
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00010447 File Offset: 0x0000E647
		public static string FullNameWithNesting(this global::System.Type type)
		{
			if (!type.IsNested)
			{
				return type.FullName;
			}
			return type.FullName.Replace('+', '.');
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00010468 File Offset: 0x0000E668
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

		// Token: 0x060004AE RID: 1198 RVA: 0x000104C0 File Offset: 0x0000E6C0
		public static bool IsPublic(this global::System.Type type)
		{
			global::System.Reflection.TypeInfo typeInfo = type.GetTypeInfo();
			return typeInfo.IsPublic || (typeInfo.IsNestedPublic && type.DeclaringType.IsPublic());
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000104F3 File Offset: 0x0000E6F3
		public static bool IsNotPublic(this global::System.Type type)
		{
			return !type.IsPublic();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000104FE File Offset: 0x0000E6FE
		public static global::System.Reflection.MethodInfo GetOnlyDeclaredMethod(this global::System.Type type, string name)
		{
			return type.GetDeclaredMethods(name).SingleOrDefault<global::System.Reflection.MethodInfo>();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001050C File Offset: 0x0000E70C
		public static global::System.Reflection.MethodInfo GetDeclaredMethod(this global::System.Type type, string name, params global::System.Type[] parameterTypes)
		{
			return type.GetDeclaredMethods(name).SingleOrDefault((global::System.Reflection.MethodInfo m) => (from p in m.GetParameters()
			select p.ParameterType).SequenceEqual(parameterTypes));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001053E File Offset: 0x0000E73E
		public static global::System.Reflection.MethodInfo GetPublicInstanceMethod(this global::System.Type type, string name, params global::System.Type[] parameterTypes)
		{
			return type.GetRuntimeMethod(name, (global::System.Reflection.MethodInfo m) => m.IsPublic && !m.IsStatic, parameterTypes);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00010568 File Offset: 0x0000E768
		public static global::System.Reflection.MethodInfo GetRuntimeMethod(this global::System.Type type, string name, global::System.Func<global::System.Reflection.MethodInfo, bool> predicate, params global::System.Type[][] parameterTypes)
		{
			return (from t in parameterTypes
			select type.GetRuntimeMethod(name, predicate, t)).FirstOrDefault((global::System.Reflection.MethodInfo m) => m != null);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000105C8 File Offset: 0x0000E7C8
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

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001063D File Offset: 0x0000E83D
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetDeclaredMethods(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredMethods;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001064A File Offset: 0x0000E84A
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.MethodInfo> GetDeclaredMethods(this global::System.Type type, string name)
		{
			return type.GetTypeInfo().GetDeclaredMethods(name);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00010658 File Offset: 0x0000E858
		public static global::System.Reflection.PropertyInfo GetDeclaredProperty(this global::System.Type type, string name)
		{
			return type.GetTypeInfo().GetDeclaredProperty(name);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00010666 File Offset: 0x0000E866
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetDeclaredProperties(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredProperties;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00010673 File Offset: 0x0000E873
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetInstanceProperties(this global::System.Type type)
		{
			return from p in type.GetRuntimeProperties()
			where !p.IsStatic()
			select p;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000106A0 File Offset: 0x0000E8A0
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetNonHiddenProperties(this global::System.Type type)
		{
			return from property in type.GetRuntimeProperties()
			group property by property.Name into propertyGroup
			select global::System.Data.Entity.Utilities.TypeExtensions.MostDerived(propertyGroup);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000106FC File Offset: 0x0000E8FC
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

		// Token: 0x060004BC RID: 1212 RVA: 0x0001076C File Offset: 0x0000E96C
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

		// Token: 0x060004BD RID: 1213 RVA: 0x000107B8 File Offset: 0x0000E9B8
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

		// Token: 0x060004BE RID: 1214 RVA: 0x00010804 File Offset: 0x0000EA04
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

		// Token: 0x060004BF RID: 1215 RVA: 0x00010850 File Offset: 0x0000EA50
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

		// Token: 0x060004C0 RID: 1216 RVA: 0x000108A0 File Offset: 0x0000EAA0
		public static global::System.Reflection.Assembly Assembly(this global::System.Type type)
		{
			return type.GetTypeInfo().Assembly;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000108AD File Offset: 0x0000EAAD
		public static global::System.Type BaseType(this global::System.Type type)
		{
			return type.GetTypeInfo().BaseType;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000108BA File Offset: 0x0000EABA
		public static bool IsGenericType(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericType;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000108C7 File Offset: 0x0000EAC7
		public static bool IsGenericTypeDefinition(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericTypeDefinition;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000108D4 File Offset: 0x0000EAD4
		public static global::System.Reflection.TypeAttributes Attributes(this global::System.Type type)
		{
			return type.GetTypeInfo().Attributes;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000108E1 File Offset: 0x0000EAE1
		public static bool IsClass(this global::System.Type type)
		{
			return type.GetTypeInfo().IsClass;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000108EE File Offset: 0x0000EAEE
		public static bool IsInterface(this global::System.Type type)
		{
			return type.GetTypeInfo().IsInterface;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000108FB File Offset: 0x0000EAFB
		public static bool IsValueType(this global::System.Type type)
		{
			return type.GetTypeInfo().IsValueType;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00010908 File Offset: 0x0000EB08
		public static bool IsAbstract(this global::System.Type type)
		{
			return type.GetTypeInfo().IsAbstract;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00010915 File Offset: 0x0000EB15
		public static bool IsSealed(this global::System.Type type)
		{
			return type.GetTypeInfo().IsSealed;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00010922 File Offset: 0x0000EB22
		public static bool IsEnum(this global::System.Type type)
		{
			return type.GetTypeInfo().IsEnum;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001092F File Offset: 0x0000EB2F
		public static bool IsSerializable(this global::System.Type type)
		{
			return type.GetTypeInfo().IsSerializable;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001093C File Offset: 0x0000EB3C
		public static bool IsGenericParameter(this global::System.Type type)
		{
			return type.GetTypeInfo().IsGenericParameter;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00010949 File Offset: 0x0000EB49
		public static bool ContainsGenericParameters(this global::System.Type type)
		{
			return type.GetTypeInfo().ContainsGenericParameters;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00010956 File Offset: 0x0000EB56
		public static bool IsPrimitive(this global::System.Type type)
		{
			return type.GetTypeInfo().IsPrimitive;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00010963 File Offset: 0x0000EB63
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.ConstructorInfo> GetDeclaredConstructors(this global::System.Type type)
		{
			return type.GetTypeInfo().DeclaredConstructors;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00010970 File Offset: 0x0000EB70
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

		// Token: 0x060004D1 RID: 1233 RVA: 0x000109A4 File Offset: 0x0000EBA4
		public static global::System.Reflection.ConstructorInfo GetPublicConstructor(this global::System.Type type, params global::System.Type[] parameterTypes)
		{
			global::System.Reflection.ConstructorInfo declaredConstructor = type.GetDeclaredConstructor(parameterTypes);
			if (!(declaredConstructor != null) || !declaredConstructor.IsPublic)
			{
				return null;
			}
			return declaredConstructor;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public static global::System.Reflection.ConstructorInfo GetDeclaredConstructor(this global::System.Type type, global::System.Func<global::System.Reflection.ConstructorInfo, bool> predicate, params global::System.Type[][] parameterTypes)
		{
			return (from p in parameterTypes
			select type.GetDeclaredConstructor(p)).FirstOrDefault((global::System.Reflection.ConstructorInfo c) => c != null && predicate(c));
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00010A14 File Offset: 0x0000EC14
		public static bool IsSubclassOf(this global::System.Type type, global::System.Type otherType)
		{
			return type.GetTypeInfo().IsSubclassOf(otherType);
		}

		// Token: 0x0400011E RID: 286
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypesMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
	}
}
