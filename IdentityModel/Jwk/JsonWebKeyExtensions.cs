using System;
using System.Text;
using Newtonsoft.Json;

namespace IdentityModel.Jwk
{
	// Token: 0x02000030 RID: 48
	public static class JsonWebKeyExtensions
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00002E3C File Offset: 0x0000103C
		public static string ToJwkString(this global::IdentityModel.Jwk.JsonWebKey key)
		{
			string s = global::Newtonsoft.Json.JsonConvert.SerializeObject(key);
			return global::IdentityModel.Base64Url.Encode(global::System.Text.Encoding.UTF8.GetBytes(s));
		}
	}
}
