using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000059 RID: 89
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class FSharpFunction
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x000160E1 File Offset: 0x000142E1
		public FSharpFunction(object instance, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})] global::Newtonsoft.Json.Utilities.MethodCall<object, object> invoker)
		{
			this._instance = instance;
			this._invoker = invoker;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000160F7 File Offset: 0x000142F7
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public object Invoke(params object[] args)
		{
			return this._invoker(this._instance, args);
		}

		// Token: 0x040001CB RID: 459
		private readonly object _instance;

		// Token: 0x040001CC RID: 460
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly global::Newtonsoft.Json.Utilities.MethodCall<object, object> _invoker;
	}
}
