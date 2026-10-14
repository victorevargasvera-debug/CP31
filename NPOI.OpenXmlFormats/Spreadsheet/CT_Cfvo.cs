using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200059F RID: 1439
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Cfvo
	{
		// Token: 0x06003FA2 RID: 16290 RVA: 0x0009A45C File Offset: 0x0009865C
		public CT_Cfvo()
		{
			this.gteField = true;
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x0009A46B File Offset: 0x0009866B
		// (set) Token: 0x06003FA4 RID: 16292 RVA: 0x0009A473 File Offset: 0x00098673
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

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x0009A47C File Offset: 0x0009867C
		// (set) Token: 0x06003FA6 RID: 16294 RVA: 0x0009A484 File Offset: 0x00098684
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x0009A48D File Offset: 0x0009868D
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x0009A495 File Offset: 0x00098695
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x0009A49E File Offset: 0x0009869E
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x0009A4A6 File Offset: 0x000986A6
		[global::System.ComponentModel.DefaultValue(true)]
		public bool gte
		{
			get
			{
				return this.gteField;
			}
			set
			{
				this.gteField = value;
			}
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x0009A4B0 File Offset: 0x000986B0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo();
			if (node.Attributes["type"] != null)
			{
				ct_Cfvo.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), node.Attributes["type"].Value);
			}
			ct_Cfvo.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["val"]);
			ct_Cfvo.gte = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["gte"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_Cfvo.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Cfvo;
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0009A5A4 File Offset: 0x000987A4
		public bool IsSetVal()
		{
			return !string.IsNullOrEmpty(this.val);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x0009A5B4 File Offset: 0x000987B4
		public void UnsetVal()
		{
			this.val = string.Empty;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x0009A5C4 File Offset: 0x000987C4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			if (this.gte)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "gte", this.gte);
			}
			if (this.extLst != null)
			{
				sw.Write(">");
				this.extLst.Write(sw, "extLst");
				sw.Write(string.Format("</{0}>", nodeName));
				return;
			}
			sw.Write("/>");
		}

		// Token: 0x04002832 RID: 10290
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x04002833 RID: 10291
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType typeField;

		// Token: 0x04002834 RID: 10292
		private string valField;

		// Token: 0x04002835 RID: 10293
		private bool gteField;
	}
}
