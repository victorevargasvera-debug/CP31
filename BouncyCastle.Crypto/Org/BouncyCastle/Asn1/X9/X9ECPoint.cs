using System;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000638 RID: 1592
	public class X9ECPoint : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x00110810 File Offset: 0x0010EA10
		public X9ECPoint(global::Org.BouncyCastle.Math.EC.ECPoint p) : this(p, false)
		{
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x0011081A File Offset: 0x0010EA1A
		public X9ECPoint(global::Org.BouncyCastle.Math.EC.ECPoint p, bool compressed)
		{
			this.p = p.Normalize();
			this.encoding = new global::Org.BouncyCastle.Asn1.DerOctetString(p.GetEncoded(compressed));
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00110840 File Offset: 0x0010EA40
		public X9ECPoint(global::Org.BouncyCastle.Math.EC.ECCurve c, byte[] encoding)
		{
			this.c = c;
			this.encoding = new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Utilities.Arrays.Clone(encoding));
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00110860 File Offset: 0x0010EA60
		public X9ECPoint(global::Org.BouncyCastle.Math.EC.ECCurve c, global::Org.BouncyCastle.Asn1.Asn1OctetString s) : this(c, s.GetOctets())
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x0011086F File Offset: 0x0010EA6F
		public byte[] GetPointEncoding()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.encoding.GetOctets());
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x00110881 File Offset: 0x0010EA81
		public global::Org.BouncyCastle.Math.EC.ECPoint Point
		{
			get
			{
				if (this.p == null)
				{
					this.p = this.c.DecodePoint(this.encoding.GetOctets()).Normalize();
				}
				return this.p;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x001108B4 File Offset: 0x0010EAB4
		public bool IsPointCompressed
		{
			get
			{
				byte[] octets = this.encoding.GetOctets();
				return octets != null && octets.Length != 0 && (octets[0] == 2 || octets[0] == 3);
			}
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001108E4 File Offset: 0x0010EAE4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.encoding;
		}

		// Token: 0x040019D6 RID: 6614
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString encoding;

		// Token: 0x040019D7 RID: 6615
		private global::Org.BouncyCastle.Math.EC.ECCurve c;

		// Token: 0x040019D8 RID: 6616
		private global::Org.BouncyCastle.Math.EC.ECPoint p;
	}
}
