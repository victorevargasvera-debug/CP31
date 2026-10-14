using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200001F RID: 31
	public class TestStatus
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public TestStatus(global::ICSharpCode.SharpZipLib.Zip.ZipFile file)
		{
			this.file_ = file;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004E03 File Offset: 0x00003003
		public global::ICSharpCode.SharpZipLib.Zip.TestOperation Operation
		{
			get
			{
				return this.operation_;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004E0B File Offset: 0x0000300B
		public global::ICSharpCode.SharpZipLib.Zip.ZipFile File
		{
			get
			{
				return this.file_;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004E13 File Offset: 0x00003013
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry Entry
		{
			get
			{
				return this.entry_;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004E1B File Offset: 0x0000301B
		public int ErrorCount
		{
			get
			{
				return this.errorCount_;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004E23 File Offset: 0x00003023
		public long BytesTested
		{
			get
			{
				return this.bytesTested_;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004E2B File Offset: 0x0000302B
		public bool EntryValid
		{
			get
			{
				return this.entryValid_;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004E33 File Offset: 0x00003033
		internal void AddError()
		{
			this.errorCount_++;
			this.entryValid_ = false;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004E4A File Offset: 0x0000304A
		internal void SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation operation)
		{
			this.operation_ = operation;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004E53 File Offset: 0x00003053
		internal void SetEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			this.entry_ = entry;
			this.entryValid_ = true;
			this.bytesTested_ = 0L;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004E6B File Offset: 0x0000306B
		internal void SetBytesTested(long value)
		{
			this.bytesTested_ = value;
		}

		// Token: 0x040000C2 RID: 194
		private readonly global::ICSharpCode.SharpZipLib.Zip.ZipFile file_;

		// Token: 0x040000C3 RID: 195
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry_;

		// Token: 0x040000C4 RID: 196
		private bool entryValid_;

		// Token: 0x040000C5 RID: 197
		private int errorCount_;

		// Token: 0x040000C6 RID: 198
		private long bytesTested_;

		// Token: 0x040000C7 RID: 199
		private global::ICSharpCode.SharpZipLib.Zip.TestOperation operation_;
	}
}
