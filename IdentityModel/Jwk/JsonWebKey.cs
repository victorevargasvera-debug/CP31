using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IdentityModel.Jwk
{
	// Token: 0x0200002D RID: 45
	[global::Newtonsoft.Json.JsonObject]
	public class JsonWebKey
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002910 File Offset: 0x00000B10
		public JsonWebKey()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002930 File Offset: 0x00000B30
		public JsonWebKey(string json)
		{
			if (string.IsNullOrWhiteSpace(json))
			{
				throw new global::System.ArgumentNullException("json");
			}
			global::IdentityModel.Jwk.JsonWebKey key = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::IdentityModel.Jwk.JsonWebKey>(json);
			this.Copy(key);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000297C File Offset: 0x00000B7C
		private void Copy(global::IdentityModel.Jwk.JsonWebKey key)
		{
			this.Alg = key.Alg;
			this.Crv = key.Crv;
			this.D = key.D;
			this.DP = key.DP;
			this.DQ = key.DQ;
			this.E = key.E;
			this.K = key.K;
			if (key.KeyOps != null)
			{
				this._keyops = new global::System.Collections.Generic.List<string>(key.KeyOps);
			}
			this.Kid = key.Kid;
			this.Kty = key.Kty;
			this.N = key.N;
			this.Oth = key.Oth;
			this.P = key.P;
			this.Q = key.Q;
			this.QI = key.QI;
			this.Use = key.Use;
			if (key.X5c != null)
			{
				this._certificateClauses = new global::System.Collections.Generic.List<string>(key.X5c);
			}
			this.X5t = key.X5t;
			this.X5tS256 = key.X5tS256;
			this.X5u = key.X5u;
			this.X = key.X;
			this.Y = key.Y;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002AAC File Offset: 0x00000CAC
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002AB4 File Offset: 0x00000CB4
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "alg", Required = global::Newtonsoft.Json.Required.Default)]
		public string Alg { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002AC8 File Offset: 0x00000CC8
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "crv", Required = global::Newtonsoft.Json.Required.Default)]
		public string Crv { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002AD4 File Offset: 0x00000CD4
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002ADC File Offset: 0x00000CDC
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "d", Required = global::Newtonsoft.Json.Required.Default)]
		public string D { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002AE8 File Offset: 0x00000CE8
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "dp", Required = global::Newtonsoft.Json.Required.Default)]
		public string DP { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002AFC File Offset: 0x00000CFC
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002B04 File Offset: 0x00000D04
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "dq", Required = global::Newtonsoft.Json.Required.Default)]
		public string DQ { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002B10 File Offset: 0x00000D10
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002B18 File Offset: 0x00000D18
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "e", Required = global::Newtonsoft.Json.Required.Default)]
		public string E { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002B24 File Offset: 0x00000D24
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002B2C File Offset: 0x00000D2C
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "k", Required = global::Newtonsoft.Json.Required.Default)]
		public string K { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002B38 File Offset: 0x00000D38
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002B40 File Offset: 0x00000D40
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "key_ops", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> KeyOps
		{
			get
			{
				return this._keyops;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("KeyOps");
				}
				foreach (string item in value)
				{
					this._keyops.Add(item);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002B9C File Offset: 0x00000D9C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "kid", Required = global::Newtonsoft.Json.Required.Default)]
		public string Kid { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "kty", Required = global::Newtonsoft.Json.Required.Default)]
		public string Kty { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002BC4 File Offset: 0x00000DC4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002BCC File Offset: 0x00000DCC
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "n", Required = global::Newtonsoft.Json.Required.Default)]
		public string N { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "oth", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> Oth { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002BEC File Offset: 0x00000DEC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "p", Required = global::Newtonsoft.Json.Required.Default)]
		public string P { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002C00 File Offset: 0x00000E00
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002C08 File Offset: 0x00000E08
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "q", Required = global::Newtonsoft.Json.Required.Default)]
		public string Q { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002C14 File Offset: 0x00000E14
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002C1C File Offset: 0x00000E1C
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "qi", Required = global::Newtonsoft.Json.Required.Default)]
		public string QI { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002C30 File Offset: 0x00000E30
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "use", Required = global::Newtonsoft.Json.Required.Default)]
		public string Use { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002C44 File Offset: 0x00000E44
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x", Required = global::Newtonsoft.Json.Required.Default)]
		public string X { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002C50 File Offset: 0x00000E50
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002C58 File Offset: 0x00000E58
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5c", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> X5c
		{
			get
			{
				return this._certificateClauses;
			}
			set
			{
				foreach (string item in value)
				{
					this._certificateClauses.Add(item);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002CA8 File Offset: 0x00000EA8
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5t", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5t { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002CBC File Offset: 0x00000EBC
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002CC4 File Offset: 0x00000EC4
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5t#S256", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5tS256 { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002CD8 File Offset: 0x00000ED8
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5u", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5u { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002CEC File Offset: 0x00000EEC
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "y", Required = global::Newtonsoft.Json.Required.Default)]
		public string Y { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public int KeySize
		{
			get
			{
				if (this.Kty == "RSA")
				{
					return global::IdentityModel.Base64Url.Decode(this.N).Length * 8;
				}
				if (this.Kty == "EC")
				{
					return global::IdentityModel.Base64Url.Decode(this.X).Length * 8;
				}
				if (this.Kty == "oct")
				{
					return global::IdentityModel.Base64Url.Decode(this.K).Length * 8;
				}
				return 0;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002D6C File Offset: 0x00000F6C
		public bool HasPrivateKey
		{
			get
			{
				if (this.Kty == "RSA")
				{
					return this.D != null && this.DP != null && this.DQ != null && this.P != null && this.Q != null && this.QI != null;
				}
				return this.Kty == "EC" && this.D != null;
			}
		}

		// Token: 0x0400011E RID: 286
		private global::System.Collections.Generic.IList<string> _certificateClauses = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400011F RID: 287
		private global::System.Collections.Generic.IList<string> _keyops = new global::System.Collections.Generic.List<string>();
	}
}
