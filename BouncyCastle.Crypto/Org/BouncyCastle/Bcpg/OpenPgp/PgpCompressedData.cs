using System;
using System.IO;
using Org.BouncyCastle.Apache.Bzip2;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A1 RID: 1441
	public class PgpCompressedData : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x0600360B RID: 13835 RVA: 0x001004B0 File Offset: 0x000FE6B0
		public PgpCompressedData(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			global::Org.BouncyCastle.Bcpg.Packet packet = bcpgInput.ReadPacket();
			if (!(packet is global::Org.BouncyCastle.Bcpg.CompressedDataPacket))
			{
				string str = "unexpected packet in stream: ";
				global::Org.BouncyCastle.Bcpg.Packet packet2 = packet;
				throw new global::System.IO.IOException(str + ((packet2 != null) ? packet2.ToString() : null));
			}
			this.data = (global::Org.BouncyCastle.Bcpg.CompressedDataPacket)packet;
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x001004FB File Offset: 0x000FE6FB
		public global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag Algorithm
		{
			get
			{
				return this.data.Algorithm;
			}
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00100508 File Offset: 0x000FE708
		public global::System.IO.Stream GetInputStream()
		{
			return this.data.GetInputStream();
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00100518 File Offset: 0x000FE718
		public global::System.IO.Stream GetDataStream()
		{
			switch (this.Algorithm)
			{
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.Uncompressed:
				return this.GetInputStream();
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.Zip:
				return new global::Org.BouncyCastle.Utilities.Zlib.ZInputStream(this.GetInputStream(), true);
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.ZLib:
				return new global::Org.BouncyCastle.Utilities.Zlib.ZInputStream(this.GetInputStream());
			case global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag.BZip2:
				return new global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream(this.GetInputStream());
			default:
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't recognise compression algorithm: " + this.Algorithm.ToString());
			}
		}

		// Token: 0x0400189D RID: 6301
		private readonly global::Org.BouncyCastle.Bcpg.CompressedDataPacket data;
	}
}
