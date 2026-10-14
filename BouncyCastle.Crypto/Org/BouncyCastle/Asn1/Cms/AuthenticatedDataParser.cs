using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200073F RID: 1855
	public class AuthenticatedDataParser
	{
		// Token: 0x0600427D RID: 17021 RVA: 0x0012B7D8 File Offset: 0x001299D8
		public AuthenticatedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this.seq = seq;
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq.ReadObject();
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x0012B7F8 File Offset: 0x001299F8
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0012B800 File Offset: 0x00129A00
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo GetOriginatorInfo()
		{
			this.originatorInfoCalled = true;
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this.nextObject).TagNo == 0)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)this.nextObject).GetObjectParser(16, false);
				this.nextObject = null;
				return global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance(asn1Convertible.ToAsn1Object());
			}
			return null;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x0012B877 File Offset: 0x00129A77
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetRecipientInfos()
		{
			if (!this.originatorInfoCalled)
			{
				this.GetOriginatorInfo();
			}
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			global::Org.BouncyCastle.Asn1.Asn1SetParser result = (global::Org.BouncyCastle.Asn1.Asn1SetParser)this.nextObject;
			this.nextObject = null;
			return result;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x0012B8B4 File Offset: 0x00129AB4
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetMacAlgorithm()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.nextObject;
				this.nextObject = null;
				return global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(asn1Convertible.ToAsn1Object());
			}
			return null;
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x0012B900 File Offset: 0x00129B00
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetDigestAlgorithm()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)
			{
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier instance = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.nextObject.ToAsn1Object(), false);
				this.nextObject = null;
				return instance;
			}
			return null;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x0012B952 File Offset: 0x00129B52
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser GetEnapsulatedContentInfo()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1SequenceParser asn1SequenceParser = (global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.nextObject;
				this.nextObject = null;
				return new global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser(asn1SequenceParser);
			}
			return null;
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x0012B990 File Offset: 0x00129B90
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetAuthAttrs()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject is global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
				this.nextObject = null;
				return (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)asn1Convertible).GetObjectParser(17, false);
			}
			return null;
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x0012B9E4 File Offset: 0x00129BE4
		public global::Org.BouncyCastle.Asn1.Asn1OctetString GetMac()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
			this.nextObject = null;
			return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(asn1Convertible.ToAsn1Object());
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0012BA18 File Offset: 0x00129C18
		public global::Org.BouncyCastle.Asn1.Asn1SetParser GetUnauthAttrs()
		{
			if (this.nextObject == null)
			{
				this.nextObject = this.seq.ReadObject();
			}
			if (this.nextObject != null)
			{
				global::Org.BouncyCastle.Asn1.IAsn1Convertible asn1Convertible = this.nextObject;
				this.nextObject = null;
				return (global::Org.BouncyCastle.Asn1.Asn1SetParser)((global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)asn1Convertible).GetObjectParser(17, false);
			}
			return null;
		}

		// Token: 0x04001FFE RID: 8190
		private global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq;

		// Token: 0x04001FFF RID: 8191
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002000 RID: 8192
		private global::Org.BouncyCastle.Asn1.IAsn1Convertible nextObject;

		// Token: 0x04002001 RID: 8193
		private bool originatorInfoCalled;
	}
}
