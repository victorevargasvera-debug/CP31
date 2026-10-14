using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000005 RID: 5
	internal class CryptoHelper
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002688 File Offset: 0x00000888
		public CryptoHelper(global::IdentityModel.OidcClient.OidcClientOptions options)
		{
			this._options = options;
			this._logger = options.LoggerFactory.CreateLogger<global::IdentityModel.OidcClient.CryptoHelper>();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026A8 File Offset: 0x000008A8
		public global::System.Security.Cryptography.HashAlgorithm GetMatchingHashAlgorithm(string signatureAlgorithm)
		{
			this._logger.LogTrace("GetMatchingHashAlgorithm", new object[0]);
			this._logger.LogDebug("Determining matching hash algorithm for {signatureAlgorithm}", new object[]
			{
				signatureAlgorithm
			});
			int num = int.Parse(signatureAlgorithm.Substring(signatureAlgorithm.Length - 3));
			if (num == 256)
			{
				this._logger.LogDebug("SHA256", new object[0]);
				return global::System.Security.Cryptography.SHA256.Create();
			}
			if (num == 384)
			{
				this._logger.LogDebug("SHA384", new object[0]);
				return global::System.Security.Cryptography.SHA384.Create();
			}
			if (num != 512)
			{
				return null;
			}
			this._logger.LogDebug("SHA512", new object[0]);
			return global::System.Security.Cryptography.SHA512.Create();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002768 File Offset: 0x00000968
		public bool ValidateHash(string data, string hashedData, string signatureAlgorithm)
		{
			this._logger.LogTrace("ValidateHash", new object[0]);
			global::System.Security.Cryptography.HashAlgorithm matchingHashAlgorithm = this.GetMatchingHashAlgorithm(signatureAlgorithm);
			if (matchingHashAlgorithm == null)
			{
				this._logger.LogError("No appropriate hashing algorithm found.", new object[0]);
			}
			bool result;
			using (matchingHashAlgorithm)
			{
				global::System.Array sourceArray = matchingHashAlgorithm.ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(data));
				byte[] array = new byte[matchingHashAlgorithm.HashSize / 16];
				global::System.Array.Copy(sourceArray, array, matchingHashAlgorithm.HashSize / 16);
				string text = global::IdentityModel.Base64Url.Encode(array);
				bool flag = text.Equals(hashedData);
				if (!flag)
				{
					this._logger.LogError(string.Format("data ({0}) does not match hash from token ({1})", text, hashedData), new object[0]);
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002830 File Offset: 0x00000A30
		public string CreateState()
		{
			this._logger.LogTrace("CreateState", new object[0]);
			return global::IdentityModel.CryptoRandom.CreateUniqueId(16);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002850 File Offset: 0x00000A50
		public string CreateNonce()
		{
			this._logger.LogTrace("CreateNonce", new object[0]);
			return global::IdentityModel.CryptoRandom.CreateUniqueId(16);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002870 File Offset: 0x00000A70
		public global::IdentityModel.OidcClient.CryptoHelper.Pkce CreatePkceData()
		{
			this._logger.LogTrace("CreatePkceData", new object[0]);
			global::IdentityModel.OidcClient.CryptoHelper.Pkce pkce = new global::IdentityModel.OidcClient.CryptoHelper.Pkce
			{
				CodeVerifier = global::IdentityModel.CryptoRandom.CreateUniqueId(32)
			};
			using (global::System.Security.Cryptography.SHA256 sha = global::System.Security.Cryptography.SHA256.Create())
			{
				byte[] arg = sha.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(pkce.CodeVerifier));
				pkce.CodeChallenge = global::IdentityModel.Base64Url.Encode(arg);
			}
			return pkce;
		}

		// Token: 0x04000011 RID: 17
		private readonly global::Microsoft.Extensions.Logging.ILogger _logger;

		// Token: 0x04000012 RID: 18
		private readonly global::IdentityModel.OidcClient.OidcClientOptions _options;

		// Token: 0x02000006 RID: 6
		internal class Pkce
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600001A RID: 26 RVA: 0x000028EC File Offset: 0x00000AEC
			// (set) Token: 0x0600001B RID: 27 RVA: 0x000028F4 File Offset: 0x00000AF4
			public string CodeVerifier { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600001C RID: 28 RVA: 0x00002900 File Offset: 0x00000B00
			// (set) Token: 0x0600001D RID: 29 RVA: 0x00002908 File Offset: 0x00000B08
			public string CodeChallenge { get; set; }
		}
	}
}
