using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200063F RID: 1599
	public class AttCertIssuer : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003B3F RID: 15167 RVA: 0x00111268 File Offset: 0x0010F468
		public static global::Org.BouncyCastle.Asn1.X509.AttCertIssuer GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AttCertIssuer)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AttCertIssuer)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.V2Form)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttCertIssuer(global::Org.BouncyCastle.Asn1.X509.V2Form.GetInstance(obj));
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.GeneralNames)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttCertIssuer((global::Org.BouncyCastle.Asn1.X509.GeneralNames)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttCertIssuer(global::Org.BouncyCastle.Asn1.X509.V2Form.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj, false));
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttCertIssuer(global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x001112F4 File Offset: 0x0010F4F4
		public static global::Org.BouncyCastle.Asn1.X509.AttCertIssuer GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X509.AttCertIssuer.GetInstance(obj.GetObject());
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00111301 File Offset: 0x0010F501
		public AttCertIssuer(global::Org.BouncyCastle.Asn1.X509.GeneralNames names)
		{
			this.obj = names;
			this.choiceObj = this.obj.ToAsn1Object();
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00111321 File Offset: 0x0010F521
		public AttCertIssuer(global::Org.BouncyCastle.Asn1.X509.V2Form v2Form)
		{
			this.obj = v2Form;
			this.choiceObj = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.obj);
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x00111343 File Offset: 0x0010F543
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Issuer
		{
			get
			{
				return this.obj;
			}
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x0011134B File Offset: 0x0010F54B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.choiceObj;
		}

		// Token: 0x04001A24 RID: 6692
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Encodable obj;

		// Token: 0x04001A25 RID: 6693
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Object choiceObj;
	}
}
