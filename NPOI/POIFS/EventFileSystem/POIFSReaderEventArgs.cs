using System;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002CB RID: 715
	public class POIFSReaderEventArgs : global::System.EventArgs
	{
		// Token: 0x060013B6 RID: 5046 RVA: 0x0003B0AE File Offset: 0x000392AE
		public POIFSReaderEventArgs(string name, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			this.name = name;
			this.path = path;
			this.document = document;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0003B0CB File Offset: 0x000392CB
		public virtual global::NPOI.POIFS.FileSystem.POIFSDocumentPath Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0003B0D3 File Offset: 0x000392D3
		public virtual global::NPOI.POIFS.FileSystem.OPOIFSDocument Document
		{
			get
			{
				return this.document;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0003B0DB File Offset: 0x000392DB
		public virtual global::NPOI.POIFS.FileSystem.DocumentInputStream Stream
		{
			get
			{
				return new global::NPOI.POIFS.FileSystem.DocumentInputStream(this.document);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0003B0E8 File Offset: 0x000392E8
		public virtual string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x04000839 RID: 2105
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

		// Token: 0x0400083A RID: 2106
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument document;

		// Token: 0x0400083B RID: 2107
		private string name;
	}
}
