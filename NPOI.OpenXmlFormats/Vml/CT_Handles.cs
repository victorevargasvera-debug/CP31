using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D7 RID: 471
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public class CT_Handles
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0003C56A File Offset: 0x0003A76A
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x0003C572 File Offset: 0x0003A772
		[global::System.Xml.Serialization.XmlElement("h")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_H> h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x0003C57B File Offset: 0x0003A77B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hSpecified
		{
			get
			{
				return this.hField != null;
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0003C588 File Offset: 0x0003A788
		public global::NPOI.OpenXmlFormats.Vml.CT_H AddNewH()
		{
			if (this.hField == null)
			{
				this.hField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_H>();
			}
			global::NPOI.OpenXmlFormats.Vml.CT_H ct_H = new global::NPOI.OpenXmlFormats.Vml.CT_H();
			this.hField.Add(ct_H);
			return ct_H;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0003C5BC File Offset: 0x0003A7BC
		public static global::NPOI.OpenXmlFormats.Vml.CT_Handles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Handles ct_Handles = new global::NPOI.OpenXmlFormats.Vml.CT_Handles();
			ct_Handles.h = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_H>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "h")
				{
					ct_Handles.h.Add(global::NPOI.OpenXmlFormats.Vml.CT_H.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Handles;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0003C64C File Offset: 0x0003A84C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			sw.Write(">");
			if (this.h != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Vml.CT_H ct_H in this.h)
				{
					ct_H.Write(sw, "h");
				}
			}
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x04000E10 RID: 3600
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_H> hField;
	}
}
