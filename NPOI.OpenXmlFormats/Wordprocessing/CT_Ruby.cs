using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000137 RID: 311
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Ruby
	{
		// Token: 0x06000899 RID: 2201 RVA: 0x0001DE0C File Offset: 0x0001C00C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby ct_Ruby = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rubyPr")
				{
					ct_Ruby.rubyPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rt")
				{
					ct_Ruby.rt = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rubyBase")
				{
					ct_Ruby.rubyBase = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Ruby;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0001DECC File Offset: 0x0001C0CC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rubyPr != null)
			{
				this.rubyPr.Write(sw, "rubyPr");
			}
			if (this.rt != null)
			{
				this.rt.Write(sw, "rt");
			}
			if (this.rubyBase != null)
			{
				this.rubyBase.Write(sw, "rubyBase");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0001DF51 File Offset: 0x0001C151
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x0001DF59 File Offset: 0x0001C159
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr rubyPr
		{
			get
			{
				return this.rubyPrField;
			}
			set
			{
				this.rubyPrField = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001DF62 File Offset: 0x0001C162
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x0001DF6A File Offset: 0x0001C16A
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent rt
		{
			get
			{
				return this.rtField;
			}
			set
			{
				this.rtField = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001DF73 File Offset: 0x0001C173
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x0001DF7B File Offset: 0x0001C17B
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent rubyBase
		{
			get
			{
				return this.rubyBaseField;
			}
			set
			{
				this.rubyBaseField = value;
			}
		}

		// Token: 0x0400079C RID: 1948
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyPr rubyPrField;

		// Token: 0x0400079D RID: 1949
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent rtField;

		// Token: 0x0400079E RID: 1950
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyContent rubyBaseField;
	}
}
