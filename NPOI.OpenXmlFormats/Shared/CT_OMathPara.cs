using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067E RID: 1662
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMathPara
	{
		// Token: 0x060046F6 RID: 18166 RVA: 0x000AA86C File Offset: 0x000A8A6C
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMathPara Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMathPara ct_OMathPara = new global::NPOI.OpenXmlFormats.Shared.CT_OMathPara();
			ct_OMathPara.oMath = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMath>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "oMathParaPr")
				{
					ct_OMathPara.oMathParaPr = global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_OMathPara.oMath.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMath.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_OMathPara;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x000AA91C File Offset: 0x000A8B1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.oMathParaPr != null)
			{
				this.oMathParaPr.Write(sw, "oMathParaPr");
			}
			if (this.oMath != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Shared.CT_OMath ct_OMath in this.oMath)
				{
					ct_OMath.Write(sw, "oMath");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x000AA9C0 File Offset: 0x000A8BC0
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x000AA9C8 File Offset: 0x000A8BC8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr oMathParaPr
		{
			get
			{
				return this.oMathParaPrField;
			}
			set
			{
				this.oMathParaPrField = value;
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x000AA9D1 File Offset: 0x000A8BD1
		// (set) Token: 0x060046FB RID: 18171 RVA: 0x000AA9D9 File Offset: 0x000A8BD9
		[global::System.Xml.Serialization.XmlElement("oMath", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMath> oMath
		{
			get
			{
				return this.oMathField;
			}
			set
			{
				this.oMathField = value;
			}
		}

		// Token: 0x04002C46 RID: 11334
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr oMathParaPrField;

		// Token: 0x04002C47 RID: 11335
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMath> oMathField;
	}
}
