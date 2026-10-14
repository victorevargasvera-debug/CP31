using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000009 RID: 9
	[global::System.Runtime.CompilerServices.b(1)]
	public interface IBinarySerializerRecord
	{
		// Token: 0x06000033 RID: 51
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			2,
			1
		})]
		global::System.Collections.Generic.IList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> GetTypes();

		// Token: 0x06000034 RID: 52
		global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult Verify(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes);
	}
}
