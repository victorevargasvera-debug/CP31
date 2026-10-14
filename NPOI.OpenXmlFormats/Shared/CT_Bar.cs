using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000656 RID: 1622
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Bar
	{
		// Token: 0x06004594 RID: 17812 RVA: 0x000A6D50 File Offset: 0x000A4F50
		public static global::NPOI.OpenXmlFormats.Shared.CT_Bar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Bar ct_Bar = new global::NPOI.OpenXmlFormats.Shared.CT_Bar();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "barPr")
				{
					ct_Bar.barPr = global::NPOI.OpenXmlFormats.Shared.CT_BarPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Bar.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Bar;
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.barPr != null)
			{
				this.barPr.Write(sw, "barPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000A6E5C File Offset: 0x000A505C
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x000A6E64 File Offset: 0x000A5064
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_BarPr barPr
		{
			get
			{
				return this.barPrField;
			}
			set
			{
				this.barPrField = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x000A6E6D File Offset: 0x000A506D
		// (set) Token: 0x06004599 RID: 17817 RVA: 0x000A6E75 File Offset: 0x000A5075
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg e
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

		// Token: 0x04002BCF RID: 11215
		private global::NPOI.OpenXmlFormats.Shared.CT_BarPr barPrField;

		// Token: 0x04002BD0 RID: 11216
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
