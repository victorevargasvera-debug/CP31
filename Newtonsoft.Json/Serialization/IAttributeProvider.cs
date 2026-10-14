using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007D RID: 125
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public interface IAttributeProvider
	{
		// Token: 0x06000678 RID: 1656
		global::System.Collections.Generic.IList<global::System.Attribute> GetAttributes(bool inherit);

		// Token: 0x06000679 RID: 1657
		global::System.Collections.Generic.IList<global::System.Attribute> GetAttributes(global::System.Type attributeType, bool inherit);
	}
}
