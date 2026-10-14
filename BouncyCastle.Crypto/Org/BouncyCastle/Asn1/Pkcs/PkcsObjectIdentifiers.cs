using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006BA RID: 1722
	public abstract class PkcsObjectIdentifiers
	{
		// Token: 0x04001C88 RID: 7304
		public const string Pkcs1 = "1.2.840.113549.1.1";

		// Token: 0x04001C89 RID: 7305
		internal static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs1Oid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.1");

		// Token: 0x04001C8A RID: 7306
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("1");

		// Token: 0x04001C8B RID: 7307
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD2WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("2");

		// Token: 0x04001C8C RID: 7308
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD4WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("3");

		// Token: 0x04001C8D RID: 7309
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD5WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("4");

		// Token: 0x04001C8E RID: 7310
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha1WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("5");

		// Token: 0x04001C8F RID: 7311
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SrsaOaepEncryptionSet = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("6");

		// Token: 0x04001C90 RID: 7312
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsaesOaep = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("7");

		// Token: 0x04001C91 RID: 7313
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdMgf1 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("8");

		// Token: 0x04001C92 RID: 7314
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdPSpecified = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("9");

		// Token: 0x04001C93 RID: 7315
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPss = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("10");

		// Token: 0x04001C94 RID: 7316
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha256WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("11");

		// Token: 0x04001C95 RID: 7317
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha384WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("12");

		// Token: 0x04001C96 RID: 7318
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("13");

		// Token: 0x04001C97 RID: 7319
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha224WithRsaEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("14");

		// Token: 0x04001C98 RID: 7320
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512_224WithRSAEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("15");

		// Token: 0x04001C99 RID: 7321
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512_256WithRSAEncryption = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs1Oid.Branch("16");

		// Token: 0x04001C9A RID: 7322
		public const string Pkcs3 = "1.2.840.113549.1.3";

		// Token: 0x04001C9B RID: 7323
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DhKeyAgreement = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.3.1");

		// Token: 0x04001C9C RID: 7324
		public const string Pkcs5 = "1.2.840.113549.1.5";

		// Token: 0x04001C9D RID: 7325
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD2AndDesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.1");

		// Token: 0x04001C9E RID: 7326
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD2AndRC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.4");

		// Token: 0x04001C9F RID: 7327
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD5AndDesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.3");

		// Token: 0x04001CA0 RID: 7328
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD5AndRC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.6");

		// Token: 0x04001CA1 RID: 7329
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithSha1AndDesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.10");

		// Token: 0x04001CA2 RID: 7330
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithSha1AndRC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.11");

		// Token: 0x04001CA3 RID: 7331
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdPbeS2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.13");

		// Token: 0x04001CA4 RID: 7332
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdPbkdf2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.5.12");

		// Token: 0x04001CA5 RID: 7333
		public const string EncryptionAlgorithm = "1.2.840.113549.3";

		// Token: 0x04001CA6 RID: 7334
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.3.7");

		// Token: 0x04001CA7 RID: 7335
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.3.2");

		// Token: 0x04001CA8 RID: 7336
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier rc4 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.3.4");

		// Token: 0x04001CA9 RID: 7337
		public const string DigestAlgorithm = "1.2.840.113549.2";

		// Token: 0x04001CAA RID: 7338
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.2");

		// Token: 0x04001CAB RID: 7339
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD4 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.4");

		// Token: 0x04001CAC RID: 7340
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MD5 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.5");

		// Token: 0x04001CAD RID: 7341
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.7");

		// Token: 0x04001CAE RID: 7342
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.8");

		// Token: 0x04001CAF RID: 7343
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.9");

		// Token: 0x04001CB0 RID: 7344
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.10");

		// Token: 0x04001CB1 RID: 7345
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.2.11");

		// Token: 0x04001CB2 RID: 7346
		public const string Pkcs7 = "1.2.840.113549.1.7";

		// Token: 0x04001CB3 RID: 7347
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Data = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.1");

		// Token: 0x04001CB4 RID: 7348
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.2");

		// Token: 0x04001CB5 RID: 7349
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EnvelopedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.3");

		// Token: 0x04001CB6 RID: 7350
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedAndEnvelopedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.4");

		// Token: 0x04001CB7 RID: 7351
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DigestedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.5");

		// Token: 0x04001CB8 RID: 7352
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.7.6");

		// Token: 0x04001CB9 RID: 7353
		public const string Pkcs9 = "1.2.840.113549.1.9";

		// Token: 0x04001CBA RID: 7354
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtEmailAddress = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.1");

		// Token: 0x04001CBB RID: 7355
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtUnstructuredName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.2");

		// Token: 0x04001CBC RID: 7356
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtContentType = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.3");

		// Token: 0x04001CBD RID: 7357
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtMessageDigest = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.4");

		// Token: 0x04001CBE RID: 7358
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSigningTime = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.5");

		// Token: 0x04001CBF RID: 7359
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtCounterSignature = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.6");

		// Token: 0x04001CC0 RID: 7360
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtChallengePassword = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.7");

		// Token: 0x04001CC1 RID: 7361
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtUnstructuredAddress = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.8");

		// Token: 0x04001CC2 RID: 7362
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtExtendedCertificateAttributes = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.9");

		// Token: 0x04001CC3 RID: 7363
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSigningDescription = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.13");

		// Token: 0x04001CC4 RID: 7364
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtExtensionRequest = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.14");

		// Token: 0x04001CC5 RID: 7365
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSmimeCapabilities = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.15");

		// Token: 0x04001CC6 RID: 7366
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSmime = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16");

		// Token: 0x04001CC7 RID: 7367
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtFriendlyName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.20");

		// Token: 0x04001CC8 RID: 7368
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtLocalKeyID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.21");

		// Token: 0x04001CC9 RID: 7369
		[global::System.Obsolete("Use X509Certificate instead")]
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier X509CertType = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.22.1");

		// Token: 0x04001CCA RID: 7370
		public const string CertTypes = "1.2.840.113549.1.9.22";

		// Token: 0x04001CCB RID: 7371
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier X509Certificate = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.22.1");

		// Token: 0x04001CCC RID: 7372
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SdsiCertificate = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.22.2");

		// Token: 0x04001CCD RID: 7373
		public const string CrlTypes = "1.2.840.113549.1.9.23";

		// Token: 0x04001CCE RID: 7374
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier X509Crl = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.23.1");

		// Token: 0x04001CCF RID: 7375
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlg = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdSmime.Branch("3");

		// Token: 0x04001CD0 RID: 7376
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgEsdh = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("5");

		// Token: 0x04001CD1 RID: 7377
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgCms3DesWrap = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("6");

		// Token: 0x04001CD2 RID: 7378
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgCmsRC2Wrap = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("7");

		// Token: 0x04001CD3 RID: 7379
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgPwriKek = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("9");

		// Token: 0x04001CD4 RID: 7380
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgSsdh = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("10");

		// Token: 0x04001CD5 RID: 7381
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsaKem = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("14");

		// Token: 0x04001CD6 RID: 7382
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgAeadChaCha20Poly1305 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlg.Branch("18");

		// Token: 0x04001CD7 RID: 7383
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtSmimeCapabilities.Branch("1");

		// Token: 0x04001CD8 RID: 7384
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtSmimeCapabilities.Branch("2");

		// Token: 0x04001CD9 RID: 7385
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitiesVersions = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtSmimeCapabilities.Branch("3");

		// Token: 0x04001CDA RID: 7386
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAReceiptRequest = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdSmime.Branch("2.1");

		// Token: 0x04001CDB RID: 7387
		public const string IdCT = "1.2.840.113549.1.9.16.1";

		// Token: 0x04001CDC RID: 7388
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTAuthData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.2");

		// Token: 0x04001CDD RID: 7389
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTTstInfo = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.4");

		// Token: 0x04001CDE RID: 7390
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTCompressedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.9");

		// Token: 0x04001CDF RID: 7391
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTAuthEnvelopedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.23");

		// Token: 0x04001CE0 RID: 7392
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTTimestampedData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.31");

		// Token: 0x04001CE1 RID: 7393
		public const string IdCti = "1.2.840.113549.1.9.16.6";

		// Token: 0x04001CE2 RID: 7394
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfOrigin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.1");

		// Token: 0x04001CE3 RID: 7395
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfReceipt = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.2");

		// Token: 0x04001CE4 RID: 7396
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfDelivery = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.3");

		// Token: 0x04001CE5 RID: 7397
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfSender = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.4");

		// Token: 0x04001CE6 RID: 7398
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfApproval = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.5");

		// Token: 0x04001CE7 RID: 7399
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfCreation = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.6.6");

		// Token: 0x04001CE8 RID: 7400
		public const string IdAA = "1.2.840.113549.1.9.16.2";

		// Token: 0x04001CE9 RID: 7401
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAOid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2");

		// Token: 0x04001CEA RID: 7402
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentHint = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.4");

		// Token: 0x04001CEB RID: 7403
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAMsgSigDigest = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.5");

		// Token: 0x04001CEC RID: 7404
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentReference = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.10");

		// Token: 0x04001CED RID: 7405
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEncrypKeyPref = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.11");

		// Token: 0x04001CEE RID: 7406
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigningCertificate = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.12");

		// Token: 0x04001CEF RID: 7407
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigningCertificateV2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.47");

		// Token: 0x04001CF0 RID: 7408
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentIdentifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.7");

		// Token: 0x04001CF1 RID: 7409
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASignatureTimeStampToken = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.14");

		// Token: 0x04001CF2 RID: 7410
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSigPolicyID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.15");

		// Token: 0x04001CF3 RID: 7411
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCommitmentType = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.16");

		// Token: 0x04001CF4 RID: 7412
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSignerLocation = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.17");

		// Token: 0x04001CF5 RID: 7413
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSignerAttr = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.18");

		// Token: 0x04001CF6 RID: 7414
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsOtherSigCert = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.19");

		// Token: 0x04001CF7 RID: 7415
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsContentTimestamp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.20");

		// Token: 0x04001CF8 RID: 7416
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertificateRefs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.21");

		// Token: 0x04001CF9 RID: 7417
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsRevocationRefs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.22");

		// Token: 0x04001CFA RID: 7418
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertValues = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.23");

		// Token: 0x04001CFB RID: 7419
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsRevocationValues = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.24");

		// Token: 0x04001CFC RID: 7420
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsEscTimeStamp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.25");

		// Token: 0x04001CFD RID: 7421
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertCrlTimestamp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.26");

		// Token: 0x04001CFE RID: 7422
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsArchiveTimestamp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.27");

		// Token: 0x04001CFF RID: 7423
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAADecryptKeyID = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAOid.Branch("37");

		// Token: 0x04001D00 RID: 7424
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAImplCryptoAlgs = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAOid.Branch("38");

		// Token: 0x04001D01 RID: 7425
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAAsymmDecryptKeyID = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAOid.Branch("54");

		// Token: 0x04001D02 RID: 7426
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAImplCompressAlgs = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAOid.Branch("43");

		// Token: 0x04001D03 RID: 7427
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAACommunityIdentifiers = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAOid.Branch("40");

		// Token: 0x04001D04 RID: 7428
		[global::System.Obsolete("Use 'IdAAEtsSigPolicyID' instead")]
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigPolicyID = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsSigPolicyID;

		// Token: 0x04001D05 RID: 7429
		[global::System.Obsolete("Use 'IdAAEtsCommitmentType' instead")]
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAACommitmentType = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsCommitmentType;

		// Token: 0x04001D06 RID: 7430
		[global::System.Obsolete("Use 'IdAAEtsSignerLocation' instead")]
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASignerLocation = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsSignerLocation;

		// Token: 0x04001D07 RID: 7431
		[global::System.Obsolete("Use 'IdAAEtsOtherSigCert' instead")]
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAOtherSigCert = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsOtherSigCert;

		// Token: 0x04001D08 RID: 7432
		public const string IdSpq = "1.2.840.113549.1.9.16.5";

		// Token: 0x04001D09 RID: 7433
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSpqEtsUri = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.5.1");

		// Token: 0x04001D0A RID: 7434
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSpqEtsUNotice = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.5.2");

		// Token: 0x04001D0B RID: 7435
		public const string Pkcs12 = "1.2.840.113549.1.12";

		// Token: 0x04001D0C RID: 7436
		public const string BagTypes = "1.2.840.113549.1.12.10.1";

		// Token: 0x04001D0D RID: 7437
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier KeyBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.1");

		// Token: 0x04001D0E RID: 7438
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs8ShroudedKeyBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.2");

		// Token: 0x04001D0F RID: 7439
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.3");

		// Token: 0x04001D10 RID: 7440
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CrlBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.4");

		// Token: 0x04001D11 RID: 7441
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecretBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.5");

		// Token: 0x04001D12 RID: 7442
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SafeContentsBag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.10.1.6");

		// Token: 0x04001D13 RID: 7443
		public const string Pkcs12PbeIds = "1.2.840.113549.1.12.1";

		// Token: 0x04001D14 RID: 7444
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd128BitRC4 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.1");

		// Token: 0x04001D15 RID: 7445
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd40BitRC4 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.2");

		// Token: 0x04001D16 RID: 7446
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd3KeyTripleDesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.3");

		// Token: 0x04001D17 RID: 7447
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd2KeyTripleDesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.4");

		// Token: 0x04001D18 RID: 7448
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd128BitRC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.5");

		// Token: 0x04001D19 RID: 7449
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PbewithShaAnd40BitRC2Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.12.1.6");
	}
}
