using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AA RID: 938
	public class PlainDsaEncoding : global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x000A64EC File Offset: 0x000A46EC
		public virtual global::Org.BouncyCastle.Math.BigInteger[] Decode(global::Org.BouncyCastle.Math.BigInteger n, byte[] encoding)
		{
			int valueLength = global::Org.BouncyCastle.Utilities.BigIntegers.GetUnsignedByteLength(n);
			if (encoding.Length != valueLength * 2)
			{
				throw new global::System.ArgumentException("Encoding has incorrect length", "encoding");
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				this.DecodeValue(n, encoding, 0, valueLength),
				this.DecodeValue(n, encoding, valueLength, valueLength)
			};
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000A6538 File Offset: 0x000A4738
		public virtual byte[] Encode(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			int valueLength = global::Org.BouncyCastle.Utilities.BigIntegers.GetUnsignedByteLength(n);
			byte[] result = new byte[valueLength * 2];
			this.EncodeValue(n, r, result, 0, valueLength);
			this.EncodeValue(n, s, result, valueLength, valueLength);
			return result;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000A656C File Offset: 0x000A476C
		protected virtual global::Org.BouncyCastle.Math.BigInteger CheckValue(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x.SignValue < 0 || x.CompareTo(n) >= 0)
			{
				throw new global::System.ArgumentException("Value out of range", "x");
			}
			return x;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000A6592 File Offset: 0x000A4792
		protected virtual global::Org.BouncyCastle.Math.BigInteger DecodeValue(global::Org.BouncyCastle.Math.BigInteger n, byte[] buf, int off, int len)
		{
			return this.CheckValue(n, new global::Org.BouncyCastle.Math.BigInteger(1, buf, off, len));
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000A65A8 File Offset: 0x000A47A8
		protected virtual void EncodeValue(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger x, byte[] buf, int off, int len)
		{
			byte[] bs = this.CheckValue(n, x).ToByteArrayUnsigned();
			int bsOff = global::System.Math.Max(0, bs.Length - len);
			int bsLen = bs.Length - bsOff;
			int pos = len - bsLen;
			global::Org.BouncyCastle.Utilities.Arrays.Fill(buf, off, off + pos, 0);
			global::System.Array.Copy(bs, bsOff, buf, off + pos, bsLen);
		}

		// Token: 0x04000F58 RID: 3928
		public static readonly global::Org.BouncyCastle.Crypto.Signers.PlainDsaEncoding Instance = new global::Org.BouncyCastle.Crypto.Signers.PlainDsaEncoding();
	}
}
