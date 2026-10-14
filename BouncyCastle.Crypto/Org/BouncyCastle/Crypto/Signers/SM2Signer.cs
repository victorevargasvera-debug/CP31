using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AE RID: 942
	public class SM2Signer : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x0600265D RID: 9821 RVA: 0x000A72DE File Offset: 0x000A54DE
		public SM2Signer() : this(global::Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding.Instance, new global::Org.BouncyCastle.Crypto.Digests.SM3Digest())
		{
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000A72F0 File Offset: 0x000A54F0
		public SM2Signer(global::Org.BouncyCastle.Crypto.IDigest digest) : this(global::Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding.Instance, digest)
		{
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000A72FE File Offset: 0x000A54FE
		public SM2Signer(global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding) : this(encoding, new global::Org.BouncyCastle.Crypto.Digests.SM3Digest())
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000A730C File Offset: 0x000A550C
		public SM2Signer(global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.encoding = encoding;
			this.digest = digest;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000A732D File Offset: 0x000A552D
		public virtual string AlgorithmName
		{
			get
			{
				return "SM2Sign";
			}
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000A7334 File Offset: 0x000A5534
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.ICipherParameters baseParam;
			byte[] userID;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)
			{
				baseParam = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)parameters).Parameters;
				userID = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithID)parameters).GetID();
				if (userID.Length >= 8192)
				{
					throw new global::System.ArgumentException("SM2 user ID must be less than 2^16 bits long");
				}
			}
			else
			{
				baseParam = parameters;
				userID = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("31323334353637383132333435363738");
			}
			if (forSigning)
			{
				if (baseParam is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)baseParam;
					this.ecKey = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters)rParam.Parameters;
					this.ecParams = this.ecKey.Parameters;
					this.kCalculator.Init(this.ecParams.N, rParam.Random);
				}
				else
				{
					this.ecKey = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters)baseParam;
					this.ecParams = this.ecKey.Parameters;
					this.kCalculator.Init(this.ecParams.N, new global::Org.BouncyCastle.Security.SecureRandom());
				}
				this.pubPoint = this.CreateBasePointMultiplier().Multiply(this.ecParams.G, ((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.ecKey).D).Normalize();
			}
			else
			{
				this.ecKey = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters)baseParam;
				this.ecParams = this.ecKey.Parameters;
				this.pubPoint = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.ecKey).Q;
			}
			this.digest.Reset();
			this.z = this.GetZ(userID);
			this.digest.BlockUpdate(this.z, 0, this.z.Length);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000A74A8 File Offset: 0x000A56A8
		public virtual void Update(byte b)
		{
			this.digest.Update(b);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000A74B6 File Offset: 0x000A56B6
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.digest.BlockUpdate(buf, off, len);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000A74C8 File Offset: 0x000A56C8
		public virtual bool VerifySignature(byte[] signature)
		{
			try
			{
				global::Org.BouncyCastle.Math.BigInteger[] rs = this.encoding.Decode(this.ecParams.N, signature);
				return this.VerifySignature(rs[0], rs[1]);
			}
			catch (global::System.Exception)
			{
			}
			return false;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000A7514 File Offset: 0x000A5714
		public virtual void Reset()
		{
			if (this.z != null)
			{
				this.digest.Reset();
				this.digest.BlockUpdate(this.z, 0, this.z.Length);
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000A7544 File Offset: 0x000A5744
		public virtual byte[] GenerateSignature()
		{
			byte[] eHash = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.digest);
			global::Org.BouncyCastle.Math.BigInteger i = this.ecParams.N;
			global::Org.BouncyCastle.Math.BigInteger e = this.CalculateE(i, eHash);
			global::Org.BouncyCastle.Math.BigInteger d = ((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.ecKey).D;
			global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier basePointMultiplier = this.CreateBasePointMultiplier();
			global::Org.BouncyCastle.Math.BigInteger r;
			global::Org.BouncyCastle.Math.BigInteger s;
			for (;;)
			{
				global::Org.BouncyCastle.Math.BigInteger j = this.kCalculator.NextK();
				global::Org.BouncyCastle.Math.EC.ECPoint p = basePointMultiplier.Multiply(this.ecParams.G, j).Normalize();
				r = e.Add(p.AffineXCoord.ToBigInteger()).Mod(i);
				if (r.SignValue != 0 && !r.Add(j).Equals(i))
				{
					global::Org.BouncyCastle.Math.BigInteger bigInteger = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(i, d.Add(global::Org.BouncyCastle.Utilities.BigIntegers.One));
					s = j.Subtract(r.Multiply(d)).Mod(i);
					s = bigInteger.Multiply(s).Mod(i);
					if (s.SignValue != 0)
					{
						break;
					}
				}
			}
			byte[] result;
			try
			{
				result = this.encoding.Encode(this.ecParams.N, r, s);
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("unable to encode signature: " + ex.Message, ex);
			}
			return result;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000A7678 File Offset: 0x000A5878
		private bool VerifySignature(global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			global::Org.BouncyCastle.Math.BigInteger i = this.ecParams.N;
			if (r.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || r.CompareTo(i) >= 0)
			{
				return false;
			}
			if (s.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || s.CompareTo(i) >= 0)
			{
				return false;
			}
			byte[] eHash = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.digest);
			global::Org.BouncyCastle.Math.BigInteger e = this.CalculateE(i, eHash);
			global::Org.BouncyCastle.Math.BigInteger t = r.Add(s).Mod(i);
			if (t.SignValue == 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.ECPoint q = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.ecKey).Q;
			global::Org.BouncyCastle.Math.EC.ECPoint x1y = global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(this.ecParams.G, s, q, t).Normalize();
			return !x1y.IsInfinity && r.Equals(e.Add(x1y.AffineXCoord.ToBigInteger()).Mod(i));
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000A7748 File Offset: 0x000A5948
		private byte[] GetZ(byte[] userID)
		{
			this.AddUserID(this.digest, userID);
			this.AddFieldElement(this.digest, this.ecParams.Curve.A);
			this.AddFieldElement(this.digest, this.ecParams.Curve.B);
			this.AddFieldElement(this.digest, this.ecParams.G.AffineXCoord);
			this.AddFieldElement(this.digest, this.ecParams.G.AffineYCoord);
			this.AddFieldElement(this.digest, this.pubPoint.AffineXCoord);
			this.AddFieldElement(this.digest, this.pubPoint.AffineYCoord);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.digest);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000A780C File Offset: 0x000A5A0C
		private void AddUserID(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] userID)
		{
			int len = userID.Length * 8;
			digest.Update((byte)(len >> 8));
			digest.Update((byte)len);
			digest.BlockUpdate(userID, 0, userID.Length);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000A783C File Offset: 0x000A5A3C
		private void AddFieldElement(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.EC.ECFieldElement v)
		{
			byte[] p = v.GetEncoded();
			digest.BlockUpdate(p, 0, p.Length);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000A785B File Offset: 0x000A5A5B
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateE(global::Org.BouncyCastle.Math.BigInteger n, byte[] message)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, message);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000A7864 File Offset: 0x000A5A64
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
		}

		// Token: 0x04000F6F RID: 3951
		private readonly global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator = new global::Org.BouncyCastle.Crypto.Signers.RandomDsaKCalculator();

		// Token: 0x04000F70 RID: 3952
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F71 RID: 3953
		private readonly global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding;

		// Token: 0x04000F72 RID: 3954
		private global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams;

		// Token: 0x04000F73 RID: 3955
		private global::Org.BouncyCastle.Math.EC.ECPoint pubPoint;

		// Token: 0x04000F74 RID: 3956
		private global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters ecKey;

		// Token: 0x04000F75 RID: 3957
		private byte[] z;
	}
}
