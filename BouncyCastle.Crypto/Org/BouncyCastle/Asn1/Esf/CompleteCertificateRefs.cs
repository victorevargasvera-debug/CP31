using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000706 RID: 1798
	public class CompleteCertificateRefs : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040EB RID: 16619 RVA: 0x00126374 File Offset: 0x00124574
		public static global::Org.BouncyCastle.Asn1.Esf.CompleteCertificateRefs GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CompleteCertificateRefs)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CompleteCertificateRefs)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CompleteCertificateRefs((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CompleteCertificateRefs' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x001263C4 File Offset: 0x001245C4
		private CompleteCertificateRefs(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Esf.OtherCertID.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
			}
			this.otherCertIDs = seq;
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x00126438 File Offset: 0x00124638
		public CompleteCertificateRefs(params global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] otherCertIDs)
		{
			if (otherCertIDs == null)
			{
				throw new global::System.ArgumentNullException("otherCertIDs");
			}
			this.otherCertIDs = new global::Org.BouncyCastle.Asn1.DerSequence(otherCertIDs);
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x00126468 File Offset: 0x00124668
		public CompleteCertificateRefs(global::System.Collections.IEnumerable otherCertIDs)
		{
			if (otherCertIDs == null)
			{
				throw new global::System.ArgumentNullException("otherCertIDs");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(otherCertIDs, typeof(global::Org.BouncyCastle.Asn1.Esf.OtherCertID)))
			{
				throw new global::System.ArgumentException("Must contain only 'OtherCertID' objects", "otherCertIDs");
			}
			this.otherCertIDs = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(otherCertIDs));
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x001264BC File Offset: 0x001246BC
		public global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] GetOtherCertIDs()
		{
			global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] result = new global::Org.BouncyCastle.Asn1.Esf.OtherCertID[this.otherCertIDs.Count];
			for (int i = 0; i < this.otherCertIDs.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Esf.OtherCertID.GetInstance(this.otherCertIDs[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0012650A File Offset: 0x0012470A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.otherCertIDs;
		}

		// Token: 0x04001F1C RID: 7964
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence otherCertIDs;
	}
}
