using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D7 RID: 215
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class CompositeExpression : global::Newtonsoft.Json.Linq.JsonPath.QueryExpression
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000303D7 File Offset: 0x0002E5D7
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000303DF File Offset: 0x0002E5DF
		public global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.QueryExpression> Expressions { get; set; }

		// Token: 0x06000C0F RID: 3087 RVA: 0x000303E8 File Offset: 0x0002E5E8
		public CompositeExpression(global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator) : base(@operator)
		{
			this.Expressions = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.QueryExpression>();
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000303FC File Offset: 0x0002E5FC
		public override bool IsMatch(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator = this.Operator;
			if (@operator == global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.And)
			{
				using (global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.QueryExpression>.Enumerator enumerator = this.Expressions.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsMatch(root, t, settings))
						{
							return false;
						}
					}
				}
				return true;
			}
			if (@operator != global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Or)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			using (global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.QueryExpression>.Enumerator enumerator = this.Expressions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsMatch(root, t, settings))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
