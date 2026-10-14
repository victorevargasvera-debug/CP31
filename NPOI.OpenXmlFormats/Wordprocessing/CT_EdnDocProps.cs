using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000129 RID: 297
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EdnDocProps : global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnProps
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x0001B258 File Offset: 0x00019458
		public new static global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps ct_EdnDocProps = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnDocProps();
			ct_EdnDocProps.endnote = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_EdnDocProps.pos = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_EdnDocProps.numFmt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numStart")
				{
					ct_EdnDocProps.numStart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numRestart")
				{
					ct_EdnDocProps.numRestart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumRestart.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endnote")
				{
					ct_EdnDocProps.endnote.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_EdnDocProps;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0001B374 File Offset: 0x00019574
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
			if (this.endnote != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef ct_FtnEdnSepRef in this.endnote)
				{
					ct_FtnEdnSepRef.Write(sw, "endnote");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0001B46C File Offset: 0x0001966C
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x0001B474 File Offset: 0x00019674
		[global::System.Xml.Serialization.XmlElement("endnote", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef> endnote
		{
			get
			{
				return this.endnoteField;
			}
			set
			{
				this.endnoteField = value;
			}
		}

		// Token: 0x04000733 RID: 1843
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnSepRef> endnoteField;
	}
}
