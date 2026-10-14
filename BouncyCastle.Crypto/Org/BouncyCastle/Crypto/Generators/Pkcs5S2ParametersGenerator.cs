using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047F RID: 1151
	public class Pkcs5S2ParametersGenerator : global::Org.BouncyCastle.Crypto.PbeParametersGenerator
	{
		// Token: 0x06002C29 RID: 11305 RVA: 0x000BEB59 File Offset: 0x000BCD59
		public Pkcs5S2ParametersGenerator() : this(new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest())
		{
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000BEB66 File Offset: 0x000BCD66
		public Pkcs5S2ParametersGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.hMac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			this.state = new byte[this.hMac.GetMacSize()];
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000BEB90 File Offset: 0x000BCD90
		private void F(byte[] S, int c, byte[] iBuf, byte[] outBytes, int outOff)
		{
			if (c == 0)
			{
				throw new global::System.ArgumentException("iteration count must be at least 1.");
			}
			if (S != null)
			{
				this.hMac.BlockUpdate(S, 0, S.Length);
			}
			this.hMac.BlockUpdate(iBuf, 0, iBuf.Length);
			this.hMac.DoFinal(this.state, 0);
			global::System.Array.Copy(this.state, 0, outBytes, outOff, this.state.Length);
			for (int count = 1; count < c; count++)
			{
				this.hMac.BlockUpdate(this.state, 0, this.state.Length);
				this.hMac.DoFinal(this.state, 0);
				for (int i = 0; i < this.state.Length; i++)
				{
					int num = outOff + i;
					outBytes[num] ^= this.state[i];
				}
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000BEC60 File Offset: 0x000BCE60
		private byte[] GenerateDerivedKey(int dkLen)
		{
			int hLen = this.hMac.GetMacSize();
			int i = (dkLen + hLen - 1) / hLen;
			byte[] iBuf = new byte[4];
			byte[] outBytes = new byte[i * hLen];
			int outPos = 0;
			global::Org.BouncyCastle.Crypto.ICipherParameters param = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.mPassword);
			this.hMac.Init(param);
			for (int j = 1; j <= i; j++)
			{
				int pos = 3;
				for (;;)
				{
					byte[] array = iBuf;
					int num = pos;
					byte b = array[num] + 1;
					array[num] = b;
					if (b != 0)
					{
						break;
					}
					pos--;
				}
				this.F(this.mSalt, this.mIterationCount, iBuf, outBytes, outPos);
				outPos += hLen;
			}
			return outBytes;
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000BECFC File Offset: 0x000BCEFC
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize)
		{
			return this.GenerateDerivedMacParameters(keySize);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000BED08 File Offset: 0x000BCF08
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
		{
			keySize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize);
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000BED2C File Offset: 0x000BCF2C
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize + ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000BED60 File Offset: 0x000BCF60
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize + ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000BED92 File Offset: 0x000BCF92
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize)
		{
			keySize /= 8;
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.GenerateDerivedKey(keySize), 0, keySize);
		}

		// Token: 0x0400126C RID: 4716
		private readonly global::Org.BouncyCastle.Crypto.IMac hMac;

		// Token: 0x0400126D RID: 4717
		private readonly byte[] state;
	}
}
