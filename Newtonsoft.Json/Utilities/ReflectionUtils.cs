using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000068 RID: 104
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class ReflectionUtils
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x00017BFC File Offset: 0x00015DFC
		public static bool IsVirtual(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			global::System.Reflection.MethodInfo methodInfo = propertyInfo.GetGetMethod(true);
			if (methodInfo != null && methodInfo.IsVirtual)
			{
				return true;
			}
			methodInfo = propertyInfo.GetSetMethod(true);
			return methodInfo != null && methodInfo.IsVirtual;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00017C4C File Offset: 0x00015E4C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Reflection.MethodInfo GetBaseDefinition(this global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			global::System.Reflection.MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod != null)
			{
				return getMethod.GetBaseDefinition();
			}
			global::System.Reflection.MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (setMethod == null)
			{
				return null;
			}
			return setMethod.GetBaseDefinition();
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00017C90 File Offset: 0x00015E90
		public static bool IsPublic(global::System.Reflection.PropertyInfo property)
		{
			global::System.Reflection.MethodInfo getMethod = property.GetGetMethod();
			if (getMethod != null && getMethod.IsPublic)
			{
				return true;
			}
			global::System.Reflection.MethodInfo setMethod = property.GetSetMethod();
			return setMethod != null && setMethod.IsPublic;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00017CD2 File Offset: 0x00015ED2
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Type GetObjectType(object v)
		{
			if (v == null)
			{
				return null;
			}
			return v.GetType();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00017CE0 File Offset: 0x00015EE0
		public static string GetTypeName(global::System.Type t, global::Newtonsoft.Json.TypeNameAssemblyFormatHandling assemblyFormat, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.ISerializationBinder binder)
		{
			string fullyQualifiedTypeName = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetFullyQualifiedTypeName(t, binder);
			if (assemblyFormat == global::Newtonsoft.Json.TypeNameAssemblyFormatHandling.Simple)
			{
				return global::Newtonsoft.Json.Utilities.ReflectionUtils.RemoveAssemblyDetails(fullyQualifiedTypeName);
			}
			if (assemblyFormat != global::Newtonsoft.Json.TypeNameAssemblyFormatHandling.Full)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			return fullyQualifiedTypeName;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00017D0C File Offset: 0x00015F0C
		private static string GetFullyQualifiedTypeName(global::System.Type t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.ISerializationBinder binder)
		{
			if (binder != null)
			{
				string text;
				string str;
				binder.BindToName(t, out text, out str);
				return str + ((text == null) ? "" : (", " + text));
			}
			return t.AssemblyQualifiedName;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00017D4C File Offset: 0x00015F4C
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = false;
			bool flag2 = false;
			foreach (char c in fullyQualifiedTypeName)
			{
				if (c != ',')
				{
					if (c == '[' || c == ']')
					{
						flag = false;
						flag2 = false;
						stringBuilder.Append(c);
					}
					else if (!flag2)
					{
						stringBuilder.Append(c);
					}
				}
				else if (!flag)
				{
					flag = true;
					stringBuilder.Append(c);
				}
				else
				{
					flag2 = true;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00017DC4 File Offset: 0x00015FC4
		public static bool HasDefaultConstructor(global::System.Type t, bool nonPublic)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(t, "t");
			return t.IsValueType() || global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDefaultConstructor(t, nonPublic) != null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00017DE8 File Offset: 0x00015FE8
		public static global::System.Reflection.ConstructorInfo GetDefaultConstructor(global::System.Type t)
		{
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDefaultConstructor(t, false);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public static global::System.Reflection.ConstructorInfo GetDefaultConstructor(global::System.Type t, bool nonPublic)
		{
			global::System.Reflection.BindingFlags bindingFlags = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public;
			if (nonPublic)
			{
				bindingFlags |= global::System.Reflection.BindingFlags.NonPublic;
			}
			return t.GetConstructors(bindingFlags).SingleOrDefault((global::System.Reflection.ConstructorInfo c) => !c.GetParameters().Any<global::System.Reflection.ParameterInfo>());
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00017E37 File Offset: 0x00016037
		public static bool IsNullable(global::System.Type t)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(t, "t");
			return !t.IsValueType() || global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(t);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00017E54 File Offset: 0x00016054
		public static bool IsNullableType(global::System.Type t)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(t, "t");
			return t.IsGenericType() && t.GetGenericTypeDefinition() == typeof(global::System.Nullable<>);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00017E80 File Offset: 0x00016080
		public static global::System.Type EnsureNotNullableType(global::System.Type t)
		{
			if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(t))
			{
				return t;
			}
			return global::System.Nullable.GetUnderlyingType(t);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00017E92 File Offset: 0x00016092
		public static global::System.Type EnsureNotByRefType(global::System.Type t)
		{
			if (!t.IsByRef || !t.HasElementType)
			{
				return t;
			}
			return t.GetElementType();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00017EAC File Offset: 0x000160AC
		public static bool IsGenericDefinition(global::System.Type type, global::System.Type genericInterfaceDefinition)
		{
			return type.IsGenericType() && type.GetGenericTypeDefinition() == genericInterfaceDefinition;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00017EC4 File Offset: 0x000160C4
		public static bool ImplementsGenericDefinition(global::System.Type type, global::System.Type genericInterfaceDefinition)
		{
			global::System.Type type2;
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(type, genericInterfaceDefinition, out type2);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00017EDC File Offset: 0x000160DC
		public static bool ImplementsGenericDefinition(global::System.Type type, global::System.Type genericInterfaceDefinition, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::System.Type implementingType)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(genericInterfaceDefinition, "genericInterfaceDefinition");
			if (!genericInterfaceDefinition.IsInterface() || !genericInterfaceDefinition.IsGenericTypeDefinition())
			{
				throw new global::System.ArgumentNullException("'{0}' is not a generic interface definition.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, genericInterfaceDefinition));
			}
			if (type.IsInterface() && type.IsGenericType())
			{
				global::System.Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericInterfaceDefinition == genericTypeDefinition)
				{
					implementingType = type;
					return true;
				}
			}
			foreach (global::System.Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType())
				{
					global::System.Type genericTypeDefinition2 = type2.GetGenericTypeDefinition();
					if (genericInterfaceDefinition == genericTypeDefinition2)
					{
						implementingType = type2;
						return true;
					}
				}
			}
			implementingType = null;
			return false;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00017F88 File Offset: 0x00016188
		public static bool InheritsGenericDefinition(global::System.Type type, global::System.Type genericClassDefinition)
		{
			global::System.Type type2;
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.InheritsGenericDefinition(type, genericClassDefinition, out type2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00017FA0 File Offset: 0x000161A0
		public static bool InheritsGenericDefinition(global::System.Type type, global::System.Type genericClassDefinition, [global::System.Runtime.CompilerServices.Nullable(2)] out global::System.Type implementingType)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(genericClassDefinition, "genericClassDefinition");
			if (!genericClassDefinition.IsClass() || !genericClassDefinition.IsGenericTypeDefinition())
			{
				throw new global::System.ArgumentNullException("'{0}' is not a generic class definition.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, genericClassDefinition));
			}
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.InheritsGenericDefinitionInternal(type, genericClassDefinition, out implementingType);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00017FF1 File Offset: 0x000161F1
		private static bool InheritsGenericDefinitionInternal(global::System.Type currentType, global::System.Type genericClassDefinition, [global::System.Runtime.CompilerServices.Nullable(2)] out global::System.Type implementingType)
		{
			while (!currentType.IsGenericType() || !(genericClassDefinition == currentType.GetGenericTypeDefinition()))
			{
				currentType = currentType.BaseType();
				if (!(currentType != null))
				{
					implementingType = null;
					return false;
				}
			}
			implementingType = currentType;
			return true;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00018024 File Offset: 0x00016224
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Type GetCollectionItemType(global::System.Type type)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			if (type.IsArray)
			{
				return type.GetElementType();
			}
			global::System.Type type2;
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(type, typeof(global::System.Collections.Generic.IEnumerable<>), out type2))
			{
				if (type2.IsGenericTypeDefinition())
				{
					throw new global::System.Exception("Type {0} is not a collection.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
				}
				return type2.GetGenericArguments()[0];
			}
			else
			{
				if (typeof(global::System.Collections.IEnumerable).IsAssignableFrom(type))
				{
					return null;
				}
				throw new global::System.Exception("Type {0} is not a collection.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000180B0 File Offset: 0x000162B0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static void GetDictionaryKeyValueTypes([global::System.Runtime.CompilerServices.Nullable(1)] global::System.Type dictionaryType, out global::System.Type keyType, out global::System.Type valueType)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(dictionaryType, "dictionaryType");
			global::System.Type type;
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(dictionaryType, typeof(global::System.Collections.Generic.IDictionary<, >), out type))
			{
				if (type.IsGenericTypeDefinition())
				{
					throw new global::System.Exception("Type {0} is not a dictionary.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, dictionaryType));
				}
				global::System.Type[] genericArguments = type.GetGenericArguments();
				keyType = genericArguments[0];
				valueType = genericArguments[1];
				return;
			}
			else
			{
				if (typeof(global::System.Collections.IDictionary).IsAssignableFrom(dictionaryType))
				{
					keyType = null;
					valueType = null;
					return;
				}
				throw new global::System.Exception("Type {0} is not a dictionary.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, dictionaryType));
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001813C File Offset: 0x0001633C
		public static global::System.Type GetMemberUnderlyingType(global::System.Reflection.MemberInfo member)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(member, "member");
			global::System.Reflection.MemberTypes memberTypes = member.MemberType();
			if (memberTypes <= global::System.Reflection.MemberTypes.Field)
			{
				if (memberTypes == global::System.Reflection.MemberTypes.Event)
				{
					return ((global::System.Reflection.EventInfo)member).EventHandlerType;
				}
				if (memberTypes == global::System.Reflection.MemberTypes.Field)
				{
					return ((global::System.Reflection.FieldInfo)member).FieldType;
				}
			}
			else
			{
				if (memberTypes == global::System.Reflection.MemberTypes.Method)
				{
					return ((global::System.Reflection.MethodInfo)member).ReturnType;
				}
				if (memberTypes == global::System.Reflection.MemberTypes.Property)
				{
					return ((global::System.Reflection.PropertyInfo)member).PropertyType;
				}
			}
			throw new global::System.ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "member");
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000181B4 File Offset: 0x000163B4
		public static bool IsByRefLikeType(global::System.Type type)
		{
			if (!type.IsValueType())
			{
				return false;
			}
			global::System.Attribute[] attributes = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttributes(type, null, false);
			for (int i = 0; i < attributes.Length; i++)
			{
				if (string.Equals(attributes[i].GetType().FullName, "System.Runtime.CompilerServices.IsByRefLikeAttribute", global::System.StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000181FF File Offset: 0x000163FF
		public static bool IsIndexedProperty(global::System.Reflection.PropertyInfo property)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(property, "property");
			return property.GetIndexParameters().Length != 0;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00018218 File Offset: 0x00016418
		public static object GetMemberValue(global::System.Reflection.MemberInfo member, object target)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(member, "member");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(target, "target");
			global::System.Reflection.MemberTypes memberTypes = member.MemberType();
			if (memberTypes != global::System.Reflection.MemberTypes.Field)
			{
				if (memberTypes == global::System.Reflection.MemberTypes.Property)
				{
					try
					{
						return ((global::System.Reflection.PropertyInfo)member).GetValue(target, null);
					}
					catch (global::System.Reflection.TargetParameterCountException innerException)
					{
						throw new global::System.ArgumentException("MemberInfo '{0}' has index parameters".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, member.Name), innerException);
					}
				}
				throw new global::System.ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, member.Name), "member");
			}
			return ((global::System.Reflection.FieldInfo)member).GetValue(target);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000182BC File Offset: 0x000164BC
		public static void SetMemberValue(global::System.Reflection.MemberInfo member, object target, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(member, "member");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(target, "target");
			global::System.Reflection.MemberTypes memberTypes = member.MemberType();
			if (memberTypes == global::System.Reflection.MemberTypes.Field)
			{
				((global::System.Reflection.FieldInfo)member).SetValue(target, value);
				return;
			}
			if (memberTypes != global::System.Reflection.MemberTypes.Property)
			{
				throw new global::System.ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, member.Name), "member");
			}
			((global::System.Reflection.PropertyInfo)member).SetValue(target, value, null);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00018330 File Offset: 0x00016530
		public static bool CanReadMemberValue(global::System.Reflection.MemberInfo member, bool nonPublic)
		{
			global::System.Reflection.MemberTypes memberTypes = member.MemberType();
			if (memberTypes == global::System.Reflection.MemberTypes.Field)
			{
				global::System.Reflection.FieldInfo fieldInfo = (global::System.Reflection.FieldInfo)member;
				return nonPublic || fieldInfo.IsPublic;
			}
			if (memberTypes != global::System.Reflection.MemberTypes.Property)
			{
				return false;
			}
			global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)member;
			return propertyInfo.CanRead && (nonPublic || propertyInfo.GetGetMethod(nonPublic) != null);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001838C File Offset: 0x0001658C
		public static bool CanSetMemberValue(global::System.Reflection.MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			global::System.Reflection.MemberTypes memberTypes = member.MemberType();
			if (memberTypes == global::System.Reflection.MemberTypes.Field)
			{
				global::System.Reflection.FieldInfo fieldInfo = (global::System.Reflection.FieldInfo)member;
				return !fieldInfo.IsLiteral && (!fieldInfo.IsInitOnly || canSetReadOnly) && (nonPublic || fieldInfo.IsPublic);
			}
			if (memberTypes != global::System.Reflection.MemberTypes.Property)
			{
				return false;
			}
			global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)member;
			return propertyInfo.CanWrite && (nonPublic || propertyInfo.GetSetMethod(nonPublic) != null);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00018400 File Offset: 0x00016600
		public static global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> GetFieldsAndProperties(global::System.Type type, global::System.Reflection.BindingFlags bindingAttr)
		{
			global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>();
			list.AddRange(global::Newtonsoft.Json.Utilities.ReflectionUtils.GetFields(type, bindingAttr));
			list.AddRange(global::Newtonsoft.Json.Utilities.ReflectionUtils.GetProperties(type, bindingAttr));
			global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list2 = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>(list.Count);
			foreach (global::System.Linq.IGrouping<string, global::System.Reflection.MemberInfo> grouping in from m in list
			group m by m.Name)
			{
				if (grouping.Count<global::System.Reflection.MemberInfo>() == 1)
				{
					list2.Add(grouping.First<global::System.Reflection.MemberInfo>());
				}
				else
				{
					global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list3 = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>();
					using (global::System.Collections.Generic.IEnumerator<global::System.Reflection.MemberInfo> enumerator2 = grouping.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Reflection.MemberInfo memberInfo = enumerator2.Current;
							if (list3.Count == 0)
							{
								list3.Add(memberInfo);
							}
							else if ((!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsOverridenGenericMember(memberInfo, bindingAttr) || memberInfo.Name == "Item") && !list3.Any((global::System.Reflection.MemberInfo m) => m.DeclaringType == memberInfo.DeclaringType))
							{
								list3.Add(memberInfo);
							}
						}
					}
					list2.AddRange(list3);
				}
			}
			return list2;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00018560 File Offset: 0x00016760
		private static bool IsOverridenGenericMember(global::System.Reflection.MemberInfo memberInfo, global::System.Reflection.BindingFlags bindingAttr)
		{
			if (memberInfo.MemberType() != global::System.Reflection.MemberTypes.Property)
			{
				return false;
			}
			global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)memberInfo;
			if (!propertyInfo.IsVirtual())
			{
				return false;
			}
			global::System.Type declaringType = propertyInfo.DeclaringType;
			if (!declaringType.IsGenericType())
			{
				return false;
			}
			global::System.Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			global::System.Reflection.MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, bindingAttr);
			return member.Length != 0 && global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(member[0]).IsGenericParameter;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000185D3 File Offset: 0x000167D3
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T GetAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(object attributeProvider) where T : global::System.Attribute
		{
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(attributeProvider, true);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000185DC File Offset: 0x000167DC
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T GetAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(object attributeProvider, bool inherit) where T : global::System.Attribute
		{
			T[] attributes = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttributes<T>(attributeProvider, inherit);
			if (attributes == null)
			{
				return default(T);
			}
			return attributes.FirstOrDefault<T>();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00018604 File Offset: 0x00016804
		public static T[] GetAttributes<[global::System.Runtime.CompilerServices.Nullable(0)] T>(object attributeProvider, bool inherit) where T : global::System.Attribute
		{
			global::System.Attribute[] attributes = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttributes(attributeProvider, typeof(T), inherit);
			T[] array = attributes as T[];
			if (array != null)
			{
				return array;
			}
			return attributes.Cast<T>().ToArray<T>();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001863C File Offset: 0x0001683C
		public static global::System.Attribute[] GetAttributes(object attributeProvider, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Type attributeType, bool inherit)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(attributeProvider, "attributeProvider");
			global::System.Type type = attributeProvider as global::System.Type;
			if (type != null)
			{
				return ((attributeType != null) ? type.GetCustomAttributes(attributeType, inherit) : type.GetCustomAttributes(inherit)).Cast<global::System.Attribute>().ToArray<global::System.Attribute>();
			}
			global::System.Reflection.Assembly assembly = attributeProvider as global::System.Reflection.Assembly;
			if (assembly == null)
			{
				global::System.Reflection.MemberInfo memberInfo = attributeProvider as global::System.Reflection.MemberInfo;
				if (memberInfo == null)
				{
					global::System.Reflection.Module module = attributeProvider as global::System.Reflection.Module;
					if (module == null)
					{
						global::System.Reflection.ParameterInfo parameterInfo = attributeProvider as global::System.Reflection.ParameterInfo;
						if (parameterInfo == null)
						{
							global::System.Reflection.ICustomAttributeProvider customAttributeProvider = (global::System.Reflection.ICustomAttributeProvider)attributeProvider;
							return (global::System.Attribute[])((attributeType != null) ? customAttributeProvider.GetCustomAttributes(attributeType, inherit) : customAttributeProvider.GetCustomAttributes(inherit));
						}
						if (!(attributeType != null))
						{
							return global::System.Attribute.GetCustomAttributes(parameterInfo, inherit);
						}
						return global::System.Attribute.GetCustomAttributes(parameterInfo, attributeType, inherit);
					}
					else
					{
						if (!(attributeType != null))
						{
							return global::System.Attribute.GetCustomAttributes(module, inherit);
						}
						return global::System.Attribute.GetCustomAttributes(module, attributeType, inherit);
					}
				}
				else
				{
					if (!(attributeType != null))
					{
						return global::System.Attribute.GetCustomAttributes(memberInfo, inherit);
					}
					return global::System.Attribute.GetCustomAttributes(memberInfo, attributeType, inherit);
				}
			}
			else
			{
				if (!(attributeType != null))
				{
					return global::System.Attribute.GetCustomAttributes(assembly);
				}
				return global::System.Attribute.GetCustomAttributes(assembly, attributeType);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001874C File Offset: 0x0001694C
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			2,
			1
		})]
		public static global::Newtonsoft.Json.Utilities.StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			int? assemblyDelimiterIndex = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAssemblyDelimiterIndex(fullyQualifiedTypeName);
			string v;
			string v2;
			if (assemblyDelimiterIndex != null)
			{
				v = fullyQualifiedTypeName.Trim(0, assemblyDelimiterIndex.GetValueOrDefault());
				v2 = fullyQualifiedTypeName.Trim(assemblyDelimiterIndex.GetValueOrDefault() + 1, fullyQualifiedTypeName.Length - assemblyDelimiterIndex.GetValueOrDefault() - 1);
			}
			else
			{
				v = fullyQualifiedTypeName;
				v2 = null;
			}
			return new global::Newtonsoft.Json.Utilities.StructMultiKey<string, string>(v2, v);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000187A8 File Offset: 0x000169A8
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			int num = 0;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char c = fullyQualifiedTypeName[i];
				if (c != ',')
				{
					if (c != '[')
					{
						if (c == ']')
						{
							num--;
						}
					}
					else
					{
						num++;
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00018800 File Offset: 0x00016A00
		public static global::System.Reflection.MemberInfo GetMemberInfoFromType(global::System.Type targetType, global::System.Reflection.MemberInfo memberInfo)
		{
			if (memberInfo.MemberType() == global::System.Reflection.MemberTypes.Property)
			{
				global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)memberInfo;
				global::System.Type[] types = (from p in propertyInfo.GetIndexParameters()
				select p.ParameterType).ToArray<global::System.Type>();
				return targetType.GetProperty(propertyInfo.Name, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
			}
			return targetType.GetMember(memberInfo.Name, memberInfo.MemberType(), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).SingleOrDefault<global::System.Reflection.MemberInfo>();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001887F File Offset: 0x00016A7F
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.FieldInfo> GetFields(global::System.Type targetType, global::System.Reflection.BindingFlags bindingAttr)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(targetType, "targetType");
			global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>(targetType.GetFields(bindingAttr));
			global::Newtonsoft.Json.Utilities.ReflectionUtils.GetChildPrivateFields(list, targetType, bindingAttr);
			return list.Cast<global::System.Reflection.FieldInfo>();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000188A8 File Offset: 0x00016AA8
		private static void GetChildPrivateFields(global::System.Collections.Generic.IList<global::System.Reflection.MemberInfo> initialFields, global::System.Type targetType, global::System.Reflection.BindingFlags bindingAttr)
		{
			if ((bindingAttr & global::System.Reflection.BindingFlags.NonPublic) != global::System.Reflection.BindingFlags.Default)
			{
				global::System.Reflection.BindingFlags bindingAttr2 = bindingAttr.RemoveFlag(global::System.Reflection.BindingFlags.Public);
				while ((targetType = targetType.BaseType()) != null)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Reflection.FieldInfo> collection = from f in targetType.GetFields(bindingAttr2)
					where f.IsPrivate
					select f;
					initialFields.AddRange(collection);
				}
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001890C File Offset: 0x00016B0C
		public static global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetProperties(global::System.Type targetType, global::System.Reflection.BindingFlags bindingAttr)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(targetType, "targetType");
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>(targetType.GetProperties(bindingAttr));
			if (targetType.IsInterface())
			{
				foreach (global::System.Type type in targetType.GetInterfaces())
				{
					list.AddRange(type.GetProperties(bindingAttr));
				}
			}
			global::Newtonsoft.Json.Utilities.ReflectionUtils.GetChildPrivateProperties(list, targetType, bindingAttr);
			for (int j = 0; j < list.Count; j++)
			{
				global::System.Reflection.PropertyInfo propertyInfo = list[j];
				if (propertyInfo.DeclaringType != targetType)
				{
					global::System.Reflection.PropertyInfo value = (global::System.Reflection.PropertyInfo)global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberInfoFromType(propertyInfo.DeclaringType, propertyInfo);
					list[j] = value;
				}
			}
			return list;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000189B5 File Offset: 0x00016BB5
		public static global::System.Reflection.BindingFlags RemoveFlag(this global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.BindingFlags flag)
		{
			if ((bindingAttr & flag) != flag)
			{
				return bindingAttr;
			}
			return bindingAttr ^ flag;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000189C4 File Offset: 0x00016BC4
		private static void GetChildPrivateProperties(global::System.Collections.Generic.IList<global::System.Reflection.PropertyInfo> initialProperties, global::System.Type targetType, global::System.Reflection.BindingFlags bindingAttr)
		{
			while ((targetType = targetType.BaseType()) != null)
			{
				foreach (global::System.Reflection.PropertyInfo subTypeProperty in targetType.GetProperties(bindingAttr))
				{
					global::Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1 = new global::Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0();
					CS$<>8__locals1.subTypeProperty = subTypeProperty;
					if (!CS$<>8__locals1.subTypeProperty.IsVirtual())
					{
						if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsPublic(CS$<>8__locals1.subTypeProperty))
						{
							int num = initialProperties.IndexOf((global::System.Reflection.PropertyInfo p) => p.Name == CS$<>8__locals1.subTypeProperty.Name);
							if (num == -1)
							{
								initialProperties.Add(CS$<>8__locals1.subTypeProperty);
							}
							else if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsPublic(initialProperties[num]))
							{
								initialProperties[num] = CS$<>8__locals1.subTypeProperty;
							}
						}
						else if (initialProperties.IndexOf((global::System.Reflection.PropertyInfo p) => p.Name == CS$<>8__locals1.subTypeProperty.Name && p.DeclaringType == CS$<>8__locals1.subTypeProperty.DeclaringType) == -1)
						{
							initialProperties.Add(CS$<>8__locals1.subTypeProperty);
						}
					}
					else
					{
						global::Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_1 CS$<>8__locals2 = new global::Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						global::Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_1 CS$<>8__locals3 = CS$<>8__locals2;
						global::System.Reflection.MethodInfo baseDefinition = CS$<>8__locals2.CS$<>8__locals1.subTypeProperty.GetBaseDefinition();
						CS$<>8__locals3.subTypePropertyDeclaringType = (((baseDefinition != null) ? baseDefinition.DeclaringType : null) ?? CS$<>8__locals2.CS$<>8__locals1.subTypeProperty.DeclaringType);
						if (initialProperties.IndexOf(delegate(global::System.Reflection.PropertyInfo p)
						{
							if (p.Name == CS$<>8__locals2.CS$<>8__locals1.subTypeProperty.Name && p.IsVirtual())
							{
								global::System.Reflection.MethodInfo baseDefinition2 = p.GetBaseDefinition();
								return (((baseDefinition2 != null) ? baseDefinition2.DeclaringType : null) ?? p.DeclaringType).IsAssignableFrom(CS$<>8__locals2.subTypePropertyDeclaringType);
							}
							return false;
						}) == -1)
						{
							initialProperties.Add(CS$<>8__locals2.CS$<>8__locals1.subTypeProperty);
						}
					}
				}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00018B14 File Offset: 0x00016D14
		public static bool IsMethodOverridden(global::System.Type currentType, global::System.Type methodDeclaringType, string method)
		{
			return currentType.GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Any((global::System.Reflection.MethodInfo info) => info.Name == method && info.DeclaringType != methodDeclaringType && info.GetBaseDefinition().DeclaringType == methodDeclaringType);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018B50 File Offset: 0x00016D50
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object GetDefaultValue(global::System.Type type)
		{
			if (!type.IsValueType())
			{
				return null;
			}
			global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(type);
			switch (typeCode)
			{
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
				return 0;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.CharNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BooleanNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByteNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.ByteNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64Nullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DecimalNullable:
				break;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
				return false;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
				return 0L;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
				return 0f;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
				return 0.0;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
				return default(global::System.DateTime);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
				return default(global::System.DateTimeOffset);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
				return 0m;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
				return default(global::System.Guid);
			default:
				if (typeCode == global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger)
				{
					return default(global::System.Numerics.BigInteger);
				}
				break;
			}
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(type))
			{
				return null;
			}
			return global::System.Activator.CreateInstance(type);
		}

		// Token: 0x04000200 RID: 512
		public static readonly global::System.Type[] EmptyTypes = global::System.Type.EmptyTypes;
	}
}
