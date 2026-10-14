using System;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace Gibraltar.Data
{
	// Token: 0x020000DD RID: 221
	internal sealed class FileLock : global::System.IDisposable
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x000148D4 File Offset: 0x00012AD4
		private FileLock(string fileName, global::System.IO.FileMode creationMode, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare, bool manualDeleteOnClose)
		{
			this.m_FileName = fileName;
			this.m_CreationMode = creationMode;
			this.m_FileShare = fileShare;
			this.m_FileAccess = fileAccess;
			this.m_DeleteOnClose = manualDeleteOnClose;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00014904 File Offset: 0x00012B04
		internal FileLock(global::Microsoft.Win32.SafeHandles.SafeFileHandle fileHandle, string fileName, global::System.IO.FileMode creationMode, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare, bool manualDeleteOnClose) : this(fileName, creationMode, fileAccess, fileShare, manualDeleteOnClose)
		{
			this.m_FileHandle = fileHandle;
			this.m_FileStream = null;
			this.m_HaveStream = false;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0001492C File Offset: 0x00012B2C
		internal FileLock(global::System.IO.FileStream fileStream, string fileName, global::System.IO.FileMode creationMode, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare, bool manualDeleteOnClose) : this(fileName, creationMode, fileAccess, fileShare, manualDeleteOnClose)
		{
			this.m_FileHandle = null;
			this.m_FileStream = fileStream;
			this.m_HaveStream = (this.m_FileStream != null);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001495C File Offset: 0x00012B5C
		public global::System.IO.FileStream GetFileStream()
		{
			if (!this.m_HaveStream && this.m_FileHandle != null && !this.m_FileHandle.IsInvalid && !this.m_FileHandle.IsClosed)
			{
				try
				{
					this.m_FileStream = new global::System.IO.FileStream(this.m_FileHandle, this.m_FileAccess);
					this.m_HaveStream = true;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
			}
			return this.m_FileStream;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000149E4 File Offset: 0x00012BE4
		public void Dispose()
		{
			if (this.m_DeleteOnClose && global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				global::Gibraltar.Data.Win32Helper.SafeDeleteFile(this.m_FileName);
			}
			if (this.m_HaveStream)
			{
				this.m_FileStream.Dispose();
			}
			else if (this.m_FileHandle != null && !this.m_FileHandle.IsClosed && !this.m_FileHandle.IsInvalid)
			{
				this.m_FileHandle.Dispose();
			}
			this.m_HaveStream = false;
			this.m_FileStream = null;
			if (this.m_DeleteOnClose && !global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				global::Gibraltar.Data.Win32Helper.SafeDeleteFile(this.m_FileName);
			}
		}

		// Token: 0x04000215 RID: 533
		private readonly string m_FileName;

		// Token: 0x04000216 RID: 534
		private readonly global::System.IO.FileMode m_CreationMode;

		// Token: 0x04000217 RID: 535
		private readonly global::System.IO.FileShare m_FileShare;

		// Token: 0x04000218 RID: 536
		private readonly global::System.IO.FileAccess m_FileAccess;

		// Token: 0x04000219 RID: 537
		private readonly bool m_DeleteOnClose;

		// Token: 0x0400021A RID: 538
		private readonly global::Microsoft.Win32.SafeHandles.SafeFileHandle m_FileHandle;

		// Token: 0x0400021B RID: 539
		private global::System.IO.FileStream m_FileStream;

		// Token: 0x0400021C RID: 540
		private bool m_HaveStream;
	}
}
