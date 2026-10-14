using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200064C RID: 1612
	public class CrlDistPoint : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BB1 RID: 15281 RVA: 0x001123DA File Offset: 0x001105DA
		public static global::Org.BouncyCastle.Asn1.X509.CrlDistPoint GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001123E8 File Offset: 0x001105E8
		public static global::Org.BouncyCastle.Asn1.X509.CrlDistPoint GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.CrlDistPoint)
			{
				return (global::Org.BouncyCastle.Asn1.X509.CrlDistPoint)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.CrlDistPoint(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00112409 File Offset: 0x00110609
		public static global::Org.BouncyCastle.Asn1.X509.CrlDistPoint FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints));
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x0011241B File Offset: 0x0011061B
		private CrlDistPoint(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0011242C File Offset: 0x0011062C
		public CrlDistPoint(global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] points)
		{
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(points);
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00112450 File Offset: 0x00110650
		public global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] GetDistributionPoints()
		{
			global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] dp = new global::Org.BouncyCastle.Asn1.X509.DistributionPoint[this.seq.Count];
			for (int i = 0; i != this.seq.Count; i++)
			{
				dp[i] = global::Org.BouncyCastle.Asn1.X509.DistributionPoint.GetInstance(this.seq[i]);
			}
			return dp;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00112499 File Offset: 0x00110699
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001124A4 File Offset: 0x001106A4
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("CRLDistPoint:");
			buf.Append(sep);
			global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] dp = this.GetDistributionPoints();
			for (int i = 0; i != dp.Length; i++)
			{
				buf.Append("    ");
				buf.Append(dp[i]);
				buf.Append(sep);
			}
			return buf.ToString();
		}

		// Token: 0x04001A43 RID: 6723
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
