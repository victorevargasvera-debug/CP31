using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000099 RID: 153
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class JsonTypeReflector
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x00023351 File Offset: 0x00021551
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T GetCachedAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(object attributeProvider) where T : global::System.Attribute
		{
			return global::Newtonsoft.Json.Serialization.CachedAttributeGetter<T>.GetAttribute(attributeProvider);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002335C File Offset: 0x0002155C
		public static bool CanTypeDescriptorConvertString(global::System.Type type, out global::System.ComponentModel.TypeConverter typeConverter)
		{
			typeConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
			if (typeConverter != null)
			{
				global::System.Type type2 = typeConverter.GetType();
				if (!string.Equals(type2.FullName, "System.ComponentModel.ComponentConverter", global::System.StringComparison.Ordinal) && !string.Equals(type2.FullName, "System.ComponentModel.ReferenceConverter", global::System.StringComparison.Ordinal) && !string.Equals(type2.FullName, "System.Windows.Forms.Design.DataSourceConverter", global::System.StringComparison.Ordinal) && type2 != typeof(global::System.ComponentModel.TypeConverter))
				{
					return typeConverter.CanConvertTo(typeof(string));
				}
			}
			return false;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000233DC File Offset: 0x000215DC
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Runtime.Serialization.DataContractAttribute GetDataContractAttribute(global::System.Type type)
		{
			global::System.Type type2 = type;
			while (type2 != null)
			{
				global::System.Runtime.Serialization.DataContractAttribute attribute = global::Newtonsoft.Json.Serialization.CachedAttributeGetter<global::System.Runtime.Serialization.DataContractAttribute>.GetAttribute(type2);
				if (attribute != null)
				{
					return attribute;
				}
				type2 = type2.BaseType();
			}
			return null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002340C File Offset: 0x0002160C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute(global::System.Reflection.MemberInfo memberInfo)
		{
			if (memberInfo.MemberType() == global::System.Reflection.MemberTypes.Field)
			{
				return global::Newtonsoft.Json.Serialization.CachedAttributeGetter<global::System.Runtime.Serialization.DataMemberAttribute>.GetAttribute(memberInfo);
			}
			global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)memberInfo;
			global::System.Runtime.Serialization.DataMemberAttribute attribute = global::Newtonsoft.Json.Serialization.CachedAttributeGetter<global::System.Runtime.Serialization.DataMemberAttribute>.GetAttribute(propertyInfo);
			if (attribute == null && propertyInfo.IsVirtual())
			{
				global::System.Type type = propertyInfo.DeclaringType;
				while (attribute == null && type != null)
				{
					global::System.Reflection.PropertyInfo propertyInfo2 = (global::System.Reflection.PropertyInfo)global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberInfoFromType(type, propertyInfo);
					if (propertyInfo2 != null && propertyInfo2.IsVirtual())
					{
						attribute = global::Newtonsoft.Json.Serialization.CachedAttributeGetter<global::System.Runtime.Serialization.DataMemberAttribute>.GetAttribute(propertyInfo2);
					}
					type = type.BaseType();
				}
			}
			return attribute;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00023484 File Offset: 0x00021684
		public static global::Newtonsoft.Json.MemberSerialization GetObjectMemberSerialization(global::System.Type objectType, bool ignoreSerializableAttribute)
		{
			global::Newtonsoft.Json.JsonObjectAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonObjectAttribute>(objectType);
			if (cachedAttribute != null)
			{
				return cachedAttribute.MemberSerialization;
			}
			if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetDataContractAttribute(objectType) != null)
			{
				return global::Newtonsoft.Json.MemberSerialization.OptIn;
			}
			if (!ignoreSerializableAttribute && global::Newtonsoft.Json.Serialization.JsonTypeReflector.IsSerializable(objectType))
			{
				return global::Newtonsoft.Json.MemberSerialization.Fields;
			}
			return global::Newtonsoft.Json.MemberSerialization.OptOut;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000234BC File Offset: 0x000216BC
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::Newtonsoft.Json.JsonConverter GetJsonConverter(object attributeProvider)
		{
			global::Newtonsoft.Json.JsonConverterAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonConverterAttribute>(attributeProvider);
			if (cachedAttribute != null)
			{
				global::System.Func<object[], object> func = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreatorCache.Get(cachedAttribute.ConverterType);
				if (func != null)
				{
					return (global::Newtonsoft.Json.JsonConverter)func(cachedAttribute.ConverterParameters);
				}
			}
			return null;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000234FA File Offset: 0x000216FA
		public static global::Newtonsoft.Json.JsonConverter CreateJsonConverterInstance(global::System.Type converterType, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] object[] args)
		{
			return (global::Newtonsoft.Json.JsonConverter)global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreatorCache.Get(converterType)(args);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00023512 File Offset: 0x00021712
		public static global::Newtonsoft.Json.Serialization.NamingStrategy CreateNamingStrategyInstance(global::System.Type namingStrategyType, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] object[] args)
		{
			return (global::Newtonsoft.Json.Serialization.NamingStrategy)global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreatorCache.Get(namingStrategyType)(args);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002352A File Offset: 0x0002172A
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::Newtonsoft.Json.Serialization.NamingStrategy GetContainerNamingStrategy(global::Newtonsoft.Json.JsonContainerAttribute containerAttribute)
		{
			if (containerAttribute.NamingStrategyInstance == null)
			{
				if (containerAttribute.NamingStrategyType == null)
				{
					return null;
				}
				containerAttribute.NamingStrategyInstance = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateNamingStrategyInstance(containerAttribute.NamingStrategyType, containerAttribute.NamingStrategyParameters);
			}
			return containerAttribute.NamingStrategyInstance;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00023564 File Offset: 0x00021764
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})]
		private static global::System.Func<object[], object> GetCreator(global::System.Type type)
		{
			global::System.Func<object> defaultConstructor = global::Newtonsoft.Json.Utilities.ReflectionUtils.HasDefaultConstructor(type, false) ? global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type) : null;
			return delegate([global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				2,
				1
			})] object[] parameters)
			{
				object result;
				try
				{
					if (parameters != null)
					{
						global::System.Type[] types = parameters.Select(delegate(object param)
						{
							if (param == null)
							{
								throw new global::System.InvalidOperationException("Cannot pass a null parameter to the constructor.");
							}
							return param.GetType();
						}).ToArray<global::System.Type>();
						global::System.Reflection.ConstructorInfo constructor = type.GetConstructor(types);
						if (!(constructor != null))
						{
							throw new global::Newtonsoft.Json.JsonException("No matching parameterized constructor found for '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
						}
						result = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor)(parameters);
					}
					else
					{
						if (defaultConstructor == null)
						{
							throw new global::Newtonsoft.Json.JsonException("No parameterless constructor defined for '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
						}
						result = defaultConstructor();
					}
				}
				catch (global::System.Exception innerException)
				{
					throw new global::Newtonsoft.Json.JsonException("Error creating '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type), innerException);
				}
				return result;
			};
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000235B1 File Offset: 0x000217B1
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::System.Type GetAssociatedMetadataType(global::System.Type type)
		{
			return global::Newtonsoft.Json.Serialization.JsonTypeReflector.AssociatedMetadataTypesCache.Get(type);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000235C0 File Offset: 0x000217C0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::System.Type GetAssociateMetadataTypeFromAttribute(global::System.Type type)
		{
			foreach (global::System.Attribute attribute in global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttributes(type, null, true))
			{
				global::System.Type type2 = attribute.GetType();
				if (string.Equals(type2.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", global::System.StringComparison.Ordinal))
				{
					if (global::Newtonsoft.Json.Serialization.JsonTypeReflector._metadataTypeAttributeReflectionObject == null)
					{
						global::Newtonsoft.Json.Serialization.JsonTypeReflector._metadataTypeAttributeReflectionObject = global::Newtonsoft.Json.Utilities.ReflectionObject.Create(type2, new string[]
						{
							"MetadataClassType"
						});
					}
					return (global::System.Type)global::Newtonsoft.Json.Serialization.JsonTypeReflector._metadataTypeAttributeReflectionObject.GetValue(attribute, "MetadataClassType");
				}
			}
			return null;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002363C File Offset: 0x0002183C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static T GetAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(global::System.Type type) where T : global::System.Attribute
		{
			global::System.Type associatedMetadataType = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAssociatedMetadataType(type);
			T attribute;
			if (associatedMetadataType != null)
			{
				attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(associatedMetadataType, true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(type, true);
			if (attribute != null)
			{
				return attribute;
			}
			global::System.Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(interfaces[i], true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			return default(T);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000236B0 File Offset: 0x000218B0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static T GetAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(global::System.Reflection.MemberInfo memberInfo) where T : global::System.Attribute
		{
			global::System.Type associatedMetadataType = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAssociatedMetadataType(memberInfo.DeclaringType);
			T attribute;
			if (associatedMetadataType != null)
			{
				global::System.Reflection.MemberInfo memberInfoFromType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberInfoFromType(associatedMetadataType, memberInfo);
				if (memberInfoFromType != null)
				{
					attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(memberInfoFromType, true);
					if (attribute != null)
					{
						return attribute;
					}
				}
			}
			attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(memberInfo, true);
			if (attribute != null)
			{
				return attribute;
			}
			if (memberInfo.DeclaringType != null)
			{
				global::System.Type[] interfaces = memberInfo.DeclaringType.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					global::System.Reflection.MemberInfo memberInfoFromType2 = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberInfoFromType(interfaces[i], memberInfo);
					if (memberInfoFromType2 != null)
					{
						attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(memberInfoFromType2, true);
						if (attribute != null)
						{
							return attribute;
						}
					}
				}
			}
			return default(T);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00023766 File Offset: 0x00021966
		public static bool IsNonSerializable(object provider)
		{
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<global::System.NonSerializedAttribute>(provider, false) != null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00023772 File Offset: 0x00021972
		public static bool IsSerializable(object provider)
		{
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<global::System.SerializableAttribute>(provider, false) != null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00023780 File Offset: 0x00021980
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T GetAttribute<[global::System.Runtime.CompilerServices.Nullable(0)] T>(object provider) where T : global::System.Attribute
		{
			global::System.Type type = provider as global::System.Type;
			if (type != null)
			{
				return global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<T>(type);
			}
			global::System.Reflection.MemberInfo memberInfo = provider as global::System.Reflection.MemberInfo;
			if (memberInfo != null)
			{
				return global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAttribute<T>(memberInfo);
			}
			return global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<T>(provider, true);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000237B8 File Offset: 0x000219B8
		public static bool DynamicCodeGeneration
		{
			[global::System.Security.SecuritySafeCritical]
			get
			{
				if (global::Newtonsoft.Json.Serialization.JsonTypeReflector._dynamicCodeGeneration == null)
				{
					try
					{
						new global::System.Security.Permissions.ReflectionPermission(global::System.Security.Permissions.ReflectionPermissionFlag.MemberAccess).Demand();
						new global::System.Security.Permissions.ReflectionPermission(global::System.Security.Permissions.ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
						new global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityPermissionFlag.SkipVerification).Demand();
						new global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode).Demand();
						new global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.PermissionState.Unrestricted).Demand();
						global::Newtonsoft.Json.Serialization.JsonTypeReflector._dynamicCodeGeneration = new bool?(true);
					}
					catch (global::System.Exception)
					{
						global::Newtonsoft.Json.Serialization.JsonTypeReflector._dynamicCodeGeneration = new bool?(false);
					}
				}
				return global::Newtonsoft.Json.Serialization.JsonTypeReflector._dynamicCodeGeneration.GetValueOrDefault();
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00023840 File Offset: 0x00021A40
		public static bool FullyTrusted
		{
			get
			{
				if (global::Newtonsoft.Json.Serialization.JsonTypeReflector._fullyTrusted == null)
				{
					global::System.AppDomain currentDomain = global::System.AppDomain.CurrentDomain;
					global::Newtonsoft.Json.Serialization.JsonTypeReflector._fullyTrusted = new bool?(currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
				}
				return global::Newtonsoft.Json.Serialization.JsonTypeReflector._fullyTrusted.GetValueOrDefault();
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00023884 File Offset: 0x00021A84
		public static global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory ReflectionDelegateFactory
		{
			get
			{
				if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.DynamicCodeGeneration)
				{
					return global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.Instance;
				}
				return global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.Instance;
			}
		}

		// Token: 0x040002B5 RID: 693
		private static bool? _dynamicCodeGeneration;

		// Token: 0x040002B6 RID: 694
		private static bool? _fullyTrusted;

		// Token: 0x040002B7 RID: 695
		public const string IdPropertyName = "$id";

		// Token: 0x040002B8 RID: 696
		public const string RefPropertyName = "$ref";

		// Token: 0x040002B9 RID: 697
		public const string TypePropertyName = "$type";

		// Token: 0x040002BA RID: 698
		public const string ValuePropertyName = "$value";

		// Token: 0x040002BB RID: 699
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x040002BC RID: 700
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x040002BD RID: 701
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x040002BE RID: 702
		public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";

		// Token: 0x040002BF RID: 703
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			1,
			2,
			1,
			1
		})]
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Func<object[], object>> CreatorCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Func<object[], object>>(new global::System.Func<global::System.Type, global::System.Func<object[], object>>(global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCreator));

		// Token: 0x040002C0 RID: 704
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Type> AssociatedMetadataTypesCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Type>(new global::System.Func<global::System.Type, global::System.Type>(global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetAssociateMetadataTypeFromAttribute));

		// Token: 0x040002C1 RID: 705
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject;
	}
}
