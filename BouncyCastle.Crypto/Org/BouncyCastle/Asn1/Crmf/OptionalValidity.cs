using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000731 RID: 1841
	public class OptionalValidity : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004213 RID: 16915 RVA: 0x0012A54C File Offset: 0x0012874C
		private OptionalValidity(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				if (tObj.TagNo == 0)
				{
					this.notBefore = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(tObj, true);
				}
				else
				{
					this.notAfter = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(tObj, true);
				}
			}
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0012A5C4 File Offset: 0x001287C4
		public static global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x0012A5E3 File Offset: 0x001287E3
		public OptionalValidity(global::Org.BouncyCastle.Asn1.X509.Time notBefore, global::Org.BouncyCastle.Asn1.X509.Time notAfter)
		{
			this.notBefore = notBefore;
			this.notAfter = notAfter;
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x0012A5F9 File Offset: 0x001287F9
		public virtual global::Org.BouncyCastle.Asn1.X509.Time NotBefore
		{
			get
			{
				return this.notBefore;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x0012A601 File Offset: 0x00128801
		public virtual global::Org.BouncyCastle.Asn1.X509.Time NotAfter
		{
			get
			{
				return this.notAfter;
			}
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x0012A609 File Offset: 0x00128809
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.notBefore);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.notAfter);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001FD0 RID: 8144
		private readonly global::Org.BouncyCastle.Asn1.X509.Time notBefore;

		// Token: 0x04001FD1 RID: 8145
		private readonly global::Org.BouncyCastle.Asn1.X509.Time notAfter;
	}
}
