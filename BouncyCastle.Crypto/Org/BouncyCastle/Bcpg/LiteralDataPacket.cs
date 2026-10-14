using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200057C RID: 1404
	public class LiteralDataPacket : global::Org.BouncyCastle.Bcpg.InputStreamPacket
	{
		// Token: 0x06003566 RID: 13670 RVA: 0x000FE0FC File Offset: 0x000FC2FC
		internal LiteralDataPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
			this.format = bcpgIn.ReadByte();
			int len = bcpgIn.ReadByte();
			this.fileName = new byte[len];
			for (int i = 0; i != len; i++)
			{
				int ch = bcpgIn.ReadByte();
				if (ch < 0)
				{
					throw new global::System.IO.IOException("literal data truncated in header");
				}
				this.fileName[i] = (byte)ch;
			}
			this.modDate = (long)((ulong)(bcpgIn.ReadByte() << 24 | bcpgIn.ReadByte() << 16 | bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte()) * 1000UL);
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x000FE18C File Offset: 0x000FC38C
		public int Format
		{
			get
			{
				return this.format;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x000FE194 File Offset: 0x000FC394
		public long ModificationTime
		{
			get
			{
				return this.modDate;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x000FE19C File Offset: 0x000FC39C
		public string FileName
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Strings.FromUtf8ByteArray(this.fileName);
			}
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x000FE1A9 File Offset: 0x000FC3A9
		public byte[] GetRawFileName()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fileName);
		}

		// Token: 0x040017EC RID: 6124
		private int format;

		// Token: 0x040017ED RID: 6125
		private byte[] fileName;

		// Token: 0x040017EE RID: 6126
		private long modDate;
	}
}
