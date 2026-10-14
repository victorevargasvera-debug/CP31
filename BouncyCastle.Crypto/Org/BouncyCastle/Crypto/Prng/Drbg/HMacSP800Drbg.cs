using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng.Drbg
{
	// Token: 0x020003C3 RID: 963
	public class HMacSP800Drbg : global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		public HMacSP800Drbg(global::Org.BouncyCastle.Crypto.IMac hMac, int securityStrength, global::Org.BouncyCastle.Crypto.IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
		{
			if (securityStrength > global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.GetMaxSecurityStrength(hMac))
			{
				throw new global::System.ArgumentException("Requested security strength is not supported by the derivation function");
			}
			if (entropySource.EntropySize < securityStrength)
			{
				throw new global::System.ArgumentException("Not enough entropy for security strength required");
			}
			this.mHMac = hMac;
			this.mSecurityStrength = securityStrength;
			this.mEntropySource = entropySource;
			byte[] entropy = this.GetEntropy();
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				entropy,
				nonce,
				personalizationString
			});
			this.mK = new byte[hMac.GetMacSize()];
			this.mV = new byte[this.mK.Length];
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.mV, 1);
			this.hmac_DRBG_Update(seedMaterial);
			this.mReseedCounter = 1L;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000A9CA0 File Offset: 0x000A7EA0
		private void hmac_DRBG_Update(byte[] seedMaterial)
		{
			this.hmac_DRBG_Update_Func(seedMaterial, 0);
			if (seedMaterial != null)
			{
				this.hmac_DRBG_Update_Func(seedMaterial, 1);
			}
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000A9CB8 File Offset: 0x000A7EB8
		private void hmac_DRBG_Update_Func(byte[] seedMaterial, byte vValue)
		{
			this.mHMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.mK));
			this.mHMac.BlockUpdate(this.mV, 0, this.mV.Length);
			this.mHMac.Update(vValue);
			if (seedMaterial != null)
			{
				this.mHMac.BlockUpdate(seedMaterial, 0, seedMaterial.Length);
			}
			this.mHMac.DoFinal(this.mK, 0);
			this.mHMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.mK));
			this.mHMac.BlockUpdate(this.mV, 0, this.mV.Length);
			this.mHMac.DoFinal(this.mV, 0);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000A9D6A File Offset: 0x000A7F6A
		public int BlockSize
		{
			get
			{
				return this.mV.Length * 8;
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000A9D78 File Offset: 0x000A7F78
		public int Generate(byte[] output, byte[] additionalInput, bool predictionResistant)
		{
			int numberOfBits = output.Length * 8;
			if (numberOfBits > global::Org.BouncyCastle.Crypto.Prng.Drbg.HMacSP800Drbg.MAX_BITS_REQUEST)
			{
				throw new global::System.ArgumentException("Number of bits per request limited to " + global::Org.BouncyCastle.Crypto.Prng.Drbg.HMacSP800Drbg.MAX_BITS_REQUEST.ToString(), "output");
			}
			if (this.mReseedCounter > global::Org.BouncyCastle.Crypto.Prng.Drbg.HMacSP800Drbg.RESEED_MAX)
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
				this.hmac_DRBG_Update(additionalInput);
			}
			byte[] rv = new byte[output.Length];
			int i = output.Length / this.mV.Length;
			this.mHMac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.mK));
			for (int j = 0; j < i; j++)
			{
				this.mHMac.BlockUpdate(this.mV, 0, this.mV.Length);
				this.mHMac.DoFinal(this.mV, 0);
				global::System.Array.Copy(this.mV, 0, rv, j * this.mV.Length, this.mV.Length);
			}
			if (i * this.mV.Length < rv.Length)
			{
				this.mHMac.BlockUpdate(this.mV, 0, this.mV.Length);
				this.mHMac.DoFinal(this.mV, 0);
				global::System.Array.Copy(this.mV, 0, rv, i * this.mV.Length, rv.Length - i * this.mV.Length);
			}
			this.hmac_DRBG_Update(additionalInput);
			this.mReseedCounter += 1L;
			global::System.Array.Copy(rv, 0, output, 0, output.Length);
			return numberOfBits;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000A9EE8 File Offset: 0x000A80E8
		public void Reseed(byte[] additionalInput)
		{
			byte[] seedMaterial = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(this.GetEntropy(), additionalInput);
			this.hmac_DRBG_Update(seedMaterial);
			this.mReseedCounter = 1L;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000A9F11 File Offset: 0x000A8111
		private byte[] GetEntropy()
		{
			byte[] entropy = this.mEntropySource.GetEntropy();
			if (entropy.Length < (this.mSecurityStrength + 7) / 8)
			{
				throw new global::System.InvalidOperationException("Insufficient entropy provided by entropy source");
			}
			return entropy;
		}

		// Token: 0x04000FCC RID: 4044
		private static readonly long RESEED_MAX = 140737488355328L;

		// Token: 0x04000FCD RID: 4045
		private static readonly int MAX_BITS_REQUEST = 262144;

		// Token: 0x04000FCE RID: 4046
		private readonly byte[] mK;

		// Token: 0x04000FCF RID: 4047
		private readonly byte[] mV;

		// Token: 0x04000FD0 RID: 4048
		private readonly global::Org.BouncyCastle.Crypto.IEntropySource mEntropySource;

		// Token: 0x04000FD1 RID: 4049
		private readonly global::Org.BouncyCastle.Crypto.IMac mHMac;

		// Token: 0x04000FD2 RID: 4050
		private readonly int mSecurityStrength;

		// Token: 0x04000FD3 RID: 4051
		private long mReseedCounter;
	}
}
