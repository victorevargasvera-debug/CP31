using System;
using System.IO;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;

namespace NPOI.Util
{
	// Token: 0x020000EE RID: 238
	public class PackageHelper
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00033858 File Offset: 0x00031A58
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::System.IO.Stream is1)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(is1);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00033888 File Offset: 0x00031A88
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Clone(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, string path)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = global::NPOI.OpenXml4Net.OPC.OPCPackage.Create(path);
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in pkg.Relationships)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart part = pkg.GetPart(packageRelationship);
				if (packageRelationship.RelationshipType.Equals("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties"))
				{
					global::NPOI.Util.PackageHelper.CopyProperties(pkg.GetPackageProperties(), opcpackage.GetPackageProperties());
				}
				else
				{
					opcpackage.AddRelationship(part.PartName, packageRelationship.TargetMode.Value, packageRelationship.RelationshipType);
					global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = opcpackage.CreatePart(part.PartName, part.ContentType);
					global::System.IO.Stream outputStream = packagePart.GetOutputStream();
					global::NPOI.Util.IOUtils.Copy(part.GetInputStream(), outputStream);
					outputStream.Close();
					if (part.HasRelationships)
					{
						global::NPOI.Util.PackageHelper.Copy(pkg, part, opcpackage, packagePart);
					}
				}
			}
			opcpackage.Close();
			return global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(path);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0003397C File Offset: 0x00031B7C
		public string CreateTempFile()
		{
			return global::NPOI.Util.TempFile.GetTempFilePath("poi-ooxml-", ".tmp");
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00033990 File Offset: 0x00031B90
		private static void Copy(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.OPCPackage tgt, global::NPOI.OpenXml4Net.OPC.PackagePart part_tgt)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationships = part.Relationships;
			if (relationships != null)
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in relationships)
				{
					global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = packageRelationship.TargetMode;
					global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
					if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
					{
						part_tgt.AddExternalRelationship(packageRelationship.TargetUri.ToString(), packageRelationship.RelationshipType, packageRelationship.Id);
					}
					else
					{
						global::System.Uri targetUri = packageRelationship.TargetUri;
						if (targetUri.Fragment != null)
						{
							part_tgt.AddRelationship(targetUri, packageRelationship.TargetMode.Value, packageRelationship.RelationshipType, packageRelationship.Id);
						}
						else
						{
							global::NPOI.OpenXml4Net.OPC.PackagePartName partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(packageRelationship.TargetUri);
							global::NPOI.OpenXml4Net.OPC.PackagePart part2 = pkg.GetPart(partName);
							part_tgt.AddRelationship(part2.PartName, packageRelationship.TargetMode.Value, packageRelationship.RelationshipType, packageRelationship.Id);
							if (!tgt.ContainPart(part2.PartName))
							{
								global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = tgt.CreatePart(part2.PartName, part2.ContentType);
								global::System.IO.Stream outputStream = packagePart.GetOutputStream();
								global::NPOI.Util.IOUtils.Copy(part2.GetInputStream(), outputStream);
								outputStream.Close();
								global::NPOI.Util.PackageHelper.Copy(pkg, part2, tgt, packagePart);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00033AF4 File Offset: 0x00031CF4
		private static void CopyProperties(global::NPOI.OpenXml4Net.OPC.PackageProperties src, global::NPOI.OpenXml4Net.OPC.PackageProperties tgt)
		{
			tgt.SetCategoryProperty(src.GetCategoryProperty());
			tgt.SetContentStatusProperty(src.GetContentStatusProperty());
			tgt.SetContentTypeProperty(src.GetContentTypeProperty());
			tgt.SetCreatorProperty(src.GetCreatorProperty());
			tgt.SetDescriptionProperty(src.GetDescriptionProperty());
			tgt.SetIdentifierProperty(src.GetIdentifierProperty());
			tgt.SetKeywordsProperty(src.GetKeywordsProperty());
			tgt.SetLanguageProperty(src.GetLanguageProperty());
			tgt.SetRevisionProperty(src.GetRevisionProperty());
			tgt.SetSubjectProperty(src.GetSubjectProperty());
			tgt.SetTitleProperty(src.GetTitleProperty());
			tgt.SetVersionProperty(src.GetVersionProperty());
		}
	}
}
