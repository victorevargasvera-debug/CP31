using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000462 RID: 1122
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_View3D
	{
		// Token: 0x06002CB3 RID: 11443 RVA: 0x00070FD8 File Offset: 0x0006F1D8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D ct_View3D = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D();
			ct_View3D.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rotX")
				{
					ct_View3D.rotX = global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotX.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hPercent")
				{
					ct_View3D.hPercent = global::NPOI.OpenXmlFormats.Dml.Chart.CT_HPercent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rotY")
				{
					ct_View3D.rotY = global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotY.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "depthPercent")
				{
					ct_View3D.depthPercent = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rAngAx")
				{
					ct_View3D.rAngAx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "perspective")
				{
					ct_View3D.perspective = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_View3D.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_View3D;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00071148 File Offset: 0x0006F348
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.rotX != null)
			{
				this.rotX.Write(sw, "rotX");
			}
			if (this.hPercent != null)
			{
				this.hPercent.Write(sw, "hPercent");
			}
			if (this.rotY != null)
			{
				this.rotY.Write(sw, "rotY");
			}
			if (this.depthPercent != null)
			{
				this.depthPercent.Write(sw, "depthPercent");
			}
			if (this.rAngAx != null)
			{
				this.rAngAx.Write(sw, "rAngAx");
			}
			if (this.perspective != null)
			{
				this.perspective.Write(sw, "perspective");
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

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x0007126C File Offset: 0x0006F46C
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x00071274 File Offset: 0x0006F474
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotX rotX
		{
			get
			{
				return this.rotXField;
			}
			set
			{
				this.rotXField = value;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x0007127D File Offset: 0x0006F47D
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00071285 File Offset: 0x0006F485
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_HPercent hPercent
		{
			get
			{
				return this.hPercentField;
			}
			set
			{
				this.hPercentField = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x0007128E File Offset: 0x0006F48E
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00071296 File Offset: 0x0006F496
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotY rotY
		{
			get
			{
				return this.rotYField;
			}
			set
			{
				this.rotYField = value;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x0007129F File Offset: 0x0006F49F
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x000712A7 File Offset: 0x0006F4A7
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent depthPercent
		{
			get
			{
				return this.depthPercentField;
			}
			set
			{
				this.depthPercentField = value;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000712B0 File Offset: 0x0006F4B0
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x000712B8 File Offset: 0x0006F4B8
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean rAngAx
		{
			get
			{
				return this.rAngAxField;
			}
			set
			{
				this.rAngAxField = value;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000712C1 File Offset: 0x0006F4C1
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x000712C9 File Offset: 0x0006F4C9
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective perspective
		{
			get
			{
				return this.perspectiveField;
			}
			set
			{
				this.perspectiveField = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000712D2 File Offset: 0x0006F4D2
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000712DA File Offset: 0x0006F4DA
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x04001F57 RID: 8023
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotX rotXField;

		// Token: 0x04001F58 RID: 8024
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_HPercent hPercentField;

		// Token: 0x04001F59 RID: 8025
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_RotY rotYField;

		// Token: 0x04001F5A RID: 8026
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DepthPercent depthPercentField;

		// Token: 0x04001F5B RID: 8027
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean rAngAxField;

		// Token: 0x04001F5C RID: 8028
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Perspective perspectiveField;

		// Token: 0x04001F5D RID: 8029
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
