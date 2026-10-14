using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IdentityModel.Jwk
{
	// Token: 0x0200002F RID: 47
	public class JsonWebKeySet
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00002DDC File Offset: 0x00000FDC
		public JsonWebKeySet()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public JsonWebKeySet(string json)
		{
			if (string.IsNullOrWhiteSpace(json))
			{
				throw new global::System.ArgumentNullException("json");
			}
			global::IdentityModel.Jwk.JsonWebKeySet jsonWebKeySet = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::IdentityModel.Jwk.JsonWebKeySet>(json);
			this._keys = jsonWebKeySet._keys;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002E34 File Offset: 0x00001034
		public global::System.Collections.Generic.IList<global::IdentityModel.Jwk.JsonWebKey> Keys
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x0400014D RID: 333
		private global::System.Collections.Generic.List<global::IdentityModel.Jwk.JsonWebKey> _keys = new global::System.Collections.Generic.List<global::IdentityModel.Jwk.JsonWebKey>();
	}
}
