using System;
using System.Text;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200059F RID: 1439
	public class UserIdPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x06003606 RID: 13830 RVA: 0x00100456 File Offset: 0x000FE656
		public UserIdPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.idData = bcpgIn.ReadAll();
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0010046A File Offset: 0x000FE66A
		public UserIdPacket(string id)
		{
			this.idData = global::System.Text.Encoding.UTF8.GetBytes(id);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00100483 File Offset: 0x000FE683
		public string GetId()
		{
			return global::System.Text.Encoding.UTF8.GetString(this.idData, 0, this.idData.Length);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0010049E File Offset: 0x000FE69E
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.UserId, this.idData, true);
		}

		// Token: 0x0400189C RID: 6300
		private readonly byte[] idData;
	}
}
