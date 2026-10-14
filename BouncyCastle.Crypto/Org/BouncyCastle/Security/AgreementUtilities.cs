using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C0 RID: 448
	public sealed class AgreementUtilities
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x00044355 File Offset: 0x00042555
		private AgreementUtilities()
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00044360 File Offset: 0x00042560
		static AgreementUtilities()
		{
			global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassCofactorDHSha1KdfScheme.Id] = "ECCDHWITHSHA1KDF";
			global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassStdDHSha1KdfScheme.Id] = "ECDHWITHSHA1KDF";
			global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.MqvSinglePassSha1KdfScheme.Id] = "ECMQVWITHSHA1KDF";
			global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519.Id] = "X25519";
			global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448.Id] = "X448";
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x000443F4 File Offset: 0x000425F4
		public static global::Org.BouncyCastle.Crypto.IBasicAgreement GetBasicAgreement(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.AgreementUtilities.GetBasicAgreement(oid.Id);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00044404 File Offset: 0x00042604
		public static global::Org.BouncyCastle.Crypto.IBasicAgreement GetBasicAgreement(string algorithm)
		{
			string mechanism = global::Org.BouncyCastle.Security.AgreementUtilities.GetMechanism(algorithm);
			if (mechanism == "DH" || mechanism == "DIFFIEHELLMAN")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
			}
			if (mechanism == "ECDH")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
			}
			if (mechanism == "ECDHC" || mechanism == "ECCDH")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.ECDHCBasicAgreement();
			}
			if (mechanism == "ECMQV")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.ECMqvBasicAgreement();
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Basic Agreement " + algorithm + " not recognised.");
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00044493 File Offset: 0x00042693
		public static global::Org.BouncyCastle.Crypto.IBasicAgreement GetBasicAgreementWithKdf(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string wrapAlgorithm)
		{
			return global::Org.BouncyCastle.Security.AgreementUtilities.GetBasicAgreementWithKdf(oid.Id, wrapAlgorithm);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000444A4 File Offset: 0x000426A4
		public static global::Org.BouncyCastle.Crypto.IBasicAgreement GetBasicAgreementWithKdf(string agreeAlgorithm, string wrapAlgorithm)
		{
			string mechanism = global::Org.BouncyCastle.Security.AgreementUtilities.GetMechanism(agreeAlgorithm);
			if (mechanism == "DHWITHSHA1KDF" || mechanism == "ECDHWITHSHA1KDF")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.ECDHWithKdfBasicAgreement(wrapAlgorithm, new global::Org.BouncyCastle.Crypto.Agreement.Kdf.ECDHKekGenerator(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest()));
			}
			if (mechanism == "ECMQVWITHSHA1KDF")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.ECMqvWithKdfBasicAgreement(wrapAlgorithm, new global::Org.BouncyCastle.Crypto.Agreement.Kdf.ECDHKekGenerator(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest()));
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Basic Agreement (with KDF) " + agreeAlgorithm + " not recognised.");
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00044516 File Offset: 0x00042716
		public static global::Org.BouncyCastle.Crypto.IRawAgreement GetRawAgreement(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.AgreementUtilities.GetRawAgreement(oid.Id);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00044524 File Offset: 0x00042724
		public static global::Org.BouncyCastle.Crypto.IRawAgreement GetRawAgreement(string algorithm)
		{
			string mechanism = global::Org.BouncyCastle.Security.AgreementUtilities.GetMechanism(algorithm);
			if (mechanism == "X25519")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.X25519Agreement();
			}
			if (mechanism == "X448")
			{
				return new global::Org.BouncyCastle.Crypto.Agreement.X448Agreement();
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Raw Agreement " + algorithm + " not recognised.");
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00044573 File Offset: 0x00042773
		public static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[oid.Id];
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004458C File Offset: 0x0004278C
		private static string GetMechanism(string algorithm)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.AgreementUtilities.algorithms[upper];
			if (mechanism != null)
			{
				return mechanism;
			}
			return upper;
		}

		// Token: 0x040008C7 RID: 2247
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
