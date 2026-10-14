using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200051C RID: 1308
	public class CmsAuthenticatedData
	{
		// Token: 0x060032C8 RID: 13000 RVA: 0x000F2BEA File Offset: 0x000F0DEA
		public CmsAuthenticatedData(byte[] authData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(authData))
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000F2BF8 File Offset: 0x000F0DF8
		public CmsAuthenticatedData(global::System.IO.Stream authData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(authData))
		{
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000F2C08 File Offset: 0x000F0E08
		public CmsAuthenticatedData(global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo)
		{
			this.contentInfo = contentInfo;
			global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData authData = global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData.GetInstance(contentInfo.Content);
			global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos = authData.RecipientInfos;
			this.macAlg = authData.MacAlgorithm;
			global::Org.BouncyCastle.Cms.CmsReadable readable = new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(authData.EncapsulatedContentInfo.Content).GetOctets());
			global::Org.BouncyCastle.Cms.CmsSecureReadable secureReadable = new global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.CmsAuthenticatedSecureReadable(this.macAlg, readable);
			this.recipientInfoStore = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.BuildRecipientInformationStore(recipientInfos, secureReadable);
			this.authAttrs = authData.AuthAttrs;
			this.mac = authData.Mac.GetOctets();
			this.unauthAttrs = authData.UnauthAttrs;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000F2C9F File Offset: 0x000F0E9F
		public byte[] GetMac()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mac);
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000F2CAC File Offset: 0x000F0EAC
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MacAlgorithmID
		{
			get
			{
				return this.macAlg;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060032CD RID: 13005 RVA: 0x000F2CB4 File Offset: 0x000F0EB4
		public string MacAlgOid
		{
			get
			{
				return this.macAlg.Algorithm.Id;
			}
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000F2CC6 File Offset: 0x000F0EC6
		public global::Org.BouncyCastle.Cms.RecipientInformationStore GetRecipientInfos()
		{
			return this.recipientInfoStore;
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x000F2CCE File Offset: 0x000F0ECE
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo ContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000F2CD6 File Offset: 0x000F0ED6
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAuthAttrs()
		{
			if (this.authAttrs == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.authAttrs);
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000F2CED File Offset: 0x000F0EED
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetUnauthAttrs()
		{
			if (this.unauthAttrs == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.unauthAttrs);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000F2D04 File Offset: 0x000F0F04
		public byte[] GetEncoded()
		{
			return this.contentInfo.GetEncoded();
		}

		// Token: 0x04001697 RID: 5783
		internal global::Org.BouncyCastle.Cms.RecipientInformationStore recipientInfoStore;

		// Token: 0x04001698 RID: 5784
		internal global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;

		// Token: 0x04001699 RID: 5785
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg;

		// Token: 0x0400169A RID: 5786
		private global::Org.BouncyCastle.Asn1.Asn1Set authAttrs;

		// Token: 0x0400169B RID: 5787
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs;

		// Token: 0x0400169C RID: 5788
		private byte[] mac;
	}
}
