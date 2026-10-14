using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000044 RID: 68
	internal interface IWrappedCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000449 RID: 1097
		[global::System.Runtime.CompilerServices.Nullable(1)]
		object UnderlyingCollection { [global::System.Runtime.CompilerServices.NullableContext(1)] get; }
	}
}
