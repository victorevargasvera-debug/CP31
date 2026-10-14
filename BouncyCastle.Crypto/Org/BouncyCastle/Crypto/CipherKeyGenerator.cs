using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BE RID: 702
	public class CipherKeyGenerator
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x0008FFC5 File Offset: 0x0008E1C5
		public CipherKeyGenerator()
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0008FFD4 File Offset: 0x0008E1D4
		internal CipherKeyGenerator(int defaultStrength)
		{
			if (defaultStrength < 1)
			{
				throw new global::System.ArgumentException("strength must be a positive value", "defaultStrength");
			}
			this.defaultStrength = defaultStrength;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0008FFFE File Offset: 0x0008E1FE
		public int DefaultStrength
		{
			get
			{
				return this.defaultStrength;
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00090006 File Offset: 0x0008E206
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			this.uninitialised = false;
			this.engineInit(parameters);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00090024 File Offset: 0x0008E224
		protected virtual void engineInit(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
			this.strength = (parameters.Strength + 7) / 8;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00090044 File Offset: 0x0008E244
		public byte[] GenerateKey()
		{
			if (this.uninitialised)
			{
				if (this.defaultStrength < 1)
				{
					throw new global::System.InvalidOperationException("Generator has not been initialised");
				}
				this.uninitialised = false;
				this.engineInit(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(new global::Org.BouncyCastle.Security.SecureRandom(), this.defaultStrength));
			}
			return this.engineGenerateKey();
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00090090 File Offset: 0x0008E290
		protected virtual byte[] engineGenerateKey()
		{
			return global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(this.random, this.strength);
		}

		// Token: 0x04000B2B RID: 2859
		protected internal global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000B2C RID: 2860
		protected internal int strength;

		// Token: 0x04000B2D RID: 2861
		private bool uninitialised = true;

		// Token: 0x04000B2E RID: 2862
		private int defaultStrength;
	}
}
