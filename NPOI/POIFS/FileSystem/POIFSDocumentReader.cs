using System;
using System.IO;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002EF RID: 751
	[global::System.Obsolete]
	public class POIFSDocumentReader : global::System.IO.Stream
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x00040700 File Offset: 0x0003E900
		public POIFSDocumentReader(global::NPOI.POIFS.FileSystem.DocumentEntry document)
		{
			this._current_offset = 0;
			this._document_size = document.Size;
			this._closed = false;
			this._tiny_buffer = null;
			if (!(document is global::NPOI.POIFS.FileSystem.DocumentNode))
			{
				throw new global::System.IO.IOException("Cannot open internal document storage");
			}
			this._document = ((global::NPOI.POIFS.FileSystem.DocumentNode)document).Document;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00040758 File Offset: 0x0003E958
		public POIFSDocumentReader(global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			this._current_offset = 0;
			this._document_size = document.Size;
			this._closed = false;
			this._tiny_buffer = null;
			this._document = document;
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00040788 File Offset: 0x0003E988
		private bool EOD
		{
			get
			{
				return this._current_offset == this._document_size;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00040798 File Offset: 0x0003E998
		public int Available
		{
			get
			{
				if (this._closed)
				{
					throw new global::System.IO.IOException("This stream is closed");
				}
				return (int)(this.Length - this.Position);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000407BB File Offset: 0x0003E9BB
		public override void Close()
		{
			this._closed = true;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000407C4 File Offset: 0x0003E9C4
		private void DieIfClosed()
		{
			if (this._closed)
			{
				throw new global::System.IO.IOException("cannot perform requested operation on a closed stream");
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000407DC File Offset: 0x0003E9DC
		public override int Read(byte[] b, int off, int len)
		{
			this.DieIfClosed();
			if (b == null)
			{
				throw new global::System.NullReferenceException("buffer is null");
			}
			if (off < 0 || len < 0 || b.Length < off + len)
			{
				throw new global::System.IndexOutOfRangeException("can't read past buffer boundaries");
			}
			if (len == 0)
			{
				return 0;
			}
			if (this.EOD)
			{
				return -1;
			}
			int num = global::System.Math.Min(this.Available, len);
			if (off == 0 && num == b.Length)
			{
				this._document.Read(b, this._current_offset);
			}
			else
			{
				byte[] array = new byte[num];
				this._document.Read(array, this._current_offset);
				global::System.Array.Copy(array, 0, b, off, num);
			}
			this._current_offset += num;
			return num;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00040884 File Offset: 0x0003EA84
		public override int ReadByte()
		{
			this.DieIfClosed();
			if (this.EOD)
			{
				return -1;
			}
			if (this._tiny_buffer == null)
			{
				this._tiny_buffer = new byte[1];
			}
			global::NPOI.POIFS.FileSystem.OPOIFSDocument document = this._document;
			byte[] tiny_buffer = this._tiny_buffer;
			int current_offset = this._current_offset;
			this._current_offset = current_offset + 1;
			document.Read(tiny_buffer, current_offset);
			return (int)(this._tiny_buffer[0] & byte.MaxValue);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000408E8 File Offset: 0x0003EAE8
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			if (!this.CanSeek)
			{
				throw new global::System.NotSupportedException();
			}
			switch (origin)
			{
			case global::System.IO.SeekOrigin.Begin:
				if (0L > offset)
				{
					throw new global::System.ArgumentOutOfRangeException("offset", "offset must be positive");
				}
				this.Position = ((offset < this.Length) ? offset : this.Length);
				break;
			case global::System.IO.SeekOrigin.Current:
				this.Position = ((this.Position + offset < this.Length) ? (this.Position + offset) : this.Length);
				break;
			case global::System.IO.SeekOrigin.End:
				this.Position = this.Length;
				break;
			default:
				throw new global::System.ArgumentException("incorrect SeekOrigin", "origin");
			}
			return this.Position;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00040994 File Offset: 0x0003EB94
		public long Skip(long n)
		{
			this.DieIfClosed();
			if (n < 0L)
			{
				return 0L;
			}
			int num = this._current_offset + (int)n;
			if (num < this._current_offset)
			{
				num = this._document_size;
			}
			else if (num > this._document_size)
			{
				num = this._document_size;
			}
			long result = (long)(num - this._current_offset);
			this._current_offset = num;
			return result;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x000409EB File Offset: 0x0003EBEB
		public override long Length
		{
			get
			{
				return (long)this._document_size;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000409F4 File Offset: 0x0003EBF4
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x000409FD File Offset: 0x0003EBFD
		public override long Position
		{
			get
			{
				return (long)this._current_offset;
			}
			set
			{
				this._current_offset = global::System.Convert.ToInt32(value);
			}
		}

		// Token: 0x040008AA RID: 2218
		private bool _closed;

		// Token: 0x040008AB RID: 2219
		private int _current_offset;

		// Token: 0x040008AC RID: 2220
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument _document;

		// Token: 0x040008AD RID: 2221
		private int _document_size;

		// Token: 0x040008AE RID: 2222
		private byte[] _tiny_buffer;

		// Token: 0x040008AF RID: 2223
		private const int _EOD = 0;
	}
}
