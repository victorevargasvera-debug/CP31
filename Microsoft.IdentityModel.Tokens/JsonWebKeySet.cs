using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Logging;
using Newtonsoft.Json;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200002B RID: 43
	[global::Newtonsoft.Json.JsonObject]
	public class JsonWebKeySet
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000060E2 File Offset: 0x000042E2
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKeySet Create(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("json");
			}
			return new global::Microsoft.IdentityModel.Tokens.JsonWebKeySet(json);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000060FD File Offset: 0x000042FD
		public JsonWebKeySet()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000611B File Offset: 0x0000431B
		public JsonWebKeySet(string json) : this(json, null)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006128 File Offset: 0x00004328
		public JsonWebKeySet(string json, global::Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings)
		{
			if (string.IsNullOrEmpty(json))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("json");
			}
			try
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX10806: Deserializing json: '{0}' into '{1}'.", new object[]
				{
					json,
					this
				});
				if (jsonSerializerSettings != null)
				{
					global::Newtonsoft.Json.JsonConvert.PopulateObject(json, this, jsonSerializerSettings);
				}
				else
				{
					global::Newtonsoft.Json.JsonConvert.PopulateObject(json, this);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10805: Error deserializing json: '{0}' into '{1}'.", new object[]
				{
					json,
					base.GetType()
				}), innerException));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000061D0 File Offset: 0x000043D0
		[global::Newtonsoft.Json.JsonExtensionData]
		public virtual global::System.Collections.Generic.IDictionary<string, object> AdditionalData { get; } = new global::System.Collections.Generic.Dictionary<string, object>();

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000061D8 File Offset: 0x000043D8
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000061E0 File Offset: 0x000043E0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "keys", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<global::Microsoft.IdentityModel.Tokens.JsonWebKey> Keys { get; private set; } = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.JsonWebKey>();

		// Token: 0x06000126 RID: 294 RVA: 0x000061EC File Offset: 0x000043EC
		public global::System.Collections.Generic.IList<global::Microsoft.IdentityModel.Tokens.SecurityKey> GetSigningKeys()
		{
			global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey> list = new global::System.Collections.Generic.List<global::Microsoft.IdentityModel.Tokens.SecurityKey>();
			for (int i = 0; i < this.Keys.Count; i++)
			{
				global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = this.Keys[i];
				if (global::System.StringComparer.Ordinal.Equals(jsonWebKey.Kty, "RSA") && (string.IsNullOrWhiteSpace(jsonWebKey.Use) || global::System.StringComparer.Ordinal.Equals(jsonWebKey.Use, "sig")))
				{
					if (jsonWebKey.X5c != null)
					{
						foreach (string s in jsonWebKey.X5c)
						{
							try
							{
								list.Add(new global::Microsoft.IdentityModel.Tokens.X509SecurityKey(new global::System.Security.Cryptography.X509Certificates.X509Certificate2(global::System.Convert.FromBase64String(s)))
								{
									KeyId = jsonWebKey.Kid
								});
							}
							catch (global::System.Security.Cryptography.CryptographicException innerException)
							{
								throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10802: Unable to create an X509Certificate2 from the X509Data: '{0}'. See inner exception for additional details.", new object[]
								{
									jsonWebKey.X5c[0]
								}), innerException));
							}
							catch (global::System.FormatException innerException2)
							{
								throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10802: Unable to create an X509Certificate2 from the X509Data: '{0}'. See inner exception for additional details.", new object[]
								{
									jsonWebKey.X5c[0]
								}), innerException2));
							}
						}
					}
					if (!string.IsNullOrWhiteSpace(jsonWebKey.E) && !string.IsNullOrWhiteSpace(jsonWebKey.N))
					{
						try
						{
							list.Add(new global::Microsoft.IdentityModel.Tokens.RsaSecurityKey(new global::System.Security.Cryptography.RSAParameters
							{
								Exponent = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jsonWebKey.E),
								Modulus = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(jsonWebKey.N)
							})
							{
								KeyId = jsonWebKey.Kid
							});
						}
						catch (global::System.Security.Cryptography.CryptographicException innerException3)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10801: Unable to create an RSA public key from the Exponent and Modulus found in the JsonWebKey: E: '{0}', N: '{1}'. See inner exception for additional details.", new object[]
							{
								jsonWebKey.E,
								jsonWebKey.N
							}), innerException3));
						}
						catch (global::System.FormatException innerException4)
						{
							throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10801: Unable to create an RSA public key from the Exponent and Modulus found in the JsonWebKey: E: '{0}', N: '{1}'. See inner exception for additional details.", new object[]
							{
								jsonWebKey.E,
								jsonWebKey.N
							}), innerException4));
						}
					}
				}
			}
			return list;
		}
	}
}
