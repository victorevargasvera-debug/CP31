using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200047C RID: 1148
	public class OpenSslPbeParametersGenerator : global::Org.BouncyCastle.Crypto.PbeParametersGenerator
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x000BE410 File Offset: 0x000BC610
		public OpenSslPbeParametersGenerator() : this(new global::Org.BouncyCastle.Crypto.Digests.MD5Digest())
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000BE41D File Offset: 0x000BC61D
		public OpenSslPbeParametersGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000BE42C File Offset: 0x000BC62C
		public override void Init(byte[] password, byte[] salt, int iterationCount)
		{
			base.Init(password, salt, 1);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000BE437 File Offset: 0x000BC637
		public virtual void Init(byte[] password, byte[] salt)
		{
			base.Init(password, salt, 1);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000BE444 File Offset: 0x000BC644
		private byte[] GenerateDerivedKey(int bytesNeeded)
		{
			byte[] buf = new byte[this.digest.GetDigestSize()];
			byte[] key = new byte[bytesNeeded];
			int offset = 0;
			for (;;)
			{
				this.digest.BlockUpdate(this.mPassword, 0, this.mPassword.Length);
				this.digest.BlockUpdate(this.mSalt, 0, this.mSalt.Length);
				this.digest.DoFinal(buf, 0);
				int len = (bytesNeeded > buf.Length) ? buf.Length : bytesNeeded;
				global::System.Array.Copy(buf, 0, key, offset, len);
				offset += len;
				bytesNeeded -= len;
				if (bytesNeeded == 0)
				{
					break;
				}
				this.digest.Reset();
				this.digest.BlockUpdate(buf, 0, buf.Length);
			}
			return key;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000BE4F1 File Offset: 0x000BC6F1
		[global::System.Obsolete("Use version with 'algorithm' parameter")]
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize)
		{
			return this.GenerateDerivedMacParameters(keySize);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000BE4FC File Offset: 0x000BC6FC
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
		{
			keySize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize);
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000BE520 File Offset: 0x000BC720
		[global::System.Obsolete("Use version with 'algorithm' parameter")]
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize + ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000BE554 File Offset: 0x000BC754
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
		{
			keySize /= 8;
			ivSize /= 8;
			byte[] dKey = this.GenerateDerivedKey(keySize + ivSize);
			return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize), dKey, keySize, ivSize);
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x000BE586 File Offset: 0x000BC786
		public override global::Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize)
		{
			keySize /= 8;
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(this.GenerateDerivedKey(keySize), 0, keySize);
		}

		// Token: 0x04001264 RID: 4708
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;
	}
}
