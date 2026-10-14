using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DA RID: 730
	public class DocumentInputStream : global::NPOI.Util.ByteArrayInputStream, global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x0003CAE0 File Offset: 0x0003ACE0
		protected DocumentInputStream()
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0003CAE8 File Offset: 0x0003ACE8
		public DocumentInputStream(global::NPOI.POIFS.FileSystem.DocumentEntry document)
		{
			if (!(document is global::NPOI.POIFS.FileSystem.DocumentNode))
			{
				throw new global::System.IO.IOException("Cannot open internal document storage");
			}
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)document;
			global::NPOI.POIFS.FileSystem.DirectoryNode directoryNode = (global::NPOI.POIFS.FileSystem.DirectoryNode)document.Parent;
			if (documentNode.Document != null)
			{
				this.delegate1 = new global::NPOI.POIFS.FileSystem.ODocumentInputStream(document);
				return;
			}
			if (directoryNode.OFileSystem != null)
			{
				this.delegate1 = new global::NPOI.POIFS.FileSystem.ODocumentInputStream(document);
				return;
			}
			if (directoryNode.NFileSystem != null)
			{
				this.delegate1 = new global::NPOI.POIFS.FileSystem.NDocumentInputStream(document);
				return;
			}
			throw new global::System.IO.IOException("No FileSystem bound on the parent, can't read contents");
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0003CB68 File Offset: 0x0003AD68
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.delegate1.Seek(offset, origin);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0003CB77 File Offset: 0x0003AD77
		public override long Length
		{
			get
			{
				return this.delegate1.Length;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0003CB84 File Offset: 0x0003AD84
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0003CB91 File Offset: 0x0003AD91
		public override long Position
		{
			get
			{
				return this.delegate1.Position;
			}
			set
			{
				this.delegate1.Position = value;
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0003CB9F File Offset: 0x0003AD9F
		public DocumentInputStream(global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			this.delegate1 = new global::NPOI.POIFS.FileSystem.ODocumentInputStream(document);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0003CBB3 File Offset: 0x0003ADB3
		public DocumentInputStream(global::NPOI.POIFS.FileSystem.NPOIFSDocument document)
		{
			this.delegate1 = new global::NPOI.POIFS.FileSystem.NDocumentInputStream(document);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0003CBC7 File Offset: 0x0003ADC7
		public override int Available()
		{
			return this.delegate1.Available();
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		public override void Close()
		{
			this.delegate1.Close();
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0003CBE1 File Offset: 0x0003ADE1
		public override void Mark(int ignoredReadlimit)
		{
			this.delegate1.Mark(ignoredReadlimit);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool MarkSupported()
		{
			return true;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0003CBEF File Offset: 0x0003ADEF
		public override int Read()
		{
			return this.delegate1.Read();
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public override int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0003CBFC File Offset: 0x0003ADFC
		public override int Read(byte[] b, int off, int len)
		{
			return this.delegate1.Read(b, off, len);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003CC0C File Offset: 0x0003AE0C
		public override void Reset()
		{
			this.delegate1.Reset();
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0003CC19 File Offset: 0x0003AE19
		public new virtual long Skip(long n)
		{
			return this.delegate1.Skip(n);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0003CC27 File Offset: 0x0003AE27
		public override int ReadByte()
		{
			return this.delegate1.ReadByte();
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0003CC34 File Offset: 0x0003AE34
		public virtual double ReadDouble()
		{
			return this.delegate1.ReadDouble();
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0003CC41 File Offset: 0x0003AE41
		public virtual short ReadShort()
		{
			return (short)this.ReadUShort();
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0003CC4A File Offset: 0x0003AE4A
		public virtual void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0003CC57 File Offset: 0x0003AE57
		public virtual void ReadFully(byte[] buf, int off, int len)
		{
			this.delegate1.ReadFully(buf, off, len);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0003CC67 File Offset: 0x0003AE67
		public virtual long ReadLong()
		{
			return this.delegate1.ReadLong();
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0003CC74 File Offset: 0x0003AE74
		public virtual int ReadInt()
		{
			return this.delegate1.ReadInt();
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0003CC81 File Offset: 0x0003AE81
		public virtual int ReadUShort()
		{
			return this.delegate1.ReadUShort();
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0003CC8E File Offset: 0x0003AE8E
		public virtual int ReadUByte()
		{
			return this.delegate1.ReadUByte();
		}

		// Token: 0x0400085D RID: 2141
		protected static int EOF = -1;

		// Token: 0x0400085E RID: 2142
		protected static int SIZE_SHORT = 2;

		// Token: 0x0400085F RID: 2143
		protected static int SIZE_INT = 4;

		// Token: 0x04000860 RID: 2144
		protected static int SIZE_LONG = 8;

		// Token: 0x04000861 RID: 2145
		private global::NPOI.POIFS.FileSystem.DocumentInputStream delegate1;
	}
}
