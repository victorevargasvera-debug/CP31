using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A8 RID: 936
	public class Iso9796d2Signer : global::Org.BouncyCastle.Crypto.ISignerWithRecovery, global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06002619 RID: 9753 RVA: 0x000A5AA8 File Offset: 0x000A3CA8
		public byte[] GetRecoveredMessage()
		{
			return this.recoveredMessage;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x000A5AB0 File Offset: 0x000A3CB0
		public Iso9796d2Signer(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest, bool isImplicit)
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

		// Token: 0x0600261B RID: 9755 RVA: 0x000A5B04 File Offset: 0x000A3D04
		public Iso9796d2Signer(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest digest) : this(cipher, digest, false)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000A5B0F File Offset: 0x000A3D0F
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "withISO9796-2S1";
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000A5B28 File Offset: 0x000A3D28
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
			this.cipher.Init(forSigning, kParam);
			this.keyBits = kParam.Modulus.BitLength;
			this.block = new byte[(this.keyBits + 7) / 8];
			if (this.trailer == 188)
			{
				this.mBuf = new byte[this.block.Length - this.digest.GetDigestSize() - 2];
			}
			else
			{
				this.mBuf = new byte[this.block.Length - this.digest.GetDigestSize() - 3];
			}
			this.Reset();
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000A5BC8 File Offset: 0x000A3DC8
		private bool IsSameAs(byte[] a, byte[] b)
		{
			int checkLen;
			if (this.messageLength > this.mBuf.Length)
			{
				if (this.mBuf.Length > b.Length)
				{
					return false;
				}
				checkLen = this.mBuf.Length;
			}
			else
			{
				if (this.messageLength != b.Length)
				{
					return false;
				}
				checkLen = b.Length;
			}
			bool isOkay = true;
			for (int i = 0; i != checkLen; i++)
			{
				if (a[i] != b[i])
				{
					isOkay = false;
				}
			}
			return isOkay;
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000A5C29 File Offset: 0x000A3E29
		private void ClearBlock(byte[] block)
		{
			global::System.Array.Clear(block, 0, block.Length);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000A5C38 File Offset: 0x000A3E38
		public virtual void UpdateWithRecoveredMessage(byte[] signature)
		{
			byte[] block = this.cipher.ProcessBlock(signature, 0, signature.Length);
			if (((block[0] & 192) ^ 64) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("malformed signature");
			}
			if (((block[block.Length - 1] & 15) ^ 12) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("malformed signature");
			}
			int delta;
			if (((block[block.Length - 1] & 255) ^ 188) == 0)
			{
				delta = 1;
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
				delta = 2;
			}
			int mStart = 0;
			while (mStart != block.Length && ((block[mStart] & 15) ^ 10) != 0)
			{
				mStart++;
			}
			mStart++;
			int off = block.Length - delta - this.digest.GetDigestSize();
			if (off - mStart <= 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("malformed block");
			}
			if ((block[0] & 32) == 0)
			{
				this.fullMessage = true;
				this.recoveredMessage = new byte[off - mStart];
				global::System.Array.Copy(block, mStart, this.recoveredMessage, 0, this.recoveredMessage.Length);
			}
			else
			{
				this.fullMessage = false;
				this.recoveredMessage = new byte[off - mStart];
				global::System.Array.Copy(block, mStart, this.recoveredMessage, 0, this.recoveredMessage.Length);
			}
			this.preSig = signature;
			this.preBlock = block;
			this.digest.BlockUpdate(this.recoveredMessage, 0, this.recoveredMessage.Length);
			this.messageLength = this.recoveredMessage.Length;
			this.recoveredMessage.CopyTo(this.mBuf, 0);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000A5DED File Offset: 0x000A3FED
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
			if (this.messageLength < this.mBuf.Length)
			{
				this.mBuf[this.messageLength] = input;
			}
			this.messageLength++;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000A5E28 File Offset: 0x000A4028
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (length > 0 && this.messageLength < this.mBuf.Length)
			{
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
			this.digest.BlockUpdate(input, inOff, length);
			this.messageLength += length;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000A5E7C File Offset: 0x000A407C
		public virtual void Reset()
		{
			this.digest.Reset();
			this.messageLength = 0;
			this.ClearBlock(this.mBuf);
			if (this.recoveredMessage != null)
			{
				this.ClearBlock(this.recoveredMessage);
			}
			this.recoveredMessage = null;
			this.fullMessage = false;
			if (this.preSig != null)
			{
				this.preSig = null;
				this.ClearBlock(this.preBlock);
				this.preBlock = null;
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000A5EEC File Offset: 0x000A40EC
		public virtual byte[] GenerateSignature()
		{
			int digSize = this.digest.GetDigestSize();
			int t;
			int delta;
			if (this.trailer == 188)
			{
				t = 8;
				delta = this.block.Length - digSize - 1;
				this.digest.DoFinal(this.block, delta);
				this.block[this.block.Length - 1] = 188;
			}
			else
			{
				t = 16;
				delta = this.block.Length - digSize - 2;
				this.digest.DoFinal(this.block, delta);
				this.block[this.block.Length - 2] = (byte)((uint)this.trailer >> 8);
				this.block[this.block.Length - 1] = (byte)this.trailer;
			}
			int x = (digSize + this.messageLength) * 8 + t + 4 - this.keyBits;
			byte header;
			if (x > 0)
			{
				int mR = this.messageLength - (x + 7) / 8;
				header = 96;
				delta -= mR;
				global::System.Array.Copy(this.mBuf, 0, this.block, delta, mR);
			}
			else
			{
				header = 64;
				delta -= this.messageLength;
				global::System.Array.Copy(this.mBuf, 0, this.block, delta, this.messageLength);
			}
			if (delta - 1 > 0)
			{
				for (int i = delta - 1; i != 0; i--)
				{
					this.block[i] = 187;
				}
				byte[] array = this.block;
				int num = delta - 1;
				array[num] ^= 1;
				this.block[0] = 11;
				byte[] array2 = this.block;
				int num2 = 0;
				array2[num2] |= header;
			}
			else
			{
				this.block[0] = 10;
				byte[] array3 = this.block;
				int num3 = 0;
				array3[num3] |= header;
			}
			byte[] result = this.cipher.ProcessBlock(this.block, 0, this.block.Length);
			this.messageLength = 0;
			this.ClearBlock(this.mBuf);
			this.ClearBlock(this.block);
			return result;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000A60C4 File Offset: 0x000A42C4
		public virtual bool VerifySignature(byte[] signature)
		{
			byte[] block;
			if (this.preSig == null)
			{
				try
				{
					block = this.cipher.ProcessBlock(signature, 0, signature.Length);
					goto IL_52;
				}
				catch (global::System.Exception)
				{
					return false;
				}
			}
			if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.preSig, signature))
			{
				throw new global::System.InvalidOperationException("updateWithRecoveredMessage called on different signature");
			}
			block = this.preBlock;
			this.preSig = null;
			this.preBlock = null;
			IL_52:
			if (((block[0] & 192) ^ 64) != 0)
			{
				return this.ReturnFalse(block);
			}
			if (((block[block.Length - 1] & 15) ^ 12) != 0)
			{
				return this.ReturnFalse(block);
			}
			int delta;
			if (((block[block.Length - 1] & 255) ^ 188) == 0)
			{
				delta = 1;
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
				delta = 2;
			}
			int mStart = 0;
			while (mStart != block.Length && ((block[mStart] & 15) ^ 10) != 0)
			{
				mStart++;
			}
			mStart++;
			byte[] hash = new byte[this.digest.GetDigestSize()];
			int off = block.Length - delta - hash.Length;
			if (off - mStart <= 0)
			{
				return this.ReturnFalse(block);
			}
			if ((block[0] & 32) == 0)
			{
				this.fullMessage = true;
				if (this.messageLength > off - mStart)
				{
					return this.ReturnFalse(block);
				}
				this.digest.Reset();
				this.digest.BlockUpdate(block, mStart, off - mStart);
				this.digest.DoFinal(hash, 0);
				bool isOkay = true;
				for (int i = 0; i != hash.Length; i++)
				{
					byte[] array = block;
					int num = off + i;
					array[num] ^= hash[i];
					if (block[off + i] != 0)
					{
						isOkay = false;
					}
				}
				if (!isOkay)
				{
					return this.ReturnFalse(block);
				}
				this.recoveredMessage = new byte[off - mStart];
				global::System.Array.Copy(block, mStart, this.recoveredMessage, 0, this.recoveredMessage.Length);
			}
			else
			{
				this.fullMessage = false;
				this.digest.DoFinal(hash, 0);
				bool isOkay2 = true;
				for (int j = 0; j != hash.Length; j++)
				{
					byte[] array2 = block;
					int num2 = off + j;
					array2[num2] ^= hash[j];
					if (block[off + j] != 0)
					{
						isOkay2 = false;
					}
				}
				if (!isOkay2)
				{
					return this.ReturnFalse(block);
				}
				this.recoveredMessage = new byte[off - mStart];
				global::System.Array.Copy(block, mStart, this.recoveredMessage, 0, this.recoveredMessage.Length);
			}
			if (this.messageLength != 0 && !this.IsSameAs(this.mBuf, this.recoveredMessage))
			{
				return this.ReturnFalse(block);
			}
			this.ClearBlock(this.mBuf);
			this.ClearBlock(block);
			this.messageLength = 0;
			return true;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000A6398 File Offset: 0x000A4598
		private bool ReturnFalse(byte[] block)
		{
			this.messageLength = 0;
			this.ClearBlock(this.mBuf);
			this.ClearBlock(block);
			return false;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000A63B5 File Offset: 0x000A45B5
		public virtual bool HasFullMessage()
		{
			return this.fullMessage;
		}

		// Token: 0x04000F39 RID: 3897
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerImplicit = 188;

		// Token: 0x04000F3A RID: 3898
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD160 = 12748;

		// Token: 0x04000F3B RID: 3899
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD128 = 13004;

		// Token: 0x04000F3C RID: 3900
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha1 = 13260;

		// Token: 0x04000F3D RID: 3901
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha256 = 13516;

		// Token: 0x04000F3E RID: 3902
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha512 = 13772;

		// Token: 0x04000F3F RID: 3903
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha384 = 14028;

		// Token: 0x04000F40 RID: 3904
		[global::System.Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerWhirlpool = 14284;

		// Token: 0x04000F41 RID: 3905
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F42 RID: 3906
		private global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;

		// Token: 0x04000F43 RID: 3907
		private int trailer;

		// Token: 0x04000F44 RID: 3908
		private int keyBits;

		// Token: 0x04000F45 RID: 3909
		private byte[] block;

		// Token: 0x04000F46 RID: 3910
		private byte[] mBuf;

		// Token: 0x04000F47 RID: 3911
		private int messageLength;

		// Token: 0x04000F48 RID: 3912
		private bool fullMessage;

		// Token: 0x04000F49 RID: 3913
		private byte[] recoveredMessage;

		// Token: 0x04000F4A RID: 3914
		private byte[] preSig;

		// Token: 0x04000F4B RID: 3915
		private byte[] preBlock;
	}
}
