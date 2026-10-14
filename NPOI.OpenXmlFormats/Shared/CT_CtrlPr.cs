using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064F RID: 1615
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CtrlPr
	{
		// Token: 0x0600455E RID: 17758 RVA: 0x000A5458 File Offset: 0x000A3658
		public static global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ct_CtrlPr = new global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_CtrlPr.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ins")
				{
					ct_CtrlPr.ins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_CtrlPr.del = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CtrlPr;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x000A5518 File Offset: 0x000A3718
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			if (this.ins != null)
			{
				this.ins.Write(sw, "ins");
			}
			if (this.del != null)
			{
				this.del.Write(sw, "del");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x000A559D File Offset: 0x000A379D
		// (set) Token: 0x06004561 RID: 17761 RVA: 0x000A55A5 File Offset: 0x000A37A5
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x000A55AE File Offset: 0x000A37AE
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x000A55B6 File Offset: 0x000A37B6
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Type = typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange), Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange ins
		{
			get
			{
				return this.insField;
			}
			set
			{
				this.insField = value;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x000A55BF File Offset: 0x000A37BF
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x000A55C7 File Offset: 0x000A37C7
		[global::System.Xml.Serialization.XmlElement(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", Type = typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange), Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange del
		{
			get
			{
				return this.delField;
			}
			set
			{
				this.delField = value;
			}
		}

		// Token: 0x04002B93 RID: 11155
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;

		// Token: 0x04002B94 RID: 11156
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange insField;

		// Token: 0x04002B95 RID: 11157
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange delField;
	}
}
