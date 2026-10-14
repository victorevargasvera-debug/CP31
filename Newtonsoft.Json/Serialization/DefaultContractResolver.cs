using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000074 RID: 116
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DefaultContractResolver : global::Newtonsoft.Json.Serialization.IContractResolver
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00019715 File Offset: 0x00017915
		internal static global::Newtonsoft.Json.Serialization.IContractResolver Instance
		{
			get
			{
				return global::Newtonsoft.Json.Serialization.DefaultContractResolver._instance;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001971C File Offset: 0x0001791C
		public bool DynamicCodeGeneration
		{
			get
			{
				return global::Newtonsoft.Json.Serialization.JsonTypeReflector.DynamicCodeGeneration;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00019723 File Offset: 0x00017923
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0001972B File Offset: 0x0001792B
		[global::System.Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public global::System.Reflection.BindingFlags DefaultMembersSearchFlags { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00019734 File Offset: 0x00017934
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0001973C File Offset: 0x0001793C
		public bool SerializeCompilerGeneratedMembers { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00019745 File Offset: 0x00017945
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0001974D File Offset: 0x0001794D
		public bool IgnoreSerializableInterface { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00019756 File Offset: 0x00017956
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0001975E File Offset: 0x0001795E
		public bool IgnoreSerializableAttribute { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00019767 File Offset: 0x00017967
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0001976F File Offset: 0x0001796F
		public bool IgnoreIsSpecifiedMembers { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00019778 File Offset: 0x00017978
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00019780 File Offset: 0x00017980
		public bool IgnoreShouldSerializeMembers { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00019789 File Offset: 0x00017989
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00019791 File Offset: 0x00017991
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Serialization.NamingStrategy NamingStrategy { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] set; }

		// Token: 0x06000621 RID: 1569 RVA: 0x0001979A File Offset: 0x0001799A
		public DefaultContractResolver()
		{
			this.IgnoreSerializableAttribute = true;
			this.DefaultMembersSearchFlags = (global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
			this._contractCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Serialization.JsonContract>(new global::System.Func<global::System.Type, global::Newtonsoft.Json.Serialization.JsonContract>(this.CreateContract));
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000197D4 File Offset: 0x000179D4
		public virtual global::Newtonsoft.Json.Serialization.JsonContract ResolveContract(global::System.Type type)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			return this._contractCache.Get(type);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000197F0 File Offset: 0x000179F0
		private static bool FilterMembers(global::System.Reflection.MemberInfo member)
		{
			global::System.Reflection.PropertyInfo propertyInfo = member as global::System.Reflection.PropertyInfo;
			if (propertyInfo != null)
			{
				return !global::Newtonsoft.Json.Utilities.ReflectionUtils.IsIndexedProperty(propertyInfo) && !global::Newtonsoft.Json.Utilities.ReflectionUtils.IsByRefLikeType(propertyInfo.PropertyType);
			}
			global::System.Reflection.FieldInfo fieldInfo = member as global::System.Reflection.FieldInfo;
			return fieldInfo == null || !global::Newtonsoft.Json.Utilities.ReflectionUtils.IsByRefLikeType(fieldInfo.FieldType);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001983C File Offset: 0x00017A3C
		protected virtual global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> GetSerializableMembers(global::System.Type objectType)
		{
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			global::Newtonsoft.Json.MemberSerialization objectMemberSerialization = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetObjectMemberSerialization(objectType, ignoreSerializableAttribute);
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.MemberInfo> enumerable = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetFieldsAndProperties(objectType, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(delegate(global::System.Reflection.MemberInfo m)
			{
				global::System.Reflection.PropertyInfo propertyInfo = m as global::System.Reflection.PropertyInfo;
				return propertyInfo == null || !global::Newtonsoft.Json.Utilities.ReflectionUtils.IsIndexedProperty(propertyInfo);
			});
			global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>();
			if (objectMemberSerialization != global::Newtonsoft.Json.MemberSerialization.Fields)
			{
				global::System.Runtime.Serialization.DataContractAttribute dataContractAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetDataContractAttribute(objectType);
				global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list2 = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetFieldsAndProperties(objectType, this.DefaultMembersSearchFlags).Where(new global::System.Func<global::System.Reflection.MemberInfo, bool>(global::Newtonsoft.Json.Serialization.DefaultContractResolver.FilterMembers)).ToList<global::System.Reflection.MemberInfo>();
				foreach (global::System.Reflection.MemberInfo memberInfo in enumerable)
				{
					if (this.SerializeCompilerGeneratedMembers || !memberInfo.IsDefined(typeof(global::System.Runtime.CompilerServices.CompilerGeneratedAttribute), true))
					{
						if (list2.Contains(memberInfo))
						{
							list.Add(memberInfo);
						}
						else if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonPropertyAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonRequiredAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (dataContractAttribute != null && global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::System.Runtime.Serialization.DataMemberAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (objectMemberSerialization == global::Newtonsoft.Json.MemberSerialization.Fields && memberInfo.MemberType() == global::System.Reflection.MemberTypes.Field)
						{
							list.Add(memberInfo);
						}
					}
				}
				global::System.Type type;
				if (objectType.AssignableToTypeName("System.Data.Objects.DataClasses.EntityObject", false, out type))
				{
					list = list.Where(new global::System.Func<global::System.Reflection.MemberInfo, bool>(this.ShouldSerializeEntityMember)).ToList<global::System.Reflection.MemberInfo>();
				}
				if (typeof(global::System.Exception).IsAssignableFrom(objectType))
				{
					list = (from m in list
					where !string.Equals(m.Name, "TargetSite", global::System.StringComparison.Ordinal)
					select m).ToList<global::System.Reflection.MemberInfo>();
				}
			}
			else
			{
				foreach (global::System.Reflection.MemberInfo memberInfo2 in enumerable)
				{
					global::System.Reflection.FieldInfo fieldInfo = memberInfo2 as global::System.Reflection.FieldInfo;
					if (fieldInfo != null && !fieldInfo.IsStatic)
					{
						list.Add(memberInfo2);
					}
				}
			}
			return list;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00019A40 File Offset: 0x00017C40
		private bool ShouldSerializeEntityMember(global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
			return propertyInfo == null || !propertyInfo.PropertyType.IsGenericType() || !(propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1");
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00019A84 File Offset: 0x00017C84
		protected virtual global::Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonObjectContract jsonObjectContract = new global::Newtonsoft.Json.Serialization.JsonObjectContract(objectType);
			this.InitializeContract(jsonObjectContract);
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			jsonObjectContract.MemberSerialization = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetObjectMemberSerialization(jsonObjectContract.NonNullableUnderlyingType, ignoreSerializableAttribute);
			jsonObjectContract.Properties.AddRange(this.CreateProperties(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.MemberSerialization));
			global::System.Func<string, string> func = null;
			global::Newtonsoft.Json.JsonObjectAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonObjectAttribute>(jsonObjectContract.NonNullableUnderlyingType);
			if (cachedAttribute != null)
			{
				jsonObjectContract.ItemRequired = cachedAttribute._itemRequired;
				jsonObjectContract.ItemNullValueHandling = cachedAttribute._itemNullValueHandling;
				jsonObjectContract.MissingMemberHandling = cachedAttribute._missingMemberHandling;
				if (cachedAttribute.NamingStrategyType != null)
				{
					global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetContainerNamingStrategy(cachedAttribute);
					func = ((string s) => namingStrategy.GetDictionaryKey(s));
				}
			}
			if (func == null)
			{
				func = new global::System.Func<string, string>(this.ResolveExtensionDataName);
			}
			jsonObjectContract.ExtensionDataNameResolver = func;
			if (jsonObjectContract.IsInstantiable)
			{
				global::System.Reflection.ConstructorInfo attributeConstructor = this.GetAttributeConstructor(jsonObjectContract.NonNullableUnderlyingType);
				if (attributeConstructor != null)
				{
					jsonObjectContract.OverrideCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(attributeConstructor);
					jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(attributeConstructor, jsonObjectContract.Properties));
				}
				else if (jsonObjectContract.MemberSerialization == global::Newtonsoft.Json.MemberSerialization.Fields)
				{
					if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.FullyTrusted)
					{
						jsonObjectContract.DefaultCreator = new global::System.Func<object>(jsonObjectContract.GetUninitializedObject);
					}
				}
				else if (jsonObjectContract.DefaultCreator == null || jsonObjectContract.DefaultCreatorNonPublic)
				{
					global::System.Reflection.ConstructorInfo parameterizedConstructor = this.GetParameterizedConstructor(jsonObjectContract.NonNullableUnderlyingType);
					if (parameterizedConstructor != null)
					{
						jsonObjectContract.ParameterizedCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(parameterizedConstructor);
						jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(parameterizedConstructor, jsonObjectContract.Properties));
					}
				}
				else if (jsonObjectContract.NonNullableUnderlyingType.IsValueType())
				{
					global::System.Reflection.ConstructorInfo immutableConstructor = this.GetImmutableConstructor(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.Properties);
					if (immutableConstructor != null)
					{
						jsonObjectContract.OverrideCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(immutableConstructor);
						jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(immutableConstructor, jsonObjectContract.Properties));
					}
				}
			}
			global::System.Reflection.MemberInfo extensionDataMemberForType = this.GetExtensionDataMemberForType(jsonObjectContract.NonNullableUnderlyingType);
			if (extensionDataMemberForType != null)
			{
				global::Newtonsoft.Json.Serialization.DefaultContractResolver.SetExtensionDataDelegates(jsonObjectContract, extensionDataMemberForType);
			}
			if (global::System.Array.IndexOf<string>(global::Newtonsoft.Json.Serialization.DefaultContractResolver.BlacklistedTypeNames, objectType.FullName) != -1)
			{
				jsonObjectContract.OnSerializingCallbacks.Add(new global::Newtonsoft.Json.Serialization.SerializationCallback(global::Newtonsoft.Json.Serialization.DefaultContractResolver.ThrowUnableToSerializeError));
			}
			return jsonObjectContract;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00019CC3 File Offset: 0x00017EC3
		private static void ThrowUnableToSerializeError(object o, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw new global::Newtonsoft.Json.JsonSerializationException("Unable to serialize instance of '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, o.GetType()));
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00019CE0 File Offset: 0x00017EE0
		private global::System.Reflection.MemberInfo GetExtensionDataMemberForType(global::System.Type type)
		{
			return this.GetClassHierarchyForType(type).SelectMany(delegate(global::System.Type baseType)
			{
				global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> list = new global::System.Collections.Generic.List<global::System.Reflection.MemberInfo>();
				list.AddRange(baseType.GetProperties(global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic));
				list.AddRange(baseType.GetFields(global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic));
				return list;
			}).LastOrDefault(delegate(global::System.Reflection.MemberInfo m)
			{
				global::System.Reflection.MemberTypes memberTypes = m.MemberType();
				if (memberTypes != global::System.Reflection.MemberTypes.Property && memberTypes != global::System.Reflection.MemberTypes.Field)
				{
					return false;
				}
				if (!m.IsDefined(typeof(global::Newtonsoft.Json.JsonExtensionDataAttribute), false))
				{
					return false;
				}
				if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.CanReadMemberValue(m, true))
				{
					throw new global::Newtonsoft.Json.JsonException("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(m.DeclaringType), m.Name));
				}
				global::System.Type type2;
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(m), typeof(global::System.Collections.Generic.IDictionary<, >), out type2))
				{
					global::System.Type type3 = type2.GetGenericArguments()[0];
					global::System.Type type4 = type2.GetGenericArguments()[1];
					if (type3.IsAssignableFrom(typeof(string)) && type4.IsAssignableFrom(typeof(global::Newtonsoft.Json.Linq.JToken)))
					{
						return true;
					}
				}
				throw new global::Newtonsoft.Json.JsonException("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(m.DeclaringType), m.Name));
			});
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00019D3C File Offset: 0x00017F3C
		private static void SetExtensionDataDelegates(global::Newtonsoft.Json.Serialization.JsonObjectContract contract, global::System.Reflection.MemberInfo member)
		{
			global::Newtonsoft.Json.JsonExtensionDataAttribute attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<global::Newtonsoft.Json.JsonExtensionDataAttribute>(member);
			if (attribute == null)
			{
				return;
			}
			global::System.Type memberUnderlyingType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(member);
			global::System.Type type;
			global::Newtonsoft.Json.Utilities.ReflectionUtils.ImplementsGenericDefinition(memberUnderlyingType, typeof(global::System.Collections.Generic.IDictionary<, >), out type);
			global::System.Type type2 = type.GetGenericArguments()[0];
			global::System.Type type3 = type.GetGenericArguments()[1];
			global::System.Type type4;
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsGenericDefinition(memberUnderlyingType, typeof(global::System.Collections.Generic.IDictionary<, >)))
			{
				type4 = typeof(global::System.Collections.Generic.Dictionary<, >).MakeGenericType(new global::System.Type[]
				{
					type2,
					type3
				});
			}
			else
			{
				type4 = memberUnderlyingType;
			}
			global::System.Func<object, object> getExtensionDataDictionary = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(member);
			if (attribute.ReadData)
			{
				global::System.Action<object, object> setExtensionDataDictionary = global::Newtonsoft.Json.Utilities.ReflectionUtils.CanSetMemberValue(member, true, false) ? global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(member) : null;
				global::System.Func<object> createExtensionDataDictionary = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type4);
				global::System.Reflection.PropertyInfo property = memberUnderlyingType.GetProperty("Item", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public, null, type3, new global::System.Type[]
				{
					type2
				}, null);
				global::System.Reflection.MethodInfo methodInfo = (property != null) ? property.GetSetMethod() : null;
				if (methodInfo == null)
				{
					global::System.Reflection.PropertyInfo property2 = type.GetProperty("Item", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public, null, type3, new global::System.Type[]
					{
						type2
					}, null);
					methodInfo = ((property2 != null) ? property2.GetSetMethod() : null);
				}
				global::Newtonsoft.Json.Utilities.MethodCall<object, object> setExtensionDataDictionaryValue = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
				global::Newtonsoft.Json.Serialization.ExtensionDataSetter extensionDataSetter = delegate(object o, string key, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
				{
					object obj = getExtensionDataDictionary(o);
					if (obj == null)
					{
						if (setExtensionDataDictionary == null)
						{
							throw new global::Newtonsoft.Json.JsonSerializationException("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, member.Name));
						}
						obj = createExtensionDataDictionary();
						setExtensionDataDictionary(o, obj);
					}
					setExtensionDataDictionaryValue(obj, new object[]
					{
						key,
						value
					});
				};
				contract.ExtensionDataSetter = extensionDataSetter;
			}
			if (attribute.WriteData)
			{
				global::System.Reflection.ConstructorInfo method = typeof(global::Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<, >).MakeGenericType(new global::System.Type[]
				{
					type2,
					type3
				}).GetConstructors().First<global::System.Reflection.ConstructorInfo>();
				global::Newtonsoft.Json.Serialization.ObjectConstructor<object> createEnumerableWrapper = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(method);
				global::Newtonsoft.Json.Serialization.ExtensionDataGetter extensionDataGetter = delegate(object o)
				{
					object obj = getExtensionDataDictionary(o);
					if (obj == null)
					{
						return null;
					}
					return (global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, object>>)createEnumerableWrapper(new object[]
					{
						obj
					});
				};
				contract.ExtensionDataGetter = extensionDataGetter;
			}
			contract.ExtensionDataValueType = type3;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00019F48 File Offset: 0x00018148
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Reflection.ConstructorInfo GetAttributeConstructor(global::System.Type objectType)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Reflection.ConstructorInfo> enumerator = (from c in objectType.GetConstructors(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic)
			where c.IsDefined(typeof(global::Newtonsoft.Json.JsonConstructorAttribute), true)
			select c).GetEnumerator();
			if (enumerator.MoveNext())
			{
				global::System.Reflection.ConstructorInfo result = enumerator.Current;
				if (enumerator.MoveNext())
				{
					throw new global::Newtonsoft.Json.JsonException("Multiple constructors with the JsonConstructorAttribute.");
				}
				return result;
			}
			else
			{
				if (objectType == typeof(global::System.Version))
				{
					return objectType.GetConstructor(new global::System.Type[]
					{
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int)
					});
				}
				return null;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001A000 File Offset: 0x00018200
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Reflection.ConstructorInfo GetImmutableConstructor(global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Reflection.ConstructorInfo> enumerator = ((global::System.Collections.Generic.IEnumerable<global::System.Reflection.ConstructorInfo>)objectType.GetConstructors()).GetEnumerator();
			if (enumerator.MoveNext())
			{
				global::System.Reflection.ConstructorInfo constructorInfo = enumerator.Current;
				if (!enumerator.MoveNext())
				{
					global::System.Reflection.ParameterInfo[] parameters = constructorInfo.GetParameters();
					if (parameters.Length != 0)
					{
						foreach (global::System.Reflection.ParameterInfo parameterInfo in parameters)
						{
							global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = this.MatchProperty(memberProperties, parameterInfo.Name, parameterInfo.ParameterType);
							if (jsonProperty == null || jsonProperty.Writable)
							{
								return null;
							}
						}
						return constructorInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001A080 File Offset: 0x00018280
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Reflection.ConstructorInfo GetParameterizedConstructor(global::System.Type objectType)
		{
			global::System.Reflection.ConstructorInfo[] constructors = objectType.GetConstructors(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
			if (constructors.Length == 1)
			{
				return constructors[0];
			}
			return null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001A0A4 File Offset: 0x000182A4
		protected virtual global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(global::System.Reflection.ConstructorInfo constructor, global::Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties)
		{
			global::System.Reflection.ParameterInfo[] parameters = constructor.GetParameters();
			global::Newtonsoft.Json.Serialization.JsonPropertyCollection jsonPropertyCollection = new global::Newtonsoft.Json.Serialization.JsonPropertyCollection(constructor.DeclaringType);
			foreach (global::System.Reflection.ParameterInfo parameterInfo in parameters)
			{
				if (parameterInfo.Name != null)
				{
					global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = this.MatchProperty(memberProperties, parameterInfo.Name, parameterInfo.ParameterType);
					if (jsonProperty != null || parameterInfo.Name != null)
					{
						global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty2 = this.CreatePropertyFromConstructorParameter(jsonProperty, parameterInfo);
						if (jsonProperty2 != null)
						{
							jsonPropertyCollection.AddProperty(jsonProperty2);
						}
					}
				}
			}
			return jsonPropertyCollection;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0001A118 File Offset: 0x00018318
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Serialization.JsonProperty MatchProperty(global::Newtonsoft.Json.Serialization.JsonPropertyCollection properties, string name, global::System.Type type)
		{
			if (name == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Serialization.JsonProperty closestMatchProperty = properties.GetClosestMatchProperty(name);
			if (closestMatchProperty == null || closestMatchProperty.PropertyType != type)
			{
				return null;
			}
			return closestMatchProperty;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001A148 File Offset: 0x00018348
		protected virtual global::Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, global::System.Reflection.ParameterInfo parameterInfo)
		{
			global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = new global::Newtonsoft.Json.Serialization.JsonProperty();
			jsonProperty.PropertyType = parameterInfo.ParameterType;
			jsonProperty.AttributeProvider = new global::Newtonsoft.Json.Serialization.ReflectionAttributeProvider(parameterInfo);
			bool flag;
			this.SetPropertySettingsFromAttributes(jsonProperty, parameterInfo, parameterInfo.Name, parameterInfo.Member.DeclaringType, global::Newtonsoft.Json.MemberSerialization.OptOut, out flag);
			jsonProperty.Readable = false;
			jsonProperty.Writable = true;
			if (matchingMemberProperty != null)
			{
				jsonProperty.PropertyName = ((jsonProperty.PropertyName != parameterInfo.Name) ? jsonProperty.PropertyName : matchingMemberProperty.PropertyName);
				jsonProperty.Converter = (jsonProperty.Converter ?? matchingMemberProperty.Converter);
				if (!jsonProperty._hasExplicitDefaultValue && matchingMemberProperty._hasExplicitDefaultValue)
				{
					jsonProperty.DefaultValue = matchingMemberProperty.DefaultValue;
				}
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty2 = jsonProperty;
				global::Newtonsoft.Json.Required? required = jsonProperty._required;
				jsonProperty2._required = ((required != null) ? required : matchingMemberProperty._required);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty3 = jsonProperty;
				bool? isReference = jsonProperty.IsReference;
				jsonProperty3.IsReference = ((isReference != null) ? isReference : matchingMemberProperty.IsReference);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty4 = jsonProperty;
				global::Newtonsoft.Json.NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
				jsonProperty4.NullValueHandling = ((nullValueHandling != null) ? nullValueHandling : matchingMemberProperty.NullValueHandling);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty5 = jsonProperty;
				global::Newtonsoft.Json.DefaultValueHandling? defaultValueHandling = jsonProperty.DefaultValueHandling;
				jsonProperty5.DefaultValueHandling = ((defaultValueHandling != null) ? defaultValueHandling : matchingMemberProperty.DefaultValueHandling);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty6 = jsonProperty;
				global::Newtonsoft.Json.ReferenceLoopHandling? referenceLoopHandling = jsonProperty.ReferenceLoopHandling;
				jsonProperty6.ReferenceLoopHandling = ((referenceLoopHandling != null) ? referenceLoopHandling : matchingMemberProperty.ReferenceLoopHandling);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty7 = jsonProperty;
				global::Newtonsoft.Json.ObjectCreationHandling? objectCreationHandling = jsonProperty.ObjectCreationHandling;
				jsonProperty7.ObjectCreationHandling = ((objectCreationHandling != null) ? objectCreationHandling : matchingMemberProperty.ObjectCreationHandling);
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty8 = jsonProperty;
				global::Newtonsoft.Json.TypeNameHandling? typeNameHandling = jsonProperty.TypeNameHandling;
				jsonProperty8.TypeNameHandling = ((typeNameHandling != null) ? typeNameHandling : matchingMemberProperty.TypeNameHandling);
			}
			return jsonProperty;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		protected virtual global::Newtonsoft.Json.JsonConverter ResolveContractConverter(global::System.Type objectType)
		{
			return global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetJsonConverter(objectType);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001A2E8 File Offset: 0x000184E8
		private global::System.Func<object> GetDefaultCreator(global::System.Type createdType)
		{
			return global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(createdType);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0001A2F8 File Offset: 0x000184F8
		private void InitializeContract(global::Newtonsoft.Json.Serialization.JsonContract contract)
		{
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(contract.NonNullableUnderlyingType);
			if (cachedAttribute != null)
			{
				contract.IsReference = cachedAttribute._isReference;
			}
			else
			{
				global::System.Runtime.Serialization.DataContractAttribute dataContractAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetDataContractAttribute(contract.NonNullableUnderlyingType);
				if (dataContractAttribute != null && dataContractAttribute.IsReference)
				{
					contract.IsReference = new bool?(true);
				}
			}
			contract.Converter = this.ResolveContractConverter(contract.NonNullableUnderlyingType);
			contract.InternalConverter = global::Newtonsoft.Json.JsonSerializer.GetMatchingConverter(global::Newtonsoft.Json.Serialization.DefaultContractResolver.BuiltInConverters, contract.NonNullableUnderlyingType);
			if (contract.IsInstantiable && (global::Newtonsoft.Json.Utilities.ReflectionUtils.HasDefaultConstructor(contract.CreatedType, true) || contract.CreatedType.IsValueType()))
			{
				contract.DefaultCreator = this.GetDefaultCreator(contract.CreatedType);
				contract.DefaultCreatorNonPublic = (!contract.CreatedType.IsValueType() && global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDefaultConstructor(contract.CreatedType) == null);
			}
			this.ResolveCallbackMethods(contract, contract.NonNullableUnderlyingType);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001A3D8 File Offset: 0x000185D8
		private void ResolveCallbackMethods(global::Newtonsoft.Json.Serialization.JsonContract contract, global::System.Type t)
		{
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> list;
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> list2;
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> list3;
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> list4;
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationErrorCallback> list5;
			this.GetCallbackMethodsForType(t, out list, out list2, out list3, out list4, out list5);
			if (list != null)
			{
				contract.OnSerializingCallbacks.AddRange(list);
			}
			if (list2 != null)
			{
				contract.OnSerializedCallbacks.AddRange(list2);
			}
			if (list3 != null)
			{
				contract.OnDeserializingCallbacks.AddRange(list3);
			}
			if (list4 != null)
			{
				contract.OnDeserializedCallbacks.AddRange(list4);
			}
			if (list5 != null)
			{
				contract.OnErrorCallbacks.AddRange(list5);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001A444 File Offset: 0x00018644
		private void GetCallbackMethodsForType(global::System.Type type, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> onSerializing, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> onSerialized, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> onDeserializing, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> onDeserialized, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationErrorCallback> onError)
		{
			onSerializing = null;
			onSerialized = null;
			onDeserializing = null;
			onDeserialized = null;
			onError = null;
			foreach (global::System.Type type2 in this.GetClassHierarchyForType(type))
			{
				global::System.Reflection.MethodInfo currentCallback = null;
				global::System.Reflection.MethodInfo currentCallback2 = null;
				global::System.Reflection.MethodInfo currentCallback3 = null;
				global::System.Reflection.MethodInfo currentCallback4 = null;
				global::System.Reflection.MethodInfo currentCallback5 = null;
				bool flag = global::Newtonsoft.Json.Serialization.DefaultContractResolver.ShouldSkipSerializing(type2);
				bool flag2 = global::Newtonsoft.Json.Serialization.DefaultContractResolver.ShouldSkipDeserialized(type2);
				foreach (global::System.Reflection.MethodInfo methodInfo in type2.GetMethods(global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic))
				{
					if (!methodInfo.ContainsGenericParameters)
					{
						global::System.Type type3 = null;
						global::System.Reflection.ParameterInfo[] parameters = methodInfo.GetParameters();
						if (!flag && global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(global::System.Runtime.Serialization.OnSerializingAttribute), currentCallback, ref type3))
						{
							onSerializing = (onSerializing ?? new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>());
							onSerializing.Add(global::Newtonsoft.Json.Serialization.JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback = methodInfo;
						}
						if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(global::System.Runtime.Serialization.OnSerializedAttribute), currentCallback2, ref type3))
						{
							onSerialized = (onSerialized ?? new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>());
							onSerialized.Add(global::Newtonsoft.Json.Serialization.JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback2 = methodInfo;
						}
						if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(global::System.Runtime.Serialization.OnDeserializingAttribute), currentCallback3, ref type3))
						{
							onDeserializing = (onDeserializing ?? new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>());
							onDeserializing.Add(global::Newtonsoft.Json.Serialization.JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback3 = methodInfo;
						}
						if (!flag2 && global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(global::System.Runtime.Serialization.OnDeserializedAttribute), currentCallback4, ref type3))
						{
							onDeserialized = (onDeserialized ?? new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>());
							onDeserialized.Add(global::Newtonsoft.Json.Serialization.JsonContract.CreateSerializationCallback(methodInfo));
							currentCallback4 = methodInfo;
						}
						if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsValidCallback(methodInfo, parameters, typeof(global::Newtonsoft.Json.Serialization.OnErrorAttribute), currentCallback5, ref type3))
						{
							onError = (onError ?? new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationErrorCallback>());
							onError.Add(global::Newtonsoft.Json.Serialization.JsonContract.CreateSerializationErrorCallback(methodInfo));
							currentCallback5 = methodInfo;
						}
					}
				}
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0001A634 File Offset: 0x00018834
		private static bool IsConcurrentOrObservableCollection(global::System.Type t)
		{
			if (t.IsGenericType())
			{
				string fullName = t.GetGenericTypeDefinition().FullName;
				if (fullName == "System.Collections.Concurrent.ConcurrentQueue`1" || fullName == "System.Collections.Concurrent.ConcurrentStack`1" || fullName == "System.Collections.Concurrent.ConcurrentBag`1" || fullName == "System.Collections.Concurrent.ConcurrentDictionary`2" || fullName == "System.Collections.ObjectModel.ObservableCollection`1")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001A699 File Offset: 0x00018899
		private static bool ShouldSkipDeserialized(global::System.Type t)
		{
			return global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsConcurrentOrObservableCollection(t) || (t.Name == "FSharpSet`1" || t.Name == "FSharpMap`2");
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001A6CC File Offset: 0x000188CC
		private static bool ShouldSkipSerializing(global::System.Type t)
		{
			return global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsConcurrentOrObservableCollection(t) || (t.Name == "FSharpSet`1" || t.Name == "FSharpMap`2");
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001A700 File Offset: 0x00018900
		private global::System.Collections.Generic.List<global::System.Type> GetClassHierarchyForType(global::System.Type type)
		{
			global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
			global::System.Type type2 = type;
			while (type2 != null && type2 != typeof(object))
			{
				list.Add(type2);
				type2 = type2.BaseType();
			}
			list.Reverse();
			return list;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001A748 File Offset: 0x00018948
		protected virtual global::Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonDictionaryContract jsonDictionaryContract = new global::Newtonsoft.Json.Serialization.JsonDictionaryContract(objectType);
			this.InitializeContract(jsonDictionaryContract);
			global::Newtonsoft.Json.JsonContainerAttribute attribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(objectType);
			if (((attribute != null) ? attribute.NamingStrategyType : null) != null)
			{
				global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetContainerNamingStrategy(attribute);
				jsonDictionaryContract.DictionaryKeyResolver = ((string s) => namingStrategy.GetDictionaryKey(s));
			}
			else
			{
				jsonDictionaryContract.DictionaryKeyResolver = new global::System.Func<string, string>(this.ResolveDictionaryKey);
			}
			global::System.Reflection.ConstructorInfo attributeConstructor = this.GetAttributeConstructor(jsonDictionaryContract.NonNullableUnderlyingType);
			if (attributeConstructor != null)
			{
				global::System.Reflection.ParameterInfo[] parameters = attributeConstructor.GetParameters();
				global::System.Type type = (jsonDictionaryContract.DictionaryKeyType != null && jsonDictionaryContract.DictionaryValueType != null) ? typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					typeof(global::System.Collections.Generic.KeyValuePair<, >).MakeGenericType(new global::System.Type[]
					{
						jsonDictionaryContract.DictionaryKeyType,
						jsonDictionaryContract.DictionaryValueType
					})
				}) : typeof(global::System.Collections.IDictionary);
				if (parameters.Length == 0)
				{
					jsonDictionaryContract.HasParameterizedCreator = false;
				}
				else
				{
					if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
					{
						throw new global::Newtonsoft.Json.JsonException("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jsonDictionaryContract.UnderlyingType, type));
					}
					jsonDictionaryContract.HasParameterizedCreator = true;
				}
				jsonDictionaryContract.OverrideCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(attributeConstructor);
			}
			return jsonDictionaryContract;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		protected virtual global::Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = new global::Newtonsoft.Json.Serialization.JsonArrayContract(objectType);
			this.InitializeContract(jsonArrayContract);
			global::System.Reflection.ConstructorInfo attributeConstructor = this.GetAttributeConstructor(jsonArrayContract.NonNullableUnderlyingType);
			if (attributeConstructor != null)
			{
				global::System.Reflection.ParameterInfo[] parameters = attributeConstructor.GetParameters();
				global::System.Type type = (jsonArrayContract.CollectionItemType != null) ? typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					jsonArrayContract.CollectionItemType
				}) : typeof(global::System.Collections.IEnumerable);
				if (parameters.Length == 0)
				{
					jsonArrayContract.HasParameterizedCreator = false;
				}
				else
				{
					if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
					{
						throw new global::Newtonsoft.Json.JsonException("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jsonArrayContract.UnderlyingType, type));
					}
					jsonArrayContract.HasParameterizedCreator = true;
				}
				jsonArrayContract.OverrideCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(attributeConstructor);
			}
			return jsonArrayContract;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001A970 File Offset: 0x00018B70
		protected virtual global::Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonPrimitiveContract jsonPrimitiveContract = new global::Newtonsoft.Json.Serialization.JsonPrimitiveContract(objectType);
			this.InitializeContract(jsonPrimitiveContract);
			return jsonPrimitiveContract;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001A98C File Offset: 0x00018B8C
		protected virtual global::Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonLinqContract jsonLinqContract = new global::Newtonsoft.Json.Serialization.JsonLinqContract(objectType);
			this.InitializeContract(jsonLinqContract);
			return jsonLinqContract;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		protected virtual global::Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonISerializableContract jsonISerializableContract = new global::Newtonsoft.Json.Serialization.JsonISerializableContract(objectType);
			this.InitializeContract(jsonISerializableContract);
			if (jsonISerializableContract.IsInstantiable)
			{
				global::System.Reflection.ConstructorInfo constructor = jsonISerializableContract.NonNullableUnderlyingType.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, new global::System.Type[]
				{
					typeof(global::System.Runtime.Serialization.SerializationInfo),
					typeof(global::System.Runtime.Serialization.StreamingContext)
				}, null);
				if (constructor != null)
				{
					global::Newtonsoft.Json.Serialization.ObjectConstructor<object> iserializableCreator = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
					jsonISerializableContract.ISerializableCreator = iserializableCreator;
				}
			}
			return jsonISerializableContract;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001AA18 File Offset: 0x00018C18
		protected virtual global::Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonDynamicContract jsonDynamicContract = new global::Newtonsoft.Json.Serialization.JsonDynamicContract(objectType);
			this.InitializeContract(jsonDynamicContract);
			global::Newtonsoft.Json.JsonContainerAttribute attribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(objectType);
			if (((attribute != null) ? attribute.NamingStrategyType : null) != null)
			{
				global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetContainerNamingStrategy(attribute);
				jsonDynamicContract.PropertyNameResolver = ((string s) => namingStrategy.GetDictionaryKey(s));
			}
			else
			{
				jsonDynamicContract.PropertyNameResolver = new global::System.Func<string, string>(this.ResolveDictionaryKey);
			}
			jsonDynamicContract.Properties.AddRange(this.CreateProperties(objectType, global::Newtonsoft.Json.MemberSerialization.OptOut));
			return jsonDynamicContract;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001AA9C File Offset: 0x00018C9C
		protected virtual global::Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(global::System.Type objectType)
		{
			global::Newtonsoft.Json.Serialization.JsonStringContract jsonStringContract = new global::Newtonsoft.Json.Serialization.JsonStringContract(objectType);
			this.InitializeContract(jsonStringContract);
			return jsonStringContract;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		protected virtual global::Newtonsoft.Json.Serialization.JsonContract CreateContract(global::System.Type objectType)
		{
			global::System.Type type = global::Newtonsoft.Json.Utilities.ReflectionUtils.EnsureNotByRefType(objectType);
			if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsJsonPrimitiveType(type))
			{
				return this.CreatePrimitiveContract(objectType);
			}
			type = global::Newtonsoft.Json.Utilities.ReflectionUtils.EnsureNotNullableType(type);
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(type);
			if (cachedAttribute is global::Newtonsoft.Json.JsonObjectAttribute)
			{
				return this.CreateObjectContract(objectType);
			}
			if (cachedAttribute is global::Newtonsoft.Json.JsonArrayAttribute)
			{
				return this.CreateArrayContract(objectType);
			}
			if (cachedAttribute is global::Newtonsoft.Json.JsonDictionaryAttribute)
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (type == typeof(global::Newtonsoft.Json.Linq.JToken) || type.IsSubclassOf(typeof(global::Newtonsoft.Json.Linq.JToken)))
			{
				return this.CreateLinqContract(objectType);
			}
			if (global::Newtonsoft.Json.Utilities.CollectionUtils.IsDictionaryType(type))
			{
				return this.CreateDictionaryContract(objectType);
			}
			if (typeof(global::System.Collections.IEnumerable).IsAssignableFrom(type))
			{
				return this.CreateArrayContract(objectType);
			}
			if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.CanConvertToString(type))
			{
				return this.CreateStringContract(objectType);
			}
			if (!this.IgnoreSerializableInterface && typeof(global::System.Runtime.Serialization.ISerializable).IsAssignableFrom(type) && global::Newtonsoft.Json.Serialization.JsonTypeReflector.IsSerializable(type))
			{
				return this.CreateISerializableContract(objectType);
			}
			if (typeof(global::System.Dynamic.IDynamicMetaObjectProvider).IsAssignableFrom(type))
			{
				return this.CreateDynamicContract(objectType);
			}
			if (global::Newtonsoft.Json.Serialization.DefaultContractResolver.IsIConvertible(type))
			{
				return this.CreatePrimitiveContract(type);
			}
			return this.CreateObjectContract(objectType);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001ABDC File Offset: 0x00018DDC
		internal static bool IsJsonPrimitiveType(global::System.Type t)
		{
			global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(t);
			return typeCode != global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Empty && typeCode != global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001ABFC File Offset: 0x00018DFC
		internal static bool IsIConvertible(global::System.Type t)
		{
			return (typeof(global::System.IConvertible).IsAssignableFrom(t) || (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(t) && typeof(global::System.IConvertible).IsAssignableFrom(global::System.Nullable.GetUnderlyingType(t)))) && !typeof(global::Newtonsoft.Json.Linq.JToken).IsAssignableFrom(t);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001AC50 File Offset: 0x00018E50
		internal static bool CanConvertToString(global::System.Type type)
		{
			global::System.ComponentModel.TypeConverter typeConverter;
			return global::Newtonsoft.Json.Serialization.JsonTypeReflector.CanTypeDescriptorConvertString(type, out typeConverter) || (type == typeof(global::System.Type) || type.IsSubclassOf(typeof(global::System.Type)));
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001AC90 File Offset: 0x00018E90
		private static bool IsValidCallback(global::System.Reflection.MethodInfo method, global::System.Reflection.ParameterInfo[] parameters, global::System.Type attributeType, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Reflection.MethodInfo currentCallback, [global::System.Runtime.CompilerServices.Nullable(2)] ref global::System.Type prevAttributeType)
		{
			if (!method.IsDefined(attributeType, false))
			{
				return false;
			}
			if (currentCallback != null)
			{
				throw new global::Newtonsoft.Json.JsonException("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, method, currentCallback, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType));
			}
			if (prevAttributeType != null)
			{
				throw new global::Newtonsoft.Json.JsonException("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, prevAttributeType, attributeType, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method));
			}
			if (method.IsVirtual)
			{
				throw new global::Newtonsoft.Json.JsonException("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, method, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), attributeType));
			}
			if (method.ReturnType != typeof(void))
			{
				throw new global::Newtonsoft.Json.JsonException("Serialization Callback '{1}' in type '{0}' must return void.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method));
			}
			if (attributeType == typeof(global::Newtonsoft.Json.Serialization.OnErrorAttribute))
			{
				if (parameters == null || parameters.Length != 2 || parameters[0].ParameterType != typeof(global::System.Runtime.Serialization.StreamingContext) || parameters[1].ParameterType != typeof(global::Newtonsoft.Json.Serialization.ErrorContext))
				{
					throw new global::Newtonsoft.Json.JsonException("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(global::System.Runtime.Serialization.StreamingContext), typeof(global::Newtonsoft.Json.Serialization.ErrorContext)));
				}
			}
			else if (parameters == null || parameters.Length != 1 || parameters[0].ParameterType != typeof(global::System.Runtime.Serialization.StreamingContext))
			{
				throw new global::Newtonsoft.Json.JsonException("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Serialization.DefaultContractResolver.GetClrTypeFullName(method.DeclaringType), method, typeof(global::System.Runtime.Serialization.StreamingContext)));
			}
			prevAttributeType = attributeType;
			return true;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001AE3E File Offset: 0x0001903E
		internal static string GetClrTypeFullName(global::System.Type type)
		{
			if (type.IsGenericTypeDefinition() || !type.ContainsGenericParameters())
			{
				return type.FullName;
			}
			return "{0}.{1}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type.Namespace, type.Name);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001AE74 File Offset: 0x00019074
		protected virtual global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(global::System.Type type, global::Newtonsoft.Json.MemberSerialization memberSerialization)
		{
			global::System.Collections.Generic.List<global::System.Reflection.MemberInfo> serializableMembers = this.GetSerializableMembers(type);
			if (serializableMembers == null)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Null collection of serializable members returned.");
			}
			global::Newtonsoft.Json.DefaultJsonNameTable nameTable = this.GetNameTable();
			global::Newtonsoft.Json.Serialization.JsonPropertyCollection jsonPropertyCollection = new global::Newtonsoft.Json.Serialization.JsonPropertyCollection(type);
			foreach (global::System.Reflection.MemberInfo member in serializableMembers)
			{
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = this.CreateProperty(member, memberSerialization);
				if (jsonProperty != null)
				{
					global::Newtonsoft.Json.DefaultJsonNameTable obj = nameTable;
					lock (obj)
					{
						jsonProperty.PropertyName = nameTable.Add(jsonProperty.PropertyName);
					}
					jsonPropertyCollection.AddProperty(jsonProperty);
				}
			}
			return jsonPropertyCollection.OrderBy(delegate(global::Newtonsoft.Json.Serialization.JsonProperty p)
			{
				int? order = p.Order;
				if (order == null)
				{
					return -1;
				}
				return order.GetValueOrDefault();
			}).ToList<global::Newtonsoft.Json.Serialization.JsonProperty>();
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001AF5C File Offset: 0x0001915C
		internal virtual global::Newtonsoft.Json.DefaultJsonNameTable GetNameTable()
		{
			return this._nameTable;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001AF64 File Offset: 0x00019164
		protected virtual global::Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(global::System.Reflection.MemberInfo member)
		{
			global::Newtonsoft.Json.Serialization.IValueProvider result;
			if (this.DynamicCodeGeneration)
			{
				result = new global::Newtonsoft.Json.Serialization.DynamicValueProvider(member);
			}
			else
			{
				result = new global::Newtonsoft.Json.Serialization.ReflectionValueProvider(member);
			}
			return result;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001AF8C File Offset: 0x0001918C
		protected virtual global::Newtonsoft.Json.Serialization.JsonProperty CreateProperty(global::System.Reflection.MemberInfo member, global::Newtonsoft.Json.MemberSerialization memberSerialization)
		{
			global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = new global::Newtonsoft.Json.Serialization.JsonProperty();
			jsonProperty.PropertyType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(member);
			jsonProperty.DeclaringType = member.DeclaringType;
			jsonProperty.ValueProvider = this.CreateMemberValueProvider(member);
			jsonProperty.AttributeProvider = new global::Newtonsoft.Json.Serialization.ReflectionAttributeProvider(member);
			bool flag;
			this.SetPropertySettingsFromAttributes(jsonProperty, member, member.Name, member.DeclaringType, memberSerialization, out flag);
			if (memberSerialization != global::Newtonsoft.Json.MemberSerialization.Fields)
			{
				jsonProperty.Readable = global::Newtonsoft.Json.Utilities.ReflectionUtils.CanReadMemberValue(member, flag);
				jsonProperty.Writable = global::Newtonsoft.Json.Utilities.ReflectionUtils.CanSetMemberValue(member, flag, jsonProperty.HasMemberAttribute);
			}
			else
			{
				jsonProperty.Readable = true;
				jsonProperty.Writable = true;
			}
			if (!this.IgnoreShouldSerializeMembers)
			{
				jsonProperty.ShouldSerialize = this.CreateShouldSerializeTest(member);
			}
			if (!this.IgnoreIsSpecifiedMembers)
			{
				this.SetIsSpecifiedActions(jsonProperty, member, flag);
			}
			return jsonProperty;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001B044 File Offset: 0x00019244
		private void SetPropertySettingsFromAttributes(global::Newtonsoft.Json.Serialization.JsonProperty property, object attributeProvider, string name, global::System.Type declaringType, global::Newtonsoft.Json.MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
			bool dataContractAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetDataContractAttribute(declaringType) != null;
			global::System.Reflection.MemberInfo memberInfo = attributeProvider as global::System.Reflection.MemberInfo;
			global::System.Runtime.Serialization.DataMemberAttribute dataMemberAttribute;
			if (dataContractAttribute && memberInfo != null)
			{
				dataMemberAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetDataMemberAttribute(memberInfo);
			}
			else
			{
				dataMemberAttribute = null;
			}
			global::Newtonsoft.Json.JsonPropertyAttribute attribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonPropertyAttribute>(attributeProvider);
			bool attribute2 = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonRequiredAttribute>(attributeProvider) != null;
			string text;
			bool hasSpecifiedName;
			if (attribute != null && attribute.PropertyName != null)
			{
				text = attribute.PropertyName;
				hasSpecifiedName = true;
			}
			else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
			{
				text = dataMemberAttribute.Name;
				hasSpecifiedName = true;
			}
			else
			{
				text = name;
				hasSpecifiedName = false;
			}
			global::Newtonsoft.Json.JsonContainerAttribute attribute3 = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(declaringType);
			global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy;
			if (((attribute != null) ? attribute.NamingStrategyType : null) != null)
			{
				namingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateNamingStrategyInstance(attribute.NamingStrategyType, attribute.NamingStrategyParameters);
			}
			else if (((attribute3 != null) ? attribute3.NamingStrategyType : null) != null)
			{
				namingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetContainerNamingStrategy(attribute3);
			}
			else
			{
				namingStrategy = this.NamingStrategy;
			}
			if (namingStrategy != null)
			{
				property.PropertyName = namingStrategy.GetPropertyName(text, hasSpecifiedName);
			}
			else
			{
				property.PropertyName = this.ResolvePropertyName(text);
			}
			property.UnderlyingName = name;
			bool flag = false;
			if (attribute != null)
			{
				property._required = attribute._required;
				property.Order = attribute._order;
				property.DefaultValueHandling = attribute._defaultValueHandling;
				flag = true;
				property.NullValueHandling = attribute._nullValueHandling;
				property.ReferenceLoopHandling = attribute._referenceLoopHandling;
				property.ObjectCreationHandling = attribute._objectCreationHandling;
				property.TypeNameHandling = attribute._typeNameHandling;
				property.IsReference = attribute._isReference;
				property.ItemIsReference = attribute._itemIsReference;
				property.ItemConverter = ((attribute.ItemConverterType != null) ? global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateJsonConverterInstance(attribute.ItemConverterType, attribute.ItemConverterParameters) : null);
				property.ItemReferenceLoopHandling = attribute._itemReferenceLoopHandling;
				property.ItemTypeNameHandling = attribute._itemTypeNameHandling;
			}
			else
			{
				property.NullValueHandling = null;
				property.ReferenceLoopHandling = null;
				property.ObjectCreationHandling = null;
				property.TypeNameHandling = null;
				property.IsReference = null;
				property.ItemIsReference = null;
				property.ItemConverter = null;
				property.ItemReferenceLoopHandling = null;
				property.ItemTypeNameHandling = null;
				if (dataMemberAttribute != null)
				{
					property._required = new global::Newtonsoft.Json.Required?(dataMemberAttribute.IsRequired ? global::Newtonsoft.Json.Required.AllowNull : global::Newtonsoft.Json.Required.Default);
					property.Order = ((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
					property.DefaultValueHandling = ((!dataMemberAttribute.EmitDefaultValue) ? new global::Newtonsoft.Json.DefaultValueHandling?(global::Newtonsoft.Json.DefaultValueHandling.Ignore) : null);
					flag = true;
				}
			}
			if (attribute2)
			{
				property._required = new global::Newtonsoft.Json.Required?(global::Newtonsoft.Json.Required.Always);
				flag = true;
			}
			property.HasMemberAttribute = flag;
			bool flag2 = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonIgnoreAttribute>(attributeProvider) != null || global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::Newtonsoft.Json.JsonExtensionDataAttribute>(attributeProvider) != null || global::Newtonsoft.Json.Serialization.JsonTypeReflector.IsNonSerializable(attributeProvider);
			if (memberSerialization != global::Newtonsoft.Json.MemberSerialization.OptIn)
			{
				bool flag3 = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::System.Runtime.Serialization.IgnoreDataMemberAttribute>(attributeProvider) != null;
				property.Ignored = (flag2 || flag3);
			}
			else
			{
				property.Ignored = (flag2 || !flag);
			}
			property.Converter = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetJsonConverter(attributeProvider);
			global::System.ComponentModel.DefaultValueAttribute attribute4 = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<global::System.ComponentModel.DefaultValueAttribute>(attributeProvider);
			if (attribute4 != null)
			{
				property.DefaultValue = attribute4.Value;
			}
			allowNonPublicAccess = false;
			if ((this.DefaultMembersSearchFlags & global::System.Reflection.BindingFlags.NonPublic) == global::System.Reflection.BindingFlags.NonPublic)
			{
				allowNonPublicAccess = true;
			}
			if (flag)
			{
				allowNonPublicAccess = true;
			}
			if (memberSerialization == global::Newtonsoft.Json.MemberSerialization.Fields)
			{
				allowNonPublicAccess = true;
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001B394 File Offset: 0x00019594
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Predicate<object> CreateShouldSerializeTest(global::System.Reflection.MemberInfo member)
		{
			global::System.Reflection.MethodInfo method = member.DeclaringType.GetMethod("ShouldSerialize" + member.Name, global::Newtonsoft.Json.Utilities.ReflectionUtils.EmptyTypes);
			if (method == null || method.ReturnType != typeof(bool))
			{
				return null;
			}
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> shouldSerializeCall = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return (object o) => (bool)shouldSerializeCall(o, new object[0]);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001B408 File Offset: 0x00019608
		private void SetIsSpecifiedActions(global::Newtonsoft.Json.Serialization.JsonProperty property, global::System.Reflection.MemberInfo member, bool allowNonPublicAccess)
		{
			global::System.Reflection.MemberInfo memberInfo = member.DeclaringType.GetProperty(member.Name + "Specified", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			if (memberInfo == null)
			{
				memberInfo = member.DeclaringType.GetField(member.Name + "Specified", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			}
			if (memberInfo == null || global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(memberInfo) != typeof(bool))
			{
				return;
			}
			global::System.Func<object, object> specifiedPropertyGet = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(memberInfo);
			property.GetIsSpecified = ((object o) => (bool)specifiedPropertyGet(o));
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.CanSetMemberValue(memberInfo, allowNonPublicAccess, false))
			{
				property.SetIsSpecified = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(memberInfo);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001B4BF File Offset: 0x000196BF
		protected virtual string ResolvePropertyName(string propertyName)
		{
			if (this.NamingStrategy != null)
			{
				return this.NamingStrategy.GetPropertyName(propertyName, false);
			}
			return propertyName;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001B4D8 File Offset: 0x000196D8
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			if (this.NamingStrategy != null)
			{
				return this.NamingStrategy.GetExtensionDataName(extensionDataName);
			}
			return extensionDataName;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001B4F0 File Offset: 0x000196F0
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			if (this.NamingStrategy != null)
			{
				return this.NamingStrategy.GetDictionaryKey(dictionaryKey);
			}
			return this.ResolvePropertyName(dictionaryKey);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001B50E File Offset: 0x0001970E
		public string GetResolvedPropertyName(string propertyName)
		{
			return this.ResolvePropertyName(propertyName);
		}

		// Token: 0x04000213 RID: 531
		private static readonly global::Newtonsoft.Json.Serialization.IContractResolver _instance = new global::Newtonsoft.Json.Serialization.DefaultContractResolver();

		// Token: 0x04000214 RID: 532
		private static readonly string[] BlacklistedTypeNames = new string[]
		{
			"System.IO.DriveInfo",
			"System.IO.FileInfo",
			"System.IO.DirectoryInfo"
		};

		// Token: 0x04000215 RID: 533
		private static readonly global::Newtonsoft.Json.JsonConverter[] BuiltInConverters = new global::Newtonsoft.Json.JsonConverter[]
		{
			new global::Newtonsoft.Json.Converters.EntityKeyMemberConverter(),
			new global::Newtonsoft.Json.Converters.ExpandoObjectConverter(),
			new global::Newtonsoft.Json.Converters.XmlNodeConverter(),
			new global::Newtonsoft.Json.Converters.BinaryConverter(),
			new global::Newtonsoft.Json.Converters.DataSetConverter(),
			new global::Newtonsoft.Json.Converters.DataTableConverter(),
			new global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter(),
			new global::Newtonsoft.Json.Converters.KeyValuePairConverter(),
			new global::Newtonsoft.Json.Converters.BsonObjectIdConverter(),
			new global::Newtonsoft.Json.Converters.RegexConverter()
		};

		// Token: 0x04000216 RID: 534
		private readonly global::Newtonsoft.Json.DefaultJsonNameTable _nameTable = new global::Newtonsoft.Json.DefaultJsonNameTable();

		// Token: 0x04000217 RID: 535
		private readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Serialization.JsonContract> _contractCache;

		// Token: 0x02000199 RID: 409
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		internal class EnumerableDictionaryWrapper<[global::System.Runtime.CompilerServices.Nullable(2)] TEnumeratorKey, [global::System.Runtime.CompilerServices.Nullable(2)] TEnumeratorValue> : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000F0D RID: 3853 RVA: 0x00042883 File Offset: 0x00040A83
			public EnumerableDictionaryWrapper([global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})] global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(e, "e");
				this._e = e;
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x0004289D File Offset: 0x00040A9D
			[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator()
			{
				foreach (global::System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair in this._e)
				{
					yield return new global::System.Collections.Generic.KeyValuePair<object, object>(keyValuePair.Key, keyValuePair.Value);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x06000F0F RID: 3855 RVA: 0x000428AC File Offset: 0x00040AAC
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000703 RID: 1795
			[global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
		}
	}
}
