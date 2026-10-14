using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.Util;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000018 RID: 24
	public class PackageRelationshipCollection : global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x06000105 RID: 261 RVA: 0x000053D9 File Offset: 0x000035D9
		public PackageRelationshipCollection()
		{
			this.relationshipsByID = new global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship>();
			this.relationshipsByType = new global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship>(new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection.DuplicateComparer());
			this.internalRelationshipsByTargetName = new global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship>();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005410 File Offset: 0x00003610
		public PackageRelationshipCollection(global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection coll, string filter) : this()
		{
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in coll.relationshipsByID.Values)
			{
				if (filter == null || packageRelationship.RelationshipType.Equals(filter))
				{
					this.AddRelationship(packageRelationship);
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000547C File Offset: 0x0000367C
		public PackageRelationshipCollection(global::NPOI.OpenXml4Net.OPC.OPCPackage container) : this(container, null)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005486 File Offset: 0x00003686
		public PackageRelationshipCollection(global::NPOI.OpenXml4Net.OPC.PackagePart part) : this(part._container, part)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005498 File Offset: 0x00003698
		public PackageRelationshipCollection(global::NPOI.OpenXml4Net.OPC.OPCPackage container, global::NPOI.OpenXml4Net.OPC.PackagePart part) : this()
		{
			if (container == null)
			{
				throw new global::System.ArgumentException("container");
			}
			if (part != null && part.IsRelationshipPart)
			{
				throw new global::System.ArgumentException("part");
			}
			this.container = container;
			this.sourcePart = part;
			this.partName = global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection.GetRelationshipPartName(part);
			if (container.GetPackageAccess() != global::NPOI.OpenXml4Net.OPC.PackageAccess.WRITE && container.ContainPart(this.partName))
			{
				this.relationshipPart = container.GetPart(this.partName);
				this.ParseRelationshipsPart(this.relationshipPart);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005520 File Offset: 0x00003720
		private static global::NPOI.OpenXml4Net.OPC.PackagePartName GetRelationshipPartName(global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePartName package_ROOT_PART_NAME;
			if (part == null)
			{
				package_ROOT_PART_NAME = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_PART_NAME;
			}
			else
			{
				package_ROOT_PART_NAME = part.PartName;
			}
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetRelationshipPartName(package_ROOT_PART_NAME);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005548 File Offset: 0x00003748
		public void AddRelationship(global::NPOI.OpenXml4Net.OPC.PackageRelationship relPart)
		{
			if (relPart == null || string.IsNullOrEmpty(relPart.Id))
			{
				throw new global::System.ArgumentException("invalid relationship part/id");
			}
			this.relationshipsByID[relPart.Id] = relPart;
			this.relationshipsByType[relPart.RelationshipType] = relPart;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005594 File Offset: 0x00003794
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::System.Uri targetUri, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string id)
		{
			if (id == null)
			{
				if (this.nextRelationshipId == -1)
				{
					this.nextRelationshipId = this.Size + 1;
				}
				do
				{
					string str = "rId";
					int num = this.nextRelationshipId;
					this.nextRelationshipId = num + 1;
					id = str + num.ToString();
				}
				while (this.relationshipsByID.ContainsKey(id));
			}
			global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = new global::NPOI.OpenXml4Net.OPC.PackageRelationship(this.container, this.sourcePart, targetUri, targetMode, relationshipType, id);
			this.relationshipsByID[packageRelationship.Id] = packageRelationship;
			this.relationshipsByType[packageRelationship.RelationshipType] = packageRelationship;
			if (targetMode == global::NPOI.OpenXml4Net.OPC.TargetMode.Internal)
			{
				this.internalRelationshipsByTargetName.Add(targetUri.OriginalString, packageRelationship);
			}
			return packageRelationship;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005640 File Offset: 0x00003840
		public void RemoveRelationship(string id)
		{
			if (this.relationshipsByID != null && this.relationshipsByType != null)
			{
				global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = this.relationshipsByID[id];
				if (packageRelationship != null)
				{
					this.relationshipsByID.Remove(packageRelationship.Id);
					for (int i = 0; i < this.relationshipsByType.Count; i++)
					{
						if (this.relationshipsByType.Values[i] == packageRelationship)
						{
							this.relationshipsByType.RemoveAt(i);
						}
					}
					this.internalRelationshipsByTargetName.RemoveAt(this.internalRelationshipsByTargetName.IndexOfValue(packageRelationship));
				}
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000056CC File Offset: 0x000038CC
		public void RemoveRelationship(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			if (rel == null)
			{
				throw new global::System.ArgumentException("rel");
			}
			this.relationshipsByID.Values.Remove(rel);
			this.relationshipsByType.Values.Remove(rel);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005700 File Offset: 0x00003900
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship GetRelationship(int index)
		{
			if (index < 0 || index > this.relationshipsByID.Values.Count)
			{
				throw new global::System.ArgumentException("index");
			}
			int num = 0;
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship result in this.relationshipsByID.Values)
			{
				if (index == num++)
				{
					return result;
				}
			}
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005780 File Offset: 0x00003980
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship GetRelationshipByID(string id)
		{
			if (!this.relationshipsByID.ContainsKey(id))
			{
				return null;
			}
			return this.relationshipsByID[id];
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000579E File Offset: 0x0000399E
		public int Size
		{
			get
			{
				return this.relationshipsByID.Values.Count;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000057B0 File Offset: 0x000039B0
		private void ParseRelationshipsPart(global::NPOI.OpenXml4Net.OPC.PackagePart relPart)
		{
			try
			{
				global::NPOI.Util.POILogger poilogger = global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection.logger;
				int level = 1;
				string str = "Parsing relationship: ";
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = relPart.PartName;
				poilogger.Log(level, str + ((packagePartName != null) ? packagePartName.ToString() : null));
				global::System.Xml.XPath.XPathDocument xpathDocument = global::NPOI.Util.DocumentHelper.ReadDocument(relPart.GetInputStream());
				bool flag = false;
				global::System.Xml.XPath.XPathNavigator xpathNavigator = xpathDocument.CreateNavigator();
				global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(xpathNavigator.NameTable);
				xmlNamespaceManager.AddNamespace("x", "http://schemas.openxmlformats.org/package/2006/relationships");
				global::System.Xml.XPath.XPathNodeIterator xpathNodeIterator = xpathNavigator.Select("//x:" + global::NPOI.OpenXml4Net.OPC.PackageRelationship.RELATIONSHIP_TAG_NAME, xmlNamespaceManager);
				while (xpathNodeIterator.MoveNext())
				{
					global::System.Xml.XPath.XPathNavigator xpathNavigator2 = xpathNodeIterator.Current;
					string attribute = xpathNavigator2.GetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.ID_ATTRIBUTE_NAME, xpathNavigator.NamespaceURI);
					string attribute2 = xpathNodeIterator.Current.GetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TYPE_ATTRIBUTE_NAME, xpathNavigator.NamespaceURI);
					if (attribute2.Equals("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties"))
					{
						if (flag)
						{
							throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("OPC Compliance error [M4.1]: there is more than one core properties relationship in the package !");
						}
						flag = true;
					}
					string attribute3 = xpathNodeIterator.Current.GetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TARGET_MODE_ATTRIBUTE_NAME, xpathNavigator.NamespaceURI);
					global::NPOI.OpenXml4Net.OPC.TargetMode targetMode = global::NPOI.OpenXml4Net.OPC.TargetMode.Internal;
					if (attribute3 != string.Empty)
					{
						targetMode = (attribute3.ToLower().Equals("internal") ? global::NPOI.OpenXml4Net.OPC.TargetMode.Internal : global::NPOI.OpenXml4Net.OPC.TargetMode.External);
					}
					global::System.Uri targetUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ToUri("http://invalid.uri");
					string attribute4 = xpathNodeIterator.Current.GetAttribute(global::NPOI.OpenXml4Net.OPC.PackageRelationship.TARGET_ATTRIBUTE_NAME, xpathNavigator.NamespaceURI);
					try
					{
						targetUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ToUri(attribute4);
					}
					catch (global::System.UriFormatException exception)
					{
						global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection.logger.Log(7, "Cannot convert " + attribute4 + " in a valid relationship URI-> dummy-URI used", exception);
					}
					this.AddRelationship(targetUri, targetMode, attribute2, attribute);
				}
			}
			catch (global::System.Exception ex)
			{
				global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection.logger.Log(7, ex);
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005980 File Offset: 0x00003B80
		public global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationships(string typeFilter)
		{
			return new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(this, typeFilter);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005989 File Offset: 0x00003B89
		public global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship> GetEnumerator()
		{
			return this.relationshipsByID.Values.GetEnumerator();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000599C File Offset: 0x00003B9C
		public global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship> Iterator(string typeFilter)
		{
			global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackageRelationship> list = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackageRelationship>();
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in this.relationshipsByID.Values)
			{
				if (packageRelationship.RelationshipType.Equals(typeFilter))
				{
					list.Add(packageRelationship);
				}
			}
			return list.GetEnumerator();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005A10 File Offset: 0x00003C10
		public void Clear()
		{
			this.relationshipsByID.Clear();
			this.relationshipsByType.Clear();
			this.internalRelationshipsByTargetName.Clear();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005A34 File Offset: 0x00003C34
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship FindExistingInternalRelation(global::NPOI.OpenXml4Net.OPC.PackagePart packagePart)
		{
			string name = packagePart.PartName.Name;
			if (!this.internalRelationshipsByTargetName.ContainsKey(name))
			{
				return null;
			}
			return this.internalRelationshipsByTargetName[name];
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005A6C File Offset: 0x00003C6C
		public override string ToString()
		{
			string text;
			if (this.relationshipsByID == null)
			{
				text = "relationshipsByID=null";
			}
			else
			{
				text = this.relationshipsByID.Count.ToString() + " relationship(s) = [";
			}
			if (this.relationshipPart != null && this.relationshipPart.PartName != null)
			{
				string str = text;
				string str2 = ",";
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = this.relationshipPart.PartName;
				text = str + str2 + ((packagePartName != null) ? packagePartName.ToString() : null);
			}
			else
			{
				text += ",relationshipPart=null";
			}
			if (this.sourcePart != null && this.sourcePart.PartName != null)
			{
				string str3 = text;
				string str4 = ",";
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName2 = this.sourcePart.PartName;
				text = str3 + str4 + ((packagePartName2 != null) ? packagePartName2.ToString() : null);
			}
			else
			{
				text += ",sourcePart=null";
			}
			if (this.partName != null)
			{
				string str5 = text;
				string str6 = ",";
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName3 = this.partName;
				text = str5 + str6 + ((packagePartName3 != null) ? packagePartName3.ToString() : null);
			}
			else
			{
				text += ",uri=null)";
			}
			return text + "]";
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002150 File Offset: 0x00000350
		global::NPOI.OpenXml4Net.OPC.PackageRelationship global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship>.Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000478E File Offset: 0x0000298E
		void global::System.IDisposable.Dispose()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002150 File Offset: 0x00000350
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002150 File Offset: 0x00000350
		bool global::System.Collections.IEnumerator.MoveNext()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005B72 File Offset: 0x00003D72
		void global::System.Collections.IEnumerator.Reset()
		{
			this.Clear();
		}

		// Token: 0x04000063 RID: 99
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection));

		// Token: 0x04000064 RID: 100
		private global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship> relationshipsByID;

		// Token: 0x04000065 RID: 101
		private global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship> relationshipsByType;

		// Token: 0x04000066 RID: 102
		private global::System.Collections.Generic.SortedList<string, global::NPOI.OpenXml4Net.OPC.PackageRelationship> internalRelationshipsByTargetName;

		// Token: 0x04000067 RID: 103
		private global::NPOI.OpenXml4Net.OPC.PackagePart relationshipPart;

		// Token: 0x04000068 RID: 104
		private global::NPOI.OpenXml4Net.OPC.PackagePart sourcePart;

		// Token: 0x04000069 RID: 105
		private global::NPOI.OpenXml4Net.OPC.PackagePartName partName;

		// Token: 0x0400006A RID: 106
		private global::NPOI.OpenXml4Net.OPC.OPCPackage container;

		// Token: 0x0400006B RID: 107
		private int nextRelationshipId = -1;

		// Token: 0x02000036 RID: 54
		private class DuplicateComparer : global::System.Collections.Generic.IComparer<string>
		{
			// Token: 0x0600021F RID: 543 RVA: 0x0000A1BC File Offset: 0x000083BC
			public int Compare(string x, string y)
			{
				if (x.CompareTo(y) < 0)
				{
					return -1;
				}
				return 1;
			}
		}
	}
}
