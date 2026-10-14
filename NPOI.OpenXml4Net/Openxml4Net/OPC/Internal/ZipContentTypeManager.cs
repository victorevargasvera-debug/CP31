using System;
using System.IO;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000028 RID: 40
	public class ZipContentTypeManager : global::NPOI.OpenXml4Net.OPC.Internal.ContentTypeManager
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00008464 File Offset: 0x00006664
		public ZipContentTypeManager(global::System.IO.Stream in1, global::NPOI.OpenXml4Net.OPC.OPCPackage pkg) : base(in1, pkg)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00008470 File Offset: 0x00006670
		public override bool SaveImpl(global::System.Xml.XmlDocument content, global::System.IO.Stream out1)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream;
			if (out1 is global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream)
			{
				zipOutputStream = (global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream)out1;
			}
			else
			{
				zipOutputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(out1);
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry("[Content_Types].xml");
			try
			{
				zipOutputStream.PutNextEntry(entry);
				global::NPOI.OpenXml4Net.OPC.StreamHelper.SaveXmlInStream(content, out1);
				global::System.IO.Stream stream = new global::System.IO.MemoryStream();
				byte[] buffer = new byte[global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.READ_WRITE_FILE_BUFFER_SIZE];
				for (;;)
				{
					int num = stream.Read(buffer, 0, global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.READ_WRITE_FILE_BUFFER_SIZE);
					if (num == 0)
					{
						break;
					}
					zipOutputStream.Write(buffer, 0, num);
				}
				zipOutputStream.CloseEntry();
			}
			catch (global::System.IO.IOException exception)
			{
				global::NPOI.OpenXml4Net.OPC.Internal.ZipContentTypeManager.logger.Log(7, "Cannot write: [Content_Types].xml in Zip !", exception);
				return false;
			}
			return true;
		}

		// Token: 0x040000C4 RID: 196
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.OpenXml4Net.OPC.Internal.ZipContentTypeManager));
	}
}
