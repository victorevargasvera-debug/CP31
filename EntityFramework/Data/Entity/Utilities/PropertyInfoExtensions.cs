using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008E RID: 142
	internal static class PropertyInfoExtensions
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		public static bool IsSameAs(this global::System.Reflection.PropertyInfo propertyInfo, global::System.Reflection.PropertyInfo otherPropertyInfo)
		{
			return propertyInfo == otherPropertyInfo || (propertyInfo.Name == otherPropertyInfo.Name && (propertyInfo.DeclaringType == otherPropertyInfo.DeclaringType || propertyInfo.DeclaringType.IsSubclassOf(otherPropertyInfo.DeclaringType) || otherPropertyInfo.DeclaringType.IsSubclassOf(propertyInfo.DeclaringType) || propertyInfo.DeclaringType.GetInterfaces().Contains(otherPropertyInfo.DeclaringType) || otherPropertyInfo.DeclaringType.GetInterfaces().Contains(propertyInfo.DeclaringType)));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000FB82 File Offset: 0x0000DD82
		public static bool ContainsSame(this global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable, global::System.Reflection.PropertyInfo propertyInfo)
		{
			return enumerable.Any(new global::System.Func<global::System.Reflection.PropertyInfo, bool>(propertyInfo.IsSameAs));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000FB96 File Offset: 0x0000DD96
		public static bool IsValidStructuralProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.IsValidInterfaceStructuralProperty() && !propertyInfo.Getter().IsAbstract;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		public static bool IsValidInterfaceStructuralProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.CanRead && (propertyInfo.CanWriteExtended() || propertyInfo.PropertyType.IsCollection()) && propertyInfo.GetIndexParameters().Length == 0 && propertyInfo.PropertyType.IsValidStructuralPropertyType();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000FBE5 File Offset: 0x0000DDE5
		public static bool IsValidEdmScalarProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			return propertyInfo.IsValidInterfaceStructuralProperty() && propertyInfo.PropertyType.IsValidEdmScalarType();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public static bool IsValidEdmNavigationProperty(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Type type;
			return propertyInfo.IsValidInterfaceStructuralProperty() && ((propertyInfo.PropertyType.IsCollection(out type) && type.IsValidStructuralType()) || propertyInfo.PropertyType.IsValidStructuralType());
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000FC38 File Offset: 0x0000DE38
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

		// Token: 0x06000487 RID: 1159 RVA: 0x0000FC84 File Offset: 0x0000DE84
		public static bool CanWriteExtended(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (propertyInfo.CanWrite)
			{
				return true;
			}
			global::System.Reflection.PropertyInfo declaredProperty = global::System.Data.Entity.Utilities.PropertyInfoExtensions.GetDeclaredProperty(propertyInfo);
			return declaredProperty != null && declaredProperty.CanWrite;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
		public static global::System.Reflection.PropertyInfo GetPropertyInfoForSet(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.PropertyInfo result;
			if (!propertyInfo.CanWrite)
			{
				if ((result = global::System.Data.Entity.Utilities.PropertyInfoExtensions.GetDeclaredProperty(propertyInfo)) == null)
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

		// Token: 0x06000489 RID: 1161 RVA: 0x0000FCCC File Offset: 0x0000DECC
		private static global::System.Reflection.PropertyInfo GetDeclaredProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			if (!(propertyInfo.DeclaringType == propertyInfo.ReflectedType))
			{
				return propertyInfo.DeclaringType.GetInstanceProperties().SingleOrDefault((global::System.Reflection.PropertyInfo p) => p.Name == propertyInfo.Name && p.DeclaringType == propertyInfo.DeclaringType && !p.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>() && p.PropertyType == propertyInfo.PropertyType);
			}
			return propertyInfo;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetPropertiesInHierarchy(this global::System.Reflection.PropertyInfo property)
		{
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>
			{
				property
			};
			global::System.Data.Entity.Utilities.PropertyInfoExtensions.CollectProperties(property, list);
			return list.Distinct<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000FD53 File Offset: 0x0000DF53
		private static void CollectProperties(global::System.Reflection.PropertyInfo property, global::System.Collections.Generic.IList<global::System.Reflection.PropertyInfo> collection)
		{
			global::System.Data.Entity.Utilities.PropertyInfoExtensions.FindNextProperty(property, collection, true);
			global::System.Data.Entity.Utilities.PropertyInfoExtensions.FindNextProperty(property, collection, false);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000FD68 File Offset: 0x0000DF68
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
						global::System.Data.Entity.Utilities.PropertyInfoExtensions.CollectProperties(propertyInfo, collection);
					}
				}
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000FE4E File Offset: 0x0000E04E
		public static global::System.Reflection.MethodInfo Getter(this global::System.Reflection.PropertyInfo property)
		{
			return property.GetMethod;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000FE56 File Offset: 0x0000E056
		public static global::System.Reflection.MethodInfo Setter(this global::System.Reflection.PropertyInfo property)
		{
			return property.SetMethod;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000FE5E File Offset: 0x0000E05E
		public static bool IsStatic(this global::System.Reflection.PropertyInfo property)
		{
			return (property.Getter() ?? property.Setter()).IsStatic;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000FE78 File Offset: 0x0000E078
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
