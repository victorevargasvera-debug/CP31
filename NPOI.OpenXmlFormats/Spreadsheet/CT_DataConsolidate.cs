using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200058E RID: 1422
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_DataConsolidate
	{
		// Token: 0x06003E77 RID: 15991 RVA: 0x0009775C File Offset: 0x0009595C
		public CT_DataConsolidate()
		{
			this.dataRefsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs();
			this.functionField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction.sum;
			this.leftLabelsField = false;
			this.topLabelsField = false;
			this.linkField = false;
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x0009778B File Offset: 0x0009598B
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x00097793 File Offset: 0x00095993
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs dataRefs
		{
			get
			{
				return this.dataRefsField;
			}
			set
			{
				this.dataRefsField = value;
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x0009779C File Offset: 0x0009599C
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x000977A4 File Offset: 0x000959A4
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction.sum)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction function
		{
			get
			{
				return this.functionField;
			}
			set
			{
				this.functionField = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x000977AD File Offset: 0x000959AD
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x000977B5 File Offset: 0x000959B5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool leftLabels
		{
			get
			{
				return this.leftLabelsField;
			}
			set
			{
				this.leftLabelsField = value;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x000977BE File Offset: 0x000959BE
		// (set) Token: 0x06003E7F RID: 15999 RVA: 0x000977C6 File Offset: 0x000959C6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool topLabels
		{
			get
			{
				return this.topLabelsField;
			}
			set
			{
				this.topLabelsField = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x000977CF File Offset: 0x000959CF
		// (set) Token: 0x06003E81 RID: 16001 RVA: 0x000977D7 File Offset: 0x000959D7
		[global::System.ComponentModel.DefaultValue(false)]
		public bool link
		{
			get
			{
				return this.linkField;
			}
			set
			{
				this.linkField = value;
			}
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000977E0 File Offset: 0x000959E0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate ct_DataConsolidate = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataConsolidate();
			if (node.Attributes["function"] != null)
			{
				ct_DataConsolidate.function = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction), node.Attributes["function"].Value);
			}
			ct_DataConsolidate.leftLabels = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["leftLabels"]);
			ct_DataConsolidate.topLabels = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["topLabels"]);
			ct_DataConsolidate.link = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["link"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dataRefs")
				{
					ct_DataConsolidate.dataRefs = global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DataConsolidate;
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000978F0 File Offset: 0x00095AF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "function", this.function.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "leftLabels", this.leftLabels);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "topLabels", this.topLabels);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "link", this.link);
			sw.Write(">");
			if (this.dataRefs != null)
			{
				this.dataRefs.Write(sw, "dataRefs");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040027AC RID: 10156
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataRefs dataRefsField;

		// Token: 0x040027AD RID: 10157
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DataConsolidateFunction functionField;

		// Token: 0x040027AE RID: 10158
		private bool leftLabelsField;

		// Token: 0x040027AF RID: 10159
		private bool topLabelsField;

		// Token: 0x040027B0 RID: 10160
		private bool linkField;
	}
}
