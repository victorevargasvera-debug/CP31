using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000640 RID: 1600
	public class AttCertValidityPeriod : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B45 RID: 15173 RVA: 0x00111354 File Offset: 0x0010F554
		public static global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod || obj == null)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001113A1 File Offset: 0x0010F5A1
		public static global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x001113B0 File Offset: 0x0010F5B0
		private AttCertValidityPeriod(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.notBeforeTime = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(seq[0]);
			this.notAfterTime = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(seq[1]);
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x0011140E File Offset: 0x0010F60E
		public AttCertValidityPeriod(global::Org.BouncyCastle.Asn1.DerGeneralizedTime notBeforeTime, global::Org.BouncyCastle.Asn1.DerGeneralizedTime notAfterTime)
		{
			this.notBeforeTime = notBeforeTime;
			this.notAfterTime = notAfterTime;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x00111424 File Offset: 0x0010F624
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime NotBeforeTime
		{
			get
			{
				return this.notBeforeTime;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x0011142C File Offset: 0x0010F62C
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime NotAfterTime
		{
			get
			{
				return this.notAfterTime;
			}
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00111434 File Offset: 0x0010F634
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.notBeforeTime,
				this.notAfterTime
			});
		}

		// Token: 0x04001A26 RID: 6694
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime notBeforeTime;

		// Token: 0x04001A27 RID: 6695
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime notAfterTime;
	}
}
