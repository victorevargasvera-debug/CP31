using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class LateBoundReflectionDelegateFactory : global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001727F File Offset: 0x0001547F
		internal static global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory Instance
		{
			get
			{
				return global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory._instance;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00017288 File Offset: 0x00015488
		public override global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(global::System.Reflection.MethodBase method)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(method, "method");
			global::System.Reflection.ConstructorInfo c = method as global::System.Reflection.ConstructorInfo;
			if (c != null)
			{
				return ([global::System.Runtime.CompilerServices.Nullable(new byte[]
				{
					1,
					2
				})] object[] a) => c.Invoke(a);
			}
			return ([global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				2
			})] object[] a) => method.Invoke(null, a);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000172E4 File Offset: 0x000154E4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MethodBase method)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(method, "method");
			global::System.Reflection.ConstructorInfo c = method as global::System.Reflection.ConstructorInfo;
			if (c != null)
			{
				return (T o, [global::System.Runtime.CompilerServices.Nullable(new byte[]
				{
					1,
					2
				})] object[] a) => c.Invoke(a);
			}
			return (T o, [global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				2
			})] object[] a) => method.Invoke(o, a);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00017340 File Offset: 0x00015540
		public override global::System.Func<T> CreateDefaultConstructor<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Type type)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			if (type.IsValueType())
			{
				return () => (T)((object)global::System.Activator.CreateInstance(type));
			}
			global::System.Reflection.ConstructorInfo constructorInfo = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDefaultConstructor(type, true);
			return () => (T)((object)constructorInfo.Invoke(null));
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000173A2 File Offset: 0x000155A2
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			return (T o) => propertyInfo.GetValue(o, null);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000173CB File Offset: 0x000155CB
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			return (T o) => fieldInfo.GetValue(o);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000173F4 File Offset: 0x000155F4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			return delegate(T o, [global::System.Runtime.CompilerServices.Nullable(2)] object v)
			{
				fieldInfo.SetValue(o, v);
			};
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001741D File Offset: 0x0001561D
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			return delegate(T o, [global::System.Runtime.CompilerServices.Nullable(2)] object v)
			{
				propertyInfo.SetValue(o, v, null);
			};
		}

		// Token: 0x040001FA RID: 506
		private static readonly global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory _instance = new global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory();
	}
}
