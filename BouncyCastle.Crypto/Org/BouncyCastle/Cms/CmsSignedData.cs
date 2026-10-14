using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000536 RID: 1334
	public class CmsSignedData
	{
		// Token: 0x0600335E RID: 13150 RVA: 0x000F4B84 File Offset: 0x000F2D84
		private CmsSignedData(global::Org.BouncyCastle.Cms.CmsSignedData c)
		{
			this.signedData = c.signedData;
			this.contentInfo = c.contentInfo;
			this.signedContent = c.signedContent;
			this.signerInfoStore = c.signerInfoStore;
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000F4BBC File Offset: 0x000F2DBC
		public CmsSignedData(byte[] sigBlock) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(new global::System.IO.MemoryStream(sigBlock, false)))
		{
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000F4BD0 File Offset: 0x000F2DD0
		public CmsSignedData(global::Org.BouncyCastle.Cms.CmsProcessable signedContent, byte[] sigBlock) : this(signedContent, global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(new global::System.IO.MemoryStream(sigBlock, false)))
		{
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000F4BE5 File Offset: 0x000F2DE5
		public CmsSignedData(global::System.Collections.IDictionary hashes, byte[] sigBlock) : this(hashes, global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(sigBlock))
		{
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000F4BF4 File Offset: 0x000F2DF4
		public CmsSignedData(global::Org.BouncyCastle.Cms.CmsProcessable signedContent, global::System.IO.Stream sigData) : this(signedContent, global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(sigData))
		{
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000F4C03 File Offset: 0x000F2E03
		public CmsSignedData(global::System.IO.Stream sigData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(sigData))
		{
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000F4C11 File Offset: 0x000F2E11
		public CmsSignedData(global::Org.BouncyCastle.Cms.CmsProcessable signedContent, global::Org.BouncyCastle.Asn1.Cms.ContentInfo sigData)
		{
			this.signedContent = signedContent;
			this.contentInfo = sigData;
			this.signedData = global::Org.BouncyCastle.Asn1.Cms.SignedData.GetInstance(this.contentInfo.Content);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000F4C3D File Offset: 0x000F2E3D
		public CmsSignedData(global::System.Collections.IDictionary hashes, global::Org.BouncyCastle.Asn1.Cms.ContentInfo sigData)
		{
			this.hashes = hashes;
			this.contentInfo = sigData;
			this.signedData = global::Org.BouncyCastle.Asn1.Cms.SignedData.GetInstance(this.contentInfo.Content);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000F4C6C File Offset: 0x000F2E6C
		public CmsSignedData(global::Org.BouncyCastle.Asn1.Cms.ContentInfo sigData)
		{
			this.contentInfo = sigData;
			this.signedData = global::Org.BouncyCastle.Asn1.Cms.SignedData.GetInstance(this.contentInfo.Content);
			if (this.signedData.EncapContentInfo.Content != null)
			{
				this.signedContent = new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(((global::Org.BouncyCastle.Asn1.Asn1OctetString)this.signedData.EncapContentInfo.Content).GetOctets());
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000F4CD3 File Offset: 0x000F2ED3
		public int Version
		{
			get
			{
				return this.signedData.Version.IntValueExact;
			}
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000F4CE5 File Offset: 0x000F2EE5
		internal global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates()
		{
			return global::Org.BouncyCastle.Cms.CmsSignedData.Helper.GetCertificates(this.signedData.Certificates);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x000F4CFC File Offset: 0x000F2EFC
		public global::Org.BouncyCastle.Cms.SignerInformationStore GetSignerInfos()
		{
			if (this.signerInfoStore == null)
			{
				global::System.Collections.IList signerInfos = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				foreach (object obj in this.signedData.SignerInfos)
				{
					global::Org.BouncyCastle.Asn1.Cms.SignerInfo info = global::Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(obj);
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType = this.signedData.EncapContentInfo.ContentType;
					if (this.hashes == null)
					{
						signerInfos.Add(new global::Org.BouncyCastle.Cms.SignerInformation(info, contentType, this.signedContent, null));
					}
					else
					{
						byte[] hash = (byte[])this.hashes[info.DigestAlgorithm.Algorithm.Id];
						signerInfos.Add(new global::Org.BouncyCastle.Cms.SignerInformation(info, contentType, null, new global::Org.BouncyCastle.Cms.BaseDigestCalculator(hash)));
					}
				}
				this.signerInfoStore = new global::Org.BouncyCastle.Cms.SignerInformationStore(signerInfos);
			}
			return this.signerInfoStore;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000F4DE4 File Offset: 0x000F2FE4
		public global::Org.BouncyCastle.X509.Store.IX509Store GetAttributeCertificates(string type)
		{
			if (this.attrCertStore == null)
			{
				this.attrCertStore = global::Org.BouncyCastle.Cms.CmsSignedData.Helper.CreateAttributeStore(type, this.signedData.Certificates);
			}
			return this.attrCertStore;
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000F4E10 File Offset: 0x000F3010
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(string type)
		{
			if (this.certificateStore == null)
			{
				this.certificateStore = global::Org.BouncyCastle.Cms.CmsSignedData.Helper.CreateCertificateStore(type, this.signedData.Certificates);
			}
			return this.certificateStore;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000F4E3C File Offset: 0x000F303C
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCrls(string type)
		{
			if (this.crlStore == null)
			{
				this.crlStore = global::Org.BouncyCastle.Cms.CmsSignedData.Helper.CreateCrlStore(type, this.signedData.CRLs);
			}
			return this.crlStore;
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x000F4E68 File Offset: 0x000F3068
		[global::System.Obsolete("Use 'SignedContentType' property instead.")]
		public string SignedContentTypeOid
		{
			get
			{
				return this.signedData.EncapContentInfo.ContentType.Id;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x000F4E7F File Offset: 0x000F307F
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedContentType
		{
			get
			{
				return this.signedData.EncapContentInfo.ContentType;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x000F4E91 File Offset: 0x000F3091
		public global::Org.BouncyCastle.Cms.CmsProcessable SignedContent
		{
			get
			{
				return this.signedContent;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x000F4E99 File Offset: 0x000F3099
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo ContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000F4EA1 File Offset: 0x000F30A1
		public byte[] GetEncoded()
		{
			return this.contentInfo.GetEncoded();
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000F4EAE File Offset: 0x000F30AE
		public byte[] GetEncoded(string encoding)
		{
			return this.contentInfo.GetEncoded(encoding);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000F4EBC File Offset: 0x000F30BC
		public static global::Org.BouncyCastle.Cms.CmsSignedData ReplaceSigners(global::Org.BouncyCastle.Cms.CmsSignedData signedData, global::Org.BouncyCastle.Cms.SignerInformationStore signerInformationStore)
		{
			global::Org.BouncyCastle.Cms.CmsSignedData cms = new global::Org.BouncyCastle.Cms.CmsSignedData(signedData);
			cms.signerInfoStore = signerInformationStore;
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector digestAlgs = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in signerInformationStore.GetSigners())
			{
				global::Org.BouncyCastle.Cms.SignerInformation signer = (global::Org.BouncyCastle.Cms.SignerInformation)obj;
				digestAlgs.Add(global::Org.BouncyCastle.Cms.CmsSignedData.Helper.FixAlgID(signer.DigestAlgorithmID));
				vec.Add(signer.ToSignerInfo());
			}
			global::Org.BouncyCastle.Asn1.Asn1Set digests = new global::Org.BouncyCastle.Asn1.DerSet(digestAlgs);
			global::Org.BouncyCastle.Asn1.Asn1Set signers = new global::Org.BouncyCastle.Asn1.DerSet(vec);
			global::Org.BouncyCastle.Asn1.Asn1Sequence sD = (global::Org.BouncyCastle.Asn1.Asn1Sequence)signedData.signedData.ToAsn1Object();
			vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				sD[0],
				digests
			});
			for (int i = 2; i != sD.Count - 1; i++)
			{
				vec.Add(sD[i]);
			}
			vec.Add(signers);
			cms.signedData = global::Org.BouncyCastle.Asn1.Cms.SignedData.GetInstance(new global::Org.BouncyCastle.Asn1.BerSequence(vec));
			cms.contentInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(cms.contentInfo.ContentType, cms.signedData);
			return cms;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000F4FF0 File Offset: 0x000F31F0
		public static global::Org.BouncyCastle.Cms.CmsSignedData ReplaceCertificatesAndCrls(global::Org.BouncyCastle.Cms.CmsSignedData signedData, global::Org.BouncyCastle.X509.Store.IX509Store x509Certs, global::Org.BouncyCastle.X509.Store.IX509Store x509Crls, global::Org.BouncyCastle.X509.Store.IX509Store x509AttrCerts)
		{
			if (x509AttrCerts != null)
			{
				throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("Currently can't replace attribute certificates");
			}
			global::Org.BouncyCastle.Cms.CmsSignedData cms = new global::Org.BouncyCastle.Cms.CmsSignedData(signedData);
			global::Org.BouncyCastle.Asn1.Asn1Set certs = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(global::Org.BouncyCastle.Cms.CmsUtilities.GetCertificatesFromStore(x509Certs));
				if (asn1Set.Count != 0)
				{
					certs = asn1Set;
				}
			}
			catch (global::Org.BouncyCastle.X509.Store.X509StoreException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error getting certificates from store", e);
			}
			global::Org.BouncyCastle.Asn1.Asn1Set crls = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Set asn1Set2 = global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(global::Org.BouncyCastle.Cms.CmsUtilities.GetCrlsFromStore(x509Crls));
				if (asn1Set2.Count != 0)
				{
					crls = asn1Set2;
				}
			}
			catch (global::Org.BouncyCastle.X509.Store.X509StoreException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("error getting CRLs from store", e2);
			}
			global::Org.BouncyCastle.Asn1.Cms.SignedData old = signedData.signedData;
			cms.signedData = new global::Org.BouncyCastle.Asn1.Cms.SignedData(old.DigestAlgorithms, old.EncapContentInfo, certs, crls, old.SignerInfos);
			cms.contentInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(cms.contentInfo.ContentType, cms.signedData);
			return cms;
		}

		// Token: 0x040016ED RID: 5869
		private static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Helper = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance;

		// Token: 0x040016EE RID: 5870
		private readonly global::Org.BouncyCastle.Cms.CmsProcessable signedContent;

		// Token: 0x040016EF RID: 5871
		private global::Org.BouncyCastle.Asn1.Cms.SignedData signedData;

		// Token: 0x040016F0 RID: 5872
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;

		// Token: 0x040016F1 RID: 5873
		private global::Org.BouncyCastle.Cms.SignerInformationStore signerInfoStore;

		// Token: 0x040016F2 RID: 5874
		private global::Org.BouncyCastle.X509.Store.IX509Store attrCertStore;

		// Token: 0x040016F3 RID: 5875
		private global::Org.BouncyCastle.X509.Store.IX509Store certificateStore;

		// Token: 0x040016F4 RID: 5876
		private global::Org.BouncyCastle.X509.Store.IX509Store crlStore;

		// Token: 0x040016F5 RID: 5877
		private global::System.Collections.IDictionary hashes;
	}
}
