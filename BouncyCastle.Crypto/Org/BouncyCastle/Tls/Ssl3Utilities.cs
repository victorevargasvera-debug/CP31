using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F4 RID: 244
	internal abstract class Ssl3Utilities
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x00023948 File Offset: 0x00021B48
		internal static byte[] CalculateVerifyData(global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, bool isServer)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsHash tlsHash = handshakeHash.ForkPrfHash();
			byte[] sslSender = isServer ? global::Org.BouncyCastle.Tls.Ssl3Utilities.SSL_SERVER : global::Org.BouncyCastle.Tls.Ssl3Utilities.SSL_CLIENT;
			tlsHash.Update(sslSender, 0, sslSender.Length);
			return tlsHash.CalculateHash();
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002397C File Offset: 0x00021B7C
		internal static void CompleteCombinedHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsHash md5, global::Org.BouncyCastle.Tls.Crypto.TlsHash sha1)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret = context.SecurityParameters.MasterSecret;
			byte[] master_secret = context.Crypto.AdoptSecret(masterSecret).Extract();
			global::Org.BouncyCastle.Tls.Ssl3Utilities.CompleteHash(master_secret, md5, 48);
			global::Org.BouncyCastle.Tls.Ssl3Utilities.CompleteHash(master_secret, sha1, 40);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000239B8 File Offset: 0x00021BB8
		private static void CompleteHash(byte[] master_secret, global::Org.BouncyCastle.Tls.Crypto.TlsHash hash, int padLength)
		{
			hash.Update(master_secret, 0, master_secret.Length);
			hash.Update(global::Org.BouncyCastle.Tls.Ssl3Utilities.IPAD, 0, padLength);
			byte[] tmp = hash.CalculateHash();
			hash.Update(master_secret, 0, master_secret.Length);
			hash.Update(global::Org.BouncyCastle.Tls.Ssl3Utilities.OPAD, 0, padLength);
			hash.Update(tmp, 0, tmp.Length);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00023A07 File Offset: 0x00021C07
		private static byte[] GenPad(byte b, int count)
		{
			byte[] array = new byte[count];
			global::Org.BouncyCastle.Utilities.Arrays.Fill(array, b);
			return array;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00023A16 File Offset: 0x00021C16
		internal static byte[] ReadEncryptedPms(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(input);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00023A1E File Offset: 0x00021C1E
		internal static void WriteEncryptedPms(byte[] encryptedPms, global::System.IO.Stream output)
		{
			output.Write(encryptedPms, 0, encryptedPms.Length);
		}

		// Token: 0x040006CD RID: 1741
		private static readonly byte[] SSL_CLIENT = new byte[]
		{
			67,
			76,
			78,
			84
		};

		// Token: 0x040006CE RID: 1742
		private static readonly byte[] SSL_SERVER = new byte[]
		{
			83,
			82,
			86,
			82
		};

		// Token: 0x040006CF RID: 1743
		private const byte IPAD_BYTE = 54;

		// Token: 0x040006D0 RID: 1744
		private const byte OPAD_BYTE = 92;

		// Token: 0x040006D1 RID: 1745
		private static readonly byte[] IPAD = global::Org.BouncyCastle.Tls.Ssl3Utilities.GenPad(54, 48);

		// Token: 0x040006D2 RID: 1746
		private static readonly byte[] OPAD = global::Org.BouncyCastle.Tls.Ssl3Utilities.GenPad(92, 48);
	}
}
