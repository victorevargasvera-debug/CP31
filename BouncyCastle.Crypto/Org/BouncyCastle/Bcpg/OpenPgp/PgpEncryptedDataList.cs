using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A6 RID: 1446
	public class PgpEncryptedDataList : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x0600362E RID: 13870 RVA: 0x00100E90 File Offset: 0x000FF090
		public PgpEncryptedDataList(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			while (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.PublicKeyEncryptedSession || bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncryptedSessionKey)
			{
				this.list.Add(bcpgInput.ReadPacket());
			}
			global::Org.BouncyCastle.Bcpg.Packet packet = bcpgInput.ReadPacket();
			if (!(packet is global::Org.BouncyCastle.Bcpg.InputStreamPacket))
			{
				string str = "unexpected packet in stream: ";
				global::Org.BouncyCastle.Bcpg.Packet packet2 = packet;
				throw new global::System.IO.IOException(str + ((packet2 != null) ? packet2.ToString() : null));
			}
			this.data = (global::Org.BouncyCastle.Bcpg.InputStreamPacket)packet;
			for (int i = 0; i != this.list.Count; i++)
			{
				if (this.list[i] is global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket)
				{
					this.list[i] = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPbeEncryptedData((global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket)this.list[i], this.data);
				}
				else
				{
					this.list[i] = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyEncryptedData((global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket)this.list[i], this.data);
				}
			}
		}

		// Token: 0x17000746 RID: 1862
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData this[int index]
		{
			get
			{
				return (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData)this.list[index];
			}
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00100F9A File Offset: 0x000FF19A
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public object Get(int index)
		{
			return this[index];
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x00100FA3 File Offset: 0x000FF1A3
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x00100FB0 File Offset: 0x000FF1B0
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x00100FBD File Offset: 0x000FF1BD
		public bool IsEmpty
		{
			get
			{
				return this.list.Count == 0;
			}
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00100FCD File Offset: 0x000FF1CD
		public global::System.Collections.IEnumerable GetEncryptedDataObjects()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.list);
		}

		// Token: 0x040018AE RID: 6318
		private readonly global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018AF RID: 6319
		private readonly global::Org.BouncyCastle.Bcpg.InputStreamPacket data;
	}
}
