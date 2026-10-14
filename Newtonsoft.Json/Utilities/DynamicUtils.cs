using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000052 RID: 82
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class DynamicUtils
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x0001516D File Offset: 0x0001336D
		public static global::System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(this global::System.Dynamic.IDynamicMetaObjectProvider dynamicProvider)
		{
			return dynamicProvider.GetMetaObject(global::System.Linq.Expressions.Expression.Constant(dynamicProvider)).GetDynamicMemberNames();
		}

		// Token: 0x02000179 RID: 377
		[global::System.Runtime.CompilerServices.Nullable(0)]
		internal static class BinderWrapper
		{
			// Token: 0x06000EB9 RID: 3769 RVA: 0x00041814 File Offset: 0x0003FA14
			private static void Init()
			{
				if (!global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._init)
				{
					if (global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) == null)
					{
						throw new global::System.InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
					}
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._getCSharpArgumentInfoArray = global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.CreateSharpArgumentInfoArray(new int[1]);
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._setCSharpArgumentInfoArray = global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.CreateSharpArgumentInfoArray(new int[]
					{
						0,
						3
					});
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.CreateMemberCalls();
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._init = true;
				}
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x00041884 File Offset: 0x0003FA84
			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				global::System.Type type = global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				global::System.Type type2 = global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				global::System.Array array = global::System.Array.CreateInstance(type, values.Length);
				for (int i = 0; i < values.Length; i++)
				{
					global::System.Reflection.MethodBase method = type.GetMethod("Create", new global::System.Type[]
					{
						type2,
						typeof(string)
					});
					object obj = null;
					object[] array2 = new object[2];
					array2[0] = 0;
					object value = method.Invoke(obj, array2);
					array.SetValue(value, i);
				}
				return array;
			}

			// Token: 0x06000EBB RID: 3771 RVA: 0x00041904 File Offset: 0x0003FB04
			private static void CreateMemberCalls()
			{
				global::System.Type type = global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				global::System.Type type2 = global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				global::System.Type type3 = global::System.Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				global::System.Type type4 = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
				{
					type
				});
				global::System.Reflection.MethodInfo method = type3.GetMethod("GetMember", new global::System.Type[]
				{
					type2,
					typeof(string),
					typeof(global::System.Type),
					type4
				});
				global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._getMemberCall = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
				global::System.Reflection.MethodInfo method2 = type3.GetMethod("SetMember", new global::System.Type[]
				{
					type2,
					typeof(string),
					typeof(global::System.Type),
					type4
				});
				global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._setMemberCall = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method2);
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x000419DB File Offset: 0x0003FBDB
			public static global::System.Runtime.CompilerServices.CallSiteBinder GetMember(string name, global::System.Type context)
			{
				global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.Init();
				return (global::System.Runtime.CompilerServices.CallSiteBinder)global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._getMemberCall(null, new object[]
				{
					0,
					name,
					context,
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._getCSharpArgumentInfoArray
				});
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x00041A11 File Offset: 0x0003FC11
			public static global::System.Runtime.CompilerServices.CallSiteBinder SetMember(string name, global::System.Type context)
			{
				global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.Init();
				return (global::System.Runtime.CompilerServices.CallSiteBinder)global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._setMemberCall(null, new object[]
				{
					0,
					name,
					context,
					global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper._setCSharpArgumentInfoArray
				});
			}

			// Token: 0x040006A4 RID: 1700
			public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x040006A5 RID: 1701
			private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x040006A6 RID: 1702
			private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x040006A7 RID: 1703
			private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x040006A8 RID: 1704
			private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x040006A9 RID: 1705
			[global::System.Runtime.CompilerServices.Nullable(2)]
			private static object _getCSharpArgumentInfoArray;

			// Token: 0x040006AA RID: 1706
			[global::System.Runtime.CompilerServices.Nullable(2)]
			private static object _setCSharpArgumentInfoArray;

			// Token: 0x040006AB RID: 1707
			[global::System.Runtime.CompilerServices.Nullable(2)]
			private static global::Newtonsoft.Json.Utilities.MethodCall<object, object> _getMemberCall;

			// Token: 0x040006AC RID: 1708
			[global::System.Runtime.CompilerServices.Nullable(2)]
			private static global::Newtonsoft.Json.Utilities.MethodCall<object, object> _setMemberCall;

			// Token: 0x040006AD RID: 1709
			private static bool _init;
		}
	}
}
