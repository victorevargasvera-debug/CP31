using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FB RID: 763
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualConnectorProperties
	{
		// Token: 0x06001DC1 RID: 7617 RVA: 0x000509DC File Offset: 0x0004EBDC
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties ct_NonVisualConnectorProperties = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualConnectorProperties();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cxnSpLocks")
				{
					ct_NonVisualConnectorProperties.cxnSpLocks = global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "stCxn")
				{
					ct_NonVisualConnectorProperties.stCxn = global::NPOI.OpenXmlFormats.Dml.CT_Connection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endCxn")
				{
					ct_NonVisualConnectorProperties.endCxn = global::NPOI.OpenXmlFormats.Dml.CT_Connection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualConnectorProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualConnectorProperties;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00050AC4 File Offset: 0x0004ECC4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.cxnSpLocks != null)
			{
				this.cxnSpLocks.Write(sw, "cxnSpLocks");
			}
			if (this.stCxn != null)
			{
				this.stCxn.Write(sw, "stCxn");
			}
			if (this.endCxn != null)
			{
				this.endCxn.Write(sw, "endCxn");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00050B62 File Offset: 0x0004ED62
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x00050B6A File Offset: 0x0004ED6A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking cxnSpLocks
		{
			get
			{
				return this.cxnSpLocksField;
			}
			set
			{
				this.cxnSpLocksField = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00050B73 File Offset: 0x0004ED73
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x00050B7B File Offset: 0x0004ED7B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Connection stCxn
		{
			get
			{
				return this.stCxnField;
			}
			set
			{
				this.stCxnField = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00050B84 File Offset: 0x0004ED84
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00050B8C File Offset: 0x0004ED8C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Connection endCxn
		{
			get
			{
				return this.endCxnField;
			}
			set
			{
				this.endCxnField = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00050B95 File Offset: 0x0004ED95
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00050B9D File Offset: 0x0004ED9D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
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

		// Token: 0x040017AE RID: 6062
		private global::NPOI.OpenXmlFormats.Dml.CT_ConnectorLocking cxnSpLocksField;

		// Token: 0x040017AF RID: 6063
		private global::NPOI.OpenXmlFormats.Dml.CT_Connection stCxnField;

		// Token: 0x040017B0 RID: 6064
		private global::NPOI.OpenXmlFormats.Dml.CT_Connection endCxnField;

		// Token: 0x040017B1 RID: 6065
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
