using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200059B RID: 1435
	public class UserAttributePacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x060035F9 RID: 13817 RVA: 0x00100130 File Offset: 0x000FE330
		public UserAttributePacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketsParser sIn = new global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketsParser(bcpgIn);
			global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket sub;
			while ((sub = sIn.ReadPacket()) != null)
			{
				v.Add(sub);
			}
			this.subpackets = new global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[v.Count];
			for (int i = 0; i != this.subpackets.Length; i++)
			{
				this.subpackets[i] = (global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket)v[i];
			}
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x0010019C File Offset: 0x000FE39C
		public UserAttributePacket(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] subpackets)
		{
			this.subpackets = subpackets;
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x001001AB File Offset: 0x000FE3AB
		public global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] GetSubpackets()
		{
			return this.subpackets;
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x001001B4 File Offset: 0x000FE3B4
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			for (int i = 0; i != this.subpackets.Length; i++)
			{
				this.subpackets[i].Encode(bOut);
			}
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.UserAttribute, bOut.ToArray(), false);
		}

		// Token: 0x04001895 RID: 6293
		private readonly global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] subpackets;
	}
}
