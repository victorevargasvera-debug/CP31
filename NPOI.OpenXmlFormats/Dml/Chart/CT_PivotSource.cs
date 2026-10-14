using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000466 RID: 1126
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PivotSource
	{
		// Token: 0x06002D04 RID: 11524 RVA: 0x00071D40 File Offset: 0x0006FF40
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource ct_PivotSource = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotSource();
			ct_PivotSource.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "name")
				{
					ct_PivotSource.name = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "fmtId")
				{
					ct_PivotSource.fmtId = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotSource.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotSource;
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00071E10 File Offset: 0x00070010
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.name != null)
			{
				sw.Write(string.Format("<name>{0}</name>", this.name));
			}
			if (this.fmtId != null)
			{
				this.fmtId.Write(sw, "fmtId");
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x00071ED4 File Offset: 0x000700D4
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00071EDC File Offset: 0x000700DC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00071EE5 File Offset: 0x000700E5
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x00071EED File Offset: 0x000700ED
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt fmtId
		{
			get
			{
				return this.fmtIdField;
			}
			set
			{
				this.fmtIdField = value;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x00071EF6 File Offset: 0x000700F6
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x00071EFE File Offset: 0x000700FE
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
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

		// Token: 0x04001F76 RID: 8054
		private string nameField;

		// Token: 0x04001F77 RID: 8055
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt fmtIdField;

		// Token: 0x04001F78 RID: 8056
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
