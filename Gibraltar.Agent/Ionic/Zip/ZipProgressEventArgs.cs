using System;

namespace Ionic.Zip
{
	// Token: 0x02000450 RID: 1104
	internal class ZipProgressEventArgs : global::System.EventArgs
	{
		// Token: 0x06002FB7 RID: 12215 RVA: 0x000A9A40 File Offset: 0x000A7C40
		internal ZipProgressEventArgs()
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x000A9A48 File Offset: 0x000A7C48
		internal ZipProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor)
		{
			this._archiveName = archiveName;
			this._flavor = flavor;
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x000A9A60 File Offset: 0x000A7C60
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x000A9A68 File Offset: 0x000A7C68
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000A9A74 File Offset: 0x000A7C74
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x000A9A7C File Offset: 0x000A7C7C
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000A9A88 File Offset: 0x000A7C88
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x000A9A90 File Offset: 0x000A7C90
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x000A9AA8 File Offset: 0x000A7CA8
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

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x000A9ABC File Offset: 0x000A7CBC
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

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x000A9AC8 File Offset: 0x000A7CC8
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x000A9AD0 File Offset: 0x000A7CD0
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000A9ADC File Offset: 0x000A7CDC
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x000A9AE4 File Offset: 0x000A7CE4
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

		// Token: 0x0400116F RID: 4463
		private int _entriesTotal;

		// Token: 0x04001170 RID: 4464
		private bool _cancel;

		// Token: 0x04001171 RID: 4465
		private global::Ionic.Zip.ZipEntry _latestEntry;

		// Token: 0x04001172 RID: 4466
		private global::Ionic.Zip.ZipProgressEventType _flavor;

		// Token: 0x04001173 RID: 4467
		private string _archiveName;

		// Token: 0x04001174 RID: 4468
		private long _bytesTransferred;

		// Token: 0x04001175 RID: 4469
		private long _totalBytesToTransfer;
	}
}
