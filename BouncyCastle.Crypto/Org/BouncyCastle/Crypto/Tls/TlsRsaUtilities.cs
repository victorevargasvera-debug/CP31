using System;
using System.IO;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000381 RID: 897
	public abstract class TlsRsaUtilities
	{
		// Token: 0x06002485 RID: 9349 RVA: 0x0009EC20 File Offset: 0x0009CE20
		public static byte[] GenerateEncryptedPreMasterSecret(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaServerPublicKey, global::System.IO.Stream output)
		{
			byte[] premasterSecret = new byte[48];
			context.SecureRandom.NextBytes(premasterSecret);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(context.ClientVersion, premasterSecret, 0);
			global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding encoding = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
			encoding.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(rsaServerPublicKey, context.SecureRandom));
			try
			{
				byte[] encryptedPreMasterSecret = encoding.ProcessBlock(premasterSecret, 0, premasterSecret.Length);
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
				{
					output.Write(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
				}
				else
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(encryptedPreMasterSecret, output);
				}
			}
			catch (global::Org.BouncyCastle.Crypto.InvalidCipherTextException e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			return premasterSecret;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0009ECB4 File Offset: 0x0009CEB4
		public static byte[] SafeDecryptPreMasterSecret(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
		{
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion = context.ClientVersion;
			bool versionNumberCheckDisabled = false;
			byte[] fallback = new byte[48];
			context.SecureRandom.NextBytes(fallback);
			byte[] M = global::Org.BouncyCastle.Utilities.Arrays.Clone(fallback);
			try
			{
				global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding pkcs1Encoding = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), fallback);
				pkcs1Encoding.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(rsaServerPrivateKey, context.SecureRandom));
				M = pkcs1Encoding.ProcessBlock(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
			}
			catch (global::System.Exception)
			{
			}
			if (!versionNumberCheckDisabled || !clientVersion.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10))
			{
				int num = (clientVersion.MajorVersion ^ (int)(M[0] & byte.MaxValue)) | (clientVersion.MinorVersion ^ (int)(M[1] & byte.MaxValue));
				int num2 = num | num >> 1;
				int num3 = num2 | num2 >> 2;
				int mask = ~(((num3 | num3 >> 4) & 1) - 1);
				for (int i = 0; i < 48; i++)
				{
					M[i] = (byte)(((int)M[i] & ~mask) | ((int)fallback[i] & mask));
				}
			}
			return M;
		}
	}
}
