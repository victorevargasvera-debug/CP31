using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065E RID: 1630
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EqArr
	{
		// Token: 0x060045F2 RID: 17906 RVA: 0x000A7D04 File Offset: 0x000A5F04
		public static global::NPOI.OpenXmlFormats.Shared.CT_EqArr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_EqArr ct_EqArr = new global::NPOI.OpenXmlFormats.Shared.CT_EqArr();
			ct_EqArr.e = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "eqArrPr")
				{
					ct_EqArr.eqArrPr = global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_EqArr.e.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_EqArr;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x000A7DB4 File Offset: 0x000A5FB4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.eqArrPr != null)
			{
				this.eqArrPr.Write(sw, "eqArrPr");
			}
			if (this.e != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Shared.CT_OMathArg ct_OMathArg in this.e)
				{
					ct_OMathArg.Write(sw, "e");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x000A7E58 File Offset: 0x000A6058
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x000A7E60 File Offset: 0x000A6060
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr eqArrPr
		{
			get
			{
				return this.eqArrPrField;
			}
			set
			{
				this.eqArrPrField = value;
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x000A7E69 File Offset: 0x000A6069
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x000A7E71 File Offset: 0x000A6071
		[global::System.Xml.Serialization.XmlElement("e", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> e
		{
			get
			{
				return this.eField;
			}
			set
			{
				this.eField = value;
			}
		}

		// Token: 0x04002BF2 RID: 11250
		private global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr eqArrPrField;

		// Token: 0x04002BF3 RID: 11251
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> eField;
	}
}
