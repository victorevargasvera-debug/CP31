using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044B RID: 1099
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumData
	{
		// Token: 0x06002BE5 RID: 11237 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData ct_NumData = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData();
			ct_NumData.pt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal>();
			ct_NumData.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "formatCode")
				{
					ct_NumData.formatCode = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "ptCount")
				{
					ct_NumData.ptCount = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pt")
				{
					ct_NumData.pt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NumData.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_NumData;
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.formatCode != null)
			{
				sw.Write(string.Format("<c:formatCode>{0}</c:formatCode>", this.formatCode));
			}
			if (this.ptCount != null)
			{
				this.ptCount.Write(sw, "ptCount");
			}
			if (this.pt != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal ct_NumVal in this.pt)
				{
					ct_NumVal.Write(sw, "pt");
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

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0006E5B8 File Offset: 0x0006C7B8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal AddNewPt()
		{
			if (this.ptField == null)
			{
				this.ptField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal ct_NumVal = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal();
			this.ptField.Add(ct_NumVal);
			return ct_NumVal;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0006E5EB File Offset: 0x0006C7EB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewPtCount()
		{
			this.ptCountField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.ptCountField;
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x0006E5FE File Offset: 0x0006C7FE
		// (set) Token: 0x06002BEB RID: 11243 RVA: 0x0006E606 File Offset: 0x0006C806
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string formatCode
		{
			get
			{
				return this.formatCodeField;
			}
			set
			{
				this.formatCodeField = value;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x0006E60F File Offset: 0x0006C80F
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x0006E617 File Offset: 0x0006C817
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x0006E620 File Offset: 0x0006C820
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x0006E628 File Offset: 0x0006C828
		[global::System.Xml.Serialization.XmlElement("pt", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal> pt
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x0006E631 File Offset: 0x0006C831
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x0006E639 File Offset: 0x0006C839
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

		// Token: 0x04001F07 RID: 7943
		private string formatCodeField;

		// Token: 0x04001F08 RID: 7944
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ptCountField;

		// Token: 0x04001F09 RID: 7945
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumVal> ptField;

		// Token: 0x04001F0A RID: 7946
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
