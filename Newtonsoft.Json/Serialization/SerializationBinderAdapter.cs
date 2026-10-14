using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A1 RID: 161
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class SerializationBinderAdapter : global::Newtonsoft.Json.Serialization.ISerializationBinder
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x00023D08 File Offset: 0x00021F08
		public SerializationBinderAdapter(global::System.Runtime.Serialization.SerializationBinder serializationBinder)
		{
			this.SerializationBinder = serializationBinder;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00023D17 File Offset: 0x00021F17
		public global::System.Type BindToType([global::System.Runtime.CompilerServices.Nullable(2)] string assemblyName, string typeName)
		{
			return this.SerializationBinder.BindToType(assemblyName, typeName);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00023D26 File Offset: 0x00021F26
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void BindToName([global::System.Runtime.CompilerServices.Nullable(1)] global::System.Type serializedType, out string assemblyName, out string typeName)
		{
			this.SerializationBinder.BindToName(serializedType, out assemblyName, out typeName);
		}

		// Token: 0x040002CA RID: 714
		public readonly global::System.Runtime.Serialization.SerializationBinder SerializationBinder;
	}
}
