using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000756 RID: 1878
	public class OriginatorInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004327 RID: 17191 RVA: 0x0012D522 File Offset: 0x0012B722
		public OriginatorInfo(global::Org.BouncyCastle.Asn1.Asn1Set certs, global::Org.BouncyCastle.Asn1.Asn1Set crls)
		{
			this.certs = certs;
			this.crls = crls;
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0012D538 File Offset: 0x0012B738
		public OriginatorInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			switch (seq.Count)
			{
			case 0:
				return;
			case 1:
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[0];
				int tagNo = o.TagNo;
				if (tagNo == 0)
				{
					this.certs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(o, false);
					return;
				}
				if (tagNo != 1)
				{
					throw new global::System.ArgumentException("Bad tag in OriginatorInfo: " + o.TagNo.ToString());
				}
				this.crls = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(o, false);
				return;
			}
			case 2:
				this.certs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[0], false);
				this.crls = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], false);
				return;
			default:
				throw new global::System.ArgumentException("OriginatorInfo too big");
			}
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x0012D5FC File Offset: 0x0012B7FC
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x0012D60A File Offset: 0x0012B80A
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid OriginatorInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x0012D647 File Offset: 0x0012B847
		public global::Org.BouncyCastle.Asn1.Asn1Set Certificates
		{
			get
			{
				return this.certs;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x0012D64F File Offset: 0x0012B84F
		public global::Org.BouncyCastle.Asn1.Asn1Set Crls
		{
			get
			{
				return this.crls;
			}
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0012D657 File Offset: 0x0012B857
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.certs);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.crls);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002057 RID: 8279
		private global::Org.BouncyCastle.Asn1.Asn1Set certs;

		// Token: 0x04002058 RID: 8280
		private global::Org.BouncyCastle.Asn1.Asn1Set crls;
	}
}
