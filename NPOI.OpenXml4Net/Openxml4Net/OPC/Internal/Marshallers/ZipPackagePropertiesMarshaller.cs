using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace NPOI.OpenXml4Net.OPC.Internal.Marshallers
{
	// Token: 0x0200002E RID: 46
	public class ZipPackagePropertiesMarshaller : global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.PackagePropertiesMarshaller
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00009D34 File Offset: 0x00007F34
		public override bool Marshall(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::System.IO.Stream out1)
		{
			if (!(out1 is global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream))
			{
				throw new global::System.ArgumentException("ZipOutputStream expected!");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream = (global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream)out1;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetZipItemNameFromOPCName(part.PartName.URI.ToString()));
			try
			{
				zipOutputStream.PutNextEntry(entry);
				base.Marshall(part, out1);
				global::NPOI.OpenXml4Net.OPC.StreamHelper.SaveXmlInStream(this.xmlDoc, out1);
				zipOutputStream.CloseEntry();
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException(ex.Message, ex);
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
}
