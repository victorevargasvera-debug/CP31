using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000218 RID: 536
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot("shapelayout", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ShapeLayout
	{
		// Token: 0x0600160A RID: 5642 RVA: 0x00041C5F File Offset: 0x0003FE5F
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap AddNewIdmap()
		{
			this.idmapField = new global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap();
			return this.idmapField;
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00041C72 File Offset: 0x0003FE72
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00041C7A File Offset: 0x0003FE7A
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap idmap
		{
			get
			{
				return this.idmapField;
			}
			set
			{
				this.idmapField = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00041C83 File Offset: 0x0003FE83
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x00041C8B File Offset: 0x0003FE8B
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable regrouptable
		{
			get
			{
				return this.regrouptableField;
			}
			set
			{
				this.regrouptableField = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00041C94 File Offset: 0x0003FE94
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x00041C9C File Offset: 0x0003FE9C
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules rules
		{
			get
			{
				return this.rulesField;
			}
			set
			{
				this.rulesField = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00041CA5 File Offset: 0x0003FEA5
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00041CAD File Offset: 0x0003FEAD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00041CB6 File Offset: 0x0003FEB6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00041CC4 File Offset: 0x0003FEC4
		public static global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout ct_ShapeLayout = new global::NPOI.OpenXmlFormats.Vml.Office.CT_ShapeLayout();
			if (node.Attributes["v:ext"] != null)
			{
				ct_ShapeLayout.ext = (global::NPOI.OpenXmlFormats.Vml.ST_Ext)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_Ext), node.Attributes["v:ext"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idmap")
				{
					ct_ShapeLayout.idmap = global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "regrouptable")
				{
					ct_ShapeLayout.regrouptable = global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rules")
				{
					ct_ShapeLayout.rules = global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ShapeLayout;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		public void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<o:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v:ext", this.ext.ToString());
			sw.Write(">");
			if (this.idmap != null)
			{
				this.idmap.Write(sw, "idmap");
			}
			if (this.regrouptable != null)
			{
				this.regrouptable.Write(sw, "regrouptable");
			}
			if (this.rules != null)
			{
				this.rules.Write(sw, "rules");
			}
			sw.Write(string.Format("</o:{0}>", nodeName));
		}

		// Token: 0x0400115F RID: 4447
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_IdMap idmapField;

		// Token: 0x04001160 RID: 4448
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_RegroupTable regrouptableField;

		// Token: 0x04001161 RID: 4449
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_Rules rulesField;

		// Token: 0x04001162 RID: 4450
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;
	}
}
