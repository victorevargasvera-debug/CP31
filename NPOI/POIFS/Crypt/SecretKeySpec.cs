using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002FA RID: 762
	public class SecretKeySpec : global::NPOI.POIFS.Crypt.IKeySpec, global::NPOI.POIFS.Crypt.ISecretKey, global::NPOI.POIFS.Crypt.IKey
	{
		// Token: 0x060015FF RID: 5631 RVA: 0x000420CC File Offset: 0x000402CC
		public SecretKeySpec(byte[] key, string algorithm)
		{
			if (key == null || algorithm == null)
			{
				throw new global::System.ArgumentException("Missing argument");
			}
			if (key.Length == 0)
			{
				throw new global::System.ArgumentException("Empty key");
			}
			this.key = new byte[key.Length];
			global::System.Array.Copy(key, this.key, key.Length);
			this.algorithm = algorithm;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00042123 File Offset: 0x00040323
		public string GetAlgorithm()
		{
			return this.algorithm;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0004212C File Offset: 0x0004032C
		public byte[] GetEncoded()
		{
			byte[] array = new byte[this.key.Length];
			global::System.Array.Copy(this.key, array, this.key.Length);
			return array;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0004215C File Offset: 0x0004035C
		public string GetFormat()
		{
			return "RAW";
		}

		// Token: 0x040008F1 RID: 2289
		private byte[] key;

		// Token: 0x040008F2 RID: 2290
		private string algorithm;
	}
}
