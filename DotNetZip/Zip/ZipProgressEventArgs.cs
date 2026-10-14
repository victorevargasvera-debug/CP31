using System;

namespace Ionic.Zip
{
	// Token: 0x02000035 RID: 53
	public class ZipProgressEventArgs : global::System.EventArgs
	{
		// Token: 0x0600028F RID: 655 RVA: 0x000115AA File Offset: 0x0000F7AA
		internal ZipProgressEventArgs()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000115B2 File Offset: 0x0000F7B2
		internal ZipProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor)
		{
			this._archiveName = archiveName;
			this._flavor = flavor;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000115D0 File Offset: 0x0000F7D0
		public int EntriesTotal
		{
			get
			{
				return this._entriesTotal;
			}
			set
			{
				this._entriesTotal = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000115D9 File Offset: 0x0000F7D9
		// (set) Token: 0x06000294 RID: 660 RVA: 0x000115E1 File Offset: 0x0000F7E1
		public global::Ionic.Zip.ZipEntry CurrentEntry
		{
			get
			{
				return this._latestEntry;
			}
			set
			{
				this._latestEntry = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000115EA File Offset: 0x0000F7EA
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000115F2 File Offset: 0x0000F7F2
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				this._cancel = (this._cancel || value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00011602 File Offset: 0x0000F802
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0001160A File Offset: 0x0000F80A
		public global::Ionic.Zip.ZipProgressEventType EventType
		{
			get
			{
				return this._flavor;
			}
			set
			{
				this._flavor = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00011613 File Offset: 0x0000F813
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0001161B File Offset: 0x0000F81B
		public string ArchiveName
		{
			get
			{
				return this._archiveName;
			}
			set
			{
				this._archiveName = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00011624 File Offset: 0x0000F824
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0001162C File Offset: 0x0000F82C
		public long BytesTransferred
		{
			get
			{
				return this._bytesTransferred;
			}
			set
			{
				this._bytesTransferred = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00011635 File Offset: 0x0000F835
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0001163D File Offset: 0x0000F83D
		public long TotalBytesToTransfer
		{
			get
			{
				return this._totalBytesToTransfer;
			}
			set
			{
				this._totalBytesToTransfer = value;
			}
		}

		// Token: 0x040001EA RID: 490
		private int _entriesTotal;

		// Token: 0x040001EB RID: 491
		private bool _cancel;

		// Token: 0x040001EC RID: 492
		private global::Ionic.Zip.ZipEntry _latestEntry;

		// Token: 0x040001ED RID: 493
		private global::Ionic.Zip.ZipProgressEventType _flavor;

		// Token: 0x040001EE RID: 494
		private string _archiveName;

		// Token: 0x040001EF RID: 495
		private long _bytesTransferred;

		// Token: 0x040001F0 RID: 496
		private long _totalBytesToTransfer;
	}
}
