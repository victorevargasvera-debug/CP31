using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F8 RID: 1016
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HeaderFooter
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000666CA File Offset: 0x000648CA
		public CT_HeaderFooter()
		{
			this.alignWithMarginsField = true;
			this.differentOddEvenField = false;
			this.differentFirstField = false;
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000666E8 File Offset: 0x000648E8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter ct_HeaderFooter = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_HeaderFooter();
			if (node.Attributes["alignWithMargins"] != null)
			{
				ct_HeaderFooter.alignWithMargins = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["alignWithMargins"]);
			}
			else
			{
				ct_HeaderFooter.alignWithMargins = true;
			}
			if (node.Attributes["differentOddEven"] != null)
			{
				ct_HeaderFooter.differentOddEven = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["differentOddEven"]);
			}
			if (node.Attributes["differentFirst"] != null)
			{
				ct_HeaderFooter.differentFirst = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["differentFirst"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "oddHeader")
				{
					ct_HeaderFooter.oddHeader = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "oddFooter")
				{
					ct_HeaderFooter.oddFooter = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "evenHeader")
				{
					ct_HeaderFooter.evenHeader = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "evenFooter")
				{
					ct_HeaderFooter.evenFooter = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "firstHeader")
				{
					ct_HeaderFooter.firstHeader = xmlNode.InnerText;
				}
				else if (xmlNode.LocalName == "firstFooter")
				{
					ct_HeaderFooter.firstFooter = xmlNode.InnerText;
				}
			}
			return ct_HeaderFooter;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000668A0 File Offset: 0x00064AA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (!this.alignWithMargins)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "alignWithMargins", this.alignWithMargins, true);
			}
			if (this.differentOddEven)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "differentOddEven", this.differentOddEven);
			}
			if (this.differentFirst)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "differentFirst", this.differentFirst);
			}
			sw.Write(">");
			if (this.oddHeader != null)
			{
				sw.Write(string.Format("<oddHeader>{0}</oddHeader>", this.oddHeader));
			}
			if (this.oddFooter != null)
			{
				sw.Write(string.Format("<oddFooter>{0}</oddFooter>", this.oddFooter));
			}
			if (this.evenHeader != null)
			{
				sw.Write(string.Format("<evenHeader>{0}</evenHeader>", this.evenHeader));
			}
			if (this.evenFooter != null)
			{
				sw.Write(string.Format("<evenFooter>{0}</evenFooter>", this.evenFooter));
			}
			if (this.firstHeader != null)
			{
				sw.Write(string.Format("<firstHeader>{0}</firstHeader>", this.firstHeader));
			}
			if (this.firstFooter != null)
			{
				sw.Write(string.Format("<firstFooter>{0}</firstFooter>", this.firstFooter));
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000669DA File Offset: 0x00064BDA
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x000669E2 File Offset: 0x00064BE2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public string oddHeader
		{
			get
			{
				return this.oddHeaderField;
			}
			set
			{
				this.oddHeaderField = value;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000669EB File Offset: 0x00064BEB
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x000669F3 File Offset: 0x00064BF3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public string oddFooter
		{
			get
			{
				return this.oddFooterField;
			}
			set
			{
				this.oddFooterField = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000669FC File Offset: 0x00064BFC
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x00066A04 File Offset: 0x00064C04
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public string evenHeader
		{
			get
			{
				return this.evenHeaderField;
			}
			set
			{
				this.evenHeaderField = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x00066A0D File Offset: 0x00064C0D
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00066A15 File Offset: 0x00064C15
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public string evenFooter
		{
			get
			{
				return this.evenFooterField;
			}
			set
			{
				this.evenFooterField = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x00066A1E File Offset: 0x00064C1E
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00066A26 File Offset: 0x00064C26
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public string firstHeader
		{
			get
			{
				return this.firstHeaderField;
			}
			set
			{
				this.firstHeaderField = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00066A2F File Offset: 0x00064C2F
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x00066A37 File Offset: 0x00064C37
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public string firstFooter
		{
			get
			{
				return this.firstFooterField;
			}
			set
			{
				this.firstFooterField = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00066A40 File Offset: 0x00064C40
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00066A48 File Offset: 0x00064C48
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool alignWithMargins
		{
			get
			{
				return this.alignWithMarginsField;
			}
			set
			{
				this.alignWithMarginsField = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x00066A51 File Offset: 0x00064C51
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00066A59 File Offset: 0x00064C59
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool differentOddEven
		{
			get
			{
				return this.differentOddEvenField;
			}
			set
			{
				this.differentOddEvenField = value;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x00066A62 File Offset: 0x00064C62
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00066A6A File Offset: 0x00064C6A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool differentFirst
		{
			get
			{
				return this.differentFirstField;
			}
			set
			{
				this.differentFirstField = value;
			}
		}

		// Token: 0x04001D8B RID: 7563
		private string oddHeaderField;

		// Token: 0x04001D8C RID: 7564
		private string oddFooterField;

		// Token: 0x04001D8D RID: 7565
		private string evenHeaderField;

		// Token: 0x04001D8E RID: 7566
		private string evenFooterField;

		// Token: 0x04001D8F RID: 7567
		private string firstHeaderField;

		// Token: 0x04001D90 RID: 7568
		private string firstFooterField;

		// Token: 0x04001D91 RID: 7569
		private bool alignWithMarginsField;

		// Token: 0x04001D92 RID: 7570
		private bool differentOddEvenField;

		// Token: 0x04001D93 RID: 7571
		private bool differentFirstField;
	}
}
