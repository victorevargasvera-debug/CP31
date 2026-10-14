using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CE RID: 1230
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Format
	{
		// Token: 0x0600336B RID: 13163 RVA: 0x00080F34 File Offset: 0x0007F134
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format ct_Format = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Format();
			if (node.Attributes["action"] != null)
			{
				ct_Format.action = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction), node.Attributes["action"].Value);
			}
			if (node.Attributes["dxfId"] != null)
			{
				ct_Format.dxfId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dxfId"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_Format.pivotArea = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Format.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Format;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00081040 File Offset: 0x0007F240
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "action", this.action.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dxfId", this.dxfId, false);
			sw.Write(">");
			if (this.pivotArea != null)
			{
				this.pivotArea.Write(sw, "pivotArea");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000810DD File Offset: 0x0007F2DD
		public CT_Format()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.pivotAreaField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
			this.actionField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction.formatting;
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x00081102 File Offset: 0x0007F302
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x0008110A File Offset: 0x0007F30A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x00081113 File Offset: 0x0007F313
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x0008111B File Offset: 0x0007F31B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x00081124 File Offset: 0x0007F324
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x0008112C File Offset: 0x0007F32C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction.formatting)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x00081135 File Offset: 0x0007F335
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x0008113D File Offset: 0x0007F33D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dxfId
		{
			get
			{
				return this.dxfIdField;
			}
			set
			{
				this.dxfIdField = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x00081146 File Offset: 0x0007F346
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x0008114E File Offset: 0x0007F34E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxfIdSpecified
		{
			get
			{
				return this.dxfIdFieldSpecified;
			}
			set
			{
				this.dxfIdFieldSpecified = value;
			}
		}

		// Token: 0x04002245 RID: 8773
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotAreaField;

		// Token: 0x04002246 RID: 8774
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002247 RID: 8775
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_FormatAction actionField;

		// Token: 0x04002248 RID: 8776
		private uint dxfIdField;

		// Token: 0x04002249 RID: 8777
		private bool dxfIdFieldSpecified;
	}
}
