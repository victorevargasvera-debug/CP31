using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065D RID: 1629
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EqArrPr
	{
		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x000A7A9E File Offset: 0x000A5C9E
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x000A7AA6 File Offset: 0x000A5CA6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_YAlign baseJc
		{
			get
			{
				return this.baseJcField;
			}
			set
			{
				this.baseJcField = value;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x000A7AAF File Offset: 0x000A5CAF
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x000A7AB7 File Offset: 0x000A5CB7
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff maxDist
		{
			get
			{
				return this.maxDistField;
			}
			set
			{
				this.maxDistField = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x000A7AC8 File Offset: 0x000A5CC8
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff objDist
		{
			get
			{
				return this.objDistField;
			}
			set
			{
				this.objDistField = value;
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x000A7AD1 File Offset: 0x000A5CD1
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x000A7AD9 File Offset: 0x000A5CD9
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule rSpRule
		{
			get
			{
				return this.rSpRuleField;
			}
			set
			{
				this.rSpRuleField = value;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x000A7AE2 File Offset: 0x000A5CE2
		// (set) Token: 0x060045EC RID: 17900 RVA: 0x000A7AEA File Offset: 0x000A5CEA
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger rSp
		{
			get
			{
				return this.rSpField;
			}
			set
			{
				this.rSpField = value;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x000A7AF3 File Offset: 0x000A5CF3
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x000A7AFB File Offset: 0x000A5CFB
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

		// Token: 0x060045EF RID: 17903 RVA: 0x000A7B04 File Offset: 0x000A5D04
		public static global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr ct_EqArrPr = new global::NPOI.OpenXmlFormats.Shared.CT_EqArrPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "baseJc")
				{
					ct_EqArrPr.baseJc = global::NPOI.OpenXmlFormats.Shared.CT_YAlign.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "maxDist")
				{
					ct_EqArrPr.maxDist = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "objDist")
				{
					ct_EqArrPr.objDist = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rSpRule")
				{
					ct_EqArrPr.rSpRule = global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rSp")
				{
					ct_EqArrPr.rSp = global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_EqArrPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_EqArrPr;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x000A7C34 File Offset: 0x000A5E34
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.baseJc != null)
			{
				this.baseJc.Write(sw, "baseJc");
			}
			if (this.maxDist != null)
			{
				this.maxDist.Write(sw, "maxDist");
			}
			if (this.objDist != null)
			{
				this.objDist.Write(sw, "objDist");
			}
			if (this.rSpRule != null)
			{
				this.rSpRule.Write(sw, "rSpRule");
			}
			if (this.rSp != null)
			{
				this.rSp.Write(sw, "rSp");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x04002BEC RID: 11244
		private global::NPOI.OpenXmlFormats.Shared.CT_YAlign baseJcField;

		// Token: 0x04002BED RID: 11245
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff maxDistField;

		// Token: 0x04002BEE RID: 11246
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff objDistField;

		// Token: 0x04002BEF RID: 11247
		private global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule rSpRuleField;

		// Token: 0x04002BF0 RID: 11248
		private global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger rSpField;

		// Token: 0x04002BF1 RID: 11249
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
