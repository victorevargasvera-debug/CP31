using System;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A0 RID: 928
	public class Ed448Signer : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x000A4501 File Offset: 0x000A2701
		public Ed448Signer(byte[] context)
		{
			this.context = global::Org.BouncyCastle.Utilities.Arrays.Clone(context);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000A4520 File Offset: 0x000A2720
		public virtual string AlgorithmName
		{
			get
			{
				return "Ed448";
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x000A4527 File Offset: 0x000A2727
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

		// Token: 0x060025E1 RID: 9697 RVA: 0x000A4561 File Offset: 0x000A2761
		public virtual void Update(byte b)
		{
			this.buffer.WriteByte(b);
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000A456F File Offset: 0x000A276F
		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
			this.buffer.Write(buf, off, len);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000A457F File Offset: 0x000A277F
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning || this.privateKey == null)
			{
				throw new global::System.InvalidOperationException("Ed448Signer not initialised for signature generation.");
			}
			return this.buffer.GenerateSignature(this.privateKey, this.context);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000A45B3 File Offset: 0x000A27B3
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning || this.publicKey == null)
			{
				throw new global::System.InvalidOperationException("Ed448Signer not initialised for verification");
			}
			return this.buffer.VerifySignature(this.publicKey, this.context, signature);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000A45E8 File Offset: 0x000A27E8
		public virtual void Reset()
		{
			this.buffer.Reset();
		}

		// Token: 0x04000F0D RID: 3853
		private readonly global::Org.BouncyCastle.Crypto.Signers.Ed448Signer.Buffer buffer = new global::Org.BouncyCastle.Crypto.Signers.Ed448Signer.Buffer();

		// Token: 0x04000F0E RID: 3854
		private readonly byte[] context;

		// Token: 0x04000F0F RID: 3855
		private bool forSigning;

		// Token: 0x04000F10 RID: 3856
		private global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey;

		// Token: 0x04000F11 RID: 3857
		private global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey;

		// Token: 0x02000804 RID: 2052
		private class Buffer : global::System.IO.MemoryStream
		{
			// Token: 0x0600465B RID: 18011 RVA: 0x00136818 File Offset: 0x00134A18
			internal byte[] GenerateSignature(global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey, byte[] ctx)
			{
				byte[] result;
				lock (this)
				{
					byte[] buf = this.GetBuffer();
					int count = (int)this.Position;
					byte[] signature = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.SignatureSize];
					privateKey.Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm.Ed448, ctx, buf, 0, count, signature, 0);
					this.Reset();
					result = signature;
				}
				return result;
			}

			// Token: 0x0600465C RID: 18012 RVA: 0x00136884 File Offset: 0x00134A84
			internal bool VerifySignature(global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey, byte[] ctx, byte[] signature)
			{
				if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SignatureSize != signature.Length)
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
					bool flag2 = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Verify(signature, 0, pk, 0, ctx, buf, 0, count);
					this.Reset();
					result = flag2;
				}
				return result;
			}

			// Token: 0x0600465D RID: 18013 RVA: 0x001368FC File Offset: 0x00134AFC
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
