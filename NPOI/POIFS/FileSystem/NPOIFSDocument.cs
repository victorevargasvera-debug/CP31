using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.POIFS.Dev;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.Properties;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DD RID: 733
	public class NPOIFSDocument : global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		public NPOIFSDocument(global::NPOI.POIFS.FileSystem.DocumentNode document) : this((global::NPOI.POIFS.Properties.DocumentProperty)document.Property, ((global::NPOI.POIFS.FileSystem.DirectoryNode)document.Parent).NFileSystem)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0003D3DC File Offset: 0x0003B5DC
		public NPOIFSDocument(global::NPOI.POIFS.Properties.DocumentProperty property, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem filesystem)
		{
			this._property = property;
			this._filesystem = filesystem;
			if (property.Size < 4096)
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._filesystem.GetMiniStore(), property.StartBlock);
				this._block_size = this._filesystem.GetMiniStore().GetBlockStoreBlockSize();
				return;
			}
			this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._filesystem, property.StartBlock);
			this._block_size = this._filesystem.GetBlockStoreBlockSize();
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0003D468 File Offset: 0x0003B668
		public NPOIFSDocument(string name, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem filesystem, global::System.IO.Stream stream)
		{
			this._filesystem = filesystem;
			int size = this.Store(stream);
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, size);
			this._property.StartBlock = this._stream.GetStartBlock();
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		private int Store(global::System.IO.Stream inStream)
		{
			int num = 4096;
			if (inStream.Length < (long)num)
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._filesystem.GetMiniStore());
				this._block_size = this._filesystem.GetMiniStore().GetBlockStoreBlockSize();
			}
			else
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._filesystem);
				this._block_size = this._filesystem.GetBlockStoreBlockSize();
			}
			global::System.IO.Stream outputStream = this._stream.GetOutputStream();
			byte[] array = new byte[1024];
			int num2 = 0;
			for (;;)
			{
				int num3 = inStream.Read(array, 0, array.Length);
				if (num3 <= 0)
				{
					break;
				}
				num2 += num3;
				outputStream.Write(array, 0, num3);
			}
			int num4 = num2 % this._block_size;
			if (num4 != 0 && num4 != this._block_size)
			{
				byte[] array2 = new byte[this._block_size - num4];
				global::NPOI.Util.Arrays.Fill(array2, byte.MaxValue);
				outputStream.Write(array2, 0, array2.Length);
			}
			outputStream.Close();
			return num2;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0003D5A4 File Offset: 0x0003B7A4
		public NPOIFSDocument(string name, int size, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem filesystem, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener Writer)
		{
			this._filesystem = filesystem;
			if (size < 4096)
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(filesystem.GetMiniStore());
				this._block_size = this._filesystem.GetMiniStore().GetBlockStoreBlockSize();
			}
			else
			{
				this._stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(filesystem);
				this._block_size = this._filesystem.GetBlockStoreBlockSize();
			}
			global::System.IO.Stream outputStream = this._stream.GetOutputStream();
			global::NPOI.POIFS.FileSystem.DocumentOutputStream stream = new global::NPOI.POIFS.FileSystem.DocumentOutputStream(outputStream, size);
			global::NPOI.POIFS.FileSystem.POIFSDocumentPath poifsdocumentPath = new global::NPOI.POIFS.FileSystem.POIFSDocumentPath(name.Split(new string[]
			{
				"\\\\"
			}, global::System.StringSplitOptions.RemoveEmptyEntries));
			string component = poifsdocumentPath.GetComponent(poifsdocumentPath.Length - 1);
			global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent @event = new global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent(stream, poifsdocumentPath, component, size);
			Writer.ProcessPOIFSWriterEvent(@event);
			outputStream.Close();
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, size);
			this._property.StartBlock = this._stream.GetStartBlock();
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0003D687 File Offset: 0x0003B887
		internal void Free()
		{
			this._stream.Free();
			this._property.StartBlock = -2;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0003D6A1 File Offset: 0x0003B8A1
		internal global::NPOI.POIFS.FileSystem.NPOIFSFileSystem FileSystem
		{
			get
			{
				return this._filesystem;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0003D6A9 File Offset: 0x0003B8A9
		public int GetDocumentBlockSize()
		{
			return this._block_size;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0003D6B1 File Offset: 0x0003B8B1
		public global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer> GetBlockIterator()
		{
			if (this.Size > 0)
			{
				return this._stream.GetBlockIterator();
			}
			return new global::System.Collections.Generic.List<global::NPOI.Util.ByteBuffer>().GetEnumerator();
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0003D6D7 File Offset: 0x0003B8D7
		public int Size
		{
			get
			{
				return this._property.Size;
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		public void ReplaceContents(global::System.IO.Stream stream)
		{
			this.Free();
			int size = this.Store(stream);
			this._property.StartBlock = this._stream.GetStartBlock();
			this._property.UpdateSize(size);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0003D721 File Offset: 0x0003B921
		public global::NPOI.POIFS.Properties.DocumentProperty DocumentProperty
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0003D72C File Offset: 0x0003B92C
		protected object[] GetViewableArray()
		{
			string text = "<NO DATA>";
			if (this.Size > 0)
			{
				byte[] array = new byte[this.Size];
				int num = 0;
				foreach (global::NPOI.Util.ByteBuffer byteBuffer in this._stream)
				{
					int num2 = global::System.Math.Min(this._block_size, array.Length - num);
					byteBuffer.Read(array, num, num2);
					num += num2;
				}
				text = global::NPOI.Util.HexDump.Dump(array, 0L, 0);
			}
			return new string[]
			{
				text
			};
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0002BE0C File Offset: 0x0002A00C
		protected global::System.Collections.IEnumerator GetViewableIterator()
		{
			return null;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
		protected string GetShortDescription()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("Document: \"").Append(this._property.Name).Append("\"");
			stringBuilder.Append(" size = ").Append(this.Size);
			return stringBuilder.ToString();
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00008875 File Offset: 0x00006A75
		public bool PreferArray
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0003D81C File Offset: 0x0003BA1C
		public string ShortDescription
		{
			get
			{
				return this.GetShortDescription();
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0003D824 File Offset: 0x0003BA24
		public global::System.Array ViewableArray
		{
			get
			{
				return this.GetViewableArray();
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0003D82C File Offset: 0x0003BA2C
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				return this.GetViewableIterator();
			}
		}

		// Token: 0x0400086E RID: 2158
		private global::NPOI.POIFS.Properties.DocumentProperty _property;

		// Token: 0x0400086F RID: 2159
		private global::NPOI.POIFS.FileSystem.NPOIFSFileSystem _filesystem;

		// Token: 0x04000870 RID: 2160
		private global::NPOI.POIFS.FileSystem.NPOIFSStream _stream;

		// Token: 0x04000871 RID: 2161
		private int _block_size;
	}
}
