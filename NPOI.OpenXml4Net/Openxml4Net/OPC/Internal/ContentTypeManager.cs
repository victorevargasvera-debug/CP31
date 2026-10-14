using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000021 RID: 33
	public abstract class ContentTypeManager
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0000775C File Offset: 0x0000595C
		public ContentTypeManager(global::System.IO.Stream in1, global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			this.container = pkg;
			this.defaultContentType = new global::System.Collections.Generic.SortedList<string, string>();
			if (in1 != null)
			{
				try
				{
					this.ParseContentTypesFile(in1);
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException innerException)
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Can't read content types part !", innerException);
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000077AC File Offset: 0x000059AC
		public void AddContentType(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType)
		{
			bool flag = false;
			string text = partName.Extension.ToLower();
			if (text.Length == 0 || (this.defaultContentType.ContainsKey(text) && !(flag = this.defaultContentType.ContainsValue(contentType))))
			{
				this.AddOverrideContentType(partName, contentType);
				return;
			}
			if (!flag)
			{
				this.AddDefaultContentType(text, contentType);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007801 File Offset: 0x00005A01
		private void AddOverrideContentType(global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType)
		{
			if (this.overrideContentType == null)
			{
				this.overrideContentType = new global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.PackagePartName, string>();
			}
			if (!this.overrideContentType.ContainsKey(partName))
			{
				this.overrideContentType.Add(partName, contentType);
				return;
			}
			this.overrideContentType[partName] = contentType;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000783F File Offset: 0x00005A3F
		private void AddDefaultContentType(string extension, string contentType)
		{
			this.defaultContentType.Add(extension.ToLower(), contentType);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007854 File Offset: 0x00005A54
		public void RemoveContentType(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null)
			{
				throw new global::System.ArgumentException("partName");
			}
			if (this.overrideContentType != null && this.overrideContentType.ContainsKey(partName))
			{
				this.overrideContentType.Remove(partName);
				return;
			}
			string extension = partName.Extension;
			bool flag = true;
			if (this.container != null)
			{
				try
				{
					foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart in this.container.GetParts())
					{
						if (!packagePart.PartName.Equals(partName) && packagePart.PartName.Extension.Equals(extension, global::System.StringComparison.InvariantCultureIgnoreCase))
						{
							flag = false;
							break;
						}
					}
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
				{
					throw new global::System.InvalidOperationException(ex.Message);
				}
			}
			if (flag)
			{
				this.defaultContentType.Remove(extension);
			}
			if (this.container != null)
			{
				try
				{
					foreach (global::NPOI.OpenXml4Net.OPC.PackagePart packagePart2 in this.container.GetParts())
					{
						if (!packagePart2.PartName.Equals(partName) && this.GetContentType(packagePart2.PartName) == null)
						{
							throw new global::System.InvalidOperationException("Rule M2.4 is not respected: Nor a default element or override element is associated with the part: " + packagePart2.PartName.Name);
						}
					}
				}
				catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex2)
				{
					throw new global::System.InvalidOperationException(ex2.Message);
				}
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000079D4 File Offset: 0x00005BD4
		public bool IsContentTypeRegister(string contentType)
		{
			if (contentType == null)
			{
				throw new global::System.ArgumentException("contentType");
			}
			return this.defaultContentType.Values.Contains(contentType) || (this.overrideContentType != null && this.overrideContentType.Values.Contains(contentType));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007A14 File Offset: 0x00005C14
		public string GetContentType(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null)
			{
				throw new global::System.ArgumentException("partName");
			}
			if (this.overrideContentType != null && this.overrideContentType.ContainsKey(partName))
			{
				return this.overrideContentType[partName];
			}
			string key = partName.Extension.ToLower();
			if (this.defaultContentType.ContainsKey(key))
			{
				return this.defaultContentType[key];
			}
			if (this.container != null && this.container.GetPart(partName) != null)
			{
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException("Rule M2.4 exception : this error should NEVER happen! If you can provide the triggering file, then please raise a bug at https://bz.apache.org/bugzilla/enter_bug.cgi?product=POI and attach a file that triggers it, thanks!");
			}
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007A9B File Offset: 0x00005C9B
		public void ClearAll()
		{
			this.defaultContentType.Clear();
			if (this.overrideContentType != null)
			{
				this.overrideContentType.Clear();
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00007ABB File Offset: 0x00005CBB
		public void ClearOverrideContentTypes()
		{
			if (this.overrideContentType != null)
			{
				this.overrideContentType.Clear();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00007AD0 File Offset: 0x00005CD0
		private void ParseContentTypesFile(global::System.IO.Stream in1)
		{
			try
			{
				global::System.Xml.XPath.XPathNavigator xpathNavigator = global::NPOI.Util.DocumentHelper.ReadDocument(in1).CreateNavigator();
				global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(xpathNavigator.NameTable);
				xmlNamespaceManager.AddNamespace("x", "http://schemas.openxmlformats.org/package/2006/content-types");
				global::System.Xml.XPath.XPathNodeIterator xpathNodeIterator = xpathNavigator.Select("//x:Default", xmlNamespaceManager);
				while (xpathNodeIterator.MoveNext())
				{
					global::System.Xml.XPath.XPathNavigator xpathNavigator2 = xpathNodeIterator.Current;
					string attribute = xpathNavigator2.GetAttribute("Extension", xpathNavigator.NamespaceURI);
					string attribute2 = xpathNodeIterator.Current.GetAttribute("ContentType", xpathNavigator.NamespaceURI);
					this.AddDefaultContentType(attribute, attribute2);
				}
				xpathNodeIterator = xpathNavigator.Select("//x:Override", xmlNamespaceManager);
				while (xpathNodeIterator.MoveNext())
				{
					global::System.Xml.XPath.XPathNavigator xpathNavigator3 = xpathNodeIterator.Current;
					global::NPOI.OpenXml4Net.OPC.PackagePartName partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(xpathNavigator3.GetAttribute("PartName", xpathNavigator.NamespaceURI), global::System.UriKind.RelativeOrAbsolute));
					string attribute3 = xpathNodeIterator.Current.GetAttribute("ContentType", xpathNavigator.NamespaceURI);
					this.AddOverrideContentType(partName, attribute3);
				}
			}
			catch (global::System.UriFormatException ex)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public bool Save(global::System.IO.Stream outStream)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			new global::System.Xml.XmlNamespaceManager(xmlDocument.NameTable).AddNamespace("x", "http://schemas.openxmlformats.org/package/2006/content-types");
			global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement("Types", "http://schemas.openxmlformats.org/package/2006/content-types");
			xmlDocument.AppendChild(xmlElement);
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> entry in this.defaultContentType)
			{
				this.AppendDefaultType(xmlDocument, xmlElement, entry);
			}
			if (this.overrideContentType != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.OpenXml4Net.OPC.PackagePartName, string> entry2 in this.overrideContentType)
				{
					this.AppendSpecificTypes(xmlDocument, xmlElement, entry2);
				}
			}
			xmlDocument.Normalize();
			return this.SaveImpl(xmlDocument, outStream);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007C74 File Offset: 0x00005E74
		private void AppendSpecificTypes(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlElement root, global::System.Collections.Generic.KeyValuePair<global::NPOI.OpenXml4Net.OPC.PackagePartName, string> entry)
		{
			global::System.Xml.XmlElement xmlElement = xmldoc.CreateElement("Override", "http://schemas.openxmlformats.org/package/2006/content-types");
			root.AppendChild(xmlElement);
			xmlElement.SetAttribute("PartName", entry.Key.Name);
			xmlElement.SetAttribute("ContentType", entry.Value);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007CC4 File Offset: 0x00005EC4
		private void AppendDefaultType(global::System.Xml.XmlDocument xmldoc, global::System.Xml.XmlElement root, global::System.Collections.Generic.KeyValuePair<string, string> entry)
		{
			global::System.Xml.XmlElement xmlElement = xmldoc.CreateElement("Default", "http://schemas.openxmlformats.org/package/2006/content-types");
			root.AppendChild(xmlElement);
			xmlElement.SetAttribute("Extension", entry.Key);
			xmlElement.SetAttribute("ContentType", entry.Value);
		}

		// Token: 0x0600017D RID: 381
		public abstract bool SaveImpl(global::System.Xml.XmlDocument content, global::System.IO.Stream out1);

		// Token: 0x0400009D RID: 157
		public const string CONTENT_TYPES_PART_NAME = "[Content_Types].xml";

		// Token: 0x0400009E RID: 158
		public const string TYPES_NAMESPACE_URI = "http://schemas.openxmlformats.org/package/2006/content-types";

		// Token: 0x0400009F RID: 159
		private const string TYPES_TAG_NAME = "Types";

		// Token: 0x040000A0 RID: 160
		private const string DEFAULT_TAG_NAME = "Default";

		// Token: 0x040000A1 RID: 161
		private const string EXTENSION_ATTRIBUTE_NAME = "Extension";

		// Token: 0x040000A2 RID: 162
		private const string CONTENT_TYPE_ATTRIBUTE_NAME = "ContentType";

		// Token: 0x040000A3 RID: 163
		private const string OVERRIDE_TAG_NAME = "Override";

		// Token: 0x040000A4 RID: 164
		private const string PART_NAME_ATTRIBUTE_NAME = "PartName";

		// Token: 0x040000A5 RID: 165
		protected global::NPOI.OpenXml4Net.OPC.OPCPackage container;

		// Token: 0x040000A6 RID: 166
		private global::System.Collections.Generic.SortedList<string, string> defaultContentType;

		// Token: 0x040000A7 RID: 167
		private global::System.Collections.Generic.SortedList<global::NPOI.OpenXml4Net.OPC.PackagePartName, string> overrideContentType;
	}
}
