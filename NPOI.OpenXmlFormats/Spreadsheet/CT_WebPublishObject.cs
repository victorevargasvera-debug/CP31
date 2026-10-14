using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200052C RID: 1324
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WebPublishObject
	{
		// Token: 0x06003A35 RID: 14901 RVA: 0x00090839 File Offset: 0x0008EA39
		public CT_WebPublishObject()
		{
			this.autoRepublishField = false;
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00090848 File Offset: 0x0008EA48
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]),
				divId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["divId"]),
				sourceObject = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["sourceObject"]),
				destinationFile = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["destinationFile"]),
				title = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["title"]),
				autoRepublish = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["autoRepublish"])
			};
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00090904 File Offset: 0x0008EB04
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "divId", this.divId);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sourceObject", this.sourceObject);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "destinationFile", this.destinationFile);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "title", this.title);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "autoRepublish", this.autoRepublish);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x000909A5 File Offset: 0x0008EBA5
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x000909AD File Offset: 0x0008EBAD
		[global::System.Xml.Serialization.XmlAnyAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000909B6 File Offset: 0x0008EBB6
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x000909BE File Offset: 0x0008EBBE
		[global::System.Xml.Serialization.XmlAnyAttribute]
		public string divId
		{
			get
			{
				return this.divIdField;
			}
			set
			{
				this.divIdField = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x000909C7 File Offset: 0x0008EBC7
		// (set) Token: 0x06003A3D RID: 14909 RVA: 0x000909CF File Offset: 0x0008EBCF
		[global::System.Xml.Serialization.XmlAnyAttribute]
		public string sourceObject
		{
			get
			{
				return this.sourceObjectField;
			}
			set
			{
				this.sourceObjectField = value;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x000909D8 File Offset: 0x0008EBD8
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x000909E0 File Offset: 0x0008EBE0
		[global::System.Xml.Serialization.XmlAnyAttribute]
		public string destinationFile
		{
			get
			{
				return this.destinationFileField;
			}
			set
			{
				this.destinationFileField = value;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x000909E9 File Offset: 0x0008EBE9
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x000909F1 File Offset: 0x0008EBF1
		[global::System.Xml.Serialization.XmlAnyAttribute]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x000909FA File Offset: 0x0008EBFA
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00090A02 File Offset: 0x0008EC02
		[global::System.Xml.Serialization.XmlAnyAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool autoRepublish
		{
			get
			{
				return this.autoRepublishField;
			}
			set
			{
				this.autoRepublishField = value;
			}
		}

		// Token: 0x04002522 RID: 9506
		private uint idField;

		// Token: 0x04002523 RID: 9507
		private string divIdField;

		// Token: 0x04002524 RID: 9508
		private string sourceObjectField;

		// Token: 0x04002525 RID: 9509
		private string destinationFileField;

		// Token: 0x04002526 RID: 9510
		private string titleField;

		// Token: 0x04002527 RID: 9511
		private bool autoRepublishField;
	}
}
