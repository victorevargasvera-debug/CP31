using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.Openxml4Net.Exceptions;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC.Internal;
using NPOI.OpenXml4Net.OPC.Internal.Marshallers;
using NPOI.OpenXml4Net.Util;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200001E RID: 30
	public class ZipPackage : global::NPOI.OpenXml4Net.OPC.OPCPackage
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000068B3 File Offset: 0x00004AB3
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000068BB File Offset: 0x00004ABB
		public bool IsExternalStream
		{
			get
			{
				return this.isStream;
			}
			set
			{
				this.isStream = value;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000068C4 File Offset: 0x00004AC4
		public ZipPackage() : base(global::NPOI.OpenXml4Net.OPC.OPCPackage.defaultPackageAccess)
		{
			this.zipArchive = null;
			try
			{
				this.contentTypeManager = new global::NPOI.OpenXml4Net.OPC.Internal.ZipContentTypeManager(null, this);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException exception)
			{
				global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(5, "Could not parse ZipPackage", exception);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006918 File Offset: 0x00004B18
		public ZipPackage(global::System.IO.Stream in1, global::NPOI.OpenXml4Net.OPC.PackageAccess access) : base(access)
		{
			this.isStream = true;
			global::ICSharpCode.SharpZipLib.Zip.ZipInputStream inp = global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.OpenZipStream(in1);
			this.zipArchive = new global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource(inp);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006946 File Offset: 0x00004B46
		public ZipPackage(string path, global::NPOI.OpenXml4Net.OPC.PackageAccess access) : this(new global::System.IO.FileInfo(path), access)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006958 File Offset: 0x00004B58
		public ZipPackage(global::System.IO.FileInfo file, global::NPOI.OpenXml4Net.OPC.PackageAccess access) : base(access)
		{
			global::NPOI.OpenXml4Net.Util.ZipEntrySource zipEntrySource;
			try
			{
				zipEntrySource = new global::NPOI.OpenXml4Net.Util.ZipFileZipEntrySource(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.OpenZipFile(file));
			}
			catch (global::System.IO.IOException innerException)
			{
				if (access == global::NPOI.OpenXml4Net.OPC.PackageAccess.WRITE)
				{
					throw new global::System.InvalidOperationException("Can't open the specified file: '" + ((file != null) ? file.ToString() : null) + "'", innerException);
				}
				global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(7, "Error in zip file " + ((file != null) ? file.ToString() : null) + " - falling back to stream processing (i.e. ignoring zip central directory)");
				global::System.IO.FileStream fileStream = null;
				global::ICSharpCode.SharpZipLib.Zip.ZipInputStream zipInputStream = null;
				try
				{
					fileStream = file.Create();
					zipInputStream = global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.OpenZipStream(fileStream);
					zipEntrySource = new global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource(zipInputStream);
				}
				catch (global::System.IO.IOException innerException2)
				{
					if (zipInputStream != null)
					{
						try
						{
							zipInputStream.Close();
							goto IL_E5;
						}
						catch (global::System.IO.IOException)
						{
							throw new global::System.InvalidOperationException("Can't open the specified file: '" + ((file != null) ? file.ToString() : null) + "' and couldn't close the file input stream", innerException);
						}
					}
					if (fileStream != null)
					{
						try
						{
							fileStream.Close();
						}
						catch (global::System.IO.IOException)
						{
							throw new global::System.InvalidOperationException("Can't open the specified file: '" + ((file != null) ? file.ToString() : null) + "' and couldn't close the file input stream", innerException);
						}
					}
					IL_E5:
					throw new global::System.InvalidOperationException("Can't open the specified file: '" + ((file != null) ? file.ToString() : null) + "'", innerException2);
				}
			}
			this.zipArchive = zipEntrySource;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006AAC File Offset: 0x00004CAC
		public ZipPackage(global::NPOI.OpenXml4Net.Util.ZipEntrySource zipEntry, global::NPOI.OpenXml4Net.OPC.PackageAccess access) : base(access)
		{
			this.zipArchive = zipEntry;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006ABC File Offset: 0x00004CBC
		protected override global::NPOI.OpenXml4Net.OPC.PackagePart[] GetPartsImpl()
		{
			if (this.partList == null)
			{
				this.partList = new global::NPOI.OpenXml4Net.OPC.PackagePartCollection();
			}
			if (this.zipArchive == null)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart[] array = new global::NPOI.OpenXml4Net.OPC.PackagePart[this.partList.Values.Count];
				this.partList.Values.CopyTo(array, 0);
				return array;
			}
			global::System.Collections.IEnumerator entries = this.zipArchive.Entries;
			while (entries.MoveNext())
			{
				object obj = entries.Current;
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj;
				if (zipEntry.Name.ToLower().Equals("[Content_Types].xml".ToLower()))
				{
					try
					{
						this.contentTypeManager = new global::NPOI.OpenXml4Net.OPC.Internal.ZipContentTypeManager(this.ZipArchive.GetInputStream(zipEntry), this);
						break;
					}
					catch (global::System.IO.IOException ex)
					{
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message, ex);
					}
				}
			}
			if (this.contentTypeManager != null)
			{
				entries = this.zipArchive.Entries;
				while (entries.MoveNext())
				{
					object obj2 = entries.Current;
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry2 = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj2;
					global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = this.BuildPartName(zipEntry2);
					if (packagePartName != null)
					{
						string contentType = this.contentTypeManager.GetContentType(packagePartName);
						if (contentType != null && contentType.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.RELATIONSHIPS_PART))
						{
							try
							{
								global::NPOI.OpenXml4Net.OPC.PackagePart value = new global::NPOI.OpenXml4Net.OPC.ZipPackagePart(this, zipEntry2, packagePartName, contentType);
								this.partList[packagePartName] = value;
							}
							catch (global::System.InvalidOperationException ex2)
							{
								throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex2.Message, ex2);
							}
						}
					}
				}
				entries = this.zipArchive.Entries;
				while (entries.MoveNext())
				{
					object obj3 = entries.Current;
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry3 = obj3 as global::ICSharpCode.SharpZipLib.Zip.ZipEntry;
					global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName2 = this.BuildPartName(zipEntry3);
					if (packagePartName2 != null)
					{
						string contentType2 = this.contentTypeManager.GetContentType(packagePartName2);
						if (contentType2 == null || !contentType2.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.RELATIONSHIPS_PART))
						{
							if (contentType2 != null)
							{
								try
								{
									global::NPOI.OpenXml4Net.OPC.PackagePart value2 = new global::NPOI.OpenXml4Net.OPC.ZipPackagePart(this, zipEntry3, packagePartName2, contentType2);
									this.partList[packagePartName2] = value2;
									continue;
								}
								catch (global::System.InvalidOperationException ex3)
								{
									throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex3.Message, ex3);
								}
							}
							throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("The part " + packagePartName2.URI.OriginalString + " does not have any content type ! Rule: Package require content types when retrieving a part from a package. [M.1.14]");
						}
					}
				}
				global::NPOI.OpenXml4Net.OPC.ZipPackagePart[] array2 = new global::NPOI.OpenXml4Net.OPC.ZipPackagePart[this.partList.Count];
				global::System.Collections.Generic.ICollection<global::NPOI.OpenXml4Net.OPC.PackagePart> values = this.partList.Values;
				global::NPOI.OpenXml4Net.OPC.PackagePart[] array3 = array2;
				values.CopyTo(array3, 0);
				return array2;
			}
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			entries = this.zipArchive.Entries;
			while (entries.MoveNext())
			{
				object obj4 = entries.Current;
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry4 = obj4 as global::ICSharpCode.SharpZipLib.Zip.ZipEntry;
				if (zipEntry4.Name.Equals(global::NPOI.OpenXml4Net.OPC.ZipPackage.MIMETYPE))
				{
					flag = true;
				}
				if (zipEntry4.Name.Equals(global::NPOI.OpenXml4Net.OPC.ZipPackage.SETTINGS_XML))
				{
					flag2 = true;
				}
				num++;
			}
			if (flag && flag2)
			{
				throw new global::NPOI.Openxml4Net.Exceptions.ODFNotOfficeXmlFileException("The supplied data appears to be in ODF (Open Document) Format. Formats like these (eg ODS, ODP) are not supported, try Apache ODFToolkit");
			}
			if (num == 0)
			{
				throw new global::NPOI.Openxml4Net.Exceptions.NotOfficeXmlFileException("No valid entries or contents found, this is not a valid OOXML (Office Open XML) file");
			}
			throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Package should contain a content type part [M1.13]");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006D8C File Offset: 0x00004F8C
		private global::NPOI.OpenXml4Net.OPC.PackagePartName BuildPartName(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePartName result;
			try
			{
				if (entry.Name.ToLower().Equals("[Content_Types].xml".ToLower()))
				{
					result = null;
				}
				else
				{
					result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetOPCNameFromZipItemName(entry.Name));
				}
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006DE4 File Offset: 0x00004FE4
		protected override global::NPOI.OpenXml4Net.OPC.PackagePart CreatePartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType, bool loadRelationships)
		{
			if (contentType == null)
			{
				throw new global::System.ArgumentException("contentType");
			}
			if (partName == null)
			{
				throw new global::System.ArgumentException("partName");
			}
			global::NPOI.OpenXml4Net.OPC.PackagePart result;
			try
			{
				result = new global::NPOI.OpenXml4Net.OPC.Internal.MemoryPackagePart(this, partName, contentType, loadRelationships);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006E30 File Offset: 0x00005030
		protected override void RemovePartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null)
			{
				throw new global::System.ArgumentException("partUri");
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000478E File Offset: 0x0000298E
		protected override void FlushImpl()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006E40 File Offset: 0x00005040
		protected override void CloseImpl()
		{
			base.Flush();
			if (this.originalPackagePath != null && !"".Equals(this.originalPackagePath))
			{
				if (global::System.IO.File.Exists(this.originalPackagePath))
				{
					string text = this.GenerateTempFileName(global::NPOI.OpenXml4Net.OPC.Internal.FileHelper.GetDirectory(this.originalPackagePath));
					global::System.IO.FileInfo fileInfo = global::NPOI.Util.TempFile.CreateTempFile(text, ".tmp");
					try
					{
						base.Save(fileInfo.FullName);
						return;
					}
					finally
					{
						try
						{
							if (this.zipArchive != null)
							{
								this.zipArchive.Close();
							}
							global::NPOI.OpenXml4Net.OPC.Internal.FileHelper.CopyFile(fileInfo.FullName, this.originalPackagePath);
						}
						finally
						{
							global::System.IO.File.Delete(fileInfo.FullName);
							global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(5, "The temporary file: '" + text + "' cannot be deleted ! Make sure that no other application use it.");
						}
					}
				}
				throw new global::System.InvalidOperationException("Can't close a package not previously open with the open() method !");
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006F24 File Offset: 0x00005124
		private string GenerateTempFileName(string directory)
		{
			string text;
			global::System.IO.FileInfo fileInfo;
			do
			{
				text = directory + "\\OpenXml4Net" + global::System.DateTime.Now.Ticks.ToString();
				fileInfo = new global::System.IO.FileInfo(text);
			}
			while (global::System.IO.File.Exists(text));
			return fileInfo.Name;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006F6C File Offset: 0x0000516C
		protected override void RevertImpl()
		{
			try
			{
				if (this.zipArchive != null)
				{
					this.zipArchive.Close();
				}
			}
			catch (global::System.IO.IOException)
			{
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006FA4 File Offset: 0x000051A4
		protected override global::NPOI.OpenXml4Net.OPC.PackagePart GetPartImpl(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (this.partList.ContainsKey(partName))
			{
				return this.partList[partName];
			}
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006FC4 File Offset: 0x000051C4
		protected override void SaveImpl(global::System.IO.Stream outputStream)
		{
			base.ThrowExceptionIfReadOnly();
			global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream = null;
			try
			{
				if (!(outputStream is global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream))
				{
					zipOutputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(outputStream);
				}
				else
				{
					zipOutputStream = (global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream)outputStream;
				}
				zipOutputStream.UseZip64 = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Off;
				if (base.GetPartsByRelationshipType("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties").Count == 0 && base.GetPartsByRelationshipType("http://schemas.openxmlformats.org/officedocument/2006/relationships/metadata/core-properties").Count == 0)
				{
					global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(1, "Save core properties part");
					base.GetPackageProperties();
					base.AddPackagePart(this.packageProperties);
					this.relationships.AddRelationship(this.packageProperties.PartName.URI, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", null);
					if (!this.contentTypeManager.IsContentTypeRegister(global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART))
					{
						this.contentTypeManager.AddContentType(this.packageProperties.PartName, global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART);
					}
				}
				global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(1, "Save package relationships");
				global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller.MarshallRelationshipPart(base.Relationships, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_PART_NAME, zipOutputStream);
				global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(1, "Save content types part");
				this.contentTypeManager.Save(zipOutputStream);
				foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart in base.GetParts())
				{
					if (!packagePart.IsRelationshipPart)
					{
						global::NPOI.OpenXml4Net.OPC.ZipPackage.logger.Log(1, "Save part '" + global::NPOI.OpenXml4Net.OPC.Internal.ZipHelper.GetZipItemNameFromOPCName(packagePart.PartName.Name) + "'");
						if (this.partMarshallers.ContainsKey(packagePart._contentType))
						{
							global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller partMarshaller = this.partMarshallers[packagePart._contentType];
							if (!partMarshaller.Marshall(packagePart, zipOutputStream))
							{
								string str = "The part ";
								global::System.Uri uri = packagePart.PartName.URI;
								string str2 = (uri != null) ? uri.ToString() : null;
								string str3 = " fail to be saved in the stream with marshaller ";
								global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller partMarshaller2 = partMarshaller;
								throw new global::NPOI.OpenXml4Net.OpenXml4NetException(str + str2 + str3 + ((partMarshaller2 != null) ? partMarshaller2.ToString() : null));
							}
						}
						else if (!this.defaultPartMarshaller.Marshall(packagePart, zipOutputStream))
						{
							string str4 = "The part ";
							global::System.Uri uri2 = packagePart.PartName.URI;
							string str5 = (uri2 != null) ? uri2.ToString() : null;
							string str6 = " fail to be saved in the stream with marshaller ";
							global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller defaultPartMarshaller = this.defaultPartMarshaller;
							throw new global::NPOI.OpenXml4Net.OpenXml4NetException(str4 + str5 + str6 + ((defaultPartMarshaller != null) ? defaultPartMarshaller.ToString() : null));
						}
					}
				}
				if (this.isStream)
				{
					zipOutputStream.Finish();
				}
				else
				{
					zipOutputStream.Close();
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.OpenXML4NetRuntimeException ex)
			{
				throw ex;
			}
			catch (global::System.IO.IOException ex2)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.OpenXML4NetRuntimeException("Fail to save: an error occurs while saving the package : " + ex2.Message, ex2);
			}
			catch (global::System.Exception ex3)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.OpenXML4NetRuntimeException("Fail to save: an error occurs while saving the package : " + ex3.Message, ex3);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000072A8 File Offset: 0x000054A8
		public global::NPOI.OpenXml4Net.Util.ZipEntrySource ZipArchive
		{
			get
			{
				return this.zipArchive;
			}
		}

		// Token: 0x04000090 RID: 144
		private static string MIMETYPE = "mimetype";

		// Token: 0x04000091 RID: 145
		private static string SETTINGS_XML = "settings.xml";

		// Token: 0x04000092 RID: 146
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.OpenXml4Net.OPC.ZipPackage));

		// Token: 0x04000093 RID: 147
		private global::NPOI.OpenXml4Net.Util.ZipEntrySource zipArchive;

		// Token: 0x04000094 RID: 148
		private bool isStream;
	}
}
