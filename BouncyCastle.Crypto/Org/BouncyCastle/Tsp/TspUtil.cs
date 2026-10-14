using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000084 RID: 132
	public class TspUtil
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x00017D1C File Offset: 0x00015F1C
		static TspUtil()
		{
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id, 16);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id, 20);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id, 28);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id, 32);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id, 48);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id, 64);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id, 16);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id, 20);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id, 32);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id, 32);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256.Id, 32);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512.Id, 64);
			global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Add(global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3.Id, 32);
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id, "MD5");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id, "SHA1");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id, "SHA224");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id, "SHA256");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id, "SHA384");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id, "SHA512");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption.Id, "MD5");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id, "SHA1");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption.Id, "SHA224");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption.Id, "SHA256");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption.Id, "SHA384");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption.Id, "SHA512");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id, "RIPEMD128");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id, "RIPEMD160");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id, "RIPEMD256");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id, "GOST3411");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1.Id, "SHA1");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa.Id, "SHA1");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa.Id, "MD5");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256.Id, "GOST3411-2012-256");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512.Id, "GOST3411-2012-512");
			global::Org.BouncyCastle.Tsp.TspUtil.digestNames.Add(global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3.Id, "SM3");
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000180E0 File Offset: 0x000162E0
		public static global::System.Collections.ICollection GetSignatureTimestamps(global::Org.BouncyCastle.Cms.SignerInformation signerInfo)
		{
			global::System.Collections.IList timestamps = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttrs = signerInfo.UnsignedAttributes;
			if (unsignedAttrs != null)
			{
				foreach (object obj in unsignedAttrs.GetAll(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASignatureTimeStampToken))
				{
					foreach (object obj2 in ((global::Org.BouncyCastle.Asn1.Cms.Attribute)obj).AttrValues)
					{
						global::Org.BouncyCastle.Asn1.Asn1Encodable asn = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2;
						try
						{
							global::Org.BouncyCastle.Tsp.TimeStampToken timeStampToken = new global::Org.BouncyCastle.Tsp.TimeStampToken(global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(asn.ToAsn1Object()));
							global::Org.BouncyCastle.Tsp.TimeStampTokenInfo tstInfo = timeStampToken.TimeStampInfo;
							if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(global::Org.BouncyCastle.Tsp.TspUtil.GetDigestAlgName(tstInfo.MessageImprintAlgOid), signerInfo.GetSignature()), tstInfo.GetMessageImprintDigest()))
							{
								throw new global::Org.BouncyCastle.Tsp.TspValidationException("Incorrect digest in message imprint");
							}
							timestamps.Add(timeStampToken);
						}
						catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
						{
							throw new global::Org.BouncyCastle.Tsp.TspValidationException("Unknown hash algorithm specified in timestamp");
						}
						catch (global::System.Exception)
						{
							throw new global::Org.BouncyCastle.Tsp.TspValidationException("Timestamp could not be parsed");
						}
					}
				}
			}
			return timestamps;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00018224 File Offset: 0x00016424
		public static void ValidateCertificate(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			if (cert.Version != 3)
			{
				throw new global::System.ArgumentException("Certificate must have an ExtendedKeyUsage extension.");
			}
			global::Org.BouncyCastle.Asn1.Asn1OctetString ext = cert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.ExtendedKeyUsage);
			if (ext == null)
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("Certificate must have an ExtendedKeyUsage extension.");
			}
			if (!cert.GetCriticalExtensionOids().Contains(global::Org.BouncyCastle.Asn1.X509.X509Extensions.ExtendedKeyUsage.Id))
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("Certificate must have an ExtendedKeyUsage extension marked as critical.");
			}
			try
			{
				global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage extKey = global::Org.BouncyCastle.Asn1.X509.ExtendedKeyUsage.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(ext.GetOctets()));
				if (!extKey.HasKeyPurposeId(global::Org.BouncyCastle.Asn1.X509.KeyPurposeID.IdKPTimeStamping) || extKey.Count != 1)
				{
					throw new global::Org.BouncyCastle.Tsp.TspValidationException("ExtendedKeyUsage not solely time stamping.");
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("cannot process ExtendedKeyUsage extension");
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000182D4 File Offset: 0x000164D4
		internal static string GetDigestAlgName(string digestAlgOID)
		{
			string digestName = (string)global::Org.BouncyCastle.Tsp.TspUtil.digestNames[digestAlgOID];
			if (digestName == null)
			{
				return digestAlgOID;
			}
			return digestName;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000182F8 File Offset: 0x000164F8
		internal static int GetDigestLength(string digestAlgOID)
		{
			if (!global::Org.BouncyCastle.Tsp.TspUtil.digestLengths.Contains(digestAlgOID))
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("digest algorithm cannot be found.");
			}
			return (int)global::Org.BouncyCastle.Tsp.TspUtil.digestLengths[digestAlgOID];
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00018322 File Offset: 0x00016522
		internal static global::Org.BouncyCastle.Crypto.IDigest CreateDigestInstance(string digestAlgOID)
		{
			return global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Tsp.TspUtil.GetDigestAlgName(digestAlgOID));
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001832F File Offset: 0x0001652F
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet GetCriticalExtensionOids(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			if (extensions == null)
			{
				return global::Org.BouncyCastle.Tsp.TspUtil.EmptySet;
			}
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(new global::Org.BouncyCastle.Utilities.Collections.HashSet(extensions.GetCriticalExtensionOids()));
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001834A File Offset: 0x0001654A
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet GetNonCriticalExtensionOids(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			if (extensions == null)
			{
				return global::Org.BouncyCastle.Tsp.TspUtil.EmptySet;
			}
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(new global::Org.BouncyCastle.Utilities.Collections.HashSet(extensions.GetNonCriticalExtensionOids()));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00018365 File Offset: 0x00016565
		internal static global::System.Collections.IList GetExtensionOids(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			if (extensions == null)
			{
				return global::Org.BouncyCastle.Tsp.TspUtil.EmptyList;
			}
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(extensions.GetExtensionOids()));
		}

		// Token: 0x040002DC RID: 732
		private static global::Org.BouncyCastle.Utilities.Collections.ISet EmptySet = global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(new global::Org.BouncyCastle.Utilities.Collections.HashSet());

		// Token: 0x040002DD RID: 733
		private static global::System.Collections.IList EmptyList = global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ReadOnly(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList());

		// Token: 0x040002DE RID: 734
		private static readonly global::System.Collections.IDictionary digestLengths = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040002DF RID: 735
		private static readonly global::System.Collections.IDictionary digestNames = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
