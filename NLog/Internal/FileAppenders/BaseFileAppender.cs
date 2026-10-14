using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;
using NLog.Common;
using NLog.Time;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x0200013C RID: 316
	[global::System.Security.SecuritySafeCritical]
	internal abstract class BaseFileAppender : global::System.IDisposable
	{
		// Token: 0x06000E31 RID: 3633 RVA: 0x00024122 File Offset: 0x00022322
		protected BaseFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters createParameters)
		{
			this.CreateFileParameters = createParameters;
			this.FileName = fileName;
			this.OpenTimeUtc = global::System.DateTime.UtcNow;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x0002414E File Offset: 0x0002234E
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00024156 File Offset: 0x00022356
		public string FileName { get; private set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0002415F File Offset: 0x0002235F
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00024167 File Offset: 0x00022367
		public global::System.DateTime CreationTimeUtc
		{
			get
			{
				return this._creationTimeUtc;
			}
			internal set
			{
				this._creationTimeUtc = value;
				this.CreationTimeSource = global::NLog.Time.TimeSource.Current.FromSystemTime(value);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00024181 File Offset: 0x00022381
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00024189 File Offset: 0x00022389
		public global::System.DateTime CreationTimeSource { get; private set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00024192 File Offset: 0x00022392
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x0002419A File Offset: 0x0002239A
		public global::System.DateTime OpenTimeUtc { get; private set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000241A3 File Offset: 0x000223A3
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x000241AB File Offset: 0x000223AB
		public global::NLog.Internal.FileAppenders.ICreateFileParameters CreateFileParameters { get; private set; }

		// Token: 0x06000E3C RID: 3644 RVA: 0x000241B4 File Offset: 0x000223B4
		public void Write(byte[] bytes)
		{
			this.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x06000E3D RID: 3645
		public abstract void Write(byte[] bytes, int offset, int count);

		// Token: 0x06000E3E RID: 3646
		public abstract void Flush();

		// Token: 0x06000E3F RID: 3647
		public abstract void Close();

		// Token: 0x06000E40 RID: 3648
		public abstract global::System.DateTime? GetFileCreationTimeUtc();

		// Token: 0x06000E41 RID: 3649
		public abstract long? GetFileLength();

		// Token: 0x06000E42 RID: 3650 RVA: 0x000241C1 File Offset: 0x000223C1
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000241D0 File Offset: 0x000223D0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000241DC File Offset: 0x000223DC
		protected global::System.IO.FileStream CreateFileStream(bool allowFileSharedWriting)
		{
			int num = this.CreateFileParameters.ConcurrentWriteAttemptDelay;
			global::NLog.Common.InternalLogger.Trace<string, bool>("Opening {0} with allowFileSharedWriting={1}", this.FileName, allowFileSharedWriting);
			for (int i = 0; i < this.CreateFileParameters.ConcurrentWriteAttempts; i++)
			{
				try
				{
					try
					{
						return this.TryCreateFileStream(allowFileSharedWriting);
					}
					catch (global::System.IO.DirectoryNotFoundException)
					{
						if (!this.CreateFileParameters.CreateDirs)
						{
							throw;
						}
						string directoryName = global::System.IO.Path.GetDirectoryName(this.FileName);
						try
						{
							global::System.IO.Directory.CreateDirectory(directoryName);
						}
						catch (global::System.IO.DirectoryNotFoundException)
						{
							throw new global::NLog.NLogRuntimeException("Could not create directory {0}", new object[]
							{
								directoryName
							});
						}
						return this.TryCreateFileStream(allowFileSharedWriting);
					}
				}
				catch (global::System.IO.IOException)
				{
					if (!this.CreateFileParameters.ConcurrentWrites || i + 1 == this.CreateFileParameters.ConcurrentWriteAttempts)
					{
						throw;
					}
					int num2 = this._random.Next(num);
					global::NLog.Common.InternalLogger.Warn<int, string, int>("Attempt #{0} to open {1} failed. Sleeping for {2}ms", i, this.FileName, num2);
					num *= 2;
					global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds((double)num2));
				}
			}
			throw new global::System.InvalidOperationException("Should not be reached.");
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00024300 File Offset: 0x00022500
		private global::System.IO.FileStream WindowsCreateFile(string fileName, bool allowFileSharedWriting)
		{
			int num = 1;
			if (allowFileSharedWriting)
			{
				num |= 2;
			}
			if (this.CreateFileParameters.EnableFileDelete && global::NLog.Internal.PlatformDetector.CurrentOS != global::NLog.Internal.RuntimeOS.Windows)
			{
				num |= 4;
			}
			global::Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = null;
			global::System.IO.FileStream fileStream = null;
			global::System.IO.FileStream result;
			try
			{
				safeFileHandle = global::NLog.Internal.Win32FileNativeMethods.CreateFile(fileName, global::NLog.Internal.Win32FileNativeMethods.FileAccess.GenericWrite, num, global::System.IntPtr.Zero, global::NLog.Internal.Win32FileNativeMethods.CreationDisposition.OpenAlways, this.CreateFileParameters.FileAttributes, global::System.IntPtr.Zero);
				if (safeFileHandle.IsInvalid)
				{
					global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(global::System.Runtime.InteropServices.Marshal.GetHRForLastWin32Error());
				}
				fileStream = new global::System.IO.FileStream(safeFileHandle, global::System.IO.FileAccess.Write, this.CreateFileParameters.BufferSize);
				fileStream.Seek(0L, global::System.IO.SeekOrigin.End);
				result = fileStream;
			}
			catch
			{
				if (fileStream != null)
				{
					fileStream.Dispose();
				}
				if (safeFileHandle != null && !safeFileHandle.IsClosed)
				{
					safeFileHandle.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000243B8 File Offset: 0x000225B8
		private global::System.IO.FileStream TryCreateFileStream(bool allowFileSharedWriting)
		{
			this.UpdateCreationTime();
			try
			{
				if (!this.CreateFileParameters.ForceManaged && global::NLog.Internal.PlatformDetector.IsDesktopWin32 && !global::NLog.Internal.PlatformDetector.IsMono)
				{
					return this.WindowsCreateFile(this.FileName, allowFileSharedWriting);
				}
			}
			catch (global::System.Security.SecurityException)
			{
				global::NLog.Common.InternalLogger.Debug<string>("Could not use native Windows create file, falling back to managed filestream: {0}", this.FileName);
			}
			global::System.IO.FileShare fileShare = allowFileSharedWriting ? global::System.IO.FileShare.ReadWrite : global::System.IO.FileShare.Read;
			if (this.CreateFileParameters.EnableFileDelete)
			{
				fileShare |= global::System.IO.FileShare.Delete;
			}
			return new global::System.IO.FileStream(this.FileName, global::System.IO.FileMode.Append, global::System.IO.FileAccess.Write, fileShare, this.CreateFileParameters.BufferSize);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00024450 File Offset: 0x00022650
		private void UpdateCreationTime()
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.FileName);
			if (fileInfo.Exists)
			{
				this.CreationTimeUtc = global::NLog.Internal.FileCharacteristicsHelper.ValidateFileCreationTime<global::System.IO.FileInfo>(fileInfo, (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetCreationTimeUtc()), (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetLastWriteTimeUtc()), null).Value;
				return;
			}
			global::System.IO.File.Create(this.FileName).Dispose();
			this.CreationTimeUtc = global::System.DateTime.UtcNow;
			global::System.IO.File.SetCreationTimeUtc(this.FileName, this.CreationTimeUtc);
		}

		// Token: 0x040003ED RID: 1005
		private readonly global::System.Random _random = new global::System.Random();

		// Token: 0x040003EF RID: 1007
		private global::System.DateTime _creationTimeUtc;
	}
}
