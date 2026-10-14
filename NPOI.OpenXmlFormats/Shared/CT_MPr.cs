using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066C RID: 1644
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MPr
	{
		// Token: 0x06004654 RID: 18004 RVA: 0x000A8D6C File Offset: 0x000A6F6C
		public static global::NPOI.OpenXmlFormats.Shared.CT_MPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_MPr ct_MPr = new global::NPOI.OpenXmlFormats.Shared.CT_MPr();
			ct_MPr.mcs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "baseJc")
				{
					ct_MPr.baseJc = global::NPOI.OpenXmlFormats.Shared.CT_YAlign.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "plcHide")
				{
					ct_MPr.plcHide = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rSpRule")
				{
					ct_MPr.rSpRule = global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cGpRule")
				{
					ct_MPr.cGpRule = global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rSp")
				{
					ct_MPr.rSp = global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cSp")
				{
					ct_MPr.cSp = global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cGp")
				{
					ct_MPr.cGp = global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_MPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mcs")
				{
					ct_MPr.mcs.Add(global::NPOI.OpenXmlFormats.Shared.CT_MC.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MPr;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x000A8F24 File Offset: 0x000A7124
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.baseJc != null)
			{
				this.baseJc.Write(sw, "baseJc");
			}
			if (this.plcHide != null)
			{
				this.plcHide.Write(sw, "plcHide");
			}
			if (this.rSpRule != null)
			{
				this.rSpRule.Write(sw, "rSpRule");
			}
			if (this.cGpRule != null)
			{
				this.cGpRule.Write(sw, "cGpRule");
			}
			if (this.rSp != null)
			{
				this.rSp.Write(sw, "rSp");
			}
			if (this.cSp != null)
			{
				this.cSp.Write(sw, "cSp");
			}
			if (this.cGp != null)
			{
				this.cGp.Write(sw, "cGp");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			if (this.mcs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Shared.CT_MC ct_MC in this.mcs)
				{
					ct_MC.Write(sw, "mcs");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x000A9078 File Offset: 0x000A7278
		// (set) Token: 0x06004657 RID: 18007 RVA: 0x000A9080 File Offset: 0x000A7280
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

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x000A9089 File Offset: 0x000A7289
		// (set) Token: 0x06004659 RID: 18009 RVA: 0x000A9091 File Offset: 0x000A7291
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff plcHide
		{
			get
			{
				return this.plcHideField;
			}
			set
			{
				this.plcHideField = value;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x000A909A File Offset: 0x000A729A
		// (set) Token: 0x0600465B RID: 18011 RVA: 0x000A90A2 File Offset: 0x000A72A2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x000A90AB File Offset: 0x000A72AB
		// (set) Token: 0x0600465D RID: 18013 RVA: 0x000A90B3 File Offset: 0x000A72B3
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule cGpRule
		{
			get
			{
				return this.cGpRuleField;
			}
			set
			{
				this.cGpRuleField = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x000A90BC File Offset: 0x000A72BC
		// (set) Token: 0x0600465F RID: 18015 RVA: 0x000A90C4 File Offset: 0x000A72C4
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

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x000A90CD File Offset: 0x000A72CD
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x000A90D5 File Offset: 0x000A72D5
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger cSp
		{
			get
			{
				return this.cSpField;
			}
			set
			{
				this.cSpField = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x000A90DE File Offset: 0x000A72DE
		// (set) Token: 0x06004663 RID: 18019 RVA: 0x000A90E6 File Offset: 0x000A72E6
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger cGp
		{
			get
			{
				return this.cGpField;
			}
			set
			{
				this.cGpField = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x000A90EF File Offset: 0x000A72EF
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x000A90F7 File Offset: 0x000A72F7
		[global::System.Xml.Serialization.XmlArray(Order = 7)]
		[global::System.Xml.Serialization.XmlArrayItem("mc", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC> mcs
		{
			get
			{
				return this.mcsField;
			}
			set
			{
				this.mcsField = value;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x000A9100 File Offset: 0x000A7300
		// (set) Token: 0x06004667 RID: 18023 RVA: 0x000A9108 File Offset: 0x000A7308
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x04002C0F RID: 11279
		private global::NPOI.OpenXmlFormats.Shared.CT_YAlign baseJcField;

		// Token: 0x04002C10 RID: 11280
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff plcHideField;

		// Token: 0x04002C11 RID: 11281
		private global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule rSpRuleField;

		// Token: 0x04002C12 RID: 11282
		private global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule cGpRuleField;

		// Token: 0x04002C13 RID: 11283
		private global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger rSpField;

		// Token: 0x04002C14 RID: 11284
		private global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger cSpField;

		// Token: 0x04002C15 RID: 11285
		private global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger cGpField;

		// Token: 0x04002C16 RID: 11286
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_MC> mcsField;

		// Token: 0x04002C17 RID: 11287
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
