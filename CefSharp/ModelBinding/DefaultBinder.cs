using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using CefSharp.JavascriptBinding;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000BD RID: 189
	public class DefaultBinder : global::CefSharp.ModelBinding.IBinder
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00008EA2 File Offset: 0x000070A2
		public DefaultBinder(global::CefSharp.JavascriptBinding.IJavascriptNameConverter javascriptNameConverter = null)
		{
			this.javascriptNameConverter = javascriptNameConverter;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00008EB4 File Offset: 0x000070B4
		public virtual object Bind(object obj, global::System.Type targetType)
		{
			if (obj == null)
			{
				if (targetType.IsValueType)
				{
					return global::System.Activator.CreateInstance(targetType);
				}
				return null;
			}
			else
			{
				global::System.Type type = obj.GetType();
				if (targetType.IsAssignableFrom(type))
				{
					return obj;
				}
				if (targetType.IsEnum && targetType.IsEnumDefined(obj))
				{
					return global::System.Enum.ToObject(targetType, obj);
				}
				global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
				if (converter.CanConvertTo(targetType))
				{
					return converter.ConvertTo(obj, targetType);
				}
				if (targetType.IsCollection() || targetType.IsArray() || targetType.IsEnumerable())
				{
					return this.BindCollection(targetType, type, obj);
				}
				return this.BindObject(targetType, type, obj);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00008F44 File Offset: 0x00007144
		protected virtual object BindCollection(global::System.Type targetType, global::System.Type objType, object obj)
		{
			global::System.Collections.ICollection collection = obj as global::System.Collections.ICollection;
			if (collection == null)
			{
				return null;
			}
			global::System.Type type;
			if (targetType.GetTypeInfo().IsGenericType)
			{
				type = targetType.GetGenericArguments().FirstOrDefault<global::System.Type>();
			}
			else
			{
				global::System.Type type2 = (from i in targetType.GetInterfaces()
				where i.GetTypeInfo().IsGenericType
				select i).FirstOrDefault((global::System.Type i) => i.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.IEnumerable<>));
				type = ((type2 == null) ? null : type2.GetGenericArguments().FirstOrDefault<global::System.Type>());
			}
			if (type == null)
			{
				type = typeof(object);
			}
			global::System.Type type3 = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
			{
				type
			});
			global::System.Collections.IList list = (global::System.Collections.IList)global::System.Activator.CreateInstance(type3);
			global::System.Collections.Generic.IList<object> source = (global::System.Collections.Generic.IList<object>)obj;
			for (int j = 0; j < collection.Count; j++)
			{
				object obj2 = source.ElementAtOrDefault(j);
				object value = this.Bind(obj2, type);
				list.Add(value);
			}
			if (targetType.IsArray())
			{
				global::System.Reflection.MethodInfo methodInfo = global::CefSharp.ModelBinding.DefaultBinder.ToArrayMethodInfo.MakeGenericMethod(new global::System.Type[]
				{
					type
				});
				global::System.Reflection.MethodBase methodBase = methodInfo;
				object obj3 = null;
				object[] parameters = new global::System.Collections.IList[]
				{
					list
				};
				return methodBase.Invoke(obj3, parameters);
			}
			return list;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00009090 File Offset: 0x00007290
		protected virtual object BindObject(global::System.Type targetType, global::System.Type objType, object obj)
		{
			object obj2 = global::System.Activator.CreateInstance(targetType, true);
			if (typeof(global::System.Collections.Generic.IDictionary<string, object>).IsAssignableFrom(objType))
			{
				global::System.Collections.Generic.IDictionary<string, object> dictionary = (global::System.Collections.Generic.IDictionary<string, object>)obj;
				global::System.Collections.Generic.List<global::CefSharp.ModelBinding.BindingMemberInfo> list = global::CefSharp.ModelBinding.BindingMemberInfo.Collect(targetType).ToList<global::CefSharp.ModelBinding.BindingMemberInfo>();
				foreach (global::CefSharp.ModelBinding.BindingMemberInfo bindingMemberInfo in list)
				{
					string propertyName = this.GetPropertyName(bindingMemberInfo);
					object obj3;
					if (dictionary.TryGetValue(propertyName, out obj3))
					{
						object newValue = this.Bind(obj3, bindingMemberInfo.Type);
						bindingMemberInfo.SetValue(obj2, newValue);
					}
				}
			}
			return obj2;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00009138 File Offset: 0x00007338
		private string GetPropertyName(global::CefSharp.ModelBinding.BindingMemberInfo modelProperty)
		{
			if (this.javascriptNameConverter == null)
			{
				return modelProperty.Name;
			}
			return this.javascriptNameConverter.ConvertReturnedObjectPropertyAndFieldToNameJavascript(modelProperty);
		}

		// Token: 0x04000355 RID: 853
		private static readonly global::System.Reflection.MethodInfo ToArrayMethodInfo = typeof(global::System.Linq.Enumerable).GetMethod("ToArray", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);

		// Token: 0x04000356 RID: 854
		private readonly global::CefSharp.JavascriptBinding.IJavascriptNameConverter javascriptNameConverter;

		// Token: 0x04000357 RID: 855
		public static readonly global::CefSharp.ModelBinding.IBinder Instance = new global::CefSharp.ModelBinding.DefaultBinder(new global::CefSharp.JavascriptBinding.CamelCaseJavascriptNameConverter());
	}
}
