using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.SigI
{
	// Token: 0x02000685 RID: 1669
	public class PersonalData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003D9C RID: 15772 RVA: 0x00119420 File Offset: 0x00117620
		public static global::Org.BouncyCastle.Asn1.X509.SigI.PersonalData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.SigI.PersonalData)
			{
				return (global::Org.BouncyCastle.Asn1.X509.SigI.PersonalData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SigI.PersonalData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00119470 File Offset: 0x00117670
		private PersonalData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.nameOrPseudonym = global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym.GetInstance(e.Current);
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj);
				switch (o.TagNo)
				{
				case 0:
					this.nameDistinguisher = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, false).Value;
					break;
				case 1:
					this.dateOfBirth = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(o, false);
					break;
				case 2:
					this.placeOfBirth = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o, true);
					break;
				case 3:
					this.gender = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(o, false).GetString();
					break;
				case 4:
					this.postalAddress = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o, true);
					break;
				default:
					throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
				}
			}
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x0011957B File Offset: 0x0011777B
		public PersonalData(global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym nameOrPseudonym, global::Org.BouncyCastle.Math.BigInteger nameDistinguisher, global::Org.BouncyCastle.Asn1.DerGeneralizedTime dateOfBirth, global::Org.BouncyCastle.Asn1.X500.DirectoryString placeOfBirth, string gender, global::Org.BouncyCastle.Asn1.X500.DirectoryString postalAddress)
		{
			this.nameOrPseudonym = nameOrPseudonym;
			this.dateOfBirth = dateOfBirth;
			this.gender = gender;
			this.nameDistinguisher = nameDistinguisher;
			this.postalAddress = postalAddress;
			this.placeOfBirth = placeOfBirth;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x001195B0 File Offset: 0x001177B0
		public global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym NameOrPseudonym
		{
			get
			{
				return this.nameOrPseudonym;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x001195B8 File Offset: 0x001177B8
		public global::Org.BouncyCastle.Math.BigInteger NameDistinguisher
		{
			get
			{
				return this.nameDistinguisher;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x001195C0 File Offset: 0x001177C0
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime DateOfBirth
		{
			get
			{
				return this.dateOfBirth;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x001195C8 File Offset: 0x001177C8
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString PlaceOfBirth
		{
			get
			{
				return this.placeOfBirth;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x001195D0 File Offset: 0x001177D0
		public string Gender
		{
			get
			{
				return this.gender;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x001195D8 File Offset: 0x001177D8
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString PostalAddress
		{
			get
			{
				return this.postalAddress;
			}
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x001195E0 File Offset: 0x001177E0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.nameOrPseudonym
			});
			if (this.nameDistinguisher != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, new global::Org.BouncyCastle.Asn1.DerInteger(this.nameDistinguisher)));
			}
			v.AddOptionalTagged(false, 1, this.dateOfBirth);
			v.AddOptionalTagged(true, 2, this.placeOfBirth);
			if (this.gender != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 3, new global::Org.BouncyCastle.Asn1.DerPrintableString(this.gender, true)));
			}
			v.AddOptionalTagged(true, 4, this.postalAddress);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001B80 RID: 7040
		private readonly global::Org.BouncyCastle.Asn1.X509.SigI.NameOrPseudonym nameOrPseudonym;

		// Token: 0x04001B81 RID: 7041
		private readonly global::Org.BouncyCastle.Math.BigInteger nameDistinguisher;

		// Token: 0x04001B82 RID: 7042
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime dateOfBirth;

		// Token: 0x04001B83 RID: 7043
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString placeOfBirth;

		// Token: 0x04001B84 RID: 7044
		private readonly string gender;

		// Token: 0x04001B85 RID: 7045
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString postalAddress;
	}
}
