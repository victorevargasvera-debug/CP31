using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A7 RID: 1191
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PCDSDTCEntries
	{
		// Token: 0x060030C3 RID: 12483 RVA: 0x0007A2B4 File Offset: 0x000784B4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries ct_PCDSDTCEntries = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDSDTCEntries();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "m")
				{
					ct_PCDSDTCEntries.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "n")
				{
					ct_PCDSDTCEntries.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_PCDSDTCEntries.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "s")
				{
					ct_PCDSDTCEntries.Items.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_String.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PCDSDTCEntries;
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0007A3B0 File Offset: 0x000785B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			sw.Write(">");
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing)obj).Write(sw, "m");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number)obj).Write(sw, "n");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error)obj).Write(sw, "e");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)
				{
					((global::NPOI.OpenXmlFormats.Spreadsheet.CT_String)obj).Write(sw, "s");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0007A494 File Offset: 0x00078694
		public CT_PCDSDTCEntries()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x0007A4A7 File Offset: 0x000786A7
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x0007A4AF File Offset: 0x000786AF
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

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x0007A4B8 File Offset: 0x000786B8
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x0007A4C0 File Offset: 0x000786C0
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

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x0007A4C9 File Offset: 0x000786C9
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x0007A4D1 File Offset: 0x000786D1
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

		// Token: 0x0400210C RID: 8460
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x0400210D RID: 8461
		private uint countField;

		// Token: 0x0400210E RID: 8462
		private bool countFieldSpecified;
	}
}
