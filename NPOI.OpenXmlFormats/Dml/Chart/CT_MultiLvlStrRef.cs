using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044F RID: 1103
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MultiLvlStrRef
	{
		// Token: 0x06002C16 RID: 11286 RVA: 0x0006EBF8 File Offset: 0x0006CDF8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef ct_MultiLvlStrRef = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrRef();
			ct_MultiLvlStrRef.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "f")
				{
					ct_MultiLvlStrRef.f = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "multiLvlStrCache")
				{
					ct_MultiLvlStrRef.multiLvlStrCache = global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_MultiLvlStrRef.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MultiLvlStrRef;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.f != null)
			{
				sw.Write(string.Format("<c:f>{0}</c:f>", this.f));
			}
			if (this.multiLvlStrCache != null)
			{
				this.multiLvlStrCache.Write(sw, "multiLvlStrCache");
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

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0006ED8C File Offset: 0x0006CF8C
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x0006ED94 File Offset: 0x0006CF94
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

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0006ED9D File Offset: 0x0006CF9D
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x0006EDA5 File Offset: 0x0006CFA5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData multiLvlStrCache
		{
			get
			{
				return this.multiLvlStrCacheField;
			}
			set
			{
				this.multiLvlStrCacheField = value;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x0006EDAE File Offset: 0x0006CFAE
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x0006EDB6 File Offset: 0x0006CFB6
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

		// Token: 0x04001F16 RID: 7958
		private string fField;

		// Token: 0x04001F17 RID: 7959
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_MultiLvlStrData multiLvlStrCacheField;

		// Token: 0x04001F18 RID: 7960
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
