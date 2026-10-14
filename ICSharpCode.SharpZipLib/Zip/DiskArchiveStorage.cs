using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000029 RID: 41
	public class DiskArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.BaseArchiveStorage
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00008004 File Offset: 0x00006204
		public DiskArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.ZipFile file, global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode) : base(updateMode)
		{
			if (file.Name == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cant handle non file archives");
			}
			this.fileName_ = file.Name;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000802C File Offset: 0x0000622C
		public DiskArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.ZipFile file) : this(file, global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008036 File Offset: 0x00006236
		public override global::System.IO.Stream GetTemporaryOutput()
		{
			this.temporaryName_ = global::ICSharpCode.SharpZipLib.Core.PathUtils.GetTempFileName(this.temporaryName_);
			this.temporaryStream_ = global::System.IO.File.Open(this.temporaryName_, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.Write, global::System.IO.FileShare.None);
			return this.temporaryStream_;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008064 File Offset: 0x00006264
		public override global::System.IO.Stream ConvertTemporaryToFinal()
		{
			if (this.temporaryStream_ == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No temporary stream has been created");
			}
			global::System.IO.Stream result = null;
			string tempFileName = global::ICSharpCode.SharpZipLib.Core.PathUtils.GetTempFileName(this.fileName_);
			bool flag = false;
			try
			{
				this.temporaryStream_.Dispose();
				global::System.IO.File.Move(this.fileName_, tempFileName);
				global::System.IO.File.Move(this.temporaryName_, this.fileName_);
				flag = true;
				global::System.IO.File.Delete(tempFileName);
				result = global::System.IO.File.Open(this.fileName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			}
			catch (global::System.Exception)
			{
				result = null;
				if (!flag)
				{
					global::System.IO.File.Move(tempFileName, this.fileName_);
					global::System.IO.File.Delete(this.temporaryName_);
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008108 File Offset: 0x00006308
		public override global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream)
		{
			stream.Dispose();
			this.temporaryName_ = global::ICSharpCode.SharpZipLib.Core.PathUtils.GetTempFileName(this.fileName_);
			global::System.IO.File.Copy(this.fileName_, this.temporaryName_, true);
			this.temporaryStream_ = new global::System.IO.FileStream(this.temporaryName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
			return this.temporaryStream_;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008158 File Offset: 0x00006358
		public override global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream)
		{
			global::System.IO.Stream result;
			if (stream == null || !stream.CanWrite)
			{
				if (stream != null)
				{
					stream.Dispose();
				}
				result = new global::System.IO.FileStream(this.fileName_, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
			}
			else
			{
				result = stream;
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000818C File Offset: 0x0000638C
		public override void Dispose()
		{
			if (this.temporaryStream_ != null)
			{
				this.temporaryStream_.Dispose();
			}
		}

		// Token: 0x040000E5 RID: 229
		private global::System.IO.Stream temporaryStream_;

		// Token: 0x040000E6 RID: 230
		private readonly string fileName_;

		// Token: 0x040000E7 RID: 231
		private string temporaryName_;
	}
}
