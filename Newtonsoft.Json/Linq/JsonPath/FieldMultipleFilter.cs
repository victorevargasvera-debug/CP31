using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D2 RID: 210
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class FieldMultipleFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000BED RID: 3053 RVA: 0x0002F0E9 File Offset: 0x0002D2E9
		public FieldMultipleFilter(global::System.Collections.Generic.List<string> names)
		{
			this.Names = names;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in current)
			{
				global::Newtonsoft.Json.Linq.JObject o = jtoken as global::Newtonsoft.Json.Linq.JObject;
				if (o != null)
				{
					foreach (string name in this.Names)
					{
						global::Newtonsoft.Json.Linq.JToken jtoken2 = o[name];
						if (jtoken2 != null)
						{
							yield return jtoken2;
						}
						if (settings != null && settings.ErrorWhenNoMatch)
						{
							throw new global::Newtonsoft.Json.JsonException("Property '{0}' does not exist on JObject.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, name));
						}
						name = null;
					}
					global::System.Collections.Generic.List<string>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<string>.Enumerator);
				}
				else if (settings != null && settings.ErrorWhenNoMatch)
				{
					throw new global::Newtonsoft.Json.JsonException("Properties {0} not valid on {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, string.Join(", ", from n in this.Names
					select "'" + n + "'"), jtoken.GetType().Name));
				}
				o = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003B4 RID: 948
		internal global::System.Collections.Generic.List<string> Names;
	}
}
