using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001BB RID: 443
	internal sealed class PemUtilities
	{
		// Token: 0x0600109F RID: 4255 RVA: 0x00043E3C File Offset: 0x0004203C
		static PemUtilities()
		{
			((global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg))).ToString();
			((global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode))).ToString();
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00043E90 File Offset: 0x00042090
		private static void ParseDekAlgName(string dekAlgName, out global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg baseAlg, out global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode mode)
		{
			try
			{
				mode = global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.ECB;
				if (dekAlgName == "DES-EDE" || dekAlgName == "DES-EDE3")
				{
					baseAlg = (global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg), dekAlgName);
					return;
				}
				int pos = dekAlgName.LastIndexOf('-');
				if (pos >= 0)
				{
					baseAlg = (global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg), dekAlgName.Substring(0, pos));
					mode = (global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode), dekAlgName.Substring(pos + 1));
					return;
				}
			}
			catch (global::System.ArgumentException)
			{
			}
			throw new global::Org.BouncyCastle.Security.EncryptionException("Unknown DEK algorithm: " + dekAlgName);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00043F48 File Offset: 0x00042148
		internal static byte[] Crypt(bool encrypt, byte[] bytes, char[] password, string dekAlgName, byte[] iv)
		{
			global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg baseAlg;
			global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode mode;
			global::Org.BouncyCastle.OpenSsl.PemUtilities.ParseDekAlgName(dekAlgName, out baseAlg, out mode);
			string padding;
			switch (mode)
			{
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.CBC:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.ECB:
				padding = "PKCS5Padding";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.CFB:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.OFB:
				padding = "NoPadding";
				break;
			default:
				throw new global::Org.BouncyCastle.Security.EncryptionException("Unknown DEK algorithm: " + dekAlgName);
			}
			byte[] salt = iv;
			string algorithm;
			switch (baseAlg)
			{
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_128:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_192:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_256:
				algorithm = "AES";
				if (salt.Length > 8)
				{
					salt = new byte[8];
					global::System.Array.Copy(iv, 0, salt, 0, salt.Length);
				}
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.BF:
				algorithm = "BLOWFISH";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES:
				algorithm = "DES";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES_EDE:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES_EDE3:
				algorithm = "DESede";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2_40:
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2_64:
				algorithm = "RC2";
				break;
			default:
				throw new global::Org.BouncyCastle.Security.EncryptionException("Unknown DEK algorithm: " + dekAlgName);
			}
			global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(string.Concat(new string[]
			{
				algorithm,
				"/",
				mode.ToString(),
				"/",
				padding
			}));
			global::Org.BouncyCastle.Crypto.ICipherParameters cParams = global::Org.BouncyCastle.OpenSsl.PemUtilities.GetCipherParameters(password, baseAlg, salt);
			if (mode != global::Org.BouncyCastle.OpenSsl.PemUtilities.PemMode.ECB)
			{
				cParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(cParams, iv);
			}
			cipher.Init(encrypt, cParams);
			return cipher.DoFinal(bytes);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00044084 File Offset: 0x00042284
		private static global::Org.BouncyCastle.Crypto.ICipherParameters GetCipherParameters(char[] password, global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg baseAlg, byte[] salt)
		{
			int keyBits;
			string algorithm;
			switch (baseAlg)
			{
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_128:
				keyBits = 128;
				algorithm = "AES128";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_192:
				keyBits = 192;
				algorithm = "AES192";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.AES_256:
				keyBits = 256;
				algorithm = "AES256";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.BF:
				keyBits = 128;
				algorithm = "BLOWFISH";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES:
				keyBits = 64;
				algorithm = "DES";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES_EDE:
				keyBits = 128;
				algorithm = "DESEDE";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.DES_EDE3:
				keyBits = 192;
				algorithm = "DESEDE3";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2:
				keyBits = 128;
				algorithm = "RC2";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2_40:
				keyBits = 40;
				algorithm = "RC2";
				break;
			case global::Org.BouncyCastle.OpenSsl.PemUtilities.PemBaseAlg.RC2_64:
				keyBits = 64;
				algorithm = "RC2";
				break;
			default:
				return null;
			}
			global::Org.BouncyCastle.Crypto.Generators.OpenSslPbeParametersGenerator openSslPbeParametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.OpenSslPbeParametersGenerator();
			openSslPbeParametersGenerator.Init(global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs5PasswordToBytes(password), salt);
			return openSslPbeParametersGenerator.GenerateDerivedParameters(algorithm, keyBits);
		}

		// Token: 0x020007B1 RID: 1969
		private enum PemBaseAlg
		{
			// Token: 0x04002336 RID: 9014
			AES_128,
			// Token: 0x04002337 RID: 9015
			AES_192,
			// Token: 0x04002338 RID: 9016
			AES_256,
			// Token: 0x04002339 RID: 9017
			BF,
			// Token: 0x0400233A RID: 9018
			DES,
			// Token: 0x0400233B RID: 9019
			DES_EDE,
			// Token: 0x0400233C RID: 9020
			DES_EDE3,
			// Token: 0x0400233D RID: 9021
			RC2,
			// Token: 0x0400233E RID: 9022
			RC2_40,
			// Token: 0x0400233F RID: 9023
			RC2_64
		}

		// Token: 0x020007B2 RID: 1970
		private enum PemMode
		{
			// Token: 0x04002341 RID: 9025
			CBC,
			// Token: 0x04002342 RID: 9026
			CFB,
			// Token: 0x04002343 RID: 9027
			ECB,
			// Token: 0x04002344 RID: 9028
			OFB
		}
	}
}
