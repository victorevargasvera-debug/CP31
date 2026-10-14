using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000671 RID: 1649
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PhantPr
	{
		// Token: 0x0600468D RID: 18061 RVA: 0x000A96E4 File Offset: 0x000A78E4
		public static global::NPOI.OpenXmlFormats.Shared.CT_PhantPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_PhantPr ct_PhantPr = new global::NPOI.OpenXmlFormats.Shared.CT_PhantPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "show")
				{
					ct_PhantPr.show = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "zeroWid")
				{
					ct_PhantPr.zeroWid = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "zeroAsc")
				{
					ct_PhantPr.zeroAsc = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "zeroDesc")
				{
					ct_PhantPr.zeroDesc = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "transp")
				{
					ct_PhantPr.transp = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_PhantPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PhantPr;
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x000A9814 File Offset: 0x000A7A14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.show != null)
			{
				this.show.Write(sw, "show");
			}
			if (this.zeroWid != null)
			{
				this.zeroWid.Write(sw, "zeroWid");
			}
			if (this.zeroAsc != null)
			{
				this.zeroAsc.Write(sw, "zeroAsc");
			}
			if (this.zeroDesc != null)
			{
				this.zeroDesc.Write(sw, "zeroDesc");
			}
			if (this.transp != null)
			{
				this.transp.Write(sw, "transp");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x000A98E4 File Offset: 0x000A7AE4
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x000A98EC File Offset: 0x000A7AEC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff show
		{
			get
			{
				return this.showField;
			}
			set
			{
				this.showField = value;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x000A98F5 File Offset: 0x000A7AF5
		// (set) Token: 0x06004692 RID: 18066 RVA: 0x000A98FD File Offset: 0x000A7AFD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroWid
		{
			get
			{
				return this.zeroWidField;
			}
			set
			{
				this.zeroWidField = value;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x000A9906 File Offset: 0x000A7B06
		// (set) Token: 0x06004694 RID: 18068 RVA: 0x000A990E File Offset: 0x000A7B0E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroAsc
		{
			get
			{
				return this.zeroAscField;
			}
			set
			{
				this.zeroAscField = value;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06004695 RID: 18069 RVA: 0x000A9917 File Offset: 0x000A7B17
		// (set) Token: 0x06004696 RID: 18070 RVA: 0x000A991F File Offset: 0x000A7B1F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroDesc
		{
			get
			{
				return this.zeroDescField;
			}
			set
			{
				this.zeroDescField = value;
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x000A9928 File Offset: 0x000A7B28
		// (set) Token: 0x06004698 RID: 18072 RVA: 0x000A9930 File Offset: 0x000A7B30
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff transp
		{
			get
			{
				return this.transpField;
			}
			set
			{
				this.transpField = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x000A9939 File Offset: 0x000A7B39
		// (set) Token: 0x0600469A RID: 18074 RVA: 0x000A9941 File Offset: 0x000A7B41
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPr
		{
			get
			{
				return this.ctrlPrField;
			}
			set
			{
				this.ctrlPrField = value;
			}
		}

		// Token: 0x04002C25 RID: 11301
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff showField;

		// Token: 0x04002C26 RID: 11302
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroWidField;

		// Token: 0x04002C27 RID: 11303
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroAscField;

		// Token: 0x04002C28 RID: 11304
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff zeroDescField;

		// Token: 0x04002C29 RID: 11305
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff transpField;

		// Token: 0x04002C2A RID: 11306
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
