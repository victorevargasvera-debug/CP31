using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000498 RID: 1176
	public class DesEdeWrapEngine : global::Org.BouncyCastle.Crypto.IWrapper
	{
		// Token: 0x06002D3D RID: 11581 RVA: 0x000C99F8 File Offset: 0x000C7BF8
		public virtual void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forWrapping = forWrapping;
			this.engine = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
			global::Org.BouncyCastle.Security.SecureRandom sr;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom parametersWithRandom = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				parameters = parametersWithRandom.Parameters;
				sr = parametersWithRandom.Random;
			}
			else
			{
				sr = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
				if (this.forWrapping)
				{
					this.iv = new byte[8];
					sr.NextBytes(this.iv);
					this.paramPlusIV = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param, this.iv);
					return;
				}
			}
			else if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				if (!forWrapping)
				{
					throw new global::System.ArgumentException("You should not supply an IV for unwrapping");
				}
				this.paramPlusIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				this.iv = this.paramPlusIV.GetIV();
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)this.paramPlusIV.Parameters;
				if (this.iv.Length != 8)
				{
					throw new global::System.ArgumentException("IV is not 8 octets", "parameters");
				}
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000C9AF3 File Offset: 0x000C7CF3
		public virtual string AlgorithmName
		{
			get
			{
				return "DESede";
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000C9AFC File Offset: 0x000C7CFC
		public virtual byte[] Wrap(byte[] input, int inOff, int length)
		{
			if (!this.forWrapping)
			{
				throw new global::System.InvalidOperationException("Not initialized for wrapping");
			}
			byte[] keyToBeWrapped = new byte[length];
			global::System.Array.Copy(input, inOff, keyToBeWrapped, 0, length);
			byte[] CKS = this.CalculateCmsKeyChecksum(keyToBeWrapped);
			byte[] WKCKS = new byte[keyToBeWrapped.Length + CKS.Length];
			global::System.Array.Copy(keyToBeWrapped, 0, WKCKS, 0, keyToBeWrapped.Length);
			global::System.Array.Copy(CKS, 0, WKCKS, keyToBeWrapped.Length, CKS.Length);
			int blockSize = this.engine.GetBlockSize();
			if (WKCKS.Length % blockSize != 0)
			{
				throw new global::System.InvalidOperationException("Not multiple of block length");
			}
			this.engine.Init(true, this.paramPlusIV);
			byte[] TEMP = new byte[WKCKS.Length];
			for (int currentBytePos = 0; currentBytePos != WKCKS.Length; currentBytePos += blockSize)
			{
				this.engine.ProcessBlock(WKCKS, currentBytePos, TEMP, currentBytePos);
			}
			byte[] TEMP2 = new byte[this.iv.Length + TEMP.Length];
			global::System.Array.Copy(this.iv, 0, TEMP2, 0, this.iv.Length);
			global::System.Array.Copy(TEMP, 0, TEMP2, this.iv.Length, TEMP.Length);
			byte[] TEMP3 = global::Org.BouncyCastle.Crypto.Engines.DesEdeWrapEngine.reverse(TEMP2);
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param2 = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param, global::Org.BouncyCastle.Crypto.Engines.DesEdeWrapEngine.IV2);
			this.engine.Init(true, param2);
			for (int currentBytePos2 = 0; currentBytePos2 != TEMP3.Length; currentBytePos2 += blockSize)
			{
				this.engine.ProcessBlock(TEMP3, currentBytePos2, TEMP3, currentBytePos2);
			}
			return TEMP3;
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000C9C50 File Offset: 0x000C7E50
		public virtual byte[] Unwrap(byte[] input, int inOff, int length)
		{
			if (this.forWrapping)
			{
				throw new global::System.InvalidOperationException("Not set for unwrapping");
			}
			if (input == null)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Null pointer as ciphertext");
			}
			int blockSize = this.engine.GetBlockSize();
			if (length % blockSize != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Ciphertext not multiple of " + blockSize.ToString());
			}
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param2 = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param, global::Org.BouncyCastle.Crypto.Engines.DesEdeWrapEngine.IV2);
			this.engine.Init(false, param2);
			byte[] TEMP3 = new byte[length];
			for (int currentBytePos = 0; currentBytePos != TEMP3.Length; currentBytePos += blockSize)
			{
				this.engine.ProcessBlock(input, inOff + currentBytePos, TEMP3, currentBytePos);
			}
			byte[] TEMP4 = global::Org.BouncyCastle.Crypto.Engines.DesEdeWrapEngine.reverse(TEMP3);
			this.iv = new byte[8];
			byte[] TEMP5 = new byte[TEMP4.Length - 8];
			global::System.Array.Copy(TEMP4, 0, this.iv, 0, 8);
			global::System.Array.Copy(TEMP4, 8, TEMP5, 0, TEMP4.Length - 8);
			this.paramPlusIV = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param, this.iv);
			this.engine.Init(false, this.paramPlusIV);
			byte[] WKCKS = new byte[TEMP5.Length];
			for (int currentBytePos2 = 0; currentBytePos2 != WKCKS.Length; currentBytePos2 += blockSize)
			{
				this.engine.ProcessBlock(TEMP5, currentBytePos2, WKCKS, currentBytePos2);
			}
			byte[] result = new byte[WKCKS.Length - 8];
			byte[] CKStoBeVerified = new byte[8];
			global::System.Array.Copy(WKCKS, 0, result, 0, WKCKS.Length - 8);
			global::System.Array.Copy(WKCKS, WKCKS.Length - 8, CKStoBeVerified, 0, 8);
			if (!this.CheckCmsKeyChecksum(result, CKStoBeVerified))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Checksum inside ciphertext is corrupted");
			}
			return result;
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x000C9DDC File Offset: 0x000C7FDC
		private byte[] CalculateCmsKeyChecksum(byte[] key)
		{
			this.sha1.BlockUpdate(key, 0, key.Length);
			this.sha1.DoFinal(this.digest, 0);
			byte[] result = new byte[8];
			global::System.Array.Copy(this.digest, 0, result, 0, 8);
			return result;
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000C9E23 File Offset: 0x000C8023
		private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.CalculateCmsKeyChecksum(key), checksum);
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000C9E34 File Offset: 0x000C8034
		private static byte[] reverse(byte[] bs)
		{
			byte[] result = new byte[bs.Length];
			for (int i = 0; i < bs.Length; i++)
			{
				result[i] = bs[bs.Length - (i + 1)];
			}
			return result;
		}

		// Token: 0x040012F9 RID: 4857
		private global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine;

		// Token: 0x040012FA RID: 4858
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter param;

		// Token: 0x040012FB RID: 4859
		private global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV paramPlusIV;

		// Token: 0x040012FC RID: 4860
		private byte[] iv;

		// Token: 0x040012FD RID: 4861
		private bool forWrapping;

		// Token: 0x040012FE RID: 4862
		private static readonly byte[] IV2 = new byte[]
		{
			74,
			221,
			162,
			44,
			121,
			232,
			33,
			5
		};

		// Token: 0x040012FF RID: 4863
		private readonly global::Org.BouncyCastle.Crypto.IDigest sha1 = new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();

		// Token: 0x04001300 RID: 4864
		private readonly byte[] digest = new byte[20];
	}
}
