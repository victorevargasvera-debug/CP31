using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002EF RID: 751
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DList
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0004ED21 File Offset: 0x0004CF21
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0004ED29 File Offset: 0x0004CF29
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Path2D> path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0004ED34 File Offset: 0x0004CF34
		internal static global::NPOI.OpenXmlFormats.Dml.CT_Path2DList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_Path2DList ct_Path2DList = new global::NPOI.OpenXmlFormats.Dml.CT_Path2DList();
			ct_Path2DList.path = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Path2D>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "path")
				{
					ct_Path2DList.pathField.Add(global::NPOI.OpenXmlFormats.Dml.CT_Path2D.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Path2DList;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0004EDBC File Offset: 0x0004CFBC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write("<a:{0}>", nodeName);
			if (this.pathField != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_Path2D ct_Path2D in this.pathField)
				{
					ct_Path2D.Write(sw, "path");
				}
			}
			sw.Write("</a:{0}>", nodeName);
		}

		// Token: 0x04001769 RID: 5993
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_Path2D> pathField;
	}
}
