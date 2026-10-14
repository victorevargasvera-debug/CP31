using System;
using System.IO;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXml4Net.OPC.Internal;
using NPOI.OpenXmlFormats;

namespace NPOI
{
	// Token: 0x02000009 RID: 9
	public class POIXMLProperties
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003654 File Offset: 0x00001854
		static POIXMLProperties()
		{
			global::NPOI.POIXMLProperties.NEW_EXT_INSTANCE.AddNewProperties();
			global::NPOI.POIXMLProperties.NEW_CUST_INSTANCE = new global::NPOI.OpenXmlFormats.CustomPropertiesDocument();
			global::NPOI.POIXMLProperties.NEW_CUST_INSTANCE.AddNewProperties();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003680 File Offset: 0x00001880
		public POIXMLProperties(global::NPOI.OpenXml4Net.OPC.OPCPackage docPackage)
		{
			this.pkg = docPackage;
			this.core = new global::NPOI.CoreProperties((global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart)this.pkg.GetPackageProperties());
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType = this.pkg.GetRelationshipsByType("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties");
			if (relationshipsByType.Size == 1)
			{
				this.extPart = this.pkg.GetPart(relationshipsByType.GetRelationship(0));
				global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument props = global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument.Parse(this.extPart.GetInputStream());
				this.ext = new global::NPOI.ExtendedProperties(props);
			}
			else
			{
				this.extPart = null;
				this.ext = new global::NPOI.ExtendedProperties(global::NPOI.POIXMLProperties.NEW_EXT_INSTANCE.Copy());
			}
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType2 = this.pkg.GetRelationshipsByType("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties");
			if (relationshipsByType2.Size == 1)
			{
				this.custPart = this.pkg.GetPart(relationshipsByType2.GetRelationship(0));
				global::NPOI.OpenXmlFormats.CustomPropertiesDocument props2 = global::NPOI.OpenXmlFormats.CustomPropertiesDocument.Parse(this.custPart.GetInputStream());
				this.cust = new global::NPOI.CustomProperties(props2);
				return;
			}
			this.custPart = null;
			this.cust = new global::NPOI.CustomProperties(global::NPOI.POIXMLProperties.NEW_CUST_INSTANCE.Copy());
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000378E File Offset: 0x0000198E
		public global::NPOI.CoreProperties CoreProperties
		{
			get
			{
				return this.core;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003796 File Offset: 0x00001996
		public global::NPOI.ExtendedProperties ExtendedProperties
		{
			get
			{
				return this.ext;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000379E File Offset: 0x0000199E
		public global::NPOI.CustomProperties CustomProperties
		{
			get
			{
				return this.cust;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000037A8 File Offset: 0x000019A8
		protected internal global::NPOI.OpenXml4Net.OPC.PackagePart ThumbnailPart
		{
			get
			{
				global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType = this.pkg.GetRelationshipsByType("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail");
				if (relationshipsByType.Size == 1)
				{
					return this.pkg.GetPart(relationshipsByType.GetRelationship(0));
				}
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000037E4 File Offset: 0x000019E4
		public string ThumbnailFilename
		{
			get
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart thumbnailPart = this.ThumbnailPart;
				if (thumbnailPart == null)
				{
					return null;
				}
				string name = thumbnailPart.PartName.Name;
				return name.Substring(name.LastIndexOf('/') + 1);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003818 File Offset: 0x00001A18
		public global::System.IO.Stream ThumbnailImage
		{
			get
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart thumbnailPart = this.ThumbnailPart;
				if (thumbnailPart == null)
				{
					return null;
				}
				return thumbnailPart.GetInputStream();
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003838 File Offset: 0x00001A38
		public void SetThumbnail(string filename, global::System.IO.Stream imageData)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart thumbnailPart = this.ThumbnailPart;
			if (thumbnailPart == null)
			{
				this.pkg.AddThumbnail(filename, imageData);
				return;
			}
			string contentTypeFromFileExtension = global::NPOI.OpenXml4Net.OPC.ContentTypes.GetContentTypeFromFileExtension(filename);
			if (!contentTypeFromFileExtension.Equals(thumbnailPart.ContentType))
			{
				throw new global::System.ArgumentException("Can't set a Thumbnail of type " + contentTypeFromFileExtension + " when existing one is of a different type " + thumbnailPart.ContentType);
			}
			global::NPOI.OpenXml4Net.OPC.StreamHelper.CopyStream(imageData, thumbnailPart.GetOutputStream());
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000389C File Offset: 0x00001A9C
		public virtual void Commit()
		{
			if (this.extPart == null && !global::NPOI.POIXMLProperties.NEW_EXT_INSTANCE.ToString().Equals(this.ext.props.ToString()))
			{
				try
				{
					global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName("/docProps/app.xml");
					this.pkg.AddRelationship(packagePartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties");
					this.extPart = this.pkg.CreatePart(packagePartName, "application/vnd.openxmlformats-officedocument.extended-properties+xml");
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
			}
			if (this.custPart == null && !global::NPOI.POIXMLProperties.NEW_CUST_INSTANCE.ToString().Equals(this.cust.props.ToString()))
			{
				try
				{
					global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName2 = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName("/docProps/custom.xml");
					this.pkg.AddRelationship(packagePartName2, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties");
					this.custPart = this.pkg.CreatePart(packagePartName2, "application/vnd.openxmlformats-officedocument.custom-properties+xml");
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex2)
				{
					throw new global::NPOI.POIXMLException(ex2);
				}
			}
			if (this.extPart != null)
			{
				global::System.IO.Stream outputStream = this.extPart.GetOutputStream();
				if (this.extPart.Size > 0L)
				{
					this.extPart.Clear();
				}
				this.ext.props.Save(outputStream);
				outputStream.Close();
			}
			if (this.custPart != null)
			{
				global::System.IO.Stream outputStream2 = this.custPart.GetOutputStream();
				this.cust.props.Save(outputStream2);
				outputStream2.Close();
			}
		}

		// Token: 0x04000015 RID: 21
		private global::NPOI.OpenXml4Net.OPC.OPCPackage pkg;

		// Token: 0x04000016 RID: 22
		private global::NPOI.CoreProperties core;

		// Token: 0x04000017 RID: 23
		private global::NPOI.ExtendedProperties ext;

		// Token: 0x04000018 RID: 24
		private global::NPOI.CustomProperties cust;

		// Token: 0x04000019 RID: 25
		private global::NPOI.OpenXml4Net.OPC.PackagePart extPart;

		// Token: 0x0400001A RID: 26
		private global::NPOI.OpenXml4Net.OPC.PackagePart custPart;

		// Token: 0x0400001B RID: 27
		private static global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument NEW_EXT_INSTANCE = new global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument();

		// Token: 0x0400001C RID: 28
		private static global::NPOI.OpenXmlFormats.CustomPropertiesDocument NEW_CUST_INSTANCE;
	}
}
