using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C6 RID: 198
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JTokenEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::Newtonsoft.Json.Linq.JToken>
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x0002D2A6 File Offset: 0x0002B4A6
		public bool Equals(global::Newtonsoft.Json.Linq.JToken x, global::Newtonsoft.Json.Linq.JToken y)
		{
			return global::Newtonsoft.Json.Linq.JToken.DeepEquals(x, y);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002D2AF File Offset: 0x0002B4AF
		public int GetHashCode(global::Newtonsoft.Json.Linq.JToken obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetDeepHashCode();
		}
	}
}
