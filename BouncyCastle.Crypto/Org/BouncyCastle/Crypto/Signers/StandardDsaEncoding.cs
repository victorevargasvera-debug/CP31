using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AF RID: 943
	public class StandardDsaEncoding : global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding
	{
		// Token: 0x0600266E RID: 9838 RVA: 0x000A786C File Offset: 0x000A5A6C
		public virtual global::Org.BouncyCastle.Math.BigInteger[] Decode(global::Org.BouncyCastle.Math.BigInteger n, byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(encoding);
			if (seq.Count == 2)
			{
				global::Org.BouncyCastle.Math.BigInteger r = this.DecodeValue(n, seq, 0);
				global::Org.BouncyCastle.Math.BigInteger s = this.DecodeValue(n, seq, 1);
				if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.Encode(n, r, s), encoding))
				{
					return new global::Org.BouncyCastle.Math.BigInteger[]
					{
						r,
						s
					};
				}
			}
			throw new global::System.ArgumentException("Malformed signature", "encoding");
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000A78D1 File Offset: 0x000A5AD1
		public virtual byte[] Encode(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.EncodeValue(n, r),
				this.EncodeValue(n, s)
			}).GetEncoded("DER");
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000A78FE File Offset: 0x000A5AFE
		protected virtual global::Org.BouncyCastle.Math.BigInteger CheckValue(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x.SignValue < 0 || (n != null && x.CompareTo(n) >= 0))
			{
				throw new global::System.ArgumentException("Value out of range", "x");
			}
			return x;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000A7927 File Offset: 0x000A5B27
		protected virtual global::Org.BouncyCastle.Math.BigInteger DecodeValue(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Asn1.Asn1Sequence s, int pos)
		{
			return this.CheckValue(n, ((global::Org.BouncyCastle.Asn1.DerInteger)s[pos]).Value);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000A7941 File Offset: 0x000A5B41
		protected virtual global::Org.BouncyCastle.Asn1.DerInteger EncodeValue(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Asn1.DerInteger(this.CheckValue(n, x));
		}

		// Token: 0x04000F76 RID: 3958
		public static readonly global::Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding Instance = new global::Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding();
	}
}
