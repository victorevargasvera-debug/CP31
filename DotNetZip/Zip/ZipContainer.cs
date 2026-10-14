using System;
using System.IO;
using System.Text;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000057 RID: 87
	internal class ZipContainer
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x0001A53A File Offset: 0x0001873A
		public ZipContainer(object o)
		{
			this._zf = (o as global::Ionic.Zip.ZipFile);
			this._zos = (o as global::Ionic.Zip.ZipOutputStream);
			this._zis = (o as global::Ionic.Zip.ZipInputStream);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001A566 File Offset: 0x00018766
		public global::Ionic.Zip.ZipFile ZipFile
		{
			get
			{
				return this._zf;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001A56E File Offset: 0x0001876E
		public global::Ionic.Zip.ZipOutputStream ZipOutputStream
		{
			get
			{
				return this._zos;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001A576 File Offset: 0x00018776
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0001A5A5 File Offset: 0x000187A5
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001A5DA File Offset: 0x000187DA
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001A609 File Offset: 0x00018809
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001A62E File Offset: 0x0001882E
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0001A659 File Offset: 0x00018859
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001A684 File Offset: 0x00018884
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001A6A5 File Offset: 0x000188A5
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001A6C6 File Offset: 0x000188C6
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001A6FB File Offset: 0x000188FB
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001A71C File Offset: 0x0001891C
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001A73D File Offset: 0x0001893D
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0001A768 File Offset: 0x00018968
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001A787 File Offset: 0x00018987
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001A7B2 File Offset: 0x000189B2
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

		// Token: 0x040002DF RID: 735
		private global::Ionic.Zip.ZipFile _zf;

		// Token: 0x040002E0 RID: 736
		private global::Ionic.Zip.ZipOutputStream _zos;

		// Token: 0x040002E1 RID: 737
		private global::Ionic.Zip.ZipInputStream _zis;
	}
}
