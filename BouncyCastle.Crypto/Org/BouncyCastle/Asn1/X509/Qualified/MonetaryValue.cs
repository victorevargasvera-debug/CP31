using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x0200068A RID: 1674
	public class MonetaryValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DBA RID: 15802 RVA: 0x00119B00 File Offset: 0x00117D00
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.MonetaryValue GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.MonetaryValue)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.MonetaryValue)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.MonetaryValue(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00119B50 File Offset: 0x00117D50
		private MonetaryValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.currency = global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode.GetInstance(seq[0]);
			this.amount = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			this.exponent = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00119BC5 File Offset: 0x00117DC5
		public MonetaryValue(global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode currency, int amount, int exponent)
		{
			this.currency = currency;
			this.amount = new global::Org.BouncyCastle.Asn1.DerInteger(amount);
			this.exponent = new global::Org.BouncyCastle.Asn1.DerInteger(exponent);
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x00119BEC File Offset: 0x00117DEC
		public global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode Currency
		{
			get
			{
				return this.currency;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x00119BF4 File Offset: 0x00117DF4
		public global::Org.BouncyCastle.Math.BigInteger Amount
		{
			get
			{
				return this.amount.Value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x00119C01 File Offset: 0x00117E01
		public global::Org.BouncyCastle.Math.BigInteger Exponent
		{
			get
			{
				return this.exponent.Value;
			}
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00119C0E File Offset: 0x00117E0E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.currency,
				this.amount,
				this.exponent
			});
		}

		// Token: 0x04001B9A RID: 7066
		internal global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode currency;

		// Token: 0x04001B9B RID: 7067
		internal global::Org.BouncyCastle.Asn1.DerInteger amount;

		// Token: 0x04001B9C RID: 7068
		internal global::Org.BouncyCastle.Asn1.DerInteger exponent;
	}
}
