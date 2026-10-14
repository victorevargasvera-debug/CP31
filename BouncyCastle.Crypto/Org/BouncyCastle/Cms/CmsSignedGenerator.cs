using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053C RID: 1340
	public class CmsSignedGenerator
	{
		// Token: 0x060033C5 RID: 13253 RVA: 0x000F78CF File Offset: 0x000F5ACF
		protected CmsSignedGenerator() : this(new global::Org.BouncyCastle.Security.SecureRandom())
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x000F78DC File Offset: 0x000F5ADC
		protected CmsSignedGenerator(global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.rand = rand;
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x000F7918 File Offset: 0x000F5B18
		protected internal virtual global::System.Collections.IDictionary GetBaseParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgId, byte[] hash)
		{
			global::System.Collections.IDictionary param = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			if (contentType != null)
			{
				param[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.ContentType] = contentType;
			}
			param[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.DigestAlgorithmIdentifier] = digAlgId;
			param[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.Digest] = hash.Clone();
			return param;
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000F795B File Offset: 0x000F5B5B
		protected internal virtual global::Org.BouncyCastle.Asn1.Asn1Set GetAttributeSet(global::Org.BouncyCastle.Asn1.Cms.AttributeTable attr)
		{
			if (attr != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerSet(attr.ToAsn1EncodableVector());
			}
			return null;
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000F796D File Offset: 0x000F5B6D
		public void AddCertificates(global::Org.BouncyCastle.X509.Store.IX509Store certStore)
		{
			global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(this._certs, global::Org.BouncyCastle.Cms.CmsUtilities.GetCertificatesFromStore(certStore));
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000F7980 File Offset: 0x000F5B80
		public void AddCrls(global::Org.BouncyCastle.X509.Store.IX509Store crlStore)
		{
			global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(this._crls, global::Org.BouncyCastle.Cms.CmsUtilities.GetCrlsFromStore(crlStore));
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000F7994 File Offset: 0x000F5B94
		public void AddAttributeCertificates(global::Org.BouncyCastle.X509.Store.IX509Store store)
		{
			try
			{
				foreach (object obj in store.GetMatches(null))
				{
					global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert = (global::Org.BouncyCastle.X509.IX509AttributeCertificate)obj;
					this._certs.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(attrCert.GetEncoded()))));
				}
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error processing attribute certs", e);
			}
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x000F7A28 File Offset: 0x000F5C28
		public void AddSigners(global::Org.BouncyCastle.Cms.SignerInformationStore signerStore)
		{
			foreach (object obj in signerStore.GetSigners())
			{
				global::Org.BouncyCastle.Cms.SignerInformation o = (global::Org.BouncyCastle.Cms.SignerInformation)obj;
				this._signers.Add(o);
				this.AddSignerCallback(o);
			}
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x000F7A90 File Offset: 0x000F5C90
		public global::System.Collections.IDictionary GetGeneratedDigests()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(this._digests);
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x000F7A9D File Offset: 0x000F5C9D
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x000F7AA5 File Offset: 0x000F5CA5
		public bool UseDerForCerts
		{
			get
			{
				return this._useDerForCerts;
			}
			set
			{
				this._useDerForCerts = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x000F7AAE File Offset: 0x000F5CAE
		// (set) Token: 0x060033D1 RID: 13265 RVA: 0x000F7AB6 File Offset: 0x000F5CB6
		public bool UseDerForCrls
		{
			get
			{
				return this._useDerForCrls;
			}
			set
			{
				this._useDerForCrls = value;
			}
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x000F7ABF File Offset: 0x000F5CBF
		internal virtual void AddSignerCallback(global::Org.BouncyCastle.Cms.SignerInformation si)
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x000F7AC1 File Offset: 0x000F5CC1
		internal static global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier GetSignerIdentifier(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			return new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier(global::Org.BouncyCastle.Cms.CmsUtilities.GetIssuerAndSerialNumber(cert));
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x000F7ACE File Offset: 0x000F5CCE
		internal static global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier GetSignerIdentifier(byte[] subjectKeyIdentifier)
		{
			return new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier(new global::Org.BouncyCastle.Asn1.DerOctetString(subjectKeyIdentifier));
		}

		// Token: 0x0400171C RID: 5916
		public static readonly string Data = global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data.Id;

		// Token: 0x0400171D RID: 5917
		public static readonly string DigestSha1 = global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id;

		// Token: 0x0400171E RID: 5918
		public static readonly string DigestSha224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id;

		// Token: 0x0400171F RID: 5919
		public static readonly string DigestSha256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id;

		// Token: 0x04001720 RID: 5920
		public static readonly string DigestSha384 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id;

		// Token: 0x04001721 RID: 5921
		public static readonly string DigestSha512 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id;

		// Token: 0x04001722 RID: 5922
		public static readonly string DigestSha512_224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224.Id;

		// Token: 0x04001723 RID: 5923
		public static readonly string DigestSha512_256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256.Id;

		// Token: 0x04001724 RID: 5924
		public static readonly string DigestMD5 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id;

		// Token: 0x04001725 RID: 5925
		public static readonly string DigestGost3411 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id;

		// Token: 0x04001726 RID: 5926
		public static readonly string DigestRipeMD128 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id;

		// Token: 0x04001727 RID: 5927
		public static readonly string DigestRipeMD160 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id;

		// Token: 0x04001728 RID: 5928
		public static readonly string DigestRipeMD256 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id;

		// Token: 0x04001729 RID: 5929
		public static readonly string EncryptionRsa = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Id;

		// Token: 0x0400172A RID: 5930
		public static readonly string EncryptionDsa = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1.Id;

		// Token: 0x0400172B RID: 5931
		public static readonly string EncryptionECDsa = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1.Id;

		// Token: 0x0400172C RID: 5932
		public static readonly string EncryptionRsaPss = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Id;

		// Token: 0x0400172D RID: 5933
		public static readonly string EncryptionGost3410 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94.Id;

		// Token: 0x0400172E RID: 5934
		public static readonly string EncryptionECGost3410 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001.Id;

		// Token: 0x0400172F RID: 5935
		internal global::System.Collections.IList _certs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001730 RID: 5936
		internal global::System.Collections.IList _crls = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001731 RID: 5937
		internal global::System.Collections.IList _signers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001732 RID: 5938
		internal global::System.Collections.IDictionary _digests = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001733 RID: 5939
		internal bool _useDerForCerts;

		// Token: 0x04001734 RID: 5940
		internal bool _useDerForCrls;

		// Token: 0x04001735 RID: 5941
		protected readonly global::Org.BouncyCastle.Security.SecureRandom rand;
	}
}
