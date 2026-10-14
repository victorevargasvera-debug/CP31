using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200043D RID: 1085
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Trendline
	{
		// Token: 0x06002B80 RID: 11136 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline ct_Trendline = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline();
			ct_Trendline.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "name")
				{
					ct_Trendline.name = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Trendline.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trendlineType")
				{
					ct_Trendline.trendlineType = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_Trendline.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "period")
				{
					ct_Trendline.period = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "forward")
				{
					ct_Trendline.forward = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "backward")
				{
					ct_Trendline.backward = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "intercept")
				{
					ct_Trendline.intercept = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dispRSqr")
				{
					ct_Trendline.dispRSqr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dispEq")
				{
					ct_Trendline.dispEq = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "trendlineLbl")
				{
					ct_Trendline.trendlineLbl = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Trendline.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Trendline;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0006D4DC File Offset: 0x0006B6DC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.name != null)
			{
				sw.Write(string.Format("<name>{0}</name>", this.name));
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.trendlineType != null)
			{
				this.trendlineType.Write(sw, "trendlineType");
			}
			if (this.order != null)
			{
				this.order.Write(sw, "order");
			}
			if (this.period != null)
			{
				this.period.Write(sw, "period");
			}
			if (this.forward != null)
			{
				this.forward.Write(sw, "forward");
			}
			if (this.backward != null)
			{
				this.backward.Write(sw, "backward");
			}
			if (this.intercept != null)
			{
				this.intercept.Write(sw, "intercept");
			}
			if (this.dispRSqr != null)
			{
				this.dispRSqr.Write(sw, "dispRSqr");
			}
			if (this.dispEq != null)
			{
				this.dispEq.Write(sw, "dispEq");
			}
			if (this.trendlineLbl != null)
			{
				this.trendlineLbl.Write(sw, "trendlineLbl");
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x0006D680 File Offset: 0x0006B880
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x0006D688 File Offset: 0x0006B888
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x0006D691 File Offset: 0x0006B891
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0006D699 File Offset: 0x0006B899
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0006D6A2 File Offset: 0x0006B8A2
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0006D6AA File Offset: 0x0006B8AA
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType trendlineType
		{
			get
			{
				return this.trendlineTypeField;
			}
			set
			{
				this.trendlineTypeField = value;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0006D6B3 File Offset: 0x0006B8B3
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0006D6BB File Offset: 0x0006B8BB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0006D6C4 File Offset: 0x0006B8C4
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x0006D6CC File Offset: 0x0006B8CC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period period
		{
			get
			{
				return this.periodField;
			}
			set
			{
				this.periodField = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x0006D6D5 File Offset: 0x0006B8D5
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x0006D6DD File Offset: 0x0006B8DD
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double forward
		{
			get
			{
				return this.forwardField;
			}
			set
			{
				this.forwardField = value;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x0006D6E6 File Offset: 0x0006B8E6
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0006D6EE File Offset: 0x0006B8EE
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double backward
		{
			get
			{
				return this.backwardField;
			}
			set
			{
				this.backwardField = value;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x0006D6F7 File Offset: 0x0006B8F7
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x0006D6FF File Offset: 0x0006B8FF
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double intercept
		{
			get
			{
				return this.interceptField;
			}
			set
			{
				this.interceptField = value;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0006D708 File Offset: 0x0006B908
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0006D710 File Offset: 0x0006B910
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean dispRSqr
		{
			get
			{
				return this.dispRSqrField;
			}
			set
			{
				this.dispRSqrField = value;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x0006D719 File Offset: 0x0006B919
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0006D721 File Offset: 0x0006B921
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean dispEq
		{
			get
			{
				return this.dispEqField;
			}
			set
			{
				this.dispEqField = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x0006D72A File Offset: 0x0006B92A
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x0006D732 File Offset: 0x0006B932
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl trendlineLbl
		{
			get
			{
				return this.trendlineLblField;
			}
			set
			{
				this.trendlineLblField = value;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x0006D73B File Offset: 0x0006B93B
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x0006D743 File Offset: 0x0006B943
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
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

		// Token: 0x04001ED0 RID: 7888
		private string nameField;

		// Token: 0x04001ED1 RID: 7889
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001ED2 RID: 7890
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType trendlineTypeField;

		// Token: 0x04001ED3 RID: 7891
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Order orderField;

		// Token: 0x04001ED4 RID: 7892
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Period periodField;

		// Token: 0x04001ED5 RID: 7893
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double forwardField;

		// Token: 0x04001ED6 RID: 7894
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double backwardField;

		// Token: 0x04001ED7 RID: 7895
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double interceptField;

		// Token: 0x04001ED8 RID: 7896
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean dispRSqrField;

		// Token: 0x04001ED9 RID: 7897
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean dispEqField;

		// Token: 0x04001EDA RID: 7898
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl trendlineLblField;

		// Token: 0x04001EDB RID: 7899
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
