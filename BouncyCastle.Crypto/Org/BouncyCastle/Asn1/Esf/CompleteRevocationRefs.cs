using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000707 RID: 1799
	public class CompleteRevocationRefs : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040F1 RID: 16625 RVA: 0x00126514 File Offset: 0x00124714
		public static global::Org.BouncyCastle.Asn1.Esf.CompleteRevocationRefs GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CompleteRevocationRefs)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CompleteRevocationRefs)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CompleteRevocationRefs((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CompleteRevocationRefs' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00126564 File Offset: 0x00124764
		private CompleteRevocationRefs(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
			}
			this.crlOcspRefs = seq;
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x001265D8 File Offset: 0x001247D8
		public CompleteRevocationRefs(params global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef[] crlOcspRefs)
		{
			if (crlOcspRefs == null)
			{
				throw new global::System.ArgumentNullException("crlOcspRefs");
			}
			this.crlOcspRefs = new global::Org.BouncyCastle.Asn1.DerSequence(crlOcspRefs);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00126608 File Offset: 0x00124808
		public CompleteRevocationRefs(global::System.Collections.IEnumerable crlOcspRefs)
		{
			if (crlOcspRefs == null)
			{
				throw new global::System.ArgumentNullException("crlOcspRefs");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(crlOcspRefs, typeof(global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef)))
			{
				throw new global::System.ArgumentException("Must contain only 'CrlOcspRef' objects", "crlOcspRefs");
			}
			this.crlOcspRefs = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(crlOcspRefs));
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x0012665C File Offset: 0x0012485C
		public global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef[] GetCrlOcspRefs()
		{
			global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef[] result = new global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef[this.crlOcspRefs.Count];
			for (int i = 0; i < this.crlOcspRefs.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef.GetInstance(this.crlOcspRefs[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x001266AA File Offset: 0x001248AA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.crlOcspRefs;
		}

		// Token: 0x04001F1D RID: 7965
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence crlOcspRefs;
	}
}
