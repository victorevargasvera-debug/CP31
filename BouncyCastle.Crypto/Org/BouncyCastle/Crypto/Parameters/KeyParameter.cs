using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F7 RID: 1015
	public class KeyParameter : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x000AC5DA File Offset: 0x000AA7DA
		public KeyParameter(byte[] key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			this.key = (byte[])key.Clone();
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000AC604 File Offset: 0x000AA804
		public KeyParameter(byte[] key, int keyOff, int keyLen)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (keyOff < 0 || keyOff > key.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("keyOff");
			}
			if (keyLen < 0 || keyLen > key.Length - keyOff)
			{
				throw new global::System.ArgumentOutOfRangeException("keyLen");
			}
			this.key = new byte[keyLen];
			global::System.Array.Copy(key, keyOff, this.key, 0, keyLen);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000AC66C File Offset: 0x000AA86C
		public byte[] GetKey()
		{
			return (byte[])this.key.Clone();
		}

		// Token: 0x0400104E RID: 4174
		private readonly byte[] key;
	}
}
