using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E9 RID: 1001
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Surface
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x00063C2C File Offset: 0x00061E2C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface ct_Surface = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface();
			ct_Surface.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "thickness")
				{
					ct_Surface.thickness = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Surface.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureOptions")
				{
					ct_Surface.pictureOptions = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Surface.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Surface;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00063D24 File Offset: 0x00061F24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.thickness != null)
			{
				this.thickness.Write(sw, "thickness");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.pictureOptions != null)
			{
				this.pictureOptions.Write(sw, "pictureOptions");
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

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x00063DFC File Offset: 0x00061FFC
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x00063E04 File Offset: 0x00062004
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt thickness
		{
			get
			{
				return this.thicknessField;
			}
			set
			{
				this.thicknessField = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x00063E0D File Offset: 0x0006200D
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00063E15 File Offset: 0x00062015
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00063E1E File Offset: 0x0006201E
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00063E26 File Offset: 0x00062026
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptions
		{
			get
			{
				return this.pictureOptionsField;
			}
			set
			{
				this.pictureOptionsField = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00063E2F File Offset: 0x0006202F
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00063E37 File Offset: 0x00062037
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04001D2C RID: 7468
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt thicknessField;

		// Token: 0x04001D2D RID: 7469
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001D2E RID: 7470
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptionsField;

		// Token: 0x04001D2F RID: 7471
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
