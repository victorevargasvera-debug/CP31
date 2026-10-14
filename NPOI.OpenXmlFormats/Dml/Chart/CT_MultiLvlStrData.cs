using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000450 RID: 1104
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MultiLvlStrData
	{
		// Token: 0x06002C1F RID: 11295 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData ct_MultiLvlStrData = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData();
			ct_MultiLvlStrData.lvl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal>();
			ct_MultiLvlStrData.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ptCount")
				{
					ct_MultiLvlStrData.ptCount = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl")
				{
					ct_MultiLvlStrData.lvl.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_MultiLvlStrData.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MultiLvlStrData;
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x0006EEA0 File Offset: 0x0006D0A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.ptCount != null)
			{
				this.ptCount.Write(sw, "ptCount");
			}
			if (this.lvl != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal ct_StrVal in this.lvl)
				{
					ct_StrVal.Write(sw, "lvl");
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

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x0006EF94 File Offset: 0x0006D194
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x0006EF9C File Offset: 0x0006D19C
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

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x0006EFA5 File Offset: 0x0006D1A5
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x0006EFAD File Offset: 0x0006D1AD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> lvl
		{
			get
			{
				return this.lvlField;
			}
			set
			{
				this.lvlField = value;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x0006EFB6 File Offset: 0x0006D1B6
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x0006EFBE File Offset: 0x0006D1BE
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

		// Token: 0x04001F19 RID: 7961
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ptCountField;

		// Token: 0x04001F1A RID: 7962
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrVal> lvlField;

		// Token: 0x04001F1B RID: 7963
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
