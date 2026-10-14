using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B9 RID: 1209
	public class SM2Engine
	{
		// Token: 0x06002EC8 RID: 11976 RVA: 0x000D65BC File Offset: 0x000D47BC
		public SM2Engine() : this(new global::Org.BouncyCastle.Crypto.Digests.SM3Digest())
		{
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x000D65C9 File Offset: 0x000D47C9
		public SM2Engine(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.mDigest = digest;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x000D65D8 File Offset: 0x000D47D8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			this.mForEncryption = forEncryption;
			if (forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param;
				this.mECKey = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters)rParam.Parameters;
				this.mECParams = this.mECKey.Parameters;
				if (((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.mECKey).Q.Multiply(this.mECParams.H).IsInfinity)
				{
					throw new global::System.ArgumentException("invalid key: [h]Q at infinity");
				}
				this.mRandom = rParam.Random;
			}
			else
			{
				this.mECKey = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters)param;
				this.mECParams = this.mECKey.Parameters;
			}
			this.mCurveLength = (this.mECParams.Curve.FieldSize + 7) / 8;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x000D668F File Offset: 0x000D488F
		public virtual byte[] ProcessBlock(byte[] input, int inOff, int inLen)
		{
			if (this.mForEncryption)
			{
				return this.Encrypt(input, inOff, inLen);
			}
			return this.Decrypt(input, inOff, inLen);
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000D66AC File Offset: 0x000D48AC
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000D66B4 File Offset: 0x000D48B4
		private byte[] Encrypt(byte[] input, int inOff, int inLen)
		{
			byte[] c2 = new byte[inLen];
			global::System.Array.Copy(input, inOff, c2, 0, c2.Length);
			global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier multiplier = this.CreateBasePointMultiplier();
			byte[] c3;
			global::Org.BouncyCastle.Math.EC.ECPoint kPB;
			do
			{
				global::Org.BouncyCastle.Math.BigInteger i = this.NextK();
				c3 = multiplier.Multiply(this.mECParams.G, i).Normalize().GetEncoded(false);
				kPB = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.mECKey).Q.Multiply(i).Normalize();
				this.Kdf(this.mDigest, kPB, c2);
			}
			while (this.NotEncrypted(c2, input, inOff));
			this.AddFieldElement(this.mDigest, kPB.AffineXCoord);
			this.mDigest.BlockUpdate(input, inOff, inLen);
			this.AddFieldElement(this.mDigest, kPB.AffineYCoord);
			byte[] c4 = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.mDigest);
			return global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				c3,
				c2,
				c4
			});
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000D6790 File Offset: 0x000D4990
		private byte[] Decrypt(byte[] input, int inOff, int inLen)
		{
			byte[] c = new byte[this.mCurveLength * 2 + 1];
			global::System.Array.Copy(input, inOff, c, 0, c.Length);
			global::Org.BouncyCastle.Math.EC.ECPoint c1P = this.mECParams.Curve.DecodePoint(c);
			if (c1P.Multiply(this.mECParams.H).IsInfinity)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("[h]C1 at infinity");
			}
			c1P = c1P.Multiply(((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.mECKey).D).Normalize();
			byte[] c2 = new byte[inLen - c.Length - this.mDigest.GetDigestSize()];
			global::System.Array.Copy(input, inOff + c.Length, c2, 0, c2.Length);
			this.Kdf(this.mDigest, c1P, c2);
			this.AddFieldElement(this.mDigest, c1P.AffineXCoord);
			this.mDigest.BlockUpdate(c2, 0, c2.Length);
			this.AddFieldElement(this.mDigest, c1P.AffineYCoord);
			byte[] c3 = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.mDigest);
			int check = 0;
			for (int i = 0; i != c3.Length; i++)
			{
				check |= (int)(c3[i] ^ input[inOff + c.Length + c2.Length + i]);
			}
			global::Org.BouncyCastle.Utilities.Arrays.Fill(c, 0);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(c3, 0);
			if (check != 0)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(c2, 0);
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("invalid cipher text");
			}
			return c2;
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000D68D4 File Offset: 0x000D4AD4
		private bool NotEncrypted(byte[] encData, byte[] input, int inOff)
		{
			for (int i = 0; i != encData.Length; i++)
			{
				if (encData[i] != input[inOff + i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000D68FC File Offset: 0x000D4AFC
		private void Kdf(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECPoint c1, byte[] encData)
		{
			int digestSize = digest.GetDigestSize();
			byte[] buf = new byte[global::System.Math.Max(4, digestSize)];
			int off = 0;
			global::Org.BouncyCastle.Utilities.IMemoable memo = digest as global::Org.BouncyCastle.Utilities.IMemoable;
			global::Org.BouncyCastle.Utilities.IMemoable copy = null;
			if (memo != null)
			{
				this.AddFieldElement(digest, c1.AffineXCoord);
				this.AddFieldElement(digest, c1.AffineYCoord);
				copy = memo.Copy();
			}
			uint ct = 0U;
			while (off < encData.Length)
			{
				if (memo != null)
				{
					memo.Reset(copy);
				}
				else
				{
					this.AddFieldElement(digest, c1.AffineXCoord);
					this.AddFieldElement(digest, c1.AffineYCoord);
				}
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ct += 1U, buf, 0);
				digest.BlockUpdate(buf, 0, 4);
				digest.DoFinal(buf, 0);
				int xorLen = global::System.Math.Min(digestSize, encData.Length - off);
				this.Xor(encData, buf, off, xorLen);
				off += xorLen;
			}
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000D69C0 File Offset: 0x000D4BC0
		private void Xor(byte[] data, byte[] kdfOut, int dOff, int dRemaining)
		{
			for (int i = 0; i != dRemaining; i++)
			{
				int num = dOff + i;
				data[num] ^= kdfOut[i];
			}
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x000D69EC File Offset: 0x000D4BEC
		private global::Org.BouncyCastle.Math.BigInteger NextK()
		{
			int qBitLength = this.mECParams.N.BitLength;
			global::Org.BouncyCastle.Math.BigInteger i;
			do
			{
				i = new global::Org.BouncyCastle.Math.BigInteger(qBitLength, this.mRandom);
			}
			while (i.SignValue == 0 || i.CompareTo(this.mECParams.N) >= 0);
			return i;
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000D6A34 File Offset: 0x000D4C34
		private void AddFieldElement(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECFieldElement v)
		{
			byte[] p = v.GetEncoded();
			digest.BlockUpdate(p, 0, p.Length);
		}

		// Token: 0x040013DF RID: 5087
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

		// Token: 0x040013E0 RID: 5088
		private bool mForEncryption;

		// Token: 0x040013E1 RID: 5089
		private global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters mECKey;

		// Token: 0x040013E2 RID: 5090
		private global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters mECParams;

		// Token: 0x040013E3 RID: 5091
		private int mCurveLength;

		// Token: 0x040013E4 RID: 5092
		private global::Org.BouncyCastle.Security.SecureRandom mRandom;
	}
}
