using System;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039C RID: 924
	public class Ed25519ctxSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025BE RID: 9662 RVA: 0x000A405B File Offset: 0x000A225B
		public Ed25519ctxSigner(byte[] context)
		{
			this.context = global::Org.BouncyCastle.Utilities.Arrays.Clone(context);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000A407A File Offset: 0x000A227A
		public virtual string AlgorithmName
		{
			get
			{
				return "Ed25519ctx";
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000A4081 File Offset: 0x000A2281
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

		// Token: 0x060025C1 RID: 9665 RVA: 0x000A40BB File Offset: 0x000A22BB
		public virtual void Update(byte b)
		{
			this.buffer.WriteByte(b);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000A40C9 File Offset: 0x000A22C9
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.buffer.Write(buf, off, len);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000A40D9 File Offset: 0x000A22D9
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning || this.privateKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519ctxSigner not initialised for signature generation.");
			}
			return this.buffer.GenerateSignature(this.privateKey, this.context);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000A410D File Offset: 0x000A230D
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning || this.publicKey == null)
			{
				throw new global::System.InvalidOperationException("Ed25519ctxSigner not initialised for verification");
			}
			return this.buffer.VerifySignature(this.publicKey, this.context, signature);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000A4142 File Offset: 0x000A2342
		public virtual void Reset()
		{
			this.buffer.Reset();
		}

		// Token: 0x04000EFA RID: 3834
		private readonly global::Org.BouncyCastle.Crypto.Signers.Ed25519ctxSigner.Buffer buffer = new global::Org.BouncyCastle.Crypto.Signers.Ed25519ctxSigner.Buffer();

		// Token: 0x04000EFB RID: 3835
		private readonly byte[] context;

		// Token: 0x04000EFC RID: 3836
		private bool forSigning;

		// Token: 0x04000EFD RID: 3837
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey;

		// Token: 0x04000EFE RID: 3838
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey;

		// Token: 0x02000802 RID: 2050
		private class Buffer : global::System.IO.MemoryStream
		{
			// Token: 0x06004653 RID: 18003 RVA: 0x00136598 File Offset: 0x00134798
			internal byte[] GenerateSignature(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey, byte[] ctx)
			{
				byte[] result;
				lock (this)
				{
					byte[] buf = this.GetBuffer();
					int count = (int)this.Position;
					byte[] signature = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.SignatureSize];
					privateKey.Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519ctx, ctx, buf, 0, count, signature, 0);
					this.Reset();
					result = signature;
				}
				return result;
			}

			// Token: 0x06004654 RID: 18004 RVA: 0x00136604 File Offset: 0x00134804
			internal bool VerifySignature(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey, byte[] ctx, byte[] signature)
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
					bool flag2 = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Verify(signature, 0, pk, 0, ctx, buf, 0, count);
					this.Reset();
					result = flag2;
				}
				return result;
			}

			// Token: 0x06004655 RID: 18005 RVA: 0x0013667C File Offset: 0x0013487C
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
