using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066F RID: 1647
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NaryPr
	{
		// Token: 0x06004673 RID: 18035 RVA: 0x000A92B0 File Offset: 0x000A74B0
		public static global::NPOI.OpenXmlFormats.Shared.CT_NaryPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_NaryPr ct_NaryPr = new global::NPOI.OpenXmlFormats.Shared.CT_NaryPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "chr")
				{
					ct_NaryPr.chr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "limLoc")
				{
					ct_NaryPr.limLoc = global::NPOI.OpenXmlFormats.Shared.CT_LimLoc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grow")
				{
					ct_NaryPr.grow = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "subHide")
				{
					ct_NaryPr.subHide = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "supHide")
				{
					ct_NaryPr.supHide = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_NaryPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NaryPr;
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x000A93E0 File Offset: 0x000A75E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.chr != null)
			{
				this.chr.Write(sw, "chr");
			}
			if (this.limLoc != null)
			{
				this.limLoc.Write(sw, "limLoc");
			}
			if (this.grow != null)
			{
				this.grow.Write(sw, "grow");
			}
			if (this.subHide != null)
			{
				this.subHide.Write(sw, "subHide");
			}
			if (this.supHide != null)
			{
				this.supHide.Write(sw, "supHide");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x000A94B0 File Offset: 0x000A76B0
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x000A94B8 File Offset: 0x000A76B8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Char chr
		{
			get
			{
				return this.chrField;
			}
			set
			{
				this.chrField = value;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x000A94C1 File Offset: 0x000A76C1
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x000A94C9 File Offset: 0x000A76C9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_LimLoc limLoc
		{
			get
			{
				return this.limLocField;
			}
			set
			{
				this.limLocField = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x000A94D2 File Offset: 0x000A76D2
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x000A94DA File Offset: 0x000A76DA
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff grow
		{
			get
			{
				return this.growField;
			}
			set
			{
				this.growField = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x000A94E3 File Offset: 0x000A76E3
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x000A94EB File Offset: 0x000A76EB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff subHide
		{
			get
			{
				return this.subHideField;
			}
			set
			{
				this.subHideField = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x000A94F4 File Offset: 0x000A76F4
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x000A94FC File Offset: 0x000A76FC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff supHide
		{
			get
			{
				return this.supHideField;
			}
			set
			{
				this.supHideField = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x000A9505 File Offset: 0x000A7705
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x000A950D File Offset: 0x000A770D
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

		// Token: 0x04002C1B RID: 11291
		private global::NPOI.OpenXmlFormats.Shared.CT_Char chrField;

		// Token: 0x04002C1C RID: 11292
		private global::NPOI.OpenXmlFormats.Shared.CT_LimLoc limLocField;

		// Token: 0x04002C1D RID: 11293
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff growField;

		// Token: 0x04002C1E RID: 11294
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff subHideField;

		// Token: 0x04002C1F RID: 11295
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff supHideField;

		// Token: 0x04002C20 RID: 11296
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
