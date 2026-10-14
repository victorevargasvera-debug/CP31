using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AB RID: 939
	public class PssSigner : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06002634 RID: 9780 RVA: 0x000A6609 File Offset: 0x000A4809
		public static global::Org.BouncyCastle.Crypto.Signers.PssSigner CreateRawSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.PssSigner(cipher, new global::Org.BouncyCastle.Crypto.Digests.NullDigest(), digest, digest, digest.GetDigestSize(), null, 188);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000A6624 File Offset: 0x000A4824
		public static global::Org.BouncyCastle.Crypto.Signers.PssSigner CreateRawSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest contentDigest, global::Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte trailer)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.PssSigner(cipher, new global::Org.BouncyCastle.Crypto.Digests.NullDigest(), contentDigest, mgfDigest, saltLen, null, trailer);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000A6637 File Offset: 0x000A4837
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest) : this(cipher, digest, digest.GetDigestSize())
		{
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000A6647 File Offset: 0x000A4847
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, int saltLen) : this(cipher, digest, saltLen, 188)
		{
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000A6657 File Offset: 0x000A4857
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, byte[] salt) : this(cipher, digest, digest, digest, salt.Length, salt, 188)
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000A666C File Offset: 0x000A486C
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest contentDigest, global::Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen) : this(cipher, contentDigest, mgfDigest, saltLen, 188)
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000A667E File Offset: 0x000A487E
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest contentDigest, global::Org.BouncyCastle.Crypto.IDigest mgfDigest, byte[] salt) : this(cipher, contentDigest, contentDigest, mgfDigest, salt.Length, salt, 188)
		{
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000A6695 File Offset: 0x000A4895
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, int saltLen, byte trailer) : this(cipher, digest, digest, saltLen, trailer)
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000A66A3 File Offset: 0x000A48A3
		public PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest contentDigest, global::Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte trailer) : this(cipher, contentDigest, contentDigest, mgfDigest, saltLen, null, trailer)
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000A66B4 File Offset: 0x000A48B4
		private PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest contentDigest1, global::Org.BouncyCastle.Crypto.IDigest contentDigest2, global::Org.BouncyCastle.Crypto.IDigest mgfDigest, int saltLen, byte[] salt, byte trailer)
		{
			this.cipher = cipher;
			this.contentDigest1 = contentDigest1;
			this.contentDigest2 = contentDigest2;
			this.mgfDigest = mgfDigest;
			this.hLen = contentDigest2.GetDigestSize();
			this.mgfhLen = mgfDigest.GetDigestSize();
			this.sLen = saltLen;
			this.sSet = (salt != null);
			if (this.sSet)
			{
				this.salt = salt;
			}
			else
			{
				this.salt = new byte[saltLen];
			}
			this.mDash = new byte[8 + saltLen + this.hLen];
			this.trailer = trailer;
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000A674D File Offset: 0x000A494D
		public virtual string AlgorithmName
		{
			get
			{
				return this.mgfDigest.AlgorithmName + "withRSAandMGF1";
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000A6764 File Offset: 0x000A4964
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom p = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				parameters = p.Parameters;
				this.random = p.Random;
			}
			else if (forSigning)
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			this.cipher.Init(forSigning, parameters);
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.RsaBlindingParameters)
			{
				kParam = ((global::Org.BouncyCastle.Crypto.Parameters.RsaBlindingParameters)parameters).PublicKey;
			}
			else
			{
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
			}
			this.emBits = kParam.Modulus.BitLength - 1;
			if (this.emBits < 8 * this.hLen + 8 * this.sLen + 9)
			{
				throw new global::System.ArgumentException("key too small for specified hash and salt lengths");
			}
			this.block = new byte[(this.emBits + 7) / 8];
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000A681D File Offset: 0x000A4A1D
		private void ClearBlock(byte[] block)
		{
			global::System.Array.Clear(block, 0, block.Length);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000A6829 File Offset: 0x000A4A29
		public virtual void Update(byte input)
		{
			this.contentDigest1.Update(input);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000A6837 File Offset: 0x000A4A37
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.contentDigest1.BlockUpdate(input, inOff, length);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000A6847 File Offset: 0x000A4A47
		public virtual void Reset()
		{
			this.contentDigest1.Reset();
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000A6854 File Offset: 0x000A4A54
		public virtual byte[] GenerateSignature()
		{
			this.contentDigest1.DoFinal(this.mDash, this.mDash.Length - this.hLen - this.sLen);
			if (this.sLen != 0)
			{
				if (!this.sSet)
				{
					this.random.NextBytes(this.salt);
				}
				this.salt.CopyTo(this.mDash, this.mDash.Length - this.sLen);
			}
			byte[] h = new byte[this.hLen];
			this.contentDigest2.BlockUpdate(this.mDash, 0, this.mDash.Length);
			this.contentDigest2.DoFinal(h, 0);
			this.block[this.block.Length - this.sLen - 1 - this.hLen - 1] = 1;
			this.salt.CopyTo(this.block, this.block.Length - this.sLen - this.hLen - 1);
			byte[] dbMask = this.MaskGeneratorFunction(h, 0, h.Length, this.block.Length - this.hLen - 1);
			for (int i = 0; i != dbMask.Length; i++)
			{
				byte[] array = this.block;
				int num = i;
				array[num] ^= dbMask[i];
			}
			h.CopyTo(this.block, this.block.Length - this.hLen - 1);
			uint firstByteMask = 255U >> this.block.Length * 8 - this.emBits;
			byte[] array2 = this.block;
			int num2 = 0;
			array2[num2] &= (byte)firstByteMask;
			this.block[this.block.Length - 1] = this.trailer;
			byte[] result = this.cipher.ProcessBlock(this.block, 0, this.block.Length);
			this.ClearBlock(this.block);
			return result;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000A6A10 File Offset: 0x000A4C10
		public virtual bool VerifySignature(byte[] signature)
		{
			this.contentDigest1.DoFinal(this.mDash, this.mDash.Length - this.hLen - this.sLen);
			byte[] b = this.cipher.ProcessBlock(signature, 0, signature.Length);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.block, 0, this.block.Length - b.Length, 0);
			b.CopyTo(this.block, this.block.Length - b.Length);
			uint firstByteMask = 255U >> this.block.Length * 8 - this.emBits;
			if (this.block[0] != (byte)((uint)this.block[0] & firstByteMask) || this.block[this.block.Length - 1] != this.trailer)
			{
				this.ClearBlock(this.block);
				return false;
			}
			byte[] dbMask = this.MaskGeneratorFunction(this.block, this.block.Length - this.hLen - 1, this.hLen, this.block.Length - this.hLen - 1);
			for (int i = 0; i != dbMask.Length; i++)
			{
				byte[] array = this.block;
				int num = i;
				array[num] ^= dbMask[i];
			}
			byte[] array2 = this.block;
			int num2 = 0;
			array2[num2] &= (byte)firstByteMask;
			for (int j = 0; j != this.block.Length - this.hLen - this.sLen - 2; j++)
			{
				if (this.block[j] != 0)
				{
					this.ClearBlock(this.block);
					return false;
				}
			}
			if (this.block[this.block.Length - this.hLen - this.sLen - 2] != 1)
			{
				this.ClearBlock(this.block);
				return false;
			}
			if (this.sSet)
			{
				global::System.Array.Copy(this.salt, 0, this.mDash, this.mDash.Length - this.sLen, this.sLen);
			}
			else
			{
				global::System.Array.Copy(this.block, this.block.Length - this.sLen - this.hLen - 1, this.mDash, this.mDash.Length - this.sLen, this.sLen);
			}
			this.contentDigest2.BlockUpdate(this.mDash, 0, this.mDash.Length);
			this.contentDigest2.DoFinal(this.mDash, this.mDash.Length - this.hLen);
			int k = this.block.Length - this.hLen - 1;
			for (int l = this.mDash.Length - this.hLen; l != this.mDash.Length; l++)
			{
				if ((this.block[k] ^ this.mDash[l]) != 0)
				{
					this.ClearBlock(this.mDash);
					this.ClearBlock(this.block);
					return false;
				}
				k++;
			}
			this.ClearBlock(this.mDash);
			this.ClearBlock(this.block);
			return true;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000A6CE8 File Offset: 0x000A4EE8
		private void ItoOSP(int i, byte[] sp)
		{
			sp[0] = (byte)((uint)i >> 24);
			sp[1] = (byte)((uint)i >> 16);
			sp[2] = (byte)((uint)i >> 8);
			sp[3] = (byte)i;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000A6D08 File Offset: 0x000A4F08
		private byte[] MaskGeneratorFunction(byte[] Z, int zOff, int zLen, int length)
		{
			if (this.mgfDigest is global::Org.BouncyCastle.Crypto.IXof)
			{
				byte[] mask = new byte[length];
				this.mgfDigest.BlockUpdate(Z, zOff, zLen);
				((global::Org.BouncyCastle.Crypto.IXof)this.mgfDigest).DoFinal(mask, 0, mask.Length);
				return mask;
			}
			return this.MaskGeneratorFunction1(Z, zOff, zLen, length);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000A6D5C File Offset: 0x000A4F5C
		private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			byte[] mask = new byte[length];
			byte[] hashBuf = new byte[this.mgfhLen];
			byte[] C = new byte[4];
			int counter = 0;
			this.mgfDigest.Reset();
			while (counter < length / this.mgfhLen)
			{
				this.ItoOSP(counter, C);
				this.mgfDigest.BlockUpdate(Z, zOff, zLen);
				this.mgfDigest.BlockUpdate(C, 0, C.Length);
				this.mgfDigest.DoFinal(hashBuf, 0);
				hashBuf.CopyTo(mask, counter * this.mgfhLen);
				counter++;
			}
			if (counter * this.mgfhLen < length)
			{
				this.ItoOSP(counter, C);
				this.mgfDigest.BlockUpdate(Z, zOff, zLen);
				this.mgfDigest.BlockUpdate(C, 0, C.Length);
				this.mgfDigest.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, mask, counter * this.mgfhLen, mask.Length - counter * this.mgfhLen);
			}
			return mask;
		}

		// Token: 0x04000F59 RID: 3929
		public const byte TrailerImplicit = 188;

		// Token: 0x04000F5A RID: 3930
		private readonly global::Org.BouncyCastle.Crypto.IDigest contentDigest1;

		// Token: 0x04000F5B RID: 3931
		private readonly global::Org.BouncyCastle.Crypto.IDigest contentDigest2;

		// Token: 0x04000F5C RID: 3932
		private readonly global::Org.BouncyCastle.Crypto.IDigest mgfDigest;

		// Token: 0x04000F5D RID: 3933
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;

		// Token: 0x04000F5E RID: 3934
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000F5F RID: 3935
		private int hLen;

		// Token: 0x04000F60 RID: 3936
		private int mgfhLen;

		// Token: 0x04000F61 RID: 3937
		private int sLen;

		// Token: 0x04000F62 RID: 3938
		private bool sSet;

		// Token: 0x04000F63 RID: 3939
		private int emBits;

		// Token: 0x04000F64 RID: 3940
		private byte[] salt;

		// Token: 0x04000F65 RID: 3941
		private byte[] mDash;

		// Token: 0x04000F66 RID: 3942
		private byte[] block;

		// Token: 0x04000F67 RID: 3943
		private byte trailer;
	}
}
