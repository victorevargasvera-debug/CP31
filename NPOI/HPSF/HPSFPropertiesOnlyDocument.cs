using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.FileSystem;

namespace NPOI.HPSF
{
	// Token: 0x02000500 RID: 1280
	public class HPSFPropertiesOnlyDocument : global::NPOI.POIDocument
	{
		// Token: 0x06002FE1 RID: 12257 RVA: 0x000020B7 File Offset: 0x000002B7
		public HPSFPropertiesOnlyDocument(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : base(fs.Root)
		{
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00090F45 File Offset: 0x0008F145
		public HPSFPropertiesOnlyDocument(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fs) : base(fs)
		{
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00090F4E File Offset: 0x0008F14E
		public HPSFPropertiesOnlyDocument(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : base(fs)
		{
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00090F58 File Offset: 0x0008F158
		public override void Write()
		{
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fileSystem = this.directory.FileSystem;
			base.ValidateInPlaceWritePossible();
			base.WriteProperties(fileSystem, null);
			fileSystem.WriteFileSystem();
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00090F88 File Offset: 0x0008F188
		public override void Write(global::System.IO.FileInfo newFile)
		{
			global::NPOI.POIFS.FileSystem.POIFSFileSystem poifsfileSystem = global::NPOI.POIFS.FileSystem.POIFSFileSystem.Create(newFile);
			try
			{
				this.Write(poifsfileSystem);
				poifsfileSystem.WriteFileSystem();
			}
			finally
			{
				poifsfileSystem.Close();
			}
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00090FC4 File Offset: 0x0008F1C4
		public override void Write(global::System.IO.Stream out1)
		{
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem();
			try
			{
				this.Write(npoifsfileSystem);
				npoifsfileSystem.WriteFileSystem(out1);
			}
			finally
			{
				npoifsfileSystem.Close();
			}
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00091000 File Offset: 0x0008F200
		private void Write(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>(1);
			base.WriteProperties(fs, list);
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(this.directory, fs.Root, list);
		}
	}
}
