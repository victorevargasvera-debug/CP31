using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000726 RID: 1830
	public class CertId : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041BD RID: 16829 RVA: 0x00129920 File Offset: 0x00127B20
		private CertId(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.issuer = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[0]);
			this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0012994C File Offset: 0x00127B4C
		public static global::Org.BouncyCastle.Asn1.Crmf.CertId GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.CertId)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.CertId)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.CertId((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0012998B File Offset: 0x00127B8B
		public static global::Org.BouncyCastle.Asn1.Crmf.CertId GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Crmf.CertId.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x00129999 File Offset: 0x00127B99
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x001299A1 File Offset: 0x00127BA1
		public virtual global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x001299A9 File Offset: 0x00127BA9
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuer,
				this.serialNumber
			});
		}

		// Token: 0x04001F9F RID: 8095
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName issuer;

		// Token: 0x04001FA0 RID: 8096
		private readonly global::Org.BouncyCastle.Asn1.DerInteger serialNumber;
	}
}
