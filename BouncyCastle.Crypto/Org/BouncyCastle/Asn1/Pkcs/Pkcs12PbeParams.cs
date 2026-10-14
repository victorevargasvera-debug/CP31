using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B9 RID: 1721
	public class Pkcs12PbeParams : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EF3 RID: 16115 RVA: 0x0011E6EA File Offset: 0x0011C8EA
		public Pkcs12PbeParams(byte[] salt, int iterations)
		{
			this.iv = new global::Org.BouncyCastle.Asn1.DerOctetString(salt);
			this.iterations = new global::Org.BouncyCastle.Asn1.DerInteger(iterations);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0011E70C File Offset: 0x0011C90C
		private Pkcs12PbeParams(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.iv = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			this.iterations = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0011E75C File Offset: 0x0011C95C
		public static global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x0011E79B File Offset: 0x0011C99B
		public global::Org.BouncyCastle.Math.BigInteger Iterations
		{
			get
			{
				return this.iterations.Value;
			}
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0011E7A8 File Offset: 0x0011C9A8
		public byte[] GetIV()
		{
			return this.iv.GetOctets();
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0011E7B5 File Offset: 0x0011C9B5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.iv,
				this.iterations
			});
		}

		// Token: 0x04001C86 RID: 7302
		private readonly global::Org.BouncyCastle.Asn1.DerInteger iterations;

		// Token: 0x04001C87 RID: 7303
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString iv;
	}
}
