using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200049A RID: 1178
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_GroupItems
	{
		// Token: 0x06002FFE RID: 12286 RVA: 0x000783B8 File Offset: 0x000765B8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems ct_GroupItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_GroupItems();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "e")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "d")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "n")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "m")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "s")
				{
					ct_GroupItems.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_GroupItems;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00078510 File Offset: 0x00076710
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)obj).Write(sw, "e");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean)obj).Write(sw, "b");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime)obj).Write(sw, "d");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)obj).Write(sw, "n");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)obj).Write(sw, "m");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)obj).Write(sw, "s");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00078634 File Offset: 0x00076834
		public CT_GroupItems()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x00078647 File Offset: 0x00076847
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x0007864F File Offset: 0x0007684F
		[global::System.Xml.Serialization.XmlElement("b", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("d", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("e", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("m", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("n", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("s", typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x00078658 File Offset: 0x00076858
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x00078660 File Offset: 0x00076860
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x00078669 File Offset: 0x00076869
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00078671 File Offset: 0x00076871
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x040020BD RID: 8381
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x040020BE RID: 8382
		private uint countField;

		// Token: 0x040020BF RID: 8383
		private bool countFieldSpecified;
	}
}
