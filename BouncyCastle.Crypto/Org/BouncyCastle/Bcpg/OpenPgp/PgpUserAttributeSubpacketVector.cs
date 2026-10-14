using System;
using Org.BouncyCastle.Bcpg.Attr;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C4 RID: 1476
	public class PgpUserAttributeSubpacketVector
	{
		// Token: 0x060037AC RID: 14252 RVA: 0x0010743E File Offset: 0x0010563E
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector FromSubpackets(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] packets)
		{
			if (packets == null)
			{
				packets = new global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[0];
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector(packets);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00107451 File Offset: 0x00105651
		internal PgpUserAttributeSubpacketVector(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] packets)
		{
			this.packets = packets;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00107460 File Offset: 0x00105660
		public global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket GetSubpacket(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag type)
		{
			for (int i = 0; i != this.packets.Length; i++)
			{
				if (this.packets[i].SubpacketType == type)
				{
					return this.packets[i];
				}
			}
			return null;
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0010749C File Offset: 0x0010569C
		public global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib GetImageAttribute()
		{
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag.ImageAttribute);
			if (p != null)
			{
				return (global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib)p;
			}
			return null;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x001074BC File Offset: 0x001056BC
		internal global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] ToSubpacketArray()
		{
			return this.packets;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x001074C4 File Offset: 0x001056C4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector other = obj as global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector;
			if (other == null)
			{
				return false;
			}
			if (other.packets.Length != this.packets.Length)
			{
				return false;
			}
			for (int i = 0; i != this.packets.Length; i++)
			{
				if (!other.packets[i].Equals(this.packets[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00107524 File Offset: 0x00105724
		public override int GetHashCode()
		{
			int code = 0;
			foreach (global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket o in this.packets)
			{
				code ^= o.GetHashCode();
			}
			return code;
		}

		// Token: 0x0400190F RID: 6415
		private readonly global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket[] packets;
	}
}
