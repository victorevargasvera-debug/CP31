using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200057D RID: 1405
	public class MarkerPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x0600356B RID: 13675 RVA: 0x000FE1B6 File Offset: 0x000FC3B6
		public MarkerPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			bcpgIn.ReadFully(this.marker);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x000FE1E1 File Offset: 0x000FC3E1
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.Marker, this.marker, true);
		}

		// Token: 0x040017EF RID: 6127
		private byte[] marker = new byte[]
		{
			80,
			71,
			80
		};
	}
}
