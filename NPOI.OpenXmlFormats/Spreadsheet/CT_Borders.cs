using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004F2 RID: 1266
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Borders
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x00085BF0 File Offset: 0x00083DF0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders ct_Borders = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Borders();
			ct_Borders.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_Borders.border = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "border")
				{
					ct_Borders.border.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Borders;
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00085C98 File Offset: 0x00083E98
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, true);
			sw.Write(">");
			if (this.border != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ct_Border in this.border)
				{
					ct_Border.Write(sw, "border");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00085D38 File Offset: 0x00083F38
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border AddNewBorder()
		{
			if (this.borderField == null)
			{
				this.borderField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border ct_Border = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border();
			this.borderField.Add(ct_Border);
			return ct_Border;
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x00085D6B File Offset: 0x00083F6B
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x00085D73 File Offset: 0x00083F73
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border> border
		{
			get
			{
				return this.borderField;
			}
			set
			{
				this.borderField = value;
			}
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00085D73 File Offset: 0x00083F73
		public void SetBorderArray(global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border> array)
		{
			this.borderField = array;
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x00085D7C File Offset: 0x00083F7C
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x00085D84 File Offset: 0x00083F84
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

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x00085D8D File Offset: 0x00083F8D
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00085D95 File Offset: 0x00083F95
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

		// Token: 0x0400238D RID: 9101
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border> borderField;

		// Token: 0x0400238E RID: 9102
		private uint countField;

		// Token: 0x0400238F RID: 9103
		private bool countFieldSpecified;
	}
}
