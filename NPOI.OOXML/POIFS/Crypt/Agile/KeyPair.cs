using System;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000119 RID: 281
	public class KeyPair
	{
		// Token: 0x06000FD1 RID: 4049 RVA: 0x000381B8 File Offset: 0x000363B8
		public KeyPair(global::NPOI.POIFS.Crypt.Agile.IPublicKey publicKey, global::NPOI.POIFS.Crypt.Agile.IPrivateKey privateKey)
		{
			this.publicKey = publicKey;
			this.privateKey = privateKey;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000381CE File Offset: 0x000363CE
		public global::NPOI.POIFS.Crypt.Agile.IPublicKey getPublic()
		{
			return this.publicKey;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000381D6 File Offset: 0x000363D6
		public global::NPOI.POIFS.Crypt.Agile.IPrivateKey getPrivate()
		{
			return this.privateKey;
		}

		// Token: 0x040004DE RID: 1246
		private global::NPOI.POIFS.Crypt.Agile.IPrivateKey privateKey;

		// Token: 0x040004DF RID: 1247
		private global::NPOI.POIFS.Crypt.Agile.IPublicKey publicKey;
	}
}
