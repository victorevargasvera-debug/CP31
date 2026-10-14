using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200063B RID: 1595
	public abstract class X9IntegerConverter
	{
		// Token: 0x06003B27 RID: 15143 RVA: 0x00110AD6 File Offset: 0x0010ECD6
		public static int GetByteLength(global::Org.BouncyCastle.Math.EC.ECFieldElement fe)
		{
			return (fe.FieldSize + 7) / 8;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x00110AE2 File Offset: 0x0010ECE2
		public static int GetByteLength(global::Org.BouncyCastle.Math.EC.ECCurve c)
		{
			return (c.FieldSize + 7) / 8;
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00110AF0 File Offset: 0x0010ECF0
		public static byte[] IntegerToBytes(global::Org.BouncyCastle.Math.BigInteger s, int qLength)
		{
			byte[] bytes = s.ToByteArrayUnsigned();
			if (qLength < bytes.Length)
			{
				byte[] tmp = new byte[qLength];
				global::System.Array.Copy(bytes, bytes.Length - tmp.Length, tmp, 0, tmp.Length);
				return tmp;
			}
			if (qLength > bytes.Length)
			{
				byte[] tmp2 = new byte[qLength];
				global::System.Array.Copy(bytes, 0, tmp2, tmp2.Length - bytes.Length, bytes.Length);
				return tmp2;
			}
			return bytes;
		}
	}
}
