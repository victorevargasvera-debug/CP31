using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000080 RID: 128
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public interface ISerializationBinder
	{
		// Token: 0x0600067F RID: 1663
		global::System.Type BindToType([global::System.Runtime.CompilerServices.Nullable(2)] string assemblyName, string typeName);

		// Token: 0x06000680 RID: 1664
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		void BindToName([global::System.Runtime.CompilerServices.Nullable(1)] global::System.Type serializedType, out string assemblyName, out string typeName);
	}
}
