using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D9 RID: 217
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class QueryFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x0003090B File Offset: 0x0002EB0B
		public QueryFilter(global::Newtonsoft.Json.Linq.JsonPath.QueryExpression expression)
		{
			this.Expression = expression;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0003091A File Offset: 0x0002EB1A
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in current)
			{
				foreach (global::Newtonsoft.Json.Linq.JToken jtoken2 in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)jtoken))
				{
					if (this.Expression.IsMatch(root, jtoken2, settings))
					{
						yield return jtoken2;
					}
				}
				global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003CB RID: 971
		internal global::Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression;
	}
}
