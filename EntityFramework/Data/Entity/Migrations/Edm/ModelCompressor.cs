using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Edm
{
	// Token: 0x020000E1 RID: 225
	internal class ModelCompressor
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x00026DCC File Offset: 0x00024FCC
		public virtual byte[] Compress(global::System.Xml.Linq.XDocument model)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress))
				{
					model.Save(gzipStream);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00026E2C File Offset: 0x0002502C
		public virtual global::System.Xml.Linq.XDocument Decompress(byte[] bytes)
		{
			global::System.Xml.Linq.XDocument result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bytes))
			{
				using (global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress))
				{
					result = global::System.Xml.Linq.XDocument.Load(gzipStream);
				}
			}
			return result;
		}
	}
}
