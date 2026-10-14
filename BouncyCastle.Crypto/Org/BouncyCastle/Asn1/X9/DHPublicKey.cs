using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200062E RID: 1582
	public class DHPublicKey : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003AC7 RID: 15047 RVA: 0x0010F938 File Offset: 0x0010DB38
		public static global::Org.BouncyCastle.Asn1.X9.DHPublicKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X9.DHPublicKey.GetInstance(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x0010F948 File Offset: 0x0010DB48
		public static global::Org.BouncyCastle.Asn1.X9.DHPublicKey GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X9.DHPublicKey)
			{
				return (global::Org.BouncyCastle.Asn1.X9.DHPublicKey)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return new global::Org.BouncyCastle.Asn1.X9.DHPublicKey((global::Org.BouncyCastle.Asn1.DerInteger)obj);
			}
			throw new global::System.ArgumentException("Invalid DHPublicKey: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0010F995 File Offset: 0x0010DB95
		public DHPublicKey(global::Org.BouncyCastle.Asn1.DerInteger y)
		{
			if (y == null)
			{
				throw new global::System.ArgumentNullException("y");
			}
			this.y = y;
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x0010F9B2 File Offset: 0x0010DBB2
		public global::Org.BouncyCastle.Asn1.DerInteger Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x0010F9BA File Offset: 0x0010DBBA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.y;
		}

		// Token: 0x040019C0 RID: 6592
		private readonly global::Org.BouncyCastle.Asn1.DerInteger y;
	}
}
