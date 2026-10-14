using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CefSharp.Event;
using CefSharp.JavascriptBinding;

namespace CefSharp.Internals
{
	// Token: 0x020000E3 RID: 227
	public class JavascriptObjectRepository : global::CefSharp.Internals.FreezableBase, global::CefSharp.Internals.IJavascriptObjectRepositoryInternal, global::CefSharp.IJavascriptObjectRepository, global::System.IDisposable
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060006B4 RID: 1716 RVA: 0x0000A2C8 File Offset: 0x000084C8
		// (remove) Token: 0x060006B5 RID: 1717 RVA: 0x0000A300 File Offset: 0x00008500
		public event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingEventArgs> ResolveObject;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060006B6 RID: 1718 RVA: 0x0000A338 File Offset: 0x00008538
		// (remove) Token: 0x060006B7 RID: 1719 RVA: 0x0000A370 File Offset: 0x00008570
		public event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingCompleteEventArgs> ObjectBoundInJavascript;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060006B8 RID: 1720 RVA: 0x0000A3A8 File Offset: 0x000085A8
		// (remove) Token: 0x060006B9 RID: 1721 RVA: 0x0000A3E0 File Offset: 0x000085E0
		public event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs> ObjectsBoundInJavascript;

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0000A415 File Offset: 0x00008615
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0000A41D File Offset: 0x0000861D
		public bool IsBrowserInitialized { get; set; }

