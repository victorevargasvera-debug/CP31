using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000403 RID: 1027
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Layout
	{
		// Token: 0x06002911 RID: 10513 RVA: 0x000675E0 File Offset: 0x000657E0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout ct_Layout = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout();
			ct_Layout.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "manualLayout")
				{
					ct_Layout.manualLayout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Layout.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Layout;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00067690 File Offset: 0x00065890
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.manualLayout != null)
			{
				this.manualLayout.Write(sw, "manualLayout");
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

		// Token: 0x06002913 RID: 10515 RVA: 0x00067734 File Offset: 0x00065934
		public bool IsSetManualLayout()
		{
			return this.manualLayout != null;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0006773F File Offset: 0x0006593F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout AddNewManualLayout()
		{
			this.manualLayoutField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout();
			return this.manualLayoutField;
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00067752 File Offset: 0x00065952
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x0006775A File Offset: 0x0006595A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout manualLayout
		{
			get
			{
				return this.manualLayoutField;
			}
			set
			{
				this.manualLayoutField = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x00067763 File Offset: 0x00065963
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x0006776B File Offset: 0x0006596B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x04001DB5 RID: 7605
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ManualLayout manualLayoutField;

		// Token: 0x04001DB6 RID: 7606
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
