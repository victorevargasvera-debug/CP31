using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000404 RID: 1028
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ManualLayout
	{
		// Token: 0x06002919 RID: 10521 RVA: 0x00067774 File Offset: 0x00065974
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout ct_ManualLayout = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout();
			ct_ManualLayout.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "layoutTarget")
				{
					ct_ManualLayout.layoutTarget = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "xMode")
				{
					ct_ManualLayout.xMode = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "yMode")
				{
					ct_ManualLayout.yMode = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wMode")
				{
					ct_ManualLayout.wMode = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hMode")
				{
					ct_ManualLayout.hMode = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_ManualLayout.x = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "y")
				{
					ct_ManualLayout.y = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "w")
				{
					ct_ManualLayout.w = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "h")
				{
					ct_ManualLayout.h = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ManualLayout.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ManualLayout;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00067950 File Offset: 0x00065B50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.layoutTarget != null)
			{
				this.layoutTarget.Write(sw, "layoutTarget");
			}
			if (this.xMode != null)
			{
				this.xMode.Write(sw, "xMode");
			}
			if (this.yMode != null)
			{
				this.yMode.Write(sw, "yMode");
			}
			if (this.wMode != null)
			{
				this.wMode.Write(sw, "wMode");
			}
			if (this.hMode != null)
			{
				this.hMode.Write(sw, "hMode");
			}
			if (this.x != null)
			{
				this.x.Write(sw, "x");
			}
			if (this.y != null)
			{
				this.y.Write(sw, "y");
			}
			if (this.w != null)
			{
				this.w.Write(sw, "w");
			}
			if (this.h != null)
			{
				this.h.Write(sw, "h");
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

		// Token: 0x0600291C RID: 10524 RVA: 0x00067ABC File Offset: 0x00065CBC
		public bool IsSetLayoutTarget()
		{
			return this.layoutTargetField != null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00067AC7 File Offset: 0x00065CC7
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget AddNewLayoutTarget()
		{
			this.layoutTargetField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget();
			return this.layoutTargetField;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00067ADA File Offset: 0x00065CDA
		public bool IsSetY()
		{
			return this.yField != null;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00067AE5 File Offset: 0x00065CE5
		public bool IsSetX()
		{
			return this.xField != null;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00067AF0 File Offset: 0x00065CF0
		public bool IsSetW()
		{
			return this.wField != null;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00067AFB File Offset: 0x00065CFB
		public bool IsSetH()
		{
			return this.hField != null;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00067B06 File Offset: 0x00065D06
		public bool IsSetXMode()
		{
			return this.xModeField != null;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00067B11 File Offset: 0x00065D11
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode AddNewXMode()
		{
			this.xModeField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode();
			return this.xModeField;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00067B24 File Offset: 0x00065D24
		public bool IsSetYMode()
		{
			return this.yModeField != null;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00067B2F File Offset: 0x00065D2F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode AddNewYMode()
		{
			this.yModeField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode();
			return this.yModeField;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00067B42 File Offset: 0x00065D42
		public bool IsSetWMode()
		{
			return this.wModeField != null;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00067B4D File Offset: 0x00065D4D
		public bool IsSetHMode()
		{
			return this.hModeField != null;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00067B58 File Offset: 0x00065D58
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode AddNewHMode()
		{
			if (this.hModeField == null)
			{
				this.hModeField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode();
			}
			return this.hModeField;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00067B73 File Offset: 0x00065D73
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode AddNewWMode()
		{
			if (this.wModeField == null)
			{
				this.wModeField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode();
			}
			return this.wModeField;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00067B8E File Offset: 0x00065D8E
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewW()
		{
			if (this.wField == null)
			{
				this.wField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			}
			return this.wField;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00067BA9 File Offset: 0x00065DA9
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewH()
		{
			if (this.hField == null)
			{
				this.hField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			}
			return this.hField;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00067BC4 File Offset: 0x00065DC4
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewY()
		{
			if (this.yField == null)
			{
				this.yField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			}
			return this.yField;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00067BDF File Offset: 0x00065DDF
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewX()
		{
			if (this.xField == null)
			{
				this.xField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			}
			return this.xField;
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x00067BFA File Offset: 0x00065DFA
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x00067C02 File Offset: 0x00065E02
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget layoutTarget
		{
			get
			{
				return this.layoutTargetField;
			}
			set
			{
				this.layoutTargetField = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00067C0B File Offset: 0x00065E0B
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x00067C13 File Offset: 0x00065E13
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode xMode
		{
			get
			{
				return this.xModeField;
			}
			set
			{
				this.xModeField = value;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x00067C1C File Offset: 0x00065E1C
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x00067C24 File Offset: 0x00065E24
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode yMode
		{
			get
			{
				return this.yModeField;
			}
			set
			{
				this.yModeField = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x00067C2D File Offset: 0x00065E2D
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x00067C35 File Offset: 0x00065E35
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode wMode
		{
			get
			{
				return this.wModeField;
			}
			set
			{
				this.wModeField = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00067C3E File Offset: 0x00065E3E
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x00067C46 File Offset: 0x00065E46
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode hMode
		{
			get
			{
				return this.hModeField;
			}
			set
			{
				this.hModeField = value;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00067C4F File Offset: 0x00065E4F
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00067C57 File Offset: 0x00065E57
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x00067C60 File Offset: 0x00065E60
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x00067C68 File Offset: 0x00065E68
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double y
		{
			get
			{
				return this.yField;
			}
			set
			{
				this.yField = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x00067C71 File Offset: 0x00065E71
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00067C79 File Offset: 0x00065E79
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00067C82 File Offset: 0x00065E82
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00067C8A File Offset: 0x00065E8A
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00067C93 File Offset: 0x00065E93
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x00067C9B File Offset: 0x00065E9B
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x04001DB7 RID: 7607
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget layoutTargetField;

		// Token: 0x04001DB8 RID: 7608
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode xModeField;

		// Token: 0x04001DB9 RID: 7609
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode yModeField;

		// Token: 0x04001DBA RID: 7610
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode wModeField;

		// Token: 0x04001DBB RID: 7611
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode hModeField;

		// Token: 0x04001DBC RID: 7612
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double xField;

		// Token: 0x04001DBD RID: 7613
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double yField;

		// Token: 0x04001DBE RID: 7614
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double wField;

		// Token: 0x04001DBF RID: 7615
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double hField;

		// Token: 0x04001DC0 RID: 7616
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
