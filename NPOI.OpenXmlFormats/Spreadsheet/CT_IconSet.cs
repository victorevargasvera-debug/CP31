using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005A2 RID: 1442
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_IconSet
	{
		// Token: 0x06003FBE RID: 16318 RVA: 0x0009A914 File Offset: 0x00098B14
		public CT_IconSet()
		{
			this.iconSetField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3TrafficLights1;
			this.showValueField = true;
			this.percentField = true;
			this.reverseField = false;
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x0009A938 File Offset: 0x00098B38
		// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x0009A940 File Offset: 0x00098B40
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo> cfvo
		{
			get
			{
				return this.cfvoField;
			}
			set
			{
				this.cfvoField = value;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x0009A949 File Offset: 0x00098B49
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x0009A951 File Offset: 0x00098B51
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3TrafficLights1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSet
		{
			get
			{
				return this.iconSetField;
			}
			set
			{
				this.iconSetField = value;
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x0009A95A File Offset: 0x00098B5A
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x0009A962 File Offset: 0x00098B62
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool showValue
		{
			get
			{
				return this.showValueField;
			}
			set
			{
				this.showValueField = value;
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x0009A96B File Offset: 0x00098B6B
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x0009A973 File Offset: 0x00098B73
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x0009A97C File Offset: 0x00098B7C
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x0009A984 File Offset: 0x00098B84
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool reverse
		{
			get
			{
				return this.reverseField;
			}
			set
			{
				this.reverseField = value;
			}
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0009A990 File Offset: 0x00098B90
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet ct_IconSet = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet();
			if (node.Attributes["iconSet"] != null)
			{
				ct_IconSet.iconSet = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType), "Item" + node.Attributes["iconSet"].Value);
			}
			ct_IconSet.showValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showValue"], true);
			if (!ct_IconSet.showValue)
			{
				ct_IconSet.showValueFieldSpecified = true;
			}
			ct_IconSet.percent = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["percent"], true);
			ct_IconSet.reverse = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["reverse"]);
			ct_IconSet.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cfvo")
				{
					ct_IconSet.cfvo.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_IconSet;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x0009AACC File Offset: 0x00098CCC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo AddNewCfvo()
		{
			if (this.cfvoField == null)
			{
				this.cfvoField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo();
			this.cfvoField.Add(ct_Cfvo);
			return ct_Cfvo;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x0009AAFF File Offset: 0x00098CFF
		public bool IsSetShowValue()
		{
			return this.showValueFieldSpecified;
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x0009AB08 File Offset: 0x00098D08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.iconSet != global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3TrafficLights1)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "iconSet", this.iconSet.ToString().Replace("Item", ""));
			}
			if (!this.showValue)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showValue", this.showValue);
			}
			if (!this.percent)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "percent", this.percent);
			}
			if (this.reverse)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "reverse", this.reverse);
			}
			sw.Write(">");
			if (this.cfvo != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo in this.cfvo)
				{
					ct_Cfvo.Write(sw, "cfvo");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002844 RID: 10308
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo> cfvoField;

		// Token: 0x04002845 RID: 10309
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSetField;

		// Token: 0x04002846 RID: 10310
		private bool showValueField;

		// Token: 0x04002847 RID: 10311
		private bool showValueFieldSpecified;

		// Token: 0x04002848 RID: 10312
		private bool percentField;

		// Token: 0x04002849 RID: 10313
		private bool reverseField;
	}
}
