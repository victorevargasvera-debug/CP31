using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005A RID: 90
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class FSharpUtils
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x0001610C File Offset: 0x0001430C
		private FSharpUtils(global::System.Reflection.Assembly fsharpCoreAssembly)
		{
			this.FSharpCoreAssembly = fsharpCoreAssembly;
			global::System.Type type = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpType");
			global::System.Reflection.MethodInfo methodWithNonPublicFallback = global::Newtonsoft.Json.Utilities.FSharpUtils.GetMethodWithNonPublicFallback(type, "IsUnion", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			this.IsUnion = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodWithNonPublicFallback);
			global::System.Reflection.MethodInfo methodWithNonPublicFallback2 = global::Newtonsoft.Json.Utilities.FSharpUtils.GetMethodWithNonPublicFallback(type, "GetUnionCases", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			this.GetUnionCases = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodWithNonPublicFallback2);
			global::System.Type type2 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpValue");
			this.PreComputeUnionTagReader = global::Newtonsoft.Json.Utilities.FSharpUtils.CreateFSharpFuncCall(type2, "PreComputeUnionTagReader");
			this.PreComputeUnionReader = global::Newtonsoft.Json.Utilities.FSharpUtils.CreateFSharpFuncCall(type2, "PreComputeUnionReader");
			this.PreComputeUnionConstructor = global::Newtonsoft.Json.Utilities.FSharpUtils.CreateFSharpFuncCall(type2, "PreComputeUnionConstructor");
			global::System.Type type3 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
			this.GetUnionCaseInfoName = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty("Name"));
			this.GetUnionCaseInfoTag = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty("Tag"));
			this.GetUnionCaseInfoDeclaringType = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(type3.GetProperty("DeclaringType"));
			this.GetUnionCaseInfoFields = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(type3.GetMethod("GetFields"));
			global::System.Type type4 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.ListModule");
			this._ofSeq = type4.GetMethod("OfSeq");
			this._mapType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00016255 File Offset: 0x00014455
		public static global::Newtonsoft.Json.Utilities.FSharpUtils Instance
		{
			get
			{
				return global::Newtonsoft.Json.Utilities.FSharpUtils._instance;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001625C File Offset: 0x0001445C
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00016264 File Offset: 0x00014464
		public global::System.Reflection.Assembly FSharpCoreAssembly { get; private set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001626D File Offset: 0x0001446D
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00016275 File Offset: 0x00014475
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> IsUnion { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] private set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001627E File Offset: 0x0001447E
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00016286 File Offset: 0x00014486
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> GetUnionCases { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] private set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001628F File Offset: 0x0001448F
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00016297 File Offset: 0x00014497
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> PreComputeUnionTagReader { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] private set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000162A0 File Offset: 0x000144A0
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000162A8 File Offset: 0x000144A8
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> PreComputeUnionReader { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] private set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000162B1 File Offset: 0x000144B1
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000162B9 File Offset: 0x000144B9
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> PreComputeUnionConstructor { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] private set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000162C2 File Offset: 0x000144C2
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000162CA File Offset: 0x000144CA
		public global::System.Func<object, object> GetUnionCaseInfoDeclaringType { get; private set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000162D3 File Offset: 0x000144D3
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000162DB File Offset: 0x000144DB
		public global::System.Func<object, object> GetUnionCaseInfoName { get; private set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000162E4 File Offset: 0x000144E4
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000162EC File Offset: 0x000144EC
		public global::System.Func<object, object> GetUnionCaseInfoTag { get; private set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000162F5 File Offset: 0x000144F5
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000162FD File Offset: 0x000144FD
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public global::Newtonsoft.Json.Utilities.MethodCall<object, object> GetUnionCaseInfoFields { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})] private set; }

		// Token: 0x06000539 RID: 1337 RVA: 0x00016308 File Offset: 0x00014508
		public static void EnsureInitialized(global::System.Reflection.Assembly fsharpCoreAssembly)
		{
			if (global::Newtonsoft.Json.Utilities.FSharpUtils._instance == null)
			{
				object @lock = global::Newtonsoft.Json.Utilities.FSharpUtils.Lock;
				lock (@lock)
				{
					if (global::Newtonsoft.Json.Utilities.FSharpUtils._instance == null)
					{
						global::Newtonsoft.Json.Utilities.FSharpUtils._instance = new global::Newtonsoft.Json.Utilities.FSharpUtils(fsharpCoreAssembly);
					}
				}
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001635C File Offset: 0x0001455C
		private static global::System.Reflection.MethodInfo GetMethodWithNonPublicFallback(global::System.Type type, string methodName, global::System.Reflection.BindingFlags bindingFlags)
		{
			global::System.Reflection.MethodInfo method = type.GetMethod(methodName, bindingFlags);
			if (method == null && (bindingFlags & global::System.Reflection.BindingFlags.NonPublic) != global::System.Reflection.BindingFlags.NonPublic)
			{
				method = type.GetMethod(methodName, bindingFlags | global::System.Reflection.BindingFlags.NonPublic);
			}
			return method;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00016390 File Offset: 0x00014590
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private static global::Newtonsoft.Json.Utilities.MethodCall<object, object> CreateFSharpFuncCall(global::System.Type type, string methodName)
		{
			global::System.Reflection.MethodInfo methodWithNonPublicFallback = global::Newtonsoft.Json.Utilities.FSharpUtils.GetMethodWithNonPublicFallback(type, methodName, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			global::System.Reflection.MethodInfo method = methodWithNonPublicFallback.ReturnType.GetMethod("Invoke", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> call = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodWithNonPublicFallback);
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> invoke = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
			return ([global::System.Runtime.CompilerServices.Nullable(2)] object target, [global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				2
			})] object[] args) => new global::Newtonsoft.Json.Utilities.FSharpFunction(call(target, args), invoke);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000163EC File Offset: 0x000145EC
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateSeq(global::System.Type t)
		{
			global::System.Reflection.MethodInfo method = this._ofSeq.MakeGenericMethod(new global::System.Type[]
			{
				t
			});
			return global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(method);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001641A File Offset: 0x0001461A
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateMap(global::System.Type keyType, global::System.Type valueType)
		{
			return (global::Newtonsoft.Json.Serialization.ObjectConstructor<object>)typeof(global::Newtonsoft.Json.Utilities.FSharpUtils).GetMethod("BuildMapCreator").MakeGenericMethod(new global::System.Type[]
			{
				keyType,
				valueType
			}).Invoke(this, null);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00016450 File Offset: 0x00014650
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
		{
			global::System.Reflection.ConstructorInfo constructor = this._mapType.MakeGenericType(new global::System.Type[]
			{
				typeof(TKey),
				typeof(TValue)
			}).GetConstructor(new global::System.Type[]
			{
				typeof(global::System.Collections.Generic.IEnumerable<global::System.Tuple<TKey, TValue>>)
			});
			global::Newtonsoft.Json.Serialization.ObjectConstructor<object> ctorDelegate = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
			return delegate([global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				2
			})] object[] args)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Tuple<TKey, TValue>> enumerable = from kv in (global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>)args[0]
				select new global::System.Tuple<TKey, TValue>(kv.Key, kv.Value);
				return ctorDelegate(new object[]
				{
					enumerable
				});
			};
		}

		// Token: 0x040001CD RID: 461
		private static readonly object Lock = new object();

		// Token: 0x040001CE RID: 462
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Utilities.FSharpUtils _instance;

		// Token: 0x040001CF RID: 463
		private global::System.Reflection.MethodInfo _ofSeq;

		// Token: 0x040001D0 RID: 464
		private global::System.Type _mapType;

		// Token: 0x040001DB RID: 475
		public const string FSharpSetTypeName = "FSharpSet`1";

		// Token: 0x040001DC RID: 476
		public const string FSharpListTypeName = "FSharpList`1";

		// Token: 0x040001DD RID: 477
		public const string FSharpMapTypeName = "FSharpMap`2";
	}
}
