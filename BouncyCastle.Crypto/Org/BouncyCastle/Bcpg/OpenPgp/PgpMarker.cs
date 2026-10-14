using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B0 RID: 1456
	public class PgpMarker : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x06003666 RID: 13926 RVA: 0x001018E8 File Offset: 0x000FFAE8
		public PgpMarker(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			global::Org.BouncyCastle.Bcpg.Packet packet = bcpgInput.ReadPacket();
			if (!(packet is global::Org.BouncyCastle.Bcpg.MarkerPacket))
			{
				string str = "unexpected packet in stream: ";
				global::Org.BouncyCastle.Bcpg.Packet packet2 = packet;
				throw new global::System.IO.IOException(str + ((packet2 != null) ? packet2.ToString() : null));
			}
			this.data = (global::Org.BouncyCastle.Bcpg.MarkerPacket)packet;
		}

		// Token: 0x040018CF RID: 6351
		private readonly global::Org.BouncyCastle.Bcpg.MarkerPacket data;
	}
}
