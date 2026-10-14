using System;
using System.IO;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E1 RID: 737
	public class ODocumentInputStream : global::NPOI.POIFS.FileSystem.DocumentInputStream
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		public ODocumentInputStream(global::NPOI.POIFS.FileSystem.DocumentEntry document)
		{
			if (!(document is global::NPOI.POIFS.FileSystem.DocumentNode))
			{
				throw new global::System.IO.IOException("Cannot open internal document storage");
			}
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)document;
			if (documentNode.Document == null)
			{
				throw new global::System.IO.IOException("Cannot open internal document storage");
			}
			this._current_offset = 0L;
			this._marked_offset = 0L;
			this._document_size = document.Size;
			this._closed = false;
			this._document = documentNode.Document;
			this._currentBlock = this.GetDataInputBlock(0L);
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0003EAC9 File Offset: 0x0003CCC9
		public override long Length
		{
			get
			{
				return (long)this._document_size;
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0003EAD2 File Offset: 0x0003CCD2
		public ODocumentInputStream(global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			this._current_offset = 0L;
			this._marked_offset = 0L;
			this._document_size = document.Size;
			this._closed = false;
			this._document = document;
			this._currentBlock = this.GetDataInputBlock(0L);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0003EB12 File Offset: 0x0003CD12
		public override int Available()
		{
			if (this._closed)
			{
				throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
			}
			return this._document_size - (int)this._current_offset;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0003EB35 File Offset: 0x0003CD35
		public override void Close()
		{
			this._closed = true;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0003EB3E File Offset: 0x0003CD3E
		public override void Mark(int ignoredReadlimit)
		{
			this._marked_offset = this._current_offset;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0003EB4C File Offset: 0x0003CD4C
		private global::NPOI.POIFS.Storage.DataInputBlock GetDataInputBlock(long offset)
		{
			return this._document.GetDataInputBlock((int)offset);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0003EB5C File Offset: 0x0003CD5C
		public override int Read()
		{
			this.dieIfClosed();
			if (this.atEOD())
			{
				return global::NPOI.POIFS.FileSystem.DocumentInputStream.EOF;
			}
			int result = this._currentBlock.ReadUByte();
			this._current_offset += 1L;
			if (this._currentBlock.Available() < 1)
			{
				this._currentBlock = this.GetDataInputBlock(this._current_offset);
			}
			return result;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0003EBB8 File Offset: 0x0003CDB8
		public override int Read(byte[] b, int off, int len)
		{
			this.dieIfClosed();
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

		// Token: 0x060014D6 RID: 5334 RVA: 0x0003EC1E File Offset: 0x0003CE1E
		public override void Reset()
		{
			this._current_offset = this._marked_offset;
			this._currentBlock = this.GetDataInputBlock(this._current_offset);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0003EC40 File Offset: 0x0003CE40
		public override long Skip(long n)
		{
			this.dieIfClosed();
			if (n < 0L)
			{
				return 0L;
			}
			long num = this._current_offset + (long)((int)n);
			if (num < this._current_offset)
			{
				num = (long)this._document_size;
			}
			else if (num > (long)this._document_size)
			{
				num = (long)this._document_size;
			}
			long result = num - this._current_offset;
			this._current_offset = num;
			this._currentBlock = this.GetDataInputBlock(this._current_offset);
			return result;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0003ECAC File Offset: 0x0003CEAC
		private void dieIfClosed()
		{
			if (this._closed)
			{
				throw new global::System.IO.IOException("cannot perform requested operation on a closed stream");
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0003ECC1 File Offset: 0x0003CEC1
		private bool atEOD()
		{
			return this._current_offset == (long)this._document_size;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0003ECD4 File Offset: 0x0003CED4
		private void CheckAvaliable(int requestedSize)
		{
			if (this._closed)
			{
				throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
			}
			if ((long)requestedSize > (long)this._document_size - this._current_offset)
			{
				throw new global::System.Exception(string.Concat(new string[]
				{
					"Buffer underrun - requested ",
					requestedSize.ToString(),
					" bytes but ",
					((long)this._document_size - this._current_offset).ToString(),
					" was available"
				}));
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0003D233 File Offset: 0x0003B433
		public override int ReadByte()
		{
			return this.ReadUByte();
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0003D23B File Offset: 0x0003B43B
		public override double ReadDouble()
		{
			return global::System.BitConverter.Int64BitsToDouble(this.ReadLong());
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0003CC41 File Offset: 0x0003AE41
		public override short ReadShort()
		{
			return (short)this.ReadUShort();
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0003ED54 File Offset: 0x0003CF54
		public override void ReadFully(byte[] buf, int off, int len)
		{
			this.CheckAvaliable(len);
			int num = this._currentBlock.Available();
			if (num > len)
			{
				this._currentBlock.ReadFully(buf, off, len);
				this._current_offset += (long)len;
				return;
			}
			int i = len;
			int num2 = off;
			while (i > 0)
			{
				bool flag = i >= num;
				int num3;
				if (flag)
				{
					num3 = num;
				}
				else
				{
					num3 = i;
				}
				this._currentBlock.ReadFully(buf, num2, num3);
				i -= num3;
				num2 += num3;
				this._current_offset += (long)num3;
				if (flag)
				{
					if (this._current_offset == (long)this._document_size)
					{
						if (i > 0)
						{
							throw new global::System.InvalidOperationException("reached end of document stream unexpectedly");
						}
						this._currentBlock = null;
						return;
					}
					else
					{
						this._currentBlock = this.GetDataInputBlock(this._current_offset);
						num = this._currentBlock.Available();
					}
				}
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0003EE1C File Offset: 0x0003D01C
		public override long ReadLong()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG);
			int num = this._currentBlock.Available();
			long result;
			if (num > global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG)
			{
				result = this._currentBlock.ReadLongLE();
			}
			else
			{
				global::NPOI.POIFS.Storage.DataInputBlock dataInputBlock = this.GetDataInputBlock(this._current_offset + (long)num);
				if (num == global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG)
				{
					result = this._currentBlock.ReadLongLE();
				}
				else
				{
					result = dataInputBlock.ReadLongLE(this._currentBlock, num);
				}
				this._currentBlock = dataInputBlock;
			}
			this._current_offset += (long)global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_LONG;
			return result;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		public override int ReadInt()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT);
			int num = this._currentBlock.Available();
			int result;
			if (num > global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT)
			{
				result = this._currentBlock.ReadIntLE();
			}
			else
			{
				global::NPOI.POIFS.Storage.DataInputBlock dataInputBlock = this.GetDataInputBlock(this._current_offset + (long)num);
				if (num == global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT)
				{
					result = this._currentBlock.ReadIntLE();
				}
				else
				{
					result = dataInputBlock.ReadIntLE(this._currentBlock, num);
				}
				this._currentBlock = dataInputBlock;
			}
			this._current_offset += (long)global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_INT;
			return result;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0003EF34 File Offset: 0x0003D134
		public override int ReadUShort()
		{
			this.CheckAvaliable(global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT);
			int num = this._currentBlock.Available();
			int result;
			if (num > global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT)
			{
				result = this._currentBlock.ReadUshortLE();
			}
			else
			{
				global::NPOI.POIFS.Storage.DataInputBlock dataInputBlock = this.GetDataInputBlock(this._current_offset + (long)num);
				if (num == global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT)
				{
					result = this._currentBlock.ReadUshortLE();
				}
				else
				{
					result = dataInputBlock.ReadUshortLE(this._currentBlock);
				}
				this._currentBlock = dataInputBlock;
			}
			this._current_offset += (long)global::NPOI.POIFS.FileSystem.DocumentInputStream.SIZE_SHORT;
			return result;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0003EFBC File Offset: 0x0003D1BC
		public override int ReadUByte()
		{
			this.CheckAvaliable(1);
			int result = this._currentBlock.ReadUByte();
			this._current_offset += 1L;
			if (this._currentBlock.Available() < 1)
			{
				this._currentBlock = this.GetDataInputBlock(this._current_offset);
			}
			return result;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0003F00C File Offset: 0x0003D20C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			if (origin == global::System.IO.SeekOrigin.Current)
			{
				if (this._current_offset + offset >= this.Length || this._current_offset + offset < 0L)
				{
					throw new global::System.ArgumentException("invalid offset");
				}
				this._current_offset += (long)((int)offset);
			}
			else if (origin == global::System.IO.SeekOrigin.Begin)
			{
				if (offset >= this.Length || offset < 0L)
				{
					throw new global::System.ArgumentException("invalid offset");
				}
				this._current_offset = offset;
			}
			else if (origin == global::System.IO.SeekOrigin.End)
			{
				if (this.Length + offset >= this.Length || this.Length + offset < 0L)
				{
					throw new global::System.ArgumentException("invalid offset");
				}
				this._current_offset = this.Length + offset;
			}
			return this._current_offset;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0003F0BA File Offset: 0x0003D2BA
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0003F0D5 File Offset: 0x0003D2D5
		public override long Position
		{
			get
			{
				if (this._closed)
				{
					throw new global::System.InvalidOperationException("cannot perform requested operation on a closed stream");
				}
				return this._current_offset;
			}
			set
			{
				this._current_offset = (long)((int)value);
			}
		}

		// Token: 0x04000883 RID: 2179
		private long _current_offset;

		// Token: 0x04000884 RID: 2180
		private long _marked_offset;

		// Token: 0x04000885 RID: 2181
		private int _document_size;

		// Token: 0x04000886 RID: 2182
		private bool _closed;

		// Token: 0x04000887 RID: 2183
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument _document;

		// Token: 0x04000888 RID: 2184
		private global::NPOI.POIFS.Storage.DataInputBlock _currentBlock;
	}
}
