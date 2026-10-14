using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Properties;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DC RID: 732
	public class NDocumentInputStream : global::NPOI.POIFS.FileSystem.DocumentInputStream
	{
		// Token: 0x06001456 RID: 5206 RVA: 0x0003CD74 File Offset: 0x0003AF74
		public NDocumentInputStream(global::NPOI.POIFS.FileSystem.DocumentEntry document)
		{
			if (!(document is global::NPOI.POIFS.FileSystem.DocumentNode))
			{
				throw new global::System.IO.IOException("Cannot open internal document storage, " + ((document != null) ? document.ToString() : null) + " not a Document Node");
			}
			this._current_offset = 0;
			this._current_block_count = 0;
			this._marked_offset = 0;
			this._marked_offset_count = 0;
			this._document_size = document.Size;
			this._closed = false;
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)document;
			global::NPOI.POIFS.Properties.DocumentProperty property = (global::NPOI.POIFS.Properties.DocumentProperty)documentNode.Property;
			this._document = new global::NPOI.POIFS.FileSystem.NPOIFSDocument(property, ((global::NPOI.POIFS.FileSystem.DirectoryNode)documentNode.Parent).NFileSystem);
			this._data = this._document.GetBlockIterator();
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0003CE20 File Offset: 0x0003B020
		public NDocumentInputStream(global::NPOI.POIFS.FileSystem.NPOIFSDocument document)
		{
			this._current_offset = 0;
			this._current_block_count = 0;
			this._marked_offset = 0;
			this._marked_offset_count = 0;
			this._document_size = document.Size;
			this._closed = false;
			this._document = document;
			this._data = this._document.GetBlockIterator();
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0003CE7A File Offset: 0x0003B07A
		public override int Available()
		{
			if (this._closed)
			{
				throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
			}
			return this._document_size - this._current_offset;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0003CE9C File Offset: 0x0003B09C
		public override void Close()
		{
			this._closed = true;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0003CEA5 File Offset: 0x0003B0A5
		public override void Mark(int ignoredReadlimit)
		{
			this._marked_offset = this._current_offset;
			this._marked_offset_count = global::System.Math.Max(0, this._current_block_count - 1);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		public override int Read()
		{
			this.DieIfClosed();
			if (this.atEOD())
			{
				return global::NPOI.POIFS.FileSystem.DocumentInputStream.EOF;
			}
			byte[] array = new byte[1];
			int num = this.Read(array, 0, 1);
			if (num < 0)
			{
				return num;
			}
			if (array[0] < 0)
			{
				return (int)array[0] + 256;
			}
			return (int)array[0];
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0003CF14 File Offset: 0x0003B114
		public override int Read(byte[] b, int off, int len)
		{
			this.DieIfClosed();
			if (b == null)
			{
				throw new global::System.ArgumentException("buffer must not be null");
			}
			if (off < 0 || len < 0 || b.Length < off + len)
			{
				throw new global::System.IndexOutOfRangeException("can't read past buffer boundaries");
			}
			if (len == 0)
			{
				return 0;
			}
			if (this.atEOD())
			{
				return global::NPOI.POIFS.FileSystem.DocumentInputStream.EOF;
			}
			int num = global::System.Math.Min(this.Available(), len);
			this.ReadFully(b, off, num);
			return num;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0003CF7C File Offset: 0x0003B17C
		public override void Reset()
		{
			if (this._marked_offset == 0 && this._marked_offset_count == 0)
			{
				this._current_block_count = this._marked_offset_count;
				this._current_offset = this._marked_offset;
				this._data = this._document.GetBlockIterator();
				this._buffer = null;
				return;
			}
			this._data = this._document.GetBlockIterator();
			this._current_offset = 0;
			for (int i = 0; i < this._marked_offset_count; i++)
			{
				this._data.MoveNext();
				this._buffer = this._data.Current;
				this._current_offset += this._buffer.Remain;
			}
			this._current_block_count = this._marked_offset_count;
			if (this._current_offset != this._marked_offset)
			{
				this._data.MoveNext();
				this._buffer = this._data.Current;
				this._current_block_count++;
				int num = this._marked_offset - this._current_offset;
				this._buffer.Position = this._buffer.Position + num;
			}
			this._current_offset = this._marked_offset;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
		public override long Skip(long n)
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
			long num2 = (long)(num - this._current_offset);
			byte[] buf = new byte[(int)num2];
			this.ReadFully(buf);
			return num2;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0003D0FF File Offset: 0x0003B2FF
		private void DieIfClosed()
		{
			if (this._closed)
			{
				throw new global::System.IO.IOException("cannot perform requested operation on a closed stream");
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0003D114 File Offset: 0x0003B314
		private bool atEOD()
		{
			return this._current_offset == this._document_size;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0003D124 File Offset: 0x0003B324
		private void CheckAvaliable(int requestedSize)
		{
			if (this._closed)
			{
				throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
			}
			if (requestedSize > this._document_size - this._current_offset)
			{
				throw new global::System.Exception(string.Concat(new string[]
				{
					"Buffer underrun - requested ",
					requestedSize.ToString(),
					" bytes but ",
					(this._document_size - this._current_offset).ToString(),
					" was available"
				}));
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0003D1A0 File Offset: 0x0003B3A0
		public override void ReadFully(byte[] buf, int off, int len)
		{
			this.CheckAvaliable(len);
			int num;
			for (int i = 0; i < len; i += num)
			{
				if (this._buffer == null || this._buffer.Remain == 0)
				{
					this._current_block_count++;
					this._data.MoveNext();
					this._buffer = this._data.Current;
				}
				num = global::System.Math.Min(len - i, this._buffer.Remain);
				this._buffer.Read(buf, off + i, num);
				this._current_offset += num;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0003D233 File Offset: 0x0003B433
		public override int ReadByte()
		{
			return this.ReadUByte();
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0003D23B File Offset: 0x0003B43B
		public override double ReadDouble()
		{
			return global::System.BitConverter.Int64BitsToDouble(this.ReadLong());
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0003D248 File Offset: 0x0003B448
		public override long ReadLong()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG);
			byte[] array = new byte[global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG];
			this.ReadFully(array, 0, global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG);
			return global::NPOI.Util.LittleEndian.GetLong(array, 0);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0003CC4A File Offset: 0x0003AE4A
		public override void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0003D280 File Offset: 0x0003B480
		public override short ReadShort()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT);
			byte[] array = new byte[global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT];
			this.ReadFully(array, 0, global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT);
			return global::NPOI.Util.LittleEndian.GetShort(array);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		public override int ReadInt()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT);
			byte[] array = new byte[global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT];
			this.ReadFully(array, 0, global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT);
			return global::NPOI.Util.LittleEndian.GetInt(array);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
		public override int ReadUShort()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT);
			byte[] array = new byte[global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT];
			this.ReadFully(array, 0, global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT);
			return global::NPOI.Util.LittleEndian.GetUShort(array);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0003D328 File Offset: 0x0003B528
		public override int ReadUByte()
		{
			this.CheckAvaliable(1);
			byte[] array = new byte[1];
			this.ReadFully(array, 0, 1);
			if (array[0] >= 0)
			{
				return (int)array[0];
			}
			return (int)array[0] + 256;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0003D35F File Offset: 0x0003B55F
		public override long Length
		{
			get
			{
				if (this._closed)
				{
					throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
				}
				return (long)this._document_size;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0003D37B File Offset: 0x0003B57B
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x0003D397 File Offset: 0x0003B597
		public override long Position
		{
			get
			{
				if (this._closed)
				{
					throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
				}
				return (long)this._current_offset;
			}
			set
			{
				this._current_offset = (int)value;
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003D3A1 File Offset: 0x0003B5A1
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			if (offset == 0L)
			{
				this.Reset();
			}
			else
			{
				this.Mark((int)offset);
			}
			return 0L;
		}

		// Token: 0x04000865 RID: 2149
		private int _current_offset;

		// Token: 0x04000866 RID: 2150
		private int _current_block_count;

		// Token: 0x04000867 RID: 2151
		private int _marked_offset;

		// Token: 0x04000868 RID: 2152
		private int _marked_offset_count;

		// Token: 0x04000869 RID: 2153
		private int _document_size;

		// Token: 0x0400086A RID: 2154
		private bool _closed;

		// Token: 0x0400086B RID: 2155
		private global::NPOI.POIFS.FileSystem.NPOIFSDocument _document;

		// Token: 0x0400086C RID: 2156
		private global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer> _data;

		// Token: 0x0400086D RID: 2157
		private global::NPOI.Util.ByteBuffer _buffer;
	}
}
