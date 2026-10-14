using System;
using System.Collections;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AE RID: 1710
	public class DHParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EAB RID: 16043 RVA: 0x0011DBA2 File Offset: 0x0011BDA2
		public DHParameter(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, int l)
		{
			this.p = new global::Org.BouncyCastle.Asn1.DerInteger(p);
			this.g = new global::Org.BouncyCastle.Asn1.DerInteger(g);
			if (l != 0)
			{
				this.l = new global::Org.BouncyCastle.Asn1.DerInteger(l);
			}
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0011DBD4 File Offset: 0x0011BDD4
		public DHParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.p = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			e.MoveNext();
			this.g = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			if (e.MoveNext())
			{
				this.l = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x0011DC37 File Offset: 0x0011BE37
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.PositiveValue;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0011DC44 File Offset: 0x0011BE44
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g.PositiveValue;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x0011DC51 File Offset: 0x0011BE51
		public global::Org.BouncyCastle.Math.BigInteger L
		{
			get
			{
				if (this.l != null)
				{
					return this.l.PositiveValue;
				}
				return null;
			}
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x0011DC68 File Offset: 0x0011BE68
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.p,
				this.g
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.l
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001C70 RID: 7280
		internal global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x04001C71 RID: 7281
		internal global::Org.BouncyCastle.Asn1.DerInteger g;

		// Token: 0x04001C72 RID: 7282
		internal global::Org.BouncyCastle.Asn1.DerInteger l;
	}
}
