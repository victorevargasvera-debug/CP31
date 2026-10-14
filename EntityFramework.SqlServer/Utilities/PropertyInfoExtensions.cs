using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000026 RID: 38
	internal static class PropertyInfoExtensions
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public static bool IsSameAs(this global::System.Reflection.PropertyInfo propertyInfo, global::System.Reflection.PropertyInfo otherPropertyInfo)
		{
			return propertyInfo == otherPropertyInfo || (propertyInfo.Name == otherPropertyInfo.Name && (propertyInfo.DeclaringType == otherPropertyInfo.DeclaringType || propertyInfo.DeclaringType.IsSubclassOf(otherPropertyInfo.DeclaringType) || otherPropertyInfo.DeclaringType.IsSubclassOf(propertyInfo.DeclaringType) || propertyInfo.DeclaringType.GetInterfaces().Contains(otherPropertyInfo.DeclaringType) || otherPropertyInfo.DeclaringType.GetInterfaces().Contains(propertyInfo.DeclaringType)));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000FDAA File Offset: 0x0000DFAA
		public static bool ContainsSame(this global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable, global::System.Reflection.PropertyInfo propertyInfo)
		{
			return enumerable.Any(new global::System.Func<global::System.Reflection.PropertyInfo, bool>(propertyInfo.IsSameAs));
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000FDBE File Offset: 0x0000DFBE
		public static bool IsValidStructuralProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.IsValidInterfaceStructuralProperty() && !propertyInfo.Getter().IsAbstract;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		public static bool IsValidInterfaceStructuralProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.CanRead && (propertyInfo.CanWriteExtended() || propertyInfo.PropertyType.IsCollection()) && propertyInfo.GetIndexParameters().Length == 0 && propertyInfo.PropertyType.IsValidStructuralPropertyType();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000FE0D File Offset: 0x0000E00D
		public static bool IsValidEdmScalarProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.IsValidInterfaceStructuralProperty() && propertyInfo.PropertyType.IsValidEdmScalarType();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000FE24 File Offset: 0x0000E024
		public static bool IsValidEdmNavigationProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Type type;
			return propertyInfo.IsValidInterfaceStructuralProperty() && ((propertyInfo.PropertyType.IsCollection(out type) && type.IsValidStructuralType()) || propertyInfo.PropertyType.IsValidStructuralType());
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000FE60 File Offset: 0x0000E060
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty AsEdmPrimitiveProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Type propertyType = propertyInfo.PropertyType;
			bool nullable = propertyType.TryUnwrapNullableType(out propertyType) || !propertyType.IsValueType();
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			if (propertyType.IsPrimitiveType(out primitiveType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreatePrimitive(propertyInfo.Name, primitiveType);
				edmProperty.Nullable = nullable;
				return edmProperty;
			}
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		public static bool CanWriteExtended(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (propertyInfo.CanWrite)
			{
				return true;
			}
			global::System.Reflection.PropertyInfo declaredProperty = global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.GetDeclaredProperty(propertyInfo);
			return declaredProperty != null && declaredProperty.CanWrite;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000FEDB File Offset: 0x0000E0DB
		public static global::System.Reflection.PropertyInfo GetPropertyInfoForSet(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.PropertyInfo result;
			if (!propertyInfo.CanWrite)
			{
				if ((result = global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.GetDeclaredProperty(propertyInfo)) == null)
				{
					return propertyInfo;
				}
			}
			else
			{
				result = propertyInfo;
			}
			return result;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		private static global::System.Reflection.PropertyInfo GetDeclaredProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (!(propertyInfo.DeclaringType == propertyInfo.ReflectedType))
			{
				return propertyInfo.DeclaringType.GetInstanceProperties().SingleOrDefault((global::System.Reflection.PropertyInfo p) => p.Name == propertyInfo.Name && p.DeclaringType == propertyInfo.DeclaringType && !p.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>() && p.PropertyType == propertyInfo.PropertyType);
			}
			return propertyInfo;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000FF54 File Offset: 0x0000E154
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetPropertiesInHierarchy(this global::System.Reflection.PropertyInfo property)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>
			{
				property
			};
			global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.CollectProperties(property, list);
			return list.Distinct<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000FF7B File Offset: 0x0000E17B
		private static void CollectProperties(global::System.Reflection.PropertyInfo property, global::System.Collections.Generic.IList<global::System.Reflection.PropertyInfo> collection)
		{
			global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.FindNextProperty(property, collection, true);
			global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.FindNextProperty(property, collection, false);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000FF90 File Offset: 0x0000E190
		private static void FindNextProperty(global::System.Reflection.PropertyInfo property, global::System.Collections.Generic.IList<global::System.Reflection.PropertyInfo> collection, bool getter)
		{
			global::System.Reflection.MethodInfo methodInfo = getter ? property.Getter() : property.Setter();
			if (methodInfo != null)
			{
				global::System.Type type = methodInfo.DeclaringType.BaseType();
				if (type != null && type != typeof(object))
				{
					global::System.Reflection.MethodInfo baseMethod = methodInfo.GetBaseDefinition();
					global::System.Reflection.PropertyInfo propertyInfo = (from p in type.GetInstanceProperties()
					let candidateMethod = getter ? p.Getter() : p.Setter()
					where candidateMethod != null && candidateMethod.GetBaseDefinition() == baseMethod
					select p).FirstOrDefault<global::System.Reflection.PropertyInfo>();
					if (propertyInfo != null)
					{
						collection.Add(propertyInfo);
						global::System.Data.Entity.SqlServer.Utilities.PropertyInfoExtensions.CollectProperties(propertyInfo, collection);
					}
				}
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00010076 File Offset: 0x0000E276
		public static global::System.Reflection.MethodInfo Getter(this global::System.Reflection.PropertyInfo property)
		{
			return property.GetMethod;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001007E File Offset: 0x0000E27E
		public static global::System.Reflection.MethodInfo Setter(this global::System.Reflection.PropertyInfo property)
		{
			return property.SetMethod;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00010086 File Offset: 0x0000E286
		public static bool IsStatic(this global::System.Reflection.PropertyInfo property)
		{
			return (property.Getter() ?? property.Setter()).IsStatic;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000100A0 File Offset: 0x0000E2A0
		public static bool IsPublic(this global::System.Reflection.PropertyInfo property)
		{
			global::System.Reflection.MethodInfo methodInfo = property.Getter();
			global::System.Reflection.MethodAttributes methodAttributes = (methodInfo == null) ? global::System.Reflection.MethodAttributes.Private : (methodInfo.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask);
			global::System.Reflection.MethodInfo methodInfo2 = property.Setter();
			global::System.Reflection.MethodAttributes methodAttributes2 = (methodInfo2 == null) ? global::System.Reflection.MethodAttributes.Private : (methodInfo2.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask);
			return ((methodAttributes > methodAttributes2) ? methodAttributes : methodAttributes2) == global::System.Reflection.MethodAttributes.Public;
		}
	}
}
