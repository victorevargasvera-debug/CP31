using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000416 RID: 1046
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StrData
	{
		// Token: 0x060029DB RID: 10715 RVA: 0x00069464 File Offset: 0x00067664
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData ct_StrData = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData();
			ct_StrData.pt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal>();
			ct_StrData.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ptCount")
				{
					ct_StrData.ptCount = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pt")
				{
					ct_StrData.pt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_StrData.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_StrData;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00069544 File Offset: 0x00067744
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.ptCount != null)
			{
				this.ptCount.Write(sw, "ptCount");
			}
			if (this.pt != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal ct_StrVal in this.pt)
				{
					ct_StrVal.Write(sw, "pt");
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

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x00069638 File Offset: 0x00067838
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00069640 File Offset: 0x00067840
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ptCount
		{
			get
			{
				return this.ptCountField;
			}
			set
			{
				this.ptCountField = value;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x00069649 File Offset: 0x00067849
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x00069651 File Offset: 0x00067851
		[global::System.Xml.Serialization.XmlElement("pt", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> pt
		{
			get
			{
				return this.ptField;
			}
			set
			{
				this.ptField = value;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0006965A File Offset: 0x0006785A
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x00069662 File Offset: 0x00067862
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

		// Token: 0x060029E3 RID: 10723 RVA: 0x0006966B File Offset: 0x0006786B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewPtCount()
		{
			this.ptCount = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.ptCount;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00069680 File Offset: 0x00067880
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal AddNewPt()
		{
			if (this.pt == null)
			{
				this.pt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal ct_StrVal = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal();
			this.pt.Add(ct_StrVal);
			return ct_StrVal;
		}

		// Token: 0x04001E00 RID: 7680
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ptCountField;

		// Token: 0x04001E01 RID: 7681
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> ptField;

		// Token: 0x04001E02 RID: 7682
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
