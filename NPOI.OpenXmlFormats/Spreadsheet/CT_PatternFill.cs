using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000517 RID: 1303
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PatternFill
	{
		// Token: 0x060038CD RID: 14541 RVA: 0x0008D518 File Offset: 0x0008B718
		public bool IsSetPatternType()
		{
			if (this.patternTypeField != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType? st_PatternType = this.patternTypeField;
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType st_PatternType2 = global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.none;
				return !(st_PatternType.GetValueOrDefault() == st_PatternType2 & st_PatternType != null);
			}
			return false;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0008D552 File Offset: 0x0008B752
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color AddNewFgColor()
		{
			this.fgColorField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
			return this.fgColorField;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0008D565 File Offset: 0x0008B765
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color AddNewBgColor()
		{
			this.bgColorField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
			return this.bgColorField;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0008D578 File Offset: 0x0008B778
		public void UnsetPatternType()
		{
			this.patternTypeField = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType.none);
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x0008D586 File Offset: 0x0008B786
		public void UnsetFgColor()
		{
			this.fgColorField = null;
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0008D58F File Offset: 0x0008B78F
		public void UnsetBgColor()
		{
			this.bgColorField = null;
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0008D598 File Offset: 0x0008B798
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill ct_PatternFill = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PatternFill();
			if (node.Attributes["patternType"] != null)
			{
				ct_PatternFill.patternType = new global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType?((global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType), node.Attributes["patternType"].Value));
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fgColor")
				{
					ct_PatternFill.fgColor = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bgColor")
				{
					ct_PatternFill.bgColor = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PatternFill;
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0008D67C File Offset: 0x0008B87C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.patternType != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "patternType", this.patternType.ToString());
			}
			if (this.fgColor == null && this.bgColor == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			if (this.fgColor != null)
			{
				this.fgColor.Write(sw, "fgColor");
			}
			if (this.bgColor != null)
			{
				this.bgColor.Write(sw, "bgColor");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x0008D733 File Offset: 0x0008B933
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x0008D73B File Offset: 0x0008B93B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color fgColor
		{
			get
			{
				return this.fgColorField;
			}
			set
			{
				this.fgColorField = value;
			}
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0008D744 File Offset: 0x0008B944
		public bool IsSetBgColor()
		{
			return this.bgColorField != null;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0008D74F File Offset: 0x0008B94F
		public bool IsSetFgColor()
		{
			return this.fgColorField != null;
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x0008D75A File Offset: 0x0008B95A
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x0008D762 File Offset: 0x0008B962
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color bgColor
		{
			get
			{
				return this.bgColorField;
			}
			set
			{
				this.bgColorField = value;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x0008D76B File Offset: 0x0008B96B
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x0008D773 File Offset: 0x0008B973
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType? patternType
		{
			get
			{
				return this.patternTypeField;
			}
			set
			{
				this.patternTypeField = value;
			}
		}

		// Token: 0x0400247D RID: 9341
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color fgColorField;

		// Token: 0x0400247E RID: 9342
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color bgColorField;

		// Token: 0x0400247F RID: 9343
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_PatternType? patternTypeField;
	}
}
