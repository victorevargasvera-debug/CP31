using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F4 RID: 1268
	public class SM2KeyExchange
	{
		// Token: 0x060031D0 RID: 12752 RVA: 0x000EF7D7 File Offset: 0x000ED9D7
		public SM2KeyExchange() : this(new global::Org.BouncyCastle.Crypto.Digests.SM3Digest())
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x000EF7E4 File Offset: 0x000ED9E4
		public SM2KeyExchange(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.mDigest = digest;
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000EF7F4 File Offset: 0x000ED9F4
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters privParam)
		{
			global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePrivateParameters baseParam;
			if (privParam is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)
			{
				baseParam = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePrivateParameters)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)privParam).Parameters;
				this.mUserID = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)privParam).GetID();
			}
			else
			{
				baseParam = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePrivateParameters)privParam;
				this.mUserID = new byte[0];
			}
			this.mInitiator = baseParam.IsInitiator;
			this.mStaticKey = baseParam.StaticPrivateKey;
			this.mEphemeralKey = baseParam.EphemeralPrivateKey;
			this.mECParams = this.mStaticKey.Parameters;
			this.mStaticPubPoint = baseParam.StaticPublicPoint;
			this.mEphemeralPubPoint = baseParam.EphemeralPublicPoint;
			this.mW = this.mECParams.Curve.FieldSize / 2 - 1;
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000EF8A8 File Offset: 0x000EDAA8
		public virtual byte[] CalculateKey(int kLen, global::Org.BouncyCastle.Crypto.ICipherParameters pubParam)
		{
			global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters otherPub;
			byte[] otherUserID;
			if (pubParam is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)
			{
				otherPub = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)pubParam).Parameters;
				otherUserID = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)pubParam).GetID();
			}
			else
			{
				otherPub = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters)pubParam;
				otherUserID = new byte[0];
			}
			byte[] za = this.GetZ(this.mDigest, this.mUserID, this.mStaticPubPoint);
			byte[] zb = this.GetZ(this.mDigest, otherUserID, otherPub.StaticPublicKey.Q);
			global::Org.BouncyCastle.Math.EC.ECPoint U = this.CalculateU(otherPub);
			byte[] rv;
			if (this.mInitiator)
			{
				rv = this.Kdf(U, za, zb, kLen);
			}
			else
			{
				rv = this.Kdf(U, zb, za, kLen);
			}
			return rv;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000EF94C File Offset: 0x000EDB4C
		public virtual byte[][] CalculateKeyWithConfirmation(int kLen, byte[] confirmationTag, global::Org.BouncyCastle.Crypto.ICipherParameters pubParam)
		{
			global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters otherPub;
			byte[] otherUserID;
			if (pubParam is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)
			{
				otherPub = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)pubParam).Parameters;
				otherUserID = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)pubParam).GetID();
			}
			else
			{
				otherPub = (global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters)pubParam;
				otherUserID = new byte[0];
			}
			if (this.mInitiator && confirmationTag == null)
			{
				throw new global::System.ArgumentException("if initiating, confirmationTag must be set");
			}
			byte[] za = this.GetZ(this.mDigest, this.mUserID, this.mStaticPubPoint);
			byte[] zb = this.GetZ(this.mDigest, otherUserID, otherPub.StaticPublicKey.Q);
			global::Org.BouncyCastle.Math.EC.ECPoint U = this.CalculateU(otherPub);
			byte[] rv;
			if (!this.mInitiator)
			{
				rv = this.Kdf(U, zb, za, kLen);
				byte[] inner = this.CalculateInnerHash(this.mDigest, U, zb, za, otherPub.EphemeralPublicKey.Q, this.mEphemeralPubPoint);
				return new byte[][]
				{
					rv,
					this.S1(this.mDigest, U, inner),
					this.S2(this.mDigest, U, inner)
				};
			}
			rv = this.Kdf(U, za, zb, kLen);
			byte[] inner2 = this.CalculateInnerHash(this.mDigest, U, za, zb, this.mEphemeralPubPoint, otherPub.EphemeralPublicKey.Q);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.S1(this.mDigest, U, inner2), confirmationTag))
			{
				throw new global::System.InvalidOperationException("confirmation tag mismatch");
			}
			return new byte[][]
			{
				rv,
				this.S2(this.mDigest, U, inner2)
			};
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000EFABC File Offset: 0x000EDCBC
		protected virtual global::Org.BouncyCastle.Math.EC.ECPoint CalculateU(global::Org.BouncyCastle.Crypto.Parameters.SM2KeyExchangePublicParameters otherPub)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters = this.mStaticKey.Parameters;
			global::Org.BouncyCastle.Math.EC.ECPoint p = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(parameters.Curve, otherPub.StaticPublicKey.Q);
			global::Org.BouncyCastle.Math.EC.ECPoint p2 = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(parameters.Curve, otherPub.EphemeralPublicKey.Q);
			global::Org.BouncyCastle.Math.BigInteger x = this.Reduce(this.mEphemeralPubPoint.AffineXCoord.ToBigInteger());
			global::Org.BouncyCastle.Math.BigInteger x2 = this.Reduce(p2.AffineXCoord.ToBigInteger());
			global::Org.BouncyCastle.Math.BigInteger tA = this.mStaticKey.D.Add(x.Multiply(this.mEphemeralKey.D));
			global::Org.BouncyCastle.Math.BigInteger k = this.mECParams.H.Multiply(tA).Mod(this.mECParams.N);
			global::Org.BouncyCastle.Math.BigInteger k2 = k.Multiply(x2).Mod(this.mECParams.N);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(p, k, p2, k2).Normalize();
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000EFB9C File Offset: 0x000EDD9C
		protected virtual byte[] Kdf(global::Org.BouncyCastle.Math.EC.ECPoint u, byte[] za, byte[] zb, int klen)
		{
			int digestSize = this.mDigest.GetDigestSize();
			byte[] buf = new byte[global::System.Math.Max(4, digestSize)];
			byte[] rv = new byte[(klen + 7) / 8];
			int off = 0;
			global::Org.BouncyCastle.Utilities.IMemoable memo = this.mDigest as global::Org.BouncyCastle.Utilities.IMemoable;
			global::Org.BouncyCastle.Utilities.IMemoable copy = null;
			if (memo != null)
			{
				this.AddFieldElement(this.mDigest, u.AffineXCoord);
				this.AddFieldElement(this.mDigest, u.AffineYCoord);
				this.mDigest.BlockUpdate(za, 0, za.Length);
				this.mDigest.BlockUpdate(zb, 0, zb.Length);
				copy = memo.Copy();
			}
			uint ct = 0U;
			while (off < rv.Length)
			{
				if (memo != null)
				{
					memo.Reset(copy);
				}
				else
				{
					this.AddFieldElement(this.mDigest, u.AffineXCoord);
					this.AddFieldElement(this.mDigest, u.AffineYCoord);
					this.mDigest.BlockUpdate(za, 0, za.Length);
					this.mDigest.BlockUpdate(zb, 0, zb.Length);
				}
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ct += 1U, buf, 0);
				this.mDigest.BlockUpdate(buf, 0, 4);
				this.mDigest.DoFinal(buf, 0);
				int copyLen = global::System.Math.Min(digestSize, rv.Length - off);
				global::System.Array.Copy(buf, 0, rv, off, copyLen);
				off += copyLen;
			}
			return rv;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000EFCDD File Offset: 0x000EDEDD
		private global::Org.BouncyCastle.Math.BigInteger Reduce(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return x.And(global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(this.mW).Subtract(global::Org.BouncyCastle.Math.BigInteger.One)).SetBit(this.mW);
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000EFD0A File Offset: 0x000EDF0A
		private byte[] S1(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECPoint u, byte[] inner)
		{
			digest.Update(2);
			this.AddFieldElement(digest, u.AffineYCoord);
			digest.BlockUpdate(inner, 0, inner.Length);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000EFD34 File Offset: 0x000EDF34
		private byte[] CalculateInnerHash(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECPoint u, byte[] za, byte[] zb, global::Org.BouncyCastle.Math.EC.ECPoint p1, global::Org.BouncyCastle.Math.EC.ECPoint p2)
		{
			this.AddFieldElement(digest, u.AffineXCoord);
			digest.BlockUpdate(za, 0, za.Length);
			digest.BlockUpdate(zb, 0, zb.Length);
			this.AddFieldElement(digest, p1.AffineXCoord);
			this.AddFieldElement(digest, p1.AffineYCoord);
			this.AddFieldElement(digest, p2.AffineXCoord);
			this.AddFieldElement(digest, p2.AffineYCoord);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000EFDA4 File Offset: 0x000EDFA4
		private byte[] S2(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECPoint u, byte[] inner)
		{
			digest.Update(3);
			this.AddFieldElement(digest, u.AffineYCoord);
			digest.BlockUpdate(inner, 0, inner.Length);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000EFDCC File Offset: 0x000EDFCC
		private byte[] GetZ(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] userID, global::Org.BouncyCastle.Math.EC.ECPoint pubPoint)
		{
			this.AddUserID(digest, userID);
			this.AddFieldElement(digest, this.mECParams.Curve.A);
			this.AddFieldElement(digest, this.mECParams.Curve.B);
			this.AddFieldElement(digest, this.mECParams.G.AffineXCoord);
			this.AddFieldElement(digest, this.mECParams.G.AffineYCoord);
			this.AddFieldElement(digest, pubPoint.AffineXCoord);
			this.AddFieldElement(digest, pubPoint.AffineYCoord);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000EFE60 File Offset: 0x000EE060
		private void AddUserID(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] userID)
		{
			uint len = (uint)(userID.Length * 8);
			digest.Update((byte)(len >> 8));
			digest.Update((byte)len);
			digest.BlockUpdate(userID, 0, userID.Length);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000EFE90 File Offset: 0x000EE090
		private void AddFieldElement(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECFieldElement v)
		{
			byte[] p = v.GetEncoded();
			digest.BlockUpdate(p, 0, p.Length);
		}

		// Token: 0x040015E9 RID: 5609
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

		// Token: 0x040015EA RID: 5610
		private byte[] mUserID;

		// Token: 0x040015EB RID: 5611
		private global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mStaticKey;

		// Token: 0x040015EC RID: 5612
		private global::Org.BouncyCastle.Math.EC.ECPoint mStaticPubPoint;

		// Token: 0x040015ED RID: 5613
		private global::Org.BouncyCastle.Math.EC.ECPoint mEphemeralPubPoint;

		// Token: 0x040015EE RID: 5614
		private global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters mECParams;

		// Token: 0x040015EF RID: 5615
		private int mW;

		// Token: 0x040015F0 RID: 5616
		private global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mEphemeralKey;

		// Token: 0x040015F1 RID: 5617
		private bool mInitiator;
	}
}
