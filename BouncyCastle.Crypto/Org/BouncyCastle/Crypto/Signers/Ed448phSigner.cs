using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039F RID: 927
	public class Ed448phSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025D6 RID: 9686 RVA: 0x000A4395 File Offset: 0x000A2595
		public Ed448phSigner(byte[] context)
		{
			this.context = global::Org.BouncyCastle.Utilities.Arrays.Clone(context);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000A43B4 File Offset: 0x000A25B4
		public virtual string AlgorithmName
		{
			get
			{
				return "Ed448ph";
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x000A43BB File Offset: 0x000A25BB
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forSigning = forSigning;
			if (forSigning)
			{
				this.privateKey = (global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters)parameters;
				this.publicKey = null;
			}
			else
			{
				this.privateKey = null;
				this.publicKey = (global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters)parameters;
			}
			this.Reset();
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000A43F5 File Offset: 0x000A25F5
		public virtual void Update(byte b)
		{
			this.prehash.Update(b);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x000A4403 File Offset: 0x000A2603
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.prehash.BlockUpdate(buf, off, len);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x000A4414 File Offset: 0x000A2614
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning || this.privateKey == null)
			{
				throw new global::System.InvalidOperationException("Ed448phSigner not initialised for signature generation.");
			}
			byte[] msg = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize != this.prehash.DoFinal(msg, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize))
			{
				throw new global::System.InvalidOperationException("Prehash digest failed");
			}
			byte[] signature = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.SignatureSize];
			this.privateKey.Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm.Ed448ph, this.context, msg, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize, signature, 0);
			return signature;
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000A4494 File Offset: 0x000A2694
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning || this.publicKey == null)
			{
				throw new global::System.InvalidOperationException("Ed448phSigner not initialised for verification");
			}
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SignatureSize != signature.Length)
			{
				this.prehash.Reset();
				return false;
			}
			byte[] pk = this.publicKey.GetEncoded();
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.VerifyPrehash(signature, 0, pk, 0, this.context, this.prehash);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000A44F4 File Offset: 0x000A26F4
		public void Reset()
		{
			this.prehash.Reset();
		}

		// Token: 0x04000F08 RID: 3848
		private readonly global::Org.BouncyCastle.Crypto.IXof prehash = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.CreatePrehash();

		// Token: 0x04000F09 RID: 3849
		private readonly byte[] context;

		// Token: 0x04000F0A RID: 3850
		private bool forSigning;

		// Token: 0x04000F0B RID: 3851
		private global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey;

		// Token: 0x04000F0C RID: 3852
		private global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey;
	}
}
