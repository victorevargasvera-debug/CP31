using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp
{
	// Token: 0x02000699 RID: 1689
	public class TimeStampReq : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E1F RID: 15903 RVA: 0x0011B8AB File Offset: 0x00119AAB
		public static global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq)
			{
				return (global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Tsp.TimeStampReq(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x0011B8CC File Offset: 0x00119ACC
		private TimeStampReq(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int nbObjects = seq.Count;
			int seqStart = 0;
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[seqStart++]);
			this.messageImprint = global::Org.BouncyCastle.Asn1.Tsp.MessageImprint.GetInstance(seq[seqStart++]);
			for (int opt = seqStart; opt < nbObjects; opt++)
			{
				if (seq[opt] is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
				{
					this.tsaPolicy = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[opt]);
				}
				else if (seq[opt] is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					this.nonce = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[opt]);
				}
				else if (seq[opt] is global::Org.BouncyCastle.Asn1.DerBoolean)
				{
					this.certReq = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(seq[opt]);
				}
				else if (seq[opt] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[opt];
					if (tagged.TagNo == 0)
					{
						this.extensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(tagged, false);
					}
				}
			}
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x0011B9BC File Offset: 0x00119BBC
		public TimeStampReq(global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint, global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicy, global::Org.BouncyCastle.Asn1.DerInteger nonce, global::Org.BouncyCastle.Asn1.DerBoolean certReq, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			this.messageImprint = messageImprint;
			this.tsaPolicy = tsaPolicy;
			this.nonce = nonce;
			this.certReq = certReq;
			this.extensions = extensions;
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0011B9F5 File Offset: 0x00119BF5
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x0011B9FD File Offset: 0x00119BFD
		public global::Org.BouncyCastle.Asn1.Tsp.MessageImprint MessageImprint
		{
			get
			{
				return this.messageImprint;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x0011BA05 File Offset: 0x00119C05
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ReqPolicy
		{
			get
			{
				return this.tsaPolicy;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x0011BA0D File Offset: 0x00119C0D
		public global::Org.BouncyCastle.Asn1.DerInteger Nonce
		{
			get
			{
				return this.nonce;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x0011BA15 File Offset: 0x00119C15
		public global::Org.BouncyCastle.Asn1.DerBoolean CertReq
		{
			get
			{
				return this.certReq;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003E27 RID: 15911 RVA: 0x0011BA1D File Offset: 0x00119C1D
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x0011BA28 File Offset: 0x00119C28
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.messageImprint
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.tsaPolicy,
				this.nonce
			});
			if (this.certReq != null && this.certReq.IsTrue)
			{
				v.Add(this.certReq);
			}
			v.AddOptionalTagged(false, 0, this.extensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001BDF RID: 7135
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001BE0 RID: 7136
		private readonly global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint;

		// Token: 0x04001BE1 RID: 7137
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicy;

		// Token: 0x04001BE2 RID: 7138
		private readonly global::Org.BouncyCastle.Asn1.DerInteger nonce;

		// Token: 0x04001BE3 RID: 7139
		private readonly global::Org.BouncyCastle.Asn1.DerBoolean certReq;

		// Token: 0x04001BE4 RID: 7140
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
