using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200057B RID: 1403
	public class InputStreamPacket : global::Org.BouncyCastle.Bcpg.Packet
	{
		// Token: 0x06003564 RID: 13668 RVA: 0x000FE0E4 File Offset: 0x000FC2E4
		public InputStreamPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.bcpgIn = bcpgIn;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000FE0F3 File Offset: 0x000FC2F3
		public global::Org.BouncyCastle.Bcpg.BcpgInputStream GetInputStream()
		{
			return this.bcpgIn;
		}

		// Token: 0x040017EB RID: 6123
		private readonly global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn;
	}
}
