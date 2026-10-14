using System;
using System.Text;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000017 RID: 23
	public class PackageRelationship
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00005028 File Offset: 0x00003228
		public PackageRelationship(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, global::NPOI.OpenXml4Net.OPC.PackagePart sourcePart, global::System.Uri targetUri, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string id)
		{
			if (pkg == null)
			{
				throw new global::System.ArgumentException("pkg");
			}
			if (targetUri == null)
			{
				throw new global::System.ArgumentException("targetUri");
			}
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			if (id == null)
			{
				throw new global::System.ArgumentException("id");
			}
			this.container = pkg;
			this.source = sourcePart;
			this.targetUri = targetUri;
			this.targetMode = new global::NPOI.OpenXml4Net.OPC.TargetMode?(targetMode);
			this.relationshipType = relationshipType;
			this.id = id;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000050B0 File Offset: 0x000032B0
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.OpenXml4Net.OPC.PackageRelationship))
			{
				return false;
			}
			global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = (global::NPOI.OpenXml4Net.OPC.PackageRelationship)obj;
			if (this.id == packageRelationship.id && this.relationshipType == packageRelationship.relationshipType && (packageRelationship.source == null || packageRelationship.source.Equals(this.source)))
			{
				global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = this.targetMode;
				global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode2 = packageRelationship.targetMode;
				if (targetMode.GetValueOrDefault() == targetMode2.GetValueOrDefault() & targetMode != null == (targetMode2 != null))
				{
					return this.targetUri.Equals(packageRelationship.targetUri);
				}
			}
			return false;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005158 File Offset: 0x00003358
		public override int GetHashCode()
		{
			return this.id.GetHashCode() + this.relationshipType.GetHashCode() + this.source.GetHashCode() + this.targetMode.GetHashCode() + this.targetUri.GetHashCode();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000051A6 File Offset: 0x000033A6
		public static global::System.Uri ContainerPartRelationship
		{
			get
			{
				return global::NPOI.OpenXml4Net.OPC.PackageRelationship.containerRelationshipPart;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000051AD File Offset: 0x000033AD
		public global::NPOI.OpenXml4Net.OPC.OPCPackage Package
		{
			get
			{
				return this.container;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000051B5 File Offset: 0x000033B5
		public string Id
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000051BD File Offset: 0x000033BD
		public string RelationshipType
		{
			get
			{
				return this.relationshipType;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000051C5 File Offset: 0x000033C5
		public global::NPOI.OpenXml4Net.OPC.PackagePart Source
		{
			get
			{
				return this.source;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000051CD File Offset: 0x000033CD
		public global::System.Uri SourceUri
		{
			get
			{
				if (this.source == null)
				{
					return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI;
				}
				return this.source.PartName.URI;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000051ED File Offset: 0x000033ED
		public global::NPOI.OpenXml4Net.OPC.TargetMode? TargetMode
		{
			get
			{
				return this.targetMode;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000051F8 File Offset: 0x000033F8
		public global::System.Uri TargetUri
		{
			get
			{
				global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = this.targetMode;
				global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
				if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
				{
					return this.targetUri;
				}
				if (!this.targetUri.ToString().StartsWith("/"))
				{
					return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ResolvePartUri(this.SourceUri, this.targetUri);
				}
				return this.targetUri;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005258 File Offset: 0x00003458
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append((this.id == null) ? "id=null" : ("id=" + this.id));
			stringBuilder.Append((this.container == null) ? " - container=null" : (" - container=" + this.container.ToString()));
			stringBuilder.Append((this.relationshipType == null) ? " - relationshipType=null" : (" - relationshipType=" + this.relationshipType.ToString()));
			stringBuilder.Append((this.source == null) ? " - source=null" : (" - source=" + this.SourceUri.OriginalString));
			stringBuilder.Append((this.targetUri == null) ? " - target=null" : (" - target=" + this.TargetUri.OriginalString));
			stringBuilder.Append((this.targetMode == null) ? ",targetMode=null" : (",targetMode=" + this.targetMode.ToString()));
			return stringBuilder.ToString();
		}

		// Token: 0x04000056 RID: 86
		private static global::System.Uri containerRelationshipPart = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri("/_rels/.rels", global::System.UriKind.RelativeOrAbsolute);

		// Token: 0x04000057 RID: 87
		public static string ID_ATTRIBUTE_NAME = "Id";

		// Token: 0x04000058 RID: 88
		public static string RELATIONSHIPS_TAG_NAME = "Relationships";

		// Token: 0x04000059 RID: 89
		public static string RELATIONSHIP_TAG_NAME = "Relationship";

		// Token: 0x0400005A RID: 90
		public static string TARGET_ATTRIBUTE_NAME = "Target";

		// Token: 0x0400005B RID: 91
		public static string TARGET_MODE_ATTRIBUTE_NAME = "TargetMode";

		// Token: 0x0400005C RID: 92
		public static string TYPE_ATTRIBUTE_NAME = "Type";

		// Token: 0x0400005D RID: 93
		private string id;

		// Token: 0x0400005E RID: 94
		private global::NPOI.OpenXml4Net.OPC.OPCPackage container;

		// Token: 0x0400005F RID: 95
		private string relationshipType;

		// Token: 0x04000060 RID: 96
		private global::NPOI.OpenXml4Net.OPC.PackagePart source;

		// Token: 0x04000061 RID: 97
		private global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode;

		// Token: 0x04000062 RID: 98
		private global::System.Uri targetUri;
	}
}
