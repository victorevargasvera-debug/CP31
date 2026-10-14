using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D2 RID: 1746
	public class ServiceLocator : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FB6 RID: 16310 RVA: 0x00120F64 File Offset: 0x0011F164
		public static global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00120F74 File Offset: 0x0011F174
		public static global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ServiceLocator((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00120FC1 File Offset: 0x0011F1C1
		public ServiceLocator(global::Org.BouncyCastle.Asn1.X509.X509Name issuer) : this(issuer, null)
		{
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00120FCB File Offset: 0x0011F1CB
		public ServiceLocator(global::Org.BouncyCastle.Asn1.X509.X509Name issuer, global::Org.BouncyCastle.Asn1.Asn1Object locator)
		{
			if (issuer == null)
			{
				throw new global::System.ArgumentNullException("issuer");
			}
			this.issuer = issuer;
			this.locator = locator;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00120FEF File Offset: 0x0011F1EF
		private ServiceLocator(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.locator = seq[1].ToAsn1Object();
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x00121024 File Offset: 0x0011F224
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x0012102C File Offset: 0x0011F22C
		public global::Org.BouncyCastle.Asn1.Asn1Object Locator
		{
			get
			{
				return this.locator;
			}
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00121034 File Offset: 0x0011F234
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuer
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.locator
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D83 RID: 7555
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001D84 RID: 7556
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object locator;
	}
}
