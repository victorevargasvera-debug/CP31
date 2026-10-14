using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E0 RID: 736
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GeomGuideList
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0004E44B File Offset: 0x0004C64B
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0004E453 File Offset: 0x0004C653
		[global::System.Xml.Serialization.XmlElement("gd", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide> gd
		{
			get
			{
				return this.gdField;
			}
			set
			{
				this.gdField = value;
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0004E45C File Offset: 0x0004C65C
		internal static global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList ct_GeomGuideList = new global::NPOI.OpenXmlFormats.Dml.CT_GeomGuideList();
			ct_GeomGuideList.gdField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide>();
			if (node.ChildNodes != null)
			{
				foreach (object obj in node.ChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
					if (xmlNode.LocalName == "gd")
					{
						ct_GeomGuideList.gdField.Add(global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide.Parse(xmlNode, namespaceManager));
					}
				}
			}
			return ct_GeomGuideList;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0004E4EC File Offset: 0x0004C6EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write("<a:{0}", nodeName);
			if (this.gdField == null || this.gdField.Count == 0)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			foreach (global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide ct_GeomGuide in this.gdField)
			{
				ct_GeomGuide.Write(sw, "gd");
			}
			sw.Write("</a:{0}>", nodeName);
		}

		// Token: 0x04001737 RID: 5943
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_GeomGuide> gdField;
	}
}
