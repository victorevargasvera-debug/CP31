using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006E9 RID: 1769
	public class DeclarationOfMajority : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x0600402B RID: 16427 RVA: 0x00123319 File Offset: 0x00121519
		public DeclarationOfMajority(int notYoungerThan)
		{
			this.declaration = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, new global::Org.BouncyCastle.Asn1.DerInteger(notYoungerThan));
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00123334 File Offset: 0x00121534
		public DeclarationOfMajority(bool fullAge, string country)
		{
			if (country.Length > 2)
			{
				throw new global::System.ArgumentException("country can only be 2 characters");
			}
			global::Org.BouncyCastle.Asn1.DerPrintableString countryString = new global::Org.BouncyCastle.Asn1.DerPrintableString(country, true);
			global::Org.BouncyCastle.Asn1.DerSequence seq;
			if (fullAge)
			{
				seq = new global::Org.BouncyCastle.Asn1.DerSequence(countryString);
			}
			else
			{
				seq = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					global::Org.BouncyCastle.Asn1.DerBoolean.False,
					countryString
				});
			}
			this.declaration = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, seq);
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00123395 File Offset: 0x00121595
		public DeclarationOfMajority(global::Org.BouncyCastle.Asn1.DerGeneralizedTime dateOfBirth)
		{
			this.declaration = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, dateOfBirth);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001233AC File Offset: 0x001215AC
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001233FC File Offset: 0x001215FC
		private DeclarationOfMajority(global::Org.BouncyCastle.Asn1.Asn1TaggedObject o)
		{
			if (o.TagNo > 2)
			{
				throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
			}
			this.declaration = o;
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x0012343D File Offset: 0x0012163D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.declaration;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x00123445 File Offset: 0x00121645
		public global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority.Choice Type
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.DeclarationOfMajority.Choice)this.declaration.TagNo;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x00123452 File Offset: 0x00121652
		public virtual int NotYoungerThan
		{
			get
			{
				if (this.declaration.TagNo == 0)
				{
					return global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(this.declaration, false).IntValueExact;
				}
				return -1;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x00123474 File Offset: 0x00121674
		public virtual global::Org.BouncyCastle.Asn1.Asn1Sequence FullAgeAtCountry
		{
			get
			{
				if (this.declaration.TagNo == 1)
				{
					return global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(this.declaration, false);
				}
				return null;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x00123492 File Offset: 0x00121692
		public virtual global::Org.BouncyCastle.Asn1.DerGeneralizedTime DateOfBirth
		{
			get
			{
				if (this.declaration.TagNo == 2)
				{
					return global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(this.declaration, false);
				}
				return null;
			}
		}

		// Token: 0x04001E5F RID: 7775
		private readonly global::Org.BouncyCastle.Asn1.Asn1TaggedObject declaration;

		// Token: 0x02000899 RID: 2201
		public enum Choice
		{
			// Token: 0x0400264B RID: 9803
			NotYoungerThan,
			// Token: 0x0400264C RID: 9804
			FullAgeAtCountry,
			// Token: 0x0400264D RID: 9805
			DateOfBirth
		}
	}
}
