using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065B RID: 1627
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DPr
	{
		// Token: 0x060045CD RID: 17869 RVA: 0x000A76C0 File Offset: 0x000A58C0
		public static global::NPOI.OpenXmlFormats.Shared.CT_DPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_DPr ct_DPr = new global::NPOI.OpenXmlFormats.Shared.CT_DPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "begChr")
				{
					ct_DPr.begChr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sepChr")
				{
					ct_DPr.sepChr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endChr")
				{
					ct_DPr.endChr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grow")
				{
					ct_DPr.grow = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shp")
				{
					ct_DPr.shp = global::NPOI.OpenXmlFormats.Shared.CT_Shp.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_DPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DPr;
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x000A77F0 File Offset: 0x000A59F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.begChr != null)
			{
				this.begChr.Write(sw, "begChr");
			}
			if (this.sepChr != null)
			{
				this.sepChr.Write(sw, "sepChr");
			}
			if (this.endChr != null)
			{
				this.endChr.Write(sw, "endChr");
			}
			if (this.grow != null)
			{
				this.grow.Write(sw, "grow");
			}
			if (this.shp != null)
			{
				this.shp.Write(sw, "shp");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x000A78C0 File Offset: 0x000A5AC0
		// (set) Token: 0x060045D0 RID: 17872 RVA: 0x000A78C8 File Offset: 0x000A5AC8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Char begChr
		{
			get
			{
				return this.begChrField;
			}
			set
			{
				this.begChrField = value;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x000A78D1 File Offset: 0x000A5AD1
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x000A78D9 File Offset: 0x000A5AD9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Char sepChr
		{
			get
			{
				return this.sepChrField;
			}
			set
			{
				this.sepChrField = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x000A78E2 File Offset: 0x000A5AE2
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x000A78EA File Offset: 0x000A5AEA
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Char endChr
		{
			get
			{
				return this.endChrField;
			}
			set
			{
				this.endChrField = value;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x000A78F3 File Offset: 0x000A5AF3
		// (set) Token: 0x060045D6 RID: 17878 RVA: 0x000A78FB File Offset: 0x000A5AFB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x060045D7 RID: 17879 RVA: 0x000A7904 File Offset: 0x000A5B04
		// (set) Token: 0x060045D8 RID: 17880 RVA: 0x000A790C File Offset: 0x000A5B0C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Shp shp
		{
			get
			{
				return this.shpField;
			}
			set
			{
				this.shpField = value;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x000A7915 File Offset: 0x000A5B15
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x000A791D File Offset: 0x000A5B1D
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

		// Token: 0x04002BE4 RID: 11236
		private global::NPOI.OpenXmlFormats.Shared.CT_Char begChrField;

		// Token: 0x04002BE5 RID: 11237
		private global::NPOI.OpenXmlFormats.Shared.CT_Char sepChrField;

		// Token: 0x04002BE6 RID: 11238
		private global::NPOI.OpenXmlFormats.Shared.CT_Char endChrField;

		// Token: 0x04002BE7 RID: 11239
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff growField;

		// Token: 0x04002BE8 RID: 11240
		private global::NPOI.OpenXmlFormats.Shared.CT_Shp shpField;

		// Token: 0x04002BE9 RID: 11241
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
