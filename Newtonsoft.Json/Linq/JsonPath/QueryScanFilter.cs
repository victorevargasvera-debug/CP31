using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000DA RID: 218
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class QueryScanFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x0003093F File Offset: 0x0002EB3F
		public QueryScanFilter(global::Newtonsoft.Json.Linq.JsonPath.QueryExpression expression)
		{
			this.Expression = expression;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0003094E File Offset: 0x0002EB4E
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in current)
			{
				global::Newtonsoft.Json.Linq.JContainer jcontainer = jtoken as global::Newtonsoft.Json.Linq.JContainer;
				if (jcontainer != null)
				{
					foreach (global::Newtonsoft.Json.Linq.JToken jtoken2 in jcontainer.DescendantsAndSelf())
					{
						if (this.Expression.IsMatch(root, jtoken2, settings))
						{
							yield return jtoken2;
						}
					}
					global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = null;
				}
				else if (this.Expression.IsMatch(root, jtoken, settings))
				{
					yield return jtoken;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003CC RID: 972
		internal global::Newtonsoft.Json.Linq.JsonPath.QueryExpression Expression;
	}
}
