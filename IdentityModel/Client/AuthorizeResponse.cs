using System;
using System.Collections.Generic;
using System.Net;

namespace IdentityModel.Client
{
	// Token: 0x0200003A RID: 58
	public class AuthorizeResponse
	{
		// Token: 0x0600007E RID: 126 RVA: 0x000032B4 File Offset: 0x000014B4
		public AuthorizeResponse(string raw)
		{
			this.Raw = raw;
			this.ParseRaw();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000032D4 File Offset: 0x000014D4
		public string Raw { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000032DC File Offset: 0x000014DC
		public global::System.Collections.Generic.Dictionary<string, string> Values { get; } = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000032E4 File Offset: 0x000014E4
		public string Code
		{
			get
			{
				return this.TryGet("code");
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000032F4 File Offset: 0x000014F4
		public string AccessToken
		{
			get
			{
				return this.TryGet("access_token");
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003304 File Offset: 0x00001504
		public string IdentityToken
		{
			get
			{
				return this.TryGet("id_token");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003314 File Offset: 0x00001514
		public string Error
		{
			get
			{
				return this.TryGet("error");
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003324 File Offset: 0x00001524
		public string Scope
		{
			get
			{
				return this.TryGet("scope");
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003334 File Offset: 0x00001534
		public string TokenType
		{
			get
			{
				return this.TryGet("token_type");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003344 File Offset: 0x00001544
		public string State
		{
			get
			{
				return this.TryGet("state");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003354 File Offset: 0x00001554
		public string ErrorDescription
		{
			get
			{
				return this.TryGet("error_description");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003364 File Offset: 0x00001564
		public bool IsError
		{
			get
			{
				return !string.IsNullOrEmpty(this.Error);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003374 File Offset: 0x00001574
		public long ExpiresIn
		{
			get
			{
				long result;
				long.TryParse(this.TryGet("expires_in"), out result);
				return result;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003398 File Offset: 0x00001598
		private void ParseRaw()
		{
			string[] array;
			if (this.Raw.Contains("?"))
			{
				array = this.Raw.Split(new char[]
				{
					'?'
				});
				int num = array[1].IndexOf('#');
				if (num >= 0)
				{
					array[1] = array[1].Substring(0, num);
				}
			}
			else if (this.Raw.Contains("#"))
			{
				array = this.Raw.Split(new char[]
				{
					'#'
				});
			}
			else
			{
				array = new string[]
				{
					"",
					this.Raw
				};
			}
			string[] array2 = array[1].Split(new char[]
			{
				'&'
			});
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(new char[]
				{
					'='
				});
				if (array3.Length != 2)
				{
					throw new global::System.InvalidOperationException("Malformed callback URL.");
				}
				this.Values.Add(array3[0], array3[1]);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003490 File Offset: 0x00001690
		public string TryGet(string type)
		{
			string encodedValue;
			if (this.Values.TryGetValue(type, out encodedValue))
			{
				return global::System.Net.WebUtility.UrlDecode(encodedValue);
			}
			return null;
		}
	}
}
