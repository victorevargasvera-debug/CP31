using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D6 RID: 214
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class QueryExpression
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x000303BD File Offset: 0x0002E5BD
		public QueryExpression(global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator)
		{
			this.Operator = @operator;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000303CC File Offset: 0x0002E5CC
		public bool IsMatch(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t)
		{
			return this.IsMatch(root, t, null);
		}

		// Token: 0x06000C0C RID: 3084
		public abstract bool IsMatch(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings);

		// Token: 0x040003C7 RID: 967
		internal global::Newtonsoft.Json.Linq.JsonPath.QueryOperator Operator;
	}
}
