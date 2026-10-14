using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000283 RID: 643
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineStyleList
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004834A File Offset: 0x0004654A
		public CT_LineStyleList()
		{
			this.lnField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_LineProperties>();
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00048360 File Offset: 0x00046560
		public static global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList ct_LineStyleList = new global::NPOI.OpenXmlFormats.Dml.CT_LineStyleList();
			ct_LineStyleList.ln = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_LineProperties>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj;
				ct_LineStyleList.ln.Add(global::NPOI.OpenXmlFormats.Dml.CT_LineProperties.Parse(node2, namespaceManager));
			}
			return ct_LineStyleList;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x000483DC File Offset: 0x000465DC
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x000483E4 File Offset: 0x000465E4
		[global::System.Xml.Serialization.XmlElement("ln", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_LineProperties> ln
		{
			get
			{
				return this.lnField;
			}
			set
			{
				this.lnField = value;
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000483F0 File Offset: 0x000465F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}>", nodeName));
			if (this.ln.Count > 0)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ct_LineProperties in this.ln)
				{
					ct_LineProperties.Write(sw, "ln");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x040013D3 RID: 5075
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_LineProperties> lnField;
	}
}
