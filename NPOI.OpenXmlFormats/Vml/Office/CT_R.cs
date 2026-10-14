using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021D RID: 541
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_R
	{
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000423F4 File Offset: 0x000405F4
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x000423FC File Offset: 0x000405FC
		[global::System.Xml.Serialization.XmlElement("proxy")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy> proxy
		{
			get
			{
				return this.proxyField;
			}
			set
			{
				this.proxyField = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x00042405 File Offset: 0x00040605
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0004240D File Offset: 0x0004060D
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00042416 File Offset: 0x00040616
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0004241E File Offset: 0x0004061E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_RType type
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x00042427 File Offset: 0x00040627
		[global::System.Xml.Serialization.XmlIgnore]
		public bool typeSpecified
		{
			get
			{
				return this.typeField > global::NPOI.OpenXmlFormats.Vml.Office.ST_RType.NONE;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00042432 File Offset: 0x00040632
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x0004243A File Offset: 0x0004063A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_How how
		{
			get
			{
				return this.howField;
			}
			set
			{
				this.howField = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00042443 File Offset: 0x00040643
		[global::System.Xml.Serialization.XmlIgnore]
		public bool howSpecified
		{
			get
			{
				return this.howField > global::NPOI.OpenXmlFormats.Vml.Office.ST_How.NONE;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x0004244E File Offset: 0x0004064E
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00042456 File Offset: 0x00040656
		[global::System.Xml.Serialization.XmlAttribute]
		public string idref
		{
			get
			{
				return this.idrefField;
			}
			set
			{
				this.idrefField = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0004245F File Offset: 0x0004065F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool idrefSpecified
		{
			get
			{
				return this.idrefField != null;
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0004246C File Offset: 0x0004066C
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_R Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_R ct_R = new global::NPOI.OpenXmlFormats.Vml.Office.CT_R();
			ct_R.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			if (node.Attributes["type"] != null)
			{
				ct_R.type = (global::NPOI.OpenXmlFormats.Vml.Office.ST_RType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Office.ST_RType), node.Attributes["type"].Value);
			}
			if (node.Attributes["how"] != null)
			{
				ct_R.how = (global::NPOI.OpenXmlFormats.Vml.Office.ST_How)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Office.ST_How), node.Attributes["how"].Value);
			}
			ct_R.idref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["idref"]);
			ct_R.proxy = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "proxy")
				{
					ct_R.proxy.Add(global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_R;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000425B4 File Offset: 0x000407B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			if (this.type != global::NPOI.OpenXmlFormats.Vml.Office.ST_RType.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
			}
			if (this.how != global::NPOI.OpenXmlFormats.Vml.Office.ST_How.NONE)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "how", this.how.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idref", this.idref);
			sw.Write(">");
			if (this.proxy != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy ct_Proxy in this.proxy)
				{
					ct_Proxy.Write(sw, "proxy");
				}
			}
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x0400116B RID: 4459
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Office.CT_Proxy> proxyField;

		// Token: 0x0400116C RID: 4460
		private string idField = string.Empty;

		// Token: 0x0400116D RID: 4461
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_RType typeField;

		// Token: 0x0400116E RID: 4462
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_How howField;

		// Token: 0x0400116F RID: 4463
		private string idrefField;
	}
}
