using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047E RID: 1150
	public class Pkcs5S1ParametersGenerator : global::Org.BouncyCastle.Crypto.PbeParametersGenerator
	{
		// Token: 0x06002C22 RID: 11298 RVA: 0x000BE964 File Offset: 0x000BCB64
		public Pkcs5S1ParametersGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000BE974 File Offset: 0x000BCB74
		private byte[] GenerateDerivedKey()
		{
			byte[] digestBytes = new byte[this.digest.GetDigestSize()];
			this.digest.BlockUpdate(this.mPassword, 0, this.mPassword.Length);
			this.digest.BlockUpdate(this.mSalt, 0, this.mSalt.Length);
			this.digest.DoFinal(digestBytes, 0);
			for (int i = 1; i < this.mIterationCount; i++)
			{
				this.digest.BlockUpdate(digestBytes, 0, digestBytes.Length);
				this.digest.DoFinal(digestBytes, 0);
			}
			return digestBytes;
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x000BEA04 File Offset: 0x000BCC04
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize)
		{
			return this.GenerateDerivedMacParameters(keySize);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000BEA10 File Offset: 0x000BCC10
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
		{
			keySize /= 8;
			if (keySize > this.digest.GetDigestSize())
			{
				throw new global::System.ArgumentException("Can't Generate a derived key " + keySize.ToString() + " bytes long.");
			}
			byte[] dKey = this.GenerateDerivedKey();
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000BEA5C File Offset: 0x000BCC5C
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			if (keySize + ivSize > this.digest.GetDigestSize())
			{
				throw new global::System.ArgumentException("Can't Generate a derived key " + (keySize + ivSize).ToString() + " bytes long.");
			}
			byte[] dKey = this.GenerateDerivedKey();
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000BEABC File Offset: 0x000BCCBC
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			if (keySize + ivSize > this.digest.GetDigestSize())
			{
				throw new global::System.ArgumentException("Can't Generate a derived key " + (keySize + ivSize).ToString() + " bytes long.");
			}
			byte[] dKey = this.GenerateDerivedKey();
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000BEB1B File Offset: 0x000BCD1B
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize)
		{
			keySize /= 8;
			if (keySize > this.digest.GetDigestSize())
			{
				throw new global::System.ArgumentException("Can't Generate a derived key " + keySize.ToString() + " bytes long.");
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.GenerateDerivedKey(), 0, keySize);
		}

		// Token: 0x0400126B RID: 4715
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;
	}
}
