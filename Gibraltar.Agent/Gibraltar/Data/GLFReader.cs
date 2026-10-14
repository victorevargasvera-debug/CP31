using System;
using System.IO;
using Gibraltar.Serialization;
using Ionic.Zlib;

namespace Gibraltar.Data
{
	// Token: 0x02000258 RID: 600
	internal class GLFReader : global::System.IDisposable
	{
		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0006B00C File Offset: 0x0006920C
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0006B014 File Offset: 0x00069214
		public global::Gibraltar.Serialization.FragmentStorageSummary FragmentStorageSummary { get; private set; }

		// Token: 0x06001E13 RID: 7699 RVA: 0x0006B020 File Offset: 0x00069220
		public GLFReader(global::System.IO.Stream file)
		{
			this.m_File = file;
			this.m_IsSessionStream = global::Gibraltar.Data.GLFReader.IsGLF(this.m_File, out this.m_FileHeader);
			if (this.m_IsSessionStream)
			{
				byte[] array = new byte[this.m_FileHeader.DataOffset - 20];
				this.m_File.Position = 20L;
				this.m_File.Read(array, 0, array.Length);
				this.m_File.Position = 0L;
				this.m_SessionHeader = new global::Gibraltar.Data.SessionHeader(array);
				this.m_SessionHeader.HasData = true;
				this.FragmentStorageSummary = new global::Gibraltar.Serialization.FragmentStorageSummary(this.m_SessionHeader.FileStartDateTime, this.m_SessionHeader.FileEndDateTime, file.Length);
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0006B0E0 File Offset: 0x000692E0
		public static bool IsGLF(string fileName)
		{
			bool result = false;
			try
			{
				if (!string.IsNullOrEmpty(fileName) && global::System.IO.File.Exists(fileName))
				{
					using (global::System.IO.FileStream fileStream = global::Gibraltar.Data.Win32Helper.OpenFileStream(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
					{
						if (fileStream != null)
						{
							result = global::Gibraltar.Data.GLFReader.IsGLF(fileStream);
						}
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0006B158 File Offset: 0x00069358
		public static bool IsGLF(global::System.IO.Stream fileStream)
		{
			global::Gibraltar.Data.FileHeader fileHeader;
			return global::Gibraltar.Data.GLFReader.IsGLF(fileStream, out fileHeader);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0006B174 File Offset: 0x00069374
		public static bool IsGLF(global::System.IO.Stream fileStream, out global::Gibraltar.Data.FileHeader fileHeader)
		{
			bool result = false;
			fileHeader = null;
			if (fileStream == null)
			{
				return false;
			}
			if (!fileStream.CanSeek)
			{
				throw new global::System.ArgumentException("The provided data stream doesn't support seeking so it can't be used to read sessions.");
			}
			if (fileStream.Length >= 20L)
			{
				byte[] array = new byte[20];
				fileStream.Position = 0L;
				fileStream.Read(array, 0, array.Length);
				fileStream.Position = 0L;
				global::Gibraltar.Data.FileHeader fileHeader2 = new global::Gibraltar.Data.FileHeader(array);
				if (fileHeader2.TypeCode == 8739037465685924362L)
				{
					fileHeader = fileHeader2;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0006B1FC File Offset: 0x000693FC
		public int MajorVersion
		{
			get
			{
				return (int)this.m_FileHeader.MajorVersion;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0006B20C File Offset: 0x0006940C
		public int MinorVersion
		{
			get
			{
				return (int)this.m_FileHeader.MinorVersion;
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0006B21C File Offset: 0x0006941C
		public void EnsureDataLoaded()
		{
			if (!this.m_IsSessionStream)
			{
				throw new global::System.InvalidOperationException("The provided file is not a valid Loupe data stream and can't be read.");
			}
			if (this.m_RawStream == null)
			{
				this.m_RawStream = this.m_File;
				this.m_RawStream.Position = (long)this.m_FileHeader.DataOffset;
				this.m_File = null;
			}
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0006B278 File Offset: 0x00069478
		public void Close()
		{
			if (this.m_PacketStream != null)
			{
				try
				{
					this.m_PacketStream.Close();
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				this.m_PacketStream.Dispose();
				if (this.m_RawStream == this.m_PacketStream)
				{
					this.m_PacketStream = null;
				}
				if (this.m_File == this.m_RawStream)
				{
					this.m_RawStream = null;
				}
				this.m_PacketStream = null;
			}
			if (this.m_RawStream != null)
			{
				this.m_RawStream.Close();
				this.m_RawStream.Dispose();
				if (this.m_File == this.m_PacketStream)
				{
					this.m_PacketStream = null;
				}
				this.m_RawStream = null;
			}
			if (this.m_File != null)
			{
				this.m_File.Close();
				this.m_File.Dispose();
				this.m_File = null;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0006B364 File Offset: 0x00069564
		public bool IsSessionStream
		{
			get
			{
				return this.m_IsSessionStream;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x0006B36C File Offset: 0x0006956C
		public global::Gibraltar.Data.FileHeader FileHeader
		{
			get
			{
				return this.m_FileHeader;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0006B374 File Offset: 0x00069574
		public global::Gibraltar.Data.SessionHeader SessionHeader
		{
			get
			{
				return this.m_SessionHeader;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0006B37C File Offset: 0x0006957C
		internal global::System.IO.Stream RawStream
		{
			get
			{
				this.EnsureDataLoaded();
				return this.m_RawStream;
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0006B38C File Offset: 0x0006958C
		public global::System.IO.Stream GetPacketStreamStart()
		{
			this.EnsureDataLoaded();
			if (this.m_FileHeader.MajorVersion > 1)
			{
				this.m_RawStream.Position = (long)this.m_FileHeader.DataOffset;
				this.m_PacketStream = new global::Ionic.Zlib.GZipStream(this.m_RawStream, global::Ionic.Zlib.CompressionMode.Decompress, true);
				return this.m_PacketStream;
			}
			this.m_RawStream.Position = (long)this.m_FileHeader.DataOffset;
			return this.m_RawStream;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0006B404 File Offset: 0x00069604
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0006B414 File Offset: 0x00069614
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
				if (releaseManaged)
				{
					this.Close();
				}
			}
		}

		// Token: 0x04000B36 RID: 2870
		private readonly global::Gibraltar.Data.FileHeader m_FileHeader;

		// Token: 0x04000B37 RID: 2871
		private readonly global::Gibraltar.Data.SessionHeader m_SessionHeader;

		// Token: 0x04000B38 RID: 2872
		private readonly bool m_IsSessionStream;

		// Token: 0x04000B39 RID: 2873
		private global::System.IO.Stream m_File;

		// Token: 0x04000B3A RID: 2874
		private global::System.IO.Stream m_RawStream;

		// Token: 0x04000B3B RID: 2875
		private global::System.IO.Stream m_PacketStream;

		// Token: 0x04000B3C RID: 2876
		private bool m_IsDisposed;
	}
}
