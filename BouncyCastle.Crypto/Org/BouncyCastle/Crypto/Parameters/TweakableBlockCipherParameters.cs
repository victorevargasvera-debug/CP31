using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040D RID: 1037
	public class TweakableBlockCipherParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x000AD179 File Offset: 0x000AB379
		public TweakableBlockCipherParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, byte[] tweak)
		{
			this.key = key;
			this.tweak = global::Org.BouncyCastle.Utilities.Arrays.Clone(tweak);
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000AD194 File Offset: 0x000AB394
		public global::Org.BouncyCastle.Crypto.Parameters.KeyParameter Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x000AD19C File Offset: 0x000AB39C
		public byte[] Tweak
		{
			get
			{
				return this.tweak;
			}
		}

		// Token: 0x04001087 RID: 4231
		private readonly byte[] tweak;

		// Token: 0x04001088 RID: 4232
		private readonly global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
	}
}
