using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000141 RID: 321
	public abstract class TlsCryptoUtilities
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x00032160 File Offset: 0x00030360
		public static int GetHash(short hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return 3;
			case 4:
				return 4;
			case 5:
				return 5;
			case 6:
				return 6;
			default:
				throw new global::System.ArgumentException("specified HashAlgorithm invalid: " + global::Org.BouncyCastle.Tls.HashAlgorithm.GetText(hashAlgorithm));
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000321B0 File Offset: 0x000303B0
		public static int GetHashForHmac(int macAlgorithm)
		{
			switch (macAlgorithm)
			{
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return 4;
			case 4:
				return 5;
			case 5:
				return 6;
			default:
				throw new global::System.ArgumentException("specified MacAlgorithm not an HMAC: " + global::Org.BouncyCastle.Tls.MacAlgorithm.GetText(macAlgorithm));
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000321F0 File Offset: 0x000303F0
		public static int GetHashForPrf(int prfAlgorithm)
		{
			switch (prfAlgorithm)
			{
			case 0:
			case 1:
				throw new global::System.ArgumentException("legacy PRF not a valid algorithm");
			case 2:
			case 4:
				return 4;
			case 3:
			case 5:
				return 5;
			case 7:
				return 7;
			}
			throw new global::System.ArgumentException("unknown PrfAlgorithm: " + global::Org.BouncyCastle.Tls.PrfAlgorithm.GetText(prfAlgorithm));
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003224B File Offset: 0x0003044B
		public static int GetHashOutputSize(int cryptoHashAlgorithm)
		{
			switch (cryptoHashAlgorithm)
			{
			case 1:
				return 16;
			case 2:
				return 20;
			case 3:
				return 28;
			case 4:
			case 7:
				return 32;
			case 5:
				return 48;
			case 6:
				return 64;
			default:
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003228C File Offset: 0x0003048C
		public static int GetSignature(short signatureAlgorithm)
		{
			switch (signatureAlgorithm)
			{
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return 3;
			case 4:
				return 4;
			case 5:
				return 5;
			case 6:
				return 6;
			case 7:
				return 7;
			case 8:
				return 8;
			case 9:
				return 9;
			case 10:
				return 10;
			case 11:
				return 11;
			default:
				if (signatureAlgorithm == 64)
				{
					return 64;
				}
				if (signatureAlgorithm != 65)
				{
					throw new global::System.ArgumentException("specified SignatureAlgorithm invalid: " + global::Org.BouncyCastle.Tls.SignatureAlgorithm.GetText(signatureAlgorithm));
				}
				return 65;
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00032310 File Offset: 0x00030510
		public static global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExpandLabel(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, int cryptoHashAlgorithm, string label, byte[] context, int length)
		{
			int labelLength = label.Length;
			if (labelLength < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			int contextLength = context.Length;
			int expandedLabelLength = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.Tls13Prefix.Length + labelLength;
			byte[] hkdfLabel = new byte[2 + (1 + expandedLabelLength) + (1 + contextLength)];
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(length, hkdfLabel, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(expandedLabelLength);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(expandedLabelLength, hkdfLabel, 2);
			global::System.Array.Copy(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.Tls13Prefix, 0, hkdfLabel, 3, global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.Tls13Prefix.Length);
			int labelPos = 2 + (1 + global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.Tls13Prefix.Length);
			for (int i = 0; i < labelLength; i++)
			{
				char c = label[i];
				hkdfLabel[labelPos + i] = (byte)c;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(context, hkdfLabel, 2 + (1 + expandedLabelLength));
			return secret.HkdfExpand(cryptoHashAlgorithm, hkdfLabel, length);
		}

		// Token: 0x040007C5 RID: 1989
		private static readonly byte[] Tls13Prefix = new byte[]
		{
			116,
			108,
			115,
			49,
			51,
			32
		};
	}
}
