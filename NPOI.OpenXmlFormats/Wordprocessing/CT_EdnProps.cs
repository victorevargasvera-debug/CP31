using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000126 RID: 294
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public class CT_EdnProps
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x0001AFC4 File Offset: 0x000191C4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps ct_EdnProps = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_EdnProps.pos = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_EdnProps.numFmt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numStart")
				{
					ct_EdnProps.numStart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRestart")
				{
					ct_EdnProps.numRestart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_EdnProps;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0001B0AC File Offset: 0x000192AC
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0001B14A File Offset: 0x0001934A
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0001B152 File Offset: 0x00019352
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos pos
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0001B15B File Offset: 0x0001935B
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0001B163 File Offset: 0x00019363
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0001B16C File Offset: 0x0001936C
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0001B174 File Offset: 0x00019374
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0001B17D File Offset: 0x0001937D
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0001B185 File Offset: 0x00019385
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

		// Token: 0x0400072B RID: 1835
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos posField;

		// Token: 0x0400072C RID: 1836
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt numFmtField;

		// Token: 0x0400072D RID: 1837
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber numStartField;

		// Token: 0x0400072E RID: 1838
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart numRestartField;
	}
}
