using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000212 RID: 530
	public abstract class ECPointBase : global::Org.BouncyCastle.Math.EC.ECPoint
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x00062D08 File Offset: 0x00060F08
		protected internal ECPointBase(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00062D15 File Offset: 0x00060F15
		protected internal ECPointBase(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00062D24 File Offset: 0x00060F24
		public override byte[] GetEncoded(bool compressed)
		{
			if (base.IsInfinity)
			{
				return new byte[1];
			}
			global::Org.BouncyCastle.Math.EC.ECPoint normed = this.Normalize();
			byte[] X = normed.XCoord.GetEncoded();
			if (compressed)
			{
				byte[] PO = new byte[X.Length + 1];
				PO[0] = (normed.CompressionYTilde ? 3 : 2);
				global::System.Array.Copy(X, 0, PO, 1, X.Length);
				return PO;
			}
			byte[] Y = normed.YCoord.GetEncoded();
			byte[] PO2 = new byte[X.Length + Y.Length + 1];
			PO2[0] = 4;
			global::System.Array.Copy(X, 0, PO2, 1, X.Length);
			global::System.Array.Copy(Y, 0, PO2, X.Length + 1, Y.Length);
			return PO2;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00062DC0 File Offset: 0x00060FC0
		public override global::Org.BouncyCastle.Math.EC.ECPoint Multiply(global::Org.BouncyCastle.Math.BigInteger k)
		{
			return this.Curve.GetMultiplier().Multiply(this, k);
		}
	}
}
