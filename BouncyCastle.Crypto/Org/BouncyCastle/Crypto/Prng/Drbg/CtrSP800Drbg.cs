using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Prng.Drbg
{
	// Token: 0x020003C0 RID: 960
	public class CtrSP800Drbg : global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg
	{
		// Token: 0x060026CB RID: 9931 RVA: 0x000A8C10 File Offset: 0x000A6E10
		public CtrSP800Drbg(global::Org.BouncyCastle.Crypto.IBlockCipher engine, int keySizeInBits, int securityStrength, global::Org.BouncyCastle.Crypto.IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
		{
			if (securityStrength > 256)
			{
				throw new global::System.ArgumentException("Requested security strength is not supported by the derivation function");
			}
			if (this.GetMaxSecurityStrength(engine, keySizeInBits) < securityStrength)
			{
				throw new global::System.ArgumentException("Requested security strength is not supported by block cipher and key size");
			}
			if (entropySource.EntropySize < securityStrength)
			{
				throw new global::System.ArgumentException("Not enough entropy for security strength required");
			}
			this.mEntropySource = entropySource;
			this.mEngine = engine;
			this.mKeySizeInBits = keySizeInBits;
			this.mSecurityStrength = securityStrength;
			this.mSeedLength = keySizeInBits + engine.GetBlockSize() * 8;
			this.mIsTdea = this.IsTdea(engine);
			byte[] entropy = this.GetEntropy();
			this.CTR_DRBG_Instantiate_algorithm(entropy, nonce, personalizationString);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000A8CB0 File Offset: 0x000A6EB0
		private void CTR_DRBG_Instantiate_algorithm(byte[] entropy, byte[] nonce, byte[] personalisationString)
		{
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				entropy,
				nonce,
				personalisationString
			});
			byte[] seed = this.Block_Cipher_df(seedMaterial, this.mSeedLength);
			int outlen = this.mEngine.GetBlockSize();
			this.mKey = new byte[(this.mKeySizeInBits + 7) / 8];
			this.mV = new byte[outlen];
			this.CTR_DRBG_Update(seed, this.mKey, this.mV);
			this.mReseedCounter = 1L;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000A8D2C File Offset: 0x000A6F2C
		private void CTR_DRBG_Update(byte[] seed, byte[] key, byte[] v)
		{
			byte[] temp = new byte[seed.Length];
			byte[] outputBlock = new byte[this.mEngine.GetBlockSize()];
			int i = 0;
			int outLen = this.mEngine.GetBlockSize();
			this.mEngine.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.ExpandKey(key)));
			while (i * outLen < seed.Length)
			{
				this.AddOneTo(v);
				this.mEngine.ProcessBlock(v, 0, outputBlock, 0);
				int bytesToCopy = (temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen);
				global::System.Array.Copy(outputBlock, 0, temp, i * outLen, bytesToCopy);
				i++;
			}
			this.XOR(temp, seed, temp, 0);
			global::System.Array.Copy(temp, 0, key, 0, key.Length);
			global::System.Array.Copy(temp, key.Length, v, 0, v.Length);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000A8DE8 File Offset: 0x000A6FE8
		private void CTR_DRBG_Reseed_algorithm(byte[] additionalInput)
		{
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(this.GetEntropy(), additionalInput);
			seedMaterial = this.Block_Cipher_df(seedMaterial, this.mSeedLength);
			this.CTR_DRBG_Update(seedMaterial, this.mKey, this.mV);
			this.mReseedCounter = 1L;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000A8E2C File Offset: 0x000A702C
		private void XOR(byte[] output, byte[] a, byte[] b, int bOff)
		{
			for (int i = 0; i < output.Length; i++)
			{
				output[i] = (a[i] ^ b[bOff + i]);
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000A8E58 File Offset: 0x000A7058
		private void AddOneTo(byte[] longer)
		{
			uint carry = 1U;
			int i = longer.Length;
			while (--i >= 0)
			{
				carry += (uint)longer[i];
				longer[i] = (byte)carry;
				carry >>= 8;
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000A8E84 File Offset: 0x000A7084
		private byte[] GetEntropy()
		{
			byte[] entropy = this.mEntropySource.GetEntropy();
			if (entropy.Length < (this.mSecurityStrength + 7) / 8)
			{
				throw new global::System.InvalidOperationException("Insufficient entropy provided by entropy source");
			}
			return entropy;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000A8EAC File Offset: 0x000A70AC
		private byte[] Block_Cipher_df(byte[] inputString, int bitLength)
		{
			int outLen = this.mEngine.GetBlockSize();
			int L = inputString.Length;
			int N = bitLength / 8;
			byte[] S = new byte[(8 + L + 1 + outLen - 1) / outLen * outLen];
			this.copyIntToByteArray(S, L, 0);
			this.copyIntToByteArray(S, N, 4);
			global::System.Array.Copy(inputString, 0, S, 8, L);
			S[8 + L] = 128;
			byte[] temp = new byte[this.mKeySizeInBits / 8 + outLen];
			byte[] bccOut = new byte[outLen];
			byte[] IV = new byte[outLen];
			int i = 0;
			byte[] K = new byte[this.mKeySizeInBits / 8];
			global::System.Array.Copy(global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.K_BITS, 0, K, 0, K.Length);
			while (i * outLen * 8 < this.mKeySizeInBits + outLen * 8)
			{
				this.copyIntToByteArray(IV, i, 0);
				this.BCC(bccOut, K, IV, S);
				int bytesToCopy = (temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen);
				global::System.Array.Copy(bccOut, 0, temp, i * outLen, bytesToCopy);
				i++;
			}
			byte[] X = new byte[outLen];
			global::System.Array.Copy(temp, 0, K, 0, K.Length);
			global::System.Array.Copy(temp, K.Length, X, 0, X.Length);
			temp = new byte[bitLength / 2];
			i = 0;
			this.mEngine.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.ExpandKey(K)));
			while (i * outLen < temp.Length)
			{
				this.mEngine.ProcessBlock(X, 0, X, 0);
				int bytesToCopy2 = (temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen);
				global::System.Array.Copy(X, 0, temp, i * outLen, bytesToCopy2);
				i++;
			}
			return temp;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x000A9048 File Offset: 0x000A7248
		private void BCC(byte[] bccOut, byte[] k, byte[] iV, byte[] data)
		{
			int outlen = this.mEngine.GetBlockSize();
			byte[] chainingValue = new byte[outlen];
			int i = data.Length / outlen;
			byte[] inputBlock = new byte[outlen];
			this.mEngine.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.ExpandKey(k)));
			this.mEngine.ProcessBlock(iV, 0, chainingValue, 0);
			for (int j = 0; j < i; j++)
			{
				this.XOR(inputBlock, chainingValue, data, j * outlen);
				this.mEngine.ProcessBlock(inputBlock, 0, chainingValue, 0);
			}
			global::System.Array.Copy(chainingValue, 0, bccOut, 0, bccOut.Length);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000A90D8 File Offset: 0x000A72D8
		private void copyIntToByteArray(byte[] buf, int value, int offSet)
		{
			buf[offSet] = (byte)(value >> 24);
			buf[offSet + 1] = (byte)(value >> 16);
			buf[offSet + 2] = (byte)(value >> 8);
			buf[offSet + 3] = (byte)value;
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000A90FC File Offset: 0x000A72FC
		public int BlockSize
		{
			get
			{
				return this.mV.Length * 8;
			}
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x000A9108 File Offset: 0x000A7308
		public int Generate(byte[] output, byte[] additionalInput, bool predictionResistant)
		{
			if (this.mIsTdea)
			{
				if (this.mReseedCounter > global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.TDEA_RESEED_MAX)
				{
					return -1;
				}
				if (global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.IsTooLarge(output, global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.TDEA_MAX_BITS_REQUEST / 8))
				{
					throw new global::System.ArgumentException("Number of bits per request limited to " + global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.TDEA_MAX_BITS_REQUEST.ToString(), "output");
				}
			}
			else
			{
				if (this.mReseedCounter > global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.AES_RESEED_MAX)
				{
					return -1;
				}
				if (global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.IsTooLarge(output, global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.AES_MAX_BITS_REQUEST / 8))
				{
					throw new global::System.ArgumentException("Number of bits per request limited to " + global::Org.BouncyCastle.Crypto.Prng.Drbg.CtrSP800Drbg.AES_MAX_BITS_REQUEST.ToString(), "output");
				}
			}
			if (predictionResistant)
			{
				this.CTR_DRBG_Reseed_algorithm(additionalInput);
				additionalInput = null;
			}
			if (additionalInput != null)
			{
				additionalInput = this.Block_Cipher_df(additionalInput, this.mSeedLength);
				this.CTR_DRBG_Update(additionalInput, this.mKey, this.mV);
			}
			else
			{
				additionalInput = new byte[this.mSeedLength];
			}
			byte[] tmp = new byte[this.mV.Length];
			this.mEngine.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.ExpandKey(this.mKey)));
			for (int i = 0; i <= output.Length / tmp.Length; i++)
			{
				int bytesToCopy = (output.Length - i * tmp.Length > tmp.Length) ? tmp.Length : (output.Length - i * this.mV.Length);
				if (bytesToCopy != 0)
				{
					this.AddOneTo(this.mV);
					this.mEngine.ProcessBlock(this.mV, 0, tmp, 0);
					global::System.Array.Copy(tmp, 0, output, i * tmp.Length, bytesToCopy);
				}
			}
			this.CTR_DRBG_Update(additionalInput, this.mKey, this.mV);
			this.mReseedCounter += 1L;
			return output.Length * 8;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x000A9296 File Offset: 0x000A7496
		public void Reseed(byte[] additionalInput)
		{
			this.CTR_DRBG_Reseed_algorithm(additionalInput);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x000A929F File Offset: 0x000A749F
		private bool IsTdea(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			return cipher.AlgorithmName.Equals("DESede") || cipher.AlgorithmName.Equals("TDEA");
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000A92C5 File Offset: 0x000A74C5
		private int GetMaxSecurityStrength(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, int keySizeInBits)
		{
			if (this.IsTdea(cipher) && keySizeInBits == 168)
			{
				return 112;
			}
			if (cipher.AlgorithmName.Equals("AES"))
			{
				return keySizeInBits;
			}
			return -1;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000A92F0 File Offset: 0x000A74F0
		private byte[] ExpandKey(byte[] key)
		{
			if (this.mIsTdea)
			{
				byte[] tmp = new byte[24];
				this.PadKey(key, 0, tmp, 0);
				this.PadKey(key, 7, tmp, 8);
				this.PadKey(key, 14, tmp, 16);
				return tmp;
			}
			return key;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000A9330 File Offset: 0x000A7530
		private void PadKey(byte[] keyMaster, int keyOff, byte[] tmp, int tmpOff)
		{
			tmp[tmpOff] = (keyMaster[keyOff] & 254);
			tmp[tmpOff + 1] = (byte)((int)keyMaster[keyOff] << 7 | (keyMaster[keyOff + 1] & 252) >> 1);
			tmp[tmpOff + 2] = (byte)((int)keyMaster[keyOff + 1] << 6 | (keyMaster[keyOff + 2] & 248) >> 2);
			tmp[tmpOff + 3] = (byte)((int)keyMaster[keyOff + 2] << 5 | (keyMaster[keyOff + 3] & 240) >> 3);
			tmp[tmpOff + 4] = (byte)((int)keyMaster[keyOff + 3] << 4 | (keyMaster[keyOff + 4] & 224) >> 4);
			tmp[tmpOff + 5] = (byte)((int)keyMaster[keyOff + 4] << 3 | (keyMaster[keyOff + 5] & 192) >> 5);
			tmp[tmpOff + 6] = (byte)((int)keyMaster[keyOff + 5] << 2 | (keyMaster[keyOff + 6] & 128) >> 6);
			tmp[tmpOff + 7] = (byte)(keyMaster[keyOff + 6] << 1);
			global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(tmp, tmpOff, 8);
		}

		// Token: 0x04000FB2 RID: 4018
		private static readonly long TDEA_RESEED_MAX = (long)((ulong)int.MinValue);

		// Token: 0x04000FB3 RID: 4019
		private static readonly long AES_RESEED_MAX = 140737488355328L;

		// Token: 0x04000FB4 RID: 4020
		private static readonly int TDEA_MAX_BITS_REQUEST = 4096;

		// Token: 0x04000FB5 RID: 4021
		private static readonly int AES_MAX_BITS_REQUEST = 262144;

		// Token: 0x04000FB6 RID: 4022
		private readonly global::Org.BouncyCastle.Crypto.IEntropySource mEntropySource;

		// Token: 0x04000FB7 RID: 4023
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher mEngine;

		// Token: 0x04000FB8 RID: 4024
		private readonly int mKeySizeInBits;

		// Token: 0x04000FB9 RID: 4025
		private readonly int mSeedLength;

		// Token: 0x04000FBA RID: 4026
		private readonly int mSecurityStrength;

		// Token: 0x04000FBB RID: 4027
		private byte[] mKey;

		// Token: 0x04000FBC RID: 4028
		private byte[] mV;

		// Token: 0x04000FBD RID: 4029
		private long mReseedCounter;

		// Token: 0x04000FBE RID: 4030
		private bool mIsTdea;

		// Token: 0x04000FBF RID: 4031
		private static readonly byte[] K_BITS = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F");
	}
}
