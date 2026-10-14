using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000465 RID: 1125
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Protection
	{
		// Token: 0x06002CF7 RID: 11511 RVA: 0x00071B28 File Offset: 0x0006FD28
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection ct_Protection = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Protection();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "chartObject")
				{
					ct_Protection.chartObject = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "data")
				{
					ct_Protection.data = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "formatting")
				{
					ct_Protection.formatting = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "selection")
				{
					ct_Protection.selection = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "userInterface")
				{
					ct_Protection.userInterface = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Protection;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00071C34 File Offset: 0x0006FE34
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.chartObject != null)
			{
				this.chartObject.Write(sw, "chartObject");
			}
			if (this.data != null)
			{
				this.data.Write(sw, "data");
			}
			if (this.formatting != null)
			{
				this.formatting.Write(sw, "formatting");
			}
			if (this.selection != null)
			{
				this.selection.Write(sw, "selection");
			}
			if (this.userInterface != null)
			{
				this.userInterface.Write(sw, "userInterface");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x00071CEB File Offset: 0x0006FEEB
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00071CF3 File Offset: 0x0006FEF3
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean chartObject
		{
			get
			{
				return this.chartObjectField;
			}
			set
			{
				this.chartObjectField = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x00071CFC File Offset: 0x0006FEFC
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x00071D04 File Offset: 0x0006FF04
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00071D0D File Offset: 0x0006FF0D
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00071D15 File Offset: 0x0006FF15
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean formatting
		{
			get
			{
				return this.formattingField;
			}
			set
			{
				this.formattingField = value;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x00071D1E File Offset: 0x0006FF1E
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00071D26 File Offset: 0x0006FF26
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean selection
		{
			get
			{
				return this.selectionField;
			}
			set
			{
				this.selectionField = value;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00071D2F File Offset: 0x0006FF2F
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x00071D37 File Offset: 0x0006FF37
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean userInterface
		{
			get
			{
				return this.userInterfaceField;
			}
			set
			{
				this.userInterfaceField = value;
			}
		}

		// Token: 0x04001F71 RID: 8049
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean chartObjectField;

		// Token: 0x04001F72 RID: 8050
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean dataField;

		// Token: 0x04001F73 RID: 8051
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean formattingField;

		// Token: 0x04001F74 RID: 8052
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean selectionField;

		// Token: 0x04001F75 RID: 8053
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean userInterfaceField;
	}
}
