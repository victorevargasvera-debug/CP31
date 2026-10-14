using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x020004C4 RID: 1220
	public class OaepEncoding : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x06002F3D RID: 12093 RVA: 0x000DB844 File Offset: 0x000D9A44
		public OaepEncoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher) : this(cipher, new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest(), null)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000DB853 File Offset: 0x000D9A53
		public OaepEncoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest hash) : this(cipher, hash, null)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000DB85E File Offset: 0x000D9A5E
		public OaepEncoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest hash, byte[] encodingParams) : this(cipher, hash, hash, encodingParams)
		{
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000DB86C File Offset: 0x000D9A6C
		public OaepEncoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, global::Org.BouncyCastle.Crypto.IDigest hash, global::Org.BouncyCastle.Crypto.IDigest mgf1Hash, byte[] encodingParams)
		{
			this.engine = cipher;
			this.mgf1Hash = mgf1Hash;
			this.defHash = new byte[hash.GetDigestSize()];
			hash.Reset();
			if (encodingParams != null)
			{
				hash.BlockUpdate(encodingParams, 0, encodingParams.Length);
			}
			hash.DoFinal(this.defHash, 0);
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000DB8C3 File Offset: 0x000D9AC3
		public global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return this.engine;
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002F42 RID: 12098 RVA: 0x000DB8CB File Offset: 0x000D9ACB
		public string AlgorithmName
		{
			get
			{
				return this.engine.AlgorithmName + "/OAEPPadding";
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000DB8E4 File Offset: 0x000D9AE4
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			if (param is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param;
				this.random = rParam.Random;
			}
			else
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			this.engine.Init(forEncryption, param);
			this.forEncryption = forEncryption;
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000DB930 File Offset: 0x000D9B30
		public int GetInputBlockSize()
		{
			int baseBlockSize = this.engine.GetInputBlockSize();
			if (this.forEncryption)
			{
				return baseBlockSize - 1 - 2 * this.defHash.Length;
			}
			return baseBlockSize;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000DB964 File Offset: 0x000D9B64
		public int GetOutputBlockSize()
		{
			int baseBlockSize = this.engine.GetOutputBlockSize();
			if (this.forEncryption)
			{
				return baseBlockSize;
			}
			return baseBlockSize - 1 - 2 * this.defHash.Length;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000DB995 File Offset: 0x000D9B95
		public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
		{
			if (this.forEncryption)
			{
				return this.EncodeBlock(inBytes, inOff, inLen);
			}
			return this.DecodeBlock(inBytes, inOff, inLen);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000DB9B4 File Offset: 0x000D9BB4
		private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(inLen > this.GetInputBlockSize(), "input data too long");
			byte[] block = new byte[this.GetInputBlockSize() + 1 + 2 * this.defHash.Length];
			global::System.Array.Copy(inBytes, inOff, block, block.Length - inLen, inLen);
			block[block.Length - inLen - 1] = 1;
			global::System.Array.Copy(this.defHash, 0, block, this.defHash.Length, this.defHash.Length);
			byte[] seed = global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(this.random, this.defHash.Length);
			byte[] mask = this.MaskGeneratorFunction(seed, 0, seed.Length, block.Length - this.defHash.Length);
			for (int i = this.defHash.Length; i != block.Length; i++)
			{
				byte[] array = block;
				int num = i;
				array[num] ^= mask[i - this.defHash.Length];
			}
			global::System.Array.Copy(seed, 0, block, 0, this.defHash.Length);
			mask = this.MaskGeneratorFunction(block, this.defHash.Length, block.Length - this.defHash.Length, this.defHash.Length);
			for (int j = 0; j != this.defHash.Length; j++)
			{
				byte[] array2 = block;
				int num2 = j;
				array2[num2] ^= mask[j];
			}
			return this.engine.ProcessBlock(block, 0, block.Length);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000DBAE8 File Offset: 0x000D9CE8
		private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
		{
			byte[] data = this.engine.ProcessBlock(inBytes, inOff, inLen);
			byte[] block = new byte[this.engine.GetOutputBlockSize()];
			bool wrongData = block.Length < 2 * this.defHash.Length + 1;
			if (data.Length <= block.Length)
			{
				global::System.Array.Copy(data, 0, block, block.Length - data.Length, data.Length);
			}
			else
			{
				global::System.Array.Copy(data, 0, block, 0, block.Length);
				wrongData = true;
			}
			byte[] mask = this.MaskGeneratorFunction(block, this.defHash.Length, block.Length - this.defHash.Length, this.defHash.Length);
			for (int i = 0; i != this.defHash.Length; i++)
			{
				byte[] array = block;
				int num = i;
				array[num] ^= mask[i];
			}
			mask = this.MaskGeneratorFunction(block, 0, this.defHash.Length, block.Length - this.defHash.Length);
			for (int j = this.defHash.Length; j != block.Length; j++)
			{
				byte[] array2 = block;
				int num2 = j;
				array2[num2] ^= mask[j - this.defHash.Length];
			}
			bool defHashWrong = false;
			for (int k = 0; k != this.defHash.Length; k++)
			{
				if (this.defHash[k] != block[this.defHash.Length + k])
				{
					defHashWrong = true;
				}
			}
			int start = block.Length;
			for (int index = 2 * this.defHash.Length; index != block.Length; index++)
			{
				if (block[index] > 0 & start == block.Length)
				{
					start = index;
				}
			}
			bool dataStartWrong = start > block.Length - 1 | block[start] != 1;
			start++;
			if (defHashWrong || wrongData || dataStartWrong)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(block, 0);
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("data wrong");
			}
			byte[] output = new byte[block.Length - start];
			global::System.Array.Copy(block, start, output, 0, output.Length);
			global::System.Array.Clear(block, 0, block.Length);
			return output;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000DBCB8 File Offset: 0x000D9EB8
		private byte[] MaskGeneratorFunction(byte[] Z, int zOff, int zLen, int length)
		{
			if (this.mgf1Hash is global::Org.BouncyCastle.Crypto.IXof)
			{
				byte[] mask = new byte[length];
				this.mgf1Hash.BlockUpdate(Z, zOff, zLen);
				((global::Org.BouncyCastle.Crypto.IXof)this.mgf1Hash).DoFinal(mask, 0, mask.Length);
				return mask;
			}
			return this.MaskGeneratorFunction1(Z, zOff, zLen, length);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000DBD0C File Offset: 0x000D9F0C
		private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			byte[] mask = new byte[length];
			byte[] hashBuf = new byte[this.mgf1Hash.GetDigestSize()];
			byte[] C = new byte[4];
			int counter = 0;
			this.mgf1Hash.Reset();
			while (counter < length / hashBuf.Length)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)counter, C);
				this.mgf1Hash.BlockUpdate(Z, zOff, zLen);
				this.mgf1Hash.BlockUpdate(C, 0, C.Length);
				this.mgf1Hash.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, mask, counter * hashBuf.Length, hashBuf.Length);
				counter++;
			}
			if (counter * hashBuf.Length < length)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)counter, C);
				this.mgf1Hash.BlockUpdate(Z, zOff, zLen);
				this.mgf1Hash.BlockUpdate(C, 0, C.Length);
				this.mgf1Hash.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, mask, counter * hashBuf.Length, mask.Length - counter * hashBuf.Length);
			}
			return mask;
		}

		// Token: 0x0400144C RID: 5196
		private byte[] defHash;

		// Token: 0x0400144D RID: 5197
		private global::Org.BouncyCastle.Crypto.IDigest mgf1Hash;

		// Token: 0x0400144E RID: 5198
		private global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;

		// Token: 0x0400144F RID: 5199
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001450 RID: 5200
		private bool forEncryption;
	}
}