		// Token: 0x060006BC RID: 1724 RVA: 0x0000A426 File Offset: 0x00008626
		public void Dispose()
		{
			this.ResolveObject = null;
			this.ObjectBoundInJavascript = null;
			this.ObjectsBoundInJavascript = null;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0000A43D File Offset: 0x0000863D
		public bool HasBoundObjects
		{
			get
			{
				return this.objects.Count > 0;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0000A44D File Offset: 0x0000864D
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0000A455 File Offset: 0x00008655
		public global::CefSharp.JavascriptBinding.JavascriptBindingSettings Settings { get; private set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0000A45E File Offset: 0x0000865E
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x0000A466 File Offset: 0x00008666
		public global::CefSharp.JavascriptBinding.IJavascriptNameConverter NameConverter
		{
			get
			{
				return this.nameConverter;
			}
			set
			{
				base.ThrowIfFrozen("NameConverter");
				this.nameConverter = value;
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000A47A File Offset: 0x0000867A
		public JavascriptObjectRepository()
		{
			this.Settings = new global::CefSharp.JavascriptBinding.JavascriptBindingSettings();
			this.nameConverter = new global::CefSharp.JavascriptBinding.LegacyCamelCaseJavascriptNameConverter();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000A4A4 File Offset: 0x000086A4
		public bool IsBound(string name)
		{
			return this.objects.Values.Any((global::CefSharp.Internals.JavascriptObject x) => x.Name == name);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000A4DC File Offset: 0x000086DC
		global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptObject> global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.GetLegacyBoundObjects()
		{
			this.RaiseResolveObjectEvent("Legacy");
			return (from x in this.objects.Values
			where x.RootObject
			select x).ToList<global::CefSharp.Internals.JavascriptObject>();
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000A528 File Offset: 0x00008728
		global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptObject> global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.GetObjects(global::System.Collections.Generic.List<string> names)
		{
			bool flag = names == null || names.Count == 0;
			if (flag)
			{
				this.RaiseResolveObjectEvent("All");
				return (from x in this.objects.Values
				where x.RootObject
				select x).ToList<global::CefSharp.Internals.JavascriptObject>();
			}
			foreach (string name in names)
			{
				if (!this.IsBound(name))
				{
					this.RaiseResolveObjectEvent(name);
				}
			}
			return (from x in this.objects.Values
			where names.Contains(x.JavascriptName) && x.RootObject
			select x).ToList<global::CefSharp.Internals.JavascriptObject>();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000A614 File Offset: 0x00008814
		void global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.ObjectsBound(global::System.Collections.Generic.List<global::System.Tuple<string, bool, bool>> objs)
		{
			global::System.EventHandler<global::CefSharp.Event.JavascriptBindingCompleteEventArgs> boundObjectHandler = this.ObjectBoundInJavascript;
			global::System.EventHandler<global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs> boundObjectsHandler = this.ObjectsBoundInJavascript;
			if (boundObjectHandler != null || boundObjectsHandler != null)
			{
				global::System.Threading.Tasks.Task.Run(delegate()
				{
					foreach (global::System.Tuple<string, bool, bool> tuple in objs)
					{
						global::System.EventHandler<global::CefSharp.Event.JavascriptBindingCompleteEventArgs> boundObjectHandler = boundObjectHandler;
						if (boundObjectHandler != null)
						{
							boundObjectHandler(this, new global::CefSharp.Event.JavascriptBindingCompleteEventArgs(this, tuple.Item1, tuple.Item2, tuple.Item3));
						}
					}
					global::System.EventHandler<global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs> boundObjectsHandler = boundObjectsHandler;
					if (boundObjectsHandler == null)
					{
						return;
					}
					boundObjectsHandler(this, new global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs(this, (from x in objs
					select x.Item1).ToList<string>()));
				});
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000A670 File Offset: 0x00008870
		private global::CefSharp.Internals.JavascriptObject CreateJavascriptObject(bool rootObject)
		{
			long num = global::System.Threading.Interlocked.Increment(ref global::CefSharp.Internals.JavascriptObjectRepository.lastId);
			global::CefSharp.Internals.JavascriptObject javascriptObject = new global::CefSharp.Internals.JavascriptObject
			{
				Id = num,
				RootObject = rootObject
			};
			this.objects[num] = javascriptObject;
			return javascriptObject;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000A6AC File Offset: 0x000088AC
		public void Register(string name, object value, bool isAsync, global::CefSharp.BindingOptions options)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			base.Freeze();
			if (!this.IsBrowserInitialized && !isAsync)
			{
				global::CefSharp.CefSharpSettings.WcfEnabled = true;
			}
			if (!global::CefSharp.CefSharpSettings.WcfEnabled && !isAsync)
			{
				throw new global::System.InvalidOperationException("To enable synchronous JS bindings set WcfEnabled true in CefSharpSettings before you create\n                                                    your ChromiumWebBrowser instances.");
			}
			if (this.objects.Values.Count((global::CefSharp.Internals.JavascriptObject x) => string.Equals(x.Name, name, global::System.StringComparison.OrdinalIgnoreCase)) > 0)
			{
				throw new global::System.ArgumentException("Object already bound with name:" + name, name);
			}
			global::System.Type type = value.GetType();
			if (type.IsPrimitive || type.BaseType.Namespace.StartsWith("System."))
			{
				throw new global::System.ArgumentException("Registering of .Net framework built in types is not supported, create your own Object and proxy the calls if you need to access a Window/Form/Control.", "value");
			}
			global::CefSharp.Internals.JavascriptObject javascriptObject = this.CreateJavascriptObject(true);
			javascriptObject.Value = value;
			javascriptObject.Name = name;
			javascriptObject.JavascriptName = name;
			javascriptObject.IsAsync = isAsync;
			javascriptObject.Binder = ((options != null) ? options.Binder : null);
			javascriptObject.MethodInterceptor = ((options != null) ? options.MethodInterceptor : null);
			javascriptObject.PropertyInterceptor = ((options != null) ? options.PropertyInterceptor : null);
			this.AnalyseObjectForBinding(javascriptObject, true, !isAsync, false);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000A7FB File Offset: 0x000089FB
		public void UnRegisterAll()
		{
			this.objects.Clear();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000A808 File Offset: 0x00008A08
		public bool UnRegister(string name)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<long, global::CefSharp.Internals.JavascriptObject> keyValuePair in this.objects)
			{
				if (string.Equals(keyValuePair.Value.Name, name, global::System.StringComparison.OrdinalIgnoreCase))
				{
					global::CefSharp.Internals.JavascriptObject javascriptObject;
					this.objects.TryRemove(keyValuePair.Key, out javascriptObject);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000A880 File Offset: 0x00008A80
		global::CefSharp.Internals.TryCallMethodResult global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.TryCallMethod(long objectId, string name, object[] parameters)
		{
			return this.TryCallMethod(objectId, name, parameters);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000A88C File Offset: 0x00008A8C
		protected virtual global::CefSharp.Internals.TryCallMethodResult TryCallMethod(long objectId, string name, object[] parameters)
		{
			string exception = "";
			object obj2 = null;
			global::CefSharp.Internals.JavascriptObject obj;
			if (!this.objects.TryGetValue(objectId, out obj))
			{
				int num = (parameters == null) ? 0 : parameters.Length;
				return new global::CefSharp.Internals.TryCallMethodResult(false, obj2, string.Format("Object Not Found Matching Id:{0}, MethodName:{1}, ParamCount:{2}", objectId, name, num));
			}
			global::CefSharp.Internals.JavascriptMethod method = obj.Methods.FirstOrDefault((global::CefSharp.Internals.JavascriptMethod p) => p.JavascriptName == name);
			if (method == null)
			{
				throw new global::System.InvalidOperationException(string.Format("Method {0} not found on Object of Type {1}", name, obj.Value.GetType()));
			}
			try
			{
				if (method.HasParamArray)
				{
					global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>(method.Parameters.Count);
					for (int i = 0; i < method.Parameters.Count; i++)
					{
						if (method.Parameters[i].IsParamArray)
						{
							global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
							for (int j = i; j < parameters.Length; j++)
							{
								list2.Add(parameters[j]);
							}
							list.Add(list2.ToArray());
						}
						else
						{
							object item = parameters.ElementAtOrDefault(i);
							list.Add(item);
						}
					}
					parameters = list.ToArray();
				}
				int num2 = 0;
				try
				{
					if (obj.Binder != null)
					{
						for (int k = 0; k < parameters.Length; k++)
						{
							global::System.Type type = method.Parameters[k].Type;
							parameters[k] = obj.Binder.Bind(parameters[k], type);
						}
					}
					num2 = method.ParameterCount - parameters.Length;
					if (num2 > 0)
					{
						global::System.Collections.Generic.List<object> list3 = new global::System.Collections.Generic.List<object>(parameters);
						for (int l = 0; l < num2; l++)
						{
							list3.Add(global::System.Type.Missing);
						}
						parameters = list3.ToArray();
					}
					if (obj.MethodInterceptor == null)
					{
						obj2 = method.Function(obj.Value, parameters);
					}
					else
					{
						obj2 = obj.MethodInterceptor.Intercept((object[] p) => method.Function(obj.Value, p), parameters, method.ManagedName);
					}
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"Could not execute method: ",
						name,
						"(",
						string.Join(", ", parameters),
						") ",
						(num2 > 0) ? ("- Missing Parameters: " + num2.ToString()) : ""
					}), innerException);
				}
				if (!obj.IsAsync && obj2 != null && global::CefSharp.Internals.JavascriptObjectRepository.IsComplexType(obj2.GetType()))
				{
					global::CefSharp.Internals.JavascriptObject javascriptObject = this.CreateJavascriptObject(false);
					javascriptObject.Value = obj2;
					javascriptObject.Name = "FunctionResult(" + name + ")";
					javascriptObject.JavascriptName = javascriptObject.Name;
					this.AnalyseObjectForBinding(javascriptObject, false, true, true);
					obj2 = javascriptObject;
				}
				return new global::CefSharp.Internals.TryCallMethodResult(true, obj2, exception);
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				global::System.Exception baseException = ex.GetBaseException();
				exception = baseException.ToString();
			}
			catch (global::System.Exception ex2)
			{
				exception = ex2.ToString();
			}
			return new global::CefSharp.Internals.TryCallMethodResult(false, obj2, exception);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000AC30 File Offset: 0x00008E30
		global::System.Threading.Tasks.Task<global::CefSharp.Internals.TryCallMethodResult> global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.TryCallMethodAsync(long objectId, string name, object[] parameters)
		{
			return this.TryCallMethodAsync(objectId, name, parameters);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000AC3C File Offset: 0x00008E3C
		protected virtual global::System.Threading.Tasks.Task<global::CefSharp.Internals.TryCallMethodResult> TryCallMethodAsync(long objectId, string name, object[] parameters)
		{
			global::CefSharp.Internals.JavascriptObjectRepository.<TryCallMethodAsync>d__40 <TryCallMethodAsync>d__;
			<TryCallMethodAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.Internals.TryCallMethodResult>.Create();
			<TryCallMethodAsync>d__.<>4__this = this;
			<TryCallMethodAsync>d__.objectId = objectId;
			<TryCallMethodAsync>d__.name = name;
			<TryCallMethodAsync>d__.parameters = parameters;
			<TryCallMethodAsync>d__.<>1__state = -1;
			<TryCallMethodAsync>d__.<>t__builder.Start<global::CefSharp.Internals.JavascriptObjectRepository.<TryCallMethodAsync>d__40>(ref <TryCallMethodAsync>d__);
			return <TryCallMethodAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000AC97 File Offset: 0x00008E97
		bool global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.TryGetProperty(long objectId, string name, out object result, out string exception)
		{
			return this.TryGetProperty(objectId, name, out result, out exception);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		protected virtual bool TryGetProperty(long objectId, string name, out object result, out string exception)
		{
			exception = "";
			result = null;
			global::CefSharp.Internals.JavascriptObject obj;
			if (!this.objects.TryGetValue(objectId, out obj))
			{
				return false;
			}
			global::CefSharp.Internals.JavascriptProperty property = obj.Properties.FirstOrDefault((global::CefSharp.Internals.JavascriptProperty p) => p.JavascriptName == name);
			if (property == null)
			{
				throw new global::System.InvalidOperationException(string.Format("Property {0} not found on Object of Type {1}", name, obj.Value.GetType()));
			}
			try
			{
				if (obj.PropertyInterceptor == null)
				{
					result = property.GetValue(obj.Value);
				}
				else
				{
					result = obj.PropertyInterceptor.InterceptGet(() => property.GetValue(obj.Value), property.ManagedName);
				}
				return true;
			}
			catch (global::System.Exception ex)
			{
				exception = ex.ToString();
			}
			return false;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		bool global::CefSharp.Internals.IJavascriptObjectRepositoryInternal.TrySetProperty(long objectId, string name, object value, out string exception)
		{
			return this.TrySetProperty(objectId, name, value, out exception);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		protected virtual bool TrySetProperty(long objectId, string name, object value, out string exception)
		{
			exception = "";
			global::CefSharp.Internals.JavascriptObject obj;
			if (!this.objects.TryGetValue(objectId, out obj))
			{
				return false;
			}
			global::CefSharp.Internals.JavascriptProperty property = obj.Properties.FirstOrDefault((global::CefSharp.Internals.JavascriptProperty p) => p.JavascriptName == name);
			if (property == null)
			{
				throw new global::System.InvalidOperationException(string.Format("Property {0} not found on Object of Type {1}", name, obj.Value.GetType()));
			}
			try
			{
				if (obj.PropertyInterceptor == null)
				{
					property.SetValue(obj.Value, value);
				}
				else
				{
					obj.PropertyInterceptor.InterceptSet(delegate(object p)
					{
						property.SetValue(obj.Value, p);
					}, value, property.ManagedName);
				}
				return true;
			}
			catch (global::System.Exception ex)
			{
				exception = ex.ToString();
			}
			return false;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000AEB8 File Offset: 0x000090B8
		private void AnalyseObjectForBinding(global::CefSharp.Internals.JavascriptObject obj, bool analyseMethods, bool analyseProperties, bool readPropertyValue)
		{
			if (obj.Value == null)
			{
				return;
			}
			global::System.Type type = obj.Value.GetType();
			if (type.IsPrimitive || type == typeof(string))
			{
				return;
			}
			if (analyseMethods)
			{
				foreach (global::System.Reflection.MethodInfo methodInfo in from p in type.GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public)
				where !p.IsSpecialName
				select p)
				{
					if (!(methodInfo.ReturnType == typeof(global::System.Type)) && !global::System.Attribute.IsDefined(methodInfo, typeof(global::CefSharp.JavascriptIgnoreAttribute)))
					{
						global::CefSharp.Internals.JavascriptMethod item = global::CefSharp.Internals.JavascriptObjectRepository.CreateJavaScriptMethod(methodInfo, this.nameConverter);
						obj.Methods.Add(item);
					}
				}
			}
			if (analyseProperties)
			{
				foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public)
				where !p.IsSpecialName
				select p)
				{
					bool flag = propertyInfo.GetIndexParameters().Length != 0;
					bool flag2 = global::System.Attribute.IsDefined(propertyInfo, typeof(global::CefSharp.JavascriptIgnoreAttribute));
					if (!(propertyInfo.PropertyType == typeof(global::System.Type)) && !flag && !flag2)
					{
						global::CefSharp.Internals.JavascriptProperty javascriptProperty = this.CreateJavaScriptProperty(propertyInfo);
						if (javascriptProperty.IsComplexType)
						{
							global::CefSharp.Internals.JavascriptObject javascriptObject = this.CreateJavascriptObject(false);
							javascriptObject.Name = propertyInfo.Name;
							javascriptObject.JavascriptName = ((this.nameConverter == null) ? propertyInfo.Name : this.nameConverter.ConvertToJavascript(propertyInfo));
							javascriptObject.Value = javascriptProperty.GetValue(obj.Value);
							javascriptProperty.JsObject = javascriptObject;
							this.AnalyseObjectForBinding(javascriptProperty.JsObject, analyseMethods, true, readPropertyValue);
						}
						else if (readPropertyValue)
						{
							javascriptProperty.PropertyValue = javascriptProperty.GetValue(obj.Value);
						}
						obj.Properties.Add(javascriptProperty);
					}
				}
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000B110 File Offset: 0x00009310
		private void RaiseResolveObjectEvent(string name)
		{
			global::System.EventHandler<global::CefSharp.Event.JavascriptBindingEventArgs> resolveObject = this.ResolveObject;
			if (resolveObject == null)
			{
				return;
			}
			resolveObject(this, new global::CefSharp.Event.JavascriptBindingEventArgs(this, name));
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000B12C File Offset: 0x0000932C
		private static global::CefSharp.Internals.JavascriptMethod CreateJavaScriptMethod(global::System.Reflection.MethodInfo methodInfo, global::CefSharp.JavascriptBinding.IJavascriptNameConverter nameConverter)
		{
			global::CefSharp.Internals.JavascriptMethod javascriptMethod = new global::CefSharp.Internals.JavascriptMethod();
			javascriptMethod.ManagedName = methodInfo.Name;
			javascriptMethod.JavascriptName = ((nameConverter == null) ? methodInfo.Name : nameConverter.ConvertToJavascript(methodInfo));
			javascriptMethod.Function = new global::System.Func<object, object[], object>(methodInfo.Invoke);
			javascriptMethod.ReturnType = methodInfo.ReturnType;
			javascriptMethod.ParameterCount = methodInfo.GetParameters().Length;
			javascriptMethod.Parameters = (from t in methodInfo.GetParameters()
			select new global::CefSharp.Internals.MethodParameter
			{
				IsParamArray = (t.GetCustomAttributes(typeof(global::System.ParamArrayAttribute), false).Length != 0),
				Type = t.ParameterType
			}).ToList<global::CefSharp.Internals.MethodParameter>();
			javascriptMethod.HasParamArray = (javascriptMethod.Parameters.LastOrDefault((global::CefSharp.Internals.MethodParameter t) => t.IsParamArray) != null);
			return javascriptMethod;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000B1FC File Offset: 0x000093FC
		private global::CefSharp.Internals.JavascriptProperty CreateJavaScriptProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			return new global::CefSharp.Internals.JavascriptProperty
			{
				ManagedName = propertyInfo.Name,
				JavascriptName = ((this.nameConverter == null) ? propertyInfo.Name : this.nameConverter.ConvertToJavascript(propertyInfo)),
				SetValue = delegate(object o, object v)
				{
					propertyInfo.SetValue(o, v, null);
				},
				GetValue = ((object o) => propertyInfo.GetValue(o, null)),
				IsComplexType = global::CefSharp.Internals.JavascriptObjectRepository.IsComplexType(propertyInfo.PropertyType),
				IsReadOnly = !propertyInfo.CanWrite
			};
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000B2A8 File Offset: 0x000094A8
		private static bool IsComplexType(global::System.Type type)
		{
			if (type == typeof(void))
			{
				return false;
			}
			global::System.Type type2 = type;
			bool flag = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>);
			if (flag)
			{
				type2 = global::System.Nullable.GetUnderlyingType(type);
			}
			if (!(type2 == null) && !type2.IsArray)
			{
				string @namespace = type2.Namespace;
				if (@namespace == null || !@namespace.StartsWith("System"))
				{
					return (!type2.IsValueType || type2.IsPrimitive || type2.IsEnum) && !type2.IsPrimitive && type2 != typeof(string);
				}
			}
			return false;
		}

		// Token: 0x04000399 RID: 921
		public const string AllObjects = "All";

		// Token: 0x0400039A RID: 922
		public const string LegacyObjects = "Legacy";

		// Token: 0x0400039B RID: 923
		private static long lastId;

		// Token: 0x0400039F RID: 927
		protected readonly global::System.Collections.Concurrent.ConcurrentDictionary<long, global::CefSharp.Internals.JavascriptObject> objects = new global::System.Collections.Concurrent.ConcurrentDictionary<long, global::CefSharp.Internals.JavascriptObject>();

		// Token: 0x040003A0 RID: 928
		private global::CefSharp.JavascriptBinding.IJavascriptNameConverter nameConverter;
	}
}
