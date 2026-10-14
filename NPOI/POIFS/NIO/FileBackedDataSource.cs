using System;
using System.Collections.Generic;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.NIO
{
	// Token: 0x020002C3 RID: 707
	public class FileBackedDataSource : global::NPOI.POIFS.NIO.DataSource
	{
		// Token: 0x06001386 RID: 4998 RVA: 0x0003AA6A File Offset: 0x00038C6A
		public FileBackedDataSource(global::System.IO.FileInfo file) : this(file, false)
		{
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0003AA74 File Offset: 0x00038C74
		public FileBackedDataSource(global::System.IO.FileInfo file, bool readOnly)
		{
			this.buffersToClean = new global::System.Collections.Generic.List<global::NPOI.Util.ByteBuffer>();
			base..ctor();
			if (!file.Exists)
			{
				throw new global::System.IO.FileNotFoundException(file.FullName);
			}
			this.fileinfo = file;
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(file.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array, 0, array.Length);
			this.fileStream = memoryStream;
			this.writable = !readOnly;
			fileStream.Position = 0L;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0003AAFC File Offset: 0x00038CFC
		public FileBackedDataSource(global::System.IO.FileStream stream, bool readOnly)
		{
			this.buffersToClean = new global::System.Collections.Generic.List<global::NPOI.Util.ByteBuffer>();
			base..ctor();
			stream.Position = 0L;
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, (int)stream.Length);
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array, 0, array.Length);
			this.fileStream = memoryStream;
			this.writable = !readOnly;
			stream.Position = 0L;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0003AB63 File Offset: 0x00038D63
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0003AB72 File Offset: 0x00038D72
		private void Dispose(bool disposing)
		{
			if (disposing && this.fileStream != null)
			{
				this.fileStream.Dispose();
				this.fileStream = null;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0003AB94 File Offset: 0x00038D94
		~FileBackedDataSource()
		{
			this.Dispose(false);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0003ABC4 File Offset: 0x00038DC4
		public bool IsWriteable
		{
			get
			{
				return this.writable;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0003ABCC File Offset: 0x00038DCC
		public global::System.IO.Stream Stream
		{
			get
			{
				return this.fileStream;
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0003ABD4 File Offset: 0x00038DD4
		public override global::NPOI.Util.ByteBuffer Read(int length, long position)
		{
			if (position >= this.Size)
			{
				throw new global::System.IndexOutOfRangeException("Position " + position.ToString() + " past the end of the file");
			}
			global::NPOI.Util.ByteBuffer byteBuffer;
			if (this.writable)
			{
				byteBuffer = global::NPOI.Util.ByteBuffer.CreateBuffer(length);
				this.buffersToClean.Add(byteBuffer);
			}
			else
			{
				this.fileStream.Position = position;
				byteBuffer = global::NPOI.Util.ByteBuffer.CreateBuffer(length);
				if (global::NPOI.Util.IOUtils.ReadFully(this.fileStream, byteBuffer.Buffer) == -1)
				{
					throw new global::System.IndexOutOfRangeException("Position " + position.ToString() + " past the end of the file");
				}
			}
			byteBuffer.Position = 0;
			return byteBuffer;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0003AC6E File Offset: 0x00038E6E
		public override void Write(global::NPOI.Util.ByteBuffer src, long position)
		{
			this.fileStream.Write(src.Buffer, (int)position, src.Length);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0003AC8C File Offset: 0x00038E8C
		public override void CopyTo(global::System.IO.Stream stream)
		{
			byte[] array = this.fileStream.ToArray();
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		public override long Size
		{
			get
			{
				if (this.fileStream != null)
				{
					return this.fileStream.Length;
				}
				return this.fileinfo.Length;
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		public override void Close()
		{
			foreach (global::NPOI.Util.ByteBuffer bb in this.buffersToClean)
			{
				global::NPOI.POIFS.NIO.FileBackedDataSource.unmap(bb);
			}
			this.buffersToClean.Clear();
			if (this.fileStream != null)
			{
				this.fileStream.Close();
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00019A7F File Offset: 0x00017C7F
		private static void unmap(global::NPOI.Util.ByteBuffer bb)
		{
		}

		// Token: 0x04000827 RID: 2087
		private global::System.IO.MemoryStream fileStream;

		// Token: 0x04000828 RID: 2088
		private global::System.IO.FileInfo fileinfo;

		// Token: 0x04000829 RID: 2089
		private bool writable;

		// Token: 0x0400082A RID: 2090
		private global::System.Collections.Generic.List<global::NPOI.Util.ByteBuffer> buffersToClean;
	}
}
