using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000716 RID: 1814
	public class RevocationValues : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004152 RID: 16722 RVA: 0x00127B25 File Offset: 0x00125D25
		public static global::Org.BouncyCastle.Asn1.Esf.RevocationValues GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.RevocationValues)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.RevocationValues)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Esf.RevocationValues(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x00127B44 File Offset: 0x00125D44
		private RevocationValues(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject asn1TaggedObject = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Obj = asn1TaggedObject.GetObject();
				switch (asn1TaggedObject.TagNo)
				{
				case 0:
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence crlValsSeq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Obj;
					foreach (object obj2 in crlValsSeq)
					{
						global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object());
					}
					this.crlVals = crlValsSeq;
					break;
				}
				case 1:
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence ocspValsSeq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)asn1Obj;
					foreach (object obj3 in ocspValsSeq)
					{
						global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj3).ToAsn1Object());
					}
					this.ocspVals = ocspValsSeq;
					break;
				}
				case 2:
					this.otherRevVals = global::Org.BouncyCastle.Asn1.Esf.OtherRevVals.GetInstance(asn1Obj);
					break;
				default:
					throw new global::System.ArgumentException("Illegal tag in RevocationValues", "seq");
				}
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x00127CFC File Offset: 0x00125EFC
		public RevocationValues(global::Org.BouncyCastle.Asn1.X509.CertificateList[] crlVals, global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse[] ocspVals, global::Org.BouncyCastle.Asn1.Esf.OtherRevVals otherRevVals)
		{
			if (crlVals != null)
			{
				this.crlVals = new global::Org.BouncyCastle.Asn1.DerSequence(crlVals);
			}
			if (ocspVals != null)
			{
				this.ocspVals = new global::Org.BouncyCastle.Asn1.DerSequence(ocspVals);
			}
			this.otherRevVals = otherRevVals;
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00127D38 File Offset: 0x00125F38
		public RevocationValues(global::System.Collections.IEnumerable crlVals, global::System.Collections.IEnumerable ocspVals, global::Org.BouncyCastle.Asn1.Esf.OtherRevVals otherRevVals)
		{
			if (crlVals != null)
			{
				if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(crlVals, typeof(global::Org.BouncyCastle.Asn1.X509.CertificateList)))
				{
					throw new global::System.ArgumentException("Must contain only 'CertificateList' objects", "crlVals");
				}
				this.crlVals = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(crlVals));
			}
			if (ocspVals != null)
			{
				if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(ocspVals, typeof(global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse)))
				{
					throw new global::System.ArgumentException("Must contain only 'BasicOcspResponse' objects", "ocspVals");
				}
				this.ocspVals = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(ocspVals));
			}
			this.otherRevVals = otherRevVals;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00127DC0 File Offset: 0x00125FC0
		public global::Org.BouncyCastle.Asn1.X509.CertificateList[] GetCrlVals()
		{
			global::Org.BouncyCastle.Asn1.X509.CertificateList[] result = new global::Org.BouncyCastle.Asn1.X509.CertificateList[this.crlVals.Count];
			for (int i = 0; i < this.crlVals.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(this.crlVals[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00127E10 File Offset: 0x00126010
		public global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse[] GetOcspVals()
		{
			global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse[] result = new global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse[this.ocspVals.Count];
			for (int i = 0; i < this.ocspVals.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse.GetInstance(this.ocspVals[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00127E5E File Offset: 0x0012605E
		public global::Org.BouncyCastle.Asn1.Esf.OtherRevVals OtherRevVals
		{
			get
			{
				return this.otherRevVals;
			}
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00127E68 File Offset: 0x00126068
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptionalTagged(true, 0, this.crlVals);
			v.AddOptionalTagged(true, 1, this.ocspVals);
			if (this.otherRevVals != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, this.otherRevVals.ToAsn1Object()));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F46 RID: 8006
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence crlVals;

		// Token: 0x04001F47 RID: 8007
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence ocspVals;

		// Token: 0x04001F48 RID: 8008
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherRevVals otherRevVals;
	}
}
