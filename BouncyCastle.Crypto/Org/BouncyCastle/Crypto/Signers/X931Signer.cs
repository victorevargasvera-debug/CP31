using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003B0 RID: 944
	public class X931Signer : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06002675 RID: 9845 RVA: 0x000A7964 File Offset: 0x000A5B64
		public X931Signer(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, bool isImplicit)
		{
			this.cipher = cipher;
			this.digest = digest;
			if (isImplicit)
			{
				this.trailer = 188;
				return;
			}
			if (global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(digest))
			{
				throw new global::System.ArgumentException("no valid trailer", "digest");
			}
			this.trailer = global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(digest);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x000A79B8 File Offset: 0x000A5BB8
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "with" + this.cipher.AlgorithmName + "/X9.31";
			}
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000A79DF File Offset: 0x000A5BDF
		public X931Signer(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest) : this(cipher, digest, false)
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000A79EC File Offset: 0x000A5BEC
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
			this.cipher.Init(forSigning, this.kParam);
			this.keyBits = this.kParam.Modulus.BitLength;
			this.block = new byte[(this.keyBits + 7) / 8];
			this.Reset();
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000A7A48 File Offset: 0x000A5C48
		private void ClearBlock(byte[] block)
		{
			global::System.Array.Clear(block, 0, block.Length);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000A7A54 File Offset: 0x000A5C54
		public virtual void Update(byte b)
		{
			this.digest.Update(b);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000A7A62 File Offset: 0x000A5C62
		public virtual void BlockUpdate(byte[] input, int off, int len)
		{
			this.digest.BlockUpdate(input, off, len);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000A7A72 File Offset: 0x000A5C72
		public virtual void Reset()
		{
			this.digest.Reset();
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000A7A80 File Offset: 0x000A5C80
		public virtual byte[] GenerateSignature()
		{
			this.CreateSignatureBlock();
			global::Org.BouncyCastle.Math.BigInteger t = new global::Org.BouncyCastle.Math.BigInteger(1, this.cipher.ProcessBlock(this.block, 0, this.block.Length));
			this.ClearBlock(this.block);
			t = t.Min(this.kParam.Modulus.Subtract(t));
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(global::Org.BouncyCastle.Utilities.BigIntegers.GetUnsignedByteLength(this.kParam.Modulus), t);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000A7AF0 File Offset: 0x000A5CF0
		private void CreateSignatureBlock()
		{
			int digSize = this.digest.GetDigestSize();
			int delta;
			if (this.trailer == 188)
			{
				delta = this.block.Length - digSize - 1;
				this.digest.DoFinal(this.block, delta);
				this.block[this.block.Length - 1] = 188;
			}
			else
			{
				delta = this.block.Length - digSize - 2;
				this.digest.DoFinal(this.block, delta);
				this.block[this.block.Length - 2] = (byte)(this.trailer >> 8);
				this.block[this.block.Length - 1] = (byte)this.trailer;
			}
			this.block[0] = 107;
			for (int i = delta - 2; i != 0; i--)
			{
				this.block[i] = 187;
			}
			this.block[delta - 1] = 186;
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000A7BD4 File Offset: 0x000A5DD4
		public virtual bool VerifySignature(byte[] signature)
		{
			try
			{
				this.block = this.cipher.ProcessBlock(signature, 0, signature.Length);
			}
			catch (global::System.Exception)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger t = new global::Org.BouncyCastle.Math.BigInteger(1, this.block);
			global::Org.BouncyCastle.Math.BigInteger f;
			if ((t.IntValue & 15) == 12)
			{
				f = t;
			}
			else
			{
				t = this.kParam.Modulus.Subtract(t);
				if ((t.IntValue & 15) != 12)
				{
					return false;
				}
				f = t;
			}
			this.CreateSignatureBlock();
			byte[] fBlock = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(this.block.Length, f);
			bool result = global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.block, fBlock);
			this.ClearBlock(this.block);
			this.ClearBlock(fBlock);
			return result;
		}

		// Token: 0x04000F77 RID: 3959
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_IMPLICIT = 188;

		// Token: 0x04000F78 RID: 3960
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_RIPEMD160 = 12748;

		// Token: 0x04000F79 RID: 3961
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_RIPEMD128 = 13004;

		// Token: 0x04000F7A RID: 3962
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA1 = 13260;

		// Token: 0x04000F7B RID: 3963
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA256 = 13516;

		// Token: 0x04000F7C RID: 3964
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA512 = 13772;

		// Token: 0x04000F7D RID: 3965
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA384 = 14028;

		// Token: 0x04000F7E RID: 3966
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_WHIRLPOOL = 14284;

		// Token: 0x04000F7F RID: 3967
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TRAILER_SHA224 = 14540;

		// Token: 0x04000F80 RID: 3968
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F81 RID: 3969
		private global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;

		// Token: 0x04000F82 RID: 3970
		private global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam;

		// Token: 0x04000F83 RID: 3971
		private int trailer;

		// Token: 0x04000F84 RID: 3972
		private int keyBits;

		// Token: 0x04000F85 RID: 3973
		private byte[] block;
	}
}
