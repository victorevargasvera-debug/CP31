using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D4 RID: 1748
	public class SingleResponse : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FC8 RID: 16328 RVA: 0x001211C3 File Offset: 0x0011F3C3
		public SingleResponse(global::Org.BouncyCastle.Asn1.Ocsp.CertID certID, global::Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus, global::Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate, global::Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate, global::Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions)
		{
			this.certID = certID;
			this.certStatus = certStatus;
			this.thisUpdate = thisUpdate;
			this.nextUpdate = nextUpdate;
			this.singleExtensions = singleExtensions;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x001211F0 File Offset: 0x0011F3F0
		public SingleResponse(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certID = global::Org.BouncyCastle.Asn1.Ocsp.CertID.GetInstance(seq[0]);
			this.certStatus = global::Org.BouncyCastle.Asn1.Ocsp.CertStatus.GetInstance(seq[1]);
			this.thisUpdate = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[2];
			if (seq.Count > 4)
			{
				this.nextUpdate = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[3], true);
				this.singleExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[4], true);
				return;
			}
			if (seq.Count > 3)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[3];
				if (o.TagNo == 0)
				{
					this.nextUpdate = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(o, true);
					return;
				}
				this.singleExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(o, true);
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x001212AC File Offset: 0x0011F4AC
		public static global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x001212BC File Offset: 0x0011F4BC
		public static global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x00121309 File Offset: 0x0011F509
		public global::Org.BouncyCastle.Asn1.Ocsp.CertID CertId
		{
			get
			{
				return this.certID;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x00121311 File Offset: 0x0011F511
		public global::Org.BouncyCastle.Asn1.Ocsp.CertStatus CertStatus
		{
			get
			{
				return this.certStatus;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x00121319 File Offset: 0x0011F519
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime ThisUpdate
		{
			get
			{
				return this.thisUpdate;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x00121321 File Offset: 0x0011F521
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime NextUpdate
		{
			get
			{
				return this.nextUpdate;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x00121329 File Offset: 0x0011F529
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions SingleExtensions
		{
			get
			{
				return this.singleExtensions;
			}
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00121334 File Offset: 0x0011F534
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certID,
				this.certStatus,
				this.thisUpdate
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.nextUpdate);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.singleExtensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D88 RID: 7560
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.CertID certID;

		// Token: 0x04001D89 RID: 7561
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus;

		// Token: 0x04001D8A RID: 7562
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate;

		// Token: 0x04001D8B RID: 7563
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate;

		// Token: 0x04001D8C RID: 7564
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions singleExtensions;
	}
}
