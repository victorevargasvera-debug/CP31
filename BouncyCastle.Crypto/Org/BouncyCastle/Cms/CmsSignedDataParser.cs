using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000538 RID: 1336
	public class CmsSignedDataParser : global::Org.BouncyCastle.Cms.CmsContentInfoParser
	{
		// Token: 0x0600338B RID: 13195 RVA: 0x000F5531 File Offset: 0x000F3731
		public CmsSignedDataParser(byte[] sigBlock) : this(new global::System.IO.MemoryStream(sigBlock, false))
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000F5540 File Offset: 0x000F3740
		public CmsSignedDataParser(global::Org.BouncyCastle.Cms.CmsTypedStream signedContent, byte[] sigBlock) : this(signedContent, new global::System.IO.MemoryStream(sigBlock, false))
		{
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000F5550 File Offset: 0x000F3750
		public CmsSignedDataParser(global::System.IO.Stream sigData) : this(null, sigData)
		{
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000F555C File Offset: 0x000F375C
		public CmsSignedDataParser(global::Org.BouncyCastle.Cms.CmsTypedStream signedContent, global::System.IO.Stream sigData) : base(sigData)
		{
			try
			{
				this._signedContent = signedContent;
				this._signedData = global::Org.BouncyCastle.Asn1.Cms.SignedDataParser.GetInstance(this.contentInfo.GetContent(16));
				this._digests = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
				this._digestOids = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				global::Org.BouncyCastle.Asn1.Asn1SetParser digAlgs = this._signedData.GetDigestAlgorithms();
				global::Org.BouncyCastle.Asn1.IAsn1Convertible o;
				while ((o = digAlgs.ReadObject()) != null)
				{
					global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier id = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(o.ToAsn1Object());
					try
					{
						string digestOid = id.Algorithm.Id;
						string digestName = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.GetDigestAlgName(digestOid);
						if (!this._digests.Contains(digestName))
						{
							this._digests[digestName] = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.GetDigestInstance(digestName);
							this._digestOids.Add(digestOid);
						}
					}
					catch (global::Org.BouncyCastle.Security.SecurityUtilityException)
					{
					}
				}
				global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser cont = this._signedData.GetEncapContentInfo();
				global::Org.BouncyCastle.Asn1.Asn1OctetStringParser octs = (global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)cont.GetContent(4);
				if (octs != null)
				{
					global::Org.BouncyCastle.Cms.CmsTypedStream ctStr = new global::Org.BouncyCastle.Cms.CmsTypedStream(cont.ContentType.Id, octs.GetOctetStream());
					if (this._signedContent == null)
					{
						this._signedContent = ctStr;
					}
					else
					{
						ctStr.Drain();
					}
				}
				this._signedContentType = ((this._signedContent == null) ? cont.ContentType : new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this._signedContent.ContentType));
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("io exception: " + e.Message, e);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x000F56E4 File Offset: 0x000F38E4
		public int Version
		{
			get
			{
				return this._signedData.Version.IntValueExact;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000F56F6 File Offset: 0x000F38F6
		public global::Org.BouncyCastle.Utilities.Collections.ISet DigestOids
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet(this._digestOids);
			}
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000F5704 File Offset: 0x000F3904
		public global::Org.BouncyCastle.Cms.SignerInformationStore GetSignerInfos()
		{
			if (this._signerInfoStore == null)
			{
				this.PopulateCertCrlSets();
				global::System.Collections.IList signerInfos = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::System.Collections.IDictionary hashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
				foreach (object digestKey in this._digests.Keys)
				{
					hashes[digestKey] = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal((global::Org.BouncyCastle.Crypto.IDigest)this._digests[digestKey]);
				}
				try
				{
					global::Org.BouncyCastle.Asn1.Asn1SetParser s = this._signedData.GetSignerInfos();
					global::Org.BouncyCastle.Asn1.IAsn1Convertible o;
					while ((o = s.ReadObject()) != null)
					{
						global::Org.BouncyCastle.Asn1.Cms.SignerInfo info = global::Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(o.ToAsn1Object());
						string digestName = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.GetDigestAlgName(info.DigestAlgorithm.Algorithm.Id);
						byte[] hash = (byte[])hashes[digestName];
						signerInfos.Add(new global::Org.BouncyCastle.Cms.SignerInformation(info, this._signedContentType, null, new global::Org.BouncyCastle.Cms.BaseDigestCalculator(hash)));
					}
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("io exception: " + e.Message, e);
				}
				this._signerInfoStore = new global::Org.BouncyCastle.Cms.SignerInformationStore(signerInfos);
			}
			return this._signerInfoStore;
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x000F5840 File Offset: 0x000F3A40
		public global::Org.BouncyCastle.X509.Store.IX509Store GetAttributeCertificates(string type)
		{
			if (this._attributeStore == null)
			{
				this.PopulateCertCrlSets();
				this._attributeStore = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.CreateAttributeStore(type, this._certSet);
			}
			return this._attributeStore;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x000F586D File Offset: 0x000F3A6D
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates(string type)
		{
			if (this._certificateStore == null)
			{
				this.PopulateCertCrlSets();
				this._certificateStore = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.CreateCertificateStore(type, this._certSet);
			}
			return this._certificateStore;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x000F589A File Offset: 0x000F3A9A
		public global::Org.BouncyCastle.X509.Store.IX509Store GetCrls(string type)
		{
			if (this._crlStore == null)
			{
				this.PopulateCertCrlSets();
				this._crlStore = global::Org.BouncyCastle.Cms.CmsSignedDataParser.Helper.CreateCrlStore(type, this._crlSet);
			}
			return this._crlStore;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000F58C8 File Offset: 0x000F3AC8
		private void PopulateCertCrlSets()
		{
			if (this._isCertCrlParsed)
			{
				return;
			}
			this._isCertCrlParsed = true;
			try
			{
				this._certSet = global::Org.BouncyCastle.Cms.CmsSignedDataParser.GetAsn1Set(this._signedData.GetCertificates());
				this._crlSet = global::Org.BouncyCastle.Cms.CmsSignedDataParser.GetAsn1Set(this._signedData.GetCrls());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("problem parsing cert/crl sets", e);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x000F5930 File Offset: 0x000F3B30
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedContentType
		{
			get
			{
				return this._signedContentType;
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000F5938 File Offset: 0x000F3B38
		public global::Org.BouncyCastle.Cms.CmsTypedStream GetSignedContent()
		{
			if (this._signedContent == null)
			{
				return null;
			}
			global::System.IO.Stream digStream = this._signedContent.ContentStream;
			foreach (object obj in this._digests.Values)
			{
				global::Org.BouncyCastle.Crypto.IDigest digest = (global::Org.BouncyCastle.Crypto.IDigest)obj;
				digStream = new global::Org.BouncyCastle.Crypto.IO.DigestStream(digStream, digest, null);
			}
			return new global::Org.BouncyCastle.Cms.CmsTypedStream(this._signedContent.ContentType, digStream);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000F59C0 File Offset: 0x000F3BC0
		public static global::System.IO.Stream ReplaceSigners(global::System.IO.Stream original, global::Org.BouncyCastle.Cms.SignerInformationStore signerInformationStore, global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator cmsSignedDataStreamGenerator = new global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator();
			global::Org.BouncyCastle.Cms.CmsSignedDataParser parser = new global::Org.BouncyCastle.Cms.CmsSignedDataParser(original);
			cmsSignedDataStreamGenerator.AddSigners(signerInformationStore);
			global::Org.BouncyCastle.Cms.CmsTypedStream signedContent = parser.GetSignedContent();
			bool encapsulate = signedContent != null;
			global::System.IO.Stream contentOut = cmsSignedDataStreamGenerator.Open(outStr, parser.SignedContentType.Id, encapsulate);
			if (encapsulate)
			{
				global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(signedContent.ContentStream, contentOut);
			}
			cmsSignedDataStreamGenerator.AddAttributeCertificates(parser.GetAttributeCertificates("Collection"));
			cmsSignedDataStreamGenerator.AddCertificates(parser.GetCertificates("Collection"));
			cmsSignedDataStreamGenerator.AddCrls(parser.GetCrls("Collection"));
			global::Org.BouncyCastle.Utilities.Platform.Dispose(contentOut);
			return outStr;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000F5A48 File Offset: 0x000F3C48
		public static global::System.IO.Stream ReplaceCertificatesAndCrls(global::System.IO.Stream original, global::Org.BouncyCastle.X509.Store.IX509Store x509Certs, global::Org.BouncyCastle.X509.Store.IX509Store x509Crls, global::Org.BouncyCastle.X509.Store.IX509Store x509AttrCerts, global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator gen = new global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator();
			global::Org.BouncyCastle.Cms.CmsSignedDataParser parser = new global::Org.BouncyCastle.Cms.CmsSignedDataParser(original);
			gen.AddDigests(parser.DigestOids);
			global::Org.BouncyCastle.Cms.CmsTypedStream signedContent = parser.GetSignedContent();
			bool encapsulate = signedContent != null;
			global::System.IO.Stream contentOut = gen.Open(outStr, parser.SignedContentType.Id, encapsulate);
			if (encapsulate)
			{
				global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(signedContent.ContentStream, contentOut);
			}
			if (x509AttrCerts != null)
			{
				gen.AddAttributeCertificates(x509AttrCerts);
			}
			if (x509Certs != null)
			{
				gen.AddCertificates(x509Certs);
			}
			if (x509Crls != null)
			{
				gen.AddCrls(x509Crls);
			}
			gen.AddSigners(parser.GetSignerInfos());
			global::Org.BouncyCastle.Utilities.Platform.Dispose(contentOut);
			return outStr;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000F5AD3 File Offset: 0x000F3CD3
		private static global::Org.BouncyCastle.Asn1.Asn1Set GetAsn1Set(global::Org.BouncyCastle.Asn1.Asn1SetParser asn1SetParser)
		{
			if (asn1SetParser != null)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(asn1SetParser.ToAsn1Object());
			}
			return null;
		}

		// Token: 0x040016F8 RID: 5880
		private static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Helper = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance;

		// Token: 0x040016F9 RID: 5881
		private global::Org.BouncyCastle.Asn1.Cms.SignedDataParser _signedData;

		// Token: 0x040016FA RID: 5882
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier _signedContentType;

		// Token: 0x040016FB RID: 5883
		private global::Org.BouncyCastle.Cms.CmsTypedStream _signedContent;

		// Token: 0x040016FC RID: 5884
		private global::System.Collections.IDictionary _digests;

		// Token: 0x040016FD RID: 5885
		private global::Org.BouncyCastle.Utilities.Collections.ISet _digestOids;

		// Token: 0x040016FE RID: 5886
		private global::Org.BouncyCastle.Cms.SignerInformationStore _signerInfoStore;

		// Token: 0x040016FF RID: 5887
		private global::Org.BouncyCastle.Asn1.Asn1Set _certSet;

		// Token: 0x04001700 RID: 5888
		private global::Org.BouncyCastle.Asn1.Asn1Set _crlSet;

		// Token: 0x04001701 RID: 5889
		private bool _isCertCrlParsed;

		// Token: 0x04001702 RID: 5890
		private global::Org.BouncyCastle.X509.Store.IX509Store _attributeStore;

		// Token: 0x04001703 RID: 5891
		private global::Org.BouncyCastle.X509.Store.IX509Store _certificateStore;

		// Token: 0x04001704 RID: 5892
		private global::Org.BouncyCastle.X509.Store.IX509Store _crlStore;
	}
}
