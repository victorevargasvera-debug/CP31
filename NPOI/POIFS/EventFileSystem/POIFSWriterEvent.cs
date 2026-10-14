using System;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002C5 RID: 709
	public class POIFSWriterEvent
	{
		// Token: 0x0600139A RID: 5018 RVA: 0x0003AD44 File Offset: 0x00038F44
		public POIFSWriterEvent(global::NPOI.POIFS.FileSystem.DocumentOutputStream stream, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string documentName, int limit)
		{
			this.stream = stream;
			this.path = path;
			this.documentName = documentName;
			this.limit = limit;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0003AD69 File Offset: 0x00038F69
		public global::NPOI.POIFS.FileSystem.DocumentOutputStream Stream
		{
			get
			{
				return this.stream;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0003AD71 File Offset: 0x00038F71
		public global::NPOI.POIFS.FileSystem.POIFSDocumentPath Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0003AD79 File Offset: 0x00038F79
		public string Name
		{
			get
			{
				return this.documentName;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0003AD81 File Offset: 0x00038F81
		public int Limit
		{
			get
			{
				return this.limit;
			}
		}

		// Token: 0x0400082B RID: 2091
		private global::NPOI.POIFS.FileSystem.DocumentOutputStream stream;

		// Token: 0x0400082C RID: 2092
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

		// Token: 0x0400082D RID: 2093
		private string documentName;

		// Token: 0x0400082E RID: 2094
		private int limit;
	}
}
