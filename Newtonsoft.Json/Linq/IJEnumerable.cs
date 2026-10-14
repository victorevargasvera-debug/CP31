using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B8 RID: 184
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public interface IJEnumerable<[global::System.Runtime.CompilerServices.Nullable(0)] out T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable where T : global::Newtonsoft.Json.Linq.JToken
	{
		// Token: 0x170001BA RID: 442
		global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> this[object key]
		{
			get;
		}
	}
}
