using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000281 RID: 641
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontScheme
	{
		// Token: 0x06001A86 RID: 6790 RVA: 0x00047D84 File Offset: 0x00045F84
		public static global::NPOI.OpenXmlFormats.Dml.CT_FontScheme Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_FontScheme ct_FontScheme = new global::NPOI.OpenXmlFormats.Dml.CT_FontScheme();
			ct_FontScheme.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "majorFont")
				{
					ct_FontScheme.majorFont = global::NPOI.OpenXmlFormats.Dml.CT_FontCollection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorFont")
				{
					ct_FontScheme.minorFont = global::NPOI.OpenXmlFormats.Dml.CT_FontCollection.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_FontScheme.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FontScheme;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00047E60 File Offset: 0x00046060
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			if (this.majorFont != null)
			{
				this.majorFont.Write(sw, "majorFont");
			}
			if (this.minorFont != null)
			{
				this.minorFont.Write(sw, "minorFont");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00047EF6 File Offset: 0x000460F6
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x00047EFE File Offset: 0x000460FE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontCollection majorFont
		{
			get
			{
				return this.majorFontField;
			}
			set
			{
				this.majorFontField = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00047F07 File Offset: 0x00046107
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x00047F0F File Offset: 0x0004610F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontCollection minorFont
		{
			get
			{
				return this.minorFontField;
			}
			set
			{
				this.minorFontField = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00047F18 File Offset: 0x00046118
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x00047F20 File Offset: 0x00046120
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x00047F29 File Offset: 0x00046129
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x00047F31 File Offset: 0x00046131
		[global::System.Xml.Serialization.XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x040013C9 RID: 5065
		private global::NPOI.OpenXmlFormats.Dml.CT_FontCollection majorFontField;

		// Token: 0x040013CA RID: 5066
		private global::NPOI.OpenXmlFormats.Dml.CT_FontCollection minorFontField;

		// Token: 0x040013CB RID: 5067
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x040013CC RID: 5068
		private string nameField;
	}
}
