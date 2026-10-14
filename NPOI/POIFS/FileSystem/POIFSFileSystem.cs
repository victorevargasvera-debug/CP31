using System;
using System.IO;
using NPOI.POIFS.Dev;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002F1 RID: 753
	[global::System.Serializable]
	public class POIFSFileSystem : global::NPOI.POIFS.FileSystem.NPOIFSFileSystem, global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x0003C4F2 File Offset: 0x0003A6F2
		public new static global::System.IO.Stream CreateNonClosingInputStream(global::System.IO.Stream stream)
		{
			return new global::NPOI.POIFS.FileSystem.CloseIgnoringInputStream(stream);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00040B1E File Offset: 0x0003ED1E
		public POIFSFileSystem()
		{
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00040B26 File Offset: 0x0003ED26
		public POIFSFileSystem(global::System.IO.Stream stream) : base(stream)
		{
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00040B2F File Offset: 0x0003ED2F
		public POIFSFileSystem(global::System.IO.FileInfo file, bool readOnly) : base(file, readOnly)
		{
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00040B39 File Offset: 0x0003ED39
		public POIFSFileSystem(global::System.IO.FileInfo file) : base(file)
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00040B42 File Offset: 0x0003ED42
		public new static bool HasPOIFSHeader(global::System.IO.Stream inp)
		{
			return global::NPOI.POIFS.FileSystem.NPOIFSFileSystem.HasPOIFSHeader(inp);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00040B4A File Offset: 0x0003ED4A
		public new static bool HasPOIFSHeader(byte[] header8Bytes)
		{
			return global::NPOI.POIFS.FileSystem.NPOIFSFileSystem.HasPOIFSHeader(header8Bytes);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00040B54 File Offset: 0x0003ED54
		public static global::NPOI.POIFS.FileSystem.POIFSFileSystem Create(global::System.IO.FileInfo file)
		{
			global::NPOI.POIFS.FileSystem.POIFSFileSystem poifsfileSystem = new global::NPOI.POIFS.FileSystem.POIFSFileSystem();
			global::System.IO.FileStream fileStream = file.Open(global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			poifsfileSystem.WriteFileSystem(fileStream);
			fileStream.Close();
			poifsfileSystem.Close();
			return new global::NPOI.POIFS.FileSystem.POIFSFileSystem(file, false);
		}
	}
}
