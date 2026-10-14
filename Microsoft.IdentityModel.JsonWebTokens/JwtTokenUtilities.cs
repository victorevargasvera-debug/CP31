using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x02000009 RID: 9
	public class JwtTokenUtilities
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00003844 File Offset: 0x00001A44
		public static string CreateEncodedSignature(string input, global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials)
		{
			if (input == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("input");
			}
			if (signingCredentials == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signingCredentials");
			}
			global::Microsoft.IdentityModel.Tokens.CryptoProviderFactory cryptoProviderFactory = signingCredentials.CryptoProviderFactory ?? signingCredentials.Key.CryptoProviderFactory;
			global::Microsoft.IdentityModel.Tokens.SignatureProvider signatureProvider = cryptoProviderFactory.CreateForSigning(signingCredentials.Key, signingCredentials.Algorithm);
			if (signatureProvider == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.InvalidOperationException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10636: CryptoProviderFactory.CreateForVerifying returned null for key: '{0}', signatureAlgorithm: '{1}'.", new object[]
				{
					(signingCredentials.Key == null) ? "Null" : signingCredentials.Key.ToString(),
					signingCredentials.Algorithm ?? "Null"
				})));
			}
			string result;
			try
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX14200: Creating raw signature using the signature credentials.", new object[0]);
				result = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(signatureProvider.Sign(global::System.Text.Encoding.UTF8.GetBytes(input)));
			}
			finally
			{
				cryptoProviderFactory.ReleaseSignatureProvider(signatureProvider);
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003928 File Offset: 0x00001B28
		public static byte[] GenerateKeyBytes(int sizeInBits)
		{
			if (sizeInBits != 256 && sizeInBits != 384 && sizeInBits != 512)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException("IDX10401: Invalid requested key size. Valid key sizes are: 256, 384, and 512.", "sizeInBits"));
			}
			global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
			int num = sizeInBits >> 4;
			byte[] array = new byte[num << 1];
			aes.KeySize = sizeInBits >> 1;
			aes.GenerateKey();
			global::System.Array.Copy(aes.Key, array, num);
			aes.GenerateKey();
			global::System.Array.Copy(aes.Key, 0, array, num, num);
			return array;
		}

		// Token: 0x0400003C RID: 60
		public static global::System.Text.RegularExpressions.Regex RegexJws = new global::System.Text.RegularExpressions.Regex("^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*$", global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant, global::System.TimeSpan.FromMilliseconds(100.0));

		// Token: 0x0400003D RID: 61
		public static global::System.Text.RegularExpressions.Regex RegexJwe = new global::System.Text.RegularExpressions.Regex("^[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]*\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+\\.[A-Za-z0-9-_]+$", global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant, global::System.TimeSpan.FromMilliseconds(100.0));
	}
}
