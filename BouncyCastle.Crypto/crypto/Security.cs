using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace crypto
{
	// Token: 0x02000004 RID: 4
	public class Security
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020A8 File Offset: 0x000002A8
		public static string ComputeHash(string text, string salt)
		{
			byte[] data = global::System.Text.Encoding.UTF8.GetBytes(text);
			global::Org.BouncyCastle.Crypto.Digests.Sha512Digest sha = new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest();
			global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator(sha);
			pkcs5S2ParametersGenerator.Init(data, global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(salt), 2048);
			return global::Org.BouncyCastle.Utilities.Encoders.Base64.ToBase64String(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedParameters(sha.GetDigestSize() * 8)).GetKey());
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020FC File Offset: 0x000002FC
		public static string Decrypt(string cipherText, string key, string iv)
		{
			byte[] textAsBytes = global::crypto.Security.CreateCipher(false, key, iv).DoFinal(global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(cipherText));
			return global::System.Text.Encoding.UTF8.GetString(textAsBytes, 0, textAsBytes.Length);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000212C File Offset: 0x0000032C
		public static string Encrypt(string plainText, string key, string iv)
		{
			return global::Org.BouncyCastle.Utilities.Encoders.Base64.ToBase64String(global::crypto.Security.CreateCipher(true, key, iv).DoFinal(global::System.Text.Encoding.UTF8.GetBytes(plainText)));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000214C File Offset: 0x0000034C
		public static string GenerateText(int size)
		{
			byte[] textAsBytes = new byte[size];
			global::Org.BouncyCastle.Security.SecureRandom.GetInstance("SHA256PRNG", true).NextBytes(textAsBytes);
			return global::Org.BouncyCastle.Utilities.Encoders.Base64.ToBase64String(textAsBytes);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002178 File Offset: 0x00000378
		private static global::Org.BouncyCastle.Crypto.IBufferedCipher CreateCipher(bool isEncryption, string key, string iv)
		{
			global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher paddedBufferedBlockCipher = new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.RijndaelEngine()), new global::Org.BouncyCastle.Crypto.Paddings.ISO10126d2Padding());
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParam = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(key));
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters2;
			if (iv != null && iv.Length >= 1)
			{
				global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(keyParam, global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(iv));
				cipherParameters2 = cipherParameters;
			}
			else
			{
				global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = keyParam;
				cipherParameters2 = cipherParameters;
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParams = cipherParameters2;
			((global::Org.BouncyCastle.Crypto.IBufferedCipher)paddedBufferedBlockCipher).Init(isEncryption, cipherParams);
			return paddedBufferedBlockCipher;
		}
	}
}
