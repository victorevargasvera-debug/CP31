using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002A RID: 42
	public class MemoryArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.BaseArchiveStorage
	{
		// Token: 0x0600019A RID: 410 RVA: 0x000081A1 File Offset: 0x000063A1
		public MemoryArchiveStorage() : base(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000081AA File Offset: 0x000063AA
		public MemoryArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode) : base(updateMode)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000081B3 File Offset: 0x000063B3
		public global::System.IO.MemoryStream FinalStream
		{
			get
			{
				return this.finalStream_;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000081BB File Offset: 0x000063BB
		public override global::System.IO.Stream GetTemporaryOutput()
		{
			this.temporaryStream_ = new global::System.IO.MemoryStream();
			return this.temporaryStream_;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000081CE File Offset: 0x000063CE
		public override global::System.IO.Stream ConvertTemporaryToFinal()
		{
			if (this.temporaryStream_ == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No temporary stream has been created");
			}
			this.finalStream_ = new global::System.IO.MemoryStream(this.temporaryStream_.ToArray());
			return this.finalStream_;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000081FF File Offset: 0x000063FF
		public override global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream)
		{
			this.temporaryStream_ = new global::System.IO.MemoryStream();
			stream.Position = 0L;
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.temporaryStream_, new byte[4096]);
			return this.temporaryStream_;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008230 File Offset: 0x00006430
		public override global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream)
		{
			global::System.IO.Stream stream2;
			if (stream == null || !stream.CanWrite)
			{
				stream2 = new global::System.IO.MemoryStream();
				if (stream != null)
				{
					stream.Position = 0L;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, stream2, new byte[4096]);
					stream.Dispose();
				}
			}
			else
			{
				stream2 = stream;
			}
			return stream2;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008275 File Offset: 0x00006475
		public override void Dispose()
		{
			if (this.temporaryStream_ != null)
			{
				this.temporaryStream_.Dispose();
			}
		}

		// Token: 0x040000E8 RID: 232
		private global::System.IO.MemoryStream temporaryStream_;

		// Token: 0x040000E9 RID: 233
		private global::System.IO.MemoryStream finalStream_;
	}
}
