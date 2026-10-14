using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A8 RID: 1448
	public class PgpExperimental : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x06003639 RID: 13881 RVA: 0x00100FFD File Offset: 0x000FF1FD
		public PgpExperimental(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.p = (global::Org.BouncyCastle.Bcpg.ExperimentalPacket)bcpgIn.ReadPacket();
		}

		// Token: 0x040018B0 RID: 6320
		private readonly global::Org.BouncyCastle.Bcpg.ExperimentalPacket p;
	}
}
