using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg.Attr
{
	// Token: 0x020005D9 RID: 1497
	public class ImageAttrib : global::Org.BouncyCastle.Bcpg.UserAttributeSubpacket
	{
		// Token: 0x06003824 RID: 14372 RVA: 0x00108CA1 File Offset: 0x00106EA1
		public ImageAttrib(byte[] data) : this(false, data)
		{
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00108CAC File Offset: 0x00106EAC
		public ImageAttrib(bool forceLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.UserAttributeSubpacketTag.ImageAttribute, forceLongLength, data)
		{
			this.hdrLength = ((int)(data[1] & byte.MaxValue) << 8 | (int)(data[0] & byte.MaxValue));
			this._version = (int)(data[2] & byte.MaxValue);
			this._encoding = (int)(data[3] & byte.MaxValue);
			this.imageData = new byte[data.Length - this.hdrLength];
			global::System.Array.Copy(data, this.hdrLength, this.imageData, 0, this.imageData.Length);
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00108D2B File Offset: 0x00106F2B
		public ImageAttrib(global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.Format imageType, byte[] imageData) : this(global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.ToByteArray(imageType, imageData))
		{
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00108D3C File Offset: 0x00106F3C
		private static byte[] ToByteArray(global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.Format imageType, byte[] imageData)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(16);
			memoryStream.WriteByte(0);
			memoryStream.WriteByte(1);
			memoryStream.WriteByte((byte)imageType);
			memoryStream.Write(global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.Zeroes, 0, global::Org.BouncyCastle.Bcpg.Attr.ImageAttrib.Zeroes.Length);
			memoryStream.Write(imageData, 0, imageData.Length);
			return memoryStream.ToArray();
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x00108D8E File Offset: 0x00106F8E
		public virtual int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x00108D96 File Offset: 0x00106F96
		public virtual int Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00108D9E File Offset: 0x00106F9E
		public virtual byte[] GetImageData()
		{
			return this.imageData;
		}

		// Token: 0x04001928 RID: 6440
		private static readonly byte[] Zeroes = new byte[12];

		// Token: 0x04001929 RID: 6441
		private int hdrLength;

		// Token: 0x0400192A RID: 6442
		private int _version;

		// Token: 0x0400192B RID: 6443
		private int _encoding;

		// Token: 0x0400192C RID: 6444
		private byte[] imageData;

		// Token: 0x0200084B RID: 2123
		public enum Format : byte
		{
			// Token: 0x040025BB RID: 9659
			Jpeg = 1
		}
	}
}
