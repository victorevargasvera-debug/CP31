using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AA RID: 426
	public sealed class EncryptedPrivateKeyInfoFactory
	{
		// Token: 0x06001023 RID: 4131 RVA: 0x0003FE8C File Offset: 0x0003E08C
		private EncryptedPrivateKeyInfoFactory()
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0003FE94 File Offset: 0x0003E094
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			return global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm.Id, passPhrase, salt, iterationCount, global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(key));
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0003FEAB File Offset: 0x0003E0AB
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			return global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(key));
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo keyInfo)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher = global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(algorithm) as global::Org.BouncyCastle.Crypto.IBufferedCipher;
			if (bufferedCipher == null)
			{
				throw new global::System.Exception("Unknown encryption algorithm: " + algorithm);
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters = global::Org.BouncyCastle.Security.PbeUtilities.GenerateAlgorithmParameters(algorithm, salt, iterationCount);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algorithm, passPhrase, pbeParameters);
			bufferedCipher.Init(true, cipherParameters);
			byte[] encoding = bufferedCipher.DoFinal(keyInfo.GetEncoded());
			return new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Security.PbeUtilities.GetObjectIdentifier(algorithm), pbeParameters), encoding);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0003FF25 File Offset: 0x0003E125
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier cipherAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier prfAlgorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			return global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(cipherAlgorithm, prfAlgorithm, passPhrase, salt, iterationCount, random, global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(key));
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0003FF3C File Offset: 0x0003E13C
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo CreateEncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier cipherAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier prfAlgorithm, char[] passPhrase, byte[] salt, int iterationCount, global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo keyInfo)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(cipherAlgorithm);
			if (cipher == null)
			{
				throw new global::System.Exception("Unknown encryption algorithm: " + ((cipherAlgorithm != null) ? cipherAlgorithm.ToString() : null));
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters = global::Org.BouncyCastle.Security.PbeUtilities.GenerateAlgorithmParameters(cipherAlgorithm, prfAlgorithm, salt, iterationCount, random);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbeS2, passPhrase, pbeParameters);
			cipher.Init(true, cipherParameters);
			byte[] encoding = cipher.DoFinal(keyInfo.GetEncoded());
			return new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbeS2, pbeParameters), encoding);
		}
	}
}
