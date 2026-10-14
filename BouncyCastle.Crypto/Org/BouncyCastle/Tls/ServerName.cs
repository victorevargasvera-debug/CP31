using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E8 RID: 232
	public sealed class ServerName
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x00022AE0 File Offset: 0x00020CE0
		public ServerName(short nameType, byte[] nameData)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(nameType))
			{
				throw new global::System.ArgumentException("must be from 0 to 255", "nameType");
			}
			if (nameData == null)
			{
				throw new global::System.ArgumentNullException("nameData");
			}
			if (nameData.Length < 1 || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(nameData.Length))
			{
				throw new global::System.ArgumentException("must have length from 1 to 65535", "nameData");
			}
			this.nameType = nameType;
			this.nameData = nameData;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00022B47 File Offset: 0x00020D47
		public byte[] NameData
		{
			get
			{
				return this.nameData;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00022B4F File Offset: 0x00020D4F
		public short NameType
		{
			get
			{
				return this.nameType;
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00022B57 File Offset: 0x00020D57
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.nameType, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.nameData, output);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00022B74 File Offset: 0x00020D74
		public static global::Org.BouncyCastle.Tls.ServerName Parse(global::System.IO.Stream input)
		{
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			byte[] nameData = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
			return new global::Org.BouncyCastle.Tls.ServerName(num, nameData);
		}

		// Token: 0x04000678 RID: 1656
		private readonly short nameType;

		// Token: 0x04000679 RID: 1657
		private readonly byte[] nameData;
	}
}
