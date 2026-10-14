using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200040C RID: 1036
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Scaling
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x0006888C File Offset: 0x00066A8C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling ct_Scaling = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling();
			ct_Scaling.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "logBase")
				{
					ct_Scaling.logBase = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "orientation")
				{
					ct_Scaling.orientation = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "max")
				{
					ct_Scaling.max = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "min")
				{
					ct_Scaling.min = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Scaling.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Scaling;
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000689A8 File Offset: 0x00066BA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}>", nodeName));
			if (this.logBase != null)
			{
				this.logBase.Write(sw, "logBase");
			}
			if (this.orientation != null)
			{
				this.orientation.Write(sw, "orientation");
			}
			if (this.max != null)
			{
				this.max.Write(sw, "max");
			}
			if (this.min != null)
			{
				this.min.Write(sw, "min");
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

		// Token: 0x0600298E RID: 10638 RVA: 0x00068A8C File Offset: 0x00066C8C
		public bool IsSetOrientation()
		{
			return this.orientationField != null;
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00068A97 File Offset: 0x00066C97
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation AddNewOrientation()
		{
			this.orientationField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation();
			return this.orientationField;
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00068AAA File Offset: 0x00066CAA
		public bool IsSetLogBase()
		{
			return this.logBaseField != null;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00068AB5 File Offset: 0x00066CB5
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase AddNewLogBase()
		{
			this.logBaseField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase();
			return this.logBaseField;
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00068AC8 File Offset: 0x00066CC8
		public bool IsSetMax()
		{
			return this.maxField != null;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00068AD3 File Offset: 0x00066CD3
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewMax()
		{
			this.maxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			return this.maxField;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00068AE6 File Offset: 0x00066CE6
		public bool IsSetMin()
		{
			return this.minField != null;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00068AF1 File Offset: 0x00066CF1
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double AddNewMin()
		{
			this.minField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double();
			return this.minField;
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00068B04 File Offset: 0x00066D04
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x00068B0C File Offset: 0x00066D0C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase logBase
		{
			get
			{
				return this.logBaseField;
			}
			set
			{
				this.logBaseField = value;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x00068B15 File Offset: 0x00066D15
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x00068B1D File Offset: 0x00066D1D
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation orientation
		{
			get
			{
				return this.orientationField;
			}
			set
			{
				this.orientationField = value;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x00068B26 File Offset: 0x00066D26
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x00068B2E File Offset: 0x00066D2E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x00068B37 File Offset: 0x00066D37
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x00068B3F File Offset: 0x00066D3F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double min
		{
			get
			{
				return this.minField;
			}
			set
			{
				this.minField = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x00068B48 File Offset: 0x00066D48
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x00068B50 File Offset: 0x00066D50
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x04001DE4 RID: 7652
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase logBaseField;

		// Token: 0x04001DE5 RID: 7653
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation orientationField;

		// Token: 0x04001DE6 RID: 7654
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double maxField;

		// Token: 0x04001DE7 RID: 7655
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double minField;

		// Token: 0x04001DE8 RID: 7656
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
