using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D1 RID: 209
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class FieldFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x0002F0BC File Offset: 0x0002D2BC
		public FieldFilter(string name)
		{
			this.Name = name;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0002F0CB File Offset: 0x0002D2CB
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in current)
			{
				global::Newtonsoft.Json.Linq.JObject jobject = jtoken as global::Newtonsoft.Json.Linq.JObject;
				if (jobject != null)
				{
					if (this.Name != null)
					{
						global::Newtonsoft.Json.Linq.JToken jtoken2 = jobject[this.Name];
						if (jtoken2 != null)
						{
							yield return jtoken2;
						}
						else if (settings != null && settings.ErrorWhenNoMatch)
						{
							throw new global::Newtonsoft.Json.JsonException("Property '{0}' does not exist on JObject.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.Name));
						}
					}
					else
					{
						foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in jobject)
						{
							yield return keyValuePair.Value;
						}
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>> enumerator2 = null;
					}
				}
				else if (settings != null && settings.ErrorWhenNoMatch)
				{
					throw new global::Newtonsoft.Json.JsonException("Property '{0}' not valid on {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.Name ?? "*", jtoken.GetType().Name));
				}
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003B3 RID: 947
		internal string Name;
	}
}
