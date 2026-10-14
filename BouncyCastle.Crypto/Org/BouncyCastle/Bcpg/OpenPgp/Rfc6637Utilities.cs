using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C8 RID: 1480
	public sealed class Rfc6637Utilities
	{
		// Token: 0x060037D7 RID: 14295 RVA: 0x0010812A File Offset: 0x0010632A
		private Rfc6637Utilities()
		{
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x00108134 File Offset: 0x00106334
		public static string GetAgreementAlgorithm(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyData)
		{
			global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey ecKey = (global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey)pubKeyData.Key;
			switch (ecKey.HashAlgorithm)
			{
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha256:
				return "ECCDHwithSHA256CKDF";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha384:
				return "ECCDHwithSHA384CKDF";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha512:
				return "ECCDHwithSHA512CKDF";
			default:
				throw new global::System.ArgumentException("Unknown hash algorithm specified: " + ecKey.HashAlgorithm.ToString());
			}
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x001081A0 File Offset: 0x001063A0
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetKeyEncryptionOID(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algID)
		{
			switch (algID)
			{
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes192:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes256:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap;
			default:
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown symmetric algorithm ID: " + algID.ToString());
			}
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x001081F1 File Offset: 0x001063F1
		public static int GetKeyLength(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algID)
		{
			switch (algID)
			{
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128:
				return 16;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes192:
				return 24;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes256:
				return 32;
			default:
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown symmetric algorithm ID: " + algID.ToString());
			}
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00108230 File Offset: 0x00106430
		public static byte[] CreateKey(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyData, global::Org.BouncyCastle.Math.EC.ECPoint s)
		{
			byte[] userKeyingMaterial = global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.CreateUserKeyingMaterial(pubKeyData);
			global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey ecKey = (global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey)pubKeyData.Key;
			return global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.Kdf(ecKey.HashAlgorithm, s, global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.GetKeyLength(ecKey.SymmetricKeyAlgorithm), userKeyingMaterial);
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00108268 File Offset: 0x00106468
		public static byte[] CreateUserKeyingMaterial(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyData)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey ecKey = (global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey)pubKeyData.Key;
			byte[] encOid = ecKey.CurveOid.GetEncoded();
			memoryStream.Write(encOid, 1, encOid.Length - 1);
			memoryStream.WriteByte((byte)pubKeyData.Algorithm);
			memoryStream.WriteByte(3);
			memoryStream.WriteByte(1);
			memoryStream.WriteByte((byte)ecKey.HashAlgorithm);
			memoryStream.WriteByte((byte)ecKey.SymmetricKeyAlgorithm);
			memoryStream.Write(global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.ANONYMOUS_SENDER, 0, global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.ANONYMOUS_SENDER.Length);
			byte[] fingerprint = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.CalculateFingerprint(pubKeyData);
			memoryStream.Write(fingerprint, 0, fingerprint.Length);
			return memoryStream.ToArray();
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00108300 File Offset: 0x00106500
		private static byte[] Kdf(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag digestAlg, global::Org.BouncyCastle.Math.EC.ECPoint s, int keyLen, byte[] parameters)
		{
			byte[] ZB = s.XCoord.GetEncoded();
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(digestAlg));
			digest.Update(0);
			digest.Update(0);
			digest.Update(0);
			digest.Update(1);
			digest.BlockUpdate(ZB, 0, ZB.Length);
			digest.BlockUpdate(parameters, 0, parameters.Length);
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest), 0, keyLen);
		}

		// Token: 0x04001919 RID: 6425
		private static readonly byte[] ANONYMOUS_SENDER = global::Org.BouncyCastle.Utilities.Encoders.Hex.Decode("416E6F6E796D6F75732053656E64657220202020");
	}
}
