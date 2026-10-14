using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D1 RID: 1745
	public class RevokedInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FAE RID: 16302 RVA: 0x00120E60 File Offset: 0x0011F060
		public static global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x00120E70 File Offset: 0x0011F070
		public static global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00120EBD File Offset: 0x0011F0BD
		public RevokedInfo(global::Org.BouncyCastle.Asn1.DerGeneralizedTime revocationTime) : this(revocationTime, null)
		{
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00120EC7 File Offset: 0x0011F0C7
		public RevokedInfo(global::Org.BouncyCastle.Asn1.DerGeneralizedTime revocationTime, global::Org.BouncyCastle.Asn1.X509.CrlReason revocationReason)
		{
			if (revocationTime == null)
			{
				throw new global::System.ArgumentNullException("revocationTime");
			}
			this.revocationTime = revocationTime;
			this.revocationReason = revocationReason;
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00120EEB File Offset: 0x0011F0EB
		private RevokedInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.revocationTime = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[0];
			if (seq.Count > 1)
			{
				this.revocationReason = new global::Org.BouncyCastle.Asn1.X509.CrlReason(global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x00120F2B File Offset: 0x0011F12B
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime RevocationTime
		{
			get
			{
				return this.revocationTime;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x00120F33 File Offset: 0x0011F133
		public global::Org.BouncyCastle.Asn1.X509.CrlReason RevocationReason
		{
			get
			{
				return this.revocationReason;
			}
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00120F3B File Offset: 0x0011F13B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.revocationTime
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.revocationReason);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D81 RID: 7553
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime revocationTime;

		// Token: 0x04001D82 RID: 7554
		private readonly global::Org.BouncyCastle.Asn1.X509.CrlReason revocationReason;
	}
}
