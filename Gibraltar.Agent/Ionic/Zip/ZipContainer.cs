using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000475 RID: 1141
	internal class ZipContainer
	{
		// Token: 0x06003262 RID: 12898 RVA: 0x000B812C File Offset: 0x000B632C
		public ZipContainer(object o)
		{
			this._zf = (o as global::Ionic.Zip.ZipFile);
			this._zos = (o as global::Ionic.Zip.ZipOutputStream);
			this._zis = (o as global::Ionic.Zip.ZipInputStream);
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000B8158 File Offset: 0x000B6358
		public global::Ionic.Zip.ZipFile ZipFile
		{
			get
			{
				return this._zf;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x000B8160 File Offset: 0x000B6360
		public global::Ionic.Zip.ZipOutputStream ZipOutputStream
		{
			get
			{
				return this._zos;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x000B8168 File Offset: 0x000B6368
		public string Name
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.Name;
				}
				if (this._zis != null)
				{
					throw new global::System.NotSupportedException();
				}
				return this._zos.Name;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x000B81A0 File Offset: 0x000B63A0
		public string Password
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf._Password;
				}
				if (this._zis != null)
				{
					return this._zis._Password;
				}
				return this._zos._password;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000B81DC File Offset: 0x000B63DC
		public global::Ionic.Zip.Zip64Option Zip64
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf._zip64;
				}
				if (this._zis != null)
				{
					throw new global::System.NotSupportedException();
				}
				return this._zos._zip64;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003268 RID: 12904 RVA: 0x000B8214 File Offset: 0x000B6414
		public int BufferSize
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.BufferSize;
				}
				if (this._zis != null)
				{
					throw new global::System.NotSupportedException();
				}
				return 0;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000B8240 File Offset: 0x000B6440
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x000B8274 File Offset: 0x000B6474
		public global::Ionic.Zlib.ParallelDeflateOutputStream ParallelDeflater
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.ParallelDeflater;
				}
				if (this._zis != null)
				{
					return null;
				}
				return this._zos.ParallelDeflater;
			}
			set
			{
				if (this._zf != null)
				{
					this._zf.ParallelDeflater = value;
					return;
				}
				if (this._zos != null)
				{
					this._zos.ParallelDeflater = value;
				}
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000B82A8 File Offset: 0x000B64A8
		public long ParallelDeflateThreshold
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.ParallelDeflateThreshold;
				}
				return this._zos.ParallelDeflateThreshold;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x000B82CC File Offset: 0x000B64CC
		public int ParallelDeflateMaxBufferPairs
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.ParallelDeflateMaxBufferPairs;
				}
				return this._zos.ParallelDeflateMaxBufferPairs;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000B82F0 File Offset: 0x000B64F0
		public int CodecBufferSize
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.CodecBufferSize;
				}
				if (this._zis != null)
				{
					return this._zis.CodecBufferSize;
				}
				return this._zos.CodecBufferSize;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x000B832C File Offset: 0x000B652C
		public global::Ionic.Zlib.CompressionStrategy Strategy
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.Strategy;
				}
				return this._zos.Strategy;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000B8350 File Offset: 0x000B6550
		public global::Ionic.Zip.Zip64Option UseZip64WhenSaving
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.UseZip64WhenSaving;
				}
				return this._zos.EnableZip64;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003270 RID: 12912 RVA: 0x000B8374 File Offset: 0x000B6574
		public global::System.Text.Encoding AlternateEncoding
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.AlternateEncoding;
				}
				if (this._zos != null)
				{
					return this._zos.AlternateEncoding;
				}
				return null;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x000B83A8 File Offset: 0x000B65A8
		public global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				if (this._zf != null)
				{
					return global::Ionic.Zip.ZipFile.DefaultEncoding;
				}
				if (this._zos != null)
				{
					return global::Ionic.Zip.ZipOutputStream.DefaultEncoding;
				}
				return null;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003272 RID: 12914 RVA: 0x000B83D0 File Offset: 0x000B65D0
		public global::Ionic.Zip.ZipOption AlternateEncodingUsage
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.AlternateEncodingUsage;
				}
				if (this._zos != null)
				{
					return this._zos.AlternateEncodingUsage;
				}
				return global::Ionic.Zip.ZipOption.Default;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000B8404 File Offset: 0x000B6604
		public global::System.IO.Stream ReadStream
		{
			get
			{
				if (this._zf != null)
				{
					return this._zf.ReadStream;
				}
				return this._zis.ReadStream;
			}
		}

		// Token: 0x040012B3 RID: 4787
		private global::Ionic.Zip.ZipFile _zf;

		// Token: 0x040012B4 RID: 4788
		private global::Ionic.Zip.ZipOutputStream _zos;

		// Token: 0x040012B5 RID: 4789
		private global::Ionic.Zip.ZipInputStream _zis;
	}
}
