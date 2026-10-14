using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000469 RID: 1129
	internal static class TypeSystem
	{
		// Token: 0x06003797 RID: 14231 RVA: 0x000B51CC File Offset: 0x000B33CC
		private static T GetDefault<T>()
		{
			return default(T);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000B51E4 File Offset: 0x000B33E4
		internal static object GetDefaultValue(global::System.Type type)
		{
			if (!type.IsValueType() || (type.IsGenericType() && typeof(global::System.Nullable<>) == type.GetGenericTypeDefinition()))
			{
				return null;
			}
			return global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDefaultMethod.MakeGenericMethod(new global::System.Type[]
			{
				type
			}).Invoke(null, new object[0]);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000B523A File Offset: 0x000B343A
		internal static bool IsSequenceType(global::System.Type seqType)
		{
			return global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.FindIEnumerable(seqType) != null;
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x000B5248 File Offset: 0x000B3448
		internal static global::System.Type GetDelegateType(global::System.Collections.Generic.IEnumerable<global::System.Type> inputTypes, global::System.Type returnType)
		{
			inputTypes = (inputTypes ?? global::System.Linq.Enumerable.Empty<global::System.Type>());
			int num = inputTypes.Count<global::System.Type>();
			global::System.Type[] array = new global::System.Type[num + 1];
			int num2 = 0;
			foreach (global::System.Type type in inputTypes)
			{
				array[num2++] = type;
			}
			array[num2] = returnType;
			global::System.Type type2;
			switch (num)
			{
			case 0:
				type2 = typeof(global::System.Func<>);
				break;
			case 1:
				type2 = typeof(global::System.Func<, >);
				break;
			case 2:
				type2 = typeof(global::System.Func<, , >);
				break;
			case 3:
				type2 = typeof(global::System.Func<, , , >);
				break;
			case 4:
				type2 = typeof(global::System.Func<, , , , >);
				break;
			case 5:
				type2 = typeof(global::System.Func<, , , , , >);
				break;
			case 6:
				type2 = typeof(global::System.Func<, , , , , , >);
				break;
			case 7:
				type2 = typeof(global::System.Func<, , , , , , , >);
				break;
			case 8:
				type2 = typeof(global::System.Func<, , , , , , , , >);
				break;
			case 9:
				type2 = typeof(global::System.Func<, , , , , , , , , >);
				break;
			case 10:
				type2 = typeof(global::System.Func<, , , , , , , , , , >);
				break;
			case 11:
				type2 = typeof(global::System.Func<, , , , , , , , , , , >);
				break;
			case 12:
				type2 = typeof(global::System.Func<, , , , , , , , , , , , >);
				break;
			case 13:
				type2 = typeof(global::System.Func<, , , , , , , , , , , , , >);
				break;
			case 14:
				type2 = typeof(global::System.Func<, , , , , , , , , , , , , , >);
				break;
			case 15:
				type2 = typeof(global::System.Func<, , , , , , , , , , , , , , , >);
				break;
			default:
				type2 = null;
				break;
			}
			return type2.MakeGenericType(array);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x000B53F4 File Offset: 0x000B35F4
		internal static global::System.Linq.Expressions.Expression EnsureType(global::System.Linq.Expressions.Expression expression, global::System.Type requiredType)
		{
			if (expression.Type != requiredType)
			{
				expression = global::System.Linq.Expressions.Expression.Convert(expression, requiredType);
			}
			return expression;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x000B5410 File Offset: 0x000B3610
		internal static global::System.Reflection.MemberInfo PropertyOrField(global::System.Reflection.MemberInfo member, out string name, out global::System.Type type)
		{
			name = null;
			type = null;
			if (member.MemberType == global::System.Reflection.MemberTypes.Field)
			{
				global::System.Reflection.FieldInfo fieldInfo = (global::System.Reflection.FieldInfo)member;
				name = fieldInfo.Name;
				type = fieldInfo.FieldType;
				return fieldInfo;
			}
			if (member.MemberType != global::System.Reflection.MemberTypes.Property)
			{
				if (member.MemberType == global::System.Reflection.MemberTypes.Method)
				{
					global::System.Reflection.MethodInfo methodInfo = (global::System.Reflection.MethodInfo)member;
					if (methodInfo.IsSpecialName)
					{
						foreach (global::System.Reflection.PropertyInfo propertyInfo in methodInfo.DeclaringType.GetRuntimeProperties())
						{
							if (propertyInfo.CanRead && propertyInfo.Getter() == methodInfo)
							{
								return global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.PropertyOrField(propertyInfo, out name, out type);
							}
						}
					}
				}
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_NotPropertyOrField(member.Name));
			}
			global::System.Reflection.PropertyInfo propertyInfo2 = (global::System.Reflection.PropertyInfo)member;
			if (propertyInfo2.GetIndexParameters().Length != 0)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_PropertyIndexNotSupported);
			}
			name = propertyInfo2.Name;
			type = propertyInfo2.PropertyType;
			return propertyInfo2;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000B550C File Offset: 0x000B370C
		private static global::System.Type FindIEnumerable(global::System.Type seqType)
		{
			if (seqType == null || seqType == typeof(string) || seqType == typeof(byte[]))
			{
				return null;
			}
			if (seqType.IsArray)
			{
				return typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					seqType.GetElementType()
				});
			}
			if (seqType.IsGenericType())
			{
				foreach (global::System.Type type in seqType.GetGenericArguments())
				{
					global::System.Type type2 = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
					{
						type
					});
					if (type2.IsAssignableFrom(seqType))
					{
						return type2;
					}
				}
			}
			global::System.Type[] interfaces = seqType.GetInterfaces();
			if (interfaces != null && interfaces.Length != 0)
			{
				global::System.Type[] array = interfaces;
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Type type3 = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.FindIEnumerable(array[i]);
					if (type3 != null)
					{
						return type3;
					}
				}
			}
			if (seqType.BaseType() != null && seqType.BaseType() != typeof(object))
			{
				return global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.FindIEnumerable(seqType.BaseType());
			}
			return null;
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000B5620 File Offset: 0x000B3820
		internal static global::System.Type GetElementType(global::System.Type seqType)
		{
			global::System.Type type = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.FindIEnumerable(seqType);
			if (type == null)
			{
				return seqType;
			}
			return type.GetGenericArguments()[0];
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000B5647 File Offset: 0x000B3847
		internal static global::System.Type GetNonNullableType(global::System.Type type)
		{
			if (type != null)
			{
				return global::System.Nullable.GetUnderlyingType(type) ?? type;
			}
			return null;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000B5660 File Offset: 0x000B3860
		internal static bool IsImplementationOfGenericInterfaceMethod(this global::System.Reflection.MethodInfo test, global::System.Type match, out global::System.Type[] genericTypeArguments)
		{
			genericTypeArguments = null;
			if (null == test || null == match || !match.IsInterface() || !match.IsGenericTypeDefinition() || null == test.DeclaringType)
			{
				return false;
			}
			if (test.DeclaringType.IsInterface() && test.DeclaringType.IsGenericType() && test.DeclaringType.GetGenericTypeDefinition() == match)
			{
				return true;
			}
			foreach (global::System.Type type in test.DeclaringType.GetInterfaces())
			{
				if (type.IsGenericType() && type.GetGenericTypeDefinition() == match && test.DeclaringType.GetInterfaceMap(type).TargetMethods.Contains(test))
				{
					genericTypeArguments = type.GetGenericArguments();
					return true;
				}
			}
			return false;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000B572C File Offset: 0x000B392C
		internal static bool IsImplementationOf(this global::System.Reflection.PropertyInfo propertyInfo, global::System.Type interfaceType)
		{
			global::System.Reflection.PropertyInfo declaredProperty = interfaceType.GetDeclaredProperty(propertyInfo.Name);
			if (null == declaredProperty)
			{
				return false;
			}
			if (propertyInfo.DeclaringType.IsInterface())
			{
				return declaredProperty.Equals(propertyInfo);
			}
			bool result = false;
			global::System.Reflection.MethodInfo value = declaredProperty.Getter();
			global::System.Reflection.InterfaceMapping interfaceMap = propertyInfo.DeclaringType.GetInterfaceMap(interfaceType);
			int num = global::System.Array.IndexOf<global::System.Reflection.MethodInfo>(interfaceMap.InterfaceMethods, value);
			global::System.Reflection.MethodInfo[] targetMethods = interfaceMap.TargetMethods;
			if (num > -1 && num < targetMethods.Length)
			{
				global::System.Reflection.MethodInfo methodInfo = propertyInfo.Getter();
				if (methodInfo != null)
				{
					result = methodInfo.Equals(targetMethods[num]);
				}
			}
			return result;
		}

		// Token: 0x040012D0 RID: 4816
		internal static readonly global::System.Reflection.MethodInfo GetDefaultMethod = typeof(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem).GetOnlyDeclaredMethod("GetDefault");
	}
}
