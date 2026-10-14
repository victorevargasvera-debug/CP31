using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000028 RID: 40
	public class JsonWebKeyConverter
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00005E7C File Offset: 0x0000407C
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKey ConvertFromSecurityKey(global::Microsoft.IdentityModel.Tokens.SecurityKey key)
		{
			if (key.GetType() == typeof(global::Microsoft.IdentityModel.Tokens.RsaSecurityKey))
			{
				return global::Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.ConvertFromRSASecurityKey(key as global::Microsoft.IdentityModel.Tokens.RsaSecurityKey);
			}
			if (key.GetType() == typeof(global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey))
			{
				return global::Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.ConvertFromSymmetricSecurityKey(key as global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey);
			}
			if (key.GetType() == typeof(global::Microsoft.IdentityModel.Tokens.X509SecurityKey))
			{
				return global::Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.ConvertFromX509SecurityKey(key as global::Microsoft.IdentityModel.Tokens.X509SecurityKey);
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.NotSupportedException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10674: JsonWebKeyConverter does not support SecurityKey of type: {0}", new object[]
			{
				key.GetType().FullName
			})));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005F1C File Offset: 0x0000411C
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKey ConvertFromRSASecurityKey(global::Microsoft.IdentityModel.Tokens.RsaSecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = new global::Microsoft.IdentityModel.Tokens.JsonWebKey();
			global::System.Security.Cryptography.RSAParameters rsaparameters = default(global::System.Security.Cryptography.RSAParameters);
			jsonWebKey.Kty = "RSA";
			jsonWebKey.Kid = key.KeyId;
			if (key.Rsa != null)
			{
				rsaparameters = key.Rsa.ExportParameters(true);
			}
			else
			{
				rsaparameters = key.Parameters;
			}
			jsonWebKey.N = ((rsaparameters.Modulus != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.Modulus) : null);
			jsonWebKey.E = ((rsaparameters.Exponent != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.Exponent) : null);
			jsonWebKey.D = ((rsaparameters.D != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.D) : null);
			jsonWebKey.P = ((rsaparameters.P != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.P) : null);
			jsonWebKey.Q = ((rsaparameters.Q != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.Q) : null);
			jsonWebKey.DP = ((rsaparameters.DP != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.DP) : null);
			jsonWebKey.DQ = ((rsaparameters.DQ != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.DQ) : null);
			jsonWebKey.QI = ((rsaparameters.InverseQ != null) ? global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(rsaparameters.InverseQ) : null);
			return jsonWebKey;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000604C File Offset: 0x0000424C
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKey ConvertFromX509SecurityKey(global::Microsoft.IdentityModel.Tokens.X509SecurityKey key)
		{
			global::Microsoft.IdentityModel.Tokens.JsonWebKey jsonWebKey = new global::Microsoft.IdentityModel.Tokens.JsonWebKey();
			jsonWebKey.Kty = "RSA";
			jsonWebKey.Kid = key.KeyId;
			jsonWebKey.X5t = key.X5t;
			if (key.Certificate.RawData != null)
			{
				jsonWebKey.X5c.Add(global::System.Convert.ToBase64String(key.Certificate.RawData));
			}
			return jsonWebKey;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000060AB File Offset: 0x000042AB
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKey ConvertFromSymmetricSecurityKey(global::Microsoft.IdentityModel.Tokens.SymmetricSecurityKey key)
		{
			return new global::Microsoft.IdentityModel.Tokens.JsonWebKey
			{
				K = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(key.Key),
				Kid = key.KeyId,
				Kty = "oct"
			};
		}
	}
}
