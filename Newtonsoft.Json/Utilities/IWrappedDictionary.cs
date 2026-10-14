using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004D RID: 77
	internal interface IWrappedDictionary : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004A6 RID: 1190
		[global::System.Runtime.CompilerServices.Nullable(1)]
		object UnderlyingDictionary { [global::System.Runtime.CompilerServices.NullableContext(1)] get; }
	}
}
