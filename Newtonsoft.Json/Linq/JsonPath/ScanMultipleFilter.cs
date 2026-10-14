using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000DD RID: 221
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ScanMultipleFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x000309B9 File Offset: 0x0002EBB9
		public ScanMultipleFilter(global::System.Collections.Generic.List<string> names)
		{
			this._names = names;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000309C8 File Offset: 0x0002EBC8
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken c in current)
			{
				global::Newtonsoft.Json.Linq.JToken value = c;
				for (;;)
				{
					global::Newtonsoft.Json.Linq.JContainer container = value as global::Newtonsoft.Json.Linq.JContainer;
					value = global::Newtonsoft.Json.Linq.JsonPath.PathFilter.GetNextScanValue(c, container, value);
					if (value == null)
					{
						break;
					}
					global::Newtonsoft.Json.Linq.JProperty property = value as global::Newtonsoft.Json.Linq.JProperty;
					if (property != null)
					{
						foreach (string b in this._names)
						{
							if (property.Name == b)
							{
								yield return property.Value;
							}
						}
						global::System.Collections.Generic.List<string>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<string>.Enumerator);
					}
					property = null;
				}
				value = null;
				c = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003CF RID: 975
		private global::System.Collections.Generic.List<string> _names;
	}
}
