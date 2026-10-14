using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039D RID: 925
	public class Ed25519phSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x000A414F File Offset: 0x000A234F
		public Ed25519phSigner(byte[] context)
		{
			this.context = global::Org.BouncyCastle.Utilities.Arrays.Clone(context);
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000A416E File Offset: 0x000A236E
		public virtual string AlgorithmName
		{
			get
			{
				return "Ed25519ph";
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000A4175 File Offset: 0x000A2375
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forSigning = forSigning;
			if (forSigning)
			{
				this.privateKey = (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters)parameters;
				this.publicKey = null;
			}
			else
			{
				this.privateKey = null;
				this.publicKey = (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters)parameters;
			}
			this.Reset();
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000A41AF File Offset: 0x000A23AF
		public virtual void Update(byte b)
		{
			this.prehash.Update(b);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000A41BD File Offset: 0x000A23BD
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.prehash.BlockUpdate(buf, off, len);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000A41D0 File Offset: 0x000A23D0
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning || this.privateKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519phSigner not initialised for signature generation.");
			}
			byte[] msg = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize];
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize != this.prehash.DoFinal(msg, 0))
			{
				throw new global::System.InvalidOperationException("Prehash digest failed");
			}
			byte[] signature = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.SignatureSize];
			this.privateKey.Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519ph, this.context, msg, 0, global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize, signature, 0);
			return signature;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000A424C File Offset: 0x000A244C
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning || this.publicKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519phSigner not initialised for verification");
			}
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SignatureSize != signature.Length)
			{
				this.prehash.Reset();
				return false;
			}
			byte[] pk = this.publicKey.GetEncoded();
			return global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.VerifyPrehash(signature, 0, pk, 0, this.context, this.prehash);
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000A42AC File Offset: 0x000A24AC
		public void Reset()
		{
			this.prehash.Reset();
		}

		// Token: 0x04000EFF RID: 3839
		private readonly global::Org.BouncyCastle.Crypto.IDigest prehash = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.CreatePrehash();

		// Token: 0x04000F00 RID: 3840
		private readonly byte[] context;

		// Token: 0x04000F01 RID: 3841
		private bool forSigning;

		// Token: 0x04000F02 RID: 3842
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey;

		// Token: 0x04000F03 RID: 3843
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey;
	}
}
