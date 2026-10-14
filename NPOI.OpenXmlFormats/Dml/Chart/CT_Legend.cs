using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000402 RID: 1026
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Legend
	{
		// Token: 0x060028F6 RID: 10486 RVA: 0x00067218 File Offset: 0x00065418
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend ct_Legend = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend();
			ct_Legend.legendEntry = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry>();
			ct_Legend.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "legendPos")
				{
					ct_Legend.legendPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "layout")
				{
					ct_Legend.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "overlay")
				{
					ct_Legend.overlay = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Legend.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_Legend.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legendEntry")
				{
					ct_Legend.legendEntry.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Legend.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Legend;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00067398 File Offset: 0x00065598
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.legendPos != null)
			{
				this.legendPos.Write(sw, "legendPos");
			}
			if (this.layout != null)
			{
				this.layout.Write(sw, "layout");
			}
			if (this.overlay != null)
			{
				this.overlay.Write(sw, "overlay");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
			}
			if (this.legendEntry != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry ct_LegendEntry in this.legendEntry)
				{
					ct_LegendEntry.Write(sw, "legendEntry");
				}
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

		// Token: 0x060028F8 RID: 10488 RVA: 0x000674F0 File Offset: 0x000656F0
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout AddNewLayout()
		{
			this.layoutField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout();
			return this.layoutField;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00067503 File Offset: 0x00065703
		public bool IsSetLegendPos()
		{
			return this.legendPosSpecifiedField;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0006750B File Offset: 0x0006570B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos AddNewLegendPos()
		{
			if (this.legendPosField == null)
			{
				this.legendPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos();
			}
			return this.legendPosField;
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x00067503 File Offset: 0x00065703
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x00067526 File Offset: 0x00065726
		[global::System.Xml.Serialization.XmlIgnore]
		public bool legendPosSpecified
		{
			get
			{
				return this.legendPosSpecifiedField;
			}
			set
			{
				this.legendPosSpecifiedField = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0006752F File Offset: 0x0006572F
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x00067537 File Offset: 0x00065737
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos legendPos
		{
			get
			{
				return this.legendPosField;
			}
			set
			{
				this.legendPosField = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x00067540 File Offset: 0x00065740
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x00067548 File Offset: 0x00065748
		[global::System.Xml.Serialization.XmlElement("legendEntry", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry> legendEntry
		{
			get
			{
				return this.legendEntryField;
			}
			set
			{
				this.legendEntryField = value;
			}
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00067551 File Offset: 0x00065751
		public bool IsSetLayout()
		{
			return this.layoutSpecifiedField;
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00067551 File Offset: 0x00065751
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x00067559 File Offset: 0x00065759
		[global::System.Xml.Serialization.XmlIgnore]
		public bool layoutSpecified
		{
			get
			{
				return this.layoutSpecifiedField;
			}
			set
			{
				this.layoutSpecifiedField = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x00067562 File Offset: 0x00065762
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x0006756A File Offset: 0x0006576A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layout
		{
			get
			{
				return this.layoutField;
			}
			set
			{
				this.layoutField = value;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x00067573 File Offset: 0x00065773
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0006757B File Offset: 0x0006577B
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean overlay
		{
			get
			{
				return this.overlayField;
			}
			set
			{
				this.overlayField = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00067584 File Offset: 0x00065784
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0006758C File Offset: 0x0006578C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x00067595 File Offset: 0x00065795
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x0006759D File Offset: 0x0006579D
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPr
		{
			get
			{
				return this.txPrField;
			}
			set
			{
				this.txPrField = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000675A6 File Offset: 0x000657A6
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x000675AE File Offset: 0x000657AE
		[global::System.Xml.Serialization.XmlArray(Order = 6)]
		[global::System.Xml.Serialization.XmlArrayItem("ext", IsNullable = false)]
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

		// Token: 0x0600290E RID: 10510 RVA: 0x000675B7 File Offset: 0x000657B7
		public bool IsSetOverlay()
		{
			return this.overlayField != null && this.overlayField.val > 0;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000675D1 File Offset: 0x000657D1
		public void AddNewOverlay()
		{
			this.overlayField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
		}

		// Token: 0x04001DAC RID: 7596
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos legendPosField;

		// Token: 0x04001DAD RID: 7597
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendEntry> legendEntryField;

		// Token: 0x04001DAE RID: 7598
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001DAF RID: 7599
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean overlayField;

		// Token: 0x04001DB0 RID: 7600
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001DB1 RID: 7601
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001DB2 RID: 7602
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001DB3 RID: 7603
		private bool legendPosSpecifiedField;

		// Token: 0x04001DB4 RID: 7604
		private bool layoutSpecifiedField;
	}
}
