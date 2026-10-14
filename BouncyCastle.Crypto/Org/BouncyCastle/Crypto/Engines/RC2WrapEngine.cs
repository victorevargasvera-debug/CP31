using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A7 RID: 1191
	public class RC2WrapEngine : global::Org.BouncyCastle.Crypto.IWrapper
	{
		// Token: 0x06002DF2 RID: 11762 RVA: 0x000CF6D8 File Offset: 0x000CD8D8
		public virtual void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forWrapping = forWrapping;
			this.engine = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine());
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom pWithR = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				this.sr = pWithR.Random;
				parameters = pWithR.Parameters;
			}
			else
			{
				this.sr = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				if (!forWrapping)
				{
					throw new global::System.ArgumentException("You should not supply an IV for unwrapping");
				}
				this.paramPlusIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				this.iv = this.paramPlusIV.GetIV();
				this.parameters = this.paramPlusIV.Parameters;
				if (this.iv.Length != 8)
				{
					throw new global::System.ArgumentException("IV is not 8 octets");
				}
			}
			else
			{
				this.parameters = parameters;
				if (this.forWrapping)
				{
					this.iv = new byte[8];
					this.sr.NextBytes(this.iv);
					this.paramPlusIV = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.parameters, this.iv);
				}
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000CF7C9 File Offset: 0x000CD9C9
		public virtual string AlgorithmName
		{
			get
			{
				return "RC2";
			}
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000CF7D0 File Offset: 0x000CD9D0
		public virtual byte[] Wrap(byte[] input, int inOff, int length)
		{
			if (!this.forWrapping)
			{
				throw new global::System.InvalidOperationException("Not initialized for wrapping");
			}
			int len = length + 1;
			if (len % 8 != 0)
			{
				len += 8 - len % 8;
			}
			byte[] keyToBeWrapped = new byte[len];
			keyToBeWrapped[0] = (byte)length;
			global::System.Array.Copy(input, inOff, keyToBeWrapped, 1, length);
			byte[] pad = new byte[keyToBeWrapped.Length - length - 1];
			if (pad.Length != 0)
			{
				this.sr.NextBytes(pad);
				global::System.Array.Copy(pad, 0, keyToBeWrapped, length + 1, pad.Length);
			}
			byte[] CKS = this.CalculateCmsKeyChecksum(keyToBeWrapped);
			byte[] WKCKS = new byte[keyToBeWrapped.Length + CKS.Length];
			global::System.Array.Copy(keyToBeWrapped, 0, WKCKS, 0, keyToBeWrapped.Length);
			global::System.Array.Copy(CKS, 0, WKCKS, keyToBeWrapped.Length, CKS.Length);
			byte[] TEMP = new byte[WKCKS.Length];
			global::System.Array.Copy(WKCKS, 0, TEMP, 0, WKCKS.Length);
			int noOfBlocks = WKCKS.Length / this.engine.GetBlockSize();
			if (WKCKS.Length % this.engine.GetBlockSize() != 0)
			{
				throw new global::System.InvalidOperationException("Not multiple of block length");
			}
			this.engine.Init(true, this.paramPlusIV);
			for (int i = 0; i < noOfBlocks; i++)
			{
				int currentBytePos = i * this.engine.GetBlockSize();
				this.engine.ProcessBlock(TEMP, currentBytePos, TEMP, currentBytePos);
			}
			byte[] TEMP2 = new byte[this.iv.Length + TEMP.Length];
			global::System.Array.Copy(this.iv, 0, TEMP2, 0, this.iv.Length);
			global::System.Array.Copy(TEMP, 0, TEMP2, this.iv.Length, TEMP.Length);
			byte[] TEMP3 = new byte[TEMP2.Length];
			for (int j = 0; j < TEMP2.Length; j++)
			{
				TEMP3[j] = TEMP2[TEMP2.Length - (j + 1)];
			}
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param2 = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.parameters, global::Org.BouncyCastle.Crypto.Engines.RC2WrapEngine.IV2);
			this.engine.Init(true, param2);
			for (int k = 0; k < noOfBlocks + 1; k++)
			{
				int currentBytePos2 = k * this.engine.GetBlockSize();
				this.engine.ProcessBlock(TEMP3, currentBytePos2, TEMP3, currentBytePos2);
			}
			return TEMP3;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x000CF9D0 File Offset: 0x000CDBD0
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
			if (length % this.engine.GetBlockSize() != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Ciphertext not multiple of " + this.engine.GetBlockSize().ToString());
			}
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param2 = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.parameters, global::Org.BouncyCastle.Crypto.Engines.RC2WrapEngine.IV2);
			this.engine.Init(false, param2);
			byte[] TEMP3 = new byte[length];
			global::System.Array.Copy(input, inOff, TEMP3, 0, length);
			for (int i = 0; i < TEMP3.Length / this.engine.GetBlockSize(); i++)
			{
				int currentBytePos = i * this.engine.GetBlockSize();
				this.engine.ProcessBlock(TEMP3, currentBytePos, TEMP3, currentBytePos);
			}
			byte[] TEMP4 = new byte[TEMP3.Length];
			for (int j = 0; j < TEMP3.Length; j++)
			{
				TEMP4[j] = TEMP3[TEMP3.Length - (j + 1)];
			}
			this.iv = new byte[8];
			byte[] TEMP5 = new byte[TEMP4.Length - 8];
			global::System.Array.Copy(TEMP4, 0, this.iv, 0, 8);
			global::System.Array.Copy(TEMP4, 8, TEMP5, 0, TEMP4.Length - 8);
			this.paramPlusIV = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.parameters, this.iv);
			this.engine.Init(false, this.paramPlusIV);
			byte[] LCEKPADICV = new byte[TEMP5.Length];
			global::System.Array.Copy(TEMP5, 0, LCEKPADICV, 0, TEMP5.Length);
			for (int k = 0; k < LCEKPADICV.Length / this.engine.GetBlockSize(); k++)
			{
				int currentBytePos2 = k * this.engine.GetBlockSize();
				this.engine.ProcessBlock(LCEKPADICV, currentBytePos2, LCEKPADICV, currentBytePos2);
			}
			byte[] result = new byte[LCEKPADICV.Length - 8];
			byte[] CKStoBeVerified = new byte[8];
			global::System.Array.Copy(LCEKPADICV, 0, result, 0, LCEKPADICV.Length - 8);
			global::System.Array.Copy(LCEKPADICV, LCEKPADICV.Length - 8, CKStoBeVerified, 0, 8);
			if (!this.CheckCmsKeyChecksum(result, CKStoBeVerified))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("Checksum inside ciphertext is corrupted");
			}
			if (result.Length - (int)((result[0] & 255) + 1) > 7)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("too many pad bytes (" + (result.Length - (int)((result[0] & byte.MaxValue) + 1)).ToString() + ")");
			}
			byte[] CEK = new byte[(int)result[0]];
			global::System.Array.Copy(result, 1, CEK, 0, CEK.Length);
			return CEK;
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000CFC30 File Offset: 0x000CDE30
		private byte[] CalculateCmsKeyChecksum(byte[] key)
		{
			this.sha1.BlockUpdate(key, 0, key.Length);
			this.sha1.DoFinal(this.digest, 0);
			byte[] result = new byte[8];
			global::System.Array.Copy(this.digest, 0, result, 0, 8);
			return result;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000CFC77 File Offset: 0x000CDE77
		private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.CalculateCmsKeyChecksum(key), checksum);
		}

		// Token: 0x0400136F RID: 4975
		private global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine;

		// Token: 0x04001370 RID: 4976
		private global::Org.BouncyCastle.Crypto.ICipherParameters parameters;

		// Token: 0x04001371 RID: 4977
		private global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV paramPlusIV;

		// Token: 0x04001372 RID: 4978
		private byte[] iv;

		// Token: 0x04001373 RID: 4979
		private bool forWrapping;

		// Token: 0x04001374 RID: 4980
		private global::Org.BouncyCastle.Security.SecureRandom sr;

		// Token: 0x04001375 RID: 4981
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

		// Token: 0x04001376 RID: 4982
		private global::Org.BouncyCastle.Crypto.IDigest sha1 = new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();

		// Token: 0x04001377 RID: 4983
		private byte[] digest = new byte[20];
	}
}
