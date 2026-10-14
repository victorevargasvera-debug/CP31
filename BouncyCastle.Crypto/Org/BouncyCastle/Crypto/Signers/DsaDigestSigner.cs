using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x02000397 RID: 919
	public class DsaDigestSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x000A32EE File Offset: 0x000A14EE
		public DsaDigestSigner(global::Org.BouncyCastle.Crypto.IDsa dsa, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.dsa = dsa;
			this.digest = digest;
			this.encoding = global::Org.BouncyCastle.Crypto.Signers.StandardDsaEncoding.Instance;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000A330F File Offset: 0x000A150F
		public DsaDigestSigner(global::Org.BouncyCastle.Crypto.IDsaExt dsa, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding)
		{
			this.dsa = dsa;
			this.digest = digest;
			this.encoding = encoding;
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000A332C File Offset: 0x000A152C
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "with" + this.dsa.AlgorithmName;
			}
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000A3350 File Offset: 0x000A1550
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
			this.dsa.Init(forSigning, parameters);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000A33C5 File Offset: 0x000A15C5
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000A33D3 File Offset: 0x000A15D3
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.digest.BlockUpdate(input, inOff, length);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x000A33E4 File Offset: 0x000A15E4
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("DSADigestSigner not initialised for signature generation.");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			global::Org.BouncyCastle.Math.BigInteger[] sig = this.dsa.GenerateSignature(hash);
			byte[] result;
			try
			{
				result = this.encoding.Encode(this.GetOrder(), sig[0], sig[1]);
			}
			catch (global::System.Exception)
			{
				throw new global::System.InvalidOperationException("unable to encode signature");
			}
			return result;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000A3468 File Offset: 0x000A1668
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("DSADigestSigner not initialised for verification");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			bool result;
			try
			{
				global::Org.BouncyCastle.Math.BigInteger[] sig = this.encoding.Decode(this.GetOrder(), signature);
				result = this.dsa.VerifySignature(hash, sig[0], sig[1]);
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000A34E8 File Offset: 0x000A16E8
		public virtual void Reset()
		{
			this.digest.Reset();
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000A34F5 File Offset: 0x000A16F5
		protected virtual global::Org.BouncyCastle.Math.BigInteger GetOrder()
		{
			if (!(this.dsa is global::Org.BouncyCastle.Crypto.IDsaExt))
			{
				return null;
			}
			return ((global::Org.BouncyCastle.Crypto.IDsaExt)this.dsa).Order;
		}

		// Token: 0x04000EE9 RID: 3817
		private readonly global::Org.BouncyCastle.Crypto.IDsa dsa;

		// Token: 0x04000EEA RID: 3818
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000EEB RID: 3819
		private readonly global::Org.BouncyCastle.Crypto.Signers.IDsaEncoding encoding;

		// Token: 0x04000EEC RID: 3820
		private bool forSigning;
	}
}
