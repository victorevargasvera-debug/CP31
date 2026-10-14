using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Attr;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200059D RID: 1437
	public class UserAttributeSubpacketsParser
	{
		// Token: 0x06003604 RID: 13828 RVA: 0x0010034F File Offset: 0x000FE54F
		public UserAttributeSubpacketsParser(global::System.IO.Stream input)
		{
			this.input = input;
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00100360 File Offset: 0x000FE560
		public virtual global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket ReadPacket()
		{
			int i = this.input.ReadByte();
			if (i < 0)
			{
				return null;
			}
			bool longLength = false;
			int bodyLen;
			if (i < 192)
			{
				bodyLen = i;
			}
			else if (i <= 223)
			{
				bodyLen = (i - 192 << 8) + this.input.ReadByte() + 192;
			}
			else
			{
				if (i != 255)
				{
					throw new global::System.IO.IOException("unrecognised length reading user attribute sub packet");
				}
				bodyLen = (this.input.ReadByte() << 24 | this.input.ReadByte() << 16 | this.input.ReadByte() << 8 | this.input.ReadByte());
				longLength = true;
			}
			int num = this.input.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("unexpected EOF reading user attribute sub packet");
			}
			byte[] data = new byte[bodyLen - 1];
			if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this.input, data) < data.Length)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag type = (global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag)num;
			if (type == global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag.ImageAttribute)
			{
				return new global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib(longLength, data);
			}
			return new global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket(type, longLength, data);
		}

		// Token: 0x04001899 RID: 6297
		private readonly global::System.IO.Stream input;
	}
}
