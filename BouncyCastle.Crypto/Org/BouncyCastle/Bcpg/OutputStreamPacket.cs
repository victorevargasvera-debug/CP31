using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000581 RID: 1409
	public abstract class OutputStreamPacket
	{
		// Token: 0x0600357D RID: 13693 RVA: 0x000FE50D File Offset: 0x000FC70D
		internal OutputStreamPacket(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			if (bcpgOut == null)
			{
				throw new global::System.ArgumentNullException("bcpgOut");
			}
			this.bcpgOut = bcpgOut;
		}

		// Token: 0x0600357E RID: 13694
		public abstract global::Org.BouncyCastle.Bcpg.BcpgOutputStream Open();

		// Token: 0x0600357F RID: 13695
		public abstract void Close();

		// Token: 0x040017F8 RID: 6136
		private readonly global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut;
	}
}
