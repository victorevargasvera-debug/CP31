using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace CefSharp.DevTools
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.DataContract]
	public abstract class DevToolsDomainEntityBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x000048A8 File Offset: 0x00002AA8
		internal static object StringToEnum(global::System.Type enumType, string input)
		{
			if (!enumType.IsArray)
			{
				if (enumType.IsGenericType && enumType.GetGenericTypeDefinition() == typeof(global::System.Nullable<>))
				{
					if (string.IsNullOrEmpty(input))
					{
						return null;
					}
					enumType = global::System.Nullable.GetUnderlyingType(enumType);
				}
				return global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnumInternal(enumType, input);
			}
			if (string.IsNullOrEmpty(input) || input == "[]" || input == "[ ]")
			{
				return null;
			}
			string[] array = input.Substring(1, input.Length - 2).Split(new char[]
			{
				','
			});
			global::System.Array array2 = global::System.Array.CreateInstance(enumType.GetElementType(), array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				string input2 = array[i].Trim(new char[]
				{
					'\r',
					'\n',
					'"',
					' '
				});
				object value = global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnumInternal(enumType.GetElementType(), input2);
				array2.SetValue(value, i);
			}
			return array2;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000498C File Offset: 0x00002B8C
		private static object StringToEnumInternal(global::System.Type enumType, string input)
		{
			foreach (string text in global::System.Enum.GetNames(enumType))
			{
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = ((global::System.Runtime.Serialization.EnumMemberAttribute[])enumType.GetField(text).GetCustomAttributes(typeof(global::System.Runtime.Serialization.EnumMemberAttribute), true)).Single<global::System.Runtime.Serialization.EnumMemberAttribute>();
				if (enumMemberAttribute.Value == input)
				{
					return global::System.Enum.Parse(enumType, text);
				}
			}
			return global::System.Enum.GetValues(enumType).GetValue(0);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000049F8 File Offset: 0x00002BF8
		internal static string EnumToString(global::System.Enum e)
		{
			global::System.Reflection.MemberInfo element = e.GetType().GetMember(e.ToString()).FirstOrDefault<global::System.Reflection.MemberInfo>();
			global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(element, typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
			return enumMemberAttribute.Value;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00004A3C File Offset: 0x00002C3C
		internal static string EnumToString(global::System.Array enumArray)
		{
			string text = "[";
			foreach (object obj in enumArray)
			{
				global::System.Reflection.MemberInfo element = obj.GetType().GetMember(obj.ToString()).FirstOrDefault<global::System.Reflection.MemberInfo>();
				global::System.Runtime.Serialization.EnumMemberAttribute enumMemberAttribute = (global::System.Runtime.Serialization.EnumMemberAttribute)global::System.Attribute.GetCustomAttribute(element, typeof(global::System.Runtime.Serialization.EnumMemberAttribute), false);
				text = text + enumMemberAttribute.Value + ",";
			}
			text = text + text.Substring(0, text.Length - 1) + "]";
			return text;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00004AEC File Offset: 0x00002CEC
		public global::System.Collections.Generic.IDictionary<string, object> ToDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::System.Reflection.PropertyInfo[] properties = base.GetType().GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				global::System.Runtime.Serialization.DataMemberAttribute dataMemberAttribute = (global::System.Runtime.Serialization.DataMemberAttribute)global::System.Attribute.GetCustomAttribute(propertyInfo, typeof(global::System.Runtime.Serialization.DataMemberAttribute), false);
				if (dataMemberAttribute != null)
				{
					string name = dataMemberAttribute.Name;
					bool isRequired = dataMemberAttribute.IsRequired;
					object obj = propertyInfo.GetValue(this);
					if (isRequired && obj == null)
					{
						throw new global::CefSharp.DevTools.DevToolsClientException(propertyInfo.Name + " is required");
					}
					if (obj != null)
					{
						global::System.Type type = obj.GetType();
						if (typeof(global::CefSharp.DevTools.DevToolsDomainEntityBase).IsAssignableFrom(type))
						{
							obj = ((global::CefSharp.DevTools.DevToolsDomainEntityBase)obj).ToDictionary();
						}
						else if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IList<>) && typeof(global::CefSharp.DevTools.DevToolsDomainEntityBase).IsAssignableFrom(propertyInfo.PropertyType.GetGenericArguments()[0]))
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, object>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, object>>();
							foreach (object obj2 in ((global::System.Collections.IEnumerable)obj))
							{
								list.Add(((global::CefSharp.DevTools.DevToolsDomainEntityBase)obj2).ToDictionary());
							}
							obj = list;
						}
						dictionary.Add(name, obj);
					}
				}
			}
			return dictionary;
		}
	}
}
