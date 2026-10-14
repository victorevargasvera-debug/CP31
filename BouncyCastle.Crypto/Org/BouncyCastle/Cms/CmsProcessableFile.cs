using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000532 RID: 1330
	public class CmsProcessableFile : global::Org.BouncyCastle.Cms.CmsProcessable, global::Org.BouncyCastle.Cms.CmsReadable
	{
		// Token: 0x06003350 RID: 13136 RVA: 0x000F4A89 File Offset: 0x000F2C89
		public CmsProcessableFile(global::System.IO.FileInfo file) : this(file, 32768)
		{
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000F4A97 File Offset: 0x000F2C97
		public CmsProcessableFile(global::System.IO.FileInfo file, int bufSize)
		{
			this._file = file;
			this._bufSize = bufSize;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000F4AAD File Offset: 0x000F2CAD
		public virtual global::System.IO.Stream GetInputStream()
		{
			return new global::System.IO.FileStream(this._file.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read, this._bufSize);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000F4AC8 File Offset: 0x000F2CC8
		public virtual void Write(global::System.IO.Stream zOut)
		{
			global::System.IO.FileStream fileStream = this._file.OpenRead();
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(fileStream, zOut, this._bufSize);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(fileStream);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000F4AE7 File Offset: 0x000F2CE7
		[global::System.Obsolete]
		public virtual object GetContent()
		{
			return this._file;
		}

		// Token: 0x040016E8 RID: 5864
		private const int DefaultBufSize = 32768;

		// Token: 0x040016E9 RID: 5865
		private readonly global::System.IO.FileInfo _file;

		// Token: 0x040016EA RID: 5866
		private readonly int _bufSize;
	}
}
