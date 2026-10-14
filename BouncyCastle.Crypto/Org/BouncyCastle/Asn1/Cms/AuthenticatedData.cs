using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200073E RID: 1854
	public class AuthenticatedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600426E RID: 17006 RVA: 0x0012B434 File Offset: 0x00129634
		public AuthenticatedData(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo, global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm, global::Org.BouncyCastle.Asn1.Cms.ContentInfo encapsulatedContent, global::Org.BouncyCastle.Asn1.Asn1Set authAttrs, global::Org.BouncyCastle.Asn1.Asn1OctetString mac, global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs)
		{
			if ((digestAlgorithm != null || authAttrs != null) && (digestAlgorithm == null || authAttrs == null))
			{
				throw new global::System.ArgumentException("digestAlgorithm and authAttrs must be set together");
			}
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData.CalculateVersion(originatorInfo));
			this.originatorInfo = originatorInfo;
			this.macAlgorithm = macAlgorithm;
			this.digestAlgorithm = digestAlgorithm;
			this.recipientInfos = recipientInfos;
			this.encapsulatedContentInfo = encapsulatedContent;
			this.authAttrs = authAttrs;
			this.mac = mac;
			this.unauthAttrs = unauthAttrs;
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x0012B4B0 File Offset: 0x001296B0
		private AuthenticatedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[index++];
			global::Org.BouncyCastle.Asn1.Asn1Encodable tmp = seq[index++];
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.originatorInfo = global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++];
			}
			this.recipientInfos = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tmp);
			this.macAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[index++]);
			tmp = seq[index++];
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.digestAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++];
			}
			this.encapsulatedContentInfo = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(tmp);
			tmp = seq[index++];
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.authAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++];
			}
			this.mac = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tmp);
			if (seq.Count > index)
			{
				this.unauthAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index], false);
			}
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x0012B5CC File Offset: 0x001297CC
		public static global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0012B5DA File Offset: 0x001297DA
		public static global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid AuthenticatedData: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x0012B617 File Offset: 0x00129817
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x0012B61F File Offset: 0x0012981F
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo
		{
			get
			{
				return this.originatorInfo;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x0012B627 File Offset: 0x00129827
		public global::Org.BouncyCastle.Asn1.Asn1Set RecipientInfos
		{
			get
			{
				return this.recipientInfos;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x0012B62F File Offset: 0x0012982F
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MacAlgorithm
		{
			get
			{
				return this.macAlgorithm;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0012B637 File Offset: 0x00129837
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digestAlgorithm;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x0012B63F File Offset: 0x0012983F
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo EncapsulatedContentInfo
		{
			get
			{
				return this.encapsulatedContentInfo;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x0012B647 File Offset: 0x00129847
		public global::Org.BouncyCastle.Asn1.Asn1Set AuthAttrs
		{
			get
			{
				return this.authAttrs;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x0012B64F File Offset: 0x0012984F
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Mac
		{
			get
			{
				return this.mac;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600427A RID: 17018 RVA: 0x0012B657 File Offset: 0x00129857
		public global::Org.BouncyCastle.Asn1.Asn1Set UnauthAttrs
		{
			get
			{
				return this.unauthAttrs;
			}
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0012B660 File Offset: 0x00129860
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version
			});
			v.AddOptionalTagged(false, 0, this.originatorInfo);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.recipientInfos,
				this.macAlgorithm
			});
			v.AddOptionalTagged(false, 1, this.digestAlgorithm);
			v.Add(this.encapsulatedContentInfo);
			v.AddOptionalTagged(false, 2, this.authAttrs);
			v.Add(this.mac);
			v.AddOptionalTagged(false, 3, this.unauthAttrs);
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x0012B6F8 File Offset: 0x001298F8
		public static int CalculateVersion(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo origInfo)
		{
			if (origInfo == null)
			{
				return 0;
			}
			int ver = 0;
			foreach (object obj in origInfo.Certificates)
			{
				if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tag = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
					if (tag.TagNo == 2)
					{
						ver = 1;
					}
					else if (tag.TagNo == 3)
					{
						ver = 3;
						break;
					}
				}
			}
			foreach (object obj2 in origInfo.Crls)
			{
				if (obj2 is global::Org.BouncyCastle.Asn1.Asn1TaggedObject && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj2).TagNo == 1)
				{
					ver = 3;
					break;
				}
			}
			return ver;
		}

		// Token: 0x04001FF5 RID: 8181
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001FF6 RID: 8182
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo;

		// Token: 0x04001FF7 RID: 8183
		private global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos;

		// Token: 0x04001FF8 RID: 8184
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgorithm;

		// Token: 0x04001FF9 RID: 8185
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm;

		// Token: 0x04001FFA RID: 8186
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfo encapsulatedContentInfo;

		// Token: 0x04001FFB RID: 8187
		private global::Org.BouncyCastle.Asn1.Asn1Set authAttrs;

		// Token: 0x04001FFC RID: 8188
		private global::Org.BouncyCastle.Asn1.Asn1OctetString mac;

		// Token: 0x04001FFD RID: 8189
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs;
	}
}
