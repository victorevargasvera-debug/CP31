using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CE RID: 206
	internal class ArrayIndexFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002EFF1 File Offset: 0x0002D1F1
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0002EFF9 File Offset: 0x0002D1F9
		public int? Index { get; set; }

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002F002 File Offset: 0x0002D202
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in current)
			{
				if (this.Index != null)
				{
					global::Newtonsoft.Json.Linq.JToken tokenIndex = global::Newtonsoft.Json.Linq.JsonPath.PathFilter.GetTokenIndex(jtoken, settings, this.Index.GetValueOrDefault());
					if (tokenIndex != null)
					{
						yield return tokenIndex;
					}
				}
				else if (jtoken is global::Newtonsoft.Json.Linq.JArray || jtoken is global::Newtonsoft.Json.Linq.JConstructor)
				{
					foreach (global::Newtonsoft.Json.Linq.JToken jtoken2 in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)jtoken))
					{
						yield return jtoken2;
					}
					global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = null;
				}
				else if (settings != null && settings.ErrorWhenNoMatch)
				{
					throw new global::Newtonsoft.Json.JsonException("Index * not valid on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jtoken.GetType().Name));
				}
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}
	}
}
