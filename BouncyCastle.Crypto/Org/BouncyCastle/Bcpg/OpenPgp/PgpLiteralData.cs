using System;
using System.IO;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AE RID: 1454
	public class PgpLiteralData : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x06003658 RID: 13912 RVA: 0x001016B0 File Offset: 0x000FF8B0
		public PgpLiteralData(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			global::Org.BouncyCastle.Bcpg.Packet packet = bcpgInput.ReadPacket();
			if (!(packet is global::Org.BouncyCastle.Bcpg.LiteralDataPacket))
			{
				string str = "unexpected packet in stream: ";
				global::Org.BouncyCastle.Bcpg.Packet packet2 = packet;
				throw new global::System.IO.IOException(str + ((packet2 != null) ? packet2.ToString() : null));
			}
			this.data = (global::Org.BouncyCastle.Bcpg.LiteralDataPacket)packet;
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x001016FB File Offset: 0x000FF8FB
		public int Format
		{
			get
			{
				return this.data.Format;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x00101708 File Offset: 0x000FF908
		public string FileName
		{
			get
			{
				return this.data.FileName;
			}
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00101715 File Offset: 0x000FF915
		public byte[] GetRawFileName()
		{
			return this.data.GetRawFileName();
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x00101722 File Offset: 0x000FF922
		public global::System.DateTime ModificationTime
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixMsToDateTime(this.data.ModificationTime);
			}
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00101734 File Offset: 0x000FF934
		public global::System.IO.Stream GetInputStream()
		{
			return this.data.GetInputStream();
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00101741 File Offset: 0x000FF941
		public global::System.IO.Stream GetDataStream()
		{
			return this.GetInputStream();
		}

		// Token: 0x040018C4 RID: 6340
		public const char Binary = 'b';

		// Token: 0x040018C5 RID: 6341
		public const char Text = 't';

		// Token: 0x040018C6 RID: 6342
		public const char Utf8 = 'u';

		// Token: 0x040018C7 RID: 6343
		public const string Console = "_CONSOLE";

		// Token: 0x040018C8 RID: 6344
		private readonly global::Org.BouncyCastle.Bcpg.LiteralDataPacket data;
	}
}
