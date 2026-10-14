using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C4 RID: 1220
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_rowItems
	{
		// Token: 0x06003300 RID: 13056 RVA: 0x0007FC20 File Offset: 0x0007DE20
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems ct_rowItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_rowItems();
			if (node.Attributes["count"] != null)
			{
				ct_rowItems.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_rowItems.i = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "i")
				{
					ct_rowItems.i.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_I.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_rowItems;
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0007FCDC File Offset: 0x0007DEDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.i != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_I ct_I in this.i)
				{
					ct_I.Write(sw, "i");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0007FD7C File Offset: 0x0007DF7C
		public CT_rowItems()
		{
			this.iField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I>();
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x0007FD8F File Offset: 0x0007DF8F
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x0007FD97 File Offset: 0x0007DF97
		[global::System.Xml.Serialization.XmlElement("i", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I> i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x0007FDA0 File Offset: 0x0007DFA0
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x0007FDA8 File Offset: 0x0007DFA8
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

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x0007FDB1 File Offset: 0x0007DFB1
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x0007FDB9 File Offset: 0x0007DFB9
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

		// Token: 0x04002216 RID: 8726
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I> iField;

		// Token: 0x04002217 RID: 8727
		private uint countField;

		// Token: 0x04002218 RID: 8728
		private bool countFieldSpecified;
	}
}
