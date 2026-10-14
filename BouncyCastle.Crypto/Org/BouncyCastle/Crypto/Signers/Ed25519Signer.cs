using System;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039E RID: 926
	public class Ed25519Signer : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x000A42CC File Offset: 0x000A24CC
		public virtual string AlgorithmName
		{
			get
			{
				return "Ed25519";
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000A42D3 File Offset: 0x000A24D3
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

		// Token: 0x060025D1 RID: 9681 RVA: 0x000A430D File Offset: 0x000A250D
		public virtual void Update(byte b)
		{
			this.buffer.WriteByte(b);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000A431B File Offset: 0x000A251B
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.buffer.Write(buf, off, len);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x000A432B File Offset: 0x000A252B
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning || this.privateKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519Signer not initialised for signature generation.");
			}
			return this.buffer.GenerateSignature(this.privateKey);
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000A4359 File Offset: 0x000A2559
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning || this.publicKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519Signer not initialised for verification");
			}
			return this.buffer.VerifySignature(this.publicKey, signature);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000A4388 File Offset: 0x000A2588
		public virtual void Reset()
		{
			this.buffer.Reset();
		}

		// Token: 0x04000F04 RID: 3844
		private readonly global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer.Buffer buffer = new global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer.Buffer();

		// Token: 0x04000F05 RID: 3845
		private bool forSigning;

		// Token: 0x04000F06 RID: 3846
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey;

		// Token: 0x04000F07 RID: 3847
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey;

		// Token: 0x02000803 RID: 2051
		private class Buffer : global::System.IO.MemoryStream
		{
			// Token: 0x06004657 RID: 18007 RVA: 0x001366D8 File Offset: 0x001348D8
			internal byte[] GenerateSignature(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey)
			{
				byte[] result;
				lock (this)
				{
					byte[] buf = this.GetBuffer();
					int count = (int)this.Position;
					byte[] signature = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.SignatureSize];
					privateKey.Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519, null, buf, 0, count, signature, 0);
					this.Reset();
					result = signature;
				}
				return result;
			}

			// Token: 0x06004658 RID: 18008 RVA: 0x00136744 File Offset: 0x00134944
			internal bool VerifySignature(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey, byte[] signature)
			{
				if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SignatureSize != signature.Length)
				{
					this.Reset();
					return false;
				}
				bool result;
				lock (this)
				{
					byte[] buf = this.GetBuffer();
					int count = (int)this.Position;
					byte[] pk = publicKey.GetEncoded();
					bool flag2 = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Verify(signature, 0, pk, 0, buf, 0, count);
					this.Reset();
					result = flag2;
				}
				return result;
			}

			// Token: 0x06004659 RID: 18009 RVA: 0x001367BC File Offset: 0x001349BC
			internal void Reset()
			{
				lock (this)
				{
					long count = this.Position;
					global::System.Array.Clear(this.GetBuffer(), 0, (int)count);
					this.Position = 0L;
				}
			}
		}
	}
}
