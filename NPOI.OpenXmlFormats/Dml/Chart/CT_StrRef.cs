using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000415 RID: 1045
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StrRef
	{
		// Token: 0x060029D1 RID: 10705 RVA: 0x00069288 File Offset: 0x00067488
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef ct_StrRef = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrRef();
			ct_StrRef.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "f")
				{
					ct_StrRef.f = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "strCache")
				{
					ct_StrRef.strCache = global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_StrRef.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_StrRef;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00069358 File Offset: 0x00067558
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.f != null)
			{
				sw.Write(string.Format("<c:f>{0}</c:f>", this.f));
			}
			if (this.strCache != null)
			{
				this.strCache.Write(sw, "strCache");
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

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0006941C File Offset: 0x0006761C
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x00069424 File Offset: 0x00067624
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string f
		{
			get
			{
				return this.fField;
			}
			set
			{
				this.fField = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x0006942D File Offset: 0x0006762D
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00069435 File Offset: 0x00067635
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData strCache
		{
			get
			{
				return this.strCacheField;
			}
			set
			{
				this.strCacheField = value;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0006943E File Offset: 0x0006763E
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00069446 File Offset: 0x00067646
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

		// Token: 0x060029D9 RID: 10713 RVA: 0x0006944F File Offset: 0x0006764F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData AddNewStrCache()
		{
			this.strCache = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData();
			return this.strCache;
		}

		// Token: 0x04001DFD RID: 7677
		private string fField;

		// Token: 0x04001DFE RID: 7678
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_StrData strCacheField;

		// Token: 0x04001DFF RID: 7679
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
