using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000702 RID: 1794
	public class CertificateValues : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040D5 RID: 16597 RVA: 0x00125ED8 File Offset: 0x001240D8
		public static global::Org.BouncyCastle.Asn1.Esf.CertificateValues GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CertificateValues)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CertificateValues)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CertificateValues((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CertificateValues' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00125F28 File Offset: 0x00124128
		private CertificateValues(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
			}
			this.certificates = seq;
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00125F9C File Offset: 0x0012419C
		public CertificateValues(params global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certificates)
		{
			if (certificates == null)
			{
				throw new global::System.ArgumentNullException("certificates");
			}
			this.certificates = new global::Org.BouncyCastle.Asn1.DerSequence(certificates);
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00125FCC File Offset: 0x001241CC
		public CertificateValues(global::System.Collections.IEnumerable certificates)
		{
			if (certificates == null)
			{
				throw new global::System.ArgumentNullException("certificates");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(certificates, typeof(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure)))
			{
				throw new global::System.ArgumentException("Must contain only 'X509CertificateStructure' objects", "certificates");
			}
			this.certificates = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(certificates));
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00126020 File Offset: 0x00124220
		public global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] GetCertificates()
		{
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] result = new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[this.certificates.Count];
			for (int i = 0; i < this.certificates.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(this.certificates[i]);
			}
			return result;
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00126069 File Offset: 0x00124269
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.certificates;
		}

		// Token: 0x04001F11 RID: 7953
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence certificates;
	}
}
