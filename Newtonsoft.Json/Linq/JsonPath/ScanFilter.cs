using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000DC RID: 220
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ScanFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000C1F RID: 3103 RVA: 0x00030993 File Offset: 0x0002EB93
		public ScanFilter(string name)
		{
			this.Name = name;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000309A2 File Offset: 0x0002EBA2
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken c in current)
			{
				if (this.Name == null)
				{
					yield return c;
				}
				global::Newtonsoft.Json.Linq.JToken value = c;
				for (;;)
				{
					global::Newtonsoft.Json.Linq.JContainer container = value as global::Newtonsoft.Json.Linq.JContainer;
					value = global::Newtonsoft.Json.Linq.JsonPath.PathFilter.GetNextScanValue(c, container, value);
					if (value == null)
					{
						break;
					}
					global::Newtonsoft.Json.Linq.JProperty jproperty = value as global::Newtonsoft.Json.Linq.JProperty;
					if (jproperty != null)
					{
						if (jproperty.Name == this.Name)
						{
							yield return jproperty.Value;
						}
					}
					else if (this.Name == null)
					{
						yield return value;
					}
				}
				value = null;
				c = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003CE RID: 974
		internal string Name;
	}
}
