using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000124 RID: 292
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FtnDocProps : global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnProps
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x0001AD40 File Offset: 0x00018F40
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps ct_FtnDocProps = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnDocProps();
			ct_FtnDocProps.footnote = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_FtnDocProps.pos = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_FtnDocProps.numFmt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numStart")
				{
					ct_FtnDocProps.numStart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRestart")
				{
					ct_FtnDocProps.numRestart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "footnote")
				{
					ct_FtnDocProps.footnote.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FtnDocProps;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001AE5C File Offset: 0x0001905C
		internal new void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (base.pos != null)
			{
				base.pos.Write(sw, "pos");
			}
			if (base.numFmt != null)
			{
				base.numFmt.Write(sw, "numFmt");
			}
			if (base.numStart != null)
			{
				base.numStart.Write(sw, "numStart");
			}
			if (base.numRestart != null)
			{
				base.numRestart.Write(sw, "numRestart");
			}
			if (this.footnote != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef ct_FtnEdnSepRef in this.footnote)
				{
					ct_FtnEdnSepRef.Write(sw, "footnote");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0001AF4C File Offset: 0x0001914C
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0001AF54 File Offset: 0x00019154
		[global::System.Xml.Serialization.XmlElement("footnote", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef> footnote
		{
			get
			{
				return this.footnoteField;
			}
			set
			{
				this.footnoteField = value;
			}
		}

		// Token: 0x04000729 RID: 1833
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef> footnoteField;
	}
}
