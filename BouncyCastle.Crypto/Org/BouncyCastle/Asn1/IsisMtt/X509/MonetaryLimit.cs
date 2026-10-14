using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006EA RID: 1770
	public class MonetaryLimit : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004035 RID: 16437 RVA: 0x001234B0 File Offset: 0x001216B0
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.MonetaryLimit GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.MonetaryLimit)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.MonetaryLimit)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.MonetaryLimit(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x00123500 File Offset: 0x00121700
		private MonetaryLimit(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.currency = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(seq[0]);
			this.amount = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			this.exponent = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00123570 File Offset: 0x00121770
		public MonetaryLimit(string currency, int amount, int exponent)
		{
			this.currency = new global::Org.BouncyCastle.Asn1.DerPrintableString(currency, true);
			this.amount = new global::Org.BouncyCastle.Asn1.DerInteger(amount);
			this.exponent = new global::Org.BouncyCastle.Asn1.DerInteger(exponent);
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x0012359D File Offset: 0x0012179D
		public virtual string Currency
		{
			get
			{
				return this.currency.GetString();
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x001235AA File Offset: 0x001217AA
		public virtual global::Org.BouncyCastle.Math.BigInteger Amount
		{
			get
			{
				return this.amount.Value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x001235B7 File Offset: 0x001217B7
		public virtual global::Org.BouncyCastle.Math.BigInteger Exponent
		{
			get
			{
				return this.exponent.Value;
			}
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x001235C4 File Offset: 0x001217C4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.currency,
				this.amount,
				this.exponent
			});
		}

		// Token: 0x04001E60 RID: 7776
		private readonly global::Org.BouncyCastle.Asn1.DerPrintableString currency;

		// Token: 0x04001E61 RID: 7777
		private readonly global::Org.BouncyCastle.Asn1.DerInteger amount;

		// Token: 0x04001E62 RID: 7778
		private readonly global::Org.BouncyCastle.Asn1.DerInteger exponent;
	}
}
