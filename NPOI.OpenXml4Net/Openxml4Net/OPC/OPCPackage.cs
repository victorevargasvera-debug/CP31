using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC.Internal;
using NPOI.OpenXml4Net.OPC.Internal.Marshallers;
using NPOI.OpenXml4Net.OPC.Internal.Unmarshallers;
using NPOI.OpenXml4Net.Util;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000010 RID: 16
	public abstract class OPCPackage : global::NPOI.OpenXml4Net.OPC.RelationshipSource
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002C7D File Offset: 0x00000E7D
		public OPCPackage(global::NPOI.OpenXml4Net.OPC.PackageAccess access)
		{
			if (base.GetType() != typeof(global::NPOI.OpenXml4Net.OPC.ZipPackage))
			{
				throw new global::System.ArgumentException("PackageBase may not be subclassed");
			}
			this.Init();
			this.packageAccess = access;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private void Init()
		{
			this.partMarshallers = new global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.Internal.ContentType, global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller>(5);
			this.partUnmarshallers = new global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.Internal.ContentType, global::NPOI.OpenXml4Net.OPC.Internal.PartUnmarshaller>(2);
			try
			{
				this.partUnmarshallers.Add(new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART), new global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.PackagePropertiesUnmarshaller());
				this.defaultPartMarshaller = new global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.DefaultMarshaller();
				this.partMarshallers.Add(new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART), new global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPackagePropertiesMarshaller());
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException("Package.init() : this exception should never happen, if you read this message please send a mail to the developers team.");
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002D38 File Offset: 0x00000F38
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(string path)
		{
			return global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(path, global::NPOI.OpenXml4Net.OPC.OPCPackage.defaultPackageAccess);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002D45 File Offset: 0x00000F45
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::System.IO.FileInfo file)
		{
			return global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(file, global::NPOI.OpenXml4Net.OPC.OPCPackage.defaultPackageAccess);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002D54 File Offset: 0x00000F54
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::NPOI.OpenXml4Net.Util.ZipEntrySource zipEntry)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage(zipEntry, global::NPOI.OpenXml4Net.OPC.PackageAccess.READ);
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				if (opcpackage.partList == null)
				{
					opcpackage.GetParts();
				}
				result = opcpackage;
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				try
				{
					opcpackage.Close();
				}
				catch (global::System.IO.IOException ex2)
				{
					throw new global::System.InvalidOperationException(ex2.Message, ex);
				}
				throw ex;
			}
			catch (global::NPOI.Util.RuntimeException ex3)
			{
				try
				{
					opcpackage.Close();
				}
				catch (global::System.IO.IOException ex4)
				{
					throw new global::System.InvalidOperationException(ex4.Message, ex3);
				}
				throw ex3;
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(string path, global::NPOI.OpenXml4Net.OPC.PackageAccess access)
		{
			if (path == null || "".Equals(path.Trim()))
			{
				throw new global::System.ArgumentException("'path' must be given");
			}
			if (new global::System.IO.DirectoryInfo(path).Exists)
			{
				throw new global::System.ArgumentException("path must not be a directory");
			}
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage(path, access);
			bool flag = false;
			if (opcpackage.partList == null && access != global::NPOI.OpenXml4Net.OPC.PackageAccess.WRITE)
			{
				try
				{
					opcpackage.GetParts();
					flag = true;
				}
				finally
				{
					if (!flag)
					{
						try
						{
							opcpackage.Close();
						}
						catch (global::System.IO.IOException innerException)
						{
							throw new global::System.InvalidOperationException("Could not close OPCPackage while cleaning up", innerException);
						}
					}
				}
			}
			opcpackage.originalPackagePath = new global::System.IO.DirectoryInfo(path).FullName;
			return opcpackage;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E90 File Offset: 0x00001090
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::System.IO.FileInfo file, global::NPOI.OpenXml4Net.OPC.PackageAccess access)
		{
			if (file == null)
			{
				throw new global::System.ArgumentNullException("'file' must be given");
			}
			if (new global::System.IO.DirectoryInfo(file.FullName).Exists)
			{
				throw new global::System.ArgumentException("file must not be a directory");
			}
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage(file, access);
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			try
			{
				if (opcpackage.partList == null && access != global::NPOI.OpenXml4Net.OPC.PackageAccess.WRITE)
				{
					opcpackage.GetParts();
				}
				opcpackage.originalPackagePath = file.FullName;
				result = opcpackage;
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				try
				{
					opcpackage.Close();
				}
				catch (global::System.IO.IOException ex2)
				{
					throw new global::System.InvalidOperationException(ex2.Message, ex);
				}
				throw ex;
			}
			catch (global::NPOI.Util.RuntimeException ex3)
			{
				try
				{
					opcpackage.Close();
				}
				catch (global::System.IO.IOException ex4)
				{
					throw new global::System.InvalidOperationException(ex4.Message, ex3);
				}
				throw ex3;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002F58 File Offset: 0x00001158
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::System.IO.Stream in1)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage(in1, global::NPOI.OpenXml4Net.OPC.PackageAccess.READ_WRITE);
			if (opcpackage.partList == null)
			{
				opcpackage.GetParts();
			}
			return opcpackage;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F80 File Offset: 0x00001180
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Open(global::System.IO.Stream in1, bool bReadonly)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage opcpackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage(in1, bReadonly ? global::NPOI.OpenXml4Net.OPC.PackageAccess.READ : global::NPOI.OpenXml4Net.OPC.PackageAccess.READ_WRITE);
			if (opcpackage.partList == null)
			{
				opcpackage.GetParts();
			}
			return opcpackage;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002FAC File Offset: 0x000011AC
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage OpenOrCreate(string path)
		{
			global::NPOI.OpenXml4Net.OPC.OPCPackage result;
			if (global::System.IO.File.Exists(path))
			{
				result = global::NPOI.OpenXml4Net.OPC.OPCPackage.Open(path);
			}
			else
			{
				result = global::NPOI.OpenXml4Net.OPC.OPCPackage.Create(path);
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002FD4 File Offset: 0x000011D4
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Create(string path)
		{
			if (new global::System.IO.DirectoryInfo(path).Exists)
			{
				throw new global::System.ArgumentException("file");
			}
			if (global::System.IO.File.Exists(path))
			{
				throw new global::System.InvalidOperationException("This package (or file) already exists : use the open() method or delete the file.");
			}
			global::NPOI.OpenXml4Net.OPC.ZipPackage zipPackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage();
			zipPackage.originalPackagePath = new global::System.IO.FileInfo(path).FullName;
			global::NPOI.OpenXml4Net.OPC.OPCPackage.ConfigurePackage(zipPackage);
			return zipPackage;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003028 File Offset: 0x00001228
		public static global::NPOI.OpenXml4Net.OPC.OPCPackage Create(global::System.IO.Stream output)
		{
			global::NPOI.OpenXml4Net.OPC.ZipPackage zipPackage = new global::NPOI.OpenXml4Net.OPC.ZipPackage();
			zipPackage.originalPackagePath = null;
			zipPackage.output = output;
			global::NPOI.OpenXml4Net.OPC.OPCPackage.ConfigurePackage(zipPackage);
			return zipPackage;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003044 File Offset: 0x00001244
		private static void ConfigurePackage(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			try
			{
				pkg.contentTypeManager = new global::NPOI.OpenXml4Net.OPC.Internal.ZipContentTypeManager(null, pkg);
				pkg.contentTypeManager.AddContentType(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_URI), global::NPOI.OpenXml4Net.OPC.ContentTypes.RELATIONSHIPS_PART);
				pkg.contentTypeManager.AddContentType(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName("/default.xml"), global::NPOI.OpenXml4Net.OPC.ContentTypes.PLAIN_OLD_XML);
				pkg.packageProperties = new global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart(pkg, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CORE_PROPERTIES_PART_NAME);
				pkg.packageProperties.SetCreatorProperty("Generated by OpenXml4Net");
				pkg.packageProperties.SetCreatedProperty(new global::System.DateTime?(global::System.DateTime.Now));
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				throw;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000030E0 File Offset: 0x000012E0
		public void Flush()
		{
			this.ThrowExceptionIfReadOnly();
			if (this.packageProperties != null)
			{
				this.packageProperties.Flush();
			}
			this.FlushImpl();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003104 File Offset: 0x00001304
		public void Close()
		{
			if (this.packageAccess == global::NPOI.OpenXml4Net.OPC.PackageAccess.READ)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage.logger.Log(5, "The close() method is intended to SAVE a package. This package is open in READ ONLY mode, use the revert() method instead !");
				this.Revert();
				return;
			}
			if (this.contentTypeManager == null)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage.logger.Log(5, "Unable to call close() on a package that hasn't been fully opened yet");
				this.Revert();
				return;
			}
			if (this.originalPackagePath != null && !"".Equals(this.originalPackagePath.Trim()))
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.originalPackagePath);
				if (!global::System.IO.File.Exists(this.originalPackagePath) || !this.originalPackagePath.Equals(fileInfo.FullName, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					this.Save(this.originalPackagePath);
				}
				else
				{
					this.CloseImpl();
				}
			}
			else if (this.output != null)
			{
				this.Save(this.output);
			}
			this.contentTypeManager.ClearAll();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000031D0 File Offset: 0x000013D0
		public void Revert()
		{
			this.RevertImpl();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000031D8 File Offset: 0x000013D8
		public void AddThumbnail(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				throw new global::System.ArgumentException("path");
			}
			string filename = path.Substring(path.LastIndexOf(global::System.IO.Path.DirectorySeparatorChar) + 1);
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			try
			{
				this.AddThumbnail(filename, fileStream);
			}
			finally
			{
				fileStream.Close();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003238 File Offset: 0x00001438
		public void AddThumbnail(string filename, global::System.IO.Stream data)
		{
			if (string.IsNullOrEmpty(filename))
			{
				throw new global::System.ArgumentException("filename");
			}
			string contentTypeFromFileExtension = global::NPOI.OpenXml4Net.OPC.ContentTypes.GetContentTypeFromFileExtension(filename);
			global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = null;
			try
			{
				packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName("/docProps/" + filename);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				string partName = "/docProps/thumbnail" + filename.Substring(filename.LastIndexOf(".") + 1);
				try
				{
					packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(partName);
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
				{
					throw new global::System.InvalidOperationException("Can't add a thumbnail file named '" + filename + "'");
				}
			}
			if (this.GetPart(packagePartName) != null)
			{
				throw new global::System.InvalidOperationException("You already add a thumbnail named '" + filename + "'");
			}
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.CreatePart(packagePartName, contentTypeFromFileExtension, false);
			this.AddRelationship(packagePartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail");
			global::NPOI.OpenXml4Net.OPC.StreamHelper.CopyStream(data, packagePart.GetOutputStream());
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003314 File Offset: 0x00001514
		internal void ThrowExceptionIfReadOnly()
		{
			if (this.packageAccess == global::NPOI.OpenXml4Net.OPC.PackageAccess.READ)
			{
				throw new global::System.InvalidOperationException("Operation not allowed, document open in read only mode!");
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003329 File Offset: 0x00001529
		internal void ThrowExceptionIfWriteOnly()
		{
			if (this.packageAccess == global::NPOI.OpenXml4Net.OPC.PackageAccess.WRITE)
			{
				throw new global::System.InvalidOperationException("Operation not allowed, document open in write only mode!");
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000333F File Offset: 0x0000153F
		public global::NPOI.OpenXml4Net.OPC.PackageProperties GetPackageProperties()
		{
			this.ThrowExceptionIfWriteOnly();
			if (this.packageProperties == null)
			{
				this.packageProperties = new global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart(this, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CORE_PROPERTIES_PART_NAME);
			}
			return this.packageProperties;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003366 File Offset: 0x00001566
		public bool PartExists(global::System.Uri uri)
		{
			return !uri.IsAbsoluteUri && this.GetPartImpl(new global::NPOI.OpenXml4Net.OPC.PackagePartName(uri.OriginalString, true)) != null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003388 File Offset: 0x00001588
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetPart(global::System.Uri uri)
		{
			this.ThrowExceptionIfWriteOnly();
			global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = new global::NPOI.OpenXml4Net.OPC.PackagePartName(uri.ToString(), true);
			if (packagePartName == null)
			{
				throw new global::System.ArgumentException("PartName");
			}
			if (this.partList == null)
			{
				try
				{
					this.GetParts();
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
				{
					return null;
				}
			}
			return this.GetPartImpl(packagePartName);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000033E8 File Offset: 0x000015E8
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetPart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			this.ThrowExceptionIfWriteOnly();
			if (partName == null)
			{
				throw new global::System.ArgumentException("PartName");
			}
			if (this.partList == null)
			{
				try
				{
					this.GetParts();
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
				{
					return null;
				}
			}
			return this.GetPartImpl(partName);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003438 File Offset: 0x00001638
		public global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetPartsByContentType(string contentType)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart in this.partList.Values)
			{
				if (packagePart.ContentType.Equals(contentType))
				{
					list.Add(packagePart);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000034A8 File Offset: 0x000016A8
		public global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetPartsByRelationshipType(string relationshipType)
		{
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship partRel in this.GetRelationshipsByType(relationshipType))
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart part = this.GetPart(partRel);
				if (part != null)
				{
					list.Add(part);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000351C File Offset: 0x0000171C
		public global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetPartsByName(global::System.Text.RegularExpressions.Regex namePattern)
		{
			if (namePattern == null)
			{
				throw new global::System.ArgumentException("name pattern must not be null");
			}
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>();
			foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart in this.partList.Values)
			{
				string name = packagePart.PartName.Name;
				if (namePattern.IsMatch(name))
				{
					list.Add(packagePart);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000035A0 File Offset: 0x000017A0
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetPart(global::NPOI.OpenXml4Net.OPC.PackageRelationship partRel)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart result = null;
			this.EnsureRelationships();
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in this.relationships)
			{
				if (packageRelationship.RelationshipType.Equals(partRel.RelationshipType))
				{
					try
					{
						result = this.GetPart(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(packageRelationship.TargetUri));
						break;
					}
					catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
					{
					}
				}
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003628 File Offset: 0x00001828
		public global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> GetParts()
		{
			this.ThrowExceptionIfWriteOnly();
			if (this.partList == null)
			{
				bool flag = false;
				bool flag2 = true;
				global::NPOI.OpenXml4Net.OPC.PackagePart[] partsImpl = this.GetPartsImpl();
				this.partList = new global::NPOI.OpenXml4Net.OPC.PackagePartCollection();
				global::NPOI.OpenXml4Net.OPC.PackagePart[] array = partsImpl;
				int i = 0;
				while (i < array.Length)
				{
					global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = array[i];
					bool flag3 = false;
					foreach (global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName in this.partList.Keys)
					{
						if (packagePart.PartName.Name.StartsWith(packagePartName.Name))
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						string str = "A part with the name '";
						global::NPOI.OpenXml4Net.OPC.PackagePartName partName = packagePart.PartName;
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(str + ((partName != null) ? partName.ToString() : null) + "' already exist : Packages shall not contain equivalent part names and package implementers shall neither create nor recognize packages with equivalent part names. [M1.12]");
					}
					if (packagePart.ContentType.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART))
					{
						if (!flag)
						{
							flag = true;
						}
						else
						{
							global::System.Console.WriteLine("OPC Compliance error [M4.1]: there is more than one core properties relationship in the package ! POI will use only the first, but other software may reject this file.");
						}
					}
					if (this.partUnmarshallers.ContainsKey(packagePart._contentType))
					{
						global::NPOI.OpenXml4Net.OPC.Internal.PartUnmarshaller partUnmarshaller = this.partUnmarshallers[packagePart._contentType];
						global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.UnmarshallContext context = new global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.UnmarshallContext(this, packagePart.PartName);
						try
						{
							global::NPOI.OpenXml4Net.OPC.PackagePart packagePart2 = partUnmarshaller.Unmarshall(context, packagePart.GetInputStream());
							this.partList[packagePart2.PartName] = packagePart2;
							if (packagePart2 is global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart && flag && flag2)
							{
								this.packageProperties = (global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart)packagePart2;
								flag2 = false;
							}
							goto IL_1B2;
						}
						catch (global::System.IO.IOException)
						{
							global::NPOI.Util.POILogger poilogger = global::NPOI.OpenXml4Net.OPC.OPCPackage.logger;
							int level = 5;
							string str2 = "Unmarshall operation : IOException for ";
							global::NPOI.OpenXml4Net.OPC.PackagePartName partName2 = packagePart.PartName;
							poilogger.Log(level, str2 + ((partName2 != null) ? partName2.ToString() : null));
							goto IL_1B2;
						}
						catch (global::System.InvalidOperationException ex)
						{
							throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message);
						}
						goto IL_190;
					}
					goto IL_190;
					IL_1B2:
					i++;
					continue;
					IL_190:
					try
					{
						this.partList[packagePart.PartName] = packagePart;
					}
					catch (global::System.InvalidOperationException ex2)
					{
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex2.Message);
					}
					goto IL_1B2;
				}
			}
			return new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart>(this.partList.Values);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003838 File Offset: 0x00001A38
		public global::NPOI.OpenXml4Net.OPC.PackagePart CreatePart(global::System.Uri partName, string contentType)
		{
			return this.CreatePart(new global::NPOI.OpenXml4Net.OPC.PackagePartName(partName.OriginalString, true), contentType, true);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000384E File Offset: 0x00001A4E
		public global::NPOI.OpenXml4Net.OPC.PackagePart CreatePart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType)
		{
			return this.CreatePart(partName, contentType, true);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000385C File Offset: 0x00001A5C
		public global::NPOI.OpenXml4Net.OPC.PackagePart CreatePart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType, bool loadRelationships)
		{
			this.ThrowExceptionIfReadOnly();
			if (partName == null)
			{
				throw new global::System.ArgumentException("PartName");
			}
			if (contentType == null || contentType == "")
			{
				throw new global::System.ArgumentException("contentType");
			}
			bool flag = false;
			bool flag2 = false;
			foreach (global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName in this.partList.Keys)
			{
				if (partName.Name.StartsWith(packagePartName.Name))
				{
					flag = true;
					if (this.partList[packagePartName].IsDeleted)
					{
						flag2 = true;
						break;
					}
					break;
				}
			}
			if (flag && !flag2)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.PartAlreadyExistsException("A part with the name '" + partName.Name + "' already exists : Packages shall not contain equivalent part names and package implementers shall neither create nor recognize packages with equivalent part names. [M1.12]");
			}
			if (contentType == global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART && this.packageProperties != null)
			{
				throw new global::System.InvalidOperationException("OPC Compliance error [M4.1]: you try to add more than one core properties relationship in the package !");
			}
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.CreatePartImpl(partName, contentType, loadRelationships);
			this.contentTypeManager.AddContentType(partName, contentType);
			this.partList[partName] = packagePart;
			this.isDirty = true;
			return packagePart;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003978 File Offset: 0x00001B78
		public global::NPOI.OpenXml4Net.OPC.PackagePart CreatePart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType, global::System.IO.MemoryStream content)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.CreatePart(partName, contentType);
			if (packagePart == null)
			{
				return null;
			}
			if (content != null)
			{
				try
				{
					global::System.IO.Stream outputStream = packagePart.GetOutputStream();
					if (outputStream == null)
					{
						return null;
					}
					outputStream.Write(content.ToArray(), 0, (int)content.Length);
					outputStream.Close();
					return packagePart;
				}
				catch (global::System.IO.IOException)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000039DC File Offset: 0x00001BDC
		protected global::NPOI.OpenXml4Net.OPC.PackagePart AddPackagePart(global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			this.ThrowExceptionIfReadOnly();
			if (part == null)
			{
				throw new global::System.ArgumentException("part");
			}
			if (this.partList.ContainsKey(part.PartName))
			{
				if (!this.partList[part.PartName].IsDeleted)
				{
					throw new global::System.InvalidOperationException("A part with the name '" + part.PartName.Name + "' already exists : Packages shall not contain equivalent part names and package implementers shall neither Create nor recognize packages with equivalent part names. [M1.12]");
				}
				part.IsDeleted = false;
				this.partList.Remove(part.PartName);
			}
			this.partList[part.PartName] = part;
			this.isDirty = true;
			return part;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003A7A File Offset: 0x00001C7A
		public void RemovePart(global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			if (part != null)
			{
				this.RemovePart(part.PartName);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003A8C File Offset: 0x00001C8C
		public void RemovePart(global::NPOI.OpenXml4Net.OPC.PackagePartName PartName)
		{
			this.ThrowExceptionIfReadOnly();
			if (PartName == null || !this.ContainPart(PartName))
			{
				throw new global::System.ArgumentException("PartName");
			}
			if (this.partList.ContainsKey(PartName))
			{
				this.partList[PartName].IsDeleted = true;
				this.RemovePartImpl(PartName);
				this.partList.Remove(PartName);
			}
			else
			{
				this.RemovePartImpl(PartName);
			}
			this.contentTypeManager.RemoveContentType(PartName);
			if (PartName.IsRelationshipPartURI())
			{
				global::System.Uri sourcePartUriFromRelationshipPartUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetSourcePartUriFromRelationshipPartUri(PartName.URI);
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName;
				try
				{
					packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(sourcePartUriFromRelationshipPartUri);
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
				{
					global::NPOI.Util.POILogger poilogger = global::NPOI.OpenXml4Net.OPC.OPCPackage.logger;
					int level = 7;
					string str = "Part name URI '";
					global::System.Uri uri = sourcePartUriFromRelationshipPartUri;
					poilogger.Log(level, str + ((uri != null) ? uri.ToString() : null) + "' is not valid ! This message is not intended to be displayed !");
					return;
				}
				if (packagePartName.URI.Equals(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI))
				{
					this.ClearRelationships();
				}
				else if (this.ContainPart(packagePartName))
				{
					global::NPOI.OpenXml4Net.OPC.PackagePart part = this.GetPart(packagePartName);
					if (part != null)
					{
						part.ClearRelationships();
					}
				}
			}
			this.isDirty = true;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003B90 File Offset: 0x00001D90
		public void RemovePartRecursive(global::NPOI.OpenXml4Net.OPC.PackagePartName PartName)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.partList[global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(PartName)];
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart2 = this.partList[PartName];
			if (packagePart != null)
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(packagePart2))
				{
					global::NPOI.OpenXml4Net.OPC.PackagePartName partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ResolvePartUri(packageRelationship.SourceUri, packageRelationship.TargetUri));
					this.RemovePart(partName);
				}
				this.RemovePart(packagePart.PartName);
			}
			this.RemovePart(packagePart2.PartName);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003C30 File Offset: 0x00001E30
		public void DeletePart(global::System.Uri uri)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = new global::NPOI.OpenXml4Net.OPC.PackagePartName(uri.ToString(), true);
			if (packagePartName == null)
			{
				throw new global::System.ArgumentException("PartName");
			}
			this.RemovePart(packagePartName);
			this.RemovePart(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(packagePartName));
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C6B File Offset: 0x00001E6B
		public void DeletePart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null)
			{
				throw new global::System.ArgumentException("PartName");
			}
			this.RemovePart(partName);
			this.RemovePart(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(partName));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003C90 File Offset: 0x00001E90
		public void DeletePartRecursive(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null || !this.ContainPart(partName))
			{
				throw new global::System.ArgumentException("PartName");
			}
			global::NPOI.OpenXml4Net.OPC.PackagePart part = this.GetPart(partName);
			this.RemovePart(partName);
			try
			{
				foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in part.Relationships)
				{
					global::NPOI.OpenXml4Net.OPC.PackagePartName partName2 = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ResolvePartUri(partName.URI, packageRelationship.TargetUri));
					this.DeletePartRecursive(partName2);
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage.logger.Log(5, "An exception occurs while deleting part '" + partName.Name + "'. Some parts may remain in the package. - " + ex.Message);
				return;
			}
			global::NPOI.OpenXml4Net.OPC.PackagePartName relationshipPartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(partName);
			if (relationshipPartName != null && this.ContainPart(relationshipPartName))
			{
				this.RemovePart(relationshipPartName);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003D70 File Offset: 0x00001F70
		public bool ContainPart(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			return this.GetPart(partName) != null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003D7C File Offset: 0x00001F7C
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string relID)
		{
			if (relationshipType.Equals("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties") && this.packageProperties != null)
			{
				throw new global::System.InvalidOperationException("OPC Compliance error [M4.1]: can't add another core properties part ! Use the built-in package method instead.");
			}
			if (targetPartName.IsRelationshipPartURI())
			{
				throw new global::System.InvalidOperationException("Rule M1.25: The Relationships part shall not have relationships to any other part.");
			}
			this.EnsureRelationships();
			global::NPOI.OpenXml4Net.OPC.PackageRelationship result = this.relationships.AddRelationship(targetPartName.URI, targetMode, relationshipType, relID);
			this.isDirty = true;
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003DDE File Offset: 0x00001FDE
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType)
		{
			return this.AddRelationship(targetPartName, targetMode, relationshipType, null);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003DEA File Offset: 0x00001FEA
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType)
		{
			return this.AddExternalRelationship(target, relationshipType, null);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType, string id)
		{
			if (target == null)
			{
				throw new global::System.ArgumentException("target");
			}
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			global::System.Uri targetUri;
			try
			{
				targetUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(target, global::System.UriKind.Absolute);
			}
			catch (global::System.UriFormatException ex)
			{
				string str = "Invalid target - ";
				global::System.UriFormatException ex2 = ex;
				throw new global::System.ArgumentException(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			this.EnsureRelationships();
			global::NPOI.OpenXml4Net.OPC.PackageRelationship result = this.relationships.AddRelationship(targetUri, global::NPOI.OpenXml4Net.OPC.TargetMode.External, relationshipType, id);
			this.isDirty = true;
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003E78 File Offset: 0x00002078
		public void RemoveRelationship(string id)
		{
			if (this.relationships != null)
			{
				this.relationships.RemoveRelationship(id);
				this.isDirty = true;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003E95 File Offset: 0x00002095
		public global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection Relationships
		{
			get
			{
				return this.GetRelationshipsHelper(null);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003E9E File Offset: 0x0000209E
		public global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationshipsByType(string relationshipType)
		{
			this.ThrowExceptionIfWriteOnly();
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			return this.GetRelationshipsHelper(relationshipType);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003EBB File Offset: 0x000020BB
		private global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationshipsHelper(string id)
		{
			this.ThrowExceptionIfWriteOnly();
			this.EnsureRelationships();
			return this.relationships.GetRelationships(id);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003ED5 File Offset: 0x000020D5
		public void ClearRelationships()
		{
			if (this.relationships != null)
			{
				this.relationships.Clear();
				this.isDirty = true;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003EF4 File Offset: 0x000020F4
		public void EnsureRelationships()
		{
			if (this.relationships == null)
			{
				try
				{
					this.relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(this);
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
				{
					this.relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection();
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003F38 File Offset: 0x00002138
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship GetRelationship(string id)
		{
			return this.relationships.GetRelationshipByID(id);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003F46 File Offset: 0x00002146
		public bool HasRelationships
		{
			get
			{
				return this.relationships.Size > 0;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003F58 File Offset: 0x00002158
		public bool IsRelationshipExists(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			using (global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship> enumerator = this.Relationships.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == rel)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003FA8 File Offset: 0x000021A8
		public void AddMarshaller(string contentType, global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller marshaller)
		{
			try
			{
				this.partMarshallers[new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType)] = marshaller;
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage.logger.Log(5, "The specified content type is not valid: '" + ex.Message + "'. The marshaller will not be Added !");
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003FFC File Offset: 0x000021FC
		public void AddUnmarshaller(string contentType, global::NPOI.OpenXml4Net.OPC.Internal.PartUnmarshaller unmarshaller)
		{
			try
			{
				this.partUnmarshallers[new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType)] = unmarshaller;
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage.logger.Log(5, "The specified content type is not valid: '" + ex.Message + "'. The unmarshaller will not be Added !");
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004050 File Offset: 0x00002250
		public void RemoveMarshaller(string contentType)
		{
			this.partMarshallers.Remove(new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004064 File Offset: 0x00002264
		public void RemoveUnmarshaller(string contentType)
		{
			this.partUnmarshallers.Remove(new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004078 File Offset: 0x00002278
		public global::NPOI.OpenXml4Net.OPC.PackageAccess GetPackageAccess()
		{
			return this.packageAccess;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004080 File Offset: 0x00002280
		public bool ValidatePackage(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			throw new global::System.InvalidOperationException("Not implemented yet !!!");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000408C File Offset: 0x0000228C
		public void Save(string path)
		{
			if (path == null)
			{
				throw new global::System.ArgumentException("targetFile");
			}
			this.ThrowExceptionIfReadOnly();
			global::System.IO.FileStream fileStream = null;
			try
			{
				fileStream = new global::System.IO.FileStream(path, global::System.IO.FileMode.OpenOrCreate);
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::System.IO.IOException(ex.Message, ex);
			}
			try
			{
				this.Save(fileStream);
			}
			finally
			{
				fileStream.Close();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000040F4 File Offset: 0x000022F4
		public void Save(global::System.IO.Stream outputStream)
		{
			this.ThrowExceptionIfReadOnly();
			this.SaveImpl(outputStream);
		}

		// Token: 0x06000084 RID: 132
		protected abstract global::NPOI.OpenXml4Net.OPC.PackagePart CreatePartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName PartName, string contentType, bool loadRelationships);

		// Token: 0x06000085 RID: 133
		protected abstract void RemovePartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName PartName);

		// Token: 0x06000086 RID: 134
		protected abstract void FlushImpl();

		// Token: 0x06000087 RID: 135
		protected abstract void CloseImpl();

		// Token: 0x06000088 RID: 136
		protected abstract void RevertImpl();

		// Token: 0x06000089 RID: 137
		protected abstract void SaveImpl(global::System.IO.Stream outputStream);

		// Token: 0x0600008A RID: 138
		protected abstract global::NPOI.OpenXml4Net.OPC.PackagePart GetPartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName PartName);

		// Token: 0x0600008B RID: 139
		protected abstract global::NPOI.OpenXml4Net.OPC.PackagePart[] GetPartsImpl();

		// Token: 0x0600008C RID: 140 RVA: 0x00004104 File Offset: 0x00002304
		public bool ReplaceContentType(string oldContentType, string newContentType)
		{
			bool result = false;
			foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart in this.GetPartsByContentType(oldContentType))
			{
				if (packagePart.ContentType.Equals(oldContentType))
				{
					global::NPOI.OpenXml4Net.OPC.PackagePartName partName = packagePart.PartName;
					this.contentTypeManager.AddContentType(partName, newContentType);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004178 File Offset: 0x00002378
		public void RegisterPartAndContentType(global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			this.AddPackagePart(part);
			this.contentTypeManager.AddContentType(part.PartName, part.ContentType);
			this.isDirty = true;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000041A0 File Offset: 0x000023A0
		public void UnregisterPartAndContentType(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			this.RemovePart(partName);
			this.contentTypeManager.RemoveContentType(partName);
			this.isDirty = true;
		}

		// Token: 0x0400002A RID: 42
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.OpenXml4Net.OPC.OPCPackage));

		// Token: 0x0400002B RID: 43
		protected static global::NPOI.OpenXml4Net.OPC.PackageAccess defaultPackageAccess = global::NPOI.OpenXml4Net.OPC.PackageAccess.READ_WRITE;

		// Token: 0x0400002C RID: 44
		private global::NPOI.OpenXml4Net.OPC.PackageAccess packageAccess;

		// Token: 0x0400002D RID: 45
		protected global::NPOI.OpenXml4Net.OPC.PackagePartCollection partList;

		// Token: 0x0400002E RID: 46
		protected global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationships;

		// Token: 0x0400002F RID: 47
		protected global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.Internal.ContentType, global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller> partMarshallers;

		// Token: 0x04000030 RID: 48
		protected global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller defaultPartMarshaller;

		// Token: 0x04000031 RID: 49
		protected global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.Internal.ContentType, global::NPOI.OpenXml4Net.OPC.Internal.PartUnmarshaller> partUnmarshallers;

		// Token: 0x04000032 RID: 50
		protected global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart packageProperties;

		// Token: 0x04000033 RID: 51
		protected global::NPOI.OpenXml4Net.OPC.Internal.ContentTypeManager contentTypeManager;

		// Token: 0x04000034 RID: 52
		protected bool isDirty;

		// Token: 0x04000035 RID: 53
		protected string originalPackagePath;

		// Token: 0x04000036 RID: 54
		protected global::System.IO.Stream output;
	}
}
