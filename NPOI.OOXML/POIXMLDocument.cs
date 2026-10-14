using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NPOI.OpenXml4Net;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI
{
	// Token: 0x02000002 RID: 2
	public abstract class POIXMLDocument : global::NPOI.POIXMLDocumentPart, global::NPOI.Util.ICloseable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		protected POIXMLDocument(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg) : base(pkg)
		{
			this.init(pkg);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		protected POIXMLDocument(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, string coreDocumentRel) : base(pkg, coreDocumentRel)
		{
			this.init(pkg);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002071 File Offset: 0x00000271
		private void init(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			this.pkg = pkg;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207C File Offset: 0x0000027C
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage OpenPackage(string path)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(path);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				throw new global::System.IO.IOException(ex.ToString());
			}
			return result;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000002B0
		public global::NPOI.OpenXml4Net.OPC.OPCPackage Package
		{
			get
			{
				return this.pkg;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020B8 File Offset: 0x000002B8
		protected global::NPOI.OpenXml4Net.OPC.PackagePart CorePart
		{
			get
			{
				return base.GetPackagePart();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C0 File Offset: 0x000002C0
		protected global::NPOI.OpenXml4Net.OPC.PackagePart[] GetRelatedByType(string contentType)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType = base.GetPackagePart().GetRelationshipsByType(contentType);
			global::NPOI.OpenXml4Net.OPC.PackagePart[] array = new global::NPOI.OpenXml4Net.OPC.PackagePart[relationshipsByType.Size];
			int num = 0;
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship rel in relationshipsByType)
			{
				array[num] = base.GetPackagePart().GetRelatedPart(rel);
				num++;
			}
			return array;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002130 File Offset: 0x00000330
		[global::System.Obsolete("Use the method from DocumentFactoryHelper")]
		public static bool HasOOXMLHeader(global::System.IO.Stream inp)
		{
			return global::NPOI.POIFS.FileSystem.DocumentFactoryHelper.HasOOXMLHeader(inp);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002138 File Offset: 0x00000338
		public global::NPOI.POIXMLProperties GetProperties()
		{
			if (this.properties == null)
			{
				try
				{
					this.properties = new global::NPOI.POIXMLProperties(this.pkg);
				}
				catch (global::System.Exception ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
			}
			return this.properties;
		}

		// Token: 0x0600000A RID: 10
		public abstract global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetAllEmbedds();

		// Token: 0x0600000B RID: 11 RVA: 0x0000217C File Offset: 0x0000037C
		protected void Load(global::NPOI.POIXMLFactory factory)
		{
			global::System.Collections.Generic.Dictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart> dictionary = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart>();
			try
			{
				base.Read(factory, dictionary);
			}
			catch (global::NPOI.OpenXml4Net.OpenXml4NetException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			this.OnDocumentRead();
			dictionary.Clear();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021BC File Offset: 0x000003BC
		public void Close()
		{
			if (this.pkg != null)
			{
				if (this.pkg.GetPackageAccess() == global::NPOI.OpenXml4Net.OPC.PackageAccess.READ)
				{
					this.pkg.Revert();
				}
				else
				{
					this.pkg.Close();
				}
				this.pkg = null;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021F4 File Offset: 0x000003F4
		public void Write(global::System.IO.Stream stream)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage package = this.Package;
			if (package == null)
			{
				throw new global::System.IO.IOException("Cannot write data, document seems to have been closed already");
			}
			if (!this.GetProperties().CustomProperties.Contains("Generator"))
			{
				this.GetProperties().CustomProperties.AddProperty("Generator", "NPOI");
			}
			if (!this.GetProperties().CustomProperties.Contains("Generator Version"))
			{
				this.GetProperties().CustomProperties.AddProperty("Generator Version", global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3));
			}
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			base.OnSave(list);
			list.Clear();
			this.GetProperties().Commit();
			package.Save(stream);
		}

		// Token: 0x04000001 RID: 1
		public static string DOCUMENT_CREATOR = "NPOI";

		// Token: 0x04000002 RID: 2
		public static string OLE_OBJECT_REL_TYPE = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject";

		// Token: 0x04000003 RID: 3
		public static string PACK_OBJECT_REL_TYPE = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package";

		// Token: 0x04000004 RID: 4
		private global::NPOI.OpenXml4Net.OPC.OPCPackage pkg;

		// Token: 0x04000005 RID: 5
		private global::NPOI.POIXMLProperties properties;
	}
}
