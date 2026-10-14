using System;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.Util;

namespace NPOI
{
	// Token: 0x02000005 RID: 5
	public abstract class POIXMLFactory
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002E10 File Offset: 0x00001010
		public virtual global::NPOI.POIXMLDocumentPart CreateDocumentPart(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = this.GetPackageRelationship(parent, part);
			global::NPOI.POIXMLRelation descriptor = this.GetDescriptor(packageRelationship.RelationshipType);
			if (descriptor == null || descriptor.RelationClass == null)
			{
				global::NPOI.POIXMLFactory.LOGGER.Log(1, "using default POIXMLDocumentPart for " + packageRelationship.RelationshipType);
				return new global::NPOI.POIXMLDocumentPart(parent, part);
			}
			global::System.Type relationClass = descriptor.RelationClass;
			global::NPOI.POIXMLDocumentPart result;
			try
			{
				try
				{
					result = this.CreateDocumentPart(relationClass, global::NPOI.POIXMLFactory.PARENT_PART, new object[]
					{
						parent,
						part
					});
				}
				catch (global::System.MissingMethodException)
				{
					result = this.CreateDocumentPart(relationClass, global::NPOI.POIXMLFactory.ORPHAN_PART, new object[]
					{
						part
					});
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x0600003E RID: 62
		protected abstract global::NPOI.POIXMLDocumentPart CreateDocumentPart(global::System.Type cls, global::System.Type[] classes, object[] values);

		// Token: 0x0600003F RID: 63
		protected abstract global::NPOI.POIXMLRelation GetDescriptor(string relationshipType);

		// Token: 0x06000040 RID: 64 RVA: 0x00002EC8 File Offset: 0x000010C8
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public virtual global::NPOI.POIXMLDocumentPart CreateDocumentPart(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel, global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			return this.CreateDocumentPart(parent, part);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002ED4 File Offset: 0x000010D4
		public global::NPOI.POIXMLDocumentPart NewDocumentPart(global::NPOI.POIXMLRelation descriptor)
		{
			global::System.Type relationClass = descriptor.RelationClass;
			global::NPOI.POIXMLDocumentPart result;
			try
			{
				result = this.CreateDocumentPart(relationClass, null, null);
			}
			catch (global::System.Exception ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002F0C File Offset: 0x0000110C
		protected global::NPOI.OpenXml4Net.OPC.PackageRelationship GetPackageRelationship(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			try
			{
				string name = part.PartName.Name;
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in parent.GetPackagePart().Relationships)
				{
					if (packageRelationship.TargetUri.ToString().Equals(name, global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						return packageRelationship;
					}
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::NPOI.POIXMLException("error while determining package relations", ex);
			}
			throw new global::NPOI.POIXMLException("package part isn't a child of the parent document.");
		}

		// Token: 0x0400000E RID: 14
		private static global::NPOI.Util.POILogger LOGGER = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIXMLFactory));

		// Token: 0x0400000F RID: 15
		private static global::System.Type[] PARENT_PART = new global::System.Type[]
		{
			typeof(global::NPOI.POIXMLDocumentPart),
			typeof(global::NPOI.OpenXml4Net.OPC.PackagePart)
		};

		// Token: 0x04000010 RID: 16
		private static global::System.Type[] ORPHAN_PART = new global::System.Type[]
		{
			typeof(global::NPOI.OpenXml4Net.OPC.PackagePart)
		};
	}
}
