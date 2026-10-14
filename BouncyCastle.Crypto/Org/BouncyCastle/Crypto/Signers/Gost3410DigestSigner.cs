using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A2 RID: 930
	public class Gost3410DigestSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x000A47E1 File Offset: 0x000A29E1
		public Gost3410DigestSigner(global::Org.BouncyCastle.Crypto.IDsa signer, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.dsaSigner = signer;
			this.digest = digest;
			this.halfSize = digest.GetDigestSize();
			this.size = this.halfSize * 2;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000A4811 File Offset: 0x000A2A11
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "with" + this.dsaSigner.AlgorithmName;
			}
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000A4834 File Offset: 0x000A2A34
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forSigning = forSigning;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter i;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				i = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			else
			{
				i = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)parameters;
			}
			if (forSigning && !i.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Signing Requires Private Key.");
			}
			if (!forSigning && i.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Verification Requires Public Key.");
			}
			this.Reset();
			this.dsaSigner.Init(forSigning, parameters);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000A48A9 File Offset: 0x000A2AA9
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000A48B7 File Offset: 0x000A2AB7
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.digest.BlockUpdate(input, inOff, length);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000A48C8 File Offset: 0x000A2AC8
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("GOST3410DigestSigner not initialised for signature generation.");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			byte[] result;
			try
			{
				global::Org.BouncyCastle.Math.BigInteger[] array = this.dsaSigner.GenerateSignature(hash);
				byte[] sigBytes = new byte[this.size];
				byte[] r = array[0].ToByteArrayUnsigned();
				byte[] s = array[1].ToByteArrayUnsigned();
				s.CopyTo(sigBytes, this.halfSize - s.Length);
				r.CopyTo(sigBytes, this.size - r.Length);
				result = sigBytes;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.SignatureException(e.Message, e);
			}
			return result;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000A497C File Offset: 0x000A2B7C
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("DSADigestSigner not initialised for verification");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			global::Org.BouncyCastle.Math.BigInteger R;
			global::Org.BouncyCastle.Math.BigInteger S;
			try
			{
				R = new global::Org.BouncyCastle.Math.BigInteger(1, signature, this.halfSize, this.halfSize);
				S = new global::Org.BouncyCastle.Math.BigInteger(1, signature, 0, this.halfSize);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.SignatureException("error decoding signature bytes.", e);
			}
			return this.dsaSigner.VerifySignature(hash, R, S);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000A4A0C File Offset: 0x000A2C0C
		public virtual void Reset()
		{
			this.digest.Reset();
		}

		// Token: 0x04000F15 RID: 3861
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F16 RID: 3862
		private readonly global::Org.BouncyCastle.Crypto.IDsa dsaSigner;

		// Token: 0x04000F17 RID: 3863
		private readonly int size;

		// Token: 0x04000F18 RID: 3864
		private int halfSize;

		// Token: 0x04000F19 RID: 3865
		private bool forSigning;
	}
}
