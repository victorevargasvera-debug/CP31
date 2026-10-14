using System;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002CA RID: 714
	public class POIFSReaderEvent
	{
		// Token: 0x060013B2 RID: 5042 RVA: 0x0003B079 File Offset: 0x00039279
		public POIFSReaderEvent(global::NPOI.POIFS.FileSystem.DocumentInputStream stream, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string documentName)
		{
			this.stream = stream;
			this.path = path;
			this.documentName = documentName;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0003B096 File Offset: 0x00039296
		public global::NPOI.POIFS.FileSystem.DocumentInputStream Stream
		{
			get
			{
				return this.stream;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0003B09E File Offset: 0x0003929E
		public global::NPOI.POIFS.FileSystem.POIFSDocumentPath Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003B0A6 File Offset: 0x000392A6
		public string Name
		{
			get
			{
				return this.documentName;
			}
		}

		// Token: 0x04000836 RID: 2102
		private global::NPOI.POIFS.FileSystem.DocumentInputStream stream;

		// Token: 0x04000837 RID: 2103
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

		// Token: 0x04000838 RID: 2104
		private string documentName;
	}
}
