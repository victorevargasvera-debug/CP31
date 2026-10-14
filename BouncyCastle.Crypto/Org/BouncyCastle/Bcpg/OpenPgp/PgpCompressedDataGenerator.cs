using System;
using System.IO;
using Org.BouncyCastle.Apache.Bzip2;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A2 RID: 1442
	public class PgpCompressedDataGenerator : global::Org.BouncyCastle.Bcpg.OpenPgp.IStreamGenerator
	{
		// Token: 0x0600360F RID: 13839 RVA: 0x00100593 File Offset: 0x000FE793
		public PgpCompressedDataGenerator(global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag algorithm) : this(algorithm, -1)
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x001005A0 File Offset: 0x000FE7A0
		public PgpCompressedDataGenerator(global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag algorithm, int compression)
		{
			if (algorithm > global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.BZip2)
			{
				throw new global::System.ArgumentException("unknown compression algorithm", "algorithm");
			}
			if (compression != -1 && (compression < 0 || compression > 9))
			{
				throw new global::System.ArgumentException("unknown compression level: " + compression.ToString());
			}
			this.algorithm = algorithm;
			this.compression = compression;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x001005FC File Offset: 0x000FE7FC
		public global::System.IO.Stream Open(global::System.IO.Stream outStr)
		{
			if (this.dOut != null)
			{
				throw new global::System.InvalidOperationException("generator already in open state");
			}
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.pkOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.CompressedData);
			this.doOpen();
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.WrappedGeneratorStream(this, this.dOut);
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x0010064C File Offset: 0x000FE84C
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, byte[] buffer)
		{
			if (this.dOut != null)
			{
				throw new global::System.InvalidOperationException("generator already in open state");
			}
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			this.pkOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.CompressedData, buffer);
			this.doOpen();
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.WrappedGeneratorStream(this, this.dOut);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x001006A8 File Offset: 0x000FE8A8
		private void doOpen()
		{
			this.pkOut.WriteByte((byte)this.algorithm);
			switch (this.algorithm)
			{
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.Uncompressed:
				this.dOut = this.pkOut;
				return;
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.Zip:
				this.dOut = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpCompressedDataGenerator.SafeZOutputStream(this.pkOut, this.compression, true);
				return;
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.ZLib:
				this.dOut = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpCompressedDataGenerator.SafeZOutputStream(this.pkOut, this.compression, false);
				return;
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.BZip2:
				this.dOut = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpCompressedDataGenerator.SafeCBZip2OutputStream(this.pkOut);
				return;
			default:
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0010073C File Offset: 0x000FE93C
		public void Close()
		{
			if (this.dOut != null)
			{
				if (this.dOut != this.pkOut)
				{
					global::Org.BouncyCastle.Utilities.Platform.Dispose(this.dOut);
				}
				this.dOut = null;
				this.pkOut.Finish();
				this.pkOut.Flush();
				this.pkOut = null;
			}
		}

		// Token: 0x0400189E RID: 6302
		private readonly global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag algorithm;

		// Token: 0x0400189F RID: 6303
		private readonly int compression;

		// Token: 0x040018A0 RID: 6304
		private global::System.IO.Stream dOut;

		// Token: 0x040018A1 RID: 6305
		private global::Org.BouncyCastle.Bcpg.BcpgOutputStream pkOut;

		// Token: 0x02000844 RID: 2116
		private class SafeCBZip2OutputStream : global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream
		{
			// Token: 0x06004734 RID: 18228 RVA: 0x0013AEB7 File Offset: 0x001390B7
			public SafeCBZip2OutputStream(global::System.IO.Stream output) : base(output)
			{
			}

			// Token: 0x06004735 RID: 18229 RVA: 0x0013AEC0 File Offset: 0x001390C0
			public override void Close()
			{
				base.Finish();
			}
		}

		// Token: 0x02000845 RID: 2117
		private class SafeZOutputStream : global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream
		{
			// Token: 0x06004736 RID: 18230 RVA: 0x0013AEC8 File Offset: 0x001390C8
			public SafeZOutputStream(global::System.IO.Stream output, int level, bool nowrap) : base(output, level, nowrap)
			{
			}

			// Token: 0x06004737 RID: 18231 RVA: 0x0013AED3 File Offset: 0x001390D3
			public override void Close()
			{
				this.Finish();
				this.End();
			}
		}
	}
}
