using System;
using System.IO;
using System.Text;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D1 RID: 1489
	public class NotationData : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x06003800 RID: 14336 RVA: 0x001087B7 File Offset: 0x001069B7
		public NotationData(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.NotationData, critical, isLongLength, data)
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x001087C4 File Offset: 0x001069C4
		public NotationData(bool critical, bool humanReadable, string notationName, string notationValue) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.NotationData, critical, false, global::Org.BouncyCastle.Bcpg.Sig.NotationData.CreateData(humanReadable, notationName, notationValue))
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x001087DC File Offset: 0x001069DC
		private static byte[] CreateData(bool humanReadable, string notationName, string notationValue)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(humanReadable ? 128 : 0);
			memoryStream.WriteByte(0);
			memoryStream.WriteByte(0);
			memoryStream.WriteByte(0);
			byte[] nameData = global::System.Text.Encoding.UTF8.GetBytes(notationName);
			int nameLength = global::System.Math.Min(nameData.Length, 255);
			byte[] valueData = global::System.Text.Encoding.UTF8.GetBytes(notationValue);
			int valueLength = global::System.Math.Min(valueData.Length, 255);
			memoryStream.WriteByte((byte)(nameLength >> 8));
			memoryStream.WriteByte((byte)nameLength);
			memoryStream.WriteByte((byte)(valueLength >> 8));
			memoryStream.WriteByte((byte)valueLength);
			memoryStream.Write(nameData, 0, nameLength);
			memoryStream.Write(valueData, 0, valueLength);
			return memoryStream.ToArray();
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x00108885 File Offset: 0x00106A85
		public bool IsHumanReadable
		{
			get
			{
				return this.data[0] == 128;
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00108898 File Offset: 0x00106A98
		public string GetNotationName()
		{
			int nameLength = ((int)this.data[4] << 8) + (int)this.data[5];
			int namePos = 8;
			return global::System.Text.Encoding.UTF8.GetString(this.data, namePos, nameLength);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x001088D0 File Offset: 0x00106AD0
		public string GetNotationValue()
		{
			int nameLength = ((int)this.data[4] << 8) + (int)this.data[5];
			int valueLength = ((int)this.data[6] << 8) + (int)this.data[7];
			int valuePos = 8 + nameLength;
			return global::System.Text.Encoding.UTF8.GetString(this.data, valuePos, valueLength);
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x0010891C File Offset: 0x00106B1C
		public byte[] GetNotationValueBytes()
		{
			int nameLength = ((int)this.data[4] << 8) + (int)this.data[5];
			int valueLength = ((int)this.data[6] << 8) + (int)this.data[7];
			int valuePos = 8 + nameLength;
			byte[] bytes = new byte[valueLength];
			global::System.Array.Copy(this.data, valuePos, bytes, 0, valueLength);
			return bytes;
		}

		// Token: 0x04001925 RID: 6437
		public const int HeaderFlagLength = 4;

		// Token: 0x04001926 RID: 6438
		public const int HeaderNameLength = 2;

		// Token: 0x04001927 RID: 6439
		public const int HeaderValueLength = 2;
	}
}
