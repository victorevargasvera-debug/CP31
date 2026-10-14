using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200051E RID: 1310
	public class CmsAuthenticatedDataParser : global::Org.BouncyCastle.Cms.CmsContentInfoParser
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x000F2F24 File Offset: 0x000F1124
		public CmsAuthenticatedDataParser(byte[] envelopedData) : this(new global::System.IO.MemoryStream(envelopedData, false))
		{
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000F2F34 File Offset: 0x000F1134
		public CmsAuthenticatedDataParser(global::System.IO.Stream envelopedData) : base(envelopedData)
		{
			this.authAttrNotRead = true;
			this.authData = new global::Org.BouncyCastle.Asn1.Cms.AuthenticatedDataParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.contentInfo.GetContent(16));
			global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(this.authData.GetRecipientInfos().ToAsn1Object());
			this.macAlg = this.authData.GetMacAlgorithm();
			global::Org.BouncyCastle.Cms.CmsReadable readable = new global::Org.BouncyCastle.Cms.CmsProcessableInputStream(((global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)this.authData.GetEnapsulatedContentInfo().GetContent(4)).GetOctetStream());
			global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable = new global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.CmsAuthenticatedSecureReadable(this.macAlg, readable);
			this._recipientInfoStore = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x000F2FCE File Offset: 0x000F11CE
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MacAlgorithmID
		{
			get
			{
				return this.macAlg;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x000F2FD6 File Offset: 0x000F11D6
		public string MacAlgOid
		{
			get
			{
				return this.macAlg.Algorithm.Id;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x000F2FE8 File Offset: 0x000F11E8
		public global::Org.BouncyCastle.Asn1.Asn1Object MacAlgParams
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = this.macAlg.Parameters;
				if (ae != null)
				{
					return ae.ToAsn1Object();
				}
				return null;
			}
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000F300C File Offset: 0x000F120C
		public global::Org.BouncyCastle.Cms.RecipientInformationStore GetRecipientInfos()
		{
			return this._recipientInfoStore;
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x000F3014 File Offset: 0x000F1214
		public byte[] GetMac()
		{
			if (this.mac == null)
			{
				this.GetAuthAttrs();
				this.mac = this.authData.GetMac().GetOctets();
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mac);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x000F3048 File Offset: 0x000F1248
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAuthAttrs()
		{
			if (this.authAttrs == null && this.authAttrNotRead)
			{
				global::Org.BouncyCastle.Asn1.Asn1SetParser s = this.authData.GetAuthAttrs();
				this.authAttrNotRead = false;
				if (s != null)
				{
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					global::Org.BouncyCastle.Asn1.IAsn1Convertible o;
					while ((o = s.ReadObject()) != null)
					{
						global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)o;
						v.Add(seq.ToAsn1Object());
					}
					this.authAttrs = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(new global::Org.BouncyCastle.Asn1.DerSet(v));
				}
			}
			return this.authAttrs;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x000F30B8 File Offset: 0x000F12B8
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnauthAttrs()
		{
			if (this.unauthAttrs == null && this.unauthAttrNotRead)
			{
				global::Org.BouncyCastle.Asn1.Asn1SetParser s = this.authData.GetUnauthAttrs();
				this.unauthAttrNotRead = false;
				if (s != null)
				{
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					global::Org.BouncyCastle.Asn1.IAsn1Convertible o;
					while ((o = s.ReadObject()) != null)
					{
						global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)o;
						v.Add(seq.ToAsn1Object());
					}
					this.unauthAttrs = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(new global::Org.BouncyCastle.Asn1.DerSet(v));
				}
			}
			return this.unauthAttrs;
		}

		// Token: 0x0400169D RID: 5789
		internal global::Org.BouncyCastle.Cms.RecipientInformationStore _recipientInfoStore;

		// Token: 0x0400169E RID: 5790
		internal global::Org.BouncyCastle.Asn1.Cms.AuthenticatedDataParser authData;

		// Token: 0x0400169F RID: 5791
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg;

		// Token: 0x040016A0 RID: 5792
		private byte[] mac;

		// Token: 0x040016A1 RID: 5793
		private global::Org.BouncyCastle.Asn1.Cms.AttributeTable authAttrs;

		// Token: 0x040016A2 RID: 5794
		private global::Org.BouncyCastle.Asn1.Cms.AttributeTable unauthAttrs;

		// Token: 0x040016A3 RID: 5795
		private bool authAttrNotRead;

		// Token: 0x040016A4 RID: 5796
		private bool unauthAttrNotRead;
	}
}
