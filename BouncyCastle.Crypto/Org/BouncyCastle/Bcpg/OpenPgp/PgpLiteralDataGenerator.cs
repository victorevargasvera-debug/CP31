using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AF RID: 1455
	public class PgpLiteralDataGenerator : global::Org.BouncyCastle.Bcpg.OpenPgp.IStreamGenerator
	{
		// Token: 0x0600365F RID: 13919 RVA: 0x00101749 File Offset: 0x000FF949
		public PgpLiteralDataGenerator()
		{
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00101751 File Offset: 0x000FF951
		public PgpLiteralDataGenerator(bool oldFormat)
		{
			this.oldFormat = oldFormat;
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00101760 File Offset: 0x000FF960
		private void WriteHeader(global::Org.BouncyCastle.Bcpg.BcpgOutputStream outStr, char format, byte[] encName, long modificationTime)
		{
			outStr.Write(new byte[]
			{
				(byte)format,
				(byte)encName.Length
			});
			outStr.Write(encName);
			long modDate = modificationTime / 1000L;
			outStr.Write(new byte[]
			{
				(byte)(modDate >> 24),
				(byte)(modDate >> 16),
				(byte)(modDate >> 8),
				(byte)modDate
			});
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x001017C0 File Offset: 0x000FF9C0
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, char format, string name, long length, global::System.DateTime modificationTime)
		{
			if (this.pkOut != null)
			{
				throw new global::System.InvalidOperationException("generator already in open state");
			}
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			long unixMs = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(modificationTime);
			byte[] encName = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(name);
			this.pkOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.LiteralData, length + 2L + (long)encName.Length + 4L, this.oldFormat);
			this.WriteHeader(this.pkOut, format, encName, unixMs);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.WrappedGeneratorStream(this, this.pkOut);
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0010183C File Offset: 0x000FFA3C
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, char format, string name, global::System.DateTime modificationTime, byte[] buffer)
		{
			if (this.pkOut != null)
			{
				throw new global::System.InvalidOperationException("generator already in open state");
			}
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			long unixMs = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(modificationTime);
			byte[] encName = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(name);
			this.pkOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.LiteralData, buffer);
			this.WriteHeader(this.pkOut, format, encName, unixMs);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.WrappedGeneratorStream(this, this.pkOut);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x001018A4 File Offset: 0x000FFAA4
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, char format, global::System.IO.FileInfo file)
		{
			return this.Open(outStr, format, file.Name, file.Length, file.LastWriteTime);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x001018C0 File Offset: 0x000FFAC0
		public void Close()
		{
			if (this.pkOut != null)
			{
				this.pkOut.Finish();
				this.pkOut.Flush();
				this.pkOut = null;
			}
		}

		// Token: 0x040018C9 RID: 6345
		public const char Binary = 'b';

		// Token: 0x040018CA RID: 6346
		public const char Text = 't';

		// Token: 0x040018CB RID: 6347
		public const char Utf8 = 'u';

		// Token: 0x040018CC RID: 6348
		public const string Console = "_CONSOLE";

		// Token: 0x040018CD RID: 6349
		private global::Org.BouncyCastle.Bcpg.BcpgOutputStream pkOut;

		// Token: 0x040018CE RID: 6350
		private bool oldFormat;
	}
}
