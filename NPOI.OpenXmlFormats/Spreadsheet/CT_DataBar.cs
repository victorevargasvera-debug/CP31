using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005A1 RID: 1441
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DataBar
	{
		// Token: 0x06003FAF RID: 16303 RVA: 0x0009A66C File Offset: 0x0009886C
		public CT_DataBar()
		{
			this.minLengthField = 10U;
			this.maxLengthField = 90U;
			this.showValueField = true;
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x0009A68B File Offset: 0x0009888B
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x0009A693 File Offset: 0x00098893
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

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x0009A69C File Offset: 0x0009889C
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x0009A6A4 File Offset: 0x000988A4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x0009A6AD File Offset: 0x000988AD
		// (set) Token: 0x06003FB5 RID: 16309 RVA: 0x0009A6B5 File Offset: 0x000988B5
		[global::System.ComponentModel.DefaultValue(typeof(uint), "10")]
		public uint minLength
		{
			get
			{
				return this.minLengthField;
			}
			set
			{
				this.minLengthField = value;
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x0009A6BE File Offset: 0x000988BE
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x0009A6C6 File Offset: 0x000988C6
		[global::System.ComponentModel.DefaultValue(typeof(uint), "90")]
		public uint maxLength
		{
			get
			{
				return this.maxLengthField;
			}
			set
			{
				this.maxLengthField = value;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x0009A6CF File Offset: 0x000988CF
		// (set) Token: 0x06003FB9 RID: 16313 RVA: 0x0009A6D7 File Offset: 0x000988D7
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

		// Token: 0x06003FBA RID: 16314 RVA: 0x0009A6E0 File Offset: 0x000988E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar ct_DataBar = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar();
			ct_DataBar.minLength = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["minLength"]);
			ct_DataBar.maxLength = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["maxLength"]);
			if (node.Attributes["showValue"] == null)
			{
				ct_DataBar.showValue = true;
			}
			else
			{
				ct_DataBar.showValue = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["showValue"]);
			}
			ct_DataBar.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "color")
				{
					ct_DataBar.color = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cfvo")
				{
					ct_DataBar.cfvo.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DataBar;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x0009A7FC File Offset: 0x000989FC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo AddNewCfvo()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo();
			if (this.cfvo == null)
			{
				this.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>();
			}
			this.cfvo.Add(ct_Cfvo);
			return ct_Cfvo;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0009A6CF File Offset: 0x000988CF
		public bool IsSetShowValue()
		{
			return this.showValueField;
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x0009A830 File Offset: 0x00098A30
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "minLength", this.minLength, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "maxLength", this.maxLength, false);
			if (this.showValue)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "showValue", this.showValue);
			}
			sw.Write(">");
			if (this.cfvo != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo in this.cfvo)
				{
					ct_Cfvo.Write(sw, "cfvo");
				}
			}
			if (this.color != null)
			{
				this.color.Write(sw, "color");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0400283F RID: 10303
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo> cfvoField;

		// Token: 0x04002840 RID: 10304
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color colorField;

		// Token: 0x04002841 RID: 10305
		private uint minLengthField;

		// Token: 0x04002842 RID: 10306
		private uint maxLengthField;

		// Token: 0x04002843 RID: 10307
		private bool showValueField;
	}
}
