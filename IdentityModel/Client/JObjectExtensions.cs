using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Newtonsoft.Json.Linq;

namespace IdentityModel.Client
{
	// Token: 0x02000049 RID: 73
	public static class JObjectExtensions
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public static global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> ToClaims(this global::Newtonsoft.Json.Linq.JObject json, params string[] excludeKeys)
		{
			global::System.Collections.Generic.List<global::System.Security.Claims.Claim> list = new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
			global::System.Collections.Generic.List<string> list2 = excludeKeys.ToList<string>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in json)
			{
				if (!list2.Contains(keyValuePair.Key))
				{
					global::Newtonsoft.Json.Linq.JArray jarray = keyValuePair.Value as global::Newtonsoft.Json.Linq.JArray;
					if (jarray != null)
					{
						using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = jarray.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::Newtonsoft.Json.Linq.JToken jtoken = enumerator2.Current;
								list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, jtoken.ToString()));
							}
							continue;
						}
					}
					list.Add(new global::System.Security.Claims.Claim(keyValuePair.Key, keyValuePair.Value.ToString()));
				}
			}
			return list;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004ECC File Offset: 0x000030CC
		public static global::Newtonsoft.Json.Linq.JToken TryGetValue(this global::Newtonsoft.Json.Linq.JObject json, string name)
		{
			global::Newtonsoft.Json.Linq.JToken result;
			if (json != null && json.TryGetValue(name, global::System.StringComparison.OrdinalIgnoreCase, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004EEC File Offset: 0x000030EC
		public static int? TryGetInt(this global::Newtonsoft.Json.Linq.JObject json, string name)
		{
			string text = json.TryGetString(name);
			int value;
			if (text != null && int.TryParse(text, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004F20 File Offset: 0x00003120
		public static string TryGetString(this global::Newtonsoft.Json.Linq.JObject json, string name)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = json.TryGetValue(name);
			if (jtoken == null)
			{
				return null;
			}
			return jtoken.ToString();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004F34 File Offset: 0x00003134
		public static bool? TryGetBoolean(this global::Newtonsoft.Json.Linq.JObject json, string name)
		{
			bool value;
			if (bool.TryParse(json.TryGetString(name), out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004F64 File Offset: 0x00003164
		public static global::System.Collections.Generic.IEnumerable<string> TryGetStringArray(this global::Newtonsoft.Json.Linq.JObject json, string name)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::Newtonsoft.Json.Linq.JArray jarray = json.TryGetValue(name) as global::Newtonsoft.Json.Linq.JArray;
			if (jarray != null)
			{
				foreach (global::Newtonsoft.Json.Linq.JToken jtoken in jarray)
				{
					list.Add(jtoken.ToString());
				}
			}
			return list;
		}
	}
}
