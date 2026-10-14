using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.Openxml4Net.Exceptions;
using NPOI.POIFS.Common;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000029 RID: 41
	public class ZipHelper
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		private ZipHelper()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008530 File Offset: 0x00006730
		public static global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetCorePropertiesZipEntry(global::NPOI.OpenXml4Net.OPC.ZipPackage pkg)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = pkg.GetRelationshipsByType("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties").GetRelationship(0);
			if (relationship == null)
			{
				return null;
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(relationship.TargetUri.OriginalString);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008564 File Offset: 0x00006764
		public static global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetContentTypeZipEntry(global::NPOI.OpenXml4Net.OPC.ZipPackage pkg)
		{
			global::System.Collections.IEnumerator entries = pkg.ZipArchive.Entries;
			while (entries.MoveNext())
			{
				object obj = entries.Current;
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj;
				if (zipEntry.Name.Equals("[Content_Types].xml"))
				{
					return zipEntry;
				}
			}
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000085A8 File Offset: 0x000067A8
		public static string GetOPCNameFromZipItemName(string zipItemName)
		{
			if (zipItemName == null)
			{
				throw new global::System.ArgumentException("zipItemName");
			}
			if (zipItemName.StartsWith(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.FORWARD_SLASH))
			{
				return zipItemName;
			}
			return global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.FORWARD_SLASH + zipItemName;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000085D4 File Offset: 0x000067D4
		public static string GetZipItemNameFromOPCName(string opcItemName)
		{
			if (opcItemName == null)
			{
				throw new global::System.ArgumentException("opcItemName");
			}
			string text = opcItemName;
			while (text.StartsWith(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.FORWARD_SLASH))
			{
				text = text.Substring(1);
			}
			return text;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000860C File Offset: 0x0000680C
		public static global::System.Uri GetZipURIFromOPCName(string opcItemName)
		{
			if (opcItemName == null)
			{
				throw new global::System.ArgumentException("opcItemName");
			}
			string text = opcItemName;
			while (text.StartsWith(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.FORWARD_SLASH))
			{
				text = text.Substring(1);
			}
			global::System.Uri result;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(text, global::System.UriKind.RelativeOrAbsolute);
			}
			catch (global::System.UriFormatException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00008664 File Offset: 0x00006864
		public static void VerifyZipHeader(global::NPOI.Util.InputStream stream)
		{
			byte[] array = new byte[8];
			global::NPOI.Util.IOUtils.ReadFully(stream, array);
			if (global::NPOI.Util.LittleEndian.GetLong(array) == -2226271756974174256L)
			{
				throw new global::NPOI.Openxml4Net.Exceptions.OLE2NotOfficeXmlFileException("The supplied data appears to be in the OLE2 Format. You are calling the part of POI that deals with OOXML (Office Open XML) Documents. You need to call a different part of POI to process this data (eg HSSF instead of XSSF)");
			}
			byte[] raw_XML_FILE_HEADER = global::NPOI.POIFS.Common.POIFSConstants.RAW_XML_FILE_HEADER;
			if (array[0] == raw_XML_FILE_HEADER[0] && array[1] == raw_XML_FILE_HEADER[1] && array[2] == raw_XML_FILE_HEADER[2] && array[3] == raw_XML_FILE_HEADER[3] && array[4] == raw_XML_FILE_HEADER[4])
			{
				throw new global::NPOI.Openxml4Net.Exceptions.NotOfficeXmlFileException("The supplied data appears to be a raw XML file. Formats such as Office 2003 XML are not supported");
			}
			if (stream is global::NPOI.Util.PushbackInputStream)
			{
				((global::NPOI.Util.PushbackInputStream)stream).Unread(array);
				return;
			}
			if (stream.MarkSupported())
			{
				stream.Reset();
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000086F8 File Offset: 0x000068F8
		private static global::NPOI.Util.InputStream PrepareToCheckHeader(global::NPOI.Util.InputStream stream)
		{
			if (stream is global::NPOI.Util.PushbackInputStream)
			{
				return stream;
			}
			if (stream.MarkSupported())
			{
				stream.Mark(8);
				return stream;
			}
			return new global::NPOI.Util.PushbackInputStream(stream, 8);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000871C File Offset: 0x0000691C
		public static global::ICSharpCode.SharpZipLib.Zip.ZipInputStream OpenZipStream(global::System.IO.Stream stream)
		{
			return new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream(stream);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008724 File Offset: 0x00006924
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile OpenZipFile(global::System.IO.FileInfo file)
		{
			if (!file.Exists)
			{
				throw new global::System.IO.FileNotFoundException("File does not exist");
			}
			global::NPOI.Util.FileInputStream fileInputStream = new global::NPOI.Util.FileInputStream(file.OpenRead());
			try
			{
				global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.VerifyZipHeader(fileInputStream);
			}
			finally
			{
				fileInputStream.Close();
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile(global::System.IO.File.OpenRead(file.FullName));
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008780 File Offset: 0x00006980
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile OpenZipFile(string path)
		{
			return global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.OpenZipFile(new global::System.IO.FileInfo(path));
		}

		// Token: 0x040000C5 RID: 197
		private static string FORWARD_SLASH = "/";

		// Token: 0x040000C6 RID: 198
		public static int READ_WRITE_FILE_BUFFER_SIZE = 8192;
	}
}
