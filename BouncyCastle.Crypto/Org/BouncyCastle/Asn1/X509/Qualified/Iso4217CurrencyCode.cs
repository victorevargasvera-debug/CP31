using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x02000689 RID: 1673
	public class Iso4217CurrencyCode : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003DB3 RID: 15795 RVA: 0x001199A0 File Offset: 0x00117BA0
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj).IntValueExact);
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerPrintableString)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.Iso4217CurrencyCode(global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(obj).GetString());
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00119A0C File Offset: 0x00117C0C
		public Iso4217CurrencyCode(int numeric)
		{
			if (numeric > 999 || numeric < 1)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"wrong size in numeric code : not in (",
					1.ToString(),
					"..",
					999.ToString(),
					")"
				}));
			}
			this.obj = new global::Org.BouncyCastle.Asn1.DerInteger(numeric);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00119A7C File Offset: 0x00117C7C
		public Iso4217CurrencyCode(string alphabetic)
		{
			if (alphabetic.Length > 3)
			{
				throw new global::System.ArgumentException("wrong size in alphabetic code : max size is " + 3.ToString());
			}
			this.obj = new global::Org.BouncyCastle.Asn1.DerPrintableString(alphabetic);
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00119ABD File Offset: 0x00117CBD
		public bool IsAlphabetic
		{
			get
			{
				return this.obj is global::Org.BouncyCastle.Asn1.DerPrintableString;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x00119ACD File Offset: 0x00117CCD
		public string Alphabetic
		{
			get
			{
				return ((global::Org.BouncyCastle.Asn1.DerPrintableString)this.obj).GetString();
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00119ADF File Offset: 0x00117CDF
		public int Numeric
		{
			get
			{
				return ((global::Org.BouncyCastle.Asn1.DerInteger)this.obj).IntValueExact;
			}
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00119AF1 File Offset: 0x00117CF1
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.obj.ToAsn1Object();
		}

		// Token: 0x04001B96 RID: 7062
		internal const int AlphabeticMaxSize = 3;

		// Token: 0x04001B97 RID: 7063
		internal const int NumericMinSize = 1;

		// Token: 0x04001B98 RID: 7064
		internal const int NumericMaxSize = 999;

		// Token: 0x04001B99 RID: 7065
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable obj;
	}
}
