using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng.Drbg
{
	// Token: 0x020003C2 RID: 962
	public class HashSP800Drbg : global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg
	{
		// Token: 0x060026E3 RID: 9955 RVA: 0x000A9678 File Offset: 0x000A7878
		static HashSP800Drbg()
		{
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-1", 440);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-224", 440);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-256", 440);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-512/256", 440);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-512/224", 440);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-384", 888);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens.Add("SHA-512", 888);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000A9768 File Offset: 0x000A7968
		public HashSP800Drbg(global::Org.BouncyCastle.Crypto.IDigest digest, int securityStrength, global::Org.BouncyCastle.Crypto.IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
		{
			if (securityStrength > global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.GetMaxSecurityStrength(digest))
			{
				throw new global::System.ArgumentException("Requested security strength is not supported by the derivation function");
			}
			if (entropySource.EntropySize < securityStrength)
			{
				throw new global::System.ArgumentException("Not enough entropy for security strength required");
			}
			this.mDigest = digest;
			this.mEntropySource = entropySource;
			this.mSecurityStrength = securityStrength;
			this.mSeedLength = (int)global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.seedlens[digest.AlgorithmName];
			byte[] entropy = this.GetEntropy();
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				entropy,
				nonce,
				personalizationString
			});
			byte[] seed = global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.HashDF(this.mDigest, seedMaterial, this.mSeedLength);
			this.mV = seed;
			byte[] subV = new byte[this.mV.Length + 1];
			global::System.Array.Copy(this.mV, 0, subV, 1, this.mV.Length);
			this.mC = global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.HashDF(this.mDigest, subV, this.mSeedLength);
			this.mReseedCounter = 1L;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000A9854 File Offset: 0x000A7A54
		public int BlockSize
		{
			get
			{
				return this.mDigest.GetDigestSize() * 8;
			}
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000A9864 File Offset: 0x000A7A64
		public int Generate(byte[] output, byte[] additionalInput, bool predictionResistant)
		{
			int numberOfBits = output.Length * 8;
			if (numberOfBits > global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.MAX_BITS_REQUEST)
			{
				throw new global::System.ArgumentException("Number of bits per request limited to " + global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.MAX_BITS_REQUEST.ToString(), "output");
			}
			if (this.mReseedCounter > global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.RESEED_MAX)
			{
				return -1;
			}
			if (predictionResistant)
			{
				this.Reseed(additionalInput);
				additionalInput = null;
			}
			if (additionalInput != null)
			{
				byte[] newInput = new byte[1 + this.mV.Length + additionalInput.Length];
				newInput[0] = 2;
				global::System.Array.Copy(this.mV, 0, newInput, 1, this.mV.Length);
				global::System.Array.Copy(additionalInput, 0, newInput, 1 + this.mV.Length, additionalInput.Length);
				byte[] w = this.Hash(newInput);
				this.AddTo(this.mV, w);
			}
			global::System.Array sourceArray = this.hashgen(this.mV, numberOfBits);
			byte[] subH = new byte[this.mV.Length + 1];
			global::System.Array.Copy(this.mV, 0, subH, 1, this.mV.Length);
			subH[0] = 3;
			byte[] H = this.Hash(subH);
			this.AddTo(this.mV, H);
			this.AddTo(this.mV, this.mC);
			byte[] c = new byte[]
			{
				(byte)(this.mReseedCounter >> 24),
				(byte)(this.mReseedCounter >> 16),
				(byte)(this.mReseedCounter >> 8),
				(byte)this.mReseedCounter
			};
			this.AddTo(this.mV, c);
			this.mReseedCounter += 1L;
			global::System.Array.Copy(sourceArray, 0, output, 0, output.Length);
			return numberOfBits;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000A99DD File Offset: 0x000A7BDD
		private byte[] GetEntropy()
		{
			byte[] entropy = this.mEntropySource.GetEntropy();
			if (entropy.Length < (this.mSecurityStrength + 7) / 8)
			{
				throw new global::System.InvalidOperationException("Insufficient entropy provided by entropy source");
			}
			return entropy;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000A9A04 File Offset: 0x000A7C04
		private void AddTo(byte[] longer, byte[] shorter)
		{
			int off = longer.Length - shorter.Length;
			uint carry = 0U;
			int i = shorter.Length;
			while (--i >= 0)
			{
				carry += (uint)(longer[off + i] + shorter[i]);
				longer[off + i] = (byte)carry;
				carry >>= 8;
			}
			i = off;
			while (--i >= 0)
			{
				carry += (uint)longer[i];
				longer[i] = (byte)carry;
				carry >>= 8;
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000A9A5C File Offset: 0x000A7C5C
		public void Reseed(byte[] additionalInput)
		{
			byte[] entropy = this.GetEntropy();
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.ONE,
				this.mV,
				entropy,
				additionalInput
			});
			byte[] seed = global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.HashDF(this.mDigest, seedMaterial, this.mSeedLength);
			this.mV = seed;
			byte[] subV = new byte[this.mV.Length + 1];
			subV[0] = 0;
			global::System.Array.Copy(this.mV, 0, subV, 1, this.mV.Length);
			this.mC = global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.HashDF(this.mDigest, subV, this.mSeedLength);
			this.mReseedCounter = 1L;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000A9AFC File Offset: 0x000A7CFC
		private byte[] Hash(byte[] input)
		{
			byte[] hash = new byte[this.mDigest.GetDigestSize()];
			this.DoHash(input, hash);
			return hash;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000A9B23 File Offset: 0x000A7D23
		private void DoHash(byte[] input, byte[] output)
		{
			this.mDigest.BlockUpdate(input, 0, input.Length);
			this.mDigest.DoFinal(output, 0);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000A9B44 File Offset: 0x000A7D44
		private byte[] hashgen(byte[] input, int lengthInBits)
		{
			int digestSize = this.mDigest.GetDigestSize();
			int i = lengthInBits / 8 / digestSize;
			byte[] data = new byte[input.Length];
			global::System.Array.Copy(input, 0, data, 0, input.Length);
			byte[] W = new byte[lengthInBits / 8];
			byte[] dig = new byte[this.mDigest.GetDigestSize()];
			for (int j = 0; j <= i; j++)
			{
				this.DoHash(data, dig);
				int bytesToCopy = (W.Length - j * dig.Length > dig.Length) ? dig.Length : (W.Length - j * dig.Length);
				global::System.Array.Copy(dig, 0, W, j * dig.Length, bytesToCopy);
				this.AddTo(data, global::Org.BouncyCastle.Crypto.Prng.Drbg.HashSP800Drbg.ONE);
			}
			return W;
		}

		// Token: 0x04000FC1 RID: 4033
		private static readonly byte[] ONE = new byte[]
		{
			1
		};

		// Token: 0x04000FC2 RID: 4034
		private static readonly long RESEED_MAX = 140737488355328L;

		// Token: 0x04000FC3 RID: 4035
		private static readonly int MAX_BITS_REQUEST = 262144;

		// Token: 0x04000FC4 RID: 4036
		private static readonly global::System.Collections.IDictionary seedlens = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04000FC5 RID: 4037
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

		// Token: 0x04000FC6 RID: 4038
		private readonly global::Org.BouncyCastle.Crypto.IEntropySource mEntropySource;

		// Token: 0x04000FC7 RID: 4039
		private readonly int mSecurityStrength;

		// Token: 0x04000FC8 RID: 4040
		private readonly int mSeedLength;

		// Token: 0x04000FC9 RID: 4041
		private byte[] mV;

		// Token: 0x04000FCA RID: 4042
		private byte[] mC;

		// Token: 0x04000FCB RID: 4043
		private long mReseedCounter;
	}
}
