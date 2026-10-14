using System;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002C6 RID: 710
	public class POIFSWriterEventArgs : global::System.EventArgs
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x0003AD89 File Offset: 0x00038F89
		public POIFSWriterEventArgs(global::NPOI.POIFS.FileSystem.DocumentOutputStream stream, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string documentName, int limit)
		{
			this.stream = stream;
			this.path = path;
			this.documentName = documentName;
			this.limit = limit;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0003ADAE File Offset: 0x00038FAE
		public virtual int Limit
		{
			get
			{
				return this.limit;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0003ADB6 File Offset: 0x00038FB6
		public virtual string Name
		{
			get
			{
				return this.documentName;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0003ADBE File Offset: 0x00038FBE
		public virtual global::NPOI.POIFS.FileSystem.POIFSDocumentPath Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0003ADC6 File Offset: 0x00038FC6
		public virtual global::NPOI.POIFS.FileSystem.DocumentOutputStream Stream
		{
			get
			{
				return this.stream;
			}
		}

		// Token: 0x0400082F RID: 2095
		private string documentName;

		// Token: 0x04000830 RID: 2096
		private int limit;

		// Token: 0x04000831 RID: 2097
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

		// Token: 0x04000832 RID: 2098
		private global::NPOI.POIFS.FileSystem.DocumentOutputStream stream;
	}
}
