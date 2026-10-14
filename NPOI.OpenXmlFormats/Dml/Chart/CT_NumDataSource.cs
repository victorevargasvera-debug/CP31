using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200044A RID: 1098
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumDataSource
	{
		// Token: 0x06002BDC RID: 11228 RVA: 0x0006E24C File Offset: 0x0006C44C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource ct_NumDataSource = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "numLit")
				{
					ct_NumDataSource.numLit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRef")
				{
					ct_NumDataSource.numRef = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NumDataSource;
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0006E2EC File Offset: 0x0006C4EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.numLit != null)
			{
				this.numLit.Write(sw, "numLit");
			}
			if (this.numRef != null)
			{
				this.numRef.Write(sw, "numRef");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0006E358 File Offset: 0x0006C558
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef AddNewNumRef()
		{
			this.numRefField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef();
			return this.numRefField;
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x0006E36B File Offset: 0x0006C56B
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x0006E373 File Offset: 0x0006C573
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numLit
		{
			get
			{
				return this.numLitField;
			}
			set
			{
				this.numLitField = value;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x0006E37C File Offset: 0x0006C57C
		// (set) Token: 0x06002BE2 RID: 11234 RVA: 0x0006E384 File Offset: 0x0006C584
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef numRef
		{
			get
			{
				return this.numRefField;
			}
			set
			{
				this.numRefField = value;
			}
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x0006E38D File Offset: 0x0006C58D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData AddNewNumLit()
		{
			this.numLit = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData();
			return this.numLit;
		}

		// Token: 0x04001F05 RID: 7941
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumData numLitField;

		// Token: 0x04001F06 RID: 7942
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumRef numRefField;
	}
}
