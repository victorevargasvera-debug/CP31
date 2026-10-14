using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using Newtonsoft.Json.Linq;

namespace IdentityModel.Client
{
	// Token: 0x02000048 RID: 72
	public class IntrospectionResponse : global::IdentityModel.Client.Response
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public IntrospectionResponse(string raw) : base(raw)
		{
			if (!base.IsError)
			{
				global::System.Collections.Generic.List<global::System.Security.Claims.Claim> list = base.Json.ToClaims(new string[]
				{
					"scope"
				}).ToList<global::System.Security.Claims.Claim>();
				global::Newtonsoft.Json.Linq.JToken jtoken = base.Json.TryGetValue("scope");
				if (jtoken != null)
				{
					global::Newtonsoft.Json.Linq.JArray jarray;
					if ((jarray = (jtoken as global::Newtonsoft.Json.Linq.JArray)) != null)
					{
						using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = jarray.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Newtonsoft.Json.Linq.JToken jtoken2 = enumerator.Current;
								list.Add(new global::System.Security.Claims.Claim("scope", jtoken2.ToString()));
							}
							goto IL_D3;
						}
					}
					foreach (string value in jtoken.ToString().Split(new char[]
					{
						' '
					}, global::System.StringSplitOptions.RemoveEmptyEntries))
					{
						list.Add(new global::System.Security.Claims.Claim("scope", value));
					}
				}
				IL_D3:
				this.Claims = list;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public IntrospectionResponse(global::System.Exception exception) : base(exception)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004DAC File Offset: 0x00002FAC
		public IntrospectionResponse(global::System.Net.HttpStatusCode statusCode, string reason) : base(statusCode, reason)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public bool IsActive
		{
			get
			{
				return base.Json.TryGetBoolean("active").Value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00004DE0 File Offset: 0x00002FE0
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims { get; }
	}
}
