using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200011C RID: 284
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FtnProps
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x000197D8 File Offset: 0x000179D8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps ct_FtnProps = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_FtnProps.pos = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_FtnProps.numFmt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numStart")
				{
					ct_FtnProps.numStart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRestart")
				{
					ct_FtnProps.numRestart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FtnProps;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000198C0 File Offset: 0x00017AC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.pos != null)
			{
				this.pos.Write(sw, "pos");
			}
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
			}
			if (this.numStart != null)
			{
				this.numStart.Write(sw, "numStart");
			}
			if (this.numRestart != null)
			{
				this.numRestart.Write(sw, "numRestart");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0001995E File Offset: 0x00017B5E
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00019966 File Offset: 0x00017B66
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0001996F File Offset: 0x00017B6F
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00019977 File Offset: 0x00017B77
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00019980 File Offset: 0x00017B80
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00019988 File Offset: 0x00017B88
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numStart
		{
			get
			{
				return this.numStartField;
			}
			set
			{
				this.numStartField = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00019991 File Offset: 0x00017B91
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00019999 File Offset: 0x00017B99
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart numRestart
		{
			get
			{
				return this.numRestartField;
			}
			set
			{
				this.numRestartField = value;
			}
		}

		// Token: 0x040006F4 RID: 1780
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos posField;

		// Token: 0x040006F5 RID: 1781
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt numFmtField;

		// Token: 0x040006F6 RID: 1782
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numStartField;

		// Token: 0x040006F7 RID: 1783
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart numRestartField;
	}
}
