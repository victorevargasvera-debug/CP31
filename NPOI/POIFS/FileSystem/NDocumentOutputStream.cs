using System;
using System.IO;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D4 RID: 724
	public class NDocumentOutputStream : global::System.IO.MemoryStream
	{
		// Token: 0x060013FB RID: 5115 RVA: 0x0003C218 File Offset: 0x0003A418
		public NDocumentOutputStream(global::NPOI.POIFS.FileSystem.DocumentEntry document)
		{
			if (!(document is global::NPOI.POIFS.FileSystem.DocumentNode))
			{
				throw new global::System.IO.IOException("Cannot open internal document storage, " + ((document != null) ? document.ToString() : null) + " not a Document Node");
			}
			this._document_size = 0;
			this._closed = false;
			this._property = (global::NPOI.POIFS.Properties.DocumentProperty)((global::NPOI.POIFS.FileSystem.DocumentNode)document).Property;
			this._document = new global::NPOI.POIFS.FileSystem.NPOIFSDocument((global::NPOI.POIFS.FileSystem.DocumentNode)document);
			this._document.Free();
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0003C2A8 File Offset: 0x0003A4A8
		public NDocumentOutputStream(global::NPOI.POIFS.FileSystem.DirectoryEntry parent, string name)
		{
			if (!(parent is global::NPOI.POIFS.FileSystem.DirectoryNode))
			{
				throw new global::System.IO.IOException("Cannot open internal directory storage, " + ((parent != null) ? parent.ToString() : null) + " not a Directory Node");
			}
			this._document_size = 0;
			this._closed = false;
			global::NPOI.POIFS.FileSystem.DocumentEntry documentEntry = parent.CreateDocument(name, new global::System.IO.MemoryStream(new byte[0]));
			this._property = (global::NPOI.POIFS.Properties.DocumentProperty)((global::NPOI.POIFS.FileSystem.DocumentNode)documentEntry).Property;
			this._document = new global::NPOI.POIFS.FileSystem.NPOIFSDocument((global::NPOI.POIFS.FileSystem.DocumentNode)documentEntry);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0003C33D File Offset: 0x0003A53D
		private void dieIfClosed()
		{
			if (this._closed)
			{
				throw new global::System.IO.IOException("cannot perform requested operation on a closed stream");
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0003C354 File Offset: 0x0003A554
		private void CheckBufferSize()
		{
			if (this._buffer.Length > 4096L)
			{
				byte[] array = this._buffer.ToArray();
				this._buffer = null;
				this.Write(array, 0, array.Length);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0003C392 File Offset: 0x0003A592
		public void Write(int b)
		{
			this.dieIfClosed();
			if (this._buffer != null)
			{
				this._buffer.WriteByte((byte)b);
				this.CheckBufferSize();
				return;
			}
			this.Write(new byte[]
			{
				(byte)b
			});
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0003C3C7 File Offset: 0x0003A5C7
		public void Write(byte[] b)
		{
			this.dieIfClosed();
			if (this._buffer != null)
			{
				this._buffer.Write(b, 0, b.Length);
				this.CheckBufferSize();
				return;
			}
			this.Write(b, 0, b.Length);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0003C3FC File Offset: 0x0003A5FC
		public override void Write(byte[] b, int off, int len)
		{
			this.dieIfClosed();
			if (this._buffer != null)
			{
				this._buffer.Write(b, off, len);
				this.CheckBufferSize();
				return;
			}
			if (this._stream == null)
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._document.FileSystem);
				this._stream_output = this._stream.GetOutputStream();
			}
			this._stream_output.Write(b, off, len);
			this._document_size += len;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0003C478 File Offset: 0x0003A678
		public override void Close()
		{
			base.Close();
			if (this._buffer != null)
			{
				this._document.ReplaceContents(new global::System.IO.MemoryStream(this._buffer.ToArray()));
			}
			else
			{
				this._stream_output.Close();
				this._property.UpdateSize(this._document_size);
				this._property.StartBlock = this._stream.GetStartBlock();
			}
			this._closed = true;
		}

		// Token: 0x0400084F RID: 2127
		private int _document_size;

		// Token: 0x04000850 RID: 2128
		private bool _closed;

		// Token: 0x04000851 RID: 2129
		private global::NPOI.POIFS.FileSystem.NPOIFSDocument _document;

		// Token: 0x04000852 RID: 2130
		private global::NPOI.POIFS.Properties.DocumentProperty _property;

		// Token: 0x04000853 RID: 2131
		private global::System.IO.MemoryStream _buffer = new global::System.IO.MemoryStream(4096);

		// Token: 0x04000854 RID: 2132
		private global::NPOI.POIFS.FileSystem.NPOIFSStream _stream;

		// Token: 0x04000855 RID: 2133
		private global::System.IO.Stream _stream_output;
	}
}
