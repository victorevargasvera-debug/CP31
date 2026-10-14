using System;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006EC RID: 1772
	public class ProcurationSyntax : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004045 RID: 16453 RVA: 0x00123854 File Offset: 0x00121A54
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProcurationSyntax GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProcurationSyntax)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProcurationSyntax)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProcurationSyntax((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x001238A4 File Offset: 0x00121AA4
		private ProcurationSyntax(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj);
				switch (o.TagNo)
				{
				case 1:
					this.country = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(o, true).GetString();
					break;
				case 2:
					this.typeOfSubstitution = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(o, true);
					break;
				case 3:
				{
					global::Org.BouncyCastle.Asn1.Asn1Object signingFor = o.GetObject();
					if (signingFor is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
					{
						this.thirdPerson = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(signingFor);
					}
					else
					{
						this.certRef = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(signingFor);
					}
					break;
				}
				default:
					throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
				}
			}
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00123994 File Offset: 0x00121B94
		public ProcurationSyntax(string country, global::Org.BouncyCastle.Asn1.X500.DirectoryString typeOfSubstitution, global::Org.BouncyCastle.Asn1.X509.IssuerSerial certRef)
		{
			this.country = country;
			this.typeOfSubstitution = typeOfSubstitution;
			this.thirdPerson = null;
			this.certRef = certRef;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x001239B8 File Offset: 0x00121BB8
		public ProcurationSyntax(string country, global::Org.BouncyCastle.Asn1.X500.DirectoryString typeOfSubstitution, global::Org.BouncyCastle.Asn1.X509.GeneralName thirdPerson)
		{
			this.country = country;
			this.typeOfSubstitution = typeOfSubstitution;
			this.thirdPerson = thirdPerson;
			this.certRef = null;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06004049 RID: 16457 RVA: 0x001239DC File Offset: 0x00121BDC
		public virtual string Country
		{
			get
			{
				return this.country;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x001239E4 File Offset: 0x00121BE4
		public virtual global::Org.BouncyCastle.Asn1.X500.DirectoryString TypeOfSubstitution
		{
			get
			{
				return this.typeOfSubstitution;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x001239EC File Offset: 0x00121BEC
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName ThirdPerson
		{
			get
			{
				return this.thirdPerson;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x001239F4 File Offset: 0x00121BF4
		public virtual global::Org.BouncyCastle.Asn1.X509.IssuerSerial CertRef
		{
			get
			{
				return this.certRef;
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x001239FC File Offset: 0x00121BFC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.country != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, new global::Org.BouncyCastle.Asn1.DerPrintableString(this.country, true)));
			}
			v.AddOptionalTagged(true, 2, this.typeOfSubstitution);
			if (this.thirdPerson != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 3, this.thirdPerson));
			}
			else
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 3, this.certRef));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001E67 RID: 7783
		private readonly string country;

		// Token: 0x04001E68 RID: 7784
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString typeOfSubstitution;

		// Token: 0x04001E69 RID: 7785
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName thirdPerson;

		// Token: 0x04001E6A RID: 7786
		private readonly global::Org.BouncyCastle.Asn1.X509.IssuerSerial certRef;
	}
}
