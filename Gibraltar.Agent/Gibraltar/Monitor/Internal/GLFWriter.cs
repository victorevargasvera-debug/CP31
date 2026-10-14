using System;
using System.Diagnostics;
using System.IO;
using Gibraltar.Data;
using Gibraltar.Serialization;
using Ionic.Zlib;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FA RID: 506
	internal class GLFWriter : global::System.IDisposable
	{
		// Token: 0x06001905 RID: 6405 RVA: 0x000582A8 File Offset: 0x000564A8
		public GLFWriter(global::System.IO.Stream file, global::Gibraltar.Monitor.SessionSummary sessionSummary) : this(file, sessionSummary, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000582BC File Offset: 0x000564BC
		public GLFWriter(global::System.IO.Stream file, global::Gibraltar.Monitor.SessionSummary sessionSummary, int majorVersion, int minorVersion) : this(file, sessionSummary, 1, null, majorVersion, minorVersion)
		{
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000582E4 File Offset: 0x000564E4
		public GLFWriter(global::System.IO.Stream file, global::Gibraltar.Monitor.SessionSummary sessionSummary, int fileSequence, global::System.DateTimeOffset? fileStartTime) : this(file, sessionSummary, fileSequence, fileStartTime, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000582FC File Offset: 0x000564FC
		public GLFWriter(global::System.IO.Stream file, global::Gibraltar.Monitor.SessionSummary sessionSummary, int fileSequence, global::System.DateTimeOffset? fileStartTime, int majorVersion, int minorVersion)
		{
			if (!file.CanSeek)
			{
				throw new global::System.ArgumentException("Provided stream can't be used because it doesn't support seeking", "file");
			}
			this.m_SessionSummary = sessionSummary;
			this.m_OutputStream = file;
			if (majorVersion > 1)
			{
				this.m_PacketStream = new global::Ionic.Zlib.GZipStream(this.m_OutputStream, global::Ionic.Zlib.CompressionMode.Compress, true);
			}
			else
			{
				this.m_PacketStream = new global::System.IO.MemoryStream(17408);
			}
			this.m_PacketWriter = new global::Gibraltar.Serialization.PacketWriter(this.m_PacketStream, majorVersion, minorVersion);
			this.m_FileHeader = new global::Gibraltar.Data.FileHeader(majorVersion, minorVersion);
			this.m_SessionHeader = new global::Gibraltar.Data.SessionHeader(sessionSummary);
			if (fileStartTime != null)
			{
				this.m_SessionHeader.FileId = global::System.Guid.NewGuid();
				this.m_SessionHeader.FileSequence = fileSequence;
				this.m_SessionHeader.FileStartDateTime = fileStartTime.Value;
				this.m_SessionHeader.FileEndDateTime = this.m_SessionHeader.EndDateTime;
				this.m_SessionHeader.IsLastFile = true;
			}
			byte[] array = this.m_SessionHeader.RawData();
			this.m_FileHeader.DataOffset = 20 + array.Length;
			byte[] buffer = this.m_FileHeader.RawData();
			this.m_OutputStream.Position = 0L;
			this.m_OutputStream.Write(buffer, 0, 20);
			this.m_OutputStream.Write(array, 0, array.Length);
			this.m_OutputStream.Flush();
			this.Synchronous = global::System.Diagnostics.Debugger.IsAttached;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00058464 File Offset: 0x00056664
		public virtual void Write(global::Gibraltar.Serialization.IPacket packet)
		{
			this.m_PacketWriter.Write(packet);
			if (this.m_AutoFlush || (this.m_PacketStream is global::System.IO.MemoryStream && this.m_PacketStream.Position >= 16384L))
			{
				this.Flush();
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000584B8 File Offset: 0x000566B8
		public virtual void Write(global::System.IO.Stream sessionPacketStream)
		{
			global::Gibraltar.FileSystemTools.StreamContentPump(sessionPacketStream, this.m_OutputStream);
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x000584C8 File Offset: 0x000566C8
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x000584D0 File Offset: 0x000566D0
		public bool AutoFlush
		{
			get
			{
				return this.m_AutoFlush;
			}
			set
			{
				this.m_AutoFlush = value;
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000584DC File Offset: 0x000566DC
		public void Flush()
		{
			this.UpdateSessionHeader();
			int num = (int)this.m_PacketStream.Position;
			if (num > 0)
			{
				if (this.m_PacketStream is global::System.IO.MemoryStream)
				{
					byte[] buffer = ((global::System.IO.MemoryStream)this.m_PacketStream).GetBuffer();
					this.m_OutputStream.Write(buffer, 0, num);
					this.m_OutputStream.Flush();
					this.m_PacketStream.Position = 0L;
					return;
				}
				this.m_PacketStream.Flush();
				this.m_OutputStream.Flush();
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00058568 File Offset: 0x00056768
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x00058598 File Offset: 0x00056798
		public bool Synchronous
		{
			get
			{
				global::Ionic.Zlib.GZipStream gzipStream = this.m_PacketStream as global::Ionic.Zlib.GZipStream;
				return gzipStream != null && gzipStream.FlushMode == global::Ionic.Zlib.FlushType.Sync;
			}
			set
			{
				global::Ionic.Zlib.GZipStream gzipStream = this.m_PacketStream as global::Ionic.Zlib.GZipStream;
				if (gzipStream == null)
				{
					return;
				}
				if (value)
				{
					gzipStream.FlushMode = global::Ionic.Zlib.FlushType.Sync;
					gzipStream.Flush();
					return;
				}
				gzipStream.FlushMode = global::Ionic.Zlib.FlushType.None;
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000585D8 File Offset: 0x000567D8
		internal static void UpdateSessionHeader(global::Gibraltar.Data.GLFReader sourceFile, global::System.IO.Stream updateFile)
		{
			long position = updateFile.Position;
			try
			{
				updateFile.Position = 20L;
				byte[] array = sourceFile.SessionHeader.RawData();
				updateFile.Write(array, 0, array.Length);
			}
			finally
			{
				updateFile.Position = position;
				updateFile.Flush();
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00058630 File Offset: 0x00056830
		private void UpdateSessionHeader()
		{
			long position = this.m_OutputStream.Position;
			try
			{
				this.m_OutputStream.Position = 20L;
				this.m_SessionHeader.EndDateTime = this.m_SessionSummary.EndDateTime;
				if (this.m_SessionHeader.HasFileInfo)
				{
					this.m_SessionHeader.FileEndDateTime = this.m_SessionSummary.EndDateTime;
				}
				if (this.m_SessionSummary.Status == global::Loupe.Extensibility.Data.SessionStatus.Crashed || this.m_SessionSummary.Status == global::Loupe.Extensibility.Data.SessionStatus.Normal)
				{
					this.m_SessionHeader.StatusName = this.m_SessionSummary.Status.ToString();
				}
				this.m_SessionHeader.MessageCount = this.m_SessionSummary.MessageCount;
				this.m_SessionHeader.CriticalCount = this.m_SessionSummary.CriticalCount;
				this.m_SessionHeader.ErrorCount = this.m_SessionSummary.ErrorCount;
				this.m_SessionHeader.WarningCount = this.m_SessionSummary.WarningCount;
				byte[] array = this.m_SessionHeader.RawData();
				this.m_OutputStream.Write(array, 0, array.Length);
			}
			finally
			{
				this.m_OutputStream.Position = position;
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0005877C File Offset: 0x0005697C
		public virtual void Close(bool isLastFile)
		{
			if (this.m_SessionSummary.Status == global::Loupe.Extensibility.Data.SessionStatus.Crashed)
			{
				this.m_SessionHeader.StatusName = global::Loupe.Extensibility.Data.SessionStatus.Crashed.ToString();
			}
			else
			{
				this.m_SessionHeader.StatusName = global::Loupe.Extensibility.Data.SessionStatus.Normal.ToString();
			}
			this.m_SessionHeader.IsLastFile = isLastFile;
			this.Flush();
			this.m_PacketStream.Close();
			this.m_PacketWriter.Dispose();
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00058800 File Offset: 0x00056A00
		public global::Gibraltar.Data.SessionHeader SessionHeader
		{
			get
			{
				return this.m_SessionHeader;
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00058808 File Offset: 0x00056A08
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00058818 File Offset: 0x00056A18
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_WeAreDisposed)
			{
				this.m_WeAreDisposed = true;
				if (releaseManaged)
				{
					this.Close(false);
				}
			}
		}

		// Token: 0x04000914 RID: 2324
		private const int MaxExpectedPacketSize = 1024;

		// Token: 0x04000915 RID: 2325
		private const int BufferSize = 16384;

		// Token: 0x04000916 RID: 2326
		private readonly global::System.IO.Stream m_OutputStream;

		// Token: 0x04000917 RID: 2327
		private readonly global::System.IO.Stream m_PacketStream;

		// Token: 0x04000918 RID: 2328
		private readonly global::Gibraltar.Serialization.PacketWriter m_PacketWriter;

		// Token: 0x04000919 RID: 2329
		private readonly global::Gibraltar.Data.FileHeader m_FileHeader;

		// Token: 0x0400091A RID: 2330
		private readonly global::Gibraltar.Monitor.SessionSummary m_SessionSummary;

		// Token: 0x0400091B RID: 2331
		private readonly global::Gibraltar.Data.SessionHeader m_SessionHeader;

		// Token: 0x0400091C RID: 2332
		private bool m_AutoFlush;

		// Token: 0x0400091D RID: 2333
		private bool m_WeAreDisposed;
	}
}
