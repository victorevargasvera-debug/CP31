using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000653 RID: 1619
	public class DsaParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BE1 RID: 15329 RVA: 0x00112C00 File Offset: 0x00110E00
		public static global::Org.BouncyCastle.Asn1.X509.DsaParameter GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.DsaParameter.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00112C0E File Offset: 0x00110E0E
		public static global::Org.BouncyCastle.Asn1.X509.DsaParameter GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.DsaParameter)
			{
				return (global::Org.BouncyCastle.Asn1.X509.DsaParameter)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.DsaParameter((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid DsaParameter: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00112C4B File Offset: 0x00110E4B
		public DsaParameter(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g)
		{
			this.p = new global::Org.BouncyCastle.Asn1.DerInteger(p);
			this.q = new global::Org.BouncyCastle.Asn1.DerInteger(q);
			this.g = new global::Org.BouncyCastle.Asn1.DerInteger(g);
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x00112C78 File Offset: 0x00110E78
		private DsaParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.q = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			this.g = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x00112CED File Offset: 0x00110EED
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.PositiveValue;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00112CFA File Offset: 0x00110EFA
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q.PositiveValue;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x00112D07 File Offset: 0x00110F07
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g.PositiveValue;
			}
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00112D14 File Offset: 0x00110F14
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.p,
				this.q,
				this.g
			});
		}

		// Token: 0x04001A5F RID: 6751
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x04001A60 RID: 6752
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger q;

		// Token: 0x04001A61 RID: 6753
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger g;
	}
}
