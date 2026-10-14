using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058E RID: 1422
	public class SignatureSubpacket
	{
		// Token: 0x060035D5 RID: 13781 RVA: 0x000FFA03 File Offset: 0x000FDC03
		protected internal SignatureSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data)
		{
			this.type = type;
			this.critical = critical;
			this.isLongLength = isLongLength;
			this.data = data;
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000FFA28 File Offset: 0x000FDC28
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag SubpacketType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000FFA30 File Offset: 0x000FDC30
		public bool IsCritical()
		{
			return this.critical;
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x000FFA38 File Offset: 0x000FDC38
		public bool IsLongLength()
		{
			return this.isLongLength;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x000FFA40 File Offset: 0x000FDC40
		public byte[] GetData()
		{
			return (byte[])this.data.Clone();
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x000FFA54 File Offset: 0x000FDC54
		public void Encode(global::System.IO.Stream os)
		{
			int bodyLen = this.data.Length + 1;
			if (this.isLongLength)
			{
				os.WriteByte(byte.MaxValue);
				os.WriteByte((byte)(bodyLen >> 24));
				os.WriteByte((byte)(bodyLen >> 16));
				os.WriteByte((byte)(bodyLen >> 8));
				os.WriteByte((byte)bodyLen);
			}
			else if (bodyLen < 192)
			{
				os.WriteByte((byte)bodyLen);
			}
			else if (bodyLen <= 8383)
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
			if (this.critical)
			{
				os.WriteByte((byte)((global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag)128 | this.type));
			}
			else
			{
				os.WriteByte((byte)this.type);
			}
			os.Write(this.data, 0, this.data.Length);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x000FFB5D File Offset: 0x000FDD5D
		public override int GetHashCode()
		{
			return (int)((this.critical ? 1 : 0) + global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Revocable * this.type + 49 * global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.data));
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x000FFB84 File Offset: 0x000FDD84
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket other = obj as global::Org.BouncyCastle.Bcpg.SignatureSubpacket;
			return other != null && (this.type == other.type && this.critical == other.critical) && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.data, other.data);
		}

		// Token: 0x04001859 RID: 6233
		private readonly global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type;

		// Token: 0x0400185A RID: 6234
		private readonly bool critical;

		// Token: 0x0400185B RID: 6235
		private readonly bool isLongLength;

		// Token: 0x0400185C RID: 6236
		internal byte[] data;
	}
}
