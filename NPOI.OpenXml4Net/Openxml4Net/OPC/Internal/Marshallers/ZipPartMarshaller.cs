using System;
using System.IO;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC.Internal.Marshallers
{
	// Token: 0x0200002F RID: 47
	public class ZipPartMarshaller : global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public bool Marshall(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::System.IO.Stream os)
		{
			if (!(os is global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream))
			{
				global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller.logger.Log(7, "Unexpected class " + os.GetType().Name);
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException("ZipOutputStream expected !");
			}
			if (part.Size == 0L && part.PartName.Name.Equals("/xl/sharedStrings.xml"))
			{
				return true;
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream = (global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream)os;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetZipItemNameFromOPCName(part.PartName.URI.OriginalString));
			try
			{
				zipOutputStream.PutNextEntry(entry);
				global::System.IO.Stream inputStream = part.GetInputStream();
				byte[] array = new byte[global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.READ_WRITE_FILE_BUFFER_SIZE];
				int num = 0;
				for (;;)
				{
					int num2 = inputStream.Read(array, 0, array.Length);
					if (num2 == 0)
					{
						break;
					}
					zipOutputStream.Write(array, 0, num2);
					num += num2;
				}
				zipOutputStream.CloseEntry();
			}
			catch (global::System.IO.IOException exception)
			{
				global::NPOI.Util.POILogger poilogger = global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller.logger;
				int level = 7;
				string str = "Cannot write: ";
				global::NPOI.OpenXml4Net.OPC.PackagePartName partName = part.PartName;
				poilogger.Log(level, str + ((partName != null) ? partName.ToString() : null) + ": in ZIP", exception);
				return false;
			}
			if (part.HasRelationships)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName relationshipPartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(part.PartName);
				global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller.MarshallRelationshipPart(part.Relationships, relationshipPartName, zipOutputStream);
			}
			return true;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00009F0C File Offset: 0x0000810C
		public static bool MarshallRelationshipPart(global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection rels, global::NPOI.OpenXml4Net.OPC.PackagePartName relPartName, global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zos)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			new global::System.Xml.XmlNamespaceManager(xmlDocument.NameTable).AddNamespace("x", "http://schemas.openxmlformats.org/package/2006/relationships");
			xmlDocument.AppendChild(xmlDocument.CreateElement(global::NPOI.OpenXml4Net.OPC.PackageRelationship.RELATIONSHIPS_TAG_NAME, "http://schemas.openxmlformats.org/package/2006/relationships"));
			global::System.Uri sourcePartUriFromRelationshipPartUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetSourcePartUriFromRelationshipPartUri(relPartName.URI);
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in rels)
			{
				global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(global::NPOI.OpenXml4Net.OPC.PackageRelationship.RELATIONSHIP_TAG_NAME, "http://schemas.openxmlformats.org/package/2006/relationships");
				xmlElement.SetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.ID_ATTRIBUTE_NAME, packageRelationship.Id);
				xmlElement.SetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TYPE_ATTRIBUTE_NAME, packageRelationship.RelationshipType);
				global::System.Uri targetUri = packageRelationship.TargetUri;
				global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = packageRelationship.TargetMode;
				global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
				string value;
				if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
				{
					value = targetUri.OriginalString;
					xmlElement.SetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TARGET_MODE_ATTRIBUTE_NAME, "External");
				}
				else
				{
					value = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RelativizeUri(sourcePartUriFromRelationshipPartUri, packageRelationship.TargetUri, true).ToString();
				}
				xmlElement.SetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TARGET_ATTRIBUTE_NAME, value);
				xmlDocument.DocumentElement.AppendChild(xmlElement);
			}
			xmlDocument.Normalize();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetZipURIFromOPCName(relPartName.URI.ToString()).OriginalString);
			try
			{
				zos.PutNextEntry(entry);
				global::NPOI.OpenXml4Net.OPC.StreamHelper.SaveXmlInStream(xmlDocument, zos);
				zos.CloseEntry();
			}
			catch (global::System.IO.IOException exception)
			{
				global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller.logger.Log(7, "Cannot create zip entry " + ((relPartName != null) ? relPartName.ToString() : null), exception);
				return false;
			}
			return true;
		}

		// Token: 0x040000F7 RID: 247
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller));
	}
}
