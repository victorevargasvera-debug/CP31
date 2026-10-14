using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200059C RID: 1436
	public class UserAttributeSubpacket
	{
		// Token: 0x060035FD RID: 13821 RVA: 0x001001F7 File Offset: 0x000FE3F7
		protected internal UserAttributeSubpacket(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag type, byte[] data) : this(type, false, data)
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00100202 File Offset: 0x000FE402
		protected internal UserAttributeSubpacket(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag type, bool forceLongLength, byte[] data)
		{
			this.type = type;
			this.longLength = forceLongLength;
			this.data = data;
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x0010021F File Offset: 0x000FE41F
		public virtual global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag SubpacketType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00100227 File Offset: 0x000FE427
		public virtual byte[] GetData()
		{
			return this.data;
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00100230 File Offset: 0x000FE430
		public virtual void Encode(global::System.IO.Stream os)
		{
			int bodyLen = this.data.Length + 1;
			if (bodyLen < 192 && !this.longLength)
			{
				os.WriteByte((byte)bodyLen);
			}
			else if (bodyLen <= 8383 && !this.longLength)
			{
				bodyLen -= 192;
				os.WriteByte((byte)((bodyLen >> 8 & 255) + 192));
				os.WriteByte((byte)bodyLen);
			}
			else
			{
				os.WriteByte(byte.MaxValue);
				os.WriteByte((byte)(bodyLen >> 24));
				os.WriteByte((byte)(bodyLen >> 16));
				os.WriteByte((byte)(bodyLen >> 8));
				os.WriteByte((byte)bodyLen);
			}
			os.WriteByte((byte)this.type);
			os.Write(this.data, 0, this.data.Length);
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x001002F0 File Offset: 0x000FE4F0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket other = obj as global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket;
			return other != null && this.type == other.type && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.data, other.data);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x00100330 File Offset: 0x000FE530
		public override int GetHashCode()
		{
			return this.type.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.data);
		}

		// Token: 0x04001896 RID: 6294
		internal readonly global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag type;

		// Token: 0x04001897 RID: 6295
		private readonly bool longLength;

		// Token: 0x04001898 RID: 6296
		protected readonly byte[] data;
	}
}
