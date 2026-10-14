using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E6 RID: 742
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ConnectionSiteList
	{
		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0004E8DB File Offset: 0x0004CADB
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0004E8E3 File Offset: 0x0004CAE3
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite> cxn
		{
			get
			{
				return this.cxnField;
			}
			set
			{
				this.cxnField = value;
			}
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		internal static global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList ct_ConnectionSiteList = new global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSiteList();
			ct_ConnectionSiteList.cxnField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "cxn")
				{
					ct_ConnectionSiteList.cxnField.Add(global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ConnectionSiteList;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0004E974 File Offset: 0x0004CB74
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write("<a:{0}>", nodeName);
			if (this.cxnField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite ct_ConnectionSite in this.cxnField)
				{
					ct_ConnectionSite.Write(sw, "cxn");
				}
			}
			sw.Write("</a:{0}>", nodeName);
		}

		// Token: 0x0400174D RID: 5965
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_ConnectionSite> cxnField;
	}
}
