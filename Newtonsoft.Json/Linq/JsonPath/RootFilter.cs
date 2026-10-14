using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000DB RID: 219
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class RootFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x00030973 File Offset: 0x0002EB73
		private RootFilter()
		{
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0003097B File Offset: 0x0002EB7B
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			return new global::Newtonsoft.Json.Linq.JToken[]
			{
				root
			};
		}

		// Token: 0x040003CD RID: 973
		public static readonly global::Newtonsoft.Json.Linq.JsonPath.RootFilter Instance = new global::Newtonsoft.Json.Linq.JsonPath.RootFilter();
	}
}
