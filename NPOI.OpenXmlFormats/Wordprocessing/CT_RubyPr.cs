using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000134 RID: 308
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RubyPr
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x0001D0B8 File Offset: 0x0001B2B8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr ct_RubyPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rubyAlign")
				{
					ct_RubyPr.rubyAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hps")
				{
					ct_RubyPr.hps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hpsRaise")
				{
					ct_RubyPr.hpsRaise = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hpsBaseText")
				{
					ct_RubyPr.hpsBaseText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lid")
				{
					ct_RubyPr.lid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dirty")
				{
					ct_RubyPr.dirty = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RubyPr;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rubyAlign != null)
			{
				this.rubyAlign.Write(sw, "rubyAlign");
			}
			if (this.hps != null)
			{
				this.hps.Write(sw, "hps");
			}
			if (this.hpsRaise != null)
			{
				this.hpsRaise.Write(sw, "hpsRaise");
			}
			if (this.hpsBaseText != null)
			{
				this.hpsBaseText.Write(sw, "hpsBaseText");
			}
			if (this.lid != null)
			{
				this.lid.Write(sw, "lid");
			}
			if (this.dirty != null)
			{
				this.dirty.Write(sw, "dirty");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0001D2C0 File Offset: 0x0001B4C0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign rubyAlign
		{
			get
			{
				return this.rubyAlignField;
			}
			set
			{
				this.rubyAlignField = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0001D2C9 File Offset: 0x0001B4C9
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0001D2D1 File Offset: 0x0001B4D1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hps
		{
			get
			{
				return this.hpsField;
			}
			set
			{
				this.hpsField = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0001D2DA File Offset: 0x0001B4DA
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0001D2E2 File Offset: 0x0001B4E2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hpsRaise
		{
			get
			{
				return this.hpsRaiseField;
			}
			set
			{
				this.hpsRaiseField = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001D2EB File Offset: 0x0001B4EB
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0001D2F3 File Offset: 0x0001B4F3
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hpsBaseText
		{
			get
			{
				return this.hpsBaseTextField;
			}
			set
			{
				this.hpsBaseTextField = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0001D2FC File Offset: 0x0001B4FC
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0001D304 File Offset: 0x0001B504
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lid
		{
			get
			{
				return this.lidField;
			}
			set
			{
				this.lidField = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0001D30D File Offset: 0x0001B50D
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x0001D315 File Offset: 0x0001B515
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dirty
		{
			get
			{
				return this.dirtyField;
			}
			set
			{
				this.dirtyField = value;
			}
		}

		// Token: 0x04000779 RID: 1913
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign rubyAlignField;

		// Token: 0x0400077A RID: 1914
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hpsField;

		// Token: 0x0400077B RID: 1915
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hpsRaiseField;

		// Token: 0x0400077C RID: 1916
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure hpsBaseTextField;

		// Token: 0x0400077D RID: 1917
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lang lidField;

		// Token: 0x0400077E RID: 1918
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dirtyField;
	}
}
