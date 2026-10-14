using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A7 RID: 935
	public class Iso9796d2PssSigner : global::Org.BouncyCastle.Crypto.ISignerWithRecovery, global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x000A5000 File Offset: 0x000A3200
		public byte[] GetRecoveredMessage()
		{
			return this.recoveredMessage;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000A5008 File Offset: 0x000A3208
		public Iso9796d2PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, int saltLength, bool isImplicit)
		{
			this.cipher = cipher;
			this.digest = digest;
			this.hLen = digest.GetDigestSize();
			this.saltLength = saltLength;
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

		// Token: 0x0600260A RID: 9738 RVA: 0x000A5070 File Offset: 0x000A3270
		public Iso9796d2PssSigner(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, int saltLength) : this(cipher, digest, saltLength, false)
		{
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x000A507C File Offset: 0x000A327C
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "withISO9796-2S2";
			}
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000A5094 File Offset: 0x000A3294
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom p = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)p.Parameters;
				if (forSigning)
				{
					this.random = p.Random;
				}
			}
			else if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSalt)
			{
				if (!forSigning)
				{
					throw new global::System.ArgumentException("ParametersWithSalt only valid for signing", "parameters");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSalt p2 = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSalt)parameters;
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)p2.Parameters;
				this.standardSalt = p2.GetSalt();
				if (this.standardSalt.Length != this.saltLength)
				{
					throw new global::System.ArgumentException("Fixed salt is of wrong length");
				}
			}
			else
			{
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
				if (forSigning)
				{
					this.random = new global::Org.BouncyCastle.Security.SecureRandom();
				}
			}
			this.cipher.Init(forSigning, kParam);
			this.keyBits = kParam.Modulus.BitLength;
			this.block = new byte[(this.keyBits + 7) / 8];
			if (this.trailer == 188)
			{
				this.mBuf = new byte[this.block.Length - this.digest.GetDigestSize() - this.saltLength - 1 - 1];
			}
			else
			{
				this.mBuf = new byte[this.block.Length - this.digest.GetDigestSize() - this.saltLength - 1 - 2];
			}
			this.Reset();
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000A51D4 File Offset: 0x000A33D4
		private bool IsSameAs(byte[] a, byte[] b)
		{
			if (this.messageLength != b.Length)
			{
				return false;
			}
			bool isOkay = true;
			for (int i = 0; i != b.Length; i++)
			{
				if (a[i] != b[i])
				{
					isOkay = false;
				}
			}
			return isOkay;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x000A5209 File Offset: 0x000A3409
		private void ClearBlock(byte[] block)
		{
			global::System.Array.Clear(block, 0, block.Length);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000A5218 File Offset: 0x000A3418
		public virtual void UpdateWithRecoveredMessage(byte[] signature)
		{
			byte[] block = this.cipher.ProcessBlock(signature, 0, signature.Length);
			if (block.Length < (this.keyBits + 7) / 8)
			{
				byte[] tmp = new byte[(this.keyBits + 7) / 8];
				global::System.Array.Copy(block, 0, tmp, tmp.Length - block.Length, block.Length);
				this.ClearBlock(block);
				block = tmp;
			}
			int tLength;
			if (((block[block.Length - 1] & 255) ^ 188) == 0)
			{
				tLength = 1;
			}
			else
			{
				int sigTrail = (int)(block[block.Length - 2] & byte.MaxValue) << 8 | (int)(block[block.Length - 1] & byte.MaxValue);
				if (global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(this.digest))
				{
					throw new global::System.ArgumentException("unrecognised hash in signature");
				}
				if (sigTrail != global::Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(this.digest))
				{
					throw new global::System.InvalidOperationException("signer initialised with wrong digest for trailer " + sigTrail.ToString());
				}
				tLength = 2;
			}
			byte[] m2Hash = new byte[this.hLen];
			this.digest.DoFinal(m2Hash, 0);
			byte[] dbMask = this.MaskGeneratorFunction1(block, block.Length - this.hLen - tLength, this.hLen, block.Length - this.hLen - tLength);
			for (int i = 0; i != dbMask.Length; i++)
			{
				byte[] array = block;
				int num = i;
				array[num] ^= dbMask[i];
			}
			byte[] array2 = block;
			int num2 = 0;
			array2[num2] &= 127;
			int mStart = 0;
			while (mStart < block.Length && block[mStart++] != 1)
			{
			}
			if (mStart >= block.Length)
			{
				this.ClearBlock(block);
			}
			this.fullMessage = (mStart > 1);
			this.recoveredMessage = new byte[dbMask.Length - mStart - this.saltLength];
			global::System.Array.Copy(block, mStart, this.recoveredMessage, 0, this.recoveredMessage.Length);
			this.recoveredMessage.CopyTo(this.mBuf, 0);
			this.preSig = signature;
			this.preBlock = block;
			this.preMStart = mStart;
			this.preTLength = tLength;
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x000A53EC File Offset: 0x000A35EC
		public virtual void Update(byte input)
		{
			if (this.preSig == null && this.messageLength < this.mBuf.Length)
			{
				byte[] array = this.mBuf;
				int num = this.messageLength;
				this.messageLength = num + 1;
				array[num] = input;
				return;
			}
			this.digest.Update(input);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x000A5438 File Offset: 0x000A3638
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			if (this.preSig == null)
			{
				while (length > 0 && this.messageLength < this.mBuf.Length)
				{
					this.Update(input[inOff]);
					inOff++;
					length--;
				}
			}
			if (length > 0)
			{
				this.digest.BlockUpdate(input, inOff, length);
			}
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000A5488 File Offset: 0x000A3688
		public virtual void Reset()
		{
			this.digest.Reset();
			this.messageLength = 0;
			if (this.mBuf != null)
			{
				this.ClearBlock(this.mBuf);
			}
			if (this.recoveredMessage != null)
			{
				this.ClearBlock(this.recoveredMessage);
				this.recoveredMessage = null;
			}
			this.fullMessage = false;
			if (this.preSig != null)
			{
				this.preSig = null;
				this.ClearBlock(this.preBlock);
				this.preBlock = null;
			}
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x000A5500 File Offset: 0x000A3700
		public virtual byte[] GenerateSignature()
		{
			byte[] m2Hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(m2Hash, 0);
			byte[] C = new byte[8];
			this.LtoOSP((long)(this.messageLength * 8), C);
			this.digest.BlockUpdate(C, 0, C.Length);
			this.digest.BlockUpdate(this.mBuf, 0, this.messageLength);
			this.digest.BlockUpdate(m2Hash, 0, m2Hash.Length);
			byte[] salt;
			if (this.standardSalt != null)
			{
				salt = this.standardSalt;
			}
			else
			{
				salt = new byte[this.saltLength];
				this.random.NextBytes(salt);
			}
			this.digest.BlockUpdate(salt, 0, salt.Length);
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			int tLength = 2;
			if (this.trailer == 188)
			{
				tLength = 1;
			}
			int off = this.block.Length - this.messageLength - salt.Length - this.hLen - tLength - 1;
			this.block[off] = 1;
			global::System.Array.Copy(this.mBuf, 0, this.block, off + 1, this.messageLength);
			global::System.Array.Copy(salt, 0, this.block, off + 1 + this.messageLength, salt.Length);
			byte[] dbMask = this.MaskGeneratorFunction1(hash, 0, hash.Length, this.block.Length - this.hLen - tLength);
			for (int i = 0; i != dbMask.Length; i++)
			{
				byte[] array = this.block;
				int num = i;
				array[num] ^= dbMask[i];
			}
			global::System.Array.Copy(hash, 0, this.block, this.block.Length - this.hLen - tLength, this.hLen);
			if (this.trailer == 188)
			{
				this.block[this.block.Length - 1] = 188;
			}
			else
			{
				this.block[this.block.Length - 2] = (byte)((uint)this.trailer >> 8);
				this.block[this.block.Length - 1] = (byte)this.trailer;
			}
			byte[] array2 = this.block;
			int num2 = 0;
			array2[num2] &= 127;
			byte[] result = this.cipher.ProcessBlock(this.block, 0, this.block.Length);
			this.ClearBlock(this.mBuf);
			this.ClearBlock(this.block);
			this.messageLength = 0;
			return result;
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000A575C File Offset: 0x000A395C
		public virtual bool VerifySignature(byte[] signature)
		{
			byte[] m2Hash = new byte[this.hLen];
			this.digest.DoFinal(m2Hash, 0);
			if (this.preSig == null)
			{
				try
				{
					this.UpdateWithRecoveredMessage(signature);
					goto IL_4F;
				}
				catch (global::System.Exception)
				{
					return false;
				}
			}
			if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.preSig, signature))
			{
				throw new global::System.InvalidOperationException("UpdateWithRecoveredMessage called on different signature");
			}
			IL_4F:
			byte[] block = this.preBlock;
			int mStart = this.preMStart;
			int tLength = this.preTLength;
			this.preSig = null;
			this.preBlock = null;
			byte[] C = new byte[8];
			this.LtoOSP((long)(this.recoveredMessage.Length * 8), C);
			this.digest.BlockUpdate(C, 0, C.Length);
			if (this.recoveredMessage.Length != 0)
			{
				this.digest.BlockUpdate(this.recoveredMessage, 0, this.recoveredMessage.Length);
			}
			this.digest.BlockUpdate(m2Hash, 0, m2Hash.Length);
			if (this.standardSalt != null)
			{
				this.digest.BlockUpdate(this.standardSalt, 0, this.standardSalt.Length);
			}
			else
			{
				this.digest.BlockUpdate(block, mStart + this.recoveredMessage.Length, this.saltLength);
			}
			byte[] hash = new byte[this.digest.GetDigestSize()];
			this.digest.DoFinal(hash, 0);
			int off = block.Length - tLength - hash.Length;
			bool isOkay = true;
			for (int i = 0; i != hash.Length; i++)
			{
				if (hash[i] != block[off + i])
				{
					isOkay = false;
				}
			}
			this.ClearBlock(block);
			this.ClearBlock(hash);
			if (!isOkay)
			{
				this.fullMessage = false;
				this.messageLength = 0;
				this.ClearBlock(this.recoveredMessage);
				return false;
			}
			if (this.messageLength != 0 && !this.IsSameAs(this.mBuf, this.recoveredMessage))
			{
				this.messageLength = 0;
				this.ClearBlock(this.mBuf);
				return false;
			}
			this.messageLength = 0;
			this.ClearBlock(this.mBuf);
			return true;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000A5958 File Offset: 0x000A3B58
		public virtual bool HasFullMessage()
		{
			return this.fullMessage;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000A5960 File Offset: 0x000A3B60
		private void ItoOSP(int i, byte[] sp)
		{
			sp[0] = (byte)((uint)i >> 24);
			sp[1] = (byte)((uint)i >> 16);
			sp[2] = (byte)((uint)i >> 8);
			sp[3] = (byte)i;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x000A597E File Offset: 0x000A3B7E
		private void LtoOSP(long l, byte[] sp)
		{
			sp[0] = (byte)((ulong)l >> 56);
			sp[1] = (byte)((ulong)l >> 48);
			sp[2] = (byte)((ulong)l >> 40);
			sp[3] = (byte)((ulong)l >> 32);
			sp[4] = (byte)((ulong)l >> 24);
			sp[5] = (byte)((ulong)l >> 16);
			sp[6] = (byte)((ulong)l >> 8);
			sp[7] = (byte)l;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000A59BC File Offset: 0x000A3BBC
		private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			byte[] mask = new byte[length];
			byte[] hashBuf = new byte[this.hLen];
			byte[] C = new byte[4];
			int counter = 0;
			this.digest.Reset();
			do
			{
				this.ItoOSP(counter, C);
				this.digest.BlockUpdate(Z, zOff, zLen);
				this.digest.BlockUpdate(C, 0, C.Length);
				this.digest.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, mask, counter * this.hLen, this.hLen);
			}
			while (++counter < length / this.hLen);
			if (counter * this.hLen < length)
			{
				this.ItoOSP(counter, C);
				this.digest.BlockUpdate(Z, zOff, zLen);
				this.digest.BlockUpdate(C, 0, C.Length);
				this.digest.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, mask, counter * this.hLen, mask.Length - counter * this.hLen);
			}
			return mask;
		}

		// Token: 0x04000F20 RID: 3872
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerImplicit = 188;

		// Token: 0x04000F21 RID: 3873
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD160 = 12748;

		// Token: 0x04000F22 RID: 3874
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD128 = 13004;

		// Token: 0x04000F23 RID: 3875
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha1 = 13260;

		// Token: 0x04000F24 RID: 3876
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha256 = 13516;

		// Token: 0x04000F25 RID: 3877
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha512 = 13772;

		// Token: 0x04000F26 RID: 3878
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha384 = 14028;

		// Token: 0x04000F27 RID: 3879
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerWhirlpool = 14284;

		// Token: 0x04000F28 RID: 3880
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F29 RID: 3881
		private global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;

		// Token: 0x04000F2A RID: 3882
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000F2B RID: 3883
		private byte[] standardSalt;

		// Token: 0x04000F2C RID: 3884
		private int hLen;

		// Token: 0x04000F2D RID: 3885
		private int trailer;

		// Token: 0x04000F2E RID: 3886
		private int keyBits;

		// Token: 0x04000F2F RID: 3887
		private byte[] block;

		// Token: 0x04000F30 RID: 3888
		private byte[] mBuf;

		// Token: 0x04000F31 RID: 3889
		private int messageLength;

		// Token: 0x04000F32 RID: 3890
		private readonly int saltLength;

		// Token: 0x04000F33 RID: 3891
		private bool fullMessage;

		// Token: 0x04000F34 RID: 3892
		private byte[] recoveredMessage;

		// Token: 0x04000F35 RID: 3893
		private byte[] preSig;

		// Token: 0x04000F36 RID: 3894
		private byte[] preBlock;

		// Token: 0x04000F37 RID: 3895
		private int preMStart;

		// Token: 0x04000F38 RID: 3896
		private int preTLength;
	}
}
