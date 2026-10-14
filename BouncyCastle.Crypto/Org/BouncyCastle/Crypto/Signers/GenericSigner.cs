using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A1 RID: 929
	public class GenericSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x060025E6 RID: 9702 RVA: 0x000A45F5 File Offset: 0x000A27F5
		public GenericSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.engine = engine;
			this.digest = digest;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000A460C File Offset: 0x000A280C
		public virtual string AlgorithmName
		{
			get
			{
				return string.Concat(new string[]
				{
					"Generic(",
					this.engine.AlgorithmName,
					"/",
					this.digest.AlgorithmName,
					")"
				});
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000A4658 File Offset: 0x000A2858
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
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Signing requires private key.");
			}
			if (!forSigning && i.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Verification requires public key.");
			}
			this.Reset();
			this.engine.Init(forSigning, parameters);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000A46CD File Offset: 0x000A28CD
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000A46DB File Offset: 0x000A28DB
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.digest.BlockUpdate(input, inOff, length);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000A46EC File Offset: 0x000A28EC
		public virtual byte[] GenerateSignature()
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("GenericSigner not initialised for signature generation.");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			return this.engine.ProcessBlock(hash, 0, hash.Length);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000A473C File Offset: 0x000A293C
		public virtual bool VerifySignature(byte[] signature)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("GenericSigner not initialised for verification");
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			bool result;
			try
			{
				byte[] sig = this.engine.ProcessBlock(signature, 0, signature.Length);
				if (sig.Length < hash.Length)
				{
					byte[] tmp = new byte[hash.Length];
					global::System.Array.Copy(sig, 0, tmp, tmp.Length - sig.Length, sig.Length);
					sig = tmp;
				}
				result = global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(sig, hash);
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000A47D4 File Offset: 0x000A29D4
		public virtual void Reset()
		{
			this.digest.Reset();
		}

		// Token: 0x04000F12 RID: 3858
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;

		// Token: 0x04000F13 RID: 3859
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F14 RID: 3860
		private bool forSigning;
	}
}
