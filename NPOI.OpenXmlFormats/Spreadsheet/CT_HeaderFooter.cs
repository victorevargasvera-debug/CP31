using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200059B RID: 1435
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_HeaderFooter
	{
		// Token: 0x06003F31 RID: 16177 RVA: 0x000992B0 File Offset: 0x000974B0
		public CT_HeaderFooter()
		{
			this.differentOddEvenField = false;
			this.differentFirstField = false;
			this.scaleWithDocField = true;
			this.alignWithMarginsField = true;
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x000992D4 File Offset: 0x000974D4
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x000992DC File Offset: 0x000974DC
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x000992E5 File Offset: 0x000974E5
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x000992ED File Offset: 0x000974ED
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x000992F6 File Offset: 0x000974F6
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x000992FE File Offset: 0x000974FE
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x00099307 File Offset: 0x00097507
		// (set) Token: 0x06003F39 RID: 16185 RVA: 0x0009930F File Offset: 0x0009750F
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x00099318 File Offset: 0x00097518
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x00099320 File Offset: 0x00097520
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x00099329 File Offset: 0x00097529
		// (set) Token: 0x06003F3D RID: 16189 RVA: 0x00099331 File Offset: 0x00097531
		[global::System.Xml.Serialization.XmlElement]
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x0009933A File Offset: 0x0009753A
		// (set) Token: 0x06003F3F RID: 16191 RVA: 0x00099342 File Offset: 0x00097542
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

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x0009934B File Offset: 0x0009754B
		// (set) Token: 0x06003F41 RID: 16193 RVA: 0x00099353 File Offset: 0x00097553
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

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x0009935C File Offset: 0x0009755C
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x00099364 File Offset: 0x00097564
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool scaleWithDoc
		{
			get
			{
				return this.scaleWithDocField;
			}
			set
			{
				this.scaleWithDocField = value;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x0009936D File Offset: 0x0009756D
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x00099375 File Offset: 0x00097575
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

		// Token: 0x06003F46 RID: 16198 RVA: 0x00099380 File Offset: 0x00097580
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter ct_HeaderFooter = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter();
			ct_HeaderFooter.differentOddEven = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["differentOddEven"]);
			ct_HeaderFooter.differentFirst = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["differentFirst"]);
			if (node.Attributes["scaleWithDoc"] != null)
			{
				ct_HeaderFooter.scaleWithDoc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["scaleWithDoc"]);
			}
			if (node.Attributes["alignWithMargins"] != null)
			{
				ct_HeaderFooter.alignWithMargins = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["alignWithMargins"]);
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

		// Token: 0x06003F47 RID: 16199 RVA: 0x00099538 File Offset: 0x00097738
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			if (this.differentOddEven)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "differentOddEven", this.differentOddEven);
			}
			if (this.differentFirst)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "differentFirst", this.differentFirst);
			}
			if (!this.scaleWithDoc)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "scaleWithDoc", this.scaleWithDoc);
			}
			if (!this.alignWithMargins)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "alignWithMargins", this.alignWithMargins);
			}
			if (this.oddHeader == null && this.oddFooter == null && this.evenHeader == null && this.firstHeader == null && this.firstFooter == null)
			{
				sw.Write("/>");
				return;
			}
			sw.Write(">");
			if (this.oddHeader != null)
			{
				sw.Write(string.Format("<oddHeader><![CDATA[{0}]]></oddHeader>", this.oddHeader));
			}
			if (this.oddFooter != null)
			{
				sw.Write(string.Format("<oddFooter><![CDATA[{0}]]></oddFooter>", this.oddFooter));
			}
			if (this.evenHeader != null)
			{
				sw.Write(string.Format("<evenHeader><![CDATA[{0}]]></evenHeader>", this.evenHeader));
			}
			if (this.evenFooter != null)
			{
				sw.Write(string.Format("<evenFooter><![CDATA[{0}]]></evenFooter>", this.evenFooter));
			}
			if (this.firstHeader != null)
			{
				sw.Write(string.Format("<firstHeader><![CDATA[{0}]]></firstHeader>", this.firstHeader));
			}
			if (this.firstFooter != null)
			{
				sw.Write(string.Format("<firstFooter><![CDATA[{0}]]></firstFooter>", this.firstFooter));
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0400280A RID: 10250
		private string oddHeaderField;

		// Token: 0x0400280B RID: 10251
		private string oddFooterField;

		// Token: 0x0400280C RID: 10252
		private string evenHeaderField;

		// Token: 0x0400280D RID: 10253
		private string evenFooterField;

		// Token: 0x0400280E RID: 10254
		private string firstHeaderField;

		// Token: 0x0400280F RID: 10255
		private string firstFooterField;

		// Token: 0x04002810 RID: 10256
		private bool differentOddEvenField;

		// Token: 0x04002811 RID: 10257
		private bool differentFirstField;

		// Token: 0x04002812 RID: 10258
		private bool scaleWithDocField;

		// Token: 0x04002813 RID: 10259
		private bool alignWithMarginsField;
	}
}
