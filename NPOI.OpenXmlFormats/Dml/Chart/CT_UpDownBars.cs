using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003EE RID: 1006
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_UpDownBars
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x00064E4C File Offset: 0x0006304C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars ct_UpDownBars = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars();
			ct_UpDownBars.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "gapWidth")
				{
					ct_UpDownBars.gapWidth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "upBars")
				{
					ct_UpDownBars.upBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "downBars")
				{
					ct_UpDownBars.downBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_UpDownBars.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_UpDownBars;
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00064F44 File Offset: 0x00063144
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.gapWidth != null)
			{
				this.gapWidth.Write(sw, "gapWidth");
			}
			if (this.upBars != null)
			{
				this.upBars.Write(sw, "upBars");
			}
			if (this.downBars != null)
			{
				this.downBars.Write(sw, "downBars");
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

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0006501C File Offset: 0x0006321C
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x00065024 File Offset: 0x00063224
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidth
		{
			get
			{
				return this.gapWidthField;
			}
			set
			{
				this.gapWidthField = value;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0006502D File Offset: 0x0006322D
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x00065035 File Offset: 0x00063235
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar upBars
		{
			get
			{
				return this.upBarsField;
			}
			set
			{
				this.upBarsField = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0006503E File Offset: 0x0006323E
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x00065046 File Offset: 0x00063246
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar downBars
		{
			get
			{
				return this.downBarsField;
			}
			set
			{
				this.downBarsField = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0006504F File Offset: 0x0006324F
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x00065057 File Offset: 0x00063257
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

		// Token: 0x04001D51 RID: 7505
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidthField;

		// Token: 0x04001D52 RID: 7506
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar upBarsField;

		// Token: 0x04001D53 RID: 7507
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar downBarsField;

		// Token: 0x04001D54 RID: 7508
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
