using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044D RID: 1101
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumRef
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x0006E7B8 File Offset: 0x0006C9B8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef ct_NumRef = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef();
			ct_NumRef.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "f")
				{
					ct_NumRef.f = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "numCache")
				{
					ct_NumRef.numCache = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NumRef.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_NumRef;
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0006E888 File Offset: 0x0006CA88
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.f != null)
			{
				sw.Write(string.Format("<c:f>{0}</c:f>", this.f));
			}
			if (this.numCache != null)
			{
				this.numCache.Write(sw, "numCache");
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

		// Token: 0x06002BFE RID: 11262 RVA: 0x0006E94C File Offset: 0x0006CB4C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData AddNewNumCache()
		{
			this.numCacheField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData();
			return this.numCacheField;
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x0006E95F File Offset: 0x0006CB5F
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0006E967 File Offset: 0x0006CB67
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

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x0006E970 File Offset: 0x0006CB70
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x0006E978 File Offset: 0x0006CB78
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numCache
		{
			get
			{
				return this.numCacheField;
			}
			set
			{
				this.numCacheField = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x0006E981 File Offset: 0x0006CB81
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x0006E989 File Offset: 0x0006CB89
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

		// Token: 0x04001F0E RID: 7950
		private string fField;

		// Token: 0x04001F0F RID: 7951
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numCacheField;

		// Token: 0x04001F10 RID: 7952
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
